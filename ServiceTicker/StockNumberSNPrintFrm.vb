Imports Microsoft.Reporting.WinForms

Public Class StockNumberSNPrintFrm

    Private Sub StockNumberPrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StockNumberSNDataSet.stock_number_sn_cache' table. You can move, or remove it, as needed.
        Me.stock_number_sn_cacheTableAdapter.Fill(Me.StockNumberSNDataSet.stock_number_sn_cache)
        Me.ReportViewer1.RefreshReport()
        Me.Icon = Mainfrm.Icon
    End Sub


End Class