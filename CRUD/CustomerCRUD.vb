Imports MySql.Data.MySqlClient
Public Class CustomerCRUD
    Private Sub CustomerCRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        ds = New DataSet

        'Filling datagrid with customer infos
        sql = "Select customer_id as CustomerID, customer_name as Name, customer_age as Age, customer_address as Address,
               customer_phone as PhoneNum from customer"

        DataAdapter1 = New MySqlDataAdapter(sql, conn)

        DataAdapter1.Fill(ds, "AllCustomers")


        dgCustomers.DataSource = ds.Tables("AllCustomers")

        DataAdapter1.Dispose()

        conn.Close()

        dgCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub


    'Filter datagrid through search text box
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        conn.Open()
        dt = New DataTable

        sql = "Select customer_id as CustomerID, customer_name as Name, customer_age as Age, customer_address as Address,
               customer_phone as PhoneNum from customer
               WHERE customer_name like '%" & txtSearch.Text & "%'"

        DataAdapter1 = New MySqlDataAdapter(sql, conn)

        DataAdapter1.Fill(dt)

        dgCustomers.DataSource = dt

        DataAdapter1.Dispose()
        conn.Close()

    End Sub

    'Sets textboxes to the selected customer info
    Private Sub dgCustomers_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgCustomers.MouseDoubleClick
        txtName.Text = Me.dgCustomers.CurrentRow.Cells("Name").Value
        txtAddress.Text = Me.dgCustomers.CurrentRow.Cells("Address").Value
        txtAge.Text = Me.dgCustomers.CurrentRow.Cells("Age").Value
        txtPhone.Text = Me.dgCustomers.CurrentRow.Cells("PhoneNum").Value

        lblCustomerID.Text = Me.dgCustomers.CurrentRow.Cells("CustomerID").Value
    End Sub





    'CRUD Functions
    Private Sub cmdAddp_Click(sender As Object, e As EventArgs) Handles cmdAddp.Click
        conn.Open()

        'Insert to customer 
        sql = "INSERT INTO customer(customer_name, customer_age, customer_address, customer_phone)
               VALUES (@cusName, @cusAge, @cusAddress, @cusPhone)"

        dbcomm = New MySqlCommand(sql, conn)

        dbcomm.Parameters.AddWithValue("@cusName", txtName.Text)
        dbcomm.Parameters.AddWithValue("@cusAge", CInt(txtAge.Text))
        dbcomm.Parameters.AddWithValue("@cusAddress", txtAddress.Text)
        dbcomm.Parameters.AddWithValue("@cusPhone", txtPhone.Text)

        Dim i As Integer = dbcomm.ExecuteNonQuery

        If i > 0 Then
            MsgBox("Data saved")

        Else
            MsgBox("Data save failed")
        End If

        dbcomm.Dispose()

        conn.Close()
        Call CustomerCRUD_Load(sender, e)


    End Sub

    Private Sub cmdUpdatep_Click(sender As Object, e As EventArgs) Handles cmdUpdatep.Click
        conn.Open()

        'Update product details
        sql = "UPDATE customer SET customer_name = @cusName, customer_age = @cusAge, customer_address = @cusAddress, customer_phone = @cusPhone
               WHERE customer_id = @cusID"

        dbcomm = New MySqlCommand(sql, conn)


        dbcomm.Parameters.AddWithValue("@cusName", txtName.Text)
        dbcomm.Parameters.AddWithValue("@cusAge", CInt(txtAge.Text))
        dbcomm.Parameters.AddWithValue("@cusAddress", txtAddress.Text)
        dbcomm.Parameters.AddWithValue("@cusPhone", txtPhone.Text)
        dbcomm.Parameters.AddWithValue("@cusID", CInt(lblCustomerID.Text))

        Dim i As Integer = dbcomm.ExecuteNonQuery

        If i > 0 Then
            MsgBox(i.ToString + "Data saved")

        Else
            MsgBox("Data save failed")
        End If


        conn.Close()
        Call CustomerCRUD_Load(sender, e)
    End Sub

    Private Sub cmdDeletep_Click(sender As Object, e As EventArgs) Handles cmdDeletep.Click
        conn.Open()

        sql = "DELETE FROM customer WHERE customer_id = " & CInt(lblCustomerID.Text)

        dbcomm = New MySqlCommand(sql, conn)

        Dim i As Integer = dbcomm.ExecuteNonQuery

        If i > 0 Then
            MsgBox("Data Deleted")

        Else
            MsgBox("Data not Deleted")
        End If

        conn.Close()

        Call CustomerCRUD_Load(sender, e)



    End Sub


End Class