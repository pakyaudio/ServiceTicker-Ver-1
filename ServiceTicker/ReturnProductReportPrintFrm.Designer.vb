<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnProductReportPrintFrm
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReturnProductDataSet = New ServiceTicker.ReturnProductDataSet()
        Me.returnproduct_barcodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.returnproduct_barcodeTableAdapter = New ServiceTicker.ReturnProductDataSetTableAdapters.returnproduct_barcodeTableAdapter()
        CType(Me.ReturnProductDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.returnproduct_barcodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ReturnProDataSet"
        ReportDataSource1.Value = Me.returnproduct_barcodeBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ServiceTicker.ReturnProductReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(784, 561)
        Me.ReportViewer1.TabIndex = 0
        '
        'ReturnProductDataSet
        '
        Me.ReturnProductDataSet.DataSetName = "ReturnProductDataSet"
        Me.ReturnProductDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'returnproduct_barcodeBindingSource
        '
        Me.returnproduct_barcodeBindingSource.DataMember = "returnproduct_barcode"
        Me.returnproduct_barcodeBindingSource.DataSource = Me.ReturnProductDataSet
        '
        'returnproduct_barcodeTableAdapter
        '
        Me.returnproduct_barcodeTableAdapter.ClearBeforeFill = True
        '
        'ReturnProductReportPrintFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReturnProductReportPrintFrm"
        Me.Text = "พิมพ์ใบเสร็จรับเงิน"
        CType(Me.ReturnProductDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.returnproduct_barcodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents returnproduct_barcodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReturnProductDataSet As ServiceTicker.ReturnProductDataSet
    Friend WithEvents returnproduct_barcodeTableAdapter As ServiceTicker.ReturnProductDataSetTableAdapters.returnproduct_barcodeTableAdapter
End Class
