Imports MySql.Data.MySqlClient
Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkOpen()




        'Fetches the total of mechanics in the database
        sql = "SELECT COUNT(mechanic_id) FROM mechanics"

        dbcomm = New MySqlCommand(sql, conn)

        dbread = dbcomm.ExecuteReader

        dbread.Read()

        lblMech.Text = dbread(0)
        dbread.Dispose()



        sql1 = "SELECT COUNT(customer_id) from customer"
        dbcomm = New MySqlCommand(sql1, conn)

        dbread = dbcomm.ExecuteReader

        dbread.Read()

        lblCustomers.Text = dbread(0)
        dbread.Dispose()




        sql2 = "SELECT COUNT(product_id) from products"
        dbcomm = New MySqlCommand(sql2, conn)

        dbread = dbcomm.ExecuteReader

        dbread.Read()

        lblProd.Text = dbread(0)
        dbread.Dispose()




        sql3 = "SELECT COUNT(accessory_id) from accessories"
        dbcomm = New MySqlCommand(sql3, conn)

        dbread = dbcomm.ExecuteReader

        dbread.Read()

        lblAcce.Text = dbread(0)
        dbread.Dispose()

        conn.Close()







    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim salesRep As New SalesForm

        salesRep.Show()
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Dim expRep As New ExpenseForm

        expRep.Show()
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        Dim salRep As New SalaryForm

        salRep.Show()
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        Dim increp As New IncomeForm

        increp.Show()
    End Sub
End Class