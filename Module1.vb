Imports MySql.Data.MySqlClient
Module Module1
    Public conn As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=bikeDB;User=root;Password=;")
    Public dbconn As New MySqlConnection
    Public sql, sql1, sql2, sql3 As String
    Public dbcomm As MySqlCommand
    Public dbread, dbread1 As MySqlDataReader
    Public DataAdapter1, DataAdapter2 As MySqlDataAdapter
    Public ds As DataSet
    Public dt As DataTable
    Public id As Integer



    Public Sub checkOpen()
        If conn.State = ConnectionState.Closed Then

            conn.Open()

        End If
    End Sub
End Module
