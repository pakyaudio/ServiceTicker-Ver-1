﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuditSatitisPrintFrm
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
        Me.ReportDBDataSet = New ServiceTicker.ReportDBDataSet()
        Me.satitisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.satitisTableAdapter = New ServiceTicker.ReportDBDataSetTableAdapters.satitisTableAdapter()
        CType(Me.ReportDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.satitisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "SatitisDataSet"
        ReportDataSource1.Value = Me.satitisBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ServiceTicker.AuditSatitisByYear.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(784, 561)
        Me.ReportViewer1.TabIndex = 0
        '
        'ReportDBDataSet
        '
        Me.ReportDBDataSet.DataSetName = "ReportDBDataSet"
        Me.ReportDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'satitisBindingSource
        '
        Me.satitisBindingSource.DataMember = "satitis"
        Me.satitisBindingSource.DataSource = Me.ReportDBDataSet
        '
        'satitisTableAdapter
        '
        Me.satitisTableAdapter.ClearBeforeFill = True
        '
        'AuditSatitisPrintFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "AuditSatitisPrintFrm"
        Me.Text = "พิมพ์สถิติรายปี"
        CType(Me.ReportDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.satitisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents satitisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportDBDataSet As ServiceTicker.ReportDBDataSet
    Friend WithEvents satitisTableAdapter As ServiceTicker.ReportDBDataSetTableAdapters.satitisTableAdapter
End Class