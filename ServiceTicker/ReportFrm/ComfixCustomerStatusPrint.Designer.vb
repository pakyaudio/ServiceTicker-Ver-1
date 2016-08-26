<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComfixCustomerStatusPrint
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
        Me.comfixcustomerstatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportDBDataSet = New ServiceTicker.ReportDBDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.comfixcustomerstatusTableAdapter = New ServiceTicker.ReportDBDataSetTableAdapters.comfixcustomerstatusTableAdapter()
        CType(Me.comfixcustomerstatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'comfixcustomerstatusBindingSource
        '
        Me.comfixcustomerstatusBindingSource.DataMember = "comfixcustomerstatus"
        Me.comfixcustomerstatusBindingSource.DataSource = Me.ReportDBDataSet
        '
        'ReportDBDataSet
        '
        Me.ReportDBDataSet.DataSetName = "ReportDBDataSet"
        Me.ReportDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "ComfixStatusComfix"
        ReportDataSource1.Value = Me.comfixcustomerstatusBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ServiceTicker.ComfixCustomerStatusComfix.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(784, 561)
        Me.ReportViewer1.TabIndex = 0
        '
        'comfixcustomerstatusTableAdapter
        '
        Me.comfixcustomerstatusTableAdapter.ClearBeforeFill = True
        '
        'ComfixCustomerStatusPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ComfixCustomerStatusPrint"
        Me.Text = "พิมพ์สถิติงานซ่อม"
        CType(Me.comfixcustomerstatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents comfixcustomerstatusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportDBDataSet As ServiceTicker.ReportDBDataSet
    Friend WithEvents comfixcustomerstatusTableAdapter As ServiceTicker.ReportDBDataSetTableAdapters.comfixcustomerstatusTableAdapter
End Class
