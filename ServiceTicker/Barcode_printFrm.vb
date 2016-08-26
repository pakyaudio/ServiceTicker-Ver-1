Public Class Barcode_printFrm

    Private Sub Barcode_printFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BCPrintDataSet.barcode_print' table. You can move, or remove it, as needed.
        Me.barcode_printTableAdapter.Fill(Me.BCPrintDataSet.barcode_print)
        Me.Icon = Mainfrm.Icon
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class