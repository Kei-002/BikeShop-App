<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accessories
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgAcce = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdModAcce = New FontAwesome.Sharp.IconButton()
        Me.cmdViewOrder = New FontAwesome.Sharp.IconButton()
        Me.cmdAddOrder = New FontAwesome.Sharp.IconButton()
        Me.cmbTypes = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        CType(Me.dgAcce, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgAcce
        '
        Me.dgAcce.AllowUserToAddRows = False
        Me.dgAcce.AllowUserToDeleteRows = False
        Me.dgAcce.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(28, Byte), Integer))
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgAcce.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgAcce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Noto Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgAcce.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgAcce.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgAcce.Location = New System.Drawing.Point(12, 144)
        Me.dgAcce.Name = "dgAcce"
        Me.dgAcce.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgAcce.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgAcce.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgAcce.Size = New System.Drawing.Size(665, 394)
        Me.dgAcce.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.BikeShop.My.Resources.Resources.red_sunset_bike_trail_vector
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cmdModAcce)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(790, 96)
        Me.Panel1.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Hiruko", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(91, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(291, 36)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Available Accessories"
        '
        'cmdModAcce
        '
        Me.cmdModAcce.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdModAcce.BackColor = System.Drawing.Color.Transparent
        Me.cmdModAcce.FlatAppearance.BorderSize = 0
        Me.cmdModAcce.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdModAcce.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdModAcce.Font = New System.Drawing.Font("Comfortaa", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModAcce.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.cmdModAcce.IconChar = FontAwesome.Sharp.IconChar.Pen
        Me.cmdModAcce.IconColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.cmdModAcce.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cmdModAcce.IconSize = 30
        Me.cmdModAcce.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdModAcce.Location = New System.Drawing.Point(591, 16)
        Me.cmdModAcce.Name = "cmdModAcce"
        Me.cmdModAcce.Size = New System.Drawing.Size(186, 38)
        Me.cmdModAcce.TabIndex = 7
        Me.cmdModAcce.Text = "Modify Accessories"
        Me.cmdModAcce.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdModAcce.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdModAcce.UseVisualStyleBackColor = False
        '
        'cmdViewOrder
        '
        Me.cmdViewOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdViewOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdViewOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmdViewOrder.FlatAppearance.BorderSize = 3
        Me.cmdViewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdViewOrder.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdViewOrder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.cmdViewOrder.IconChar = FontAwesome.Sharp.IconChar.Eye
        Me.cmdViewOrder.IconColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.cmdViewOrder.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cmdViewOrder.IconSize = 30
        Me.cmdViewOrder.Location = New System.Drawing.Point(683, 324)
        Me.cmdViewOrder.Name = "cmdViewOrder"
        Me.cmdViewOrder.Size = New System.Drawing.Size(119, 40)
        Me.cmdViewOrder.TabIndex = 5
        Me.cmdViewOrder.Text = "View Orders"
        Me.cmdViewOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdViewOrder.UseVisualStyleBackColor = False
        '
        'cmdAddOrder
        '
        Me.cmdAddOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAddOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdAddOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmdAddOrder.FlatAppearance.BorderSize = 3
        Me.cmdAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAddOrder.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddOrder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.cmdAddOrder.IconChar = FontAwesome.Sharp.IconChar.CartPlus
        Me.cmdAddOrder.IconColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.cmdAddOrder.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cmdAddOrder.IconSize = 30
        Me.cmdAddOrder.Location = New System.Drawing.Point(683, 268)
        Me.cmdAddOrder.Name = "cmdAddOrder"
        Me.cmdAddOrder.Size = New System.Drawing.Size(119, 40)
        Me.cmdAddOrder.TabIndex = 6
        Me.cmdAddOrder.Text = "Add order"
        Me.cmdAddOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAddOrder.UseVisualStyleBackColor = False
        '
        'cmbTypes
        '
        Me.cmbTypes.FormattingEnabled = True
        Me.cmbTypes.Location = New System.Drawing.Point(12, 117)
        Me.cmbTypes.Name = "cmbTypes"
        Me.cmbTypes.Size = New System.Drawing.Size(121, 21)
        Me.cmbTypes.TabIndex = 12
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(560, 117)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(117, 20)
        Me.txtSearch.TabIndex = 13
        '
        'Accessories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(814, 550)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmbTypes)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgAcce)
        Me.Controls.Add(Me.cmdViewOrder)
        Me.Controls.Add(Me.cmdAddOrder)
        Me.Name = "Accessories"
        Me.Text = "Accessories"
        CType(Me.dgAcce, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdViewOrder As FontAwesome.Sharp.IconButton
    Friend WithEvents cmdAddOrder As FontAwesome.Sharp.IconButton
    Friend WithEvents cmdModAcce As FontAwesome.Sharp.IconButton
    Friend WithEvents dgAcce As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmbTypes As ComboBox
    Friend WithEvents txtSearch As TextBox
End Class
