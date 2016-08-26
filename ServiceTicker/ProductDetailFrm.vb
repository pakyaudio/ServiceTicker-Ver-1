Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.IO

Public Class ProductDetailFrm
    Private Sub startfrm()
        A1 = Nothing
        PictureBoxProduct.Image = Nothing
        Me.cbbPDproSection.Items.Clear()
        Me.cbbPDproSection1.Items.Clear()
        Me.cbbPDproUnit.Items.Clear()
        Me.cbbPDsalefor.Items.Clear()
        Me.dgPDshowproduct.Enabled = True
        Me.dgPDserial.Rows.Clear()
        Me.dgPDshowproduct.Rows.Clear()
        Call disableTextBoxes(Me)
        Call getdatacombobox_product_section()
        Me.txtPDsearch.Enabled = True
        Me.cbbPDproSection1.Enabled = False
        Me.cbbPDproUnit.Enabled = False
        Me.cbbPDsalefor.Enabled = False
        Me.cbPDvaruntee.Enabled = False
        Me.btnPDgetBarcode.Enabled = False
        Me.btnPDSerialSave.Enabled = False
        Me.btnPDserialDel.Enabled = False

        Me.btnPDproDel.Enabled = False
        Me.btnPDbp.Enabled = False
        Me.btnPDproAdd.Enabled = True
        Me.btnPDselectImage.Enabled = False
        Me.btnPDproEdit.Text = "แก้ไข"
        Me.btnPDproAdd.Text = "เพิ่มสินค้า"
        Me.txtDprobuy.Text = "0"
        Me.txtPDproPiceCost.Text = "0"
        Me.txtPDstockbalance.Text = "0"
        Me.txtPDprodepleted.Text = "0"
        Me.txtPDnote.Text = "-"
        Me.lblPDsnCount2.Text = "0"
        Me.txtPDproID.Text = ""
        Me.txtPDbarcode.Text = ""
        Me.txtPDproName.Text = ""
        Me.lblPDdateEdit.Text = "-"
        If Me.txtPDproID.Text <> "" Then
            Me.btnPDproEdit.Enabled = True
            Me.btnPDproAdd.Enabled = True
        ElseIf Me.txtPDproID.Text = "" Then
            Me.btnPDproEdit.Enabled = False
            Me.btnPDproAdd.Enabled = True
        End If

    End Sub

    Private Sub startfrmSaveNewPro()
        A1 = Nothing
        Me.dgPDshowproduct.Enabled = True
        Me.dgPDshowproduct.Rows.Clear()
        Call disableTextBoxes(Me)
        Call getdatacombobox_product_section()
        Me.txtPDsearch.Enabled = True
        Me.cbbPDproSection1.Enabled = False
        Me.cbbPDproUnit.Enabled = False
        Me.cbbPDsalefor.Enabled = False
        Me.cbPDvaruntee.Enabled = False
        Me.btnPDgetBarcode.Enabled = False
        Me.btnPDSerialSave.Enabled = False
        Me.btnPDserialDel.Enabled = False
        Me.btnPDproEdit.Enabled = False
        Me.btnPDproDel.Enabled = False
        Me.btnPDbp.Enabled = False
        Me.btnPDproAdd.Enabled = True
        Me.btnPDselectImage.Enabled = False
        Me.btnPDproEdit.Text = "แก้ไข"
        Me.btnPDproAdd.Text = "เพิ่มสินค้า"
        Me.lblPDdateEdit.Text = "-"
        If Me.txtPDproID.Text <> "" Then
            Me.btnPDproEdit.Enabled = True
            Me.btnPDproAdd.Enabled = True
        ElseIf Me.txtPDproID.Text = "" Then
            Me.btnPDproEdit.Enabled = False
            Me.btnPDproAdd.Enabled = True
        End If
    End Sub
   
    Private Sub AutoNumberNo()
        Try
            Mainfrm.lblMainStatus.Text = "โหลดไอดี"
            dt = New DataTable
            strSQL = "SELECT ver_productid FROM ver_detail"
            dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
            Call open_connection()
            dtAdapter.Fill(dt)
            Dim verpid As String = dt.Rows(0).Item("ver_productid")

            strSQL = "SELECT Max(ID) as ID FROM product_id"

            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                txtPDproID.Text = verpid & Now.ToString("yy") & "0000001"
            Else
                Dim newID As Integer = CInt(Dr.Item("id"))
                newID += 1
                txtPDproID.Text = verpid & Now.ToString("yy") & newID.ToString("0000000")
            End If
            Dr.Close()
            Mainfrm.lblMainStatus.Text = "โหลดไอดีแล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub AutoNumberNo_barcode()
        Try
            Mainfrm.lblMainStatus.Text = "โหลดไอดีบาร์โค๊ต"
            dt = New DataTable
            strSQL = "SELECT ver_barcode FROM ver_detail"
            dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
            Call open_connection()
            dtAdapter.Fill(dt)
            Dim verbc As String = dt.Rows(0).Item("ver_barcode")

            strSQL = "SELECT Max(ID) as ID FROM product_id"
            dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                txtPDbarcode.Text = verbc & Now.ToString("yy") & "000001"
            Else
                Dim newID As Integer = CInt(Dr.Item("id"))
                newID += 1
                txtPDbarcode.Text = verbc & Now.ToString("yy") & newID.ToString("000000")
            End If
            Dr.Close()
            Mainfrm.lblMainStatus.Text = "โหลดไอดีบาร์โค๊ตแล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub getdatacombobox_product_section()
        Try
            Mainfrm.lblMainStatus.Text = "โหลด prosection_name"
            Me.cbbPDproSection.Items.Clear()
            strSQL = "select prosection_name from product_section ORDER BY prosection_name ASC"
            cmd = New MySqlCommand
            cmd.CommandText = strSQL
            cmd.Connection = ConnectionDB
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.cbbPDproSection.Items.Add(Dr("prosection_name"))
            End While
            Dr.Close()
            Mainfrm.lblMainStatus.Text = "โหลด prosection_name แล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub getdatacombobox_product_section1()
        Try
            Mainfrm.lblMainStatus.Text = "โหลด prosection_name"
            Me.cbbPDproSection1.Items.Clear()
            strSQL = "select prosection_name from product_section ORDER BY prosection_name ASC"
            cmd = New MySqlCommand
            cmd.CommandText = strSQL
            cmd.Connection = ConnectionDB
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.cbbPDproSection1.Items.Add(Dr("prosection_name"))
            End While
            Dr.Close()
            Mainfrm.lblMainStatus.Text = "โหลด prosection_name แล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub getdatacombobox_product_unit()
        Try
            Mainfrm.lblMainStatus.Text = "โหลด unit_p"
            Me.cbbPDproUnit.Items.Clear()
            strSQL = "select unit_p from unit ORDER BY unit_p ASC"
            cmd = New MySqlCommand
            cmd.CommandText = strSQL
            cmd.Connection = ConnectionDB
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                cbbPDproUnit.Items.Add(Dr("unit_p"))
            End While
            Dr.Close()
            Mainfrm.lblMainStatus.Text = "โหลด unit_p แล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub getdatacombobox_sale_company()
        Try
            Mainfrm.lblMainStatus.Text = "โหลด sale_company_name"
            Me.cbbPDsalefor.Items.Clear()
            strSQL = "select sale_company_name from sale_company ORDER BY sale_company_name ASC"
            cmd = New MySqlCommand
            cmd.CommandText = strSQL
            cmd.Connection = ConnectionDB
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                cbbPDsalefor.Items.Add(Dr("sale_company_name"))
            End While
            Dr.Close()
            Mainfrm.lblMainStatus.Text = "โหลด sale_company_name แล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub BLPrice()
        'ปรับราคาที่ไม่มีราคาให้มีราคา งงไหม
        Try
            strSQL = "SELECT version FROM database_version"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Me.dgPDshowproduct.Rows.Clear()
            Dr = cmd.ExecuteReader
            Dim v As String
            Dr.Read()
            v = Dr.GetString("version")
            If v = "2.7" Then
                Mainfrm.lblMainStatus.Text = "กำลังปรับสินค้าที่ไม่มีระดับราคาให้เท่ากับราคาขายปกติ"
                strSQL = "SELECT code_pro,bar_code,name_pro,price_cost,price_buy,price_wholesale,price_technician,price_loyal,price_members,count_num,update_date FROM product"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Me.dgPDshowproduct.Rows.Clear()
                Dr = cmd.ExecuteReader
                While (Dr.Read())
                    Dim r As Integer
                    With Me.dgPDshowproduct
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(1).Value = Dr.Item("code_pro")
                        .Rows(r).Cells(2).Value = Dr.Item("bar_code")
                        .Rows(r).Cells(3).Value = Dr.Item("name_pro")
                        .Rows(r).Cells(4).Value = Dr.Item("count_num")
                        .Rows(r).Cells(5).Value = Dr.GetDecimal("price_cost")
                        .Rows(r).Cells(6).Value = Dr.GetDecimal("price_buy")
                        .Rows(r).Cells(7).Value = Dr.GetDecimal("price_wholesale")
                        .Rows(r).Cells(8).Value = Dr.GetDecimal("price_technician")
                        .Rows(r).Cells(9).Value = Dr.GetDecimal("price_loyal")
                        .Rows(r).Cells(10).Value = Dr.GetDecimal("price_members")
                        .Rows(r).Cells(11).Value = Dr.Item("update_date")
                    End With
                End While
                For sum As Integer = 0 To Me.dgPDshowproduct.Rows.Count - 1
                    Me.dgPDshowproduct.Rows(sum).Cells(0).Value = sum + 1
                Next
                For blp As Integer = 0 To Me.dgPDshowproduct.Rows.Count - 1
                    If Me.dgPDshowproduct.Rows(blp).Cells(7).Value = "-" Or Me.dgPDshowproduct.Rows(blp).Cells(7).Value = "0" Then
                        strSQL = "UPDATE product SET price_wholesale=@price_wholesale WHERE code_pro='" & Me.dgPDshowproduct.Rows(blp).Cells(1).Value & "'"
                        Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                            cmd.Parameters.AddWithValue("@price_wholesale", Me.dgPDshowproduct.Rows(blp).Cells(6).Value)
                            Call open_connection()
                            cmd.ExecuteNonQuery()
                        End Using
                    End If
                Next
                For blp1 As Integer = 0 To Me.dgPDshowproduct.Rows.Count - 1
                    If Me.dgPDshowproduct.Rows(blp1).Cells(8).Value = "-" Or Me.dgPDshowproduct.Rows(blp1).Cells(8).Value = "0" Then
                        strSQL = "UPDATE product SET price_technician=@price_technician WHERE code_pro='" & Me.dgPDshowproduct.Rows(blp1).Cells(1).Value & "'"
                        Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                            cmd.Parameters.AddWithValue("@price_technician", Me.dgPDshowproduct.Rows(blp1).Cells(6).Value)
                            Call open_connection()
                            cmd.ExecuteNonQuery()
                        End Using
                    End If
                Next
                For blp2 As Integer = 0 To Me.dgPDshowproduct.Rows.Count - 1
                    If Me.dgPDshowproduct.Rows(blp2).Cells(9).Value = "-" Or Me.dgPDshowproduct.Rows(blp2).Cells(9).Value = "0" Then
                        strSQL = "UPDATE product SET price_loyal=@price_loyal WHERE code_pro='" & Me.dgPDshowproduct.Rows(blp2).Cells(1).Value & "'"
                        Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                            cmd.Parameters.AddWithValue("@price_loyal", Me.dgPDshowproduct.Rows(blp2).Cells(6).Value)
                            Call open_connection()
                            cmd.ExecuteNonQuery()
                        End Using
                    End If
                Next
                For blp3 As Integer = 0 To Me.dgPDshowproduct.Rows.Count - 1
                    If Me.dgPDshowproduct.Rows(blp3).Cells(10).Value = "-" Or Me.dgPDshowproduct.Rows(blp3).Cells(10).Value = "0" Then
                        strSQL = "UPDATE product SET price_members=@price_members WHERE code_pro='" & Me.dgPDshowproduct.Rows(blp3).Cells(1).Value & "'"
                        Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                            cmd.Parameters.AddWithValue("@price_members", Me.dgPDshowproduct.Rows(blp3).Cells(6).Value)
                            Call open_connection()
                            cmd.ExecuteNonQuery()
                        End Using

                    End If
                Next
                strSQL = "UPDATE `database_version` SET `version`='2.7.1';"

                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                Mainfrm.lblMainStatus.Text = "ปรับสินค้าที่ไม่มีระดับราคาให้เท่ากับราคาขายปกติแล้ว"
                Me.dgPDshowproduct.Rows.Clear()
            Else

            End If
        Catch ex As Exception

        End Try
    End Sub

    Dim selectSQL As String
    Private Sub getdata()
        Try
        Mainfrm.lblMainStatus.Text = "โหลด product"
            If selectSQL = 100 Then
                If Me.cbbPDproSection.Text = Nothing Then
                    strSQL = "SELECT code_pro,bar_code,name_pro,price_cost,price_buy,price_wholesale,price_technician,price_loyal,price_members,count_num,update_date " & _
                        "FROM product WHERE name_pro LIKE '%" & Me.txtPDsearch.Text & "%'"
                Else
                    strSQL = "SELECT code_pro,bar_code,name_pro,price_cost,price_buy,price_wholesale,price_technician,price_loyal,price_members,count_num,update_date " & _
                        "FROM product WHERE name_pro LIKE '%" & Me.txtPDsearch.Text & "%' AND `type`='" & Me.cbbPDproSection.Text & "'"
                End If
            ElseIf selectSQL = 200 Then
                strSQL = "SELECT code_pro,bar_code,name_pro,price_cost,price_buy,price_wholesale,price_technician,price_loyal,price_members,count_num,update_date FROM product"
            ElseIf selectSQL = 300 Then
                strSQL = "SELECT code_pro,bar_code,name_pro,price_cost,price_buy,price_wholesale,price_technician,price_loyal,price_members,count_num,update_date FROM product WHERE type='" & Me.cbbPDproSection.Text & "'"
            ElseIf selectSQL = 400 Then
                strSQL = "SELECT code_pro,bar_code,name_pro,price_cost,price_buy,price_wholesale,price_technician,price_loyal,price_members,count_num,update_date FROM product WHERE count_num='" & "0" & "'"
            ElseIf selectSQL = 500 Then
                strSQL = "SELECT code_pro,bar_code,name_pro,price_cost,price_buy,price_wholesale,price_technician,price_loyal,price_members,count_num,update_date FROM product WHERE update_date LIKE '%" & Now.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "%'"
            End If
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Me.dgPDshowproduct.Rows.Clear()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                If Dr.HasRows Then
                    Dim r As Integer
                    With Me.dgPDshowproduct
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(1).Value = Dr.Item("code_pro")
                        .Rows(r).Cells(2).Value = Dr.Item("bar_code")
                        .Rows(r).Cells(3).Value = Dr.Item("name_pro")
                        .Rows(r).Cells(4).Value = Dr.Item("count_num")
                        .Rows(r).Cells(5).Value = Dr.GetDecimal("price_cost")
                        .Rows(r).Cells(6).Value = Dr.GetDecimal("price_buy")
                        .Rows(r).Cells(7).Value = Dr.GetDecimal("price_wholesale")
                        .Rows(r).Cells(8).Value = Dr.GetDecimal("price_technician")
                        .Rows(r).Cells(9).Value = Dr.GetDecimal("price_loyal")
                        .Rows(r).Cells(10).Value = Dr.GetDecimal("price_members")
                        .Rows(r).Cells(11).Value = Dr.Item("update_date")
                    End With
                ElseIf Not Dr.HasRows Then
                    Mainfrm.lblMainStatus.Text = "ไม่พบข้อมูล"
                    Exit Try
                End If
            End While
            For sum As Integer = 0 To Me.dgPDshowproduct.Rows.Count - 1
                Me.dgPDshowproduct.Rows(sum).Cells(0).Value = sum + 1
            Next
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        selectSQL = Nothing
    End Sub
   
    Private Sub updateData()
        If Me.btnPDproEdit.Text = "แก้ไข" Then
            Mainfrm.lblMainStatus.Text = "แก้ไขข้อมูล"
            Me.btnPDproEdit.Text = "บันทึก"
            Call enableTextBoxes(Me)
            Me.dgPDshowproduct.Enabled = False
            Me.txtPDproID.Enabled = False
            Me.cbbPDproSection1.Enabled = True
            Me.cbPDvaruntee.Enabled = True
            Me.cbbPDproUnit.Enabled = True
            Me.cbbPDsalefor.Enabled = True
            Me.btnPDgetBarcode.Enabled = True
            Me.btnPDSerialSave.Enabled = True
            Me.btnPDserialDel.Enabled = True
            Me.btnPDbp.Enabled = True
            Me.btnPDproAdd.Enabled = False
            Me.btnPDproDel.Enabled = False
            Call getdatacombobox_product_section1()
            Call getdatacombobox_product_unit()
            Call getdatacombobox_sale_company()
            Exit Sub
        ElseIf Me.btnPDproEdit.Text = "บันทึก" Then
            If Me.txtPDbarcode.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่บาร์โค๊ดหรือกดปุ่มสร้างบาร์โค๊ด"
                MsgBox("กรุณาใส่บาร์โค๊ดหรือกดปุ่มสร้างบาร์โค๊ด", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.txtPDbarcode.Focus()
                Me.txtPDbarcode.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtPDproName.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่ชื่อสินค้า"
                MsgBox("กรุณาใส่ชื่อสินค้า", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.txtPDproName.Focus()
                Me.txtPDproName.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.cbbPDproSection1.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ไม่ได้เลือกประเภท"
                MsgBox("กรุณาเลือกประเภท", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.cbbPDproSection1.Focus()
                Me.cbbPDproSection1.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtDprobuy.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่ราคาขายปลีก"
                MsgBox("กรุณาใส่ราคาขายปลีก", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.txtDprobuy.Focus()
                Me.txtDprobuy.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtPDproPiceCost.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่ราคาต้นทุน"
                MsgBox("กรุณาใส่ราคาต้นทุน", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.txtPDproPiceCost.Focus()
                Me.txtPDproPiceCost.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.cbbPDproUnit.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่หน่วยนับ"
                MsgBox("กรุณาเลือกหรือใส่ หน่วยนับ", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.cbbPDproUnit.Focus()
                Me.cbbPDproUnit.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtPDstockbalance.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่จำนวนสินค้าที่นำเข้า หากเป็นสินค้า serial ให้ไปใส่ในช่อง ป้อนหมายเลข serial"
                MsgBox("กรุณาใส่สต็อกที่มี จำนวนสินค้าที่นำเข้า หากเป็นสินค้า serial ให้ไปใส่ในช่อง ป้อนหมายเลข serial ", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.txtPDstockbalance.Focus()
                Me.txtPDstockbalance.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtPDprodepleted.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่จำนวนเมื่อสิ้นค้าใกล้หมดให้เตือน"
                MsgBox("กรุณาใส่จำนวนเมื่อสิ้นค้าใกล้หมดให้เตือน", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.txtPDprodepleted.Focus()
                Me.txtPDprodepleted.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.cbPDvaruntee.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่ระยะเวลารับประกัน"
                MsgBox("กรุณาเลือกระยะเวลารับประกัน", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.cbPDvaruntee.Focus()
                Me.cbPDvaruntee.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.cbbPDsalefor.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ไม่ได้เลือกบริษัทหรือรายที่จัดซื้อมา"
                MsgBox("กรุณาเลือกบริษัทหรือรายที่จัดซื้อมา", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.cbbPDsalefor.Focus()
                Me.cbbPDsalefor.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtPDnote.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่หมายเหตุ "
                MsgBox("กรุณาใส่หมายเหตุ หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.txtPDnote.Focus()
                Me.txtPDnote.BackColor = Color.Salmon
                Exit Sub
            End If
            Try
            Dim UpDateAns As String
            UpDateAns = MsgBox("คุณแน่ใจว่าจะแก้ไขข้อมูลนี้", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
            If UpDateAns = System.Windows.Forms.DialogResult.No Then
                Mainfrm.lblMainStatus.Text = "การแก้ไขข้อมูลถูกยกเลิก"
                MsgBox("การแก้ไขข้อมูลถูกยกเลิก.", MsgBoxStyle.Information, "ยกเลิกการแก้ไข")
            Else
                    strSQL = "update product set bar_code='" & Me.txtPDbarcode.Text & "', name_pro='" & Me.txtPDproName.Text & "', type='" & Me.cbbPDproSection1.Text & "',varuntee='" & Me.cbPDvaruntee.Text & "', price_buy='" & Me.txtDprobuy.Text & "', price_wholesale='" & Me.txtPDp_wholsale.Text & "', price_technician='" & Me.txtPDp_technician.Text & "', price_loyel='" & Me.txtPDp_loyel.Text & "', price_members='" & Me.txtPDp_member.Text & "', spec='" & Me.txtPDspec.Text & "', price_cost='" & Me.txtPDproPiceCost.Text & "', unit='" & Me.cbbPDproUnit.Text & "', count_num='" & Me.txtPDstockbalance.Text & "', check_stock='" & Me.txtPDprodepleted.Text & "', update_date='" & Now.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "', company_buy='" & Me.cbbPDsalefor.Text & "', notepro='" & Me.txtPDnote.Text & "'  where code_pro='" & Me.dgPDshowproduct.SelectedCells(0).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                Mainfrm.lblMainStatus.Text = "แก้ไขข้อมูลเรียบร้อยแล้ว"
                MsgBox("แก้ไขข้อมูลเรียบร้อยแล้ว.", MsgBoxStyle.Information, "ยืนยัน")
                Me.btnPDproEdit.Text = "แก้ไข"
                End If
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
            'clear all textbox
            Call ClearTextBoxes(Me)
            Me.btnPDproEdit.Text = "แก้ไข"
        End If

        Call startfrm()
    End Sub

    Public Sub RestatrForm()
        'Friend frmm = New ProductDetailFrm
        'frmm.MdiParent = Mainfrm
        'frmm.Show()
        'Me.Close()
        Call startfrm()
    End Sub
    Private Sub DeleteData()
        Try
            Mainfrm.lblMainStatus.Text = "ลบข้อมูล"
            Dim Ans As String
            Ans = MsgBox("คุณแน่ในว่าจะลบข้อมูลนี้ ข้อมูล SN ของสินค้านี้จะถูกลบไปด้วย", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
            If Ans = System.Windows.Forms.DialogResult.No Then
                MsgBox("การลบข้อมูลถูกยกเลิก", MsgBoxStyle.Information, "ยืนยัน")
                'Me.dgPDshowproduct.ClearSelection()
                Call startfrm()
                Call ClearTextBoxes(Me)
                Exit Sub
            Else
                Mainfrm.lblMainStatus.Text = "กำลังลบข้อมูลสินค้า"
                strSQL = "DELETE FROM product WHERE code_pro='" & Me.txtPDproID.Text & "'"
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End Using
                Mainfrm.lblMainStatus.Text = "กำลังลบข้อมูล SN"
                strSQL = "DELETE FROM product_serial WHERE code_pro='" & Me.txtPDproID.Text & "'"
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End Using
                Mainfrm.lblMainStatus.Text = "ลบข้อมูลแล้ว"
                MsgBox("ลบข้อมูลที่คุณเลือกแล้ว", MsgBoxStyle.Information, "ยืนยัน")
                'Me.dgPDshowproduct.ClearSelection()
            End If
            Call startfrm()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Dim A1 As String
    Private Sub openImages()
        Try
            Mainfrm.lblMainStatus.Text = "กำลังเปิดไฟล์รูป"
            If Me.btnPDproAdd.Text = "บันทึก" Then
                strSQL = "SELECT picture FROM product_cache WHERE code_pro='" & Me.txtPDproID.Text & "'"
            Else
                strSQL = "SELECT picture FROM product WHERE code_pro='" & Me.txtPDproID.Text & "'"
            End If
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            'Dim picture As Image = Nothing
            Dim pictureData As Byte() = DirectCast(cmd.ExecuteScalar(), Byte())
            Dim stream As New IO.MemoryStream(pictureData)
            'Read the stream and create an Image object from the data.'
            stream.Write(pictureData, 0, pictureData.Length)
            Dim bitmap As New Bitmap(stream)
            PictureBoxProduct.Image = bitmap
            Mainfrm.lblMainStatus.Text = "เปิดไฟล์รูปแล้ว"
            A1 = "4528"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            Mainfrm.lblMainStatus.Text = "ไม่มีรูป"
            PictureBoxProduct.Image = Nothing
            A1 = "123456789"
        End Try
    End Sub
    Private Sub DeleteData_serialNumber()
        Try
            If Me.dgPDserial.Rows.Count <= 0 Then
            Else

                Mainfrm.lblMainStatus.Text = "กำลังลบข้อมูล"
                strSQL = "DELETE FROM product_serial WHERE serial_pro='" & Me.dgPDserial.SelectedCells(0).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                Dim rowr As Integer = Me.dgPDserial.SelectedRows.Count - 1
                Me.dgPDserial.Rows.Remove(Me.dgPDserial.SelectedRows(rowr))
                'For g As Integer = 0 To Me.dgPDserial.Rows.Count - 1
                '    Me.dgPDserial.Rows(g).Cells(0).Value = g + 1
                'Next
                'del count_num product
                Dim cp As String
                Dim scp As Decimal
                strSQL = "SELECT count_num FROM product WHERE code_pro='" & Me.txtPDproID.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                cp = Dr.GetDecimal("count_num")
                scp = CDec(cp) - 1

                'update count_num product
                strSQL = "UPDATE product SET count_num='" & scp & "' WHERE code_pro='" & Me.txtPDproID.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                'del count_num
                Me.txtPDstockbalance.Text = CDec(Me.txtPDstockbalance.Text) - 1
                Me.lblPDsnCount2.Text = CDec(Me.lblPDsnCount2.Text) - 1
                For sumNsn As Integer = 0 To Me.dgPDshowproduct.Rows.Count - 1
                    If Me.dgPDshowproduct.Rows(sumNsn).Cells(1).Value = Me.txtPDproID.Text Then
                        Me.dgPDshowproduct.Rows(sumNsn).Cells(4).Value = CDec(Me.dgPDshowproduct.Rows(sumNsn).Cells(4).Value) - 1
                    End If
                Next
                Me.txtPDAddSn.Text = ""
            End If

            Mainfrm.lblMainStatus.Text = "ลบข้อมูลแล้ว"
            'Call getDataSerialNumber()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub btuPDaddSaleCompany_Click(sender As Object, e As EventArgs) Handles btuPDaddSaleCompany.Click
        SaleCompanyFrm.MdiParent = Mainfrm
        SaleCompanyFrm.Show()
    End Sub

    Private Sub btnPDaddSection_Click(sender As Object, e As EventArgs) Handles btnPDaddSection.Click
        ProductSectionFrm.MdiParent = Mainfrm
        ProductSectionFrm.Show()
    End Sub

    Private Sub ProductDetailfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call startfrm()
        Me.Icon = Mainfrm.Icon
        'Call BLPrice()
    End Sub

    Private Sub btnPDgetBarcode_Click(sender As Object, e As EventArgs) Handles btnPDgetBarcode.Click
        Call AutoNumberNo_barcode()
    End Sub

    Private Sub btnPDproAdd_Click(sender As Object, e As EventArgs) Handles btnPDproAdd.Click
        If Me.btnPDproAdd.Text = "เพิ่มสินค้า" Then
            Call ClearTextBoxes(Me)
            Call startfrm()
            Mainfrm.lblMainStatus.Text = "เพิ่มสินค้า"
            Me.btnPDproAdd.Text = "บันทึก"
            Me.dgPDshowproduct.Enabled = False
            Call enableTextBoxes(Me)
            Call AutoNumberNo()
            Call getdatacombobox_product_section1()
            Call getdatacombobox_product_unit()
            Call getdatacombobox_sale_company()
            Me.txtPDproID.Enabled = False
            Me.cbbPDproSection1.Enabled = True
            Me.cbPDvaruntee.Enabled = True
            Me.cbbPDproUnit.Enabled = True
            Me.cbbPDsalefor.Enabled = True
            Me.btnPDgetBarcode.Enabled = True
            Me.btnPDSerialSave.Enabled = True
            Me.btnPDserialDel.Enabled = True
            Me.btnPDproEdit.Enabled = False
            Me.btnPDproDel.Enabled = False
            Me.btnPDselectImage.Enabled = True
            Me.btnPDbp.Enabled = True
            Me.txtPDAddSn.Enabled = False
            Me.btnPDSerialSave.Enabled = False
            Me.btnPDserialDel.Enabled = False
            Exit Sub
        ElseIf Me.btnPDproAdd.Text = "บันทึก" Then
            If Me.txtPDbarcode.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่บาร์โค๊ด"
                MsgBox("กรุณาใส่บาร์โค๊ดหรือกดปุ่มสร้างบาร์โค๊ด", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.txtPDbarcode.Focus()
                Me.txtPDbarcode.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtPDproName.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่ชื่อสินค้า"
                MsgBox("กรุณาใส่ชื่อสินค้า", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.txtPDproName.Focus()
                Me.txtPDproName.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.cbbPDproSection1.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่ชื่อประเภท"
                MsgBox("กรุณาเลือกประเภท", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.cbbPDproSection1.Focus()
                Me.cbbPDproSection1.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.cbPDvaruntee.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่ระยะเวลารับประกัน"
                MsgBox("กรุณาเลือกระยะเวลารับประกัน", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.cbPDvaruntee.Focus()
                Me.cbPDvaruntee.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtDprobuy.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่ราคาขายปลีก"
                MsgBox("กรุณาใส่ราคาขายปลีก", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.txtDprobuy.Focus()
                Me.txtDprobuy.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtPDproPiceCost.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่ราคาต้นทุน"
                MsgBox("กรุณาใส่ราคาต้นทุน", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.txtPDproPiceCost.Focus()
                Me.txtPDproPiceCost.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.cbbPDproUnit.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ไม่ได้เลือกหน่วยนับ"
                MsgBox("กรุณาเลือกหรือใส่ หน่วยนับ", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.cbbPDproUnit.Focus()
                Me.cbbPDproUnit.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtPDstockbalance.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่สต็อกที่มี"
                MsgBox("กรุณาใส่สต็อกที่มี จำนวนสินค้าที่นำเข้า หากเป็นสินค้า serial ให้ไปใส่ในช่อง ป้อนหมายเลข serial ", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.txtPDstockbalance.Focus()
                Me.txtPDstockbalance.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtPDprodepleted.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่จำนวนเตือนใกล้หมด"
                MsgBox("กรุณาใส่จำนวนเมื่อสิ้นค้าใกล้หมดให้เตือน", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.txtPDprodepleted.Focus()
                Me.txtPDprodepleted.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.cbbPDsalefor.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่ชื่อบริษัทที่จัดซื้อ"
                MsgBox("กรุณาเลือกบริษัทหรือรายที่จัดซื้อมา", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.cbbPDsalefor.Focus()
                Me.cbbPDsalefor.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtPDnote.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่หมายเหตุ"
                MsgBox("กรุณาใส่หมายเหตุ หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.txtPDnote.Focus()
                Me.txtPDnote.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtPDp_wholsale.Text = "" Or Me.txtPDp_wholsale.Text = "-" Then
                Me.txtPDp_wholsale.Text = "0"
            End If
            If Me.txtPDp_technician.Text = "" Or Me.txtPDp_technician.Text = "-" Then
                Me.txtPDp_technician.Text = "0"
            End If
            If Me.txtPDp_loyel.Text = "" Or Me.txtPDp_loyel.Text = "-" Then
                Me.txtPDp_loyel.Text = "0"
            End If
            If Me.txtPDp_member.Text = "" Or Me.txtPDp_member.Text = "-" Then
                Me.txtPDp_member.Text = "0"
            End If
            Dim Ans As String
            Mainfrm.lblMainStatus.Text = "จะเพิ่มข้อมูลไหม"
            Ans = MsgBox("คุณแน่ใจว่าจะเพิ่มข้อมูลนี้", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
            If Ans = System.Windows.Forms.DialogResult.No Then
                MsgBox("การเพิ่มข้อมูลถูกยกเลิก", MsgBoxStyle.Information, "ยืนยัน")
                Call startfrm()
                Exit Sub
            Else
                Try
                    Mainfrm.lblMainStatus.Text = "กำลังส่งข้อมูลเข้าฐานข้อมูล"
                    strSQL = "INSERT INTO product(code_pro,bar_code,name_pro,`type`,varuntee,price_cost,price_buy,price_wholesale,price_technician,price_loyal,price_members,unit,count_num,check_stock,company_buy,notepro,spec,update_date)" _
                        & "VALUES(@code_pro,@bar_code,@name_pro,@type,@varuntee,@price_cost,@price_buy,@price_wholesale,@price_technician,@price_loyal,@price_members,@unit,@count_num,@check_stock,@company_buy,@notepro,@spec,@update_date)"
                    Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                        cmd.Parameters.AddWithValue("@code_pro", Me.txtPDproID.Text)
                        cmd.Parameters.AddWithValue("@bar_code", Me.txtPDbarcode.Text)
                        cmd.Parameters.AddWithValue("@name_pro", Me.txtPDproName.Text)
                        cmd.Parameters.AddWithValue("@type", Me.cbbPDproSection1.Text)
                        cmd.Parameters.AddWithValue("@varuntee", Me.cbPDvaruntee.Text)
                        cmd.Parameters.AddWithValue("@price_buy", Me.txtDprobuy.Text)
                        cmd.Parameters.AddWithValue("@price_cost", Me.txtPDproPiceCost.Text)
                        cmd.Parameters.AddWithValue("@price_wholesale", Me.txtPDp_wholsale.Text)
                        cmd.Parameters.AddWithValue("@price_technician", Me.txtPDp_technician.Text)
                        cmd.Parameters.AddWithValue("@price_loyal", Me.txtPDp_loyel.Text)
                        cmd.Parameters.AddWithValue("@price_members", Me.txtPDp_member.Text)
                        cmd.Parameters.AddWithValue("@unit", Me.cbbPDproUnit.Text)
                        cmd.Parameters.AddWithValue("@count_num", Me.txtPDstockbalance.Text)
                        cmd.Parameters.AddWithValue("@check_stock", Me.txtPDprodepleted.Text)
                        cmd.Parameters.AddWithValue("@company_buy", Me.cbbPDsalefor.Text)
                        cmd.Parameters.AddWithValue("@notepro", Me.txtPDnote.Text)
                        cmd.Parameters.AddWithValue("@spec", Me.txtPDspec.Text)
                        cmd.Parameters.AddWithValue("@update_date", Now.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")))
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    End Using
                Catch ex As Exception
                    Mainfrm.lblMainStatus.Text = "ส่งข้อมูลเข้าฐานข้อมูลผิดพลาด"
                End Try
                Try
                    Mainfrm.lblMainStatus.Text = "กำลังส่งข้อมูลเข้าฐานข้อมูล ID"
                    strSQL = "insert into product_id(code_pro,bar_code,name_pro,datetime_save)VALUES(@code_pro,@bar_code,@name_pro,@datetime_save)"
                    Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                        cmd.Parameters.AddWithValue("@code_pro", Me.txtPDproID.Text)
                        cmd.Parameters.AddWithValue("@bar_code", Me.txtPDbarcode.Text)
                        cmd.Parameters.AddWithValue("@name_pro", Me.txtPDproName.Text)
                        cmd.Parameters.AddWithValue("@datetime_save", Now.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")))
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    End Using
                Catch ex As Exception
                    Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    Mainfrm.lblMainStatus.Text = "ส่งข้อมูลเข้าฐานข้อมูล ID ผิดพลาด"
                End Try
                Try
                    Mainfrm.lblMainStatus.Text = "โหลดข้อมูลรูป"
                    Dim pic() As Byte
                    strSQL = "SELECT picture FROM product_cache WHERE code_pro='" & Me.txtPDproID.Text & "'"
                    Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        Dr = cmd.ExecuteReader
                        Dr.Read()
                        pic = Dr.Item("picture")
                    End Using
                    Mainfrm.lblMainStatus.Text = "อัพเดทข้อมูลรูป"
                    strSQL = "UPDATE product SET picture=@pic WHERE code_pro='" & Me.txtPDproID.Text & "'"
                    Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                        cmd.Parameters.AddWithValue("@pic", pic)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    End Using

                    Mainfrm.lblMainStatus.Text = "ลบข้อมูลรูปจากฐานข้อมูลชั่วคราว"
                    strSQL = "DELETE FROM product_cache WHERE code_pro='" & Me.txtPDproID.Text & "'"
                    Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    End Using
                    Mainfrm.lblMainStatus.Text = "บันทึกข้อมูลแล้ว"
                    MsgBox("บันทึกข้อมูลแล้ว", MsgBoxStyle.Information, "บันทึกข้อมูล")
                Catch ex As Exception
                    Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    Mainfrm.lblMainStatus.Text = "อัพเดทข้อมูลรูปผิดพลาด"
                End Try
            End If

            Me.btnPDproAdd.Text = "เพิ่มสินค้า"
        End If
        'Call ClearTextBoxes(Me)
        Call startfrmSaveNewPro()
        selectSQL = 500
        Call getdata()
        ' Me.dgPDshowproduct.DataSource = "null"
    End Sub

    Private Sub btnPDgetDataAll_Click(sender As Object, e As EventArgs) Handles btnPDgetDataAll.Click
        selectSQL = 200
        Call getdata()
    End Sub

    Private Sub btnPDSerachProduct_Click(sender As Object, e As EventArgs) Handles btnPDSerachProduct.Click
        If String.IsNullOrEmpty(Me.txtPDsearch.Text) Then
            Mainfrm.lblMainStatus.Text = "ใส่อักษรตั้งแต่ 1 ตัว เพื่อค้นหา"
        Else
            selectSQL = 100
            Call getdata()
            Me.txtPDsearch.Clear()
        End If
    End Sub
    Private Sub getDataSerialNumber()
        Try
            Application.DoEvents()
        Mainfrm.lblMainStatus.Text = "ดึงข้อมูล SN"
            Me.dgPDserial.Rows.Clear()
            strSQL = "SELECT serial_pro,name_pro,date_in FROM product_serial WHERE code_pro='" & Me.txtPDproID.Text & "'"
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                While (Dr.Read())
                    Dim r As Integer
                    With Me.dgPDserial

                        'Me.Enabled = False
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(0).Value = Dr("serial_pro")
                        .Rows(r).Cells(1).Value = Dr("name_pro")
                        .Rows(r).Cells(2).Value = Dr("date_in")
                        Me.lblPDsnCount2.Text = r + 1
                    End With
                End While
            End Using
        Mainfrm.lblMainStatus.Text = "ดึงข้อมูล SN เสร็จแล้ว"
        Dr.Close()
            'Me.Enabled = True

        Catch ex As Exception

            Mainfrm.lblMainStatus.Text = "ผิดพลาด ดึงข้อมูล SN " & ex.Message
        End Try
    End Sub
    Private Sub dgPDshowproduct_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgPDshowproduct.MouseDoubleClick
        Try
        Mainfrm.lblMainStatus.Text = "ดึงข้อมูลสินค้า"
            strSQL = "SELECT code_pro,bar_code,name_pro,type,varuntee,price_cost,price_buy,price_wholesale,price_technician,price_loyal,price_members,unit,count_num,check_stock,company_buy,notepro,spec,update_date FROM product WHERE code_pro='" & Me.dgPDshowproduct.SelectedCells(1).Value & "'"
        Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                Me.txtPDproID.Text = Dr.GetString("code_pro")
                Me.txtPDbarcode.Text = Dr.GetString("bar_code")
                Me.txtPDproName.Text = Dr.GetString("name_pro")
                Me.cbbPDproSection1.Text = Dr.GetString("type")
                Me.cbPDvaruntee.Text = Dr.GetString("varuntee")
                Me.lblPDdateEdit.Text = Dr.GetString("update_date")
                Me.txtDprobuy.Text = Dr.GetDecimal("price_buy")
                Me.txtPDproPiceCost.Text = Dr.GetDecimal("price_cost")
                Me.txtPDp_wholsale.Text = Dr.GetDecimal("price_wholesale")
                Me.txtPDp_technician.Text = Dr.GetDecimal("price_technician")
                Me.txtPDp_loyel.Text = Dr.GetDecimal("price_loyal")
                Me.txtPDp_member.Text = Dr.GetDecimal("price_members")
                Me.cbbPDproUnit.Text = Dr("unit")
                Me.txtPDstockbalance.Text = Dr.GetString("count_num")
                Me.txtPDprodepleted.Text = Dr.GetString("check_stock")
                Me.cbbPDsalefor.Text = Dr.GetString("company_buy")
                Me.txtPDnote.Text = Dr.GetString("notepro")
                Me.txtPDspec.Text = Dr.GetString("spec")
        End Using
        Me.btnPDproEdit.Enabled = True
        Me.btnPDproDel.Enabled = True
        Me.btnPDproAdd.Enabled = False
        Mainfrm.lblMainStatus.Text = "ดึงข้อมูลสินค้าแล้ว"
        Call openImages()

        'getdata serial number
            Call getDataSerialNumber()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub btnPDproEdit_Click(sender As Object, e As EventArgs) Handles btnPDproEdit.Click
        If Me.btnPDproEdit.Text = "แก้ไข" Then
            Mainfrm.lblMainStatus.Text = "แก้ไขข้อมูลสินค้า"
            Me.btnPDproEdit.Text = "บันทึก"
            Call enableTextBoxes(Me)
            Me.dgPDshowproduct.Enabled = False
            Me.txtPDproID.Enabled = False
            Me.cbbPDproSection1.Enabled = True
            Me.cbPDvaruntee.Enabled = True
            Me.cbbPDproUnit.Enabled = True
            Me.cbbPDsalefor.Enabled = True
            Me.btnPDgetBarcode.Enabled = True
            Me.btnPDSerialSave.Enabled = True
            Me.btnPDserialDel.Enabled = True
            Me.btnPDproAdd.Enabled = False
            Me.btnPDproDel.Enabled = False
            Me.btnPDbp.Enabled = True
            Me.btnPDselectImage.Enabled = True
            Call getdatacombobox_product_section1()
            Call getdatacombobox_product_unit()
            Call getdatacombobox_sale_company()
            Exit Sub
        ElseIf Me.btnPDproEdit.Text = "บันทึก" Then
            If Me.txtPDbarcode.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่บาร์โค๊ด"
                MsgBox("กรุณาใส่บาร์โค๊ดหรือกดปุ่มสร้างบาร์โค๊ด", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.txtPDbarcode.Focus()
                Me.txtPDbarcode.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtPDproName.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่ชื่อสินค้า"
                MsgBox("กรุณาใส่ชื่อสินค้า", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.txtPDproName.Focus()
                Me.txtPDproName.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.cbbPDproSection1.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่ประเภท"
                MsgBox("กรุณาเลือกประเภท", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.cbbPDproSection1.Focus()
                Me.cbbPDproSection1.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.cbPDvaruntee.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่ระยะเวลารับประกัน"
                MsgBox("กรุณาเลือกระยะเวลารับประกัน", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.cbPDvaruntee.Focus()
                Me.cbPDvaruntee.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtDprobuy.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่ราคาขายปลีก"
                MsgBox("กรุณาใส่ราคาขายปลีก", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.txtDprobuy.Focus()
                Me.txtDprobuy.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtPDproPiceCost.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่ราคาต้นทุน"
                MsgBox("กรุณาใส่ราคาต้นทุน", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.txtPDproPiceCost.Focus()
                Me.txtPDproPiceCost.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.cbbPDproUnit.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ไม่ได้เลือกหน่วยนับ"
                MsgBox("กรุณาเลือกหรือใส่ หน่วยนับ", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.cbbPDproUnit.Focus()
                Me.cbbPDproUnit.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtPDstockbalance.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่สต็อกที่มี"
                MsgBox("กรุณาใส่สต็อกที่มี จำนวนสินค้าที่นำเข้า หากเป็นสินค้า serial ให้ไปใส่ในช่อง ป้อนหมายเลข serial ", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.txtPDstockbalance.Focus()
                Me.txtPDstockbalance.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtPDprodepleted.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่จำนวนเมื่อสิ้นค้าใกล้หมดให้เตือน"
                MsgBox("กรุณาใส่จำนวนเมื่อสิ้นค้าใกล้หมดให้เตือน", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.txtPDprodepleted.Focus()
                Me.txtPDprodepleted.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.cbbPDsalefor.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ไม่ได้เลือกบริษัทหรือรายที่จัดซื้อมา"
                MsgBox("กรุณาเลือกบริษัทหรือรายที่จัดซื้อมา", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.cbbPDsalefor.Focus()
                Me.cbbPDsalefor.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtPDnote.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ไม่ได้ใส่หมายเหตุ"
                MsgBox("กรุณาใส่หมายเหตุ หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.txtPDnote.Focus()
                Me.txtPDnote.BackColor = Color.Salmon
                Exit Sub
            End If
            Try
                Dim UpDateAns As String
                Mainfrm.lblMainStatus.Text = "แก้ไขข้อมูลไหม"
                UpDateAns = MsgBox("คุณแน่ใจว่าจะแก้ไขข้อมูลนี้", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
                If UpDateAns = System.Windows.Forms.DialogResult.No Then
                    Mainfrm.lblMainStatus.Text = "ยกเลิกการแก้ไขข้อมูล"
                    MsgBox("การแก้ไขข้อมูลถูกยกเลิก.", MsgBoxStyle.Information, "ยกเลิกการแก้ไข")
                    Call startfrm()
                Else
                    Try
                    'อัพเดท product
                        strSQL = "UPDATE product SET bar_code='" & Me.txtPDbarcode.Text & "'," _
                            & "name_pro='" & Me.txtPDproName.Text & "'," _
                            & "type='" & Me.cbbPDproSection1.Text & "'," _
                            & "varuntee='" & Me.cbPDvaruntee.Text & "'," _
                            & "price_buy='" & Me.txtDprobuy.Text & "'," _
                            & "price_cost='" & Me.txtPDproPiceCost.Text & "'," _
                            & "price_wholesale='" & Me.txtPDp_wholsale.Text & "'," _
                            & "price_technician='" & Me.txtPDp_technician.Text & "'," _
                            & "price_loyal='" & Me.txtPDp_loyel.Text & "'," _
                            & "price_members='" & Me.txtPDp_member.Text & "'," _
                            & "unit='" & Me.cbbPDproUnit.Text & "'," _
                            & "count_num='" & Me.txtPDstockbalance.Text & "'," _
                            & "check_stock='" & Me.txtPDprodepleted.Text & "'," _
                            & "update_date='" & Now.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "', company_buy='" & Me.cbbPDsalefor.Text & "'," _
                            & "notepro='" & Me.txtPDnote.Text & "'," _
                            & "spec='" & Me.txtPDspec.Text & "'" _
                            & " WHERE code_pro='" & Me.txtPDproID.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด อัพเดท product " & ex.Message
                    End Try

                    'อัพเดท product_serial
                    Try
                        strSQL = "UPDATE product_serial SET name_pro='" & Me.txtPDproName.Text & "'" & _
                            " WHERE code_pro='" & Me.txtPDproID.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด อัพเดท product_serial " & ex.Message
                    End Try

                    'อัพเดท product_id
                    Try
                        strSQL = "UPDATE product_id SET bar_code='" & Me.txtPDbarcode.Text & "',name_pro='" & Me.txtPDproName.Text & "'" & _
                            " WHERE code_pro='" & Me.txtPDproID.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด อัพเดท product_id " & ex.Message
                    End Try

                    'อัพเดท buy_pro
                    Try
                        strSQL = "UPDATE buy_pro SET bar_code='" & Me.txtPDbarcode.Text & "'," & _
                            "name_pro='" & Me.txtPDproName.Text & "',unit='" & Me.cbbPDproUnit.Text & "' WHERE code_pro='" & Me.txtPDproID.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด อัพเดท buy_pro " & ex.Message
                    End Try

                    'อัพเดท cash_sale_barcode
                    Try
                        strSQL = "UPDATE cash_sale_barcode SET bar_code='" & Me.txtPDbarcode.Text & "'," & _
                            "name_pro='" & Me.txtPDproName.Text & "',unit='" & Me.cbbPDproUnit.Text & "'," & _
                            "type='" & Me.cbbPDproSection1.Text & "' WHERE code_pro='" & Me.txtPDproID.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด อัพเดท cash_sale_barcode " & ex.Message
                    End Try

                    'อัพเดท cash_sale_serial
                    Try
                        strSQL = "UPDATE cash_sale_serial SET bar_code='" & Me.txtPDbarcode.Text & "'," & _
                            "name_pro='" & Me.txtPDproName.Text & "'" & _
                            " WHERE code_pro='" & Me.txtPDproID.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด อัพเดท cash_sale_serial " & ex.Message
                    End Try

                    'อัพเดท check_stock
                    Try
                        strSQL = "UPDATE check_stock SET " & _
                            "name_pro='" & Me.txtPDproName.Text & "'" & _
                            " WHERE code_pro='" & Me.txtPDproID.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด อัพเดท check_stock " & ex.Message
                    End Try

                    'อัพเดท check_stock_bc
                    Try
                        strSQL = "UPDATE check_stock_bc SET bar_code='" & Me.txtPDbarcode.Text & "'," & _
                            "name_pro='" & Me.txtPDproName.Text & "'" & _
                            " WHERE code_pro='" & Me.txtPDproID.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด อัพเดท check_stock_bc " & ex.Message
                    End Try

                    'อัพเดท claims
                    Try
                        strSQL = "UPDATE claims SET bar_code='" & Me.txtPDbarcode.Text & "'," & _
                            "name_pro='" & Me.txtPDproName.Text & "'" & _
                            " WHERE code_pro='" & Me.txtPDproID.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด อัพเดท claims " & ex.Message
                    End Try

                    'อัพเดท claims_cache
                    Try
                        strSQL = "UPDATE claims_cache SET bar_code='" & Me.txtPDbarcode.Text & "'," & _
                            "name_pro='" & Me.txtPDproName.Text & "'" & _
                            " WHERE code_pro='" & Me.txtPDproID.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด อัพเดท claims_cache " & ex.Message
                    End Try

                    'อัพเดท claims_copy
                    Try
                        strSQL = "UPDATE claims_copy SET bar_code='" & Me.txtPDbarcode.Text & "'," & _
                            "name_pro='" & Me.txtPDproName.Text & "'" & _
                            " WHERE code_pro='" & Me.txtPDproID.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด อัพเดท claims_copy " & ex.Message
                    End Try

                    'อัพเดท claims_send_report
                    Try
                        strSQL = "UPDATE claims_send_report SET bar_code='" & Me.txtPDbarcode.Text & "'," & _
                            "name_pro='" & Me.txtPDproName.Text & "',unit='" & Me.cbbPDproUnit.Text & "'," & _
                            "type='" & Me.cbbPDproSection1.Text & "'" & _
                            " WHERE code_pro='" & Me.txtPDproID.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด อัพเดท claims_send_report " & ex.Message
                    End Try

                    'อัพเดท returnproduct_barcode
                    Try
                        strSQL = "UPDATE returnproduct_barcode SET " & _
                            "name_pro='" & Me.txtPDproName.Text & "'" & _
                            " WHERE code_pro='" & Me.txtPDproID.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด อัพเดท returnproduct_barcode " & ex.Message
                    End Try

                    'อัพเดท returnproduct_serial
                    Try
                        strSQL = "UPDATE returnproduct_serial SET " & _
                            "name_pro='" & Me.txtPDproName.Text & "'" & _
                            " WHERE code_pro='" & Me.txtPDproID.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด อัพเดท returnproduct_serial " & ex.Message
                    End Try

                    'อัพเดท sale_barcode
                    Try
                        strSQL = "UPDATE sale_barcode SET bar_code='" & Me.txtPDbarcode.Text & "'," & _
                            "name_pro='" & Me.txtPDproName.Text & "',unit='" & Me.cbbPDproUnit.Text & "'," & _
                            "type='" & Me.cbbPDproSection1.Text & "'," & _
                            "name_pro='" & Me.txtPDproName.Text & "'" & _
                            " WHERE code_pro='" & Me.txtPDproID.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด อัพเดท sale_barcode " & ex.Message
                    End Try

                    'อัพเดท sale_serial
                    Try
                        strSQL = "UPDATE sale_serial SET bar_code='" & Me.txtPDbarcode.Text & "'," & _
                            "name_pro='" & Me.txtPDproName.Text & "'" & _
                            " WHERE code_pro='" & Me.txtPDproID.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด อัพเดท sale_serial " & ex.Message
                    End Try

                    'อัพเดท stock_number_cache
                    Try
                        strSQL = "UPDATE stock_number_cache SET bar_code='" & Me.txtPDbarcode.Text & "'," & _
                            "name_pro='" & Me.txtPDproName.Text & "',type='" & Me.cbbPDproSection1.Text & "'" & _
                            " WHERE code_pro='" & Me.txtPDproID.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด อัพเดท stock_number_cache " & ex.Message
                    End Try

                    'อัพเดท stock_number_sn_cache
                    Try
                        strSQL = "UPDATE stock_number_sn_cache SET " & _
                            "name_pro='" & Me.txtPDproName.Text & "'" & _
                            " WHERE code_pro='" & Me.txtPDproID.Text & "'"
                        Mainfrm.lblMainStatus.Text = strSQL
                        cmd = New MySqlCommand(strSQL, ConnectionDB)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด อัพเดท stock_number_sn_cache " & ex.Message
                    End Try

                    Mainfrm.lblMainStatus.Text = "แก้ไขข้อมูลแล้ว"
                    MsgBox("แก้ไขข้อมูลเรียบร้อยแล้ว.", MsgBoxStyle.Information, "ยืนยัน")
                    Me.btnPDproEdit.Text = "แก้ไข"
                End If
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "แก้ไขข้อมูลไม่ได้"
                MsgBox("ไม่สามารถบันทึกข้อมูลได้ 1.ตรวจสอบการกรอกข้อมูลห้ามมีอักษรพิเศษ !@#$%^&*' 2.ตรวจสอบฐานข้อมูล", MsgBoxStyle.Exclamation, "แจ้งเตือน")
            End Try
            'clear all textbox
            Call ClearTextBoxes(Me)
            Me.btnPDproEdit.Text = "แก้ไข"
        End If
        Me.dgPDshowproduct.Rows.Clear()
        Me.dgPDserial.Rows.Clear()
        Call ClearTextBoxes(Me)
        Call startfrm()
        selectSQL = 500
        Call getdata()
    End Sub

    Private Sub btnPDproDel_Click(sender As Object, e As EventArgs) Handles btnPDproDel.Click
        If Me.btnPDproEdit.Text = "บันทึก" Then
            Mainfrm.lblMainStatus.Text = "ข้อมูลถูกแก้ไขอยู่"
            MsgBox("คุณได้ทำการแก้ไขข้อมูล โปรดทำการบันทึกก่อน", MsgBoxStyle.Exclamation, "แจ้งเตือน")
        End If
        Call DeleteData()
        'Call startfrm()
        Me.dgPDshowproduct.Refresh()
        'Me.dgPDshowproduct.DataSource = "null"
    End Sub
    Private Sub addSN()
        If Me.dgPDserial.RowCount = 0 Then
            If Me.txtPDAddSn.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ใส่ SN"
                MsgBox("กรุณาใส่ SerialNumber", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.txtPDAddSn.Focus()
                Me.txtPDAddSn.BackColor = Color.Salmon
            Else
                Try
                    Mainfrm.lblMainStatus.Text = "บันทึกข้อมูลลงฐานข้อมูล"
                    strSQL = "INSERT INTO product_serial(code_pro,serial_pro,date_in,name_pro)VALUES(@cp,@sp,@di,@np)"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    cmd.Parameters.AddWithValue("@cp", Me.txtPDproID.Text)
                    cmd.Parameters.AddWithValue("@sp", Me.txtPDAddSn.Text)
                    cmd.Parameters.AddWithValue("@di", Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")))
                    cmd.Parameters.AddWithValue("@np", Me.txtPDproName.Text)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                    Dim rs As Integer
                    With Me.dgPDserial
                        rs = .Rows.Count
                        .Rows.Add()
                        .Rows(rs).Cells(0).Value = Me.txtPDAddSn.Text
                        .Rows(rs).Cells(1).Value = Me.txtPDproName.Text
                        .Rows(rs).Cells(2).Value = Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))
                    End With
                    'sum count_num product
                    Dim cp As String
                    Dim scp As Decimal
                    strSQL = "SELECT count_num FROM product WHERE code_pro='" & Me.txtPDproID.Text & "'"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader()
                    Dr.Read()
                    cp = Dr.GetDecimal("count_num")
                    scp = CDec(cp) + 1

                    'update count_num product
                    strSQL = "UPDATE product SET count_num='" & scp & "' WHERE code_pro='" & Me.txtPDproID.Text & "'"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                    'sum count_num
                    Me.txtPDstockbalance.Text = CDec(Me.txtPDstockbalance.Text) + 1
                    Me.lblPDsnCount2.Text = CDec(Me.lblPDsnCount2.Text) + 1
                    For sumNsn As Integer = 0 To Me.dgPDshowproduct.Rows.Count - 1
                        If Me.dgPDshowproduct.Rows(sumNsn).Cells(1).Value = Me.txtPDproID.Text Then
                            Me.dgPDshowproduct.Rows(sumNsn).Cells(4).Value = CDec(Me.dgPDshowproduct.Rows(sumNsn).Cells(4).Value) + 1
                        End If
                    Next
                    Me.txtPDAddSn.Text = ""
                Catch ex As Exception

                End Try
            End If
        Else
            If Me.txtPDAddSn.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ใส่ SN"
                MsgBox("กรุณาใส่ SerialNumber", MsgBoxStyle.Exclamation, "ตรวจสอบข้อมูล")
                Me.txtPDAddSn.Focus()
                Me.txtPDAddSn.BackColor = Color.Salmon
            Else
                For sn As Integer = 0 To Me.dgPDserial.Rows.Count - 1
                    If Me.dgPDserial.Rows(sn).Cells(0).Value = Me.txtPDAddSn.Text Then
                        Mainfrm.lblMainStatus.Text = "SN ซ้ำ"
                        MsgBox("SN ซ้ำ กรุณาตรวจสอบ", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                        Exit Sub
                    End If
                Next
                Try
                    Mainfrm.lblMainStatus.Text = "บันทึกข้อมูลลงฐานข้อมูล"
                    strSQL = "INSERT INTO product_serial(code_pro,serial_pro,date_in,name_pro)VALUES(@cp,@sp,@di,@np)"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    cmd.Parameters.AddWithValue("@cp", Me.txtPDproID.Text)
                    cmd.Parameters.AddWithValue("@sp", Me.txtPDAddSn.Text)
                    cmd.Parameters.AddWithValue("@di", Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")))
                    cmd.Parameters.AddWithValue("@np", Me.txtPDproName.Text)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                    Dim rs As Integer
                    With Me.dgPDserial
                        rs = .Rows.Count
                        .Rows.Add()
                        .Rows(rs).Cells(0).Value = Me.txtPDAddSn.Text
                        .Rows(rs).Cells(1).Value = Me.txtPDproName.Text
                        .Rows(rs).Cells(2).Value = Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN"))
                    End With
                    'sum count_num product
                    Dim cp As String
                    Dim scp As Decimal
                    strSQL = "SELECT count_num FROM product WHERE code_pro='" & Me.txtPDproID.Text & "'"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader()
                    Dr.Read()
                    cp = Dr.GetDecimal("count_num")
                    scp = CDec(cp) + 1

                    'update count_num product
                    strSQL = "UPDATE product SET count_num='" & scp & "' WHERE code_pro='" & Me.txtPDproID.Text & "'"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                    'sum count_num
                    Me.txtPDstockbalance.Text = CDec(Me.txtPDstockbalance.Text) + 1
                    Me.lblPDsnCount2.Text = CDec(Me.lblPDsnCount2.Text) + 1
                    For sumNsn As Integer = 0 To Me.dgPDshowproduct.Rows.Count - 1
                        If Me.dgPDshowproduct.Rows(sumNsn).Cells(1).Value = Me.txtPDproID.Text Then
                            Me.dgPDshowproduct.Rows(sumNsn).Cells(4).Value = CDec(Me.dgPDshowproduct.Rows(sumNsn).Cells(4).Value) + 1
                        End If
                    Next
                    Me.txtPDAddSn.Text = ""
                Catch ex As Exception

                End Try
            End If
        End If
    End Sub
    Private Sub btnPDSerialSave_Click(sender As Object, e As EventArgs) Handles btnPDSerialSave.Click
        Call addSN()
    End Sub

    Private Sub txtPDserialNumber_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPDAddSn.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call addSN()
        End If
    End Sub

    Private Sub btnPDproClear_Click(sender As Object, e As EventArgs) Handles btnPDproClear.Click
        If Me.btnPDproEdit.Text = "บันทึก" Or Me.btnPDproAdd.Text = "บันทึก" Then
            MsgBox("คุณได้ทำการแก้ไขข้อมูล โปรดทำการบันทึกก่อน", MsgBoxStyle.Exclamation, "การแก้ไขข้อมูล")
        Else
            Call RestatrForm()
        End If
    End Sub
    Private Sub Data_History_Bus_Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Mainfrm.lblMainStatus.Text = "ปิดหน้าต่าง"
        If Me.btnPDproEdit.Text = "บันทึก" Or Me.btnPDproAdd.Text = "บันทึก" Then
            If MessageBox.Show("คุณได้ทำการแก้ไขข้อมูล กด No ถ้าต้องการกลับไปบันทึกข้อมูล หรือ กด Yes เพื่อออกจากหน้านี้", "การแก้ไขข้อมูล", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                e.Cancel = False
                Mainfrm.lblMainStatus.Text = "ออกจากหน้าต่าง"
            Else
                e.Cancel = True
                Mainfrm.lblMainStatus.Text = "ยกเลิกการปิดหน้าต่าง"
            End If
        End If
    End Sub

    Private Sub btnPDserialDel_Click(sender As Object, e As EventArgs) Handles btnPDserialDel.Click
        Call DeleteData_serialNumber()
    End Sub

    Private Sub cbbPDproSection_Click(sender As Object, e As EventArgs) Handles cbbPDproSection.Click
        Call getdatacombobox_product_section()
    End Sub
   
    Private Sub cbbPDproSection1_Click(sender As Object, e As EventArgs) Handles cbbPDproSection1.Click
        Call getdatacombobox_product_section1()
    End Sub

    Private Sub cbbPDsalefor_Click(sender As Object, e As EventArgs) Handles cbbPDsalefor.Click
        Call getdatacombobox_sale_company()
    End Sub

    Private Sub txtPDbarcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPDbarcode.KeyPress
        ' Mainfrm.lblMainStatus.Text = "ตรวจสอบตัวอักษร"
        'Select Case Asc(e.KeyChar)
        '     Case 48 To 122 ' โค๊ดภาษาอังกฤษ์ตามจริงจะอยู่ที่ 58ถึง122 แต่ที่เอา 48มาเพราะเราต้องการตัวเลข
        '         e.Handled = False
        '     Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
        '         e.Handled = False
        '     Case Else
        '         e.Handled = True
        '         Mainfrm.lblMainStatus.Text = "ตรวจสอบตัวอักษรผิดพลาดตามเงื่อนไข"
        '         MsgBox("ตัวอักษรภาษาอังกฤษและตัวเลขเท่านั้น", MsgBoxStyle.Exclamation, "แจ้งเตือน")
        ' End Select
        ' Mainfrm.lblMainStatus.Text = "ตรวจสอบตัวอักษรแล้ว"
    End Sub

    Private Sub txtPDserialNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPDAddSn.KeyPress
        'Mainfrm.lblMainStatus.Text = "ตรวจสอบตัวอักษร"
        'Select Case Asc(e.KeyChar)
        '    Case 48 To 122 ' โค๊ดภาษาอังกฤษ์ตามจริงจะอยู่ที่ 58ถึง122 แต่ที่เอา 48มาเพราะเราต้องการตัวเลข
        '        e.Handled = False
        '    Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
        '        e.Handled = False
        '    Case Else
        '        e.Handled = True
        '        Mainfrm.lblMainStatus.Text = "ตรวจสอบตัวอักษรผิดพลาดตามเงื่อนไข"
        '        MsgBox("ตัวอักษรภาษาอังกฤษและตัวเลขเท่านั้น", MsgBoxStyle.Exclamation, "แจ้งเตือน")
        'End Select
        'Mainfrm.lblMainStatus.Text = "ตรวจสอบตัวอักษรแล้ว"
    End Sub

    Private Sub btnPDselectImage_Click(sender As Object, e As EventArgs) Handles btnPDselectImage.Click
        Mainfrm.lblMainStatus.Text = "เลือกรูป"

        If btnPDproAdd.Text = "บันทึก" Then
            'ofdPDselectImage.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
            Mainfrm.lblMainStatus.Text = "บันทึกรูปลงฐานข้อมูลชั่วคราวแล้ว"

            ofdPDselectImage.Filter = "Picture File|*.jpg;*.jpeg;*.bmp;*.png"
            If ofdPDselectImage.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofdPDselectImage.FileName <> "" Then

                Mainfrm.lblMainStatus.Text = "บันทึกรูป"
                strSQL = "INSERT INTO product_cache(code_pro,picture)VALUES(@cp,@pic)"
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Using picture As Image = Image.FromFile(ofdPDselectImage.FileName)
                        Using stream As New IO.MemoryStream
                            picture.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
                            Dim arrImage() As Byte = stream.GetBuffer()
                            cmd.Parameters.AddWithValue("@cp", Me.txtPDproID.Text)
                            cmd.Parameters.AddWithValue("@pic", arrImage)
                        End Using
                    End Using
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End Using
                Mainfrm.lblMainStatus.Text = "บันทึกรูปลงฐานข้อมูลชั่วคราวแล้ว"
                Call openImages()
            End If

        ElseIf Me.btnPDproEdit.Text = "บันทึก" Then
            'ofdPDselectImage.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
            ofdPDselectImage.Filter = "Picture File|*.jpg;*.jpeg;*.bmp;*.png"
            If ofdPDselectImage.ShowDialog = Windows.Forms.DialogResult.OK AndAlso ofdPDselectImage.FileName <> "" Then

                Mainfrm.lblMainStatus.Text = "บันทึกรูป"
                strSQL = "UPDATE product SET picture=@pic WHERE code_pro='" & Me.txtPDproID.Text & "'"
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Using picture As Image = Image.FromFile(ofdPDselectImage.FileName)
                        Using stream As New IO.MemoryStream
                            picture.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
                            Dim arrImage() As Byte = stream.GetBuffer()
                            cmd.Parameters.AddWithValue("@pic", arrImage)
                        End Using
                    End Using
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End Using
                Mainfrm.lblMainStatus.Text = "บันทึกรูปแล้ว"
                Call openImages()
            End If
        End If
       
    End Sub

    Private Sub PictureBoxProduct_Click(sender As Object, e As EventArgs) Handles PictureBoxProduct.Click
        If A1 = "4528" Then
            Mainfrm.lblMainStatus.Text = "ขยายรูป"
            ZoomImgFrm.Show()
        Else
        End If
    End Sub

    Private Sub txtPDsearch_Click(sender As Object, e As EventArgs) Handles txtPDsearch.Click
        Me.txtPDsearch.Clear()
        Me.txtPDsearch.ForeColor = Color.Black
    End Sub

    Private Sub txtPDsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPDsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            If String.IsNullOrEmpty(Me.txtPDsearch.Text) Then
                Mainfrm.lblMainStatus.Text = "ใส่อักษรตั้งแต่ 1 ตัว เพื่อค้นหา"
            Else
                selectSQL = 100
                Call getdata()
                Me.txtPDsearch.Clear()
            End If
        End If
    End Sub

    Private Sub cbbPDproSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbPDproSection.SelectedIndexChanged
        selectSQL = 300
        Call getdata()
    End Sub

    Private Sub btnPDproductEmply_Click(sender As Object, e As EventArgs) Handles btnPDproductEmply.Click
        selectSQL = 400
        Call getdata()
    End Sub

    Private Sub btnPDproUpdate_Click(sender As Object, e As EventArgs) Handles btnPDproUpdate.Click
        selectSQL = 500
        Call getdata()
    End Sub

    Private Sub cbPDvaruntee_Click(sender As Object, e As EventArgs) Handles cbPDvaruntee.Click
        Try
            Mainfrm.lblMainStatus.Text = "โหลด varuntee"
            Me.cbPDvaruntee.Items.Clear()
            strSQL = "SELECT varuntee_status FROM varuntee ORDER BY ID ASC"
            cmd = New MySqlCommand
            cmd.CommandText = strSQL
            cmd.Connection = ConnectionDB
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.cbPDvaruntee.Items.Add(Dr("varuntee_status"))
            End While
            Dr.Close()
            Mainfrm.lblMainStatus.Text = "โหลด varuntee แล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub btnPDbp_Click(sender As Object, e As EventArgs) Handles btnPDbp.Click
        Me.txtPDp_wholsale.Text = Me.txtDprobuy.Text
        Me.txtPDp_technician.Text = Me.txtDprobuy.Text
        Me.txtPDp_loyel.Text = Me.txtDprobuy.Text
        Me.txtPDp_member.Text = Me.txtDprobuy.Text
    End Sub

End Class