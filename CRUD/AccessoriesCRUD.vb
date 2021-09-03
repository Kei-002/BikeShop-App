Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class AccessoriesCRUD
    Private Sub AccessoriesCRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkOpen()


        ds = New DataSet
        cmbTypes.Items.Clear()
        cmbItemType.Items.Clear()
        cmbBrands.Items.Clear()


        'Loading products to datagrid
        sql = "SELECT a.accessory_id as AccessoryID, accessory_name as Name, accessory_type_name as Type, brand_name as Brand, accessory_price as Price
               FROM accessories a, accessory_types at, brands b
               WHERE a.accessory_type = at.accessory_type_id AND a.accessory_brand = b.brand_id
               GROUP BY AccessoryID"

        DataAdapter1 = New MySqlDataAdapter(sql, conn)
        DataAdapter1.Fill(ds, "AllAcces")
        dgItem.DataSource = ds.Tables("AllAcces")
        DataAdapter1.Dispose()



        'Loading categories(accessory_types) to cmbTypes and cmbItemType
        sql1 = "SELECT * FROM accessory_types"

        dbcomm = New MySqlCommand(sql1, conn)

        dbread = dbcomm.ExecuteReader


        While dbread.Read
            cmbTypes.Items.Add(dbread(1))
            cmbItemType.Items.Add(dbread(1))
        End While
        dbread.Dispose()



        'Loading brands to cmbBrands
        sql2 = "SELECT * FROM brands"

        dbcomm = New MySqlCommand(sql2, conn)

        dbread = dbcomm.ExecuteReader

        While dbread.Read
            cmbBrands.Items.Add(dbread(1))
        End While

        dbread.Dispose()

        DataAdapter2 = New MySqlDataAdapter(sql2, conn)
        ds = New DataSet("tblBrands")
        DataAdapter2.Fill(ds, "tblBrands")

        DataAdapter2.Dispose()

        cmbBrands.SelectedItem = 0
        cmbItemType.SelectedItem = 0
        cmbTypes.SelectedItem = 0

        conn.Close()


        dgItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        checkOpen()
        dt = New DataTable

        sql = "SELECT a.accessory_id as AccessoryID, accessory_name as Name, accessory_type_name as Type, brand_name as Brand, accessory_price as Price
               FROM accessories a, accessory_types at, brands b
               WHERE a.accessory_type = at.accessory_type_id AND a.accessory_brand = b.brand_id AND accessory_name like '%" & txtSearch.Text & "%'
               GROUP BY AccessoryID"

        DataAdapter1 = New MySqlDataAdapter(sql, conn)

        DataAdapter1.Fill(dt)

        dgItem.DataSource = dt

        DataAdapter1.Dispose()
        conn.Close()
    End Sub


    'Filtering products through combobox
    Private Sub cmbTypes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTypes.SelectedIndexChanged
        checkOpen()
        dt = New DataTable

        sql = "SELECT a.accessory_id as AccessoryID, accessory_name as Name, accessory_type_name as Type, brand_name as Brand, accessory_price as Price
               FROM accessories a, accessory_types at, brands b
               WHERE a.accessory_type = at.accessory_type_id AND a.accessory_brand = b.brand_id AND accessory_type_name like '%" & cmbTypes.SelectedItem & "%'
               GROUP BY AccessoryID"

        DataAdapter1 = New MySqlDataAdapter(sql, conn)

        DataAdapter1.Fill(dt)

        dgItem.DataSource = dt

        DataAdapter1.Dispose()
        conn.Close()

    End Sub


    'Getting last ID
    Private Function getLastID()

        Dim lastID As Integer

        sql = "SELECT MAX(accessory_id) FROM accessories"

        dbcomm = New MySqlCommand(sql, conn)

        dbread = dbcomm.ExecuteReader

        dbread.Read()
        lastID = dbread(0)

        dbread.Dispose()
        Return lastID

    End Function

    Private Sub dgItem_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgItem.MouseDoubleClick
        lblAccessoryID.Text = Me.dgItem.CurrentRow.Cells("AccessoryID").Value
        txtName.Text = Me.dgItem.CurrentRow.Cells("Name").Value
        cmbItemType.SelectedItem = Me.dgItem.CurrentRow.Cells("Type").Value
        cmbBrands.SelectedItem = Me.dgItem.CurrentRow.Cells("Brand").Value
        txtPrice.Text = Me.dgItem.CurrentRow.Cells("Price").Value


    End Sub

    'Function for getting Type ID
    Private Function getTypeID(ByVal typeName As String) As Integer
        Dim typeID As Integer

        checkOpen()

        sql = "SELECT accessory_type_id from accessory_types WHERE accessory_type_name = @typeN"
        dbcomm = New MySqlCommand(sql, conn)
        dbcomm.Parameters.AddWithValue("@typeN", typeName)
        dbread = dbcomm.ExecuteReader

        dbread.Read()
        typeID = dbread(0)

        dbread.Dispose()
        conn.Close()

        Return typeID

    End Function


    'Function for getting brand ID
    Private Function getBrandId(ByVal brandName As String) As Integer

        Dim brandID As Integer

        checkOpen()

        sql = "SELECT brand_id from brands WHERE brand_name = @brandN"
        dbcomm = New MySqlCommand(sql, conn)
        dbcomm.Parameters.AddWithValue("@brandN", brandName)
        dbread = dbcomm.ExecuteReader

        dbread.Read()
        brandID = dbread(0)

        dbread.Dispose()
        conn.Close()

        Return brandID


    End Function

    Private Sub clear_text()

        txtName.Clear()
        txtPrice.Clear()
        cmbTypes.Items.Clear()
        cmbItemType.Items.Clear()
        cmbBrands.Items.Clear()

    End Sub









    'CRUD functions
    Private Sub cmdAddp_Click(sender As Object, e As EventArgs) Handles cmdAddp.Click

        Dim typeID As Integer = getTypeID(cmbItemType.SelectedItem)
        Dim brandID As Integer = getBrandId(cmbBrands.SelectedItem)

        checkOpen()


        'Insert to products
        sql = "INSERT INTO accessories(accessory_name, accessory_type, accessory_brand ,accessory_price) VALUES (@acceName, @acceType, @acceBrand, @accePrice)"

        dbcomm = New MySqlCommand(sql, conn)

        dbcomm.Parameters.AddWithValue("@acceName", txtName.Text)
        dbcomm.Parameters.AddWithValue("@acceType", typeID)
        dbcomm.Parameters.AddWithValue("@acceBrand", brandID)
        dbcomm.Parameters.AddWithValue("@accePrice", txtPrice.Text)

        Dim i As Integer = dbcomm.ExecuteNonQuery

        If i > 0 Then
            MsgBox("Data saved")

        Else
            MsgBox("Data save failed")
        End If

        dbcomm.Dispose()
        'End of product insert

        conn.Close()

        Call AccessoriesCRUD_Load(sender, e)
    End Sub

    Private Sub cmdUpdatep_Click(sender As Object, e As EventArgs) Handles cmdUpdatep.Click
        Dim typeID As Integer = getTypeID(cmbItemType.SelectedItem)
        Dim brandID As Integer = getBrandId(cmbBrands.SelectedItem)

        checkOpen()


        'Update product details
        sql = "UPDATE accessories SET accessory_name = @acceName, accessory_type = @acceType, accessory_brand = @acceBrand, accessory_price = @accePrice
               WHERE accessory_id = @acceID"

        dbcomm = New MySqlCommand(sql, conn)

        dbcomm.Parameters.AddWithValue("@acceName", txtName.Text)
        dbcomm.Parameters.AddWithValue("@acceType", typeID)
        dbcomm.Parameters.AddWithValue("@acceBrand", brandID)
        dbcomm.Parameters.AddWithValue("@accePrice", txtPrice.Text)
        dbcomm.Parameters.AddWithValue("@acceID", lblAccessoryID.Text)

        Dim i As Integer = dbcomm.ExecuteNonQuery

        If i > 0 Then
            MsgBox(i.ToString + "Data saved")

        Else
            MsgBox("Data save failed")
        End If


        conn.Close()

        Call AccessoriesCRUD_Load(sender, e)
    End Sub

    Private Sub cmdDeletep_Click(sender As Object, e As EventArgs) Handles cmdDeletep.Click
        checkOpen()

        sql = "DELETE FROM accessories WHERE accessory_id = " & lblAccessoryID.Text

        dbcomm = New MySqlCommand(sql, conn)

        Dim i As Integer = dbcomm.ExecuteNonQuery

        If i > 0 Then
            MsgBox("Data Deleted")

        Else
            MsgBox("Data not Deleted")
        End If

        conn.Close()


        clear_text()


        Call AccessoriesCRUD_Load(sender, e)

    End Sub


End Class