Imports MySql.Data.MySqlClient

Public Class OwnerProfile
    Private Sub OwnerProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkOpen()

        Dim ownerID As Integer = getOwnerID(LogIn.lblAccID.Text)

        sql = "SELECT owner_name FROM ownerlist WHERE owner_id = @ownID"
        dbcomm = New MySqlCommand(sql, conn)
        dbcomm.Parameters.AddWithValue("@ownID", ownerID)

        dbread = dbcomm.ExecuteReader


        If dbread.Read = False Then
            MsgBox("noData")
        Else
            txtName.Text = dbread(0)
        End If

        dbread.Dispose()
        conn.Close()

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If MsgBox("Do you want to log off?", MsgBoxStyle.YesNo Or
MsgBoxStyle.DefaultButton2, "Quit?") = Windows.Forms.DialogResult.Yes Then

            Application.Restart()

        Else

            'Application.Restart()
        End If
    End Sub


    Private Function getOwnerID(ByVal accID As Integer) As Integer


        Dim mID As Integer

        sql = "SELECT owner_id FROM ownerlist WHERE account_id = @aID"

        dbcomm = New MySqlCommand(sql, conn)

        dbcomm.Parameters.AddWithValue("@aID", accID)

        dbread1 = dbcomm.ExecuteReader

        If dbread1.Read = False Then
            MsgBox("No data")
        Else
            mID = dbread1(0)
        End If

        dbread1.Dispose()

        Return mID

    End Function
End Class