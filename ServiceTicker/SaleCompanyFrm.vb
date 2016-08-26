Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class SaleCompanyFrm
   
    Private Sub AutoNumberNo()
        Try
            Mainfrm.lblMainStatus.Text = "SELECT Max(ID) as ID"
            strSQL = "SELECT Max(ID) as ID FROM sale_company_id"
            dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                Me.txtSCid.Text = "00001"
            Else
                Dim newID As Integer = CInt(Dr.Item("id"))
                newID += 1
                Me.txtSCid.Text = newID.ToString("00000")
            End If
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Dim strSQLget As Integer
    Private Sub getDataSale_Company()
        Try
            Me.dgSC.Rows.Clear()
            If strSQLget = 100 Then
                strSQL = "SELECT sale_company_id,sale_company_name,sale_company_address," & _
                    "sale_company_tel,sale_company_fax,sale_company_contact,sale_company_line," & _
                    "sale_company_email,sale_company_facebook,sale_company_website,sale_company_tax FROM sale_company WHERE sale_company_id"
            ElseIf strSQLget = 200 Then
                strSQL = "SELECT sale_company_id,sale_company_name,sale_company_address," & _
                    "sale_company_tel,sale_company_fax,sale_company_contact,sale_company_line," & _
                    "sale_company_email,sale_company_facebook,sale_company_website,sale_company_tax " & _
                    "FROM sale_company WHERE 1=1 AND sale_company_name LIKE '%" & Me.txtSCsearch.Text & "%'"
            End If
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Dim tt As Integer
                With Me.dgSC
                    tt = .Rows.Count
                    .Rows.Add()
                    .Rows(tt).Cells(0).Value = Dr.GetString("sale_company_id")
                    .Rows(tt).Cells(1).Value = Dr.GetString("sale_company_name")
                    .Rows(tt).Cells(2).Value = Dr.GetString("sale_company_address")
                    .Rows(tt).Cells(3).Value = Dr.GetString("sale_company_tel")
                    .Rows(tt).Cells(4).Value = Dr.GetString("sale_company_contact")
                    .Rows(tt).Cells(5).Value = Dr.GetString("sale_company_fax")
                    .Rows(tt).Cells(6).Value = Dr.GetString("sale_company_line")
                    .Rows(tt).Cells(7).Value = Dr.GetString("sale_company_email")
                    .Rows(tt).Cells(8).Value = Dr.GetString("sale_company_facebook")
                    .Rows(tt).Cells(9).Value = Dr.GetString("sale_company_website")
                    .Rows(tt).Cells(10).Value = Dr.GetString("sale_company_tax")
                End With
            End While
            strSQLget = Nothing
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub DeleteData()
        Try
        Dim Ans As String
        Ans = MsgBox("คุณแน่ในว่าจะลบข้อมูลนี้", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
        If Ans = System.Windows.Forms.DialogResult.No Then
            MsgBox("การลบข้อมูลถูกยกเลิก", MsgBoxStyle.Information, "ยืนยัน")
            Me.dgSC.ClearSelection()
            'clear all textbox
            For Each ctl In Controls
                If TypeOf ctl Is TextBox Then ctl.Text = ""
            Next ctl
            Exit Sub
            Else
                strSQL = "DELETE FROM sale_company WHERE sale_company_id='" & Me.txtSCid.Text & "';"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                MsgBox("ลบข้อมูลที่คุณเลือกแล้ว", MsgBoxStyle.Information, "ยืนยัน")
                Me.dgSC.ClearSelection()
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Call startfrm()
    End Sub
    Private Sub startfrm()
        Me.dgSC.Refresh()
        Me.dgSC.ClearSelection()
        strSQLget = 100
        Call getDataSale_Company()
        Call ClearTextBoxes(Me)
        Me.dgSC.Enabled = True
        Me.txtSCid.Enabled = False
        Me.txtSCname.Enabled = False
        Me.txtSCaddress.Enabled = False
        Me.txtSCtel.Enabled = False
        Me.txtSCcontact.Enabled = False
        Me.txtSCfax.Enabled = False
        Me.txtSCline.Enabled = False
        Me.txtSCemail.Enabled = False
        Me.txtSCfacebook.Enabled = False
        Me.txtSCwebsite.Enabled = False
        Me.txtSCtax.Enabled = False
        Me.btnSCedit.Enabled = False
        Me.btnSCadd.Enabled = True
        Me.btnSCdel.Enabled = False
        Me.btnSCadd.Text = "เพิ่ม"
    End Sub
    Private Sub dgSC_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgSC.MouseDoubleClick
        Try
            Me.txtSCid.Text = Me.dgSC.SelectedCells(0).Value
            Me.txtSCname.Text = Me.dgSC.SelectedCells(1).Value
            Me.txtSCaddress.Text = Me.dgSC.SelectedCells(2).Value
            Me.txtSCtel.Text = Me.dgSC.SelectedCells(3).Value
            Me.txtSCcontact.Text = Me.dgSC.SelectedCells(4).Value
            Me.txtSCfax.Text = Me.dgSC.SelectedCells(5).Value
            Me.txtSCline.Text = Me.dgSC.SelectedCells(6).Value
            Me.txtSCemail.Text = Me.dgSC.SelectedCells(7).Value
            Me.txtSCfacebook.Text = Me.dgSC.SelectedCells(8).Value
            Me.txtSCwebsite.Text = Me.dgSC.SelectedCells(9).Value
            Me.txtSCtax.Text = Me.dgSC.SelectedCells(10).Value
            Me.btnSCadd.Enabled = False
            Me.btnSCedit.Enabled = True
            Me.btnSCdel.Enabled = True
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SaleCompanyfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call startfrm()
        Me.Icon = Mainfrm.Icon
    End Sub
    Private Sub btnSCdel_Click(sender As Object, e As EventArgs) Handles btnSCdel.Click
        Call DeleteData()
    End Sub
    Private Sub btnSCadd_Click(sender As Object, e As EventArgs) Handles btnSCadd.Click
        If Me.btnSCadd.Text = "เพิ่ม" Then
            Me.btnSCadd.Text = "บันทึก"
            Call AutoNumberNo()
            Me.btnSCdel.Enabled = False
            Me.btnSCedit.Enabled = False
            Call enableTextBoxes(Me)
            Me.txtSCid.Enabled = False
            Me.dgSC.Enabled = False
            Exit Sub
        ElseIf Me.btnSCadd.Text = "บันทึก" Then
            If Me.txtSCname.Text = "" Then
                MsgBox("กรุณาใส่ชื่อ", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
                Me.txtSCname.Focus()
                Me.txtSCname.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtSCaddress.Text = "" Then
                MsgBox("กรุณาใส่ที่อยู่ หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
                Me.txtSCaddress.Focus()
                Me.txtSCaddress.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtSCcontact.Text = "" Then
                MsgBox("กรุณาใส่ผู้ติดต่อ หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
                Me.txtSCcontact.Focus()
                Me.txtSCcontact.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtSCtel.Text = "" Then
                MsgBox("กรุณาใส่เบอร์โทร หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
                Me.txtSCtel.Focus()
                Me.txtSCtel.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtSCfax.Text = "" Then
                MsgBox("กรุณาใส่เบอร์แฟกซ์ หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
                Me.txtSCfax.Focus()
                Me.txtSCfax.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtSCline.Text = "" Then
                MsgBox("กรุณาใส่ Line หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
                Me.txtSCline.Focus()
                Me.txtSCline.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtSCfacebook.Text = "" Then
                MsgBox("กรุณาใส่ FaceBook หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
                Me.txtSCfacebook.Focus()
                Me.txtSCfacebook.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtSCemail.Text = "" Then
                MsgBox("กรุณาใส่ Email หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
                Me.txtSCemail.Focus()
                Me.txtSCemail.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtSCwebsite.Text = "" Then
                MsgBox("กรุณาใส่ WebSite หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
                Me.txtSCwebsite.Focus()
                Me.txtSCwebsite.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtSCtax.Text = "" Then
                MsgBox("กรุณาใส่หมายเลขผู้เสียภาษี หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
                Me.txtSCtax.Focus()
                Me.txtSCtax.BackColor = Color.Salmon
                Exit Sub
            End If
            Dim Ans As String
            Ans = MsgBox("คุณแน่ในว่าจะเพิ่มข้อมูลนี้", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
            If Ans = System.Windows.Forms.DialogResult.No Then
                MsgBox("การเพิ่มข้อมูลถูกยกเลิก", MsgBoxStyle.Information, "ยืนยัน")
                Call startfrm()
                Exit Sub
            Else
                Try
                    Mainfrm.lblMainStatus.Text = "INSERT INTO sale_company "
                    strSQL = "INSERT INTO sale_company(sale_company_id,sale_company_name,sale_company_address," _
                        & "sale_company_tel,sale_company_fax,sale_company_contact,sale_company_line,sale_company_email," _
                        & "sale_company_facebook,sale_company_website,sale_company_tax)VALUES" _
                        & "(@sale_company_id,@sale_company_name,@sale_company_address," _
                        & "@sale_company_tel,@sale_company_fax,@sale_company_contact,@sale_company_line,@sale_company_email," _
                        & "@sale_company_facebook,@sale_company_website,@sale_company_tax)"
                    Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                        cmd.Parameters.AddWithValue("@sale_company_id", Me.txtSCid.Text)
                        cmd.Parameters.AddWithValue("@sale_company_name", Me.txtSCname.Text)
                        cmd.Parameters.AddWithValue("@sale_company_address", Me.txtSCaddress.Text)
                        cmd.Parameters.AddWithValue("@sale_company_tel", Me.txtSCtel.Text)
                        cmd.Parameters.AddWithValue("@sale_company_fax", Me.txtSCfax.Text)
                        cmd.Parameters.AddWithValue("@sale_company_contact", Me.txtSCcontact.Text)
                        cmd.Parameters.AddWithValue("@sale_company_line", Me.txtSCline.Text)
                        cmd.Parameters.AddWithValue("@sale_company_email", Me.txtSCemail.Text)
                        cmd.Parameters.AddWithValue("@sale_company_facebook", Me.txtSCfacebook.Text)
                        cmd.Parameters.AddWithValue("@sale_company_website", Me.txtSCwebsite.Text)
                        cmd.Parameters.AddWithValue("@sale_company_tax", Me.txtSCtax.Text)
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    End Using
                    Mainfrm.lblMainStatus.Text = "INSERT INTO sale_company_id "
                    strSQL = "INSERT INTO sale_company_id(sale_company_name,sale_company_id,datetime_save)" _
                            & "values(@sale_company_name,@sale_company_id,@datetime_save)"
                    Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                        cmd.Parameters.AddWithValue("@sale_company_name", Me.txtSCname.Text)
                        cmd.Parameters.AddWithValue("@sale_company_id", Me.txtSCid.Text)
                        cmd.Parameters.AddWithValue("@datetime_save", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")))
                        Call open_connection()
                        cmd.ExecuteNonQuery()
                    End Using
                    MsgBox("บันทึกข้อมูลแล้ว", MsgBoxStyle.Information, "บันทึกข้อมูล")
                Catch ex As Exception
                    Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                End Try
            End If
            Me.btnSCadd.Text = "เพิ่ม"
        End If
        Call ClearTextBoxes(Me)
        Me.dgSC.ClearSelection()
        Call startfrm()
    End Sub
    Private Sub btnSCedit_Click(sender As Object, e As EventArgs) Handles btnSCedit.Click
        If Me.btnSCedit.Text = "แก้ไข" Then
            Me.btnSCedit.Text = "บันทึก"
            Me.btnSCdel.Enabled = False
            Me.btnSCadd.Enabled = False
            Call enableTextBoxes(Me)
            Me.txtSCid.Enabled = False
            Me.dgSC.Enabled = False
            Exit Sub
        ElseIf Me.btnSCedit.Text = "บันทึก" Then
            If Me.txtSCname.Text = "" Then
                MsgBox("กรุณาใส่ชื่อ", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
                Me.txtSCname.Focus()
                Me.txtSCname.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtSCaddress.Text = "" Then
                MsgBox("กรุณาใส่ที่อยู่ หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
                Me.txtSCaddress.Focus()
                Me.txtSCaddress.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtSCcontact.Text = "" Then
                MsgBox("กรุณาใส่ผู้ติดต่อ หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
                Me.txtSCcontact.Focus()
                Me.txtSCcontact.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtSCtel.Text = "" Then
                MsgBox("กรุณาใส่เบอร์โทร หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
                Me.txtSCtel.Focus()
                Me.txtSCtel.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtSCfax.Text = "" Then
                MsgBox("กรุณาใส่เบอร์แฟกซ์ หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
                Me.txtSCfax.Focus()
                Me.txtSCfax.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtSCline.Text = "" Then
                MsgBox("กรุณาใส่ Line หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
                Me.txtSCline.Focus()
                Me.txtSCline.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtSCfacebook.Text = "" Then
                MsgBox("กรุณาใส่ FaceBook หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
                Me.txtSCfacebook.Focus()
                Me.txtSCfacebook.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtSCemail.Text = "" Then
                MsgBox("กรุณาใส่ Email หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
                Me.txtSCemail.Focus()
                Me.txtSCemail.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtSCwebsite.Text = "" Then
                MsgBox("กรุณาใส่ WebSite หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
                Me.txtSCwebsite.Focus()
                Me.txtSCwebsite.BackColor = Color.Salmon
                Exit Sub
            End If
            If Me.txtSCtax.Text = "" Then
                MsgBox("กรุณาใส่หมายเลขผู้เสียภาษี หากไม่มีให้ -", MsgBoxStyle.Exclamation, "ข้อมูลลูกค้า")
                Me.txtSCtax.Focus()
                Me.txtSCtax.BackColor = Color.Salmon
                Exit Sub
            End If
            Dim UpDateAns As String
            UpDateAns = MsgBox("คุณแน่ใจว่าจะแก้ไขข้อมูลนี้", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
            If UpDateAns = System.Windows.Forms.DialogResult.No Then
                MsgBox("การแก้ไขข้อมูลถูกยกเลิก.", MsgBoxStyle.Information, "ยกเลิกการแก้ไข")
            Else
                Try
                    Mainfrm.lblMainStatus.Text = "update sale_company "
                    strSQL = "update sale_company set sale_company_id='" & Me.txtSCid.Text & "'," _
                         & "sale_company_name='" & Me.txtSCname.Text & "'," _
                         & "sale_company_address='" & Me.txtSCaddress.Text & "'," _
                         & "sale_company_tel='" & Me.txtSCtel.Text & "'," _
                         & "sale_company_contact='" & Me.txtSCcontact.Text & "'," _
                         & "sale_company_fax='" & Me.txtSCfax.Text & "'," _
                         & "sale_company_line='" & Me.txtSCline.Text & "'," _
                         & "sale_company_email='" & Me.txtSCemail.Text & "'," _
                         & "sale_company_facebook='" & Me.txtSCfacebook.Text & "'," _
                         & "sale_company_website='" & Me.txtSCwebsite.Text & "'," _
                         & "sale_company_tax='" & Me.txtSCtax.Text & "'" _
                         & "where sale_company_id='" & Me.txtSCid.Text & "'"
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                    MsgBox("แก้ไขข้อมูลเรียบร้อยแล้ว.", MsgBoxStyle.Information, "ยืนยัน")
                Catch ex As Exception
                    Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                End Try
                Me.btnSCedit.Text = "แก้ไข"
                Me.dgSC.ClearSelection()
            End If
            Me.btnSCedit.Text = "แก้ไข"
          
        End If
      
        Call ClearTextBoxes(Me)
        Me.dgSC.ClearSelection()
        Call startfrm()
    End Sub
    Private Sub btnSCsearch_Click(sender As Object, e As EventArgs) Handles btnSCsearch.Click
        strSQLget = 200
        Call getDataSale_Company()
        Me.txtSCsearch.Clear()
    End Sub
    Private Sub btnSCgetallData_Click(sender As Object, e As EventArgs) Handles btnSCgetallData.Click
        strSQLget = 100
        Call getDataSale_Company()
    End Sub

    Private Sub txtSCsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSCsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            strSQLget = 200
            Call getDataSale_Company()
            Me.txtSCsearch.Clear()
        End If
    End Sub
End Class