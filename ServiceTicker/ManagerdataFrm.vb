Imports MySql.Data.MySqlClient
Public Class ManagerdataFrm
    'เสร็จ v2 2014/12/27
    
    Private Sub GetAllData()
        Try
            Me.dgmdataName.Rows.Clear()
            strSQL = "SELECT ID,mdata FROM managerdata"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Dim ro As Integer = Me.dgmdataName.RowCount
                With Me.dgmdataName
                    .Rows.Add()
                    .Rows(ro).Cells(0).Value = Dr.GetString("id")
                    .Rows(ro).Cells(1).Value = Dr.GetString("mdata")
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
                Mainfrm.lblMainStatus.Text = "Update managerdata"
                strSQL = "UPDATE managerdata SET mdata='" & Me.txtmdataName.Text & "' WHERE mdata='" & Me.dgmdataName.SelectedCells(1).Value & "'"
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
        Me.txtmdataName.Enabled = False
        Me.btnDel.Enabled = False
        Me.btnEdit.Enabled = False
        Me.txtmdataName.Text = ""
        Me.dgmdataName.Enabled = True
        Me.btnAdd.Enabled = True
        Me.dgmdataName.Enabled = True
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
            Me.dgmdataName.ClearSelection()
        Else
            Try
                Mainfrm.lblMainStatus.Text = "Delete from managerdata "
                strSQL = "DELETE FROM managerdata WHERE ID='" & Me.dgmdataName.SelectedCells(0).Value & "'"
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
            Me.dgmdataName.ClearSelection()
        Else
            Try
                Mainfrm.lblMainStatus.Text = "INSERT INTO managerdata "
                strSQL = "INSERT INTO managerdata(mdata)VALUES('" & Me.txtmdataName.Text & "');"
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
            Me.txtmdataName.Enabled = True
            Me.dgmdataName.Enabled = False
            Me.btnEdit.Text = "&บันทึก"
            Me.btnDel.Enabled = False
            Me.btnCancel.Text = "&ยกเลิก"
        ElseIf Me.btnEdit.Text = "&บันทึก" Then
            If txtmdataName.Text = "" Then
                MsgBox("กรุณาใส่ข้อมูล.", MsgBoxStyle.Exclamation, "ตรวจสอบการป้อนข้อมูล")
                txtmdataName.Focus()
                txtmdataName.BackColor = Color.Salmon
            Else
                Call EditData()
                Me.btnEdit.Text = "&แก้ไข"
                Call startfrm()
            End If
        End If
    End Sub
    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Call DeleteData()
        Call startfrm()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Me.btnAdd.Text = "&เพิ่ม" Then
            Me.txtmdataName.Enabled = True
            Me.dgmdataName.Enabled = False
            Me.btnAdd.Text = "&บันทึก"
            Me.btnDel.Enabled = False
            Me.btnEdit.Enabled = False
            Me.btnCancel.Text = "&ยกเลิก"
        ElseIf Me.btnAdd.Text = "&บันทึก" Then
            If txtmdataName.Text = "" Then
                MsgBox("กรุณาใส่ข้อมูล.", MsgBoxStyle.Exclamation, "ตรวจสอบการป้อนข้อมูล")
                txtmdataName.Focus()
                txtmdataName.BackColor = Color.Salmon
            Else
                Call addData()
                Me.btnAdd.Text = "&เพิ่ม"
                Call startfrm()
            End If
        End If
    End Sub
    Private Sub dgmdataName_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgmdataName.MouseDoubleClick
        If Me.dgmdataName.Rows.Count = 0 Then
        Else
            Me.btnAdd.Enabled = False
            Me.btnDel.Enabled = True
            Me.btnEdit.Enabled = True
            Me.btnCancel.Text = "&ยกเลิก"
            Me.txtmdataName.Text = Me.dgmdataName.SelectedCells(1).Value
        End If
    End Sub
End Class