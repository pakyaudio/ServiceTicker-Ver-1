Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class ClaimsreceiveGroupFrm

    Private Sub ClaimsPrepareFrm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Call TRUNCATEdata()
    End Sub

    Private Sub ClaimsPrepareFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Icon = Mainfrm.Icon
    End Sub
    Dim staX As String
    Friend Sub getDataClaim()
        Mainfrm.lblMainStatus.Text = "ดึงข้อมูลสินค้าเคลม"
        Try
            strSQL = "SELECT `status` FROM claims WHERE serial_pro='" & Me.txtCRGsearchSN.Text & "' AND `status`='" & "ส่งเคลม" & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            If Dr.HasRows Then
                staX = Dr.GetString("status")
            Else

                MsgBox("ไม่พบข้อมูล " & Me.txtCRGsearchSN.Text, MsgBoxStyle.Information, "แจ้งเตือน")
                Me.txtCRGsearchSN.Clear()
                Me.txtCRGsearchSN.Focus()
                Exit Sub
            End If
        Catch ex As Exception

        End Try
        If staX = "ส่งเคลม" Then
            If Me.txtCRGsearchSN.Text = "" Then
            Else
                If Me.dgCRG.Rows.Count = 0 Then
                    Try
                        strSQL = "SELECT claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,`type`,unit,datetime_save FROM claims WHERE serial_pro='" & Me.txtCRGsearchSN.Text & "' AND `status`='" & "ส่งเคลม" & "'"
                        Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                            Call open_connection()
                            Dr = cmd.ExecuteReader()
                            Dim r As Integer
                            While (Dr.Read())
                                With Me.dgCRG
                                    r = .RowCount
                                    .Rows.Add()
                                    .Rows(r).Cells(1).Value = Dr.Item("claims_id")
                                    .Rows(r).Cells(2).Value = Dr.Item("customer_id")
                                    .Rows(r).Cells(3).Value = Dr.Item("code_pro")
                                    .Rows(r).Cells(4).Value = Dr.Item("bar_code")
                                    .Rows(r).Cells(5).Value = Dr.Item("serial_pro")
                                    .Rows(r).Cells(6).Value = Dr.Item("name_pro")
                                    .Rows(r).Cells(7).Value = Dr.Item("type")
                                    .Rows(r).Cells(8).Value = Dr.Item("unit")
                                    .Rows(r).Cells(9).Value = Dr.Item("datetime_save")
                                    Me.txtCRGlastSN.Text = Me.txtCRGsearchSN.Text
                                End With
                            End While
                        End Using
                    Catch ex As Exception

                    End Try
                    Me.txtCRGsearchSN.Clear()
                    Me.txtCRGsearchSN.Focus()
                Else
                    For g As Integer = 0 To dgCRG.Rows.Count - 1
                        If Me.dgCRG.Rows(g).Cells(5).Value = Me.txtCRGsearchSN.Text Then
                            MsgBox("มีข้อมูล " & Me.txtCRGsearchSN.Text & " อยู่ในตารางแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
                            Me.txtCRGsearchSN.Clear()
                            Me.txtCRGsearchSN.Focus()
                            Exit Sub
                        End If
                    Next
                    Try
                        strSQL = "SELECT claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,`type`,unit,datetime_save FROM claims WHERE serial_pro='" & Me.txtCRGsearchSN.Text & "'"
                        Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                            Call open_connection()
                            Dr = cmd.ExecuteReader()
                            Dim r As Integer
                            While (Dr.Read())
                                With Me.dgCRG
                                    r = .RowCount
                                    .Rows.Add()
                                    .Rows(r).Cells(1).Value = Dr.Item("claims_id")
                                    .Rows(r).Cells(2).Value = Dr.Item("customer_id")
                                    .Rows(r).Cells(3).Value = Dr.Item("code_pro")
                                    .Rows(r).Cells(4).Value = Dr.Item("bar_code")
                                    .Rows(r).Cells(5).Value = Dr.Item("serial_pro")
                                    .Rows(r).Cells(6).Value = Dr.Item("name_pro")
                                    .Rows(r).Cells(7).Value = Dr.Item("type")
                                    .Rows(r).Cells(8).Value = Dr.Item("unit")
                                    .Rows(r).Cells(9).Value = Dr.Item("datetime_save")
                                    Me.txtCRGlastSN.Text = Me.txtCRGsearchSN.Text
                                End With
                            End While
                        End Using
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ดึงข้อมูลสินค้าเคลมผิดพลาด " & ex.Message
                    End Try
                    Me.txtCRGsearchSN.Clear()
                    Me.txtCRGsearchSN.Focus()
                End If
            End If
        Else
            MsgBox("สินค้านี้มีสถานะ " & staX & " สินค้าต้องมีสถานะ ส่งเคลม เท่านั้น จึงจะสามารถรับสินค้าเคลมเข้าได้", MsgBoxStyle.Critical, "แจ้งเตือน")
            Me.txtCRGsearchSN.Clear()
            Me.txtCRGsearchSN.Focus()
        End If
        For ggg As Integer = 0 To dgCRG.Rows.Count - 1
            Me.dgCRG.Rows(ggg).Cells(0).Value = ggg + 1
            Me.txtCRGtotal.Text = ggg + 1
        Next
        Mainfrm.lblMainStatus.Text = "ดึงข้อมูลสินค้าเคลมเสร็จ"
    End Sub

    Private Sub InsertData()
        Try
            Mainfrm.lblMainStatus.Text = "เริ่มเปลี่ยนแปลงข้อมูลเคลม"
            For gg As Integer = 0 To dgCRG.Rows.Count - 1

                Dim n As String = Me.dgCRG.Rows(gg).Cells(1).Value
                strSQL = "INSERT INTO claims_send_report(claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,price_buy,price_wholesale,price_technician,price_loyal,price_members,`type`,unit,datetime_sale,datetime_return,datetime_edit,claims_money,employee_claims_return,tel_to_cus,employee_sale,symptom,accressory,note,note2,`status`,employee,datetime_save,claims_id_pic)" _
                    & "(SELECT * FROM claims WHERE claims_id='" & n & "')"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                'update claims status
                strSQL = "UPDATE claims SET status='" & "รอทดสอบ" & "',datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "',employee='" & Me.lblemployee.Text & "' WHERE claims_id='" & n & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                'update claims send status
                strSQL = "UPDATE claims_send SET claims_send_status='" & "รอทดสอบ" & "',datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "',employee='" & Me.lblemployee.Text & "' WHERE claims_id='" & n & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                n = Nothing
            Next

            ClaimsSendReportPrintFrm.Ctxt = 300
            ClaimsSendReportPrintFrm.MdiParent = Mainfrm
            ClaimsSendReportPrintFrm.Show()
            MsgBox("บันทึกข้อมูลแล้ว สินค้าจะอยู่ในสถานะรอทดสอบ", MsgBoxStyle.Information, "แจ้งเตือน")
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Me.dgCRG.Rows.Clear()
        Me.txtCRGtotal.Clear()
        Me.txtCRGlastSN.Clear()
        Mainfrm.lblMainStatus.Text = "เปลี่ยนแปลงข้อมูลเคลมเสร็จ"
        Call TRUNCATEdata()
    End Sub
    Private Sub TRUNCATEdata()
        Try
            Mainfrm.lblMainStatus.Text = "ลบข้อมูลเคลมชั่วคราว"
            strSQL = "TRUNCATE `claims_send_report`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            Mainfrm.lblMainStatus.Text = "ลบข้อมูลเคลมชั่วคราวเสร็จ"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtCPsearchSN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCRGsearchSN.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtCRGsearchSN.Text = "" Then
            Else
                Call getDataClaim()
            End If
        End If
    End Sub

    Private Sub btnCPsave_Click(sender As Object, e As EventArgs) Handles btnCRGsave.Click
        If Me.dgCRG.Rows.Count = 0 Then
            MsgBox("ยังไม่มีข้อมูลเคลมในตาราง", MsgBoxStyle.Exclamation, "No Data")
        Else
            If MessageBox.Show("โปรดแน่ใจว่าข้อมูลถูกต้องก่อนการบันทึก คุณต้องการจะบันทึกข้อมูลหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Call InsertData()
            Else
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ClaimsTestResultsSelectSNFrm1.MdiParent = Mainfrm
        ClaimsTestResultsSelectSNFrm1.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtCRGlastSN_TextChanged(sender As Object, e As EventArgs) Handles txtCRGlastSN.TextChanged

    End Sub

    Private Sub txtCRGtotal_TextChanged(sender As Object, e As EventArgs) Handles txtCRGtotal.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class