Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports GenCode128

Public Class EditClaimsStatusFrm
    Private Sub Data_History_Bus_Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Mainfrm.lblMainStatus.Text = "หน้าต่างดำเนินการสถานะเคลมถูกปิด"
    End Sub
  

    Private Sub getdata()
        Try

            Mainfrm.lblMainStatus.Text = "โหลดข้อมูล Claims"
            strSQL = "SELECT serial_pro,code_pro,bar_code,name_pro,price_buy,type,unit,symptom,accressory,status,employee FROM claims WHERE claims_id='" & Me.txtECSclaimsID.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                Me.txtECSsn.Text = Dr.Item("serial_pro")
                Me.txtECScode_pro.Text = Dr.Item("code_pro")
                Me.txtECSbar_code.Text = Dr.Item("bar_code")
                Me.txtECSname_pro.Text = Dr.Item("name_pro")
                Me.txtECSprice_buy.Text = Dr.Item("price_buy")
                Me.txtECStype.Text = Dr.Item("type")
                Me.txtECSunit.Text = Dr.Item("unit")
                Me.txtECSsymptom.Text = Dr.Item("symptom")
                Me.txtECSaccessory.Text = Dr.Item("accressory")
                Me.txtECSstatus.Text = Dr.Item("status")
                Me.txtECSemployee.Text = Dr.Item("employee")
            End Using
            Mainfrm.lblMainStatus.Text = "โหลดข้อมูล Claims แล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub txtECSclaimsID_TextChanged(sender As Object, e As EventArgs) Handles txtECSclaimsID.TextChanged
        Call getdata()
    End Sub
    Dim lblAutoNumber As String
    Private Sub getautonumber()
        Try
        'auto number 
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
            lblAutoNumber = nid & Now.ToString("yyyyMMddHHmmss") & "00001"
        Else
            Dim newID As Integer = CInt(Dr.Item("ID"))
            newID += 1
            lblAutoNumber = nid & Now.ToString("yyMMddHHmm") & newID.ToString("00000")
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub sendDataToComfix()
        Try
            Mainfrm.lblMainStatus.Text = "เพิ่มไปงานช่าง"
            'save data
            Mainfrm.lblMainStatus.Text = "INSERT INTO comfix"
            strSQL = "INSERT INTO comfix (fix_id,claims_id,date_save,customer_id,customer_name,sn,symptom,managerdata,fixrepairnote,fixaccessory,fixnote,fixtprice, " _
                & "varuntee,date_get,fixuser,status,user_repair,note_repair,teltocus,date_send,comfix_barcode)VALUES " _
                & "(@fix_id,@claims_id,@date_save,@customer_id,@customer_name,@sn,@symptom,@managerdata,@fixrepairnote,@fixaccessory,@fixnote,@fixtprice," _
                & "@varuntee,@date_get,@fixuser,@status,@user_repair,@note_repair,@teltocus,@date_send,@comfix_barcode)"
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                cmd.Parameters.AddWithValue("@fix_id", lblAutoNumber)
                cmd.Parameters.AddWithValue("@claims_id", Me.txtECSclaimsID.Text)
                cmd.Parameters.AddWithValue("@date_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")))
                cmd.Parameters.AddWithValue("@customer_id", Me.txtECScus_id.Text)
                cmd.Parameters.AddWithValue("@customer_name", Me.txtECScus_name.Text)
                cmd.Parameters.AddWithValue("@sn", Me.txtECSsn.Text)
                cmd.Parameters.AddWithValue("@symptom", Me.txtECSsymptom.Text)
                cmd.Parameters.AddWithValue("@managerdata", "-")
                cmd.Parameters.AddWithValue("@fixrepairnote", "ส่งมาจากงานเคลม")
                cmd.Parameters.AddWithValue("@fixaccessory", Me.txtECSaccessory.Text)
                cmd.Parameters.AddWithValue("@fixnote", "-")
                cmd.Parameters.AddWithValue("@fixtprice", "-")
                cmd.Parameters.AddWithValue("@varuntee", "-")
                cmd.Parameters.AddWithValue("@date_get", "-")
                cmd.Parameters.AddWithValue("@fixuser", ClaimsStatusFrm.lblemployee.Text)
                cmd.Parameters.AddWithValue("@status", "1 รอซ่อม")
                cmd.Parameters.AddWithValue("@user_repair", "-")
                cmd.Parameters.AddWithValue("@note_repair", "-")
                cmd.Parameters.AddWithValue("@teltocus", "-")
                'cmd.Parameters.AddWithValue("@sale_id", "-")
                cmd.Parameters.AddWithValue("@date_send", "-")
                Using stream As New IO.MemoryStream
                    PictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim arrImage() As Byte = stream.GetBuffer()
                    cmd.Parameters.AddWithValue("@comfix_barcode", arrImage)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Mainfrm.lblMainStatus.Text = "เพิ่มไปงานช่างแล้ว"
            Mainfrm.lblMainStatus.Text = "เพิ่มไอดีงานซ่อม"
            Mainfrm.lblMainStatus.Text = "INSERT INTO comfix_id"
            strSQL = "INSERT INTO comfix_id (fix_id,datetime_save)VALUES" _
                    & "(@fix_id,@datetime_save)"
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                cmd.Parameters.AddWithValue("@fix_id", lblAutoNumber)
                cmd.Parameters.AddWithValue("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")))
                Call open_connection()
                cmd.ExecuteNonQuery()
            End Using
            Mainfrm.lblMainStatus.Text = "เพิ่มไอดีงานซ่อมแล้ว"

            Mainfrm.lblMainStatus.Text = "อัพเดทสถานะงานเคลม"
            strSQL = "UPDATE claims SET status='" & "ส่งไปงานช่าง" & "' WHERE claims_id='" & Me.txtECSclaimsID.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            Mainfrm.lblMainStatus.Text = "อัพเดทสถานะงานเคลมแล้ว"
        Catch ex As Exception

        End Try
        lblAutoNumber = Nothing
    End Sub
    Private Sub addsn()
        Try
            Mainfrm.lblMainStatus.Text = "เพิ่ม SN"
            strSQL = "select Snum from sn where Snum='" & Me.txtECSsn.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                strSQL = "INSERT INTO sn (Snum,p_type,p_name,model,color,startdate)VALUES" _
               & "(@Snum,@p_type,@p_name,@model,@color,@startdate)"
                Mainfrm.lblMainStatus.Text = strSQL
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    cmd.Parameters.AddWithValue("@Snum", Me.txtECSsn.Text)
                    cmd.Parameters.AddWithValue("@p_type", Me.txtECStype.Text)
                    cmd.Parameters.AddWithValue("@p_name", Me.txtECSname_pro.Text)
                    cmd.Parameters.AddWithValue("@model", "-")
                    cmd.Parameters.AddWithValue("@color", "-")
                    cmd.Parameters.AddWithValue("@startdate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")))
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End Using
                Mainfrm.lblMainStatus.Text = "เพิ่ม SN แล้ว"
            ElseIf Dr.HasRows Then
                Mainfrm.lblMainStatus.Text = "มี SN แล้ว"
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cbbECSclaimsStatus_Click(sender As Object, e As EventArgs) Handles cbbECSclaimsStatus.Click
        If Me.txtECSstatus.Text = "รับเข้าระบบ" And Me.txtECScus_id.Text = "สินค้าจากสต็อก" Then
            Me.cbbECSclaimsStatus.Items.Clear()
            'Me.cbbECSclaimsStatus.Items.Add("ส่งเคลม")
            Me.cbbECSclaimsStatus.Items.Add("ส่งซ่อม")
            'Me.cbbECSclaimsStatus.Items.Add("รอส่งคืน")
            'Me.cbbECSclaimsStatus.Items.Add("รอคืนเงิน")
            'ElseIf Me.txtECSstatus.Text = "ส่งเคลม" Then
            '    Me.cbbECSclaimsStatus.Items.Clear()
            '    Me.cbbECSclaimsStatus.Items.Add("รอส่งคืน")
        ElseIf Me.txtECSstatus.Text = "รับเข้าระบบ" Then
            Me.cbbECSclaimsStatus.Items.Clear()
            'Me.cbbECSclaimsStatus.Items.Add("ส่งเคลม")
            Me.cbbECSclaimsStatus.Items.Add("ส่งซ่อม")
            Me.cbbECSclaimsStatus.Items.Add("รอส่งคืน")
            Me.cbbECSclaimsStatus.Items.Add("รอคืนเงิน")
        End If
    End Sub

    Private Sub EditClaimsStatusFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mainfrm.lblMainStatus.Text = "หน้าต่างดำเนินการสถานะเคลมถูกเปิด"
        Me.Icon = Mainfrm.Icon
    End Sub

    Private Sub btnECScancel_Click(sender As Object, e As EventArgs) Handles btnECScancel.Click
        Me.Close()
    End Sub

    Private Sub btnECSsave_Click(sender As Object, e As EventArgs) Handles btnECSsave.Click
        If Me.cbbECSclaimsStatus.Text = "รอคืนเงิน" Then
            If Me.txtECSsendMoney.Text = "" Then
                Me.txtECSsendMoney.BackColor = Color.OrangeRed
                Mainfrm.lblMainStatus.Text = "กรุณาระบุสาเหตุการคืนเงิน"
                MsgBox("กรุณาระบุสาเหตุการคืนเงิน", MsgBoxStyle.Information, "แจ้งเตือน")
                Exit Sub
            Else

                Dim Ans As String
                Ans = MsgBox("คุณแน่ใจว่าต้องการจะเปลี่ยนสถานะสินค้าเคลมนี้เป็น รอคืนเงิน ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
                Mainfrm.lblMainStatus.Text = "คุณแน่ใจว่าต้องการจะเปลี่ยนสถานะสินค้าเคลมนี้เป็น รอคืนเงิน"
                If Ans = System.Windows.Forms.DialogResult.No Then
                    Mainfrm.lblMainStatus.Text = "ยกเลิกการเปลี่ยนสถานะ รอคืนเงิน"
                    MsgBox("ยกเลิกการเปลี่ยนสถานะ รอคืนเงิน", MsgBoxStyle.Information, "ยืนยัน")
                    Me.Label14.Visible = False
                    Me.txtECSsendMoney.Visible = False
                    Me.cbbECSclaimsStatus.Items.Clear()
                    Exit Sub
                Else
                    Call sendmoney()
                    Mainfrm.lblMainStatus.Text = "เปลี่ยนสถานะสินค้าเคลมนี้เป็น รอคืนเงิน เรียบร้อยแล้ว"
                    MsgBox("เปลี่ยนสถานะสินค้าเคลมนี้เป็น รอคืนเงิน เรียบร้อยแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
                    ClaimsStatusFrm.strsqlSelect = 200
                    Call ClaimsStatusFrm.getdataClaims()
                    Me.Label14.Visible = False
                    Me.txtECSsendMoney.Visible = False
                    Me.cbbECSclaimsStatus.Items.Clear()
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.lblECSstatusSelect.BackColor = Color.OrangeRed
        Me.cbbECSclaimsStatus.BackColor = Color.OrangeRed
        If Me.lblECSstatusSelect.Visible = True Then
            Me.lblECSstatusSelect.Visible = False
        Else
            Me.lblECSstatusSelect.Visible = True
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.lblECSstatusSelect.BackColor = SystemColors.Control
        Me.cbbECSclaimsStatus.BackColor = SystemColors.Window
        Me.Timer1.Stop()
        Me.Timer2.Stop()
    End Sub
    Private Sub sendmoney()
        Try
            Mainfrm.lblMainStatus.Text = "อัพเดทสถานะงานเคลม"
            strSQL = "UPDATE claims SET status='" & "รอคืนเงิน" & "',datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "', employee='" & ClaimsStatusFrm.lblemployee.Text & "',note='" & Me.txtECSsendMoney.Text & "' WHERE claims_id='" & Me.txtECSclaimsID.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            Mainfrm.lblMainStatus.Text = "อัพเดทสถานะงานเคลมแล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            Exit Sub
        End Try

    End Sub
    Private Sub cbbECSclaimsStatus_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbECSclaimsStatus.SelectedValueChanged

        If Me.cbbECSclaimsStatus.Text = "ส่งเคลม" Then
            ClaimsSendFrm.MdiParent = Mainfrm
            ClaimsSendFrm.Show()
            ClaimsSendFrm.txtCSclaims_id.Text = Me.txtECSclaimsID.Text
        ElseIf Me.cbbECSclaimsStatus.Text = "ส่งซ่อม" Then
            Dim Ans As String
            Ans = MsgBox("คุณแน่ใจว่าจะส่งข้อมูลนี้ไปงานช่าง เมื่อส่งข้อมูลไปแล้วสถานะจะไปปรากฎที่งานช่าง", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
            Mainfrm.lblMainStatus.Text = "ยืนยันการส่งข้อมูล"
            If Ans = System.Windows.Forms.DialogResult.No Then
                MsgBox("การส่งข้อมูลถูกยกเลิก", MsgBoxStyle.Information, "ยืนยัน")
                Mainfrm.lblMainStatus.Text = "การส่งข้อมูลยกเลิก"
                Me.cbbECSclaimsStatus.Items.Clear()
                Exit Sub
            Else
                Call getautonumber()
                PictureBox1.Image = Code128Rendering.MakeBarcodeImage(lblAutoNumber, CInt(1), True)
                Call addsn()
                Call sendDataToComfix()
                Mainfrm.lblMainStatus.Text = "ส่งข้อมูลไปงานช่างเรียบร้อยแล้ว"
                MsgBox("ส่งข้อมูลไปงานช่างเรียบร้อยแล้ว", MsgBoxStyle.Information, "ส่งข้อมูลเรียบร้อย")
                ClaimsStatusFrm.strsqlSelect = 200
                Call ClaimsStatusFrm.getdataClaims()
                Me.cbbECSclaimsStatus.Items.Clear()
                Me.Close()
            End If
        ElseIf Me.cbbECSclaimsStatus.Text = "รอคืนเงิน" Then
            Me.Label14.Visible = True
            Me.txtECSsendMoney.Visible = True
           
        ElseIf Me.cbbECSclaimsStatus.Text = "รอส่งคืน" Then
            ReturnClaimsFrm.MdiParent = Mainfrm
            ReturnClaimsFrm.Show()
            ReturnClaimsFrm.txtRCclaimsID.Text = Me.txtECSclaimsID.Text
            ReturnClaimsFrm.txtRCaccessory.Text = Me.txtECSaccessory.Text
            End If
    End Sub

    Private Sub txtECSsendMoney_Click(sender As Object, e As EventArgs) Handles txtECSsendMoney.Click
        Me.txtECSsendMoney.BackColor = SystemColors.Window
    End Sub
End Class