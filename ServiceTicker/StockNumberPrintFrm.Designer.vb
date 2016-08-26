<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockNumberPrintFrm
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
        Me.stock_number_cacheBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockNumbeDataSet = New ServiceTicker.StockNumbeDataSet()
        Me.stock_number_cacheTableAdapter = New ServiceTicker.StockNumbeDataSetTableAdapters.stock_number_cacheTableAdapter()
        CType(Me.stock_number_cacheBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockNumbeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "StockNumberDataSet"
        ReportDataSource1.Value = Me.stock_number_cacheBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ServiceTicker.StockNumberReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(784, 561)
        Me.ReportViewer1.TabIndex = 0
        '
        'stock_number_cacheBindingSource
        '
        Me.stock_number_cacheBindingSource.DataMember = "stock_number_cache"
        Me.stock_number_cacheBindingSource.DataSource = Me.StockNumbeDataSet
        '
        'StockNumbeDataSet
        '
        Me.StockNumbeDataSet.DataSetName = "StockNumbeDataSet"
        Me.StockNumbeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'stock_number_cacheTableAdapter
        '
        Me.stock_number_cacheTableAdapter.ClearBeforeFill = True
        '
        'StockNumberPrintFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "StockNumberPrintFrm"
        Me.Text = "พิมพ์ยอดจำนวนสต็อก A4"
        CType(Me.stock_number_cacheBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockNumbeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents stock_number_cacheBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StockNumbeDataSet As ServiceTicker.StockNumbeDataSet
    Friend WithEvents stock_number_cacheTableAdapter As ServiceTicker.StockNumbeDataSetTableAdapters.stock_number_cacheTableAdapter
End Class
