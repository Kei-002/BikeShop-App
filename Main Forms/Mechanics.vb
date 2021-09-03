Imports MySql.Data.MySqlClient
Public Class Mechanics
    Private Sub Mechanics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkOpen()
        ds = New DataSet

        'Filling datagrid with customer infos
        sql = "SELECT mechanic_id as MechID, mechanic_name as Name, mechanic_balance as Balance
               FROM mechanics"

        DataAdapter1 = New MySqlDataAdapter(sql, conn)

        DataAdapter1.Fill(ds, "AllMech")


        dgMech.DataSource = ds.Tables("AllMech")

        DataAdapter1.Dispose()

        conn.Close()

        dgMech.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub



    Private Sub cmdModMech_Click(sender As Object, e As EventArgs) Handles cmdModMech.Click

        Dim mechCrud As New MechanicCrud

        mechCrud.ShowDialog()
        Call Mechanics_Load(sender, e)
    End Sub



    'Filtering datagrid by tsearch
    Private Sub txtTypeFilter_TextChanged(sender As Object, e As EventArgs) Handles txtTypeFilter.TextChanged

        checkOpen()
        dt = New DataTable

        sql = "SELECT mechanic_id as MechID, mechanic_name as Name, mechanic_balance as Balance
               FROM mechanics WHERE mechanic_name like '%" & txtTypeFilter.Text & "%'"

        DataAdapter1 = New MySqlDataAdapter(sql, conn)

        DataAdapter1.Fill(dt)

        dgMech.DataSource = dt

        DataAdapter1.Dispose()
        conn.Close()

    End Sub




    Private Sub cmdViewMech_Click(sender As Object, e As EventArgs) Handles cmdViewMech.Click
        Dim viewHistory As New MechServiceHistory
        Form1.lblSavedMechID.Text = Me.dgMech.CurrentRow.Cells("MechID").Value
        viewHistory.Show()
    End Sub
End Class