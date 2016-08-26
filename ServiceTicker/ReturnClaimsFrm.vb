Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class ReturnClaimsFrm

    Private Sub ReturnClaimsFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = DateTime.Now.AddDays(0)
        Me.Icon = Mainfrm.Icon
    End Sub

    Private Sub cbbRCtel_to_cus_Click(sender As Object, e As EventArgs) Handles cbbRCtel_to_cus.Click
        Me.cbbRCtel_to_cus.Items.Clear()
        Me.cbbRCtel_to_cus.Items.Add("ยังไม่ได้แจ้ง")
        Me.cbbRCtel_to_cus.Items.Add("แจ้งแล้ว")
        Me.lblRCtel_to_cus.BackColor = SystemColors.Control
    End Sub

    Private Sub btnRCcencel_Click(sender As Object, e As EventArgs) Handles btnRCcencel.Click
        Me.Close()
    End Sub
    Private Sub saveDataClaims()
        Try
            Mainfrm.lblMainStatus.Text = "บันทึกข้อมูลงานเคลมกลับ"
            strSQL = "UPDATE claims SET claims_money='" & Me.txtRCclaims_money.Text & "'," _
                 & "employee_claims_return='" & ClaimsStatusFrm.lblemployee.Text & "'," _
                 & "tel_to_cus='" & Me.cbbRCtel_to_cus.Text & "'," _
                 & "status='" & "รอส่งคืน" & "'," _
                 & "datetime_return='" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "'" _
                 & "WHERE claims_id='" & Me.txtRCclaimsID.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            Mainfrm.lblMainStatus.Text = "บันทึกข้อมูลงานเคลมกลับเรียบร้อยแล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub btnRCsave_Click(sender As Object, e As EventArgs) Handles btnRCsave.Click
      
        If Me.cbbRCtel_to_cus.Text = "" Then
            Mainfrm.lblMainStatus.Text = "เลือกการแจ้งลูกค้าด้วย"
            Me.lblRCtel_to_cus.BackColor = Color.OrangeRed
            MsgBox("เลือกการแจ้งลูกค้าด้วย", MsgBoxStyle.Information, "แจ้งเตือน")
            Exit Sub
        ElseIf Me.txtRCnote.Text = "" Then
            Mainfrm.lblMainStatus.Text = "การซ่อมแซมแก้ไขจากทางบริษัท(ถ้ามี หากไม่มีให้ - ไว้)"
            Me.txtRCnote.BackColor = Color.OrangeRed
            MsgBox("ระบุการซ่อมแซมแก้ไขจากทางบริษัท(ถ้ามี หากไม่มีให้ - ไว้)", MsgBoxStyle.Information, "แจ้งเตือน")
            Exit Sub
        Else
            Dim Ans As String
            Ans = MsgBox("โปรดตรวจสอบข้อมูลให้เรียบร้อยถูกต้องก่อนบันทึก", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
            Mainfrm.lblMainStatus.Text = "ยืนยันการส่งข้อมูลเคลม"
            If Ans = System.Windows.Forms.DialogResult.No Then
                MsgBox("การส่งข้อมูลถูกยกเลิก", MsgBoxStyle.Information, "ยืนยัน")
                Mainfrm.lblMainStatus.Text = "การส่งข้อมูลยกเลิก"
                Exit Sub
            Else
                Call saveDataClaims()
            End If
            Mainfrm.lblMainStatus.Text = "บันทึกข้อมูลเรียบร้อยแล้ว"
            MsgBox("บันทึกข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
            ClaimsStatusFrm.strsqlSelect = 200
            ClaimsStatusFrm.getdataClaims()
            Me.Close()
            EditClaimsStatusFrm.Close()
        End If
    End Sub

    Private Sub txtRCclaims_money_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRCclaims_money.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                Mainfrm.lblMainStatus.Text = "ผิดพลาดใส่ได้เฉพาะตัวเลขเท่านั้น"
                MessageBox.Show("ใส่ได้เฉพาะตัวเลขเท่านั้น")
        End Select
    End Sub

    Private Sub txtRCnote_Click(sender As Object, e As EventArgs) Handles txtRCnote.Click
        Me.txtRCnote.BackColor = SystemColors.Window
    End Sub

    Private Sub btnRCtelCUS_Click(sender As Object, e As EventArgs) Handles btnRCtelCUS.Click
        Try
            Mainfrm.lblMainStatus.Text = "ค้นหาเบอร์โทรศัพท์ลูกค้า"
            strSQL = "SELECT customer_tel FROM customer WHERE customer_id='" & EditClaimsStatusFrm.txtECScus_id.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            Me.lblRCtel.Text = "TEL : " & Dr.Item("customer_tel")
            Mainfrm.lblMainStatus.Text = "ค้นหาเบอร์โทรศัพท์ลูกค้าแล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
End Class