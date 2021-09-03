Imports MySql.Data.MySqlClient

Public Class Suppliers
    Private Sub Suppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkOpen()
        ds = New DataSet

        'Filling datagrid with supplier infos
        sql = "SELECT supplier_id as SupplierID, supplier_name as SupplierName, supplier_address as SupplierAddress
               FROM supplier"

        DataAdapter1 = New MySqlDataAdapter(sql, conn)

        DataAdapter1.Fill(ds, "AllSupplier")


        dgSupp.DataSource = ds.Tables("AllSupplier")

        DataAdapter1.Dispose()

        conn.Close()

        dgSupp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        checkOpen()
        dt = New DataTable

        sql = "SELECT supplier_id as SupplierID, supplier_name as SupplierName, supplier_address as SupplierAddress
               FROM supplier
               WHERE supplier_name like '%" & txtSearch.Text & "%'"

        DataAdapter1 = New MySqlDataAdapter(sql, conn)

        DataAdapter1.Fill(dt)

        dgSupp.DataSource = dt

        DataAdapter1.Dispose()
        conn.Close()
    End Sub

    Private Sub cmdView_Click(sender As Object, e As EventArgs) Handles cmdView.Click
        Form1.lblSuppID.Text = Me.dgSupp.CurrentRow.Cells("SupplierID").Value
        Dim dRecord As New DeliveryRecord

        dRecord.ShowDialog()

    End Sub

    Private Sub dgSupp_MouseClick(sender As Object, e As MouseEventArgs) Handles dgSupp.MouseClick
        Form1.lblSuppID.Text = Me.dgSupp.CurrentRow.Cells("SupplierID").Value
    End Sub

    Private Sub cmdModSupp_Click(sender As Object, e As EventArgs) Handles cmdModSupp.Click
        Dim suppCRUD As New SupplierCRUD

        suppCRUD.ShowDialog()
        Call Suppliers_Load(sender, e)
    End Sub

    Private Sub cmdOrder_Click(sender As Object, e As EventArgs) Handles cmdOrder.Click
        Dim suppDeliv As New DeliverySupp

        suppDeliv.ShowDialog()
        'Call Suppliers_Load(sender, e)
    End Sub
End Class