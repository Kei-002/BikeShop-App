Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class Form1

    Dim currentChildForm As Form

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkOpen()

        Dim accID As Integer = LogIn.lblAccID.Text

        lblCurrentUser.Text = accID

        'gets the account type of the logged in account
        sql = "SELECT account_type FROM accounts WHERE account_id = @aID"

        dbcomm = New MySqlCommand(sql, conn)
        dbcomm.Parameters.AddWithValue("@aID", accID)

        dbread = dbcomm.ExecuteReader

        dbread.Read()
        Dim accType As String = dbread("account_type")
        dbread.Dispose()

        'If the account type is an owner, the sql is set to access ownerlist
        If accType = "owner" Then
            sql1 = "SELECT owner_name FROM ownerlist WHERE account_id = @aID"
        Else
            sql1 = "SELECT mechanic_name FROM mechanics WHERE  account_id = @aID"
        End If

        dbcomm = New MySqlCommand(sql1, conn)
        dbcomm.Parameters.AddWithValue("@aID", accID)

        dbread = dbcomm.ExecuteReader
        dbread.Read()

        Dim fullName As String = dbread(0)
        lblName.Text = fullName

        Dim usName() As String = fullName.Split(" ")

        lblCurrentUser.Text = usName(0)

        lblAccType.Text = accType

        dbread.Dispose()
        conn.Close()

        openChildForm(New Dashboard)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim accType As String = lblAccType.Text

        If accType = "mechanic" Then
            Profile.Show()

        End If

    End Sub




    Private Sub openChildForm(childForm As Form)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If

        currentChildForm = childForm


        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        PanelMain.Controls.Add(childForm)

        childForm.BringToFront()
        childForm.Show()

    End Sub


    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim exit_app As String = MsgBox("Exit application?", vbQuestion + vbYesNo, "Exit")
        If exit_app = vbNo Then
            e.Cancel = True
        Else
            End
        End If
    End Sub

    Private Sub cmdView_Click(sender As Object, e As EventArgs) Handles cmdView.Click



        If lblAccType.Text = "owner" Then
            Dim ownProfile As New OwnerProfile
            ownProfile.ShowDialog()

        Else
            Dim meProfile As New Profile
            meProfile.ShowDialog()
        End If


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

    Private Sub cmdBuy_Click(sender As Object, e As EventArgs) Handles cmdBuy.Click
        openChildForm(New Products)
    End Sub

    Private Sub cmdAccessories_Click(sender As Object, e As EventArgs) Handles cmdAccessories.Click
        openChildForm(New Accessories)
    End Sub


    Private Sub cmdSettings_Click(sender As Object, e As EventArgs) Handles cmdSuppliers.Click
        openChildForm(New Suppliers)
    End Sub

    Private Sub cmdServices_Click(sender As Object, e As EventArgs) Handles cmdServices.Click
        openChildForm(New Services)
    End Sub

    Private Sub cmdCustomer_Click(sender As Object, e As EventArgs) Handles cmdCustomer.Click
        openChildForm(New Customers)
    End Sub

    Private Sub cmdMechanics_Click(sender As Object, e As EventArgs) Handles cmdMechanics.Click
        openChildForm(New Mechanics)
    End Sub

    Private Sub cmdBrands_Click(sender As Object, e As EventArgs) Handles cmdBrands.Click
        openChildForm(New Brands)
    End Sub

    Private Sub cmdHome_Click(sender As Object, e As EventArgs) Handles cmdHome.Click
        openChildForm(New Dashboard)
    End Sub
End Class
