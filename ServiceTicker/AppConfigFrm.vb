Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.IO

Public Class AppConfigFrm

    Private Sub AppConfigFrm_Click(sender As Object, e As EventArgs) Handles Me.Click
        If QAppconfigFrm.WindowState = FormWindowState.Normal Then
            QAppconfigFrm.Close()
        End If
    End Sub

    Private Sub checkRegister()
        'สตาร์ทฐานข้อมูลตอนเปิดเครื่อง
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "startup", Nothing) = "0" Then
            If Me.cbACstartPro.CheckState = CheckState.Checked Then
                Me.cbACstartPro.CheckState = CheckState.Unchecked
            End If
        ElseIf My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "startup", Nothing) = "1" Then
            If Me.cbACstartPro.CheckState = CheckState.Unchecked Then
                Me.cbACstartPro.CheckState = CheckState.Checked
            End If
        End If
        'ยืนยันตัวตน
        'If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "verified", Nothing) = "0" Then
        '    If Me.cbACver.CheckState = CheckState.Checked Then
        '        Me.cbACver.CheckState = CheckState.Unchecked
        '    End If
        'ElseIf My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "verified", Nothing) = "1" Then
        '    If Me.cbACver.CheckState = CheckState.Unchecked Then
        '        Me.cbACver.CheckState = CheckState.Checked
        '    End If
        'End If
        'ปิด/เปิด แจ้งเตือนงานด่วน
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "importune", Nothing) = "0" Then
            If Me.cbACimp.CheckState = CheckState.Checked Then
                Me.cbACimp.CheckState = CheckState.Unchecked
            End If
        ElseIf My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "importune", Nothing) = "1" Then
            If Me.cbACimp.CheckState = CheckState.Unchecked Then
                Me.cbACimp.CheckState = CheckState.Checked
            End If
        End If
        'startMySQL ตอนเปิดโปรแกรม
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "startmysql", Nothing) = "0" Then
            Me.rbACserver.Checked = False
            Me.rbACclient.Checked = True
        ElseIf My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "startmysql", Nothing) = "1" Then
            Me.rbACserver.Checked = True
            Me.rbACclient.Checked = False
        End If
    End Sub

    Private Sub cbCheckSt()
        If MessageBox.Show("แน่ใจว่าจะเปลี่ยนแปลง รีจิสเตอร์สตาร์ทอัพ", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            If Me.cbACstartPro.CheckState = CheckState.Unchecked Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Run", "ServiceTicker", "")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\serviceticker", "startup", "0")
                Mainfrm.lblMainStatus.Text = "ลบค่า C:\ServiceTicker\Mysql\start.exe ออกจากรีจิสเตอร์สตาร์ทอัพแล้ว"
            ElseIf Me.cbACstartPro.CheckState = CheckState.Checked Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Run", "ServiceTicker", "C:\ServiceTicker\Mysql\start.exe")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\serviceticker", "startup", "1")
                Mainfrm.lblMainStatus.Text = "เพิ่มค่า C:\ServiceTicker\Mysql\start.exe ลงในรีจิสเตอร์สตาร์ทอัพแล้ว"
            End If
        Else
            'สตาร์ทฐานข้อมูลตอนเปิดเครื่อง
            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "startup", Nothing) = "0" Then
                If Me.cbACstartPro.CheckState = CheckState.Checked Then
                    Me.cbACstartPro.CheckState = CheckState.Unchecked
                End If
            ElseIf My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "startup", Nothing) = "1" Then
                If Me.cbACstartPro.CheckState = CheckState.Unchecked Then
                    Me.cbACstartPro.CheckState = CheckState.Checked
                End If
            End If
        End If
    End Sub
    'Private Sub cbCheckVerified()
    '    If MessageBox.Show("แน่ใจว่าจะเปลี่ยนแปลง การยืนยันตัวตน", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
    '        If Me.cbACver.CheckState = CheckState.Unchecked Then
    '            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\serviceticker", "verified", "0")
    '            Mainfrm.lblMainStatus.Text = "ปิดค่าการยืนยันตัวตนแล้ว"
    '        ElseIf Me.cbACver.CheckState = CheckState.Checked Then
    '            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\serviceticker", "verified", "1")
    '            Mainfrm.lblMainStatus.Text = "เปิดค่าการยืนยันตัวตนแล้ว"
    '        End If
    '    Else
    '        'ยืนยันตัวตน
    '        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "verified", Nothing) = "0" Then
    '            If Me.cbACver.CheckState = CheckState.Checked Then
    '                Me.cbACver.CheckState = CheckState.Unchecked
    '            End If
    '        ElseIf My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "verified", Nothing) = "1" Then
    '            If Me.cbACver.CheckState = CheckState.Unchecked Then
    '                Me.cbACver.CheckState = CheckState.Checked
    '            End If
    '        End If
    '    End If
    'End Sub

    Private Sub cbCheckImp()
        If MessageBox.Show("แน่ใจว่าจะเปลี่ยนแปลง สถานะเตือนมีการซ่อมด่วน", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            If Me.cbACimp.CheckState = CheckState.Unchecked Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\serviceticker", "importune", "0")
                Mainfrm.lblMainStatus.Text = "ปิดการแจ้งเตือนงานซ่อมด่วนแล้ว"
            ElseIf Me.cbACimp.CheckState = CheckState.Checked Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\serviceticker", "importune", "1")
                Mainfrm.lblMainStatus.Text = "เปิดการแจ้งเตือนงานซ่อมด่วนแล้ว"
            End If
        Else
            'ปิด/เปิด แจ้งเตือนงานด่วน
            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "importune", Nothing) = "0" Then
                If Me.cbACimp.CheckState = CheckState.Checked Then
                    Me.cbACimp.CheckState = CheckState.Unchecked
                End If
            ElseIf My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "importune", Nothing) = "1" Then
                If Me.cbACimp.CheckState = CheckState.Unchecked Then
                    Me.cbACimp.CheckState = CheckState.Checked
                End If
            End If
        End If
    End Sub

    Private Sub cbCheckServer()
        If MessageBox.Show("แน่ใจว่าจะเปลี่ยนแปลง สถานะโปรแกรม", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            If Me.rbACserver.Checked = False And Me.rbACclient.Checked = True Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\serviceticker", "startmysql", "0")
                Mainfrm.lblMainStatus.Text = "เปลี่ยนแปลง สถานะโปรแกรเป็นเครื่องลูกข่ายแล้ว"
                MsgBox("เปลี่ยนแปลง สถานะโปรแกรเป็นเครื่องลูกข่ายแล้ว มีผลตอนเริ่มระบบคอมพิวเตอร์ใหม่", MsgBoxStyle.Information, "แจ้งให้ทราบ")
            ElseIf Me.rbACserver.Checked = True And Me.rbACclient.Checked = False Then
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\serviceticker", "startmysql", "1")
                Mainfrm.lblMainStatus.Text = "เปลี่ยนแปลง สถานะโปรแกรเป็นเครื่องลูกแม่ข่าย"
                MsgBox("เปลี่ยนแปลง สถานะโปรแกรเป็นเครื่องลูกแม่ข่าย มีผลตอนเริ่มระบบคอมพิวเตอร์ใหม่", MsgBoxStyle.Information, "แจ้งให้ทราบ")
            End If
        Else
            'startMySQL ตอนเปิดโปรแกรม
            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "startmysql", Nothing) = "0" Then
                Me.rbACserver.Checked = False
                Me.rbACclient.Checked = True
            ElseIf My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "startmysql", Nothing) = "1" Then
                Me.rbACserver.Checked = True
                Me.rbACclient.Checked = False
            End If
        End If
    End Sub

    Private Sub AppConfigFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        Call loadDataBill()
        Call checkRegister()
        Call loadIcon()
    End Sub
    Private Sub loadIcon()
        Try
            Mainfrm.lblMainStatus.Text = "โหลดไอคอน"
            dt = New DataTable
            strSQL = "SELECT * FROM ver_detail"
            Using dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)
                Me.txtACloginImageSave.Text = dt.Rows(0).Item("ver_imglogin")
                Me.txtACappnameSave.Text = dt.Rows(0).Item("ver_company")
                Me.txtACtextlogin.Text = dt.Rows(0).Item("ver_version")
                Me.txtACfixID.Text = dt.Rows(0).Item("ver_fixid")
                Me.txtACcusID.Text = dt.Rows(0).Item("ver_cusid")
                Me.txtACproductID.Text = dt.Rows(0).Item("ver_productid")
                Me.txtACPartsWithdrawal.Text = dt.Rows(0).Item("ver_PartsWithdrawal")
                Me.txtACproductsectio.Text = dt.Rows(0).Item("ver_productsectio")
                Me.txtACbarcode.Text = dt.Rows(0).Item("ver_barcode")
                Me.txtACorderID.Text = dt.Rows(0).Item("ver_order")
                Me.txtACreceive.Text = dt.Rows(0).Item("ver_receive")
                Me.txtRNreturnsProduct.Text = dt.Rows(0).Item("ver_returns")
                Me.txtACdebtor.Text = dt.Rows(0).Item("ver_debtor")
                Me.txtACcash.Text = dt.Rows(0).Item("ver_cash")
                Me.txtACquotation.Text = dt.Rows(0).Item("ver_quotation")
                Me.txtACtaxinvoice.Text = dt.Rows(0).Item("ver_cashinvoice")
                Me.txtACclaims.Text = dt.Rows(0).Item("ver_claims")
            End Using
            Mainfrm.lblMainStatus.Text = "โหลดไอคอนแล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "โหลดไอคอนผิดพลาด " & ex.Message
        End Try
        Try
            strSQL = "SELECT ver_icon FROM ver_detail"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dim pictureData As Byte() = DirectCast(cmd.ExecuteScalar(), Byte())
            Dim stream As New IO.MemoryStream(pictureData)
            'Read the stream and create an Image object from the data.'
            stream.Write(pictureData, 0, pictureData.Length)
            Dim bitmap As New Bitmap(stream)
            PictureBox2.Image = bitmap
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "โหลดไอคอนผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub loadDataBill()
        strSQL = "SELECT footer1,footer2,footer3,com_sendrepairrow1,com_sendrepairrow2,com_sendrepairrow3,com_Invoice,com_quotation,com_billing,com_claims,com_qjob FROM company"
        cmd = New MySqlCommand(strSQL, ConnectionDB)
        Call open_connection()
        Dr = cmd.ExecuteReader()
        Dr.Read()
        Me.txtACTextFooter1.Text = Dr.GetString("footer1")
        Me.txtACTextFooter2.Text = Dr.GetString("footer2")
        Me.txtACTextFooter3.Text = Dr.GetString("footer3")
        Me.txtACSendRepairRow1.Text = Dr.GetString("com_sendrepairrow1")
        Me.txtACSendRepairRow2.Text = Dr.GetString("com_sendrepairrow2")
        Me.txtACSendRepairRow3.Text = Dr.GetString("com_sendrepairrow3")
        Me.txtACInvoice.Text = Dr.GetString("com_Invoice")
        Me.txtACtxtQuotation.Text = Dr.GetString("com_quotation")
        Me.txtACBilling.Text = Dr.GetString("com_billing")
        Me.txtACclaimsbill.Text = Dr.GetString("com_claims")
        Me.txtACqJob.Text = Dr.GetString("com_qjob")
    End Sub

    Private Sub UpdateDataBill()
        Try
            If MessageBox.Show("คุณแน่ใจว่าจะบันทึกข้อมูลนี้", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                strSQL = "UPDATE company SET footer1=@f1,footer2=@f2,footer3=@f3,com_sendrepairrow1=@cs1," _
                    & "com_sendrepairrow2=@cs2,com_sendrepairrow3=@cs3,com_Invoice=@ci,com_quotation=@cq," _
                    & "com_billing=@cb,com_claims=@cm,com_qjob=@qj"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                cmd.Parameters.AddWithValue("@f1", Me.txtACTextFooter1.Text)
                cmd.Parameters.AddWithValue("@f2", Me.txtACTextFooter2.Text)
                cmd.Parameters.AddWithValue("@f3", Me.txtACTextFooter3.Text)
                cmd.Parameters.AddWithValue("@cs1", Me.txtACSendRepairRow1.Text)
                cmd.Parameters.AddWithValue("@cs2", Me.txtACSendRepairRow2.Text)
                cmd.Parameters.AddWithValue("@cs3", Me.txtACSendRepairRow3.Text)
                cmd.Parameters.AddWithValue("@ci", Me.txtACInvoice.Text)
                cmd.Parameters.AddWithValue("@cq", Me.txtACtxtQuotation.Text)
                cmd.Parameters.AddWithValue("@cb", Me.txtACBilling.Text)
                cmd.Parameters.AddWithValue("@cm", Me.txtACclaimsbill.Text)
                cmd.Parameters.AddWithValue("@qj", Me.txtACqJob.Text)
                Call open_connection()
                Dim save As Integer
                save = cmd.ExecuteNonQuery()
                If save = 1 Then
                    Mainfrm.lblMainStatus.Text = "update ver_detail แล้ว"
                    MsgBox("บันทึกแล้ว", MsgBoxStyle.Information, "แสดงผลบันทึก")
                End If
                Call loadIcon()
                Call loadDataBill()
            Else
                Mainfrm.lblMainStatus.Text = "การบันทึกข้อความท้ายบิลถูกยกเลิก"
                Exit Sub
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "UPDATE company ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub btnACappIconSave_Click(sender As Object, e As EventArgs) Handles btnACappIconSave.Click
        Try
            If MessageBox.Show("คุณแน่ใจว่าจะบันทึกข้อมูลนี้", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                strSQL = "update ver_detail set ver_icon=@vi"
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Using picture As Image = PictureBox1.Image
                        Using stream As New IO.MemoryStream
                            picture.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg)
                            Dim arrImage() As Byte = stream.GetBuffer()
                            cmd.Parameters.AddWithValue("@vi", arrImage)
                        End Using
                    End Using
                    Call open_connection()
                    Dim save As Integer
                    save = cmd.ExecuteNonQuery()
                    If save = 1 Then
                        Mainfrm.lblMainStatus.Text = "update ver_detail แล้ว"
                        MsgBox("บันทึกแล้ว", MsgBoxStyle.Information, "แสดงผลบันทึก")
                    Else
                        Mainfrm.lblMainStatus.Text = "update ver_detail ผิดพลาด"
                        MsgBox("บันทึกข้อมูลไม่สำเร็จ", MsgBoxStyle.Information, "แสดงผลบันทึก")
                    End If
                End Using
            Else
                Mainfrm.lblMainStatus.Text = "การบันทึกถูกยกเลิก"
                Exit Sub
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "update ver_detail ผิดพลาด " & ex.Message
        End Try
        Call Mainfrm.loadIcon()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Mainfrm.lblMainStatus.Text = "Open File Dialog"
            Dim fpath As New OpenFileDialog
            'fpath.InitialDirectory = "C:\"
            fpath.Filter = "Icon Picture File|*.ico"
            fpath.FilterIndex = 1
            fpath.RestoreDirectory = True
            If fpath.ShowDialog = Windows.Forms.DialogResult.OK AndAlso fpath.FileName <> "" Then
                Mainfrm.lblMainStatus.Text = "Open File Dialog " & fpath.FileName
                PictureBox1.Image = System.Drawing.Image.FromFile(fpath.FileName)
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "Open File Dialog ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Mainfrm.lblMainStatus.Text = "Open File Dialog"
        Dim fpath As New OpenFileDialog
        fpath.InitialDirectory = "C:\"
        fpath.Filter = "Picture File|*.png;*.jpg;*.jpeg;*.gif"
        fpath.FilterIndex = 1
        fpath.RestoreDirectory = True
        If fpath.ShowDialog = Windows.Forms.DialogResult.OK AndAlso fpath.FileName <> "" Then
            Mainfrm.lblMainStatus.Text = "Open File Dialog " & fpath.FileName
            Me.txtACloginImageSave.Text = fpath.FileName
        End If
    End Sub

    Private Sub btnACloginImageSave_Click(sender As Object, e As EventArgs) Handles btnACloginImageSave.Click

        Try
            If MessageBox.Show("คุณแน่ใจว่าจะบันทึกข้อมูลนี้", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Mainfrm.lblMainStatus.Text = "update ver_detail"
                dt = New DataTable
                strSQL = "update ver_detail set ver_imglogin=@vil"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                cmd.Parameters.AddWithValue("@vil", Me.txtACloginImageSave.Text)
                Call open_connection()
                Dim save As Integer
                save = cmd.ExecuteNonQuery()
                If save = 1 Then
                    Mainfrm.lblMainStatus.Text = "update ver_detail set ver_imglogin"
                    MsgBox("บันทึกแล้ว", MsgBoxStyle.Information, "แสดงผลบันทึก")
                End If
            Else
                Mainfrm.lblMainStatus.Text = "การบันทึกถูกยกเลิก"
                Exit Sub
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "update ver_detail set ver_imglogin ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub btnACappnameSave_Click(sender As Object, e As EventArgs) Handles btnACappnameSave.Click
        Try
            If MessageBox.Show("คุณแน่ใจว่าจะบันทึกข้อมูลนี้", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Mainfrm.lblMainStatus.Text = "update ver_detail set ver_company"
                dt = New DataTable
                strSQL = "update ver_detail set ver_company=@vc"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                cmd.Parameters.AddWithValue("@vc", Me.txtACappnameSave.Text)
                Call open_connection()
                Dim save As Integer
                save = cmd.ExecuteNonQuery()
                If save = 1 Then
                    Mainfrm.lblMainStatus.Text = "update ver_detail set ver_company แล้ว"
                    MsgBox("บันทึกแล้ว", MsgBoxStyle.Information, "แสดงผลบันทึก")
                End If
            Else
                Mainfrm.lblMainStatus.Text = "การบันทึกถูกยกเลิก"
                Exit Sub
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "update ver_detail set ver_company ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub btnACtextlogin_Click(sender As Object, e As EventArgs) Handles btnACtextlogin.Click
        Try
            If MessageBox.Show("คุณแน่ใจว่าจะบันทึกข้อมูลนี้", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Mainfrm.lblMainStatus.Text = "update ver_detail set ver_version"
                dt = New DataTable
                strSQL = "update ver_detail set ver_version=@vv"
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                cmd.Parameters.AddWithValue("@vv", Me.txtACtextlogin.Text)
                Call open_connection()
                Dim save As Integer
                save = cmd.ExecuteNonQuery()
                If save = 1 Then
                    Mainfrm.lblMainStatus.Text = "update ver_detail set ver_version แล้ว"
                    MsgBox("บันทึกแล้ว", MsgBoxStyle.Information, "แสดงผลบันทึก")
                End If
            Else
                Mainfrm.lblMainStatus.Text = "การบันทึกถูกยกเลิก"
                Exit Sub
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "update ver_detail set ver_version ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub btnACdocumentNumSave_Click(sender As Object, e As EventArgs) Handles btnACdocumentNumSave.Click
        Try
            If MessageBox.Show("คุณแน่ใจว่าจะบันทึกข้อมูลนี้", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                Mainfrm.lblMainStatus.Text = "update ver_detail"
                dt = New DataTable
                strSQL = "update ver_detail set ver_fixid=@vf," _
                       & "ver_cusid=@vc," _
                       & "ver_productid=@vp," _
                       & "ver_PartsWithdrawal=@vpw," _
                       & "ver_productsectio=@vps," _
                       & "ver_barcode=@vbc," _
                       & "ver_order=@vo," _
                       & "ver_receive=@rp," _
                       & "ver_returns=@rtp," _
                       & "ver_debtor=@dt," _
                       & "ver_cash=@ci," _
                       & "ver_quotation=@vq," _
                       & "ver_cashinvoice=@cav," _
                       & "ver_claims=@claims"
                Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                    With cmd.Parameters
                        .AddWithValue("@vf", Me.txtACfixID.Text)
                        .AddWithValue("@vc", Me.txtACcusID.Text)
                        .AddWithValue("@vp", Me.txtACproductID.Text)
                        .AddWithValue("@vpw", Me.txtACPartsWithdrawal.Text)
                        .AddWithValue("@vps", Me.txtACproductsectio.Text)
                        .AddWithValue("@vbc", Me.txtACbarcode.Text)
                        .AddWithValue("@vo", Me.txtACorderID.Text)
                        .AddWithValue("@rp", Me.txtACreceive.Text)
                        .AddWithValue("@rtp", Me.txtRNreturnsProduct.Text)
                        .AddWithValue("@dt", Me.txtACdebtor.Text)
                        .AddWithValue("@ci", Me.txtACcash.Text)
                        .AddWithValue("@vq", Me.txtACquotation.Text)
                        .AddWithValue("@cav", Me.txtACtaxinvoice.Text)
                        .AddWithValue("@claims", Me.txtACclaims.Text)
                    End With
                    Call open_connection()
                    Dim save As Integer
                    save = cmd.ExecuteNonQuery()
                    If save = 1 Then
                        Mainfrm.lblMainStatus.Text = "update ver_detail แล้ว"
                        MsgBox("บันทึกแล้ว", MsgBoxStyle.Information, "แสดงผลบันทึก")
                    End If
                End Using
            Else
                Mainfrm.lblMainStatus.Text = "การบันทึกถูกยกเลิก"
                Exit Sub
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "update ver_detail ผิดพลาด " & ex.Message
        End Try

    End Sub

    Private Sub btnACupdateBilling_Click(sender As Object, e As EventArgs) Handles btnACupdateBilling.Click
        Call UpdateDataBill()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        QAppconfigFrm.MdiParent = Mainfrm
        QAppconfigFrm.Show()
    End Sub

    Private Sub cbACstartPro_Click(sender As Object, e As EventArgs) Handles cbACstartPro.Click
        Call cbCheckSt()
    End Sub

    Private Sub cbACimp_Click(sender As Object, e As EventArgs) Handles cbACimp.Click
        Call cbCheckImp()
    End Sub

    Private Sub rbACserver_Click(sender As Object, e As EventArgs) Handles rbACserver.Click
        Call cbCheckServer()
    End Sub

    Private Sub rbACclient_Click(sender As Object, e As EventArgs) Handles rbACclient.Click
        Call cbCheckServer()
    End Sub
End Class