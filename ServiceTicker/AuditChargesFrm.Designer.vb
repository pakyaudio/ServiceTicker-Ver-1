<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuditChargesFrm
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
        Me.dgAC = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namewiden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.list = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.money = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.note = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgAC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgAC
        '
        Me.dgAC.AllowUserToAddRows = False
        Me.dgAC.AllowUserToDeleteRows = False
        Me.dgAC.AllowUserToOrderColumns = True
        Me.dgAC.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgAC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.namewiden, Me.list, Me.money, Me.note})
        Me.dgAC.Location = New System.Drawing.Point(12, 12)
        Me.dgAC.Name = "dgAC"
        Me.dgAC.ReadOnly = True
        Me.dgAC.RowHeadersVisible = False
        Me.dgAC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgAC.Size = New System.Drawing.Size(574, 237)
        Me.dgAC.TabIndex = 0
        '
        'no
        '
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.Width = 30
        '
        'namewiden
        '
        Me.namewiden.HeaderText = "ชื่อผู้เบิก"
        Me.namewiden.Name = "namewiden"
        Me.namewiden.ReadOnly = True
        Me.namewiden.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.namewiden.ToolTipText = "ชื่อผู้เบิกเงิน"
        Me.namewiden.Width = 130
        '
        'list
        '
        Me.list.HeaderText = "ชื่อรายการ"
        Me.list.Name = "list"
        Me.list.ReadOnly = True
        Me.list.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.list.ToolTipText = "ชื่อรายการเบิก"
        Me.list.Width = 180
        '
        'money
        '
        Me.money.HeaderText = "จำนวน"
        Me.money.Name = "money"
        Me.money.ReadOnly = True
        Me.money.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.money.ToolTipText = "จำนวนเงินที่เบิก"
        '
        'note
        '
        Me.note.HeaderText = "หมายเหตุ"
        Me.note.Name = "note"
        Me.note.ReadOnly = True
        Me.note.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'AuditChargesFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 261)
        Me.Controls.Add(Me.dgAC)
        Me.Name = "AuditChargesFrm"
        Me.Text = "รายละเอียดรายการค่าใช้จ่าย"
        CType(Me.dgAC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgAC As System.Windows.Forms.DataGridView
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents namewiden As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents list As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents money As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents note As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
