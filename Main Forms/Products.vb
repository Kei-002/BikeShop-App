Imports MySql.Data.MySqlClient
Public Class Products

    Private ItemsBackup As New List(Of ListViewItem)

    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkOpen()
        ds = New DataSet

        sql = "SELECT p.product_id as ProductID, product_desc as Name, type_desc as Type, brand_name as Brand,product_price as Price
               FROM products p, producttype pt, brands b, multibrand mb
               WHERE p.type_id = pt.type_id AND b.brand_id = mb.brand_id AND mb.product_id = p.product_id
               GROUP BY ProductID"

        DataAdapter1 = New MySqlDataAdapter(sql, conn)

        DataAdapter1.Fill(ds, "AllProducts")


        dgAllProducts.DataSource = ds.Tables("AllProducts")

        DataAdapter1.Dispose()

        conn.Close()

        dgAllProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub txtTypeFilter_TextChanged(sender As Object, e As EventArgs) Handles txtTypeFilter.TextChanged
        checkOpen()
        dt = New DataTable

        sql = "SELECT p.product_id as ProductID, product_desc as Name, type_desc as Type, brand_name as Brand,product_price as Price
               FROM products p, producttype pt, brands b, multibrand mb
               WHERE p.type_id = pt.type_id AND b.brand_id = mb.brand_id AND mb.product_id = p.product_id AND product_desc Like '%" & txtTypeFilter.Text & "%'
               GROUP BY ProductID"

        DataAdapter1 = New MySqlDataAdapter(sql, conn)

        DataAdapter1.Fill(dt)

        dgAllProducts.DataSource = dt

        DataAdapter1.Dispose()
        conn.Close()

    End Sub

    Private Sub cmdModProd_Click(sender As Object, e As EventArgs) Handles cmdModProd.Click
        Dim prody As New ProductsCRUD

        prody.Show()
    End Sub

    Private Sub cmbOrder_Click(sender As Object, e As EventArgs) Handles cmbOrder.Click
        Dim cusOrder As New CustomerOrder

        cusOrder.ShowDialog()
    End Sub
End Class