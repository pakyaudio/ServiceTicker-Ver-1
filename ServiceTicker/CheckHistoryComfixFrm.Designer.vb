<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckHistoryComfixFrm
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
        Me.dgSDFsearchfixbySN = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fix_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cus_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cus_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.symptom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.note_repair = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_send = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prolist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCHCsearchSN = New System.Windows.Forms.Button()
        Me.txtCHCsearchSN = New System.Windows.Forms.TextBox()
        Me.lblCHCsn = New System.Windows.Forms.Label()
        Me.btnCHCviewpro = New System.Windows.Forms.Button()
        Me.lblemployee = New System.Windows.Forms.Label()
        CType(Me.dgSDFsearchfixbySN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgSDFsearchfixbySN
        '
        Me.dgSDFsearchfixbySN.AllowUserToAddRows = False
        Me.dgSDFsearchfixbySN.AllowUserToDeleteRows = False
        Me.dgSDFsearchfixbySN.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgSDFsearchfixbySN.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgSDFsearchfixbySN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSDFsearchfixbySN.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.fix_id, Me.cus_name, Me.cus_id, Me.sn, Me.symptom, Me.note_repair, Me.date_save, Me.date_send, Me.prolist})
        Me.dgSDFsearchfixbySN.Location = New System.Drawing.Point(12, 37)
        Me.dgSDFsearchfixbySN.Name = "dgSDFsearchfixbySN"
        Me.dgSDFsearchfixbySN.ReadOnly = True
        Me.dgSDFsearchfixbySN.RowHeadersVisible = False
        Me.dgSDFsearchfixbySN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSDFsearchfixbySN.Size = New System.Drawing.Size(904, 249)
        Me.dgSDFsearchfixbySN.TabIndex = 3
        '
        'no
        '
        Me.no.DataPropertyName = "no"
        Me.no.Frozen = True
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.no.ToolTipText = "ลำดับ"
        Me.no.Width = 35
        '
        'fix_id
        '
        Me.fix_id.HeaderText = "เลขใบซ่อม"
        Me.fix_id.Name = "fix_id"
        Me.fix_id.ReadOnly = True
        '
        'cus_name
        '
        Me.cus_name.HeaderText = "ชื่อลูกค้า"
        Me.cus_name.Name = "cus_name"
        Me.cus_name.ReadOnly = True
        '
        'cus_id
        '
        Me.cus_id.HeaderText = "รหัสลูกค้า"
        Me.cus_id.Name = "cus_id"
        Me.cus_id.ReadOnly = True
        '
        'sn
        '
        Me.sn.HeaderText = "SN"
        Me.sn.Name = "sn"
        Me.sn.ReadOnly = True
        '
        'symptom
        '
        Me.symptom.DataPropertyName = "symptom"
        Me.symptom.HeaderText = "อาการเสีย"
        Me.symptom.Name = "symptom"
        Me.symptom.ReadOnly = True
        Me.symptom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.symptom.ToolTipText = "อาการเสีย"
        '
        'note_repair
        '
        Me.note_repair.DataPropertyName = "note_repair"
        Me.note_repair.HeaderText = "บันทึกการซ่อม"
        Me.note_repair.Name = "note_repair"
        Me.note_repair.ReadOnly = True
        Me.note_repair.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.note_repair.ToolTipText = "บันทึกการซ่อม"
        '
        'date_save
        '
        Me.date_save.DataPropertyName = "date_save"
        Me.date_save.HeaderText = "วันรับเครื่อง"
        Me.date_save.Name = "date_save"
        Me.date_save.ReadOnly = True
        Me.date_save.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.date_save.ToolTipText = "วันที่รับเครื่อง"
        Me.date_save.Width = 70
        '
        'date_send
        '
        Me.date_send.DataPropertyName = "date_send"
        Me.date_send.HeaderText = "วันส่งเครื่อง"
        Me.date_send.Name = "date_send"
        Me.date_send.ReadOnly = True
        Me.date_send.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.date_send.ToolTipText = "วันที่ส่งเครื่อง"
        Me.date_send.Width = 70
        '
        'prolist
        '
        Me.prolist.HeaderText = "รายการสินค้า"
        Me.prolist.Name = "prolist"
        Me.prolist.ReadOnly = True
        '
        'btnCHCsearchSN
        '
        Me.btnCHCsearchSN.Location = New System.Drawing.Point(291, 9)
        Me.btnCHCsearchSN.Name = "btnCHCsearchSN"
        Me.btnCHCsearchSN.Size = New System.Drawing.Size(43, 23)
        Me.btnCHCsearchSN.TabIndex = 1
        Me.btnCHCsearchSN.Text = "ค้นหา"
        Me.btnCHCsearchSN.UseVisualStyleBackColor = True
        '
        'txtCHCsearchSN
        '
        Me.txtCHCsearchSN.Location = New System.Drawing.Point(86, 11)
        Me.txtCHCsearchSN.Name = "txtCHCsearchSN"
        Me.txtCHCsearchSN.Size = New System.Drawing.Size(199, 20)
        Me.txtCHCsearchSN.TabIndex = 0
        '
        'lblCHCsn
        '
        Me.lblCHCsn.AutoSize = True
        Me.lblCHCsn.Location = New System.Drawing.Point(9, 14)
        Me.lblCHCsn.Name = "lblCHCsn"
        Me.lblCHCsn.Size = New System.Drawing.Size(74, 13)
        Me.lblCHCsn.TabIndex = 26
        Me.lblCHCsn.Text = "SN เครื่องซ่อม"
        '
        'btnCHCviewpro
        '
        Me.btnCHCviewpro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCHCviewpro.Enabled = False
        Me.btnCHCviewpro.Location = New System.Drawing.Point(774, 292)
        Me.btnCHCviewpro.Name = "btnCHCviewpro"
        Me.btnCHCviewpro.Size = New System.Drawing.Size(142, 23)
        Me.btnCHCviewpro.TabIndex = 4
        Me.btnCHCviewpro.Text = "ดูรายการสินค้า/อะไหล่"
        Me.btnCHCviewpro.UseVisualStyleBackColor = True
        '
        'lblemployee
        '
        Me.lblemployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(9, 302)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 27
        Me.lblemployee.Text = "User"
        '
        'CheckHistoryComfixFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 320)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.btnCHCviewpro)
        Me.Controls.Add(Me.lblCHCsn)
        Me.Controls.Add(Me.txtCHCsearchSN)
        Me.Controls.Add(Me.btnCHCsearchSN)
        Me.Controls.Add(Me.dgSDFsearchfixbySN)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "CheckHistoryComfixFrm"
        Me.Text = "เช็คประวัติงานซ่อมและเปลี่ยนอะไหล่"
        CType(Me.dgSDFsearchfixbySN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgSDFsearchfixbySN As System.Windows.Forms.DataGridView
    Friend WithEvents btnCHCsearchSN As System.Windows.Forms.Button
    Friend WithEvents txtCHCsearchSN As System.Windows.Forms.TextBox
    Friend WithEvents lblCHCsn As System.Windows.Forms.Label
    Friend WithEvents btnCHCviewpro As System.Windows.Forms.Button
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fix_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cus_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cus_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents symptom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents note_repair As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date_send As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prolist As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class
