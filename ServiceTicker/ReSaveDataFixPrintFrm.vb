Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Drawing.Printing
Public Class ReSaveDataFixPrintFrm

    Private Sub ReSaveDataFixPrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'comfixDataSet.comfix' table. You can move, or remove it, as needed.
        Me.comfixTableAdapter.Fillcomfix(Me.comfixDataSet.comfix)
        Me.Icon = Mainfrm.Icon
        Me.ReportViewer1.RefreshReport()
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
        Dim fixID As New ReportParameter("fixid", PrintSaveDatafixSendRepairFrm.fixid)
        Dim cusID As New ReportParameter("cus_id", PrintSaveDatafixSendRepairFrm.cusid)
        Dim cusname As New ReportParameter("cus_name", PrintSaveDatafixSendRepairFrm.cusname)
        Dim custel As New ReportParameter("cus_tel", PrintSaveDatafixSendRepairFrm.custel)
        Dim datetime As New ReportParameter("datetime", PrintSaveDatafixSendRepairFrm.datesave)
        Dim sn As New ReportParameter("sn", PrintSaveDatafixSendRepairFrm.snn)
        Dim p_type As New ReportParameter("ptype", PrintSaveDatafixSendRepairFrm.pt)
        Dim p_name As New ReportParameter("pname", PrintSaveDatafixSendRepairFrm.pn)
        Dim p_model As New ReportParameter("pmodel", PrintSaveDatafixSendRepairFrm.md)
        Dim p_color As New ReportParameter("pcolor", PrintSaveDatafixSendRepairFrm.clo)
        Dim rtype As New ReportParameter("RepairType", PrintSaveDatafixSendRepairFrm.spt)
        Dim rdata As New ReportParameter("repairData", PrintSaveDatafixSendRepairFrm.spt)
        Dim rnote As New ReportParameter("fixrepairNote", PrintSaveDatafixSendRepairFrm.frnote)
        Dim racc As New ReportParameter("fixaccessory", PrintSaveDatafixSendRepairFrm.fa)
        Dim datesend As New ReportParameter("datesend", PrintSaveDatafixSendRepairFrm.dateget)
        Dim fixuser As New ReportParameter("fixuser", PrintSaveDatafixSendRepairFrm.fuser)
        Dim fixnote As New ReportParameter("fixnote", PrintSaveDatafixSendRepairFrm.fnote)
        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {comname, comaddress, comtel, comfax, f1, f2, f3, fixID, cusID, cusname, custel, _
                                                                       datetime, sn, p_name, p_type, p_model, p_color, rtype, rdata, rnote, racc, datesend, fixuser, _
                                                                       fixnote})
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.RefreshReport()
        PrintSaveDatafixSendRepairFrm.fixid = Nothing
        PrintSaveDatafixSendRepairFrm.cusid = Nothing
        PrintSaveDatafixSendRepairFrm.cusname = Nothing
        PrintSaveDatafixSendRepairFrm.custel = Nothing
        PrintSaveDatafixSendRepairFrm.datesave = Nothing
        PrintSaveDatafixSendRepairFrm.snn = Nothing
        PrintSaveDatafixSendRepairFrm.pt = Nothing
        PrintSaveDatafixSendRepairFrm.pn = Nothing
        PrintSaveDatafixSendRepairFrm.md = Nothing
        PrintSaveDatafixSendRepairFrm.clo = Nothing
        PrintSaveDatafixSendRepairFrm.spt = Nothing
        PrintSaveDatafixSendRepairFrm.spt = Nothing
        PrintSaveDatafixSendRepairFrm.frnote = Nothing
        PrintSaveDatafixSendRepairFrm.fa = Nothing
        PrintSaveDatafixSendRepairFrm.dateget = Nothing
        PrintSaveDatafixSendRepairFrm.fuser = Nothing
        PrintSaveDatafixSendRepairFrm.fnote = Nothing
    End Sub
End Class