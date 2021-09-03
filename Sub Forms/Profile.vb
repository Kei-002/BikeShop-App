Imports MySql.Data.MySqlClient
Public Class Profile

    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkOpen()

        ds = New DataSet

        Dim mechanicID As Integer = getMechID(LogIn.lblAccID.Text)

        'Loading bike services bought by users to datagrid

        sql = "SELECT service_desc as ServiceName, customer_name as Customer, service_date as DateServiced, mech_wage as Wage
               FROM services s, customer c, bikeservice bs
               WHERE s.service_id = bs.service_id AND c.customer_id = bs.customer_id
               AND mechanic_id = " & mechanicID


        DataAdapter1 = New MySqlDataAdapter(sql, conn)

        DataAdapter1.Fill(ds, "ServeDone")

        dgServeDone.DataSource = ds.Tables("ServeDone")

        DataAdapter1.Dispose()

        sql1 = "SELECT * from mechanics where mechanic_id = @mechID"

        dbcomm = New MySqlCommand(sql1, conn)
        dbcomm.Parameters.AddWithValue("@mechID", mechanicID)

        dbread = dbcomm.ExecuteReader

        dbread.Read()

        txtName.Text = dbread("mechanic_name")
        txtBal.Text = dbread("mechanic_balance")

        dgServeDone.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dbread.Dispose()

        conn.Close()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If MsgBox("Do you want to log off?", MsgBoxStyle.YesNo Or
MsgBoxStyle.DefaultButton2, "Quit?") = Windows.Forms.DialogResult.Yes Then

            Application.Restart()

        Else

            'Application.Restart()
        End If
    End Sub


    Private Function getMechID(ByVal accID As Integer)
        Dim mID As Integer

        sql = "SELECT mechanic_id FROM mechanics WHERE account_id = @aID"

        dbcomm = New MySqlCommand(sql, conn)

        dbcomm.Parameters.AddWithValue("@aID", accID)
        dbread = dbcomm.ExecuteReader

        dbread.Read()
        mID = dbread(0)
        dbread.Dispose()

        Return mID

    End Function
End Class