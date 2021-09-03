<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mechanics
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgMech = New System.Windows.Forms.DataGridView()
        Me.txtTypeFilter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdViewMech = New FontAwesome.Sharp.IconButton()
        Me.cmdModMech = New FontAwesome.Sharp.IconButton()
        CType(Me.dgMech, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Noto Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(503, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 18)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Search"
        '
        'dgMech
        '
        Me.dgMech.AllowUserToAddRows = False
        Me.dgMech.AllowUserToDeleteRows = False
        Me.dgMech.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgMech.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Moon", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgMech.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgMech.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Noto Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(78, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgMech.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgMech.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgMech.Location = New System.Drawing.Point(14, 122)
        Me.dgMech.Name = "dgMech"
        Me.dgMech.ReadOnly = True
        Me.dgMech.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMech.Size = New System.Drawing.Size(643, 416)
        Me.dgMech.TabIndex = 13
        '
        'txtTypeFilter
        '
        Me.txtTypeFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTypeFilter.Location = New System.Drawing.Point(557, 96)
        Me.txtTypeFilter.Name = "txtTypeFilter"
        Me.txtTypeFilter.Size = New System.Drawing.Size(100, 20)
        Me.txtTypeFilter.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Hiruko", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(33, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 26)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Mechanics in BikeBox"
        '
        'cmdViewMech
        '
        Me.cmdViewMech.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdViewMech.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.cmdViewMech.FlatAppearance.BorderSize = 3
        Me.cmdViewMech.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdViewMech.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdViewMech.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.cmdViewMech.IconChar = FontAwesome.Sharp.IconChar.Eye
        Me.cmdViewMech.IconColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.cmdViewMech.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cmdViewMech.IconSize = 30
        Me.cmdViewMech.Location = New System.Drawing.Point(674, 285)
        Me.cmdViewMech.Name = "cmdViewMech"
        Me.cmdViewMech.Size = New System.Drawing.Size(130, 49)
        Me.cmdViewMech.TabIndex = 10
        Me.cmdViewMech.Text = "View Done Services"
        Me.cmdViewMech.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdViewMech.UseVisualStyleBackColor = True
        '
        'cmdModMech
        '
        Me.cmdModMech.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdModMech.BackColor = System.Drawing.Color.Transparent
        Me.cmdModMech.FlatAppearance.BorderSize = 0
        Me.cmdModMech.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cmdModMech.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdModMech.Font = New System.Drawing.Font("Comfortaa", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModMech.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.cmdModMech.IconChar = FontAwesome.Sharp.IconChar.Pen
        Me.cmdModMech.IconColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.cmdModMech.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cmdModMech.IconSize = 30
        Me.cmdModMech.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdModMech.Location = New System.Drawing.Point(639, 12)
        Me.cmdModMech.Name = "cmdModMech"
        Me.cmdModMech.Size = New System.Drawing.Size(165, 38)
        Me.cmdModMech.TabIndex = 8
        Me.cmdModMech.Text = "Modify Mechanics"
        Me.cmdModMech.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdModMech.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdModMech.UseVisualStyleBackColor = False
        '
        'Mechanics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(818, 550)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgMech)
        Me.Controls.Add(Me.txtTypeFilter)
        Me.Controls.Add(Me.cmdViewMech)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdModMech)
        Me.Name = "Mechanics"
        Me.Text = "Mechanics"
        CType(Me.dgMech, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents dgMech As DataGridView
    Friend WithEvents txtTypeFilter As TextBox
    Friend WithEvents cmdViewMech As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdModMech As FontAwesome.Sharp.IconButton
End Class
