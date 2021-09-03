<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupplierCRUD
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
        Me.dgSupp = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdDeletep = New FontAwesome.Sharp.IconButton()
        Me.cmdUpdatep = New FontAwesome.Sharp.IconButton()
        Me.cmdAddp = New FontAwesome.Sharp.IconButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgSupp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgSupp
        '
        Me.dgSupp.AllowUserToAddRows = False
        Me.dgSupp.AllowUserToDeleteRows = False
        Me.dgSupp.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Comfortaa", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgSupp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgSupp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgSupp.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgSupp.GridColor = System.Drawing.Color.White
        Me.dgSupp.Location = New System.Drawing.Point(12, 112)
        Me.dgSupp.Name = "dgSupp"
        Me.dgSupp.ReadOnly = True
        Me.dgSupp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSupp.Size = New System.Drawing.Size(370, 414)
        Me.dgSupp.TabIndex = 16
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cmdDeletep)
        Me.Panel1.Controls.Add(Me.cmdUpdatep)
        Me.Panel1.Controls.Add(Me.cmdAddp)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtAdd)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(388, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(217, 414)
        Me.Panel1.TabIndex = 17
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
        Me.cmdDeletep.Location = New System.Drawing.Point(23, 344)
        Me.cmdDeletep.Name = "cmdDeletep"
        Me.cmdDeletep.Size = New System.Drawing.Size(177, 52)
        Me.cmdDeletep.TabIndex = 4
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
        Me.cmdUpdatep.Location = New System.Drawing.Point(23, 286)
        Me.cmdUpdatep.Name = "cmdUpdatep"
        Me.cmdUpdatep.Size = New System.Drawing.Size(177, 52)
        Me.cmdUpdatep.TabIndex = 4
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
        Me.cmdAddp.Location = New System.Drawing.Point(23, 228)
        Me.cmdAddp.Name = "cmdAddp"
        Me.cmdAddp.Size = New System.Drawing.Size(177, 52)
        Me.cmdAddp.TabIndex = 4
        Me.cmdAddp.Text = "Add"
        Me.cmdAddp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdAddp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAddp.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Hiruko", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(37, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 27)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Supplier Info"
        '
        'txtAdd
        '
        Me.txtAdd.Location = New System.Drawing.Point(87, 116)
        Me.txtAdd.Multiline = True
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(113, 60)
        Me.txtAdd.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comfortaa", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(19, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Address"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(87, 72)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(113, 20)
        Me.txtName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comfortaa", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(19, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(282, 86)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(225, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Search"
        '
        'SupplierCRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 532)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgSupp)
        Me.Name = "SupplierCRUD"
        Me.Text = "SupplierCRUD"
        CType(Me.dgSupp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgSupp As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmdDeletep As FontAwesome.Sharp.IconButton
    Friend WithEvents cmdUpdatep As FontAwesome.Sharp.IconButton
    Friend WithEvents cmdAddp As FontAwesome.Sharp.IconButton
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAdd As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label2 As Label
End Class
