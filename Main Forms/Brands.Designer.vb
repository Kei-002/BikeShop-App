<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Brands
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblMechID = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdDeletep = New FontAwesome.Sharp.IconButton()
        Me.cmdUpdatep = New FontAwesome.Sharp.IconButton()
        Me.cmdAddp = New FontAwesome.Sharp.IconButton()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgBrands = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgBrands, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(426, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Search"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblMechID)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(9, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(793, 92)
        Me.Panel2.TabIndex = 22
        '
        'lblMechID
        '
        Me.lblMechID.AutoSize = True
        Me.lblMechID.Location = New System.Drawing.Point(680, 37)
        Me.lblMechID.Name = "lblMechID"
        Me.lblMechID.Size = New System.Drawing.Size(39, 13)
        Me.lblMechID.TabIndex = 1
        Me.lblMechID.Text = "Label8"
        Me.lblMechID.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Hiruko", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(14, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 36)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "All Brands"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(473, 144)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 21
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cmdDeletep)
        Me.Panel1.Controls.Add(Me.cmdUpdatep)
        Me.Panel1.Controls.Add(Me.cmdAddp)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(579, 170)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(225, 368)
        Me.Panel1.TabIndex = 20
        '
        'cmdDeletep
        '
        Me.cmdDeletep.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.cmdDeletep.FlatAppearance.BorderSize = 0
        Me.cmdDeletep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDeletep.Font = New System.Drawing.Font("Noto Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDeletep.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdDeletep.IconChar = FontAwesome.Sharp.IconChar.Trash
        Me.cmdDeletep.IconColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdDeletep.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cmdDeletep.IconSize = 30
        Me.cmdDeletep.Location = New System.Drawing.Point(21, 305)
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
        Me.cmdUpdatep.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.cmdUpdatep.FlatAppearance.BorderSize = 0
        Me.cmdUpdatep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdUpdatep.Font = New System.Drawing.Font("Noto Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdatep.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdUpdatep.IconChar = FontAwesome.Sharp.IconChar.SyncAlt
        Me.cmdUpdatep.IconColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdUpdatep.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cmdUpdatep.IconSize = 30
        Me.cmdUpdatep.Location = New System.Drawing.Point(21, 247)
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
        Me.cmdAddp.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.cmdAddp.FlatAppearance.BorderSize = 0
        Me.cmdAddp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAddp.Font = New System.Drawing.Font("Noto Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdAddp.IconChar = FontAwesome.Sharp.IconChar.PlusSquare
        Me.cmdAddp.IconColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdAddp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cmdAddp.IconSize = 30
        Me.cmdAddp.Location = New System.Drawing.Point(21, 189)
        Me.cmdAddp.Name = "cmdAddp"
        Me.cmdAddp.Size = New System.Drawing.Size(183, 52)
        Me.cmdAddp.TabIndex = 7
        Me.cmdAddp.Text = "Add"
        Me.cmdAddp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdAddp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAddp.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(92, 67)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(112, 20)
        Me.txtName.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comfortaa", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(10, 66)
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
        Me.Label1.Location = New System.Drawing.Point(60, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Brand Info"
        '
        'dgBrands
        '
        Me.dgBrands.AllowUserToAddRows = False
        Me.dgBrands.AllowUserToDeleteRows = False
        Me.dgBrands.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dgBrands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Noto Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(78, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgBrands.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgBrands.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dgBrands.Location = New System.Drawing.Point(11, 170)
        Me.dgBrands.Name = "dgBrands"
        Me.dgBrands.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Comfortaa", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgBrands.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgBrands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgBrands.Size = New System.Drawing.Size(562, 368)
        Me.dgBrands.TabIndex = 19
        '
        'Brands
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 550)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgBrands)
        Me.Name = "Brands"
        Me.Text = "Brands"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgBrands, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblMechID As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmdDeletep As FontAwesome.Sharp.IconButton
    Friend WithEvents cmdUpdatep As FontAwesome.Sharp.IconButton
    Friend WithEvents cmdAddp As FontAwesome.Sharp.IconButton
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgBrands As DataGridView
End Class
