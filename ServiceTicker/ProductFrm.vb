Imports MySql.Data.MySqlClient
Public Class ProductFrm
    'เสร็จแล้ว 
    Private Sub GetAllData()
        Try
            Me.dgProductType.Rows.Clear()
            strSQL = "SELECT ID,p_type FROM product_type"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Dim ro As Integer = Me.dgProductType.RowCount
                With Me.dgProductType
                    .Rows.Add()
                    .Rows(ro).Cells(0).Value = Dr.GetString("ID")
                    .Rows(ro).Cells(1).Value = Dr.GetString("p_type")
                End With
            End While
        Catch ex As Exception

        End Try
    End Sub
   
    Private Sub startfrm()
        Me.txtProductType.Enabled = False
        Me.btnDel.Enabled = False
        Me.btnEdit.Enabled = False
        Me.txtProductType.Text = ""
        Me.dgProductType.Enabled = True
        Me.btnAdd.Enabled = True
        Me.btnAdd.Text = "&เพิ่ม"
        Me.btnCancel.Text = "&ปิด"
        Me.btnEdit.Text = "&แก้ไข"
        Call GetAllData()
        Mainfrm.lblMainStatus.Text = "ฟอร์มเริ่มต้นพร้อมทำงาน"
    End Sub

    Private Sub EditData()
        Dim UpDateAns As String
        UpDateAns = MsgBox("คุณแน่ใจว่าจะแก้ไขข้อมูลนี้", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
        If UpDateAns = System.Windows.Forms.DialogResult.No Then
            MsgBox("การแก้ไขข้อมูลถูกยกเลิก.", MsgBoxStyle.Information, "ยกเลิกการแก้ไข")
            Call startfrm()
        Else
            strSQL = "UPDATE product_type SET p_type='" & Me.txtProductType.Text & "' WHERE ID='" & Me.dgProductType.SelectedCells(0).Value & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            MsgBox("แก้ไขข้อมูลเรียบร้อยแล้ว.", MsgBoxStyle.Information, "ยืนยัน")
            Call startfrm()
        End If
    End Sub



    Private Sub DeleteData()
        Dim Ans As String
        Ans = MsgBox("คุณแน่ในว่าจะลบข้อมูลนี้", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
        If Ans = System.Windows.Forms.DialogResult.No Then
            MsgBox("การลบข้อมูลถูกยกเลิก", MsgBoxStyle.Information, "ยืนยัน")
            Me.dgProductType.ClearSelection()
            Exit Sub
        Else
            strSQL = "DELETE FROM product_type WHERE ID='" & Me.dgProductType.SelectedCells(0).Value & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            MsgBox("ลบข้อมูลที่คุณเลือกแล้ว", MsgBoxStyle.Information, "ยืนยัน")
        End If
    End Sub
    Private Sub addData()
        Dim Ans As String
        Ans = MsgBox("คุณแน่ในว่าจะเพิ่มข้อมูลนี้", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
        If Ans = System.Windows.Forms.DialogResult.No Then
            MsgBox("การเพิ่มข้อมูลถูกยกเลิก", MsgBoxStyle.Information, "ยืนยัน")
            Me.dgProductType.ClearSelection()
            Exit Sub
        Else
            strSQL = "INSERT INTO product_type(p_type)VALUES('" & Me.txtProductType.Text & "');"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            MsgBox("เพิ่มข้อมูลแล้ว", MsgBoxStyle.Information, "ยืนยัน")
        End If
    End Sub
    Private Sub ProductTypefrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If Me.btnEdit.Text = "&แก้ไข" Then
            Me.txtProductType.Enabled = True
            Me.dgProductType.Enabled = False
            Me.btnEdit.Text = "&บันทึก"
            Me.btnDel.Enabled = False
            Me.btnCancel.Text = "&ยกเลิก"
            Exit Sub
        ElseIf Me.btnEdit.Text = "&บันทึก" Then
            If txtProductType.Text = "" Then
                MsgBox("กรุณาใส่ข้อมูล.", vbOKOnly + vbExclamation, "ตรวจสอบการป้อนข้อมูล")
                txtProductType.Focus()
                txtProductType.BackColor = Color.Salmon
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
            Me.txtProductType.Enabled = True
            Me.dgProductType.Enabled = False
            Me.btnAdd.Text = "&บันทึก"
            Me.btnDel.Enabled = False
            Me.btnEdit.Enabled = False
            Me.btnCancel.Text = "&ยกเลิก"
            Exit Sub
        ElseIf Me.btnAdd.Text = "&บันทึก" Then
            If txtProductType.Text = "" Then
                MsgBox("กรุณาใส่ข้อมูล.", vbOKOnly + vbExclamation, "ตรวจสอบการป้อนข้อมูล")
                txtProductType.Focus()
                txtProductType.BackColor = Color.Salmon
                Exit Sub
            End If
            Call addData()
            Me.btnAdd.Text = "&เพิ่ม"
        End If
        Call GetAllData()
        Call startfrm()
    End Sub
    Private Sub dgProductType_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgProductType.MouseDoubleClick
        If Me.dgProductType.Rows.Count = 0 Then
        Else
            Me.btnAdd.Enabled = False
            Me.btnDel.Enabled = True
            Me.btnEdit.Enabled = True
            Me.btnCancel.Text = "&ยกเลิก"
            Me.txtProductType.Text = Me.dgProductType.SelectedCells(1).Value
        End If
        
    End Sub
End Class