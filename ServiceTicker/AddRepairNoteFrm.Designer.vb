<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRepairNoteFrm
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
        Me.dgAddRepairNote = New System.Windows.Forms.DataGridView()
        Me.pbADD = New System.Windows.Forms.PictureBox()
        Me.PBcancel = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.repair_note = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgAddRepairNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbADD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBcancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgAddRepairNote
        '
        Me.dgAddRepairNote.AllowUserToAddRows = False
        Me.dgAddRepairNote.AllowUserToDeleteRows = False
        Me.dgAddRepairNote.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgAddRepairNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAddRepairNote.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.repair_note})
        Me.dgAddRepairNote.Location = New System.Drawing.Point(12, 12)
        Me.dgAddRepairNote.Name = "dgAddRepairNote"
        Me.dgAddRepairNote.ReadOnly = True
        Me.dgAddRepairNote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgAddRepairNote.Size = New System.Drawing.Size(379, 199)
        Me.dgAddRepairNote.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.dgAddRepairNote, "เลือกแล้วกดเพิ่ม")
        '
        'pbADD
        '
        Me.pbADD.Image = Global.ServiceTicker.My.Resources.Resources.images
        Me.pbADD.Location = New System.Drawing.Point(325, 217)
        Me.pbADD.Name = "pbADD"
        Me.pbADD.Size = New System.Drawing.Size(30, 30)
        Me.pbADD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbADD.TabIndex = 1
        Me.pbADD.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbADD, "เพิม")
        '
        'PBcancel
        '
        Me.PBcancel.Image = Global.ServiceTicker.My.Resources.Resources.imagesX
        Me.PBcancel.Location = New System.Drawing.Point(361, 217)
        Me.PBcancel.Name = "PBcancel"
        Me.PBcancel.Size = New System.Drawing.Size(30, 30)
        Me.PBcancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBcancel.TabIndex = 2
        Me.PBcancel.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PBcancel, "ปิด")
        '
        'repair_note
        '
        Me.repair_note.HeaderText = "รายละเอียดการซ่อมแซม"
        Me.repair_note.Name = "repair_note"
        Me.repair_note.ReadOnly = True
        Me.repair_note.Width = 300
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ข้อมูลการซ่อมถูกดึงจากรายการที่เคยบันทึกมาก่อนหน้านี้"
        '
        'AddRepairNoteFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 252)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PBcancel)
        Me.Controls.Add(Me.pbADD)
        Me.Controls.Add(Me.dgAddRepairNote)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AddRepairNoteFrm"
        Me.Text = "เพิ่มรายละเอียดการซ่อม"
        CType(Me.dgAddRepairNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbADD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBcancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgAddRepairNote As System.Windows.Forms.DataGridView
    Friend WithEvents pbADD As System.Windows.Forms.PictureBox
    Friend WithEvents PBcancel As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents repair_note As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
