<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuditDetailFrm
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
        Me.dgAD = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.money1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.money2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.money5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.money10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.money20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.money50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.money100 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.money500 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.money1000 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.check = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.transfer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cash = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.charges = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deliverMorning = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deliverNoon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deliverEvening = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalDeliver = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.difference = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgAD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgAD
        '
        Me.dgAD.AllowUserToAddRows = False
        Me.dgAD.AllowUserToDeleteRows = False
        Me.dgAD.AllowUserToOrderColumns = True
        Me.dgAD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgAD.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgAD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAD.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.datetime, Me.money1, Me.money2, Me.money5, Me.money10, Me.money20, Me.money50, Me.money100, Me.money500, Me.money1000, Me.total, Me.check, Me.transfer, Me.cash, Me.charges, Me.deliverMorning, Me.deliverNoon, Me.deliverEvening, Me.totalDeliver, Me.difference})
        Me.dgAD.Location = New System.Drawing.Point(12, 12)
        Me.dgAD.MultiSelect = False
        Me.dgAD.Name = "dgAD"
        Me.dgAD.ReadOnly = True
        Me.dgAD.RowHeadersVisible = False
        Me.dgAD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgAD.Size = New System.Drawing.Size(760, 135)
        Me.dgAD.TabIndex = 0
        '
        'no
        '
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.no.Width = 30
        '
        'datetime
        '
        Me.datetime.HeaderText = "วันที่(ป/ด/ว)"
        Me.datetime.Name = "datetime"
        Me.datetime.ReadOnly = True
        Me.datetime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'money1
        '
        Me.money1.HeaderText = "1"
        Me.money1.Name = "money1"
        Me.money1.ReadOnly = True
        Me.money1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.money1.ToolTipText = "เหรียญบาท"
        Me.money1.Width = 30
        '
        'money2
        '
        Me.money2.HeaderText = "2"
        Me.money2.Name = "money2"
        Me.money2.ReadOnly = True
        Me.money2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.money2.ToolTipText = "เหรียญสองบาท"
        Me.money2.Width = 30
        '
        'money5
        '
        Me.money5.HeaderText = "5"
        Me.money5.Name = "money5"
        Me.money5.ReadOnly = True
        Me.money5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.money5.ToolTipText = "เหรียญห้าบาท"
        Me.money5.Width = 30
        '
        'money10
        '
        Me.money10.HeaderText = "10"
        Me.money10.Name = "money10"
        Me.money10.ReadOnly = True
        Me.money10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.money10.ToolTipText = "เหรียญสิบบาท"
        Me.money10.Width = 30
        '
        'money20
        '
        Me.money20.HeaderText = "20"
        Me.money20.Name = "money20"
        Me.money20.ReadOnly = True
        Me.money20.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.money20.ToolTipText = "แบ้งค์ยี่สิบบาท"
        Me.money20.Width = 30
        '
        'money50
        '
        Me.money50.HeaderText = "50"
        Me.money50.Name = "money50"
        Me.money50.ReadOnly = True
        Me.money50.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.money50.ToolTipText = "แบ้งค์ห้าสิบบาท"
        Me.money50.Width = 30
        '
        'money100
        '
        Me.money100.HeaderText = "100"
        Me.money100.Name = "money100"
        Me.money100.ReadOnly = True
        Me.money100.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.money100.ToolTipText = "แบ้งค์หนึ่งร้อยบาท"
        Me.money100.Width = 30
        '
        'money500
        '
        Me.money500.HeaderText = "500"
        Me.money500.Name = "money500"
        Me.money500.ReadOnly = True
        Me.money500.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.money500.ToolTipText = "แบ้งค์ห้าร้อยบาท"
        Me.money500.Width = 30
        '
        'money1000
        '
        Me.money1000.HeaderText = "1000"
        Me.money1000.Name = "money1000"
        Me.money1000.ReadOnly = True
        Me.money1000.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.money1000.ToolTipText = "แบ้งค์หนึ่งพันบาท"
        Me.money1000.Width = 50
        '
        'total
        '
        Me.total.HeaderText = "รวม"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.total.ToolTipText = "รวมเงินทอน"
        Me.total.Width = 40
        '
        'check
        '
        Me.check.HeaderText = "เช็ค"
        Me.check.Name = "check"
        Me.check.ReadOnly = True
        Me.check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.check.ToolTipText = "รายรับเป็นเช็ค"
        Me.check.Width = 50
        '
        'transfer
        '
        Me.transfer.HeaderText = "เงินโอน"
        Me.transfer.Name = "transfer"
        Me.transfer.ReadOnly = True
        Me.transfer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.transfer.ToolTipText = "รายรับเป็นเงินโอน"
        Me.transfer.Width = 50
        '
        'cash
        '
        Me.cash.HeaderText = "เงินสด"
        Me.cash.Name = "cash"
        Me.cash.ReadOnly = True
        Me.cash.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cash.ToolTipText = "รายรับเป็นเงินสด"
        Me.cash.Width = 50
        '
        'charges
        '
        Me.charges.HeaderText = "ค่าใช้จ่าย"
        Me.charges.Name = "charges"
        Me.charges.ReadOnly = True
        Me.charges.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.charges.ToolTipText = "ยอดรวมค่าใช้จ่ายในวัน"
        Me.charges.Width = 70
        '
        'deliverMorning
        '
        Me.deliverMorning.HeaderText = "นำส่งเช้า"
        Me.deliverMorning.Name = "deliverMorning"
        Me.deliverMorning.ReadOnly = True
        Me.deliverMorning.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.deliverMorning.ToolTipText = "เงินนำส่งเช้า"
        Me.deliverMorning.Width = 70
        '
        'deliverNoon
        '
        Me.deliverNoon.HeaderText = "นำส่งบ่าย"
        Me.deliverNoon.Name = "deliverNoon"
        Me.deliverNoon.ReadOnly = True
        Me.deliverNoon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.deliverNoon.ToolTipText = "เงินนำส่งบ่าย"
        Me.deliverNoon.Width = 70
        '
        'deliverEvening
        '
        Me.deliverEvening.HeaderText = "นำส่งเย็น"
        Me.deliverEvening.Name = "deliverEvening"
        Me.deliverEvening.ReadOnly = True
        Me.deliverEvening.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.deliverEvening.ToolTipText = "เงินนำส่งเย็น"
        Me.deliverEvening.Width = 70
        '
        'totalDeliver
        '
        Me.totalDeliver.HeaderText = "รวมนำส่ง"
        Me.totalDeliver.Name = "totalDeliver"
        Me.totalDeliver.ReadOnly = True
        Me.totalDeliver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.totalDeliver.ToolTipText = "รวมเงินนำส่ง"
        Me.totalDeliver.Width = 70
        '
        'difference
        '
        Me.difference.HeaderText = "ผลต่าง"
        Me.difference.Name = "difference"
        Me.difference.ReadOnly = True
        Me.difference.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.difference.Width = 50
        '
        'AuditDetailFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 159)
        Me.Controls.Add(Me.dgAD)
        Me.Name = "AuditDetailFrm"
        Me.Text = "รายละเอียดรายการตรวจสอบบัญชี"
        CType(Me.dgAD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgAD As System.Windows.Forms.DataGridView
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents money1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents money2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents money5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents money10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents money20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents money50 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents money100 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents money500 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents money1000 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents check As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents transfer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cash As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents charges As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents deliverMorning As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents deliverNoon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents deliverEvening As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totalDeliver As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents difference As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
