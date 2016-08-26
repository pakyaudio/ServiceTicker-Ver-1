<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FixcomFrm
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
        Me.lblFixComNote = New System.Windows.Forms.Label()
        Me.dgFixCom = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fixcom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblFixCom = New System.Windows.Forms.Label()
        Me.txtFixCom = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblemployee = New System.Windows.Forms.Label()
        CType(Me.dgFixCom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFixComNote
        '
        Me.lblFixComNote.AutoSize = True
        Me.lblFixComNote.ForeColor = System.Drawing.Color.Red
        Me.lblFixComNote.Location = New System.Drawing.Point(14, 78)
        Me.lblFixComNote.Name = "lblFixComNote"
        Me.lblFixComNote.Size = New System.Drawing.Size(182, 13)
        Me.lblFixComNote.TabIndex = 31
        Me.lblFixComNote.Text = "คลิ๊กเลือกตารางเพื่อแก้ไขหรือลบข้อมูล"
        '
        'dgFixCom
        '
        Me.dgFixCom.AllowUserToAddRows = False
        Me.dgFixCom.AllowUserToDeleteRows = False
        Me.dgFixCom.AllowUserToOrderColumns = True
        Me.dgFixCom.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgFixCom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFixCom.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.fixcom})
        Me.dgFixCom.Location = New System.Drawing.Point(12, 97)
        Me.dgFixCom.Name = "dgFixCom"
        Me.dgFixCom.ReadOnly = True
        Me.dgFixCom.RowHeadersVisible = False
        Me.dgFixCom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgFixCom.Size = New System.Drawing.Size(323, 283)
        Me.dgFixCom.TabIndex = 30
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ID.Width = 40
        '
        'fixcom
        '
        Me.fixcom.HeaderText = "อาการเสีย"
        Me.fixcom.Name = "fixcom"
        Me.fixcom.ReadOnly = True
        Me.fixcom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fixcom.Width = 260
        '
        'lblFixCom
        '
        Me.lblFixCom.AutoSize = True
        Me.lblFixCom.Location = New System.Drawing.Point(-1, 46)
        Me.lblFixCom.Name = "lblFixCom"
        Me.lblFixCom.Size = New System.Drawing.Size(54, 13)
        Me.lblFixCom.TabIndex = 29
        Me.lblFixCom.Text = "อาการเสีย"
        '
        'txtFixCom
        '
        Me.txtFixCom.Location = New System.Drawing.Point(59, 43)
        Me.txtFixCom.Name = "txtFixCom"
        Me.txtFixCom.Size = New System.Drawing.Size(276, 20)
        Me.txtFixCom.TabIndex = 28
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(260, 14)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.Text = "&ปิด"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(179, 14)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 23)
        Me.btnDel.TabIndex = 26
        Me.btnDel.Text = "&ลบ"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(97, 14)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 25
        Me.btnEdit.Text = "&แก้ไข"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(14, 14)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 24
        Me.btnAdd.Text = "&เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblemployee
        '
        Me.lblemployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(9, 383)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 32
        Me.lblemployee.Text = "User"
        '
        'FixcomFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 403)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.lblFixComNote)
        Me.Controls.Add(Me.dgFixCom)
        Me.Controls.Add(Me.lblFixCom)
        Me.Controls.Add(Me.txtFixCom)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FixcomFrm"
        Me.Text = "ข้อมูลอาการเสีย"
        CType(Me.dgFixCom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFixComNote As System.Windows.Forms.Label
    Friend WithEvents dgFixCom As System.Windows.Forms.DataGridView
    Friend WithEvents lblFixCom As System.Windows.Forms.Label
    Friend WithEvents txtFixCom As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fixcom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class
