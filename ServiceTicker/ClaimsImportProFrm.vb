Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports GenCode128

Public Class ClaimsImportProFrm
    Private Sub getDataClaims()
        Try
            Mainfrm.lblMainStatus.Text = "โหลดข้อมูล Claims"
            strSQL = "SELECT claims_id,customer_id,code_pro,bar_code,name_pro,symptom,accressory FROM claims WHERE `status`='" & "ทดสอบแล้ว" & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim r As Integer
            While (Dr.Read())
                With Me.dgCIP
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(1).Value = Dr.Item("claims_id")
                    .Rows(r).Cells(2).Value = Dr.Item("customer_id")
                    .Rows(r).Cells(6).Value = Dr.Item("code_pro")
                    .Rows(r).Cells(7).Value = Dr.Item("name_pro")
                    .Rows(r).Cells(8).Value = Dr.Item("symptom")
                    .Rows(r).Cells(9).Value = Dr.Item("accressory")
                End With
            End While

            For i As Integer = 0 To Me.dgCIP.Rows.Count - 1
                Me.dgCIP.Rows(i).Cells.Item(0).Value = i + 1
                strSQL = "SELECT old_sn,new_sn,test_results FROM claims_test_results WHERE claims_id='" & Me.dgCIP.Rows(i).Cells.Item(1).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                With Me.dgCIP
                    .Rows(i).Cells(3).Value = Dr.GetString("old_sn")
                    .Rows(i).Cells(4).Value = Dr.GetString("new_sn")
                    If Dr.GetString("test_results") = "past" Then
                        .Rows(i).Cells(5).Value = "ผ่าน"
                    ElseIf Dr.GetString("test_results") = "fail" Then
                        .Rows(i).Cells(5).Value = "ไม่ผ่าน"
                    End If
                End With
            Next
            Mainfrm.lblMainStatus.Text = "โหลดข้อมูล Claims แล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub ClaimsImportProFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        Call getDataClaims()
        Call startFrm()
    End Sub

    Private Sub startFrm()
        Me.dgCIP.Enabled = True
        Me.dgCIP.ClearSelection()
        Me.tpCIP.SelectedTab = StartTab
        'tab to customer
        Me.lblCIPclaims_id.Text = "Claims_id"
        Me.lblCIPclaims_idMe.Text = "Claims_id"
        Me.txtCIPcus_id.Clear()
        Me.txtCIPcus_name.Clear()
        Me.txtCIPold_sn.Clear()
        Me.txtCIPnew_sn.Clear()
        Me.txtCIPtest.Clear()
        Me.txtCIPtest.Clear()
        Me.txtCIPcus_id.Enabled = False
        Me.txtCIPcus_name.Enabled = False
        Me.txtCIPold_sn.Enabled = False
        Me.txtCIPnew_sn.Enabled = False
        Me.txtCIPtest.Enabled = False
        Me.txtCIPtest.Enabled = False
        Me.btnCIPsavetoCus.Enabled = False
        Me.rbCIPreturnClaims.Enabled = False
        Me.rbCIPreturnToCus.Enabled = False
        'tab to stock
        Me.txtCIPold_snMe.Clear()
        Me.txtCIPnew_snMe.Clear()
        Me.txtCIPmeTestMe.Clear()
        Me.txtCIPold_snMe.Enabled = False
        Me.txtCIPnew_snMe.Enabled = False
        Me.txtCIPmeTestMe.Enabled = False
        Me.btnCIPsaveMe.Enabled = False
        Me.rbCIPreturnClaimsMe.Enabled = False
        Me.rbCIPreturnStockMe.Enabled = False
        Me.lblCIPdetail.Text = "คำอธิบาย"
        Me.lblCIPdetailMe.Text = "คำอธิบาย"
        Me.txtCIPsearchSN.Focus()
    End Sub

    Dim ci As String
    Private Sub txtCIPsearchSN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCIPsearchSN.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call startFrm()
            Try
                Me.dgCIP.ClearSelection()
                For f As Integer = 0 To dgCIP.RowCount - 1
                    Me.dgCIP.Rows(f).DefaultCellStyle.BackColor = SystemColors.Window
                Next
                Dim temp As Integer = 0
                For i As Integer = 0 To dgCIP.RowCount - 1
                    If Me.dgCIP.Rows(i).Cells(3).Value = Me.txtCIPsearchSN.Text Or Me.dgCIP.Rows(i).Cells(4).Value = txtCIPsearchSN.Text Then
                        Me.dgCIP.Rows(i).DefaultCellStyle.BackColor = Color.GreenYellow
                        temp = 1
                        ci = Me.dgCIP.Rows(i).Cells(2).Value
                        Me.dgCIP.Rows(i).Selected = True
                    End If
                Next
                If temp = 0 Then
                    Me.txtCIPsearchSN.Clear()
                    MsgBox("ไม่พบข้อมูล" & Me.txtCIPsearchSN.Text, MsgBoxStyle.Exclamation, "No Data")
                    Call startFrm()
                    Exit Sub
                End If
                If ci = "สินค้าจากสต็อก" Then
                    Me.dgCIP.Enabled = False
                    Me.txtCIPold_snMe.Clear()
                    Me.txtCIPnew_snMe.Clear()
                    Me.txtCIPmeTestMe.Clear()
                    Me.txtCIPold_snMe.Enabled = True
                    Me.txtCIPnew_snMe.Enabled = True
                    Me.txtCIPmeTestMe.Enabled = True
                    Me.btnCIPsaveMe.Enabled = True
                    Me.btnCIPsaveMe.Enabled = True
                    Me.rbCIPreturnClaimsMe.Enabled = True
                    Me.rbCIPreturnStockMe.Enabled = True
                    Me.tpCIP.SelectedTab = ReturnClaimsMe
                    Me.lblCIPclaims_idMe.Text = Me.dgCIP.SelectedCells.Item(1).Value
                    Me.txtCIPold_snMe.Text = Me.dgCIP.SelectedCells.Item(3).Value
                    Me.txtCIPnew_snMe.Text = Me.dgCIP.SelectedCells.Item(4).Value
                    Me.txtCIPmeTestMe.Text = Me.dgCIP.SelectedCells.Item(5).Value
                    If Me.txtCIPmeTestMe.Text = "ผ่าน" Then
                        Me.rbCIPreturnStockMe.Checked = True
                        Me.lblCIPdetailMe.Text = "สถานะทดสอบผ่าน กด 'บันทึก' เพื่อส่งข้อมูลเข้าสต็อกได้ทันที"
                    ElseIf Me.txtCIPmeTestMe.Text = "ไม่ผ่าน" Then
                        Me.rbCIPreturnClaimsMe.Checked = True
                        Me.lblCIPdetailMe.Text = "สถานะทดสอบไม่ผ่าน กด 'บันทึก' เลือกส่งเคลมอีกรอบ หรือเปลี่ยนเป็นสถานะเป็น 'ส่งเข้าสต็อก' กรณีไม่ต้องการส่งเคลมอีกรอบ"
                    End If
                Else
                    Me.dgCIP.Enabled = False
                    Me.lblCIPclaims_id.Text = "Claims_id"
                    Me.txtCIPcus_name.Clear()
                    Me.txtCIPold_sn.Clear()
                    Me.txtCIPnew_sn.Clear()
                    Me.txtCIPtest.Clear()
                    Me.txtCIPtest.Clear()
                    Me.txtCIPcus_id.Enabled = True
                    Me.txtCIPcus_name.Enabled = True
                    Me.txtCIPold_sn.Enabled = True
                    Me.txtCIPnew_sn.Enabled = True
                    Me.txtCIPtest.Enabled = True
                    Me.txtCIPtest.Enabled = True
                    Me.btnCIPsavetoCus.Enabled = True
                    Me.rbCIPreturnClaims.Enabled = True
                    Me.rbCIPreturnToCus.Enabled = True
                    Me.tpCIP.SelectedTab = SendToCus
                    Me.lblCIPclaims_id.Text = Me.dgCIP.SelectedCells.Item(1).Value
                    Me.txtCIPcus_id.Text = Me.dgCIP.SelectedCells.Item(2).Value
                    Try
                        strSQL = "SELECT customer_name FROM customer WHERE customer_id='" & Me.txtCIPcus_id.Text & "'"
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        Dr = cmd.ExecuteReader()
                        Dr.Read()
                        Me.txtCIPcus_name.Text = Dr.GetString("customer_name")
                    Catch ex As Exception

                    End Try
                    Me.txtCIPold_sn.Text = Me.dgCIP.SelectedCells.Item(3).Value
                    Me.txtCIPnew_sn.Text = Me.dgCIP.SelectedCells.Item(4).Value
                    Me.txtCIPtest.Text = Me.dgCIP.SelectedCells.Item(5).Value
                    If Me.txtCIPtest.Text = "ผ่าน" Then
                        Me.rbCIPreturnToCus.Checked = True
                        Me.lblCIPdetail.Text = "สถานะทดสอบผ่าน กด 'บันทึก' เพื่อรอส่งคืนลูกค้าได้เลย"
                    ElseIf Me.txtCIPtest.Text = "ไม่ผ่าน" Then
                        Me.rbCIPreturnClaims.Checked = True
                        Me.lblCIPdetail.Text = "สถานะทดสอบไม่ผ่าน กด 'บันทึก' เลือกส่งเคลมอีกรอบ หรือเปลี่ยนเป็นสถานะ 'รอส่งคืนลูกค้า' กรณีไม่ต้องการส่งเคลมอีกรอบ"
                    End If
                End If

            Catch ex As Exception

            End Try
            Me.txtCIPsearchSN.Clear()
            Me.txtCIPsearchSN.Focus()
        End If
    End Sub

    Private Sub btnCIPsaveMe_Click(sender As Object, e As EventArgs) Handles btnCIPsaveMe.Click
        If Me.rbCIPreturnStockMe.Checked = True Then
            Try
                'ส่งเข้าสต็อก
                'insert into product_serial
                strSQL = "INSERT INTO product_serial(code_pro,serial_pro,name_pro,date_in)" _
                       & "VALUES(@code_pro,@serial_pro,@name_pro,@date_in)"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.AddWithValue("@code_pro", Me.dgCIP.SelectedCells.Item(6).Value)
                    .Parameters.AddWithValue("@serial_pro", Me.txtCIPnew_snMe.Text)
                    .Parameters.AddWithValue("@name_pro", Me.dgCIP.SelectedCells.Item(7).Value)
                    .Parameters.AddWithValue("@date_in", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")))
                End With
                Call open_connection()
                cmd.ExecuteNonQuery()

                'sum count_num product
                Dim cp As String
                Dim scp As Integer
                strSQL = "SELECT count_num FROM product WHERE code_pro='" & Me.dgCIP.SelectedCells.Item(6).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                cp = Dr.GetString("count_num")
                scp = CInt(cp) + 1

                'update count_num product
                strSQL = "UPDATE product SET count_num='" & scp & "' WHERE code_pro='" & Me.dgCIP.SelectedCells.Item(6).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()

                'update status claims
                strSQL = "UPDATE claims SET `status`='" & "ส่งคืนแล้ว" & "' WHERE claims_id='" & Me.lblCIPclaims_idMe.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()

                'update claims send
                strSQL = "UPDATE claims_send SET claims_send_status='" & "ส่งคืนแล้ว" & "' WHERE claims_id='" & Me.lblCIPclaims_idMe.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()

                'ย้ายข้อมูลงานเคลมที่ส่งคืนแล้ว
                Mainfrm.lblMainStatus.Text = "ย้ายข้อมูลเคลม"
                strSQL = "INSERT INTO claims_copy(claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,price_buy,price_wholesale,price_technician,price_loyel,price_members,`type`,unit,datetime_sale,datetime_return,datetime_edit,claims_money,employee_claims_return,tel_to_cus,employee_sale,symptom,accressory,note,note2,`status`,employee,datetime_save,claims_id_pic)" _
                    & "SELECT * FROM claims WHERE claims_id='" & Me.lblCIPclaims_idMe.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                Mainfrm.lblMainStatus.Text = "ย้ายข้อมูลเคลมเรียบร้อย"
                Mainfrm.lblMainStatus.Text = "ลบข้อมูลเคลมที่ส่งคืนแล้ว"
                strSQL = "DELETE FROM claims WHERE claims_id='" & Me.lblCIPclaims_idMe.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                Mainfrm.lblMainStatus.Text = "ลบข้อมูลเคลมที่ส่งคืนแล้วเรียบร้อย"

                For i As Integer = Me.dgCIP.SelectedRows.Count - 1 To 0 Step -1
                    Me.dgCIP.Rows.RemoveAt(Me.dgCIP.SelectedRows(i).Index)
                Next
                cp = Nothing
                scp = Nothing
                MsgBox("บันทึกคืนสต็อกแล้ว", MsgBoxStyle.Information, "แจ้งให้ทราบ")

                Call startFrm()
            Catch ex As Exception

            End Try
        ElseIf Me.rbCIPreturnClaimsMe.Checked = True Then
            Try
                'ส่งเคลมอีกรอบ
                Call AutoNumberNo()
                Dim txtCFcustomer_id As String
                Dim txtCFcustomer_name As String
                Dim txtCFserial_pro As String
                Dim txtCFcode_pro As String
                Dim txtCFname_pro As String
                Dim txtCFbar_code As String
                Dim txtCFdatetime_sale As String
                Dim txtCFemployee_sale As String
                Dim txtCFprice_buy As Decimal
                Dim txtCFprice_wholsale As Decimal
                Dim txtCFprice_technician As Decimal
                Dim txtCFprice_loyal As Decimal
                Dim txtCFprice_members As Decimal
                Dim txtCFunit As String
                Dim txtCFtype As String
                strSQL = "SELECT code_pro,bar_code,name_pro,price_buy,price_wholesale,price_technician,price_loyal,price_members,unit,type,update_date FROM product WHERE code_pro='" & Me.dgCIP.SelectedCells.Item(6).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                With Dr
                    txtCFcustomer_id = "สินค้าจากสต็อก"
                    txtCFcustomer_name = "-"
                    txtCFserial_pro = Me.txtCIPnew_snMe.Text
                    txtCFcode_pro = .Item("code_pro")
                    txtCFname_pro = .Item("name_pro")
                    txtCFbar_code = .Item("bar_code")
                    txtCFprice_buy = .GetDecimal("price_buy")
                    txtCFprice_wholsale = .GetDecimal("price_wholesale")
                    txtCFprice_technician = .GetDecimal("price_technician")
                    txtCFprice_loyal = .GetDecimal("price_loyal")
                    txtCFprice_members = .GetDecimal("price_members")
                    txtCFunit = .Item("unit")
                    txtCFtype = .Item("type")
                    txtCFdatetime_sale = .Item("update_date")
                    txtCFemployee_sale = "-"
                End With
                PictureBox1.Image = Code128Rendering.MakeBarcodeImage(txtCFclaims_id, CInt(1), True)
                'บันทึกข้อมูล
                strSQL = "insert into claims(claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,price_buy,price_wholesale,price_technician,price_loyal,price_members,type,unit,datetime_sale,employee_sale,symptom,accressory,note,status,employee,datetime_save,claims_id_pic) " _
                                    & " values(@claims_id,@customer_id,@serial_pro,@code_pro,@bar_code,@name_pro,@price_buy,@price_wholesale,@price_technician,@price_loyal,@price_members,@type,@unit,@datetime_sale,@employee_sale,@symptom,@accressory,@note,@status,@employee,@datetime_save,@claims_id_pic)"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.Add(New MySqlParameter("@claims_id", txtCFclaims_id))
                    .Parameters.Add(New MySqlParameter("@customer_id", txtCFcustomer_id))
                    .Parameters.Add(New MySqlParameter("@serial_pro", txtCFserial_pro))
                    .Parameters.Add(New MySqlParameter("@code_pro", txtCFcode_pro))
                    .Parameters.Add(New MySqlParameter("@bar_code", txtCFbar_code))
                    .Parameters.Add(New MySqlParameter("@name_pro", txtCFname_pro))
                    .Parameters.Add(New MySqlParameter("@price_buy", txtCFprice_buy))
                    .Parameters.Add(New MySqlParameter("@price_wholesale", txtCFprice_wholsale))
                    .Parameters.Add(New MySqlParameter("@price_technician", txtCFprice_technician))
                    .Parameters.Add(New MySqlParameter("@price_loyal", txtCFprice_loyal))
                    .Parameters.Add(New MySqlParameter("@price_members", txtCFprice_members))
                    .Parameters.Add(New MySqlParameter("@type", txtCFtype))
                    .Parameters.Add(New MySqlParameter("@unit", txtCFunit))
                    .Parameters.Add(New MySqlParameter("@datetime_sale", txtCFdatetime_sale))
                    .Parameters.Add(New MySqlParameter("@employee_sale", txtCFemployee_sale))
                    .Parameters.Add(New MySqlParameter("@symptom", Me.dgCIP.SelectedCells.Item(8).Value))
                    .Parameters.Add(New MySqlParameter("@accressory", Me.dgCIP.SelectedCells.Item(9).Value))
                    .Parameters.Add(New MySqlParameter("@note", "ส่งเคลมอีกรอบ"))
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
                'save id
                Mainfrm.lblMainStatus.Text = "บันทึกเคลมไอดี"
                strSQL = "insert into claims_id(claims_id) " _
                           & " values(@claims_id)"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.Add(New MySqlParameter("@claims_id", txtCFclaims_id))
                    Call open_connection()
                    .ExecuteNonQuery()
                End With

                'update status claims
                strSQL = "UPDATE claims SET serial_pro='" & Me.txtCIPnew_snMe.Text & "'," _
                     & "datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "'," _
                     & "`status`='" & "ส่งคืนแล้ว" & "' WHERE claims_id='" & Me.lblCIPclaims_idMe.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()

                'update claims send
                strSQL = "UPDATE claims_send SET claims_send_status='" & "ส่งคืนแล้ว" & "'," _
                    & "datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "' WHERE claims_id='" & Me.lblCIPclaims_idMe.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()

                'ย้ายข้อมูลงานเคลมที่ส่งคืนแล้ว
                Mainfrm.lblMainStatus.Text = "ย้ายข้อมูลเคลม"
                strSQL = "INSERT INTO claims_copy(claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,price_buy,price_wholesale,price_technician,price_loyel,price_members,`type`,unit,datetime_sale,datetime_return,datetime_edit,claims_money,employee_claims_return,tel_to_cus,employee_sale,symptom,accressory,note,note2,`status`,employee,datetime_save,claims_id_pic)" _
                    & "SELECT * FROM claims WHERE claims_id='" & Me.lblCIPclaims_idMe.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                Mainfrm.lblMainStatus.Text = "ย้ายข้อมูลเคลมเรียบร้อย"
                Mainfrm.lblMainStatus.Text = "ลบข้อมูลเคลมที่ส่งคืนแล้ว"
                strSQL = "DELETE FROM claims WHERE claims_id='" & Me.lblCIPclaims_idMe.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                Mainfrm.lblMainStatus.Text = "ลบข้อมูลเคลมที่ส่งคืนแล้วเรียบร้อย"
                For i As Integer = Me.dgCIP.SelectedRows.Count - 1 To 0 Step -1
                    Me.dgCIP.Rows.RemoveAt(Me.dgCIP.SelectedRows(i).Index)
                Next
                MsgBox("บันทึกส่งเคลมอีกรอบแล้ว", MsgBoxStyle.Information, "แจ้งให้ทราบ")
                Call startFrm()
            Catch ex As Exception

            End Try
        End If
    End Sub
    Dim txtCFclaims_id As String
    Private Sub btnCIPsavetoCus_Click(sender As Object, e As EventArgs) Handles btnCIPsavetoCus.Click
        If Me.rbCIPreturnClaims.Checked = True Then
            'ส่งเคลมอีกรอบ
            Try
                'ส่งเคลมอีกรอบ
                Call AutoNumberNo()
                Dim txtCFcustomer_id As String
                Dim txtCFcustomer_name As String
                Dim txtCFserial_pro As String
                Dim txtCFcode_pro As String
                Dim txtCFname_pro As String
                Dim txtCFbar_code As String
                Dim txtCFdatetime_sale As String
                Dim txtCFemployee_sale As String
                Dim txtCFprice_buy As Decimal
                Dim txtCFprice_wholsale As Decimal
                Dim txtCFprice_technician As Decimal
                Dim txtCFprice_loyal As Decimal
                Dim txtCFprice_members As Decimal
                Dim txtCFunit As String
                Dim txtCFtype As String
                strSQL = "SELECT code_pro,bar_code,name_pro," _
                    & "price_buy,`type`," _
                    & "unit FROM claims WHERE claims_id='" & Me.lblCIPclaims_id.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                With Dr
                    txtCFcustomer_id = Me.txtCIPcus_id.Text
                    txtCFcustomer_name = Me.txtCIPcus_name.Text
                    txtCFserial_pro = Me.txtCIPnew_sn.Text
                    txtCFcode_pro = .Item("code_pro")
                    txtCFname_pro = .Item("name_pro")
                    txtCFbar_code = .Item("bar_code")
                    txtCFprice_buy = .GetDecimal("price_buy")
                    txtCFprice_wholsale = "-"
                    txtCFprice_technician = "-"
                    txtCFprice_loyal = "-"
                    txtCFprice_members = "-"
                    txtCFunit = .Item("unit")
                    txtCFtype = .Item("type")
                    txtCFdatetime_sale = "-"
                    txtCFemployee_sale = "-"
                End With
                PictureBox1.Image = Code128Rendering.MakeBarcodeImage(txtCFclaims_id, CInt(1), True)
                'บันทึกข้อมูล
                strSQL = "insert into claims(claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,price_buy,price_wholesale,price_technician,price_loyal,price_members,type,unit,datetime_sale,employee_sale,symptom,accressory,note,status,employee,datetime_save,claims_id_pic) " _
                                    & " values(@claims_id,@customer_id,@serial_pro,@code_pro,@bar_code,@name_pro,@price_buy,@price_wholesale,@price_technician,@price_loyal,@price_members,@type,@unit,@datetime_sale,@employee_sale,@symptom,@accressory,@note,@status,@employee,@datetime_save,@claims_id_pic)"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.Add(New MySqlParameter("@claims_id", txtCFclaims_id))
                    .Parameters.Add(New MySqlParameter("@customer_id", txtCFcustomer_id))
                    .Parameters.Add(New MySqlParameter("@serial_pro", txtCFserial_pro))
                    .Parameters.Add(New MySqlParameter("@code_pro", txtCFcode_pro))
                    .Parameters.Add(New MySqlParameter("@bar_code", txtCFbar_code))
                    .Parameters.Add(New MySqlParameter("@name_pro", txtCFname_pro))
                    .Parameters.Add(New MySqlParameter("@price_buy", txtCFprice_buy))
                    .Parameters.Add(New MySqlParameter("@price_wholesale", txtCFprice_wholsale))
                    .Parameters.Add(New MySqlParameter("@price_technician", txtCFprice_technician))
                    .Parameters.Add(New MySqlParameter("@price_loyal", txtCFprice_loyal))
                    .Parameters.Add(New MySqlParameter("@price_members", txtCFprice_members))
                    .Parameters.Add(New MySqlParameter("@type", txtCFtype))
                    .Parameters.Add(New MySqlParameter("@unit", txtCFunit))
                    .Parameters.Add(New MySqlParameter("@datetime_sale", txtCFdatetime_sale))
                    .Parameters.Add(New MySqlParameter("@employee_sale", txtCFemployee_sale))
                    .Parameters.Add(New MySqlParameter("@symptom", Me.dgCIP.SelectedCells.Item(8).Value))
                    .Parameters.Add(New MySqlParameter("@accressory", Me.dgCIP.SelectedCells.Item(9).Value))
                    .Parameters.Add(New MySqlParameter("@note", "ส่งเคลมอีกรอบ"))
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
                'save id
                Mainfrm.lblMainStatus.Text = "บันทึกเคลมไอดี"
                strSQL = "insert into claims_id(claims_id) " _
                           & " values(@claims_id)"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    .Parameters.Add(New MySqlParameter("@claims_id", txtCFclaims_id))
                    Call open_connection()
                    .ExecuteNonQuery()
                End With

                'update status claims
                strSQL = "UPDATE claims SET serial_pro='" & Me.txtCIPnew_sn.Text & "'," _
                     & "datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "'," _
                     & "`status`='" & "ส่งคืนแล้ว" & "' WHERE claims_id='" & Me.lblCIPclaims_id.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()

                'update claims send
                strSQL = "UPDATE claims_send SET claims_send_status='" & "ส่งคืนแล้ว" & "'," _
                    & "datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "' WHERE claims_id='" & Me.lblCIPclaims_id.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                For i As Integer = Me.dgCIP.SelectedRows.Count - 1 To 0 Step -1
                    Me.dgCIP.Rows.RemoveAt(Me.dgCIP.SelectedRows(i).Index)
                Next

                'ย้ายข้อมูลงานเคลมที่ส่งคืนแล้ว
                Mainfrm.lblMainStatus.Text = "ย้ายข้อมูลเคลม"
                strSQL = "INSERT INTO claims_copy(claims_id,customer_id,serial_pro,code_pro,bar_code,name_pro,price_buy,price_wholesale,price_technician,price_loyel,price_members,`type`,unit,datetime_sale,datetime_return,datetime_edit,claims_money,employee_claims_return,tel_to_cus,employee_sale,symptom,accressory,note,note2,`status`,employee,datetime_save,claims_id_pic)" _
                    & "SELECT * FROM claims WHERE claims_id='" & Me.lblCIPclaims_id.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                Mainfrm.lblMainStatus.Text = "ย้ายข้อมูลเคลมเรียบร้อย"
                Mainfrm.lblMainStatus.Text = "ลบข้อมูลเคลมที่ส่งคืนแล้ว"
                strSQL = "DELETE FROM claims WHERE claims_id='" & Me.lblCIPclaims_id.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                Mainfrm.lblMainStatus.Text = "ลบข้อมูลเคลมที่ส่งคืนแล้วเรียบร้อย"
                MsgBox("บันทึกส่งเคลมอีกรอบแล้ว", MsgBoxStyle.Information, "แจ้งให้ทราบ")
                Call startFrm()
            Catch ex As Exception

            End Try

        ElseIf Me.rbCIPreturnToCus.Checked = True Then
            'รอส่งคืนลูกค้า
            Try
                'update status claims
                strSQL = "UPDATE claims SET serial_pro='" & Me.txtCIPnew_sn.Text & "'," _
                 & "datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "'," _
                 & "`status`='" & "รอส่งคืน" & "' WHERE claims_id='" & Me.lblCIPclaims_id.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()

                'update claims send
                strSQL = "UPDATE claims_send SET claims_send_status='" & "รอส่งคืน" & "'," _
                    & "datetime_edit='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "' WHERE claims_id='" & Me.lblCIPclaims_id.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                For i As Integer = Me.dgCIP.SelectedRows.Count - 1 To 0 Step -1
                    Me.dgCIP.Rows.RemoveAt(Me.dgCIP.SelectedRows(i).Index)
                Next
                MsgBox("บันทึกรอส่งคืนแล้ว", MsgBoxStyle.Information, "แจ้งให้ทราบ")
                Call startFrm()
            Catch ex As Exception

            End Try
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
                txtCFclaims_id = nid & Now.ToString("yyyyMMddHHmmss") & "00001"
            Else
                Dim newID As Integer = CInt(Dr.Item("ID"))
                newID += 1
                txtCFclaims_id = nid & Now.ToString("yyMMddHHmm") & newID.ToString("00000")
            End If
            Dr.Close()
            Mainfrm.lblMainStatus.Text = "โหลด ID แล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "โหลด ID ผิดพลาด"
        End Try
    End Sub

   
End Class