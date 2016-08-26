Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Drawing.Printing
Imports System.Globalization

Public Class AuditReportPrintFrm
  
    Private Sub AuditReportPrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AuditDataSet1.audit' table. You can move, or remove it, as needed.
        Me.auditTableAdapter.Fill(Me.AuditDataSet1.audit)
        Me.Icon = Mainfrm.Icon
        Me.ReportViewer1.RefreshReport()
    End Sub
    Dim cn, ca, ct, ims, ctax, cf As String
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        Try
            strSQL = "select com_name,com_address from company"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()

            cn = Dr.Item("com_name")
            ca = Dr.Item("com_address")
        Catch ex As Exception

        End Try


        Dim cname As New ReportParameter("com_name", cn)
        Dim caddress As New ReportParameter("com_address", ca)
        Dim ctel As New ReportParameter("dateF", AuditReportFrm.DateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")))
        Dim cfax As New ReportParameter("dateL", AuditReportFrm.DateTimePicker2.Value.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")))



        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {cname, caddress, ctel, cfax _
                                                                         })
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class