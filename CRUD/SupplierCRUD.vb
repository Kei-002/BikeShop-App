Imports MySql.Data.MySqlClient
Public Class SupplierCRUD
    Private Sub SupplierCRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub dgSupp_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgSupp.MouseDoubleClick
        txtName.Text = Me.dgSupp.CurrentRow.Cells("SupplierName").Value
        txtAdd.Text = Me.dgSupp.CurrentRow.Cells("SupplierAddress").Value
    End Sub



    'CRUD Functions
    Private Sub cmdAddp_Click(sender As Object, e As EventArgs) Handles cmdAddp.Click
        checkOpen()


        'Insert to supplier
        sql = "INSERT INTO supplier(supplier_name, supplier_address) VALUES (@suppName, @suppAdd)"

        dbcomm = New MySqlCommand(sql, conn)

        dbcomm.Parameters.AddWithValue("@suppName", txtName.Text)
        dbcomm.Parameters.AddWithValue("@suppAdd", txtAdd.Text)

        Dim i As Integer = dbcomm.ExecuteNonQuery

        If i > 0 Then
            MsgBox("Data saved")

        Else
            MsgBox("Data save failed")
        End If

        dbcomm.Dispose()
        'End of supplier insert

        conn.Close()

        Call SupplierCRUD_Load(sender, e)
    End Sub

    Private Sub cmdUpdatep_Click(sender As Object, e As EventArgs) Handles cmdUpdatep.Click
        Dim selectedID As Integer = Me.dgSupp.CurrentRow.Cells("SupplierID").Value
        checkOpen()

        sql = "UPDATE supplier SET supplier_name = @suppName, supplier_address = @suppAdd
              WHERE supplier_id = @suppID"

        dbcomm = New MySqlCommand(sql, conn)

        dbcomm.Parameters.AddWithValue("@suppName", txtName.Text)
        dbcomm.Parameters.AddWithValue("@suppAdd", txtAdd.Text)
        dbcomm.Parameters.AddWithValue("@suppID", selectedID)

        Dim i As Integer = dbcomm.ExecuteNonQuery

        If i > 0 Then
            MsgBox(i.ToString + "Data saved")

        Else
            MsgBox("Data save failed")
        End If



        conn.Close()
        Call SupplierCRUD_Load(sender, e)
    End Sub

    Private Sub cmdDeletep_Click(sender As Object, e As EventArgs) Handles cmdDeletep.Click
        Dim selectedID As Integer = Me.dgSupp.CurrentRow.Cells("SupplierID").Value
        checkOpen()

        sql = "DELETE FROM supplier WHERE supplier_id = " & selectedID

        dbcomm = New MySqlCommand(sql, conn)

        Dim i As Integer = dbcomm.ExecuteNonQuery

        If i > 0 Then
            MsgBox("Data Deleted")

        Else
            MsgBox("Data not Deleted")
        End If

        conn.Close()
        conn.Close()
        Call SupplierCRUD_Load(sender, e)
    End Sub


End Class