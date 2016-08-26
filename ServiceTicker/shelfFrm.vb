Imports MySql.Data.MySqlClient
Public Class shelfFrm
    Private Sub LoadData()
        Try
            Me.dgSF.Rows.Clear()
            strSQL = "SELECT `s` FROM `shelf` ORDER BY `s` ASC"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Dim i As Integer
                With Me.dgSF
                    i = .RowCount
                    .Rows.Add()
                    .Rows(i).Cells(0).Value = Dr.GetString("s")
                End With
            End While
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub AddData()
        Try
            strSQL = "INSERT INTO `shelf`(`s`)VALUES(@s)"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            cmd.Parameters.AddWithValue("@s", Me.txtSF.Text)
            Call open_connection()
            Dim sa As Integer
            sa = cmd.ExecuteNonQuery()
            If sa = 1 Then
                MsgBox("บันทึกข้อมูลแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
            ElseIf sa = 0 Then
                MsgBox("บันทึกไม่สำเร็จ", MsgBoxStyle.Information, "แจ้งเตือน")
            End If

        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub EditData()
        Try
            strSQL = "UPDATE `shelf` SET `s`='" & Me.txtSF.Text & "' WHERE `s`='" & Me.dgSF.CurrentRow.Cells(0).Value & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dim sa As Integer
            sa = cmd.ExecuteNonQuery()
            If sa = 1 Then
                MsgBox("แก้ไขข้อมูลแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
            ElseIf sa = 0 Then
                MsgBox("แก้ไขไม่สำเร็จ", MsgBoxStyle.Information, "แจ้งเตือน")
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub DeleteData()
        Try
            strSQL = "DELETE FROM shelf WHERE `s`='" & Me.dgSF.CurrentRow.Cells(0).Value & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dim sa As Integer
            sa = cmd.ExecuteNonQuery()
            If sa = 1 Then
                MsgBox("ลบข้อมูลแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
            ElseIf sa = 0 Then
                MsgBox("ลบไม่สำเร็จ", MsgBoxStyle.Information, "แจ้งเตือน")
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub StartFrm()
        Me.btnSFadd.Enabled = True
        Me.btnSFedit.Enabled = False
        Me.btnSFdelete.Enabled = False
        Me.btnSFclose.Text = "ปิด"
        Me.btnSFadd.Text = "เพิ่ม"
        Me.btnSFedit.Text = "แก้ไข"
        Me.txtSF.Text = Nothing
        Me.txtSF.Enabled = False
        Call LoadData()
    End Sub
    Private Sub shelfFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        Call StartFrm()
        Call LoadData()
    End Sub

    Private Sub btnSFadd_Click(sender As Object, e As EventArgs) Handles btnSFadd.Click
        If Me.btnSFadd.Text = "เพิ่ม" Then
            Me.btnSFadd.Text = "บันทึก"
            Me.btnSFclose.Text = "ยกเลิก"
            Me.txtSF.Enabled = True
        ElseIf Me.btnSFadd.Text = "บันทึก" Then
            Call AddData()
            Call StartFrm()
        End If
    End Sub

    Private Sub btnSFedit_Click(sender As Object, e As EventArgs) Handles btnSFedit.Click
        If Me.btnSFedit.Text = "แก้ไข" Then
            Me.btnSFedit.Text = "บันทึก"
            Me.btnSFclose.Text = "ยกเลิก"
            Me.btnSFadd.Enabled = False
            Me.txtSF.Enabled = True
        ElseIf Me.btnSFedit.Text = "บันทึก" Then
            Call EditData()
            Call StartFrm()
        End If
    End Sub

    Private Sub btnSFdelete_Click(sender As Object, e As EventArgs) Handles btnSFdelete.Click
        If MessageBox.Show("คุณแน่ใจว่าจะลบข้อมูล " & Me.dgSF.CurrentRow.Cells(0).Value & " นี้", "ยืนยัน", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.OK Then
            Call DeleteData()
            Call StartFrm()
        Else
            Call StartFrm()
            Exit Sub
        End If
    End Sub

    Private Sub btnSFclose_Click(sender As Object, e As EventArgs) Handles btnSFclose.Click
        If Me.btnSFclose.Text = "ปิด" Then
            Me.Close()
        ElseIf Me.btnSFclose.Text = "ยกเลิก" Then
            Call StartFrm()
        End If
    End Sub

    Private Sub dgSF_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSF.CellDoubleClick
        Me.txtSF.Text = Me.dgSF.CurrentRow.Cells(0).Value
        Me.btnSFadd.Enabled = False
        Me.btnSFedit.Enabled = True
        Me.btnSFdelete.Enabled = True
        Me.btnSFclose.Text = "ยกเลิก"
    End Sub
End Class