Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class SNFrm
   
    Private Sub AutoNumberNo()
        Try
            strSQL = "SELECT Max(id) as ID FROM sn_id"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                Me.txtSNNumber.Text = Now.ToString("yyMMdd", CultureInfo.CreateSpecificCulture("en-EN")) & "0001"
            Else
                Dim newID As Integer = CInt(Dr.Item("ID"))
                newID += 1
                Me.txtSNNumber.Text = Now.ToString("yyMMdd", CultureInfo.CreateSpecificCulture("en-EN")) & newID.ToString("0000")
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub druSN()
        Try
            strSQL = "SELECT Snum FROM sn WHERE Snum='" & Me.txtSNNumber.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            If Dr.HasRows Then
                Me.lblSNcCN.Text = "มี SN นี้ในระบบแล้ว ไม่สามารถบันทึก SN ซ้ำในระบบได้"
            Else
                Me.lblSNcCN.Text = "ไม่มี SN นี้ในระบบ บันทึก SN ใหม่ได้"
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GetAllData()
        Try
            Me.dgSN.Rows.Clear()
            strSQL = "SELECT Snum,p_type,p_name,model,color,startdate FROM sn"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dim r As Integer
                While (Dr.Read())
                    With Me.dgSN
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells("Snum").Value = Dr.Item("Snum")
                        .Rows(r).Cells("p_type").Value = Dr.Item("p_type")
                        .Rows(r).Cells("p_name").Value = Dr.Item("p_name")
                        .Rows(r).Cells("model").Value = Dr.Item("model")
                        .Rows(r).Cells("color").Value = Dr.Item("color")
                        .Rows(r).Cells("startdate").Value = Dr.Item("startdate")
                    End With
                End While
            End Using
            For sum As Integer = 0 To Me.dgSN.Rows.Count - 1
                Me.dgSN.Rows(sum).Cells(0).Value = sum + 1
            Next
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub getdatecombbox_typeSN()
        Try
            Me.cbbP_Type.Items.Clear()
            Mainfrm.lblMainStatus.Text = "กำลังโหลดข้อมูล type"
            strSQL = "SELECT p_type FROM product_type ORDER BY p_type ASC"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.cbbP_Type.Items.Add(Dr.GetString("p_type"))
            End While
            Dr.Close()
            Mainfrm.lblMainStatus.Text = "โหลดข้อมูล type แล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub getdatecombbox_nameSN()
        Try
            Me.cbbP_Name.Items.Clear()
            Mainfrm.lblMainStatus.Text = "กำลังโหลดข้อมูลยี่ห้อ"
            strSQL = "SELECT p_name FROM product_name ORDER BY p_name ASC"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.cbbP_Name.Items.Add(Dr.GetString("p_name"))
            End While
            Dr.Close()
            Mainfrm.lblMainStatus.Text = "โหลดข้อมูลยี่ห้อแล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub getdatecombbox_modelSN()
        Try
            Me.cbbP_model.Items.Clear()
            Mainfrm.lblMainStatus.Text = "กำลังโหลดข้อมูลยี่ห้อ"
            strSQL = "SELECT p_model FROM product_model WHERE p_name='" & Me.cbbP_Name.Text & "' ORDER BY p_model ASC"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.cbbP_model.Items.Add(Dr.GetString("p_model"))
            End While
            Dr.Close()
            Mainfrm.lblMainStatus.Text = "โหลดข้อมูลยี่ห้อแล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub getdatecombbox_colorSN()
        Try
            Me.cbbP_color.Items.Clear()
            Mainfrm.lblMainStatus.Text = "กำลังโหลดข้อมูลสี"
            strSQL = "SELECT color FROM product_color ORDER BY color ASC"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Me.cbbP_color.Items.Add(Dr.GetString("color"))
            End While
            Dr.Close()
            Mainfrm.lblMainStatus.Text = "โหลดข้อมูลสีแล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub editdata()
        Try
            Dim UpDateAns As String
            UpDateAns = MsgBox("คุณแน่ใจว่าจะแก้ไขข้อมูลนี้", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
            If UpDateAns = System.Windows.Forms.DialogResult.No Then
                MsgBox("การแก้ไขข้อมูลถูกยกเลิก.", MsgBoxStyle.Information, "ยกเลิกการแก้ไข")
            Else
                strSQL = "UPDATE sn SET Snum='" & Me.txtSNNumber.Text & "', p_type='" & Me.cbbP_Type.Text & "', p_name='" & Me.cbbP_Name.Text & "', model='" & Me.cbbP_model.Text & "', color='" & Me.cbbP_color.Text & "' WHERE Snum='" & Me.dgSN.SelectedCells(1).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()

                strSQL = "SELECT p_name,p_model FROM product_model WHERE p_name='" & Me.cbbP_Name.Text & "' AND p_model='" & Me.cbbP_model.Text & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                If Dr.HasRows Then
                Else
                    strSQL = "INSERT INTO product_model (p_name,p_model)VALUES" _
                        & "(@p_name,@p_model)"
                    Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                        cmd.Parameters.AddWithValue("@p_name", Me.cbbP_Name.Text)
                        cmd.Parameters.AddWithValue("@p_model", Me.cbbP_model.Text)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    End Using
                End If

                MsgBox("แก้ไขข้อมูลเรียบร้อยแล้ว.", MsgBoxStyle.Information, "ยืนยัน")
                Me.btnSNEdit.Text = "&แก้ไข"
                Call GetAllData()
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub DeleteData()
        Dim Ans As String
        Ans = MsgBox("คุณแน่ในว่าจะลบข้อมูลนี้", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
        If Ans = System.Windows.Forms.DialogResult.No Then
            MsgBox("การลบข้อมูลถูกยกเลิก", MsgBoxStyle.Information, "ยืนยัน")
            Me.dgSN.ClearSelection()
            Call ClearTextBoxes(Me)
        Else
            strSQL = "DELETE FROM SN WHERE Snum='" & Me.txtSNNumber.Text & "';"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            MsgBox("ลบข้อมูลที่คุณเลือกแล้ว", MsgBoxStyle.Information, "ยืนยัน")
            Me.dgSN.ClearSelection()
            Call ClearTextBoxes(Me)
        End If
    End Sub
    Private Sub startfrm()
        Call disableTextBoxes(Me)
        Me.dgSN.Enabled = True
        Me.txtSNSearch.Enabled = True
        Me.btnSNDel.Enabled = False
        Me.btnSNEdit.Enabled = False
        Me.btnSNAdd.Enabled = True
        Me.cbbP_Type.Enabled = False
        Me.cbbP_Name.Enabled = False
        Me.cbbP_model.Enabled = False
        Me.cbbP_color.Enabled = False
        Me.btnSNAdd.Text = "&เพิ่ม"
        Me.btnSNEdit.Text = "&แก้ไข"
        Me.btnSNCancel.Text = "&ปิด"
        Me.cbbP_Type.Items.Clear()
        Me.cbbP_Name.Items.Clear()
        Me.cbbP_model.Items.Clear()
        Me.cbbP_color.Items.Clear()
        Me.cbSNautoSN.Enabled = False
        If Me.cbSNautoSN.CheckState = CheckState.Checked Then
            Me.cbSNautoSN.CheckState = CheckState.Unchecked
        End If
        Call ClearTextBoxes(Me)
    End Sub

    Private Sub search_record()
        Try
            Me.dgSN.Rows.Clear()
            Dim strKeyWord As String = Me.txtSNSearch.Text
            strSQL = "SELECT Snum,p_type,p_name,model,color,startdate from sn where "
            If strKeyWord <> "" Then
                strSQL = strSQL & "Snum like '%" & strKeyWord & "%' or p_type like '%" & strKeyWord & "%' or p_name like '%" & strKeyWord & "%' or model like '%" & strKeyWord & "%' or color like '%" & strKeyWord & "%'"
                Mainfrm.lblMainStatus.Text = strSQL
            End If
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dim r As Integer
                While (Dr.Read())
                    With Me.dgSN
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells("Snum").Value = Dr.Item("Snum")
                        .Rows(r).Cells("p_type").Value = Dr.Item("p_type")
                        .Rows(r).Cells("p_name").Value = Dr.Item("p_name")
                        .Rows(r).Cells("model").Value = Dr.Item("model")
                        .Rows(r).Cells("color").Value = Dr.Item("color")
                        .Rows(r).Cells("startdate").Value = Dr.Item("startdate")
                    End With
                End While
            End Using
            Me.txtSNSearch.Text = ""
            For sum As Integer = 0 To Me.dgSN.Rows.Count - 1
                Me.dgSN.Rows(sum).Cells(0).Value = sum + 1
            Next
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub btnSNGetdataall_Click(sender As Object, e As EventArgs) Handles btnSNGetdataall.Click
        Call GetAllData()
    End Sub

    Private Sub SNfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call startfrm()
        Me.Icon = Mainfrm.Icon
        If Mainfrm.snC = 1 Then
            Me.btnSNSendToSDF.Visible = False
        Else
            Me.btnSNSendToSDF.Visible = True
        End If
        Mainfrm.snC = Nothing
    End Sub

    Private Sub btnSNAdd_Click(sender As Object, e As EventArgs) Handles btnSNAdd.Click
        If Me.btnSNAdd.Text = "&เพิ่ม" Then
            Me.txtSNNumber.Enabled = True
            Me.cbbP_Type.Enabled = True
            Me.cbbP_Name.Enabled = True
            Me.cbbP_model.Enabled = True
            Me.cbbP_color.Enabled = True
            Me.cbSNautoSN.Enabled = True
            Me.btnSNAdd.Text = "&บันทึก"
            Me.btnSNCancel.Text = "&ยกเลิก"
            Me.btnSNDel.Enabled = False
            Me.btnSNEdit.Enabled = False
            Me.dgSN.Enabled = False
            Exit Sub
        ElseIf Me.btnSNAdd.Text = "&บันทึก" Then
            If Me.txtSNNumber.Text = "" Then
                MsgBox("กรุณาใส่ SN ถ้าไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมููล SN")
                Timer1.Start()
                Me.txtSNNumber.Focus()
                Me.txtSNNumber.BackColor = Drawing.Color.OrangeRed
            ElseIf Me.cbbP_Type.Text = "" Then
                MsgBox("กรุณาเลือกประเภทสินค้า ถ้าไม่มีให้ไปเพิ่มใหม่ในหน้าตั้งค่า", MsgBoxStyle.Exclamation, "ข้อมููล SN")
                Timer1.Start()
                Me.cbbP_Type.Focus()
                Me.cbbP_Type.BackColor = Drawing.Color.OrangeRed
            ElseIf Me.cbbP_Name.Text = "" Then
                MsgBox("กรุณาเลือกยี่ห้อ ถ้าไม่มีให้ไปเพิ่มใหม่ในหน้าตั้งค่า", MsgBoxStyle.Exclamation, "ข้อมููล SN")
                Timer1.Start()
                Me.cbbP_Name.Focus()
                Me.cbbP_Name.BackColor = Drawing.Color.OrangeRed
            ElseIf Me.cbbP_model.Text = "" Then
                MsgBox("กรุณาใส่รุ่น ถ้าไม่รู้ให้ใส่ -", MsgBoxStyle.Exclamation, "ข้อมููล SN")
                Timer1.Start()
                Me.cbbP_model.Focus()
                Me.cbbP_model.BackColor = Drawing.Color.OrangeRed
            ElseIf Me.cbbP_color.Text = "" Then
                MsgBox("กรุณาใส่สี ถ้าไม่รู้ให้ใส่ -", MsgBoxStyle.Exclamation, "ข้อมููล SN")
                Timer1.Start()
                Me.cbbP_color.Focus()
                Me.cbbP_color.BackColor = Drawing.Color.OrangeRed
            Else
                Try
                    strSQL = "select Snum from sn where Snum='" & Me.txtSNNumber.Text & "'"
                    Mainfrm.lblMainStatus.Text = strSQL
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader
                    Dr.Read()
                    If Not Dr.HasRows Then
                        Dim Ans As String
                        Ans = MsgBox("คุณแน่ในว่าจะเพิ่มข้อมูลนี้", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
                        If Ans = System.Windows.Forms.DialogResult.No Then
                            MsgBox("การเพิ่มข้อมูลถูกยกเลิก", MsgBoxStyle.Information, "ยืนยัน")
                            Me.dgSN.ClearSelection()
                            Exit Sub
                        Else
                            Call savedatasn()
                        End If
                    ElseIf Dr.HasRows Then
                        If Me.txtSNNumber.Text = "-" Then
                            Call savedatasn()
                        Else
                            MsgBox("SN ซ้ำกับเครื่องอื่น โปรดตรวจสอบ", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                            Exit Sub
                        End If
                    End If
                    Me.btnSNAdd.Text = "&เพิ่ม"
                    Call startfrm()
                Catch ex As Exception
                    Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                End Try
            End If
        End If
    End Sub
    Private Sub savedatasn()
        Try
            strSQL = "INSERT INTO sn (Snum,p_type,p_name,model,color,startdate)VALUES('" & Me.txtSNNumber.Text & "','" & Me.cbbP_Type.Text & "','" & Me.cbbP_Name.Text & "','" & Me.cbbP_model.Text & "','" & Me.cbbP_color.Text & "', Now());"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            If Me.cbSNautoSN.Checked Then
                strSQL = "INSERT INTO sn_id (sn_id)VALUES('" & Me.txtSNNumber.Text & "');"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
            End If


            strSQL = "SELECT p_name,p_model FROM product_model WHERE p_name='" & Me.cbbP_Name.Text & "' AND p_model='" & Me.cbbP_model.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            If Dr.HasRows Then
            Else
                strSQL = "INSERT INTO product_model (p_name,p_model)VALUES" _
                    & "(@p_name,@p_model)"
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    cmd.Parameters.AddWithValue("@p_name", Me.cbbP_Name.Text)
                    cmd.Parameters.AddWithValue("@p_model", Me.cbbP_model.Text)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                End Using
            End If
            MsgBox("เพิ่มข้อมูลแล้ว", MsgBoxStyle.Information, "ยืนยัน")
            Call GetAllData()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub btnSNCancel_Click(sender As Object, e As EventArgs) Handles btnSNCancel.Click
        If Me.btnSNCancel.Text = "&ปิด" Then
            Me.Close()
        ElseIf Me.btnSNCancel.Text = "&ยกเลิก" Then
            Call startfrm()
        End If

    End Sub

    Private Sub txtSNSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSNSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If Me.txtSNSearch.Text = "" Then
                MsgBox("กรุณาใส่ข้อมูล sn ประเภท ยี่ห้อ หรือรุ่น อย่างใดอย่างหนึ่งลงในช่องค้นหา", MsgBoxStyle.Exclamation, "ค้นหา")
                Timer1.Start()
                Me.txtSNSearch.Focus()
                Me.txtSNSearch.BackColor = Drawing.Color.OrangeRed
            Else
                Call search_record()
            End If
        End If
    End Sub

    Private Sub dgSN_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgSN.CellMouseClick
        Me.txtSNNumber.Text = Me.dgSN.SelectedCells(1).Value
        Me.cbbP_Type.Text = Me.dgSN.SelectedCells(2).Value
        Me.cbbP_Name.Text = Me.dgSN.SelectedCells(3).Value
        Me.cbbP_model.Text = Me.dgSN.SelectedCells(4).Value
        Me.cbbP_color.Text = Me.dgSN.SelectedCells(5).Value
        Me.btnSNAdd.Enabled = False
        Me.btnSNEdit.Enabled = True
        Me.btnSNDel.Enabled = True
        Me.btnSNCancel.Enabled = True
    End Sub
    Private Sub btnSNEdit_Click(sender As Object, e As EventArgs) Handles btnSNEdit.Click
        If Me.btnSNEdit.Text = "&แก้ไข" Then
            Me.dgSN.Enabled = False
            Me.txtSNNumber.Enabled = False
            Me.cbbP_Type.Enabled = True
            Me.cbbP_Name.Enabled = True
            Me.cbbP_model.Enabled = True
            Me.cbbP_color.Enabled = True
            Me.btnSNEdit.Text = "&บันทึก"
            Me.btnSNCancel.Text = "&ยกเลิก"
        ElseIf Me.btnSNEdit.Text = "&บันทึก" Then
            If Me.txtSNNumber.Text = "" Then
                MsgBox("กรุณาใส่ SN ถ้าไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมููล SN")
                Timer1.Start()
                Me.txtSNNumber.Focus()
                Me.txtSNNumber.BackColor = Drawing.Color.OrangeRed
            ElseIf Me.cbbP_Type.Text = "" Then
                MsgBox("กรุณาเลือกประเภทสินค้า ถ้าไม่มีให้ไปเพิ่มใหม่ในหน้าตั้งค่า", MsgBoxStyle.Exclamation, "ข้อมููล SN")
                Timer1.Start()
                Me.cbbP_Type.Focus()
                Me.cbbP_Type.BackColor = Drawing.Color.OrangeRed
            ElseIf Me.cbbP_Name.Text = "" Then
                MsgBox("กรุณาเลือกยี่ห้อ ถ้าไม่มีให้ไปเพิ่มใหม่ในหน้าตั้งค่า", MsgBoxStyle.Exclamation, "ข้อมููล SN")
                Timer1.Start()
                Me.cbbP_Name.Focus()
                Me.cbbP_Name.BackColor = Drawing.Color.OrangeRed
            ElseIf Me.cbbP_model.Text = "" Then
                MsgBox("กรุณาใส่รุ่น ถ้าไม่รู้ให้ใส่ -", MsgBoxStyle.Exclamation, "ข้อมููล SN")
                Timer1.Start()
                Me.cbbP_model.Focus()
                Me.cbbP_model.BackColor = Drawing.Color.OrangeRed
            ElseIf Me.cbbP_color.Text = "" Then
                MsgBox("กรุณาใส่สี ถ้าไม่รู้ให้ใส่ -", MsgBoxStyle.Exclamation, "ข้อมููล SN")
                Timer1.Start()
                Me.cbbP_color.Focus()
                Me.cbbP_color.BackColor = Drawing.Color.OrangeRed
            Else
                Call editdata()
                Me.btnSNEdit.Text = "&แก้ไข"
            End If
            Call ClearTextBoxes(Me)
            Call startfrm()
        End If
    End Sub

    Private Sub btnSNDel_Click(sender As Object, e As EventArgs) Handles btnSNDel.Click
        Call DeleteData()
        Call GetAllData()
        Call startfrm()
    End Sub
    Friend selectFrm As Integer
    Private Sub btnSNSendToSDF_Click(sender As Object, e As EventArgs) Handles btnSNSendToSDF.Click
        'Dim SDF As New SaveDataFixfrm
        If selectFrm = 100 Then
            SaveDataFixFrm.txtSDFfixSN.Text = Me.dgSN.SelectedCells(1).Value
            SaveDataFixFrm.cbbSDFtype.Text = Me.dgSN.SelectedCells(2).Value
            SaveDataFixFrm.cbbSDFname.Text = Me.dgSN.SelectedCells(3).Value
            SaveDataFixFrm.cbbSDFmodel.Text = Me.dgSN.SelectedCells(4).Value
            SaveDataFixFrm.cbbSDFcolor.Text = Me.dgSN.SelectedCells(5).Value
            selectFrm = Nothing
            Me.Close()
        ElseIf selectFrm = 200 Then
            SaveDataFixGroupFrm.txtSDFfixSN.Text = Me.dgSN.SelectedCells(1).Value
            SaveDataFixGroupFrm.txtSDFfixType.Text = Me.dgSN.SelectedCells(2).Value
            SaveDataFixGroupFrm.txtSDFfixPName.Text = Me.dgSN.SelectedCells(3).Value
            SaveDataFixGroupFrm.txtSDFfixModel.Text = Me.dgSN.SelectedCells(4).Value
            SaveDataFixGroupFrm.txtSDFfixcolor.Text = Me.dgSN.SelectedCells(5).Value
            selectFrm = Nothing
            Me.Close()
        End If
    End Sub

    Private Sub btnSNSearch_Click(sender As Object, e As EventArgs) Handles btnSNSearch.Click
        If Me.txtSNSearch.Text = "" Then
            MsgBox("กรุณาใส่ข้อมูล sn ประเภท ยี่ห้อ หรือรุ่น อย่างใดอย่างหนึ่งลงในช่องค้นหา", MsgBoxStyle.Exclamation, "ค้นหา")
            Timer1.Start()
            Me.txtSNSearch.Focus()
            Me.txtSNSearch.BackColor = Drawing.Color.OrangeRed
        Else
            Call search_record()
        End If
    End Sub

    Private Sub cbSNautoSN_CheckStateChanged(sender As Object, e As EventArgs) Handles cbSNautoSN.CheckStateChanged
        If Me.cbSNautoSN.Checked Then
            Call AutoNumberNo()
        Else
            Me.txtSNNumber.Text = ""
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.txtSNSearch.BackColor = Drawing.Color.LemonChiffon
        Me.txtSNNumber.BackColor = Drawing.Color.LemonChiffon
        Me.cbbP_Type.BackColor = Drawing.Color.LemonChiffon
        Me.cbbP_Name.BackColor = Drawing.Color.LemonChiffon
        Me.cbbP_model.BackColor = Drawing.Color.LemonChiffon
        Me.cbbP_color.BackColor = Drawing.Color.LemonChiffon
        Timer1.Stop()
        Timer2.Stop()
    End Sub
    Private Sub cbbP_Type_Click(sender As Object, e As EventArgs) Handles cbbP_Type.Click
        Call getdatecombbox_typeSN()
    End Sub
    Private Sub cbbP_Name_Click(sender As Object, e As EventArgs) Handles cbbP_Name.Click
        Call getdatecombbox_nameSN()
    End Sub

    Private Sub cbbP_model_Click(sender As Object, e As EventArgs) Handles cbbP_model.Click
        Call getdatecombbox_modelSN()
    End Sub

    Private Sub cbbP_color_Click(sender As Object, e As EventArgs) Handles cbbP_color.Click
        Call getdatecombbox_colorSN()
    End Sub

    Private Sub lblSNType_Click(sender As Object, e As EventArgs) Handles lblSNType.Click
        ProductFrm.MdiParent = Mainfrm
        ProductFrm.Show()
    End Sub

    Private Sub lblSNname_Click(sender As Object, e As EventArgs) Handles lblSNname.Click
        ProductNameFrm.MdiParent = Mainfrm
        ProductNameFrm.Show()
    End Sub

    Private Sub lblSNcolor_Click(sender As Object, e As EventArgs) Handles lblSNcolor.Click
        ProductColorFrm.MdiParent = Mainfrm
        ProductColorFrm.Show()
    End Sub

    Private Sub txtSNNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSNNumber.KeyPress
        Call druSN()
    End Sub
End Class