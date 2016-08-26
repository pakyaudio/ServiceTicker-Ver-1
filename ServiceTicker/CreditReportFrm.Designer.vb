<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreditReportFrm
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
        Me.pledge_saleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CreditDataSet = New ServiceTicker.CreditDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.pledge_saleTableAdapter = New ServiceTicker.CreditDataSetTableAdapters.pledge_saleTableAdapter()
        CType(Me.pledge_saleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pledge_saleBindingSource
        '
        Me.pledge_saleBindingSource.DataMember = "pledge_sale"
        Me.pledge_saleBindingSource.DataSource = Me.CreditDataSet
        '
        'CreditDataSet
        '
        Me.CreditDataSet.DataSetName = "CreditDataSet"
        Me.CreditDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "CreditDataSet"
        ReportDataSource1.Value = Me.pledge_saleBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ServiceTicker.CreditReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(784, 561)
        Me.ReportViewer1.TabIndex = 0
        '
        'pledge_saleTableAdapter
        '
        Me.pledge_saleTableAdapter.ClearBeforeFill = True
        '
        'CreditReportFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "CreditReportFrm"
        Me.Text = "พิมพ์ใบลดหนี้/มัดจำ (Credit)"
        Me.TopMost = True
        CType(Me.pledge_saleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents pledge_saleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CreditDataSet As ServiceTicker.CreditDataSet
    Friend WithEvents pledge_saleTableAdapter As ServiceTicker.CreditDataSetTableAdapters.pledge_saleTableAdapter
End Class
