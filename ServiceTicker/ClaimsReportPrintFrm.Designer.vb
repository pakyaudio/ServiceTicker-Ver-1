<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClaimsReportPrintFrm
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
        Me.claims_cacheBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClaimsGroupDataSet = New ServiceTicker.ClaimsGroupDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.claims_cacheTableAdapter = New ServiceTicker.ClaimsGroupDataSetTableAdapters.claims_cacheTableAdapter()
        CType(Me.claims_cacheBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClaimsGroupDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'claims_cacheBindingSource
        '
        Me.claims_cacheBindingSource.DataMember = "claims_cache"
        Me.claims_cacheBindingSource.DataSource = Me.ClaimsGroupDataSet
        '
        'ClaimsGroupDataSet
        '
        Me.ClaimsGroupDataSet.DataSetName = "ClaimsGroupDataSet"
        Me.ClaimsGroupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ClaimsGroupDataSet"
        ReportDataSource1.Value = Me.claims_cacheBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ServiceTicker.ClaimsGroupReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(784, 561)
        Me.ReportViewer1.TabIndex = 0
        '
        'claims_cacheTableAdapter
        '
        Me.claims_cacheTableAdapter.ClearBeforeFill = True
        '
        'ClaimsReportPrintFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ClaimsReportPrintFrm"
        Me.Text = "พิมพ์ใบรับเคลม A4"
        CType(Me.claims_cacheBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClaimsGroupDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents claims_cacheBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClaimsGroupDataSet As ServiceTicker.ClaimsGroupDataSet
    Friend WithEvents claims_cacheTableAdapter As ServiceTicker.ClaimsGroupDataSetTableAdapters.claims_cacheTableAdapter
End Class
