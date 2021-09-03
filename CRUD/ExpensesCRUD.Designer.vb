<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExpensesCRUD
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
        Me.dgExpenses = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbName = New System.Windows.Forms.ComboBox()
        Me.lblExpID = New System.Windows.Forms.Label()
        Me.cmdDeletep = New FontAwesome.Sharp.IconButton()
        Me.cmdUpdatep = New FontAwesome.Sharp.IconButton()
        Me.cmdAddp = New FontAwesome.Sharp.IconButton()
        Me.txtOthers = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRent = New System.Windows.Forms.TextBox()
        Me.txtElec = New System.Windows.Forms.TextBox()
        Me.txtWater = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.dgExpenses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgExpenses
        '
        Me.dgExpenses.AllowUserToAddRows = False
        Me.dgExpenses.AllowUserToDeleteRows = False
        Me.dgExpenses.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(226, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Comfortaa", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgExpenses.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Noto Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(71, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgExpenses.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgExpenses.Location = New System.Drawing.Point(12, 119)
        Me.dgExpenses.Name = "dgExpenses"
        Me.dgExpenses.ReadOnly = True
        Me.dgExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgExpenses.Size = New System.Drawing.Size(525, 326)
        Me.dgExpenses.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cmbName)
        Me.Panel1.Controls.Add(Me.lblExpID)
        Me.Panel1.Controls.Add(Me.cmdDeletep)
        Me.Panel1.Controls.Add(Me.cmdUpdatep)
        Me.Panel1.Controls.Add(Me.cmdAddp)
        Me.Panel1.Controls.Add(Me.txtOthers)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtRent)
        Me.Panel1.Controls.Add(Me.txtElec)
        Me.Panel1.Controls.Add(Me.txtWater)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(543, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(218, 433)
        Me.Panel1.TabIndex = 2
        '
        'cmbName
        '
        Me.cmbName.FormattingEnabled = True
        Me.cmbName.Location = New System.Drawing.Point(85, 86)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.Size = New System.Drawing.Size(86, 21)
        Me.cmbName.TabIndex = 10
        '
        'lblExpID
        '
        Me.lblExpID.AutoSize = True
        Me.lblExpID.Location = New System.Drawing.Point(140, 44)
        Me.lblExpID.Name = "lblExpID"
        Me.lblExpID.Size = New System.Drawing.Size(39, 13)
        Me.lblExpID.TabIndex = 8
        Me.lblExpID.Text = "Label7"
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
        Me.cmdDeletep.Location = New System.Drawing.Point(-3, 372)
        Me.cmdDeletep.Name = "cmdDeletep"
        Me.cmdDeletep.Size = New System.Drawing.Size(221, 52)
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
        Me.cmdUpdatep.Location = New System.Drawing.Point(-3, 314)
        Me.cmdUpdatep.Name = "cmdUpdatep"
        Me.cmdUpdatep.Size = New System.Drawing.Size(221, 52)
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
        Me.cmdAddp.Location = New System.Drawing.Point(-3, 256)
        Me.cmdAddp.Name = "cmdAddp"
        Me.cmdAddp.Size = New System.Drawing.Size(221, 52)
        Me.cmdAddp.TabIndex = 7
        Me.cmdAddp.Text = "Add"
        Me.cmdAddp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdAddp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAddp.UseVisualStyleBackColor = False
        '
        'txtOthers
        '
        Me.txtOthers.Location = New System.Drawing.Point(84, 225)
        Me.txtOthers.Name = "txtOthers"
        Me.txtOthers.Size = New System.Drawing.Size(125, 20)
        Me.txtOthers.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comfortaa", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(10, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Others"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comfortaa", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(10, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Rent"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comfortaa", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(10, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Electricity"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comfortaa", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(10, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 19)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Name"
        '
        'txtRent
        '
        Me.txtRent.Location = New System.Drawing.Point(84, 190)
        Me.txtRent.Name = "txtRent"
        Me.txtRent.Size = New System.Drawing.Size(125, 20)
        Me.txtRent.TabIndex = 4
        '
        'txtElec
        '
        Me.txtElec.Location = New System.Drawing.Point(84, 154)
        Me.txtElec.Name = "txtElec"
        Me.txtElec.Size = New System.Drawing.Size(125, 20)
        Me.txtElec.TabIndex = 4
        '
        'txtWater
        '
        Me.txtWater.Location = New System.Drawing.Point(84, 121)
        Me.txtWater.Name = "txtWater"
        Me.txtWater.Size = New System.Drawing.Size(125, 20)
        Me.txtWater.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comfortaa", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(10, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Water"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Hiruko", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(41, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Expenses Info"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(437, 93)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(13, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(524, 76)
        Me.Panel2.TabIndex = 4
        '
        'ExpensesCRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(766, 452)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgExpenses)
        Me.Name = "ExpensesCRUD"
        Me.Text = "ExpensesCRUD"
        CType(Me.dgExpenses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgExpenses As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmdDeletep As FontAwesome.Sharp.IconButton
    Friend WithEvents cmdUpdatep As FontAwesome.Sharp.IconButton
    Friend WithEvents cmdAddp As FontAwesome.Sharp.IconButton
    Friend WithEvents txtOthers As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtWater As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtRent As TextBox
    Friend WithEvents txtElec As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblExpID As Label
    Friend WithEvents cmbName As ComboBox
End Class
