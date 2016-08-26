Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class CustomerFrm
    'เสร็จ v2  2014/12/21
    'ปรับปรุงล่าสุด 2015/10/06
    Private Sub startfrm()
        Call ClearTextBoxes(Me)
        Call disableTextBoxes(Me)
        Me.btnCustomerEdit.Enabled = False
        Me.btnCustomerDel.Enabled = False
        Me.btnCustomerSave.Enabled = True
        Me.txtCustomerSearch.Enabled = True
        Me.txtCustomerTAX.Text = "000000000000"
        Me.txtCustomerSection.Text = "-"
        Me.txtCustomerZipcode.Text = ""
        Me.txtCustomerNote.Text = "-"
        Me.btnCustomerSave.Text = "&สร้างข้อมูลลูกค้าใหม่"
        Me.dgCustomerSearch.Enabled = True
        Me.btnCustomerEdit.Text = "&แก้ไข"
        Me.txtCustomerID.BackColor = SystemColors.Window
        Me.txtCustomerName.BackColor = SystemColors.Window
        Me.txtCustomerAddress.BackColor = SystemColors.Window
        Me.txtCustomerZipcode.BackColor = SystemColors.Window
        Me.txtCustomerTel.BackColor = SystemColors.Window
        Me.txtCustomerNote.BackColor = SystemColors.Window
        Me.cbbCustomerPrice_level.Enabled = False
        Me.cbbCustomerCadit.Enabled = False
        Call AutoNumberNo()
    End Sub
   
    Private Sub AutoNumberNo()
        Try
            dt = New DataTable
            strSQL = "SELECT ver_cusid FROM ver_detail"
            Mainfrm.lblMainStatus.Text = strSQL
            dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
            Call open_connection()
            dtAdapter.Fill(dt)
            Dim nameID As String = dt.Rows(0).Item("ver_cusid")

            strSQL = "SELECT Max(ID) AS cidd FROM customer_id"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                Me.txtCustomerID.Text = Now.ToString("yyMMdd") & "00001"
            ElseIf Dr.HasRows Then
                Dim newID As Decimal = Dr.GetDecimal("cidd")
                newID += 1
                Me.txtCustomerID.Text = nameID & Now.ToString("yyMMdd") & newID.ToString("00000")
            End If
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Dim cSelect As Integer
    Private Sub GetAllData()
        Try
            Me.dgCustomerSearch.Rows.Clear()
            If cSelect = 2 Then
                strSQL = "SELECT customer_id,customer_tax,customer_section,customer_name," _
                               & "customer_address,customer_zipcode,customer_tel,customer_note,price_level,maturity,date_edit FROM customer" _
                               & " WHERE customer_tax LIKE'%" & Me.txtCustomerSearch.Text & "%'" _
                               & " OR customer_section LIKE'%" & Me.txtCustomerSearch.Text & "%'" _
                               & " OR customer_name LIKE'%" & Me.txtCustomerSearch.Text & "%'" _
                               & " OR customer_address LIKE'%" & Me.txtCustomerSearch.Text & "%'" _
                               & " OR customer_tel LIKE'%" & Me.txtCustomerSearch.Text & "%'"
            Else
                strSQL = "SELECT customer_id,customer_tax,customer_section,customer_name," _
                                & "customer_address,customer_zipcode,customer_tel,customer_note,price_level,maturity,date_edit FROM customer"
            End If
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            While Dr.Read()
                With Me.dgCustomerSearch
                    Dim r As Integer = .Rows.Count
                    .Rows.Add()
                    .Rows(r).Cells(1).Value = Dr.GetString("customer_id")
                    .Rows(r).Cells(2).Value = Dr.GetString("customer_name")
                    .Rows(r).Cells(3).Value = Dr.GetString("customer_tax")
                    .Rows(r).Cells(4).Value = Dr.GetString("customer_section")
                    .Rows(r).Cells(5).Value = Dr.GetString("customer_address")
                    .Rows(r).Cells(6).Value = Dr.GetString("customer_zipcode")
                    .Rows(r).Cells(7).Value = Dr.GetString("customer_tel")
                    Dim num As String = Dr.GetString("price_level")
                    If num = "1" Then
                        .Rows(r).Cells(8).Value = "ราคาปกติ"
                    ElseIf num = "2" Then
                        .Rows(r).Cells(8).Value = "ราคาขายส่ง"
                    ElseIf num = "3" Then
                        .Rows(r).Cells(8).Value = "ราคาช่าง"
                    ElseIf num = "4" Then
                        .Rows(r).Cells(8).Value = "ราคาลูกค้าประจำ"
                    ElseIf num = "5" Then
                        .Rows(r).Cells(8).Value = "ราคาสมาชิก"
                    ElseIf num = "-" Then
                        .Rows(r).Cells(8).Value = "ราคาปกติ"
                    End If
                    Dim MT As String = Dr.GetString("maturity")
                    If MT = "5" Then
                        .Rows(r).Cells(9).Value = "5 วัน"
                    ElseIf MT = "15" Then
                        .Rows(r).Cells(9).Value = "15 วัน"
                    ElseIf MT = "30" Then
                        .Rows(r).Cells(9).Value = "1 เดือน"
                    ElseIf MT = "60" Then
                        .Rows(r).Cells(9).Value = "2 เดือน"
                    ElseIf MT = "90" Then
                        .Rows(r).Cells(9).Value = "3 เดือน"
                    ElseIf MT = "120" Then
                        .Rows(r).Cells(9).Value = "4 เดือน"
                    ElseIf MT = "150" Then
                        .Rows(r).Cells(9).Value = "5 เดือน"
                    ElseIf MT = "180" Then
                        .Rows(r).Cells(9).Value = "6 เดือน"
                    ElseIf MT = "210" Then
                        .Rows(r).Cells(9).Value = "7 เดือน"
                    ElseIf MT = "240" Then
                        .Rows(r).Cells(9).Value = "8 เดือน"
                    ElseIf MT = "270" Then
                        .Rows(r).Cells(9).Value = "9 เดือน"
                    ElseIf MT = "300" Then
                        .Rows(r).Cells(9).Value = "10 เดือน"
                    ElseIf MT = "330" Then
                        .Rows(r).Cells(9).Value = "11 เดือน"
                    ElseIf MT = "360" Then
                        .Rows(r).Cells(9).Value = "1 ปี"
                    ElseIf MT = "720" Then
                        .Rows(r).Cells(9).Value = "2 ปี"
                    ElseIf MT = "1080" Then
                        .Rows(r).Cells(9).Value = "3 ปี"
                    ElseIf MT = "-" Or MT = "" Then
                        .Rows(r).Cells(9).Value = "15 วัน"
                    End If
                    .Rows(r).Cells(10).Value = Dr.GetString("customer_note")
                    .Rows(r).Cells(11).Value = Dr.GetString("date_edit")
                End With
            End While
        Catch ex As Exception

        End Try
        For x As Integer = 0 To Me.dgCustomerSearch.Rows.Count - 1
            Me.dgCustomerSearch.Rows(x).Cells(0).Value = x + 1
            Try
                strSQL = "SELECT datetime_save FROM customer_id WHERE customer_id='" & Me.dgCustomerSearch.Rows(x).Cells(1).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                Me.dgCustomerSearch.Rows(x).Cells(12).Value = Dr.GetString("datetime_save")
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
        Next
    End Sub
    Private Sub DeleteData()
        If Me.txtCustomerID.Text = "0" Then
            Mainfrm.lblMainStatus.Text = "ไม่สามารถลบได้"
            MsgBox("ค่าปริยาย ไม่สามารถลบได้", MsgBoxStyle.Exclamation, "ลบข้อมูลไม่ได้")
        Else
            Dim Ans As String
            Ans = MsgBox("คุณแน่ใจว่าจะลบข้อมูลนี้", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
            If Ans = System.Windows.Forms.DialogResult.No Then
                MsgBox("การลบข้อมูลถูกยกเลิก", MsgBoxStyle.Information, "ยืนยัน")
            Else
                Mainfrm.lblMainStatus.Text = "DELETE FROM customer "
                strSQL = "DELETE FROM customer WHERE customer_id='" & Me.txtCustomerID.Text & "';"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                MsgBox("ลบข้อมูลที่คุณเลือกแล้ว", MsgBoxStyle.Information, "ยืนยัน")
                Call GetAllData()
                Call startfrm()
            End If
        End If
    End Sub

    Private Sub btnCustomerCancel_Click(sender As Object, e As EventArgs) Handles btnCustomerCancel.Click
        Call startfrm()
    End Sub
    Private Sub btnCustomerSave_Click(sender As Object, e As EventArgs) Handles btnCustomerSave.Click
        If Me.btnCustomerSave.Text = "&สร้างข้อมูลลูกค้าใหม่" Then
            Me.btnCustomerSave.Text = "&บันทึกข้อมูลลูกค้าใหม่"
            Me.btnCustomerDel.Enabled = False
            Me.btnCustomerEdit.Enabled = False
            Call enableTextBoxes(Me)
            Me.txtCustomerAddress.Enabled = True
            Me.txtCustomerID.Enabled = False
            Me.dgCustomerSearch.Enabled = False
            Me.cbbCustomerPrice_level.Enabled = True
            Me.cbbCustomerCadit.Enabled = True
            Exit Sub
        ElseIf Me.btnCustomerSave.Text = "&บันทึกข้อมูลลูกค้าใหม่" Then
            If Me.txtCustomerID.Text = "" Then
                MsgBox("กรุณาใส่ ID ลูกค้า หรือใส่เครื่องหมายสร้างรหัสอัตโนมัติ", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
                Me.txtCustomerID.Focus()
                Me.txtCustomerID.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtCustomerName.Text = "" Then
                MsgBox("กรุณาใส่ชื่อลูกค้า", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
                Me.txtCustomerName.Focus()
                Me.txtCustomerName.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtCustomerAddress.Text = "" Then
                MsgBox("กรุณาใส่ที่อยู่ ถ้าไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
                Me.txtCustomerAddress.Focus()
                Me.txtCustomerAddress.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtCustomerZipcode.Text = "" Then
                MsgBox("กรุณาใส่รหัสไปรษณีย์ ถ้าไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
                Me.txtCustomerZipcode.Focus()
                Me.txtCustomerZipcode.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtCustomerTel.Text = "" Then
                MsgBox("กรุณาใส่เบอร์โทร ถ้าไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
                Me.txtCustomerTel.Focus()
                Me.txtCustomerTel.BackColor = Color.Salmon
                Exit Sub
            End If

            If Me.txtCustomerNote.Text = "" Then
                MsgBox("กรุณาหมายเหตุ ถ้าไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
                Me.txtCustomerNote.Focus()
                Me.txtCustomerNote.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.cbbCustomerPrice_level.Text = "" Then
                Me.cbbCustomerPrice_level.Text = "ราคาปกติ"
            End If
            If Me.cbbCustomerCadit.Text = "" Then
                Me.cbbCustomerCadit.Text = "1 เดือน"
            End If

            Try
            'ตรวจชื่อซ้ำ
                Dim intNumRows As Integer
                strSQL = "SELECT customer_id FROM customer WHERE customer_id='" & Me.txtCustomerID.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                intNumRows = cmd.ExecuteScalar()
                If intNumRows > 0 Then
                    MsgBox("รหัสสมาชิกซ้ำ กรุณาตรวจสอบ", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                    Me.txtCustomerID.Focus()
                    Me.txtCustomerID.BackColor = Color.Salmon
                    Exit Sub
                End If
                Dim datname As String
                strSQL = "SELECT customer_id,customer_name FROM customer WHERE customer_name='" & Me.txtCustomerName.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                datname = Dr.Item("customer_id")
                If Dr.HasRows Then
                    Mainfrm.lblMainStatus.Text = "พบชื่อลูกค้าซ้ำในฐานข้อมูล"
                    MsgBox("พบชื่อนี้ตรงกับรหัสลูกค้า " & datname & " ชื่อซ้ำ กรุณาตรวจสอบ", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                    Me.txtCustomerName.Focus()
                    Me.txtCustomerName.BackColor = Color.Salmon
                    Exit Sub
                End If
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ไม่พบข้อมูลซ้ำ " & ex.Message
            End Try

            Try
                Dim iddu As String
                strSQL = "SELECT customer_name,customer_id FROM customer WHERE customer_tel='" & Me.txtCustomerTel.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                iddu = Dr.Item("customer_id")

                If Dr.HasRows Then
                    If iddu = Me.txtCustomerID.Text Or Me.txtCustomerTel.Text = "-" Then
                        Exit Try
                    Else
                        MsgBox("พบเบอร์โทรศัพท์นี้ตรงกับรหัสลูกค้า " & iddu & " เบอร์โทรศัพท์ซ้ำ กรุณาตรวจสอบ", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                        Me.txtCustomerTel.Focus()
                        Me.txtCustomerTel.BackColor = Color.Salmon
                        Exit Sub
                    End If
                End If
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try


            Dim Ans As String
            Ans = MsgBox("คุณแน่ใจว่าจะเพิ่มข้อมูลนี้", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
            If Ans = System.Windows.Forms.DialogResult.No Then
                MsgBox("การเพิ่มข้อมูลถูกยกเลิก", MsgBoxStyle.Information, "ยืนยัน")
                Call startfrm()
                Exit Sub
            Else
                Try
                    strSQL = "INSERT INTO customer(customer_id, customer_name, customer_address, customer_zipcode, " & _
                        "customer_tel, customer_note, customer_tax, customer_section, price_level, maturity, date_edit)" _
                        & "VALUES(@i, @n, @a, @z, @t, @note, @tax, @sec, @pl, @mat, @ds)"
                    Mainfrm.lblMainStatus.Text = strSQL
                    Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                        cmd.Parameters.AddWithValue("@i", Me.txtCustomerID.Text)
                        cmd.Parameters.AddWithValue("@n", Me.txtCustomerName.Text)
                        cmd.Parameters.AddWithValue("@a", Me.txtCustomerAddress.Text)
                        cmd.Parameters.AddWithValue("@z", Me.txtCustomerZipcode.Text)
                        cmd.Parameters.AddWithValue("@t", Me.txtCustomerTel.Text)
                        cmd.Parameters.AddWithValue("@note", Me.txtCustomerNote.Text)
                        cmd.Parameters.AddWithValue("@tax", Me.txtCustomerTAX.Text)
                        cmd.Parameters.AddWithValue("@sec", Me.txtCustomerSection.Text)
                        Call selectPrice_level()
                        cmd.Parameters.AddWithValue("@pl", num_level)
                        Call Todate()
                        cmd.Parameters.AddWithValue("@mat", Maturity)
                        cmd.Parameters.AddWithValue("@ds", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")))
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    End Using
                    strSQL = "INSERT INTO customer_id(customer_id,datetime_save)VALUES(@customer_id,@datetime_save)"
                    Mainfrm.lblMainStatus.Text = strSQL
                    Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                        cmd.Parameters.AddWithValue("@customer_id", Me.txtCustomerID.Text)
                        cmd.Parameters.AddWithValue("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")))
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    End Using
                    MsgBox("บันทึกข้อมูลแล้ว", MsgBoxStyle.Information, "บันทึกข้อมูล")
                Catch ex As Exception
                    Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                End Try
            End If
            Me.btnCustomerSave.Text = "&สร้างข้อมูลลูกค้าใหม่"
        End If
        Call ClearTextBoxes(Me)
        Me.dgCustomerSearch.ClearSelection()
        Call startfrm()
    End Sub
 
    Private Sub txtCustomerSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCustomerSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            cSelect = 2
            Call GetAllData()
            Me.txtCustomerSearch.Clear()
            Me.txtCustomerSearch.Focus()
        End If
    End Sub
    Private Sub btnCustomerGetall_Click(sender As Object, e As EventArgs) Handles btnCustomerGetall.Click
        Call GetAllData()
    End Sub

    Private Sub dgCustomerSearch_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgCustomerSearch.MouseDoubleClick
        If Me.dgCustomerSearch.Rows.Count = 0 Then
        Else
            Me.txtCustomerID.Text = Me.dgCustomerSearch.SelectedCells(1).Value
            Me.txtCustomerName.Text = Me.dgCustomerSearch.SelectedCells(2).Value
            Me.txtCustomerTAX.Text = Me.dgCustomerSearch.SelectedCells(3).Value
            Me.txtCustomerSection.Text = Me.dgCustomerSearch.SelectedCells(4).Value
            Me.txtCustomerAddress.Text = Me.dgCustomerSearch.SelectedCells(5).Value
            Me.txtCustomerZipcode.Text = Me.dgCustomerSearch.SelectedCells(6).Value
            Me.txtCustomerTel.Text = Me.dgCustomerSearch.SelectedCells(7).Value
            Me.cbbCustomerPrice_level.Text = Me.dgCustomerSearch.SelectedCells(8).Value
            Me.cbbCustomerCadit.Text = Me.dgCustomerSearch.SelectedCells(9).Value
            Me.txtCustomerNote.Text = Me.dgCustomerSearch.SelectedCells(10).Value
            Me.btnCustomerEdit.Enabled = True
            Me.btnCustomerDel.Enabled = True
            Me.btnCustomerSave.Enabled = False
        End If
       
    End Sub
   
    Private Sub btnCustomerEdit_Click(sender As Object, e As EventArgs) Handles btnCustomerEdit.Click
        If Me.txtCustomerID.Text = "0" Then
            MsgBox("ลูกค้าเงินสดไม่สามารถแก้ไขได้", MsgBoxStyle.Exclamation, "แก้ไม่ได้")
        Else
            Call enableTextBoxes(Me)
            Me.txtCustomerID.Enabled = False
            If Me.btnCustomerEdit.Text = "&แก้ไข" Then
                Me.btnCustomerEdit.Text = "&บันทึก"
                Call enableTextBoxes(Me)
                Me.txtCustomerID.Enabled = False
                Me.btnCustomerDel.Enabled = False
                Me.dgCustomerSearch.Enabled = False
                Me.cbbCustomerPrice_level.Enabled = True
                Me.cbbCustomerCadit.Enabled = True
                Exit Sub
            ElseIf Me.btnCustomerEdit.Text = "&บันทึก" Then
                If Me.txtCustomerID.Text = "" Then
                    MsgBox("กรุณาใส่ ID ลูกค้า หรือใส่เครื่องหมายสร้างรหัสอัตโนมัติ", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
                    txtCustomerID.Focus()
                    txtCustomerID.BackColor = Color.Salmon
                    Exit Sub
                End If
                If Me.txtCustomerName.Text = "" Then
                    MsgBox("กรุณาใส่ชื่อลูกค้า", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
                    txtCustomerName.Focus()
                    txtCustomerName.BackColor = Color.Salmon
                    Exit Sub
                End If
                If Me.txtCustomerAddress.Text = "" Then
                    MsgBox("กรุณาใส่ที่อยู่ ถ้าไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
                    txtCustomerAddress.Focus()
                    txtCustomerAddress.BackColor = Color.Salmon
                    Exit Sub
                End If
                If Me.txtCustomerZipcode.Text = "" Then
                    MsgBox("กรุณาใส่รหัสไปรษณีย์ ถ้าไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
                    txtCustomerZipcode.Focus()
                    txtCustomerZipcode.BackColor = Color.Salmon
                    Exit Sub
                End If
                If Me.txtCustomerTel.Text = "" Then
                    MsgBox("กรุณาใส่เบอร์โทร ถ้าไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
                    txtCustomerTel.Focus()
                    txtCustomerTel.BackColor = Color.Salmon
                    Exit Sub
                End If
                If Me.txtCustomerNote.Text = "" Then
                    MsgBox("กรุณาหมายเหตุ ถ้าไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
                    txtCustomerNote.Focus()
                    txtCustomerNote.BackColor = Color.Salmon
                    Exit Sub
                End If
                If Me.cbbCustomerPrice_level.Text = "" Then
                    Me.cbbCustomerPrice_level.Text = "ราคาปกติ"
                End If
                If Me.cbbCustomerCadit.Text = "" Then
                    Me.cbbCustomerCadit.Text = "1 เดือน"
                End If
                Try
                    Dim iddu As String
                    strSQL = "SELECT customer_name,customer_id FROM customer WHERE customer_name='" & Me.txtCustomerName.Text & "'"
                    Mainfrm.lblMainStatus.Text = strSQL
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader()
                    Dr.Read()
                    iddu = Dr.Item("customer_id")

                    If Dr.HasRows Then
                        If iddu = Me.txtCustomerID.Text Then
                            Exit Try
                        Else
                            MsgBox("พบรายชื่อนี้ในฐานข้อมูลซึ่งตรงกับรหัสลูกค้า " & iddu & " ชื่อซ้ำ กรุณาตรวจสอบ", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                            txtCustomerName.Focus()
                            txtCustomerName.BackColor = Color.Salmon
                            Exit Sub
                        End If
                    End If
                Catch ex As Exception
                    Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                End Try

                Try
                    Dim iddu As String
                    strSQL = "SELECT customer_name,customer_id FROM customer WHERE customer_tel='" & Me.txtCustomerTel.Text & "'"
                    Mainfrm.lblMainStatus.Text = strSQL
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader()
                    Dr.Read()
                    iddu = Dr.Item("customer_id")

                    If Dr.HasRows Then
                        If iddu = Me.txtCustomerID.Text Or Me.txtCustomerTel.Text = "-" Then
                            Exit Try
                        Else
                            MsgBox("พบเบอร์โทรศัพท์นี้ตรงกับรหัสลูกค้า " & iddu & " เบอร์โทรศัพท์ซ้ำ กรุณาตรวจสอบ", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                            Me.txtCustomerTel.Focus()
                            Me.txtCustomerTel.BackColor = Color.Salmon
                            Exit Sub
                        End If
                    End If
                Catch ex As Exception
                    Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                End Try

                Dim UpDateAns As String
                UpDateAns = MsgBox("คุณแน่ใจว่าจะแก้ไขข้อมูลนี้", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
                If UpDateAns = System.Windows.Forms.DialogResult.No Then
                    MsgBox("การแก้ไขข้อมูลถูกยกเลิก.", MsgBoxStyle.Information, "ยกเลิกการแก้ไข")
                Else
                    Try
                        ' update customer
                        Call selectPrice_level()
                        Call Todate()
                        strSQL = "UPDATE customer SET customer_id='" & Me.txtCustomerID.Text & "'," _
                            & "customer_tax='" & Me.txtCustomerTAX.Text & "'," _
                            & "customer_section='" & Me.txtCustomerSection.Text & "'," _
                            & "customer_name='" & Me.txtCustomerName.Text & "'," _
                            & "customer_address='" & Me.txtCustomerAddress.Text & "'," _
                            & "customer_zipcode='" & Me.txtCustomerZipcode.Text & "'," _
                            & "customer_tel='" & Me.txtCustomerTel.Text & "'," _
                            & "customer_note='" & Me.txtCustomerNote.Text & "'," _
                            & "price_level='" & num_level.ToString & "'," _
                            & "maturity='" & Maturity.ToString & "'," _
                            & "date_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "'" _
                            & " WHERE customer_id='" & Me.txtCustomerID.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try
                    Try
                        ' update cash_pledge_sale
                        strSQL = "UPDATE cash_pledge_sale SET customer_name='" & Me.txtCustomerName.Text & "' WHERE customer_id='" & Me.txtCustomerID.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try
                    Try
                        ' update cash_sale
                        strSQL = "UPDATE cash_sale SET customer_name='" & Me.txtCustomerName.Text & "' WHERE customer_id='" & Me.txtCustomerID.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try
                    Try
                        ' update cash_sale_barcode
                        strSQL = "UPDATE cash_sale_barcode SET customer_name='" & Me.txtCustomerName.Text & "',customer_tel='" & Me.txtCustomerTel.Text & "' WHERE customer_id='" & Me.txtCustomerID.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try
                    Try
                        ' update cash_sale_serial
                        strSQL = "UPDATE cash_sale_serial SET customer_name='" & Me.txtCustomerName.Text & "' WHERE customer_id='" & Me.txtCustomerID.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try
                    Try
                        ' update comfix
                        strSQL = "UPDATE comfix SET customer_name='" & Me.txtCustomerName.Text & "' WHERE customer_id='" & Me.txtCustomerID.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try
                    Try
                        ' update pledge_sale
                        strSQL = "UPDATE pledge_sale SET customer_name='" & Me.txtCustomerName.Text & "' WHERE customer_id='" & Me.txtCustomerID.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try
                    Try
                        ' update returnproduct
                        strSQL = "UPDATE returnproduct SET customer_name='" & Me.txtCustomerName.Text & "' WHERE customer_id='" & Me.txtCustomerID.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try
                    Try
                        ' update returnproduct_serial
                        strSQL = "UPDATE returnproduct_serial SET customer_name='" & Me.txtCustomerName.Text & "' WHERE customer_id='" & Me.txtCustomerID.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try
                    Try
                        ' update sale
                        strSQL = "UPDATE sale SET customer_name='" & Me.txtCustomerName.Text & "' WHERE customer_id='" & Me.txtCustomerID.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try
                    Try
                        ' update sale_barcode
                        strSQL = "UPDATE sale_barcode SET customer_name='" & Me.txtCustomerName.Text & "',customer_tel='" & Me.txtCustomerTel.Text & "' WHERE customer_id='" & Me.txtCustomerID.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try
                    Try
                        ' update sale_id
                        strSQL = "UPDATE sale_id SET customer_name='" & Me.txtCustomerName.Text & "' WHERE customer_id='" & Me.txtCustomerID.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try
                    Try
                        ' update sale_serial
                        strSQL = "UPDATE sale_serial SET customer_name='" & Me.txtCustomerName.Text & "' WHERE customer_id='" & Me.txtCustomerID.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try
                    Try
                        ' update taxinvoice
                        strSQL = "UPDATE taxinvoice SET customer_name='" & Me.txtCustomerName.Text & "',customer_address='" & Me.txtCustomerAddress.Text & "',customer_tel='" & Me.txtCustomerTel.Text & "' WHERE customer_id='" & Me.txtCustomerID.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try
                    MsgBox("แก้ไขข้อมูลเรียบร้อยแล้ว.", MsgBoxStyle.Information, "ยืนยัน")
                    Me.btnCustomerEdit.Text = "&แก้ไข"
                    Me.dgCustomerSearch.ClearSelection()
                
                End If
                'clear all textbox
                Call ClearTextBoxes(Me)
            End If
            Call GetAllData()
            Call startfrm()
        End If
    End Sub

    Private Sub btnCustomerDel_Click(sender As Object, e As EventArgs) Handles btnCustomerDel.Click
        Call DeleteData()
    End Sub

    Private Sub btnCustomerSearch_Click(sender As Object, e As EventArgs) Handles btnCustomerSearch.Click
        cSelect = 2
        Call GetAllData()
        Me.txtCustomerSearch.Clear()
        Me.txtCustomerSearch.Focus()
    End Sub

    Private Sub txtCustomerTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCustomerTel.KeyPress
       
    End Sub

    Private Sub txtCustomerTel_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerTel.TextChanged
        Dim countCharacter As Integer = Me.txtCustomerTel.TextLength
            Me.lblCusCountNum.Text = "มี " & countCharacter & " ตัว"
    End Sub

    Private Sub cbbCustomerPrice_level_Click(sender As Object, e As EventArgs) Handles cbbCustomerPrice_level.Click
        Me.cbbCustomerPrice_level.Items.Clear()
        Me.cbbCustomerPrice_level.Items.Add("ราคาปกติ")
        Me.cbbCustomerPrice_level.Items.Add("ราคาขายส่ง")
        Me.cbbCustomerPrice_level.Items.Add("ราคาช่าง")
        Me.cbbCustomerPrice_level.Items.Add("ราคาลูกค้าประจำ")
        Me.cbbCustomerPrice_level.Items.Add("ราคาสมาชิก")
    End Sub
    Dim num_level As String
    Private Sub selectPrice_level()
        If Me.cbbCustomerPrice_level.Text = "ราคาปกติ" Then
            num_level = "1"
        ElseIf Me.cbbCustomerPrice_level.Text = "ราคาขายส่ง" Then
            num_level = "2"
        ElseIf Me.cbbCustomerPrice_level.Text = "ราคาช่าง" Then
            num_level = "3"
        ElseIf Me.cbbCustomerPrice_level.Text = "ราคาลูกค้าประจำ" Then
            num_level = "4"
        ElseIf Me.cbbCustomerPrice_level.Text = "ราคาสมาชิก" Then
            num_level = "5"
        ElseIf Me.cbbCustomerPrice_level.Text = "" Then
            num_level = "1"
        End If
    End Sub
    Private Sub cbbCustomerCadit_Click(sender As Object, e As EventArgs) Handles cbbCustomerCadit.Click
        Me.cbbCustomerCadit.Items.Clear()
        Me.cbbCustomerCadit.Items.Add("5 วัน")
        Me.cbbCustomerCadit.Items.Add("15 วัน")
        Me.cbbCustomerCadit.Items.Add("1 เดือน")
        Me.cbbCustomerCadit.Items.Add("2 เดือน")
        Me.cbbCustomerCadit.Items.Add("3 เดือน")
        Me.cbbCustomerCadit.Items.Add("4 เดือน")
        Me.cbbCustomerCadit.Items.Add("5 เดือน")
        Me.cbbCustomerCadit.Items.Add("6 เดือน")
        Me.cbbCustomerCadit.Items.Add("7 เดือน")
        Me.cbbCustomerCadit.Items.Add("8 เดือน")
        Me.cbbCustomerCadit.Items.Add("9 เดือน")
        Me.cbbCustomerCadit.Items.Add("10 เดือน")
        Me.cbbCustomerCadit.Items.Add("11 เดือน")
        Me.cbbCustomerCadit.Items.Add("1 ปี")
        Me.cbbCustomerCadit.Items.Add("2 ปี")
        Me.cbbCustomerCadit.Items.Add("3 ปี")
    End Sub
    Dim Maturity As Integer

    Private Sub Todate()
        If Me.cbbCustomerCadit.Text = "5 วัน" Then
            Maturity = 5
        ElseIf Me.cbbCustomerCadit.Text = "15 วัน" Then
            Maturity = 15
        ElseIf Me.cbbCustomerCadit.Text = "1 เดือน" Then
            Maturity = 30
        ElseIf Me.cbbCustomerCadit.Text = "2 เดือน" Then
            Maturity = 60
        ElseIf Me.cbbCustomerCadit.Text = "3 เดือน" Then
            Maturity = 90
        ElseIf Me.cbbCustomerCadit.Text = "4 เดือน" Then
            Maturity = 120
        ElseIf Me.cbbCustomerCadit.Text = "5 เดือน" Then
            Maturity = 150
        ElseIf Me.cbbCustomerCadit.Text = "6 เดือน" Then
            Maturity = 180
        ElseIf Me.cbbCustomerCadit.Text = "7 เดือน" Then
            Maturity = 210
        ElseIf Me.cbbCustomerCadit.Text = "8 เดือน" Then
            Maturity = 240
        ElseIf Me.cbbCustomerCadit.Text = "9 เดือน" Then
            Maturity = 270
        ElseIf Me.cbbCustomerCadit.Text = "10 เดือน" Then
            Maturity = 300
        ElseIf Me.cbbCustomerCadit.Text = "11 เดือน" Then
            Maturity = 330
        ElseIf Me.cbbCustomerCadit.Text = "1 ปี" Then
            Maturity = 360
        ElseIf Me.cbbCustomerCadit.Text = "2 ปี" Then
            Maturity = 720
        ElseIf Me.cbbCustomerCadit.Text = "3 ปี" Then
            Maturity = 1080
        ElseIf Me.cbbCustomerCadit.Text = "" Then
            Maturity = 15
        End If
    End Sub
    
    'Item is filled either manually or from database 
    Dim lst As New List(Of String)

    'AutoComplete collection that will help to filter keep the records.
    Dim MySource As New AutoCompleteStringCollection()

    Private Sub txtCustomerAddress_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCustomerAddress.KeyDown
        If e.KeyCode = Keys.Enter Then   ' On enter I planned to add it the list
            If Not Me.txtCustomerAddress.AutoCompleteCustomSource.Contains(Me.txtCustomerAddress.Text) Then  ' If item not present already
                ' Add to the source directly
                Me.txtCustomerAddress.AutoCompleteCustomSource.Add(Me.txtCustomerAddress.Text)
            End If
        ElseIf e.KeyCode = Keys.Delete Then  ' On delete key i have planned to remove the entry
            ' remove item from source
            CType(Me.txtCustomerAddress.AutoCompleteCustomSource, AutoCompleteStringCollection).Remove(Me.txtCustomerAddress.Text)
            ' Clear textbox
            Me.txtCustomerAddress.Clear()
        End If
    End Sub

    Private Sub customerfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call startfrm()
        Me.Icon = Mainfrm.Icon
        Try
            Dim cmd As New MySqlCommand("SELECT DISTINCT customer_address,customer_zipcode FROM customer ORDER BY customer_id DESC LIMIT 1000", ConnectionDB)
            Call open_connection()
            Using ds As New DataSet
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(ds, "customer_address")
                Dim col As New AutoCompleteStringCollection
                Dim i As Integer
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    col.Add(ds.Tables(0).Rows(i)("customer_address").ToString())
                Next
                Me.txtCustomerAddress.AutoCompleteCustomSource = col
                Me.txtCustomerAddress.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                Me.txtCustomerAddress.AutoCompleteSource = AutoCompleteSource.CustomSource
            End Using


            Call open_connection()
            Using ds As New DataSet
                Dim da As New MySqlDataAdapter(cmd)
                da.Fill(ds, "customer_zipcode")
                Dim col As New AutoCompleteStringCollection
                Dim i As Integer
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    col.Add(ds.Tables(0).Rows(i)("customer_zipcode").ToString())
                Next
                Me.txtCustomerZipcode.AutoCompleteCustomSource = col
                Me.txtCustomerZipcode.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                Me.txtCustomerZipcode.AutoCompleteSource = AutoCompleteSource.CustomSource
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub txtCustomerZipcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCustomerZipcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not Me.txtCustomerZipcode.AutoCompleteCustomSource.Contains(Me.txtCustomerZipcode.Text) Then

                Me.txtCustomerZipcode.AutoCompleteCustomSource.Add(Me.txtCustomerZipcode.Text)
            End If
        ElseIf e.KeyCode = Keys.Delete Then
            CType(txtCustomerZipcode.AutoCompleteCustomSource, AutoCompleteStringCollection).Remove(Me.txtCustomerZipcode.Text)
            Me.txtCustomerZipcode.Clear()
        End If
    End Sub
End Class