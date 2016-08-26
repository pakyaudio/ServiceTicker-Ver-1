Imports MySql.Data.MySqlClient

Public Class ClaimsStatusFrm
    Private Sub Data_History_Bus_Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Mainfrm.lblMainStatus.Text = "หน้าต่างติดตามสถานะงานเคลมถูกปิด"
    End Sub

    Private Sub ClaimsStatusFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        strsqlSelect = 400
        Call getdataClaims()
    End Sub
    Friend strsqlSelect As String
    Friend Sub getdataClaims()
        Try
            Mainfrm.lblMainStatus.Text = "โหลดข้อมูล Claims"
            Me.dgCS.Rows.Clear()
            If strsqlSelect = 100 Then
                strSQL = "SELECT claims_id,customer_id,serial_pro,name_pro,symptom,note,note2,status,tel_to_cus,datetime_save FROM claims WHERE status='" & Me.cbbCSclaimsStatus.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
            ElseIf strsqlSelect = 200 Then
                strSQL = "SELECT claims_id,customer_id,serial_pro,name_pro,symptom,note,note2,status,tel_to_cus,datetime_save FROM claims WHERE NOT `status`='" & "ส่งคืนแล้ว" & "'"
                Mainfrm.lblMainStatus.Text = strSQL
            ElseIf strsqlSelect = 300 Then
                strSQL = "SELECT claims_id,customer_id,serial_pro,name_pro,symptom,note,note2,status,tel_to_cus,datetime_save FROM claims WHERE "
                Dim strKeyWord As String = Me.txtCSsearch.Text
                If strKeyWord <> "" Then
                    strSQL = strSQL & "name_pro like '%" & strKeyWord & "%'  or serial_pro like '%" & strKeyWord & "%';"
                End If
                Mainfrm.lblMainStatus.Text = strSQL
            ElseIf strsqlSelect = 400 Then
                strSQL = "SELECT claims_id,customer_id,serial_pro,name_pro,symptom,note,note2,`status`,tel_to_cus,datetime_save FROM claims" _
                & " WHERE NOT `status`='" & "ส่งคืนแล้ว" & "'"
                Mainfrm.lblMainStatus.Text = strSQL
            End If

            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dim r As Integer
                While (Dr.Read())
                    With Me.dgCS
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(1).Value = Dr.Item("claims_id")
                        .Rows(r).Cells(2).Value = Dr.Item("customer_id")
                        .Rows(r).Cells(4).Value = Dr.Item("serial_pro")
                        .Rows(r).Cells(5).Value = Dr.Item("name_pro")
                        .Rows(r).Cells(6).Value = Dr.Item("symptom")
                        .Rows(r).Cells(7).Value = Dr.Item("status")
                        .Rows(r).Cells(8).Value = Dr.Item("tel_to_cus")
                        .Rows(r).Cells(9).Value = Dr.Item("datetime_save")
                        .Rows(r).Cells(10).Value = Dr.Item("note2")
                        .Rows(r).Cells(11).Value = Dr.Item("note")
                    End With
                End While
            End Using
            For sum As Integer = 0 To Me.dgCS.Rows.Count - 1
                Me.dgCS.Rows(sum).Cells(0).Value = sum + 1
                If Me.dgCS.Rows(sum).Cells(2).Value = "สินค้าจากสต็อก" Then
                    With Me.dgCS
                        .Rows(sum).Cells(3).Value = "-"
                    End With
                Else
                    strSQL = "SELECT customer_name FROM customer WHERE customer_id='" & Me.dgCS.Rows(sum).Cells(2).Value & "'"
                    Mainfrm.lblMainStatus.Text = strSQL
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader()
                    Dr.Read()
                    With Me.dgCS
                        .Rows(sum).Cells(3).Value = Dr.Item("customer_name")
                    End With
                End If
            
            Next
            Dr.Close()
            Mainfrm.lblMainStatus.Text = "โหลดข้อมูล Claims แล้ว"
            strsqlSelect = Nothing
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub cbbCSclaimsStatus_Click(sender As Object, e As EventArgs) Handles cbbCSclaimsStatus.Click
        Me.cbbCSclaimsStatus.Items.Clear()
        Me.cbbCSclaimsStatus.Items.Add("รับเข้าระบบ")
        Me.cbbCSclaimsStatus.Items.Add("ส่งเคลม")
        Me.cbbCSclaimsStatus.Items.Add("ส่งไปงานช่าง")
        Me.cbbCSclaimsStatus.Items.Add("รอคืนเงิน")
        Me.cbbCSclaimsStatus.Items.Add("ซ่อมเสร็จ")
        Me.cbbCSclaimsStatus.Items.Add("รอส่งคืน")
        Me.cbbCSclaimsStatus.Items.Add("ส่งคืนแล้ว")
    End Sub

    Private Sub cbbCSclaimsStatus_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbCSclaimsStatus.SelectedValueChanged
        strsqlSelect = 100
        Call getdataClaims()
    End Sub
    
    Private Sub dgCS_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCS.CellDoubleClick
        Mainfrm.lblMainStatus.Text = "เรียกหน้าต่างดำเนินการสถานะเคลม"
        If Me.dgCS.SelectedCells.Item(7).Value = "รับเข้าระบบ" Then
            EditClaimsStatusFrm.MdiParent = Mainfrm
            EditClaimsStatusFrm.Show()
            EditClaimsStatusFrm.txtECSclaimsID.Text = Me.dgCS.SelectedCells.Item(1).Value
            EditClaimsStatusFrm.txtECScus_id.Text = Me.dgCS.SelectedCells.Item(2).Value
            EditClaimsStatusFrm.txtECScus_name.Text = Me.dgCS.SelectedCells.Item(3).Value
        ElseIf Me.dgCS.SelectedCells.Item(7).Value = "ส่งเคลม" Then
            Mainfrm.lblMainStatus.Text = "สถานะ ส่งเคลม จัดการข้อมูลส่งเคลมที่ งานเคลม >> จัดการสินค้าเคลม(ส่งออกข้างนอก)"
            '    EditClaimsStatusFrm.MdiParent = Mainfrm
            '    EditClaimsStatusFrm.Show()
            '    EditClaimsStatusFrm.txtECSclaimsID.Text = Me.dgCS.SelectedCells.Item(1).Value
            '    EditClaimsStatusFrm.txtECScus_id.Text = Me.dgCS.SelectedCells.Item(2).Value
            '    EditClaimsStatusFrm.txtECScus_name.Text = Me.dgCS.SelectedCells.Item(3).Value
        ElseIf Me.dgCS.SelectedCells.Item(7).Value = "รอทดสอบ" Then
            Mainfrm.lblMainStatus.Text = "สถานะ รอทดสอบ จัดการข้อมูลส่งเคลมที่ งานเคลม >> จัดการสินค้าเคลม(ส่งออกข้างนอก)"
        ElseIf Me.dgCS.SelectedCells.Item(7).Value = "ทดสอบแล้ว" Then
            Mainfrm.lblMainStatus.Text = "สถานะ ทดสอบแล้ว จัดการข้อมูลส่งเคลมที่ งานเคลม >> จัดการสินค้าเคลม(ส่งออกข้างนอก)"
        ElseIf Me.dgCS.SelectedCells.Item(7).Value = "ส่งไปงานช่าง" Then
            Mainfrm.lblMainStatus.Text = "สถานะ ส่งไปงานช่าง ต้องรองานช่างส่งข้อมูลกลับมา"
        ElseIf Me.dgCS.SelectedCells.Item(7).Value = "ส่งซ่อม" Then
            Mainfrm.lblMainStatus.Text = "ต้องรองานช่าง ส่งกลับมา"
            MsgBox("ต้องรองานช่าง ส่งกลับมา", MsgBoxStyle.Information, "แจ้งเตือน")
        ElseIf Me.dgCS.SelectedCells.Item(7).Value = "รอคืนเงิน" Then
            SendMoneyClaimsFrm.MdiParent = Mainfrm
            SendMoneyClaimsFrm.Show()
            SendMoneyClaimsFrm.txtRPsearchSN.Text = Me.dgCS.SelectedCells.Item(4).Value
            Call SendMoneyClaimsFrm.getDatatodgRPproBySN()
        ElseIf Me.dgCS.SelectedCells.Item(7).Value = "ซ่อมเสร็จ" Then
            ClaimsComfixBackFrm.MdiParent = Mainfrm
            ClaimsComfixBackFrm.Show()
        ElseIf Me.dgCS.SelectedCells.Item(7).Value = "รอส่งคืน" Then
            If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
                MiniAllLoginFrm.Close()
            End If
            Mainfrm.MenuLoigName = "คืนสินค้าเคลม"
            Call Mainfrm.checkAccess()
            If Mainfrm.access = 1 Then
                MiniAllLoginFrm.MdiParent = Me
                MiniAllLoginFrm.Show()
            ElseIf Mainfrm.access = 0 Then
                ReturnClaimsToCusFrm.MdiParent = Me
                ReturnClaimsToCusFrm.Show()
                ReturnClaimsToCusFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
            Else
                MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
            End If
        End If
    End Sub

    Private Sub btnCSshowAll_Click(sender As Object, e As EventArgs) Handles btnCSshowAll.Click
        strsqlSelect = 200
        Call getdataClaims()
    End Sub

    Private Sub txtCSsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCSsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            strsqlSelect = 300
            Call getdataClaims()
        End If
    End Sub

    Private Sub btnCSsearch_Click(sender As Object, e As EventArgs) Handles btnCSsearch.Click
        strsqlSelect = 300
        Call getdataClaims()
    End Sub

    Private Sub dgCS_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgCS.CellMouseClick
        Me.btnCSeditteltocus.Enabled = True
    End Sub
    Friend teltocustel As String
    Private Sub btnCSeditteltocus_Click(sender As Object, e As EventArgs) Handles btnCSeditteltocus.Click
        Try
            If Me.dgCS.SelectedCells.Item(2).Value = "สินค้าจากสต็อก" Then
                MsgBox("สินค้าของร้าน", MsgBoxStyle.Information, "NO Tel")
            Else
                strSQL = "SELECT customer_name,customer_tel FROM customer WHERE customer_id='" & Me.dgCS.SelectedCells.Item(2).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                teltocustel = Dr.GetString("customer_name") & " เบอร์โทร " & Dr.GetString("customer_tel")
                ClaimsTeltoCusFrm.MdiParent = Mainfrm
                ClaimsTeltoCusFrm.Show()
                ClaimsTeltoCusFrm.lblCTCclaims_id.Text = Me.dgCS.SelectedCells.Item(1).Value
            End If
           

        Catch ex As Exception

        End Try

    End Sub

End Class