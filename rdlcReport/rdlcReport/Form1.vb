Imports System.Data.SqlClient
Public Class rptLayout

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
        Me.Text = "tutorialspont.com"
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRpt.Click

    End Sub
End Class
