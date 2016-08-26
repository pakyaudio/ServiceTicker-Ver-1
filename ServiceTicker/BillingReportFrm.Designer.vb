<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillingReportFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents saleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BillDataSet As ServiceTicker.BillDataSet
    Friend WithEvents pledge_saleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents saleTableAdapter As ServiceTicker.BillDataSetTableAdapters.saleTableAdapter
    Friend WithEvents pledge_saleTableAdapter As ServiceTicker.BillDataSetTableAdapters.pledge_saleTableAdapter

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
 
   

 
End Class
