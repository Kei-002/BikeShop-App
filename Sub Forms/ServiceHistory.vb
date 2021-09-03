Imports MySql.Data.MySqlClient


Public Class ServiceHistory
    Private Sub ServiceHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn.Open()

        ds = New DataSet

        Dim cusID As Integer = CInt(Form1.lblSavedID.Text)

        lblCurrent.Text = PurchaseHistory.getUser(cusID)

        'Loading bike services bought by users to datagrid

        sql = "SELECT service_desc as ServiceName, service_date as ServiceDate, mechanic_name as Mechanic, service_fee as Price
               FROM services s, mechanics m, bikeservice bs, customer c
               WHERE bs.service_id = s.service_id AND bs.mechanic_id = m.mechanic_id AND bs.customer_id = c.customer_id
               AND bs.customer_id = " & cusID & "
               ORDER BY ServiceDate"


        DataAdapter1 = New MySqlDataAdapter(sql, conn)

        DataAdapter1.Fill(ds, "PurchaseHistory")

        dgPurchased.DataSource = ds.Tables("PurchaseHistory")

        DataAdapter1.Dispose()


        conn.Close()

        dgPurchased.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
End Class