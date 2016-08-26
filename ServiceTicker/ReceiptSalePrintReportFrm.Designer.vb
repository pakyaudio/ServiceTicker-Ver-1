<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceiptSalePrintReportFrm
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.cash_sale_barcodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceiptSaleDataSet = New ServiceTicker.ReceiptSaleDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.cash_sale_barcodeTableAdapter = New ServiceTicker.ReceiptSaleDataSetTableAdapters.cash_sale_barcodeTableAdapter()
        CType(Me.cash_sale_barcodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiptSaleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cash_sale_barcodeBindingSource
        '
        Me.cash_sale_barcodeBindingSource.DataMember = "cash_sale_barcode"
        Me.cash_sale_barcodeBindingSource.DataSource = Me.ReceiptSaleDataSet
        '
        'ReceiptSaleDataSet
        '
        Me.ReceiptSaleDataSet.DataSetName = "ReceiptSaleDataSet"
        Me.ReceiptSaleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet2"
        ReportDataSource1.Value = Me.cash_sale_barcodeBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ServiceTicker.ReceiveSaleReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(784, 561)
        Me.ReportViewer1.TabIndex = 0
        '
        'cash_sale_barcodeTableAdapter
        '
        Me.cash_sale_barcodeTableAdapter.ClearBeforeFill = True
        '
        'ReceiptSalePrintReportFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReceiptSalePrintReportFrm"
        Me.Text = "พิมพ์ใบเสร็จรับเงิน "
        CType(Me.cash_sale_barcodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiptSaleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cash_sale_barcodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReceiptSaleDataSet As ServiceTicker.ReceiptSaleDataSet
    Friend WithEvents cash_sale_barcodeTableAdapter As ServiceTicker.ReceiptSaleDataSetTableAdapters.cash_sale_barcodeTableAdapter
End Class
