Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class ClaimsTeltoCusFrm

    Private Sub ClaimsTeltoCusFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblCTCteltocus.Text = ClaimsStatusFrm.teltocustel
        ClaimsStatusFrm.teltocustel = Nothing
        Me.Icon = Mainfrm.Icon
    End Sub

    Private Sub btnCTCsave_Click(sender As Object, e As EventArgs) Handles btnCTCsave.Click
        If Me.ComboBox1.Text = "" Then
            Mainfrm.lblMainStatus.Text = "เลือกการโทรแจ้งก่อน"
            MsgBox("เลือกการโทรแจ้งก่อน", MsgBoxStyle.Information, "แจ้งเตือน")
        Else
            Dim UpDateAns As String
            Mainfrm.lblMainStatus.Text = "คุณแน่ใจว่าจะเปลี่ยนแปลงข้อมูลนี้"
            UpDateAns = MsgBox("คุณแน่ใจว่าจะเปลี่ยนแปลงข้อมูลนี้", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
            If UpDateAns = System.Windows.Forms.DialogResult.No Then
                Mainfrm.lblMainStatus.Text = "การบันทึกข้อมูลถูกยกเลิก"
                MsgBox("การบันทึกข้อมูลถูกยกเลิก", MsgBoxStyle.Information, "ยกเลิกการบันทึก")
                Exit Sub
            Else
                Try
                    strSQL = "UPDATE claims SET tel_to_cus='" & Me.ComboBox1.Text & "',datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "'" _
                                & ",employee='" & ClaimsStatusFrm.lblemployee.Text & "' WHERE claims_id='" & Me.lblCTCclaims_id.Text & "'"
                    Mainfrm.lblMainStatus.Text = strSQL
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                    Mainfrm.lblMainStatus.Text = "บันทึกข้อมูลแล้ว"
                    ClaimsStatusFrm.strsqlSelect = 200
                    ClaimsStatusFrm.getdataClaims()
                    MsgBox("บันทึกข้อมูลแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
                    Me.Close()
                Catch ex As Exception

                End Try
            End If
        End If
    End Sub
End Class