Imports MySql.Data.MySqlClient

Public Class AddRepairNoteFrm

    Private Sub PBcancel_Click(sender As Object, e As EventArgs) Handles PBcancel.Click
        Me.Close()
    End Sub

    Private Sub AddRepairNoteFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        Call GetData()
    End Sub

    Private Sub GetData()
        Try
            strSQL = "SELECT DISTINCT note_repair FROM comfix"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            While Dr.Read()
                Dim r As Integer
                With Me.dgAddRepairNote
                    r = .Rows.Count
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.GetString("note_repair")
                End With
            End While
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub pbADD_Click(sender As Object, e As EventArgs) Handles pbADD.Click
        If Me.dgAddRepairNote.SelectedRows.Count = False Then
        Else
            Mainfrm.lblMainStatus.Text = "เพิ่ม " & Me.dgAddRepairNote.CurrentRow.Cells(0).Value & " แล้ว"
            If Not RepairStatusFrm.txtRSnote_repair.Text = "-" Then
                RepairStatusFrm.txtRSnote_repair.SelectAll()
                RepairStatusFrm.txtRSnote_repair.Text = RepairStatusFrm.txtRSnote_repair.Text + "," & Me.dgAddRepairNote.CurrentRow.Cells(0).Value
            Else
                RepairStatusFrm.txtRSnote_repair.Text = Me.dgAddRepairNote.CurrentRow.Cells(0).Value
            End If
        End If
    End Sub
End Class