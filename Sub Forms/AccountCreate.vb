Imports MySql.Data.MySqlClient
Public Class AccountCreate
    Private Sub cmdCreate_Click(sender As Object, e As EventArgs) Handles cmdCreate.Click
        checkOpen()

        If txtPass.Text = txtConfirmPass.Text Then

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

            Me.Close()
        Else
            MsgBox("Passwords doesnt match")
            txtPass.Clear()
            txtConfirmPass.Clear()
            txtUser.Clear()
        End If
        conn.Close()
    End Sub

    Private Sub AccountCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class