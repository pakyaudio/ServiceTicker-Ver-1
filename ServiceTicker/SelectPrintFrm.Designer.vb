<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectPrintFrm
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
        Me.btnSPok = New System.Windows.Forms.Button()
        Me.rbSPha4 = New System.Windows.Forms.RadioButton()
        Me.rbSPa4 = New System.Windows.Forms.RadioButton()
        Me.btnSPcancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSPok
        '
        Me.btnSPok.Location = New System.Drawing.Point(223, 9)
        Me.btnSPok.Name = "btnSPok"
        Me.btnSPok.Size = New System.Drawing.Size(75, 23)
        Me.btnSPok.TabIndex = 0
        Me.btnSPok.Text = "ตกลง"
        Me.btnSPok.UseVisualStyleBackColor = True
        '
        'rbSPha4
        '
        Me.rbSPha4.AutoSize = True
        Me.rbSPha4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rbSPha4.Location = New System.Drawing.Point(12, 12)
        Me.rbSPha4.Name = "rbSPha4"
        Me.rbSPha4.Size = New System.Drawing.Size(88, 17)
        Me.rbSPha4.TabIndex = 1
        Me.rbSPha4.TabStop = True
        Me.rbSPha4.Text = "แบบครึ่งแผ่น"
        Me.rbSPha4.UseVisualStyleBackColor = True
        '
        'rbSPa4
        '
        Me.rbSPa4.AutoSize = True
        Me.rbSPa4.Checked = True
        Me.rbSPa4.Location = New System.Drawing.Point(106, 12)
        Me.rbSPa4.Name = "rbSPa4"
        Me.rbSPa4.Size = New System.Drawing.Size(111, 17)
        Me.rbSPa4.TabIndex = 2
        Me.rbSPa4.TabStop = True
        Me.rbSPa4.Text = "แบบเต็มแผ่น (A4)"
        Me.rbSPa4.UseVisualStyleBackColor = True
        '
        'btnSPcancel
        '
        Me.btnSPcancel.Location = New System.Drawing.Point(304, 9)
        Me.btnSPcancel.Name = "btnSPcancel"
        Me.btnSPcancel.Size = New System.Drawing.Size(75, 23)
        Me.btnSPcancel.TabIndex = 1
        Me.btnSPcancel.Text = "ยกเลิก"
        Me.btnSPcancel.UseVisualStyleBackColor = True
        '
        'SelectPrintFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Coral
        Me.ClientSize = New System.Drawing.Size(383, 42)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSPcancel)
        Me.Controls.Add(Me.rbSPa4)
        Me.Controls.Add(Me.rbSPha4)
        Me.Controls.Add(Me.btnSPok)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "SelectPrintFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกขนาดกระดาษ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSPok As System.Windows.Forms.Button
    Friend WithEvents rbSPha4 As System.Windows.Forms.RadioButton
    Friend WithEvents rbSPa4 As System.Windows.Forms.RadioButton
    Friend WithEvents btnSPcancel As System.Windows.Forms.Button
End Class
