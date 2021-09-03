Imports MySql.Data.MySqlClient
Public Class SalesForm
    Private Sub cmdDaily_Click(sender As Object, e As EventArgs) Handles cmdDaily.Click
        checkOpen()
        Dim dt As New DataTable

        Dim dailySales As New CrySalesReport

        sql = "SELECT product_desc as ItemName, date_purchased as DatePurchased, SUM(quantity) as Quantity, SUM(total_price) as TotalPrice
               FROM recieptproducts INNER JOIN products on recieptproducts.product_id = products.product_id GROUP BY product_desc, date_purchased"

        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader

        dt.Load(dbread)

        dailySales.SetDataSource(dt)

        CrystalReportViewer1.ReportSource = dailySales

        CrystalReportViewer1.Refresh()

        conn.Close()
    End Sub

    Private Sub cmdMonthly_Click(sender As Object, e As EventArgs) Handles cmdMonthly.Click
        checkOpen()
        Dim dt As New DataTable

        Dim monthlySales As New MonthlySalesReport

        sql = "SELECT product_desc as ItemName, date_purchased as DatePurchased, SUM(quantity) as Quantity, SUM(total_price) as TotalPrice
               FROM recieptproducts INNER JOIN products on recieptproducts.product_id = products.product_id GROUP BY product_desc, MONTH(date_purchased)"

        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader

        dt.Load(dbread)

        monthlySales.SetDataSource(dt)

        CrystalReportViewer1.ReportSource = monthlySales

        CrystalReportViewer1.Refresh()

        conn.Close()
    End Sub

    Private Sub cmdYearly_Click(sender As Object, e As EventArgs) Handles cmdYearly.Click
        checkOpen()
        Dim dt As New DataTable

        Dim yearlySales As New YearlySalesReport

        sql = "SELECT product_desc as ItemName, date_purchased as DatePurchased, SUM(quantity) as Quantity, SUM(total_price) as TotalPrice
               FROM recieptproducts INNER JOIN products on recieptproducts.product_id = products.product_id GROUP BY product_desc, YEAR(date_purchased)"


        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader

        dt.Load(dbread)

        yearlySales.SetDataSource(dt)

        CrystalReportViewer1.ReportSource = yearlySales

        CrystalReportViewer1.Refresh()

        conn.Close()
    End Sub

    Private Sub SalesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class