Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class AccessLavelFrm

    Private Sub loadData()
        Try
            strSQL = "SELECT * FROM access_lavel"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            While Dr.Read()
                Dim i As Integer
                With Me.dgAL
                    i = .RowCount
                    .Rows.Add()
                    .Rows(i).Cells(0).Value = Dr.GetString("id")
                    If Dr.Item("access") = 0 Then
                        .Rows(i).Cells(1).Value = "ไม่ใช่"
                    ElseIf Dr.Item("access") = 1 Then
                        .Rows(i).Cells(1).Value = "ใช่"
                    End If
                    .Rows(i).Cells(2).Value = Dr.GetString("zone")
                    If Dr.GetString("leval") = "1" Then
                        .Rows(i).Cells(3).Value = "ผู้ใช้งาน"
                    ElseIf Dr.GetString("leval") = "2" Then
                        .Rows(i).Cells(3).Value = "หัวหน้า"
                    ElseIf Dr.GetString("leval") = "3" Then
                        .Rows(i).Cells(3).Value = "ผู้ดูแลระบบ"
                    End If
                    .Rows(i).Cells(4).Value = Dr.GetString("link")
                    .Rows(i).Cells(6).Value = Dr.GetString("datetime_edit")
                End With
            End While
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Event dgALButtonClick(sender As DataGridView, e As DataGridViewCellEventArgs)

    Private Sub dgAL_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) Handles dgAL.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
            RaiseEvent dgALButtonClick(senderGrid, e)
        End If
    End Sub

    Private Sub DataGridView1_ButtonClick(sender As DataGridView, e As DataGridViewCellEventArgs) Handles Me.dgALButtonClick
        Try
            strSQL = "UPDATE access_lavel SET access=@access,leval=@leval,datetime_edit=@dted " _
                    & "WHERE id='" & Me.dgAL.CurrentRow.Cells(0).Value & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            With cmd
                If Me.dgAL.CurrentRow.Cells(1).Value = "ใช่" Then
                    .Parameters.AddWithValue("@access", 1)
                ElseIf Me.dgAL.CurrentRow.Cells(1).Value = "ไม่ใช่" Then
                    .Parameters.AddWithValue("@access", 0)
                End If

                If Me.dgAL.CurrentRow.Cells(3).Value = "ผู้ใช้งาน" Then
                    .Parameters.AddWithValue("@leval", 1)
                ElseIf Me.dgAL.CurrentRow.Cells(3).Value = "หัวหน้า" Then
                    .Parameters.AddWithValue("@leval", 2)
                ElseIf Me.dgAL.CurrentRow.Cells(3).Value = "ผู้ดูแลระบบ" Then
                    .Parameters.AddWithValue("@leval", 3)
                End If
                .Parameters.AddWithValue("@dted", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")))
            End With
            Call open_connection()
            Dim save As Integer
            save = cmd.ExecuteNonQuery()
            If save = 1 Then
                Mainfrm.lblMainStatus.Text = "บันทึกข้อมูลแล้ว"
            Else
                Mainfrm.lblMainStatus.Text = "บันทึกข้อมูลผิดพลาด"
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Try
            strSQL = "SELECT * FROM access_lavel WHERE id='" & Me.dgAL.CurrentRow.Cells(0).Value & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            While Dr.Read()
                With Me.dgAL
                    .CurrentRow.Cells(0).Value = Dr.GetString("id")
                    If Dr.Item("access") = 0 Then
                        .CurrentRow.Cells(1).Value = "ไม่ใช่"
                    ElseIf Dr.Item("access") = 1 Then
                        .CurrentRow.Cells(1).Value = "ใช่"
                    End If
                    .CurrentRow.Cells(2).Value = Dr.GetString("zone")
                    If Dr.GetString("leval") = "1" Then
                        .CurrentRow.Cells(3).Value = "ผู้ใช้งาน"
                    ElseIf Dr.GetString("leval") = "2" Then
                        .CurrentRow.Cells(3).Value = "หัวหน้า"
                    ElseIf Dr.GetString("leval") = "3" Then
                        .CurrentRow.Cells(3).Value = "ผู้ดูแลระบบ"
                    End If
                    .CurrentRow.Cells(4).Value = Dr.GetString("link")
                    .CurrentRow.Cells(6).Value = Dr.GetString("datetime_edit")
                End With
            End While
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub AccessLavelFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        Call loadData()
      
    End Sub


    Private Sub btnALsave_Click(sender As Object, e As EventArgs) Handles btnALsave.Click
        Try
            For i As Integer = 0 To Me.dgAL.Rows.Count - 1
                strSQL = "UPDATE access_lavel SET access=@access,leval=@leval,datetime_edit=@dted " _
                    & "WHERE id='" & Me.dgAL.Rows(i).Cells(0).Value & "'"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                With cmd
                    If Me.dgAL.Rows(i).Cells(1).Value = "ใช่" Then
                        .Parameters.AddWithValue("@access", 1)
                    ElseIf Me.dgAL.Rows(i).Cells(1).Value = "ไม่ใช่" Then
                        .Parameters.AddWithValue("@access", 0)
                    End If

                    If Me.dgAL.Rows(i).Cells(3).Value = "ผู้ใช้งาน" Then
                        .Parameters.AddWithValue("@leval", 1)
                    ElseIf Me.dgAL.Rows(i).Cells(3).Value = "หัวหน้า" Then
                        .Parameters.AddWithValue("@leval", 2)
                    ElseIf Me.dgAL.Rows(i).Cells(3).Value = "ผู้ดูแลระบบ" Then
                        .Parameters.AddWithValue("@leval", 3)
                    End If
                    .Parameters.AddWithValue("@dted", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")))
                End With
                Call open_connection()
                cmd.ExecuteNonQuery()
            Next
            Call loadData()
            MsgBox("บันทึกข้อมูลแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
End Class