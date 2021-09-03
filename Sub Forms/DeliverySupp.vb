Imports MySql.Data.MySqlClient

Public Class DeliverySupp
    Private Sub DeliverySupp_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        cmbType.SelectedItem = "Product"

        checkOpen()
        sql = "SELECT supplier_id, supplier_name from supplier"

        dbcomm = New MySqlCommand(sql, conn)

        dbread = dbcomm.ExecuteReader

        While dbread.Read
            cmbSupp.Items.Add(dbread(0).ToString + "-" + dbread(1).ToString)
        End While
        dbread.Dispose()

        conn.Close()
    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        checkOpen()
        cmbItemName.Items.Clear()

        If cmbType.SelectedItem = "Product" Then
            sql = "SELECT product_id,product_desc FROM products INNER JOIN producttype ON products.type_id = producttype.type_id
                   WHERE is_accessory = 0"

        Else
            sql = "SELECT product_id,product_desc FROM products INNER JOIN producttype ON products.type_id = producttype.type_id
                   WHERE is_accessory = 1"

        End If

        dbcomm = New MySqlCommand(sql, conn)

        dbread = dbcomm.ExecuteReader

        While dbread.Read
            cmbItemName.Items.Add(dbread(0).ToString + "-" + dbread(1).ToString)
        End While

        dbread.Dispose()

        cmbItemName.SelectedIndex = 0
        conn.Close()
    End Sub

    Private Sub cmdOrder_Click(sender As Object, e As EventArgs) Handles cmdOrder.Click

        Dim fullItem() As String = (cmbItemName.SelectedItem).ToString.Split("-")
        Dim itemID As Integer = fullItem(0)

        DataGridView1.Rows.Add(cmbType.SelectedItem, itemID, fullItem(1), lblPrice.Text, txtQuantity.Text, txtFee.Text)


    End Sub

    Private Sub cmbItemName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbItemName.SelectedIndexChanged
        checkOpen()

        Dim fullItem() As String = (cmbItemName.SelectedItem).ToString.Split("-")
        Dim itemID As Integer = fullItem(0)


        sql = "SELECT product_price FROM products WHERE product_id = @itemID"


        dbcomm = New MySqlCommand(sql, conn)

        dbcomm.Parameters.AddWithValue("@itemID", itemID)

        dbread = dbcomm.ExecuteReader

        While dbread.Read
            lblPrice.Text = dbread(0)
        End While

        dbread.Dispose()
        conn.Close()
    End Sub


    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        Dim quant As Integer
        If String.IsNullOrEmpty(txtQuantity.Text) Then
            quant = 0
            txtFee.Text = quant * Val(lblPrice.Text)
        Else
            quant = txtQuantity.Text
            txtFee.Text = quant * Val(lblPrice.Text)
        End If
    End Sub

    Private Sub cmdFinish_Click(sender As Object, e As EventArgs) Handles cmdFinish.Click
        checkOpen()

        Dim fullSupp() As String = (cmbSupp.SelectedItem).ToString.Split("-")
        Dim suppID As Integer = fullSupp(0)
        Dim lastDev As Integer = getLastDevID() + 1

        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim itemIDz As Integer = row.Cells("colItemID").Value
            Dim quantity As Integer = row.Cells("colQuantity").Value
            Dim totAmount As Integer = row.Cells("colTotalAmount").Value



            sql = "INSERT INTO deliveries(delivery_id,supplier_id, product_id, quantity, delivery_date, delivery_price)
                        VALUES (@devID, @suppID, @itemID, @quant, @dev_date, @dev_price)"


            dbcomm = New MySqlCommand(sql, conn)

            With dbcomm
                .Parameters.AddWithValue("@devID", lastDev)
                .Parameters.AddWithValue("@suppID", suppID)
                .Parameters.AddWithValue("@itemID", itemIDz)
                .Parameters.AddWithValue("@quant", quantity)
                .Parameters.AddWithValue("@dev_date", Now.ToString("yyyy-MM-dd"))
                .Parameters.AddWithValue("@dev_price", totAmount)
            End With

            Dim i As Integer = dbcomm.ExecuteNonQuery

            If i > 0 Then
                MsgBox("Order saved")

            Else
                MsgBox("Order failed")


            End If
        Next

        Dim dt As New DataTable
        With dt
            .Columns.Add("SupplierID")
            .Columns.Add("ItemName")
            .Columns.Add("Price")
            .Columns.Add("Quantity")
            .Columns.Add("TotalAmount")

        End With
        For Each dgr As DataGridViewRow In Me.DataGridView1.Rows
            dt.Rows.Add(suppID, dgr.Cells("colItemName").Value, dgr.Cells("colPrice").Value,
                        dgr.Cells("colQuantity").Value, dgr.Cells("colTotalAmount").Value)
        Next

        Dim reportDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument
        reportDocument = New DeliveryReport
        reportDocument.SetDataSource(dt)

        DeliveryForm.CrystalReportViewer1.ReportSource = reportDocument
        DeliveryForm.ShowDialog()
        DeliveryForm.Dispose()

        conn.Close()

    End Sub

    Private Function getLastDevID() As Integer
        Dim lastDevID As Integer

        sql = "SELECT MAX(delivery_id) FROM deliveries"

        dbcomm = New MySqlCommand(sql, conn)

        dbread = dbcomm.ExecuteReader()

        While dbread.Read
            lastDevID = dbread(0)
        End While


        dbread.Close()

        Return lastDevID
    End Function
End Class