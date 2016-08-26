<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckedStockReportFrm
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
        Me.check_stock_cacheBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CheckedDataSet = New ServiceTicker.CheckedDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.check_stock_cacheTableAdapter = New ServiceTicker.CheckedDataSetTableAdapters.check_stock_cacheTableAdapter()
        CType(Me.check_stock_cacheBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckedDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'check_stock_cacheBindingSource
        '
        Me.check_stock_cacheBindingSource.DataMember = "check_stock_cache"
        Me.check_stock_cacheBindingSource.DataSource = Me.CheckedDataSet
        '
        'CheckedDataSet
        '
        Me.CheckedDataSet.DataSetName = "CheckedDataSet"
        Me.CheckedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.check_stock_cacheBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ServiceTicker.CheckedReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(784, 561)
        Me.ReportViewer1.TabIndex = 0
        '
        'check_stock_cacheTableAdapter
        '
        Me.check_stock_cacheTableAdapter.ClearBeforeFill = True
        '
        'CheckedStockReportFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "CheckedStockReportFrm"
        Me.Text = "พิมพ์รายงาน SN ที่ตรวจสอบแล้ว"
        CType(Me.check_stock_cacheBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckedDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents check_stock_cacheBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CheckedDataSet As ServiceTicker.CheckedDataSet
    Friend WithEvents check_stock_cacheTableAdapter As ServiceTicker.CheckedDataSetTableAdapters.check_stock_cacheTableAdapter
End Class
