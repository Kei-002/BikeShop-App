<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Suppliers
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgSupp = New System.Windows.Forms.DataGridView()
        Me.cmdView = New FontAwesome.Sharp.IconButton()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdModSupp = New FontAwesome.Sharp.IconButton()
        Me.cmdOrder = New FontAwesome.Sharp.IconButton()
        CType(Me.dgSupp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgSupp
        '
        Me.dgSupp.AllowUserToAddRows = False
        Me.dgSupp.AllowUserToDeleteRows = False
        Me.dgSupp.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(28, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgSupp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgSupp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Noto Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgSupp.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgSupp.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgSupp.Location = New System.Drawing.Point(12, 144)
        Me.dgSupp.Name = "dgSupp"
        Me.dgSupp.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgSupp.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgSupp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSupp.Size = New System.Drawing.Size(646, 394)
        Me.dgSupp.TabIndex = 9
        '
        'cmdView
        '
        Me.cmdView.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.cmdView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdView.Font = New System.Drawing.Font("Noto Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdView.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdView.IconChar = FontAwesome.Sharp.IconChar.Wrench
        Me.cmdView.IconColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdView.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cmdView.IconSize = 30
        Me.cmdView.Location = New System.Drawing.Point(664, 328)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(138, 52)
        Me.cmdView.TabIndex = 10
        Me.cmdView.Text = "View Delivery Record"
        Me.cmdView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdView.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(558, 118)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(511, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Search"
        '
        'cmdModSupp
        '
        Me.cmdModSupp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdModSupp.BackColor = System.Drawing.Color.Transparent
        Me.cmdModSupp.FlatAppearance.BorderSize = 0
        Me.cmdModSupp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdModSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdModSupp.Font = New System.Drawing.Font("Comfortaa", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModSupp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.cmdModSupp.IconChar = FontAwesome.Sharp.IconChar.Pen
        Me.cmdModSupp.IconColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.cmdModSupp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cmdModSupp.IconSize = 30
        Me.cmdModSupp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdModSupp.Location = New System.Drawing.Point(616, 12)
        Me.cmdModSupp.Name = "cmdModSupp"
        Me.cmdModSupp.Size = New System.Drawing.Size(186, 38)
        Me.cmdModSupp.TabIndex = 13
        Me.cmdModSupp.Text = "Modify Supplier"
        Me.cmdModSupp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdModSupp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdModSupp.UseVisualStyleBackColor = False
        '
        'cmdOrder
        '
        Me.cmdOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.cmdOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdOrder.Font = New System.Drawing.Font("Noto Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdOrder.IconChar = FontAwesome.Sharp.IconChar.TruckLoading
        Me.cmdOrder.IconColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdOrder.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cmdOrder.IconSize = 30
        Me.cmdOrder.Location = New System.Drawing.Point(664, 270)
        Me.cmdOrder.Name = "cmdOrder"
        Me.cmdOrder.Size = New System.Drawing.Size(138, 52)
        Me.cmdOrder.TabIndex = 10
        Me.cmdOrder.Text = "Create an Order"
        Me.cmdOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdOrder.UseVisualStyleBackColor = False
        '
        'Suppliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(814, 550)
        Me.Controls.Add(Me.cmdModSupp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmdOrder)
        Me.Controls.Add(Me.cmdView)
        Me.Controls.Add(Me.dgSupp)
        Me.MinimumSize = New System.Drawing.Size(814, 550)
        Me.Name = "Suppliers"
        Me.Text = "Suppliers"
        CType(Me.dgSupp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgSupp As DataGridView
    Friend WithEvents cmdView As FontAwesome.Sharp.IconButton
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdModSupp As FontAwesome.Sharp.IconButton
    Friend WithEvents cmdOrder As FontAwesome.Sharp.IconButton
End Class
