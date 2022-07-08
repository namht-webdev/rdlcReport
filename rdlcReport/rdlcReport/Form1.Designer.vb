<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rptLayout
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnRpt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(-2, 42)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(932, 465)
        Me.ReportViewer1.TabIndex = 0
        '
        'btnRpt
        '
        Me.btnRpt.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnRpt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRpt.Location = New System.Drawing.Point(432, 12)
        Me.btnRpt.Name = "btnRpt"
        Me.btnRpt.Size = New System.Drawing.Size(106, 23)
        Me.btnRpt.TabIndex = 1
        Me.btnRpt.Text = "Tạo báo cáo"
        Me.btnRpt.UseVisualStyleBackColor = False
        '
        'rptLayout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 508)
        Me.Controls.Add(Me.btnRpt)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "rptLayout"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnRpt As System.Windows.Forms.Button

End Class
