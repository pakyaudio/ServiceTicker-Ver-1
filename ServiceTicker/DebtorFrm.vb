Imports MySql.Data.MySqlClient
Imports System.Globalization
'เกือบเสร็จเหลือ ปิดปุ่มเลือกข้อมูลเวลากดปุมทั้งหมด
'ปรับปรุง 20160114
Public Class DebtorFrm
    Dim nid As String
    Dim nids As String
    Private Sub AutoNumberNo()
        Try
            dt = New DataTable
            strSQL = "SELECT ver_debtor,ver_cash FROM ver_detail"
            Mainfrm.lblMainStatus.Text = strSQL
            dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
            Call open_connection()
            dtAdapter.Fill(dt)
            nid = dt.Rows(0).Item("ver_debtor")
            nids = dt.Rows(0).Item("ver_cash")
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try

        Try
            strSQL = "SELECT Max(ID) as ID FROM pledge_id"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                Me.txtDTautonumDT.Text = nid & Now.ToString("yyMMddHHmm") & "00001"
            Else
                Dim newID As Integer = CInt(Dr.Item("ID"))
                newID += 1
                Me.txtDTautonumDT.Text = nid & Now.ToString("yyMMddHHmm") & newID.ToString("00000")
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try

        Try
            strSQL = "SELECT Max(ID) as ID FROM cash_id"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                Me.txtDTcashID.Text = nids & Now.ToString("yyMMddHHmm") & "00001"
            Else
                Dim newID As Integer = CInt(Dr.Item("ID"))
                newID += 1
                Me.txtDTcashID.Text = nids & Now.ToString("yyMMddHHmm") & newID.ToString("00000")
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub SaveID()
        Try
            strSQL = "insert into pledge_id(pl_id,datetime_save)" _
                          & "values(@pl_id,@datetime_save)"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            With cmd
                .Parameters.Add(New MySqlParameter("@pl_id", Me.txtDTautonumDT.Text))
                .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                Call open_connection()
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub saveDataPledge_sale()
        Try
            strSQL = "insert into pledge_sale(p_id,total1,cash1,transfer1,check1,detail1,customer_id,customer_name,employee,datetime_save)values" _
             & "(@p_id,@total1,@cash1,@transfer1,@check1,@detail1,@customer_id,@customer_name,@employee,@datetime_save)"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            With cmd
                .Parameters.Add(New MySqlParameter("@p_id", Me.txtDTautonumDT.Text))
                .Parameters.Add(New MySqlParameter("@total1", Me.txtDTpaymentsPrice.Text))
                If Me.cbbDTpayments.Text = "เงินสด" Then
                    .Parameters.Add(New MySqlParameter("@cash1", "เงินสด"))
                    .Parameters.Add(New MySqlParameter("@transfer1", "-"))
                    .Parameters.Add(New MySqlParameter("@check1", "-"))
                    .Parameters.Add(New MySqlParameter("@detail1", "มัดจำ/เงินสด"))
                ElseIf Me.cbbDTpayments.Text = "เช็ค" Then
                    .Parameters.Add(New MySqlParameter("@cash1", "-"))
                    .Parameters.Add(New MySqlParameter("@transfer1", "-"))
                    .Parameters.Add(New MySqlParameter("@check1", Me.txtDTpayments.Text))
                    .Parameters.Add(New MySqlParameter("@detail1", "มัดจำ/เช็ค"))
                ElseIf Me.cbbDTpayments.Text = "โอนเข้าบัญชีธนาคาร" Then
                    .Parameters.Add(New MySqlParameter("@cash1", "-"))
                    .Parameters.Add(New MySqlParameter("@transfer1", Me.txtDTpayments.Text))
                    .Parameters.Add(New MySqlParameter("@check1", "-"))
                    .Parameters.Add(New MySqlParameter("@detail1", "มัดจำ/โอนเข้าบัญชีธนาคาร"))
                End If
                .Parameters.Add(New MySqlParameter("@customer_id", Me.txtDTcustomer_id.Text))
                .Parameters.Add(New MySqlParameter("@customer_name", Me.txtDTcustomer_name.Text))
                .Parameters.Add(New MySqlParameter("@employee", LoginFrm.txtLoginUsername.Text))
                .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                Call open_connection()
                cmd.ExecuteNonQuery()
            End With
            MsgBox("บักทึก มัดจำแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub CleartxtCus()
            Me.txtDTcustomer_id.Clear()
            Me.txtDTcustomer_name.Clear()
            Me.txtDTcustomer_address.Clear()
            Me.txtDTcustomer_tel.Clear()
    End Sub

    Private Sub CloseDebtorShow()
        If DebtorShowProFrm.WindowState = FormWindowState.Normal Or DebtorShowProFrm.WindowState = FormWindowState.Maximized _
            Or DebtorShowProFrm.WindowState = FormWindowState.Minimized Then
            DebtorShowProFrm.Close()
        End If
    End Sub
    Private Sub DebtorFrm_Click(sender As Object, e As EventArgs) Handles Me.Click
        Call CloseDebtorShow()
    End Sub

    Private Sub DebtorFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
       Call CloseDebtorShow()
    End Sub

    Private Sub DebtorFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        Call AutoNumberNo()
        DateTimePicker1.Value = DateTime.Now.AddDays(0)
        DateTimePicker2.Value = DateTime.Now.AddDays(0)
        DateTimePicker3.Value = DateTime.Now.AddDays(0)
        Me.btnDTselectAll.Enabled = False
        Me.btnDTprintProBill.Enabled = False
        Me.btnDTsave.Enabled = False
        Me.cbbDTpayments.Enabled = False
        Me.txtDTpayments.Enabled = False
        Me.txtDTpaymentsPrice.Enabled = False
        Me.btnDTpledge.Enabled = True
        Me.DateTimePicker3.Enabled = False
    End Sub
    Private Sub startfrm()
        Call AutoNumberNo()
        DateTimePicker1.Value = DateTime.Now.AddDays(0)
        DateTimePicker2.Value = DateTime.Now.AddDays(0)
        Me.btnDTselectAll.Enabled = False
        Me.btnDTprintProBill.Enabled = False
        Me.btnDTsave.Enabled = False
        Me.cbbDTpayments.Enabled = False
        Me.txtDTpayments.Enabled = False
        Me.txtDTpaymentsPrice.Enabled = False
        Me.btnDTpledge.Enabled = True
        Me.DateTimePicker3.Enabled = False
        Me.dgDTshowAll.Rows.Clear()
        Me.dgDTselectPayments.Rows.Clear()
        Me.txtDTcustomer_id.Clear()
        Me.txtDTcustomer_address.Clear()
        Me.txtDTcustomer_name.Clear()
        Me.txtDTcustomer_tel.Clear()
        Me.txtDTsearch.Clear()
        Me.txtDTpayments.Clear()
        Me.txtDTpaymentsPrice.Text = ""
        Me.txtDTsumALLselectPayments.Text = ""
    End Sub

    Private Sub cbbDTpayments_Click(sender As Object, e As EventArgs) Handles cbbDTpayments.Click
        Call CloseDebtorShow()
        Me.cbbDTpayments.Items.Clear()
        Me.cbbDTpayments.Items.Add("เงินสด")
        Me.cbbDTpayments.Items.Add("เช็ค")
        Me.cbbDTpayments.Items.Add("โอนเข้าบัญชีธนาคาร")
    End Sub

    Private Sub cbbDTpayments_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbDTpayments.SelectedValueChanged
        If Me.cbbDTpayments.Text = "เลือกรูปแบบการชำระเงิน" Then
            Me.lblDTpayments.Text = ""
            Me.txtDTpayments.Enabled = False
            Me.txtDTpaymentsPrice.Enabled = False
        ElseIf Me.cbbDTpayments.Text = "เงินสด" Then
            Me.txtDTpayments.Enabled = False
            Me.txtDTpaymentsPrice.Enabled = True
            Me.lblDTpayments.Text = ""
        ElseIf Me.cbbDTpayments.Text = "เช็ค" Then
            Me.txtDTpayments.Enabled = True
            Me.txtDTpaymentsPrice.Enabled = True
            Me.lblDTpayments.Text = "หมายเลขเช็ค"
        ElseIf Me.cbbDTpayments.Text = "โอนเข้าบัญชีธนาคาร" Then
            Me.txtDTpayments.Enabled = True
            Me.txtDTpaymentsPrice.Enabled = True
            Me.lblDTpayments.Text = "โอนเข้าธนาคาร/เวลา"
        End If
    End Sub
    Private Sub sumALL()
        Try
            If Me.dgDTshowAll.Rows.Count <= 0 Then
                Me.txtDTsumALL.Text = ""
                Me.txtDTpledge.Text = ""
            Else
                Dim all, p_all As Decimal
                For sum As Integer = 0 To Me.dgDTshowAll.Rows.Count - 1
                    all += CDec(Me.dgDTshowAll.Rows(sum).Cells(9).Value)
                    p_all += CDec(Me.dgDTshowAll.Rows(sum).Cells(8).Value)
                    Me.txtDTsumALL.Text = all.ToString("N2")
                    Me.txtDTpledge.Text = p_all.ToString("N2")
                    Me.dgDTshowAll.Rows(sum).Cells(0).Value = sum + 1
                Next
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub sumALLselectPayments()
        Try
            If Me.dgDTselectPayments.Rows.Count <= 0 Then
                Me.txtDTsumALLselectPayments.Text = ""
            Else
                Dim all As Decimal
                For sum As Integer = 0 To Me.dgDTselectPayments.Rows.Count - 1
                    all += CDec(Me.dgDTselectPayments.Rows(sum).Cells(9).Value)
                    Me.txtDTsumALLselectPayments.Text = all.ToString("N2")
                    Me.dgDTselectPayments.Rows(sum).Cells(0).Value = sum + 1
                Next
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub getDataAll()
        Try
            Me.txtDTsumALLselectPayments.Text = ""
            Me.dgDTselectPayments.Rows.Clear()
            Call CleartxtCus()
            Me.dgDTshowAll.Rows.Clear()
            strSQL = "SELECT sale_id,customer_id,customer_name,datetime_save,cash,total_all FROM sale"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dim r As Integer
                While Dr.Read
                    With dgDTshowAll
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells("sale_id").Value = Dr.Item("sale_id")
                        .Rows(r).Cells("detail").Value = "-"
                        .Rows(r).Cells("customer_id").Value = Dr.Item("customer_id")
                        .Rows(r).Cells("customer_name").Value = Dr.Item("customer_name")
                        .Rows(r).Cells("datetime_save").Value = Dr.Item("datetime_save")
                        .Rows(r).Cells("cash").Value = Dr.Item("cash")
                        .Rows(r).Cells("total_all").Value = Dr.GetDecimal("total_all")
                        .Rows(r).Cells("pledge").Value = "0"
                        .Rows(r).Cells("balance").Value = CDec(.Rows(r).Cells("total_all").Value) - CDec(.Rows(r).Cells("cash").Value)
                    End With
                End While
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try

        Try
            strSQL = "SELECT p_id,customer_id,customer_name,detail1,total1,datetime_save FROM pledge_sale"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dim r As Integer
                While Dr.Read
                    With dgDTshowAll
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells("sale_id").Value = Dr.Item("p_id")
                        .Rows(r).Cells("detail").Value = Dr.Item("detail1")
                        .Rows(r).Cells("customer_id").Value = Dr.Item("customer_id")
                        .Rows(r).Cells("customer_name").Value = Dr.Item("customer_name")
                        .Rows(r).Cells("datetime_save").Value = Dr.Item("datetime_save")
                        .Rows(r).Cells("cash").Value = "0"
                        .Rows(r).Cells("total_all").Value = "0"
                        .Rows(r).Cells("pledge").Value = Dr.GetDecimal("total1")
                        .Rows(r).Cells("balance").Value = -CDec(.Rows(r).Cells("pledge").Value)
                    End With
                End While
            End Using
            Call sumALL()

        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub btnDTgetDataAll_Click(sender As Object, e As EventArgs) Handles btnDTgetDataAll.Click
        Call CloseDebtorShow()
        Me.btnDTpledge.Enabled = False
        Me.btnDTselectAll.Enabled = False
        Me.btnDTprintProBill.Enabled = False
        Call getDataAll()
    End Sub

    Private Sub searchData()
        Try
            Me.txtDTsumALLselectPayments.Text = ""
            Me.dgDTshowAll.Rows.Clear()
            strSQL = "SELECT sale_id,customer_id,customer_name,datetime_save,cash,total_all FROM sale " & _
                "WHERE customer_id='" & Me.txtDTcustomer_id.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dim r As Integer
                While Dr.Read
                    With dgDTshowAll
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells("sale_id").Value = Dr.Item("sale_id")
                        .Rows(r).Cells("detail").Value = "-"
                        .Rows(r).Cells("customer_id").Value = Dr.Item("customer_id")
                        .Rows(r).Cells("customer_name").Value = Dr.Item("customer_name")
                        .Rows(r).Cells("datetime_save").Value = Dr.Item("datetime_save")
                        .Rows(r).Cells("cash").Value = Dr.GetDecimal("cash")
                        .Rows(r).Cells("total_all").Value = Dr.GetDecimal("total_all")
                        .Rows(r).Cells("pledge").Value = "0"
                        .Rows(r).Cells("balance").Value = CDec(.Rows(r).Cells("total_all").Value) - CDec(.Rows(r).Cells("cash").Value)
                    End With
                End While
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try

        Try
            strSQL = "SELECT p_id,customer_id,customer_name,detail1,total1,datetime_save FROM pledge_sale " & _
                "WHERE customer_id='" & Me.txtDTcustomer_id.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dim r As Integer
                While Dr.Read
                    With dgDTshowAll
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells("sale_id").Value = Dr.Item("p_id")
                        .Rows(r).Cells("detail").Value = Dr.Item("detail1")
                        .Rows(r).Cells("customer_id").Value = Dr.Item("customer_id")
                        .Rows(r).Cells("customer_name").Value = Dr.Item("customer_name")
                        .Rows(r).Cells("datetime_save").Value = Dr.Item("datetime_save")
                        .Rows(r).Cells("cash").Value = "0"
                        .Rows(r).Cells("total_all").Value = "0"
                        .Rows(r).Cells("pledge").Value = Dr.GetDecimal("total1")
                        .Rows(r).Cells("balance").Value = -CDec(.Rows(r).Cells("pledge").Value)
                    End With
                End While
            End Using
            Call sumALL()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub searchDataBysearch()
        Try
            Me.txtDTsumALLselectPayments.Text = ""
            Me.dgDTshowAll.Rows.Clear()
            strSQL = "SELECT sale_id,customer_id,customer_name,datetime_save,cash,total_all FROM " & _
                "sale WHERE customer_name LIKE'%" & Me.txtDTsearch.Text & "%'"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dim r As Integer
                While Dr.Read
                    With dgDTshowAll
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells("sale_id").Value = Dr.Item("sale_id")
                        .Rows(r).Cells("detail").Value = "-"
                        .Rows(r).Cells("customer_id").Value = Dr.Item("customer_id")
                        .Rows(r).Cells("customer_name").Value = Dr.Item("customer_name")
                        .Rows(r).Cells("datetime_save").Value = Dr.Item("datetime_save")
                        .Rows(r).Cells("cash").Value = Dr.GetDecimal("cash")
                        .Rows(r).Cells("total_all").Value = Dr.GetDecimal("total_all")
                        .Rows(r).Cells("pledge").Value = "0"
                        .Rows(r).Cells("balance").Value = CDec(.Rows(r).Cells("total_all").Value) - CDec(.Rows(r).Cells("cash").Value)
                    End With
                End While
            End Using
            Call sumALL()
            Me.txtDTsearch.Clear()
            Me.txtDTsearch.Focus()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub getDataCustomer()
        Try
            Me.txtDTsumALLselectPayments.Text = ""
            Me.txtDTcustomer_name.Text = ""
            Me.txtDTcustomer_address.Text = ""
            Me.txtDTcustomer_tel.Text = ""
            strSQL = "SELECT customer_name,customer_address,customer_tel from customer where customer_id='" & Me.txtDTcustomer_id.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                While Dr.Read
                    Me.txtDTcustomer_name.Text = Dr.Item("customer_name")
                    Me.txtDTcustomer_address.Text = Dr.Item("customer_address")
                    Me.txtDTcustomer_tel.Text = Dr.Item("customer_tel")
                End While
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub searchByDate()
        Try
            Me.dgDTshowAll.Rows.Clear()
            Me.dgDTselectPayments.Rows.Clear()
            strSQL = "SELECT sale_id,customer_id,customer_name,datetime_save,cash,total_all FROM sale " & _
                "WHERE datetime_save BETWEEN '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "' AND " & _
                "'" & Convert.ToDateTime(DateTimePicker2.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dim r As Integer
                While Dr.Read
                    With dgDTshowAll
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells("sale_id").Value = Dr.Item("sale_id")
                        .Rows(r).Cells("detail").Value = "-"
                        .Rows(r).Cells("customer_id").Value = Dr.Item("customer_id")
                        .Rows(r).Cells("customer_name").Value = Dr.Item("customer_name")
                        .Rows(r).Cells("datetime_save").Value = Dr.Item("datetime_save")
                        .Rows(r).Cells("cash").Value = Dr.GetDecimal("cash")
                        .Rows(r).Cells("total_all").Value = Dr.GetDecimal("total_all")
                        .Rows(r).Cells("pledge").Value = "0"
                        .Rows(r).Cells("balance").Value = CDec(.Rows(r).Cells("total_all").Value) - CDec(.Rows(r).Cells("cash").Value)
                    End With
                End While
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try

        Try
            strSQL = "SELECT p_id,customer_id,customer_name,detail1,total1,datetime_save FROM pledge_sale " & _
                "WHERE datetime_save BETWEEN '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "' AND " & _
                "'" & Convert.ToDateTime(DateTimePicker2.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dim r As Integer
                While Dr.Read
                    With dgDTshowAll
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells("sale_id").Value = Dr.Item("p_id")
                        .Rows(r).Cells("detail").Value = Dr.Item("detail1")
                        .Rows(r).Cells("customer_id").Value = Dr.Item("customer_id")
                        .Rows(r).Cells("customer_name").Value = Dr.Item("customer_name")
                        .Rows(r).Cells("datetime_save").Value = Dr.Item("datetime_save")
                        .Rows(r).Cells("cash").Value = "0"
                        .Rows(r).Cells("total_all").Value = "0"
                        .Rows(r).Cells("pledge").Value = Dr.GetDecimal("total1")
                        .Rows(r).Cells("balance").Value = -CDec(.Rows(r).Cells("pledge").Value)
                    End With
                End While
            End Using
            Call sumALL()

        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub txtDTshowProduct_Click(sender As Object, e As EventArgs) Handles txtDTshowProduct.Click
        If Me.dgDTshowAll.Rows.Count <= 0 Then
        Else
            If DebtorShowProFrm.WindowState = FormWindowState.Normal Or DebtorShowProFrm.WindowState = FormWindowState.Maximized _
             Or DebtorShowProFrm.WindowState = FormWindowState.Minimized Then
                DebtorShowProFrm.Close()
                DebtorShowProFrm.lblShowText.Text = Me.dgDTshowAll.SelectedCells.Item(1).Value
                DebtorShowProFrm.MdiParent = Mainfrm
                DebtorShowProFrm.Show()
            Else
                DebtorShowProFrm.lblShowText.Text = Me.dgDTshowAll.SelectedCells.Item(1).Value
                DebtorShowProFrm.MdiParent = Mainfrm
                DebtorShowProFrm.Show()
            End If
        End If
    End Sub

    Private Sub dgDTshowAll_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDTshowAll.CellDoubleClick
        Call CloseDebtorShow()
        If Me.dgDTshowAll.SelectedRows.Count <= 0 Then
        Else
            Me.txtDTcustomer_id.Text = Me.dgDTshowAll.SelectedCells.Item(3).Value
        End If

    End Sub

    Private Sub txtDTcustomer_id_TextChanged(sender As Object, e As EventArgs) Handles txtDTcustomer_id.TextChanged
        If Me.txtDTcustomer_id.Text = "" Then
            Me.btnDTpledge.Enabled = False
            Me.cbbDTpayments.Enabled = False
            Me.txtDTpaymentsPrice.Enabled = False
        Else
            Me.dgDTshowAll.Rows.Clear()
            Call searchData()
            Call getDataCustomer()
            'Me.cbbDTpayments.Enabled = True
            'Me.txtDTpayments.Enabled = True
            'Me.txtDTpaymentsPrice.Enabled = False
            Me.btnDTpledge.Enabled = True
        End If
       
    End Sub

    Private Sub btnDTsearchByDate_Click(sender As Object, e As EventArgs) Handles btnDTsearchByDate.Click
        Call CloseDebtorShow()
        Me.btnDTpledge.Enabled = False
        Me.btnDTselectAll.Enabled = False
        Me.btnDTprintProBill.Enabled = False
        Me.dgDTshowAll.Rows.Clear()
        Call CleartxtCus()
        Call searchByDate()
    End Sub

    Private Sub txtDTcustomer_name_TextChanged(sender As Object, e As EventArgs) Handles txtDTcustomer_name.TextChanged
        Me.btnDTselectAll.Enabled = True
        Me.btnDTprintProBill.Enabled = True
    End Sub

    Private Sub txtDTsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDTsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnDTselectAll.Enabled = False
            Me.btnDTprintProBill.Enabled = False
            Call CleartxtCus()
            Call searchDataBysearch()
        End If
    End Sub
    Friend cANDp, cANDp1 As String
    Private Sub btnDTpledge_Click(sender As Object, e As EventArgs) Handles btnDTpledge.Click
        If Me.btnDTpledge.Text = "มัดจำ" Then
            MsgBox("กรุณาใส่ตัวเลข", MsgBoxStyle.Exclamation, "แจ้งเตือน")
            Me.txtDTpaymentsPrice.Enabled = True
            Me.cbbDTpayments.Enabled = True
            Me.DateTimePicker3.Enabled = True
            Me.txtDTpaymentsPrice.Focus()
            Me.txtDTpaymentsPrice.BackColor = Color.Salmon
            Me.btnDTpledge.Text = "บันทึก"
            Exit Sub
        ElseIf Me.btnDTpledge.Text = "บันทึก" Then
            If Me.txtDTcustomer_id.Text = "" Then
                MsgBox("กรุณาเลือกรายชื่อลูกค้าที่ต้องการมัดจำ", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                DebtorSelectCustomerFrm.MdiParent = Mainfrm
                DebtorSelectCustomerFrm.Show()
                Exit Sub
            End If
            If Me.txtDTpaymentsPrice.Text = "" Then
                MsgBox("กรุณาใส่ข้อมูล.", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Me.txtDTpaymentsPrice.Focus()
                Me.txtDTpaymentsPrice.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.cbbDTpayments.Text = "" Then
                MsgBox("กรุณาเลือกรูปแบบการมัดจำ.", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Me.cbbDTpayments.Focus()
                Me.lblDTcbbpayments.BackColor = Color.Salmon
                Exit Sub
            End If
            Call SaveID()
            Call saveDataPledge_sale()
            If MessageBox.Show("ต้องการจะพิมพ์ใบมัดจำหรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                cANDp = "ใบมัดจำ/ลดหนี้"
                cANDp1 = "มัดจำ/ลดหนี้"
                DebtorBillingPrintFrm.Show()
            Else
            End If

            Me.btnDTpledge.Text = "มัดจำ"
            Me.txtDTpaymentsPrice.Clear()
            Me.txtDTpaymentsPrice.Enabled = False
            Call startfrm()
        End If
    End Sub

    Private Sub txtDTpaymentsPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDTpaymentsPrice.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                Mainfrm.lblMainStatus.Text = "ใส่ได้เฉพาะตัวเลขเท่านั้น"
        End Select
    End Sub

    Private Sub btnDTselectAll_Click(sender As Object, e As EventArgs) Handles btnDTselectAll.Click
        If Me.txtDTcustomer_id.Text = "" Then
            MsgBox("ดับเบิ๊ลคลิ๊กตารางเพื่อเลือกลูกค้าที่ต้องการดูยอดหนี้รวม", MsgBoxStyle.Information, "แจ้งเตือน")
        Else
            If Me.dgDTshowAll.SelectedRows.Count <= 0 Then
            Else
                Dim r As Integer
                With Me.dgDTselectPayments
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells("sale_id_lower").Value = Me.dgDTshowAll.SelectedCells.Item(1).Value
                    .Rows(r).Cells("detail_lower").Value = Me.dgDTshowAll.SelectedCells.Item(2).Value
                    .Rows(r).Cells("customer_id_lower").Value = Me.dgDTshowAll.SelectedCells.Item(3).Value
                    .Rows(r).Cells("customer_name_lower").Value = Me.dgDTshowAll.SelectedCells.Item(4).Value
                    .Rows(r).Cells("datetime_save_lower").Value = Me.dgDTshowAll.SelectedCells.Item(5).Value
                    .Rows(r).Cells("total_all_lower").Value = Me.dgDTshowAll.SelectedCells.Item(6).Value
                    .Rows(r).Cells("cash_lower").Value = Me.dgDTshowAll.SelectedCells.Item(7).Value
                    .Rows(r).Cells("pledge_lower").Value = Me.dgDTshowAll.SelectedCells.Item(8).Value
                    .Rows(r).Cells("balance_total").Value = Me.dgDTshowAll.SelectedCells.Item(9).Value
                End With
                For sum As Integer = 0 To Me.dgDTselectPayments.Rows.Count - 1
                    Me.dgDTselectPayments.Rows(sum).Cells(0).Value = sum + 1
                Next
                For sum As Integer = 0 To Me.dgDTshowAll.Rows.Count - 1
                    Me.dgDTshowAll.Rows(sum).Cells(0).Value = sum + 1
                Next
                Dim rc As Integer = Me.dgDTshowAll.SelectedRows.Count - 1
                Me.dgDTshowAll.Rows.Remove(Me.dgDTshowAll.SelectedRows(rc))
                Call sumALL()
                Call sumALLselectPayments()
                Me.txtDTpaymentsPrice.Text = Me.txtDTsumALLselectPayments.Text
            End If
        End If
       
    End Sub

    Private Sub dgDTselectPayments_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDTselectPayments.CellDoubleClick
        If Me.dgDTselectPayments.SelectedRows.Count <= 0 Then
        Else
            Dim r As Integer
            With Me.dgDTshowAll
                r = .Rows.Count
                .Rows.Add()
                .Rows(r).Cells("sale_id").Value = Me.dgDTselectPayments.SelectedCells.Item(1).Value
                .Rows(r).Cells("detail").Value = Me.dgDTselectPayments.SelectedCells.Item(2).Value
                .Rows(r).Cells("customer_id").Value = Me.dgDTselectPayments.SelectedCells.Item(3).Value
                .Rows(r).Cells("customer_name").Value = Me.dgDTselectPayments.SelectedCells.Item(4).Value
                .Rows(r).Cells("datetime_save").Value = Me.dgDTselectPayments.SelectedCells.Item(5).Value
                .Rows(r).Cells("total_all").Value = Me.dgDTselectPayments.SelectedCells.Item(6).Value
                .Rows(r).Cells("cash").Value = Me.dgDTselectPayments.SelectedCells.Item(7).Value
                .Rows(r).Cells("pledge").Value = Me.dgDTselectPayments.SelectedCells.Item(8).Value
                .Rows(r).Cells("balance").Value = Me.dgDTselectPayments.SelectedCells.Item(9).Value
            End With
            For sum As Integer = 0 To Me.dgDTshowAll.Rows.Count - 1
                Me.dgDTshowAll.Rows(sum).Cells(0).Value = sum + 1
            Next
            Dim rc As Integer = Me.dgDTselectPayments.SelectedRows.Count - 1
            Me.dgDTselectPayments.Rows.Remove(Me.dgDTselectPayments.SelectedRows(rc))
            Call sumALLselectPayments()
            Call sumALL()
            Me.txtDTpaymentsPrice.Text = Me.txtDTsumALLselectPayments.Text
        End If
    End Sub

    Private Sub btnDTcancel_Click(sender As Object, e As EventArgs) Handles btnDTcancel.Click
        Call startfrm()
    End Sub

    Private Sub txtDTsumALLselectPayments_TextChanged(sender As Object, e As EventArgs) Handles txtDTsumALLselectPayments.TextChanged
        If Me.txtDTsumALLselectPayments.Text = "" Then
            Me.btnDTsave.Enabled = False
            Me.txtDTpaymentsPrice.Enabled = False
            Me.btnDTpledge.Enabled = True
        Else
            Me.cbbDTpayments.Enabled = True
            Me.btnDTsave.Enabled = True
            Me.txtDTpaymentsPrice.Enabled = True
            Me.btnDTpledge.Enabled = False
        End If
    End Sub
    Friend cashDetail As String
    Friend fixid As String
    Private Sub SavePaymentsPrice()
        If Me.cbbDTpayments.Text = "" Then
            Me.lblDTcbbpayments.BackColor = Color.Salmon
            MsgBox("กรุณาเลือกรูปแบบการชำระ", MsgBoxStyle.Exclamation, "แจ้งเตือน")
            Exit Sub
        Else
            Me.DateTimePicker3.Enabled = True
            If CInt(txtDTpaymentsPrice.Text) = CInt(txtDTsumALLselectPayments.Text) Then
                Try
                    'อัพเดทวันที่,หมายเลขจ่ายเงิน cash ID บันทึกข้อมูล
                    Mainfrm.lblMainStatus.Text = "INSERT INTO cash_id"
                    strSQL = "INSERT INTO cash_id(cash_id,datetime_save)VALUES(@cash_id,@datetime_save)"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)

                    With cmd
                        .Parameters.Add(New MySqlParameter("@cash_id", Me.txtDTcashID.Text))
                        .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                        Call open_connection()
                        .ExecuteNonQuery()
                    End With
                Catch ex As Exception
                    Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                End Try

                For SPP As Integer = 0 To Me.dgDTselectPayments.Rows.Count - 1
                    Try
                        strSQL = "insert into cash_sale (sale_id,fix_id,customer_id,customer_name,total_all,date_in,datetime_save,date_edit,cash,cash_status,employee,return_id)" _
                        & "select * from sale where sale_id='" & Me.dgDTselectPayments.Rows(SPP).Cells(1).Value & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try

                    Try
                        'ก็อปปี้ข้อมูลจาก pledge_sale ไป cash_pledge_sale ใช้ select * into
                        strSQL = "INSERT INTO cash_pledge_sale(p_id,total1,cash1,transfer1,check1,detail1,customer_id,customer_name,employee,datetime_save)" _
                            & "SELECT * FROM pledge_sale WHERE p_id='" & Me.dgDTselectPayments.Rows(SPP).Cells(1).Value & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                            Call open_connection()
                            cmd.ExecuteNonQuery()
                        End Using
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try

                    Try
                        'ก็อปปี้ข้อมูลจาก sale_barcode ไป cash_sale_barcode ใช้ select * into
                        strSQL = "INSERT INTO cash_sale_barcode(sale_id,customer_id,fix_id,customer_name,customer_tel,code_pro,bar_code,name_pro,total_pro,price_cost,price_buy,unit,`type`,date_in,datetime_save,return_id,employee)" _
                            & "SELECT * FROM sale_barcode WHERE sale_id='" & Me.dgDTselectPayments.Rows(SPP).Cells(1).Value & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                            Call open_connection()
                            cmd.ExecuteNonQuery()
                        End Using
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try

                    Try
                        'ก็อปปี้ข้อมูลจาก sale_serial ไป cash_sale_serial ใช้ select * into
                        strSQL = "INSERT INTO cash_sale_serial(sale_id,fix_id,customer_id,customer_name,name_pro,code_pro,bar_code,serial_pro,date_in,datetime_save,employee)" _
                            & "SELECT * FROM sale_serial WHERE sale_id='" & Me.dgDTselectPayments.Rows(SPP).Cells(1).Value & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                            Call open_connection()
                            cmd.ExecuteNonQuery()
                        End Using
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try
                    'อัพเดทวันที่,หมายเลขจ่ายเงิน cash ID บันทึกข้อมูล

                    If Me.cbbDTpayments.Text = "เงินสด" Then
                        cashDetail = "เงินสด"
                    ElseIf Me.cbbDTpayments.Text = "เช็ค" Then
                        cashDetail = "เช็ค\" & "หมายเลข " & Me.txtDTpayments.Text & "\ลงวันที่ " & Me.DateTimePicker3.Text
                    ElseIf Me.cbbDTpayments.Text = "โอนเข้าบัญชีธนาคาร" Then
                        cashDetail = "โอนเข้าธนาคาร" & Me.cbbDTpayments.Text & "\โอนวันที่ " & Me.DateTimePicker3.Text
                    End If

                    Try
                        'อัพเดท cash_pledge_sale
                        strSQL = "UPDATE cash_pledge_sale SET cash_id='" & Me.txtDTcashID.Text & "', datetime_save='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "',employee='" & LoginFrm.txtLoginUsername.Text & "' WHERE p_id='" & Me.dgDTselectPayments.Rows(SPP).Cells(1).Value & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try

                    Try
                        'อัพเดท cash_sale
                        strSQL = "UPDATE cash_sale SET cash_id='" & Me.txtDTcashID.Text & "', datetime_save='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "',cash_status='" & "ชำระเงิน" & "',employee='" & LoginFrm.txtLoginUsername.Text & "',cash='" & "-" & "',cash_back='" & "-" & "',cash_detail='" & cashDetail & "' WHERE sale_id='" & Me.dgDTselectPayments.Rows(SPP).Cells(1).Value & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try

                    Try
                        'อัพเดท cash_sale_barcode
                        strSQL = "UPDATE cash_sale_barcode SET cash_id='" & Me.txtDTcashID.Text & "', datetime_save='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "',employee='" & LoginFrm.txtLoginUsername.Text & "' WHERE sale_id='" & Me.dgDTselectPayments.Rows(SPP).Cells(1).Value & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try

                    Try
                        'อัพเดท cash_sale_serial
                        strSQL = "UPDATE cash_sale_serial SET cash_id='" & Me.txtDTcashID.Text & "', datetime_save='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "',employee='" & LoginFrm.txtLoginUsername.Text & "' WHERE sale_id='" & Me.dgDTselectPayments.Rows(SPP).Cells(1).Value & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try

                    Try
                        'ลบข้อมูล ออกจาก sale
                        strSQL = "delete from sale where sale_id='" & Me.dgDTselectPayments.Rows(SPP).Cells(1).Value & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                            cmd.ExecuteNonQuery()
                        End Using
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try

                    Try
                        'ลบข้อมูลออกจาก pledge_sale
                        strSQL = "delete from pledge_sale where p_id='" & Me.dgDTselectPayments.Rows(SPP).Cells(1).Value & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                            cmd.ExecuteNonQuery()
                        End Using
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try

                    Try
                        'ลบ sale_barcode
                        strSQL = "delete from sale_barcode where sale_id='" & Me.dgDTselectPayments.Rows(SPP).Cells(1).Value & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                            cmd.ExecuteNonQuery()
                        End Using
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try

                    Try
                        'ลบ sale_serial
                        strSQL = "delete from sale_serial where sale_id='" & Me.dgDTselectPayments.Rows(SPP).Cells(1).Value & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                            cmd.ExecuteNonQuery()
                        End Using
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try
                    Dr.Close()
                Next
            Else
                MsgBox("ยอดชำระไม่เท่ากัน ถ้ายอดชำระไม่เท่ากันกรุณาใช้การมัดจำ", MsgBoxStyle.Information, "แจ้งเตือน")
                Exit Sub
            End If
        End If
        Me.dgDTselectPayments.Rows.Clear()
        MsgBox("บันทึกข้อมูลแแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
        If MessageBox.Show("ต้องการจะพิมพ์ใบชำระเงินหรือไม่", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            cANDp = "ใบชำระเงิน"
            cANDp1 = "ชำระ"
            DebtorBillingPrintFrm.Show()
        Else
        End If
        Call startfrm()
    End Sub

    Private Sub btnDTsave_Click(sender As Object, e As EventArgs) Handles btnDTsave.Click
        Call SavePaymentsPrice()
    End Sub


    Private Sub btnDTprintProBill_Click(sender As Object, e As EventArgs) Handles btnDTprintProBill.Click
        If Me.txtDTcustomer_id.Text = "" Then
            MsgBox("ดับเบิ๊ลคลิ๊กตารางเพื่อเลือกลูกค้าที่ต้องการพิมพ์ยอดหนี้รวมก่อน", MsgBoxStyle.Information, "แจ้งเตือน")
        Else
            BillingReportFrm.Show()
        End If
    End Sub
End Class