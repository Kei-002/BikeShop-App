<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExpenseForm
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
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(2, 64)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(867, 498)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'cmdYearly
        '
        Me.cmdYearly.Location = New System.Drawing.Point(511, 21)
        Me.cmdYearly.Name = "cmdYearly"
        Me.cmdYearly.Size = New System.Drawing.Size(75, 23)
        Me.cmdYearly.TabIndex = 2
        Me.cmdYearly.Text = "Yearly"
        Me.cmdYearly.UseVisualStyleBackColor = True
        '
        'cmdMonthly
        '
        Me.cmdMonthly.Location = New System.Drawing.Point(385, 21)
        Me.cmdMonthly.Name = "cmdMonthly"
        Me.cmdMonthly.Size = New System.Drawing.Size(75, 23)
        Me.cmdMonthly.TabIndex = 3
        Me.cmdMonthly.Text = "Monthly"
        Me.cmdMonthly.UseVisualStyleBackColor = True
        '
        'cmdDaily
        '
        Me.cmdDaily.Location = New System.Drawing.Point(260, 21)
        Me.cmdDaily.Name = "cmdDaily"
        Me.cmdDaily.Size = New System.Drawing.Size(75, 23)
        Me.cmdDaily.TabIndex = 4
        Me.cmdDaily.Text = "Daily"
        Me.cmdDaily.UseVisualStyleBackColor = True
        '
        'ExpenseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 564)
        Me.Controls.Add(Me.cmdYearly)
        Me.Controls.Add(Me.cmdMonthly)
        Me.Controls.Add(Me.cmdDaily)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "ExpenseForm"
        Me.Text = "ExpenseForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cmdYearly As Button
    Friend WithEvents cmdMonthly As Button
    Friend WithEvents cmdDaily As Button
End Class
