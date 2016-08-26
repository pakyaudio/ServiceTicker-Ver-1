<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReQotationNoPicReportPrintFrm
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
        Me.quotationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.REquDataSet = New ServiceTicker.REquDataSet()
        Me.quotationTableAdapter = New ServiceTicker.REquDataSetTableAdapters.quotationTableAdapter()
        CType(Me.quotationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REquDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "REQUDataSet"
        ReportDataSource1.Value = Me.quotationBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ServiceTicker.ReQuotationNoPicReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(784, 561)
        Me.ReportViewer1.TabIndex = 0
        '
        'quotationBindingSource
        '
        Me.quotationBindingSource.DataMember = "quotation"
        Me.quotationBindingSource.DataSource = Me.REquDataSet
        '
        'REquDataSet
        '
        Me.REquDataSet.DataSetName = "REquDataSet"
        Me.REquDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'quotationTableAdapter
        '
        Me.quotationTableAdapter.ClearBeforeFill = True
        '
        'ReQotationNoPicReportPrintFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ReQotationNoPicReportPrintFrm"
        Me.Text = "พิมพ์ใบเสนอราคาซ้ำ A4"
        CType(Me.quotationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REquDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents quotationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents REquDataSet As ServiceTicker.REquDataSet
    Friend WithEvents quotationTableAdapter As ServiceTicker.REquDataSetTableAdapters.quotationTableAdapter
End Class
