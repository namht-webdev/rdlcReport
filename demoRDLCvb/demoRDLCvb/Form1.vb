Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim objConn As SqlConnection
        Dim objCmd As SqlCommand
        Dim objReader As SqlDataReader
        Dim objDataset As DataSet = New cusDS
        Dim strSQL As String
        Dim DB_CONN_STRING As String

        DB_CONN_STRING = "Initial Catalog=QLCB;" & _
                                            "Data Source=.\FBOSQL;Integrated Security=SSPI;"

        strSQL = ""
        strSQL = strSQL & "SELECT * FROM KHACHHANG"

        objConn = New SqlConnection(DB_CONN_STRING)

        objCmd = New SqlCommand(strSQL, objConn)

        objCmd.CommandType = CommandType.Text
        objCmd.Connection.Open()
        objReader = objCmd.ExecuteReader
        objDataset.Tables(0).Clear()
        objDataset.Tables(0).Load(objReader)
        objReader.Close()
        objConn.Close()
        Dim rds As ReportDataSource = New ReportDataSource
        ' Note: "dsSalesRpt_dtSalesRpt" was name we gave to the report dataset
        ' when setting it up with the wizard

        ' Tên myCus này trùng với tên lúc connect đến table => phải nhớ
        rds.Name = "myCus"
        rds.Value = objDataset.Tables(0)
        Dim paramList As New Generic.List(Of ReportParameter)
        paramList.Add(New ReportParameter("title"))
        paramList.Add(New ReportParameter("tenkh"))
        paramList.Add(New ReportParameter("makh"))
        paramList.Add(New ReportParameter("dchi"))
        paramList.Add(New ReportParameter("dthoai"))
        'paramList.Add(New ReportParameter("prmToDate", Format(dtpToDate.Value, "M/d/yyyy")))
        With frmReportViewer
            ' Note: When assigning the ReportEmbeddedResource in the statement below, you must
            ' qualify the report object name with the project name (in this case "ReportExample")
            .rptView.LocalReport.ReportEmbeddedResource = "demoRDLCvb.cuscusRpt.rdlc" 'demoRDLCvb.cuscusRpt.rdlc => (tên project).(tên file report).rdlc
            .rptView.LocalReport.DataSources.Clear()
            .rptView.LocalReport.DataSources.Add(rds)
            .rptView.LocalReport.SetParameters(paramList)
            .rptView.RefreshReport()
            .Text = "Customer Report" ' Tên của form report
            .ShowDialog()

        End With


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
