<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckStockPrintReportFrm
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
        Me.check_stockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CheckStockDataSet = New ServiceTicker.CheckStockDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.check_stockTableAdapter = New ServiceTicker.CheckStockDataSetTableAdapters.check_stockTableAdapter()
        CType(Me.check_stockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckStockDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'check_stockBindingSource
        '
        Me.check_stockBindingSource.DataMember = "check_stock"
        Me.check_stockBindingSource.DataSource = Me.CheckStockDataSet
        '
        'CheckStockDataSet
        '
        Me.CheckStockDataSet.DataSetName = "CheckStockDataSet"
        Me.CheckStockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.check_stockBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ServiceTicker.CheckStockReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(784, 561)
        Me.ReportViewer1.TabIndex = 0
        '
        'check_stockTableAdapter
        '
        Me.check_stockTableAdapter.ClearBeforeFill = True
        '
        'CheckStockPrintReportFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "CheckStockPrintReportFrm"
        Me.Text = "พิมพ์ SN ที่ยังไม่ได้ตรวจสอบ"
        CType(Me.check_stockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckStockDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents check_stockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CheckStockDataSet As ServiceTicker.CheckStockDataSet
    Friend WithEvents check_stockTableAdapter As ServiceTicker.CheckStockDataSetTableAdapters.check_stockTableAdapter
End Class
