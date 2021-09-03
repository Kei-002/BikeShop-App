Imports MySql.Data.MySqlClient
Public Class PurchaseHistory
    Private Sub PurchaseHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkOpen()


        ds = New DataSet

        Dim cusID As Integer = CInt(Form1.lblSavedID.Text)

        lblCurrent.Text = getUser(cusID)

        'Loading purchased products to datagrid
        'Used UNION to merge products and accessories into one table
        sql = "SELECT product_desc as ItemName, date_purchased as DatePurchased, SUM(quantity) as Quantity, SUM(total_price) as TotalPrice from products p, recieptproducts rp, customer c
                WHERE p.product_id = rp.product_id AND c.customer_id = rp.customer_id AND rp.customer_id = " & cusID & "
               GROUP BY product_desc, date_purchased"


        DataAdapter1 = New MySqlDataAdapter(sql, conn)

        DataAdapter1.Fill(ds, "PurchaseHistory")

        dgPurchased.DataSource = ds.Tables("PurchaseHistory")

        DataAdapter1.Dispose()


        conn.Close()

        dgPurchased.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub



    'Gets the name of the currently selected user
    Public Function getUser(ByVal cusID As Integer) As String

        Dim selectedUser As String

        sql = "SELECT customer_name FROM customer WHERE customer_id = @cusID"

        dbcomm = New MySqlCommand(sql, conn)

        dbcomm.Parameters.AddWithValue("@cusID", cusID)

        dbread = dbcomm.ExecuteReader

        dbread.Read()
        selectedUser = dbread(0)

        dbread.Dispose()

        Return selectedUser

    End Function

End Class