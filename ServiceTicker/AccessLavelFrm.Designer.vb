<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccessLavelFrm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgAL = New System.Windows.Forms.DataGridView()
        Me.btnALsave = New System.Windows.Forms.Button()
        Me.lblemployee = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.access = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.zone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.link = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.save = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.datetime_edit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgAL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgAL
        '
        Me.dgAL.AllowUserToAddRows = False
        Me.dgAL.AllowUserToDeleteRows = False
        Me.dgAL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgAL.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgAL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAL.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.access, Me.zone, Me.user, Me.link, Me.save, Me.datetime_edit})
        Me.dgAL.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgAL.Location = New System.Drawing.Point(12, 12)
        Me.dgAL.Name = "dgAL"
        Me.dgAL.RowHeadersVisible = False
        Me.dgAL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgAL.Size = New System.Drawing.Size(760, 473)
        Me.dgAL.TabIndex = 0
        '
        'btnALsave
        '
        Me.btnALsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnALsave.Location = New System.Drawing.Point(671, 491)
        Me.btnALsave.Name = "btnALsave"
        Me.btnALsave.Size = New System.Drawing.Size(101, 23)
        Me.btnALsave.TabIndex = 1
        Me.btnALsave.Text = "บันทึกทั้งหมด"
        Me.btnALsave.UseVisualStyleBackColor = True
        '
        'lblemployee
        '
        Me.lblemployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(12, 501)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 2
        Me.lblemployee.Text = "User"
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.id.Width = 30
        '
        'access
        '
        Me.access.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.access.HeaderText = "ล็อกอิน"
        Me.access.Items.AddRange(New Object() {"ใช่", "ไม่ใช่"})
        Me.access.Name = "access"
        Me.access.ToolTipText = "ต้องล็อกอินก่อนเข้าใช้งานเมนู หรือไม่"
        Me.access.Width = 80
        '
        'zone
        '
        Me.zone.HeaderText = "เมนู"
        Me.zone.Name = "zone"
        Me.zone.ReadOnly = True
        Me.zone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.zone.ToolTipText = "ชื่อเมนู"
        Me.zone.Width = 120
        '
        'user
        '
        Me.user.HeaderText = "สิทธิ"
        Me.user.Items.AddRange(New Object() {"ผู้ใช้งาน", "หัวหน้า", "ผู้ดูแลระบบ"})
        Me.user.Name = "user"
        Me.user.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.user.ToolTipText = "สิทธิการใช้งาน"
        '
        'link
        '
        Me.link.HeaderText = "เมนู"
        Me.link.Name = "link"
        Me.link.ReadOnly = True
        Me.link.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.link.ToolTipText = "เมนูหลัก >> เมนูย่อย"
        Me.link.Width = 200
        '
        'save
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.save.DefaultCellStyle = DataGridViewCellStyle1
        Me.save.HeaderText = "บันทึก"
        Me.save.Name = "save"
        Me.save.ReadOnly = True
        Me.save.Text = "บันทึก"
        Me.save.ToolTipText = "บันทึกข้อมูลเฉพาะบรรทัด"
        Me.save.UseColumnTextForButtonValue = True
        Me.save.Width = 50
        '
        'datetime_edit
        '
        Me.datetime_edit.HeaderText = "วันที่แก้ไขล่าสุด"
        Me.datetime_edit.Name = "datetime_edit"
        Me.datetime_edit.ReadOnly = True
        Me.datetime_edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.datetime_edit.Width = 120
        '
        'AccessLavelFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 517)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.btnALsave)
        Me.Controls.Add(Me.dgAL)
        Me.Name = "AccessLavelFrm"
        Me.Text = "กำหนดสิทธิ"
        CType(Me.dgAL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgAL As System.Windows.Forms.DataGridView
    Friend WithEvents btnALsave As System.Windows.Forms.Button
    Friend WithEvents lblemployee As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents access As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents zone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents user As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents link As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents save As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents datetime_edit As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
