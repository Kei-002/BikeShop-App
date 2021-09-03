Imports MySql.Data.MySqlClient

Public Class DeliveryRecord
    Private Sub DeliveryRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()

        Dim suppID As Integer = Form1.lblSuppID.Text

        ds = New DataSet
        lblCurrent.Text = getSuppName(suppID)
        'Loading delivery records to datagrid

        sql = "SELECT product_desc as ItemName, quantity as Quantity,delivery_date as DateDeliverd, delivery_price as DeliveryFee
               FROM products p, deliveries d, supplier s
               WHERE p.product_id = d.product_id AND s.supplier_id = d.supplier_id
               AND d.supplier_id = " & suppID & "
               UNION
               SELECT accessory_name, quantity, delivery_date, delivery_price
                FROM accessories a, deliveries_accessories d, supplier s
                 WHERE a.accessory_id = d.accessory_id AND s.supplier_id = d.supplier_id
               AND d.supplier_id = " & suppID & ""


        DataAdapter1 = New MySqlDataAdapter(sql, conn)

        DataAdapter1.Fill(ds, "DevHistory")

        dgPurchased.DataSource = ds.Tables("DevHistory")

        DataAdapter1.Dispose()



        conn.Close()

        dgPurchased.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


    End Sub


    Private Function getSuppName(ByVal suppID As Integer) As String
        Dim suppName As String


        sql = "SELECT supplier_name FROM supplier WHERE supplier_id = @suppID"

        dbcomm = New MySqlCommand(sql, conn)

        dbcomm.Parameters.AddWithValue("@suppID", suppID)

        dbread = dbcomm.ExecuteReader

        dbread.Read()
        suppName = dbread(0)

        dbread.Dispose()



        Return suppName
    End Function
End Class