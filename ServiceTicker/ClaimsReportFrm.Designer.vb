﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClaimsReportFrm
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
        Me.txtCSsearch = New System.Windows.Forms.TextBox()
        Me.ToolTipCS = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCSsearch = New System.Windows.Forms.Button()
        Me.dgCS = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.claims_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.symptom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tel_to_cus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datetime_save = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.note2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.note = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCSshowAll = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.btnCRsearchbydate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbbCRstatus = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblemployee = New System.Windows.Forms.Label()
        CType(Me.dgCS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCSsearch
        '
        Me.txtCSsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCSsearch.Location = New System.Drawing.Point(52, 12)
        Me.txtCSsearch.Name = "txtCSsearch"
        Me.txtCSsearch.Size = New System.Drawing.Size(142, 21)
        Me.txtCSsearch.TabIndex = 0
        Me.ToolTipCS.SetToolTip(Me.txtCSsearch, "ค้นหาจาก ชื่อสินค้าหรือ SN")
        '
        'ToolTipCS
        '
        Me.ToolTipCS.IsBalloon = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(679, 39)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(93, 21)
        Me.btnPrint.TabIndex = 13
        Me.btnPrint.Text = "พิมพ์"
        Me.ToolTipCS.SetToolTip(Me.btnPrint, "พิมพ์รายงานการเคลม")
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ค้นหา"
        '
        'btnCSsearch
        '
        Me.btnCSsearch.Location = New System.Drawing.Point(200, 13)
        Me.btnCSsearch.Name = "btnCSsearch"
        Me.btnCSsearch.Size = New System.Drawing.Size(47, 21)
        Me.btnCSsearch.TabIndex = 2
        Me.btnCSsearch.Text = "ค้นหา"
        Me.btnCSsearch.UseVisualStyleBackColor = True
        '
        'dgCS
        '
        Me.dgCS.AllowUserToAddRows = False
        Me.dgCS.AllowUserToDeleteRows = False
        Me.dgCS.AllowUserToOrderColumns = True
        Me.dgCS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCS.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgCS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.claims_id, Me.customer_id, Me.customer_name, Me.SN, Me.name_pro, Me.symptom, Me.status, Me.tel_to_cus, Me.datetime_save, Me.note2, Me.note})
        Me.dgCS.Location = New System.Drawing.Point(12, 66)
        Me.dgCS.Name = "dgCS"
        Me.dgCS.ReadOnly = True
        Me.dgCS.RowHeadersVisible = False
        Me.dgCS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCS.Size = New System.Drawing.Size(760, 483)
        Me.dgCS.TabIndex = 5
        '
        'No
        '
        Me.No.HeaderText = "No."
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        Me.No.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.No.ToolTipText = "ลำดับ"
        Me.No.Width = 30
        '
        'claims_id
        '
        Me.claims_id.HeaderText = "หมายเลขเคลม"
        Me.claims_id.Name = "claims_id"
        Me.claims_id.ReadOnly = True
        Me.claims_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.claims_id.ToolTipText = "หมายเลขเคลม"
        Me.claims_id.Width = 130
        '
        'customer_id
        '
        Me.customer_id.HeaderText = "รหัสลูกค้า"
        Me.customer_id.Name = "customer_id"
        Me.customer_id.ReadOnly = True
        '
        'customer_name
        '
        Me.customer_name.HeaderText = "ชื่อลูกค้า"
        Me.customer_name.Name = "customer_name"
        Me.customer_name.ReadOnly = True
        Me.customer_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.customer_name.ToolTipText = "ชื่อลูกค้า"
        '
        'SN
        '
        Me.SN.HeaderText = "SN"
        Me.SN.Name = "SN"
        Me.SN.ReadOnly = True
        Me.SN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SN.ToolTipText = "Serial Number"
        '
        'name_pro
        '
        Me.name_pro.HeaderText = "ชื่อสินค้า"
        Me.name_pro.Name = "name_pro"
        Me.name_pro.ReadOnly = True
        Me.name_pro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.name_pro.ToolTipText = "ชื่อสินค้า"
        Me.name_pro.Width = 150
        '
        'symptom
        '
        Me.symptom.HeaderText = "อาการเสีย"
        Me.symptom.Name = "symptom"
        Me.symptom.ReadOnly = True
        Me.symptom.ToolTipText = "อาการเสีย"
        Me.symptom.Width = 120
        '
        'status
        '
        Me.status.HeaderText = "สถานะ"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.status.ToolTipText = "สถานะ"
        Me.status.Width = 80
        '
        'tel_to_cus
        '
        Me.tel_to_cus.HeaderText = "โทรแจ้ง"
        Me.tel_to_cus.Name = "tel_to_cus"
        Me.tel_to_cus.ReadOnly = True
        Me.tel_to_cus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.tel_to_cus.ToolTipText = "การโทรแจ้งลูกค้า"
        Me.tel_to_cus.Width = 80
        '
        'datetime_save
        '
        Me.datetime_save.HeaderText = "วันที่นำเข้าระบบ"
        Me.datetime_save.Name = "datetime_save"
        Me.datetime_save.ReadOnly = True
        Me.datetime_save.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.datetime_save.ToolTipText = "วันที่นำเข้าระบบ"
        Me.datetime_save.Width = 130
        '
        'note2
        '
        Me.note2.HeaderText = "ส่งไป"
        Me.note2.Name = "note2"
        Me.note2.ReadOnly = True
        '
        'note
        '
        Me.note.HeaderText = "หมายเหตุ"
        Me.note.Name = "note"
        Me.note.ReadOnly = True
        Me.note.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.note.ToolTipText = "หมายเหตุ"
        Me.note.Width = 80
        '
        'btnCSshowAll
        '
        Me.btnCSshowAll.Location = New System.Drawing.Point(253, 13)
        Me.btnCSshowAll.Name = "btnCSshowAll"
        Me.btnCSshowAll.Size = New System.Drawing.Size(99, 21)
        Me.btnCSshowAll.TabIndex = 6
        Me.btnCSshowAll.Text = "แสดงทั้งหมด"
        Me.btnCSshowAll.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(52, 40)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(283, 39)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 9
        '
        'btnCRsearchbydate
        '
        Me.btnCRsearchbydate.Location = New System.Drawing.Point(489, 38)
        Me.btnCRsearchbydate.Name = "btnCRsearchbydate"
        Me.btnCRsearchbydate.Size = New System.Drawing.Size(47, 21)
        Me.btnCRsearchbydate.TabIndex = 10
        Me.btnCRsearchbydate.Text = "ค้นหา"
        Me.btnCRsearchbydate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(258, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "ถึง"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "ระหว่าง"
        '
        'cbbCRstatus
        '
        Me.cbbCRstatus.FormattingEnabled = True
        Me.cbbCRstatus.Location = New System.Drawing.Point(586, 9)
        Me.cbbCRstatus.Name = "cbbCRstatus"
        Me.cbbCRstatus.Size = New System.Drawing.Size(186, 21)
        Me.cbbCRstatus.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(523, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "ตามสถานะ"
        '
        'lblemployee
        '
        Me.lblemployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblemployee.AutoSize = True
        Me.lblemployee.Location = New System.Drawing.Point(539, 43)
        Me.lblemployee.Name = "lblemployee"
        Me.lblemployee.Size = New System.Drawing.Size(29, 13)
        Me.lblemployee.TabIndex = 16
        Me.lblemployee.Text = "User"
        '
        'ClaimsReportFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.lblemployee)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbbCRstatus)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCRsearchbydate)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnCSshowAll)
        Me.Controls.Add(Me.dgCS)
        Me.Controls.Add(Me.btnCSsearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCSsearch)
        Me.Name = "ClaimsReportFrm"
        Me.Text = "รายงานการเคลม"
        CType(Me.dgCS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCSsearch As System.Windows.Forms.TextBox
    Friend WithEvents ToolTipCS As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCSsearch As System.Windows.Forms.Button
    Friend WithEvents dgCS As System.Windows.Forms.DataGridView
    Friend WithEvents btnCSshowAll As System.Windows.Forms.Button
    Friend WithEvents No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents claims_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents name_pro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents symptom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tel_to_cus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datetime_save As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents note2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents note As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCRsearchbydate As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents cbbCRstatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblemployee As System.Windows.Forms.Label
End Class