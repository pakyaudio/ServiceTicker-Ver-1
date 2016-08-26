<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreditCardManagFrm
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
        Me.dgCCMcredit = New System.Windows.Forms.DataGridView()
        Me.credit_card = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCCMcredit = New System.Windows.Forms.TextBox()
        Me.btnCCMcreditAdd = New System.Windows.Forms.Button()
        Me.btnCCMcreditDel = New System.Windows.Forms.Button()
        Me.btnCCMcreditEdit = New System.Windows.Forms.Button()
        Me.btnCCMcreditCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgCCMbank = New System.Windows.Forms.DataGridView()
        Me.bank_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCCMBbank = New System.Windows.Forms.TextBox()
        Me.btnCCMbankCancel = New System.Windows.Forms.Button()
        Me.btnCCMbankAdd = New System.Windows.Forms.Button()
        Me.btnCCMbankEdit = New System.Windows.Forms.Button()
        Me.btnCCMbankDel = New System.Windows.Forms.Button()
        Me.lblemployee = New System.Windows.Forms.Label()
        CType(Me.dgCCMcredit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgCCMbank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgCCMcredit
        '
        Me.dgCCMcredit.AllowUserToAddRows = False
        Me.dgCCMcredit.AllowUserToDeleteRows = False
        Me.dgCCMcredit.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgCCMcredit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCCMcredit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.credit_card})
        Me.dgCCMcredit.Location = New System.Drawing.Point(6, 82)
        Me.dgCCMcredit.Name = "dgCCMcredit"
        Me.dgCCMcredit.ReadOnly = True
        Me.dgCCMcredit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCCMcredit.Size = New System.Drawing.Size(212, 300)
        Me.dgCCMcredit.TabIndex = 0
        '
        'credit_card
        '
        Me.credit_card.HeaderText = "บัตรเครดิต"
        Me.credit_card.Name = "credit_card"
        Me.credit_card.ReadOnly = True
        Me.credit_card.Width = 150
        '
        'txtCCMcredit
        '
        Me.txtCCMcredit.Location = New System.Drawing.Point(35, 56)
        Me.txtCCMcredit.Name = "txtCCMcredit"
        Me.txtCCMcredit.Size = New System.Drawing.Size(183, 20)
        Me.txtCCMcredit.TabIndex = 1
        '
        'btnCCMcreditAdd
        '
        Me.btnCCMcreditAdd.Location = New System.Drawing.Point(9, 27)
        Me.btnCCMcreditAdd.Name = "btnCCMcreditAdd"
        Me.btnCCMcreditAdd.Size = New System.Drawing.Size(46, 23)
        Me.btnCCMcreditAdd.TabIndex = 2
        Me.btnCCMcreditAdd.Text = "เพิ่ม"
        Me.btnCCMcreditAdd.UseVisualStyleBackColor = True
        '
        'btnCCMcreditDel
        '
        Me.btnCCMcreditDel.Location = New System.Drawing.Point(113, 27)
        Me.btnCCMcreditDel.Name = "btnCCMcreditDel"
        Me.btnCCMcreditDel.Size = New System.Drawing.Size(46, 23)
        Me.btnCCMcreditDel.TabIndex = 3
        Me.btnCCMcreditDel.Text = "ลบ"
        Me.btnCCMcreditDel.UseVisualStyleBackColor = True
        '
        'btnCCMcreditEdit
        '
        Me.btnCCMcreditEdit.Location = New System.Drawing.Point(61, 27)
        Me.btnCCMcreditEdit.Name = "btnCCMcreditEdit"
        Me.btnCCMcreditEdit.Size = New System.Drawing.Size(46, 23)
        Me.btnCCMcreditEdit.TabIndex = 4
        Me.btnCCMcreditEdit.Text = "แก้ไข"
        Me.btnCCMcreditEdit.UseVisualStyleBackColor = True
        '
        'btnCCMcreditCancel
        '
        Me.btnCCMcreditCancel.Location = New System.Drawing.Point(165, 27)
        Me.btnCCMcreditCancel.Name = "btnCCMcreditCancel"
        Me.btnCCMcreditCancel.Size = New System.Drawing.Size(53, 23)
        Me.btnCCMcreditCancel.TabIndex = 5
        Me.btnCCMcreditCancel.Text = "ยกเลิก"
        Me.btnCCMcreditCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ชื่อ"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgCCMcredit)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCCMcredit)
        Me.GroupBox1.Controls.Add(Me.btnCCMcreditDel)
        Me.GroupBox1.Controls.Add(Me.btnCCMcreditCancel)
        Me.GroupBox1.Controls.Add(Me.btnCCMcreditAdd)
        Me.GroupBox1.Controls.Add(Me.btnCCMcreditEdit)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 393)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ชื่อบัตรเครดิต"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgCCMbank)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtCCMBbank)
        Me.GroupBox2.Controls.Add(Me.btnCCMbankCancel)
        Me.GroupBox2.Controls.Add(Me.btnCCMbankAdd)
        Me.GroupBox2.Controls.Add(Me.btnCCMbankEdit)
        Me.GroupBox2.Controls.Add(Me.btnCCMbankDel)
        Me.GroupBox2.Location = New System.Drawing.Point(243, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(225, 393)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ชื่อธนาคาร"
        '
        'dgCCMbank
        '
        Me.dgCCMbank.AllowUserToAddRows = False
        Me.dgCCMbank.AllowUserToDeleteRows = False
        Me.dgCCMbank.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgCCMbank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCCMbank.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bank_name})
        Me.dgCCMbank.Location = New System.Drawing.Point(6, 82)
        Me.dgCCMbank.Name = "dgCCMbank"
        Me.dgCCMbank.ReadOnly = True
        Me.dgCCMbank.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCCMbank.Size = New System.Drawing.Size(212, 300)
        Me.dgCCMbank.TabIndex = 0
        '
        'bank_name
        '
        Me.bank_name.HeaderText = "ชื่อธนาคาร"
        Me.bank_name.Name = "bank_name"
        Me.bank_name.ReadOnly = True
        Me.bank_name.Width = 150
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ชื่อ"
        '
        'txtCCMBbank
        '
        Me.txtCCMBbank.Location = New System.Drawing.Point(35, 56)
        Me.txtCCMBbank.Name = "txtCCMBbank"
        Me.txtCCMBbank.Size = New System.Drawing.Size(183, 20)
        Me.txtCCMBbank.TabIndex = 1
        '
        'btnCCMbankCancel
        '
        Me.btnCCMbankCancel.Location = New System.Drawing.Point(165, 27)
        Me.btnCCMbankCancel.Name = "btnCCMbankCancel"
        Me.btnCCMbankCancel.Size = New System.Drawing.Size(53, 23)
        Me.btnCCMbankCancel.TabIndex = 5
        Me.btnCCMbankCancel.Text = "ยกเลิก"
        Me.btnCCMbankCancel.UseVisualStyleBackColor = True
        '
        'btnCCMbankAdd
        '
        Me.btnCCMbankAdd.Location = New System.Drawing.Point(9, 27)
        Me.btnCCMbankAdd.Name = "btnCCMbankAdd"
        Me.btnCCMbankAdd.Size = New System.Drawing.Size(46, 23)
        Me.btnCCMbankAdd.TabIndex = 2
        Me.btnCCMbankAdd.Text = "เพิ่ม"
        Me.btnCCMbankAdd.UseVisualStyleBackColor = True
        '
        'btnCCMbankEdit
        '
        Me.btnCCMbankEdit.Location = New System.Drawing.Point(61, 27)
        Me.btnCCMbankEdit.Name = "btnCCMbankEdit"
        Me.btnCCMbankEdit.Size = New System.Drawing.Size(46, 23)
        Me.btnCCMbankEdit.TabIndex = 4
        Me.btnCCMbankEdit.Text = "แก้ไข"
        Me.btnCCMbankEdit.UseVisualStyleBackColor = True
        '
        'btnCCMbankDel
        '
        Me.btnCCMbankDel.Location = New System.Drawing.Point(113, 27)
        Me.btnCCMbankDel.Name = "btnCCMbankDel"
        Me.btnCCMbankDel.Size = New System.Drawing.Size(46, 23)
        Me.btnCCMbankDel.TabIndex = 3
        Me.btnCCMbankDel.Text = "ลบ"
        Me.btnCCMbankDel.UseVisualStyleBackColor = True
        '
        'lblemployee
        '
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(12, 408)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 9
        Me.lblemployee.Text = "User"
        '
        'CreditCardManagFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 425)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "CreditCardManagFrm"
        Me.Text = "จัดการบัตรเครดิต"
        CType(Me.dgCCMcredit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgCCMbank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgCCMcredit As System.Windows.Forms.DataGridView
    Friend WithEvents txtCCMcredit As System.Windows.Forms.TextBox
    Friend WithEvents btnCCMcreditAdd As System.Windows.Forms.Button
    Friend WithEvents btnCCMcreditDel As System.Windows.Forms.Button
    Friend WithEvents btnCCMcreditEdit As System.Windows.Forms.Button
    Friend WithEvents btnCCMcreditCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgCCMbank As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCCMBbank As System.Windows.Forms.TextBox
    Friend WithEvents btnCCMbankCancel As System.Windows.Forms.Button
    Friend WithEvents btnCCMbankAdd As System.Windows.Forms.Button
    Friend WithEvents btnCCMbankEdit As System.Windows.Forms.Button
    Friend WithEvents btnCCMbankDel As System.Windows.Forms.Button
    Friend WithEvents lblemployee As System.Windows.Forms.Label
    Friend WithEvents credit_card As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bank_name As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
