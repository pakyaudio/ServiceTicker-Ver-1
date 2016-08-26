Imports MySql.Data.MySqlClient

Public Class CreditCardManagFrm

    Private Sub CreditCardManagFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        Call getCreditCard()
        Call getCreditCardBank()
        Call btnCCMcreditClick()
        Call btnCCMbankClick()
    End Sub
    'ดึงข้อมูลบัตรเครดิต
    Private Sub getCreditCard()
        Try
            Me.dgCCMcredit.Rows.Clear()
            strSQL = "SELECT card_type FROM credit_card"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim r As Integer
            While Dr.Read()
                With Me.dgCCMcredit
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.GetString("card_type")
                End With
            End While
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    'ดึงข้อมูลแบ้งก์
    Private Sub getCreditCardBank()
        Try
            Me.dgCCMbank.Rows.Clear()
            strSQL = "SELECT bank_name FROM credit_card_bank"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim r As Integer
            While Dr.Read()
                With Me.dgCCMbank
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.GetString("bank_name")
                End With
            End While
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    'add edit del credit_card
    Private Sub InsertCreditCard()
        Try
            strSQL = "INSERT INTO credit_card (card_type)VALUES(@card_type)"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            cmd.Parameters.Add(New MySqlParameter("@card_type", Me.txtCCMcredit.Text))
            Call open_connection()
            Dim save As Integer
            save = cmd.ExecuteNonQuery()
            If save = 1 Then
                MsgBox("บันทึกข้อมูลแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub UpdateCreditCard()
        Try
            strSQL = "UPDATE credit_card SET card_type='" & Me.txtCCMcredit.Text & "' WHERE card_type='" & Me.dgCCMcredit.CurrentRow.Cells(0).Value & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dim save As Integer
            save = cmd.ExecuteNonQuery()
            If save = 1 Then
                MsgBox("อัพเดทข้อมูลแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub DeleteCreditCard()
        Try
            strSQL = "DELETE FROM credit_card WHERE card_type='" & Me.txtCCMcredit.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            cmd.Parameters.Add(New MySqlParameter("@card_type", Me.txtCCMcredit.Text))
            Call open_connection()
            Dim save As Integer
            save = cmd.ExecuteNonQuery()
            If save = 1 Then
                MsgBox("ลบข้อมูลแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub btnCCMcreditClick()
        Me.btnCCMcreditAdd.Enabled = True
        Me.btnCCMcreditEdit.Enabled = False
        Me.btnCCMcreditDel.Enabled = False
        Me.btnCCMcreditCancel.Enabled = False
        Me.txtCCMcredit.Enabled = False
        Me.txtCCMcredit.Clear()
        Me.btnCCMcreditAdd.Text = "เพิ่ม"
        Me.btnCCMcreditEdit.Text = "แก้ไข"
    End Sub

    Private Sub btnCCMbankClick()
        Me.btnCCMbankAdd.Enabled = True
        Me.btnCCMbankEdit.Enabled = False
        Me.btnCCMbankDel.Enabled = False
        Me.btnCCMbankCancel.Enabled = False
        Me.txtCCMBbank.Enabled = False
        Me.txtCCMBbank.Clear()
        Me.btnCCMbankAdd.Text = "เพิ่ม"
        Me.btnCCMbankEdit.Text = "แก้ไข"
    End Sub
    Private Sub dgCCMcredit_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCCMcredit.CellContentDoubleClick
        If Me.dgCCMcredit.Rows.Count = 0 Then
        Else
            Me.txtCCMcredit.Text = Me.dgCCMcredit.CurrentRow.Cells(0).Value
            Me.btnCCMcreditEdit.Enabled = True
            Me.btnCCMcreditDel.Enabled = True
            Me.btnCCMcreditCancel.Enabled = True
            Me.btnCCMcreditAdd.Enabled = False
            Me.txtCCMcredit.Enabled = False
        End If
    End Sub

    Private Sub btnCCMcreditAdd_Click(sender As Object, e As EventArgs) Handles btnCCMcreditAdd.Click
        If Me.btnCCMcreditAdd.Text = "เพิ่ม" Then
            Me.btnCCMcreditAdd.Text = "บันทึก"
            Me.btnCCMcreditEdit.Enabled = False
            Me.btnCCMcreditDel.Enabled = False
            Me.btnCCMcreditCancel.Enabled = True
            Me.txtCCMcredit.Enabled = True
        ElseIf Me.btnCCMcreditAdd.Text = "บันทึก" Then
            Call InsertCreditCard()
            Me.btnCCMcreditAdd.Text = "เพิ่ม"
            Call btnCCMcreditClick()
            Call getCreditCard()
        End If
    End Sub

    Private Sub btnCCMcreditEdit_Click(sender As Object, e As EventArgs) Handles btnCCMcreditEdit.Click
        If Me.btnCCMcreditEdit.Text = "แก้ไข" Then
            Me.btnCCMcreditEdit.Text = "บันทึก"
            Me.btnCCMcreditDel.Enabled = False
            Me.btnCCMcreditCancel.Enabled = True
            Me.txtCCMcredit.Enabled = True
        ElseIf Me.btnCCMcreditEdit.Text = "บันทึก" Then
            Call UpdateCreditCard()
            Me.btnCCMcreditEdit.Text = "แก้ไข"
            Call btnCCMcreditClick()
            Call getCreditCard()
        End If
    End Sub

    Private Sub btnCCMcreditDel_Click(sender As Object, e As EventArgs) Handles btnCCMcreditDel.Click
        If MessageBox.Show("แน่ใจว่าจะลบ " & Me.txtCCMcredit.Text, "ยืนยันการลบ", _
                           MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, _
                           MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Call DeleteCreditCard()
            Call btnCCMcreditClick()
            Call getCreditCard()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub btnCCMcreditCancel_Click(sender As Object, e As EventArgs) Handles btnCCMcreditCancel.Click
        Call btnCCMcreditClick()
    End Sub

    'add edit del bank
    Private Sub InsertBank()
        Try
            strSQL = "INSERT INTO credit_card_bank(bank_name)VALUES(@bank_name)"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            cmd.Parameters.Add(New MySqlParameter("@bank_name", Me.txtCCMBbank.Text))
            Call open_connection()
            Dim save As Integer
            save = cmd.ExecuteNonQuery()
            If save = 1 Then
                MsgBox("บันทึกข้อมูลแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub UpdateBank()
        Try
            strSQL = "UPDATE credit_card_bank SET bank_name='" & Me.txtCCMBbank.Text & "' WHERE bank_name='" & Me.dgCCMbank.CurrentRow.Cells(0).Value & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dim save As Integer
            save = cmd.ExecuteNonQuery()
            If save = 1 Then
                MsgBox("อัพเดทข้อมูลแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub DeleteBank()
        Try
            strSQL = "DELETE FROM credit_card_bank WHERE bank_name='" & Me.txtCCMBbank.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            cmd.Parameters.Add(New MySqlParameter("@card_type", Me.txtCCMBbank.Text))
            Call open_connection()
            Dim save As Integer
            save = cmd.ExecuteNonQuery()
            If save = 1 Then
                MsgBox("ลบข้อมูลแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub dgCCMbank_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCCMbank.CellContentDoubleClick
        If Me.dgCCMbank.Rows.Count = 0 Then
        Else
            Me.txtCCMBbank.Text = Me.dgCCMbank.CurrentRow.Cells(0).Value
            Me.btnCCMbankEdit.Enabled = True
            Me.btnCCMbankDel.Enabled = True
            Me.btnCCMbankCancel.Enabled = True
            Me.btnCCMbankAdd.Enabled = False
            Me.txtCCMBbank.Enabled = False
        End If
    End Sub

    Private Sub btnCCMbankAdd_Click(sender As Object, e As EventArgs) Handles btnCCMbankAdd.Click
        If Me.btnCCMbankAdd.Text = "เพิ่ม" Then
            Me.btnCCMbankAdd.Text = "บันทึก"
            Me.btnCCMbankEdit.Enabled = False
            Me.btnCCMbankDel.Enabled = False
            Me.btnCCMbankCancel.Enabled = True
            Me.txtCCMBbank.Enabled = True
        ElseIf Me.btnCCMbankAdd.Text = "บันทึก" Then
            Call InsertBank()
            Me.btnCCMbankAdd.Text = "เพิ่ม"
            Call btnCCMbankClick()
            Call getCreditCardBank()
        End If
    End Sub

    Private Sub btnCCMbankEdit_Click(sender As Object, e As EventArgs) Handles btnCCMbankEdit.Click
        If Me.btnCCMbankEdit.Text = "แก้ไข" Then
            Me.btnCCMbankEdit.Text = "บันทึก"
            Me.btnCCMbankDel.Enabled = False
            Me.btnCCMbankCancel.Enabled = True
            Me.txtCCMBbank.Enabled = True
        ElseIf Me.btnCCMbankEdit.Text = "บันทึก" Then
            Call UpdateBank()
            Me.btnCCMbankEdit.Text = "แก้ไข"
            Call btnCCMbankClick()
            Call getCreditCardBank()
        End If
    End Sub

    Private Sub btnCCMbankDel_Click(sender As Object, e As EventArgs) Handles btnCCMbankDel.Click
        If MessageBox.Show("แน่ใจว่าจะลบ " & Me.txtCCMBbank.Text, "ยืนยันการลบ", _
                           MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, _
                           MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            Call DeleteBank()
            Call btnCCMbankClick()
            Call getCreditCardBank()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnCCMbankCancel_Click(sender As Object, e As EventArgs) Handles btnCCMbankCancel.Click
        Call btnCCMbankClick()
    End Sub
End Class