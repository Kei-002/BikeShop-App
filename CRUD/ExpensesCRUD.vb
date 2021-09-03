Imports MySql.Data.MySqlClient
Public Class ExpensesCRUD
    Private Sub ExpensesCRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkOpen()

        cmbName.Items.Clear()
        ds = New DataSet

        sql = "SELECT e.service_id as ServiceID, service_desc as ServiceName, exp_water as Water, exp_electricity as Electricity,
               exp_rent as Rent, exp_other as Others from expenses e, services s WHERE e.service_id = s.service_id"

        DataAdapter1 = New MySqlDataAdapter(sql, conn)

        DataAdapter1.Fill(ds, "AllExpenses")

        dgExpenses.DataSource = ds.Tables("AllExpenses")

        DataAdapter1.Dispose()


        dgExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


        sql = "SELECT service_desc from services"

        dbcomm = New MySqlCommand(sql, conn)

        dbread = dbcomm.ExecuteReader

        While dbread.Read

            cmbName.Items.Add(dbread(0))
        End While

        dbread.Dispose()
        conn.Close()
    End Sub

    Private Sub dgExpenses_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgExpenses.MouseDoubleClick
        Try
            cmbName.SelectedItem = Me.dgExpenses.CurrentRow.Cells("ServiceName").Value
            'txtName.Text = Me.dgExpenses.CurrentRow.Cells("ServiceName").Value
            txtWater.Text = Me.dgExpenses.CurrentRow.Cells("Water").Value
            txtElec.Text = Me.dgExpenses.CurrentRow.Cells("Electricity").Value
            txtRent.Text = Me.dgExpenses.CurrentRow.Cells("Rent").Value
            txtOthers.Text = Me.dgExpenses.CurrentRow.Cells("Others").Value
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub



    Private Sub cmbName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbName.SelectedIndexChanged
        Try
            checkOpen()


            Dim SearchedID As Integer = getServiceID(cmbName.SelectedItem)

            sql = "SELECT e.service_id as ServiceID, service_desc as ServiceName, exp_water as Water, exp_electricity as Electricity,
               exp_rent as Rent, exp_other as Others from expenses e, services s WHERE e.service_id = s.service_id
               AND s.service_id = " & SearchedID

            dbcomm = New MySqlCommand(sql, conn)

            dbread = dbcomm.ExecuteReader

            While dbread.Read
                'txtName.Text = dbread("ServiceName")
                txtWater.Text = dbread("Water")
                txtElec.Text = dbread("Electricity")
                txtRent.Text = dbread("Rent")
                txtOthers.Text = dbread("Others")
            End While
            dbread.Dispose()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        conn.Close()
    End Sub

    'CRUD Functions
    Private Sub cmdAddp_Click(sender As Object, e As EventArgs) Handles cmdAddp.Click
        Try
            checkOpen()
            Dim serveID As Integer = getServiceID(cmbName.SelectedItem)

            sql = "INSERT INTO expenses(service_id,exp_water, exp_electricity, exp_rent, exp_other)
                   VALUES (@serveID, @exWater, @exElec, @exRent, @exOther)"

            dbcomm = New MySqlCommand(sql, conn)

            dbcomm.Parameters.AddWithValue("@serveID", serveID)
            dbcomm.Parameters.AddWithValue("@exWater", txtWater.Text)
            dbcomm.Parameters.AddWithValue("@exElec", txtElec.Text)
            dbcomm.Parameters.AddWithValue("@exRent", txtRent.Text)
            dbcomm.Parameters.AddWithValue("@exOther", txtOthers.Text)

            Dim i As Integer = dbcomm.ExecuteNonQuery

            If i > 0 Then

                MsgBox("Data saved")
            Else
                MsgBox("Duplicate Entry")
            End If
            dbcomm.Dispose()




        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

        conn.Close()
        Call ExpensesCRUD_Load(sender, e)
    End Sub

    Private Sub cmdUpdatep_Click(sender As Object, e As EventArgs) Handles cmdUpdatep.Click
        Try
            checkOpen()
            Dim serveID As Integer = getServiceID(cmbName.SelectedItem)

            sql = "UPDATE expenses SET exp_water = @exWater, exp_electricity = @exElec, exp_rent = @exRent, exp_other = @exOther
                   WHERE service_id = @serveID"

            dbcomm = New MySqlCommand(sql, conn)

            dbcomm.Parameters.AddWithValue("@serveID", serveID)
            dbcomm.Parameters.AddWithValue("@exWater", txtWater.Text)
            dbcomm.Parameters.AddWithValue("@exElec", txtElec.Text)
            dbcomm.Parameters.AddWithValue("@exRent", txtRent.Text)
            dbcomm.Parameters.AddWithValue("@exOther", txtOthers.Text)

            Dim i As Integer = dbcomm.ExecuteNonQuery

            If i > 0 Then

                MsgBox("Data Updated")
            Else
                MsgBox("Data not updated")
            End If

            dbcomm.Dispose()




        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

        conn.Close()
        Call ExpensesCRUD_Load(sender, e)
    End Sub

    Private Sub cmdDeletep_Click(sender As Object, e As EventArgs) Handles cmdDeletep.Click
        Try
            checkOpen()

            Dim serveID As Integer = getServiceID(cmbName.SelectedItem)
            sql = "DELETE FROM expenses
                   WHERE service_id = @serveID"

            dbcomm = New MySqlCommand(sql, conn)

            dbcomm.Parameters.AddWithValue("@serveID", serveID)

            Dim i As Integer = dbcomm.ExecuteNonQuery

            If i > 0 Then

                MsgBox("Data deleted")
            Else
                MsgBox("Data not deleted")
            End If

            dbcomm.Dispose()
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

        conn.Close()

        Call ExpensesCRUD_Load(sender, e)
    End Sub


    Private Function getServiceID(ByVal serveName As String)
        Dim serveID As Integer

        sql = "SELECT service_id from services 
               WHERE service_desc = @serveName"

        dbcomm = New MySqlCommand(sql, conn)

        dbcomm.Parameters.AddWithValue("@serveName", serveName)

        dbread = dbcomm.ExecuteReader

        dbread.Read()
        serveID = dbread(0)

        dbread.Dispose()
        Return serveID
    End Function
End Class