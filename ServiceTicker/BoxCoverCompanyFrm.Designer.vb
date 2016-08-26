<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BoxCoverCompanyFrm
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
        Me.dgCC = New System.Windows.Forms.DataGridView()
        Me.txtCCcom_id = New System.Windows.Forms.TextBox()
        Me.txtCCcom_name = New System.Windows.Forms.TextBox()
        Me.txtCCcom_address = New System.Windows.Forms.TextBox()
        Me.txtCCcom_contect = New System.Windows.Forms.TextBox()
        Me.btnCCcancel = New System.Windows.Forms.Button()
        Me.btnCCedit = New System.Windows.Forms.Button()
        Me.btnCCadd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCCsearch = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCCsearch = New System.Windows.Forms.Button()
        Me.btnCCdel = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCCtoclaimsSend = New System.Windows.Forms.Button()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.company_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.company_address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.company_address1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.company_address2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.company_zipcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.company_contect = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCCcom_address1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCCcom_address2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCCcom_zipcode = New System.Windows.Forms.TextBox()
        CType(Me.dgCC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgCC
        '
        Me.dgCC.AllowUserToAddRows = False
        Me.dgCC.AllowUserToDeleteRows = False
        Me.dgCC.AllowUserToOrderColumns = True
        Me.dgCC.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.company_name, Me.company_address, Me.company_address1, Me.company_address2, Me.company_zipcode, Me.company_contect})
        Me.dgCC.Location = New System.Drawing.Point(12, 12)
        Me.dgCC.Name = "dgCC"
        Me.dgCC.ReadOnly = True
        Me.dgCC.RowHeadersVisible = False
        Me.dgCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCC.Size = New System.Drawing.Size(610, 215)
        Me.dgCC.TabIndex = 10
        '
        'txtCCcom_id
        '
        Me.txtCCcom_id.Location = New System.Drawing.Point(224, 240)
        Me.txtCCcom_id.Name = "txtCCcom_id"
        Me.txtCCcom_id.ReadOnly = True
        Me.txtCCcom_id.Size = New System.Drawing.Size(100, 20)
        Me.txtCCcom_id.TabIndex = 2
        '
        'txtCCcom_name
        '
        Me.txtCCcom_name.Location = New System.Drawing.Point(87, 266)
        Me.txtCCcom_name.Name = "txtCCcom_name"
        Me.txtCCcom_name.Size = New System.Drawing.Size(237, 20)
        Me.txtCCcom_name.TabIndex = 3
        '
        'txtCCcom_address
        '
        Me.txtCCcom_address.Location = New System.Drawing.Point(87, 292)
        Me.txtCCcom_address.Name = "txtCCcom_address"
        Me.txtCCcom_address.Size = New System.Drawing.Size(237, 20)
        Me.txtCCcom_address.TabIndex = 4
        '
        'txtCCcom_contect
        '
        Me.txtCCcom_contect.Location = New System.Drawing.Point(231, 344)
        Me.txtCCcom_contect.Name = "txtCCcom_contect"
        Me.txtCCcom_contect.Size = New System.Drawing.Size(93, 20)
        Me.txtCCcom_contect.TabIndex = 5
        '
        'btnCCcancel
        '
        Me.btnCCcancel.Location = New System.Drawing.Point(249, 370)
        Me.btnCCcancel.Name = "btnCCcancel"
        Me.btnCCcancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCCcancel.TabIndex = 9
        Me.btnCCcancel.Text = "ยกเลิก"
        Me.btnCCcancel.UseVisualStyleBackColor = True
        '
        'btnCCedit
        '
        Me.btnCCedit.Location = New System.Drawing.Point(87, 370)
        Me.btnCCedit.Name = "btnCCedit"
        Me.btnCCedit.Size = New System.Drawing.Size(75, 23)
        Me.btnCCedit.TabIndex = 7
        Me.btnCCedit.Text = "แก้ไข"
        Me.btnCCedit.UseVisualStyleBackColor = True
        '
        'btnCCadd
        '
        Me.btnCCadd.Location = New System.Drawing.Point(6, 370)
        Me.btnCCadd.Name = "btnCCadd"
        Me.btnCCadd.Size = New System.Drawing.Size(75, 23)
        Me.btnCCadd.TabIndex = 6
        Me.btnCCadd.Text = "เพิ่ม"
        Me.btnCCadd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(200, 243)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 269)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ชื่อบริษัท"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 295)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "ที่อยู่บริษัท"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(190, 347)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "ติดต่อ"
        '
        'txtCCsearch
        '
        Me.txtCCsearch.Location = New System.Drawing.Point(369, 251)
        Me.txtCCsearch.Name = "txtCCsearch"
        Me.txtCCsearch.Size = New System.Drawing.Size(172, 20)
        Me.txtCCsearch.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(369, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "ค้นหา เช่น ชื่อ, ที่อยู่"
        '
        'btnCCsearch
        '
        Me.btnCCsearch.Location = New System.Drawing.Point(547, 249)
        Me.btnCCsearch.Name = "btnCCsearch"
        Me.btnCCsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnCCsearch.TabIndex = 1
        Me.btnCCsearch.Text = "ค้นหา"
        Me.btnCCsearch.UseVisualStyleBackColor = True
        '
        'btnCCdel
        '
        Me.btnCCdel.Location = New System.Drawing.Point(168, 370)
        Me.btnCCdel.Name = "btnCCdel"
        Me.btnCCdel.Size = New System.Drawing.Size(75, 23)
        Me.btnCCdel.TabIndex = 8
        Me.btnCCdel.Text = "ลบ"
        Me.btnCCdel.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(369, 362)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "*ชื่อที่อยู่ ใช้เป็นใบปะหน้ากล่องพัสดุ"
        '
        'btnCCtoclaimsSend
        '
        Me.btnCCtoclaimsSend.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCCtoclaimsSend.Location = New System.Drawing.Point(369, 303)
        Me.btnCCtoclaimsSend.Name = "btnCCtoclaimsSend"
        Me.btnCCtoclaimsSend.Size = New System.Drawing.Size(253, 46)
        Me.btnCCtoclaimsSend.TabIndex = 17
        Me.btnCCtoclaimsSend.Text = "เลือกไปหน้าส่งเคลมไปบริษัทรับเคลม"
        Me.btnCCtoclaimsSend.UseVisualStyleBackColor = True
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ID.Width = 30
        '
        'company_name
        '
        Me.company_name.HeaderText = "ชื่อบริษัท"
        Me.company_name.Name = "company_name"
        Me.company_name.ReadOnly = True
        Me.company_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.company_name.Width = 200
        '
        'company_address
        '
        Me.company_address.HeaderText = "ที่อยู่"
        Me.company_address.Name = "company_address"
        Me.company_address.ReadOnly = True
        Me.company_address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.company_address.Width = 150
        '
        'company_address1
        '
        Me.company_address1.HeaderText = "อำเภอ"
        Me.company_address1.Name = "company_address1"
        Me.company_address1.ReadOnly = True
        '
        'company_address2
        '
        Me.company_address2.HeaderText = "จังหวัด"
        Me.company_address2.Name = "company_address2"
        Me.company_address2.ReadOnly = True
        '
        'company_zipcode
        '
        Me.company_zipcode.HeaderText = "รหัสไปรษณีย์"
        Me.company_zipcode.Name = "company_zipcode"
        Me.company_zipcode.ReadOnly = True
        '
        'company_contect
        '
        Me.company_contect.HeaderText = "ติดต่อ"
        Me.company_contect.Name = "company_contect"
        Me.company_contect.ReadOnly = True
        Me.company_contect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.company_contect.Width = 150
        '
        'txtCCcom_address1
        '
        Me.txtCCcom_address1.Location = New System.Drawing.Point(87, 318)
        Me.txtCCcom_address1.Name = "txtCCcom_address1"
        Me.txtCCcom_address1.Size = New System.Drawing.Size(93, 20)
        Me.txtCCcom_address1.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 321)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "อำเภอ/เขต"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(186, 321)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "จังหวัด"
        '
        'txtCCcom_address2
        '
        Me.txtCCcom_address2.Location = New System.Drawing.Point(230, 318)
        Me.txtCCcom_address2.Name = "txtCCcom_address2"
        Me.txtCCcom_address2.Size = New System.Drawing.Size(94, 20)
        Me.txtCCcom_address2.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 347)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "รหัสไปรษณีย์"
        '
        'txtCCcom_zipcode
        '
        Me.txtCCcom_zipcode.Location = New System.Drawing.Point(87, 344)
        Me.txtCCcom_zipcode.Name = "txtCCcom_zipcode"
        Me.txtCCcom_zipcode.Size = New System.Drawing.Size(94, 20)
        Me.txtCCcom_zipcode.TabIndex = 23
        '
        'BoxCoverCompanyFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 404)
        Me.Controls.Add(Me.txtCCcom_zipcode)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCCcom_address2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCCcom_address1)
        Me.Controls.Add(Me.btnCCtoclaimsSend)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnCCdel)
        Me.Controls.Add(Me.btnCCsearch)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCCsearch)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCCadd)
        Me.Controls.Add(Me.btnCCedit)
        Me.Controls.Add(Me.btnCCcancel)
        Me.Controls.Add(Me.txtCCcom_contect)
        Me.Controls.Add(Me.txtCCcom_address)
        Me.Controls.Add(Me.txtCCcom_name)
        Me.Controls.Add(Me.txtCCcom_id)
        Me.Controls.Add(Me.dgCC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "BoxCoverCompanyFrm"
        Me.Text = "รายชื่อบริษัทที่ส่งเคลมสินค้า"
        CType(Me.dgCC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgCC As System.Windows.Forms.DataGridView
    Friend WithEvents txtCCcom_id As System.Windows.Forms.TextBox
    Friend WithEvents txtCCcom_name As System.Windows.Forms.TextBox
    Friend WithEvents txtCCcom_address As System.Windows.Forms.TextBox
    Friend WithEvents txtCCcom_contect As System.Windows.Forms.TextBox
    Friend WithEvents btnCCcancel As System.Windows.Forms.Button
    Friend WithEvents btnCCedit As System.Windows.Forms.Button
    Friend WithEvents btnCCadd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCCsearch As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCCsearch As System.Windows.Forms.Button
    Friend WithEvents btnCCdel As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnCCtoclaimsSend As System.Windows.Forms.Button
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents company_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents company_address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents company_address1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents company_address2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents company_zipcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents company_contect As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCCcom_address1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCCcom_address2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCCcom_zipcode As System.Windows.Forms.TextBox
End Class
