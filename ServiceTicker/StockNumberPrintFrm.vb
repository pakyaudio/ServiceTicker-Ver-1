Imports Microsoft.Reporting.WinForms

Public Class StockNumberPrintFrm

    Private Sub StockNumberPrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StockNumbeDataSet.stock_number_cache' table. You can move, or remove it, as needed.
        Me.stock_number_cacheTableAdapter.Fill(Me.StockNumbeDataSet.stock_number_cache)
        Me.Icon = Mainfrm.Icon
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        Dim TP As New ReportParameter("total_p", StockNumberFrm.txtSNtotal_p.Text)
        Dim TCA As New ReportParameter("total_costA", StockNumberFrm.txtSNtotal_costA.Text)
        Dr.Close()
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {TP, TCA _
                                                                          })
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class