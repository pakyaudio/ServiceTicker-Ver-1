<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PercenFrm
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
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.txtPCProfit = New System.Windows.Forms.TextBox()
        Me.ToolTipPersen = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtPCtt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRURperfit = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRURtotal = New System.Windows.Forms.TextBox()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(138, 50)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(65, 20)
        Me.NumericUpDown1.TabIndex = 1
        Me.ToolTipPersen.SetToolTip(Me.NumericUpDown1, "ค่าเปอร์เซ็นต์")
        '
        'txtPCProfit
        '
        Me.txtPCProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPCProfit.Location = New System.Drawing.Point(12, 47)
        Me.txtPCProfit.Name = "txtPCProfit"
        Me.txtPCProfit.Size = New System.Drawing.Size(100, 26)
        Me.txtPCProfit.TabIndex = 2
        Me.ToolTipPersen.SetToolTip(Me.txtPCProfit, "ค่ากำไรที่นำมาจากหน้ารายงาน")
        '
        'ToolTipPersen
        '
        Me.ToolTipPersen.IsBalloon = True
        '
        'txtPCtt
        '
        Me.txtPCtt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPCtt.Location = New System.Drawing.Point(246, 47)
        Me.txtPCtt.Name = "txtPCtt"
        Me.txtPCtt.ReadOnly = True
        Me.txtPCtt.Size = New System.Drawing.Size(100, 26)
        Me.txtPCtt.TabIndex = 3
        Me.ToolTipPersen.SetToolTip(Me.txtPCtt, "ผลลัพธ์")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(118, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "X"
        Me.ToolTipPersen.SetToolTip(Me.Label1, "คูณ")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(227, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "="
        Me.ToolTipPersen.SetToolTip(Me.Label2, "เท่ากับ")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "-----------------------------"
        Me.ToolTipPersen.SetToolTip(Me.Label3, "หาร")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "100"
        Me.ToolTipPersen.SetToolTip(Me.Label4, "100 น่ะสิ")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(206, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "%"
        '
        'txtRURperfit
        '
        Me.txtRURperfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRURperfit.Location = New System.Drawing.Point(246, 3)
        Me.txtRURperfit.Name = "txtRURperfit"
        Me.txtRURperfit.ReadOnly = True
        Me.txtRURperfit.Size = New System.Drawing.Size(100, 26)
        Me.txtRURperfit.TabIndex = 9
        Me.ToolTipPersen.SetToolTip(Me.txtRURperfit, "ค่ากำไรที่นำมาจากหน้ารายงาน")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(336, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "-"
        Me.ToolTipPersen.SetToolTip(Me.Label6, "ลบ")
        '
        'txtRURtotal
        '
        Me.txtRURtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtRURtotal.Location = New System.Drawing.Point(246, 89)
        Me.txtRURtotal.Name = "txtRURtotal"
        Me.txtRURtotal.ReadOnly = True
        Me.txtRURtotal.Size = New System.Drawing.Size(100, 26)
        Me.txtRURtotal.TabIndex = 11
        Me.ToolTipPersen.SetToolTip(Me.txtRURtotal, "ยอดที่หักเปอร์เซ็นต์ออกแล้ว")
        '
        'PercenFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 147)
        Me.Controls.Add(Me.txtRURtotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtRURperfit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPCtt)
        Me.Controls.Add(Me.txtPCProfit)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PercenFrm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "ตัดเปอร์เซ็นต์กำไร"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents ToolTipPersen As System.Windows.Forms.ToolTip
    Friend WithEvents txtPCProfit As System.Windows.Forms.TextBox
    Friend WithEvents txtPCtt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRURperfit As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRURtotal As System.Windows.Forms.TextBox
End Class
