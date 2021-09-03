<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductsCRUD
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgList = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProdName = New System.Windows.Forms.TextBox()
        Me.cmbTypes = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdDeletep = New FontAwesome.Sharp.IconButton()
        Me.cmdUpdatep = New FontAwesome.Sharp.IconButton()
        Me.cmdAddp = New FontAwesome.Sharp.IconButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProdPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbBrands = New System.Windows.Forms.ComboBox()
        Me.cmbItemType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTypeID = New System.Windows.Forms.Label()
        Me.lblProdID = New System.Windows.Forms.Label()
        Me.lblBrandID = New System.Windows.Forms.Label()
        Me.lblPrevBrand = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgList
        '
        Me.dgList.AllowUserToAddRows = False
        Me.dgList.AllowUserToDeleteRows = False
        Me.dgList.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Noto Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(44, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgList.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgList.GridColor = System.Drawing.SystemColors.Control
        Me.dgList.Location = New System.Drawing.Point(12, 124)
        Me.dgList.Name = "dgList"
        Me.dgList.ReadOnly = True
        Me.dgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgList.Size = New System.Drawing.Size(567, 414)
        Me.dgList.TabIndex = 0
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
        'txtProdName
        '
        Me.txtProdName.Location = New System.Drawing.Point(87, 72)
        Me.txtProdName.Name = "txtProdName"
        Me.txtProdName.Size = New System.Drawing.Size(113, 20)
        Me.txtProdName.TabIndex = 2
        '
        'cmbTypes
        '
        Me.cmbTypes.FormattingEnabled = True
        Me.cmbTypes.Location = New System.Drawing.Point(12, 87)
        Me.cmbTypes.Name = "cmbTypes"
        Me.cmbTypes.Size = New System.Drawing.Size(121, 21)
        Me.cmbTypes.TabIndex = 3
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(479, 98)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cmdDeletep)
        Me.Panel1.Controls.Add(Me.cmdUpdatep)
        Me.Panel1.Controls.Add(Me.cmdAddp)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtProdPrice)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cmbBrands)
        Me.Panel1.Controls.Add(Me.cmbItemType)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtProdName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(589, 124)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(217, 414)
        Me.Panel1.TabIndex = 4
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
        Me.Label5.Size = New System.Drawing.Size(138, 27)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Product Info"
        '
        'txtProdPrice
        '
        Me.txtProdPrice.Location = New System.Drawing.Point(87, 180)
        Me.txtProdPrice.Name = "txtProdPrice"
        Me.txtProdPrice.Size = New System.Drawing.Size(113, 20)
        Me.txtProdPrice.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comfortaa", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(19, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Price"
        '
        'cmbBrands
        '
        Me.cmbBrands.FormattingEnabled = True
        Me.cmbBrands.Location = New System.Drawing.Point(87, 144)
        Me.cmbBrands.Name = "cmbBrands"
        Me.cmbBrands.Size = New System.Drawing.Size(113, 21)
        Me.cmbBrands.TabIndex = 3
        '
        'cmbItemType
        '
        Me.cmbItemType.FormattingEnabled = True
        Me.cmbItemType.Location = New System.Drawing.Point(87, 109)
        Me.cmbItemType.Name = "cmbItemType"
        Me.cmbItemType.Size = New System.Drawing.Size(113, 21)
        Me.cmbItemType.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comfortaa", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(19, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Brand"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comfortaa", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(19, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Type"
        '
        'lblTypeID
        '
        Me.lblTypeID.AutoSize = True
        Me.lblTypeID.Location = New System.Drawing.Point(840, 226)
        Me.lblTypeID.Name = "lblTypeID"
        Me.lblTypeID.Size = New System.Drawing.Size(42, 13)
        Me.lblTypeID.TabIndex = 5
        Me.lblTypeID.Text = "TypeID"
        Me.lblTypeID.Visible = False
        '
        'lblProdID
        '
        Me.lblProdID.AutoSize = True
        Me.lblProdID.Location = New System.Drawing.Point(840, 149)
        Me.lblProdID.Name = "lblProdID"
        Me.lblProdID.Size = New System.Drawing.Size(41, 13)
        Me.lblProdID.TabIndex = 6
        Me.lblProdID.Text = "Item ID"
        Me.lblProdID.Visible = False
        '
        'lblBrandID
        '
        Me.lblBrandID.AutoSize = True
        Me.lblBrandID.Location = New System.Drawing.Point(841, 272)
        Me.lblBrandID.Name = "lblBrandID"
        Me.lblBrandID.Size = New System.Drawing.Size(46, 13)
        Me.lblBrandID.TabIndex = 5
        Me.lblBrandID.Text = "BrandID"
        Me.lblBrandID.Visible = False
        '
        'lblPrevBrand
        '
        Me.lblPrevBrand.AutoSize = True
        Me.lblPrevBrand.Location = New System.Drawing.Point(852, 327)
        Me.lblPrevBrand.Name = "lblPrevBrand"
        Me.lblPrevBrand.Size = New System.Drawing.Size(55, 13)
        Me.lblPrevBrand.TabIndex = 5
        Me.lblPrevBrand.Text = "reBrandID"
        Me.lblPrevBrand.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Noto Sans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(299, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(232, 28)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Product Modification"
        '
        'ProductsCRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(814, 550)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblProdID)
        Me.Controls.Add(Me.lblPrevBrand)
        Me.Controls.Add(Me.lblBrandID)
        Me.Controls.Add(Me.lblTypeID)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmbTypes)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgList)
        Me.Name = "ProductsCRUD"
        Me.Text = "Modify Product Window"
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgList As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtProdName As TextBox
    Friend WithEvents cmbTypes As ComboBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents txtProdPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTypeID As Label
    Friend WithEvents lblProdID As Label
    Friend WithEvents cmbItemType As ComboBox
    Friend WithEvents cmdAddp As FontAwesome.Sharp.IconButton
    Friend WithEvents cmdDeletep As FontAwesome.Sharp.IconButton
    Friend WithEvents cmdUpdatep As FontAwesome.Sharp.IconButton
    Friend WithEvents cmbBrands As ComboBox
    Friend WithEvents lblBrandID As Label
    Friend WithEvents lblPrevBrand As Label
    Friend WithEvents Label6 As Label
End Class
