<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Customers
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
        Me.dgCustomers = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmdModCus = New FontAwesome.Sharp.IconButton()
        Me.cmdServiceHistory = New FontAwesome.Sharp.IconButton()
        Me.cmdPurchaseHistory = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgCustomers
        '
        Me.dgCustomers.AllowUserToAddRows = False
        Me.dgCustomers.AllowUserToDeleteRows = False
        Me.dgCustomers.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Comfortaa", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCustomers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCustomers.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgCustomers.GridColor = System.Drawing.Color.White
        Me.dgCustomers.Location = New System.Drawing.Point(12, 137)
        Me.dgCustomers.Name = "dgCustomers"
        Me.dgCustomers.ReadOnly = True
        Me.dgCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCustomers.Size = New System.Drawing.Size(656, 401)
        Me.dgCustomers.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Hiruko", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(32, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 43)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "All Customer Info"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(568, 111)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 5
        '
        'cmdModCus
        '
        Me.cmdModCus.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmdModCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdModCus.Font = New System.Drawing.Font("Comfortaa", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModCus.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdModCus.IconChar = FontAwesome.Sharp.IconChar.PencilAlt
        Me.cmdModCus.IconColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdModCus.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cmdModCus.IconSize = 30
        Me.cmdModCus.Location = New System.Drawing.Point(674, 9)
        Me.cmdModCus.Name = "cmdModCus"
        Me.cmdModCus.Size = New System.Drawing.Size(138, 58)
        Me.cmdModCus.TabIndex = 4
        Me.cmdModCus.Text = "Modify Customer Info"
        Me.cmdModCus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdModCus.UseVisualStyleBackColor = False
        '
        'cmdServiceHistory
        '
        Me.cmdServiceHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cmdServiceHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdServiceHistory.Font = New System.Drawing.Font("Noto Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdServiceHistory.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdServiceHistory.IconChar = FontAwesome.Sharp.IconChar.History
        Me.cmdServiceHistory.IconColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdServiceHistory.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cmdServiceHistory.IconSize = 30
        Me.cmdServiceHistory.Location = New System.Drawing.Point(674, 324)
        Me.cmdServiceHistory.Name = "cmdServiceHistory"
        Me.cmdServiceHistory.Size = New System.Drawing.Size(138, 60)
        Me.cmdServiceHistory.TabIndex = 2
        Me.cmdServiceHistory.Text = "View Bike Service History"
        Me.cmdServiceHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdServiceHistory.UseVisualStyleBackColor = False
        '
        'cmdPurchaseHistory
        '
        Me.cmdPurchaseHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cmdPurchaseHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPurchaseHistory.Font = New System.Drawing.Font("Noto Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPurchaseHistory.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdPurchaseHistory.IconChar = FontAwesome.Sharp.IconChar.Eye
        Me.cmdPurchaseHistory.IconColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdPurchaseHistory.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cmdPurchaseHistory.IconSize = 30
        Me.cmdPurchaseHistory.Location = New System.Drawing.Point(674, 239)
        Me.cmdPurchaseHistory.Name = "cmdPurchaseHistory"
        Me.cmdPurchaseHistory.Size = New System.Drawing.Size(138, 52)
        Me.cmdPurchaseHistory.TabIndex = 1
        Me.cmdPurchaseHistory.Text = "View Purchase History"
        Me.cmdPurchaseHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdPurchaseHistory.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(656, 88)
        Me.Panel1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(523, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Search"
        '
        'Customers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(818, 550)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmdModCus)
        Me.Controls.Add(Me.cmdServiceHistory)
        Me.Controls.Add(Me.cmdPurchaseHistory)
        Me.Controls.Add(Me.dgCustomers)
        Me.Name = "Customers"
        Me.Text = "Customers"
        CType(Me.dgCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgCustomers As DataGridView
    Friend WithEvents cmdPurchaseHistory As FontAwesome.Sharp.IconButton
    Friend WithEvents cmdServiceHistory As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdModCus As FontAwesome.Sharp.IconButton
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
End Class
