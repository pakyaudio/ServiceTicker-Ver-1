Imports MySql.Data.MySqlClient

Public Class CheckHistoryComfixFrm
    Private Sub searchDatacomfixSN()
        Try
            Mainfrm.lblMainStatus.Text = "โหลด comfix"
            Me.dgSDFsearchfixbySN.Rows.Clear()
            strSQL = "SELECT fix_id,customer_id,customer_name,sn,symptom,note_repair,date_save,date_send FROM comfix WHERE sn='" & Me.txtCHCsearchSN.Text & "' ORDER BY date_save ASC"
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dim r As Integer
                While (Dr.Read())
                    With Me.dgSDFsearchfixbySN
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(1).Value = Dr.Item("fix_id")
                        .Rows(r).Cells(2).Value = Dr.Item("customer_id")
                        .Rows(r).Cells(3).Value = Dr.Item("customer_name")
                        .Rows(r).Cells(4).Value = Dr.Item("sn")
                        .Rows(r).Cells(5).Value = Dr.Item("symptom")
                        .Rows(r).Cells(6).Value = Dr.Item("note_repair")
                        .Rows(r).Cells(7).Value = Dr.Item("date_save")
                        .Rows(r).Cells(8).Value = Dr.Item("date_send")
                       
                    End With
                End While
            End Using
            For sum As Integer = 0 To Me.dgSDFsearchfixbySN.Rows.Count - 1
                Me.dgSDFsearchfixbySN.Rows(sum).Cells(0).Value = sum + 1
                strSQL = "SELECT fix_id FROM sale_serial WHERE fix_id='" & Me.dgSDFsearchfixbySN.Rows(sum).Cells(1).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                If Dr.HasRows Then
                    Me.dgSDFsearchfixbySN.Rows(sum).Cells(9).Value = "มี"
                Else
                    strSQL = "SELECT fix_id FROM cash_sale_serial WHERE fix_id='" & Me.dgSDFsearchfixbySN.Rows(sum).Cells(1).Value & "'"
                    Mainfrm.lblMainStatus.Text = strSQL
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader()
                    Dr.Read()
                    If Dr.HasRows Then
                        Me.dgSDFsearchfixbySN.Rows(sum).Cells(9).Value = "มี"
                    Else
                        Me.dgSDFsearchfixbySN.Rows(sum).Cells(9).Value = "ไม่มี"
                    End If
                End If
            Next
            Me.txtCHCsearchSN.Clear()
            Dr.Close()
            Mainfrm.lblMainStatus.Text = "โหลด comfix แล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "โหลด comfix ผิดพลาด"
        End Try
    End Sub

    Private Sub txtCHCsearchSN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCHCsearchSN.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call searchDatacomfixSN()
        End If
    End Sub

    Private Sub btnCHCviewpro_Click(sender As Object, e As EventArgs) Handles btnCHCviewpro.Click
        CheckHistoryViewProFrm.MdiParent = Mainfrm
        CheckHistoryViewProFrm.Show()
        CheckHistoryViewProFrm.txtVHCPfixid.Text = Me.dgSDFsearchfixbySN.SelectedCells.Item(1).Value
        Call CheckHistoryViewProFrm.searchDataSN()
    End Sub

    Private Sub dgSDFsearchfixbySN_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSDFsearchfixbySN.CellClick
       
    End Sub

    Private Sub dgSDFsearchfixbySN_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgSDFsearchfixbySN.CellMouseClick
       
    End Sub

    Private Sub CheckHistoryComfixFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.btnCHCviewpro.Enabled = False
        Me.Icon = Mainfrm.Icon
    End Sub

    Private Sub dgSDFsearchfixbySN_MouseClick(sender As Object, e As MouseEventArgs) Handles dgSDFsearchfixbySN.MouseClick
        If Me.dgSDFsearchfixbySN.SelectedCells.Item(9).Value = "มี" Then
            Me.btnCHCviewpro.Enabled = True
        Else
            Me.btnCHCviewpro.Enabled = False
        End If
    End Sub

    Private Sub btnCHCsearchSN_Click(sender As Object, e As EventArgs) Handles btnCHCsearchSN.Click
        Call searchDatacomfixSN()
    End Sub
End Class