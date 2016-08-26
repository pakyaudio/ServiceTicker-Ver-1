<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockNumberSNPrintFrm
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
        Me.StockNumberSNDataSet = New ServiceTicker.StockNumberSNDataSet()
        Me.stock_number_sn_cacheBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.stock_number_sn_cacheTableAdapter = New ServiceTicker.StockNumberSNDataSetTableAdapters.stock_number_sn_cacheTableAdapter()
        CType(Me.StockNumberSNDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stock_number_sn_cacheBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "StockNumberSNDataSet"
        ReportDataSource1.Value = Me.stock_number_sn_cacheBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ServiceTicker.StockNumberSNReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(784, 561)
        Me.ReportViewer1.TabIndex = 0
        '
        'StockNumberSNDataSet
        '
        Me.StockNumberSNDataSet.DataSetName = "StockNumberSNDataSet"
        Me.StockNumberSNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'stock_number_sn_cacheBindingSource
        '
        Me.stock_number_sn_cacheBindingSource.DataMember = "stock_number_sn_cache"
        Me.stock_number_sn_cacheBindingSource.DataSource = Me.StockNumberSNDataSet
        '
        'stock_number_sn_cacheTableAdapter
        '
        Me.stock_number_sn_cacheTableAdapter.ClearBeforeFill = True
        '
        'StockNumberSNPrintFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "StockNumberSNPrintFrm"
        Me.Text = "พิมพ์รายละเอียด SN A4"
        CType(Me.StockNumberSNDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stock_number_sn_cacheBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents stock_number_sn_cacheBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StockNumberSNDataSet As ServiceTicker.StockNumberSNDataSet
    Friend WithEvents stock_number_sn_cacheTableAdapter As ServiceTicker.StockNumberSNDataSetTableAdapters.stock_number_sn_cacheTableAdapter
End Class
