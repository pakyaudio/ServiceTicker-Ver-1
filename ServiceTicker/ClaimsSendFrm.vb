Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class ClaimsSendFrm

    Private Sub SaveData()
        Try
        Mainfrm.lblMainStatus.Text = "บันทึกข้อมูลเคลม claims_send"
        strSQL = "INSERT INTO claims_send(claims_id,claims_company,claims_company_id,claims_note,claims_send_status,datetime_edit,datetime_save,employee)" _
            & "VALUES(@claims_id,@claims_company,@claims_company_id,@claims_note,@claims_send_status,@datetime_edit,@datetime_save,@employee)"
        Mainfrm.lblMainStatus.Text = strSQL
        cmd = New MySqlCommand(strSQL, ConnectionDB)
        With cmd
            .Parameters.AddWithValue("@claims_id", Me.txtCSclaims_id.Text)
            .Parameters.AddWithValue("@claims_company", Me.txtCScom_name.Text)
            .Parameters.AddWithValue("@claims_company_id", Me.txtCScom_id.Text)
            .Parameters.AddWithValue("@claims_note", "-")
            .Parameters.AddWithValue("@claims_send_status", "ส่งเคลม")
            .Parameters.AddWithValue("@datetime_edit", "-")
            .Parameters.AddWithValue("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")))
                .Parameters.AddWithValue("@employee", ClaimsStatusFrm.lblemployee.Text)
        End With
        Call open_connection()
        cmd.ExecuteNonQuery()
            Mainfrm.lblMainStatus.Text = "บันทึกข้อมูลเคลม claims_send แล้ว"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub UpdateStatus()
        Try
        Mainfrm.lblMainStatus.Text = "อัพเดทข้อมูลเคลม claims"
            strSQL = "UPDATE claims SET status=@status,note2=@n2 WHERE claims_id='" & Me.txtCSclaims_id.Text & "'"
        Mainfrm.lblMainStatus.Text = strSQL
        cmd = New MySqlCommand(strSQL, ConnectionDB)
            cmd.Parameters.Add(New MySqlParameter("@status", "ส่งเคลม"))
            cmd.Parameters.Add(New MySqlParameter("@n2", "ส่งเคลม-" + Me.txtCScom_name.Text))
        Call open_connection()
        cmd.ExecuteNonQuery()
            Mainfrm.lblMainStatus.Text = "อัพเดทข้อมูลเคลม claims แล้ว"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ClaimsSendFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ClaimsCompanyFrm.MdiParent = Mainfrm
        ClaimsCompanyFrm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Me.txtCScom_id.Text = "" Then
            MsgBox("กรุณาเลือกบริษัทก่อน", MsgBoxStyle.Information, "แจ้งเตือน")
            Exit Sub
        Else
            BoxCoverPrintFrm.Show()
        End If
    End Sub

    Private Sub btnCScancel_Click(sender As Object, e As EventArgs) Handles btnCScancel.Click
        Me.Close()
    End Sub

    Private Sub btnCSsave_Click(sender As Object, e As EventArgs) Handles btnCSsave.Click
        If Me.txtCScom_id.Text = "" Then
            MsgBox("กรุณาเลือกบริษัทก่อน", MsgBoxStyle.Information, "แจ้งเตือน")
            Exit Sub
        Else
            If MessageBox.Show("คุณแน่ใจว่าจะเปลี่ยนแปลงข้อมูลนี้", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Call SaveData()
                Call UpdateStatus()
                EditClaimsStatusFrm.Close()
                ClaimsStatusFrm.strsqlSelect = 200
                Call ClaimsStatusFrm.getdataClaims()
                Me.Close()
            Else
                Mainfrm.lblMainStatus.Text = "การเปลี่ยนแปลงข้อมูลถูกยกเลิก"
                Exit Sub
            End If
            'Dim Ans As String
            'Ans = MsgBox("คุณแน่ใจว่าจะเปลี่ยนแปลงข้อมูลนี้", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
            'If Ans = System.Windows.Forms.DialogResult.No Then
            '    MsgBox("การเปลี่ยนแปลงข้อมูลถูกยกเลิก", MsgBoxStyle.Information, "ยืนยัน")
            '    Exit Sub
            'Else
            '    Call SaveData()
            '    Call UpdateStatus()
            '    EditClaimsStatusFrm.Close()
            '    ClaimsStatusFrm.strsqlSelect = 200
            '    Call ClaimsStatusFrm.getdataClaims()
            '    Me.Close()
            'End If
        End If
    End Sub
    Friend ecom As String
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ecom = 100
        BoxCoverCompanyFrm.MdiParent = Mainfrm
        BoxCoverCompanyFrm.Show()
    End Sub
End Class