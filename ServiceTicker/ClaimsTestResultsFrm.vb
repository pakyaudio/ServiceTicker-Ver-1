Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class ClaimsTestResultsFrm

    Private Sub startFrm()
        Me.txtCTRcus_id.Clear()
        Me.txtCTRcus_name.Clear()
        Me.txtCTRclaims_id.Clear()
        Me.txtCTRclaims_sn.Clear()
        Me.txtCTRclaims_code_pro.Clear()
        Me.txtCTR_claims_barcode.Clear()
        Me.txtCTRclaims_namepro.Clear()
        Me.txtCTRclaims_sytom.Clear()
        Me.txtCTRclaims_datetime_save.Clear()
        Me.txtCTRclaims_datetime_send.Clear()
        Me.txtCTRclaims_correction.Clear()
        Me.txtCTRtest_note.Clear()
        Me.txtCTRnewSN.Enabled = False
        Me.rbCTRold_sn.Checked = True
        Me.btnCTRsave.Text = "บันทึก"
        Me.btnCTRcancel.Visible = False
        Me.txtCTRsearchSN.Enabled = True
        Me.Button1.Enabled = True
        Me.dgCTR.Enabled = True
        Call chsRB()
        Me.txtCTRsearchSN.Focus()
    End Sub
    Private Sub chsRB()
        If Me.rbCTRold_sn.Checked = True Then
            Me.txtCTRnewSN.Enabled = False
            Me.txtCTRnewSN.Clear()
            Me.txtCTRnewSN.BackColor = SystemColors.Control
        Else
            Me.txtCTRnewSN.Enabled = True
            Me.txtCTRnewSN.BackColor = Color.LemonChiffon
        End If
    End Sub
    Private Sub testRB()
        If Me.rbCTRtestPass.Checked = True Then
            Me.txtCTRtest_note.Enabled = False
            Me.txtCTRtest_note.Clear()
            Me.txtCTRtest_note.BackColor = SystemColors.Control
        Else
            Me.txtCTRtest_note.Enabled = True
            Me.txtCTRtest_note.BackColor = Color.LemonChiffon
        End If
    End Sub
    Private Sub addDataTodgCTR()
        Dim dg As Integer = Me.dgCTR.Rows.Count
        Me.dgCTR.Rows.Add()
        Me.dgCTR.Rows(dg).Cells(0).Value = dg + 1
        Me.dgCTR.Rows(dg).Cells(1).Value = Me.txtCTRclaims_id.Text
        If Me.rbCTRold_sn.Checked = True Then
            Me.dgCTR.Rows(dg).Cells(2).Value = Me.txtCTRclaims_sn.Text
            Me.dgCTR.Rows(dg).Cells(3).Value = Me.txtCTRclaims_sn.Text
        ElseIf Me.rbCTRnew_sn.Checked = True Then
            Me.dgCTR.Rows(dg).Cells(2).Value = Me.txtCTRclaims_sn.Text
            Me.dgCTR.Rows(dg).Cells(3).Value = Me.txtCTRnewSN.Text
        End If
        Me.dgCTR.Rows(dg).Cells(4).Value = Me.txtCTRclaims_code_pro.Text
        Me.dgCTR.Rows(dg).Cells(5).Value = Me.txtCTRclaims_namepro.Text
        Me.dgCTR.Rows(dg).Cells(6).Value = Me.txtCTRclaims_correction.Text
        If Me.rbCTRtestPass.Checked = True Then
            Me.dgCTR.Rows(dg).Cells(7).Value = "ผ่าน"
        ElseIf Me.rbCTRtestNoPass.Checked = True Then
            Me.dgCTR.Rows(dg).Cells(7).Value = "ไม่ผ่าน"
        End If
    End Sub
    Private Sub EditDataTodgCTR()
        Me.dgCTR.SelectedCells.Item(1).Value = Me.txtCTRclaims_id.Text
        If Me.rbCTRold_sn.Checked = True Then
            Me.dgCTR.SelectedCells.Item(2).Value = Me.txtCTRclaims_sn.Text
            Me.dgCTR.SelectedCells.Item(3).Value = Me.txtCTRclaims_sn.Text
        ElseIf Me.rbCTRnew_sn.Checked = True Then
            Me.dgCTR.SelectedCells.Item(2).Value = Me.txtCTRclaims_sn.Text
            Me.dgCTR.SelectedCells.Item(3).Value = Me.txtCTRnewSN.Text
        End If
        Me.dgCTR.SelectedCells.Item(4).Value = Me.txtCTRclaims_code_pro.Text
        Me.dgCTR.SelectedCells.Item(5).Value = Me.txtCTRclaims_namepro.Text
        Me.dgCTR.SelectedCells.Item(6).Value = Me.txtCTRclaims_correction.Text
        If Me.rbCTRtestPass.Checked = True Then
            Me.dgCTR.SelectedCells.Item(7).Value = "ผ่าน"
        ElseIf Me.rbCTRtestNoPass.Checked = True Then
            Me.dgCTR.SelectedCells.Item(7).Value = "ไม่ผ่าน"
        End If
    End Sub
    Friend Sub getDataClaimsSNtoTextBox()
        Try
            Mainfrm.lblMainStatus.Text = "ตรวจสอบสถานะเคม"
            strSQL = "SELECT `status` FROM claims WHERE serial_pro='" & Me.txtCTRsearchSN.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader

            If Not Dr.HasRows Then
                MsgBox("ไม่พบข้อมูลเคลม " & Me.txtCTRsearchSN.Text, MsgBoxStyle.Exclamation, "NO Data")
                Call startFrm()
                Me.txtCTRsearchSN.Clear()
                Me.txtCTRsearchSN.Focus()
            Else
                Dim sta As String
                Dr.Read()
                sta = Dr.GetString("status")
                If sta = "รอทดสอบ" Then
                    Mainfrm.lblMainStatus.Text = "ตรวจสอบสถานะเคลมผ่าน"
                    Mainfrm.lblMainStatus.Text = "โหลด sn เคลม"
                    strSQL = "SELECT claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,symptom,datetime_save,datetime_edit FROM claims WHERE serial_pro='" & Me.txtCTRsearchSN.Text & "'"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    If Dr.HasRows Then
                        With Dr
                            .Read()
                            Me.txtCTRcus_id.Text = .Item("customer_id")
                            Me.txtCTRclaims_id.Text = .Item("claims_id")
                            Me.txtCTRclaims_sn.Text = .Item("serial_pro")
                            Me.txtCTRclaims_code_pro.Text = .Item("code_pro")
                            Me.txtCTR_claims_barcode.Text = .Item("bar_code")
                            Me.txtCTRclaims_namepro.Text = .Item("name_pro")
                            Me.txtCTRclaims_sytom.Text = .Item("symptom")
                            Me.txtCTRclaims_datetime_save.Text = .Item("datetime_save")
                            Me.txtCTRclaims_datetime_send.Text = .Item("datetime_edit")
                        End With
                        'โหลดชื่อลูกค้า
                        Mainfrm.lblMainStatus.Text = "โหลด sn เคลมเสร็จ"
                        If Me.txtCTRcus_id.Text = "สินค้าจากสต็อก" Or Me.txtCTRcus_id.Text = "-" Then
                            Me.txtCTRcus_name.Text = "-"
                        Else
                            Mainfrm.lblMainStatus.Text = "โหลด customer_name"
                            Mainfrm.lblMainStatus.Text = "พร้อมใช้งาน"
                            strSQL = "SELECT customer_name FROM customer WHERE customer_id='" & Me.txtCTRcus_id.Text & "'"
                            cmd = New MySqlCommand(strSQL, ConnectionDB)
                            Call open_connection()
                            Dr = cmd.ExecuteReader
                            Dr.Read()
                            If Dr.HasRows Then
                                Me.txtCTRcus_name.Text = Dr.Item("customer_name")
                            End If
                        End If
                        Mainfrm.lblMainStatus.Text = "โหลด customer_name เสร็จ"
                        Me.txtCTRsearchSN.Text = ""
                        Me.txtCTRclaims_correction.Focus()
                    End If
                Else
                    MsgBox("สินค้านี้ไม่ได้อยู่ในสถานะรอทดสอบ", MsgBoxStyle.Exclamation, "มีอะไรผิดพลาด")
                    Me.txtCTRsearchSN.Text = ""
                    Me.txtCTRsearchSN.Focus()
                    Mainfrm.lblMainStatus.Text = "ตรวจสอบสถานะเคลมไม่ผ่าน"
                End If
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "โหลด sn ผิดพลาด"
        End Try

    End Sub

    Private Sub ClaimsTestResultsFrm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Call TRUNCATEdata()
    End Sub

    Private Sub ClaimsTestResultsFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            If dgCTR.Rows.Count = 0 Then
            Else
                strSQL = "SELECT `status` FROM claims WHERE claims_id='" & Me.dgCTR.Rows(0).Cells(1).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                Dim star As String = Dr.GetString("status")
                If star = "ทดสอบแล้ว" Then
                    e.Cancel = False
                    Mainfrm.lblMainStatus.Text = "ปิดหน้าต่าง"
                Else
                    If MessageBox.Show("ยังไม่ได้บันทึกผลการทดสอบสินค้าเคลม ต้องการจะปิดเลยหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        For f As Integer = 0 To Me.dgCTR.Rows.Count - 1
                            strSQL = "DELETE FROM claims_test_results WHERE claims_id='" & Me.dgCTR.Rows(f).Cells(1).Value & "'"
                            cmd = New MySqlCommand(strSQL, ConnectionDB)
                            Call open_connection()
                            cmd.ExecuteNonQuery()
                        Next
                        e.Cancel = False
                        Mainfrm.lblMainStatus.Text = "ปิดหน้าต่าง"
                    Else
                        e.Cancel = True
                        Mainfrm.lblMainStatus.Text = "ยกเลิกการปิดหน้าต่าง"
                        Me.TabControl1.SelectedTab = TabPage2
                    End If

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ClaimsTestResultsFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Icon = Mainfrm.Icon
        Call startFrm()
    End Sub

    Private Sub txtCTRsearchSN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCTRsearchSN.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call getDataClaimsSNtoTextBox()
        End If
    End Sub

    Private Sub rbCTRnew_sn_CheckedChanged(sender As Object, e As EventArgs) Handles rbCTRnew_sn.CheckedChanged
        Call chsRB()
    End Sub


    Private Sub rbCTRold_sn_CheckedChanged(sender As Object, e As EventArgs) Handles rbCTRold_sn.CheckedChanged
        Call chsRB()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ClaimsTestSelectFrm.MdiParent = Mainfrm
        ClaimsTestSelectFrm.Show()
    End Sub

    Private Sub strSave()
        Try
            strSQL = "INSERT INTO claims_test_results(claims_id,fix_by_company,old_sn,new_sn,test_results,test_note,datetime_save)" _
                & "VALUES(@claims_id,@fix_by_company,@old_sn,@new_sn,@test_results,@test_note,@datetime_save)"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            cmd.Parameters.AddWithValue("@claims_id", Me.txtCTRclaims_id.Text)
            cmd.Parameters.AddWithValue("@fix_by_company", Me.txtCTRclaims_correction.Text)
            cmd.Parameters.AddWithValue("@old_sn", Me.txtCTRclaims_sn.Text)
            If Me.rbCTRold_sn.Checked = True Then
                cmd.Parameters.AddWithValue("@new_sn", Me.txtCTRclaims_sn.Text)
            ElseIf Me.rbCTRnew_sn.Checked = True Then
                cmd.Parameters.AddWithValue("@new_sn", Me.txtCTRnewSN.Text)
            End If
            If Me.rbCTRtestPass.Checked = True Then
                cmd.Parameters.AddWithValue("@test_results", "past")
                cmd.Parameters.AddWithValue("@test_note", "past")
            ElseIf Me.rbCTRtestNoPass.Checked = True Then
                cmd.Parameters.AddWithValue("@test_results", "fail")
                cmd.Parameters.AddWithValue("@test_note", Me.txtCTRtest_note.Text)
            End If
            cmd.Parameters.AddWithValue("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")))
            Call open_connection()
            cmd.ExecuteNonQuery()
            Call addDataTodgCTR()
            Call startFrm()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub saveTestClaimsData()
        If Me.txtCTRclaims_id.Text = "" Then
            Timer1.Start()
            Me.lblCTRWarning.Visible = True
            Me.lblCTRWarning.Text = "กรุณาใส่ SN แล้วกด enter เพื่อดึงข้อมูลเคลม"
            Me.txtCTRsearchSN.Focus()
            Me.txtCTRsearchSN.BackColor = Color.OrangeRed
            MsgBox("ยังไม่มีข้อมูล กรุณาป้อน SN", MsgBoxStyle.Exclamation, "แจ้งเตือน")
            Exit Sub
        End If
        If Me.txtCTRclaims_sn.Text = "" Then
            Timer1.Start()
            Me.lblCTRWarning.Visible = True
            Me.lblCTRWarning.Text = "กรุณาใส่ SN แล้วกด enter เพื่อดึงข้อมูลเคลม"
            Me.txtCTRsearchSN.Focus()
            Me.txtCTRsearchSN.BackColor = Color.OrangeRed
            MsgBox("ยังไม่มีข้อมูล กรุณาป้อน SN", MsgBoxStyle.Exclamation, "แจ้งเตือน")
            Exit Sub
        End If
        If Me.txtCTRclaims_correction.Text = "" Then
            Timer1.Start()
            Me.lblCTRWarning.Visible = True
            Me.lblCTRWarning.Text = "กรุณาใส่ ระบุการแก้ไขจากบริษัท"
            Me.txtCTRclaims_correction.Focus()
            Me.txtCTRclaims_correction.BackColor = Color.OrangeRed
            MsgBox("ยังไม่มีข้อมูล การแก้ไขจากบริษัท", MsgBoxStyle.Exclamation, "แจ้งเตือน")
            Exit Sub
        End If
        If Me.rbCTRtestNoPass.Checked = False And Me.rbCTRtestPass.Checked = False Then
            Timer1.Start()
            Me.lblCTRWarning.Visible = True
            Me.lblCTRWarning.Text = "กรุณาใส่ ระบุการแก้ไขจากบริษัท"
            Me.rbCTRtestNoPass.BackColor = Color.OrangeRed
            Me.rbCTRtestPass.BackColor = Color.OrangeRed
            MsgBox("เลือกผลการทดสอบ", MsgBoxStyle.Exclamation, "แจ้งเตือน")
            Exit Sub
        End If
        If Me.rbCTRold_sn.Checked = False And Me.rbCTRnew_sn.Checked = True Then
            If Me.txtCTRnewSN.Text = "" Then
                Timer1.Start()
                Me.lblCTRWarning.Visible = True
                Me.lblCTRWarning.Text = "กรุณาใส่ SN ที่เปลี่ยนใหม่"
                Me.txtCTRnewSN.BackColor = Color.OrangeRed
                Me.txtCTRnewSN.BackColor = Color.OrangeRed
                MsgBox("ใส่ SN สินค้า กรณีเปลี่ยนตัวแล้วเปลี่ยน SN ใหม่", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Exit Sub
            End If
        End If
        If Me.rbCTRtestNoPass.Checked = True And Me.rbCTRtestPass.Checked = False Then
            If Me.txtCTRtest_note.Text = "" Then
                Timer1.Start()
                Me.lblCTRWarning.Visible = True
                Me.lblCTRWarning.Text = "กรุณาใส่ ระบุอาการที่ทดสอบไม่ผ่าน"
                Me.txtCTRtest_note.Focus()
                Me.txtCTRtest_note.BackColor = Color.OrangeRed
                MsgBox("ระบุอาการที่ทดสอบไม่ผ่าน", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Exit Sub
            End If
        End If
        For csn As Integer = 0 To Me.dgCTR.Rows.Count - 1
            If Me.dgCTR.Rows(csn).Cells(2).Value = txtCTRclaims_sn.Text Then
                MsgBox("ข้อมูลนี้อยู่แล้ว", MsgBoxStyle.Exclamation, "ข้อมูลซ้ำ")
                Exit Sub
            End If
        Next
        If MessageBox.Show("คุณแน่ใจว่าข้อมูลถูกต้องและต้องการบันทึก", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Call strSave()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub EditData()
        If Me.txtCTRclaims_id.Text = "" Then
            Timer1.Start()
            Me.lblCTRWarning.Visible = True
            Me.lblCTRWarning.Text = "กรุณาใส่ SN แล้วกด enter เพื่อดึงข้อมูลเคลม"
            Me.txtCTRsearchSN.Focus()
            Me.txtCTRsearchSN.BackColor = Color.OrangeRed
            MsgBox("ยังไม่มีข้อมูล กรุณาป้อน SN", MsgBoxStyle.Exclamation, "แจ้งเตือน")
            Exit Sub
        End If
        If Me.txtCTRclaims_sn.Text = "" Then
            Timer1.Start()
            Me.lblCTRWarning.Visible = True
            Me.lblCTRWarning.Text = "กรุณาใส่ SN แล้วกด enter เพื่อดึงข้อมูลเคลม"
            Me.txtCTRsearchSN.Focus()
            Me.txtCTRsearchSN.BackColor = Color.OrangeRed
            MsgBox("ยังไม่มีข้อมูล กรุณาป้อน SN", MsgBoxStyle.Exclamation, "แจ้งเตือน")
            Exit Sub
        End If
        If Me.txtCTRclaims_correction.Text = "" Then
            Timer1.Start()
            Me.lblCTRWarning.Visible = True
            Me.lblCTRWarning.Text = "กรุณาใส่ ระบุการแก้ไขจากบริษัท"
            Me.txtCTRclaims_correction.Focus()
            Me.txtCTRclaims_correction.BackColor = Color.OrangeRed
            MsgBox("ยังไม่มีข้อมูล การแก้ไขจากบริษัท", MsgBoxStyle.Exclamation, "แจ้งเตือน")
            Exit Sub
        End If
        If Me.rbCTRtestNoPass.Checked = False And Me.rbCTRtestPass.Checked = False Then
            Timer1.Start()
            Me.lblCTRWarning.Visible = True
            Me.lblCTRWarning.Text = "กรุณาใส่ ระบุการแก้ไขจากบริษัท"
            Me.rbCTRtestNoPass.BackColor = Color.OrangeRed
            Me.rbCTRtestPass.BackColor = Color.OrangeRed
            MsgBox("เลือกผลการทดสอบ", MsgBoxStyle.Exclamation, "แจ้งเตือน")
            Exit Sub
        End If
        If Me.rbCTRold_sn.Checked = False And Me.rbCTRnew_sn.Checked = True Then
            If Me.txtCTRnewSN.Text = "" Then
                Timer1.Start()
                Me.lblCTRWarning.Visible = True
                Me.lblCTRWarning.Text = "กรุณาใส่ SN ที่เปลี่ยนใหม่"
                Me.txtCTRnewSN.BackColor = Color.OrangeRed
                Me.txtCTRnewSN.BackColor = Color.OrangeRed
                MsgBox("ใส่ SN สินค้า กรณีเปลี่ยนตัวแล้วเปลี่ยน SN ใหม่", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Exit Sub
            End If
        End If
        If Me.rbCTRtestNoPass.Checked = True And Me.rbCTRtestPass.Checked = False Then
            If Me.txtCTRtest_note.Text = "" Then
                Timer1.Start()
                Me.lblCTRWarning.Visible = True
                Me.lblCTRWarning.Text = "กรุณาใส่ ระบุอาการที่ทดสอบไม่ผ่าน"
                Me.txtCTRtest_note.Focus()
                Me.txtCTRtest_note.BackColor = Color.OrangeRed
                MsgBox("ระบุอาการที่ทดสอบไม่ผ่าน", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Exit Sub
            End If
        End If
        
        If MessageBox.Show("คุณแน่ใจว่าข้อมูลถูกต้องและต้องการแก้ไข", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Try
                strSQL = "UPDATE claims_test_results SET fix_by_company=@fix_by_company,old_sn=@old_sn,new_sn=@new_sn,test_results=@test_results,test_note=@test_note" _
                     & " WHERE claims_id='" & Me.txtCTRclaims_id.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)

                cmd.Parameters.AddWithValue("@fix_by_company", Me.txtCTRclaims_correction.Text)
                cmd.Parameters.AddWithValue("@old_sn", Me.txtCTRclaims_sn.Text)
                If Me.rbCTRold_sn.Checked = True Then
                    cmd.Parameters.AddWithValue("@new_sn", Me.txtCTRclaims_sn.Text)
                ElseIf Me.rbCTRnew_sn.Checked = True Then
                    cmd.Parameters.AddWithValue("@new_sn", Me.txtCTRnewSN.Text)
                End If
                If Me.rbCTRtestPass.Checked = True Then
                    cmd.Parameters.AddWithValue("@test_results", "past")
                    cmd.Parameters.AddWithValue("@test_note", "past")
                ElseIf Me.rbCTRtestNoPass.Checked = True Then
                    cmd.Parameters.AddWithValue("@test_results", "fail")
                    cmd.Parameters.AddWithValue("@test_note", Me.txtCTRtest_note.Text)
                End If
                Call open_connection()
                cmd.ExecuteNonQuery()
                Call EditDataTodgCTR()
                MsgBox("แก้ไขแล้ว")
                Call startFrm()
            Catch ex As Exception

            End Try
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnCTRsave_Click(sender As Object, e As EventArgs) Handles btnCTRsave.Click
        If Me.btnCTRsave.Text = "บันทึก" Then
            Call saveTestClaimsData()
        ElseIf Me.btnCTRsave.Text = "แก้ไข" Then
            Call EditData()
        End If
    End Sub

    Private Sub rbCTRtestNoPass_CheckedChanged(sender As Object, e As EventArgs) Handles rbCTRtestNoPass.CheckedChanged
        Call testRB()
    End Sub

    Private Sub rbCTRtestPass_CheckedChanged(sender As Object, e As EventArgs) Handles rbCTRtestPass.CheckedChanged
        Call testRB()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.lblCTRWarning.Visible = False
        Me.lblCTRWarning.Text = "Warning"
        Me.txtCTRsearchSN.BackColor = Color.LemonChiffon
        Me.txtCTRclaims_correction.BackColor = Color.LemonChiffon
        Me.txtCTRtest_note.BackColor = Color.LemonChiffon
        Me.rbCTRtestNoPass.BackColor = SystemColors.Control
        Me.rbCTRtestPass.BackColor = SystemColors.Control
        Call chsRB()
        Call testRB()
        Timer1.Stop()
    End Sub

    Private Sub dgCTR_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgCTR.CellMouseDoubleClick
        Try
            strSQL = "SELECT fix_by_company,old_sn FROM claims_test_results WHERE claims_id='" & Me.dgCTR.SelectedCells.Item(1).Value & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                Me.txtCTRsearchSN.Text = Dr.GetString("old_sn")
                Me.txtCTRclaims_correction.Text = Dr.GetString("fix_by_company")
                Me.TabControl1.SelectedTab = TabPage1
                Me.btnCTRsave.Text = "แก้ไข"
                Me.btnCTRcancel.Visible = True
                Me.txtCTRsearchSN.Enabled = False
                Me.Button1.Enabled = False
                Me.dgCTR.Enabled = False
                Call getDataClaimsSNtoTextBox()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub TRUNCATEdata()
        Mainfrm.lblMainStatus.Text = "ลบข้อมูลเคลมชั่วคราว"
        strSQL = "TRUNCATE `claims_send_report`;"
        cmd = New MySqlCommand(strSQL, ConnectionDB)
        Call open_connection()
        cmd.ExecuteNonQuery()
        Mainfrm.lblMainStatus.Text = "ลบข้อมูลเคลมชั่วคราวเสร็จ"
    End Sub
    Private Sub btnCTRcancel_Click(sender As Object, e As EventArgs) Handles btnCTRcancel.Click
        Call startFrm()
    End Sub
    Private Sub DelData()
        Try
            strSQL = "DELETE FROM claims_test_results WHERE claims_id='" & Me.dgCTR.SelectedCells.Item(1).Value & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
                For i As Integer = Me.dgCTR.SelectedRows.Count - 1 To 0 Step -1
                    Me.dgCTR.Rows.RemoveAt(Me.dgCTR.SelectedRows(i).Index)
                Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgCTR_KeyDown(sender As Object, e As KeyEventArgs) Handles dgCTR.KeyDown
        If e.KeyCode = Keys.Delete Then
            If Me.dgCTR.SelectedCells.Count = 0 Then
            ElseIf Me.dgCTR.SelectedCells.Count > 0 Then
                If MessageBox.Show("คุณแน่ใจว่าต้องการจะลบข้อมูล " & Me.dgCTR.SelectedCells.Item(1).Value, "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    Call DelData()
                Else
                    Exit Sub
                End If
            End If
        End If
    End Sub
    Private Sub updateData()
        Try
            Mainfrm.lblMainStatus.Text = "เริ่มเปลี่ยนแปลงข้อมูลเคลม"
            For gg As Integer = 0 To dgCTR.Rows.Count - 1
                Dim n As String = Me.dgCTR.Rows(gg).Cells(1).Value
                'update claims status
                strSQL = "UPDATE claims SET status='" & "ทดสอบแล้ว" & "',datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "',employee='" & Me.lblemployee.Text & "' WHERE claims_id='" & n & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                'update claims send status
                strSQL = "UPDATE claims_send SET claims_send_status='" & "ทดสอบแล้ว" & "',datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "',employee='" & Me.lblemployee.Text & "' WHERE claims_id='" & n & "'"
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
           
            ClaimsSendReportPrintFrm.Ctxt = 400
            ClaimsSendReportPrintFrm.MdiParent = Mainfrm
            ClaimsSendReportPrintFrm.Show()
            MsgBox("บันทึกทดสอบแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
            Me.dgCTR.Rows.Clear()
            Call startFrm()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
   
    Private Sub btnCTRsaveAll_Click(sender As Object, e As EventArgs) Handles btnCTRsaveAll.Click
        If MessageBox.Show("คุณแน่ใจว่าต้องการจะบันทึกข้อมูลทั้งหมด ", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Call updateData()
        Else
            Exit Sub
        End If
    End Sub
End Class