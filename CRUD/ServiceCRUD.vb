Imports MySql.Data.MySqlClient

Public Class ServiceCRUD
    Private Sub ServiceCRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            checkOpen()


            txtName.Clear()
            txtPercent.Clear()
            txtFee.Clear()
            txtWage.Clear()

            ds = New DataSet

            'Filling datagrid with service infos
            sql = "SELECT service_id as ServiceID, service_desc as ServiceName, service_fee as ServiceFee, service_percent as Percent, mechanic_wage as Wage from services"

            DataAdapter1 = New MySqlDataAdapter(sql, conn)

            DataAdapter1.Fill(ds, "AllServe")

            dgServices.DataSource = ds.Tables("AllServe")



            dgServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MsgBox("Load " + ex.ToString)
        End Try

        DataAdapter1.Dispose()

        conn.Close()
    End Sub


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            checkOpen()
            dt = New DataTable

            sql = "SELECT service_desc as ServiceName, service_fee as ServiceFee, service_percent as Percent, mechanic_wage as Wage from services
               WHERE service_desc like '%" & txtSearch.Text & "%'"

            DataAdapter1 = New MySqlDataAdapter(sql, conn)

            DataAdapter1.Fill(dt)

            dgServices.DataSource = dt


        Catch ex As Exception
            MsgBox("tChange " + ex.ToString)
        End Try

        DataAdapter1.Dispose()
        conn.Close()
    End Sub

    Private Sub dgServices_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgServices.MouseDoubleClick
        Try
            txtName.Text = Me.dgServices.CurrentRow.Cells("ServiceName").Value
            txtFee.Text = Me.dgServices.CurrentRow.Cells("ServiceFee").Value
            txtPercent.Text = Me.dgServices.CurrentRow.Cells("Percent").Value
            txtWage.Text = Me.dgServices.CurrentRow.Cells("Wage").Value
            lblServiceID.Text = Me.dgServices.CurrentRow.Cells("ServiceID").Value
        Catch ex As Exception
            MsgBox("2 clicks " + ex.ToString)
        End Try
    End Sub









    'CRUD Functions
    Private Sub cmdAddp_Click(sender As Object, e As EventArgs) Handles cmdAddp.Click


        Try


            checkOpen()


            'Insert to services
            sql = "INSERT INTO services(service_desc, service_fee, service_percent, mechanic_wage) VALUES (@serveName, @serveFee, @servePercent, @mechWage)"

            dbcomm = New MySqlCommand(sql, conn)

            dbcomm.Parameters.AddWithValue("@serveName", txtName.Text)
            dbcomm.Parameters.AddWithValue("@serveFee", txtFee.Text)
            dbcomm.Parameters.AddWithValue("@servePercent", txtPercent.Text)
            dbcomm.Parameters.AddWithValue("@mechWage", txtWage.Text)

            Dim i As Integer = dbcomm.ExecuteNonQuery

            If i > 0 Then
                MsgBox("Data saved")

            Else
                MsgBox("Data save failed")
            End If

        Catch ex As Exception
            MsgBox("add " + ex.ToString)
        End Try


        dbcomm.Dispose()
        conn.Close()


        Call ServiceCRUD_Load(sender, e)
    End Sub

    Private Sub cmdUpdatep_Click(sender As Object, e As EventArgs) Handles cmdUpdatep.Click
        Try
            checkOpen()


            Dim serveID As Integer = lblServiceID.Text

            'Update service details
            sql = "UPDATE services SET service_desc = @serveName, service_fee = @serveFee, service_percent = @servePercent, mechanic_wage = @mechWage
              WHERE service_id = @serveID"

            dbcomm = New MySqlCommand(sql, conn)

            dbcomm.Parameters.AddWithValue("@serveName", txtName.Text)
            dbcomm.Parameters.AddWithValue("@serveFee", txtFee.Text)
            dbcomm.Parameters.AddWithValue("@servePercent", txtPercent.Text)
            dbcomm.Parameters.AddWithValue("@mechWage", txtWage.Text)
            dbcomm.Parameters.AddWithValue("@serveID", serveID)


            Dim i As Integer = dbcomm.ExecuteNonQuery

            If i > 0 Then
                MsgBox(i.ToString + "Data saved")

            Else
                MsgBox("Data save failed")
            End If

            conn.Close()
        Catch ex As Exception
            MsgBox("update " + ex.ToString)
        End Try
        Call ServiceCRUD_Load(sender, e)
    End Sub

    Private Sub cmdDeletep_Click(sender As Object, e As EventArgs) Handles cmdDeletep.Click
        Try


            checkOpen()

            Dim serveID As Integer = lblServiceID.Text

            sql = "DELETE FROM services WHERE service_id = " & serveID

            dbcomm = New MySqlCommand(sql, conn)

            Dim i As Integer = dbcomm.ExecuteNonQuery

            If i > 0 Then
                MsgBox("Data Deleted")

            Else
                MsgBox("Data not Deleted")
            End If

        Catch ex As Exception
            MsgBox("del " + ex.ToString)
        End Try

        dbcomm.Dispose()
        conn.Close()

        Call ServiceCRUD_Load(sender, e)
    End Sub

    Private Sub txtPercent_LostFocus(sender As Object, e As EventArgs) Handles txtPercent.LostFocus
        checkOpen()
        Dim sFee As Decimal = txtFee.Text
        Dim sPerc As Decimal = txtPercent.Text

        txtWage.Text = Format(MechComputeWage(sFee, sPerc), "N2")
        conn.Close()
    End Sub

    Private Function MechComputeWage(ByVal fee As Decimal, ByVal percent As Decimal)
        Dim mechWage As Decimal

        mechWage = fee * (percent / 100)

        Return mechWage
    End Function

    Private Function getServeID(ByVal serveName As String)
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

    Private Sub txtWage_TextChanged(sender As Object, e As EventArgs) Handles txtWage.TextChanged

    End Sub
End Class