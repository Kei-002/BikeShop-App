Imports MySql.Data.MySqlClient
Public Class Accessories

    Private Sub cmdModAcce_Click(sender As Object, e As EventArgs) Handles cmdModAcce.Click
        Dim acceCrud As New AccessoriesCRUD
        acceCrud.ShowDialog()
        Call Accessories_Load(sender, e)
    End Sub



    Private Sub Accessories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkOpen()

        ds = New DataSet
        cmbTypes.Items.Clear()

        'Loading products to datagrid
        sql = "SELECT a.accessory_id as AccessoryID, accessory_name as Name, accessory_type_name as Type, brand_name as Brand, accessory_price as Price
               FROM accessories a, accessory_types at, brands b
               WHERE a.accessory_type = at.accessory_type_id AND a.accessory_brand = b.brand_id
               GROUP BY AccessoryID"

        DataAdapter1 = New MySqlDataAdapter(sql, conn)
        DataAdapter1.Fill(ds, "AllAcces")
        dgAcce.DataSource = ds.Tables("AllAcces")
        DataAdapter1.Dispose()



        'Loading accessory types to combobox
        sql1 = "SELECT * FROM accessory_types"

        dbcomm = New MySqlCommand(sql1, conn)

        dbread = dbcomm.ExecuteReader

        While dbread.Read
            cmbTypes.Items.Add(dbread(1))
        End While
        dbread.Dispose()




        cmbTypes.SelectedItem = 0

        conn.Close()

        dgAcce.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub

    'Filter datagrid through search box
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        checkOpen()
        dt = New DataTable

        sql = "SELECT a.accessory_id as AccessoryID, accessory_name as Name, accessory_type_name as Type, brand_name as Brand, accessory_price as Price
               FROM accessories a, accessory_types at, brands b
               WHERE a.accessory_type = at.accessory_type_id AND a.accessory_brand = b.brand_id AND accessory_name like '%" & txtSearch.Text & "%'
               GROUP BY AccessoryID"

        DataAdapter1 = New MySqlDataAdapter(sql, conn)

        DataAdapter1.Fill(dt)

        dgAcce.DataSource = dt

        DataAdapter1.Dispose()
        conn.Close()
    End Sub

    'Filter datagrid through combobox
    Private Sub cmbTypes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTypes.SelectedIndexChanged
        checkOpen()
        dt = New DataTable

        sql = "SELECT a.accessory_id as AccessoryID, accessory_name as Name, accessory_type_name as Type, brand_name as Brand, accessory_price as Price
               FROM accessories a, accessory_types at, brands b
               WHERE a.accessory_type = at.accessory_type_id AND a.accessory_brand = b.brand_id AND accessory_type_name like '%" & cmbTypes.SelectedItem & "%'
               GROUP BY AccessoryID"

        DataAdapter1 = New MySqlDataAdapter(sql, conn)

        DataAdapter1.Fill(dt)

        dgAcce.DataSource = dt

        DataAdapter1.Dispose()
        conn.Close()

    End Sub


End Class