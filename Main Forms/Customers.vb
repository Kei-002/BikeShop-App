Imports MySql.Data.MySqlClient
Public Class Customers
    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkOpen()
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

        checkOpen()
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



    'Opens the PurchaseHistory form and sets the hidden lbl in parent form

    Private Sub cmdPurchaseHistory_Click(sender As Object, e As EventArgs) Handles cmdPurchaseHistory.Click
        Dim purHistory As New PurchaseHistory

        Form1.lblSavedID.Text = Me.dgCustomers.SelectedCells(0).Value

        purHistory.Show()

    End Sub

    Private Sub dgCustomers_MouseClick(sender As Object, e As MouseEventArgs) Handles dgCustomers.MouseClick
        Form1.lblSavedID.Text = Me.dgCustomers.SelectedCells(0).Value
    End Sub

    Private Sub cmdServiceHistory_Click(sender As Object, e As EventArgs) Handles cmdServiceHistory.Click
        Dim servHistory As New ServiceHistory

        Form1.lblSavedID.Text = Me.dgCustomers.SelectedCells(0).Value

        servHistory.Show()
    End Sub

    Private Sub cmdModCus_Click(sender As Object, e As EventArgs) Handles cmdModCus.Click
        Dim cusCRUD As New CustomerCRUD

        cusCRUD.Show()
    End Sub
End Class