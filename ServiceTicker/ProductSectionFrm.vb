Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class ProductSectionFrm

    Private Sub startfrm()
        Me.txtPSid.Enabled = False
        Me.txtPSName.Enabled = False
        Me.dgPS.ClearSelection()
        Me.dgPS.Enabled = True
        Call getDataProduct_section()
        Call ClearTextBoxes(Me)
        Me.btnPSadd.Enabled = True
        Me.btnPSdel.Enabled = False
        Me.btnPSedit.Enabled = False
        Me.btnPSdel.Enabled = False
        Me.btnPSadd.Text = "เพิ่ม"
    End Sub
    
    Private Sub AutoNumberNo()
        Try
            dt = New DataTable
            Mainfrm.lblMainStatus.Text = "SELECT ver_productsectio"
            strSQL = "SELECT ver_productsectio FROM ver_detail"
            dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
            Call open_connection()
            dtAdapter.Fill(dt)
            Dim vid As String = dt.Rows(0).Item("ver_productsectio")
            Mainfrm.lblMainStatus.Text = "SELECT Max(ID) as ID"
            strSQL = "SELECT Max(ID) as ID FROM product_section_id"
            dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                Me.txtPSid.Text = vid & "0001"
            Else
                Dim newID As Integer = CInt(Dr.Item("id"))
                newID += 1
                Me.txtPSid.Text = vid & newID.ToString("0000")
            End If
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private WithEvents songsDataGridView As New System.Windows.Forms.DataGridView
    Private Sub search_record()
        dt = New DataTable
        Dim strKeyWord As String = Me.txtPSsearch.Text
        Mainfrm.lblMainStatus.Text = "select * from product_section"
        strSQL = "select * from product_section where 1=1"
        If strKeyWord <> "" Then
            strSQL = strSQL & " and prosection_name like '%" & strKeyWord & "%'"
        End If
        dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
        Call open_connection()
        dtAdapter.Fill(dt)
        Me.dgPS.DataSource = dt
        '******************************'
        Me.dgPS.Columns.Clear()
        With dgPS.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Navy
            .ForeColor = Color.White
            .Font = New Font(songsDataGridView.Font, FontStyle.Bold)
        End With
        Dim ColumnTextBox As DataGridViewTextBoxColumn
        '0
        '*** Column (CustomerID) ***'
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "prosection_id"
        ColumnTextBox.HeaderText = "รหัส"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 100
        Me.dgPS.Columns.Add(ColumnTextBox)
        '1
        '*** Column (Name) ***'
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "prosection_name"
        ColumnTextBox.HeaderText = "ชื่อประเภทอะไหล่"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 200
        Me.dgPS.Columns.Add(ColumnTextBox)

    End Sub
    Private Sub getDataProduct_section()
        dt = New DataTable
        Mainfrm.lblMainStatus.Text = "select prosection_id,prosection_name"
        strSQL = "select prosection_id,prosection_name from product_section ORDER BY prosection_name ASC"
        dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
        Call open_connection()
        dtAdapter.Fill(dt)
        Me.dgPS.DataSource = dt
        '******************************'
        Me.dgPS.Columns.Clear()
        With dgPS.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Navy
            .ForeColor = Color.White
            .Font = New Font(songsDataGridView.Font, FontStyle.Bold)
        End With
        Dim ColumnTextBox As DataGridViewTextBoxColumn
        '0
        '*** Column (CustomerID) ***'
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "prosection_id"
        ColumnTextBox.HeaderText = "รหัส"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 100
        Me.dgPS.Columns.Add(ColumnTextBox)
        '1
        '*** Column (Name) ***'
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "prosection_name"
        ColumnTextBox.HeaderText = "ชื่อประเภทอะไหล่"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 200
        Me.dgPS.Columns.Add(ColumnTextBox)
    End Sub
    Private Sub DeleteData()
        'ตรวจสอบว่ามีชื่อ type นี้ ใน product หรือไม่
        Try
            strSQL = "SELECT `type` FROM product WHERE `type`='" & Me.dgPS.CurrentRow.Cells(1).Value & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                    strSQL = "SELECT COUNT(`type`) AS typ FROM product WHERE `type`='" & Me.dgPS.CurrentRow.Cells(1).Value & "'"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    Dr.Read()
                Dim cn As Integer = Dr.Item("typ")
                MsgBox("พบรายการประเภทของสินค้า " & Me.dgPS.CurrentRow.Cells(1).Value & " ยังมีอยู่ " & cn & " รายการ" _
                       & vbNewLine & "ไม่สามารถลบได้ กรุณาเปลี่ยนรายการประเภทสินค้าในแก้ไขรายการสินค้าให้หมดก่อนจึงจะลบได้", MsgBoxStyle.Exclamation, "ลบไม่ได้")
                Exit Sub
            Else
                Exit Try
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Dim Ans As String
        Ans = MsgBox("คุณแน่ว่าจะลบข้อมูลนี้", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
        If Ans = System.Windows.Forms.DialogResult.No Then
            MsgBox("การลบข้อมูลถูกยกเลิก", MsgBoxStyle.Information, "ยืนยัน")
            Me.dgPS.ClearSelection()
            'clear all textbox
            For Each ctl In Controls
                If TypeOf ctl Is TextBox Then ctl.Text = ""
            Next ctl
            Exit Sub
        Else
            Try
                Mainfrm.lblMainStatus.Text = "DELETE FROM product_section"
                strSQL = "DELETE FROM product_section WHERE prosection_id='" & Me.txtPSid.Text & "';"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                MsgBox("ลบข้อมูลที่คุณเลือกแล้ว", MsgBoxStyle.Information, "ยืนยัน")
                Me.dgPS.ClearSelection()
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
        End If
        Call startfrm()
    End Sub
    Private Sub btnPSadd_Click(sender As Object, e As EventArgs) Handles btnPSadd.Click
        If Me.btnPSadd.Text = "เพิ่ม" Then
            Me.btnPSadd.Text = "บันทึก"
            Call AutoNumberNo()
            Me.btnPSdel.Enabled = False
            Me.btnPSedit.Enabled = False
            Call enableTextBoxes(Me)
            Me.txtPSid.Enabled = False
            Me.dgPS.Enabled = False
            Exit Sub
        ElseIf Me.btnPSadd.Text = "บันทึก" Then
            If Me.txtPSName.Text = "" Then
                MsgBox("ใส่ชื่อประเภทอะไหล่", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.txtPSName.Focus()
                Me.txtPSName.BackColor = Color.Salmon
                Exit Sub
            Else
                Try
                    Dim pid As String
                    strSQL = "SELECT prosection_id,prosection_name FROM product_section WHERE prosection_name='" & Me.txtPSName.Text & "'"
                    Mainfrm.lblMainStatus.Text = strSQL
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    Dr.Read()
                    pid = Dr.Item("prosection_id")
                    If Dr.HasRows Then
                        Mainfrm.lblMainStatus.Text = "พบชื่อสินค้าซ้ำกับรหัสสินค้า " & pid & " กรุณาตรวจสอบ"
                        MsgBox("พบชื่อประเภทสินค้าซ้ำกับรหัสประเภทสินค้า " & pid & " กรุณาตรวจสอบ", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                        Me.txtPSName.Focus()
                        Me.txtPSName.BackColor = Color.Salmon
                        Exit Sub
                    End If
                Catch ex As Exception
                    Mainfrm.lblMainStatus.Text = "ไม่มีข้อมูลซ้ำ"
                End Try
            End If

            Dim Ans As String
            Ans = MsgBox("คุณแน่ในว่าจะเพิ่มข้อมูลนี้", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
            If Ans = System.Windows.Forms.DialogResult.No Then
                MsgBox("การเพิ่มข้อมูลถูกยกเลิก", MsgBoxStyle.Information, "ยืนยัน")
                Call startfrm()
                Exit Sub
            Else
                Try
                    strSQL = "INSERT INTO product_section(prosection_id,prosection_name)VALUES(@1,@2)"
                    Mainfrm.lblMainStatus.Text = strSQL
                    Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                        cmd.Parameters.AddWithValue("@1", Me.txtPSid.Text)
                        cmd.Parameters.AddWithValue("@2", Me.txtPSName.Text)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    End Using
                Catch ex As Exception
                    Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                End Try
                Try
                    strSQL = "insert into product_section_id(prosection_id,prosection_name,datetime_save)" _
                           & "VALUES(@prosection_id,@prosection_name,@datetime_save)"
                    Mainfrm.lblMainStatus.Text = strSQL
                    Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                        cmd.Parameters.AddWithValue("@prosection_id", Me.txtPSid.Text)
                        cmd.Parameters.AddWithValue("@prosection_name", Me.txtPSName.Text)
                        cmd.Parameters.AddWithValue("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")))
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    End Using
                    Mainfrm.lblMainStatus.Text = "บันทึกข้อมูลแล้ว"
                    MsgBox("บันทึกข้อมูลแล้ว", MsgBoxStyle.Information, "บันทึกข้อมูล")
                Catch ex As Exception
                    Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                End Try

            End If
            Me.btnPSadd.Text = "เพิ่ม"
        End If
        Call ClearTextBoxes(Me)
        Me.dgPS.ClearSelection()
        Call startfrm()
    End Sub

    Private Sub btnPSgetall_Click(sender As Object, e As EventArgs) Handles btnPSgetall.Click
        Call getDataProduct_section()
    End Sub

    Private Sub btnPSedit_Click(sender As Object, e As EventArgs) Handles btnPSedit.Click
        If Me.btnPSedit.Text = "แก้ไข" Then
            Me.btnPSedit.Text = "บันทึก"
            Me.btnPSdel.Enabled = False
            Me.btnPSadd.Enabled = False
            Call enableTextBoxes(Me)
            Me.txtPSid.Enabled = False
            Me.dgPS.Enabled = False
            Exit Sub
        ElseIf Me.btnPSedit.Text = "บันทึก" Then
            If Me.txtPSName.Text = "" Then
                MsgBox("ใส่ชื่อประเภทอะไหล่", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.txtPSName.Focus()
                Me.txtPSName.BackColor = Color.Salmon
                Exit Sub
            End If
        End If
        Try
            Dim iddu, namedu As String
            strSQL = "SELECT prosection_id,prosection_name FROM product_section WHERE prosection_name='" & Me.txtPSName.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            iddu = Dr.Item("prosection_id")
            namedu = Dr.Item("prosection_name")
            If iddu = Me.txtPSid.Text Then
                Exit Try
            Else
                MsgBox("พบชื่อประเภทสินค้าซ้ำกับรหัสประเภทสินค้า " & iddu & " กรุณาตรวจสอบ", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Me.txtPSName.Focus()
                Me.txtPSName.BackColor = Color.Salmon
                Exit Sub
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Dim UpDateAns As String
        UpDateAns = MsgBox("คุณแน่ใจว่าจะแก้ไขข้อมูลนี้" & vbNewLine & "โปรดทราบว่าข้อมูลประเภทสินค้าในฐานข้อมูลทั้งหมดจะถูกแก้ไขไปด้วย", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
        If UpDateAns = System.Windows.Forms.DialogResult.No Then
            Mainfrm.lblMainStatus.Text = "การแก้ไขข้อมูลถูกยกเลิก."
            MsgBox("การแก้ไขข้อมูลถูกยกเลิก.", MsgBoxStyle.Information, "ยกเลิกการแก้ไข")
        Else
            'แก้ไข product_section
            Try
                strSQL = "UPDATE product_section SET prosection_name='" & Me.txtPSName.Text & "' WHERE prosection_id='" & Me.dgPS.SelectedCells(0).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try

            'แก้ไข cash_sale_barcode
            Try
                strSQL = "UPDATE cash_sale_barcode SET `type`='" & Me.txtPSName.Text & "' WHERE `type`='" & Me.dgPS.CurrentRow.Cells(1).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try

            'แก้ไข claims 
            Try
                strSQL = "UPDATE claims SET `type`='" & Me.txtPSName.Text & "' WHERE `type`='" & Me.dgPS.CurrentRow.Cells(1).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try

            'แก้ไข claims_cache 
            Try
                strSQL = "UPDATE claims_cache SET `type`='" & Me.txtPSName.Text & "' WHERE `type`='" & Me.dgPS.CurrentRow.Cells(1).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try

            'แก้ไข claims_copy
            Try
                strSQL = "UPDATE claims_copy SET `type`='" & Me.txtPSName.Text & "' WHERE `type`='" & Me.dgPS.CurrentRow.Cells(1).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try

            'แก้ไข claims_send_report 
            Try
                strSQL = "UPDATE claims_send_report SET `type`='" & Me.txtPSName.Text & "' WHERE `type`='" & Me.dgPS.CurrentRow.Cells(1).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try

            'แก้ไข product
            Try
                strSQL = "UPDATE product SET `type`='" & Me.txtPSName.Text & "' WHERE `type`='" & Me.dgPS.CurrentRow.Cells(1).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try

            'แก้ไข sale_barcode
            Try
                strSQL = "UPDATE sale_barcode SET `type`='" & Me.txtPSName.Text & "' WHERE `type`='" & Me.dgPS.CurrentRow.Cells(1).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try

            'แก้ไข product_section_id
            Try
                strSQL = "UPDATE product_section_id SET prosection_name='" & Me.txtPSName.Text & "' WHERE prosection_id='" & Me.dgPS.SelectedCells(0).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try

            'แก้ไข stock_number_cache
            Try
                strSQL = "UPDATE stock_number_cache SET `type`='" & Me.txtPSName.Text & "' WHERE `type`='" & Me.dgPS.CurrentRow.Cells(1).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try

            MsgBox("แก้ไขข้อมูลเรียบร้อยแล้ว.", MsgBoxStyle.Information, "ยืนยัน")
            Me.btnPSedit.Text = "แก้ไข"
            Me.dgPS.ClearSelection()
        End If
        Me.btnPSedit.Text = "แก้ไข"
        Call ClearTextBoxes(Me)
        Me.dgPS.ClearSelection()
        Call startfrm()
    End Sub

    Private Sub btnPSdel_Click(sender As Object, e As EventArgs) Handles btnPSdel.Click
        Call DeleteData()
        Call startfrm()
    End Sub

    Private Sub btnPSSearch_Click(sender As Object, e As EventArgs) Handles btnPSSearch.Click
        Call search_record()
    End Sub

    Private Sub ProductSectionfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call startfrm()
        Me.Icon = Mainfrm.Icon
    End Sub

    Private Sub dgPS_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgPS.MouseDoubleClick
        Me.txtPSid.Text = Me.dgPS.SelectedCells(0).Value
        Me.txtPSName.Text = Me.dgPS.SelectedCells(1).Value
        Me.btnPSadd.Enabled = False
        Me.btnPSedit.Enabled = True
        Me.btnPSdel.Enabled = True
    End Sub
End Class