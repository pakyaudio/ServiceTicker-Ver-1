Imports MySql.Data.MySqlClient
Imports System.Globalization
Public Class ClaimsSendGroupFrm
   
    Private Sub AutoNumberNo()
        Try
            Mainfrm.lblMainStatus.Text = "โหลด ID"
            strSQL = "SELECT Max(ID) as ID FROM claims_lot_id"
            dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                Me.txtCSGlotNum.Text = Now.ToString("yyyyMMddHHmmss") & "00001"
            Else
                Dim newID As Integer = CInt(Dr.Item("ID"))
                newID += 1
                Me.txtCSGlotNum.Text = newID.ToString("0000")
            End If
            Dr.Close()
            Mainfrm.lblMainStatus.Text = "โหลด ID แล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "โหลด ID ผิดพลาด"
        End Try
    End Sub

    Private Sub ClaimsPrepareFrm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Call TRUNCATEdata()
    End Sub

    Private Sub ClaimsPrepareFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Icon = Mainfrm.Icon
        Call AutoNumberNo()
        ' Me.lblCSGemployee.Text = Mainfrm.userClaimsPrepare
    End Sub
    Dim staX As String
    Private Sub getDataClaim()
        Mainfrm.lblMainStatus.Text = "ดึงข้อมูลสินค้าเคลม"
        Try
            strSQL = "SELECT status FROM claims WHERE serial_pro='" & Me.txtCSGsearchSN.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            If Dr.HasRows Then
                staX = Dr.GetString("status")
            Else

                MsgBox("ไม่พบข้อมูล " & Me.txtCSGsearchSN.Text, MsgBoxStyle.Information, "แจ้งเตือน")
                Me.txtCSGsearchSN.Clear()
                Me.txtCSGsearchSN.Focus()
                Exit Sub
            End If
        Catch ex As Exception

        End Try
        If staX = "เตรียมส่งเคลม" Then
            If Me.txtCSGsearchSN.Text = "" Then
            Else
                If Me.dgCSG.Rows.Count = 0 Then
                    Try
                        strSQL = "SELECT claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,`type`,unit,datetime_save FROM claims WHERE serial_pro='" & Me.txtCSGsearchSN.Text & "' AND `status`='" & "เตรียมส่งเคลม" & "'"
                        Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                            Call open_connection()
                            Dr = cmd.ExecuteReader()
                            Dim r As Integer
                            While (Dr.Read())
                                With Me.dgCSG
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
                                    Me.txtCSGlastSN.Text = Me.txtCSGsearchSN.Text
                                End With
                            End While
                        End Using
                    Catch ex As Exception

                    End Try
                    Me.txtCSGsearchSN.Clear()
                    Me.txtCSGsearchSN.Focus()
                Else
                    For g As Integer = 0 To dgCSG.Rows.Count - 1
                        If Me.dgCSG.Rows(g).Cells(5).Value = Me.txtCSGsearchSN.Text Then
                            MsgBox("มีข้อมูล " & Me.txtCSGsearchSN.Text & " อยู่ในตารางแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
                            Me.txtCSGsearchSN.Clear()
                            Me.txtCSGsearchSN.Focus()
                            Exit Sub
                        End If
                    Next
                    Try
                        strSQL = "SELECT claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,`type`,unit,datetime_save FROM claims WHERE serial_pro='" & Me.txtCSGsearchSN.Text & "' AND `status`='" & "เตรียมส่งเคลม" & "'"
                        Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                            Call open_connection()
                            Dr = cmd.ExecuteReader()
                            Dim r As Integer
                            While (Dr.Read())
                                With Me.dgCSG
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
                                    Me.txtCSGlastSN.Text = Me.txtCSGsearchSN.Text
                                End With
                            End While
                        End Using
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ดึงข้อมูลสินค้าเคลมผิดพลาด " & ex.Message
                    End Try
                    Me.txtCSGsearchSN.Clear()
                    Me.txtCSGsearchSN.Focus()
                End If
            End If
        Else
            MsgBox("สินค้านี้มีสถานะ " & staX & " สินค้าต้องมีสถานะ ส่งเคลม เท่านั้น จึงจะสามารถทำส่งเคลมได้", MsgBoxStyle.Critical, "แจ้งเตือน")
            Me.txtCSGsearchSN.Clear()
            Me.txtCSGsearchSN.Focus()
        End If
        For ggg As Integer = 0 To dgCSG.Rows.Count - 1
            Me.dgCSG.Rows(ggg).Cells(0).Value = ggg + 1
            Me.txtCSGtotal.Text = ggg + 1
        Next
        Mainfrm.lblMainStatus.Text = "ดึงข้อมูลสินค้าเคลมเสร็จ"
    End Sub

    Private Sub InsertData()
        Try
            Call TRUNCATEdata()
            Mainfrm.lblMainStatus.Text = "เริ่มเปลี่ยนแปลงข้อมูลเคลม"
            For gg As Integer = 0 To dgCSG.Rows.Count - 1
                Dim n As String = Me.dgCSG.Rows(gg).Cells(1).Value
                'update claims status
                strSQL = "UPDATE claims SET status='" & "ส่งเคลม" & "',datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "',employee='" & Me.lblemployee.Text & "' WHERE claims_id='" & n & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                'update claims send status
                strSQL = "UPDATE claims_send SET claims_send_status='" & "ส่งเคลม" & "',claims_lot='" & Me.txtCSGlotNum.Text & "',datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "',employee='" & Me.lblemployee.Text & "' WHERE claims_id='" & n & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                strSQL = "INSERT INTO claims_send_report(claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,price_buy,price_wholesale,price_technician,price_loyal,price_members,`type`,unit,datetime_sale,datetime_return,datetime_edit,claims_money,employee_claims_return,tel_to_cus,employee_sale,symptom,accressory,note,note2,`status`,employee,datetime_save,claims_id_pic)" _
                    & "(SELECT * FROM claims WHERE claims_id='" & n & "')"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                n = Nothing
            Next
            'อัพเดท claims_lot_id
            strSQL = "INSERT INTO claims_lot_id(claims_lot,datetime_save)VALUES('" & Me.txtCSGlotNum.Text & "',datetime_save='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "')"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            ClaimsSendReportPrintFrm.Ctxt = 200
            ClaimsSendReportPrintFrm.MdiParent = Mainfrm
            ClaimsSendReportPrintFrm.Show()
            MsgBox("บันทึกเตรียมส่งเคลมแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Me.dgCSG.Rows.Clear()
        Me.txtCSGtotal.Clear()
        Me.txtCSGlastSN.Clear()
        Mainfrm.lblMainStatus.Text = "เปลี่ยนแปลงข้อมูลเคลมเสร็จ"
        Call TRUNCATEdata()
        Call AutoNumberNo()
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
    Private Sub txtCPsearchSN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCSGsearchSN.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call getDataClaim()
        End If
    End Sub

    Private Sub btnCPsave_Click(sender As Object, e As EventArgs) Handles btnCSGsave.Click
        If Me.dgCSG.Rows.Count = 0 Then
            MsgBox("ยังไม่มีข้อมูลเคลมในตาราง", MsgBoxStyle.Exclamation, "No Data")
        Else
            If MessageBox.Show("โปรดแน่ใจว่าข้อมูลถูกต้องก่อนการบันทึก คุณต้องการจะบันทึกข้อมูลหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Call InsertData()
            Else
            End If
        End If
    End Sub

    Private Sub btnCSGprintBoxcover_Click(sender As Object, e As EventArgs) Handles btnCSGprintBoxcover.Click
        BoxCoverFrm.MdiParent = Mainfrm
        BoxCoverFrm.Show()
    End Sub
End Class