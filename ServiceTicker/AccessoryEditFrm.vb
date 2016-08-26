Imports MySql.Data.MySqlClient
Public Class AccessoryEditFrm
   
    Private Sub GetAllData()
        Mainfrm.lblMainStatus.Text = "โหลด accessory_name"
        Me.dgAccessory.Rows.Clear()
        strSQL = "SELECT id,accessory_name FROM accessory"
        cmd = New MySqlCommand(strSQL, ConnectionDB)
        Call open_connection()
        Dr = cmd.ExecuteReader
        While (Dr.Read())
            Dim ro As Integer = Me.dgAccessory.RowCount
            With Me.dgAccessory
                .Rows.Add()
                .Rows(ro).Cells(0).Value = Dr.GetString("id")
                .Rows(ro).Cells(1).Value = Dr.GetString("accessory_name")
            End With
        End While
        Mainfrm.lblMainStatus.Text = "โหลด accessory_name แล้ว"
    End Sub
    Private Sub startfrm()
        Me.btnAdd.Enabled = True
        Me.btnAdd.Text = "&เพิ่ม"
        Me.btnEdit.Enabled = False
        Me.btnDel.Enabled = False
        Me.txtFixCom.Enabled = False
        Me.dgAccessory.Enabled = True
        Me.txtFixCom.Text = ""
        Me.btnCancel.Text = "&ปิด"
        Me.btnEdit.Text = "&แก้ไข"
        Call GetAllData()
        Mainfrm.lblMainStatus.Text = "ฟอร์มเริ่มต้นพร้อมทำงาน"
    End Sub
    Private Sub EditData()
        Mainfrm.lblMainStatus.Text = "การแก้ไขข้อมูลทำงาน"
        Dim UpDateAns As String
        UpDateAns = MsgBox("คุณแน่ใจว่าจะแก้ไขข้อมูลนี้", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
        If UpDateAns = System.Windows.Forms.DialogResult.No Then
            MsgBox("การแก้ไขข้อมูลถูกยกเลิก.", MsgBoxStyle.Information, "ยกเลิกการแก้ไข")
            Mainfrm.lblMainStatus.Text = "ยกเลิกการแก้ไข"
            Call startfrm()
        Else
            strSQL = "Update accessory SET accessory_name= '" & Me.txtFixCom.Text & "' WHERE ID='" & Me.dgAccessory.SelectedCells.Item(0).Value & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            Mainfrm.lblMainStatus.Text = "การแก้ไขเรียบร้อย"
            MsgBox("แก้ไขข้อมูลเรียบร้อยแล้ว.", MsgBoxStyle.Information, "ยืนยัน")
            Call startfrm()
        End If
    End Sub

    Private Sub DeleteData()
        Mainfrm.lblMainStatus.Text = "ลบข้อมูลทำงาน"
        Dim Ans As String
        Ans = MsgBox("คุณแน่ในว่าจะลบข้อมูลนี้", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
        If Ans = System.Windows.Forms.DialogResult.No Then
            MsgBox("การลบข้อมูลถูกยกเลิก", MsgBoxStyle.Information, "ยืนยัน")
            Me.dgAccessory.ClearSelection()
            Mainfrm.lblMainStatus.Text = "ยกเลิกการลบ"
            Exit Sub
        Else
            strSQL = "DELETE FROM accessory WHERE id='" & Me.dgAccessory.SelectedCells.Item(0).Value & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            Mainfrm.lblMainStatus.Text = "ลบข้อมูลแล้ว"
            MsgBox("ลบข้อมูลที่คุณเลือกแล้ว", MsgBoxStyle.Information, "ยืนยัน")
        End If
    End Sub
    Private Sub addData()
        Mainfrm.lblMainStatus.Text = "เพิ่มข้อมูลทำงาน"
        Dim Ans As String
        Ans = MsgBox("คุณแน่ในว่าจะเพิ่มข้อมูลนี้", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ยืนยัน")
        If Ans = System.Windows.Forms.DialogResult.No Then
            MsgBox("การเพิ่มข้อมูลถูกยกเลิก", MsgBoxStyle.Information, "ยืนยัน")
            Me.dgAccessory.ClearSelection()
            Mainfrm.lblMainStatus.Text = "ยกเลิกการเพิ่ม"
            Exit Sub
        Else
            strSQL = "INSERT INTO accessory(accessory_name)VALUES('" & Me.txtFixCom.Text & "')"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            Mainfrm.lblMainStatus.Text = "เพิ่มข้อมูลแล้ว"
            MsgBox("เพิ่มข้อมูลแล้ว", MsgBoxStyle.Information, "ยืนยัน")
            Call startfrm()
        End If
    End Sub
    Private Sub FixComfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Mainfrm.lblMainStatus.Text = "แก้ไขข้อมูล"
            Me.txtFixCom.Enabled = True
            Me.dgAccessory.Enabled = False
            Me.btnEdit.Text = "&บันทึก"
            Me.btnDel.Enabled = False
            Me.btnCancel.Text = "&ยกเลิก"
            Exit Sub
        ElseIf Me.btnEdit.Text = "&บันทึก" Then
            If txtFixCom.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ใส่ข้อมูลไม่ครบ"
                MsgBox("กรุณาใส่ข้อมูล.", MsgBoxStyle.Exclamation, "ตรวจสอบการป้อนข้อมูล")
                Me.txtFixCom.Focus()
                Me.txtFixCom.BackColor = Color.Salmon
            Else
                Call EditData()
                Me.btnEdit.Text = "&แก้ไข"
                'Call startfrm()
            End If
        End If
    End Sub
    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Call DeleteData()
        Call GetAllData()
        Call startfrm()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Me.btnAdd.Text = "&เพิ่ม" Then
            Mainfrm.lblMainStatus.Text = "เพิ่มข้อมูล"
            Me.txtFixCom.Enabled = True
            Me.dgAccessory.Enabled = False
            Me.btnAdd.Text = "&บันทึก"
            Me.btnDel.Enabled = False
            Me.btnEdit.Enabled = False
            Me.btnCancel.Text = "&ยกเลิก"
            Exit Sub
        ElseIf Me.btnAdd.Text = "&บันทึก" Then
            If txtFixCom.Text = "" Then
                Mainfrm.lblMainStatus.Text = "ใส่ข้อมูลไม่ครบ"
                MsgBox("กรุณาใส่ข้อมูล.", MsgBoxStyle.Exclamation, "ตรวจสอบการป้อนข้อมูล")
                Me.txtFixCom.Focus()
                Me.txtFixCom.BackColor = Color.Salmon
            Else
                Call addData()
                Me.btnAdd.Text = "&เพิ่ม"
                'Call startfrm()
            End If
        End If
    End Sub
    Private Sub dgAccessory_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgAccessory.MouseDoubleClick
        If Me.dgAccessory.Rows.Count = 0 Then
        Else
            Me.btnAdd.Enabled = False
            Me.btnDel.Enabled = True
            Me.btnEdit.Enabled = True
            Me.btnCancel.Text = "&ยกเลิก"
            Me.txtFixCom.Text = Me.dgAccessory.SelectedCells.Item(1).Value
        End If

    End Sub
End Class