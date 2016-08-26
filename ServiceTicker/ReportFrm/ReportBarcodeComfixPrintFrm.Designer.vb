<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportBarcodeComfixPrintFrm
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
        Me.ReportDBDataSet = New ServiceTicker.ReportDBDataSet()
        Me.ReportBarcodeComfixBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportBarcodeComfixTableAdapter = New ServiceTicker.ReportDBDataSetTableAdapters.ReportBarcodeComfixTableAdapter()
        CType(Me.ReportDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportBarcodeComfixBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ReportBarcodeComfixDataSet"
        ReportDataSource1.Value = Me.ReportBarcodeComfixBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ServiceTicker.ReportBarcodeComfix.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(784, 561)
        Me.ReportViewer1.TabIndex = 0
        '
        'ReportDBDataSet
        '
        Me.ReportDBDataSet.DataSetName = "ReportDBDataSet"
        Me.ReportDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportBarcodeComfixBindingSource
        '
        Me.ReportBarcodeComfixBindingSource.DataMember = "ReportBarcodeComfix"
        Me.ReportBarcodeComfixBindingSource.DataSource = Me.ReportDBDataSet
        '
        'ReportBarcodeComfixTableAdapter
        '
        Me.ReportBarcodeComfixTableAdapter.ClearBeforeFill = True
        '
        'ReportBarcodeComfixPrintFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReportBarcodeComfixPrintFrm"
        Me.Text = "พิมพ์รายงานเบิกสินค้า แบบแสดงรายการสินค้า(เฉพาะงานช่าง(ไม่รวมงานขาย))"
        CType(Me.ReportDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportBarcodeComfixBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportBarcodeComfixBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportDBDataSet As ServiceTicker.ReportDBDataSet
    Friend WithEvents ReportBarcodeComfixTableAdapter As ServiceTicker.ReportDBDataSetTableAdapters.ReportBarcodeComfixTableAdapter
End Class
