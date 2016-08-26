Imports MySql.Data.MySqlClient
Imports GenCode128
Imports System.Globalization

Public Class ClaimsFrm
    Private Sub Data_History_Bus_Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.dgClaims.RowCount > 0 Then
            If MessageBox.Show("มีข้อมูงานเคลมที่ยังไม่ได้ถูกบันทึก หากปิดหน้าต่างนี้ไปข้อมูลงานเคลมที่ยังไม่บันทึกจะถูกลบออก", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                e.Cancel = False
                For num As Integer = 0 To Me.dgClaims.RowCount - 1
                    strSQL = "DELETE FROM claims_cache WHERE claims_id='" & Me.dgClaims.Rows(num).Cells(1).Value & "'"
                    Mainfrm.lblMainStatus.Text = strSQL
                    Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    End Using
                Next
                Mainfrm.lblMainStatus.Text = "ปิดหน้าต่างงานรับเคลม"
            Else
                e.Cancel = True
                Mainfrm.lblMainStatus.Text = "การปิดหน้าต่างงานรับเคลมถูกยกเลิก"
            End If
        End If
    End Sub

    Private Sub AutoNumberNo()
        Try
            Mainfrm.lblMainStatus.Text = "โหลด Claims_id"
            dt = New DataTable
            strSQL = "SELECT ver_claims FROM ver_detail"
            dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
            Call open_connection()
            dtAdapter.Fill(dt)
            Dim nid As String = dt.Rows(0).Item("ver_claims")
            Mainfrm.lblMainStatus.Text = "โหลด ID"
            strSQL = "SELECT Max(ID) as ID FROM claims_id"
            dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                Me.txtCFclaims_id.Text = nid & Now.ToString("yyyyMMddHHmmss") & "00001"
            Else
                Dim newID As Integer = CInt(Dr.Item("ID"))
                newID += 1
                Me.txtCFclaims_id.Text = nid & Now.ToString("yyMMddHHmm") & newID.ToString("00000")
            End If
            Dr.Close()
            Mainfrm.lblMainStatus.Text = "โหลด ID แล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "โหลด ID ผิดพลาด"
        End Try
    End Sub

    Private Sub startFrm()
        If Me.dgClaims.RowCount > 0 Then
            Me.btnCchangCustomer.Enabled = False
            Call AutoNumberNo()
            Me.txtCFsearchSN.ReadOnly = False
            Me.btnCFsearchSN.Enabled = True
            Me.txtCFserial_pro.Clear()
            Me.txtCFcode_pro.Clear()
            Me.txtCFbar_code.Clear()
            Me.txtCFname_pro.Clear()
            Me.txtCFprice_buy.Clear()
            Me.txtCFprice_wholsale.Clear()
            Me.txtCFprice_technician.Clear()
            Me.txtCFprice_loyal.Clear()
            Me.txtCFprice_members.Clear()
            Me.txtCFtype.Clear()
            Me.txtCFunit.Clear()
            Me.txtCFdatetime_sale.Clear()
            Me.txtCFemployee_sale.Clear()
            Me.txtCFsyptom.Clear()
            Me.txtCFaccessory.Clear()
            Me.txtCFnote.Clear()
            Me.txtCFstatus.Clear()
            Me.txtCFsyptom.BackColor = SystemColors.Window
            Me.txtCFaccessory.BackColor = SystemColors.Window
            Me.txtCFnote.BackColor = SystemColors.Window
            PictureBox1.Image = Code128Rendering.MakeBarcodeImage(Me.txtCFclaims_id.Text, CInt(1), True)
            Me.txtCFserial_pro.ReadOnly = True
            Me.txtCFcode_pro.ReadOnly = True
            Me.txtCFname_pro.ReadOnly = True
            Me.txtCFprice_buy.ReadOnly = True
            Me.txtCFunit.ReadOnly = True
            Me.lblCFdate.Text = "วันที่-----(ปี/เดือน/วัน เวลา)"
        Else
            Me.btnCchangCustomer.Enabled = True
            Call AutoNumberNo()
            Me.txtCFsearchSN.ReadOnly = False
            Me.btnCFsearchSN.Enabled = True
            Me.txtCFcustomer_id.Clear()
            Me.txtCFcustomer_name.Clear()
            Me.txtCFserial_pro.Clear()
            Me.txtCFcode_pro.Clear()
            Me.txtCFbar_code.Clear()
            Me.txtCFname_pro.Clear()
            Me.txtCFprice_buy.Clear()
            Me.txtCFprice_wholsale.Clear()
            Me.txtCFprice_technician.Clear()
            Me.txtCFprice_loyal.Clear()
            Me.txtCFprice_members.Clear()
            Me.txtCFtype.Clear()
            Me.txtCFunit.Clear()
            Me.txtCFdatetime_sale.Clear()
            Me.txtCFemployee_sale.Clear()
            Me.txtCFsyptom.Clear()
            Me.txtCFaccessory.Clear()
            Me.txtCFnote.Clear()
            Me.txtCFstatus.Clear()
            Me.txtCFsyptom.BackColor = SystemColors.Window
            Me.txtCFaccessory.BackColor = SystemColors.Window
            Me.txtCFnote.BackColor = SystemColors.Window
            PictureBox1.Image = Code128Rendering.MakeBarcodeImage(Me.txtCFclaims_id.Text, CInt(1), True)
            Me.txtCFserial_pro.ReadOnly = True
            Me.txtCFcode_pro.ReadOnly = True
            Me.txtCFname_pro.ReadOnly = True
            Me.txtCFprice_buy.ReadOnly = True
            Me.txtCFunit.ReadOnly = True
            Me.lblCFdate.Text = "วันที่-----(ปี/เดือน/วัน เวลา)"
        End If
    End Sub
    Dim has As String
    Private Sub chkAddressSN()
        Try
            'ค้นหา sn 
            strSQL = "SELECT serial_pro FROM cash_sale_serial WHERE serial_pro='" & Me.txtCFsearchSN.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            If Dr.HasRows Then
                has = 100
            Else
                strSQL = "SELECT serial_pro FROM sale_serial WHERE serial_pro='" & Me.txtCFsearchSN.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                If Dr.HasRows Then
                    has = 200
                Else
                    has = 300
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub getdataSN()
        Call chkAddressSN()
        Try
            'ดึงข้อมูล
            Mainfrm.lblMainStatus.Text = "ค้นหาสินค้า"
            If has = 100 Then
                strSQL = "SELECT customer_id,customer_name,code_pro,bar_code,name_pro,serial_pro,datetime_save,employee FROM cash_sale_serial WHERE serial_pro='" & Me.txtCFsearchSN.Text & "'"
                Mainfrm.lblMainStatus.Text = "ค้นหาสินค้าที่ขายที่ชำระเงินแล้ว"
                Mainfrm.lblMainStatus.Text = strSQL
                Me.lblCFdate.Text = "วันที่ขายสินค้า(ปี/เดือน/วัน เวลา)"
            ElseIf has = 200 Then
                strSQL = "SELECT customer_id,customer_name,code_pro,bar_code,name_pro,serial_pro,datetime_save,employee FROM sale_serial WHERE serial_pro='" & Me.txtCFsearchSN.Text & "'"
                Mainfrm.lblMainStatus.Text = "ค้นหาสินค้าที่ขายที่ยังไม่ชำระเงิน"
                Mainfrm.lblMainStatus.Text = strSQL
                Me.lblCFdate.Text = "วันที่ขายสินค้า(ปี/เดือน/วัน เวลา)"
            ElseIf has = 300 Then
                strSQL = "SELECT code_pro,name_pro,serial_pro,date_in FROM product_serial WHERE serial_pro='" & Me.txtCFsearchSN.Text & "'"
                Mainfrm.lblMainStatus.Text = "ค้นหาสินค้าสต็อกสินค้า"
                Mainfrm.lblMainStatus.Text = strSQL
                Me.lblCFdate.Text = "วันที่นำเข้าระบบ(ปี/เดือน/วัน เวลา)"
            End If
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            If has = 300 Then
                Dr.Read()
                With Dr
                    Me.txtCFserial_pro.Text = .Item("serial_pro")
                    Me.txtCFcode_pro.Text = .Item("code_pro")
                    Me.txtCFname_pro.Text = .Item("name_pro")
                    Me.txtCFbar_code.Text = "-"
                    Me.txtCFdatetime_sale.Text = .Item("date_in")
                    Me.txtCFemployee_sale.Text = "-"
                    Me.txtCFcustomer_id.Text = "สินค้าจากสต็อก"
                    Me.txtCFcustomer_name.Text = "-"
                End With
            Else
                Dr.Read()
                With Dr
                    Me.txtCFcustomer_id.Text = .Item("customer_id")
                    Me.txtCFcustomer_name.Text = .Item("customer_name")
                    Me.txtCFserial_pro.Text = .Item("serial_pro")
                    Me.txtCFcode_pro.Text = .Item("code_pro")
                    Me.txtCFbar_code.Text = .Item("bar_code")
                    Me.txtCFname_pro.Text = .Item("name_pro")
                    Me.txtCFdatetime_sale.Text = .Item("datetime_save")
                    Me.txtCFemployee_sale.Text = .Item("employee")
                End With
            End If
            Mainfrm.lblMainStatus.Text = "ค้นหาราคาสินค้า"
            strSQL = "SELECT bar_code,price_buy,price_wholesale,price_technician,price_loyal,price_members,unit,type FROM product WHERE code_pro='" & Me.txtCFcode_pro.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            With Dr
                If has = 300 Then
                    Me.txtCFbar_code.Text = .Item("bar_code")
                End If
                Me.txtCFprice_buy.Text = .GetDecimal("price_buy")
                Me.txtCFprice_wholsale.Text = .GetDecimal("price_wholesale")
                Me.txtCFprice_technician.Text = .GetDecimal("price_technician")
                Me.txtCFprice_loyal.Text = .GetDecimal("price_loyal")
                Me.txtCFprice_members.Text = .GetDecimal("price_members")
                Me.txtCFunit.Text = .Item("unit")
                Me.txtCFtype.Text = .Item("type")
            End With
            Mainfrm.lblMainStatus.Text = "ค้นหาข้อมูลสินค้าเรียบร้อย"
            If has = 100 Then
                Me.txtCFstatus.Text = "ชำระเงินแล้ว"
            ElseIf has = 200 Then
                Me.txtCFstatus.Text = "ยังไม่ชำระเงิน"
            ElseIf has = 300 Then
                Me.txtCFstatus.Text = "สินค้าจากสต็อกสินค้า"
            End If
            Me.txtCFsearchSN.Clear()
            Me.txtCFsearchSN.Focus()
        Catch ex As Exception
            MsgBox("ไม่พบข้อมูล", MsgBoxStyle.Exclamation, "No Data")
            Me.txtCFsearchSN.Clear()
            Me.txtCFsearchSN.Focus()
        End Try
        has = Nothing
    End Sub
    Dim cp As String
    Dim scp As Integer
    Private Sub saveAllData()
        If Me.dgClaims.RowCount = 0 Then
            MsgBox("ยังไม่มีข้อมูลงานเคลม", MsgBoxStyle.Information, "แจ้งเตือน")
        Else
            If MessageBox.Show("คุณแน่ใจว่าจะบันทึกข้อมูลนี้", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                ClaimsReportPrintFrm.MdiParent = Mainfrm
                ClaimsReportPrintFrm.Show()
                Try
                    For num As Integer = 0 To Me.dgClaims.RowCount - 1
                        strSQL = "INSERT INTO claims(claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,price_buy,price_wholesale,price_technician,price_loyal,price_members,type,unit,datetime_sale,datetime_return,datetime_edit,claims_money,employee_claims_return,tel_to_cus,employee_sale,symptom,accressory,note,note2,status,employee,datetime_save,claims_id_pic)" _
                             & "SELECT * FROM claims_cache WHERE claims_id='" & Me.dgClaims.Rows(num).Cells(1).Value & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                            Call open_connection()
                            cmd.ExecuteNonQuery()
                        End Using
                    Next
                Catch ex As Exception

                End Try


                For num As Integer = 0 To Me.dgClaims.RowCount - 1
                    Try
                        strSQL = "DELETE FROM claims_cache WHERE claims_id='" & Me.dgClaims.Rows(num).Cells(1).Value & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                            Call open_connection()
                            cmd.ExecuteNonQuery()
                        End Using
                    
                    'ลบ SN จาก product_serial จะได้เอามาขายไม่ได้

                    'ค้นหา sn
                    strSQL = "DELETE FROM product_serial WHERE serial_pro='" & Me.dgClaims.Rows(num).Cells(2).Value & "'"
                    Mainfrm.lblMainStatus.Text = strSQL
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception

                    End Try
                Next
                For de As Integer = 0 To Me.dgClaims.RowCount - 1
                    Try
                        strSQL = "SELECT count_num FROM product WHERE code_pro='" & Me.dgClaims.Rows(de).Cells(3).Value & "'"
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        Dr = cmd.ExecuteReader()
                        Dr.Read()
                        cp = Dr.GetString("count_num")
                        scp = CInt(cp) - 1
                        'update count_num product
                        strSQL = "UPDATE product SET count_num='" & scp & "' WHERE code_pro='" & Me.dgClaims.Rows(de).Cells(3).Value & "'"
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                        cp = Nothing
                        scp = Nothing
                    Catch ex As Exception

                    End Try
                Next

                Me.dgClaims.Rows.Clear()
                Me.btnCchangCustomer.Enabled = True
                Call AutoNumberNo()
                Me.txtCFsearchSN.ReadOnly = False
                Me.btnCFsearchSN.Enabled = True
                Me.txtCFcustomer_id.Clear()
                Me.txtCFcustomer_name.Clear()
                Me.txtCFserial_pro.Clear()
                Me.txtCFcode_pro.Clear()
                Me.txtCFbar_code.Clear()
                Me.txtCFname_pro.Clear()
                Me.txtCFprice_buy.Clear()
                Me.txtCFtype.Clear()
                Me.txtCFunit.Clear()
                Me.txtCFdatetime_sale.Clear()
                Me.txtCFemployee_sale.Clear()
                Me.txtCFsyptom.Clear()
                Me.txtCFaccessory.Clear()
                Me.txtCFnote.Clear()
                Me.txtCFstatus.Clear()
                Me.txtCFsyptom.BackColor = SystemColors.Window
                Me.txtCFaccessory.BackColor = SystemColors.Window
                Me.txtCFnote.BackColor = SystemColors.Window
                PictureBox1.Image = Code128Rendering.MakeBarcodeImage(Me.txtCFclaims_id.Text, CInt(1), True)
                Me.txtCFserial_pro.ReadOnly = True
                Me.txtCFcode_pro.ReadOnly = True
                Me.txtCFname_pro.ReadOnly = True
                Me.txtCFprice_buy.ReadOnly = True
                Me.txtCFunit.ReadOnly = True
                MsgBox("บันทึกข้อมูลแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtCFsearchSN_Click(sender As Object, e As EventArgs) Handles txtCFsearchSN.Click
        If desposit = 100 Then
        Else
            Me.txtCFsearchSN.BackColor = SystemColors.Window
        End If

    End Sub

    Private Sub txtCFsearchSN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCFsearchSN.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call getdataSN()
        End If
    End Sub

    Private Sub ClaimsFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call startFrm()
        Me.Icon = Mainfrm.Icon
    End Sub

    Private Sub btnCFsave_Click(sender As Object, e As EventArgs) Handles btnCFsave.Click
        Try
            strSQL = "SELECT serial_pro FROM claims WHERE serial_pro='" & Me.txtCFserial_pro.Text & "' AND NOT status='" & "ส่งคืนแล้ว" & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            If Dr.HasRows Then
                MsgBox("SN " & Me.txtCFserial_pro.Text & " มีในระบบเคลมแล้ว กรุณาตรวจสอบ", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Exit Sub
            Else
                strSQL = "SELECT serial_pro FROM claims_cache WHERE serial_pro='" & Me.txtCFserial_pro.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
               Dr = cmd.ExecuteReader()
                If Dr.HasRows Then

                    MsgBox("SN " & Me.txtCFserial_pro.Text & " มีในระบบเคลมแล้ว กรุณาตรวจสอบ", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                    Exit Sub
                Else
                    If Me.txtCFcustomer_id.Text = "" Then
                        Mainfrm.lblMainStatus.Text = "กรุณาเลือกลูกค้าก่อน"
                        Me.txtCFcustomer_name.BackColor = Color.OrangeRed
                        Me.txtCFcustomer_id.BackColor = Color.OrangeRed
                        Exit Sub
                    End If
                    If Me.txtCFserial_pro.Text = "" Then
                        Mainfrm.lblMainStatus.Text = "กรุณาใส่ SN สินค้าก่อน"
                        Me.txtCFsearchSN.Focus()
                        Me.txtCFsearchSN.BackColor = Color.OrangeRed
                        Exit Sub
                    End If
                    If Me.txtCFname_pro.Text = "" Then
                        Mainfrm.lblMainStatus.Text = "กรุณาใส่ชื่อสินค้าก่อน"
                        Me.txtCFname_pro.Focus()
                        Me.txtCFname_pro.BackColor = Color.OrangeRed
                        Exit Sub
                    End If
                    If Me.txtCFprice_buy.Text = "" Then
                        Mainfrm.lblMainStatus.Text = "กรุณาใส่ราคาสินค้าก่อน"
                        Me.txtCFprice_buy.Focus()
                        Me.txtCFprice_buy.BackColor = Color.OrangeRed
                        Exit Sub
                    End If
                    If Me.txtCFunit.Text = "" Then
                        Mainfrm.lblMainStatus.Text = "กรุณาใส่หน่วยนับสินค้าก่อน"
                        Me.txtCFunit.Focus()
                        Me.txtCFunit.BackColor = Color.OrangeRed
                        Exit Sub
                    End If
                    If Me.txtCFsyptom.Text = "" Then
                        Mainfrm.lblMainStatus.Text = "ไม่ควรปล่อยว่างช่อง อาการเสียไว้"
                        Me.txtCFsyptom.Focus()
                        Me.txtCFsyptom.BackColor = Color.OrangeRed
                        Exit Sub
                    ElseIf Me.txtCFaccessory.Text = "" Then
                        Mainfrm.lblMainStatus.Text = "ไม่ควรปล่อยว่างช่อง อุปกรณ์ที่นำมาด้วยไว้"
                        Me.txtCFaccessory.Focus()
                        Me.txtCFaccessory.BackColor = Color.OrangeRed
                        Exit Sub
                    ElseIf Me.txtCFnote.Text = "" Then
                        Mainfrm.lblMainStatus.Text = "ไม่ควรปล่อยว่างช่อง หมายเหตุไว้"
                        Me.txtCFnote.Focus()
                        Me.txtCFnote.BackColor = Color.OrangeRed
                        Exit Sub
                    End If

                    If MessageBox.Show("คุณแน่ใจว่าจะบันทึกข้อมูลนี้", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        'save id
                        Mainfrm.lblMainStatus.Text = "บันทึกเคลมไอดี"
                        strSQL = "insert into claims_id(claims_id) " _
                                  & " values(@claims_id)"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        With cmd
                            .Parameters.Add(New MySqlParameter("@claims_id", Me.txtCFclaims_id.Text))
                            Call open_connection()
                            .ExecuteNonQuery()
                        End With
                        Mainfrm.lblMainStatus.Text = "บันทึกเคลมไอดีแล้ว"
                        Mainfrm.lblMainStatus.Text = "บันทึกข้อมูลเคลม"
                        strSQL = "insert into claims_cache(claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,price_buy,price_wholesale,price_technician,price_loyal,price_members,type,unit,datetime_sale,employee_sale,symptom,accressory,note,status,employee,datetime_save,claims_id_pic) " _
                                    & " values(@claims_id,@customer_id,@serial_pro,@code_pro,@bar_code,@name_pro,@price_buy,@price_wholesale,@price_technician,@price_loyal,@price_members,@type,@unit,@datetime_sale,@employee_sale,@symptom,@accressory,@note,@status,@employee,@datetime_save,@claims_id_pic)"

                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        With cmd
                            .Parameters.Add(New MySqlParameter("@claims_id", Me.txtCFclaims_id.Text))
                            .Parameters.Add(New MySqlParameter("@customer_id", Me.txtCFcustomer_id.Text))
                            .Parameters.Add(New MySqlParameter("@serial_pro", Me.txtCFserial_pro.Text))
                            .Parameters.Add(New MySqlParameter("@code_pro", Me.txtCFcode_pro.Text))
                            .Parameters.Add(New MySqlParameter("@bar_code", Me.txtCFbar_code.Text))
                            .Parameters.Add(New MySqlParameter("@name_pro", Me.txtCFname_pro.Text))
                            .Parameters.Add(New MySqlParameter("@price_buy", Me.txtCFprice_buy.Text))
                            .Parameters.Add(New MySqlParameter("@price_wholesale", Me.txtCFprice_wholsale.Text))
                            .Parameters.Add(New MySqlParameter("@price_technician", Me.txtCFprice_technician.Text))
                            .Parameters.Add(New MySqlParameter("@price_loyal", Me.txtCFprice_loyal.Text))
                            .Parameters.Add(New MySqlParameter("@price_members", Me.txtCFprice_members.Text))
                            .Parameters.Add(New MySqlParameter("@type", Me.txtCFtype.Text))
                            .Parameters.Add(New MySqlParameter("@unit", Me.txtCFunit.Text))
                            .Parameters.Add(New MySqlParameter("@datetime_sale", Me.txtCFdatetime_sale.Text))
                            .Parameters.Add(New MySqlParameter("@employee_sale", Me.txtCFemployee_sale.Text))
                            .Parameters.Add(New MySqlParameter("@symptom", Me.txtCFsyptom.Text))
                            .Parameters.Add(New MySqlParameter("@accressory", Me.txtCFaccessory.Text))
                            .Parameters.Add(New MySqlParameter("@note", Me.txtCFnote.Text))
                            .Parameters.Add(New MySqlParameter("@status", "รับเข้าระบบ"))
                            .Parameters.Add(New MySqlParameter("@employee", Me.lblemployee.Text))
                            .Parameters.Add(New MySqlParameter("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))))
                            Using stream As New IO.MemoryStream
                                PictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
                                Dim arrImage() As Byte = stream.GetBuffer()
                                cmd.Parameters.AddWithValue("@claims_id_pic", arrImage)
                                Call open_connection()
                                cmd.ExecuteNonQuery()
                            End Using
                        End With
                        Mainfrm.lblMainStatus.Text = "บันทึกข้อมูลเคลมแล้ว"
                        Call loadDataCache()
                        Call AutoNumberNo()
                        MsgBox("บันทึกข้อมูลแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
                    Else
                        Exit Sub
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
        Call startFrm()
        desposit = Nothing
    End Sub

    Private Sub loadDataCache()
        Try
            Me.dgClaims.Rows.Clear()
            strSQL = "SELECT claims_id,serial_pro,code_pro,bar_code,name_pro,price_buy,price_wholesale,price_technician,price_loyal,price_members,type,unit,symptom,accressory,employee,datetime_save FROM claims_cache"
        Using cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dim r As Integer
            While (Dr.Read())
                    With Me.dgClaims
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(1).Value = Dr.GetString("claims_id")
                        .Rows(r).Cells(2).Value = Dr.GetString("serial_pro")
                        .Rows(r).Cells(3).Value = Dr.GetString("code_pro")
                        .Rows(r).Cells(4).Value = Dr.GetString("bar_code")
                        .Rows(r).Cells(5).Value = Dr.GetString("name_pro")
                        .Rows(r).Cells(6).Value = Dr.GetDecimal("price_buy")
                        .Rows(r).Cells(7).Value = Dr.GetDecimal("price_wholesale")
                        .Rows(r).Cells(8).Value = Dr.GetDecimal("price_technician")
                        .Rows(r).Cells(9).Value = Dr.GetDecimal("price_loyal")
                        .Rows(r).Cells(10).Value = Dr.GetDecimal("price_members")
                        .Rows(r).Cells(11).Value = Dr.GetString("type")
                        .Rows(r).Cells(12).Value = Dr.GetString("unit")
                        .Rows(r).Cells(13).Value = Dr.GetString("symptom")
                        .Rows(r).Cells(14).Value = Dr.GetString("accressory")
                        .Rows(r).Cells(15).Value = Dr.GetString("employee")
                        .Rows(r).Cells(16).Value = Dr.GetString("datetime_save")
                    End With
            End While
                For sum As Integer = 0 To Me.dgClaims.Rows.Count - 1
                    Me.dgClaims.Rows(sum).Cells(0).Value = sum + 1
                Next
            End Using
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtCFsyptom_Click(sender As Object, e As EventArgs) Handles txtCFsyptom.Click
        Me.txtCFsyptom.BackColor = SystemColors.Window
    End Sub

    Private Sub txtCFaccessory_Click(sender As Object, e As EventArgs) Handles txtCFaccessory.Click
        Me.txtCFaccessory.BackColor = SystemColors.Window
    End Sub

    Private Sub txtCFnote_Click(sender As Object, e As EventArgs) Handles txtCFnote.Click
        Me.txtCFnote.BackColor = SystemColors.Window
    End Sub

    Private Sub btnCFsearchSN_Click_1(sender As Object, e As EventArgs) Handles btnCFsearchSN.Click
        Call getdataSN()
    End Sub

    Private Sub btnCchangCustomer_Click_1(sender As Object, e As EventArgs) Handles btnCchangCustomer.Click
        Me.txtCFcustomer_name.BackColor = SystemColors.Control
        Me.txtCFcustomer_id.BackColor = SystemColors.Control
        If Me.txtCFserial_pro.Text = "" Then
            If desposit = 100 Then
                MsgBox("ใส่ SN สินค้าก่อน", MsgBoxStyle.Information, "แจ้งเตือน")
            Else
                Mainfrm.lblMainStatus.Text = "ใส่ Serial Number สินค้าก่อน"
                Exit Sub
            End If

        Else
            SearchCustomerFrm.MdiParent = Mainfrm
            SearchCustomerFrm.Show()
            SearchCustomerFrm.btnSendtoSavedatafix.Text = "เลือกไปหน้าเคลมสินค้า"
        End If
    End Sub

    Private Sub btnCFloadaccessory_Click_1(sender As Object, e As EventArgs) Handles btnCFloadaccessory.Click
        accessoryClaimsFrm.MdiParent = Mainfrm
        accessoryClaimsFrm.Show()
    End Sub

    Private Sub btnCFcancel_Click_1(sender As Object, e As EventArgs) Handles btnCFcancel.Click
        Call startFrm()
    End Sub
    Dim desposit As Integer
    Private Sub btnCdepositClaims_Click(sender As Object, e As EventArgs) Handles btnCdepositClaims.Click
        desposit = 100
        Me.txtCFsearchSN.ReadOnly = True
        Me.btnCFsearchSN.Enabled = False
        Me.txtCFserial_pro.ReadOnly = False
        Me.txtCFcode_pro.ReadOnly = False
        Me.txtCFbar_code.Text = "ฝากเคลม"
        Me.txtCFname_pro.ReadOnly = False
        Me.txtCFprice_buy.ReadOnly = False
        Me.txtCFtype.Text = "-"
        Me.txtCFunit.ReadOnly = False
        Me.txtCFdatetime_sale.Text = "-"
        Me.txtCFemployee_sale.Text = "-"
    End Sub

    Private Sub btnClaimsAll_Click(sender As Object, e As EventArgs) Handles btnClaimsAll.Click
        Call saveAllData()
    End Sub

    Private Sub txtCFname_pro_Click(sender As Object, e As EventArgs) Handles txtCFname_pro.Click
        If desposit = 100 Then
            Me.txtCFname_pro.BackColor = SystemColors.Window
        End If
    End Sub

    Private Sub txtCFprice_buy_Click(sender As Object, e As EventArgs) Handles txtCFprice_buy.Click
        If desposit = 100 Then
            Me.txtCFprice_buy.BackColor = SystemColors.Window
        End If
    End Sub

    Private Sub txtCFunit_Click(sender As Object, e As EventArgs) Handles txtCFunit.Click
        If desposit = 100 Then
            Me.txtCFunit.BackColor = SystemColors.Window
        End If
    End Sub

    Private Sub btnCRefresh_Click(sender As Object, e As EventArgs) Handles btnCRefresh.Click
        Call loadDataCache()
    End Sub

    Private Sub dgClaims_KeyDown(sender As Object, e As KeyEventArgs) Handles dgClaims.KeyDown
        If e.KeyCode = Keys.Delete Then
            If MessageBox.Show("คุณแน่ใจว่าจะลบข้อมูลนี้", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                strSQL = "DELETE FROM claims_cache WHERE claims_id='" & Me.dgClaims.SelectedCells.Item(1).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End Using
                Dim a As Integer = Me.dgClaims.SelectedRows.Count - 1
                Me.dgClaims.Rows.Remove(Me.dgClaims.SelectedRows(a))
                Me.dgClaims.Refresh()
            End If
        Else
            Exit Sub
        End If
    End Sub


End Class