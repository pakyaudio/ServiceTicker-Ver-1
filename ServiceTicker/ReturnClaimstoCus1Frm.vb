Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class ReturnClaimstoCus1Frm

    Friend Sub getdataClaims()
        Try
            Mainfrm.lblMainStatus.Text = "โหลดข้อมูล Claims"
            strSQL = "SELECT claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,price_buy,type,unit,datetime_sale,datetime_edit,symptom,accressory,note,datetime_save FROM claims WHERE claims_id='" & Me.txtRCTC1claims_id.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                Me.txtRCTC1claims_id.Text = Dr.GetString("claims_id")
                Me.txtRCTC1cus_id.Text = Dr.GetString("customer_id")
                Me.txtRCTC1serial_pro.Text = Dr.GetString("serial_pro")
                Me.txtRCTC1code_pro.Text = Dr.GetString("code_pro")
                Me.txtRCTC1bar_code.Text = Dr.GetString("bar_code")
                Me.txtRCTC1name_pro.Text = Dr.GetString("name_pro")
                Me.txtRCTC1price_buy.Text = Dr.GetString("price_buy")
                Me.txtRCTC1type.Text = Dr.GetString("type")
                Me.txtRCTC1unit.Text = Dr.GetString("unit")
                Me.txtRCTC1datetime_sale.Text = Dr.GetString("datetime_sale")
                Me.txtRCTC1datetime_save.Text = Dr.GetString("datetime_save")
                Me.txtRCTC1datetime_edit.Text = Dr.GetString("datetime_edit")
                Me.txtRCTC1symptom.Text = Dr.GetString("symptom")
                Me.txtRCTCaccessory.Text = Dr.GetString("accressory")
                Me.txtRCTC1fix.Text = Dr.GetString("note")
            End Using
            Mainfrm.lblMainStatus.Text = "โหลดข้อมูล Claims แล้ว"
            Mainfrm.lblMainStatus.Text = "โหลดข้อมูล customer"
            strSQL = "SELECT customer_name,customer_tel FROM customer WHERE customer_id='" & Me.txtRCTC1cus_id.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                Me.txtRCTC1cus_name.Text = Dr.GetString("customer_name")
                Me.txtRCTC1cus_tel.Text = Dr.GetString("customer_tel")
            End Using
            Mainfrm.lblMainStatus.Text = "โหลดข้อมูล customer แล้ว"

        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub updateClaimsReturn()
        Mainfrm.lblMainStatus.Text = "ยืนยันการอัพเดทข้อมูลเคลม"
        If MessageBox.Show("คุณแน่ใจว่าจะต้องการบันทึกคืนสินค้าเคลม", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Try
                Mainfrm.lblMainStatus.Text = "เริ่มต้นการอัพเดทข้อมูลเคลม"
                strSQL = "UPDATE claims SET datetime_return=@dtrt,employee_claims_return=@emcr,status=@sta WHERE claims_id='" & Me.txtRCTC1claims_id.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.AddWithValue("@dtrt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")))
                    .Parameters.AddWithValue("@emcr", Me.lblemployee.Text)
                    .Parameters.AddWithValue("@sta", "ส่งคืนแล้ว")
                    Call open_connection()
                    .ExecuteNonQuery()
                End With
                Mainfrm.lblMainStatus.Text = "อัพเดทข้อมูลเคลมแล้ว"
                Mainfrm.lblMainStatus.Text = "ย้ายข้อมูลเคลม"
                strSQL = "INSERT INTO claims_copy(claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,price_buy,price_wholesale,price_technician,price_loyel,price_members,`type`,unit,datetime_sale,datetime_return,datetime_edit,claims_money,employee_claims_return,tel_to_cus,employee_sale,symptom,accressory,note,note2,`status`,employee,datetime_save,claims_id_pic)" _
                    & "SELECT * FROM claims WHERE claims_id='" & Me.txtRCTC1claims_id.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                Mainfrm.lblMainStatus.Text = "ย้ายข้อมูลเคลมเรียบร้อย"
                Mainfrm.lblMainStatus.Text = "ลบข้อมูลเคลมที่ส่งคืนแล้ว"
                strSQL = "DELETE FROM claims WHERE claims_id='" & Me.txtRCTC1claims_id.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                Mainfrm.lblMainStatus.Text = "ลบข้อมูลเคลมที่ส่งคืนแล้วเรียบร้อย"
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = ex.Message
            End Try
            ReturnClaimsToCusFrm.strsqlSelect = 100
            Call ReturnClaimsToCusFrm.getdataClaims()
            ClaimsStatusFrm.strsqlSelect = 200
            Call ClaimsStatusFrm.getdataClaims()
            MsgBox("บันทึกส่งคืนแล้ว รอพิมพ์ใบส่งคืนสักครู่", MsgBoxStyle.Information, "แจ้งเตือน")
            Me.Visible = False
            ReturnClaimsToCusReportPrintFrm.MdiParent = Mainfrm
            ReturnClaimsToCusReportPrintFrm.Show()
        Else
            Mainfrm.lblMainStatus.Text = "การอัพเดทข้อมูลเคลมถูกยกเลิก"
            Exit Sub
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Mainfrm.lblMainStatus.Text = "ยกเลิกคืนสินค้าเคลม"
        Me.Close()
    End Sub

    Private Sub ReturnClaimstoCus1Frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblemployee.Text = ReturnClaimsToCusFrm.lblemployee.Text
        Me.Icon = Mainfrm.Icon
    End Sub

    Private Sub btnRCTC1save_Click(sender As Object, e As EventArgs) Handles btnRCTC1save.Click
        Call updateClaimsReturn()
    End Sub
End Class