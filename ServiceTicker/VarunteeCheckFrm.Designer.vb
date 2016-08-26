<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VarunteeCheckFrm
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
        Me.ToolTipVC = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtVCsearch = New System.Windows.Forms.TextBox()
        Me.btnVCsearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgVC = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fix_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fixrepairnote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fixaccessory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.varuntee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_repair = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datecom_repair = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtVCdetail = New System.Windows.Forms.TextBox()
        Me.lblemployee = New System.Windows.Forms.Label()
        CType(Me.dgVC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolTipVC
        '
        Me.ToolTipVC.IsBalloon = True
        '
        'txtVCsearch
        '
        Me.txtVCsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVCsearch.Location = New System.Drawing.Point(12, 20)
        Me.txtVCsearch.Name = "txtVCsearch"
        Me.txtVCsearch.Size = New System.Drawing.Size(280, 22)
        Me.txtVCsearch.TabIndex = 0
        '
        'btnVCsearch
        '
        Me.btnVCsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVCsearch.Image = Global.ServiceTicker.My.Resources.Resources.search_icon
        Me.btnVCsearch.Location = New System.Drawing.Point(298, 18)
        Me.btnVCsearch.Name = "btnVCsearch"
        Me.btnVCsearch.Size = New System.Drawing.Size(33, 27)
        Me.btnVCsearch.TabIndex = 1
        Me.btnVCsearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ค้นหาจาก SN"
        '
        'dgVC
        '
        Me.dgVC.AllowUserToAddRows = False
        Me.dgVC.AllowUserToDeleteRows = False
        Me.dgVC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgVC.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgVC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.fix_id, Me.customer_id, Me.sn, Me.fixrepairnote, Me.fixaccessory, Me.varuntee, Me.status, Me.user_repair, Me.datecom_repair})
        Me.dgVC.Location = New System.Drawing.Point(12, 87)
        Me.dgVC.Name = "dgVC"
        Me.dgVC.ReadOnly = True
        Me.dgVC.RowHeadersVisible = False
        Me.dgVC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVC.Size = New System.Drawing.Size(983, 476)
        Me.dgVC.TabIndex = 3
        '
        'no
        '
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.no.Width = 30
        '
        'fix_id
        '
        Me.fix_id.HeaderText = "เลขที่ใบซ่อม"
        Me.fix_id.Name = "fix_id"
        Me.fix_id.ReadOnly = True
        Me.fix_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fix_id.Width = 120
        '
        'customer_id
        '
        Me.customer_id.HeaderText = "รหัสลูกค้า"
        Me.customer_id.Name = "customer_id"
        Me.customer_id.ReadOnly = True
        Me.customer_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'sn
        '
        Me.sn.HeaderText = "SN"
        Me.sn.Name = "sn"
        Me.sn.ReadOnly = True
        Me.sn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'fixrepairnote
        '
        Me.fixrepairnote.HeaderText = "การซ่อม"
        Me.fixrepairnote.Name = "fixrepairnote"
        Me.fixrepairnote.ReadOnly = True
        Me.fixrepairnote.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'fixaccessory
        '
        Me.fixaccessory.HeaderText = "อุปกรณ์ที่นำมาด้วย"
        Me.fixaccessory.Name = "fixaccessory"
        Me.fixaccessory.ReadOnly = True
        Me.fixaccessory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'varuntee
        '
        Me.varuntee.HeaderText = "ประกัน"
        Me.varuntee.Name = "varuntee"
        Me.varuntee.ReadOnly = True
        Me.varuntee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'status
        '
        Me.status.HeaderText = "สถานะ"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'user_repair
        '
        Me.user_repair.HeaderText = "ผู้ซ่อม"
        Me.user_repair.Name = "user_repair"
        Me.user_repair.ReadOnly = True
        Me.user_repair.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'datecom_repair
        '
        Me.datecom_repair.HeaderText = "วันที่ซ่อมเสร็จ"
        Me.datecom_repair.Name = "datecom_repair"
        Me.datecom_repair.ReadOnly = True
        Me.datecom_repair.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'txtVCdetail
        '
        Me.txtVCdetail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVCdetail.Enabled = False
        Me.txtVCdetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtVCdetail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtVCdetail.Location = New System.Drawing.Point(358, 5)
        Me.txtVCdetail.Multiline = True
        Me.txtVCdetail.Name = "txtVCdetail"
        Me.txtVCdetail.Size = New System.Drawing.Size(637, 67)
        Me.txtVCdetail.TabIndex = 5
        '
        'lblemployee
        '
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(13, 68)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 6
        Me.lblemployee.Text = "User"
        '
        'VarunteeCheckFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 576)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.txtVCdetail)
        Me.Controls.Add(Me.dgVC)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnVCsearch)
        Me.Controls.Add(Me.txtVCsearch)
        Me.Name = "VarunteeCheckFrm"
        Me.Text = "เช็คประกันงานซ่อม/เช็คประวัติงานซ่อม"
        CType(Me.dgVC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTipVC As System.Windows.Forms.ToolTip
    Friend WithEvents txtVCsearch As System.Windows.Forms.TextBox
    Friend WithEvents btnVCsearch As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgVC As System.Windows.Forms.DataGridView
    Friend WithEvents txtVCdetail As System.Windows.Forms.TextBox
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fix_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fixrepairnote As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fixaccessory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents varuntee As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents user_repair As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datecom_repair As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class
