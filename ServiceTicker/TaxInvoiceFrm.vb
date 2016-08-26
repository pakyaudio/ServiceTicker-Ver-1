Imports MySql.Data.MySqlClient

Public Class TaxInvoiceFrm
   
    Friend DTPTI1 As String
    Private Sub thaitext()
        Dim mne As New MoneyExt()
        Try
            Me.txtTItahitext.Text = mne.NumberToThaiWord(CDbl(Me.txtTItotalAll.Text))
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Dim nid As String
    Private Sub AutoNumberNo()

        Try
            strSQL = "SELECT ver_cashinvoice FROM ver_detail"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Dr.HasRows Then
                nid = Dr.GetString("ver_cashinvoice")
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try

        Try
            strSQL = "SELECT Max(id) as ID FROM taxinvoice_id"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                Me.txtTIbillID.Text = nid & Now.ToString("yyMMddHHmm") & "00001"
            Else
                Dim newID As Integer = CInt(Dr.Item("ID"))
                newID += 1
                Me.txtTIbillID.Text = nid & Now.ToString("yyMMddHHmm") & newID.ToString("00000")
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        nid = Nothing
    End Sub
    Private Sub cbTI_CheckedChanged(sender As Object, e As EventArgs) Handles cbTI.CheckedChanged
        If Me.cbTI.Checked = False Then
            DateTimePicker1.Enabled = False
            DTPTI1 = ".............../.............../..............."
        ElseIf Me.cbTI.Checked = True Then
            DateTimePicker1.Enabled = True
            DTPTI1 = DateTimePicker1.Value.ToString("dd MMMM yyyy")
        End If
    End Sub

    Public Sub restart()
        Me.txtTIcusid.Clear()
        Me.txtTIcusname.Clear()
        Me.txtTIcustel.Clear()
        Me.txtTIcusaddress.Clear()
        Me.dgTI.Rows.Clear()
        Me.txtTInote.Text = "-"
        Me.txtTItaxNumber.Text = "0"
        Me.txtTItaxSection.Text = "สำนักงานใหญ่"
        Me.txtTItotalPro.Text = "0"
        Me.txtTIdiscount1.Text = "0"
        Me.txtTItotalTax.Text = "0"
        Me.txtTItotalAll.Text = "0"
        Me.txtTItotal.Text = "0"
        Me.txtTItaxpercen.Text = "0"
        Call AutoNumberNo()
        Call sumALL()
    End Sub
    Friend Sub getCustomerData()
        Try
            strSQL = "SELECT customer_tax,customer_section,customer_name,customer_address," & _
                "customer_zipcode,customer_tel FROM customer WHERE customer_id='" & Me.txtTIcusid.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            If Dr.HasRows Then
                Me.txtTIcusname.Text = Dr.Item("customer_name")
                Me.txtTIcusaddress.Text = Dr.Item("customer_address") & " " & Dr.Item("customer_zipcode")
                Me.txtTIcustel.Text = Dr.Item("customer_tel")
                Me.txtTItaxNumber.Text = Dr.Item("customer_tax")
                Me.txtTItaxSection.Text = Dr.Item("customer_section")
                Me.txtTIsearchBillID.Focus()
            ElseIf Not Dr.HasRows Then
                MsgBox("ไม่พบรหัสลูกค้า " & Me.txtTIcusid.Text)
                Me.txtTIcusid.Clear()
                Me.txtTIcusid.Focus()
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Dim selsctStrSQL As Integer
    Private Sub getDataBill()
        Try
            strSQL = "SELECT code_pro FROM cash_sale_barcode WHERE sale_id='" & Me.txtTIsearchBillID.Text & "' or fix_id='" & Me.txtTIsearchBillID.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            If Dr.HasRows Then
                selsctStrSQL = 100
            ElseIf Not Dr.HasRows Then
                strSQL = "SELECT code_pro FROM sale_barcode WHERE sale_id='" & Me.txtTIsearchBillID.Text & "' or fix_id='" & Me.txtTIsearchBillID.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                If Dr.HasRows Then
                    selsctStrSQL = 200
                ElseIf Not Dr.HasRows Then
                    MsgBox("ไม่พบข้อมูล " & Me.txtTIsearchBillID.Text, MsgBoxStyle.Exclamation, "แจ้งเตือน")
                End If
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try


        Try
            If selsctStrSQL = 100 Then
                strSQL = "SELECT code_pro,name_pro,total_pro,unit,price_buy FROM cash_sale_barcode WHERE sale_id='" & Me.txtTIsearchBillID.Text & "' or fix_id='" & Me.txtTIsearchBillID.Text & "'"
            ElseIf selsctStrSQL = 200 Then
                MsgBox("แจ้งเตือน หมายเลขบิลนี้ยังไม่ได้ชำระเงิน การออกใบเสร็จรับเงินสำหรับบิลนี้" & vbNewLine & "อาจมีผลตามกฎหมายที่เป็นหลักฐานว่าลูกค้าได้ชำระเงินแล้ว" & vbNewLine & "โปรดออกใบเสร็จรับเงินแก่ลูกค้าที่ไว้ใจได้เท่านั้น", MsgBoxStyle.Information, "แจ้งเตือน")
                strSQL = "SELECT code_pro,name_pro,total_pro,unit,price_buy FROM sale_barcode WHERE sale_id='" & Me.txtTIsearchBillID.Text & "' or fix_id='" & Me.txtTIsearchBillID.Text & "'"
            End If
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim r As Integer
            While (Dr.Read())
                With Me.dgTI
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(1).Value = Dr.Item("code_pro")
                    .Rows(r).Cells(2).Value = Dr.Item("name_pro")
                    .Rows(r).Cells(3).Value = Dr.Item("total_pro")
                    .Rows(r).Cells(4).Value = Dr.Item("unit")
                    .Rows(r).Cells(5).Value = Dr.GetDecimal("price_buy")
                End With
            End While
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Call sumALL()
        selsctStrSQL = Nothing
    End Sub

    Friend Sub getDataProduct()
        Try
            strSQL = "SELECT code_pro,name_pro,unit,price_buy FROM product WHERE code_pro='" & Me.txtTIsearchBarcode.Text & "' or bar_code='" & Me.txtTIsearchBarcode.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim r As Integer
            While (Dr.Read())
                If Dr.HasRows Then
                    For dup As Integer = 0 To Me.dgTI.Rows.Count - 1
                        If Dr.Item("code_pro") = Me.dgTI.Rows(dup).Cells(1).Value Then
                            Me.dgTI.Rows(dup).Cells(3).Value = CInt(Me.dgTI.Rows(dup).Cells(3).Value) + 1
                            Exit Sub
                        End If
                    Next
                    With Me.dgTI
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(1).Value = Dr.Item("code_pro")
                        .Rows(r).Cells(2).Value = Dr.Item("name_pro")
                        .Rows(r).Cells(3).Value = "1"
                        .Rows(r).Cells(4).Value = Dr.Item("unit")
                        .Rows(r).Cells(5).Value = Dr.GetDecimal("price_buy")
                    End With
                Else
                    MsgBox("ไม่พบข้อมูล " & Me.txtTIsearchBarcode.Text, MsgBoxStyle.Exclamation, "แจ้งเตือน")
                End If
            End While
            Call sumALL()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Friend Sub getDataProductByView()
        Try
            strSQL = "SELECT taxinvoice_id,taxinvoice_type,customer_id,customer_name,customer_address,customer_tel,note,tax_num,tax_section FROM taxinvoice WHERE taxinvoice_id='" & ViewOldTaxInvoiceFrm.dgVOTI.SelectedCells.Item(0).Value & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            Me.txtTIcusid.Text = Dr.Item("customer_id")
            Me.txtTIcusname.Text = Dr.Item("customer_name")
            Me.txtTIcusaddress.Text = Dr.Item("customer_address")
            Me.txtTIcustel.Text = Dr.Item("customer_tel")
            Me.txtTIbillID.Text = Dr.Item("taxinvoice_id")
            Me.cbbTIselectbill.Text = Dr.Item("taxinvoice_type")
            Me.txtTInote.Text = Dr.Item("note")
            Me.txtTItaxNumber.Text = Dr.Item("tax_num")
            Me.txtTItaxSection.Text = Dr.Item("tax_section")
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try

        Try
            strSQL = "SELECT code_pro,name_pro,total,unit,price_buy FROM taxinvoice WHERE taxinvoice_id='" & ViewOldTaxInvoiceFrm.dgVOTI.SelectedCells.Item(0).Value & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim r As Integer
            While (Dr.Read())
                If Dr.HasRows Then
                    With Me.dgTI
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(1).Value = Dr.Item("code_pro")
                        .Rows(r).Cells(2).Value = Dr.Item("name_pro")
                        .Rows(r).Cells(3).Value = Dr.Item("total")
                        .Rows(r).Cells(4).Value = Dr.Item("unit")
                        .Rows(r).Cells(5).Value = Dr.GetDecimal("price_buy")
                    End With
                Else
                    MsgBox("ไม่พบข้อมูล " & Me.txtTIsearchBarcode.Text, MsgBoxStyle.Exclamation, "แจ้งเตือน")
                End If
            End While
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Call sumALL()
    End Sub

    Friend Sub sumALL()
        Dim ptt As Decimal
        For sum As Integer = 0 To Me.dgTI.Rows.Count - 1
            Me.dgTI.Rows(sum).Cells(0).Value = sum + 1
            Me.dgTI.Rows(sum).Cells(6).Value = CDec(Me.dgTI.Rows(sum).Cells(5).Value) * CDec(Me.dgTI.Rows(sum).Cells(3).Value)
            ptt += CDec(Me.dgTI.Rows(sum).Cells(6).Value)
            Me.txtTItotalPro.Text = ptt.ToString("N2")
            Dim txtTItotala As Decimal = CDec(Me.txtTItotalPro.Text) - CDec(Me.txtTIdiscount1.Text)
            Me.txtTItotal.Text = txtTItotala.ToString("N2")
            If Me.rbTItotaltax.Checked Then
                Dim txtTItotalTax As Decimal = (CDec(Me.txtTItotal.Text) / 100) * CDec(Me.txtTItaxpercen.Text)
                'Dim txtTItotal As Decimal = CDec(Me.txtTItotal.Text) + ((CDec(Me.txtTItotal.Text) / 100) * CDec(Me.txtTItaxpercen.Text))
                Dim txtTItotalAll As Decimal = CDec(Me.txtTItotal.Text) + txtTItotalTax
                Me.txtTItotalTax.Text = txtTItotalTax.ToString("N2")
                'Me.txtTItotal.Text = txtTItotal.ToString("N2")
                Me.txtTItotalAll.Text = txtTItotalAll.ToString("N2")
            ElseIf Me.rbTIuntax.Checked Then
                Dim txtTItotalTax As Decimal = (CDec(Me.txtTItotal.Text) / 100) * CDec(Me.txtTItaxpercen.Text)
                Dim txtTItotalAll As Decimal = CDec(Me.txtTItotal.Text) + CDec(Me.txtTItotalTax.Text)
                Me.txtTItotalTax.Text = txtTItotalTax.ToString("N2")
                Me.txtTItotalAll.Text = txtTItotalAll.ToString("N2")
            End If
        Next
        Call thaitext()
    End Sub

    Private Sub rbCheck()
        If Me.rbTItotaltax.Checked = True Then
            Me.txtTItaxpercen.Enabled = True
            Me.txtTItaxpercen.Text = "7"
        ElseIf Me.rbTIuntax.Checked = True Then
            Me.txtTItaxpercen.Enabled = False
            Me.txtTItaxpercen.Text = "0"
        End If
    End Sub

    Private Sub TaxInvoiceFrm_Click(sender As Object, e As EventArgs) Handles Me.Click
        TaxInvoiceSelectProFrm.Close()
    End Sub
    Private Sub TaxInvoiceFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        Me.cbbTIselectbill.Items.Clear()
        Me.cbbTIselectbill.Items.Add("ใบส่งของ")
        Me.cbbTIselectbill.Items.Add("ใบเสร็จรับเงิน")
        Me.cbbTIselectbill.Items.Add("ใบเสร็จรับเงิน/ใบกำกับภาษี")
        Call thaitext()
        Me.DateTimePicker1.Value = DateTime.Now.AddDays(0)
        Call AutoNumberNo()
        Call rbCheck()
    End Sub

    Private Sub txtTIcusid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTIcusid.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call getCustomerData()
        End If
    End Sub

    Private Sub txtTIsearchBillID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTIsearchBillID.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call getDataBill()
            Me.txtTIsearchBillID.Clear()
            Me.txtTIsearchBillID.Focus()
        End If
    End Sub

    Private Sub dgTI_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgTI.CellEndEdit
        Call sumALL()
    End Sub

    Private Sub dgTI_KeyDown(sender As Object, e As KeyEventArgs) Handles dgTI.KeyDown
        If e.KeyCode = Keys.Delete Then
            If Me.dgTI.RowCount = 0 Then
            Else
                Dim r As Integer = Me.dgTI.SelectedRows.Count - 1
                Me.dgTI.Rows.Remove(Me.dgTI.SelectedRows(r))
                Call sumALL()
            End If
        End If
    End Sub

    Private Sub txtTIsearchBarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTIsearchBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call getDataProduct()
            Me.txtTIsearchBarcode.Clear()
            Me.txtTIsearchBarcode.Focus()
        End If
    End Sub

    Private Sub txtTIdiscount1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTIdiscount1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim txtdis As Decimal = Me.txtTIdiscount1.Text
            Me.txtTIdiscount1.Text = txtdis.ToString("N2")
            Call sumALL()
        End If
    End Sub

    Private Sub txtTIdiscount1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTIdiscount1.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                Mainfrm.lblMainStatus.Text = "เฉพาะตัวเลขเท่านั้น"
        End Select
    End Sub

    Private Sub txtTIdiscount1_LostFocus(sender As Object, e As EventArgs) Handles txtTIdiscount1.LostFocus
        If Me.txtTIdiscount1.Text = "" Then
            Me.txtTIdiscount1.Text = "0"
        Else

            Dim txtdis As Decimal = Me.txtTIdiscount1.Text
            Me.txtTIdiscount1.Text = txtdis.ToString("N2")
            Call sumALL()
        End If
    End Sub

    Private Sub txtTIdiscount1_MouseClick(sender As Object, e As MouseEventArgs) Handles txtTIdiscount1.MouseClick
        Me.txtTIdiscount1.SelectAll()
    End Sub

 

    Private Sub txtTItaxpercen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTItaxpercen.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                Mainfrm.lblMainStatus.Text = "เฉพาะตัวเลขเท่านั้น"
        End Select
    End Sub

    Private Sub txtTItaxpercen_TextChanged(sender As Object, e As EventArgs) Handles txtTItaxpercen.TextChanged
        If Me.txtTItaxpercen.Text = "" Then
            Me.txtTItaxpercen.Text = "0"
        Else
            Call sumALL()
        End If
    End Sub

    Private Sub rbTItotaltax_CheckedChanged(sender As Object, e As EventArgs) Handles rbTItotaltax.CheckedChanged
        Call rbCheck()
        Call sumALL()
    End Sub

    Private Sub rbTIuntax_CheckedChanged(sender As Object, e As EventArgs) Handles rbTIuntax.CheckedChanged
        Call rbCheck()
        Call sumALL()
    End Sub
    Private Sub saveANDprint()
        Try
            strSQL = "INSERT INTO taxinvoice_id(ti_id)" _
                 & "VALUES(@ti_id)"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.AddWithValue("@ti_id", Me.txtTIbillID.Text)
                End With
                Call open_connection()
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        If Me.cbTaxUpdate.CheckState = CheckState.Checked Then
            Try
                strSQL = "UPDATE customer SET customer_tax='" & Me.txtTItaxNumber.Text & "',customer_section='" & Me.txtTItaxSection.Text & "' WHERE customer_id='" & Me.txtTIcusid.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
        End If
        Try
            For SPP As Integer = 0 To Me.dgTI.Rows.Count - 1
                strSQL = "INSERT INTO taxinvoice(taxinvoice_id,taxinvoice_type,customer_id,customer_name,customer_address,customer_tel,code_pro,name_pro,total,unit,price_buy,note,tax_num,tax_section)" _
                            & "VALUES(@taxinvoice_id,@taxinvoice_type,@customer_id,@customer_name,@customer_address,@customer_tel,@code_pro,@name_pro,@total,@unit,@price_buy,@note,@tax_num,@tax_section)"
                Mainfrm.lblMainStatus.Text = strSQL
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    With cmd
                        .Parameters.AddWithValue("@taxinvoice_id", Me.txtTIbillID.Text)
                        .Parameters.AddWithValue("@taxinvoice_type", Me.cbbTIselectbill.Text)
                        .Parameters.AddWithValue("@customer_id", Me.txtTIcusid.Text)
                        .Parameters.AddWithValue("@customer_name", Me.txtTIcusname.Text)
                        .Parameters.AddWithValue("@customer_address", Me.txtTIcusaddress.Text)
                        .Parameters.AddWithValue("@customer_tel", Me.txtTIcustel.Text)
                        .Parameters.AddWithValue("@code_pro", Me.dgTI.Rows(SPP).Cells(1).Value)
                        .Parameters.AddWithValue("@name_pro", Me.dgTI.Rows(SPP).Cells(2).Value)
                        .Parameters.AddWithValue("@total", Me.dgTI.Rows(SPP).Cells(3).Value)
                        .Parameters.AddWithValue("@unit", Me.dgTI.Rows(SPP).Cells(4).Value)
                        .Parameters.AddWithValue("@price_buy", Me.dgTI.Rows(SPP).Cells(5).Value)
                        .Parameters.AddWithValue("@note", Me.txtTInote.Text)
                        .Parameters.AddWithValue("@tax_num", Me.txtTItaxNumber.Text)
                        .Parameters.AddWithValue("@tax_section", Me.txtTItaxSection.Text)
                    End With
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End Using
            Next
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        MsgBox("บันทึกข้อมูลแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
        TaxInvoicePrintReportFrm.Show()
        'Call restart()
    End Sub

    Private Sub updateANDprint()
        Try
            strSQL = "DELETE FROM taxinvoice WHERE taxinvoice_id='" & Me.txtTIbillID.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        If Me.cbTaxUpdate.CheckState = CheckState.Checked Then
            Try
                strSQL = "UPDATE customer SET customer_tax='" & Me.txtTItaxNumber.Text & "',customer_section='" & Me.txtTItaxSection.Text & "' WHERE customer_id='" & Me.txtTIcusid.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
        End If
        Try
            For SPP As Integer = 0 To Me.dgTI.Rows.Count - 1
                strSQL = "INSERT INTO taxinvoice(taxinvoice_id,taxinvoice_type,customer_id,customer_name,customer_address,customer_tel,code_pro,name_pro,total,unit,price_buy,note,tax_num,tax_section)" _
                            & "VALUES(@taxinvoice_id,@taxinvoice_type,@customer_id,@customer_name,@customer_address,@customer_tel,@code_pro,@name_pro,@total,@unit,@price_buy,@note,@tax_num,@tax_section)"
                Mainfrm.lblMainStatus.Text = strSQL
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    With cmd
                        .Parameters.AddWithValue("@taxinvoice_id", Me.txtTIbillID.Text)
                        .Parameters.AddWithValue("@taxinvoice_type", Me.cbbTIselectbill.Text)
                        .Parameters.AddWithValue("@customer_id", Me.txtTIcusid.Text)
                        .Parameters.AddWithValue("@customer_name", Me.txtTIcusname.Text)
                        .Parameters.AddWithValue("@customer_address", Me.txtTIcusaddress.Text)
                        .Parameters.AddWithValue("@customer_tel", Me.txtTIcustel.Text)
                        .Parameters.AddWithValue("@code_pro", Me.dgTI.Rows(SPP).Cells(1).Value)
                        .Parameters.AddWithValue("@name_pro", Me.dgTI.Rows(SPP).Cells(2).Value)
                        .Parameters.AddWithValue("@total", Me.dgTI.Rows(SPP).Cells(3).Value)
                        .Parameters.AddWithValue("@unit", Me.dgTI.Rows(SPP).Cells(4).Value)
                        .Parameters.AddWithValue("@price_buy", Me.dgTI.Rows(SPP).Cells(5).Value)
                        .Parameters.AddWithValue("@note", Me.txtTInote.Text)
                        .Parameters.AddWithValue("@tax_num", Me.txtTItaxNumber.Text)
                        .Parameters.AddWithValue("@tax_section", Me.txtTItaxSection.Text)
                    End With
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End Using
            Next
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Friend chgData As Integer
    Private Sub btnTIsavePrint_Click(sender As Object, e As EventArgs) Handles btnTIsavePrint.Click
        If Me.dgTI.Rows.Count = 0 Then
            Exit Sub
        Else
            If Me.txtTIcusid.Text = "" Then
                Me.txtTIcusid.Focus()
                Me.txtTIcusid.BackColor = Color.OrangeRed
                MsgBox("กรุณาใส่รหัสลูกค้าด้วย", MsgBoxStyle.Information, "แจ้งเตือน")
            ElseIf Me.cbbTIselectbill.Text = "" Then
                Me.Label4.BackColor = Color.OrangeRed
                MsgBox("กรุณาเลือกชนิดใบเสร็จ", MsgBoxStyle.Information, "แจ้งเตือน")
            Else
                If MessageBox.Show("โปรดตรวจสอบข้อมูลว่าถูกต้องหรือไม่ก่อนพิมพ์", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    If chgData = 10 Then
                        Call updateANDprint()
                        If cbTIact.Checked Then
                            TaxInvoiceATCPrintReportFrm.Show()
                            chgData = Nothing
                        Else
                            TaxInvoicePrintReportFrm.Show()
                            chgData = Nothing
                        End If
                    Else
                        Call saveANDprint()
                    End If
                Else
                    Mainfrm.lblMainStatus.Text = "โปรดตรวจสอบข้อมูลว่าถูกต้องหรือไม่ก่อนพิมพ์"
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub btnTIcancel_Click(sender As Object, e As EventArgs) Handles btnTIcancel.Click
        Call restart()
    End Sub

    Private Sub btnTIserachBill_Click(sender As Object, e As EventArgs) Handles btnTIserachBill.Click
        TaxInvoiceSearchIDFrm.MdiParent = Mainfrm
        TaxInvoiceSearchIDFrm.Show()
    End Sub

    Private Sub btnTIsearchBarcode_Click(sender As Object, e As EventArgs) Handles btnTIsearchBarcode.Click
        TaxInvoiceSelectProFrm.MdiParent = Mainfrm
        TaxInvoiceSelectProFrm.Show()
    End Sub

    Private Sub btnTIsearchOldBill_Click(sender As Object, e As EventArgs) Handles btnTIsearchOldBill.Click
        ViewOldTaxInvoiceFrm.MdiParent = Mainfrm
        ViewOldTaxInvoiceFrm.Show()
    End Sub
    Friend dc As String
    Friend tp As String
    Friend Sub cbs()
        If cbTIdiscount.Checked Then
            dc = "ส่วนลด " & Me.txtTIdiscount1.Text & " บาท"
        Else
            dc = ""
        End If
        If cbTItexpro.Checked Then
            tp = "ภาษีมูลค่าเพิ่ม " & Me.txtTItotalTax.Text & " บาท"
        Else
            tp = ""
        End If
    End Sub
    Friend ssp As String
    Friend srp As String
    Friend Sub selbill()
        If Me.cbbTIselectbill.Text = "ใบส่งของ" Then
            ssp = "ผู้ส่งของ....................................................." & vbNewLine & "         (.....................................................)"
            srp = "ผู้รับของ....................................................." & vbNewLine & "         (.....................................................)"
        ElseIf Me.cbbTIselectbill.Text = "ใบเสร็จรับเงิน" Then
            ssp = ""
            srp = "ผู้รับเงิน....................................................." & vbNewLine & "          (.....................................................)"
        ElseIf Me.cbbTIselectbill.Text = "ใบเสร็จรับเงิน/ใบกำกับภาษี" Then
            ssp = ""
            srp = "ผู้รับเงิน...................................................." & vbNewLine & "           (.....................................................)"
        End If
    End Sub

    Private Sub btnTIsearchCus_Click(sender As Object, e As EventArgs) Handles btnTIsearchCus.Click
        SearchCustomerTaxinvoiceFrm.MdiParent = Mainfrm
        SearchCustomerTaxinvoiceFrm.Show()
    End Sub
End Class