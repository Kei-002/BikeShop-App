Imports MySql.Data.MySqlClient

Public Class IncomeForm
    Private Sub cmdDaily_Click(sender As Object, e As EventArgs) Handles cmdDaily.Click
        checkOpen()
        Dim ds As New NetIncomeData

        Dim dailyIncome As New DailyIncomeReport



        sql = "SELECT date_purchased, SUM(total_price) as grandtotal, SUM(service_fee) as total_serviceFee, SUM(mech_wage) as salary, SUM(delivery_price) as delivery_prices, SUM(exp_water + exp_electricity + exp_rent + exp_other) as misc FROM recieptproducts INNER JOIN
                bikeservice ON  bikeservice.customer_id = recieptproducts.customer_id
                INNER JOIN services ON services.service_id = bikeservice.service_id
                INNER JOIN deliveries ON deliveries.product_id = recieptproducts.product_id
                INNER JOIN expenses ON expenses.service_id = bikeservice.service_id
                GROUP BY date_purchased;"

        DataAdapter1 = New MySqlDataAdapter(sql, conn)

        DataAdapter1.Fill(ds.Tables("Income"))
        DataAdapter1.Dispose()



        dailyIncome.SetDataSource(ds)

        CrystalReportViewer1.ReportSource = dailyIncome

        CrystalReportViewer1.Refresh()

        conn.Close()

    End Sub

    Private Sub cmdMonthly_Click(sender As Object, e As EventArgs) Handles cmdMonthly.Click
        checkOpen()
        Dim ds As New NetIncomeData

        Dim monthlyInc As New MonthlyIncomeReport


        sql = "SELECT date_purchased, SUM(total_price) as grandtotal, SUM(service_fee) as total_serviceFee, SUM(mech_wage) as salary, SUM(delivery_price) as delivery_prices, SUM(exp_water + exp_electricity + exp_rent + exp_other) as misc FROM recieptproducts INNER JOIN
                bikeservice ON  bikeservice.customer_id = recieptproducts.customer_id
                INNER JOIN services ON services.service_id = bikeservice.service_id
                INNER JOIN deliveries ON deliveries.product_id = recieptproducts.product_id
                INNER JOIN expenses ON expenses.service_id = bikeservice.service_id
                GROUP BY MONTH(date_purchased);"

        DataAdapter1 = New MySqlDataAdapter(sql, conn)

        DataAdapter1.Fill(ds.Tables("Income"))
        DataAdapter1.Dispose()


        monthlyInc.SetDataSource(ds)

        CrystalReportViewer1.ReportSource = monthlyInc

        CrystalReportViewer1.Refresh()

        conn.Close()

    End Sub

    Private Sub cmdYearly_Click(sender As Object, e As EventArgs) Handles cmdYearly.Click
        checkOpen()
        Dim ds As New NetIncomeData

        Dim yearlyInc As New YearlyIncomeReport



        sql = "SELECT date_purchased, SUM(total_price) as grandtotal, SUM(service_fee) as total_serviceFee, SUM(mech_wage) as salary, SUM(delivery_price) as delivery_prices, SUM(exp_water + exp_electricity + exp_rent + exp_other) as misc FROM recieptproducts INNER JOIN
                bikeservice ON  bikeservice.customer_id = recieptproducts.customer_id
                INNER JOIN services ON services.service_id = bikeservice.service_id
                INNER JOIN deliveries ON deliveries.product_id = recieptproducts.product_id
                INNER JOIN expenses ON expenses.service_id = bikeservice.service_id
                GROUP BY YEAR(date_purchased);"

        DataAdapter1 = New MySqlDataAdapter(sql, conn)

        DataAdapter1.Fill(ds.Tables("Income"))
        DataAdapter1.Dispose()



        yearlyInc.SetDataSource(ds)

        CrystalReportViewer1.ReportSource = yearlyInc

        CrystalReportViewer1.Refresh()

        conn.Close()

    End Sub
End Class