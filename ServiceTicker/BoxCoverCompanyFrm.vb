Imports MySql.Data.MySqlClient

Public Class BoxCoverCompanyFrm
  
    Private Sub startFrm()
        Me.txtCCcom_name.Enabled = False
        Me.txtCCcom_address.Enabled = False
        Me.txtCCcom_address1.Enabled = False
        Me.txtCCcom_address2.Enabled = False
        Me.txtCCcom_zipcode.Enabled = False
        Me.txtCCcom_contect.Enabled = False
        Me.txtCCcom_id.Clear()
        Me.txtCCcom_name.Clear()
        Me.txtCCcom_address.Clear()
        Me.txtCCcom_address1.Clear()
        Me.txtCCcom_address2.Clear()
        Me.txtCCcom_zipcode.Clear()
        Me.txtCCcom_contect.Clear()
        Me.btnCCadd.Enabled = True
        Me.btnCCedit.Enabled = False
        Me.btnCCdel.Enabled = False
        Me.btnCCcancel.Enabled = False
        Me.btnCCadd.Text = "เพิ่ม"
        Me.btnCCedit.Text = "แก้ไข"
        Me.dgCC.Enabled = True
        strsqlsel = 100
        Call getdata()
    End Sub
    Private Sub ClaimsCompanyFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        Call startFrm()
    End Sub
    Dim strsqlsel As String
    Private Sub getdata()
        Try
            Mainfrm.lblMainStatus.Text = "โหลดข้อมูล claims_company"
            Me.dgCC.Rows.Clear()
            If strsqlsel = 100 Then
                strSQL = "SELECT company_id,company_name,company_address,company_address1,company_address2,company_zipcode,company_contect FROM claims_company ORDER BY company_name ASC"
                Mainfrm.lblMainStatus.Text = strSQL
            ElseIf strsqlsel = 200 Then
                strSQL = "SELECT company_id,company_name,company_address,company_address1,company_address2,company_zipcode,company_contect FROM claims_company WHERE 1=1"
                Dim strKeyWord As String = Me.txtCCsearch.Text
                If strKeyWord <> "" Then
                    strSQL = strSQL & " AND company_name like '%" & strKeyWord & "%'  OR company_address like '%" & strKeyWord & "%';"
                    Mainfrm.lblMainStatus.Text = strSQL
                End If
            End If
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dim r As Integer
                While (Dr.Read())
                    With Me.dgCC
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(0).Value = Dr.Item("company_id")
                        .Rows(r).Cells(1).Value = Dr.Item("company_name")
                        .Rows(r).Cells(2).Value = Dr.Item("company_address")
                        .Rows(r).Cells(3).Value = Dr.Item("company_address1")
                        .Rows(r).Cells(4).Value = Dr.Item("company_address2")
                        .Rows(r).Cells(5).Value = Dr.Item("company_zipcode")
                        .Rows(r).Cells(6).Value = Dr.Item("company_contect")
                    End With
                End While
            End Using
            strsqlsel = Nothing
            Mainfrm.lblMainStatus.Text = "โหลดข้อมูล claims_company แล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub AutoNumberNo()
        Try
            Mainfrm.lblMainStatus.Text = "โหลด ID"
            strSQL = "SELECT Max(ID) as ID FROM claims_company_id"
            dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Dim newID As Integer = CInt(Dr.Item("ID"))
            newID += 1
            Me.txtCCcom_id.Text = newID.ToString("000")
            Dr.Close()
            Mainfrm.lblMainStatus.Text = "โหลด ID แล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "โหลด ID ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub txtCCsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCCsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            strsqlsel = 200
            Call getdata()
            Me.txtCCsearch.Clear()
        End If
    End Sub

    Private Sub btnCCsearch_Click(sender As Object, e As EventArgs) Handles btnCCsearch.Click
        strsqlsel = 200
        Call getdata()
        Me.txtCCsearch.Clear()
    End Sub

    Private Sub btnCCadd_Click(sender As Object, e As EventArgs) Handles btnCCadd.Click
        If Me.btnCCadd.Text = "เพิ่ม" Then
            Me.btnCCadd.Text = "บันทึก"
            Call AutoNumberNo()
            Me.btnCCcancel.Enabled = True
            Me.txtCCcom_name.Enabled = True
            Me.txtCCcom_address.Enabled = True
            Me.txtCCcom_address1.Enabled = True
            Me.txtCCcom_address2.Enabled = True
            Me.txtCCcom_zipcode.Enabled = True
            Me.txtCCcom_contect.Enabled = True
            Me.dgCC.Enabled = False
        ElseIf Me.btnCCadd.Text = "บันทึก" Then
            Mainfrm.lblMainStatus.Text = "ตรวจข้อมูลซ้ำ"
            strSQL = "SELECT company_name FROM claims_company WHERE company_name='" & Me.txtCCcom_name.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            If Dr.HasRows Then
                Mainfrm.lblMainStatus.Text = "ชื่อนี้ " & Me.txtCCcom_name.Text & " มีในระบบแล้ว กรุณาตรวจสอบ"
                MsgBox("ชื่อนี้ " & Me.txtCCcom_name.Text & " มีในระบบเแล้ว กรุณาตรวจสอบ", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Me.txtCCcom_name.BackColor = Color.OrangeRed
                Me.txtCCcom_name.Focus()
                Exit Sub
            End If
            Mainfrm.lblMainStatus.Text = "ตรวจข้อมูลซ้ำเรียบร้อย"
            If Me.txtCCcom_name.Text = "" Then
                Me.txtCCcom_name.BackColor = Color.OrangeRed
                Me.txtCCcom_name.Focus()
                Mainfrm.lblMainStatus.Text = "ไม่ควรว่างบริษัท"
                MsgBox("ไม่ควรว่าง", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Exit Sub
            ElseIf Me.txtCCcom_address.Text = "" Then
                Me.txtCCcom_address.BackColor = Color.OrangeRed
                Me.txtCCcom_address.Focus()
                Mainfrm.lblMainStatus.Text = "ไม่ควรว่างที่อยู่บริษัท"
                MsgBox("ไม่ควรว่าง", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Exit Sub
            ElseIf Me.txtCCcom_address1.Text = "" Then
                Me.txtCCcom_address1.BackColor = Color.OrangeRed
                Me.txtCCcom_address1.Focus()
                Mainfrm.lblMainStatus.Text = "ไม่ควรว่างอำเภอ/เขต"
                MsgBox("ไม่ควรว่าง", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Exit Sub
            ElseIf Me.txtCCcom_address2.Text = "" Then
                Me.txtCCcom_address2.BackColor = Color.OrangeRed
                Me.txtCCcom_address2.Focus()
                Mainfrm.lblMainStatus.Text = "ไม่ควรว่างจังหวัด"
                MsgBox("ไม่ควรว่าง", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Exit Sub
            ElseIf Me.txtCCcom_zipcode.Text = "" Then
                Me.txtCCcom_zipcode.BackColor = Color.OrangeRed
                Me.txtCCcom_zipcode.Focus()
                Mainfrm.lblMainStatus.Text = "ไม่ควรว่างรหัสไปรษณีย์"
                MsgBox("ไม่ควรว่าง", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Exit Sub
            ElseIf Me.txtCCcom_contect.Text = "" Then
                Me.txtCCcom_contect.BackColor = Color.OrangeRed
                Me.txtCCcom_contect.Focus()
                Mainfrm.lblMainStatus.Text = "ไม่ควรว่างติดต่อบริษัท"
                MsgBox("ไม่ควรว่าง", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Exit Sub
            End If
            Mainfrm.lblMainStatus.Text = "บันทึก ID"
            strSQL = "insert into claims_company_id(claims_company_id) " _
                       & " values(@claims_company_id)"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            With cmd
                .Parameters.Add(New MySqlParameter("@claims_company_id", Me.txtCCcom_id.Text))
                Call open_connection()
                .ExecuteNonQuery()
            End With
            Mainfrm.lblMainStatus.Text = "บันทึก ID แล้ว"
            Mainfrm.lblMainStatus.Text = "บันทึกข้อมูล"
            strSQL = "insert into claims_company(company_id,company_name,company_address,company_address1,company_address2,company_zipcode,company_contect) " _
                       & " values(@company_id,@company_name,@company_address,@company_address1,@company_address2,@company_zipcode,@company_contect)"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            With cmd
                .Parameters.Add(New MySqlParameter("@company_id", Me.txtCCcom_id.Text))
                .Parameters.Add(New MySqlParameter("@company_name", Me.txtCCcom_name.Text))
                .Parameters.Add(New MySqlParameter("@company_address", Me.txtCCcom_address.Text))
                .Parameters.Add(New MySqlParameter("@company_address1", Me.txtCCcom_address1.Text))
                .Parameters.Add(New MySqlParameter("@company_address2", Me.txtCCcom_address2.Text))
                .Parameters.Add(New MySqlParameter("@company_zipcode", Me.txtCCcom_zipcode.Text))
                .Parameters.Add(New MySqlParameter("@company_contect", Me.txtCCcom_contect.Text))
                Call open_connection()
                .ExecuteNonQuery()
            End With
            Mainfrm.lblMainStatus.Text = "บันทึกข้อมูลเรียบร้อย"
            Me.btnCCadd.Text = "เพิ่ม"
            Me.dgCC.Enabled = True
            Call startFrm()
        End If
    End Sub

    Private Sub btnCCcancel_Click(sender As Object, e As EventArgs) Handles btnCCcancel.Click
        Call startFrm()
    End Sub

    Private Sub txtCCcom_name_Click(sender As Object, e As EventArgs) Handles txtCCcom_name.Click
        Me.txtCCcom_name.BackColor = SystemColors.Window
    End Sub

    Private Sub txtCCcom_address_Click(sender As Object, e As EventArgs) Handles txtCCcom_address.Click
        Me.txtCCcom_address.BackColor = SystemColors.Window
    End Sub

    Private Sub txtCCcom_contect_Click(sender As Object, e As EventArgs) Handles txtCCcom_contect.Click
        Me.txtCCcom_contect.BackColor = SystemColors.Window
    End Sub

    Private Sub dgCC_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgCC.CellMouseDoubleClick
        Me.txtCCcom_id.Text = Me.dgCC.SelectedCells.Item(0).Value
        Me.txtCCcom_name.Text = Me.dgCC.SelectedCells.Item(1).Value
        Me.txtCCcom_address.Text = Me.dgCC.SelectedCells.Item(2).Value
        Me.txtCCcom_address1.Text = Me.dgCC.SelectedCells.Item(3).Value
        Me.txtCCcom_address2.Text = Me.dgCC.SelectedCells.Item(4).Value
        Me.txtCCcom_zipcode.Text = Me.dgCC.SelectedCells.Item(5).Value
        Me.txtCCcom_contect.Text = Me.dgCC.SelectedCells.Item(6).Value
        Me.btnCCadd.Enabled = False
        Me.btnCCedit.Enabled = True
        Me.btnCCdel.Enabled = True
        Me.btnCCcancel.Enabled = True
    End Sub

    Private Sub btnCCedit_Click(sender As Object, e As EventArgs) Handles btnCCedit.Click
        If Me.btnCCedit.Text = "แก้ไข" Then
            Me.btnCCedit.Text = "บันทึก"
            Me.btnCCcancel.Enabled = True
            Me.txtCCcom_name.Enabled = True
            Me.txtCCcom_address.Enabled = True
            Me.txtCCcom_address1.Enabled = True
            Me.txtCCcom_address2.Enabled = True
            Me.txtCCcom_zipcode.Enabled = True
            Me.txtCCcom_contect.Enabled = True
            Me.dgCC.Enabled = False

        ElseIf Me.btnCCedit.Text = "บันทึก" Then
            Try
                Mainfrm.lblMainStatus.Text = "ตรวจข้อมูลซ้ำ"
                strSQL = "SELECT company_id FROM claims_company WHERE company_name='" & Me.txtCCcom_name.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                Dim cn As String
                cn = Dr.Item("company_id")
                If Dr.HasRows Then
                    If cn = Me.txtCCcom_id.Text Then
                        Exit Try
                    Else
                        Mainfrm.lblMainStatus.Text = "ชื่อนี้ " & Me.txtCCcom_name.Text & " มีในระบบแล้ว กรุณาตรวจสอบ"
                        MsgBox("ชื่อนี้ " & Me.txtCCcom_name.Text & " มีในระบบเแล้ว กรุณาตรวจสอบ", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                        Me.txtCCcom_name.BackColor = Color.OrangeRed
                        Me.txtCCcom_name.Focus()
                        Exit Sub
                    End If
                End If
            Catch ex As Exception

            End Try

            Mainfrm.lblMainStatus.Text = "ตรวจข้อมูลซ้ำเรียบร้อย"
            If Me.txtCCcom_name.Text = "" Then
                Me.txtCCcom_name.BackColor = Color.OrangeRed
                Me.txtCCcom_name.Focus()
                Mainfrm.lblMainStatus.Text = "ไม่ควรว่างบริษัท"
                MsgBox("ไม่ควรว่าง", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Exit Sub
            ElseIf Me.txtCCcom_address.Text = "" Then
                Me.txtCCcom_address.BackColor = Color.OrangeRed
                Me.txtCCcom_address.Focus()
                Mainfrm.lblMainStatus.Text = "ไม่ควรว่างที่อยู่บริษัท"
                MsgBox("ไม่ควรว่าง", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Exit Sub
            ElseIf Me.txtCCcom_address1.Text = "" Then
                Me.txtCCcom_address1.BackColor = Color.OrangeRed
                Me.txtCCcom_address1.Focus()
                Mainfrm.lblMainStatus.Text = "ไม่ควรว่างอำเภอ/เขต"
                MsgBox("ไม่ควรว่าง", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Exit Sub
            ElseIf Me.txtCCcom_address2.Text = "" Then
                Me.txtCCcom_address2.BackColor = Color.OrangeRed
                Me.txtCCcom_address2.Focus()
                Mainfrm.lblMainStatus.Text = "ไม่ควรว่างจังหวัด"
                MsgBox("ไม่ควรว่าง", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Exit Sub
            ElseIf Me.txtCCcom_zipcode.Text = "" Then
                Me.txtCCcom_zipcode.BackColor = Color.OrangeRed
                Me.txtCCcom_zipcode.Focus()
                Mainfrm.lblMainStatus.Text = "ไม่ควรว่างรหัสไปรษณีย์"
                MsgBox("ไม่ควรว่าง", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Exit Sub
            ElseIf Me.txtCCcom_contect.Text = "" Then
                Me.txtCCcom_contect.BackColor = Color.OrangeRed
                Me.txtCCcom_contect.Focus()
                Mainfrm.lblMainStatus.Text = "ไม่ควรว่างติดต่อบริษัท"
                MsgBox("ไม่ควรว่าง", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                Exit Sub
            End If
            Mainfrm.lblMainStatus.Text = "แก้ไขข้อมูล"
            strSQL = "UPDATE claims_company set company_name=@company_name,company_address=@company_address,company_address1=@company_address1,company_address2=@company_address2,company_zipcode=@company_zipcode,company_contect=@company_contect WHERE company_id='" & Me.txtCCcom_id.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            With cmd
                .Parameters.Add(New MySqlParameter("@company_name", Me.txtCCcom_name.Text))
                .Parameters.Add(New MySqlParameter("@company_address", Me.txtCCcom_address.Text))
                .Parameters.Add(New MySqlParameter("@company_address1", Me.txtCCcom_address1.Text))
                .Parameters.Add(New MySqlParameter("@company_address2", Me.txtCCcom_address2.Text))
                .Parameters.Add(New MySqlParameter("@company_zipcode", Me.txtCCcom_zipcode.Text))
                .Parameters.Add(New MySqlParameter("@company_contect", Me.txtCCcom_contect.Text))
                Call open_connection()
                .ExecuteNonQuery()
            End With
            Mainfrm.lblMainStatus.Text = "แก้ไขข้อมูลเรียบร้อย"
            Me.btnCCedit.Text = "แก้ไข"
            Me.dgCC.Enabled = True
            Call startFrm()
        End If
    End Sub

    Private Sub btnCCdel_Click(sender As Object, e As EventArgs) Handles btnCCdel.Click
        Dim Ans As String
        Ans = MsgBox("คุณแน่ใจว่าจะลบข้อมูลนี้", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
        If Ans = System.Windows.Forms.DialogResult.No Then
            MsgBox("การลบข้อมูลถูกยกเลิก", MsgBoxStyle.Information, "ยืนยัน")

            Exit Sub
        Else
            strSQL = "DELETE FROM claims_company WHERE company_id='" & Me.txtCCcom_id.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            Mainfrm.lblMainStatus.Text = "ลบข้อมูลที่คุณเลือกแล้ว"
        End If
        Call startFrm()
    End Sub

    Private Sub btnCCtoclaimsSend_Click(sender As Object, e As EventArgs) Handles btnCCtoclaimsSend.Click
        If Me.dgCC.RowCount = 0 Then
            Exit Sub
        Else
            If ClaimsSendFrm.ecom = 100 Then
                ClaimsSendFrm.txtCScom_id.Text = Me.dgCC.SelectedCells.Item(0).Value
                ClaimsSendFrm.txtCScom_name.Text = Me.dgCC.SelectedCells.Item(1).Value
                ClaimsSendFrm.txtCScom_address.Text = Me.dgCC.SelectedCells.Item(2).Value
                ClaimsSendFrm.txtCScom_addressAOM.Text = Me.dgCC.SelectedCells.Item(3).Value
                ClaimsSendFrm.txtCScom_addressJJ.Text = Me.dgCC.SelectedCells.Item(4).Value
                ClaimsSendFrm.txtCScom_addressZip.Text = Me.dgCC.SelectedCells.Item(5).Value
                ClaimsSendFrm.txtCScom_contect.Text = Me.dgCC.SelectedCells.Item(6).Value
                ClaimsSendFrm.ecom = Nothing
                Me.Close()
            Else
                BoxCoverFrm.txtCScom_id.Text = Me.dgCC.SelectedCells.Item(0).Value
                BoxCoverFrm.txtCScom_name.Text = Me.dgCC.SelectedCells.Item(1).Value
                BoxCoverFrm.txtCScom_address.Text = Me.dgCC.SelectedCells.Item(2).Value
                BoxCoverFrm.txtCScom_addressAOM.Text = Me.dgCC.SelectedCells.Item(3).Value
                BoxCoverFrm.txtCScom_addressJJ.Text = Me.dgCC.SelectedCells.Item(4).Value
                BoxCoverFrm.txtCScom_addressZip.Text = Me.dgCC.SelectedCells.Item(5).Value
                BoxCoverFrm.txtCScom_contect.Text = Me.dgCC.SelectedCells.Item(6).Value
                Me.Close()
            End If
           
        End If
    End Sub
End Class