Imports MySql.Data.MySqlClient
Imports System.Globalization

'เสร็จ      2014/12/21
'ปรับปรุง    2016/01/05
Public Class RepairStatusFrm
    Dim strSelect As Integer


    Friend Sub getStatusAll()
        Try
            strSQL = "select count(status) from comfix where status='1 รอซ่อม';"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.btnRSstatus1.Text = "รอซ่อม (" & Dr(0).ToString & ")"
            End While
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try

        Try
            strSQL = "select count(status) from comfix where status='2 กำลังซ่อม';"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.btnRSstatus2.Text = "กำลังซ่อม (" & Dr(0).ToString & ")"
            End While
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try

        Try
            strSQL = "select count(status) from comfix where status='3 รออะไหล่/ส่งเคลม';"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.btnRSstatus3.Text = "รออะไหล่/ส่งเคลม (" & Dr(0).ToString & ")"
            End While
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try

        Try
            strSQL = "select count(status) from comfix where status='4 ซ่อมไม่ได้';"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.btnRSstatus4.Text = "ซ่อมไม่ได้ (" & Dr(0).ToString & ")"
            End While
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try

        Try
            strSQL = "select count(status) from comfix where status='5 ซ่อมเสร็จ';"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.btnRSstatus5.Text = "ซ่อมเสร็จ (" & Dr(0).ToString & ")"
            End While
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try

        Try
            strSQL = "select count(status) from comfix where status='6 ยกเลิกซ่อม';"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.btnRSstatus6.Text = "ยกเลิกซ่อม (" & Dr(0).ToString & ")"
            End While
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    
    'start getdata_record dgRSstatus1
    Private Sub updateDataStatus_dgRSstatus1()
        If Me.cbbRSstatus.Text = "" Then
            MsgBox("กรุณาระบุสถานะ", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.cbbRSstatus.Focus()
            Me.cbbRSstatus.BackColor = Color.Salmon
            Exit Sub
        End If
        If Me.cbbRSuser_repair.Text = "" Then
            MsgBox("กรุณาระบุช่างซ่อม", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.cbbRSuser_repair.Focus()
            Me.cbbRSuser_repair.BackColor = Color.Salmon
            Exit Sub
        End If
        If Me.cbbRSteltocus.Text = "" Then
            MsgBox("กรุณาระบุการแจ้งลูกค้า", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.cbbRSteltocus.Focus()
            Me.cbbRSteltocus.BackColor = Color.Salmon
            Exit Sub
        End If

        If Me.cbbRSvaruntee.Text = "" Then
            MsgBox("กรุณาระบุการรับประกัน", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.cbbRSvaruntee.Focus()
            Me.cbbRSvaruntee.BackColor = Color.Salmon
            Exit Sub
        End If
        If Me.txtRSnote_repair.Text = "" Then
            MsgBox("กรุณาใส่รายละเอียดการซ่อม หากไม่มีให้ใส - ", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.txtRSnote_repair.Focus()
            Me.txtRSnote_repair.BackColor = Color.Salmon
            Exit Sub
        End If
        If Me.cbbRSstorage.Text = "" Then
            MsgBox("กรุณาใส่สถานที่เก็บ หากไม่มีให้ใส - ", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.cbbRSstorage.Focus()
            Me.cbbRSstorage.BackColor = Color.Salmon
            Exit Sub
        End If

        If Me.dgRSstatus1.SelectedCells.Item(17).Value = "7 คืนเครื่องแล้ว" Then
            MsgBox("สถานะคืนเครื่องแล้ว ไม่สามารถบันทึกข้อมูลได้อีก นอกจากรับเข้าระบบใหม่", MsgBoxStyle.Information, "แจ้งเตือน")
        Else
            Dim UpDateAns As String
            UpDateAns = MsgBox("คุณแน่ใจว่าจะบันทึกข้อมูลนี้", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
            If UpDateAns = System.Windows.Forms.DialogResult.No Then
                MsgBox("การบันทึกข้อมูลถูกยกเลิก.", MsgBoxStyle.Information, "ยกเลิกการบันทึก")
                Call startfrm()
            Else
                If Me.dgRSstatus1.SelectedCells.Item(13).Value = "ส่งมาจากงานเคลม" Then
                    Try
                        Dim cl_id As String
                        strSQL = "SELECT claims_id FROM comfix WHERE fix_id='" & Me.dgRSstatus1.SelectedCells.Item(1).Value & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        Dr = cmd.ExecuteReader()
                        Dr.Read()
                        cl_id = Dr.Item("claims_id")


                        strSQL = "UPDATE claims SET note='" & Me.txtRSnote_repair.Text & "', datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "'" _
                            & "WHERE claims_id='" & cl_id & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()


                        strSQL = "Update comfix set status = '" & Me.cbbRSstatus.Text & "', user_repair='" & Me.cbbRSuser_repair.Text & "', " _
                            & "varuntee='" & Me.cbbRSvaruntee.Text & "', note_repair='" & Me.txtRSnote_repair.Text & "', teltocus='" & Me.cbbRSteltocus.Text & "', storage='" & Me.cbbRSstorage.Text & "', " _
                            & "datecom_repair='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "' where fix_id= '" & Me.txtRSfix_id.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                        MsgBox("บันทึกข้อมูลเรียบร้อยแล้ว.", MsgBoxStyle.Information, "ยืนยัน")
                        cl_id = Nothing
                        Call startfrm()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try
                Else
                    Try
                        strSQL = "Update comfix set status = '" & Me.cbbRSstatus.Text & "', user_repair='" & Me.cbbRSuser_repair.Text & "', " _
                            & "varuntee='" & Me.cbbRSvaruntee.Text & "', note_repair='" & Me.txtRSnote_repair.Text & "', teltocus='" & Me.cbbRSteltocus.Text & "', storage='" & Me.cbbRSstorage.Text & "', " _
                            & "datecom_repair='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "' where fix_id= '" & Me.txtRSfix_id.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                        MsgBox("บันทึกข้อมูลเรียบร้อยแล้ว.", MsgBoxStyle.Information, "ยืนยัน")
                        Call startfrm()
                        Call getdata_dgRSstatus1()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try
                End If
            End If
        End If

    End Sub

    Private Sub startfrm()
        Call getStatusAll()
        Me.cbbRSstatus.Enabled = False
        Me.cbbRSuser_repair.Enabled = False
        Me.cbbRSteltocus.Enabled = False
        Me.btnRSPartsWithdrawal.Enabled = False
        Me.cbbRSvaruntee.Enabled = False
        Me.btnRSviewProduct.Enabled = False
        Me.btnRSsave.Enabled = False
        Me.txtRSnote_repair.Enabled = False
        Me.cbbRSstorage.Enabled = False
        Me.txtRSnote_repair.Text = "-"
        Me.cbbRSstatus.Items.Clear()
        Me.cbbRSuser_repair.Items.Clear()
        Me.cbbRSvaruntee.Items.Clear()
        Me.txtRSfix_id.Clear()
        Me.txtRScus_id.Clear()
        Me.txtRScus_name.Clear()
        Me.txtRScus_tel.Clear()
        Me.dgRSstatus1.Refresh()
        Call ClearTextBoxes(Me)
        Call getdatacombobox_repair_status()
        Call getdatacombobox_fix_user()
        Call getdatacombobox_varuntee()
        Me.btnRSsend_to_claims.Enabled = False
        Me.lblRSsaleDetail.Text = "Sale Detail"
        Me.btnSRsendRepair.Visible = False
        Call Imp()
    End Sub
    Private Sub getdatacombobox_repair_status()
        Try
            strSQL = "select status from repair_status"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand
            cmd.CommandText = strSQL
            cmd.Connection = ConnectionDB
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                cbbRSstatus.Items.Add(Dr("status"))
            End While
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub getdatacombobox_fix_user()
        Try
            strSQL = "select user_name from users"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand
            cmd.CommandText = strSQL
            cmd.Connection = ConnectionDB
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                cbbRSuser_repair.Items.Add(Dr("user_name"))
            End While
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub getdatacombobox_varuntee()
        Try
            strSQL = "select varuntee_status from varuntee"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand
            cmd.CommandText = strSQL
            cmd.Connection = ConnectionDB
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                cbbRSvaruntee.Items.Add(Dr("varuntee_status"))
            End While
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub Imp()
        If Me.dgRSstatus1.RowCount = 0 Then
        Else
            Me.dgRSstatus1.ClearSelection()
            For i As Integer = 0 To dgRSstatus1.Rows.Count - 1
                If dgRSstatus1.Rows(i).Cells(22).Value = "เร่งด่วน" Then
                    dgRSstatus1.Rows(i).DefaultCellStyle.BackColor = Color.Salmon
                End If
            Next
        End If
    End Sub

    Private Sub getdata_dgRSstatus1()
        Try
        Me.dgRSstatus1.Rows.Clear()
        If strSelect = 10 Then
            strSQL = "SELECT fix_id,date_save,customer_id,sn,symptom,managerdata,fixrepairnote,fixaccessory,fixnote,fixtprice," _
                     & "varuntee,date_get,fixuser,status,user_repair,note_repair,teltocus,datecom_repair,importune,storage FROM comfix WHERE status='" & "1 รอซ่อม" & "'"
            Mainfrm.lblMainStatus.Text = strSQL
        ElseIf strSelect = 20 Then
            strSQL = "SELECT fix_id,date_save,customer_id,sn,symptom,managerdata,fixrepairnote,fixaccessory,fixnote,fixtprice," _
                   & "varuntee,date_get,fixuser,status,user_repair,note_repair,teltocus,datecom_repair,importune,storage FROM comfix WHERE status='" & "2 กำลังซ่อม" & "'"
            Mainfrm.lblMainStatus.Text = strSQL
        ElseIf strSelect = 30 Then
            strSQL = "SELECT fix_id,date_save,customer_id,sn,symptom,managerdata,fixrepairnote,fixaccessory,fixnote,fixtprice," _
                   & "varuntee,date_get,fixuser,status,user_repair,note_repair,teltocus,datecom_repair,importune,storage FROM comfix WHERE status='" & "3 รออะไหล่/ส่งเคลม" & "'"
            Mainfrm.lblMainStatus.Text = strSQL
        ElseIf strSelect = 40 Then
            strSQL = "SELECT fix_id,date_save,customer_id,sn,symptom,managerdata,fixrepairnote,fixaccessory,fixnote,fixtprice," _
                   & "varuntee,date_get,fixuser,status,user_repair,note_repair,teltocus,datecom_repair,importune,storage FROM comfix WHERE status='" & "4 ซ่อมไม่ได้" & "'"
            Mainfrm.lblMainStatus.Text = strSQL
        ElseIf strSelect = 50 Then
            strSQL = "SELECT fix_id,date_save,customer_id,sn,symptom,managerdata,fixrepairnote,fixaccessory,fixnote,fixtprice," _
                   & "varuntee,date_get,fixuser,status,user_repair,note_repair,teltocus,datecom_repair,importune,storage FROM comfix WHERE status='" & "5 ซ่อมเสร็จ" & "'"
            Mainfrm.lblMainStatus.Text = strSQL
        ElseIf strSelect = 60 Then
            strSQL = "SELECT fix_id,date_save,customer_id,sn,symptom,managerdata,fixrepairnote,fixaccessory,fixnote,fixtprice," _
                   & "varuntee,date_get,fixuser,status,user_repair,note_repair,teltocus,datecom_repair,importune,storage FROM comfix WHERE status='" & "6 ยกเลิกซ่อม" & "'"
            Mainfrm.lblMainStatus.Text = strSQL
        ElseIf strSelect = 70 Then
            strSQL = "SELECT fix_id,date_save,customer_id,sn,symptom,managerdata,fixrepairnote,fixaccessory,fixnote,fixtprice," _
                   & "varuntee,date_get,fixuser,status,user_repair,note_repair,teltocus,datecom_repair,importune,storage FROM comfix WHERE status='" & "7 คืนเครื่องแล้ว" & "'"
            Mainfrm.lblMainStatus.Text = strSQL
        End If
        cmd = New MySqlCommand(strSQL, ConnectionDB)
        Call open_connection()
        Dr = cmd.ExecuteReader
        While (Dr.Read())
            Dim rs As Integer
            With Me.dgRSstatus1
                rs = .RowCount
                .Rows.Add()
                .Rows(rs).Cells(1).Value = Dr.GetString("fix_id")
                .Rows(rs).Cells(2).Value = Dr.GetString("date_save")
                .Rows(rs).Cells(3).Value = Dr.GetString("customer_id")
                .Rows(rs).Cells(5).Value = Dr.GetString("sn")
                .Rows(rs).Cells(9).Value = Dr.GetString("symptom")
                .Rows(rs).Cells(10).Value = Dr.GetString("managerdata")
                .Rows(rs).Cells(11).Value = Dr.GetString("fixrepairnote")
                .Rows(rs).Cells(12).Value = Dr.GetString("fixaccessory")
                .Rows(rs).Cells(13).Value = Dr.GetString("fixnote")
                .Rows(rs).Cells(14).Value = Dr.GetString("fixtprice")
                .Rows(rs).Cells(15).Value = Dr.GetString("date_get")
                .Rows(rs).Cells(16).Value = Dr.GetString("fixuser")
                .Rows(rs).Cells(17).Value = Dr.GetString("status")
                .Rows(rs).Cells(18).Value = Dr.GetString("user_repair")
                .Rows(rs).Cells(19).Value = Dr.GetString("note_repair")
                .Rows(rs).Cells(20).Value = Dr.GetString("teltocus")
                .Rows(rs).Cells(21).Value = Dr.GetString("datecom_repair")
                .Rows(rs).Cells(22).Value = Dr.GetString("importune")
                .Rows(rs).Cells(23).Value = Dr.GetString("storage")
                .Rows(rs).Cells(24).Value = Dr.GetString("varuntee")
            End With
            End While
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try

        For ro As Integer = 0 To Me.dgRSstatus1.Rows.Count - 1
            Try
                Me.dgRSstatus1.Rows(ro).Cells(0).Value = ro + 1
                strSQL = "SELECT customer_name FROM customer WHERE customer_id='" & Me.dgRSstatus1.Rows(ro).Cells(3).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgRSstatus1
                    .Rows(ro).Cells(4).Value = Dr.GetString("customer_name")
                End With
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                Me.dgRSstatus1.Rows(ro).Cells(4).Value = "##ไม่พบข้อมูล##"
            End Try
        Next


        For nsn As Integer = 0 To Me.dgRSstatus1.Rows.Count - 1
            Try
                strSQL = "SELECT p_type,p_name,model FROM `sn` WHERE Snum='" & Me.dgRSstatus1.Rows(nsn).Cells(5).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgRSstatus1
                    .Rows(nsn).Cells(6).Value = Dr.GetString("p_type")
                    .Rows(nsn).Cells(7).Value = Dr.GetString("p_name")
                    .Rows(nsn).Cells(8).Value = Dr.GetString("model")
                End With
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                Me.dgRSstatus1.Rows(nsn).Cells(6).Value = "##ไม่พบข้อมูล##"
                Me.dgRSstatus1.Rows(nsn).Cells(7).Value = "##ไม่พบข้อมูล##"
                Me.dgRSstatus1.Rows(nsn).Cells(8).Value = "##ไม่พบข้อมูล##"
            End Try
        Next

        Call Imp()
    End Sub
    
    Private Sub showmeUnderDataGrid()
        Me.txtRSfix_id.Text = Me.dgRSstatus1.SelectedCells(1).Value
        Me.txtRScus_id.Text = Me.dgRSstatus1.SelectedCells(3).Value
        Me.txtRScus_name.Text = Me.dgRSstatus1.SelectedCells(4).Value
        Me.cbbRSstatus.Text = Me.dgRSstatus1.SelectedCells(17).Value
        Me.cbbRSuser_repair.Text = Me.dgRSstatus1.SelectedCells(18).Value
        Me.cbbRSvaruntee.Text = Me.dgRSstatus1.SelectedCells(24).Value
        Me.cbbRSstorage.Text = Me.dgRSstatus1.SelectedCells(23).Value
        Me.txtRSnote_repair.Text = Me.dgRSstatus1.SelectedCells(19).Value
        Me.cbbRSteltocus.Text = Me.dgRSstatus1.SelectedCells(20).Value
        Me.btnRSPartsWithdrawal.Enabled = True
    End Sub
    Private Sub get_sale_id()
        Dim sumTTA As Decimal
        Dim cusidff As Decimal
        Dim countpd As Decimal
        Dim countTTA As Decimal

        Dim fixid As String = Me.txtRSfix_id.Text
        Try
            strSQL = "SELECT SUM(total_all) AS ttl FROM sale WHERE fix_id='" & fixid & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            sumTTA = Dr.GetDecimal("ttl")
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            sumTTA = 0
        End Try
        Try
            strSQL = "SELECT COUNT(fix_id) AS fid FROM sale WHERE fix_id='" & fixid & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            countTTA = Dr.GetDecimal("fid")
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            countTTA = 0
        End Try
        Try
            strSQL = "SELECT SUM(total1) AS tt1 FROM pledge_sale WHERE customer_id='" & Me.txtRScus_id.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            cusidff = Dr.GetDecimal("tt1")
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            cusidff = 0
        End Try


        Try
            strSQL = "SELECT COUNT(customer_id) AS cid FROM pledge_sale WHERE customer_id='" & Me.txtRScus_id.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            countpd = Dr.GetDecimal("cid")
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            countpd = 0
        End Try
        Dim sat As Decimal = sumTTA - cusidff
        If Me.dgRSstatus1.SelectedCells.Item(17).Value = "7 คืนเครื่องแล้ว" Then
            Me.lblRSsaleDetail.Text = "คืนเครื่องแล้ว"
        Else
            Me.lblRSsaleDetail.Text = "พบรายการใบเบิกจำนวน " & countTTA & " ใบ " & vbNewLine & "รวมราคาทั้งหมด " & sumTTA.ToString("N2") & " บาท" & vbNewLine & _
                                        "พบใบมัดจำ/ลดหนี้ จำนวน " & countpd & " ใบ " & " รวมราคา " & cusidff.ToString("N2") & " บาท" & vbNewLine & _
                                        "รวมราคาที่ต้องชำระทั้งหมด " & sat.ToString("N2") & " บาท"

        End If
    End Sub
    Private Sub claimss()
        If Me.dgRSstatus1.Rows.Count = 0 Then
            Me.lblRSclaims.Text = ""
        Else
            If Me.dgRSstatus1.SelectedCells.Item(11).Value = "ส่งมาจากงานเคลม" Then
                Me.lblRSclaims.Text = "สินค้าจากงานเคลม"
                Timer1.Start()
            Else
                Me.lblRSclaims.Text = ""
            End If
        End If
       
    End Sub

    Private Sub dgRSstatus1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgRSstatus1.CellContentDoubleClick
        If Me.dgRSstatus1.Rows.Count = 0 Then
            Exit Sub
        End If
        Call showmeUnderDataGrid()
        Me.cbbRSstatus.Enabled = True
        Me.cbbRSuser_repair.Enabled = True
        Me.cbbRSteltocus.Enabled = True
        Me.btnRSPartsWithdrawal.Enabled = True
        Me.cbbRSvaruntee.Enabled = True
        Me.btnRSsave.Enabled = True
        Me.txtRSnote_repair.Enabled = True
        Me.btnRSviewProduct.Enabled = True
        Me.cbbRSstorage.Enabled = True
        If Me.btnRSstatus5.BackColor = Color.BlueViolet Or Me.btnRSstatus6.BackColor = Color.BlueViolet _
            Or Me.btnRSstatus4.BackColor = Color.BlueViolet Then
            Me.btnSRsendRepair.Visible = True
        End If
        Call get_sale_id()
        Call claimss()
    End Sub

    Private Sub btnRSsave_Click(sender As Object, e As EventArgs) Handles btnRSsave.Click
        Call updateDataStatus_dgRSstatus1()
    End Sub

    Private Sub btnRSclose_Click(sender As Object, e As EventArgs) Handles btnRSclose.Click
        Me.Close()
    End Sub

    Private Sub RepairStatusFrm_Click(sender As Object, e As EventArgs) Handles Me.Click
        If AddRepairNoteFrm.WindowState = FormWindowState.Normal Then
            AddRepairNoteFrm.Close()
        End If
    End Sub

    Friend Sub reLoadFrm()
        Call startfrm()
        Me.Icon = Mainfrm.Icon
        strSelect = 10
        Call getdata_dgRSstatus1()
        Me.lblStatusText.Text = "กำลังอยู่ที่สถานะรอซ่อม"
        Me.btnRSstatus1.BackColor = Color.BlueViolet
        Me.btnRSstatus2.BackColor = Color.Azure
        Me.btnRSstatus3.BackColor = Color.Azure
        Me.btnRSstatus4.BackColor = Color.Azure
        Me.btnRSstatus5.BackColor = Color.Azure
        Me.btnRSstatus6.BackColor = Color.Azure
        Me.btnRSstatus7.BackColor = Color.Azure

        Me.btnRSstatus1.ForeColor = Color.White
        Me.btnRSstatus2.ForeColor = Color.Black
        Me.btnRSstatus3.ForeColor = Color.Black
        Me.btnRSstatus4.ForeColor = Color.Black
        Me.btnRSstatus5.ForeColor = Color.Black
        Me.btnRSstatus6.ForeColor = Color.Black
        Me.btnRSstatus7.ForeColor = Color.Black
    End Sub
    Private Sub RepairStatusfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call startfrm()
        Me.Icon = Mainfrm.Icon
        strSelect = 10
        Call getdata_dgRSstatus1()
        Me.lblStatusText.Text = "กำลังอยู่ที่สถานะรอซ่อม"
        Me.btnRSstatus1.BackColor = Color.BlueViolet
        Me.btnRSstatus2.BackColor = Color.Azure
        Me.btnRSstatus3.BackColor = Color.Azure
        Me.btnRSstatus4.BackColor = Color.Azure
        Me.btnRSstatus5.BackColor = Color.Azure
        Me.btnRSstatus6.BackColor = Color.Azure
        Me.btnRSstatus7.BackColor = Color.Azure

        Me.btnRSstatus1.ForeColor = Color.White
        Me.btnRSstatus2.ForeColor = Color.Black
        Me.btnRSstatus3.ForeColor = Color.Black
        Me.btnRSstatus4.ForeColor = Color.Black
        Me.btnRSstatus5.ForeColor = Color.Black
        Me.btnRSstatus6.ForeColor = Color.Black
        Me.btnRSstatus7.ForeColor = Color.Black

    End Sub
    Private Sub btnRSstatus2_Click(sender As Object, e As EventArgs) Handles btnRSstatus2.Click
        Call startfrm()
        strSelect = 20
        Call getdata_dgRSstatus1()
        Me.lblStatusText.Text = "กำลังอยู่ที่สถานะกำลังซ่อม"
        Me.btnRSstatus1.BackColor = Color.Azure
        Me.btnRSstatus2.BackColor = Color.BlueViolet
        Me.btnRSstatus3.BackColor = Color.Azure
        Me.btnRSstatus4.BackColor = Color.Azure
        Me.btnRSstatus5.BackColor = Color.Azure
        Me.btnRSstatus6.BackColor = Color.Azure
        Me.btnRSstatus7.BackColor = Color.Azure

        Me.btnRSstatus1.ForeColor = Color.Black
        Me.btnRSstatus2.ForeColor = Color.White
        Me.btnRSstatus3.ForeColor = Color.Black
        Me.btnRSstatus4.ForeColor = Color.Black
        Me.btnRSstatus5.ForeColor = Color.Black
        Me.btnRSstatus6.ForeColor = Color.Black
        Me.btnRSstatus7.ForeColor = Color.Black

        Call Imp()
    End Sub

    Private Sub btnRSstatus1_Click(sender As Object, e As EventArgs) Handles btnRSstatus1.Click
        Call startfrm()
        strSelect = 10
        Call getdata_dgRSstatus1()
        Me.lblStatusText.Text = "กำลังอยู่ที่สถานะรอซ่อม"
        Me.btnRSstatus1.BackColor = Color.BlueViolet
        Me.btnRSstatus2.BackColor = Color.Azure
        Me.btnRSstatus3.BackColor = Color.Azure
        Me.btnRSstatus4.BackColor = Color.Azure
        Me.btnRSstatus5.BackColor = Color.Azure
        Me.btnRSstatus6.BackColor = Color.Azure
        Me.btnRSstatus7.BackColor = Color.Azure

        Me.btnRSstatus1.ForeColor = Color.White
        Me.btnRSstatus2.ForeColor = Color.Black
        Me.btnRSstatus3.ForeColor = Color.Black
        Me.btnRSstatus4.ForeColor = Color.Black
        Me.btnRSstatus5.ForeColor = Color.Black
        Me.btnRSstatus6.ForeColor = Color.Black
        Me.btnRSstatus7.ForeColor = Color.Black

    End Sub

    Private Sub btnRSstatus3_Click(sender As Object, e As EventArgs) Handles btnRSstatus3.Click
        Call startfrm()
        strSelect = 30
        Call getdata_dgRSstatus1()
        Me.lblStatusText.Text = "กำลังอยู่ที่สถานะรออะไหล่/ส่งเคลม"
        Me.btnRSstatus1.BackColor = Color.Azure
        Me.btnRSstatus2.BackColor = Color.Azure
        Me.btnRSstatus3.BackColor = Color.BlueViolet
        Me.btnRSstatus4.BackColor = Color.Azure
        Me.btnRSstatus5.BackColor = Color.Azure
        Me.btnRSstatus6.BackColor = Color.Azure
        Me.btnRSstatus7.BackColor = Color.Azure

        Me.btnRSstatus1.ForeColor = Color.Black
        Me.btnRSstatus2.ForeColor = Color.Black
        Me.btnRSstatus3.ForeColor = Color.White
        Me.btnRSstatus4.ForeColor = Color.Black
        Me.btnRSstatus5.ForeColor = Color.Black
        Me.btnRSstatus6.ForeColor = Color.Black
        Me.btnRSstatus7.ForeColor = Color.Black

    End Sub

    Private Sub btnRSstatus4_Click(sender As Object, e As EventArgs) Handles btnRSstatus4.Click
        Call startfrm()
        strSelect = 40
        Call getdata_dgRSstatus1()
        Me.lblStatusText.Text = "กำลังอยู่ที่สถานะซ่อมไม่ได้"
        Me.btnRSstatus1.BackColor = Color.Azure
        Me.btnRSstatus2.BackColor = Color.Azure
        Me.btnRSstatus3.BackColor = Color.Azure
        Me.btnRSstatus4.BackColor = Color.BlueViolet
        Me.btnRSstatus5.BackColor = Color.Azure
        Me.btnRSstatus6.BackColor = Color.Azure
        Me.btnRSstatus7.BackColor = Color.Azure

        Me.btnRSstatus1.ForeColor = Color.Black
        Me.btnRSstatus2.ForeColor = Color.Black
        Me.btnRSstatus3.ForeColor = Color.Black
        Me.btnRSstatus4.ForeColor = Color.White
        Me.btnRSstatus5.ForeColor = Color.Black
        Me.btnRSstatus6.ForeColor = Color.Black
        Me.btnRSstatus7.ForeColor = Color.Black

    End Sub

    Private Sub btnRSstatus5_Click(sender As Object, e As EventArgs) Handles btnRSstatus5.Click
        Call startfrm()
        strSelect = 50
        Call getdata_dgRSstatus1()
        Me.btnRSsend_to_claims.Enabled = True
        Me.lblStatusText.Text = "กำลังอยู่ที่สถานะซ่อมเสร็จ"
        Me.btnRSstatus1.BackColor = Color.Azure
        Me.btnRSstatus2.BackColor = Color.Azure
        Me.btnRSstatus3.BackColor = Color.Azure
        Me.btnRSstatus4.BackColor = Color.Azure
        Me.btnRSstatus5.BackColor = Color.BlueViolet
        Me.btnRSstatus6.BackColor = Color.Azure
        Me.btnRSstatus7.BackColor = Color.Azure

        Me.btnRSstatus1.ForeColor = Color.Black
        Me.btnRSstatus2.ForeColor = Color.Black
        Me.btnRSstatus3.ForeColor = Color.Black
        Me.btnRSstatus4.ForeColor = Color.Black
        Me.btnRSstatus5.ForeColor = Color.White
        Me.btnRSstatus6.ForeColor = Color.Black
        Me.btnRSstatus7.ForeColor = Color.Black

    End Sub

    Private Sub btnRSstatus6_Click(sender As Object, e As EventArgs) Handles btnRSstatus6.Click
        Call startfrm()
        strSelect = 60
        Call getdata_dgRSstatus1()
        Me.lblStatusText.Text = "กำลังอยู่ที่สถานะยกเลิกซ่อม"
        Me.btnRSstatus1.BackColor = Color.Azure
        Me.btnRSstatus2.BackColor = Color.Azure
        Me.btnRSstatus3.BackColor = Color.Azure
        Me.btnRSstatus4.BackColor = Color.Azure
        Me.btnRSstatus5.BackColor = Color.Azure
        Me.btnRSstatus6.BackColor = Color.BlueViolet
        Me.btnRSstatus7.BackColor = Color.Azure

        Me.btnRSstatus1.ForeColor = Color.Black
        Me.btnRSstatus2.ForeColor = Color.Black
        Me.btnRSstatus3.ForeColor = Color.Black
        Me.btnRSstatus4.ForeColor = Color.Black
        Me.btnRSstatus5.ForeColor = Color.Black
        Me.btnRSstatus6.ForeColor = Color.White
        Me.btnRSstatus7.ForeColor = Color.Black

    End Sub

    Private Sub btnRSstatus7_Click(sender As Object, e As EventArgs) Handles btnRSstatus7.Click
        Call startfrm()
        strSelect = 70
        Call getdata_dgRSstatus1()
        Me.lblStatusText.Text = "กำลังอยู่ที่สถานะคืนเครื่องแล้ว"
        Me.btnRSstatus1.BackColor = Color.Azure
        Me.btnRSstatus2.BackColor = Color.Azure
        Me.btnRSstatus3.BackColor = Color.Azure
        Me.btnRSstatus4.BackColor = Color.Azure
        Me.btnRSstatus5.BackColor = Color.Azure
        Me.btnRSstatus6.BackColor = Color.Azure
        Me.btnRSstatus7.BackColor = Color.BlueViolet

        Me.btnRSstatus1.ForeColor = Color.Black
        Me.btnRSstatus2.ForeColor = Color.Black
        Me.btnRSstatus3.ForeColor = Color.Black
        Me.btnRSstatus4.ForeColor = Color.Black
        Me.btnRSstatus5.ForeColor = Color.Black
        Me.btnRSstatus6.ForeColor = Color.Black
        Me.btnRSstatus7.ForeColor = Color.White

    End Sub

    Private Sub btnRSPartsWithdrawal_Click(sender As Object, e As EventArgs) Handles btnRSPartsWithdrawal.Click
        If Me.dgRSstatus1.SelectedCells.Item(17).Value = "7 คืนเครื่องแล้ว" Then
            Mainfrm.lblMainStatus.Text = "สถานะ คืนเครื่องแล้ว ไม่สามารถเบิกอะไหล่ได้"
            MsgBox("สถานะ คืนเครื่องแล้ว ไม่สามารถเบิกอะไหล่ได้", MsgBoxStyle.Information, "แจ้งเตือน")
            Exit Sub
        ElseIf Me.dgRSstatus1.SelectedCells.Item(17).Value = "4 ซ่อมไม่ได้" Then
            Mainfrm.lblMainStatus.Text = "สถานะ ซ่อมไม่ได้ ไม่สามารถเบิกอะไหล่ได้"
            MsgBox("สถานะ ซ่อมไม่ได้ ไม่สามารถเบิกอะไหล่ได้", MsgBoxStyle.Information, "แจ้งเตือน")
            Exit Sub
        ElseIf Me.dgRSstatus1.SelectedCells.Item(17).Value = "5 ซ่อมเสร็จ" Then
            Mainfrm.lblMainStatus.Text = "สถานะ ซ่อมเสร็จ ไม่สามารถเบิกอะไหล่ได้"
            MsgBox("สถานะ ซ่อมเสร็จ ไม่สามารถเบิกอะไหล่ได้", MsgBoxStyle.Information, "แจ้งเตือน")
            Exit Sub
        ElseIf Me.dgRSstatus1.SelectedCells.Item(17).Value = "6 ยกเลิกซ่อม" Then
            Mainfrm.lblMainStatus.Text = "สถานะ ยกเลิกซ่อม ไม่สามารถเบิกอะไหล่ได้"
            MsgBox("สถานะ ยกเลิกซ่อม ไม่สามารถเบิกอะไหล่ได้", MsgBoxStyle.Information, "แจ้งเตือน")
            Exit Sub
        Else
            If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
                MiniAllLoginFrm.Close()
            End If
            Mainfrm.MenuLoigName = "เบิกอะไหล่/ค่าซ่อม"
            Call Mainfrm.checkAccess()
            If Mainfrm.access = 1 Then
                MiniAllLoginFrm.MdiParent = Mainfrm
                MiniAllLoginFrm.Show()
            ElseIf Mainfrm.access = 0 Then
                PartsWithdrawalFrm.MdiParent = Mainfrm
                PartsWithdrawalFrm.Show()
                PartsWithdrawalFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
                PartsWithdrawalFrm.txtPWrepairID.Text = Me.txtRSfix_id.Text
                PartsWithdrawalFrm.txtPWcusID.Text = Me.txtRScus_id.Text
                PartsWithdrawalFrm.txtPWcusName.Text = Me.txtRScus_name.Text
                PartsWithdrawalFrm.txtPWcusTel.Text = Me.txtRScus_tel.Text
                PartsWithdrawalFrm.lblemployee.Text = Me.lblemployee.Text
            Else
                MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
            End If
        End If
    End Sub

    Private Sub btnRSviewProduct_Click(sender As Object, e As EventArgs) Handles btnRSviewProduct.Click
        ViewProductRepairFrm.MdiParent = Mainfrm
        ViewProductRepairFrm.Show()
        ViewProductRepairFrm.txtVPRfix_id.Text = Me.dgRSstatus1.SelectedCells(1).Value
    End Sub

    Private Sub cbbRSstatus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbRSstatus.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbbRSteltocus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbRSteltocus.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbbRSuser_repair_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbRSuser_repair.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbbRSvaruntee_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbbRSvaruntee.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnRSsend_to_claims_Click(sender As Object, e As EventArgs) Handles btnRSsend_to_claims.Click
        If Me.dgRSstatus1.RowCount = 0 Then
            Exit Sub
        ElseIf Me.dgRSstatus1.SelectedRows.Count = 0 Then
            Exit Sub
        Else
            If Me.dgRSstatus1.SelectedCells.Item(11).Value = "ส่งมาจากงานเคลม" Then
                Try
                    Dim UpDateAns As String
                    UpDateAns = MsgBox("คุณแน่ใจว่าตรวจสอบข้อมูลต่าง ๆ เรียบร้อยแล้ว", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
                    If UpDateAns = System.Windows.Forms.DialogResult.No Then
                        MsgBox("การบันทึกข้อมูลถูกยกเลิก.", MsgBoxStyle.Information, "ยกเลิกการบันทึก")
                        Exit Sub
                    Else
                        Dim cl_id As String
                        strSQL = "SELECT claims_id FROM comfix WHERE fix_id='" & Me.dgRSstatus1.SelectedCells.Item(1).Value & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        Dr = cmd.ExecuteReader()
                        Dr.Read()
                        cl_id = Dr.Item("claims_id")


                        strSQL = "UPDATE claims SET status='" & "ซ่อมเสร็จ" & "',datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "'" _
                             & "WHERE claims_id='" & cl_id & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()

                        strSQL = "UPDATE comfix SET status='" & "7 คืนเครื่องแล้ว" & "',date_send='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "'" _
                             & "WHERE claims_id='" & cl_id & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()

                        MsgBox("ส่งข้อมูลไปที่งานเคลมเรียบร้อยแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
                        cl_id = Nothing
                        Call startfrm()
                        strSelect = 50
                        Call getdata_dgRSstatus1()
                        Me.btnRSsend_to_claims.Enabled = True
                        Me.lblStatusText.Text = "กำลังอยู่ที่สถานะซ่อมเสร็จ"
                        Me.btnRSstatus1.BackColor = Color.Azure
                        Me.btnRSstatus2.BackColor = Color.Azure
                        Me.btnRSstatus3.BackColor = Color.Azure
                        Me.btnRSstatus4.BackColor = Color.Azure
                        Me.btnRSstatus5.BackColor = Color.BlueViolet
                        Me.btnRSstatus6.BackColor = Color.Azure
                        Me.btnRSstatus7.BackColor = Color.Azure

                        Me.btnRSstatus1.ForeColor = Color.Black
                        Me.btnRSstatus2.ForeColor = Color.Black
                        Me.btnRSstatus3.ForeColor = Color.Black
                        Me.btnRSstatus4.ForeColor = Color.Black
                        Me.btnRSstatus5.ForeColor = Color.White
                        Me.btnRSstatus6.ForeColor = Color.Black
                        Me.btnRSstatus7.ForeColor = Color.Black
                    End If
                Catch ex As Exception
                    Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                End Try
            Else
                MsgBox("งานซ่อมนี้ไม่ได้มาจากระบบเคลม", MsgBoxStyle.Information, "แจ้งเตือน")
            End If
        End If
    End Sub

    Private Sub txtRScus_id_TextChanged(sender As Object, e As EventArgs) Handles txtRScus_id.TextChanged
        Try
            strSQL = "SELECT customer_tel FROM customer WHERE customer_id='" & Me.txtRScus_id.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Me.txtRScus_tel.Text = Dr.GetString("customer_tel")
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.lblRSclaims.Text = Nothing
        Timer1.Stop()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Me.txtRSnote_repair.Enabled = True Then
            If AddRepairNoteFrm.WindowState = FormWindowState.Normal Then
                AddRepairNoteFrm.Close()
                AddRepairNoteFrm.MdiParent = Mainfrm
                AddRepairNoteFrm.Show()
            Else
                AddRepairNoteFrm.MdiParent = Mainfrm
                AddRepairNoteFrm.Show()
            End If
        End If
    End Sub
    Friend forrepairstatus As Integer
    Private Sub btnSRsendRepair_Click(sender As Object, e As EventArgs) Handles btnSRsendRepair.Click
        If Me.btnRSstatus5.BackColor = Color.BlueViolet Or Me.btnRSstatus6.BackColor = Color.BlueViolet _
            Or Me.btnRSstatus4.BackColor = Color.BlueViolet Then

            If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
                MiniAllLoginFrm.Close()
            End If
            Mainfrm.MenuLoigName = "ส่งคืนงานซ่อม"
            Call Mainfrm.checkAccess()
            If Mainfrm.access = 1 Then
                forrepairstatus = 1000
                MiniAllLoginFrm.MdiParent = Mainfrm
                MiniAllLoginFrm.Show()
            ElseIf Mainfrm.access = 0 Then
                SendRepairFrm.txtHideform.Text = Me.dgRSstatus1.CurrentRow.Cells(1).Value
                SendRepairFrm.cbbSRRcash_status.Enabled = True
                SendRepairFrm.DateTimePickerSRR.Enabled = True
                SendRepairFrm.MdiParent = Mainfrm
                SendRepairFrm.Show()
                SendRepairFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
            Else
                MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
            End If
        End If
    End Sub

    Private Sub llblRStechnician_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblRStechnician.LinkClicked
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        Mainfrm.MenuLoigName = "ผู้ใช้งาน"
        Call Mainfrm.checkAccess()
        If Mainfrm.access = 1 Then
            MiniAllLoginFrm.MdiParent = Mainfrm
            MiniAllLoginFrm.Show()
        ElseIf Mainfrm.access = 0 Then
            UsersFrm.MdiParent = Mainfrm
            UsersFrm.Show()
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub llblRSshelf_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblRSshelf.LinkClicked
        shelfFrm.MdiParent = Mainfrm
        shelfFrm.Show()
    End Sub

    Private Sub cbbRSstorage_DropDown(sender As Object, e As EventArgs) Handles cbbRSstorage.DropDown
        Try
            Me.cbbRSstorage.Items.Clear()
            strSQL = "SELECT `s` FROM `shelf` ORDER BY `s` ASC"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Me.cbbRSstorage.Items.Add(Dr.GetString("s"))
            End While
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
End Class