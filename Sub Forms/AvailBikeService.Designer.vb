<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AvailBikeService
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
        Me.cmbCustomer = New System.Windows.Forms.ComboBox()
        Me.cmbMechanic = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbServices = New System.Windows.Forms.ComboBox()
        Me.txtWage = New System.Windows.Forms.TextBox()
        Me.txtPercent = New System.Windows.Forms.TextBox()
        Me.txtFee = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdAvail = New FontAwesome.Sharp.IconButton()
        Me.ServID = New System.Windows.Forms.Label()
        Me.cmdCompute = New FontAwesome.Sharp.IconButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbCustomer
        '
        Me.cmbCustomer.FormattingEnabled = True
        Me.cmbCustomer.Location = New System.Drawing.Point(35, 382)
        Me.cmbCustomer.Name = "cmbCustomer"
        Me.cmbCustomer.Size = New System.Drawing.Size(186, 23)
        Me.cmbCustomer.TabIndex = 0
        '
        'cmbMechanic
        '
        Me.cmbMechanic.FormattingEnabled = True
        Me.cmbMechanic.Location = New System.Drawing.Point(35, 435)
        Me.cmbMechanic.Name = "cmbMechanic"
        Me.cmbMechanic.Size = New System.Drawing.Size(186, 23)
        Me.cmbMechanic.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BikeShop.My.Resources.Resources.logooo
        Me.PictureBox1.Location = New System.Drawing.Point(65, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 112)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(94, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Customer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(94, 417)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mechanic"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbServices)
        Me.Panel1.Controls.Add(Me.txtWage)
        Me.Panel1.Controls.Add(Me.txtPercent)
        Me.Panel1.Controls.Add(Me.txtFee)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(12, 138)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(225, 172)
        Me.Panel1.TabIndex = 4
        '
        'cmbServices
        '
        Me.cmbServices.FormattingEnabled = True
        Me.cmbServices.Location = New System.Drawing.Point(114, 41)
        Me.cmbServices.Name = "cmbServices"
        Me.cmbServices.Size = New System.Drawing.Size(100, 23)
        Me.cmbServices.TabIndex = 7
        '
        'txtWage
        '
        Me.txtWage.Enabled = False
        Me.txtWage.Location = New System.Drawing.Point(114, 131)
        Me.txtWage.Name = "txtWage"
        Me.txtWage.Size = New System.Drawing.Size(100, 21)
        Me.txtWage.TabIndex = 4
        '
        'txtPercent
        '
        Me.txtPercent.Location = New System.Drawing.Point(114, 104)
        Me.txtPercent.Name = "txtPercent"
        Me.txtPercent.Size = New System.Drawing.Size(100, 21)
        Me.txtPercent.TabIndex = 4
        '
        'txtFee
        '
        Me.txtFee.Enabled = False
        Me.txtFee.Location = New System.Drawing.Point(114, 76)
        Me.txtFee.Name = "txtFee"
        Me.txtFee.Size = New System.Drawing.Size(100, 21)
        Me.txtFee.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(20, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 15)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Mech Wage:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comfortaa", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(71, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Service Info"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(20, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 15)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Mechanic %:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(20, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Fee:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(20, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Service Name:"
        '
        'cmdAvail
        '
        Me.cmdAvail.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmdAvail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAvail.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAvail.IconChar = FontAwesome.Sharp.IconChar.Wrench
        Me.cmdAvail.IconColor = System.Drawing.Color.Black
        Me.cmdAvail.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cmdAvail.IconSize = 30
        Me.cmdAvail.Location = New System.Drawing.Point(55, 470)
        Me.cmdAvail.Name = "cmdAvail"
        Me.cmdAvail.Size = New System.Drawing.Size(142, 43)
        Me.cmdAvail.TabIndex = 5
        Me.cmdAvail.Text = "Avail Service"
        Me.cmdAvail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAvail.UseVisualStyleBackColor = False
        '
        'ServID
        '
        Me.ServID.AutoSize = True
        Me.ServID.Location = New System.Drawing.Point(192, 109)
        Me.ServID.Name = "ServID"
        Me.ServID.Size = New System.Drawing.Size(45, 15)
        Me.ServID.TabIndex = 6
        Me.ServID.Text = "Label8"
        Me.ServID.Visible = False
        '
        'cmdCompute
        '
        Me.cmdCompute.BackColor = System.Drawing.Color.DimGray
        Me.cmdCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCompute.Font = New System.Drawing.Font("Comfortaa", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCompute.IconChar = FontAwesome.Sharp.IconChar.Calculator
        Me.cmdCompute.IconColor = System.Drawing.Color.Black
        Me.cmdCompute.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cmdCompute.IconSize = 15
        Me.cmdCompute.Location = New System.Drawing.Point(126, 298)
        Me.cmdCompute.Name = "cmdCompute"
        Me.cmdCompute.Size = New System.Drawing.Size(99, 31)
        Me.cmdCompute.TabIndex = 5
        Me.cmdCompute.Text = "Compute"
        Me.cmdCompute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdCompute.UseVisualStyleBackColor = False
        '
        'AvailBikeService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(249, 535)
        Me.Controls.Add(Me.ServID)
        Me.Controls.Add(Me.cmdCompute)
        Me.Controls.Add(Me.cmdAvail)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmbMechanic)
        Me.Controls.Add(Me.cmbCustomer)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "AvailBikeService"
        Me.Text = "AvailBikeService"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbCustomer As ComboBox
    Friend WithEvents cmbMechanic As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtWage As TextBox
    Friend WithEvents txtPercent As TextBox
    Friend WithEvents txtFee As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdAvail As FontAwesome.Sharp.IconButton
    Friend WithEvents ServID As Label
    Friend WithEvents cmdCompute As FontAwesome.Sharp.IconButton
    Friend WithEvents cmbServices As ComboBox
End Class
