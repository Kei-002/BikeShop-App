<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Services
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
        Me.dgServices = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmdModCus = New FontAwesome.Sharp.IconButton()
        Me.cmdAvail = New FontAwesome.Sharp.IconButton()
        Me.lblSelectedID = New System.Windows.Forms.Label()
        Me.cmdModExp = New FontAwesome.Sharp.IconButton()
        CType(Me.dgServices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgServices
        '
        Me.dgServices.AllowUserToAddRows = False
        Me.dgServices.AllowUserToDeleteRows = False
        Me.dgServices.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Comfortaa", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgServices.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(74, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgServices.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgServices.GridColor = System.Drawing.Color.White
        Me.dgServices.Location = New System.Drawing.Point(7, 139)
        Me.dgServices.Name = "dgServices"
        Me.dgServices.ReadOnly = True
        Me.dgServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgServices.Size = New System.Drawing.Size(656, 401)
        Me.dgServices.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Hiruko", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(32, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 43)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "All Services"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(518, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Search"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(7, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(656, 88)
        Me.Panel1.TabIndex = 13
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(563, 113)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 12
        '
        'cmdModCus
        '
        Me.cmdModCus.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.cmdModCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdModCus.Font = New System.Drawing.Font("Comfortaa", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModCus.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdModCus.IconChar = FontAwesome.Sharp.IconChar.PencilAlt
        Me.cmdModCus.IconColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdModCus.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cmdModCus.IconSize = 30
        Me.cmdModCus.Location = New System.Drawing.Point(669, 11)
        Me.cmdModCus.Name = "cmdModCus"
        Me.cmdModCus.Size = New System.Drawing.Size(138, 59)
        Me.cmdModCus.TabIndex = 11
        Me.cmdModCus.Text = "Modify Services"
        Me.cmdModCus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdModCus.UseVisualStyleBackColor = False
        '
        'cmdAvail
        '
        Me.cmdAvail.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.cmdAvail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAvail.Font = New System.Drawing.Font("Noto Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAvail.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdAvail.IconChar = FontAwesome.Sharp.IconChar.Wrench
        Me.cmdAvail.IconColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdAvail.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cmdAvail.IconSize = 30
        Me.cmdAvail.Location = New System.Drawing.Point(669, 313)
        Me.cmdAvail.Name = "cmdAvail"
        Me.cmdAvail.Size = New System.Drawing.Size(138, 52)
        Me.cmdAvail.TabIndex = 9
        Me.cmdAvail.Text = "Avail selected Service"
        Me.cmdAvail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAvail.UseVisualStyleBackColor = False
        '
        'lblSelectedID
        '
        Me.lblSelectedID.AutoSize = True
        Me.lblSelectedID.Location = New System.Drawing.Point(718, 216)
        Me.lblSelectedID.Name = "lblSelectedID"
        Me.lblSelectedID.Size = New System.Drawing.Size(39, 13)
        Me.lblSelectedID.TabIndex = 15
        Me.lblSelectedID.Text = "Label3"
        Me.lblSelectedID.Visible = False
        '
        'cmdModExp
        '
        Me.cmdModExp.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.cmdModExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdModExp.Font = New System.Drawing.Font("Comfortaa", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModExp.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdModExp.IconChar = FontAwesome.Sharp.IconChar.PencilAlt
        Me.cmdModExp.IconColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmdModExp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cmdModExp.IconSize = 30
        Me.cmdModExp.Location = New System.Drawing.Point(669, 76)
        Me.cmdModExp.Name = "cmdModExp"
        Me.cmdModExp.Size = New System.Drawing.Size(138, 53)
        Me.cmdModExp.TabIndex = 11
        Me.cmdModExp.Text = "Modify Expenses"
        Me.cmdModExp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdModExp.UseVisualStyleBackColor = False
        '
        'Services
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(814, 550)
        Me.Controls.Add(Me.lblSelectedID)
        Me.Controls.Add(Me.dgServices)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmdModExp)
        Me.Controls.Add(Me.cmdModCus)
        Me.Controls.Add(Me.cmdAvail)
        Me.Name = "Services"
        Me.Text = "Services"
        CType(Me.dgServices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgServices As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cmdModCus As FontAwesome.Sharp.IconButton
    Friend WithEvents cmdAvail As FontAwesome.Sharp.IconButton
    Friend WithEvents lblSelectedID As Label
    Friend WithEvents cmdModExp As FontAwesome.Sharp.IconButton
End Class
