Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class SendRepairFrm
    
    Private Sub SendRepairFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        'Me.cbbSRRcash_status.Enabled = False
        Me.DateTimePickerSRR.Value = DateTime.Now.AddDays(0)
        'Me.DateTimePickerSRR.Enabled = False
    End Sub
    Dim frn As String
    Protected Friend cusID As String
    Protected Friend cusName As String
    Private Sub getDataFromFixid()
        Try
            dt = New DataTable
            strSQL = "SELECT fix_id,date_save,customer_id,customer_name,sn,symptom,managerdata," _
                & "fixaccessory,date_get,status,user_repair,note_repair,teltocus,fixrepairnote FROM comfix WHERE fix_id='" & Me.txtSRgetDataByFixID.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
            Call open_connection()
            dtAdapter.Fill(dt)
            Me.lblSRcustomerDetail.Text = dt.Rows(0).Item("customer_name") & " รหัสลูกค้า: " & dt.Rows(0).Item("customer_id") & vbNewLine & " อาการเสีย: " & dt.Rows(0).Item("symptom") & " ช่างซ่อม: " & dt.Rows(0).Item("user_repair") & vbNewLine & " วันที่ส่งซ่อม: " & dt.Rows(0).Item("date_save") & " วันที่นัดรับเครื่อง: " & dt.Rows(0).Item("date_get")
            Me.txtSRfixRepairNote.Text = dt.Rows(0).Item("note_repair")
            Me.txtSRfixAccessory.Text = dt.Rows(0).Item("fixaccessory")
            Me.txtSRstatus.Text = dt.Rows(0).Item("status")
            frn = dt.Rows(0).Item("fixrepairnote")
            cusID = dt.Rows(0).Item("customer_id")

        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub getDatasale()
        Try
            strSQL = "SELECT sale_id,total_all FROM sale WHERE fix_id='" & Me.txtSRgetDataByFixID.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Call open_connection()
            Dr.Read()
            MsgBox(Dr.GetDecimal("total_all"))
            Me.txtSRfixPrice.Text = Dr.GetDecimal("total_all")
            Me.txtSRsale_id.Text = Dr.GetString("sale_id")
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub getDatasale_Barcode()
        Try
            strSQL = "SELECT code_pro,name_pro,total_pro,price_buy,unit from sale_barcode where fix_id='" & Me.txtHideform.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Me.dgSRsale_detail.Rows.Clear()
            While Dr.Read
                With Me.dgSRsale_detail
                    Dim r As Integer
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells("code_pro").Value = Dr.Item("code_pro")
                    .Rows(r).Cells("name_pro").Value = Dr.Item("name_pro")
                    .Rows(r).Cells("total_pro").Value = Dr.Item("total_pro")
                    .Rows(r).Cells("price_buy").Value = Dr.Item("price_buy")
                    .Rows(r).Cells("unit").Value = Dr.Item("unit")
                    .Rows(r).Cells("total_all").Value = CDec(.Rows(r).Cells("price_buy").Value) * CDec(.Rows(r).Cells("total_pro").Value)
                End With
            End While
            'strSQL = "SELECT p_id,detail1,total1 from pledge_sale where customer_id='" & cusID & "'"
            'Mainfrm.lblMainStatus.Text = strSQL
            'Using cmd = New MySqlCommand(strSQL, ConnectionDB)
            '    Call open_connection()
            '    Dr = cmd.ExecuteReader
            '    Dim r As Integer
            '    While Dr.Read
            '        With dgSRsale_detail
            '            r = .RowCount
            '            .Rows.Add()
            '            .Rows(r).Cells("code_pro").Value = Dr.Item("p_id")
            '            .Rows(r).Cells("name_pro").Value = Dr.Item("detail1")
            '            .Rows(r).Cells("total_pro").Value = "1"
            '            .Rows(r).Cells("price_buy").Value = Dr.Item("total1")
            '            .Rows(r).Cells("unit").Value = "-"
            '            .Rows(r).Cells("total_all").Value = -CInt(.Rows(r).Cells("price_buy").Value)
            '        End With
            '    End While
            'End Using
            For sum As Integer = 0 To Me.dgSRsale_detail.Rows.Count - 1
                Me.dgSRsale_detail.Rows(sum).Cells(0).Value = sum + 1
            Next
            Dim sum1 As Decimal
            For x = 0 To Me.dgSRsale_detail.Rows.Count - 1
                sum1 += CDec(Me.dgSRsale_detail.Rows(x).Cells("total_all").Value)
            Next
            Me.txtSRfixPrice.Text = sum1
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub txtSRgetDataByFixID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSRgetDataByFixID.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call getDataFromFixid()
            If frn = "ส่งมาจากงานเคลม" Then
                Mainfrm.lblMainStatus.Text = "สินค้านี้เป็นสินค้าเคลมต้องส่งกลับไปที่งานเคลม โปรดทำส่งกลับในหน้า สถานะงานซ่อม"
                MsgBox("สินค้านี้เป็นสินค้าเคลมต้องส่งกลับไปที่งานเคลม โปรดทำส่งกลับในหน้าสถานะงานซ่อม", MsgBoxStyle.Information, "แจ้งเตือน")
                Me.Enabled = False
                Me.Close()
            Else
                Call getDatasale()
                Me.txtHideform.Text = Me.txtSRgetDataByFixID.Text
                Me.txtSRgetDataByFixID.Text = ""
            End If
        End If
    End Sub

    Private Sub txtSRsale_id_TextChanged(sender As Object, e As EventArgs) Handles txtSRsale_id.TextChanged
        Call getDatasale_Barcode()
    End Sub

    Private Sub btnSRgetDataByFixID_Click(sender As Object, e As EventArgs) Handles btnSRgetDataByFixID.Click
        Call getDataFromFixid()
        If frn = "ส่งมาจากงานเคลม" Then
            Mainfrm.lblMainStatus.Text = "สินค้านี้เป็นสินค้าเคลมต้องส่งกลับไปที่งานเคลม โปรดทำส่งกลับในหน้า สถานะงานซ่อม"
            MsgBox("สินค้านี้เป็นสินค้าเคลมต้องส่งกลับไปที่งานเคลม โปรดทำส่งกลับในหน้าสถานะงานซ่อม", MsgBoxStyle.Information, "แจ้งเตือน")
            Me.Enabled = False
            Me.Close()
        Else
            Call getDatasale()
            Me.txtHideform.Text = Me.txtSRgetDataByFixID.Text
            Me.txtSRgetDataByFixID.Text = ""
        End If
    End Sub

    Private Sub btnSRselectcomfix_Click(sender As Object, e As EventArgs) Handles btnSRselectcomfix.Click
        SearchRepairFrm.MdiParent = Mainfrm
        SearchRepairFrm.Show()
    End Sub

    Private Sub txtHideform_TextChanged(sender As Object, e As EventArgs) Handles txtHideform.TextChanged
        Call getDatasale_Barcode()
        Try
            Using dt = New DataTable
                strSQL = "SELECT fix_id,date_save,customer_id,customer_name,sn,symptom,managerdata,fixaccessory,date_get,status,user_repair,note_repair,teltocus from comfix where fix_id='" & Me.txtHideform.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)
                Me.lblSRcustomerDetail.Text = dt.Rows(0).Item("customer_name") & " รหัสลูกค้า: " & dt.Rows(0).Item("customer_id") & vbNewLine & " อาการเสีย: " & dt.Rows(0).Item("symptom") & " ช่างซ่อม: " & dt.Rows(0).Item("user_repair") & vbNewLine & " วันที่ส่งซ่อม: " & dt.Rows(0).Item("date_save") & " วันที่นัดรับเครื่อง: " & dt.Rows(0).Item("date_get")
                Me.txtSRfixRepairNote.Text = dt.Rows(0).Item("note_repair")
                Me.txtSRfixAccessory.Text = dt.Rows(0).Item("fixaccessory")
                Me.txtSRstatus.Text = dt.Rows(0).Item("status")
                cusID = dt.Rows(0).Item("customer_id")
                cusName = dt.Rows(0).Item("customer_name")
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Try
            Using dt = New DataTable
                strSQL = "SELECT sale_id FROM sale WHERE fix_id='" & Me.txtHideform.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)

                Me.txtSRsale_id.Text = dt.Rows(0).Item("sale_id")
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub cbbSRRcash_status_Click(sender As Object, e As EventArgs) Handles cbbSRRcash_status.Click
        Me.cbbSRRcash_status.Items.Clear()
        Me.cbbSRRcash_status.Items.Add("ชำระเงิน")
        Me.cbbSRRcash_status.Items.Add("ยังไม่ชำระเงิน")
    End Sub
    Private Sub notPayment()
        strSQL = "Update comfix SET status='" & "7 คืนเครื่องแล้ว" & "',date_send='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "' where fix_id='" & Me.txtHideform.Text & "'"
        Mainfrm.lblMainStatus.Text = strSQL
        cmd = New MySqlCommand(strSQL, ConnectionDB)
        Call open_connection()
        cmd.ExecuteNonQuery()

        Mainfrm.lblMainStatus.Text = "บันทึกส่งคืนเครื่องแล้ว"
    End Sub

    Private Sub btnSRsaveAndSend_Click(sender As Object, e As EventArgs) Handles btnSRsaveAndSend.Click
        Dim UpDateAns As String
        UpDateAns = MsgBox("คุณแน่ใจว่าจะคืนเครื่องซ่อมเครื่องนี้", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
        If UpDateAns = System.Windows.Forms.DialogResult.No Then
            Mainfrm.lblMainStatus.Text = "การคืนถูกยกเลิก"
            Exit Sub
        Else
            If Me.txtSRstatus.Text = "1 รอซ่อม" Or Me.txtSRstatus.Text = "4 ซ่อมไม่ได้" Or Me.txtSRstatus.Text = "5 ซ่อมเสร็จ" Or Me.txtSRstatus.Text = "6 ยกเลิกซ่อม" Then
                If Me.txtSRfixPrice.Text = "" Or Me.txtSRfixPrice.Text = "0" Or Me.txtSRfixPrice.Text = "-" Then
                    Call notPayment()
                    Mainfrm.lblMainStatus.Text = "รอสักครู่ กำลังเรียกฟอร์มการพิมพ์"
                    SendRepairPrintFrm.Show()

                    'If MessageBox.Show("บันทึกคืนเคื่องแล้ว" & vbNewLine & "ต้องการจะพิมพ์ใบส่งคืนเครื่องซ่อมหรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                    'End If

                    RepairStatusFrm.reLoadFrm()
                    Me.Close()
                Else
                    If Me.cbbSRRcash_status.Text = "" Then
                        MsgBox("เลือกการชำระเงินก่อน", MsgBoxStyle.Information, "แจ้งเตือน")
                        Me.lblSRpayment.BackColor = Color.Orange
                    ElseIf Me.cbbSRRcash_status.Text = "ชำระเงิน" Then
                        CashFrm.txtCashCusID.Text = cusID
                        CashFrm.txtCashFixID.Text = Me.txtHideform.Text
                        CashFrm.txtCashCash.Text = Me.txtSRfixPrice.Text
                        CashFrm.MdiParent = Mainfrm
                        CashFrm.Show()
                    ElseIf Me.cbbSRRcash_status.Text = "ยังไม่ชำระเงิน" Then
                        Call notPayment()
                        Mainfrm.lblMainStatus.Text = "รอสักครู่ กำลังเรียกฟอร์มการพิมพ์"
                        SendRepairPrintFrm.Show()
                        InvoiceReportFrm.Show()
                        Mainfrm.lblMainStatus.Text = "พร้อมใช้งาน"
                        'If MessageBox.Show("บันทึกคืนเคื่องแล้ว" & vbNewLine & "ต้องการจะพิมพ์ใบส่งของหรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        '    InvoiceReportFrm.Show()
                        'End If
                        RepairStatusFrm.reLoadFrm()
                        Me.Close()
                    End If
                End If
                If SendRepairPrintFrm.WindowState = FormWindowState.Normal Then
                    SendRepairPrintFrm.Activate()
                End If
            Else
                MsgBox("ต้องเป็นสถานะ ยกเลิกซ่อม, ซ่อมเสร็จ หรือ ซ่อมไม่ได้ ถึงจะทำคืนเครื่องได้ กรุณากลับไปกำหนดสถานะให้เรียบร้อยก่อน", MsgBoxStyle.Information, "แจ้งเตือน")
            End If
        End If
    End Sub

End Class