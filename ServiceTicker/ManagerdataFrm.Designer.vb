<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerdataFrm
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
        Me.lblProductNameNote = New System.Windows.Forms.Label()
        Me.dgmdataName = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.managerdata = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.txtmdataName = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblemployee = New System.Windows.Forms.Label()
        CType(Me.dgmdataName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProductNameNote
        '
        Me.lblProductNameNote.AutoSize = True
        Me.lblProductNameNote.ForeColor = System.Drawing.Color.Red
        Me.lblProductNameNote.Location = New System.Drawing.Point(13, 75)
        Me.lblProductNameNote.Name = "lblProductNameNote"
        Me.lblProductNameNote.Size = New System.Drawing.Size(202, 13)
        Me.lblProductNameNote.TabIndex = 23
        Me.lblProductNameNote.Text = "คลิ๊กเลือกหน้าตารางเพื่อแก้ไขหรือลบข้อมูล"
        '
        'dgmdataName
        '
        Me.dgmdataName.AllowUserToAddRows = False
        Me.dgmdataName.AllowUserToDeleteRows = False
        Me.dgmdataName.AllowUserToOrderColumns = True
        Me.dgmdataName.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgmdataName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgmdataName.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.managerdata})
        Me.dgmdataName.Location = New System.Drawing.Point(11, 94)
        Me.dgmdataName.Name = "dgmdataName"
        Me.dgmdataName.ReadOnly = True
        Me.dgmdataName.RowHeadersVisible = False
        Me.dgmdataName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgmdataName.Size = New System.Drawing.Size(323, 283)
        Me.dgmdataName.TabIndex = 22
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ID.Width = 40
        '
        'managerdata
        '
        Me.managerdata.HeaderText = "การจัดการข้อมูล"
        Me.managerdata.Name = "managerdata"
        Me.managerdata.ReadOnly = True
        Me.managerdata.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.managerdata.Width = 260
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Location = New System.Drawing.Point(8, 43)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(61, 13)
        Me.lblProductName.TabIndex = 21
        Me.lblProductName.Text = "รายละเอียด"
        '
        'txtmdataName
        '
        Me.txtmdataName.Location = New System.Drawing.Point(75, 40)
        Me.txtmdataName.Name = "txtmdataName"
        Me.txtmdataName.Size = New System.Drawing.Size(259, 20)
        Me.txtmdataName.TabIndex = 20
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(259, 11)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "&ปิด"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(178, 11)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 23)
        Me.btnDel.TabIndex = 18
        Me.btnDel.Text = "&ลบ"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(96, 11)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 17
        Me.btnEdit.Text = "&แก้ไข"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(13, 11)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "&เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblemployee
        '
        Me.lblemployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(8, 380)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 24
        Me.lblemployee.Text = "User"
        '
        'ManagerdataFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 395)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.lblProductNameNote)
        Me.Controls.Add(Me.dgmdataName)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.txtmdataName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ManagerdataFrm"
        Me.Text = "การจัดการข้อมูล"
        CType(Me.dgmdataName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblProductNameNote As System.Windows.Forms.Label
    Friend WithEvents dgmdataName As System.Windows.Forms.DataGridView
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents txtmdataName As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents managerdata As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class
