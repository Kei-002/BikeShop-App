<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalaryForm
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cmdYearly = New System.Windows.Forms.Button()
        Me.cmdMonthly = New System.Windows.Forms.Button()
        Me.cmdDaily = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 90)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(867, 458)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(154, 33)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(156, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'cmdYearly
        '
        Me.cmdYearly.Location = New System.Drawing.Point(604, 31)
        Me.cmdYearly.Name = "cmdYearly"
        Me.cmdYearly.Size = New System.Drawing.Size(75, 23)
        Me.cmdYearly.TabIndex = 5
        Me.cmdYearly.Text = "Yearly"
        Me.cmdYearly.UseVisualStyleBackColor = True
        '
        'cmdMonthly
        '
        Me.cmdMonthly.Location = New System.Drawing.Point(478, 31)
        Me.cmdMonthly.Name = "cmdMonthly"
        Me.cmdMonthly.Size = New System.Drawing.Size(75, 23)
        Me.cmdMonthly.TabIndex = 6
        Me.cmdMonthly.Text = "Monthly"
        Me.cmdMonthly.UseVisualStyleBackColor = True
        '
        'cmdDaily
        '
        Me.cmdDaily.Location = New System.Drawing.Point(353, 31)
        Me.cmdDaily.Name = "cmdDaily"
        Me.cmdDaily.Size = New System.Drawing.Size(75, 23)
        Me.cmdDaily.TabIndex = 7
        Me.cmdDaily.Text = "Daily"
        Me.cmdDaily.UseVisualStyleBackColor = True
        '
        'SalaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 548)
        Me.Controls.Add(Me.cmdYearly)
        Me.Controls.Add(Me.cmdMonthly)
        Me.Controls.Add(Me.cmdDaily)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "SalaryForm"
        Me.Text = "SalaryForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents cmdYearly As Button
    Friend WithEvents cmdMonthly As Button
    Friend WithEvents cmdDaily As Button
End Class
