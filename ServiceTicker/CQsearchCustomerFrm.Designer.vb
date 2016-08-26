<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CQsearchCustomerFrm
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
        Me.btnsearchShowAll = New System.Windows.Forms.Button()
        Me.btnSendtoSavedatafix = New System.Windows.Forms.Button()
        Me.txtSearchCusShowTel = New System.Windows.Forms.TextBox()
        Me.dgSearchCustoSaveFix = New System.Windows.Forms.DataGridView()
        Me.txtSearchCus = New System.Windows.Forms.TextBox()
        Me.btnsearchCusSearch = New System.Windows.Forms.Button()
        Me.ToolTipCQSC = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dgSearchCustoSaveFix, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnsearchShowAll
        '
        Me.btnsearchShowAll.Location = New System.Drawing.Point(464, 6)
        Me.btnsearchShowAll.Name = "btnsearchShowAll"
        Me.btnsearchShowAll.Size = New System.Drawing.Size(75, 23)
        Me.btnsearchShowAll.TabIndex = 17
        Me.btnsearchShowAll.Text = "แสดงทั้งหมด"
        Me.btnsearchShowAll.UseVisualStyleBackColor = True
        '
        'btnSendtoSavedatafix
        '
        Me.btnSendtoSavedatafix.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSendtoSavedatafix.ForeColor = System.Drawing.Color.Maroon
        Me.btnSendtoSavedatafix.Location = New System.Drawing.Point(12, 392)
        Me.btnSendtoSavedatafix.Name = "btnSendtoSavedatafix"
        Me.btnSendtoSavedatafix.Size = New System.Drawing.Size(527, 54)
        Me.btnSendtoSavedatafix.TabIndex = 16
        Me.btnSendtoSavedatafix.Text = "เลือกไปหน้าออกใบเสนอราคา"
        Me.btnSendtoSavedatafix.UseVisualStyleBackColor = True
        '
        'txtSearchCusShowTel
        '
        Me.txtSearchCusShowTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSearchCusShowTel.ForeColor = System.Drawing.Color.Red
        Me.txtSearchCusShowTel.Location = New System.Drawing.Point(12, 355)
        Me.txtSearchCusShowTel.Name = "txtSearchCusShowTel"
        Me.txtSearchCusShowTel.Size = New System.Drawing.Size(527, 31)
        Me.txtSearchCusShowTel.TabIndex = 15
        Me.txtSearchCusShowTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgSearchCustoSaveFix
        '
        Me.dgSearchCustoSaveFix.AllowUserToAddRows = False
        Me.dgSearchCustoSaveFix.AllowUserToDeleteRows = False
        Me.dgSearchCustoSaveFix.AllowUserToOrderColumns = True
        Me.dgSearchCustoSaveFix.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgSearchCustoSaveFix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSearchCustoSaveFix.Location = New System.Drawing.Point(12, 33)
        Me.dgSearchCustoSaveFix.Name = "dgSearchCustoSaveFix"
        Me.dgSearchCustoSaveFix.ReadOnly = True
        Me.dgSearchCustoSaveFix.RowHeadersVisible = False
        Me.dgSearchCustoSaveFix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSearchCustoSaveFix.Size = New System.Drawing.Size(527, 316)
        Me.dgSearchCustoSaveFix.TabIndex = 14
        '
        'txtSearchCus
        '
        Me.txtSearchCus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSearchCus.Location = New System.Drawing.Point(12, 6)
        Me.txtSearchCus.Name = "txtSearchCus"
        Me.txtSearchCus.Size = New System.Drawing.Size(365, 22)
        Me.txtSearchCus.TabIndex = 13
        Me.ToolTipCQSC.SetToolTip(Me.txtSearchCus, "พิมพ์คำค้นหา เช่น ชื่อ นามสกุล ที่อยู่ เบอร์โทรฯ")
        '
        'btnsearchCusSearch
        '
        Me.btnsearchCusSearch.Location = New System.Drawing.Point(383, 6)
        Me.btnsearchCusSearch.Name = "btnsearchCusSearch"
        Me.btnsearchCusSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnsearchCusSearch.TabIndex = 12
        Me.btnsearchCusSearch.Text = "ค้นหา"
        Me.btnsearchCusSearch.UseVisualStyleBackColor = True
        '
        'ToolTipCQSC
        '
        Me.ToolTipCQSC.IsBalloon = True
        '
        'CQsearchCustomerFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 455)
        Me.Controls.Add(Me.btnsearchShowAll)
        Me.Controls.Add(Me.btnSendtoSavedatafix)
        Me.Controls.Add(Me.txtSearchCusShowTel)
        Me.Controls.Add(Me.dgSearchCustoSaveFix)
        Me.Controls.Add(Me.txtSearchCus)
        Me.Controls.Add(Me.btnsearchCusSearch)
        Me.Name = "CQsearchCustomerFrm"
        Me.Text = "ค้นหาชื่อลูกค้า"
        CType(Me.dgSearchCustoSaveFix, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsearchShowAll As System.Windows.Forms.Button
    Friend WithEvents btnSendtoSavedatafix As System.Windows.Forms.Button
    Friend WithEvents txtSearchCusShowTel As System.Windows.Forms.TextBox
    Friend WithEvents dgSearchCustoSaveFix As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearchCus As System.Windows.Forms.TextBox
    Friend WithEvents ToolTipCQSC As System.Windows.Forms.ToolTip
    Friend WithEvents btnsearchCusSearch As System.Windows.Forms.Button
End Class
