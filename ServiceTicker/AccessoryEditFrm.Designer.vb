<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccessoryEditFrm
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
        Me.dgAccessory = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.accessory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblFixCom = New System.Windows.Forms.Label()
        Me.txtFixCom = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblemployee = New System.Windows.Forms.Label()
        CType(Me.dgAccessory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFixComNote
        '
        Me.lblFixComNote.AutoSize = True
        Me.lblFixComNote.ForeColor = System.Drawing.Color.Red
        Me.lblFixComNote.Location = New System.Drawing.Point(24, 72)
        Me.lblFixComNote.Name = "lblFixComNote"
        Me.lblFixComNote.Size = New System.Drawing.Size(182, 13)
        Me.lblFixComNote.TabIndex = 39
        Me.lblFixComNote.Text = "คลิ๊กเลือกตารางเพื่อแก้ไขหรือลบข้อมูล"
        '
        'dgAccessory
        '
        Me.dgAccessory.AllowUserToAddRows = False
        Me.dgAccessory.AllowUserToDeleteRows = False
        Me.dgAccessory.AllowUserToOrderColumns = True
        Me.dgAccessory.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgAccessory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAccessory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.accessory})
        Me.dgAccessory.Location = New System.Drawing.Point(12, 91)
        Me.dgAccessory.Name = "dgAccessory"
        Me.dgAccessory.ReadOnly = True
        Me.dgAccessory.RowHeadersVisible = False
        Me.dgAccessory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgAccessory.Size = New System.Drawing.Size(341, 283)
        Me.dgAccessory.TabIndex = 38
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ID.Width = 50
        '
        'accessory
        '
        Me.accessory.HeaderText = "รายชื่ออุปกรณ์"
        Me.accessory.Name = "accessory"
        Me.accessory.ReadOnly = True
        Me.accessory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.accessory.ToolTipText = "รายชื่ออุปกรณ์"
        Me.accessory.Width = 260
        '
        'lblFixCom
        '
        Me.lblFixCom.AutoSize = True
        Me.lblFixCom.Location = New System.Drawing.Point(9, 40)
        Me.lblFixCom.Name = "lblFixCom"
        Me.lblFixCom.Size = New System.Drawing.Size(55, 13)
        Me.lblFixCom.TabIndex = 37
        Me.lblFixCom.Text = "ชื่ออุปกรณ์"
        '
        'txtFixCom
        '
        Me.txtFixCom.Location = New System.Drawing.Point(69, 37)
        Me.txtFixCom.Name = "txtFixCom"
        Me.txtFixCom.Size = New System.Drawing.Size(276, 20)
        Me.txtFixCom.TabIndex = 36
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(270, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 35
        Me.btnCancel.Text = "&ปิด"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(189, 8)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 23)
        Me.btnDel.TabIndex = 34
        Me.btnDel.Text = "&ลบ"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(107, 8)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 33
        Me.btnEdit.Text = "&แก้ไข"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(24, 8)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 32
        Me.btnAdd.Text = "&เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblemployee
        '
        Me.lblemployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(19, 377)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 40
        Me.lblemployee.Text = "User"
        '
        'AccessoryEditFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 393)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.lblFixComNote)
        Me.Controls.Add(Me.dgAccessory)
        Me.Controls.Add(Me.lblFixCom)
        Me.Controls.Add(Me.txtFixCom)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AccessoryEditFrm"
        Me.Text = "แก้ไขรายการอุปกรณ์ที่นำมาด้วย"
        CType(Me.dgAccessory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFixComNote As System.Windows.Forms.Label
    Friend WithEvents dgAccessory As System.Windows.Forms.DataGridView
    Friend WithEvents lblFixCom As System.Windows.Forms.Label
    Friend WithEvents txtFixCom As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents accessory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class
