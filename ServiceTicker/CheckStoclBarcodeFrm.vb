Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Data.SQLite
'เสร็จ 2015-11-26
Public Class CheckStoclBarcodeFrm
    Private Sub ccs()
        Try
            strSQL = "SELECT csbc_id FROM check_stock_bc_id WHERE csbc_status='เตรียมสต็อกเสร็จสิ้น'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                Me.txtCSBCid.Text = Dr.GetString("csbc_id")
                strSQL = "SELECT code_pro,bar_code,name_pro,price_buy,count_num,count FROM check_stock_bc WHERE csbc_id='" & Me.txtCSBCid.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                While Dr.Read()
                    Dim r As Integer
                    With Me.dgCSBC
                        r = .Rows.Count
                        .Rows.Add()
                        .Rows(r).Cells(1).Value = Dr.GetString("code_pro")
                        .Rows(r).Cells(2).Value = Dr.GetString("bar_code")
                        .Rows(r).Cells(3).Value = Dr.GetString("name_pro")
                        .Rows(r).Cells(4).Value = Dr.GetString("price_buy")
                        .Rows(r).Cells(5).Value = Dr.GetDecimal("count_num")
                        If Dr.GetString("count") = Nothing Then
                            .Rows(r).Cells(6).Value = 0
                        Else
                            .Rows(r).Cells(6).Value = Dr.GetString("count")
                        End If
                    End With
                End While
                strSQL = "SELECT datetime_last FROM check_stock_bc_id WHERE csbc_id='" & Me.txtCSBCid.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                Label6.Text = "บันทึกข้อมูลล่าสุดเมื่อ " & Dr.GetString("datetime_last")
                Try
                    For noo As Integer = 0 To Me.dgCSBC.Rows.Count - 1
                        Me.dgCSBC.Rows(noo).Cells(0).Value = noo + 1
                    Next
                    Me.dgCSBC.Refresh()
                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                End Try
                Call sumTotalPro()
            Else
                Call AutoNumberNo()
                Call sumTotalPro()
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub CheckStoclBarcodeFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If BGWgetDatat.IsBusy = True Then
            MsgBox("กำลังทำงานไม่สามารถปิดได้", MsgBoxStyle.Information, "รอสักครู่")
            e.Cancel = True
        Else
            BGWgetDatat.Dispose()
            Try
                Me.Cursor = Cursors.WaitCursor
                Application.DoEvents()
                For upd As Integer = 0 To Me.dgCSBC.Rows.Count - 1
                    strSQL = "UPDATE check_stock_bc SET count_num='" & Me.dgCSBC.Rows(upd).Cells(5).Value & "'," _
                        & "count='" & Me.dgCSBC.Rows(upd).Cells(6).Value & "' " _
                        & "WHERE csbc_id='" & Me.txtCSBCid.Text & "' AND code_pro='" & Me.dgCSBC.Rows(upd).Cells(1).Value & "' AND " _
                        & "bar_code='" & Me.dgCSBC.Rows(upd).Cells(2).Value & "'"
                    Mainfrm.lblMainStatus.Text = strSQL
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dim savec As Integer
                    savec = cmd.ExecuteNonQuery()
                    If savec = 1 Then
                        Mainfrm.lblMainStatus.Text = "บันทึกข้อมูลตรวจสอบสต็อกแล้ว "
                    Else
                        Mainfrm.lblMainStatus.Text = "ไม่สามารถบันทึกข้อมูลตรวจสอบสต็อกได้"
                    End If
                Next
                Application.DoEvents()
                strSQL = "UPDATE check_stock_bc_id SET total_pro_bc='" & Me.txtCSBCtotalPro.Text & "'," _
                       & "count_num='" & Me.txtCSBCcNumPro.Text & "',disappear='" & Me.txtCSBCfail.Text & "',over='" & Me.txtCSBCfull.Text & "'," _
                       & "datetime_last='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "' " _
                       & "WHERE csbc_id='" & Me.txtCSBCid.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dim savec1 As Integer
                savec1 = cmd.ExecuteNonQuery()
                If savec1 = 1 Then
                    Mainfrm.lblMainStatus.Text = "บันทึกข้อมูลยอดตรวจสอบสต็อกแล้ว "
                Else
                    Mainfrm.lblMainStatus.Text = "ไม่สามารถบันทึกข้อมูลยอดตรวจสอบสต็อกได้"
                End If
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
            Me.Cursor = Cursors.Default
        End If
    End Sub
    Private Sub CheckStoclBarcodeFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        Call ccs()
    End Sub
    Private Sub AutoNumberNo()
        Try
            Mainfrm.lblMainStatus.Text = "SELECT Max(id) as ID"
            strSQL = "SELECT Max(id) as ID FROM check_stock_bc_id"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                Me.txtCSBCid.Text = Now.ToString("yyMMddHHmm") & "00001"
            Else
                Dim newID As Integer = CInt(Dr.Item("ID"))
                newID += 1
                Me.txtCSBCid.Text = "CKBC" & Now.ToString("yyMMddHHmm") & newID.ToString("00000")
            End If
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "SELECT Max(id) as ID ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub BGWgetDatat_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BGWgetDatat.DoWork
        Mainfrm.lblMainStatus.Text = "รวบรวมข้อมูลบาร์โค๊ต "
        Me.dgCSBC.Rows.Clear()
        Try
            Me.Cursor = Cursors.WaitCursor
            strSQL = "SELECT code_pro,bar_code,name_pro,price_buy,count_num FROM product"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Dim cn0 As Integer = Dr.GetDecimal("count_num")
                Dim r As Integer
                With Me.dgCSBC
                    If cn0 > 0 Then
                        r = .Rows.Count
                        .Rows.Add()
                        .Rows(r).Cells(1).Value = Dr.GetString("code_pro")
                        .Rows(r).Cells(2).Value = Dr.GetString("bar_code")
                        .Rows(r).Cells(3).Value = Dr.GetString("name_pro")
                        .Rows(r).Cells(4).Value = Dr.GetString("price_buy")
                        .Rows(r).Cells(5).Value = Dr.GetDecimal("count_num")
                    End If
                End With
            End While
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try

        Me.Cursor = Cursors.WaitCursor
        Mainfrm.lblMainStatus.Text = "นับจำนวน SN "
        Try
            Me.Cursor = Cursors.WaitCursor
            For num As Integer = 0 To Me.dgCSBC.Rows.Count - 1
                strSQL = "SELECT COUNT(code_pro) AS cp FROM product_serial WHERE code_pro='" & Me.dgCSBC.Rows(num).Cells(1).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                Dim cu As Integer = Dr.Item("cp")
                Me.dgCSBC.Rows(num).Cells(5).Value = CInt(Me.dgCSBC.Rows(num).Cells(5).Value) - cu
            Next
            'Me.dgCSBC.Refresh()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Mainfrm.lblMainStatus.Text = "ลบข้อมูลที่หัก SN ออกแล้วเหลือ 0  "
        Try
            Me.Cursor = Cursors.WaitCursor
            'ลบบรรทัดที่เหลือ 0
            For iiii As Integer = Me.dgCSBC.Rows.Count - 1 To 0 Step -1
                If Me.dgCSBC.Rows(iiii).Cells(5).Value = 0 Then
                    Me.dgCSBC.Rows.Remove(Me.dgCSBC.Rows(iiii))
                End If
            Next iiii
            'Me.dgCSBC.Refresh()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Try
            For noo As Integer = 0 To Me.dgCSBC.Rows.Count - 1
                Me.dgCSBC.Rows(noo).Cells(0).Value = noo + 1
            Next
            'Me.dgCSBC.Refresh()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Me.Cursor = Cursors.Default
        Call sumTotalPro()
        Mainfrm.lblMainStatus.Text = "รวบรวมข้อมูลบาร์โค๊ตเสร็จ "
    End Sub
    Private Sub BGWgetDatat_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BGWgetDatat.RunWorkerCompleted
        Call saveCKBC()
    End Sub
    Private Sub getallPro()
        BGWgetDatat.RunWorkerAsync()
    End Sub

    Private Sub sumTotalPro()
        Dim SMTTP As Integer = 0
        Dim cNumP As Integer = 0
        Dim mNUm As Integer = 0
        Dim fail As Integer = 0
        For sunTTP As Integer = 0 To Me.dgCSBC.Rows.Count - 1
            SMTTP += Me.dgCSBC.Rows(sunTTP).Cells(5).Value
            cNumP += Me.dgCSBC.Rows(sunTTP).Cells(6).Value
            Me.dgCSBC.Rows(sunTTP).Cells(7).Value = CInt(Me.dgCSBC.Rows(sunTTP).Cells(6).Value) - CInt(Me.dgCSBC.Rows(sunTTP).Cells(5).Value)
            fail += CInt(Me.dgCSBC.Rows(sunTTP).Cells(5).Value) - CInt(Me.dgCSBC.Rows(sunTTP).Cells(6).Value)
        Next
        Me.txtCSBCtotalPro.Text = SMTTP.ToString
        Me.txtCSBCcNumPro.Text = cNumP.ToString
        If fail < 0 Then
            Me.txtCSBCfail.Text = 0
        Else
            Me.txtCSBCfail.Text = fail.ToString
        End If
        Dim ftext As Integer = cNumP - SMTTP
        If ftext < 0 Then
            Me.txtCSBCfull.Text = 0
        Else
            Me.txtCSBCfull.Text = ftext.ToString
        End If
        Try
            For noo As Integer = 0 To Me.dgCSBC.Rows.Count - 1
                Me.dgCSBC.Rows(noo).Cells(0).Value = noo + 1
            Next
            'Me.dgCSBC.Refresh()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Friend Sub StartDataCheckStockBC()
        Try
            'แจ้งเมื่อสินค้ามีจำนวนมาก
            Me.Cursor = Cursors.WaitCursor
            strSQL = "SELECT COUNT(code_pro) AS ccp FROM product"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Dim ncp As Decimal = Dr.GetDecimal("ccp")
            If ncp > 10000 Then
                Me.Cursor = Cursors.Default
                If MessageBox.Show("ข้อมูลสินค้ามี " & ncp & " รายการ อาจจะใช้เวลานาน ต้องการจะทำการเตรียมข้อมูลหรือไม่", "มีเวลาไหม", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    Call getallPro()
                Else
                    Exit Try
                End If
            Else
                Call getallPro()
                'Call saveCKBC()
            End If
            Me.Cursor = Cursors.Default
            Me.txtCSBCenterBC.Focus()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnCSBCsetStart_Click(sender As Object, e As EventArgs) Handles btnCSBCsetStart.Click
        If Me.dgCSBC.Rows.Count > 0 Then
            MsgBox("มีข้อมูลการเตรียมสต็อกอยู่ กรุณาเคลียร์ข้อมูลออกก่อน", MsgBoxStyle.Information, "มีข้อมูล")
        ElseIf Me.dgCSBC.Rows.Count = 0 Then
            Try
                strSQL = "SELECT csbc_id FROM check_stock_bc_id WHERE csbc_status='เตรียมสต็อกเสร็จสิ้น'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                If Dr.HasRows Then
                    Dim csbcid As String = Dr.GetString("csbc_id")
                    strSQL = "UPDATE check_stock_bc_id SET csbc_status='เคลียร์ข้อมูล' WHERE csbc_id='" & csbcid & "'"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dim sav As Integer
                    sav = cmd.ExecuteNonQuery
                    Call AutoNumberNo()
                    If sav = 1 Then
                        Mainfrm.lblMainStatus.Text = "อัพเดทข้อมูล เป็นเคลียร์ข้อมูล"
                    Else
                        Mainfrm.lblMainStatus.Text = "อัพเดทข้อมูล เป็นเคลียร์ข้อมูล ไม่สำเร็จ"
                    End If
                    If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "verified", Nothing) = "0" Then
                        Call StartDataCheckStockBC()
                    ElseIf My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "verified", Nothing) = "1" Then
                        MiniLoginSetDataCheckstockBCFrm.MdiParent = Mainfrm
                        MiniLoginSetDataCheckstockBCFrm.Show()
                    End If
                Else
                    If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "verified", Nothing) = "0" Then
                        Call StartDataCheckStockBC()
                    ElseIf My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "verified", Nothing) = "1" Then
                        MiniLoginSetDataCheckstockBCFrm.MdiParent = Mainfrm
                        MiniLoginSetDataCheckstockBCFrm.Show()
                    End If
                End If
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
        End If
    End Sub

    Private Sub saveCKBC()
        Try
            strSQL = "INSERT INTO check_stock_bc_id(csbc_id,total_pro_bc,count_num,disappear,over,csbc_status,datetime_save,datetime_last,employee)" _
            & "VALUES(@csbc_id,@total_pro_bc,@count_num,@disappear,@over,@csbc_status,@datetime_save,@datetime_last,@employee)"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Mainfrm.lblMainStatus.Text = strSQL
            With cmd
                .Parameters.Add(New MySqlParameter("@csbc_id", Me.txtCSBCid.Text))
                .Parameters.Add(New MySqlParameter("@total_pro_bc", Me.txtCSBCtotalPro.Text))
                .Parameters.Add(New MySqlParameter("@count_num", Me.txtCSBCcNumPro.Text))
                .Parameters.Add(New MySqlParameter("@disappear", Me.txtCSBCfail.Text))
                .Parameters.Add(New MySqlParameter("@over", Me.txtCSBCfull.Text))
                .Parameters.Add(New MySqlParameter("@csbc_status", "เตรียมสต็อกเสร็จสิ้น"))
                .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                .Parameters.Add(New MySqlParameter("@datetime_last", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "verified", Nothing) = "0" Then
                    .Parameters.Add(New MySqlParameter("@employee", LoginFrm.txtLoginUsername.Text))
                ElseIf My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "verified", Nothing) = "1" Then
                    .Parameters.Add(New MySqlParameter("@employee", MiniLoginSetDataCheckstockBCFrm.txtMLUusername.Text))
                End If
                Call open_connection()
                cmd.ExecuteNonQuery()
            End With
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try

        Try
            For cbc As Integer = 0 To Me.dgCSBC.Rows.Count - 1
                strSQL = "INSERT INTO check_stock_bc(csbc_id,code_pro,bar_code,name_pro,price_buy,count_num,count,datetime_save)" _
              & "VALUES(@csbc_id,@code_pro,@bar_code,@name_pro,@price_buy,@count_num,@count,@datetime_save)"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Mainfrm.lblMainStatus.Text = strSQL
                With cmd
                    .Parameters.Add(New MySqlParameter("@csbc_id", Me.txtCSBCid.Text))
                    .Parameters.Add(New MySqlParameter("@code_pro", Me.dgCSBC.Rows(cbc).Cells(1).Value))
                    .Parameters.Add(New MySqlParameter("@bar_code", Me.dgCSBC.Rows(cbc).Cells(2).Value))
                    .Parameters.Add(New MySqlParameter("@name_pro", Me.dgCSBC.Rows(cbc).Cells(3).Value))
                    .Parameters.Add(New MySqlParameter("@price_buy", Me.dgCSBC.Rows(cbc).Cells(4).Value))
                    .Parameters.Add(New MySqlParameter("@count_num", Me.dgCSBC.Rows(cbc).Cells(5).Value))
                    .Parameters.Add(New MySqlParameter("@count", Me.dgCSBC.Rows(cbc).Cells(6).Value))
                    .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                    .Parameters.Add(New MySqlParameter("@datetime_last", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End With
            Next
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub


    Private Sub txtCSBCenterBC_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCSBCenterBC.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.dgCSBC.Rows.Count = 0 Then
                MsgBox("กรุณาเตรียมข้อมูลก่อน", MsgBoxStyle.Information, "แจ้งเตือน")
            Else

                For bc As Integer = 0 To Me.dgCSBC.Rows.Count - 1
                    If Me.txtCSBCenterBC.Text = Me.dgCSBC.Rows(bc).Cells(2).Value Then
                        Me.dgCSBC.Rows(bc).Cells(6).Value = CDec(Me.dgCSBC.Rows(bc).Cells(6).Value) + 1
                        Me.txtCSBClastBC.Text = Me.dgCSBC.Rows(bc).Cells(3).Value
                        Call sumTotalPro()
                        Me.txtCSBCenterBC.Clear()
                        Me.txtCSBCenterBC.Focus()
                        Try
                            My.Computer.Audio.Play("./ok.wav", AudioPlayMode.Background)
                            Mainfrm.lblMainStatus.Text = "พบข้อมูล"
                        Catch ex As Exception
                        End Try
                        Exit Sub
                    End If
                Next
                Me.txtCSBCenterBC.Clear()
                Me.txtCSBCenterBC.Focus()
                Try
                    My.Computer.Audio.Play("./error.wav", AudioPlayMode.Background)
                    Mainfrm.lblMainStatus.Text = "ไม่พบข้อมูล"
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Friend Sub clearStock()
        Try
            strSQL = "UPDATE check_stock_bc_id SET total_pro_bc='" & Me.txtCSBCtotalPro.Text & "',count_num='" & Me.txtCSBCcNumPro.Text & "'," _
                & "disappear='" & Me.txtCSBCfail.Text & "',over='" & Me.txtCSBCfull.Text & "',csbc_status='เคลียร์ข้อมูล'," _
                & "datetime_last='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "'," _
                & "employee='" & MiniLoginClearCheckstockBCFrm.txtMLUusername.Text & "'" _
                & " WHERE csbc_id='" & Me.txtCSBCid.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Mainfrm.lblMainStatus.Text = strSQL
            Call open_connection()
            cmd.ExecuteNonQuery()
            'ลบข้อมูลเช็คสต็อกทั้งหมด
            strSQL = "TRUNCATE check_stock_bc"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            Me.dgCSBC.Rows.Clear()
            Call sumTotalPro()
            Call AutoNumberNo()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub btnClearStock_Click(sender As Object, e As EventArgs) Handles btnClearStock.Click
        If Me.dgCSBC.Rows.Count = 0 Then
            MsgBox("ไม่มีข้อมูลการเตรียมตรวจสอบสต็อก", MsgBoxStyle.Exclamation, "ไม่มีข้อมูล")
        Else
            MiniLoginClearCheckstockBCFrm.MdiParent = Mainfrm
            MiniLoginClearCheckstockBCFrm.Show()
        End If
    End Sub
    Friend scc As Integer
    Private Sub ContextMenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ContextMenuStrip1.ItemClicked
        Select Case e.ClickedItem.ToString
            Case "เพิ่มจำนวนสินค้าที่นับได้"
                scc = 100
                CheckStoclBarcodeEnterFrm.MdiParent = Mainfrm
                CheckStoclBarcodeEnterFrm.Show()
            Case "ลบจำนวนสินค้าที่นับได้"
                scc = 200
                CheckStoclBarcodeEnterFrm.MdiParent = Mainfrm
                CheckStoclBarcodeEnterFrm.Show()
            Case "ลบแถว"
                Call delrow()
        End Select
    End Sub

    Private Sub delrow()
        If MessageBox.Show("คุณแน่ใจว่าจะลบข้อมูลนี้", "ลบข้อมูล", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Try
                strSQL = "DELETE FROM check_stock_bc WHERE csbc_id='" & Me.txtCSBCid.Text & "' AND code_pro='" & Me.dgCSBC.CurrentRow.Cells(1).Value & "'" _
                    & "AND bar_code='" & Me.dgCSBC.CurrentRow.Cells(2).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dim con As Integer
                con = cmd.ExecuteNonQuery()
                If con = 1 Then
                    Mainfrm.lblMainStatus.Text = "ลบข้อมูลแล้ว"
                End If
                Dim a As Integer = Me.dgCSBC.SelectedRows.Count - 1
                Me.dgCSBC.Rows.Remove(Me.dgCSBC.SelectedRows(a))
                Call sumTotalPro()
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
        Else
            Mainfrm.lblMainStatus.Text = "ยกเลิกการลบ"
            Exit Sub
        End If

    End Sub

    Private Sub dgCSBC_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgCSBC.CellMouseClick
        If Me.dgCSBC.Rows.Count = 0 Then
        Else
            If e.Button = MouseButtons.Right Then
                Me.dgCSBC.Rows(e.RowIndex).Selected = True
                Me.dgCSBC.CurrentCell = Me.dgCSBC.Rows(e.RowIndex).Cells(0)
                Me.ContextMenuStrip1.Show(dgCSBC, e.Location)
                Me.ContextMenuStrip1.Show(Cursor.Position)
            End If
        End If
    End Sub

    Private Sub dgCSBC_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgCSBC.CellValueChanged
        Call sumTotalPro()
    End Sub

    Private Sub pbPrint_Click(sender As Object, e As EventArgs) Handles pbPrint.Click
        If Me.dgCSBC.Rows.Count = 0 Then
            MsgBox("ไม่มีข้อมูลที่จะพิมพ์", MsgBoxStyle.Exclamation, "No Data")
        Else
            Me.Cursor = Cursors.WaitCursor
            Mainfrm.lblMainStatus.Text = "ล้างข้อมูลรายงานเก่า"
            Try
                strSQLite = "DELETE FROM check_stock_bc"
                Mainfrm.lblMainStatus.Text = strSQLite
                cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                Call open_connectionSQLite()
                cmdSQLite.ExecuteNonQuery()
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
            Mainfrm.lblMainStatus.Text = "สร้างข้อมูลรายงาน"
            Me.Cursor = Cursors.WaitCursor
            For r As Integer = 0 To Me.dgCSBC.Rows.Count - 1
                Try
                    strSQLite = "INSERT INTO check_stock_bc(`no`,code_pro,bar_code,name_pro,price_buy,count_num,count,over)" _
                     & "VALUES(@no,@code_pro,@bar_code,@name_pro,@price_buy,@count_num,@count,@over)"
                    Mainfrm.lblMainStatus.Text = strSQLite
                    cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                    cmdSQLite.Parameters.AddWithValue("@no", Me.dgCSBC.Rows(r).Cells(0).Value)
                    cmdSQLite.Parameters.AddWithValue("@code_pro", Me.dgCSBC.Rows(r).Cells(1).Value)
                    cmdSQLite.Parameters.AddWithValue("@bar_code", Me.dgCSBC.Rows(r).Cells(2).Value)
                    cmdSQLite.Parameters.AddWithValue("@name_pro", Me.dgCSBC.Rows(r).Cells(3).Value)
                    cmdSQLite.Parameters.AddWithValue("@price_buy", Me.dgCSBC.Rows(r).Cells(4).Value)
                    cmdSQLite.Parameters.AddWithValue("@count_num", Me.dgCSBC.Rows(r).Cells(5).Value)
                    cmdSQLite.Parameters.AddWithValue("@count", Me.dgCSBC.Rows(r).Cells(6).Value)
                    cmdSQLite.Parameters.AddWithValue("@over", Me.dgCSBC.Rows(r).Cells(7).Value)
                    Call open_connectionSQLite()
                    cmdSQLite.ExecuteNonQuery()
                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                End Try
            Next
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = "โหลดหน้าพิมพ์รายงาน"
            CheckStockBCReportPrintFrm.Show()
        End If
    End Sub
End Class