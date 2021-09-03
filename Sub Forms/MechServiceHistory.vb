Imports MySql.Data.MySqlClient
Public Class MechServiceHistory
    Private Sub MechServiceHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn.Open()

        ds = New DataSet

        Dim mechID As Integer = CInt(Form1.lblSavedMechID.Text)

        lblCurrent.Text = PurchaseHistory.getUser(mechID)

        'Loading bike services bought by users to datagrid

        sql = "SELECT service_desc as ServiceName, service_date as ServiceDate, customer_name as Customer, mech_wage as Wage
               FROM services s, mechanics m, bikeservice bs, customer c
               WHERE bs.service_id = s.service_id AND bs.mechanic_id = m.mechanic_id AND bs.customer_id = c.customer_id
               AND bs.mechanic_id = " & mechID & "
               ORDER BY ServiceDate"


        DataAdapter1 = New MySqlDataAdapter(sql, conn)

        DataAdapter1.Fill(ds, "PurchaseHistory")

        dgPurchased.DataSource = ds.Tables("PurchaseHistory")

        DataAdapter1.Dispose()


        conn.Close()

        dgPurchased.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Public Function getMechName(ByVal mechID As Integer)
        Dim mechName As String
        sql = "SELECT mechanic_name FROM mechanics WHERE mechanic_id = @mechID"

        dbcomm = New MySqlCommand(sql, conn)

        dbcomm.Parameters.AddWithValue("@mechID", mechID)

        dbread = dbcomm.ExecuteReader

        dbread.Read()
        mechName = dbread(0)

        dbread.Dispose()
        Return mechName
    End Function


End Class