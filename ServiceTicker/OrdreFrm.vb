Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Data.SQLite
Public Class OrdreFrm
    Public tbl, tbl1, tbl2 As New DataTable
    Public r, r1 As DataRow

   
    Private Sub AutoNumberNo()
        Try
            dt = New DataTable
            strSQL = "SELECT ver_order FROM ver_detail"
            Mainfrm.lblMainStatus.Text = strSQL
            dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
            Call open_connection()
            dtAdapter.Fill(dt)
            Dim ORid As String = dt.Rows(0).Item("ver_order")
            Mainfrm.lblMainStatus.Text = "SELECT Max(id) as IDr"
            strSQL = "SELECT Max(id) as ID FROM buy_id"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                Me.lblORid.Text = ORid & Now.ToString("yyMMddHHmm") & "00001"
            Else
                Dim newID As Integer = CInt(Dr.Item("id"))
                newID += 1
                Me.lblORid.Text = ORid & Now.ToString("yyMMddHHmm") & newID.ToString("00000")
            End If
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub getDtatToCbbORcompanySelect()
        Try
            Me.cbbORcompanySelect.Items.Clear()
            strSQL = "SELECT * from sale_company"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand
            cmd.CommandText = strSQL
            cmd.Connection = ConnectionDB
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.cbbORcompanySelect.Items.Add(Dr("sale_company_name"))
            End While
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub getDtatToCbbORcompany()
        Try
            strSQL = "SELECT sale_company_id,sale_company_address,sale_company_tel FROM sale_company WHERE sale_company_name='" & Me.cbbORcompanySelect.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand
            cmd.CommandText = strSQL
            cmd.Connection = ConnectionDB
            Call open_connection()
            Dr = cmd.ExecuteReader
            With Dr
                .Read()
                Me.txtORcompanyID.Text = .Item("sale_company_id")
                Me.txtORcompanyAddress.Text = .Item("sale_company_address")
                Me.txtORcompanyTel.Text = .Item("sale_company_tel")
            End With
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub addtodgOR()
        tbl.NewRow()
        tbl.Columns.Add(New DataColumn("bar_code", GetType(System.String)))
        tbl.Columns.Add(New DataColumn("name_pro", GetType(System.String)))
        tbl.Columns.Add(New DataColumn("price_cost", GetType(System.Decimal)))
        tbl.Columns.Add(New DataColumn("price_buy", GetType(System.Decimal)))
        tbl.Columns.Add(New DataColumn("unit", GetType(System.String)))
        tbl.Columns.Add(New DataColumn("count_num", GetType(System.String)))
        tbl.Columns.Add(New DataColumn("total", GetType(System.Decimal)))
        dgOR.DataSource = tbl
        With dgOR
            .Columns(0).HeaderText = "บาร์โค๊ต"
            .Columns(1).HeaderText = "ชื่อสินค้า"
            .Columns(2).HeaderText = "ราคาทุน"
            .Columns(3).HeaderText = "ราคาขาย"
            .Columns(4).HeaderText = "หน่วยนับ"
            .Columns(5).HeaderText = "จำนวน"
            .Columns(6).HeaderText = "รวมราคาทุน"

            .Columns(0).Width = 90
            .Columns(1).Width = 270
            .Columns(2).Width = 70
            .Columns(3).Width = 70
            .Columns(4).Width = 100
            .Columns(5).Width = 70
            .Columns(6).Width = 80

            .Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(0).ReadOnly = True
            .Columns(1).ReadOnly = True
            .Columns(2).ReadOnly = False
            .Columns(3).ReadOnly = False
            .Columns(4).ReadOnly = True
            .Columns(5).ReadOnly = False
            .Columns(6).ReadOnly = True
            r = tbl.NewRow
        End With
    End Sub

    Private Sub cbbORcompanySelect_Click(sender As Object, e As EventArgs) Handles cbbORcompanySelect.Click
        Call getDtatToCbbORcompanySelect()
    End Sub
    Private Sub startfrm()
        Call AutoNumberNo()
    End Sub
    Dim c As Integer
    Private Sub OrdreFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.dgOR.Rows.Count <> 0 Then
            Dim result = MessageBox.Show("มีข้อมูลยังไม่ถูกบันทึก ต้องการจะบันทึกข้อมูลหรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If result = DialogResult.Cancel Then
                e.Cancel = True
            ElseIf result = DialogResult.No Then
                e.Cancel = False
            ElseIf result = DialogResult.Yes Then
                e.Cancel = True
                c = 1
                Call savedgORToDatabase()
            End If
        End If
    End Sub
    Private Sub OrdreFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call startfrm()
        Call addtodgOR()
        Me.Icon = Mainfrm.Icon
    End Sub

    Private Sub cbbORcompanySelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbORcompanySelect.SelectedIndexChanged
        Call getDtatToCbbORcompany()
    End Sub

    Private Sub txtORcompanyID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtORcompanyID.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Me.cbbORcompanySelect.Items.Clear()
                strSQL = "SELECT sale_company_name,sale_company_address,sale_company_tel FROM sale_company WHERE sale_company_id='" & Me.txtORcompanyID.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand
                cmd.CommandText = strSQL
                cmd.Connection = ConnectionDB
                Call open_connection()
                Dr = cmd.ExecuteReader
                With Dr
                    .Read()
                    Me.cbbORcompanySelect.Text = .Item("sale_company_name")
                    Me.txtORcompanyAddress.Text = .Item("sale_company_address")
                    Me.txtORcompanyTel.Text = .Item("sale_company_tel")
                End With
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                MsgBox("ไม่พบข้อมูลรหัสบริษัท " & Me.txtORcompanyID.Text, MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Me.txtORcompanyID.Clear()
                Me.txtORcompanyAddress.Clear()
                Me.txtORcompanyTel.Clear()
                Me.cbbORcompanySelect.Text = ""
            End Try
        End If
    End Sub
 
    Private Sub getProduct()
        'ตรวจบาร์โค๊ตซ้ำ
        For duplicate As Integer = 0 To dgOR.Rows.Count - 1
            If Strings.Trim(Me.txtORbarcodePro.Text) = Strings.Trim(Me.dgOR.Item(0, duplicate).Value) Then
                If MessageBox.Show("บาร์โค๊ต " & Me.txtORbarcodePro.Text & " นี้มีอยู่แล้ว", "ข้อมูลซ้ำ", MessageBoxButtons.OK, MessageBoxIcon.Information) Then
                    Me.txtORbarcodePro.Clear()
                    Me.txtORbarcodePro.Focus()
                    Exit Sub
                End If
            End If

        Next
        'ค้นหาข้อมูล อัดลง ดาต้ากริต
        Try
            strSQL = "SELECT bar_code,name_pro,price_cost,price_buy,unit FROM product WHERE bar_code=@1"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            cmd.Prepare()
            cmd.Parameters.AddWithValue("@1", Me.txtORbarcodePro.Text)
            Call open_connection()
            Dr = cmd.ExecuteReader
            With Dr
                .Read()
                r = tbl.NewRow
                r("bar_code") = .Item("bar_code")
                r("name_pro") = .Item("name_pro")
                r("price_cost") = .GetDecimal("price_cost")
                r("price_buy") = .GetDecimal("price_buy")
                r("unit") = .Item("unit")
                r("count_num") = "1"
                r("total") = .GetDecimal("price_cost")
                tbl.Rows.Add(r)
            End With
            Dr.Close()
            Call sumTdg()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            MessageBox.Show("ไม่พบข้อมูล " & Me.txtORbarcodePro.Text, "ไม่พบข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
        Me.txtORbarcodePro.Clear()
        Me.txtORbarcodePro.Focus()
    End Sub

    Private Sub sumTdg()
        'หาผลรวมยอดสั่งซื้อทั้งหมดให้มาแสดงที่ Me.txtORsumMoney.Text
        Dim sum As Decimal = 0
        For i = 0 To dgOR.RowCount - 1
            sum += CDec(dgOR.Rows(i).Cells("total").Value)
            Me.txtORsumMoney.Text = sum.ToString("N2")
        Next
    End Sub
    Private Sub txtORbarcodePro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtORbarcodePro.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call getProduct()
        End If
    End Sub
    Friend Sub sum_dgOR()
        Try
            For su As Integer = 0 To Me.dgOR.Rows.Count - 1
                Dim iCell1 As Decimal
                Dim icell2 As Decimal
                Dim icellResult As Decimal
                iCell1 = Me.dgOR.Rows(su).Cells(2).Value
                icell2 = Me.dgOR.Rows(su).Cells(5).Value
                icellResult = iCell1 * icell2
                Me.dgOR.Rows(su).Cells(6).Value = icellResult
            Next
            Call sumTdg()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            MessageBox.Show("คำนวนยอดรวมไม่ได้ กรุณาตรวจสอบให้เป็นตัวเลขเท่านั้น", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub dgOR_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgOR.CellEndEdit
        'รวม ราคาคูณจำนวน
        Try
            Dim iCell1 As Decimal
            Dim icell2 As Decimal
            Dim icellResult As Decimal
            iCell1 = dgOR.CurrentRow.Cells(2).Value
            icell2 = dgOR.CurrentRow.Cells(5).Value
            icellResult = iCell1 * icell2
            dgOR.CurrentRow.Cells(6).Value = icellResult
           Call sumTdg()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            MessageBox.Show("คำนวนยอดรวมไม่ได้ กรุณาตรวจสอบให้เป็นตัวเลขเท่านั้น", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnORdelAll_Click(sender As Object, e As EventArgs) Handles btnORdelAll.Click
        'clear datagridview rows
        tbl.Clear()
        Me.txtORsumMoney.Clear()
    End Sub

    Private Sub btnORdel_Click(sender As Object, e As EventArgs) Handles btnORdel.Click
        'ลบโรล
        If Me.dgOR.SelectedRows.Count > 0 Then
            'you may want to add a confirmation message, and if the user confirms delete
            Me.dgOR.Rows.Remove(Me.dgOR.SelectedRows(0))
           Call sumTdg()
        Else
            MsgBox("กรุณาเลือก 1 รายการเพื่อทำการลบ", MsgBoxStyle.Information, "แจ้งเตือน")
        End If
    End Sub
    Private Sub savedgORToDatabase()
        If Me.txtORcompanyID.Text = "" Then
            Me.txtORcompanyID.BackColor = Color.Salmon
            Me.cbbORcompanySelect.BackColor = Color.Salmon
            MsgBox("กรุณาเลือกบริษัทที่จัดซื้อ", MsgBoxStyle.Exclamation, "แจ้งเตือน")
        ElseIf Me.dgOR.Rows.Count = 0 Then
            MsgBox("ไม่มีข้อมูลกรุณาเลือกสินค้าก่อนทำการบันทึก", MsgBoxStyle.Exclamation, "แจ้งเตือน")
        Else
            'หลักการคือ อ่านค่าจากตางรางที่ 1 มาจาำนั้นนำ insert into ลงฐานข้อมูล จากนั้นมาตารางที่สอง วนลูปโดยใช้ for
            Try
                'insert to buy_id
                strSQL = "insert into buy_id(buy_id,datetime_save) " _
                 & "values(@buy_id,@datetime_save)"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.Add(New MySqlParameter("@buy_id", Me.lblORid.Text))
                    .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                    Call open_connection()
                    .ExecuteNonQuery()
                End With
                'insert to buy
                strSQL = "insert into buy(buy_id,total,status,sale_company_id,sale_company_name,datetime_save,datetime_edit,employee) " _
                       & "values(@buy_id,@total,@status,@sale_company_id,@sale_company_name,@datetime_save,@datetime_edit,@employee)"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.Add(New MySqlParameter("@buy_id", Me.lblORid.Text))
                    .Parameters.Add(New MySqlParameter("@total", Me.txtORsumMoney.Text))
                    .Parameters.Add(New MySqlParameter("@status", "ยังไม่ได้รับสินค้า"))
                    .Parameters.Add(New MySqlParameter("@sale_company_id", Me.txtORcompanyID.Text))
                    .Parameters.Add(New MySqlParameter("@sale_company_name", Me.cbbORcompanySelect.Text))
                    .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                    .Parameters.Add(New MySqlParameter("@datetime_edit", "no_stockin"))
                    .Parameters.Add(New MySqlParameter("@employee", LoginFrm.txtLoginUsername.Text))
                    Call open_connection()
                    .ExecuteNonQuery()

                End With
            Catch ex As Exception

            End Try
            Try
                For rALL As Integer = 0 To dgOR.RowCount - 1
                    Me.Cursor = Cursors.WaitCursor
                    Dim gbc As String = dgOR.Rows(rALL).Cells(0).Value
                    strSQL = "SELECT code_pro,unit FROM product WHERE bar_code='" & gbc & "'"
                    Mainfrm.lblMainStatus.Text = strSQL
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    Dim code_pro, unit As String
                    With Dr
                        .Read()
                        code_pro = .Item("code_pro")
                        unit = .Item("unit")
                    End With
                    Dr.Close()


                    ''insert to buy_pro
                    strSQL = "insert into buy_pro(buy_id,sale_company_id,sale_company_name,code_pro,bar_code,name_pro,price_cost,price_buy,count_num,unit,total,datetime_save,employee) " _
                        & "values(@buy_id,@sale_company_id,@sale_company_name,@code_pro,@bar_code,@name_pro,@price_cost,@price_buy,@count_num,@unit,@total,@datetime_save,@employee)"
                    Mainfrm.lblMainStatus.Text = strSQL
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    With cmd
                        .Parameters.Add(New MySqlParameter("@buy_id", Me.lblORid.Text))
                        .Parameters.Add(New MySqlParameter("@sale_company_id", Me.txtORcompanyID.Text))
                        .Parameters.Add(New MySqlParameter("@sale_company_name", Me.cbbORcompanySelect.Text))
                        .Parameters.Add(New MySqlParameter("@code_pro", code_pro))
                        .Parameters.Add(New MySqlParameter("@bar_code", Me.dgOR.Rows(rALL).Cells(0).Value))
                        .Parameters.Add(New MySqlParameter("@name_pro", Me.dgOR.Rows(rALL).Cells(1).Value))
                        .Parameters.Add(New MySqlParameter("@price_cost", Me.dgOR.Rows(rALL).Cells(2).Value))
                        .Parameters.Add(New MySqlParameter("@price_buy", Me.dgOR.Rows(rALL).Cells(3).Value))
                        .Parameters.Add(New MySqlParameter("@count_num", Me.dgOR.Rows(rALL).Cells(5).Value))
                        .Parameters.Add(New MySqlParameter("@unit", Me.dgOR.Rows(rALL).Cells(4).Value))
                        .Parameters.Add(New MySqlParameter("@total", Me.dgOR.Rows(rALL).Cells(6).Value))
                        .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                        .Parameters.Add(New MySqlParameter("@employee", LoginFrm.txtLoginUsername.Text))
                        Call open_connection()
                        .ExecuteNonQuery()
                    End With
                Next
                Me.Cursor = Cursors.Default
                'แอดทำรีพอร์ต
                Me.Cursor = Cursors.WaitCursor
                Mainfrm.lblMainStatus.Text = "ล้างข้อมูลรายงานเก่า"
                Try
                    strSQLite = "DELETE FROM buy_pro"
                    Mainfrm.lblMainStatus.Text = strSQLite
                    cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                    Call open_connectionSQLite()
                    cmdSQLite.ExecuteNonQuery()
                    Me.Cursor = Cursors.Default
                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                End Try
                'loop save to database
                For rREPORT As Integer = 0 To dgOR.RowCount - 1
                    Try
                        Me.Cursor = Cursors.WaitCursor
                        Dim gbc As String = dgOR.Rows(rREPORT).Cells(0).Value
                        strSQL = "SELECT code_pro,unit FROM product WHERE bar_code='" & gbc & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        Dr = cmd.ExecuteReader
                        Dim code_pro, unit As String
                        With Dr
                            .Read()
                            code_pro = .Item("code_pro")
                            unit = .Item("unit")
                        End With
                        Dr.Close()

                        strSQLite = "insert into buy_pro(buy_id,sale_company_id,sale_company_name,code_pro,bar_code,name_pro,price_cost,price_buy,count_num,unit,total,datetime_save,employee) " _
                        & "values(@buy_id,@sale_company_id,@sale_company_name,@code_pro,@bar_code,@name_pro,@price_cost,@price_buy,@count_num,@unit,@total,@datetime_save,@employee)"
                        Mainfrm.lblMainStatus.Text = strSQLite
                        cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                        With cmdSQLite
                            .Parameters.Add(New SQLiteParameter("@buy_id", Me.lblORid.Text))
                            .Parameters.Add(New SQLiteParameter("@sale_company_id", Me.txtORcompanyID.Text))
                            .Parameters.Add(New SQLiteParameter("@sale_company_name", Me.cbbORcompanySelect.Text))
                            .Parameters.Add(New SQLiteParameter("@code_pro", code_pro))
                            .Parameters.Add(New SQLiteParameter("@bar_code", Me.dgOR.Rows(rREPORT).Cells(0).Value))
                            .Parameters.Add(New SQLiteParameter("@name_pro", Me.dgOR.Rows(rREPORT).Cells(1).Value))
                            .Parameters.Add(New SQLiteParameter("@price_cost", Me.dgOR.Rows(rREPORT).Cells(2).Value))
                            .Parameters.Add(New SQLiteParameter("@price_buy", Me.dgOR.Rows(rREPORT).Cells(3).Value))
                            .Parameters.Add(New SQLiteParameter("@count_num", Me.dgOR.Rows(rREPORT).Cells(5).Value))
                            .Parameters.Add(New SQLiteParameter("@unit", Me.dgOR.Rows(rREPORT).Cells(4).Value))
                            .Parameters.Add(New SQLiteParameter("@total", Me.dgOR.Rows(rREPORT).Cells(6).Value))
                            .Parameters.Add(New SQLiteParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                            .Parameters.Add(New SQLiteParameter("@employee", LoginFrm.txtLoginUsername.Text))
                            Call open_connectionSQLite()
                            .ExecuteNonQuery()
                        End With
                        Me.Cursor = Cursors.Default
                    Catch ex As Exception
                        Me.Cursor = Cursors.Default
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try
                Next
                Me.Cursor = Cursors.WaitCursor
                Buy_ProReportPrintFrm.Show()
                Me.Cursor = Cursors.Default
                tbl.Clear()
                Me.txtORsumMoney.Text = "0"
                Me.txtORcompanyID.Clear()
                Me.txtORcompanyAddress.Clear()
                Me.txtORcompanyTel.Clear()
                Me.cbbORcompanySelect.Text = ""
                Call startfrm()
                If c = 1 Then
                    Me.Close()
                End If
                MsgBox("บันทึกข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
            Me.Cursor = Cursors.Default
        End If
    End Sub
    Private Sub btnORsave_Click(sender As Object, e As EventArgs) Handles btnORsave.Click
        Call savedgORToDatabase()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaleCompanyFrm.MdiParent = Mainfrm
        SaleCompanyFrm.Show()
    End Sub

    Private Sub btnORselectPro_Click(sender As Object, e As EventArgs) Handles btnORselectPro.Click
        StockFrm.MdiParent = Mainfrm
        StockFrm.Show()
    End Sub

    Private Sub btnORokBarcode_Click(sender As Object, e As EventArgs) Handles btnORokBarcode.Click
        Call getProduct()
    End Sub
End Class