Imports MySql.Data.MySqlClient
Public Class MechAccCreate

    Private Sub MechAccCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdCreate_Click(sender As Object, e As EventArgs) Handles cmdCreate.Click

        If txtPass.Text = txtComfirm.Text Then
            checkOpen()

            sql = "INSERT INTO accounts(account_user, account_pass, account_type) VALUES (@user, md5(@pass), 'mechanic')"

            dbcomm = New MySqlCommand(sql, conn)

            dbcomm.Parameters.AddWithValue("@user", txtUser.Text)
            dbcomm.Parameters.AddWithValue("@pass", txtPass.Text)

            Dim i As Integer = dbcomm.ExecuteNonQuery

            If i > 0 Then
                MsgBox("Data saved")

            Else
                MsgBox("Data save failed")
            End If



            Dim accountID As Integer = getLastID()

            sql1 = "INSERT INTO mechanics(mechanic_name, account_id, mechanic_balance) VALUES (@mechName, @accID, 1000)"

            dbcomm = New MySqlCommand(sql1, conn)

            dbcomm.Parameters.AddWithValue("@mechName", txtName.Text)
            dbcomm.Parameters.AddWithValue("@accID", accountID)


            Dim j As Integer = dbcomm.ExecuteNonQuery

            If j > 0 Then
                MsgBox("Data saved")

            Else
                MsgBox("Data save failed")
            End If

            conn.Close()



        Else
            MsgBox("Passwords doesnt match")
            txtPass.Clear()
            txtComfirm.Clear()
            txtUser.Clear()

        End If

        Call MechAccCreate_Load(sender, e)
    End Sub

    Private Function getLastID()

        Dim lastID As Integer

        sql = "SELECT MAX(account_id) FROM accounts"

        dbcomm = New MySqlCommand(sql, conn)

        dbread = dbcomm.ExecuteReader

        dbread.Read()
        lastID = dbread(0)

        dbread.Dispose()
        Return lastID

    End Function



End Class