Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Drawing.Printing
Public Class SendRepairPrintFrm
   
    Private Sub SendRepairPrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        'โชว์ print layout
        'Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.PrinterSettings.Copies = 2
        Me.ReportViewer1.RefreshReport()
    End Sub
    Dim ptype, pname, model, color As String
    Dim cn, ca, ct, cs1, cs2, cs3 As String
    Dim dsave, cusid, cusname, sn1, symptom, fixaccessory, varuntee, userrepair, noterepair, datecomrepair As String
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        Try
            'ข้อมูลเกี่ยวกับบริษัท
            strSQL = "SELECT com_name,com_address,com_tel,com_sendrepairrow1,com_sendrepairrow2,com_sendrepairrow3 FROM company"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()

            cn = Dr.Item("com_name")
            ca = Dr.Item("com_address")
            ct = Dr.Item("com_tel")
            cs1 = Dr.Item("com_sendrepairrow1")
            cs2 = Dr.Item("com_sendrepairrow2")
            cs3 = Dr.Item("com_sendrepairrow3")
        Catch ex As Exception

        End Try
        Try
            'เครื่องซ่อม
            strSQL = "SELECT date_save,customer_id,customer_name,sn,symptom,fixaccessory,varuntee,user_repair,note_repair,datecom_repair FROM comfix WHERE fix_id='" & SendRepairFrm.txtHideform.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()

            dsave = Dr.Item("date_save")
            cusid = Dr.Item("customer_id")
            cusname = Dr.Item("customer_name")
            sn1 = Dr.Item("sn")
            symptom = Dr.Item("symptom")
            fixaccessory = Dr.Item("fixaccessory")
            varuntee = Dr.Item("varuntee")
            userrepair = Dr.Item("user_repair")
            noterepair = Dr.Item("note_repair")
            datecomrepair = Dr.Item("datecom_repair")
        Catch ex As Exception

        End Try
        Try
            'ดึง sn
            strSQL = "SELECT p_type,p_name,model,color FROM sn WHERE Snum='" & sn1 & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()

            ptype = Dr.Item("p_type")
            pname = Dr.Item("p_name")
            model = Dr.Item("model")
            Color = Dr.Item("color")
        Catch ex As Exception

        End Try
        'ทำตัวเลขให้เป็นตัวอักษร
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(CDbl(SendRepairFrm.txtSRfixPrice.Text))
        Catch ex As Exception
            thaitext = ""
        End Try

        Dim comname As New ReportParameter("com_name", cn)
        Dim comaddress As New ReportParameter("com_address", ca)
        Dim comtel As New ReportParameter("com_tel", ct)
        Dim com_sendrepairrow1 As New ReportParameter("com_sendrepairrow1", cs1)
        Dim com_sendrepairrow2 As New ReportParameter("com_sendrepairrow2", cs2)
        Dim com_sendrepairrow3 As New ReportParameter("com_sendrepairrow3", cs3)


        Dim cus_id As New ReportParameter("cus_id", cusid)
        Dim cus_name As New ReportParameter("cus_name", cusname)
        Dim dss As New ReportParameter("date_save", dsave)
        Dim Snum As New ReportParameter("Snum", sn1)
        Dim p_t As New ReportParameter("p_type", ptype)
        Dim p_n As New ReportParameter("p_name", pname)
        Dim md As New ReportParameter("model", model)
        Dim clo As New ReportParameter("color", Color)
        Dim dcr As New ReportParameter("datecom_repair", datecomrepair)
        Dim sy As New ReportParameter("symptom", symptom)
        Dim ur As New ReportParameter("user_repair", userrepair)
        Dim vtt As New ReportParameter("varuntee", varuntee)
        Dim seey As New ReportParameter("fixaccessory", fixaccessory)
        Dim nr As New ReportParameter("note_repair", noterepair)
        Dim fid As New ReportParameter("fix_id", SendRepairFrm.txtHideform.Text)

        Dim ttall As New ReportParameter("total_all", SendRepairFrm.txtSRfixPrice.Text)
        Dim tx As New ReportParameter("thai_text", thaitext)
        Dr.Close()
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {comname, comaddress, comtel, com_sendrepairrow1, com_sendrepairrow2, com_sendrepairrow3, _
                                                                         cus_id, cus_name, dss, Snum, p_t, p_n, md, clo, dcr, sy, ur, vtt, seey, nr, _
                                                                          ttall, tx, fid})
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class