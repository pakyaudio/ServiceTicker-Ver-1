Imports MySql.Data.MySqlClient

Public Class AuditChargesFrm
    Private Sub getDataaudit()
        Try
            Me.dgAC.Rows.Clear()
            strSQL = "SELECT datetime,namewiden,`list`,money,note " _
                & " FROM audit_outgoings WHERE datetime='" & AuditReportFrm.dgAR.SelectedCells.Item(1).Value & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read()
                Dim r As Integer
                With Me.dgAC
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(1).Value = Dr.GetString("namewiden")
                    .Rows(r).Cells(2).Value = Dr.GetString("list")
                    .Rows(r).Cells(3).Value = Dr.GetString("money")
                    .Rows(r).Cells(4).Value = Dr.GetString("note")
                End With
            End While
            
            For sum As Integer = 0 To Me.dgAC.Rows.Count - 1
                Me.dgAC.Rows(sum).Cells(0).Value = sum + 1
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub AuditChargesFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        Call getDataaudit()
    End Sub
End Class