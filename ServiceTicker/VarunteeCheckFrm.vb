Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class VarunteeCheckFrm
   
    Private Sub VarunteeCheckFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
    End Sub

    Private Sub searchData()
        Try
            If Me.txtVCsearch.Text = "" Then
                Exit Sub
            End If
            Me.dgVC.Rows.Clear()
            Me.txtVCdetail.Clear()
            strSQL = "SELECT fix_id,customer_id,customer_name,sn,fixrepairnote,fixaccessory,varuntee,fixuser,status,user_repair,datecom_repair FROM comfix WHERE fix_id LIKE'%" & Me.txtVCsearch.Text & "%' or sn LIKE'%" & Me.txtVCsearch.Text & "%' or customer_id LIKE'%" & Me.txtVCsearch.Text & "%' or customer_name LIKE'%" & Me.txtVCsearch.Text & "%'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Dim r As Integer
                With Me.dgVC
                    r = .Rows.Count
                    .Rows.Add()
                    .Rows(r).Cells(1).Value = Dr.Item("fix_id")
                    .Rows(r).Cells(2).Value = Dr.Item("customer_id")
                    .Rows(r).Cells(3).Value = Dr.Item("sn")
                    .Rows(r).Cells(4).Value = Dr.Item("fixrepairnote")
                    .Rows(r).Cells(5).Value = Dr.Item("fixaccessory")
                    .Rows(r).Cells(6).Value = Dr.Item("varuntee")
                    .Rows(r).Cells(7).Value = Dr.Item("status")
                    .Rows(r).Cells(8).Value = Dr.Item("user_repair")
                    .Rows(r).Cells(9).Value = Dr.Item("datecom_repair")
                End With

            End While
            For sum As Integer = 0 To Me.dgVC.Rows.Count - 1
                Me.dgVC.Rows(sum).Cells(0).Value = sum + 1
            Next
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub txtVCsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtVCsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call searchData()
            Me.txtVCsearch.Text = ""
        End If
    End Sub

    Private Sub btnVCsearch_Click(sender As Object, e As EventArgs) Handles btnVCsearch.Click
        Call searchData()
        Me.txtVCsearch.Text = ""
    End Sub
    Dim firstDate, msg, datevrt, ttd As String
    Dim secondDate As Date
    Private Sub getdataClick()
     
        Try
            strSQL = "SELECT day FROM varuntee WHERE varuntee_status='" & Me.dgVC.SelectedCells.Item(6).Value & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            datevrt = Dr.Item("day")
            Try
            firstDate = Me.dgVC.SelectedCells.Item(9).Value
            secondDate = CDate(firstDate)
                msg = DateAdd(DateInterval.Day, CInt(datevrt), secondDate)
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ไม่พบวันที่รับประกัน "
            End Try

            'Me.txtVCdetail.Refresh()
            strSQL = "SELECT customer_name,symptom,managerdata,date_save,date_get,date_send FROM comfix WHERE fix_id='" & Me.dgVC.SelectedCells.Item(1).Value & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Me.txtVCdetail.Text = "ชื่อลูกค้า " & Dr.Item("customer_name") & ", อาการเสีย " & Dr.Item("symptom") & ", การจัดการข้อมูล " & Dr.Item("managerdata") _
                & vbNewLine & "วันที่รับงาน " & Dr.Item("date_save") & ", วันที่นัดรับงาน " & Dr.Item("date_get") & ", วันที่ส่งงาน " & Dr.Item("date_send") _
                & vbNewLine & "หมดประกันวันที่(วัน/เดือน/ปี)  " & msg & " "


        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub dgVC_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgVC.CellMouseClick
        Call getdataClick()
    End Sub
End Class