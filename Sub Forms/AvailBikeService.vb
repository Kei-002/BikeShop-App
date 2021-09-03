Imports MySql.Data.MySqlClient
Public Class AvailBikeService
    Private Sub AvailBikeService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim info As String = Form1.lblServName.Text

        conn.Open()

        'Filling up service combobox  
        sql = "SELECT * FROM services"

        dbcomm = New MySqlCommand(sql, conn)

        dbread = dbcomm.ExecuteReader


        While dbread.Read
            cmbServices.Items.Add(dbread("service_desc"))
        End While

        dbread.Dispose()
        cmbServices.SelectedItem = info

        checkOpen()
        'Filling datagrid with service infos
        sql = "SELECT service_id, service_desc as ServiceName, service_fee as ServiceFee, service_percent as ServicePercent
               FROM services WHERE service_desc = '" & info & "'"

        dbcomm = New MySqlCommand(sql, conn)

        dbread = dbcomm.ExecuteReader

        While dbread.Read
            'cmbServices.SelectedItem = dbread("ServiceName")
            txtFee.Text = dbread("ServiceFee")
            txtPercent.Text = dbread("ServicePercent")
            ServID.Text = dbread("service_id")
        End While

        dbread.Dispose()



        txtWage.Text = Services.ComputeWage(ServID.Text)

        'Filling up customer combobox  
        sql1 = "SELECT * FROM customer"

        dbcomm = New MySqlCommand(sql1, conn)

        dbread = dbcomm.ExecuteReader


        While dbread.Read
            cmbCustomer.Items.Add(dbread("customer_name"))
        End While

        dbread.Dispose()

        'filling up mechanic combobox
        sql2 = "SELECT * FROM mechanics"

        dbcomm = New MySqlCommand(sql2, conn)

        dbread = dbcomm.ExecuteReader


        While dbread.Read
            cmbMechanic.Items.Add(dbread("mechanic_name"))
        End While

        dbread.Dispose()


        conn.Close()
    End Sub


    Private Sub cmdAvail_Click(sender As Object, e As EventArgs) Handles cmdAvail.Click
        conn.Open()

        Dim mechID As Integer = getMechID(cmbMechanic.SelectedItem)
        Dim cusID As Integer = getCusID(cmbCustomer.SelectedItem)
        Dim serveID As Integer = getServeID(cmbServices.SelectedItem)

        sql = "INSERT INTO bikeservice(service_id, service_date, mechanic_id, mech_wage ,customer_id)
               VALUES (@serveID, @serveDate, @mechID, @wage, @cusID)"

        dbcomm = New MySqlCommand(sql, conn)

        dbcomm.Parameters.AddWithValue("@serveID", serveID)
        dbcomm.Parameters.AddWithValue("@serveDate", Now.ToString("yyyy-MM-dd"))
        dbcomm.Parameters.AddWithValue("@mechID", mechID)
        dbcomm.Parameters.AddWithValue("@cusID", cusID)
        dbcomm.Parameters.AddWithValue("@wage", txtWage.Text)

        Dim i As Integer = dbcomm.ExecuteNonQuery

        If i > 0 Then
            MsgBox("data saved")


        Else
            MsgBox("data save failed")
        End If
        conn.Close()

        Dim exit_app As String = MsgBox("Avail a service again?", vbQuestion + vbYesNo, "Service availability")
        If exit_app = vbNo Then
            Me.Close()
        Else

        End If

    End Sub

    Private Sub cmdCompute_Click(sender As Object, e As EventArgs) Handles cmdCompute.Click
        checkOpen()
        txtWage.Text = Format(computeMechWage(txtPercent.Text, txtFee.Text), "N2")

        conn.Close()
    End Sub

    Private Sub cmbServices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbServices.SelectedIndexChanged
        checkOpen()
        'dbread.Dispose()
        sql = "SELECT service_id, service_desc as ServiceName, service_fee as ServiceFee, service_percent as ServicePercent
               FROM services WHERE service_desc = '" & cmbServices.SelectedItem & "'"

        dbcomm = New MySqlCommand(sql, conn)

        dbread = dbcomm.ExecuteReader

        While dbread.Read
            'cmbServices.SelectedItem = dbread("ServiceName")
            txtFee.Text = dbread("ServiceFee")
            txtPercent.Text = dbread("ServicePercent")
            ServID.Text = dbread("service_id")
        End While
        txtWage.Text = Format(computeMechWage(txtPercent.Text, txtFee.Text), "N2")

        dbread.Dispose()
        conn.Close()
    End Sub







#Region "Functions"



    Private Function computeMechWage(ByVal perc As Decimal, ByVal price As Decimal)
        Dim wage As Decimal

        wage = price * (perc / 100)


        Return wage
    End Function


    Private Function getCusID(ByVal cusName As String)

        Dim cusID As Integer

        sql = "SELECT customer_id FROM customer WHERE customer_name = '" & cusName & "'"

        dbcomm = New MySqlCommand(sql, conn)

        dbread = dbcomm.ExecuteReader

        dbread.Read()
        cusID = dbread(0)

        dbread.Dispose()
        Return cusID


    End Function

    Private Function getMechID(ByVal mechName As String)
        Dim mechID As Integer

        sql = "SELECT mechanic_id FROM mechanics WHERE mechanic_name = '" & mechName & "'"

        dbcomm = New MySqlCommand(sql, conn)

        dbread = dbcomm.ExecuteReader

        dbread.Read()
        mechID = dbread(0)

        dbread.Dispose()
        Return mechID

    End Function

    Public Function getServeID(ByVal serveName As String)
        Dim serveID As Integer

        sql = "SELECT service_id
               FROM services WHERE service_desc = '" & serveName & "'"

        dbcomm = New MySqlCommand(sql, conn)

        dbread = dbcomm.ExecuteReader

        dbread.Read()
        serveID = dbread(0)

        dbread.Dispose()
        Return serveID
    End Function


#End Region


End Class