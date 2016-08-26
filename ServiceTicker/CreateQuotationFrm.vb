Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class CreateQuotationFrm
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
        Me.lblPWgetTotalPrice.Text = totalx.ToString("N2")
        Me.lblPWtotalXYZ.Text = "รายการ " & totalz.ToString & " | ปริมาณ " & totaly.ToString
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
            strSQL = "SELECT ver_quotation FROM ver_detail"
            Mainfrm.lblMainStatus.Text = strSQL
            dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Dim nid As String = Dr.Item("ver_quotation")
            Mainfrm.lblMainStatus.Text = strSQL
            strSQL = "SELECT Max(id) as id FROM quotation_id"
            dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                qid = nid & Now.ToString("yyMMddHHmm") & "00001"
                Me.txtPWsaleID.Text = qid
            Else
                Dim newID As Integer = CInt(Dr.Item("id"))
                newID += 1
                qid = nid & Now.ToString("yyMMddHHmm") & newID.ToString("00000")
                Me.txtPWsaleID.Text = qid
            End If
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

    Private Sub getdatacombobox_prosection()
        Try
            Mainfrm.lblMainStatus.Text = strSQL
            strSQL = "select prosection_name from product_section"
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
        Me.dgPWproMeNoSN.Rows.Clear()
        Me.dgPWProsearch.Rows.Clear()
        Call TextBoxClear()
        Call AutoNumberNo()
        Call getdatacombobox_prosection()
        Call dateNow()
        Me.txtPWprobarcodeANDsn.Focus()
        Me.btnPWokTodg.Enabled = False
    End Sub
    Private Sub txtPWproSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPWproSearch.KeyDown
        On Error Resume Next
        If e.KeyCode = Keys.Enter Then
            Call search_record()
        End If
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
    
    Private Sub btnPWokTodg_Click(sender As Object, e As EventArgs) Handles btnPWokTodg.Click
        If Me.txtPWprobarcodeANDsn.Text = "" Then
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
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Me.btnPWokTodg.Enabled = False
    End Sub
    Private Sub cbbPWgetProSection_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbPWgetProSection.SelectedValueChanged
        Call search_recordfromcbbPWsection()
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
                    
                    Mainfrm.lblMainStatus.Text = strSQL
                    strSQL = "SELECT bar_code,name_pro,price_buy,unit,check_stock,count_num FROM product WHERE code_pro IN (SELECT code_pro FROM product_serial WHERE serial_pro=@1)"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    cmd.Prepare()
                    cmd.Parameters.AddWithValue("@1", Me.txtPWprobarcodeANDsn.Text)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    
                    With Dr
                        .Read()

                        Me.txtPWprobarcode.Text = .Item("bar_code")
                        Me.txtPWproname.Text = .Item("name_pro")
                        Me.txtPWproprice.Text = .GetDecimal("price_buy")
                        Me.txtPWproUnit.Text = .Item("unit")
                        Me.txtPWprop.Text = "1"
                       
                    End With
                    Dr.Close()
                   
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
                    Mainfrm.lblMainStatus.Text = strSQL
                    strSQL = "SELECT bar_code,name_pro,price_buy,unit,check_stock,count_num FROM product WHERE bar_code='" & Me.txtPWprobarcodeANDsn.Text & "'"
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
                        Me.txtPWproprice.Text = .Item("price_buy")
                        Me.txtPWproUnit.Text = .Item("unit")
                        Me.txtPWprop.Text = "1"
                        checkstok = .Item("check_stock")
                        countnum = .Item("count_num")
                    End With
                    Dr.Close()
                    
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
    Private Sub btnPWchangCus_Click(sender As Object, e As EventArgs) Handles btnPWchangCus.Click
        CQsearchCustomerFrm.MdiParent = Mainfrm
        CQsearchCustomerFrm.Show()
    End Sub
    

    Private Sub btnPWdel_Click(sender As Object, e As EventArgs) Handles btnPWdel.Click
        'del barcode
        Try
           
            Dim oop As Integer
            If Me.dgPWproMeNoSN.Rows(oop).Cells(4).Value = 1 Then
                dgPWproMeNoSN.Rows.Remove(Me.dgPWproMeNoSN.Rows(oop))
            ElseIf Me.dgPWproMeNoSN.Rows(oop).Cells(4).Value > 1 Then
                Me.dgPWproMeNoSN.Rows(oop).Cells(4).Value = CDec(Me.dgPWproMeNoSN.Rows(oop).Cells(4).Value) - 1
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MsgBox(dgPWproMeNoSN.SelectedCells.Item(5).Value)
    End Sub

    Private Sub dgPWproMeNoSN_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgPWproMeNoSN.CellEndEdit
        For x = 0 To dgPWproMeNoSN.RowCount - 1
            Me.dgPWproMeNoSN.Rows(x).Cells(5).Value = CDec(dgPWproMeNoSN.Rows(x).Cells(2).Value) * CDec(dgPWproMeNoSN.Rows(x).Cells(4).Value)
        Next
        Call sumDatagridview()
    End Sub
    Friend qid As String
    Private Sub btnPWbid_Click(sender As Object, e As EventArgs) Handles btnPWbid.Click
        Try
            If Me.txtPWcusID.Text = "" Then
                MsgBox("ยังไม่ได้เลือกรายชื่อลูกค้า", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Me.txtPWcusID.BackColor = Color.OrangeRed
                Me.txtPWcusName.BackColor = Color.OrangeRed
                Me.txtPWcusTel.BackColor = Color.OrangeRed
                Exit Sub
            Else
                dt = New DataTable
                Mainfrm.lblMainStatus.Text = strSQL

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
                MsgBox("บันทึกใบเสนอราคาแล้ว กรุณารอสักครู่ จะมีใบเสนอราคาขึ้นมา", MsgBoxStyle.Information, "แจ้งเตือน")
                If rbCQpic.Checked Then
                    QuotationReportPrintFrm.MdiParent = Mainfrm
                    QuotationReportPrintFrm.Show()
                    Me.Close()
                ElseIf rbCQnoPic.Checked Then
                    QuotationNoPicReportPrintFrm.MdiParent = Mainfrm
                    QuotationNoPicReportPrintFrm.Show()
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CreateQuotationFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call startfrm()
        Call addtodgNoSN()
        'Call addtodgwSN()
        Me.Icon = Mainfrm.Icon
    End Sub

    Private Sub btnCQsearceQuotation_Click(sender As Object, e As EventArgs) Handles btnCQsearceQuotation.Click
        ViewQuotationFrm.MdiParent = Mainfrm
        ViewQuotationFrm.Show()
    End Sub

    Private Sub btnPWclose_Click(sender As Object, e As EventArgs) Handles btnPWclose.Click
        Me.Close()
    End Sub

End Class