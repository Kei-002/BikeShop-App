Imports MySql.Data.MySqlClient
Public Class CustomerOrder
    Private Sub CustomerOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkOpen()

        sql = "SELECT * FROM customer"

        dbcomm = New MySqlCommand(sql, conn)

        dbread = dbcomm.ExecuteReader

        While dbread.Read
            cmbCustomer.Items.Add(dbread(0).ToString + "-" + dbread(1).ToString)
        End While

        conn.Close()
    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged, cmbCustomer.SelectedIndexChanged
        checkOpen()
        cmbItem.Items.Clear()

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
            cmbItem.Items.Add(dbread(0).ToString + "-" + dbread(1).ToString)
        End While

        dbread.Dispose()

        cmbItem.SelectedIndex = 0
        conn.Close()
    End Sub

    Private Sub cmbItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbItem.SelectedIndexChanged
        checkOpen()

        Dim fullItem() As String = (cmbItem.SelectedItem).ToString.Split("-")
        Dim itemID As Integer = fullItem(0)

        sql = "SELECT product_price FROM products WHERE product_id = @itemID"

        dbcomm = New MySqlCommand(sql, conn)

        dbcomm.Parameters.AddWithValue("@itemID", itemID)

        dbread = dbcomm.ExecuteReader

        While dbread.Read
            txtPrice.Text = dbread(0)
        End While

        txtQuantity.Text = 1
        Dim quant As Integer = txtQuantity.Text
        txtAmount.Text = quant * Val(txtPrice.Text)
        dbread.Dispose()
        conn.Close()

    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        Dim quant As Integer
        If String.IsNullOrEmpty(txtQuantity.Text) Then
            quant = 0
            txtAmount.Text = quant * Val(txtPrice.Text)
        Else
            quant = txtQuantity.Text
            txtAmount.Text = quant * Val(txtPrice.Text)
        End If
    End Sub

    Private Sub cmdAddOrder_Click(sender As Object, e As EventArgs) Handles cmdAddOrder.Click

        Dim fullItem() As String = (cmbItem.SelectedItem).ToString.Split("-")
        Dim itemID As Integer = fullItem(0)

        DataGridView1.Rows.Add(cmbType.SelectedItem, itemID, fullItem(1), txtPrice.Text, txtQuantity.Text, txtAmount.Text)

    End Sub

    Private Sub cmdFinish_Click(sender As Object, e As EventArgs) Handles cmdFinish.Click
        checkOpen()

        Dim fullName() As String = (cmbCustomer.SelectedItem).ToString.Split("-")
        Dim cusID As Integer = fullName(0)
        Dim shipfee As Decimal = 0

        Dim lastID As Integer = getLastID() + 1
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim itemID As Integer = row.Cells("colItemID").Value
            Dim quantity As Integer = row.Cells("colQuantity").Value
            Dim totAmount As Integer = row.Cells("colTotalAmount").Value


            sql = "INSERT INTO recieptproducts(reciept_id,customer_id, product_id, date_purchased, quantity, total_price)
                      VALUES (@recID,@cusID, @prodID, @datePur, @quant, @total)"

            dbcomm = New MySqlCommand(sql, conn)

            With dbcomm
                .Parameters.AddWithValue("@recID", lastID)
                .Parameters.AddWithValue("@cusID", cusID)
                .Parameters.AddWithValue("@prodID", itemID)
                .Parameters.AddWithValue("@datePur", Now.ToString("yyyy-MM-dd"))
                .Parameters.AddWithValue("@quant", quantity)
                .Parameters.AddWithValue("@total", totAmount)
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
            .Columns.Add("CustomerID")
            .Columns.Add("ItemName")
            .Columns.Add("ItemPrice")
            .Columns.Add("Quantity")
            .Columns.Add("Total")

        End With
        For Each dgr As DataGridViewRow In Me.DataGridView1.Rows
            dt.Rows.Add(cusID, dgr.Cells("colItemName").Value, dgr.Cells("colPrice").Value,
                        dgr.Cells("colQuantity").Value, dgr.Cells("colTotalAmount").Value)
        Next

        Dim reportDocument As CrystalDecisions.CrystalReports.Engine.ReportDocument
        reportDocument = New RecieptReport
        reportDocument.SetDataSource(dt)

        RecieptForm.CrystalReportViewer1.ReportSource = reportDocument
        RecieptForm.ShowDialog()
        RecieptForm.Dispose()

        conn.Close()
    End Sub


    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
        Else
            MessageBox.Show("Select 1 row before you hit Delete")
        End If
    End Sub

    Private Sub cmdCalculate_Click(sender As Object, e As EventArgs) Handles cmdCalculate.Click
        Dim ship As Integer = 0
        If cmbShipping.SelectedIndex = 0 Then
            ship = 0
        ElseIf cmbShipping.SelectedIndex = 1 Then
            ship = 50
        Else
            ship = 150
        End If

        Dim totPrice As Decimal = 0
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim totAmount As Integer = row.Cells("colTotalAmount").Value

            totPrice = totPrice + totAmount

        Next
        txtTotalPrice.Text = totPrice + ship
    End Sub

    Private Function getLastID() As Integer
        Dim lastOrderID As Integer

        sql = "SELECT MAX(reciept_id) FROM recieptproducts"

        dbcomm = New MySqlCommand(sql, conn)

        dbread = dbcomm.ExecuteReader()

        While dbread.Read
            lastOrderID = dbread(0)
        End While


        dbread.Close()

        Return lastOrderID
    End Function


End Class