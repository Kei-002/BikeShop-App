<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Products
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
        Me.txtTypeFilter = New System.Windows.Forms.TextBox()
        Me.dgAllProducts = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbOrder = New FontAwesome.Sharp.IconButton()
        Me.cmdModProd = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgAllProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTypeFilter
        '
        Me.txtTypeFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTypeFilter.Location = New System.Drawing.Point(546, 96)
        Me.txtTypeFilter.Name = "txtTypeFilter"
        Me.txtTypeFilter.Size = New System.Drawing.Size(100, 20)
        Me.txtTypeFilter.TabIndex = 5
        '
        'dgAllProducts
        '
        Me.dgAllProducts.AllowUserToAddRows = False
        Me.dgAllProducts.AllowUserToDeleteRows = False
        Me.dgAllProducts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgAllProducts.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Moon", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgAllProducts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgAllProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Noto Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(78, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgAllProducts.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgAllProducts.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgAllProducts.Location = New System.Drawing.Point(12, 122)
        Me.dgAllProducts.Name = "dgAllProducts"
        Me.dgAllProducts.ReadOnly = True
        Me.dgAllProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgAllProducts.Size = New System.Drawing.Size(643, 416)
        Me.dgAllProducts.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Hiruko", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(31, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Available Products"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Noto Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(450, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Search Item"
        '
        'cmbOrder
        '
        Me.cmbOrder.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmbOrder.FlatAppearance.BorderSize = 3
        Me.cmbOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbOrder.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOrder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.cmbOrder.IconChar = FontAwesome.Sharp.IconChar.CartPlus
        Me.cmbOrder.IconColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.cmbOrder.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cmbOrder.IconSize = 30
        Me.cmbOrder.Location = New System.Drawing.Point(15, 172)
        Me.cmbOrder.Name = "cmbOrder"
        Me.cmbOrder.Size = New System.Drawing.Size(126, 48)
        Me.cmbOrder.TabIndex = 4
        Me.cmbOrder.Text = "Make an Order"
        Me.cmbOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmbOrder.UseVisualStyleBackColor = True
        '
        'cmdModProd
        '
        Me.cmdModProd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdModProd.BackColor = System.Drawing.Color.Transparent
        Me.cmdModProd.FlatAppearance.BorderSize = 0
        Me.cmdModProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdModProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdModProd.Font = New System.Drawing.Font("Comfortaa", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModProd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.cmdModProd.IconChar = FontAwesome.Sharp.IconChar.Pen
        Me.cmdModProd.IconColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.cmdModProd.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cmdModProd.IconSize = 30
        Me.cmdModProd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdModProd.Location = New System.Drawing.Point(646, 12)
        Me.cmdModProd.Name = "cmdModProd"
        Me.cmdModProd.Size = New System.Drawing.Size(156, 38)
        Me.cmdModProd.TabIndex = 0
        Me.cmdModProd.Text = "Modify Products"
        Me.cmdModProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdModProd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdModProd.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbOrder)
        Me.Panel1.Location = New System.Drawing.Point(661, 122)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(149, 416)
        Me.Panel1.TabIndex = 8
        '
        'Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(814, 550)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgAllProducts)
        Me.Controls.Add(Me.txtTypeFilter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdModProd)
        Me.MinimumSize = New System.Drawing.Size(814, 550)
        Me.Name = "Products"
        Me.Text = "Products"
        CType(Me.dgAllProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdModProd As FontAwesome.Sharp.IconButton
    Friend WithEvents cmbOrder As FontAwesome.Sharp.IconButton
    Friend WithEvents txtTypeFilter As TextBox
    Friend WithEvents dgAllProducts As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
End Class
