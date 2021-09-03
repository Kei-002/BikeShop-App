Imports MySql.Data.MySqlClient

Public Class ExpenseForm
    Private Sub cmdDaily_Click(sender As Object, e As EventArgs) Handles cmdDaily.Click
        checkOpen()
        Dim ds As New ExpenseData

        Dim dailyExpense As New DailyExpenseReport

        'sql = "SELECT delivery_date, SUM(delivery_price) as totalDelivery FROM deliveries

        '        GROUP BY delivery_date"

        'DataAdapter1 = New MySqlDataAdapter(sql, conn)
        'dbread = dbcomm.ExecuteReader

        'DataAdapter1.Fill(ds.Tables("delivery"))
        'DataAdapter1.Dispose()



        sql1 = "SELECT expenses.service_id,service_date, SUM(mech_wage) as salary ,SUM(delivery_price) as delivery,SUM(exp_water) as water, SUM(exp_electricity) as electricity,
                SUM(exp_rent) as rent, SUM(exp_other) as ex_other FROM expenses
                INNER JOIN bikeservice ON expenses.service_id = bikeservice.service_id
                INNER JOIN deliveries ON delivery_date = service_date
                GROUP BY service_date"

        DataAdapter2 = New MySqlDataAdapter(sql1, conn)
        'dbread = dbcomm.ExecuteReader

        DataAdapter2.Fill(ds.Tables("expenses"))
        DataAdapter2.Dispose()



        dailyExpense.SetDataSource(ds)

        CrystalReportViewer1.ReportSource = dailyExpense

        CrystalReportViewer1.Refresh()

        conn.Close()

    End Sub

    Private Sub cmdMonthly_Click(sender As Object, e As EventArgs) Handles cmdMonthly.Click
        checkOpen()
        Dim ds As New ExpenseData

        Dim monthlyExp As New MonthlyExpenseReport

        'sql = "SELECT delivery_date, SUM(delivery_price) as totalDelivery FROM deliveries

        '        GROUP BY delivery_date"

        'DataAdapter1 = New MySqlDataAdapter(sql, conn)
        'dbread = dbcomm.ExecuteReader

        'DataAdapter1.Fill(ds.Tables("delivery"))
        'DataAdapter1.Dispose()



        sql1 = "SELECT expenses.service_id, service_date, SUM(mech_wage) as salary ,SUM(delivery_price) as delivery,SUM(exp_water) as water, SUM(exp_electricity) as electricity,
                SUM(exp_rent) as rent, SUM(exp_other) as ex_other FROM expenses
                INNER JOIN bikeservice ON expenses.service_id = bikeservice.service_id
                INNER JOIN deliveries ON delivery_date = service_date
                GROUP BY MONTH(service_date)"

        DataAdapter2 = New MySqlDataAdapter(sql1, conn)
        'dbread = dbcomm.ExecuteReader

        DataAdapter2.Fill(ds.Tables("expenses"))
        DataAdapter2.Dispose()



        monthlyExp.SetDataSource(ds)

        CrystalReportViewer1.ReportSource = monthlyExp

        CrystalReportViewer1.Refresh()

        conn.Close()

    End Sub

    Private Sub cmdYearly_Click(sender As Object, e As EventArgs) Handles cmdYearly.Click
        checkOpen()
        Dim ds As New ExpenseData

        Dim yearlyExp As New YearlyExpenseReport

        'sql = "SELECT delivery_date, SUM(delivery_price) as totalDelivery FROM deliveries

        '        GROUP BY delivery_date"

        'DataAdapter1 = New MySqlDataAdapter(sql, conn)
        'dbread = dbcomm.ExecuteReader

        'DataAdapter1.Fill(ds.Tables("delivery"))
        'DataAdapter1.Dispose()



        sql1 = "SELECT expenses.service_id, service_date, SUM(mech_wage) as salary ,SUM(delivery_price) as delivery,SUM(exp_water) as water, SUM(exp_electricity) as electricity,
                SUM(exp_rent) as rent, SUM(exp_other) as ex_other FROM expenses
                INNER JOIN bikeservice ON expenses.service_id = bikeservice.service_id
                INNER JOIN deliveries ON delivery_date = service_date
                GROUP BY YEAR(service_date)"

        DataAdapter2 = New MySqlDataAdapter(sql1, conn)
        'dbread = dbcomm.ExecuteReader

        DataAdapter2.Fill(ds.Tables("expenses"))
        DataAdapter2.Dispose()



        yearlyExp.SetDataSource(ds)

        CrystalReportViewer1.ReportSource = yearlyExp

        CrystalReportViewer1.Refresh()

        conn.Close()
    End Sub
End Class