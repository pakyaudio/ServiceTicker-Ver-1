Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class CashFrm
    Friend price As Decimal

    Private Sub CashFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Timer2.Stop()
    End Sub
    Private Sub CashFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        price = Me.txtCashCash.Text
        Me.btnCashSave.Enabled = False
        Me.Icon = Mainfrm.Icon
        DateTimePicker1.Value = DateTime.Now.AddDays(0)
    End Sub
    Friend cashID As String
    Private Sub AutoNumberNo()
        Try
            Using dt = New DataTable
                strSQL = "SELECT ver_debtor,ver_cash FROM ver_detail"
                Mainfrm.lblMainStatus.Text = strSQL
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)
                Dim nid As String = dt.Rows(0).Item("ver_debtor")
                Dim nids As String = dt.Rows(0).Item("ver_cash")
                strSQL = "SELECT Max(ID) as ID FROM pledge_id"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                If Not Dr.HasRows Then
                    Me.txtCashpledgeID.Text = nid & Now.ToString("yyMMddHHmm") & "00001"
                Else
                    Dim newID As Integer = CInt(Dr.Item("ID"))
                    newID += 1
                    Me.txtCashpledgeID.Text = nid & Now.ToString("yyMMddHHmm") & newID.ToString("00000")
                End If
                strSQL = "SELECT Max(ID) as ID FROM cash_id"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                If Not Dr.HasRows Then
                    cashID = nids & Now.ToString("yyMMddHHmm") & "00001"
                Else
                    Dim newID As Integer = CInt(Dr.Item("ID"))
                    newID += 1
                    cashID = nids & Now.ToString("yyMMddHHmm") & newID.ToString("00000")
                End If
                Dr.Close()
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "โหลดตัวเลขอัตโนมัติผิดพลาด" & ex.Message
        End Try
    End Sub

    Private Sub SaveID()
        Try
            strSQL = "insert into pledge_id(pl_id,datetime_save)" _
                              & "values(@pl_id,@datetime_save)"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            With cmd
                .Parameters.Add(New MySqlParameter("@pl_id", Me.txtCashpledgeID.Text))
                .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                Call open_connection()
                .ExecuteNonQuery()
            End With
            Mainfrm.lblMainStatus.Text = "insert into pledge_id แล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "insert into pledge_id ผิพพลาด" & ex.Message
        End Try
    End Sub
    Friend sid, cashDetail, discountDT As String
    Friend tta, dscl As Decimal
  
    Private Sub discount()

        Mainfrm.lblMainStatus.Text = "เริ่มส่วนลด"
        If Me.txtCashPercen.Text = "" And Me.txtCashLowerCash.Text = "" Then
            Exit Sub
        Else
            Try
                If Not Me.txtCashPercen.Text = Nothing Then
                    discountDT = "ลด " & Me.txtCashPercen.Text & " %"
                ElseIf Not Me.txtCashLowerCash.Text = Nothing Then
                    discountDT = "ลด " & Me.txtCashLowerCash.Text & " บาท"
                End If
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try

            Try
                strSQL = "SELECT sale_id,total_all FROM sale WHERE fix_id='" & Me.txtCashFixID.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()

                sid = Dr.Item("sale_id")
                tta = Dr.GetDecimal("total_all")
                dscl = tta - CDec(Me.txtCashCash.Text)
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try

            If Me.cbbCashSelectPayment.Text = "เงินสด" Then
                cashDetail = "เงินสด"
            ElseIf Me.cbbCashSelectPayment.Text = "เช็ค" Then
                cashDetail = "เช็ค\" & "หมายเลข " & Me.txtCashByselectPayment.Text & "\ลงวันที่ " & Convert.ToDateTime(Me.DateTimePicker1.Value).ToString _
                    ("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN"))
            ElseIf Me.cbbCashSelectPayment.Text = "โอนเข้าบัญชีธนาคาร" Then
                cashDetail = "โอนเข้าธนาคาร" & Me.txtCashByselectPayment.Text & "\โอนวันที่ " & Convert.ToDateTime(Me.DateTimePicker1.Value).ToString _
                    ("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN"))
            ElseIf Me.cbbCashSelectPayment.Text = "บัตรเครดิต" Then
                cashDetail = "บัตรเครดิต " & Me.txtCashByselectPayment.Text & " " & Me.cbbCScreditCard.Text & " " & Me.cbbCScreditCardBank.Text _
                    & " " & Convert.ToDateTime(Me.DateTimePicker1.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN"))
            End If

            Try
                strSQL = "insert into discount(sale_id,fix_id,cash,cash_back,cash_detail,discount,discount_detail,datetime_save)values" _
                    & "(@sale_id,@fix_id,@cash,@cash_back,@cash_detail,@discount,@discount_detail,@datetime_save)"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.Add(New MySqlParameter("@sale_id", sid))
                    .Parameters.Add(New MySqlParameter("@fix_id", Me.txtCashFixID.Text))
                    .Parameters.Add(New MySqlParameter("@cash", Me.txtCashCusPrice.Text))
                    .Parameters.Add(New MySqlParameter("@cash_back", Me.txtCashBack.Text))
                    .Parameters.Add(New MySqlParameter("@cash_detail", cashDetail))
                    .Parameters.Add(New MySqlParameter("@discount", dscl))
                    .Parameters.Add(New MySqlParameter("@discount_detail", discountDT))
                    .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                End With
                Call open_connection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
        End If
        Mainfrm.lblMainStatus.Text = "บันทึกส่วนลดแล้ว"
        cashDetail = Nothing

    End Sub

    Private Sub saveDataPledge_sale()
        Try
            strSQL = "SELECT customer_name from sale where fix_id='" & Me.txtCashFixID.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Dim xx As String
            xx = Dr.Item("customer_name")
            Dr.Close()
            strSQL = "insert into pledge_sale(p_id,total1,cash1,transfer1,check1,detail1,customer_id,customer_name,employee,datetime_save)values" _
                & "(@p_id,@total1,@cash1,@transfer1,@check1,@detail1,@customer_id,@customer_name,@employee,@datetime_save)"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            With cmd
                .Parameters.Add(New MySqlParameter("@p_id", Me.txtCashpledgeID.Text))
                .Parameters.Add(New MySqlParameter("@total1", Me.txtCashCusPrice.Text))
                If Me.cbbCashSelectPayment.Text = "เงินสด" Then
                    .Parameters.Add(New MySqlParameter("@cash1", "เงินสด"))
                    .Parameters.Add(New MySqlParameter("@transfer1", "-"))
                    .Parameters.Add(New MySqlParameter("@check1", "-"))
                    .Parameters.Add(New MySqlParameter("@detail1", "มัดจำ/เงินสด"))
                ElseIf Me.cbbCashSelectPayment.Text = "เช็ค" Then
                    .Parameters.Add(New MySqlParameter("@cash1", "-"))
                    .Parameters.Add(New MySqlParameter("@transfer1", "-"))
                    .Parameters.Add(New MySqlParameter("@check1", Me.txtCashByselectPayment.Text))
                    .Parameters.Add(New MySqlParameter("@detail1", "มัดจำ/เช็ค"))
                ElseIf Me.cbbCashSelectPayment.Text = "โอนเข้าบัญชีธนาคาร" Then
                    .Parameters.Add(New MySqlParameter("@cash1", "-"))
                    .Parameters.Add(New MySqlParameter("@transfer1", Me.txtCashByselectPayment.Text))
                    .Parameters.Add(New MySqlParameter("@check1", "-"))
                    .Parameters.Add(New MySqlParameter("@detail1", "มัดจำ/โอนเข้าบัญชีธนาคาร"))
                End If
                .Parameters.Add(New MySqlParameter("@customer_id", Me.txtCashCusID.Text))
                .Parameters.Add(New MySqlParameter("@customer_name", xx))
                .Parameters.Add(New MySqlParameter("@employee", LoginFrm.txtLoginUsername.Text))
                .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                Call open_connection()
                cmd.ExecuteNonQuery()
            End With
            MsgBox("บักทึก มัดจำแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "insert into pledge_sale ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub txtCashPercen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCashPercen.KeyPress
        If e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = vbBack Or e.KeyChar = "." Then
            If txtCashPercen.Text = "" Then 'ตรวจสอบว่า มีค่าใน textbox หรือยัง
                If e.KeyChar = "." Then 'ตรวจสอบว่า ผู้ใช้ป้อน . หรือไม่ ถ้าใช้ให้
                    txtCashPercen.Text = "0." 'แทนค่าใน textbox เป็น 0.
                    txtCashPercen.SelectionStart() = 2 'สั่งให้ ตัว select อยู่ในตำแหน่งที่ 2 คือ ต่อจาก 0.
                End If
            End If
            If txtCashPercen.Text Like "[0]" Then 'ตรวจสอบว่า ใน textbox มีตัวเลข 0 อยู่ด้านหน้าสุดหรือไม่
                If e.KeyChar = "." Or e.KeyChar = vbBack Then 'ถ้ามีให้ รับได้เฉพาะ . กับ backspace
                    e.Handled = False
                Else
                    e.Handled = True
                End If
                txtCashPercen.SelectionStart() = 1 'สั่งให้ selecttion เริ่มที่ 0 คือ ต่อจาก 1
                Exit Sub
            End If
            If Me.txtCashPercen.Text Like "*[.]*" Then
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
            Mainfrm.lblMainStatus.Text = "กรุณากรอกเป็นตัวเลข"
            'MessageBox.Show("กรุณากรอกเป็นตัวเลข", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCashPercen.Focus()
            txtCashPercen.SelectAll()
        End If
    End Sub
    Private Sub txtCashPercen_TextChanged(sender As Object, e As EventArgs) Handles txtCashPercen.TextChanged
        Try
            Me.txtCashLowerCash.Text = ""
            Me.txtCashCusPrice.Text = "0"
            Me.txtCashCash.Text = price
            If Me.txtCashPercen.Text = "" Then
                Me.txtCashCash.Text = price
            Else
                Me.txtCashCash.Text = price - ((CDec(Me.txtCashPercen.Text) / 100) * CDec(Me.txtCashCash.Text))
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
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
            Me.txtCashCash.Text = price
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

    'Private Sub txtCashCusPrice_Click(sender As Object, e As EventArgs) Handles txtCashCusPrice.Click
    '    Me.txtCashCusPrice.Text = ""
    'End Sub

    Private Sub txtCashCusPrice_TextChanged(sender As Object, e As EventArgs) Handles txtCashCusPrice.TextChanged
        Try
            If Me.txtCashCusPrice.Text = "" Then
                Me.txtCashBack.Text = "0"
                Me.txtCashpledgeID.Text = ""
                Me.btnCashSave.Enabled = False
            Else
                Me.txtCashBack.Text = CDec(Me.txtCashCusPrice.Text) - CDec(Me.txtCashCash.Text)
            End If

            If CDec(Me.txtCashCusPrice.Text) >= CDec(Me.txtCashCash.Text) Then
                Me.btnCashSave.Text = "บันทึกจ่ายเงิน"
                Me.txtCashpledgeID.Text = ""
                Me.btnCashSave.Enabled = True
            ElseIf CDec(Me.txtCashCusPrice.Text) < CDec(Me.txtCashCash.Text) Then
                Me.btnCashSave.Text = "มัดจำ"
                Me.btnCashSave.Enabled = True
                Call AutoNumberNo()
                'Call saveDataPledge_sale()
            End If
        Catch ex As Exception

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
                suml += Me.dgCash.Rows(sum).Cells(3).Value
            Next
            Me.txtCcreditTotal.Text = suml
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub PaymentAndsendRepair()
        Try
            strSQL = "Update comfix set status='" & "7 คืนเครื่องแล้ว" & "',date_send='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "' where fix_id='" & Me.txtCashFixID.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            MsgBox("บันทึกคืนเครื่องแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "Update comfix set status ผิพพลาด" & ex.Message
        End Try
    End Sub

    Private Sub txtCashCusID_TextChanged(sender As Object, e As EventArgs) Handles txtCashCusID.TextChanged
        Call getData()
    End Sub

    Private Sub cbbCashSelectPayment_Click(sender As Object, e As EventArgs) Handles cbbCashSelectPayment.Click
        Me.cbbCashSelectPayment.Items.Clear()
        Me.cbbCashSelectPayment.Items.Add("เงินสด")
        Me.cbbCashSelectPayment.Items.Add("เช็ค")
        Me.cbbCashSelectPayment.Items.Add("โอนเข้าบัญชีธนาคาร")
        Me.cbbCashSelectPayment.Items.Add("บัตรเครดิต")
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

    Private Sub SavePaymentsPrice()
        'เมื่อจ่ายเงินครบในบิลขายนั้น ๆ จะทำการก็อปปี้จาก sale,sale_barcode,sale_serial ไปเก็บไว้ใน cash_sale,cash_sale_barcode,cash_sale_serial จากนั้นลบ sale,sale_barcode,sale_serial ออก
        'Try
        '    Mainfrm.lblMainStatus.Text = "ก็อปปี้ pledge_sale ไป cash_pledge_sale"
        '    'ก็อปปี้ pledge_sale ไป cash_pledge_sale
        '    strSQL = "insert into cash_pledge_sale (p_id,total1,cash1,transfer1,check1,detail1,customer_id,customer_name,employee,datetime_save)" _
        '        & "select * from pledge_sale where customer_id='" & Me.txtCashCusID.Text & "'"
        '    Using cmd = New MySqlCommand(strSQL, ConnectionDB)
        '        Call open_connection()
        '        cmd.ExecuteNonQuery()
        '    End Using
        'Catch ex As Exception
        '    Mainfrm.lblMainStatus.Text = "ก็อปปี้ pledge_sale ไป cash_pledge_sale ผิดพลาด " & ex.Message
        '    ' MsgBox(ex.Message & "ก็อปปี้ pledge_sale ไป cash_pledge_sale")
        'End Try
        Try

            'ก็อปปี้ sale ไป cash_sale
            strSQL = "insert into cash_sale (sale_id,fix_id,customer_id,customer_name,total_all,date_in,datetime_save,date_edit,cash,cash_status,employee,return_id)" _
                 & "select * from sale where fix_id='" & Me.txtCashFixID.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ก็อปปี้ sale ไป cash_sale ผิดพลาด " & ex.Message
            'MsgBox(ex.Message & "ก็อปปี้ sale ไป cash_sale")
        End Try
        Try
            'ก็อปปี้ sale_barcode ไป cash_sale_barcode
            strSQL = "insert into cash_sale_barcode (sale_id,customer_id,fix_id,customer_name,customer_tel,code_pro,bar_code,name_pro,total_pro,price_cost,price_buy,unit,type,date_in,datetime_save,return_id,employee)" _
                    & "select * from sale_barcode where fix_id='" & Me.txtCashFixID.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ก็อปปี้ sale_barcode ไป cash_sale_barcode ผิดพลาด " & ex.Message
        End Try
        Try
            'ก็อปปี้ sale_serial ไป cash_sale_serial
            strSQL = "insert into cash_sale_serial (sale_id,fix_id,customer_id,customer_name,name_pro,code_pro,bar_code,serial_pro,date_in,datetime_save,employee)" _
                   & "select * from sale_serial where fix_id='" & Me.txtCashFixID.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ก็อปปี้ sale_serial ไป cash_sale_serial ผิดพลาด " & ex.Message
            'MsgBox(ex.Message & "ก็อปปี้ sale_serial ไป cash_sale_serial")
        End Try

        'อัพเดทวันที่บันทึก
        If Me.cbbCashSelectPayment.Text = "เงินสด" Then
            cashDetail = "เงินสด"
        ElseIf Me.cbbCashSelectPayment.Text = "เช็ค" Then
            cashDetail = "เช็ค\" & "หมายเลข " & Me.txtCashByselectPayment.Text & "\ลงวันที่ " & Convert.ToDateTime(Me.DateTimePicker1.Value).ToString _
                ("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN"))
        ElseIf Me.cbbCashSelectPayment.Text = "โอนเข้าบัญชีธนาคาร" Then
            cashDetail = "โอนเข้าธนาคาร" & Me.txtCashByselectPayment.Text & "\โอนวันที่ " & Convert.ToDateTime(Me.DateTimePicker1.Value).ToString _
                ("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN"))
        ElseIf Me.cbbCashSelectPayment.Text = "บัตรเครดิต" Then
            cashDetail = "บัตรเครดิต " & Me.txtCashByselectPayment.Text & " " & Me.cbbCScreditCard.Text & " " & Me.cbbCScreditCardBank.Text _
                & " " & Convert.ToDateTime(Me.DateTimePicker1.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN"))
        End If

        'อัพเดทวันที่,หมายเลขจ่ายเงิน cash ID บันทึกข้อมูล      
        Try
            Mainfrm.lblMainStatus.Text = "insert into cash_id "
            strSQL = "insert into cash_id(cash_id,datetime_save)values(@ci,@dts)"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            With cmd
                .Parameters.Add(New MySqlParameter("@ci", cashID))
                .Parameters.Add(New MySqlParameter("@dts", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                Call open_connection()
                cmd.ExecuteNonQuery()
            End With
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "insert into cash_id ผิดพลาด " & ex.Message
            'MsgBox(ex.Message & "อัพเดทวันที่,หมายเลขจ่ายเงิน cash ID บันทึกข้อมูล")
        End Try
        'Try
        '    'อัพเดท cash_pledge_sale
        '    Mainfrm.lblMainStatus.Text = "UPDATE cash_pledge_sale "
        '    strSQL = "UPDATE cash_pledge_sale SET cash_id='" & cashID & "', datetime_save='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "',employee='" & LoginFrm.txtLoginUsername.Text & "' where customer_id='" & Me.txtCashCusID.Text & "' ORDER BY datetime_save DESC "
        '    cmd = New MySqlCommand(strSQL, ConnectionDB)
        '    Call open_connection()
        '    cmd.ExecuteNonQuery()
        'Catch ex As Exception
        '    Mainfrm.lblMainStatus.Text = "UPDATE cash_pledge_sale ผิดพลาด" & ex.Message
        '    ' MsgBox(ex.Message & "อัพเดท cash_pledge_sale")
        'End Try
        Try
            'อัพเดท cash_sale
            strSQL = "UPDATE cash_sale SET cash_id='" & cashID & "', datetime_save='" & DateTime.Now.ToString _
                ("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "',cash_status='" & "ชำระเงิน" & "',employee='" & _
                LoginFrm.txtLoginUsername.Text & "',cash='" & Me.txtCashCusPrice.Text & "',cash_back='" & Me.txtCashBack.Text & _
                "',cash_detail='" & cashDetail & "' where fix_id='" & Me.txtCashFixID.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "UPDATE cash_sale ผิดพลาด" & ex.Message
            ' MsgBox(ex.Message & "อัพเดท cash_sale")
        End Try
        Try
            'อัพเดท cash_sale_barcode
            strSQL = "UPDATE cash_sale_barcode SET cash_id='" & cashID & "', datetime_save='" & DateTime.Now.ToString _
                ("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "',employee='" & LoginFrm.txtLoginUsername.Text & _
                "' where fix_id='" & Me.txtCashFixID.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "UPDATE cash_sale_barcode ผิดพลาด" & ex.Message
            ' MsgBox(ex.Message & "อัพเดท cash_sale_barcode")
        End Try
        Try
            'อัพเดท cash_sale_serial
            strSQL = "UPDATE cash_sale_serial SET cash_id='" & cashID & "', datetime_save='" & DateTime.Now.ToString _
                ("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "',employee='" & LoginFrm.txtLoginUsername.Text & _
                "' where fix_id='" & Me.txtCashFixID.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "UPDATE cash_sale_serial ผิดพลาด" & ex.Message
            'MsgBox(ex.Message & "อัพเดท cash_sale_serial")
        End Try

        'strSQL = "update cash_sale set datetime_save='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "',date_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "',cash_status='" & "ชำระเงิน" & "',employee='" & LoginFrm.txtLoginUsername.Text & "',cash='" & Me.txtCashCusPrice.Text & "',cash_back='" & Me.txtCashBack.Text & "',cash_detail='" & cashDetail & "' where fix_id='" & Me.txtCashFixID.Text & "'"
        'Using cmd = New MySqlCommand(strSQL, ConnectionDB)
        '    Call open_connection()
        '    cmd.ExecuteNonQuery()
        'End Using

        'strSQL = "update cash_sale_barcode set datetime_save='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "',employee='" & LoginFrm.txtLoginUsername.Text & "' where fix_id='" & Me.txtCashFixID.Text & "'"
        'Using cmd = New MySqlCommand(strSQL, ConnectionDB)
        '    Call open_connection()
        '    cmd.ExecuteNonQuery()
        'End Using

        'strSQL = "update cash_sale_serial set datetime_save='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "',employee='" & LoginFrm.txtLoginUsername.Text & "' where fix_id='" & Me.txtCashFixID.Text & "'"
        'Using cmd = New MySqlCommand(strSQL, ConnectionDB)
        '    Call open_connection()
        '    cmd.ExecuteNonQuery()
        'End Using
        Try
            'ลบ pledge_sale
            'Mainfrm.lblMainStatus.Text = "delete from pledge_sale "
            'strSQL = "delete from pledge_sale where customer_id='" & Me.txtCashCusID.Text & "'"
            'Using cmd = New MySqlCommand(strSQL, ConnectionDB)
            '    Call open_connection()
            '    cmd.ExecuteNonQuery()
            'End Using
            'ลบ sale
            strSQL = "delete from sale where fix_id='" & Me.txtCashFixID.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            End Using
            'ลบ sale_barcode
            strSQL = "delete from sale_barcode where fix_id='" & Me.txtCashFixID.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            End Using
            'ลบ sale_serial
            strSQL = "delete from sale_serial where fix_id='" & Me.txtCashFixID.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            End Using
            Mainfrm.lblMainStatus.Text = "บันทึกจ่ายเงินแล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ลบข้อมูลผิดพลาด " & ex.Message
            ' MsgBox(ex.Message & "ลบข้อมูลออก")
        End Try
    End Sub

    Private Sub btnCashSave_Click(sender As Object, e As EventArgs) Handles btnCashSave.Click
        If Me.cbbCashSelectPayment.Text = "เงินสด" Then
            cashDetail = "เงินสด"
        ElseIf Me.cbbCashSelectPayment.Text = "เช็ค" Then
            cashDetail = "เช็ค\" & "หมายเลข " & Me.txtCashByselectPayment.Text & "\ลงวันที่ " & Convert.ToDateTime(Me.DateTimePicker1.Value).ToString _
                ("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN"))
        ElseIf Me.cbbCashSelectPayment.Text = "โอนเข้าบัญชีธนาคาร" Then
            cashDetail = "โอนเข้าธนาคาร" & Me.txtCashByselectPayment.Text & "\โอนวันที่ " & Convert.ToDateTime(Me.DateTimePicker1.Value).ToString _
                ("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN"))
        ElseIf Me.cbbCashSelectPayment.Text = "บัตรเครดิต" Then
            cashDetail = "บัตรเครดิต " & Me.txtCashByselectPayment.Text & " " & Me.cbbCScreditCard.Text & " " & Me.cbbCScreditCardBank.Text _
                & " " & Convert.ToDateTime(Me.DateTimePicker1.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN"))
        End If
        If Me.btnCashSave.Text = "มัดจำ" Then
            If Me.cbbCashSelectPayment.Text = "" Then
                MsgBox("กรูณาเลือกรูปแบบการชำระเงินก่อน", MsgBoxStyle.Information, "แจ้งเตือน")
                Me.lblCashSelectPaymentlbl.BackColor = Color.Orange
            Else
                Call SaveID()
                Call saveDataPledge_sale()
                Call PaymentAndsendRepair()
                Mainfrm.lblMainStatus.Text = "รอสักครู่ กำลังเรียกฟอร์มการพิมพ์"
                'If MessageBox.Show("ต้องการจะพิมพ์ใบมัดจำหรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                '    CreditReportFrm.Show()
                '    SendRepairPrintFrm.Show()
                'Else
                SendRepairPrintFrm.Show()
                CreditReportFrm.Show()
                Mainfrm.lblMainStatus.Text = "พร้อมใช้งาน"
                'End If

                Me.Timer1.Start()
                'ปิดหน้าต่างที่หน้าปริ๊นต์
            End If
        ElseIf Me.btnCashSave.Text = "บันทึกจ่ายเงิน" Then
            If Me.cbbCashSelectPayment.Text = "" Then
                MsgBox("กรูณาเลือกรูปแบบการชำระเงินก่อน", MsgBoxStyle.Information, "แจ้งเตือน")
                Me.lblCashSelectPaymentlbl.BackColor = Color.Orange
            Else
                Call discount()
                Call PaymentAndsendRepair()

                'If MessageBox.Show("ต้องการจะพิมพ์ใบเสร็จรับเงินหรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                '    ReceiptReportPrintFrm.Show()
                '    SendRepairPrintFrm.Show()
                'Else
                'End If
                Mainfrm.lblMainStatus.Text = "รอสักครู่ กำลังเรียกฟอร์มการพิมพ์"
                SendRepairPrintFrm.Show()
                ReceiptReportPrintFrm.Show()
                Mainfrm.lblMainStatus.Text = "พร้อมใช้งาน"
                Call SavePaymentsPrice()
                Me.Timer1.Start()
                'ปิดหน้าต่างที่หน้าปริ๊นต์
            End If
        End If
        cashDetail = Nothing
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SendRepairFrm.Close()
        Me.Timer2.Start()
        Me.Timer1.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Close()
        RepairStatusFrm.reLoadFrm()
        If ReceiptReportPrintFrm.WindowState = FormWindowState.Normal Then
            SendRepairPrintFrm.Activate()
            ReceiptReportPrintFrm.Activate()
        ElseIf CreditReportFrm.WindowState = FormWindowState.Normal Then
            SendRepairPrintFrm.Activate()
            CreditReportFrm.Activate()
        End If
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