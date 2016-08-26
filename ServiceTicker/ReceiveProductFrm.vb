Imports MySql.Data.MySqlClient
Imports System.Data.Common
Imports System.Globalization
'เสร็จ v2
Public Class ReceiveProductFrm
   
    Private Sub AutoNumberNo()
        Try
            Mainfrm.lblMainStatus.Text = "SELECT ver_receive "
            dt = New DataTable
            strSQL = "SELECT ver_receive FROM ver_detail"
            dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
            Call open_connection()
            dtAdapter.Fill(dt)
            Dim nid As String = dt.Rows(0).Item("ver_receive")
            Mainfrm.lblMainStatus.Text = "SELECT Max(ID) as ID FROM receive_id "
            strSQL = "SELECT Max(ID) as ID FROM receive_id"
            dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                Me.txtRPid.Text = nid & Now.ToString("yyMMddHHmm") & "00001"
            Else
                Dim newID As Integer = CInt(Dr.Item("id"))
                newID += 1
                Me.txtRPid.Text = nid & Now.ToString("yyMMddHHmm") & newID.ToString("00000")
            End If
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try

    End Sub

    Private Sub ReceiveProductFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call startfrm()
        Me.Icon = Mainfrm.Icon
    End Sub
    Private Sub startfrm()
        Me.txtRPid.Clear()
        Me.txtRPsale_company_name.Clear()
        Me.txtRPbuy_id.Clear()
        Me.txtRPbillID.Clear()
        Me.txtRSorderID.Clear()
        Me.txtRPnamePro.Clear()
        Me.txtRPbarcode.Clear()
        Me.txtRPserialPro.Clear()
        Me.txtRPsumMoney.Clear()
        'Me.dgRPorderPro.Rows.Clear()
        Me.dgRPsn.Rows.Clear()
        'dt.Clear()
        Me.cbRPstatus.Items.Clear()
        Call AutoNumberNo()
        Me.DateTimePickerRP.Value = DateTime.Now.AddDays(0)
        
    End Sub

    Private Sub getDatatodgRPorderpro()
        Try
            Me.dgRPorderPro.Refresh()
            ds = New DataSet
            dt = New DataTable
            Mainfrm.lblMainStatus.Text = "select code_pro,name_pro,price_cost,price_buy,count_num,unit "
            strSQL = "select code_pro,name_pro,price_cost,price_buy,count_num,unit from buy_pro where buy_id='" & Me.txtRSorderID.Text & "'"
            dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
            Call open_connection()
            dtAdapter.FillSchema(ds, SchemaType.Source, "buy_pro")
            dtAdapter.Fill(dt)
            dgRPorderPro.DataSource = dt
            For i As Integer = 0 To dgRPorderPro.Rows.Count - 1
                dgRPorderPro.Rows(i).Cells(0).Value = "0"
            Next
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub getDatatodgRPorderproFromtxtbuy_id()
        Try
            Me.dgRPorderPro.Refresh()
            ds = New DataSet
            dt = New DataTable
            Mainfrm.lblMainStatus.Text = "select code_pro,name_pro,price_cost,price_buy,count_num,uni"
            strSQL = "select code_pro,name_pro,price_cost,price_buy,count_num,unit from buy_pro where buy_id='" & Me.txtRPbuy_id.Text & "'"
            dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
            Call open_connection()
            dtAdapter.FillSchema(ds, SchemaType.Source, "buy_pro")
            dtAdapter.Fill(dt)
            dgRPorderPro.DataSource = dt
            For i As Integer = 0 To dgRPorderPro.Rows.Count - 1
                dgRPorderPro.Rows(i).Cells(0).Value = "0"
                dgRPorderPro.Rows(i).Cells(1).Value = "0"
            Next
            Call totalPriceCost()
            Call totalSumCost()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub btnRPselectOrder_Click(sender As Object, e As EventArgs) Handles btnRPselectOrder.Click
        SelectReceiveProductFrm.MdiParent = Mainfrm
        SelectReceiveProductFrm.Show()
    End Sub

    Private Sub cbRPstatus_Click(sender As Object, e As EventArgs) Handles cbRPstatus.Click
        Me.cbRPstatus.Items.Clear()
        Me.cbRPstatus.Items.Add("ชำระเงินแล้ว")
        Me.cbRPstatus.Items.Add("ยังไม่ได้ชำระเงิน")
    End Sub

    Private Sub txtRSorderID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRSorderID.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call getDatatodgRPorderpro()
        End If
    End Sub

    Private Sub txtRPbuy_id_TextChanged(sender As Object, e As EventArgs) Handles txtRPbuy_id.TextChanged
        Call getDatatodgRPorderproFromtxtbuy_id()
    End Sub

    Private Sub dgRPorderPro_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgRPorderPro.CellMouseClick
        Try
            Me.txtRPnamePro.Text = Me.dgRPorderPro.SelectedCells.Item(4).Value
        Catch ex As Exception

        End Try
    End Sub
    Private Sub addTodgRPsn()
        For checkSN As Integer = 0 To Me.dgRPsn.Rows.Count - 1
            If Me.dgRPsn.Rows(checkSN).Cells("serial_pro").Value = Me.txtRPserialPro.Text Then
                MsgBox("SN ซ้ำ", MsgBoxStyle.Critical, "แจ้งเตือน")
                Me.txtRPserialPro.Clear()
                Exit Sub
            End If
        Next
        Try
            If Me.txtRPserialPro.Text = "" Then
                MsgBox("กรุณาใส่หมายเลข SN", MsgBoxStyle.Critical, "แจ้งเตือน")
            Else
                If Me.txtRPnamePro.Text = "" Then
                    MsgBox("กรุณาเลือกสินค้าก่อนที่จะป้อน SN", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                    Me.txtRPserialPro.Clear()
                    Exit Sub
                Else
                    If Me.dgRPorderPro.SelectedCells.Item(7).Value = (CInt(Me.dgRPorderPro.SelectedCells.Item(0).Value) + CInt(Me.dgRPorderPro.SelectedCells.Item(1).Value)) Then
                        MsgBox("สินค้าเกินจำนวนที่สั่งซื้อ", MsgBoxStyle.Critical, "แจ้งเตือน")
                        Me.txtRPserialPro.Clear()
                        Exit Sub
                    Else
                        Dim sd As Integer = Me.dgRPsn.Rows.Add()
                        Me.dgRPsn.Rows(sd).Cells("serial_pro").Value = Me.txtRPserialPro.Text
                        Me.dgRPsn.Rows(sd).Cells("namepro").Value = Me.dgRPorderPro.SelectedCells.Item(4).Value
                        Me.dgRPsn.Rows(sd).Cells("codepro").Value = Me.dgRPorderPro.SelectedCells.Item(3).Value
                        Dim kl As Integer = Me.dgRPorderPro.SelectedRows.Count - 1
                        Me.dgRPorderPro.SelectedCells.Item(1).Value = CDbl(Me.dgRPorderPro.SelectedCells.Item(1).Value) + CDbl("1")
                    End If
                    Me.txtRPserialPro.Clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub addBarcodeItem()
        Try
            If Me.txtRPbarcode.Text = "" Then
                MsgBox("กรุณาใส่บาร์โค๊ต", MsgBoxStyle.Critical, "แจ้งเตือน")
            Else
                If Me.txtRPnamePro.Text = "" Then
                    MsgBox("กรุณาเลือกสินค้าก่อนที่จะป้อนบาร์โค๊ต", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                    Me.txtRPbarcode.Clear()
                    Exit Sub
                Else
                    Try

                        Mainfrm.lblMainStatus.Text = "select bar_code "
                        strSQL = "select bar_code from product where code_pro='" & Me.dgRPorderPro.SelectedCells.Item(3).Value & "'"
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        Dim checkBarcode As String
                        checkBarcode = cmd.ExecuteScalar
                        If checkBarcode <> Me.txtRPbarcode.Text Then
                            MsgBox("บาร์โค๊ตไม่ตรงกับในระบบที่บันทึกไว้", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                            Me.txtRPbarcode.Clear()
                            Exit Sub
                        ElseIf checkBarcode = Me.txtRPbarcode.Text Then

                            If Me.dgRPorderPro.SelectedCells.Item(7).Value = (CInt(Me.dgRPorderPro.SelectedCells.Item(0).Value) + CInt(Me.dgRPorderPro.SelectedCells.Item(1).Value)) Then
                                MsgBox("สินค้าเกินจำนวนที่สั่งซื้อ", MsgBoxStyle.Critical, "แจ้งเตือน")
                                Me.txtRPbarcode.Clear()
                                Exit Sub
                            Else
                                Me.dgRPorderPro.SelectedCells.Item(0).Value = CDbl(Me.dgRPorderPro.SelectedCells.Item(0).Value) + CDbl("1")
                                Me.txtRPbarcode.Clear()
                            End If
                        End If
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try
                End If
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub totalPriceCost()
        For totalCost As Integer = 0 To Me.dgRPorderPro.Rows.Count - 1
            Me.dgRPorderPro.Rows(totalCost).Cells(2).Value = CInt(Me.dgRPorderPro.Rows(totalCost).Cells(5).Value) * CInt(Me.dgRPorderPro.Rows(totalCost).Cells(7).Value)
        Next
    End Sub
    Private Sub totalSumCost()
        'If dgRPorderPro.RowCount > 1 Then
        Dim oop As Integer = 0
        For index As Integer = 0 To dgRPorderPro.RowCount - 1
            oop += CInt(Me.dgRPorderPro.Rows(index).Cells(2).Value)
        Next
        Me.txtRPsumMoney.Text = oop.ToString("0,0") & " บาท"
        'End If
    End Sub

    Private Sub txtRPserialPro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRPserialPro.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call addTodgRPsn()
        End If
    End Sub

    Private Sub btnRPaddSN_Click(sender As Object, e As EventArgs) Handles btnRPaddSN.Click
        Call addTodgRPsn()
    End Sub

    Private Sub btnRPdelSN_Click(sender As Object, e As EventArgs) Handles btnRPdelSN.Click
        If dgRPsn.SelectedRows.Count > 0 Then
            For h As Integer = 0 To dgRPorderPro.Rows.Count - 1
                If dgRPsn.SelectedCells.Item(2).Value = dgRPorderPro.Rows(h).Cells(3).Value Then
                    Dim kl As Integer = Me.dgRPorderPro.Rows.Count - 1
                    Me.dgRPorderPro.Rows(h).Cells(1).Value = CDbl(Me.dgRPorderPro.Rows(h).Cells(1).Value) - CDbl("1")
                End If
            Next
            Me.dgRPsn.Rows.Remove(dgRPsn.SelectedRows(0))
        End If
    End Sub

    Private Sub btnRPsave_Click(sender As Object, e As EventArgs) Handles btnRPsave.Click
        If Me.dgRPorderPro.Rows.Count = 0 Then
            MsgBox("ยังไม่มีข้อมูลใบสั่งซื้อ", MsgBoxStyle.Critical, "แจ้งเตือน")
            Exit Sub
        End If
        If Me.txtRPbillID.Text = "" Then
            MsgBox("กรูณาใส่หมายเลขบิลสินค้า หากไม่มีให้ - ไว้", MsgBoxStyle.Exclamation, "แจ้งเตือน")
            Me.txtRPbillID.Focus()
            Me.txtRPbillID.BackColor = Color.OrangeRed
            Me.lblRPbillID.BackColor = Color.OrangeRed
            Exit Sub
        End If
        If Me.cbRPstatus.Text = "" Then
            MsgBox("กรูณาเลือกสถานะ", MsgBoxStyle.Exclamation, "แจ้งเตือน")
            Me.lblRPStatus.BackColor = Color.OrangeRed
            Exit Sub
        End If
        For checkProReceive As Integer = 0 To dgRPorderPro.Rows.Count - 1
            If Me.dgRPorderPro.Rows(checkProReceive).Cells(7).Value <> (CInt(Me.dgRPorderPro.Rows(checkProReceive).Cells(0).Value) + CInt(Me.dgRPorderPro.Rows(checkProReceive).Cells(1).Value)) Then
                MsgBox("สินค้ายังนำเข้าไม่ครบ กรุณาตรวจสอบ", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Exit Sub
            End If
        Next
        Call saveDatatoDatabase()
    End Sub

    Private Sub txtRPbarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRPbarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call addBarcodeItem()
        End If
    End Sub

    Private Sub btnRPdelBarcode_Click(sender As Object, e As EventArgs) Handles btnRPdelBarcode.Click
        Dim checkdgRPorderPro As Integer = Me.dgRPorderPro.Rows.Count
        If checkdgRPorderPro = 0 Then
            Exit Sub
        Else
            If dgRPorderPro.SelectedCells.Item(0).Value = 0 Then
                MsgBox("สินค้ามี 0 ชิ้นแล้ว หยุดลบเถอะ", MsgBoxStyle.Exclamation, "แจ้งเตือน")
            ElseIf dgRPorderPro.SelectedCells.Item(0).Value <> 0 Then
                Me.dgRPorderPro.SelectedCells.Item(0).Value = CDbl(Me.dgRPorderPro.SelectedCells.Item(0).Value) - CDbl("1")
            End If
        End If
    End Sub

    Private Sub btnRPaddBarcode_Click(sender As Object, e As EventArgs) Handles btnRPaddBarcode.Click
        Call addBarcodeItem()
    End Sub
    Private Sub btnRPclear_Click(sender As Object, e As EventArgs) Handles btnRPclear.Click
        Call startfrm()
    End Sub
    Private Sub saveDatatoDatabase()
        Try
        'update number of product from product
        For SDD As Integer = 0 To dgRPorderPro.Rows.Count - 1
                Using dt = New DataTable
                    Mainfrm.lblMainStatus.Text = "select count_num,bar_code"
                    strSQL = "select count_num,bar_code from product where code_pro='" & Me.dgRPorderPro.Rows(SDD).Cells(3).Value & "' "
                    dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                    Call open_connection()
                    dtAdapter.Fill(dt)
                    Dim count_num As Integer
                    Dim cn As String = dt.Rows(0).Item("count_num")
                    Dim cn1 As String = Me.dgRPorderPro.Rows(SDD).Cells(7).Value
                    Dim cn2 As String = dt.Rows(0).Item("bar_code")
                    count_num = CInt(cn) + CInt(cn1)
                    Mainfrm.lblMainStatus.Text = "update product"
                    strSQL = "update product set count_num='" & count_num & "' where bar_code='" & cn2 & "'"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End Using
            Next
        'insert to product_serial
            For SND As Integer = 0 To dgRPsn.Rows.Count - 1
                Mainfrm.lblMainStatus.Text = "insert into product_serial"
                strSQL = "insert into product_serial(code_pro,serial_pro,name_pro,date_in)" _
                        & " values(@code_pro,@serial_pro,@name_pro,@date_in)"
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    With cmd
                        .Parameters.Add(New MySqlParameter("@code_pro", Me.dgRPsn.Rows(SND).Cells(2).Value))
                        .Parameters.Add(New MySqlParameter("@serial_pro", Me.dgRPsn.Rows(SND).Cells(0).Value))
                        .Parameters.Add(New MySqlParameter("@name_pro", Me.dgRPsn.Rows(SND).Cells(1).Value))
                        .Parameters.Add(New MySqlParameter("@date_in", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                        Call open_connection()
                        .ExecuteNonQuery()
                    End With
                End Using
            Next
            'อัพเดท status เป็น ได้รับสินค้าแล้ว
            Mainfrm.lblMainStatus.Text = "update buy"
        strSQL = "update buy set status='" & "ได้รับสินค้าแล้ว" & "',datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "', employee='" & LoginFrm.txtLoginUsername.Text & "' where buy_id='" & Me.txtRPbuy_id.Text & "' "
        Using cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        End Using
            'insert to receive //get data000000000000000000000000000000000
            Mainfrm.lblMainStatus.Text = "select * from buy "
            strSQL = "select * from buy where buy_id='" & Me.txtRPbuy_id.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim buy_id, total, status, sale_company_id, sale_company_name, datetime_save, datetime_edit, employee As String
            With Dr
                .Read()
                buy_id = .Item("buy_id")
                total = .Item("total")
                status = .Item("status")
                sale_company_id = .Item("sale_company_id")
                sale_company_name = .Item("sale_company_name")
                datetime_save = .Item("datetime_save")
                datetime_edit = .Item("datetime_edit")
                employee = .Item("employee")
            End With
        Dr.Close()
            'insert to receive //insert
            Mainfrm.lblMainStatus.Text = "insert into receive"
            strSQL = "insert into receive(receive_id,buy_id,bill_buy_id,receive_status,total,status,sale_company_id,sale_company_name,datetime_save,datetime_edit,employee)" _
                     & " values(@receive_id,@buy_id,@bill_buy_id,@receive_status,@total,@status,@sale_company_id,@sale_company_name,@datetime_save,@datetime_edit,@employee)"
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.Add(New MySqlParameter("@receive_id", Me.txtRPid.Text))
                    .Parameters.Add(New MySqlParameter("@buy_id", buy_id))
                    .Parameters.Add(New MySqlParameter("@bill_buy_id", Me.txtRPbillID.Text))
                    .Parameters.Add(New MySqlParameter("@receive_status", Me.cbRPstatus.Text))
                    .Parameters.Add(New MySqlParameter("@total", total))
                    .Parameters.Add(New MySqlParameter("@status", status))
                    .Parameters.Add(New MySqlParameter("@sale_company_id", sale_company_id))
                    .Parameters.Add(New MySqlParameter("@sale_company_name", sale_company_name))
                    .Parameters.Add(New MySqlParameter("@datetime_save", datetime_save))
                    .Parameters.Add(New MySqlParameter("@datetime_edit", datetime_edit))
                    .Parameters.Add(New MySqlParameter("@employee", LoginFrm.txtLoginUsername.Text))
                    Call open_connection()
                    .ExecuteNonQuery()
                End With
            End Using
            'insert receive_id
            Mainfrm.lblMainStatus.Text = "insert into receive_id"
        strSQL = "insert into receive_id(receive_id,datetime_save)" _
                   & " values(@receive_id,@datetime_save)"
        Using cmd = New MySqlCommand(strSQL, ConnectionDB)
            With cmd
                .Parameters.Add(New MySqlParameter("@receive_id", Me.txtRPid.Text))
                .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                Call open_connection()
                .ExecuteNonQuery()
            End With
        End Using
        'insert to receive_pro
            For receiveLoop As Integer = 0 To Me.dgRPorderPro.Rows.Count - 1
                Mainfrm.lblMainStatus.Text = "insert into receive_pro"
                strSQL = "insert into receive_pro(receive_id,buy_id,sale_company_name,code_pro,name_pro,price_cost,price_buy,count_num,count_num_barcode,count_num_sn,unit,total_all,datetime_save,employee)" _
                            & " values(@receive_id,@buy_id,@sale_company_name,@code_pro,@name_pro,@price_cost,@price_buy,@count_num,@count_num_barcode,@count_num_sn,@unit,@total_all,@datetime_save,@employee)"
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    With cmd
                        .Parameters.Add(New MySqlParameter("@receive_id", Me.txtRPid.Text))
                        .Parameters.Add(New MySqlParameter("@buy_id", Me.txtRPbuy_id.Text))
                        .Parameters.Add(New MySqlParameter("@sale_company_name", Me.txtRPsale_company_name.Text))
                        .Parameters.Add(New MySqlParameter("@code_pro", Me.dgRPorderPro.Rows(receiveLoop).Cells(3).Value))
                        .Parameters.Add(New MySqlParameter("@name_pro", Me.dgRPorderPro.Rows(receiveLoop).Cells(4).Value))
                        .Parameters.Add(New MySqlParameter("@price_cost", Me.dgRPorderPro.Rows(receiveLoop).Cells(5).Value))
                        .Parameters.Add(New MySqlParameter("@price_buy", Me.dgRPorderPro.Rows(receiveLoop).Cells(6).Value))
                        .Parameters.Add(New MySqlParameter("@count_num", Me.dgRPorderPro.Rows(receiveLoop).Cells(7).Value))
                        .Parameters.Add(New MySqlParameter("@count_num_barcode", Me.dgRPorderPro.Rows(receiveLoop).Cells(0).Value))
                        .Parameters.Add(New MySqlParameter("@count_num_sn", Me.dgRPorderPro.Rows(receiveLoop).Cells(1).Value))
                        .Parameters.Add(New MySqlParameter("@unit", Me.dgRPorderPro.Rows(receiveLoop).Cells(8).Value))
                        .Parameters.Add(New MySqlParameter("@total_all", Me.dgRPorderPro.Rows(receiveLoop).Cells(2).Value))
                        .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                        .Parameters.Add(New MySqlParameter("@employee", LoginFrm.txtLoginUsername.Text))
                        Call open_connection()
                        .ExecuteNonQuery()
                    End With
                End Using
            Next
            MsgBox("บันทึกข้อมูลแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
        Catch ex As Exception
        Finally
            Call startfrm()
        End Try
    End Sub

    Private Sub btnRPaddBCnum_Click(sender As Object, e As EventArgs) Handles btnRPaddBCnum.Click
        If Me.txtRPnamePro.Text = "" Then
            MsgBox("กรุณาเลือกสินค้าที่จะนำเข้า", MsgBoxStyle.Exclamation, "แจ้งเตือน")
        Else
            Dim NumPro As Integer
            NumPro = CInt(Me.dgRPorderPro.SelectedCells.Item(0).Value) + CInt(Me.dgRPorderPro.SelectedCells.Item(1).Value) + CInt(Me.NumericUpDown1.Value)
            If NumPro > CInt(Me.dgRPorderPro.SelectedCells.Item(7).Value) Then
                MsgBox("จำนวนสินค้าเกินกว่าจำนวนที่สั่งซื้อ", MsgBoxStyle.Exclamation, "แจ้งเตือน")
            Else
                Me.dgRPorderPro.SelectedCells.Item(0).Value = CInt(Me.dgRPorderPro.SelectedCells.Item(0).Value) + CInt(Me.NumericUpDown1.Value)
            End If
        End If
        
    End Sub

    Private Sub btnRPdelBCnum_Click(sender As Object, e As EventArgs) Handles btnRPdelBCnum.Click
        If Me.txtRPnamePro.Text = "" Then
            MsgBox("กรุณาเลือกสินค้าที่จะลบ", MsgBoxStyle.Exclamation, "แจ้งเตือน")
        Else
            If CInt(Me.dgRPorderPro.SelectedCells.Item(0).Value) > 0 Then
                Me.dgRPorderPro.SelectedCells.Item(0).Value = CInt(Me.dgRPorderPro.SelectedCells.Item(0).Value) - CInt(Me.NumericUpDown1.Value)
            ElseIf CInt(Me.dgRPorderPro.SelectedCells.Item(0).Value) = 0 Then
                MsgBox("สินค้ามี 0 ชิ้นแล้ว หยุดลบเถอะ", MsgBoxStyle.Exclamation, "แจ้งเตือน")
            End If
        End If
    End Sub
End Class