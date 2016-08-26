Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports GenCode128

Public Class SaveDataFixFrm
    'เสร็จ  2014/12/21
  
    Private Sub AutoNumberNo()
        Try
            Mainfrm.lblMainStatus.Text = "โหลด ver_fixid"
            dt = New DataTable
            strSQL = "SELECT ver_fixid FROM ver_detail"
            dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
            Call open_connection()
            dtAdapter.Fill(dt)
            Dim nid As String = dt.Rows(0).Item("ver_fixid")
            Mainfrm.lblMainStatus.Text = "โหลด ID"
            strSQL = "SELECT Max(ID) as ID FROM comfix_id"
            dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                Me.lblAutoNumber.Text = nid & Now.ToString("yyyyMMddHHmmss") & "00001"
            Else
                Dim newID As Integer = CInt(Dr.Item("ID"))
                newID += 1
                Me.lblAutoNumber.Text = nid & Now.ToString("yyMMddHHmm") & newID.ToString("00000")
            End If
            Dr.Close()
            Mainfrm.lblMainStatus.Text = "โหลด ID แล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "โหลด ID ผิดพลาด"
        End Try
    End Sub
    Friend Sub startfrm()
        DateTimePickerSDFadd.Value = DateTime.Now.AddDays(0)
        DateTimePickerfixsendcom.Value = DateTime.Now.AddDays(1)
        Call ClearTextBoxes(Me)
        Me.txtSDFfixrepairNote.Text = "-"
        Me.txtSDFfixnote.Text = "-"
        Me.txtSDFfixTprice.Text = "-"
        Me.cbbSDFrepairData.Items.Clear()
        Me.cbbSDFRepairType.Items.Clear()
        Me.cbbSDFtype.Text = ""
        Me.cbbSDFname.Text = ""
        Me.cbbSDFmodel.Text = ""
        Me.cbbSDFcolor.Text = ""
        Call AutoNumberNo()
        If Me.cbSDFGimportune.CheckState = CheckState.Checked Then
            Me.cbSDFGimportune.CheckState = CheckState.Unchecked
        End If
        Mainfrm.lblMainStatus.Text = "ข้อมูลเริ่มต้นพร้อมใช้งานแล้ว"
        PictureBox1.Image = Code128Rendering.MakeBarcodeImage(Me.lblAutoNumber.Text, CInt(1), True)
    End Sub
    Private Sub getdatecombbox_typeSN()
        Try
            Me.cbbSDFtype.Items.Clear()
            strSQL = "SELECT p_type FROM product_type ORDER BY p_type ASC"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.cbbSDFtype.Items.Add(Dr.GetString("p_type"))
            End While
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "โหลดข้อมูล type ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub getdatecombbox_nameSN()
        Try
            Me.cbbSDFname.Items.Clear()
            strSQL = "SELECT p_name FROM product_name ORDER BY p_name ASC"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.cbbSDFname.Items.Add(Dr.GetString("p_name"))
            End While
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "โหลดข้อมูลยี่ห้อผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub getdatecombbox_modelSN()
        Try
            Me.cbbSDFmodel.Items.Clear()
            strSQL = "SELECT p_model FROM product_model WHERE p_name='" & Me.cbbSDFname.Text & "' ORDER BY p_model ASC"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.cbbSDFmodel.Items.Add(Dr.GetString("p_model"))
            End While
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "โหลดข้อมูลยี่ห้อผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub getdatecombbox_colorSN()
        Try
            Me.cbbSDFcolor.Items.Clear()
            strSQL = "SELECT color FROM product_color ORDER BY color ASC"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.cbbSDFcolor.Items.Add(Dr.GetString("color"))
            End While
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "โหลดข้อมูลสีผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub getdatacombobox_mdata()
        Try
            Me.cbbSDFrepairData.Items.Clear()
            strSQL = "SELECT mdata FROM managerdata"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.cbbSDFrepairData.Items.Add(Dr("mdata"))
            End While
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "โหลด mdata ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub getdatacombobox_repiartype()
        Try
            Me.cbbSDFRepairType.Items.Clear()
            strSQL = "select fix_name from fix_com"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.cbbSDFRepairType.Items.Add(Dr("fix_name"))
            End While
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "โหลด fix_name ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub getDataSNtoTextBox()
        Try
            strSQL = "select Snum,p_type,p_name,model,color from sn where Snum='" & Me.txtSDFfixSN.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Dr.HasRows Then
                    With Dr
                        .Read()
                        Me.txtSDFfixSN.Text = .Item("Snum")
                        Me.cbbSDFtype.Text = .Item("p_type")
                        Me.cbbSDFname.Text = .Item("p_name")
                        Me.cbbSDFmodel.Text = .Item("model")
                        Me.cbbSDFcolor.Text = .Item("color")
                    End With
                    Mainfrm.lblMainStatus.Text = "โหลด sn แล้ว"
                Else
                    Me.lblSDFcheckSN.Text = "ไม่พบ SN นี้ในระบบ"
                    Me.txtSDFfixSN.Focus()
                End If
                Dr.Close()
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "โหลด sn ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub getDataCustomertoTextBox()
        Try
            If Me.txtSDFCusID.Text = "0" Then
                MsgBox("ใช้ชื่อลูกค้าเงินสดในงานรับซ่อมไม่ได้", MsgBoxStyle.Information, "แจ้งเตือน")
                Me.txtSDFCusID.Clear()
                Me.txtSDFCusID.Focus()
            Else
                Mainfrm.lblMainStatus.Text = "โหลด customer"
                strSQL = "select customer_id,customer_name,customer_address,customer_zipcode,customer_tel from customer where customer_id=@1;"
                Mainfrm.lblMainStatus.Text = strSQL
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    cmd.Prepare()
                    cmd.Parameters.AddWithValue("@1", Me.txtSDFCusID.Text)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    If Not Dr.HasRows Then
                        Me.txtSDFCusID.Clear()
                        MsgBox("ไม่พบข้อมูล", MsgBoxStyle.Critical, "ค้นหารหัสลูกค้า")
                    End If
                    With Dr
                        .Read()
                        Me.txtSDFCusID.Text = .Item("customer_id")
                        Me.txtSDFcusname.Text = .Item("customer_name")
                        Me.txtSDFcusaddress.Text = .Item("customer_address")
                        Me.txtSDFcuszipcode.Text = .Item("customer_zipcode")
                        Me.txtSDFcusTel.Text = .Item("customer_tel")
                    End With
                    Dr.Close()
                End Using
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "โหลด customer ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub searchDatacomfixCusID()
        Try
            Me.dgSearchFixByCusID.Rows.Clear()
            strSQL = "select `sn`,symptom,note_repair,date_save,date_send from comfix where customer_id='" & Me.txtSDFCusID.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dim r As Integer
                While (Dr.Read())
                    With Me.dgSearchFixByCusID
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(1).Value = Dr.Item("sn")
                        .Rows(r).Cells(5).Value = Dr.Item("symptom")
                        .Rows(r).Cells(6).Value = Dr.Item("note_repair")
                        .Rows(r).Cells(7).Value = Dr.Item("date_save")
                        .Rows(r).Cells(8).Value = Dr.Item("date_send")
                    End With
                End While
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "โหลด comfix ผิดพลาด " & ex.Message
        End Try
        Try
            For sum As Integer = 0 To Me.dgSearchFixByCusID.Rows.Count - 1
                Me.dgSearchFixByCusID.Rows(sum).Cells(0).Value = sum + 1
                strSQL = "SELECT p_type,p_name,`model` FROM `sn` WHERE Snum='" & Me.dgSearchFixByCusID.Rows(sum).Cells(1).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                With Me.dgSearchFixByCusID
                    .Rows(sum).Cells(2).Value = Dr.Item("p_type")
                    .Rows(sum).Cells(3).Value = Dr.Item("p_name")
                    .Rows(sum).Cells(4).Value = Dr.Item("model")
                End With
            Next
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "โหลด comfix ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub searchDatacomfixSN()
        Try
            Me.dgSDFsearchfixbySN.Rows.Clear()
            strSQL = "select symptom,note_repair,date_save,date_send from comfix where sn='" & Me.txtSDFfixSN.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dim r As Integer
                While (Dr.Read())
                    With Me.dgSDFsearchfixbySN
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells("symptomSN").Value = Dr.Item("symptom")
                        .Rows(r).Cells("note_repairSN").Value = Dr.Item("note_repair")
                        .Rows(r).Cells("date_saveSN").Value = Dr.Item("date_save")
                        .Rows(r).Cells("date_sendSN").Value = Dr.Item("date_send")
                    End With
                End While
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "โหลด comfix ผิดพลาด " & ex.Message
        End Try
        Try
            For sum As Integer = 0 To Me.dgSDFsearchfixbySN.Rows.Count - 1
                Me.dgSDFsearchfixbySN.Rows(sum).Cells(0).Value = sum + 1
            Next
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
    End Sub

    Private Sub btngetSN_Click(sender As Object, e As EventArgs) Handles btnSDFaddSN.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        Mainfrm.MenuLoigName = "ข้อมูล SN เครื่องซ่อม"
        Call Mainfrm.checkAccess()
        If Mainfrm.access = 1 Then
            MiniAllLoginFrm.MdiParent = Mainfrm
            MiniAllLoginFrm.Show()
        ElseIf Mainfrm.access = 0 Then
            SNFrm.MdiParent = Mainfrm
            SNFrm.Show()
            SNFrm.selectFrm = 100
            SNFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub SaveDataFixFrm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Try
            strSQL = "TRUNCATE `comfix_cache`"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = strSQL & "  " & ex.Message
        End Try
    End Sub

    Private Sub SaveDataFixFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.dgSDFlistComfix.Rows.Count > 0 Then
            If MessageBox.Show("มีข้อมูลการรับงานถูกบันทึกอยู่ การปิดหน้าต่างนี้ข้อมูลจะโดนลบออก ต้องการจะปิดหรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Mainfrm.lblMainStatus.Text = "ลบข้อมูลรับงานซ่อมชั่วคราวออก"
                For num As Integer = 0 To Me.dgSDFlistComfix.RowCount - 1
                    Try
                    strSQL = "DELETE FROM comfix_cache WHERE fix_id='" & Me.dgSDFlistComfix.Rows(num).Cells(2).Value & "'"
                    Mainfrm.lblMainStatus.Text = strSQL
                    Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                        End Using
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = strSQL & "  " & ex.Message
                    End Try
                Next
                Me.dgSDFlistComfix.Rows.Clear()
                Mainfrm.lblMainStatus.Text = "ปิดหน้าต่างรับงานซ่อมแล้ว"
                e.Cancel = False
            Else
                Mainfrm.lblMainStatus.Text = "ยกเลิกปิดหน้าต่างรับงานซ่อม"
                e.Cancel = True
            End If
        Else
            Mainfrm.lblMainStatus.Text = "ปิดหน้าต่างรับงานซ่อมแล้ว"
            e.Cancel = False
        End If
    End Sub
    Private Sub SaveDataFixfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mainfrm.lblMainStatus.Text = "หน้าต่างรับงานซ่อมถูกเปิด"
        Call startfrm()
        Me.Icon = Mainfrm.Icon
    End Sub

    Private Sub btnSDFSearcdcusID_Click(sender As Object, e As EventArgs) Handles btnSDFSearcdcusID.Click
        SearchCustomerFrm.MdiParent = Mainfrm
        SearchCustomerFrm.Show()
    End Sub

    Private Sub btnSDFaccressory_Click(sender As Object, e As EventArgs) Handles btnSDFaccressory.Click
        accessoryFrm.MdiParent = Mainfrm
        accessoryFrm.Show()
    End Sub

    Private Sub btnSDFfixsave_Click(sender As Object, e As EventArgs) Handles btnSDFfixsave.Click
        If Me.txtSDFCusID.Text = "" Then
            Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่รหัสลูกค้า"
            MsgBox("กรุณาใส่รหัสลูกค้า", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.txtSDFCusID.Focus()
            Me.txtSDFCusID.BackColor = Color.Salmon
            Timer1.Start()
        ElseIf Me.txtSDFcusname.Text = "" Then
            Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่ชื่อ"
            MsgBox("กรุณาใส่ชื่อ", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.txtSDFcusname.Focus()
            Me.txtSDFcusname.BackColor = Color.Salmon
            Timer1.Start()
        ElseIf Me.txtSDFcusaddress.Text = "" Then
            Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่ที่อยู่"
            MsgBox("กรุณาใส่ที่อยู่", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.txtSDFcusaddress.Focus()
            Me.txtSDFcusaddress.BackColor = Color.Salmon
            Timer1.Start()
        ElseIf Me.txtSDFcuszipcode.Text = "" Then
            Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่รหัสไปรษณีย์"
            MsgBox("กรุณาใส่รหัสไปรษณีย์", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.txtSDFcuszipcode.Focus()
            Me.txtSDFcuszipcode.BackColor = Color.Salmon
            Timer1.Start()
        ElseIf Me.txtSDFcusTel.Text = "" Then
            Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่เบอร์โทร"
            MsgBox("กรุณาใส่เบอร์โทร", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.txtSDFcusTel.Focus()
            Me.txtSDFcusTel.BackColor = Color.Salmon
            Timer1.Start()
        ElseIf Me.txtSDFfixSN.Text = "" Then
            Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่ SN"
            MsgBox("กรุณาใส่ SN", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.txtSDFfixSN.Focus()
            Me.txtSDFfixSN.BackColor = Color.Salmon
            Timer1.Start()
        ElseIf Me.cbbSDFtype.Text = "" Then
            Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่ประเภท"
            MsgBox("กรุณาใส่ประเภท", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.cbbSDFtype.Focus()
            Me.cbbSDFtype.BackColor = Color.Salmon
            Timer1.Start()
        ElseIf Me.cbbSDFname.Text = "" Then
            Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่ยี่ห้อ"
            MsgBox("กรุณาใส่ยี่ห้อ", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.cbbSDFname.Focus()
            Me.cbbSDFname.BackColor = Color.Salmon
            Timer1.Start()
        ElseIf Me.cbbSDFmodel.Text = "" Then
            Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่รุ่น"
            MsgBox("กรุณาใส่รุ่น", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.cbbSDFmodel.Focus()
            Me.cbbSDFmodel.BackColor = Color.Salmon
            Timer1.Start()
        ElseIf Me.cbbSDFcolor.Text = "" Then
            Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่สี"
            MsgBox("กรุณาใส่สี", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.cbbSDFcolor.Focus()
            Me.cbbSDFcolor.BackColor = Color.Salmon
            Timer1.Start()
        ElseIf Me.cbbSDFRepairType.Text = "" Then
            Mainfrm.lblMainStatus.Text = "ไม่ได้เลือกอาการเสีย"
            MsgBox("กรุณาเลือกอาการเสีย", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.cbbSDFRepairType.Focus()
            Me.cbbSDFRepairType.BackColor = Color.Salmon
            Timer1.Start()
        ElseIf Me.cbbSDFrepairData.Text = "" Then
            Mainfrm.lblMainStatus.Text = "ไม่ได้เลือกการจัดการข้อมูล"
            MsgBox("กรุณาเลือกการจัดการข้อมูล", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.cbbSDFrepairData.Focus()
            Me.cbbSDFrepairData.BackColor = Color.Salmon
            Timer1.Start()
        ElseIf Me.txtSDFfixrepairNote.Text = "" Then
            Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่อาการเสียเพิ่มเติม"
            MsgBox("กรุณาใส่อาการเสียเพิ่มเติม หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.txtSDFfixrepairNote.Focus()
            Me.txtSDFfixrepairNote.BackColor = Color.Salmon
            Timer1.Start()
        ElseIf Me.txtSDFfixaccessory.Text = "" Then
            Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่อุปกรณ์ที่นำมา"
            MsgBox("กรุณาใส่อุปกรณ์ที่นำมา หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.txtSDFfixaccessory.Focus()
            Me.txtSDFfixaccessory.BackColor = Color.Salmon
            Timer1.Start()
        ElseIf Me.txtSDFfixnote.Text = "" Then
            Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่หมายเหตุ"
            MsgBox("กรุณาใส่หมายเหตุ หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.txtSDFfixnote.Focus()
            Me.txtSDFfixnote.BackColor = Color.Salmon
            Timer1.Start()
        ElseIf Me.txtSDFfixTprice.Text = "" Then
            Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่ประเมินค่าซ่อม"
            MsgBox("กรุณาใส่ประเมินค่าซ่อม หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.txtSDFfixTprice.Focus()
            Me.txtSDFfixTprice.BackColor = Color.Salmon
            Timer1.Start()
        Else
             Dim Ans As String
            Ans = MsgBox("คุณแน่ในว่าจะเพิ่มข้อมูลนี้", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
            Mainfrm.lblMainStatus.Text = "ยืนยันการเพิ่มข้อมูล"
            If Ans = System.Windows.Forms.DialogResult.No Then
                MsgBox("การเพิ่มข้อมูลถูกยกเลิก", MsgBoxStyle.Information, "ยืนยัน")
                Mainfrm.lblMainStatus.Text = "การเพิ่มข้อมูลยกเลิก"
                Exit Sub
            Else
                Try
                    Dim impp As String
                    If Me.cbSDFGimportune.Checked Then
                        impp = "เร่งด่วน"
                    Else
                        impp = "ธรรมดา"
                    End If
                    strSQL = "INSERT INTO comfix_cache (fix_id,date_save,customer_id,customer_name,sn,symptom,managerdata,fixrepairnote,fixaccessory,fixnote,fixtprice, " _
                          & "varuntee,date_get,fixuser,status,user_repair,note_repair,teltocus,date_send,importune,comfix_barcode)VALUES " _
                          & "(@fix_id,@date_save,@customer_id,@customer_name,@sn,@symptom,@managerdata,@fixrepairnote,@fixaccessory,@fixnote,@fixtprice," _
                          & "@varuntee,@date_get,@fixuser,@status,@user_repair,@note_repair,@teltocus,@date_send,@importune,@comfix_barcode)"
                    Mainfrm.lblMainStatus.Text = strSQL
                    Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                        cmd.Parameters.AddWithValue("@fix_id", Me.lblAutoNumber.Text)
                        cmd.Parameters.AddWithValue("@date_save", Me.DateTimePickerSDFadd.Text)
                        cmd.Parameters.AddWithValue("@customer_id", Me.txtSDFCusID.Text)
                        cmd.Parameters.AddWithValue("@customer_name", Me.txtSDFcusname.Text)
                        cmd.Parameters.AddWithValue("@sn", Me.txtSDFfixSN.Text)
                        cmd.Parameters.AddWithValue("@symptom", Me.cbbSDFRepairType.Text)
                        cmd.Parameters.AddWithValue("@managerdata", Me.cbbSDFrepairData.Text)
                        cmd.Parameters.AddWithValue("@fixrepairnote", Me.txtSDFfixrepairNote.Text)
                        cmd.Parameters.AddWithValue("@fixaccessory", Me.txtSDFfixaccessory.Text)
                        cmd.Parameters.AddWithValue("@fixnote", Me.txtSDFfixnote.Text)
                        cmd.Parameters.AddWithValue("@fixtprice", Me.txtSDFfixTprice.Text)
                        cmd.Parameters.AddWithValue("@varuntee", "-")
                        cmd.Parameters.AddWithValue("@date_get", Me.DateTimePickerfixsendcom.Text)
                        cmd.Parameters.AddWithValue("@fixuser", Me.lblemployee.Text)
                        cmd.Parameters.AddWithValue("@status", "1 รอซ่อม")
                        cmd.Parameters.AddWithValue("@user_repair", "-")
                        cmd.Parameters.AddWithValue("@note_repair", "-")
                        cmd.Parameters.AddWithValue("@teltocus", "-")
                        'cmd.Parameters.AddWithValue("@sale_id", "-")
                        cmd.Parameters.AddWithValue("@date_send", "-")
                        cmd.Parameters.AddWithValue("@importune", impp)
                        Using stream As New IO.MemoryStream
                            PictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
                            Dim arrImage() As Byte = stream.GetBuffer()
                            cmd.Parameters.AddWithValue("@comfix_barcode", arrImage)
                            Call open_connection()
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using
                    impp = Nothing
                Catch ex As Exception
                    Mainfrm.lblMainStatus.Text = "ผิดพลาด INSERT INTO comfix_cache " & ex.Message
                End Try
                'บันทึก sn_id แบบอัตโนมัติ
                If keySN = "10" Then
                    Try
                        strSQL = "INSERT INTO sn_id (sn_id)VALUES" _
                           & "(@sn_id)"
                        Mainfrm.lblMainStatus.Text = strSQL
                    Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                        cmd.Parameters.AddWithValue("@sn_id", Me.txtSDFfixSN.Text)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    End Using
                        keySN = Nothing
                    Catch ex As Exception

                    End Try
                End If
                Try
                    strSQL = "INSERT INTO comfix_id (fix_id,datetime_save)VALUES" _
                            & "(@fix_id,@datetime_save)"
                    Mainfrm.lblMainStatus.Text = strSQL
                    Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                        cmd.Parameters.AddWithValue("@fix_id", Me.lblAutoNumber.Text)
                        cmd.Parameters.AddWithValue("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")))
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    End Using
                Catch ex As Exception
                    Mainfrm.lblMainStatus.Text = "ผิดพลาด INSERT INTO comfix_id " & ex.Message
                End Try

                Try
                    Me.dgSDFlistComfix.Rows.Clear()
                    strSQL = "SELECT fix_id,customer_id,sn,symptom,managerdata,fixaccessory FROM comfix_cache"
                    Mainfrm.lblMainStatus.Text = strSQL
                    Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        Dr = cmd.ExecuteReader
                        Dim r As Integer
                        While (Dr.Read())
                            With Me.dgSDFlistComfix
                                r = .RowCount
                                .Rows.Add()
                                .Rows(r).Cells(1).Value = Dr.GetString("customer_id")
                                .Rows(r).Cells(2).Value = Dr.GetString("fix_id")
                                .Rows(r).Cells(3).Value = Dr.GetString("sn")
                                .Rows(r).Cells(4).Value = Dr.GetString("symptom")
                                .Rows(r).Cells(5).Value = Dr.GetString("managerdata")
                                .Rows(r).Cells(6).Value = Dr.GetString("fixaccessory")
                            End With
                        End While
                        For sum As Integer = 0 To Me.dgSDFlistComfix.Rows.Count - 1
                            Me.dgSDFlistComfix.Rows(sum).Cells(0).Value = sum + 1
                        Next
                    End Using
                Catch ex As Exception
                    Mainfrm.lblMainStatus.Text = "ผิดพลาด SELECT FROM comfix_cache " & ex.Message
                End Try
                'บันทึก SN
                Try
                    strSQL = "SELECT Snum FROM sn WHERE Snum='" & Me.txtSDFfixSN.Text & "'"
                    Mainfrm.lblMainStatus.Text = strSQL
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader()
                    Dr.Read()
                    If Dr.HasRows Then
                    Else
                        strSQL = "INSERT INTO sn (Snum,p_type,p_name,model,color,startdate)VALUES" _
                            & "(@Snum,@p_type,@p_name,@model,@color,@startdate)"
                        Mainfrm.lblMainStatus.Text = strSQL
                        Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                            cmd.Parameters.AddWithValue("@Snum", Me.txtSDFfixSN.Text)
                            cmd.Parameters.AddWithValue("@p_type", Me.cbbSDFtype.Text)
                            cmd.Parameters.AddWithValue("@p_name", Me.cbbSDFname.Text)
                            cmd.Parameters.AddWithValue("@model", Me.cbbSDFmodel.Text)
                            cmd.Parameters.AddWithValue("@color", Me.cbbSDFcolor.Text)
                            cmd.Parameters.AddWithValue("@startdate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")))
                            Call open_connection()
                            cmd.ExecuteNonQuery()
                        End Using
                    End If
                Catch ex As Exception

                End Try
                'บันทึกรุ่น
                Try
                    strSQL = "SELECT p_name,p_model FROM product_model WHERE p_name='" & Me.cbbSDFname.Text & "' AND p_model='" & Me.cbbSDFmodel.Text & "'"
                    Mainfrm.lblMainStatus.Text = strSQL
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader()
                    Dr.Read()
                    If Dr.HasRows Then
                    Else
                        strSQL = "INSERT INTO product_model (p_name,p_model)VALUES" _
                            & "(@p_name,@p_model)"
                        Mainfrm.lblMainStatus.Text = strSQL
                        Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                            cmd.Parameters.AddWithValue("@p_name", Me.cbbSDFname.Text)
                            cmd.Parameters.AddWithValue("@p_model", Me.cbbSDFmodel.Text)
                            Call open_connection()
                            cmd.ExecuteNonQuery()
                        End Using
                    End If
                Catch ex As Exception
                    Mainfrm.lblMainStatus.Text = ex.Message
                End Try

                DateTimePickerSDFadd.Value = DateTime.Now.AddDays(0)
                DateTimePickerfixsendcom.Value = DateTime.Now.AddDays(1)
                Me.cbbSDFrepairData.Text = ""
                Me.cbbSDFRepairType.Text = ""
                Me.txtSDFfixSN.Clear()
                Me.txtSDFfixaccessory.Clear()
                Me.cbbSDFtype.Text = ""
                Me.cbbSDFname.Text = ""
                Me.cbbSDFmodel.Text = ""
                Me.cbbSDFcolor.Text = ""
                Me.txtSDFfixrepairNote.Text = "-"
                Me.txtSDFfixnote.Text = "-"
                Me.txtSDFfixTprice.Text = "-"
                If Me.cbSDFGimportune.CheckState = CheckState.Checked Then
                    Me.cbSDFGimportune.CheckState = CheckState.Unchecked
                End If
                Call AutoNumberNo()
            End If
        End If

    End Sub

    Private Sub btnSDFfixclear_Click(sender As Object, e As EventArgs) Handles btnSDFfixclear.Click
        Me.cbbSDFrepairData.Text = ""
        Me.cbbSDFRepairType.Text = ""
        Call ClearTextBoxes(Me)
    End Sub

    Private Sub btnSDFcusadd_Click(sender As Object, e As EventArgs) Handles btnSDFcusadd.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        Mainfrm.MenuLoigName = "ข้อมูลลูกค้า"
        Call Mainfrm.checkAccess()
        If Mainfrm.access = 1 Then
            MiniAllLoginFrm.MdiParent = Mainfrm
            MiniAllLoginFrm.Show()
        ElseIf Mainfrm.access = 0 Then
            CustomerFrm.MdiParent = Mainfrm
            CustomerFrm.Show()
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub txtSDFfixSN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSDFfixSN.KeyDown
        On Error Resume Next
        If e.KeyCode = Keys.Enter Then
            Call getDataSNtoTextBox()
            Call searchDatacomfixSN()
        End If
    End Sub

    Private Sub txtSDFCusID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSDFCusID.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call getDataCustomertoTextBox()
        End If
    End Sub

    Private Sub txtSDFCusID_TextChanged(sender As Object, e As EventArgs) Handles txtSDFCusID.TextChanged
        Call searchDatacomfixCusID()
    End Sub

    Private Sub txtSDFfixSN_TextChanged(sender As Object, e As EventArgs) Handles txtSDFfixSN.TextChanged
        'ตรวจสอบ sn ซ้ำ
        Call druSN()
    End Sub
    Private Sub druSN()
        Try
            strSQL = "SELECT Snum FROM sn WHERE Snum='" & Me.txtSDFfixSN.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            If Dr.HasRows Then
                Me.lblSDFcheckSN.Text = "พบ SN นี้ในระบบ กด Enter เพื่อดึงข้อมูลเครื่องได้เลย"
            Else
                Me.lblSDFcheckSN.Text = "ไม่พบ SN นี้ในระบบ"
            End If
        Catch ex As Exception

        End Try
    End Sub
     
    Private Sub getsncomfix()
        Try
            Dim sdfcid, sdfsn As String
            strSQL = "SELECT customer_id,sn FROM comfix WHERE sn='" & Me.txtSDFsearchSN.Text & "' LIMIT 1;"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            If Dr.HasRows Then
                sdfcid = Dr.Item("customer_id")
                sdfsn = Dr.Item("sn")
                'loda customer
                Me.txtSDFCusID.Text = sdfcid
                Call getDataCustomertoTextBox()
                ''load sn
                Me.txtSDFfixSN.Text = sdfsn
                Call getDataSNtoTextBox()
                sdfcid = Nothing
                sdfsn = Nothing
                Me.txtSDFsearchSN.Clear()
            Else
                Me.txtSDFsearchSN.Clear()
                Mainfrm.lblMainStatus.Text = "ไม่พบข้อมูล SN "
                MsgBox("ไม่พบข้อมูล SN", MsgBoxStyle.Critical, "ไม่พบข้อมูล SN")
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub txtSDFsearchSN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSDFsearchSN.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call getsncomfix()
        End If
    End Sub

    Private Sub btnSDFsearchSN_Click(sender As Object, e As EventArgs) Handles btnSDFsearchSN.Click
        If Me.txtSDFsearchSN.Text = Nothing Then

        Else
            Call getsncomfix()
        End If
    End Sub

    Private Sub cbbSDFrepairData_DropDown(sender As Object, e As EventArgs) Handles cbbSDFrepairData.DropDown
        Call getdatacombobox_mdata()
    End Sub

    Private Sub cbbSDFRepairType_DropDown(sender As Object, e As EventArgs) Handles cbbSDFRepairType.DropDown
        Call getdatacombobox_repiartype()
    End Sub

    Private Sub cbbSDFtype_DropDown(sender As Object, e As EventArgs) Handles cbbSDFtype.DropDown
        Call getdatecombbox_typeSN()
    End Sub

    Private Sub cbbSDFname_DropDown(sender As Object, e As EventArgs) Handles cbbSDFname.DropDown
        Call getdatecombbox_nameSN()
    End Sub

    Private Sub cbbSDFmodel_DropDown(sender As Object, e As EventArgs) Handles cbbSDFmodel.DropDown
        Call getdatecombbox_modelSN()
    End Sub


    Private Sub btnSDFaddProduct_Click(sender As Object, e As EventArgs) Handles btnSDFaddProduct.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        Mainfrm.MenuLoigName = "ข้อมูลประเภทสินค้า"
        Call Mainfrm.checkAccess()
        If Mainfrm.access = 1 Then
            MiniAllLoginFrm.MdiParent = Mainfrm
            MiniAllLoginFrm.Show()
        ElseIf Mainfrm.access = 0 Then
            ProductFrm.MdiParent = Mainfrm
            ProductFrm.Show()
            ProductFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub btnSDFaddProductName_Click(sender As Object, e As EventArgs) Handles btnSDFaddProductName.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        Mainfrm.MenuLoigName = "ข้อมูลยี่ห้อสินค้า"
        Call Mainfrm.checkAccess()
        If Mainfrm.access = 1 Then
            MiniAllLoginFrm.MdiParent = Mainfrm
            MiniAllLoginFrm.Show()
        ElseIf Mainfrm.access = 0 Then
            ProductNameFrm.MdiParent = Mainfrm
            ProductNameFrm.Show()
            ProductNameFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub cbbSDFcolor_DropDown(sender As Object, e As EventArgs) Handles cbbSDFcolor.DropDown
        Call getdatecombbox_colorSN()
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        Mainfrm.MenuLoigName = "ข้อมูลสีตัวสินค้า"
        Call Mainfrm.checkAccess()
        If Mainfrm.access = 1 Then
            MiniAllLoginFrm.MdiParent = Mainfrm
            MiniAllLoginFrm.Show()
        ElseIf Mainfrm.access = 0 Then
            ProductColorFrm.MdiParent = Mainfrm
            ProductColorFrm.Show()
            ProductColorFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub cbbSDFname_TextChanged(sender As Object, e As EventArgs) Handles cbbSDFname.TextChanged
        Me.cbbSDFmodel.Text = ""
    End Sub
    Dim keySN As String
    Private Sub btnSDFsearcdSN_Click(sender As Object, e As EventArgs) Handles btnSDFsearcdSN.Click
        Try
            strSQL = "SELECT Max(id) as ID FROM sn_id"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                Me.txtSDFfixSN.Text = Now.ToString("yyMMdd", CultureInfo.CreateSpecificCulture("en-EN")) & "0001"
            Else
                Dim newID As Integer = CInt(Dr.Item("ID"))
                newID += 1
                Me.txtSDFfixSN.Text = Now.ToString("yyMMdd", CultureInfo.CreateSpecificCulture("en-EN")) & newID.ToString("0000")
            End If
            Me.cbbSDFtype.Text = ""
            Me.cbbSDFname.Text = ""
            Me.cbbSDFmodel.Text = ""
            Me.cbbSDFcolor.Text = ""
            keySN = "10"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub btnSDFaddAccessory_Click(sender As Object, e As EventArgs) Handles btnSDFaddAccessory.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        Mainfrm.MenuLoigName = "ข้อมูลอุปกรณ์ที่นำมาด้วย"
        Call Mainfrm.checkAccess()
        If Mainfrm.access = 1 Then
            MiniAllLoginFrm.MdiParent = Mainfrm
            MiniAllLoginFrm.Show()
        ElseIf Mainfrm.access = 0 Then
            AccessoryEditFrm.MdiParent = Mainfrm
            AccessoryEditFrm.Show()
            AccessoryEditFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub btnSDFaddfixcom_Click(sender As Object, e As EventArgs) Handles btnSDFaddfixcom.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        Mainfrm.MenuLoigName = "ข้อมูลอาการเสีย"
        Call Mainfrm.checkAccess()
        If Mainfrm.access = 1 Then
            MiniAllLoginFrm.MdiParent = Mainfrm
            MiniAllLoginFrm.Show()
        ElseIf Mainfrm.access = 0 Then
            FixcomFrm.MdiParent = Mainfrm
            FixcomFrm.Show()
            FixcomFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub btnSDFaddmanager_Click(sender As Object, e As EventArgs) Handles btnSDFaddmanager.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        Mainfrm.MenuLoigName = "ข้อมูลการจัดการข้อมูล"
        Call Mainfrm.checkAccess()
        If Mainfrm.access = 1 Then
            MiniAllLoginFrm.MdiParent = Mainfrm
            MiniAllLoginFrm.Show()
        ElseIf Mainfrm.access = 0 Then
            ManagerdataFrm.MdiParent = Mainfrm
            ManagerdataFrm.Show()
            ManagerdataFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub
    Friend Sub saveDatalistFixcom()
        For num As Integer = 0 To Me.dgSDFlistComfix.RowCount - 1
            strSQL = "INSERT INTO comfix(fix_id,claims_id,date_save,customer_id,customer_name,sn,symptom,managerdata,fixrepairnote,fixaccessory,fixnote,fixtprice,varuntee,date_get,fixuser,status,user_repair,note_repair,teltocus,date_send,datecom_repair,importune,comfix_barcode)" _
                & "SELECT * FROM comfix_cache WHERE fix_id='" & Me.dgSDFlistComfix.Rows(num).Cells(2).Value & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            End Using
        Next
        For num As Integer = 0 To Me.dgSDFlistComfix.RowCount - 1
            strSQL = "DELETE FROM comfix_cache WHERE fix_id='" & Me.dgSDFlistComfix.Rows(num).Cells(2).Value & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            End Using
        Next
        Me.dgSDFlistComfix.Rows.Clear()
        Call startfrm()
        If RepairStatusFrm.WindowState = FormWindowState.Normal Or RepairStatusFrm.WindowState = FormWindowState.Maximized Or _
          RepairStatusFrm.WindowState = FormWindowState.Minimized Then
            RepairStatusFrm.reLoadFrm()
        End If
    End Sub
    Friend fidx As String
    Private Sub btnSDFsaveAll_Click(sender As Object, e As EventArgs) Handles btnSDFsaveAll.Click
        If Me.dgSDFlistComfix.RowCount = 0 Then
            MsgBox("ไม่มีข้อมูลที่จะบันทึก", MsgBoxStyle.Information, "แจ้งเตือน")
        Else
            If MessageBox.Show("คุณแน่ใจว่าจะบันทึกข้อมูลนี้", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                If Me.dgSDFlistComfix.RowCount > 1 Then
                    SaveDataFixGroupReportPrintFrm.MdiParent = Mainfrm
                    SaveDataFixGroupReportPrintFrm.Show()
                ElseIf Me.dgSDFlistComfix.RowCount = 1 Then
                    fidx = Me.dgSDFlistComfix.Rows(0).Cells(2).Value
                    SelectPrintFrm.MdiParent = Mainfrm
                    SelectPrintFrm.Show()
                End If
            Else
                Exit Sub
            End If
        End If
      
    End Sub

  
    Private Sub dgSDFlistComfix_KeyDown(sender As Object, e As KeyEventArgs) Handles dgSDFlistComfix.KeyDown
        If e.KeyCode = Keys.Delete Then
            If MessageBox.Show("คุณแน่ใจว่าจะลบข้อมูลนี้", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                strSQL = "DELETE FROM comfix_cache WHERE fix_id='" & Me.dgSDFlistComfix.SelectedCells.Item(2).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End Using
                Dim a As Integer = Me.dgSDFlistComfix.SelectedRows.Count - 1
                Me.dgSDFlistComfix.Rows.Remove(Me.dgSDFlistComfix.SelectedRows(a))
                Me.dgSDFlistComfix.Refresh()
            End If
        Else
        End If
    End Sub

    'Private Sub Timer1_Disposed(sender As Object, e As EventArgs) Handles Timer1.Disposed
    '    Timer2.Start()
    'End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.txtSDFCusID.BackColor = Color.LemonChiffon
        Me.txtSDFfixSN.BackColor = Color.LemonChiffon
        Me.cbbSDFtype.BackColor = Color.LemonChiffon
        Me.cbbSDFname.BackColor = Color.LemonChiffon
        Me.cbbSDFmodel.BackColor = Color.LemonChiffon
        Me.cbbSDFcolor.BackColor = Color.LemonChiffon
        Me.cbbSDFRepairType.BackColor = Color.LemonChiffon
        Me.cbbSDFrepairData.BackColor = Color.LemonChiffon
        Me.txtSDFfixrepairNote.BackColor = Color.LemonChiffon
        Me.txtSDFfixTprice.BackColor = Color.LemonChiffon
        Me.txtSDFfixaccessory.BackColor = Color.LemonChiffon
        Me.txtSDFfixnote.BackColor = Color.LemonChiffon
        Timer1.Stop()
        Timer2.Stop()
    End Sub
End Class