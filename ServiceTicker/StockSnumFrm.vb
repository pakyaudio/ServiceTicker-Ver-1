Public Class StockSnumFrm

    Private Sub StockSnumFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        StockFrm.Enabled = True
        OrdreFrm.Enabled = True
    End Sub

    Private Sub StockSnumFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StockFrm.Enabled = False
        OrdreFrm.Enabled = False
    End Sub

    Private Sub NumericUpDown1_KeyDown(sender As Object, e As KeyEventArgs) Handles NumericUpDown1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call SelectOK()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub


    Private Sub btnSSok_Click(sender As Object, e As EventArgs) Handles btnSSok.Click
        Call SelectOK()
    End Sub
    Private Sub SelectOK()
        OrdreFrm.r = OrdreFrm.tbl.NewRow
        OrdreFrm.r.Item(0) = StockFrm.dgStock.SelectedCells.Item(1).Value
        OrdreFrm.r.Item(1) = StockFrm.dgStock.SelectedCells.Item(2).Value
        OrdreFrm.r.Item(2) = StockFrm.dgStock.SelectedCells.Item(3).Value
        OrdreFrm.r.Item(3) = StockFrm.dgStock.SelectedCells.Item(4).Value
        OrdreFrm.r.Item(4) = StockFrm.dgStock.SelectedCells.Item(5).Value
        OrdreFrm.r.Item(5) = NumericUpDown1.Value
        OrdreFrm.r.Item(6) = StockFrm.dgStock.SelectedCells.Item(3).Value
        OrdreFrm.tbl.Rows.Add(OrdreFrm.r)
        Call OrdreFrm.sum_dgOR()
        Call StockFrm.numOK()
        StockFrm.Enabled = True
        OrdreFrm.Enabled = True
        Me.Close()
    End Sub
End Class