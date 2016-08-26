Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports GenCode128

Public Class SaveDataFixGroupFrm
    'เสร็จ  2014/12/21
    'ปรับปรุง 2016/02/07
   
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
        Me.cbbSDFrepairData.Text = ""
        Me.cbbSDFRepairType.Text = ""
        Me.txtSDFfixrepairNote.Text = "-"
        Me.txtSDFfixnote.Text = "-"
        Me.txtSDFfixTprice.Text = "-"
        Me.txtSDFfixSN.Clear()
        Me.txtSDFfixaccessory.Clear()
        Me.txtSDFfixType.Clear()
        Me.txtSDFfixPName.Clear()
        Me.txtSDFfixModel.Clear()
        Me.txtSDFfixcolor.Clear()
        Me.txtSDFCusID.Clear()
        Me.txtSDFcusname.Clear()
        Me.txtSDFcusaddress.Clear()
        Me.txtSDFcuszipcode.Clear()
        Me.txtSDFcusTel.Clear()
        Call AutoNumberNo()
        'Call getdatacombobox_mdata()
        'Call getdatacombobox_repiartype()
        'Call getdatacombobox_user()
        If Me.cbSDFGimportune.CheckState = CheckState.Checked Then
            Me.cbSDFGimportune.CheckState = CheckState.Unchecked
        End If
        Mainfrm.lblMainStatus.Text = "ข้อมูลเริ่มต้นพร้อมใช้งานแล้ว"
        PictureBox1.Image = Code128Rendering.MakeBarcodeImage(Me.lblAutoNumber.Text, CInt(1), True)
    End Sub
    Private Sub getdatacombobox_mdata()
        Try
            Me.cbbSDFrepairData.Items.Clear()
            Mainfrm.lblMainStatus.Text = "โหลด mdata"
            strSQL = "select mdata from managerdata"
            cmd = New MySqlCommand
            cmd.CommandText = strSQL
            cmd.Connection = ConnectionDB
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                cbbSDFrepairData.Items.Add(Dr("mdata"))
            End While
            Dr.Close()
            Mainfrm.lblMainStatus.Text = "โหลด mdata แล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "โหลด mdata ผิดพลาด"
        End Try
    End Sub
    Private Sub getdatacombobox_repiartype()
        Try
            Me.cbbSDFRepairType.Items.Clear()
            Mainfrm.lblMainStatus.Text = "โหลด fix_name"
            strSQL = "select fix_name from fix_com"
            cmd = New MySqlCommand
            cmd.CommandText = strSQL
            cmd.Connection = ConnectionDB
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                cbbSDFRepairType.Items.Add(Dr("fix_name"))
            End While
            Dr.Close()
            Mainfrm.lblMainStatus.Text = "โหลด fix_name แล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "โหลด fix_name ผิดพลาด"
        End Try
    End Sub

    Private Sub getDataSNtoTextBox()
        Try
            Mainfrm.lblMainStatus.Text = "โหลด sn "
            strSQL = "select Snum,p_type,p_name,model,color from sn where Snum='" & Me.txtSDFfixSN.Text & "'"
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                If Not Dr.HasRows Then
                    Me.txtSDFfixSN.Clear()
                    MsgBox("ไม่พบข้อมูล SN", MsgBoxStyle.Critical, "ค้นหาข้อมูล")
                End If
                With Dr
                    .Read()
                    Me.txtSDFfixSN.Text = .Item("Snum")
                    Me.txtSDFfixType.Text = .Item("p_type")
                    Me.txtSDFfixPName.Text = .Item("p_name")
                    Me.txtSDFfixModel.Text = .Item("model")
                    Me.txtSDFfixcolor.Text = .Item("color")
                End With
                Dr.Close()
                Mainfrm.lblMainStatus.Text = "โหลด sn แล้ว"
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "โหลด sn ผิดพลาด"
        End Try
    End Sub
    Private Sub getDataCustomertoTextBox()
        Try
            Mainfrm.lblMainStatus.Text = "โหลด customer"
            strSQL = "select customer_id,customer_name,customer_address,customer_zipcode,customer_tel from customer where customer_id=@1;"
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
            Mainfrm.lblMainStatus.Text = "โหลด customer แล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "โหลด customer ผิดพลาด"
        End Try
    End Sub

    Private Sub searchDatacomfixCusID()
        Try
            Mainfrm.lblMainStatus.Text = "โหลด comfix"
            Me.dgSearchFixByCusID.Rows.Clear()
            strSQL = "select `sn`,symptom,note_repair,date_save,date_send from comfix where customer_id='" & Me.txtSDFCusID.Text & "'"
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
            For sum As Integer = 0 To Me.dgSearchFixByCusID.Rows.Count - 1
                Me.dgSearchFixByCusID.Rows(sum).Cells(0).Value = sum + 1
                strSQL = "SELECT p_type,p_name,`model` FROM `sn` WHERE Snum='" & Me.dgSearchFixByCusID.Rows(sum).Cells(1).Value & "'"
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
            Dr.Close()
            Mainfrm.lblMainStatus.Text = "โหลด comfix แล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "โหลด comfix ผิดพลาด"
        End Try
    End Sub

    Private Sub searchDatacomfixSN()
        Try
            Mainfrm.lblMainStatus.Text = "โหลด comfix"
            Me.dgSDFsearchfixbySN.Rows.Clear()
            strSQL = "select symptom,note_repair,date_save,date_send from comfix where sn='" & Me.txtSDFfixSN.Text & "'"
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
            For sum As Integer = 0 To Me.dgSDFsearchfixbySN.Rows.Count - 1
                Me.dgSDFsearchfixbySN.Rows(sum).Cells(0).Value = sum + 1
            Next
            Dr.Close()
            Mainfrm.lblMainStatus.Text = "โหลด comfix แล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "โหลด comfix ผิดพลาด"
        End Try
    End Sub

    Private Sub btngetSN_Click(sender As Object, e As EventArgs) Handles btngetSN.Click
        SNFrm.MdiParent = Mainfrm
        SNFrm.Show()
        SNFrm.selectFrm = 200
    End Sub

    Private Sub emptyDatabase()
        Try
            strSQL = "TRUNCATE `comfix_cache`;"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SaveDataFixfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mainfrm.lblMainStatus.Text = "หน้าต่างรับงานซ่อมถูกเปิด"
        Call startfrm()
        Me.Icon = Mainfrm.Icon
        Call emptyDatabase()
    End Sub

    Private Sub btnSDFSearcdcusID_Click(sender As Object, e As EventArgs) Handles btnSDFSearcdcusID.Click
        SearchCustomerGroupFrm.MdiParent = Mainfrm
        SearchCustomerGroupFrm.Show()
    End Sub


    Private Sub btnSDFaccressory_Click(sender As Object, e As EventArgs) Handles btnSDFaccressory.Click
        accessoryGroupFrm.MdiParent = Mainfrm
        accessoryGroupFrm.Show()
    End Sub

    Private Sub btnSDFfixclose_Click(sender As Object, e As EventArgs) Handles btnSDFfixclose.Click
        If Me.dgSDFlistComfix.Rows.Count > 0 Then
            If MessageBox.Show("มีข้อมูลการรับงานถูกบันทึกอยู่ การปิดหน้าต่างนี้ข้อมูลจะโดนลบออก ต้องการจะปิดหรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Mainfrm.lblMainStatus.Text = "ลบข้อมูลรับงานซ่อมชั่วคราวออก"
                For num As Integer = 0 To Me.dgSDFlistComfix.RowCount - 1
                    strSQL = "DELETE FROM comfix_cache WHERE fix_id='" & Me.dgSDFlistComfix.Rows(num).Cells(2).Value & "'"
                    Mainfrm.lblMainStatus.Text = strSQL
                    Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    End Using
                Next
                Me.dgSDFlistComfix.Rows.Clear()
                Mainfrm.lblMainStatus.Text = "ปิดหน้าต่างรับงานซ่อมแล้ว"
                Me.Close()
            Else
                Mainfrm.lblMainStatus.Text = "ยกเลิกปิดหน้าต่างรับงานซ่อม"
                Exit Sub
            End If
        Else
            Mainfrm.lblMainStatus.Text = "ปิดหน้าต่างรับงานซ่อมแล้ว"
            Me.Close()
        End If
    End Sub

    Private Sub btnSDFfixsave_Click(sender As Object, e As EventArgs) Handles btnSDFfixsave.Click
        If Me.txtSDFCusID.Text = "" Then
            Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่รหัสลูกค้า"
            MsgBox("กรุณาใส่รหัสลูกค้า", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.txtSDFCusID.Focus()
            Me.txtSDFCusID.BackColor = Color.Salmon
            Exit Sub
        End If
        If Me.txtSDFcusname.Text = "" Then
            Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่ชื่อ"
            MsgBox("กรุณาใส่ชื่อ", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.txtSDFcusname.Focus()
            Me.txtSDFcusname.BackColor = Color.Salmon
            Exit Sub
        End If
        If Me.txtSDFcusaddress.Text = "" Then
            Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่ใส่ที่อยู่"
            MsgBox("กรุณาใส่ที่อยู่", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.txtSDFcusaddress.Focus()
            Me.txtSDFcusaddress.BackColor = Color.Salmon
            Exit Sub
        End If
        If Me.txtSDFcuszipcode.Text = "" Then
            Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่รหัสไปรษณีย์"
            MsgBox("กรุณาใส่รหัสไปรษณีย์", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.txtSDFcuszipcode.Focus()
            Me.txtSDFcuszipcode.BackColor = Color.Salmon
            Exit Sub
        End If
        If Me.txtSDFcusTel.Text = "" Then
            Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่บอร์โทร"
            MsgBox("กรุณาใส่เบอร์โทร", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.txtSDFcusTel.Focus()
            Me.txtSDFcusTel.BackColor = Color.Salmon
            Exit Sub
        End If
        If Me.txtSDFfixSN.Text = "" Then
            Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่ SN"
            MsgBox("กรุณาใส่ SN", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.txtSDFfixSN.Focus()
            Me.txtSDFfixSN.BackColor = Color.Salmon
            Exit Sub
        End If
        If Me.txtSDFfixType.Text = "" Then
            Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่ประเภท"
            MsgBox("กรุณาใส่ประเภท", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.txtSDFfixType.Focus()
            Me.txtSDFfixType.BackColor = Color.Salmon
            Exit Sub
        End If
        If Me.txtSDFfixPName.Text = "" Then
            Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่ยี่ห้อ"
            MsgBox("กรุณาใส่ยี่ห้อ", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.txtSDFfixPName.Focus()
            Me.txtSDFfixPName.BackColor = Color.Salmon
            Exit Sub
        End If
        If Me.txtSDFfixModel.Text = "" Then
            Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่รุ่น"
            MsgBox("กรุณาใส่รุ่น", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.txtSDFfixModel.Focus()
            Me.txtSDFfixModel.BackColor = Color.Salmon
            Exit Sub
        End If
        If Me.txtSDFfixcolor.Text = "" Then
            Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่สี"
            MsgBox("กรุณาใส่สี", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.txtSDFfixcolor.Focus()
            Me.txtSDFfixcolor.BackColor = Color.Salmon
            Exit Sub
        End If
        If Me.cbbSDFRepairType.Text = "" Then
            Mainfrm.lblMainStatus.Text = "ไม่ได้เลือกอาการเสีย"
            MsgBox("กรุณาเลือกอาการเสีย", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.cbbSDFRepairType.Focus()
            Me.cbbSDFRepairType.BackColor = Color.Salmon
            Exit Sub
        End If
        If Me.cbbSDFrepairData.Text = "" Then
            Mainfrm.lblMainStatus.Text = "ไม่ได้เลือกการจัดการข้อมูล"
            MsgBox("กรุณาเลือกการจัดการข้อมูล", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.cbbSDFrepairData.Focus()
            Me.cbbSDFrepairData.BackColor = Color.Salmon
            Exit Sub
        End If
        If Me.txtSDFfixrepairNote.Text = "" Then
            Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่อาการเสียเพิ่มเติม"
            MsgBox("กรุณาใส่อาการเสียเพิ่มเติม หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.txtSDFfixrepairNote.Focus()
            Me.txtSDFfixrepairNote.BackColor = Color.Salmon
            Exit Sub
        End If
        If Me.txtSDFfixaccessory.Text = "" Then
            Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่อุปกรณ์ที่นำมา"
            MsgBox("กรุณาใส่อุปกรณ์ที่นำมา หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.txtSDFfixaccessory.Focus()
            Me.txtSDFfixaccessory.BackColor = Color.Salmon
            Exit Sub
        End If
        If Me.txtSDFfixnote.Text = "" Then
            Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่หมายเหตุ"
            MsgBox("กรุณาใส่หมายเหตุ หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.txtSDFfixnote.Focus()
            Me.txtSDFfixnote.BackColor = Color.Salmon
            Exit Sub
        End If
        If Me.txtSDFfixTprice.Text = "" Then
            Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่ประเมินค่าซ่อม"
            MsgBox("กรุณาใส่ประเมินค่าซ่อม หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ตรวจสอบการกรอกข้อมูล")
            Me.txtSDFfixTprice.Focus()
            Me.txtSDFfixTprice.BackColor = Color.Salmon
            Exit Sub
        End If

        Dim Ans As String
        Ans = MsgBox("คุณแน่ในว่าจะเพิ่มข้อมูลนี้", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
        Mainfrm.lblMainStatus.Text = "ยืนยันการเพิ่มข้อมูล"
        If Ans = System.Windows.Forms.DialogResult.No Then
            MsgBox("การเพิ่มข้อมูลถูกยกเลิก", MsgBoxStyle.Information, "ยืนยัน")
            Mainfrm.lblMainStatus.Text = "การเพิ่มข้อมูลยกเลิก"
            Exit Sub
        Else
            Mainfrm.lblMainStatus.Text = "INSERT INTO comfix_cache"
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
                    cmd.Parameters.AddWithValue("@fixuser", Me.lblSDFemployee.Text)
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

            Try
                Mainfrm.lblMainStatus.Text = "INSERT INTO comfix_id"
                strSQL = "INSERT INTO comfix_id (fix_id,datetime_save)VALUES" _
                        & "(@fix_id,@datetime_save)"
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
            DateTimePickerSDFadd.Value = DateTime.Now.AddDays(0)
            DateTimePickerfixsendcom.Value = DateTime.Now.AddDays(1)
            Me.cbbSDFrepairData.Text = ""
            Me.cbbSDFRepairType.Text = ""
            Me.txtSDFfixSN.Clear()
            Me.txtSDFfixaccessory.Clear()
            Me.txtSDFfixType.Clear()
            Me.txtSDFfixPName.Clear()
            Me.txtSDFfixModel.Clear()
            Me.txtSDFfixcolor.Clear()
            Me.txtSDFfixrepairNote.Text = "-"
            Me.txtSDFfixnote.Text = "-"
            Me.txtSDFfixTprice.Text = "-"
            If Me.cbSDFGimportune.CheckState = CheckState.Checked Then
                Me.cbSDFGimportune.CheckState = CheckState.Unchecked
            End If
            Call AutoNumberNo()
        End If
    End Sub

    Private Sub printBill()
        Mainfrm.lblMainStatus.Text = "แจ้งเตือนการจะพิมพ์ใบรับเครื่องซ่อม"
        If MessageBox.Show("ต้องการจะพิมพ์ใบรับเครื่องซ่อมหรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Mainfrm.lblMainStatus.Text = "เรียกฟอร์มการพิมพ์"
            'RepairBillFrm.Show()
            SelectPrintFrm.MdiParent = Mainfrm
            SelectPrintFrm.Show()
        End If
    End Sub

    Private Sub btnSDFfixclear_Click(sender As Object, e As EventArgs) Handles btnSDFfixclear.Click
        Me.cbbSDFrepairData.Text = ""
        Me.cbbSDFRepairType.Text = ""
        Call ClearTextBoxes(Me)
    End Sub

    Private Sub btnSDFcusadd_Click(sender As Object, e As EventArgs) Handles btnSDFcusadd.Click
        CustomerFrm.MdiParent = Mainfrm
        CustomerFrm.Show()
    End Sub

    Private Sub txtSDFfixSN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSDFfixSN.KeyDown
        On Error Resume Next
        If e.KeyCode = Keys.Enter Then
            Call getDataSNtoTextBox()
        End If
    End Sub

    Private Sub txtSDFCusID_Click(sender As Object, e As EventArgs) Handles txtSDFCusID.Click
        Me.txtSDFCusID.BackColor = Color.LemonChiffon
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
        Call searchDatacomfixSN()
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
        Call getsncomfix()
    End Sub

    Private Sub cbbSDFrepairData_DropDown(sender As Object, e As EventArgs) Handles cbbSDFrepairData.DropDown
        Me.cbbSDFrepairData.BackColor = SystemColors.Window
        Call getdatacombobox_mdata()
    End Sub

    Private Sub cbbSDFRepairType_DropDown(sender As Object, e As EventArgs) Handles cbbSDFRepairType.DropDown
        Me.cbbSDFRepairType.BackColor = SystemColors.Window
        Call getdatacombobox_repiartype()
    End Sub

    Private Sub btnSDFsaveAll_Click(sender As Object, e As EventArgs) Handles btnSDFsaveAll.Click
        If MessageBox.Show("คุณแน่ใจว่าจะบันทึกข้อมูลนี้", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            SaveDataFixGroupReportPrintFrm.MdiParent = Mainfrm
            SaveDataFixGroupReportPrintFrm.Show()
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
        Else
            Call startfrm()
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
            Exit Sub
        End If
    End Sub
End Class