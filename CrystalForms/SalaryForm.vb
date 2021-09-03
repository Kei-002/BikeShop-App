Imports MySql.Data.MySqlClient
Public Class SalaryForm

    Private Sub SalaryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkOpen()


        sql = "SELECT mechanic_id, mechanic_name FROM mechanics"
        dbcomm = New MySqlCommand(sql, conn)
        dbread = dbcomm.ExecuteReader

        While dbread.Read
            ComboBox1.Items.Add(dbread(0).ToString + "-" + dbread(1).ToString)
        End While

        dbread.Dispose()

        conn.Close()
    End Sub

    Private Sub cmdDaily_Click(sender As Object, e As EventArgs) Handles cmdDaily.Click
        Dim fullMech() As String = ComboBox1.SelectedItem.ToString.Split("-")
        Dim mechID As Integer = fullMech(0)


        checkOpen()
        Dim ds As New SalaryData

        Dim dailySalary As New DailySalaryReport


        sql = "SELECT service_desc as ServiceName, service_date, SUM(mech_wage) as salary FROM bikeservice
               INNER JOIN services ON services.service_id = bikeservice.service_id
               WHERE mechanic_id = " & mechID & " 
               GROUP BY service_date, service_desc"

        DataAdapter1 = New MySqlDataAdapter(sql, conn)

        DataAdapter1.Fill(ds.Tables("Salaryzzz"))
        DataAdapter1.Dispose()


        dailySalary.SetDataSource(ds)

        CrystalReportViewer1.ReportSource = dailySalary

        CrystalReportViewer1.Refresh()

        conn.Close()
    End Sub

    Private Sub cmdMonthly_Click(sender As Object, e As EventArgs) Handles cmdMonthly.Click
        Dim fullMech() As String = ComboBox1.SelectedItem.ToString.Split("-")
        Dim mechID As Integer = fullMech(0)


        checkOpen()
        Dim ds As New SalaryData

        Dim monthlySalary As New MonthlySalaryReport


        sql = "SELECT service_desc as ServiceName, service_date, SUM(mech_wage) as salary FROM bikeservice
               INNER JOIN services ON services.service_id = bikeservice.service_id
               WHERE mechanic_id = " & mechID & " 
               GROUP BY MONTH(service_date), service_desc"

        DataAdapter1 = New MySqlDataAdapter(sql, conn)

        DataAdapter1.Fill(ds.Tables("Salaryzzz"))
        DataAdapter1.Dispose()


        monthlySalary.SetDataSource(ds)

        CrystalReportViewer1.ReportSource = monthlySalary

        CrystalReportViewer1.Refresh()

        conn.Close()
    End Sub

    Private Sub cmdYearly_Click(sender As Object, e As EventArgs) Handles cmdYearly.Click
        Dim fullMech() As String = ComboBox1.SelectedItem.ToString.Split("-")
        Dim mechID As Integer = fullMech(0)


        checkOpen()
        Dim ds As New SalaryData

        Dim yearSalary As New YearlySalaryReport


        sql = "SELECT service_desc as ServiceName, service_date, SUM(mech_wage) as salary FROM bikeservice
               INNER JOIN services ON services.service_id = bikeservice.service_id
               WHERE mechanic_id = " & mechID & " 
               GROUP BY YEAR(service_date), service_desc"

        DataAdapter1 = New MySqlDataAdapter(sql, conn)

        DataAdapter1.Fill(ds.Tables("Salaryzzz"))
        DataAdapter1.Dispose()


        yearSalary.SetDataSource(ds)

        CrystalReportViewer1.ReportSource = yearSalary

        CrystalReportViewer1.Refresh()

        conn.Close()
    End Sub
End Class