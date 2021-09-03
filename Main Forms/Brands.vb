Imports MySql.Data.MySqlClient

Public Class Brands
    Private Sub Brands_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkOpen()
        ds = New DataSet

        'Filling datagrid with supplier infos
        sql = "SELECT brand_id as BrandID, brand_name as BrandName from brands"

        DataAdapter1 = New MySqlDataAdapter(sql, conn)

        DataAdapter1.Fill(ds, "allBrands")


        dgBrands.DataSource = ds.Tables("allBrands")

        DataAdapter1.Dispose()

        conn.Close()

        dgBrands.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub dgBrands_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgBrands.MouseDoubleClick
        txtName.Text = Me.dgBrands.CurrentRow.Cells("BrandName").Value
    End Sub






    'CRUD Functions
    Private Sub cmdAddp_Click(sender As Object, e As EventArgs) Handles cmdAddp.Click
        checkOpen()

        'Insert to brands
        sql = "INSERT INTO brands(brand_name) VALUES (@brand)"

        dbcomm = New MySqlCommand(sql, conn)

        dbcomm.Parameters.AddWithValue("@brand", txtName.Text)


        Dim i As Integer = dbcomm.ExecuteNonQuery

        If i > 0 Then
            MsgBox("Data saved")

        Else
            MsgBox("Data save failed")
        End If

        dbcomm.Dispose()
        'End of supplier insert


        conn.Close()
        Call Brands_Load(sender, e)
    End Sub

    Private Sub cmdUpdatep_Click(sender As Object, e As EventArgs) Handles cmdUpdatep.Click
        Dim selectedID As Integer = Me.dgBrands.CurrentRow.Cells("BrandID").Value
        checkOpen()


        sql = "UPDATE brands SET brand_name = @brand
              WHERE brand_id = @brandID"

        dbcomm = New MySqlCommand(sql, conn)

        dbcomm.Parameters.AddWithValue("@brand", txtName.Text)

        dbcomm.Parameters.AddWithValue("@brandID", selectedID)

        Dim i As Integer = dbcomm.ExecuteNonQuery

        If i > 0 Then
            MsgBox(i.ToString + "Data saved")

        Else
            MsgBox("Data save failed")
        End If




        conn.Close()
        Call Brands_Load(sender, e)
    End Sub

    Private Sub cmdDeletep_Click(sender As Object, e As EventArgs) Handles cmdDeletep.Click
        Dim selectedID As Integer = Me.dgBrands.CurrentRow.Cells("BrandID").Value

        checkOpen()


        sql = "DELETE FROM brands
              WHERE brand_id = @brandID"

        dbcomm = New MySqlCommand(sql, conn)

        dbcomm.Parameters.AddWithValue("@brandID", selectedID)

        Dim i As Integer = dbcomm.ExecuteNonQuery

        If i > 0 Then
            MsgBox(i.ToString + "Data saved")

        Else
            MsgBox("Data save failed")
        End If

        dbcomm.Dispose()

        conn.Close()
        Call Brands_Load(sender, e)
    End Sub




End Class