Imports MySql.Data.MySqlClient
Public Class LogIn
    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub lkCreateMech_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lkCreateMech.LinkClicked
        Dim meCreate As New MechAccCreate

        meCreate.Show()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click

        If Trim(txtUser.Text) = "" Or Trim(txtPass.Text) = "" Then
            MsgBox("Please Enter Both Fields!", vbInformation, "Note")
        Else

            checkOpen()

            Dim sql = "SELECT * FROM accounts WHERE account_user = @accUser AND account_pass = md5(@accPass)"

            dbcomm = New MySqlCommand(sql, conn)
            dbcomm.Parameters.AddWithValue("@accUser", txtUser.Text)
            dbcomm.Parameters.AddWithValue("@accPass", txtPass.Text)

            dbread = dbcomm.ExecuteReader


            Try
                If dbread.Read = False Then

                    MsgBox("Login Failed!", vbCritical, "Note")
                    txtUser.Clear()
                    txtPass.Clear()

                Else
                    lblAccID.Text = dbread("account_id")
                    MsgBox("Login Successful!", vbInformation, "Note")

                    dbread.Dispose()
                    Dim mainForm As New Form1

                    Me.Hide()
                    'mainForm.lblCurrentUser.Text = usName(0)
                    mainForm.ShowDialog()

                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            dbread.Dispose()

            conn.Close()

        End If
    End Sub


    Private Sub lkCreateOwner_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lkCreateOwner.LinkClicked
        Dim ownCreate As New OwnerAccCreate

        ownCreate.Show()
    End Sub








#Region " Move Form "

    ' [ Move Form ]
    '
    ' // By Elektro 

    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub


#End Region






End Class