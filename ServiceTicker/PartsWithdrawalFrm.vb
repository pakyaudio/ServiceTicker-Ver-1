Imports System.Globalization
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class PartsWithdrawalFrm
    Dim tbl, tbl1, tbl2 As New DataTable
    Dim r, r1 As DataRow

    'เหลือ ลบเซลล์จาก datagrid
    Private Sub sumDatagridview()
        'บวก datagrid
        Dim totalx, totaly, totalz As Decimal
        For x = 0 To dgPWproMeNoSN.RowCount - 1
            totalx += CDec(dgPWproMeNoSN.Rows(x).Cells(5).Value)
            totaly += CDec(dgPWproMeNoSN.Rows(x).Cells(4).Value)
            totalz = Me.dgPWproMeNoSN.Rows.Count
        Next
        Me.lblPWgetTotalPrice.Text = totalx
        Me.lblPWtotalXYZ.Text = "รายการ " & totalz & " | ปริมาณ " & totaly
    End Sub
   
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.dgPWproMeNoSN.Rows.Count <> 0 Or Me.dgPWproMEwSN.Rows.Count <> 0 Then
            If MessageBox.Show("มีข้อมูลอยู่ในตารางสินค้า" & vbNewLine & "ต้องการจะปิดหน้าต่างนี้ ใช่ หรือ ไม่", "ปิดหน้าต่างโปรแกรม", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        Else
            e.Cancel = False
        End If
    End Sub
    Private Sub btnPWclose_Click(sender As Object, e As EventArgs) Handles btnPWclose.Click
        If Me.btnPWclose.Text = "ปิด" Then
            Me.Close()
        ElseIf Me.btnPWclose.Text = "ยกเลิก" Then
            If Me.dgPWproMeNoSN.Rows.Count <> 0 Or Me.dgPWproMEwSN.Rows.Count <> 0 Then
                Dim result = MessageBox.Show("มีข้อมูลยังไม่ถูกบันทึก ต้องการจะบันทึกข้อมูลหรือไม่" & vbNewLine & "Yes บันทึกข้อมูล" _
                                             & vbNewLine & "No ล้างข้อมูลการขายนี้" & vbNewLine & _
                                             "Cancel ยกเลิก", "แจ้งเตือน", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If result = DialogResult.Cancel Then
                    Exit Sub
                ElseIf result = DialogResult.No Then
                    tbl.Clear()
                    tbl1.Clear()
                    tbl2.Clear()
                    Me.dgPWproMeNoSN.Refresh()
                    Me.dgPWproMEwSN.Refresh()
                    Me.dgPWProsearch.Refresh()
                    Call sumDatagridview()
                    Call cencer()
                ElseIf result = DialogResult.Yes Then
                    Dim i As Integer = dgPWproMeNoSN.Rows.Count
                    If i <= 0 Then
                        Mainfrm.lblMainStatus.Text = "ไม่มีข้อมูล กรุณาป้อนข้อมูล บาร์โค๊ตหรือ SN ก่อน"
                        Exit Sub
                    Else
                        Call saveDGwsnTodatabase()
                        Call saveDGNosnTodatabase()
                        Call saveSaleAll()
                        Call saveSale_id()
                        tbl.Rows.Clear()
                        tbl1.Rows.Clear()
                        tbl2.Rows.Clear()
                        Call cencer()
                        MsgBox("บันทึกข้อมูลเรียบร้อย", MsgBoxStyle.Information, "บันทึกข้อมูล")
                        Me.Close()
                        Call cencer()
                    End If
                End If
            End If

        End If
    End Sub

    Private Sub TextBoxClear()
        Me.txtPWprobarcodeANDsn.Text = ""
        Me.txtPWprobarcode.Text = ""
        Me.txtPWproname.Text = ""
        Me.txtPWproprice.Text = ""
        Me.txtPWproUnit.Text = ""
        Me.txtPWprop.Text = ""
    End Sub

    Private WithEvents songsDataGridView As New System.Windows.Forms.DataGridView
    Private Sub AutoNumberNo()
        Try
            dt = New DataTable
            Mainfrm.lblMainStatus.Text = "SELECT ver_PartsWithdrawal "
            strSQL = "SELECT ver_PartsWithdrawal FROM ver_detail"
            dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
            Call open_connection()
            dtAdapter.Fill(dt)
            Dim nid As String = dt.Rows(0).Item("ver_PartsWithdrawal")

            strSQL = "SELECT Max(id) as id FROM sale_id"
            dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                Me.txtPWsaleID.Text = nid & Now.ToString("yyMMddHHmm") & "00001"
            Else
                Dim newID As Integer = CInt(Dr.Item("id"))
                newID += 1
                Me.txtPWsaleID.Text = nid & Now.ToString("yyMMddHHmm") & newID.ToString("00000")
            End If
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub dateNow()
        Me.txtPWdateNow.Text = Now.ToString("d MMMM yyyy", CultureInfo.CreateSpecificCulture("th-TH"))
    End Sub
    Private Sub search_record()
        dt = New DataTable
        Dim strKeyWord As String = Me.txtPWproSearch.Text
        Mainfrm.lblMainStatus.Text = strSQL
        strSQL = "select * from product"
        If strKeyWord <> "" Then
            strSQL = strSQL & " where name_pro like '%" & strKeyWord & "%' "
        End If
        dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
        Call open_connection()
        dtAdapter.Fill(dt)
        Me.dgPWProsearch.DataSource = dt
        '******************************'
        Me.dgPWProsearch.Columns.Clear()
        With dgPWProsearch.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Navy
            .ForeColor = Color.White
            .Font = New Font(songsDataGridView.Font, FontStyle.Bold)
        End With
        Dim ColumnTextBox As DataGridViewTextBoxColumn
        '0
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "update_date"
        ColumnTextBox.HeaderText = "update"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 100
        Me.dgPWProsearch.Columns.Add(ColumnTextBox)
        '1
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "bar_code"
        ColumnTextBox.HeaderText = "รหัสสินค้า"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 100
        Me.dgPWProsearch.Columns.Add(ColumnTextBox)
        '2
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "name_pro"
        ColumnTextBox.HeaderText = "ชื่อสินค้า"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 200
        Me.dgPWProsearch.Columns.Add(ColumnTextBox)
        '3
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "price_buy"
        ColumnTextBox.HeaderText = "ราคาปกติ"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 70
        Me.dgPWProsearch.Columns.Add(ColumnTextBox)
        '4
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "unit"
        ColumnTextBox.HeaderText = "หน่วย"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 100
        Me.dgPWProsearch.Columns.Add(ColumnTextBox)
        '5
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "count_num"
        ColumnTextBox.HeaderText = "คงเหลือ"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 50
        Me.dgPWProsearch.Columns.Add(ColumnTextBox)
    End Sub

    Private Sub getdatacombobox_prosection()
        Try
            Mainfrm.lblMainStatus.Text = strSQL
            strSQL = "select prosection_name from product_section ORDER BY prosection_name ASC"
            cmd = New MySqlCommand
            cmd.CommandText = strSQL
            cmd.Connection = ConnectionDB
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                cbbPWgetProSection.Items.Add(Dr("prosection_name"))
            End While
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub search_recordfromcbbPWsection()
        dt = New DataTable
        Dim strKeyWord As String = Me.cbbPWgetProSection.Text
        Mainfrm.lblMainStatus.Text = strSQL
        strSQL = "select update_date,bar_code,name_pro,price_buy,unit,count_num from product"
        If strKeyWord <> "" Then
            strSQL = strSQL & " where type like '%" & strKeyWord & "%' "
        End If
        dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
        Call open_connection()
        dtAdapter.Fill(dt)
        Me.dgPWProsearch.DataSource = dt
        '******************************'
        Me.dgPWProsearch.Columns.Clear()
        With dgPWProsearch.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Navy
            .ForeColor = Color.White
            .Font = New Font(songsDataGridView.Font, FontStyle.Bold)
        End With
        Dim ColumnTextBox As DataGridViewTextBoxColumn
        '0
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "update_date"
        ColumnTextBox.HeaderText = "update"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 100
        Me.dgPWProsearch.Columns.Add(ColumnTextBox)
        '1
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "bar_code"
        ColumnTextBox.HeaderText = "รหัสสินค้า"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 100
        Me.dgPWProsearch.Columns.Add(ColumnTextBox)
        '2
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "name_pro"
        ColumnTextBox.HeaderText = "ชื่อสินค้า"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 200
        Me.dgPWProsearch.Columns.Add(ColumnTextBox)
        '3
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "price_buy"
        ColumnTextBox.HeaderText = "ราคา"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 100
        Me.dgPWProsearch.Columns.Add(ColumnTextBox)
        '4
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "unit"
        ColumnTextBox.HeaderText = "หน่วย"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 100
        Me.dgPWProsearch.Columns.Add(ColumnTextBox)
        '5
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "count_num"
        ColumnTextBox.HeaderText = "คงเหลือ"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 50
        Me.dgPWProsearch.Columns.Add(ColumnTextBox)
    End Sub
    Private Sub startfrm()
        Me.cbbPWgetProSection.Items.Clear()
        Call AutoNumberNo()
        Call getdatacombobox_prosection()
        Call dateNow()
        Me.txtPWprobarcodeANDsn.Focus()
        Me.btnPWokTodg.Enabled = False
        Call cencer()
    End Sub
    Private Sub txtPWproSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPWproSearch.KeyDown
        On Error Resume Next
        If e.KeyCode = Keys.Enter Then
            Call search_record()
        End If
    End Sub
    Private Sub PartsWithdrawalfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call startfrm()
        Call addtodgNoSN()
        Call addtodgwSN()
        Me.Icon = Mainfrm.Icon

    End Sub
    Private Sub addtodgNoSN()
        tbl.NewRow()
        tbl.Columns.Add(New DataColumn("bar_code", GetType(System.String)))
        tbl.Columns.Add(New DataColumn("name_pro", GetType(System.String)))
        tbl.Columns.Add(New DataColumn("price_buy", GetType(System.Decimal)))
        tbl.Columns.Add(New DataColumn("unit", GetType(System.String)))
        tbl.Columns.Add(New DataColumn("total", GetType(System.Decimal)))
        tbl.Columns.Add(New DataColumn("total_cal", GetType(System.Decimal)))
        dgPWproMeNoSN.DataSource = tbl
        With dgPWproMeNoSN
            .Columns(0).HeaderText = "บาร์โค๊ต"
            .Columns(1).HeaderText = "ชื่อสินค้า"
            .Columns(2).HeaderText = "ราคา"
            .Columns(3).HeaderText = "หน่วยนับ"
            .Columns(4).HeaderText = "จำนวน"
            .Columns(5).HeaderText = "รวมราคา"

            .Columns(0).Width = 90
            .Columns(1).Width = 200
            .Columns(2).Width = 70
            .Columns(3).Width = 100
            .Columns(4).Width = 70
            .Columns(5).Width = 100

            .Columns(0).ReadOnly = True
            .Columns(1).ReadOnly = True
            .Columns(2).ReadOnly = False
            .Columns(3).ReadOnly = True
            .Columns(4).ReadOnly = False
            .Columns(5).ReadOnly = True
            r = tbl.NewRow
        End With
    End Sub
    Private Sub addtodgwSN()
        Try
            tbl1.NewRow()
            tbl1.Columns.Add(New DataColumn("serial_pro", GetType(System.String)))
            tbl1.Columns.Add(New DataColumn("name_pro1", GetType(System.String)))
            dgPWproMEwSN.DataSource = tbl1
            With dgPWproMEwSN
                .Columns(0).HeaderText = "SN"
                .Columns(1).HeaderText = "ชื่อสินค้า"
                .Columns(0).Width = 90
                .Columns(1).Width = 200
                .Columns(0).ReadOnly = True
                .Columns(1).ReadOnly = True
                r1 = tbl1.NewRow
            End With
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub btnPWokTodg_Click(sender As Object, e As EventArgs) Handles btnPWokTodg.Click
        If Me.txtPWprobarcodeANDsn.Text = Nothing Then
            Exit Sub
        ElseIf Me.txtPWproprice.Text = Nothing Then
            Exit Sub
        ElseIf Me.txtPWprop.Text = Nothing Then
            Exit Sub
        End If
        Try
            Dim DrBarcode As MySqlDataReader
            Mainfrm.lblMainStatus.Text = strSQL
            strSQL = "SELECT count_num FROM product WHERE bar_code='" & Me.txtPWprobarcodeANDsn.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            DrBarcode = cmd.ExecuteReader()
            DrBarcode.Read()
            Dim chknum As Integer
            chknum = DrBarcode.Item("count_num")
             If chknum <= 0 Then
                MsgBox("สินค้าเหลือ " & chknum & " ชิ้น" & vbNewLine & "สินค้าในสต็อกหมด", MsgBoxStyle.Information, "สินค้าหมด")
                Call TextBoxClear()
                Exit Sub
            End If
            'ตรวจจำนวนในสต็อก
            For NPro As Integer = 0 To Me.dgPWproMeNoSN.Rows.Count - 1
                If Me.txtPWprobarcode.Text = Me.dgPWproMeNoSN.Rows(NPro).Cells("bar_code").Value Then
                    Dim ttAll As Integer = CDec(Me.dgPWproMeNoSN.Rows(NPro).Cells("total").Value) + CDec(Me.txtPWprop.Text)
                    If chknum < ttAll Then
                        MsgBox("สินค้าในสต็อกมี " & chknum & " ชิ้น" & vbNewLine & "เบิกไปแล้ว " & _
                                Me.dgPWproMeNoSN.Rows(NPro).Cells("total").Value & " ชิ้น" _
                                & " บวกอีก " & Me.txtPWprop.Text & " ชิ้น " _
                               & vbNewLine & "เบิกเกินจำนวนที่มีในสต็อก", MsgBoxStyle.Information, "เบิกเกินจำนวน")
                        Call TextBoxClear()
                        Exit Sub
                    End If
                End If
            Next
            Dim d As String = ""
            Dim f As Integer = 0
            For f = 0 To dgPWproMeNoSN.RowCount - 1
                If Me.txtPWprobarcode.Text = Me.dgPWproMeNoSN.Rows(f).Cells(0).Value Then
                    Me.dgPWproMeNoSN.Rows(f).Cells(4).Value = CDec(Me.dgPWproMeNoSN.Rows(f).Cells(4).Value) + CDec(Me.txtPWprop.Text)
                    d = "d"
                End If
            Next
            If d = "d" Then
            Else
                r = tbl.NewRow
                r("bar_code") = Me.txtPWprobarcode.Text.Trim
                r("name_pro") = Me.txtPWproname.Text.Trim
                r("price_buy") = Me.txtPWproprice.Text.Trim
                r("unit") = Me.txtPWproUnit.Text.Trim
                r("total") = Me.txtPWprop.Text.Trim
                tbl.Rows.Add(r)
            End If
            Call TextBoxClear()

            For x = 0 To dgPWproMeNoSN.RowCount - 1
                Me.dgPWproMeNoSN.Rows(x).Cells(5).Value = CDec(dgPWproMeNoSN.Rows(x).Cells(2).Value) * CDec(dgPWproMeNoSN.Rows(x).Cells(4).Value)
            Next
            Call sumDatagridview()
            Call cencer()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Me.btnPWokTodg.Enabled = False
    End Sub
    Private Sub cbbPWgetProSection_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbPWgetProSection.SelectedValueChanged
        Call search_recordfromcbbPWsection()
        Call cencer()
    End Sub
 
    Private Sub txtPWprobarcodeANDsn_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPWprobarcodeANDsn.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim DrBarcode As MySqlDataReader
                Mainfrm.lblMainStatus.Text = strSQL
                strSQL = "SELECT * FROM product WHERE bar_code='" & Me.txtPWprobarcodeANDsn.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                DrBarcode = cmd.ExecuteReader()
                DrBarcode.Read()
                If Not DrBarcode.HasRows Then
                    'ตรวจ sn ซ้ำ
                    For i As Integer = 0 To dgPWproMEwSN.Rows.Count - 1
                        If Strings.Trim(Me.txtPWprobarcodeANDsn.Text) = Strings.Trim(Me.dgPWproMEwSN.Item(0, i).Value) Then
                            If MessageBox.Show("Serial Number นี้มีอยู่แล้ว", "ข้อมูลซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Information) Then
                                Call TextBoxClear()
                                Me.txtPWprobarcodeANDsn.Focus()
                                Return
                            End If
                        End If
                    Next
                    'อ่านข้อมูลจากดาต้าเบสแล้วอัดลง ดาต้ากริต
                    If Me.rbSbuy.Checked = True Then
                        strSQL = "SELECT bar_code,name_pro,price_buy,unit,check_stock,count_num FROM product WHERE code_pro IN (SELECT code_pro FROM product_serial WHERE serial_pro=@1)"
                    ElseIf Me.rbSwholesale.Checked = True Then
                        strSQL = "SELECT bar_code,name_pro,price_wholesale,unit,check_stock,count_num FROM product WHERE code_pro IN (SELECT code_pro FROM product_serial WHERE serial_pro=@1)"
                    ElseIf Me.rbStechnician.Checked = True Then
                        strSQL = "SELECT bar_code,name_pro,price_technician,unit,check_stock,count_num FROM product WHERE code_pro IN (SELECT code_pro FROM product_serial WHERE serial_pro=@1)"
                    ElseIf Me.rbSloyal.Checked = True Then
                        strSQL = "SELECT bar_code,name_pro,price_loyal,unit,check_stock,count_num FROM product WHERE code_pro IN (SELECT code_pro FROM product_serial WHERE serial_pro=@1)"
                    ElseIf Me.rbSmembers.Checked = True Then
                        strSQL = "SELECT bar_code,name_pro,price_members,unit,check_stock,count_num FROM product WHERE code_pro IN (SELECT code_pro FROM product_serial WHERE serial_pro=@1)"
                    End If
                    Mainfrm.lblMainStatus.Text = strSQL
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    cmd.Prepare()
                    cmd.Parameters.AddWithValue("@1", Me.txtPWprobarcodeANDsn.Text)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    Dim checkstok As String
                    Dim countnum As String
                    With Dr
                        .Read()
                        'Me.txtPWprobarcodeANDsn.Text = .Item("serial_pro")
                        Me.txtPWprobarcode.Text = .Item("bar_code")
                        Me.txtPWproname.Text = .Item("name_pro")
                        If Me.rbSbuy.Checked = True Then
                            Me.txtPWproprice.Text = .GetDecimal("price_buy")
                        ElseIf Me.rbSwholesale.Checked = True Then
                            Me.txtPWproprice.Text = .GetDecimal("price_wholesale")
                        ElseIf Me.rbStechnician.Checked = True Then
                            Me.txtPWproprice.Text = .GetDecimal("price_technician")
                        ElseIf Me.rbSloyal.Checked = True Then
                            Me.txtPWproprice.Text = .GetDecimal("price_loyal")
                        ElseIf Me.rbSmembers.Checked = True Then
                            Me.txtPWproprice.Text = .GetDecimal("price_members")
                        End If
                        
                        Me.txtPWproUnit.Text = .Item("unit")
                        Me.txtPWprop.Text = "1"
                        checkstok = .Item("check_stock")
                        countnum = .Item("count_num")
                    End With
                    Dr.Close()
                    'เตือนสินค้าใกล้หมด edit
                    If countnum <= 0 Then
                        MsgBox("สินค้าเหลือ " & countnum & " ชิ้น" & vbNewLine & "สินค้าในสต็อกหมด", MsgBoxStyle.Information, "สินค้าหมด")
                        Call TextBoxClear()
                        Exit Sub
                    End If
                    'เบิกเกินสต็อกที่มี
                    For NPro As Integer = 0 To Me.dgPWproMeNoSN.Rows.Count - 1
                        If Me.txtPWprobarcode.Text = Me.dgPWproMeNoSN.Rows(NPro).Cells("bar_code").Value Then
                            Dim ttAll As Decimal = CDec(Me.dgPWproMeNoSN.Rows(NPro).Cells("total").Value) + CDec(Me.txtPWprop.Text)
                            Dim CLA As Decimal = countnum - ttAll
                            If countnum < ttAll Then
                                MsgBox("สินค้าในสต็อกมี " & countnum & " ชิ้น" & vbNewLine & "เบิกไปแล้ว " & _
                                        Me.dgPWproMeNoSN.Rows(NPro).Cells("total").Value & " ชิ้น" _
                                        & "บวกอีก " & Me.txtPWprop.Text & " ชิ้น " _
                                       & vbNewLine & "เบิกเกินจำนวนที่มีในสต็อก", MsgBoxStyle.Information, "เบิกเกินจำนวน")
                                Call TextBoxClear()
                                Exit Sub
                            End If
                        End If
                    Next
                    r1 = tbl1.NewRow
                    r1("serial_pro") = Me.txtPWprobarcodeANDsn.Text.Trim
                    r1("name_pro1") = Me.txtPWproname.Text.Trim
                    tbl1.Rows.Add(r1)
                    'ตรวจข้อมูลซ้ำ หากมีข้อมูลให้บวกจำนวนข้อมูล
                    Dim d As String = ""
                    Dim f As Integer = 0
                    For f = 0 To dgPWproMeNoSN.RowCount - 1
                        If Me.txtPWprobarcode.Text = Me.dgPWproMeNoSN.Rows(f).Cells(0).Value Then
                            Me.dgPWproMeNoSN.Rows(f).Cells(4).Value = CDec(Me.dgPWproMeNoSN.Rows(f).Cells(4).Value) + CDec(Me.txtPWprop.Text)
                            d = "d"
                        End If
                    Next
                    If d = "d" Then
                    Else
                        r = tbl.NewRow
                        r("bar_code") = Me.txtPWprobarcode.Text.Trim
                        r("name_pro") = Me.txtPWproname.Text.Trim
                        r("price_buy") = Me.txtPWproprice.Text.Trim
                        r("unit") = Me.txtPWproUnit.Text.Trim
                        r("total") = Me.txtPWprop.Text.Trim
                        tbl.Rows.Add(r)
                    End If
                    For x = 0 To dgPWproMeNoSN.RowCount - 1
                        Me.dgPWproMeNoSN.Rows(x).Cells(5).Value = CDec(dgPWproMeNoSN.Rows(x).Cells(2).Value) * CDec(dgPWproMeNoSN.Rows(x).Cells(4).Value)
                    Next
                    Call sumDatagridview()
                    Call TextBoxClear()
                    Me.txtPWprobarcodeANDsn.Focus()
                ElseIf DrBarcode.HasRows Then
                    'Barcode
                    If Me.rbSbuy.Checked = True Then
                        strSQL = "SELECT bar_code,name_pro,price_buy,unit,check_stock,count_num FROM product WHERE bar_code='" & Me.txtPWprobarcodeANDsn.Text & "'"
                    ElseIf Me.rbSwholesale.Checked = True Then
                        strSQL = "SELECT bar_code,name_pro,price_wholesale,unit,check_stock,count_num FROM product WHERE bar_code='" & Me.txtPWprobarcodeANDsn.Text & "'"
                    ElseIf Me.rbStechnician.Checked = True Then
                        strSQL = "SELECT bar_code,name_pro,price_technician,unit,check_stock,count_num FROM product WHERE bar_code='" & Me.txtPWprobarcodeANDsn.Text & "'"
                    ElseIf Me.rbSloyal.Checked = True Then
                        strSQL = "SELECT bar_code,name_pro,price_loyal,unit,check_stock,count_num FROM product WHERE bar_code='" & Me.txtPWprobarcodeANDsn.Text & "'"
                    ElseIf Me.rbSmembers.Checked = True Then
                        strSQL = "SELECT bar_code,name_pro,price_members,unit,check_stock,count_num FROM product WHERE bar_code='" & Me.txtPWprobarcodeANDsn.Text & "'"
                    End If
                    Mainfrm.lblMainStatus.Text = strSQL
                    cmd.Prepare()
                    cmd.Parameters.AddWithValue("@1", Me.txtPWprobarcodeANDsn.Text)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    Dim checkstok As String
                    Dim countnum As String
                    With Dr
                        .Read()
                        Me.txtPWprobarcode.Text = .Item("bar_code")
                        Me.txtPWproname.Text = .Item("name_pro")
                        If Me.rbSbuy.Checked = True Then
                            Me.txtPWproprice.Text = .GetDecimal("price_buy")
                        ElseIf Me.rbSwholesale.Checked = True Then
                            Me.txtPWproprice.Text = .GetDecimal("price_wholesale")
                        ElseIf Me.rbStechnician.Checked = True Then
                            Me.txtPWproprice.Text = .GetDecimal("price_technician")
                        ElseIf Me.rbSloyal.Checked = True Then
                            Me.txtPWproprice.Text = .GetDecimal("price_loyal")
                        ElseIf Me.rbSmembers.Checked = True Then
                            Me.txtPWproprice.Text = .GetDecimal("price_members")
                        End If
                        
                        Me.txtPWproUnit.Text = .Item("unit")
                        Me.txtPWprop.Text = "1"
                        checkstok = .Item("check_stock")
                        countnum = .Item("count_num")
                    End With
                    Dr.Close()
                   'เตือนสินค้าใกล้หมด edit
                    If countnum <= 0 Then
                        MsgBox("สินค้าเหลือ " & countnum & " ชิ้น" & vbNewLine & "สินค้าในสต็อกหมด", MsgBoxStyle.Information, "สินค้าหมด")
                        Call TextBoxClear()
                        Exit Sub
                    End If

                    'ตรวจจำนวนในสต็อก
                    For NPro As Integer = 0 To Me.dgPWproMeNoSN.Rows.Count - 1
                        If Me.txtPWprobarcode.Text = Me.dgPWproMeNoSN.Rows(NPro).Cells("bar_code").Value Then
                            Dim ttAll As Decimal = CDec(Me.dgPWproMeNoSN.Rows(NPro).Cells("total").Value) + CDec(Me.txtPWprop.Text)
                            If countnum < ttAll Then
                                MsgBox("สินค้าในสต็อกมี " & countnum & " ชิ้น" & vbNewLine & "เบิกไปแล้ว " & _
                                        Me.dgPWproMeNoSN.Rows(NPro).Cells("total").Value & " ชิ้น" _
                                        & " บวกอีก " & Me.txtPWprop.Text & " ชิ้น " _
                                       & vbNewLine & "เบิกเกินจำนวนที่มีในสต็อก", MsgBoxStyle.Information, "เบิกเกินจำนวน")
                                Call TextBoxClear()
                                Exit Sub
                            End If
                        End If
                    Next
                    'ตรวจข้อมูลซ้ำ หากมีข้อมูลให้บวกจำนวนข้อมูล
                    Dim d As String = ""
                    Dim f As Integer = 0
                    For f = 0 To dgPWproMeNoSN.RowCount - 1
                        If Me.txtPWprobarcode.Text = Me.dgPWproMeNoSN.Rows(f).Cells(0).Value Then
                            Me.dgPWproMeNoSN.Rows(f).Cells(4).Value = CDec(Me.dgPWproMeNoSN.Rows(f).Cells(4).Value) + CDec(Me.txtPWprop.Text)
                            d = "d"
                        End If
                    Next
                    If d = "d" Then
                    Else
                        r = tbl.NewRow
                        r("bar_code") = Me.txtPWprobarcode.Text.Trim
                        r("name_pro") = Me.txtPWproname.Text.Trim
                        r("price_buy") = Me.txtPWproprice.Text.Trim
                        r("unit") = Me.txtPWproUnit.Text.Trim
                        r("total") = Me.txtPWprop.Text.Trim
                        tbl.Rows.Add(r)
                    End If
                    Call TextBoxClear()
                    Me.txtPWprobarcodeANDsn.Focus()
                    For x = 0 To dgPWproMeNoSN.RowCount - 1
                        Me.dgPWproMeNoSN.Rows(x).Cells(5).Value = CDec(dgPWproMeNoSN.Rows(x).Cells(2).Value) * CDec(dgPWproMeNoSN.Rows(x).Cells(4).Value)
                    Next
                    Call sumDatagridview()
                    Call cencer()
                    'Else
                End If
                Return
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                MsgBox("ไม่พบข้อมูล", MsgBoxStyle.Exclamation, "ข้อมูลสินค้า")
                Call TextBoxClear()
                Me.txtPWprobarcodeANDsn.Focus()
            End Try
        End If
    End Sub
    Private Sub dgPWProsearch_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgPWProsearch.MouseDoubleClick
        If Me.dgPWProsearch.SelectedRows.Count <= 0 Then
        Else
            Me.txtPWprobarcodeANDsn.Text = Me.dgPWProsearch.SelectedCells(1).Value
            Me.txtPWprobarcode.Text = Me.dgPWProsearch.SelectedCells(1).Value
            Me.txtPWproname.Text = Me.dgPWProsearch.SelectedCells(2).Value
            Me.txtPWproprice.Text = Me.dgPWProsearch.SelectedCells(3).Value
            Me.txtPWproUnit.Text = Me.dgPWProsearch.SelectedCells(4).Value
            Me.txtPWprop.Text = "1"
            Me.btnPWokTodg.Enabled = True
        End If
    End Sub

    Private Sub saveDGwsnTodatabase()
        'SN
        'บันทึกข้อมูลลงฐานข้อมูล หลักการโดยการนำข้อมูล sn จากตาราง 0 ของ ดาต้ากริต ไปเลือกข้อมูลในฐานข้อมูลเพื่อจะนำเอาชื่อและบาร์โค๊ต ฯลฯ ออกมาจากนั้น อ่านแล้วนำไปเก็บไว้ใน String 
        'จากนั้นอ่าน String แล้ว insert into อีกที จากนั้นก็ตามไปลบ serial_pro ทิ้ง จากนั้นก็ลูปจากต้นจนครบหมดทุกแถว
        Try
            For rALL As Integer = 0 To dgPWproMEwSN.RowCount - 1
                'Dim gbc As String = Me.dgPWproMEwSN.Rows(rALL).Cells(0).Value
                Mainfrm.lblMainStatus.Text = strSQL
                strSQL = "SELECT name_pro,bar_code,code_pro FROM product WHERE code_pro IN (SELECT code_pro FROM product_serial WHERE serial_pro='" & Me.dgPWproMEwSN.Rows(rALL).Cells(0).Value & "')"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dim name_pro As String
                Dim bar_code As String
                Dim code_pro As String
                With Dr
                    .Read()
                    name_pro = .Item("name_pro").ToString
                    bar_code = .Item("bar_code").ToString
                    code_pro = .Item("code_pro").ToString
                End With
                Mainfrm.lblMainStatus.Text = strSQL
                strSQL = "INSERT INTO sale_serial(sale_id,fix_id,customer_id,customer_name,name_pro,code_pro,bar_code,serial_pro,date_in,datetime_save,employee)" _
                          & "VALUES(@sale_id,@fix_id,@customer_id,@customer_name,@name_pro,@code_pro,@bar_code,@serial_pro,@date_in,@datetime_save,@employee)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.Add(New MySqlParameter("@sale_id", Me.txtPWsaleID.Text))
                    .Parameters.Add(New MySqlParameter("@fix_id", Me.txtPWrepairID.Text))
                    .Parameters.Add(New MySqlParameter("@customer_id", Me.txtPWcusID.Text))
                    .Parameters.Add(New MySqlParameter("@customer_name", Me.txtPWcusName.Text))
                    .Parameters.Add(New MySqlParameter("@name_pro", name_pro))
                    .Parameters.Add(New MySqlParameter("@code_pro", code_pro))
                    .Parameters.Add(New MySqlParameter("@bar_code", bar_code))
                    .Parameters.Add(New MySqlParameter("@serial_pro", Me.dgPWproMEwSN.Rows(rALL).Cells(0).Value))
                    .Parameters.Add(New MySqlParameter("@date_in", Me.txtPWdateNow.Text))
                    .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                    .Parameters.Add(New MySqlParameter("@employee", LoginFrm.txtLoginUsername.Text))
                    Call open_connection()
                    .ExecuteNonQuery()
                End With
                'ลบ sn 
                Mainfrm.lblMainStatus.Text = strSQL
                strSQL = "delete from product_serial where serial_pro='" & Me.dgPWproMEwSN.Rows(rALL).Cells(0).Value & "'" & _
                                                         " AND name_pro='" & Me.dgPWproMEwSN.Rows(rALL).Cells(1).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                Dr.Close()
            Next
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            'MsgBox("sn " & ex.Message)
        End Try
    End Sub
    Private Sub saveDGNosnTodatabase()
        'barcode
        'บันทึกข้อมูลลงฐานข้อมูล หลักการโดยการนำข้อมูล sn จากตาราง 0 ของ ดาต้ากริต ไปเลือกข้อมูลในฐานข้อมูลเพื่อจะนำเอาชื่อและบาร์โค๊ต ฯลฯ ออกมาจากนั้น อ่านแล้วนำไปเก็บไว้ใน String 
        'จากนั้นอ่าน String แล้ว insert into อีกที จากนั้นก็ตามไปลบ จำนวนสินค้า ออกจาก product จากนั้นก็ลูปจากต้นจนครบหมดทุกแถว
        Try
            For rALL As Integer = 0 To dgPWproMeNoSN.RowCount - 1
                Dim gbc As String = dgPWproMeNoSN.Rows(rALL).Cells(0).Value
                If Me.rbSbuy.Checked = True Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,price_cost,price_buy,unit,type,count_num FROM product WHERE bar_code='" & gbc & "'"
                ElseIf Me.rbSwholesale.Checked = True Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,price_cost,price_wholesale,unit,type,count_num FROM product WHERE bar_code='" & gbc & "'"
                ElseIf Me.rbStechnician.Checked = True Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,price_cost,price_technician,unit,type,count_num FROM product WHERE bar_code='" & gbc & "'"
                ElseIf Me.rbSloyal.Checked = True Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,price_cost,price_loyal,unit,type,count_num FROM product WHERE bar_code='" & gbc & "'"
                ElseIf Me.rbSmembers.Checked = True Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,price_cost,price_members,unit,type,count_num FROM product WHERE bar_code='" & gbc & "'"
                End If
                Mainfrm.lblMainStatus.Text = strSQL
                'strSQL = "SELECT code_pro,bar_code,name_pro,price_cost,price_buy,unit,type,count_num FROM product WHERE bar_code='" & gbc & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dim code_pro, bar_code, name_pro, unit, Type As String
                Dim price_cost, price_buy, count_num As Decimal
                With Dr
                    .Read()
                    code_pro = .Item("code_pro")
                    bar_code = .Item("bar_code")
                    name_pro = .Item("name_pro")
                    price_cost = .GetDecimal("price_cost")
                    If Me.rbSbuy.Checked = True Then
                        price_buy = .GetDecimal("price_buy")
                    ElseIf Me.rbSwholesale.Checked = True Then
                        price_buy = .GetDecimal("price_wholesale")
                    ElseIf Me.rbStechnician.Checked = True Then
                        price_buy = .GetDecimal("price_technician")
                    ElseIf Me.rbSloyal.Checked = True Then
                        price_buy = .GetDecimal("price_loyal")
                    ElseIf Me.rbSmembers.Checked = True Then
                        price_buy = .GetDecimal("price_members")
                    End If
                    
                    unit = .Item("unit")
                    Type = .Item("type")
                    count_num = .Item("count_num")
                End With
                Mainfrm.lblMainStatus.Text = strSQL
                strSQL = "insert into sale_barcode(sale_id,fix_id,customer_id,customer_name,customer_tel,code_pro,bar_code,name_pro,total_pro,price_cost,price_buy,unit,type,date_in,datetime_save,employee) " _
                        & " values(@sale_id,@fix_id,@customer_id,@customer_name,@customer_tel,@code_pro,@bar_code,@name_pro,@total_pro,@price_cost,@price_buy,@unit,@type,@date_in,@datetime_save,@employee)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.Add(New MySqlParameter("@sale_id", Me.txtPWsaleID.Text))
                    .Parameters.Add(New MySqlParameter("@fix_id", Me.txtPWrepairID.Text))
                    .Parameters.Add(New MySqlParameter("@customer_id", Me.txtPWcusID.Text))
                    .Parameters.Add(New MySqlParameter("@customer_name", Me.txtPWcusName.Text))
                    .Parameters.Add(New MySqlParameter("@customer_tel", Me.txtPWcusTel.Text))
                    .Parameters.Add(New MySqlParameter("@code_pro", code_pro))
                    .Parameters.Add(New MySqlParameter("@bar_code", bar_code))
                    .Parameters.Add(New MySqlParameter("@name_pro", name_pro))
                    .Parameters.Add(New MySqlParameter("@total_pro", Me.dgPWproMeNoSN.Rows(rALL).Cells(4).Value))
                    .Parameters.Add(New MySqlParameter("@price_cost", price_cost))
                    .Parameters.Add(New MySqlParameter("@price_buy", Me.dgPWproMeNoSN.Rows(rALL).Cells(2).Value)) 'old = price_buy
                    .Parameters.Add(New MySqlParameter("@unit", unit))
                    .Parameters.Add(New MySqlParameter("@type", Type))
                    .Parameters.Add(New MySqlParameter("@date_in", Me.txtPWdateNow.Text))
                    .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                    .Parameters.Add(New MySqlParameter("@employee", LoginFrm.txtLoginUsername.Text))
                    Call open_connection()
                    .ExecuteNonQuery()
                End With
                'อัพเดทจำนวน 
                Dim DelNum As Decimal = dgPWproMeNoSN.Rows(rALL).Cells(4).Value
                Dim totalDel As Decimal
                totalDel = count_num - DelNum
                Mainfrm.lblMainStatus.Text = strSQL
                strSQL = "UPDATE product SET count_num='" & totalDel & "' WHERE bar_code='" & gbc.ToString & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                Dr.Close()
            Next
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            'MsgBox("barcode " & ex.Message)
        End Try
    End Sub
    Private Sub saveSaleAll()
        Try
            'sale
            Mainfrm.lblMainStatus.Text = strSQL
            strSQL = "INSERT INTO sale(sale_id,fix_id,customer_id,customer_name,total_all,date_in,datetime_save,cash_status,date_edit,employee) " _
                       & " VALUES(@sale_id,@fix_id,@customer_id,@customer_name,@total_all,@date_in,@datetime_save,@cash_status,@date_edit,@employee)"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            With cmd
                .Parameters.Add(New MySqlParameter("@sale_id", Me.txtPWsaleID.Text))
                .Parameters.Add(New MySqlParameter("@fix_id", Me.txtPWrepairID.Text))
                .Parameters.Add(New MySqlParameter("@customer_id", Me.txtPWcusID.Text))
                .Parameters.Add(New MySqlParameter("@customer_name", Me.txtPWcusName.Text))
                .Parameters.Add(New MySqlParameter("@total_all", Me.lblPWgetTotalPrice.Text))
                .Parameters.Add(New MySqlParameter("@date_in", Me.txtPWdateNow.Text))
                .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                .Parameters.Add(New MySqlParameter("@cash_status", "ยังไม่ชำระเงิน"))
                .Parameters.Add(New MySqlParameter("@date_edit", Me.txtPWdateNow.Text))
                .Parameters.Add(New MySqlParameter("@employee", LoginFrm.txtLoginUsername.Text))
                Call open_connection()
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            'MsgBox("sale " & ex.Message)
        End Try
    End Sub
    Private Sub saveSale_id()
        Try
            'sale_id
            Mainfrm.lblMainStatus.Text = strSQL
            strSQL = "INSERT INTO sale_id(sale_id,fix_id,customer_id,customer_name,date_in,datetime_save) " _
                           & " VALUES(@sale_id,@fix_id,@customer_id,@customer_name,@date_in,@datetime_save)"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            With cmd
                .Parameters.Add(New MySqlParameter("@sale_id", Me.txtPWsaleID.Text))
                .Parameters.Add(New MySqlParameter("@fix_id", Me.txtPWrepairID.Text))
                .Parameters.Add(New MySqlParameter("@customer_id", Me.txtPWcusID.Text))
                .Parameters.Add(New MySqlParameter("@customer_name", Me.txtPWcusName.Text))
                .Parameters.Add(New MySqlParameter("@date_in", Me.txtPWdateNow.Text))
                .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                Call open_connection()
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            'MsgBox("sale " & ex.Message)
        End Try
    End Sub
    Private Sub btnPWsave_Click(sender As Object, e As EventArgs) Handles btnPWsave.Click
        Dim i As Integer = dgPWproMeNoSN.Rows.Count
        If i <= 0 Then
            MsgBox("ไม่มีข้อมูล กรุณาป้อนข้อมูล บาร์โค๊ตหรือ SN ก่อน", MsgBoxStyle.Exclamation, "แจ้งเตือน")
            Exit Sub
        Else
            If MessageBox.Show("คุณแน่ใจว่าจะบันทึกข้อมูลนี้", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Call saveDGwsnTodatabase()
                Call saveDGNosnTodatabase()
                Call saveSaleAll()
                Call saveSale_id()
                tbl.Rows.Clear()
                tbl1.Rows.Clear()
                tbl2.Rows.Clear()
                Call cencer()
                MsgBox("บันทึกข้อมูลเรียบร้อย", MsgBoxStyle.Information, "บันทึกข้อมูล")
                Me.Close()
            Else
                Mainfrm.lblMainStatus.Text = "การบันทึกข้อมูลถูกยกเลิก"
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnPWdel_Click(sender As Object, e As EventArgs) Handles btnPWdel.Click
        'ลบรายการสินค้าทั้งหมด
        tbl.Clear()
        tbl1.Clear()
        tbl2.Clear()
        Me.dgPWproMeNoSN.Refresh()
        Me.dgPWproMEwSN.Refresh()
        Me.dgPWProsearch.Refresh()
        Call sumDatagridview()
        Call cencer()
    End Sub

    Private Sub dgPWproMeNoSN_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgPWproMeNoSN.CellEndEdit
        'For x = 0 To dgPWproMeNoSN.RowCount - 1
        '    Me.dgPWproMeNoSN.Rows(x).Cells(5).Value = CDec(dgPWproMeNoSN.Rows(x).Cells(2).Value) * CDec(dgPWproMeNoSN.Rows(x).Cells(4).Value)
        'Next
        Try
            Dim ind As Integer = Me.dgPWproMeNoSN.CurrentRow.Index
            If IsDBNull(Me.dgPWproMeNoSN.Rows(ind).Cells(2).Value) Then
                Me.dgPWproMeNoSN.Rows(ind).Cells(2).Value = CSelect
            End If
            strSQL = "SELECT price_cost FROM product WHERE bar_code='" & Me.dgPWproMeNoSN.Rows(ind).Cells(0).Value & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                Dim PC As Decimal = Dr.GetDecimal("price_cost")
                Dim sumPC As Decimal = CDec(Me.dgPWproMeNoSN.Rows(ind).Cells(2).Value)
                If sumPC < PC Then
                    MsgBox("คุณขายขาดทุน", MsgBoxStyle.Exclamation, "ขาดทุน")
                    Me.dgPWproMeNoSN.Rows(ind).Cells(2).Value = CSelect
                    CSelect = Nothing
                Else
                    Me.dgPWproMeNoSN.Rows(ind).Cells(5).Value = CDec(Me.dgPWproMeNoSN.Rows(ind).Cells(2).Value) * _
                        CDec(Me.dgPWproMeNoSN.Rows(ind).Cells(4).Value)
                End If
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Call cencer()
        Call sumDatagridview()
    End Sub
    Private CSelect As Decimal
    Private Sub dgPWproMeNoSN_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgPWproMeNoSN.CellMouseDoubleClick
        Dim ind As Integer = Me.dgPWproMeNoSN.CurrentRow.Index
        CSelect = Me.dgPWproMeNoSN.Rows(ind).Cells(2).Value
    End Sub
    Public qid As String
    Private Sub btnPWbid_Click(sender As Object, e As EventArgs) Handles btnPWbid.Click
        Try
            dt = New DataTable
            Mainfrm.lblMainStatus.Text = strSQL
            strSQL = "SELECT ver_quotation FROM ver_detail"
            dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
            Call open_connection()
            dtAdapter.Fill(dt)
            Dim nid As String = dt.Rows(0).Item("ver_quotation")
            Mainfrm.lblMainStatus.Text = strSQL
            strSQL = "SELECT Max(id) as id FROM quotation_id"
            dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                qid = nid & Now.ToString("yyMMddHHmm") & "00001"
            Else
                Dim newID As Integer = CInt(Dr.Item("id"))
                newID += 1
                qid = nid & Now.ToString("yyMMddHHmm") & newID.ToString("00000")
            End If
            'save quotation id
            Mainfrm.lblMainStatus.Text = strSQL
            strSQL = "INSERT INTO quotation_id(q_id)" _
                        & " VALUES(@qid)"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            cmd.Parameters.Add(New MySqlParameter("@qid", qid))
            Call open_connection()
            cmd.ExecuteNonQuery()
            'save quotation
            For rALL As Integer = 0 To dgPWproMeNoSN.RowCount - 1
                'get code_pro
                Dim codep As String
                Mainfrm.lblMainStatus.Text = strSQL
                strSQL = "SELECT code_pro FROM product WHERE bar_code='" & Me.dgPWproMeNoSN.Rows(rALL).Cells(0).Value & "'"
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                codep = Dr("code_pro")
                Mainfrm.lblMainStatus.Text = strSQL
                strSQL = "INSERT INTO quotation(quotation_id,customer_id,code_pro,name_pro,unit,total_pro,price_buy)" _
                        & " VALUES(@quotation_id,@customer_id,@code_pro,@name_pro,@unit,@total_pro,@price_buy)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.Add(New MySqlParameter("@quotation_id", qid))
                    .Parameters.Add(New MySqlParameter("@customer_id", Me.txtPWcusID.Text))
                    .Parameters.Add(New MySqlParameter("@code_pro", codep))
                    .Parameters.Add(New MySqlParameter("@name_pro", Me.dgPWproMeNoSN.Rows(rALL).Cells(1).Value))
                    .Parameters.Add(New MySqlParameter("@unit", Me.dgPWproMeNoSN.Rows(rALL).Cells(3).Value))
                    .Parameters.Add(New MySqlParameter("@total_pro", Me.dgPWproMeNoSN.Rows(rALL).Cells(4).Value))
                    .Parameters.Add(New MySqlParameter("@price_buy", Me.dgPWproMeNoSN.Rows(rALL).Cells(2).Value))
                    Call open_connection()
                    .ExecuteNonQuery()
                End With
                Mainfrm.lblMainStatus.Text = strSQL
                strSQL = "UPDATE quotation SET picture = (SELECT picture FROM product WHERE code_pro='" & codep & "') WHERE code_pro='" & codep & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            Next
            Mainfrm.lblMainStatus.Text = strSQL
            strSQL = "UPDATE quotation SET multiply=CAST(price_buy AS DECIMAL(20,2)) * CAST(total_pro AS DECIMAL) WHERE quotation_id='" & qid & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            Call cencer()
            MsgBox("บันทึกใบเสนอราคาแล้ว กรุณารอสักครู่ จะมีใบเสนอราคาขึ้นมา", MsgBoxStyle.Information, "แจ้งเตือน")
            QuotationReportPrintFrm.Show()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub txtPWcusID_TextChanged(sender As Object, e As EventArgs) Handles txtPWcusID.TextChanged
        'ดึงข้อมูลระดับราคา
        Try
            strSQL = "SELECT price_level FROM customer WHERE customer_id='" & Me.txtPWcusID.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.Read = True Then
                If Dr(0) = "1" Then
                    Me.rbSbuy.Checked = CheckState.Checked
                ElseIf Dr(0) = "2" Then
                    Me.rbSwholesale.Checked = CheckState.Checked
                ElseIf Dr(0) = "3" Then
                    Me.rbStechnician.Checked = CheckState.Checked
                ElseIf Dr(0) = "4" Then
                    Me.rbSloyal.Checked = CheckState.Checked
                ElseIf Dr(0) = "5" Then
                    Me.rbSmembers.Checked = CheckState.Checked
                End If
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub dgPWproMeNoSN_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgPWproMeNoSN.CellMouseClick
        If Me.dgPWproMeNoSN.Rows.Count = 0 Then
        Else
            If e.Button = MouseButtons.Right Then
                Me.dgPWproMeNoSN.Rows(e.RowIndex).Selected = True
                Me.dgPWproMeNoSN.CurrentCell = dgPWproMeNoSN.Rows(e.RowIndex).Cells(1)
                Me.mnuCell.Show(dgPWproMeNoSN, e.Location)
                Me.mnuCell.Show(Cursor.Position)
            End If
        End If
    End Sub



    Private Sub mnuCell_Click(sender As Object, e As EventArgs) Handles mnuCell.Click
        For checkSN As Integer = 0 To Me.dgPWproMEwSN.Rows.Count - 1
            If Me.dgPWproMeNoSN.SelectedCells.Item(1).Value = Me.dgPWproMEwSN.Rows(checkSN).Cells(1).Value Then
                MsgBox("มีรายการสินค้าที่เป็น SN กรุณาลบรายการสินค้าที่เป็น SN ออกก่อน", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Exit Sub
            End If
        Next

        For tto As Integer = Me.dgPWproMeNoSN.SelectedRows.Count - 1 To 0 Step -1
            Me.dgPWproMeNoSN.Rows.Remove(Me.dgPWproMeNoSN.SelectedRows(tto))
        Next
        Call cencer()
        Call sumDatagridview()
    End Sub

    Private Sub dgPWproMEwSN_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgPWproMEwSN.CellMouseClick
        If Me.dgPWproMEwSN.Rows.Count = 0 Then
        Else
            If e.Button = MouseButtons.Right Then
                Me.dgPWproMEwSN.Rows(e.RowIndex).Selected = True
                Me.dgPWproMEwSN.CurrentCell = dgPWproMEwSN.Rows(e.RowIndex).Cells(0)
                Me.mnuCell1.Show(dgPWproMEwSN, e.Location)
                Me.mnuCell1.Show(Cursor.Position)
            End If
        End If
    End Sub

    Private Sub mnuCell1_Click(sender As Object, e As EventArgs) Handles mnuCell1.Click
        Try
            For o As Integer = 0 To Me.dgPWproMeNoSN.Rows.Count - 1
                If Me.dgPWproMEwSN.SelectedCells.Item(1).Value = Me.dgPWproMeNoSN.Rows(o).Cells(1).Value Then
                    If Me.dgPWproMeNoSN.Rows(o).Cells(4).Value = 1 Then
                        Me.dgPWproMeNoSN.Rows.Remove(Me.dgPWproMeNoSN.Rows(o))
                    ElseIf Me.dgPWproMeNoSN.Rows(o).Cells(4).Value > 1 Then
                        Me.dgPWproMeNoSN.Rows(o).Cells(4).Value = CDec(Me.dgPWproMeNoSN.Rows(o).Cells(4).Value) - 1
                    End If
                    Dim a As Integer = Me.dgPWproMEwSN.SelectedRows.Count - 1
                    Me.dgPWproMEwSN.Rows.Remove(Me.dgPWproMEwSN.SelectedRows(a))
                End If

                For x = 0 To dgPWproMeNoSN.RowCount - 1
                    Me.dgPWproMeNoSN.Rows(x).Cells(5).Value = CDec(Me.dgPWproMeNoSN.Rows(x).Cells(2).Value) * CDec(Me.dgPWproMeNoSN.Rows(x).Cells(4).Value)
                Next
                Call sumDatagridview()
            Next
            Mainfrm.lblMainStatus.Text = "ลบ SN แล้ว"
            Call cencer()
            Call sumDatagridview()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub cencer()
        If Me.dgPWproMeNoSN.Rows.Count = 0 And Me.dgPWproMEwSN.Rows.Count = 0 Then
            Me.btnPWclose.Text = "ปิด"
        Else
            Me.btnPWclose.Text = "ยกเลิก"
        End If
    End Sub

    Private Sub txtPWproprice_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPWproprice.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtPWproprice.Text = Nothing Then
                Me.txtPWproprice.Focus()
            Else
                Me.txtPWprop.SelectAll()
                Me.txtPWprop.Focus()
            End If
        End If
    End Sub
    Private Sub txtPWproprice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPWproprice.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                Mainfrm.lblMainStatus.Text = "เฉพาะตัวเลขเท่านั้น"
                Me.txtPWproprice.SelectAll()
                Me.txtPWproprice.Focus()
        End Select
    End Sub

    Private Sub txtPWprop_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPWprop.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtPWprop.Text = Nothing Then
                Me.txtPWprop.Focus()
            Else
                Me.btnPWokTodg.Focus()
            End If
        End If
    End Sub

    Private Sub txtPWprop_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPWprop.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                Mainfrm.lblMainStatus.Text = "เฉพาะตัวเลขเท่านั้น"
                Me.txtPWprop.SelectAll()
                Me.txtPWprop.Focus()
        End Select
    End Sub

    Private Sub dgPWproMeNoSN_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgPWproMeNoSN.RowsAdded
        Call cencer()
    End Sub

    Private Sub dgPWproMeNoSN_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgPWproMeNoSN.RowsRemoved
        Call cencer()
    End Sub

    Private Sub dgPWproMEwSN_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgPWproMEwSN.RowsAdded
        Call cencer()
    End Sub

    Private Sub dgPWproMEwSN_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgPWproMEwSN.RowsRemoved
        Call cencer()
    End Sub
End Class