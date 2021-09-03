Imports MySql.Data.MySqlClient
Public Class OwnerAccCreate
    Private Sub OwnerAccCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub cmdCreate_Click(sender As Object, e As EventArgs) Handles cmdCreate.Click
        If txtPass.Text = txtComfirm.Text Then
            checkOpen()

            sql = "INSERT INTO accounts(account_user, account_pass, account_type) VALUES (@user, md5(@pass), 'owner')"

            dbcomm = New MySqlCommand(sql, conn)

            dbcomm.Parameters.AddWithValue("@user", txtUser.Text)
            dbcomm.Parameters.AddWithValue("@pass", txtPass.Text)

            Dim i As Integer = dbcomm.ExecuteNonQuery

            If i > 0 Then
                MsgBox("Account Successfully Created")

            Else
                MsgBox("Account creation failed")
            End If



            Dim accountID As Integer = getLastID()

            sql1 = "INSERT INTO ownerlist(owner_name, account_id) VALUES (@ownerName, @accID)"

            dbcomm = New MySqlCommand(sql1, conn)

            dbcomm.Parameters.AddWithValue("@ownerName", txtName.Text)
            dbcomm.Parameters.AddWithValue("@accID", accountID)


            Dim j As Integer = dbcomm.ExecuteNonQuery

            If j > 0 Then
                MsgBox("Name and Account Successfully Saved")

            Else
                MsgBox("Name and Account failed saving")
            End If

            conn.Close()

            Me.Close()

        Else
            MsgBox("Passwords doesnt match")
            txtPass.Clear()
            txtComfirm.Clear()
            txtUser.Clear()

        End If


    End Sub
End Class