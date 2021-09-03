Imports MySql.Data.MySqlClient

Public Class MechanicCRUD
    Private Sub MechanicCrud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkOpen()
        ds = New DataSet

        'Filling datagrid with customer infos
        sql = "SELECT mechanic_id as MechID, mechanic_name as Name, mechanic_balance as Balance
               FROM mechanics"

        DataAdapter1 = New MySqlDataAdapter(sql, conn)

        DataAdapter1.Fill(ds, "AllMech")


        dgMech.DataSource = ds.Tables("AllMech")

        DataAdapter1.Dispose()

        conn.Close()

        dgMech.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub



    'Searching name in datagrid
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        checkOpen()
        dt = New DataTable

        sql = "SELECT mechanic_id as MechID, mechanic_name as Name, mechanic_balance as Balance
               FROM mechanics WHERE mechanic_name like '%" & txtSearch.Text & "%'"

        DataAdapter1 = New MySqlDataAdapter(sql, conn)

        DataAdapter1.Fill(dt)

        dgMech.DataSource = dt

        DataAdapter1.Dispose()
        conn.Close()
    End Sub


    'gets the last account id
    Private Function getLastID()

        Dim lastID As Integer

        sql = "SELECT MAX(account_id) FROM accounts"

        dbcomm = New MySqlCommand(sql, conn)

        dbread = dbcomm.ExecuteReader

        dbread.Read()
        lastID = dbread(0)

        dbread.Dispose()
        Return lastID


    End Function


    Private Function getAccountID()
        Dim accId As Integer

        sql = "SELECT a.account_id FROM accounts a, mechanics m WHERE
               m.account_id = a.account_id AND mechanic_id = " & lblMechID.Text

        dbcomm = New MySqlCommand(sql, conn)

        dbread = dbcomm.ExecuteReader

        dbread.Read()
        accId = dbread(0)

        dbread.Dispose()
        Return accId

    End Function




    Private Sub dgMech_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgMech.MouseDoubleClick
        txtName.Text = Me.dgMech.CurrentRow.Cells("Name").Value
        txtBalance.Text = Me.dgMech.CurrentRow.Cells("Balance").Value

        lblMechID.Text = Me.dgMech.CurrentRow.Cells("MechId").Value
    End Sub






    'CRUD Functions
    Private Sub cmdAddp_Click(sender As Object, e As EventArgs) Handles cmdAddp.Click

        Dim accCreate As New AccountCreate
        accCreate.ShowDialog()

        Dim accountID As Integer
        checkOpen()

        accountID = getLastID()

        sql = "INSERT INTO mechanics(mechanic_name, account_id, mechanic_balance) VALUES (@mechName, @accID, @mechBalance)"

        dbcomm = New MySqlCommand(sql, conn)

        dbcomm.Parameters.AddWithValue("@mechName", txtName.Text)
        dbcomm.Parameters.AddWithValue("@accID", accountID)
        dbcomm.Parameters.AddWithValue("@mechBalance", txtBalance.Text)

        Dim i As Integer = dbcomm.ExecuteNonQuery

        If i > 0 Then
            MsgBox("Data saved")

        Else
            MsgBox("Data save failed")
        End If

        conn.Close()

        Call MechanicCrud_Load(sender, e)
    End Sub

    Private Sub cmdUpdatep_Click(sender As Object, e As EventArgs) Handles cmdUpdatep.Click
        checkOpen()


        'Update product details
        sql = "UPDATE mechanics SET mechanic_name = @mechName, mechanic_balance = @mechBal WHERE mechanic_id = @mechID"

        dbcomm = New MySqlCommand(sql, conn)

        dbcomm.Parameters.AddWithValue("@mechName", txtName.Text)
        dbcomm.Parameters.AddWithValue("@mechBal", txtBalance.Text)
        dbcomm.Parameters.AddWithValue("@mechId", lblMechID.Text)



        Dim i As Integer = dbcomm.ExecuteNonQuery

        If i > 0 Then
            MsgBox(i.ToString + "Data saved")

        Else
            MsgBox("Data save failed")
        End If
        conn.Close()

        Call MechanicCrud_Load(sender, e)
    End Sub

    Private Sub cmdDeletep_Click(sender As Object, e As EventArgs) Handles cmdDeletep.Click

        Try
            checkOpen()

            Dim MechAccID As Integer = getAccountID()

            sql = "DELETE FROM accounts WHERE account_id = " & MechAccID

            dbcomm = New MySqlCommand(sql, conn)

            Dim i As Integer = dbcomm.ExecuteNonQuery

            If i > 0 Then
                MsgBox("Data Deleted")

            Else
                MsgBox("Data not Deleted")
            End If

            conn.Close()
            Call MechanicCrud_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

End Class