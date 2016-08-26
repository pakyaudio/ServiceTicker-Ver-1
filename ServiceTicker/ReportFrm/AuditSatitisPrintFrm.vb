Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class AuditSatitisPrintFrm

    Private Sub AuditSatitisPrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        'TODO: This line of code loads data into the 'ReportDBDataSet.satitis' table. You can move, or remove it, as needed.
        Me.satitisTableAdapter.Fill(Me.ReportDBDataSet.satitis)
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.RefreshReport()
    End Sub
    Dim cn, ca As String
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        Try
            strSQL = "SELECT com_name,com_address FROM company"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            cn = Dr.Item("com_name")
            ca = Dr.GetString("com_address")
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Dim c_name As New ReportParameter("com_name", cn)
        Dim c_address As New ReportParameter("com_address", ca)
        Dim htext As New ReportParameter("h_text", AuditChartFrm.hhtext)
        Dim year As New ReportParameter("year", AuditChartFrm.header)
     
        'Dim c As New ReportParameter("cost", ReportUserRepairFrm.txtRURtotalCost.Text)
        'Dim d As New ReportParameter("discount", ReportUserRepairFrm.txtRURdiscount.Text)
        'Dim p As New ReportParameter("profit", ReportUserRepairFrm.txtRURtotalProfit.Text)
        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {c_address, c_name, year, htext})
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.RefreshReport()
        AuditChartFrm.header = Nothing
    End Sub
End Class