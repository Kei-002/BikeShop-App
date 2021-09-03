<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccessoriesCRUD
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgItem = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbBrands = New System.Windows.Forms.ComboBox()
        Me.cmbItemType = New System.Windows.Forms.ComboBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbTypes = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblAccessoryID = New System.Windows.Forms.Label()
        Me.lblBrands = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdDeletep = New FontAwesome.Sharp.IconButton()
        Me.cmdUpdatep = New FontAwesome.Sharp.IconButton()
        Me.cmdAddp = New FontAwesome.Sharp.IconButton()
        CType(Me.dgItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgItem
        '
        Me.dgItem.AllowUserToAddRows = False
        Me.dgItem.AllowUserToDeleteRows = False
        Me.dgItem.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dgItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Noto Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(78, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgItem.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgItem.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dgItem.Location = New System.Drawing.Point(12, 138)
        Me.dgItem.Name = "dgItem"
        Me.dgItem.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Comfortaa", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgItem.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgItem.Size = New System.Drawing.Size(604, 400)
        Me.dgItem.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cmbBrands)
        Me.Panel1.Controls.Add(Me.cmbItemType)
        Me.Panel1.Controls.Add(Me.cmdDeletep)
        Me.Panel1.Controls.Add(Me.cmdUpdatep)
        Me.Panel1.Controls.Add(Me.cmdAddp)
        Me.Panel1.Controls.Add(Me.txtPrice)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(625, 138)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(180, 400)
        Me.Panel1.TabIndex = 1
        '
        'cmbBrands
        '
        Me.cmbBrands.FormattingEnabled = True
        Me.cmbBrands.Location = New System.Drawing.Point(66, 143)
        Me.cmbBrands.Name = "cmbBrands"
        Me.cmbBrands.Size = New System.Drawing.Size(100, 21)
        Me.cmbBrands.TabIndex = 8
        '
        'cmbItemType
        '
        Me.cmbItemType.FormattingEnabled = True
        Me.cmbItemType.Location = New System.Drawing.Point(66, 108)
        Me.cmbItemType.Name = "cmbItemType"
        Me.cmbItemType.Size = New System.Drawing.Size(100, 21)
        Me.cmbItemType.TabIndex = 9
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(66, 179)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comfortaa", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(10, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comfortaa", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(10, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Brand"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comfortaa", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(10, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Type"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(66, 72)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comfortaa", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(10, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Hiruko", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(16, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Accessory Info"
        '
        'cmbTypes
        '
        Me.cmbTypes.FormattingEnabled = True
        Me.cmbTypes.Location = New System.Drawing.Point(12, 111)
        Me.cmbTypes.Name = "cmbTypes"
        Me.cmbTypes.Size = New System.Drawing.Size(121, 21)
        Me.cmbTypes.TabIndex = 4
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(516, 112)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 5
        '
        'lblAccessoryID
        '
        Me.lblAccessoryID.AutoSize = True
        Me.lblAccessoryID.Location = New System.Drawing.Point(830, 178)
        Me.lblAccessoryID.Name = "lblAccessoryID"
        Me.lblAccessoryID.Size = New System.Drawing.Size(67, 13)
        Me.lblAccessoryID.TabIndex = 6
        Me.lblAccessoryID.Text = "AccessoryID"
        '
        'lblBrands
        '
        Me.lblBrands.AutoSize = True
        Me.lblBrands.Location = New System.Drawing.Point(830, 254)
        Me.lblBrands.Name = "lblBrands"
        Me.lblBrands.Size = New System.Drawing.Size(46, 13)
        Me.lblBrands.TabIndex = 6
        Me.lblBrands.Text = "BrandID"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(12, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(793, 92)
        Me.Panel2.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Hiruko", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(14, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(248, 36)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Modify Accessory"
        '
        'cmdDeletep
        '
        Me.cmdDeletep.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.cmdDeletep.FlatAppearance.BorderSize = 0
        Me.cmdDeletep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDeletep.Font = New System.Drawing.Font("Noto Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDeletep.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdDeletep.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.cmdDeletep.IconColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdDeletep.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cmdDeletep.IconSize = 30
        Me.cmdDeletep.Location = New System.Drawing.Point(-3, 342)
        Me.cmdDeletep.Name = "cmdDeletep"
        Me.cmdDeletep.Size = New System.Drawing.Size(183, 52)
        Me.cmdDeletep.TabIndex = 5
        Me.cmdDeletep.Text = "Delete"
        Me.cmdDeletep.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdDeletep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdDeletep.UseVisualStyleBackColor = False
        '
        'cmdUpdatep
        '
        Me.cmdUpdatep.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.cmdUpdatep.FlatAppearance.BorderSize = 0
        Me.cmdUpdatep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdUpdatep.Font = New System.Drawing.Font("Noto Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdatep.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdUpdatep.IconChar = FontAwesome.Sharp.IconChar.SyncAlt
        Me.cmdUpdatep.IconColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdUpdatep.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cmdUpdatep.IconSize = 30
        Me.cmdUpdatep.Location = New System.Drawing.Point(-3, 284)
        Me.cmdUpdatep.Name = "cmdUpdatep"
        Me.cmdUpdatep.Size = New System.Drawing.Size(183, 52)
        Me.cmdUpdatep.TabIndex = 6
        Me.cmdUpdatep.Text = "Update"
        Me.cmdUpdatep.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdUpdatep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdUpdatep.UseVisualStyleBackColor = False
        '
        'cmdAddp
        '
        Me.cmdAddp.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.cmdAddp.FlatAppearance.BorderSize = 0
        Me.cmdAddp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAddp.Font = New System.Drawing.Font("Noto Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdAddp.IconChar = FontAwesome.Sharp.IconChar.PlusSquare
        Me.cmdAddp.IconColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdAddp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cmdAddp.IconSize = 30
        Me.cmdAddp.Location = New System.Drawing.Point(-3, 226)
        Me.cmdAddp.Name = "cmdAddp"
        Me.cmdAddp.Size = New System.Drawing.Size(183, 52)
        Me.cmdAddp.TabIndex = 7
        Me.cmdAddp.Text = "Add"
        Me.cmdAddp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdAddp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAddp.UseVisualStyleBackColor = False
        '
        'AccessoriesCRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(811, 543)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblBrands)
        Me.Controls.Add(Me.lblAccessoryID)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmbTypes)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgItem)
        Me.Name = "AccessoriesCRUD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AccessoriesCRUD"
        CType(Me.dgItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgItem As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdDeletep As FontAwesome.Sharp.IconButton
    Friend WithEvents cmdUpdatep As FontAwesome.Sharp.IconButton
    Friend WithEvents cmdAddp As FontAwesome.Sharp.IconButton
    Friend WithEvents cmbBrands As ComboBox
    Friend WithEvents cmbItemType As ComboBox
    Friend WithEvents cmbTypes As ComboBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblAccessoryID As Label
    Friend WithEvents lblBrands As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
End Class
