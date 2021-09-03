Imports MySql.Data.MySqlClient
Public Class Services
    Private Sub Services_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkOpen()
        ds = New DataSet

        'Filling datagrid with service infos
        sql = "SELECT service_desc as ServiceName, service_fee as ServiceFee from services"

        DataAdapter1 = New MySqlDataAdapter(sql, conn)

        DataAdapter1.Fill(ds, "AllServe")


        dgServices.DataSource = ds.Tables("AllServe")

        DataAdapter1.Dispose()

        conn.Close()

        dgServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        checkOpen()
        dt = New DataTable

        sql = "SELECT service_desc as ServiceName, service_fee as ServiceFee from services
               WHERE service_desc like '%" & txtSearch.Text & "%'"

        DataAdapter1 = New MySqlDataAdapter(sql, conn)

        DataAdapter1.Fill(dt)

        dgServices.DataSource = dt

        DataAdapter1.Dispose()
        conn.Close()
    End Sub

    Private Sub cmdAvail_Click(sender As Object, e As EventArgs) Handles cmdAvail.Click
        Dim availService As New AvailBikeService

        Form1.lblServName.Text = Me.dgServices.SelectedCells(0).Value
        availService.ShowDialog()


    End Sub

    Private Sub dgServices_MouseClick(sender As Object, e As MouseEventArgs) Handles dgServices.MouseClick

        Form1.lblServName.Text = Me.dgServices.SelectedCells(0).Value
    End Sub



    'Function for getting wage
    Public Function ComputeWage(ByVal serviceID As Integer) As Decimal
        Dim wageMech As Decimal
        Dim servFee As Decimal
        Dim servPercent As Integer

        'Filling datagrid with service infos
        sql = "SELECT service_id, service_fee as ServiceFee, service_percent as ServicePercent
               FROM services WHERE service_id = " & serviceID

        dbcomm = New MySqlCommand(sql, conn)

        dbread = dbcomm.ExecuteReader

        While dbread.Read
            servFee = dbread("ServiceFee")
            servPercent = dbread("ServicePercent")
        End While

        wageMech = servFee * (servPercent / 100)
        dbread.Dispose()

        Return wageMech
    End Function

    Private Sub cmdModCus_Click(sender As Object, e As EventArgs) Handles cmdModCus.Click
        Dim serveCRUD As New ServiceCRUD

        serveCRUD.ShowDialog()
        Call Services_Load(sender, e)
    End Sub

    Private Sub cmdModExp_Click(sender As Object, e As EventArgs) Handles cmdModExp.Click
        Dim expCRUD As New ExpensesCRUD

        expCRUD.ShowDialog()
        Call Services_Load(sender, e)
    End Sub
End Class