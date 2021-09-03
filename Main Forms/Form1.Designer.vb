<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PanelSide = New System.Windows.Forms.Panel()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAccType = New System.Windows.Forms.Label()
        Me.lblSuppID = New System.Windows.Forms.Label()
        Me.lblServName = New System.Windows.Forms.Label()
        Me.lblSavedID = New System.Windows.Forms.Label()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCurrentUser = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdHome = New FontAwesome.Sharp.IconButton()
        Me.cmdBrands = New FontAwesome.Sharp.IconButton()
        Me.cmdMechanics = New FontAwesome.Sharp.IconButton()
        Me.cmdSuppliers = New FontAwesome.Sharp.IconButton()
        Me.cmdCustomer = New FontAwesome.Sharp.IconButton()
        Me.cmdServices = New FontAwesome.Sharp.IconButton()
        Me.cmdAccessories = New FontAwesome.Sharp.IconButton()
        Me.cmdBuy = New FontAwesome.Sharp.IconButton()
        Me.cmdView = New FontAwesome.Sharp.IconButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblSavedMechID = New System.Windows.Forms.Label()
        Me.PanelSide.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSide
        '
        Me.PanelSide.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelSide.Controls.Add(Me.lblSavedMechID)
        Me.PanelSide.Controls.Add(Me.lblName)
        Me.PanelSide.Controls.Add(Me.lblAccType)
        Me.PanelSide.Controls.Add(Me.cmdBrands)
        Me.PanelSide.Controls.Add(Me.lblSuppID)
        Me.PanelSide.Controls.Add(Me.lblServName)
        Me.PanelSide.Controls.Add(Me.lblSavedID)
        Me.PanelSide.Controls.Add(Me.cmdMechanics)
        Me.PanelSide.Controls.Add(Me.cmdSuppliers)
        Me.PanelSide.Controls.Add(Me.cmdCustomer)
        Me.PanelSide.Controls.Add(Me.cmdServices)
        Me.PanelSide.Controls.Add(Me.cmdAccessories)
        Me.PanelSide.Controls.Add(Me.cmdBuy)
        Me.PanelSide.Controls.Add(Me.PanelLogo)
        Me.PanelSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSide.Location = New System.Drawing.Point(0, 0)
        Me.PanelSide.Name = "PanelSide"
        Me.PanelSide.Size = New System.Drawing.Size(160, 589)
        Me.PanelSide.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 604)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(39, 13)
        Me.lblName.TabIndex = 14
        Me.lblName.Text = "Label3"
        '
        'lblAccType
        '
        Me.lblAccType.AutoSize = True
        Me.lblAccType.Location = New System.Drawing.Point(63, 656)
        Me.lblAccType.Name = "lblAccType"
        Me.lblAccType.Size = New System.Drawing.Size(39, 13)
        Me.lblAccType.TabIndex = 13
        Me.lblAccType.Text = "Label3"
        '
        'lblSuppID
        '
        Me.lblSuppID.AutoSize = True
        Me.lblSuppID.Location = New System.Drawing.Point(86, 631)
        Me.lblSuppID.Name = "lblSuppID"
        Me.lblSuppID.Size = New System.Drawing.Size(39, 13)
        Me.lblSuppID.TabIndex = 11
        Me.lblSuppID.Text = "Label3"
        '
        'lblServName
        '
        Me.lblServName.AutoSize = True
        Me.lblServName.Location = New System.Drawing.Point(31, 631)
        Me.lblServName.Name = "lblServName"
        Me.lblServName.Size = New System.Drawing.Size(39, 13)
        Me.lblServName.TabIndex = 11
        Me.lblServName.Text = "Label3"
        '
        'lblSavedID
        '
        Me.lblSavedID.AutoSize = True
        Me.lblSavedID.Location = New System.Drawing.Point(63, 604)
        Me.lblSavedID.Name = "lblSavedID"
        Me.lblSavedID.Size = New System.Drawing.Size(13, 13)
        Me.lblSavedID.TabIndex = 10
        Me.lblSavedID.Text = "1"
        Me.lblSavedID.Visible = False
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.Panel1)
        Me.PanelLogo.Controls.Add(Me.Label1)
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(160, 183)
        Me.PanelLogo.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdView)
        Me.Panel1.Controls.Add(Me.lblCurrentUser)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 119)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(160, 64)
        Me.Panel1.TabIndex = 2
        '
        'lblCurrentUser
        '
        Me.lblCurrentUser.AutoSize = True
        Me.lblCurrentUser.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentUser.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCurrentUser.Location = New System.Drawing.Point(90, 4)
        Me.lblCurrentUser.Name = "lblCurrentUser"
        Me.lblCurrentUser.Size = New System.Drawing.Size(45, 21)
        Me.lblCurrentUser.TabIndex = 0
        Me.lblCurrentUser.Text = "User!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(22, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Welcome"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cronus Round", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(48, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BikeBox "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PanelMain
        '
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelMain.Location = New System.Drawing.Point(160, 39)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(830, 550)
        Me.PanelMain.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Moon", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(938, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 25)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdHome
        '
        Me.cmdHome.FlatAppearance.BorderSize = 0
        Me.cmdHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdHome.Font = New System.Drawing.Font("Moon", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmdHome.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.cmdHome.IconColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmdHome.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cmdHome.IconSize = 30
        Me.cmdHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdHome.Location = New System.Drawing.Point(176, 5)
        Me.cmdHome.Name = "cmdHome"
        Me.cmdHome.Size = New System.Drawing.Size(80, 33)
        Me.cmdHome.TabIndex = 4
        Me.cmdHome.Text = "Home"
        Me.cmdHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdHome.UseVisualStyleBackColor = True
        '
        'cmdBrands
        '
        Me.cmdBrands.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdBrands.FlatAppearance.BorderSize = 0
        Me.cmdBrands.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBrands.Font = New System.Drawing.Font("Moon", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBrands.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmdBrands.IconChar = FontAwesome.Sharp.IconChar.Award
        Me.cmdBrands.IconColor = System.Drawing.Color.WhiteSmoke
        Me.cmdBrands.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cmdBrands.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBrands.Location = New System.Drawing.Point(0, 501)
        Me.cmdBrands.Name = "cmdBrands"
        Me.cmdBrands.Size = New System.Drawing.Size(160, 53)
        Me.cmdBrands.TabIndex = 12
        Me.cmdBrands.Text = "Brands"
        Me.cmdBrands.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBrands.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdBrands.UseVisualStyleBackColor = True
        '
        'cmdMechanics
        '
        Me.cmdMechanics.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdMechanics.FlatAppearance.BorderSize = 0
        Me.cmdMechanics.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMechanics.Font = New System.Drawing.Font("Moon", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMechanics.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmdMechanics.IconChar = FontAwesome.Sharp.IconChar.UserCog
        Me.cmdMechanics.IconColor = System.Drawing.Color.WhiteSmoke
        Me.cmdMechanics.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cmdMechanics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdMechanics.Location = New System.Drawing.Point(0, 448)
        Me.cmdMechanics.Name = "cmdMechanics"
        Me.cmdMechanics.Size = New System.Drawing.Size(160, 53)
        Me.cmdMechanics.TabIndex = 9
        Me.cmdMechanics.Text = "Mechanics"
        Me.cmdMechanics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdMechanics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdMechanics.UseVisualStyleBackColor = True
        '
        'cmdSuppliers
        '
        Me.cmdSuppliers.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdSuppliers.FlatAppearance.BorderSize = 0
        Me.cmdSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSuppliers.Font = New System.Drawing.Font("Moon", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSuppliers.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmdSuppliers.IconChar = FontAwesome.Sharp.IconChar.ParachuteBox
        Me.cmdSuppliers.IconColor = System.Drawing.Color.WhiteSmoke
        Me.cmdSuppliers.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cmdSuppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSuppliers.Location = New System.Drawing.Point(0, 395)
        Me.cmdSuppliers.Name = "cmdSuppliers"
        Me.cmdSuppliers.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSuppliers.Size = New System.Drawing.Size(160, 53)
        Me.cmdSuppliers.TabIndex = 8
        Me.cmdSuppliers.Text = "Suppliers"
        Me.cmdSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSuppliers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdSuppliers.UseVisualStyleBackColor = True
        '
        'cmdCustomer
        '
        Me.cmdCustomer.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdCustomer.FlatAppearance.BorderSize = 0
        Me.cmdCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCustomer.Font = New System.Drawing.Font("Moon", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCustomer.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmdCustomer.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.cmdCustomer.IconColor = System.Drawing.Color.WhiteSmoke
        Me.cmdCustomer.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cmdCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCustomer.Location = New System.Drawing.Point(0, 342)
        Me.cmdCustomer.Name = "cmdCustomer"
        Me.cmdCustomer.Size = New System.Drawing.Size(160, 53)
        Me.cmdCustomer.TabIndex = 7
        Me.cmdCustomer.Text = "Customer"
        Me.cmdCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdCustomer.UseVisualStyleBackColor = True
        '
        'cmdServices
        '
        Me.cmdServices.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdServices.FlatAppearance.BorderSize = 0
        Me.cmdServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdServices.Font = New System.Drawing.Font("Moon", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdServices.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmdServices.IconChar = FontAwesome.Sharp.IconChar.Screwdriver
        Me.cmdServices.IconColor = System.Drawing.Color.WhiteSmoke
        Me.cmdServices.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cmdServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdServices.Location = New System.Drawing.Point(0, 289)
        Me.cmdServices.Name = "cmdServices"
        Me.cmdServices.Size = New System.Drawing.Size(160, 53)
        Me.cmdServices.TabIndex = 6
        Me.cmdServices.Text = "Services"
        Me.cmdServices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdServices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdServices.UseVisualStyleBackColor = True
        '
        'cmdAccessories
        '
        Me.cmdAccessories.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdAccessories.FlatAppearance.BorderSize = 0
        Me.cmdAccessories.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAccessories.Font = New System.Drawing.Font("Moon", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAccessories.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmdAccessories.IconChar = FontAwesome.Sharp.IconChar.Tag
        Me.cmdAccessories.IconColor = System.Drawing.Color.WhiteSmoke
        Me.cmdAccessories.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cmdAccessories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAccessories.Location = New System.Drawing.Point(0, 236)
        Me.cmdAccessories.Name = "cmdAccessories"
        Me.cmdAccessories.Size = New System.Drawing.Size(160, 53)
        Me.cmdAccessories.TabIndex = 5
        Me.cmdAccessories.Text = "Accessories"
        Me.cmdAccessories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAccessories.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAccessories.UseVisualStyleBackColor = True
        '
        'cmdBuy
        '
        Me.cmdBuy.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdBuy.FlatAppearance.BorderSize = 0
        Me.cmdBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBuy.Font = New System.Drawing.Font("Moon", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuy.ForeColor = System.Drawing.Color.Gainsboro
        Me.cmdBuy.IconChar = FontAwesome.Sharp.IconChar.Bicycle
        Me.cmdBuy.IconColor = System.Drawing.Color.WhiteSmoke
        Me.cmdBuy.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cmdBuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBuy.Location = New System.Drawing.Point(0, 183)
        Me.cmdBuy.Name = "cmdBuy"
        Me.cmdBuy.Size = New System.Drawing.Size(160, 53)
        Me.cmdBuy.TabIndex = 4
        Me.cmdBuy.Text = "Products"
        Me.cmdBuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdBuy.UseVisualStyleBackColor = True
        '
        'cmdView
        '
        Me.cmdView.FlatAppearance.BorderSize = 0
        Me.cmdView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdView.Font = New System.Drawing.Font("Moon", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdView.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cmdView.IconChar = FontAwesome.Sharp.IconChar.Eye
        Me.cmdView.IconColor = System.Drawing.Color.White
        Me.cmdView.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cmdView.IconSize = 20
        Me.cmdView.Location = New System.Drawing.Point(1, 29)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(160, 35)
        Me.cmdView.TabIndex = 1
        Me.cmdView.Text = "View Profile"
        Me.cmdView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdView.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(34, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(91, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblSavedMechID
        '
        Me.lblSavedMechID.AutoSize = True
        Me.lblSavedMechID.Location = New System.Drawing.Point(96, 604)
        Me.lblSavedMechID.Name = "lblSavedMechID"
        Me.lblSavedMechID.Size = New System.Drawing.Size(39, 13)
        Me.lblSavedMechID.TabIndex = 0
        Me.lblSavedMechID.Text = "Label3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(990, 589)
        Me.Controls.Add(Me.cmdHome)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.PanelSide)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(990, 628)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BikeBox"
        Me.PanelSide.ResumeLayout(False)
        Me.PanelSide.PerformLayout()
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelLogo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSide As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PanelMain As Panel
    Friend WithEvents cmdAccessories As FontAwesome.Sharp.IconButton
    Friend WithEvents cmdBuy As FontAwesome.Sharp.IconButton
    Friend WithEvents Button1 As Button
    Friend WithEvents cmdSuppliers As FontAwesome.Sharp.IconButton
    Friend WithEvents cmdCustomer As FontAwesome.Sharp.IconButton
    Friend WithEvents cmdServices As FontAwesome.Sharp.IconButton
    Friend WithEvents cmdHome As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCurrentUser As Label
    Friend WithEvents cmdView As FontAwesome.Sharp.IconButton
    Friend WithEvents cmdMechanics As FontAwesome.Sharp.IconButton
    Friend WithEvents lblSavedID As Label
    Friend WithEvents lblServName As Label
    Friend WithEvents cmdBrands As FontAwesome.Sharp.IconButton
    Friend WithEvents lblSuppID As Label
    Friend WithEvents lblAccType As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblSavedMechID As Label
End Class
