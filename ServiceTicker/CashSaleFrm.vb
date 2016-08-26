Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class CashSaleFrm
    Private Sub Data_History_Bus_Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        SaleFrm.Enabled = True
    End Sub
    Private Sub AutoNumberNo()
        Try
            Using dt = New DataTable
                strSQL = "SELECT ver_cash FROM ver_detail"
                Mainfrm.lblMainStatus.Text = strSQL
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)
                Dim nids As String = dt.Rows(0).Item("ver_cash")
                strSQL = "SELECT Max(ID) as ID FROM cash_id"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                If Not Dr.HasRows Then
                    Me.txtCScashID.Text = nids & Now.ToString("yyMMddHHmm") & "00001"
                Else
                    Dim newID As Integer = CInt(Dr.Item("ID"))
                    newID += 1
                    Me.txtCScashID.Text = nids & Now.ToString("yyMMddHHmm") & newID.ToString("00000")
                End If
                Dr.Close()
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "โหลดตัวเลขอัตโนมัติผิดพลาด" & ex.Message
        End Try
    End Sub
    Private Sub getData()
        Try
            Me.dgCash.Rows.Clear()
            strSQL = "SELECT sale_id,datetime_save,total_all from sale where customer_id='" & Me.txtCashCusID.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dim r As Integer
                While Dr.Read
                    With dgCash
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells("sale_id").Value = Dr.Item("sale_id")
                        .Rows(r).Cells("datetime_save").Value = Dr.Item("datetime_save")
                        .Rows(r).Cells("total_all").Value = Dr.GetDecimal("total_all")
                    End With
                End While
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try

        Try
            strSQL = "SELECT p_id,datetime_save,total1 FROM pledge_sale WHERE customer_id='" & Me.txtCashCusID.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dim r As Integer
                While Dr.Read
                    With dgCash
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(1).Value = Dr.Item("p_id")
                        .Rows(r).Cells(2).Value = Dr.Item("datetime_save")
                        .Rows(r).Cells(3).Value = -(Dr.GetDecimal("total1"))
                    End With
                End While
            End Using
            Dim suml As Decimal
            For sum As Integer = 0 To Me.dgCash.Rows.Count - 1
                Me.dgCash.Rows(sum).Cells(0).Value = sum + 1
                suml += CDec(Me.dgCash.Rows(sum).Cells(3).Value)
            Next
            Me.txtCStotal.Text = suml
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub CashSaleFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        Me.btnCashSave.Text = "ใบส่งของ"
        Me.txtCashCusPrice.Text = 0
        Me.txtCashCash.Text = SaleFrm.lblPWgetTotalPrice.Text
        Me.cbbCashSelectPayment.Enabled = False
        Me.txtCashByselectPayment.Enabled = False
        Me.DateTimePicker1.Enabled = False
        Me.cbbCScreditCard.Enabled = False
        Me.cbbCScreditCardBank.Enabled = False
    End Sub

    Private Sub txtCashCusPrice_TextChanged(sender As Object, e As EventArgs) Handles txtCashCusPrice.TextChanged
        Try
            If Me.txtCashCusPrice.Text = "" Then
                Me.txtCashBack.Text = "0"
                Me.txtCashCusPrice.Text = "0"
                Me.btnCashSave.Enabled = True
            ElseIf Me.txtCashCusPrice.Text = "0" Then
                Me.txtCashBack.Text = "0"
            Else
                Me.txtCashBack.Text = CDec(Me.txtCashCusPrice.Text) - CDec(Me.txtCashCash.Text)
            End If
            If CDec(Me.txtCashCusPrice.Text) >= CDec(Me.txtCashCash.Text) Then
                Me.btnCashSave.Text = "บันทึกจ่ายเงิน"
                Call AutoNumberNo()
                Me.cbbCashSelectPayment.Enabled = True
                Me.txtCashByselectPayment.Enabled = True
                Me.DateTimePicker1.Enabled = True
                Me.txtCashLowerCash.Enabled = True
                Me.txtCashPercen.Enabled = True
                Me.btnCashSave.Enabled = True
            ElseIf Me.txtCashCusPrice.Text = "0" Then
                Me.btnCashSave.Text = "ใบส่งของ"
                Me.txtCScashID.Text = ""
                Me.btnCashSave.Enabled = True
                'Me.txtCashLowerCash.Enabled = False
                'Me.txtCashPercen.Enabled = False
                Me.cbbCashSelectPayment.Enabled = False
                Me.txtCashByselectPayment.Enabled = False
                Me.DateTimePicker1.Enabled = False
            Else
                Me.btnCashSave.Enabled = False
                Me.cbbCashSelectPayment.Enabled = False
                Me.txtCashByselectPayment.Enabled = False
                Me.DateTimePicker1.Enabled = False
                Mainfrm.lblMainStatus.Text = "หากต้องการมัดจะให้ใส่ 0 แล้วออกใบส่งของ จากนั้นไปมัดจำที่หน้าลูกหนี้ค้างจ่าย"
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cbbCashSelectPayment_DropDown(sender As Object, e As EventArgs) Handles cbbCashSelectPayment.DropDown
        Me.cbbCashSelectPayment.Items.Clear()
        Me.cbbCashSelectPayment.Items.Add("เงินสด")
        Me.cbbCashSelectPayment.Items.Add("เช็ค")
        Me.cbbCashSelectPayment.Items.Add("โอนเข้าบัญชีธนาคาร")
        Me.cbbCashSelectPayment.Items.Add("บัตรเครดิต")
    End Sub

    Private Sub txtCashPercen_TextChanged(sender As Object, e As EventArgs) Handles txtCashPercen.TextChanged
        Try
            Me.txtCashLowerCash.Text = ""
            Me.txtCashCusPrice.Text = "0"
            Me.txtCashCash.Text = SaleFrm.lblPWgetTotalPrice.Text
            If Me.txtCashPercen.Text = "" Then
                Me.txtCashCash.Text = SaleFrm.lblPWgetTotalPrice.Text
            Else
                Me.txtCashCash.Text = SaleFrm.lblPWgetTotalPrice.Text - ((CDec(Me.txtCashPercen.Text) / 100) * CDec(Me.txtCashCash.Text))
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Friend discountDT, tta, cashDetail As String
    Friend dscl As Decimal
    Private Sub discount()
        Try
            Mainfrm.lblMainStatus.Text = "เริ่มส่วนลด"
            If Me.txtCashPercen.Text = "" And Me.txtCashLowerCash.Text = "" Then
                Exit Sub
            Else
                If Not Me.txtCashPercen.Text = "" Then
                    discountDT = "ลด " & Me.txtCashPercen.Text & " %"
                ElseIf Not Me.txtCashLowerCash.Text = "" Then
                    discountDT = "ลด " & Me.txtCashLowerCash.Text & " บาท"
                End If
                Mainfrm.lblMainStatus.Text = "บันทึกส่วนลด"

                dscl = CDec(SaleFrm.lblPWgetTotalPrice.Text) - CDec(Me.txtCashCash.Text)

                If Me.cbbCashSelectPayment.Text = "เงินสด" Then
                    cashDetail = "เงินสด"
                ElseIf Me.cbbCashSelectPayment.Text = "เช็ค" Then
                    cashDetail = "เช็ค\" & "หมายเลข " & Me.txtCashByselectPayment.Text & "\ลงวันที่ " & Convert.ToDateTime(Me.DateTimePicker1.Value).ToString _
                        ("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN"))
                ElseIf Me.cbbCashSelectPayment.Text = "โอนเข้าบัญชีธนาคาร" Then
                    cashDetail = "โอนเข้าธนาคาร" & Me.txtCashByselectPayment.Text & "\โอนวันที่ " & Convert.ToDateTime(Me.DateTimePicker1.Value).ToString _
                        ("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN"))
                    'add
                ElseIf Me.cbbCashSelectPayment.Text = "บัตรเครดิต" Then
                    cashDetail = "บัตรเครดิต " & Me.txtCashByselectPayment.Text & " " & Me.cbbCScreditCard.Text & " " & Me.cbbCScreditCardBank.Text _
                        & " " & Convert.ToDateTime(Me.DateTimePicker1.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN"))
                End If
                Mainfrm.lblMainStatus.Text = "บันทึกส่วนลด"
                strSQL = "insert into discount(sale_id,fix_id,cash,cash_back,cash_detail,discount,discount_detail,datetime_save)values" _
                    & "(@sale_id,@fix_id,@cash,@cash_back,@cash_detail,@discount,@discount_detail,@datetime_save)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.Add(New MySqlParameter("@sale_id", SaleFrm.txtPWsaleID.Text))
                    .Parameters.Add(New MySqlParameter("@fix_id", "ขายสินค้า"))
                    .Parameters.Add(New MySqlParameter("@cash", Me.txtCashCusPrice.Text))
                    .Parameters.Add(New MySqlParameter("@cash_back", Me.txtCashBack.Text))
                    .Parameters.Add(New MySqlParameter("@cash_detail", cashDetail))
                    .Parameters.Add(New MySqlParameter("@discount", dscl))
                    .Parameters.Add(New MySqlParameter("@discount_detail", discountDT))
                    .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                End With
                Call open_connection()
                cmd.ExecuteNonQuery()
            End If
            Mainfrm.lblMainStatus.Text = "บันทึกส่วนลดแล้ว"
            'cashDetail = Nothing
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "บันทึกส่วนลดผิดพลาด" & ex.Message
        End Try
    End Sub
    Private Sub txtCashLowerCash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCashLowerCash.KeyPress
        If e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack Or e.KeyChar = "." Then
            If txtCashLowerCash.Text = "" Then 'ตรวจสอบว่า มีค่าใน textbox หรือยัง
                If e.KeyChar = "." Then 'ตรวจสอบว่า ผู้ใช้ป้อน . หรือไม่ ถ้าใช้ให้
                    txtCashLowerCash.Text = "0." 'แทนค่าใน textbox เป็น 0.
                    txtCashLowerCash.SelectionStart() = 2 'สั่งให้ ตัว select อยู่ในตำแหน่งที่ 2 คือ ต่อจาก 0.
                End If
            End If
            If txtCashLowerCash.Text Like "[0]" Then 'ตรวจสอบว่า ใน textbox มีตัวเลข 0 อยู่ด้านหน้าสุดหรือไม่
                If e.KeyChar = "." Or e.KeyChar = vbBack Then 'ถ้ามีให้ รับได้เฉพาะ . กับ backspace
                    e.Handled = False
                Else
                    e.Handled = True
                End If
                txtCashLowerCash.SelectionStart() = 1 'สั่งให้ selecttion เริ่มที่ 0 คือ ต่อจาก 1
                Exit Sub
            End If
            If Me.txtCashLowerCash.Text Like "*[.]*" Then
                If e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
                Exit Sub
            End If
            e.Handled = False
        Else
            e.Handled = True
            'MessageBox.Show("กรุณากรอกเป็นตัวเลข", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCashLowerCash.Focus()
            txtCashLowerCash.SelectAll()
        End If

    End Sub

    Private Sub txtCashLowerCash_TextChanged(sender As Object, e As EventArgs) Handles txtCashLowerCash.TextChanged
        Try
            Me.txtCashPercen.Text = ""
            Me.txtCashCusPrice.Text = "0"
            Me.txtCashCash.Text = SaleFrm.lblPWgetTotalPrice.Text
            If Me.txtCashLowerCash.Text = "" Then
                'Me.txtCashCash.Text = price
            Else
                Me.txtCashCash.Text = CDec(Me.txtCashCash.Text) - CDec(Me.txtCashLowerCash.Text)
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub txtCashCusPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCashCusPrice.KeyPress
        If Me.txtCashCusPrice.Text = "0" Then
            Me.txtCashCusPrice.Text = ""
        End If
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                Mainfrm.lblMainStatus.Text = "ผิดพลาดใส่ได้เฉพาะตัวเลขเท่านั้น"
                MessageBox.Show("ใส่ได้เฉพาะตัวเลขเท่านั้น")
        End Select
    End Sub

    Private Sub txtCashCusID_TextChanged(sender As Object, e As EventArgs) Handles txtCashCusID.TextChanged
        Call getData()
    End Sub

    Private Sub cbbCashSelectPayment_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbCashSelectPayment.SelectedValueChanged
        If Me.cbbCashSelectPayment.Text = "เงินสด" Then
            Me.txtCashByselectPayment.Enabled = False
            Me.DateTimePicker1.Enabled = True
            Me.lblCashSelectPayment.Text = "......"
            Me.lblCashDTP.Text = "วันที่ชำระเงิน(วันนี้)"
            Me.cbbCScreditCard.Enabled = False
            Me.cbbCScreditCardBank.Enabled = False
        ElseIf Me.cbbCashSelectPayment.Text = "เช็ค" Then
            Me.txtCashByselectPayment.Enabled = True
            Me.DateTimePicker1.Enabled = True
            Me.lblCashSelectPayment.Text = "หมายเลขเช็ค"
            Me.lblCashDTP.Text = "สั่งจ่ายวันที่"
            Me.cbbCScreditCard.Enabled = False
            Me.cbbCScreditCardBank.Enabled = False
        ElseIf Me.cbbCashSelectPayment.Text = "โอนเข้าบัญชีธนาคาร" Then
            Me.txtCashByselectPayment.Enabled = True
            Me.DateTimePicker1.Enabled = True
            Me.lblCashSelectPayment.Text = "ชื่อธนาคาร"
            Me.lblCashDTP.Text = "วันที่โอน"
            Me.cbbCScreditCard.Enabled = False
            Me.cbbCScreditCardBank.Enabled = False
        ElseIf Me.cbbCashSelectPayment.Text = "บัตรเครดิต" Then
            Me.txtCashByselectPayment.Enabled = True
            Me.DateTimePicker1.Enabled = True
            Me.cbbCScreditCard.Enabled = True
            Me.cbbCScreditCardBank.Enabled = True
            Me.lblCashSelectPayment.Text = "หมายเลขบัตร/ประเภท"
            Me.lblCashDTP.Text = "วันที่ชำระ/ธ.เจ้าของบัตร"
        End If
    End Sub

    Private Sub btnCashSave_Click(sender As Object, e As EventArgs) Handles btnCashSave.Click
        Dim Ans As String
        Ans = MsgBox("โปรดตรวจสอบความถูกต้องของสินค้า ราคาสินค้าให้เรียบร้อย จากนี้ไปจะไม่สามารถแก้ไขได้อีก", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
        Mainfrm.lblMainStatus.Text = "โปรดตรวจสอบความถูกต้องของสินค้า ราคาสินค้าให้เรียบร้อย จากนี้ไปจะไม่สามารถแก้ไขได้อีก"
        If Ans = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            If Me.cbbCashSelectPayment.Text = "เงินสด" Then
                cashDetail = "เงินสด"
            ElseIf Me.cbbCashSelectPayment.Text = "เช็ค" Then
                cashDetail = "เช็ค\" & "หมายเลข " & Me.txtCashByselectPayment.Text & "\ลงวันที่ " & Convert.ToDateTime _
                    (Me.DateTimePicker1.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN"))
            ElseIf Me.cbbCashSelectPayment.Text = "โอนเข้าบัญชีธนาคาร" Then
                cashDetail = "โอนเข้าธนาคาร" & Me.txtCashByselectPayment.Text & "\โอนวันที่ " & Convert.ToDateTime _
                    (Me.DateTimePicker1.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN"))
                'add
            ElseIf Me.cbbCashSelectPayment.Text = "บัตรเครดิต" Then
                cashDetail = "บัตรเครดิต " & Me.txtCashByselectPayment.Text & " " & Me.cbbCScreditCard.Text & " " & Me.cbbCScreditCardBank.Text _
                    & " " & Convert.ToDateTime(Me.DateTimePicker1.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN"))
            End If
            If Me.btnCashSave.Text = "บันทึกจ่ายเงิน" Then
                If Me.cbbCashSelectPayment.Text = "" Then
                    MsgBox("กรูณาเลือกรูปแบบการชำระเงินก่อน", MsgBoxStyle.Information, "แจ้งเตือน")
                    Mainfrm.lblMainStatus.Text = "กรูณาเลือกรูปแบบการชำระเงินก่อน"
                    Me.lblCashSelectPaymentlbl.BackColor = Color.Orange
                Else
                    Mainfrm.lblMainStatus.Text = "กำลังโหลดบันทึกข้อมูล"
                    Call discount()
                    Call SaleFrm.saveSale_id()
                    Call SaleFrm.saveCash_id()
                    Call SaleFrm.saveCashDGwsnTodatabase()
                    Call SaleFrm.saveCashDGNosnTodatabase()
                    Call SaleFrm.saveCashSaleAll()
                    Mainfrm.lblMainStatus.Text = "กำลังโหลดใบเสร็จรับเงิน"
                    ReceiptSalePrintReportFrm.Show()
                    Me.Enabled = False
                    Call SaleFrm.clearDG()
                    SaleFrm.Close()
                    SaleFrm.MdiParent = Mainfrm
                    SaleFrm.Show()
                    ReceiptSalePrintReportFrm.Activate()
                    Me.Close()
                End If
            ElseIf Me.btnCashSave.Text = "ใบส่งของ" Then
                If txtCashCusID.Text = "0" Then
                    MsgBox("การออกใบส่งของควรเป็นชื่อบุคคล ไม่ใช่ชื่อลูกค้าเงินสด", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Else
                    Mainfrm.lblMainStatus.Text = "กำลังโหลดบันทึกข้อมูล"
                    Call SaleFrm.saveSaleAll()
                    Call SaleFrm.saveSale_id()
                    Call SaleFrm.saveDGwsnTodatabase()
                    Call SaleFrm.saveDGNosnTodatabase()
                    Mainfrm.lblMainStatus.Text = "กำลังโหลดใบส่งของ"
                    InvoiceSaleReportFrm.Show()
                    Me.Enabled = False
                    Call SaleFrm.clearDG()
                    SaleFrm.Close()
                    SaleFrm.MdiParent = Mainfrm
                    SaleFrm.Show()
                    InvoiceSaleReportFrm.Activate()
                    Me.Close()
                End If
                End If

        End If
        'cashDetail = Nothing
    End Sub

    Private Sub cbbCScreditCardBank_DropDown(sender As Object, e As EventArgs) Handles cbbCScreditCardBank.DropDown
        Try
            Me.cbbCScreditCardBank.Items.Clear()
            strSQL = "SELECT bank_name FROM credit_card_bank ORDER BY bank_name DESC"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                While Dr.Read
                    Me.cbbCScreditCardBank.Items.Add(Dr.GetString("bank_name"))
                End While
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub cbbCScreditCard_DropDown(sender As Object, e As EventArgs) Handles cbbCScreditCard.DropDown
        Try
            Me.cbbCScreditCard.Items.Clear()
            strSQL = "SELECT card_type FROM credit_card ORDER BY card_type DESC"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                While Dr.Read
                    Me.cbbCScreditCard.Items.Add(Dr.GetString("card_type"))
                End While
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
End Class