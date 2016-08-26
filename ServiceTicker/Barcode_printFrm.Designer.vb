<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Barcode_printFrm
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
        Me.barcode_printBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BCPrintDataSet = New ServiceTicker.BCPrintDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.barcode_printTableAdapter = New ServiceTicker.BCPrintDataSetTableAdapters.barcode_printTableAdapter()
        CType(Me.barcode_printBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BCPrintDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barcode_printBindingSource
        '
        Me.barcode_printBindingSource.DataMember = "barcode_print"
        Me.barcode_printBindingSource.DataSource = Me.BCPrintDataSet
        '
        'BCPrintDataSet
        '
        Me.BCPrintDataSet.DataSetName = "BCPrintDataSet"
        Me.BCPrintDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "bcprintDataSet"
        ReportDataSource1.Value = Me.barcode_printBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ServiceTicker.Barcode_printReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(896, 572)
        Me.ReportViewer1.TabIndex = 0
        '
        'barcode_printTableAdapter
        '
        Me.barcode_printTableAdapter.ClearBeforeFill = True
        '
        'Barcode_printFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 572)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Barcode_printFrm"
        Me.Text = "Barcode_printFrm"
        CType(Me.barcode_printBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BCPrintDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents barcode_printBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BCPrintDataSet As ServiceTicker.BCPrintDataSet
    Friend WithEvents barcode_printTableAdapter As ServiceTicker.BCPrintDataSetTableAdapters.barcode_printTableAdapter
End Class
