Imports MySql.Data.MySqlClient

Public Class AuditDetailFrm
    Private Sub getDataaudit()
        Try
            Me.dgAD.Rows.Clear()
            strSQL = "SELECT datetime,money1,money2,money5,money10,money20,money50,money100,money500,money1000,totalAll,`check`,transfer,cash,charges,deliverMorning,deliverNoon,deliverEvening,totalDeliver,difference" _
                & " FROM audit WHERE datetime='" & AuditReportFrm.dgAR.SelectedCells.Item(1).Value & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Dim r As Integer
                With Me.dgAD
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(1).Value = Dr.GetString("datetime")
                    .Rows(r).Cells(2).Value = Dr.GetString("money1")
                    .Rows(r).Cells(3).Value = Dr.GetString("money2")
                    .Rows(r).Cells(4).Value = Dr.GetString("money5")
                    .Rows(r).Cells(5).Value = Dr.GetString("money10")
                    .Rows(r).Cells(6).Value = Dr.GetString("money20")
                    .Rows(r).Cells(7).Value = Dr.GetString("money50")
                    .Rows(r).Cells(8).Value = Dr.GetString("money100")
                    .Rows(r).Cells(9).Value = Dr.GetString("money500")
                    .Rows(r).Cells(10).Value = Dr.GetString("money1000")
                    .Rows(r).Cells(11).Value = Dr.GetString("totalAll")
                    .Rows(r).Cells(12).Value = Dr.GetString("check")
                    .Rows(r).Cells(13).Value = Dr.GetString("transfer")
                    .Rows(r).Cells(14).Value = Dr.GetString("cash")
                    .Rows(r).Cells(15).Value = Dr.GetString("charges")
                    .Rows(r).Cells(16).Value = Dr.GetString("deliverMorning")
                    .Rows(r).Cells(17).Value = Dr.GetString("deliverNoon")
                    .Rows(r).Cells(18).Value = Dr.GetString("deliverEvening")
                    .Rows(r).Cells(19).Value = Dr.GetString("totalDeliver")
                    .Rows(r).Cells(20).Value = Dr.GetString("difference")
                End With
            End While
            'Dim max As Integer = Me.dgAD.Rows.Count - 1
            'Dim total As String = Me.txtARincome.Text
            'Dim total1 As String = Me.txtARcharge.Text
            'Dim tot As Integer = 0
            'Dim tot1 As Integer = 0
            'For Each row As DataGridViewRow In Me.dgAR.Rows
            '    tot += row.Cells(2).Value
            '    tot1 += row.Cells(3).Value
            'Next
            'Me.txtARincome.Text = tot
            'Me.txtARcharge.Text = tot1
            For sum As Integer = 0 To Me.dgAD.Rows.Count - 1
                Me.dgAD.Rows(sum).Cells(0).Value = sum + 1
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AuditDetailFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call getDataaudit()
        Me.Icon = Mainfrm.Icon
    End Sub
End Class