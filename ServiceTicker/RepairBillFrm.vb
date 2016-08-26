Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Drawing.Printing

Public Class RepairBillFrm
    
    Private Sub RepairBillFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'comfixDataSet.comfix' table. You can move, or remove it, as needed.
        Me.comfixTableAdapter.Fillcomfix(Me.comfixDataSet.comfix)
        'TODO: This line of code loads data into the 'REquDataSet.quotation' table. You can move, or remove it, as needed.
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.Icon = Mainfrm.Icon
        'โชว์ print layout
        'Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

        Me.ReportViewer1.RefreshReport()
    End Sub
    Dim cn, ca, ct, cf, ft1, ft2, ft3 As String
    Dim snf, typef, namef, modelf, colorf, sypf, mdf, sptft, accessf, datef, notef As String
    Friend fidf As String
    Private Sub ReportViewer1_Load_1(sender As Object, e As EventArgs) Handles ReportViewer1.Load
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
        Try

            strSQL = "SELECT fix_id,date_get,sn,symptom,managerdata,fixrepairnote,fixaccessory,fixnote FROM comfix_cache WHERE fix_id='" & SaveDataFixFrm.dgSDFlistComfix.Rows(0).Cells(2).Value & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            fidf = Dr.Item("fix_id")
            snf = Dr.Item("sn")
            sypf = Dr.Item("symptom")
            mdf = Dr.Item("managerdata")
            sptft = Dr.Item("fixrepairnote")
            accessf = Dr.Item("fixaccessory")
            datef = Dr.Item("date_get")
            notef = Dr.Item("fixnote")

            strSQL = "SELECT p_type,p_name,model,color FROM sn WHERE Snum='" & snf & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            typef = Dr.Item("p_type")
            namef = Dr.Item("p_name")
            modelf = Dr.Item("model")
            colorf = Dr.Item("color")

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
        Dim fixID As New ReportParameter("fixid", fidf)
        Dim cusID As New ReportParameter("cus_id", SaveDataFixFrm.txtSDFCusID.Text)
        Dim cusname As New ReportParameter("cus_name", SaveDataFixFrm.txtSDFcusname.Text)
        Dim custel As New ReportParameter("cus_tel", SaveDataFixFrm.txtSDFcusTel.Text)
        Dim datetime As New ReportParameter("datetime", SaveDataFixFrm.DateTimePickerSDFadd.Text)
        Dim sn As New ReportParameter("sn", snf)
        Dim p_type As New ReportParameter("ptype", typef)
        Dim p_name As New ReportParameter("pname", namef)
        Dim p_model As New ReportParameter("pmodel", modelf)
        Dim p_color As New ReportParameter("pcolor", colorf)
        Dim rtype As New ReportParameter("RepairType", sypf)
        Dim rdata As New ReportParameter("repairData", mdf)
        Dim rnote As New ReportParameter("fixrepairNote", sptft)
        Dim racc As New ReportParameter("fixaccessory", accessf)
        Dim datesend As New ReportParameter("datesend", datef)
        Dim fixuser As New ReportParameter("fixuser", SaveDataFixFrm.lblemployee.Text)
        Dim fixnote As New ReportParameter("fixnote", notef)



        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {comname, comaddress, comtel, comfax, f1, f2, f3, fixID, cusID, cusname, custel, _
                                                                       datetime, sn, p_name, p_type, p_model, p_color, rtype, rdata, rnote, racc, datesend, fixuser, _
                                                                       fixnote})


        'Dim pg As New System.Drawing.Printing.PageSettings
        'pg.Margins.Top = 0
        'pg.Margins.Bottom = 0
        'pg.Margins.Left = 0
        'pg.Margins.Right = 0
        'pg.Landscape = False

        'Dim Size As System.Drawing.Printing.PaperSize
        'Size = New Printing.PaperSize("Custom Paper Size", 827, 550)
        'pg.PaperSize = Size
        'ReportViewer1.SetPageSettings(pg)
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.RefreshReport()

    End Sub




End Class