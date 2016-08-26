<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuditReportPrintFrm
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
        Me.AuditDataSet1 = New ServiceTicker.AuditDataSet1()
        Me.auditBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.auditTableAdapter = New ServiceTicker.AuditDataSet1TableAdapters.auditTableAdapter()
        CType(Me.AuditDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.auditBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "AuditDataSet"
        ReportDataSource1.Value = Me.auditBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ServiceTicker.AuditReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(784, 561)
        Me.ReportViewer1.TabIndex = 0
        '
        'AuditDataSet1
        '
        Me.AuditDataSet1.DataSetName = "AuditDataSet1"
        Me.AuditDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'auditBindingSource
        '
        Me.auditBindingSource.DataMember = "audit"
        Me.auditBindingSource.DataSource = Me.AuditDataSet1
        '
        'auditTableAdapter
        '
        Me.auditTableAdapter.ClearBeforeFill = True
        '
        'AuditReportPrintFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "AuditReportPrintFrm"
        Me.Text = "พิมพ์รายงานตรวจสอบบัญชี (Audit) A4"
        CType(Me.AuditDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.auditBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents auditBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AuditDataSet1 As ServiceTicker.AuditDataSet1
    Friend WithEvents auditTableAdapter As ServiceTicker.AuditDataSet1TableAdapters.auditTableAdapter
End Class
