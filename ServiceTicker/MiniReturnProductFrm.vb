Public Class MiniReturnProductFrm

    Private Sub btnMRPcancel_Click(sender As Object, e As EventArgs) Handles btnMRPcancel.Click
        ReturnsProductFrm.Enabled = True
        Me.Close()
    End Sub

    Private Sub MiniReturnProductFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtMRPnumpro1.Text = Me.txtMRPnumPro.Text
    End Sub

    Private Sub btnMRPok_Click(sender As Object, e As EventArgs) Handles btnMRPok.Click
        For g As Integer = 0 To ReturnsProductFrm.dgRPsendProBarcode.Rows.Count - 1
            If ReturnsProductFrm.dgRPproBarcode.SelectedCells.Item(0).Value = ReturnsProductFrm.dgRPsendProBarcode.Rows(g).Cells(0).Value Then
                Dim CN As Integer = CInt(ReturnsProductFrm.dgRPsendProBarcode.Rows(g).Cells(3).Value) + CInt(Me.txtMRPnumpro1.Text)
                If CN > CInt(ReturnsProductFrm.dgRPproBarcode.SelectedCells.Item(3).Value) Then
                    MsgBox("จำนวนที่คืนมีมากกว่าจำนวนที่ขาย ไม่สามารถคืนมากกว่าจำนวนที่ขายได้", MsgBoxStyle.Exclamation, "แจ้งเตือน")
                    Exit Sub
                ElseIf CN <= CInt(ReturnsProductFrm.dgRPproBarcode.Rows(g).Cells(3).Value) Then
                    ReturnsProductFrm.dgRPsendProBarcode.Rows(g).Cells(3).Value = CInt(ReturnsProductFrm.dgRPsendProBarcode.Rows(g).Cells(3).Value) + CInt(Me.txtMRPnumpro1.Text)
                    Call ReturnsProductFrm.sumDG()
                    ReturnsProductFrm.Enabled = True
                    Me.Close()
                    Exit Sub
                End If
            End If
        Next
        If CInt(Me.txtMRPnumpro1.Text) > CInt(Me.txtMRPnumPro.Text) Then
            MsgBox("ปริมาณคืน มีจำนวนมากกว่าปริมาณที่สามารถคืนได้", MsgBoxStyle.Exclamation, "แจ้งเตือน")
            Exit Sub
        ElseIf CInt(Me.txtMRPnumpro1.Text) <= 0 Then
            MsgBox("ปริมาณคืน มีค่าเป็น 0 หรือน้อยกว่า 0 ไม่ได้", MsgBoxStyle.Exclamation, "แจ้งเตือน")
            Exit Sub
        Else
            Dim ff As Integer = ReturnsProductFrm.dgRPsendProBarcode.Rows.Count
            ReturnsProductFrm.dgRPsendProBarcode.Rows.Add()
            ReturnsProductFrm.dgRPsendProBarcode.Rows(ff).Cells(0).Value = ReturnsProductFrm.dgRPproBarcode.SelectedCells.Item(0).Value
            ReturnsProductFrm.dgRPsendProBarcode.Rows(ff).Cells(1).Value = ReturnsProductFrm.dgRPproBarcode.SelectedCells.Item(1).Value
            ReturnsProductFrm.dgRPsendProBarcode.Rows(ff).Cells(2).Value = ReturnsProductFrm.dgRPproBarcode.SelectedCells.Item(2).Value
            ReturnsProductFrm.dgRPsendProBarcode.Rows(ff).Cells(3).Value = CInt(Me.txtMRPnumpro1.Text)
            ReturnsProductFrm.dgRPsendProBarcode.Rows(ff).Cells(4).Value = ReturnsProductFrm.dgRPproBarcode.SelectedCells.Item(4).Value
            ReturnsProductFrm.dgRPsendProBarcode.Rows(ff).Cells(5).Value = CInt(ReturnsProductFrm.dgRPsendProBarcode.Rows(ff).Cells(2).Value) * CInt(ReturnsProductFrm.dgRPsendProBarcode.Rows(ff).Cells(3).Value)
            Call ReturnsProductFrm.sumDG()
            ReturnsProductFrm.Enabled = True
            Me.Close()
        End If
    End Sub
End Class