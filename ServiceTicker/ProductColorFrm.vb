Imports MySql.Data.MySqlClient
Public Class ProductColorFrm
    'เสร็จ V2 2014/12/21
    Private Sub GetAllData()
        Try
            Me.dgProductName.Rows.Clear()
            strSQL = "SELECT id,color FROM product_color ORDER BY color ASC"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Dim ro As Integer = Me.dgProductName.RowCount
                With Me.dgProductName
                    .Rows.Add()
                    .Rows(ro).Cells(0).Value = Dr.GetString("id")
                    .Rows(ro).Cells(1).Value = Dr.GetString("color")
                End With
            End While
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
  

    Private Sub EditData()
        Dim UpDateAns As String
        UpDateAns = MsgBox("คุณแน่ใจว่าจะแก้ไขข้อมูลนี้", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
        If UpDateAns = System.Windows.Forms.DialogResult.No Then
            MsgBox("การแก้ไขข้อมูลถูกยกเลิก.", MsgBoxStyle.Information, "ยกเลิกการแก้ไข")
            Call startfrm()
        Else
            Try
                strSQL = "UPDATE product_color SET color = '" & Me.txtProductName.Text & "' WHERE id='" & Me.dgProductName.SelectedCells(0).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                MsgBox("แก้ไขข้อมูลเรียบร้อยแล้ว.", MsgBoxStyle.Information, "ยืนยัน")
                Call startfrm()
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
        End If
    End Sub

    Private Sub startfrm()
        Me.txtProductName.Enabled = False
        Me.btnDel.Enabled = False
        Me.btnEdit.Enabled = False
        Me.txtProductName.Text = ""
        Me.dgProductName.Enabled = True
        Me.btnAdd.Enabled = True
        Me.dgProductName.Enabled = True
        Me.btnAdd.Text = "&เพิ่ม"
        Me.btnCancel.Text = "&ปิด"
        Me.btnEdit.Text = "&แก้ไข"
        Call GetAllData()
        Mainfrm.lblMainStatus.Text = "ฟอร์มเริ่มต้นพร้อมทำงาน"
    End Sub
    Private Sub DeleteData()
        Dim Ans As String
        Ans = MsgBox("คุณแน่ในว่าจะลบข้อมูลนี้", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
        If Ans = System.Windows.Forms.DialogResult.No Then
            MsgBox("การลบข้อมูลถูกยกเลิก", MsgBoxStyle.Information, "ยืนยัน")
            Me.dgProductName.ClearSelection()
            Exit Sub
        Else
            Try
                strSQL = "DELETE FROM product_color WHERE id='" & Me.dgProductName.SelectedCells(0).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                MsgBox("ลบข้อมูลที่คุณเลือกแล้ว", MsgBoxStyle.Information, "ยืนยัน")
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
        End If
    End Sub
    Private Sub addData()
        Dim Ans As String
        Ans = MsgBox("คุณแน่ในว่าจะเพิ่มข้อมูลนี้", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
        If Ans = System.Windows.Forms.DialogResult.No Then
            MsgBox("การเพิ่มข้อมูลถูกยกเลิก", MsgBoxStyle.Information, "ยืนยัน")
            Me.dgProductName.ClearSelection()
            Exit Sub
        Else
            Try
                strSQL = "INSERT INTO product_color(color)VALUES('" & Me.txtProductName.Text & "');"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                MsgBox("เพิ่มข้อมูลแล้ว", MsgBoxStyle.Information, "ยืนยัน")
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
        End If
    End Sub
    Private Sub ProductNamefrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call startfrm()
        Me.Icon = Mainfrm.Icon
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If Me.btnCancel.Text = "&ยกเลิก" Then
            Call startfrm()
        ElseIf Me.btnCancel.Text = "&ปิด" Then
            Me.Close()
        End If
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If Me.btnEdit.Text = "&แก้ไข" Then
            Me.txtProductName.Enabled = True
            Me.dgProductName.Enabled = False
            Me.btnEdit.Text = "&บันทึก"
            Me.btnDel.Enabled = False
            Me.btnCancel.Text = "&ยกเลิก"
            Exit Sub
        ElseIf Me.btnEdit.Text = "&บันทึก" Then
            If txtProductName.Text = "" Then
                MsgBox("กรุณาใส่ข้อมูล.", MsgBoxStyle.Exclamation, "ตรวจสอบการป้อนข้อมูล")
                txtProductName.Focus()
                txtProductName.BackColor = Color.Salmon
                Exit Sub
            End If
            Call EditData()
            Me.btnEdit.Text = "&แก้ไข"
        End If
        Call GetAllData()
        Call startfrm()
    End Sub
    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Call DeleteData()
        Call GetAllData()
        Call startfrm()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Me.btnAdd.Text = "&เพิ่ม" Then
            Me.txtProductName.Enabled = True
            Me.dgProductName.Enabled = False
            Me.btnAdd.Text = "&บันทึก"
            Me.btnDel.Enabled = False
            Me.btnEdit.Enabled = False
            Me.btnCancel.Text = "&ยกเลิก"
            Exit Sub
        ElseIf Me.btnAdd.Text = "&บันทึก" Then
            If txtProductName.Text = "" Then
                MsgBox("กรุณาใส่ข้อมูล.", MsgBoxStyle.Exclamation, "ตรวจสอบการป้อนข้อมูล")
                txtProductName.Focus()
                txtProductName.BackColor = Color.Salmon
                Exit Sub
            End If
            Call addData()
            Me.btnAdd.Text = "&เพิ่ม"
        End If

        Call GetAllData()
        Call startfrm()
    End Sub
    Private Sub dgProductName_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgProductName.MouseDoubleClick
        If Me.dgProductName.Rows.Count = 0 Then
        Else
            Me.btnAdd.Enabled = False
            Me.btnDel.Enabled = True
            Me.btnEdit.Enabled = True
            Me.btnCancel.Text = "&ยกเลิก"
            Me.txtProductName.Text = Me.dgProductName.SelectedCells(1).Value
        End If
    End Sub
End Class