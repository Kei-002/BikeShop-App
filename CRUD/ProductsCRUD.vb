Imports MySql.Data.MySqlClient
Public Class ProductsCRUD
    Private Sub ProductsCRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkOpen()


        ds = New DataSet
        cmbTypes.Items.Clear()
        cmbItemType.Items.Clear()
        cmbBrands.Items.Clear()


        'Loading products to datagrid
        sql = "SELECT p.product_id as ProductID, product_desc as Name, type_desc as Type, brand_name as Brand,product_price as Price
               FROM products p, producttype pt, brands b, multibrand mb
               WHERE p.type_id = pt.type_id AND b.brand_id = mb.brand_id AND mb.product_id = p.product_id
               GROUP BY ProductID"


        DataAdapter1 = New MySqlDataAdapter(sql, conn)

        DataAdapter1.Fill(ds, "AllProducts")

        dgList.DataSource = ds.Tables("AllProducts")

        DataAdapter1.Dispose()



        'Loading categories(producttype) to cmbTypes and cmbItemType
        sql1 = "SELECT * FROM producttype"

        dbcomm = New MySqlCommand(sql1, conn)

        dbread = dbcomm.ExecuteReader


        While dbread.Read
            cmbTypes.Items.Add(dbread(1))
            cmbItemType.Items.Add(dbread(1))
        End While

        dbread.Dispose()


        DataAdapter1 = New MySqlDataAdapter(sql1, conn)
        ds = New DataSet("tblProdType")
        DataAdapter1.Fill(ds, "tblProdType")

        DataAdapter1.Dispose()



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

        clear_text()
        conn.Close()


        dgList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub


    'Searching product in datagrid
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        checkOpen()
        dt = New DataTable

        sql = "SELECT p.product_id as ProductID, product_desc as Name, type_desc as Type, brand_name as Brand,product_price as Price
               FROM products p, producttype pt, brands b, multibrand mb
               WHERE p.type_id = pt.type_id AND b.brand_id = mb.brand_id AND mb.product_id = p.product_id AND product_desc Like '%" & txtSearch.Text & "%'
               GROUP BY ProductID"

        DataAdapter1 = New MySqlDataAdapter(sql, conn)

        DataAdapter1.Fill(dt)

        dgList.DataSource = dt

        DataAdapter1.Dispose()
        conn.Close()

    End Sub


    'Filtering products through combobox
    Private Sub cmbTypes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTypes.SelectedIndexChanged
        checkOpen()
        dt = New DataTable

        sql = "SELECT p.product_id as ProductID, product_desc as Name, type_desc as Type, brand_name as Brand,product_price as Price
               FROM products p, producttype pt, brands b, multibrand mb
               WHERE p.type_id = pt.type_id AND b.brand_id = mb.brand_id AND mb.product_id = p.product_id AND type_desc Like '%" & cmbTypes.SelectedItem & "%'
               GROUP BY ProductID"

        DataAdapter1 = New MySqlDataAdapter(sql, conn)

        DataAdapter1.Fill(dt)

        dgList.DataSource = dt

        DataAdapter1.Dispose()
        conn.Close()

    End Sub


    'Getting the TypeId
    Private Function getLastProdID()

        Dim lastID As Integer

        sql = "SELECT MAX(product_id) FROM products"

        dbcomm = New MySqlCommand(sql, conn)

        dbread = dbcomm.ExecuteReader

        dbread.Read()
        lastID = dbread(0)

        dbread.Dispose()
        Return lastID

    End Function


    'Sets the text boxes to the selected item in datagird
    Private Sub dgList_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgList.MouseDoubleClick
        lblProdID.Text = Me.dgList.CurrentRow.Cells("ProductID").Value
        txtProdName.Text = Me.dgList.CurrentRow.Cells("Name").Value
        cmbItemType.SelectedItem = Me.dgList.CurrentRow.Cells("Type").Value
        cmbBrands.SelectedItem = Me.dgList.CurrentRow.Cells("Brand").Value
        txtProdPrice.Text = Me.dgList.CurrentRow.Cells("Price").Value

        Dim i As Integer

        i = cmbBrands.SelectedIndex

        lblPrevBrand.Text = ds.Tables("tblBrands").Rows(i).Item("brand_id")

    End Sub



    Public Sub clear_text()

        txtProdName.Clear()
        txtProdPrice.Clear()

        cmbItemType.SelectedItem = -1
        cmbBrands.SelectedIndex = -1
        cmbItemType.SelectedIndex = -1
    End Sub


    Private Function getTypeID(ByVal typeName As String)
        Dim typeID As Integer

        sql = "SELECT type_id FROM producttype WHERE type_desc = @typeName"

        dbcomm = New MySqlCommand(sql, conn)

        dbcomm.Parameters.AddWithValue("@typeName", typeName)
        dbread = dbcomm.ExecuteReader

        dbread.Read()
        typeID = dbread(0)
        dbread.Dispose()

        Return typeID
    End Function


    Private Function getBrandID(ByVal brandName As String)
        Dim brandID As Integer


        sql = "SELECT brand_id FROM brands WHERE brand_name = @bName"

        dbcomm = New MySqlCommand(sql, conn)

        dbcomm.Parameters.AddWithValue("@bName", brandName)
        dbread = dbcomm.ExecuteReader

        dbread.Read()
        brandID = dbread(0)
        dbread.Dispose()

        Return brandID

    End Function


    'CRUD commands
    Private Sub cmdAddp_Click(sender As Object, e As EventArgs) Handles cmdAddp.Click
        checkOpen()

        Dim prodType As Integer = getTypeID(cmbItemType.SelectedItem)
        'Insert to products
        sql = "INSERT INTO products(product_desc, type_id, product_price) VALUES (@prodName, @prodType, @prodPrice)"

        dbcomm = New MySqlCommand(sql, conn)

        dbcomm.Parameters.AddWithValue("@prodName", txtProdName.Text)
        dbcomm.Parameters.AddWithValue("@prodType", prodType)
        dbcomm.Parameters.AddWithValue("@prodPrice", txtProdPrice.Text)

        Dim i As Integer = dbcomm.ExecuteNonQuery

        If i > 0 Then
            MsgBox("Data saved")

        Else
            MsgBox("Data save failed")
        End If

        dbcomm.Dispose()
        'End of product insert


        Dim pID As Integer = getLastProdID()


        Dim bID As Integer = getBrandID(cmbBrands.SelectedItem)

        'Insert to multibrand
        sql = "INSERT INTO multibrand(product_id, brand_id)
               VALUES (@prodID, @brandID)" ' (SELECT b.brand_id FROM brands b WHERE brand_name = @brandName)

        dbcomm = New MySqlCommand(sql, conn)

        dbcomm.Parameters.AddWithValue("@prodID", pID)
        dbcomm.Parameters.AddWithValue("@brandID", bID)

        Dim j As Integer = dbcomm.ExecuteNonQuery

        If j > 0 Then
            MsgBox("brand save success")

        Else
            MsgBox("fail")
        End If

        dbcomm.Dispose()
        'End of multibrand insert

        conn.Close()

        Call ProductsCRUD_Load(sender, e)
    End Sub

    Private Sub cmdUpdatep_Click(sender As Object, e As EventArgs) Handles cmdUpdatep.Click
        checkOpen()

        Dim prodType As Integer = getTypeID(cmbItemType.SelectedItem)
        'Update product details
        sql = "UPDATE products SET product_desc = @prodName, type_id = @prodType, product_price = @prodPrice
              WHERE product_id = @prodID"

        dbcomm = New MySqlCommand(sql, conn)

        dbcomm.Parameters.AddWithValue("@prodName", txtProdName.Text)
        dbcomm.Parameters.AddWithValue("@prodType", prodType)
        dbcomm.Parameters.AddWithValue("@prodPrice", txtProdPrice.Text)
        dbcomm.Parameters.AddWithValue("@prodID", CInt(lblProdID.Text))

        Dim i As Integer = dbcomm.ExecuteNonQuery

        If i > 0 Then
            MsgBox(i.ToString + "Data saved")

        Else
            MsgBox("Data save failed")
        End If


        sql = "UPDATE multibrand
               SET multibrand.brand_id= (SELECT b.brand_id from brands b WHERE brand_name = @brandName)
               WHERE product_id = @prodID AND brand_id = @PrevBrandID;"

        dbcomm = New MySqlCommand(sql, conn)

        dbcomm.Parameters.AddWithValue("@prodID", CInt(lblProdID.Text))
        dbcomm.Parameters.AddWithValue("@PrevBrandID", CInt(lblPrevBrand.Text))
        dbcomm.Parameters.AddWithValue("@brandName", cmbBrands.SelectedItem)

        lblBrandID.Text = sql

        Dim j As Integer = dbcomm.ExecuteNonQuery

        If j > 0 Then
            MsgBox("brand save success")

        Else
            MsgBox("fail")
        End If

        dbcomm.Dispose()
        conn.Close()

        Call ProductsCRUD_Load(sender, e)
    End Sub

    Private Sub cmdDeletep_Click(sender As Object, e As EventArgs) Handles cmdDeletep.Click
        checkOpen()

        sql = "DELETE FROM products WHERE product_id = " & lblProdID.Text

        dbcomm = New MySqlCommand(sql, conn)

        Dim i As Integer = dbcomm.ExecuteNonQuery

        If i > 0 Then
            MsgBox("Data Deleted")

        Else
            MsgBox("Data not Deleted")
        End If

        conn.Close()
        Call ProductsCRUD_Load(sender, e)

    End Sub


End Class