Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class ReceviceReportPrintFrm

    Private Sub ReceviceReportPrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReportDBDataSet.receivereport' table. You can move, or remove it, as needed.
        Me.receivereportTableAdapter.Fill(Me.ReportDBDataSet.receivereport)
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.Icon = Mainfrm.Icon
        Me.ReportViewer1.RefreshReport()
    End Sub
    Dim datetime, cn As String
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        Try
            strSQL = "SELECT com_name,images FROM company"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            cn = Dr.Item("com_name")
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        datetime = "ระหว่างวันที่ " & ReceiveReportFrm.DateTimePicker1.Text & " ถึง " & ReceiveReportFrm.DateTimePicker2.Text
        If ReceiveReportFrm.cbbVRbuyCompany.Text <> "" Then
            datetime = datetime & "  " & ReceiveReportFrm.cbbVRbuyCompany.Text
        End If
        Dim cnn As New ReportParameter("com_name", cn)
        Dim u_datetime As New ReportParameter("start_end_date", datetime)
        Dim u_totalpro As New ReportParameter("total_pro", ReceiveReportFrm.txtRRRrow.Text)
        Dim st_money As New ReportParameter("total_money", ReceiveReportFrm.txtRRRsum.Text)
        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {cnn, u_datetime, u_totalpro, st_money})
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class