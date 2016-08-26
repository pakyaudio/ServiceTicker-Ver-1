Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Drawing.Printing


Public Class SaveDataFixGroupReportPrintFrm

   
    Private Sub SaveDataFixGroupReportPrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'servicetickerDataSet.comfix_cache' table. You can move, or remove it, as needed.
        Me.comfix_cacheTableAdapter.Fill(Me.servicetickerDataSet.comfix_cache)
        Me.Icon = Mainfrm.Icon
        'โชว์ print layout
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.PrinterSettings.Copies = 1
        Me.ReportViewer1.RefreshReport()
        Call SaveDataFixFrm.saveDatalistFixcom()
    End Sub
    Dim cn, ca, ct, cf, ft1, ft2, ft3 As String
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        Try
            strSQL = "SELECT com_name,com_address,com_tel,com_fax,footer1,footer2,footer3,images FROM company"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            cn = Dr.Item("com_name")
            ca = Dr.Item("com_address")
            ct = Dr.Item("com_tel")
            cf = Dr.Item("com_fax")
            ft1 = Dr.Item("footer1")
            ft2 = Dr.Item("footer2")
            ft3 = Dr.Item("footer3")
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try

        Dim comname As New ReportParameter("com_name", cn)
        Dim comaddress As New ReportParameter("com_address", ca)
        Dim comtel As New ReportParameter("com_tel", ct)
        Dim comfax As New ReportParameter("com_fax", cf)
        Dim f1 As New ReportParameter("footer1", ft1)
        Dim f2 As New ReportParameter("footer2", ft2)
        Dim f3 As New ReportParameter("footer3", ft3)
        Dim cusID As New ReportParameter("cus_id", SaveDataFixFrm.txtSDFCusID.Text)
        Dim cusname As New ReportParameter("cus_name", SaveDataFixFrm.txtSDFcusname.Text)
        Dim custel As New ReportParameter("cus_tel", SaveDataFixFrm.txtSDFcusTel.Text)
        Dim fixuser As New ReportParameter("fixuser", SaveDataFixFrm.lblemployee.Text)
        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {comname, comaddress, comtel, comfax, f1, f2, f3, cusID, cusname, custel, _
                                                                        fixuser})

        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class