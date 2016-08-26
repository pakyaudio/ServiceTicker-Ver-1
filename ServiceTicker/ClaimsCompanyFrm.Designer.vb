<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClaimsCompanyFrm
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
        Me.dgCC = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.company_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.company_address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.company_contect = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.lblCCwarninig = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblemployee = New System.Windows.Forms.Label()
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
        Me.dgCC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.company_name, Me.company_address, Me.company_contect})
        Me.dgCC.Location = New System.Drawing.Point(12, 12)
        Me.dgCC.Name = "dgCC"
        Me.dgCC.ReadOnly = True
        Me.dgCC.RowHeadersVisible = False
        Me.dgCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCC.Size = New System.Drawing.Size(635, 215)
        Me.dgCC.TabIndex = 10
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        'company_contect
        '
        Me.company_contect.HeaderText = "ติดต่อ"
        Me.company_contect.Name = "company_contect"
        Me.company_contect.ReadOnly = True
        Me.company_contect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.company_contect.Width = 150
        '
        'txtCCcom_id
        '
        Me.txtCCcom_id.Location = New System.Drawing.Point(547, 243)
        Me.txtCCcom_id.Name = "txtCCcom_id"
        Me.txtCCcom_id.ReadOnly = True
        Me.txtCCcom_id.Size = New System.Drawing.Size(100, 20)
        Me.txtCCcom_id.TabIndex = 2
        '
        'txtCCcom_name
        '
        Me.txtCCcom_name.Location = New System.Drawing.Point(410, 269)
        Me.txtCCcom_name.Name = "txtCCcom_name"
        Me.txtCCcom_name.Size = New System.Drawing.Size(237, 20)
        Me.txtCCcom_name.TabIndex = 3
        '
        'txtCCcom_address
        '
        Me.txtCCcom_address.Location = New System.Drawing.Point(410, 295)
        Me.txtCCcom_address.Name = "txtCCcom_address"
        Me.txtCCcom_address.Size = New System.Drawing.Size(237, 20)
        Me.txtCCcom_address.TabIndex = 4
        '
        'txtCCcom_contect
        '
        Me.txtCCcom_contect.Location = New System.Drawing.Point(410, 321)
        Me.txtCCcom_contect.Name = "txtCCcom_contect"
        Me.txtCCcom_contect.Size = New System.Drawing.Size(237, 20)
        Me.txtCCcom_contect.TabIndex = 5
        '
        'btnCCcancel
        '
        Me.btnCCcancel.Location = New System.Drawing.Point(572, 347)
        Me.btnCCcancel.Name = "btnCCcancel"
        Me.btnCCcancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCCcancel.TabIndex = 9
        Me.btnCCcancel.Text = "ยกเลิก"
        Me.btnCCcancel.UseVisualStyleBackColor = True
        '
        'btnCCedit
        '
        Me.btnCCedit.Location = New System.Drawing.Point(410, 347)
        Me.btnCCedit.Name = "btnCCedit"
        Me.btnCCedit.Size = New System.Drawing.Size(75, 23)
        Me.btnCCedit.TabIndex = 7
        Me.btnCCedit.Text = "แก้ไข"
        Me.btnCCedit.UseVisualStyleBackColor = True
        '
        'btnCCadd
        '
        Me.btnCCadd.Location = New System.Drawing.Point(329, 347)
        Me.btnCCadd.Name = "btnCCadd"
        Me.btnCCadd.Size = New System.Drawing.Size(75, 23)
        Me.btnCCadd.TabIndex = 6
        Me.btnCCadd.Text = "เพิ่ม"
        Me.btnCCadd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(523, 246)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(356, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ชื่อบริษัท"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(349, 298)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "ที่อยู่บริษัท"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(370, 324)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "ติดต่อ"
        '
        'txtCCsearch
        '
        Me.txtCCsearch.Location = New System.Drawing.Point(12, 246)
        Me.txtCCsearch.Name = "txtCCsearch"
        Me.txtCCsearch.Size = New System.Drawing.Size(172, 20)
        Me.txtCCsearch.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "ค้นหา เช่น ชื่อ, ที่อยู่"
        '
        'btnCCsearch
        '
        Me.btnCCsearch.Location = New System.Drawing.Point(190, 244)
        Me.btnCCsearch.Name = "btnCCsearch"
        Me.btnCCsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnCCsearch.TabIndex = 1
        Me.btnCCsearch.Text = "ค้นหา"
        Me.btnCCsearch.UseVisualStyleBackColor = True
        '
        'btnCCdel
        '
        Me.btnCCdel.Location = New System.Drawing.Point(491, 347)
        Me.btnCCdel.Name = "btnCCdel"
        Me.btnCCdel.Size = New System.Drawing.Size(75, 23)
        Me.btnCCdel.TabIndex = 8
        Me.btnCCdel.Text = "ลบ"
        Me.btnCCdel.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 347)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "*ชื่อที่อยู่ ใช้เป็นใบปะหน้ากล่องพัสดุ"
        '
        'btnCCtoclaimsSend
        '
        Me.btnCCtoclaimsSend.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCCtoclaimsSend.Location = New System.Drawing.Point(12, 298)
        Me.btnCCtoclaimsSend.Name = "btnCCtoclaimsSend"
        Me.btnCCtoclaimsSend.Size = New System.Drawing.Size(253, 46)
        Me.btnCCtoclaimsSend.TabIndex = 17
        Me.btnCCtoclaimsSend.Text = "เลือกไปหน้าส่งเคลมไปบริษัทรับเคลม"
        Me.btnCCtoclaimsSend.UseVisualStyleBackColor = True
        '
        'lblCCwarninig
        '
        Me.lblCCwarninig.AutoSize = True
        Me.lblCCwarninig.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCCwarninig.ForeColor = System.Drawing.Color.DarkRed
        Me.lblCCwarninig.Location = New System.Drawing.Point(50, 272)
        Me.lblCCwarninig.Name = "lblCCwarninig"
        Me.lblCCwarninig.Size = New System.Drawing.Size(215, 20)
        Me.lblCCwarninig.TabIndex = 18
        Me.lblCCwarninig.Text = "กรุณาเลือกบริษัทที่ต้องการส่งเคลม"
        Me.lblCCwarninig.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblemployee
        '
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(9, 361)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 19
        Me.lblemployee.Text = "User"
        '
        'ClaimsCompanyFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 383)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.lblCCwarninig)
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
        Me.Name = "ClaimsCompanyFrm"
        Me.Text = "รายชื่อบริษัทที่ส่งเคลมสินค้า"
        CType(Me.dgCC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgCC As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents company_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents company_address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents company_contect As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents lblCCwarninig As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class
