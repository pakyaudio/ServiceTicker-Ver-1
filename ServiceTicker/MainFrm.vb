Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Management
Imports System.Threading
Imports System.Data.SQLite

Public Class Mainfrm
    Private Const AW_BLEND = &H80000
    Private Declare Function AnimateWindow Lib "user32" (ByVal hwnd As Int32, ByVal dwTime As Int32, ByVal dwFlags As Int32) As Boolean
    Dim winHide As Integer = &H10000
    Dim winBlend As Integer = &H80000
    Private Sub Data_History_Bus_Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.lblMainStatus.Text = "กำลังจะปิดโปรแกรม"
        If MdiChildren.Length > 0 Then
            MsgBox("มีหน้าต่างของโปรแกรมเปิดอยู่ กรุณาปิดหน้าต่างของโปรแกรมทั้งหมดก่อน", MsgBoxStyle.Information, "แจ้งเตือน")
            e.Cancel = True
        Else
            If MessageBox.Show("คุณแน่ใจว่าจะออกจากโปรแกรม จงแน่ใจว่าบันทึกข้อมูลต่างๆเรียบร้อยแล้ว", "ออกจากโปรแกรม", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                e.Cancel = False
                ConnectionDB.Close()
                Try
                    AnimateWindow(Me.Handle.ToInt32, CInt(500), winHide Or winBlend)
                Catch ex As Exception

                End Try
                LoginFrm.Close()

                Me.lblMainStatus.Text = "ปิดโปรแกรม"
            Else
                e.Cancel = True
                Me.lblMainStatus.Text = "การปิดโปรแกรมถูกยกเลิก"
            End If
        End If
    End Sub
   
    Friend msg As String
    Private rng As New Random
    Private Sub importune()
        'แสดงผลงานที่เร่งด่วน
        Try
          
            Dim ims As Integer = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "importune", Nothing)
            If ims = 1 Then
                strSQL = "SELECT importune FROM comfix WHERE importune='" & "เร่งด่วน" & "' AND status='" & "1 รอซ่อม" & "'"
                Me.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                If Dr.HasRows Then
                    strSQL = "SELECT com_qjob FROM company"
                    Me.lblMainStatus.Text = strSQL
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    Dr = cmd.ExecuteReader()
                    Dr.Read()
                    msg = Dr.GetString("com_qjob")
                    Dim res = WindowsApi.FlashWindow(Process.GetCurrentProcess().MainWindowHandle, True, True, 10)
                  

                    Dim slice As New POPUPmsgFrm(5000, msg)

                    'slice.Height = Me.rng.Next(50, 200)
                    slice.Show()
                Else
                    Exit Sub
                End If
            Else
                Exit Sub
            End If
        Catch ex As Exception
            Me.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Dim progressThread As Threading.Thread
    Private Sub prot1()
        If ProgressBar1.Visible = True Then
            ProgressBar1.Hide()
            Me.Cursor = Cursors.Default
        ElseIf ProgressBar1.Visible = False Then
            ProgressBar1.Show()
            Me.Cursor = Cursors.AppStarting
        End If
        Threading.Thread.Sleep(10)
    End Sub

    Public Sub progress()
        progressThread = New System.Threading.Thread(AddressOf Me.prot1)
        progressThread.Start()
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Me.Opacity = Me.Opacity + 0.01
        If Me.Opacity = 1 Then
            Timer3.Enabled = False
        End If
    End Sub
    '<System.Runtime.InteropServices.DllImportAttribute("user32.dll")> Private Shared Function DestroyIcon(ByVal handle As IntPtr) As Boolean
    'End Function

    Friend Sub loadIcon()
        Try
            strSQL = "SELECT ver_icon FROM ver_detail"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dim pictureData As Byte() = DirectCast(cmd.ExecuteScalar(), Byte())
            Dim stream As New IO.MemoryStream(pictureData)
            'Read the stream and create an Image object from the data.'
            stream.Write(pictureData, 0, pictureData.Length)
            Dim PICON As New Bitmap(stream)
            Dim HIcon As IntPtr = PICON.GetHicon()
            Dim newIcon As Icon = System.Drawing.Icon.FromHandle(HIcon)
            Me.Icon = newIcon
        Catch ex As Exception
            Me.lblMainStatus.Text = "โหลดไอคอนโปรแกรมผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub Mainfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        Timer3.Enabled = True
        Me.Opacity = 0.1
        Application.CurrentCulture = New CultureInfo("th-TH")
        MainTsslUserLogin.Text = "ผู้เข้าระบบ : " & LoginFrm.txtLoginUsername.Text
        Call loadIcon()
        Call progress()
        'Try
        '    Me.lblMainStatus.Text = "ตรวจสอบอัพเดท"
        '    Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://update.patechgroup.net/Version.txt")
        '    Dim response As System.Net.HttpWebResponse = request.GetResponse()
        '    Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        '    Dim newestversion As String = sr.ReadToEnd()
        '    Dim currentversion As String = Application.ProductVersion
        '    If newestversion.Contains(currentversion) Then
        '        Me.lblMainStatus.Text = "ไม่มีเวอร์ชั่นใหม่"
        '    Else
        '        Me.lblMainStatus.Text = "มีเวอร์ชั่นใหม่"
        '        NewVersionFrm.MdiParent = Me
        '        NewVersionFrm.Show()
        '    End If
        'Catch ex As Exception
        '    Me.lblMainStatus.Text = "ไม่สามารถเชื่อมต่อ การตรวจสอบอัพเดทได้"
        'End Try
        Me.lblMainStatus.Text = "พร้อมใช้งาน"
        Me.TimerImportune.Start()
        Me.lblMhost.Text = "เครื่องแม่ข่าย : " & My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "server", Nothing) _
        & "   ฐานข้อมูล : " & My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "database", Nothing) _
        & "   ชื่อคอมพิวเตอร์ : " & SystemInformation.ComputerName
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "enable_backup", Nothing) = "yes" Then
            Me.Timer4Backup.Start()
        End If
        Call tbk()
    End Sub

    Private thisMenu As ContextMenu
    Friend Sub checkAccess()
        Try
            strSQL = "SELECT access,leval FROM access_lavel WHERE zone='" & MenuLoigName & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            If Dr.HasRows Then
                access = Dr.Item("access")
                leval = Dr.Item("leval")
            End If
        Catch ex As Exception

        End Try
    End Sub
    Friend MenuLoigName As String
    Friend access, leval As Integer
    Public Sub ขอมลสถานประกอบการToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ขอมลสถานประกอบการToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "ข้อมูลสถานประกอบการ"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            CompanyFrm.MdiParent = Me
            CompanyFrm.Show()
            CompanyFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub ผใชงานToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ผใชงานToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "ผู้ใช้งาน"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            UsersFrm.MdiParent = Me
            UsersFrm.Show()
            UsersFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub ขอมลลกคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ขอมลลกคาToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "ข้อมูลลูกค้า"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            CustomerFrm.MdiParent = Me
            CustomerFrm.Show()
            CustomerFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub ตงคาโปรแกรมToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ตงคาโปรแกรมToolStripMenuItem1.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "ตั้งค่าโปรแกรม"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            AppConfigFrm.MdiParent = Me
            AppConfigFrm.Show()
            AppConfigFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub ตงคาขอมลบตรเครดตToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ตงคาขอมลบตรเครดตToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "ตั้งค่าข้อมูลบัตรเครดิต"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            CreditCardManagFrm.MdiParent = Me
            CreditCardManagFrm.Show()
            CreditCardManagFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub ตงคาสทธการใชงานโปรแกรมToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ตงคาสทธการใชงานโปรแกรมToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "ตั้งค่าสิทธิการใช้งานโปรแกรม"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            AccessLavelFrm.MdiParent = Me
            AccessLavelFrm.Show()
            AccessLavelFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub สำรองฐานขอมลToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles สำรองฐานขอมลToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "สำรองฐานข้อมูล"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            BackupDatabaseFrm.MdiParent = Me
            BackupDatabaseFrm.Show()
            BackupDatabaseFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub นำเขาฐานขอมลToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles นำเขาฐานขอมลToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "นำเข้าฐานข้อมูล"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            ImportRestoreDatabaseFrm.MdiParent = Me
            ImportRestoreDatabaseFrm.Show()
            ImportRestoreDatabaseFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub เปลยนฐานขอมลToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles เปลยนฐานขอมลToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "เปลี่ยนฐานข้อมูล"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            DataBaseConnectFrm.MdiParent = Me
            DataBaseConnectFrm.Show()
            DataBaseConnectFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub ปรบปรงฐานขอมลToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ปรบปรงฐานขอมลToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "ปรับปรุงฐานข้อมูล"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            OpimizeDBFrm.MdiParent = Me
            OpimizeDBFrm.Show()
            OpimizeDBFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub UserLogsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserLogsToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "User Logs"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            logsFrm.MdiParent = Me
            logsFrm.Show()
            logsFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub รบงานซอมToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles รบงานซอมToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "รับงานซ่อม"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            SaveDataFixFrm.MdiParent = Me
            SaveDataFixFrm.Show()
            SaveDataFixFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub รายการซอมToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles รายการซอมToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "สถานะงานซ่อม"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            RepairStatusFrm.MdiParent = Me
            RepairStatusFrm.Show()
            RepairStatusFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub สงงานซอมToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles สงงานซอมToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "ค้นหางานซ่อม"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            SearchRepairFrm.MdiParent = Me
            SearchRepairFrm.Show()
            SearchRepairFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub สงคนงานซอมToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles สงคนงานซอมToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "ส่งคืนงานซ่อม"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            SendRepairFrm.MdiParent = Me
            SendRepairFrm.Show()
            SendRepairFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem11.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "รายงานการซ่อมตามรายชื่อช่างซ่อม"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            ReportUserRepairFrm.MdiParent = Me
            ReportUserRepairFrm.Show()
            ReportUserRepairFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub คนหาประวตงานซอมToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles คนหาประวตงานซอมToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "รายงานประวิติงานซ่อม"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            RepairHistoryFrm.MdiParent = Me
            RepairHistoryFrm.Show()
            RepairHistoryFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub สถตToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles สถตToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "สถิติงานช่าง"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            ComfixCustomerStatusFrm.MdiParent = Me
            ComfixCustomerStatusFrm.Show()
            ComfixCustomerStatusFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub รายงานการเบกสนคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รายงานการเบกสนคาToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "รายงานการเบิกสินค้า แบบแสดงรายชื่อสินค้า"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            ReportBarcodeComfixFrm.MdiParent = Me
            ReportBarcodeComfixFrm.Show()
            ReportBarcodeComfixFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub รายงานรวมเบกสนคาตามวนทToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รายงานรวมเบกสนคาตามวนทToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "รายงานรวมเบิกสินค้าตามวันที่"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            ReportRepairFrm.MdiParent = Me
            ReportRepairFrm.Show()
            ReportRepairFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub เชคประกนงานซอมToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles เชคประกนงานซอมToolStripMenuItem1.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "เช็คประกันงานซ่อม"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            VarunteeCheckFrm.MdiParent = Me
            VarunteeCheckFrm.Show()
            VarunteeCheckFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub เชคประวตซอมเปลยนอะไหลToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles เชคประวตซอมเปลยนอะไหลToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "เช็คประวิติซ่อมเปลี่ยนอะไหล่"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            CheckHistoryComfixFrm.MdiParent = Me
            CheckHistoryComfixFrm.Show()
            CheckHistoryComfixFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub เชคประกนกบบรษทผจำหนายToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles เชคประกนกบบรษทผจำหนายToolStripMenuItem1.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "เช็คประกันกับบริษัทผู้จำหน่าย"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            WebLinkFrm.MdiParent = Me
            WebLinkFrm.Show()
            WebLinkFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub ขอมลประเภทสนคาToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ขอมลประเภทสนคาToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "ข้อมูลประเภทสินค้า"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            ProductFrm.MdiParent = Me
            ProductFrm.Show()
            ProductFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub ขอมลยหอสนคาToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ขอมลยหอสนคาToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "ข้อมูลยี่ห้อสินค้า"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            ProductNameFrm.MdiParent = Me
            ProductNameFrm.Show()
            ProductNameFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub ขอมลอาการเสยToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ขอมลอาการเสยToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "ข้อมูลอาการเสีย"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            FixcomFrm.MdiParent = Me
            FixcomFrm.Show()
            FixcomFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub ขอมลการจดการขอมลToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ขอมลการจดการขอมลToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "ข้อมูลการจัดการข้อมูล"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            ManagerdataFrm.MdiParent = Me
            ManagerdataFrm.Show()
            ManagerdataFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub ขอมลอปกรณทนำมาดวยToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ขอมลอปกรณทนำมาดวยToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "ข้อมูลอุปกรณ์ที่นำมาด้วย"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            AccessoryEditFrm.MdiParent = Me
            AccessoryEditFrm.Show()
            AccessoryEditFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub ขอมลสตวสนคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ขอมลสตวสนคาToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "ข้อมูลสีตัวสินค้า"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            ProductColorFrm.MdiParent = Me
            ProductColorFrm.Show()
            ProductColorFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Friend snC As String
    Private Sub ขอมลSNเครองซอมToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ขอมลSNเครองซอมToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "ข้อมูล SN เครื่องซ่อม"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            snC = 1
            SNFrm.MdiParent = Me
            SNFrm.Show()
            SNFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub
    Friend selectCompanyClaims As Integer
    Friend userClaimsPrepare As String

    Private Sub พมพใบสงคนยอนหลงToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles พมพใบสงคนยอนหลงToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "พิมพ์ใบรับซ่อม/ส่งคืนย้อนหลัง"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            PrintSaveDatafixSendRepairFrm.MdiParent = Me
            PrintSaveDatafixSendRepairFrm.Show()
            PrintSaveDatafixSendRepairFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "สั่งซื้อสินค้า"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            OrdreFrm.MdiParent = Me
            OrdreFrm.Show()
            OrdreFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "รายการสั่งซื้อสินค้า"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            ViewReceiveFrm.MdiParent = Me
            ViewReceiveFrm.Show()
            ViewReceiveFrm.lblEmployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "รับสินค้าเข้าระบบ"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            ReceiveProductFrm.MdiParent = Me
            ReceiveProductFrm.Show()
            ReceiveProductFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "รายชื่อบริษัทที่สั่งซื้อ"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            SaleCompanyFrm.MdiParent = Me
            SaleCompanyFrm.Show()
            SaleCompanyFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub รายงานการรบสนคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รายงานการรบสนคาToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "รายงานการรับสินค้า"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            ReceiveReportFrm.MdiParent = Me
            ReceiveReportFrm.Show()
            ReceiveReportFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub ขายสนคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ขายสนคาToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "ขายสินค้า"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            SaleFrm.MdiParent = Me
            SaleFrm.Show()
            SaleFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub
    Private Sub คนสนคายกเลกบลขายToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles คนสนคายกเลกบลขายToolStripMenuItem1.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "คืนสินค้า/ยกเลิกบิลขาย"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            ReturnsProductFrm.MdiParent = Me
            ReturnsProductFrm.Show()
            ReturnsProductFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "รายงานรวมขายสินค้าตามวันที่"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            ReportSaleFrm.MdiParent = Me
            ReportSaleFrm.Show()
            ReportSaleFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "รายงานขาย แบบแสดงรายชื่อสินค้า"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            ReportBarcodeFrm.MdiParent = Me
            ReportBarcodeFrm.Show()
            ReportBarcodeFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "รายงานการคืน รวม"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            ReturnProdductReportFrm.MdiParent = Me
            ReturnProdductReportFrm.Show()
            ReturnProdductReportFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "รายงานคืนสินค้าแบบแสดงชื่อสินค้า"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            ReturnProductbarcodeReportFrm.MdiParent = Me
            ReturnProductbarcodeReportFrm.Show()
            ReturnProductbarcodeReportFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem13.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "สถิติงานขาย"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            SalesCustomerStatusFrm.MdiParent = Me
            SalesCustomerStatusFrm.Show()
            SalesCustomerStatusFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub
    Private Sub เชคราคาสนคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles เชคราคาสนคาToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "ตรวจสอบราคาสินค้า"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            CheckPriceFrm.MdiParent = Me
            CheckPriceFrm.Show()
            CheckPriceFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub
    Private Sub เชคประกนตวสนคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles เชคประกนตวสนคาToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "เช็คประกันตัวสินค้า"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            VarunteeCheckSNFrm.MdiParent = Me
            VarunteeCheckSNFrm.Show()
            VarunteeCheckSNFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub รบเคลมสนคาToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles รบเคลมสนคาToolStripMenuItem1.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "รับเคลมสินค้า"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            ClaimsFrm.MdiParent = Me
            ClaimsFrm.Show()
            ClaimsFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub เตรยมสนคาเคลมToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles เตรยมสนคาเคลมToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "เตรียมสินค้าเคลม"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            selectCompanyClaims = 100
            ClaimsCompanyFrm.Timer1.Start()
            ClaimsCompanyFrm.MdiParent = Me
            ClaimsCompanyFrm.Show()
            ClaimsCompanyFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub สงสนคาเคลมToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles สงสนคาเคลมToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "ส่งสินค้าเคลม"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            ClaimsSendGroupFrm.MdiParent = Me
            ClaimsSendGroupFrm.Show()
            ClaimsSendGroupFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub รบเขาสนคาเคลมToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รบเขาสนคาเคลมToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "รับเข้าสินค้าเคลม"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            ClaimsreceiveGroupFrm.MdiParent = Me
            ClaimsreceiveGroupFrm.Show()
            ClaimsreceiveGroupFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub ทดสอบสนคาเคลมToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ทดสอบสนคาเคลมToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "ทดสอบสินค้าเคลม"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            ClaimsTestResultsFrm.MdiParent = Me
            ClaimsTestResultsFrm.Show()
            ClaimsTestResultsFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub นำเขาสนคาเคลมToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles นำเขาสนคาเคลมToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "นำเข้าสินค้าเคลม"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            ClaimsImportProFrm.MdiParent = Me
            ClaimsImportProFrm.Show()
            ClaimsImportProFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub ตดตามสถานะงานเคลมToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ตดตามสถานะงานเคลมToolStripMenuItem1.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "ติดตามสถานะเคลม"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            ClaimsStatusFrm.MdiParent = Me
            ClaimsStatusFrm.Show()
            ClaimsStatusFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub คนสนคาเคลมToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles คนสนคาเคลมToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "คืนสินค้าเคลม"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            ReturnClaimsToCusFrm.MdiParent = Me
            ReturnClaimsToCusFrm.Show()
            ReturnClaimsToCusFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub พมพใบปะหนากลองToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles พมพใบปะหนากลองToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "พิมพ์ใบปะหน้ากล่อง"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            BoxCoverFrm.MdiParent = Me
            BoxCoverFrm.Show()
            BoxCoverFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem12.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "รายงานการเคลม"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            ClaimsReportFrm.MdiParent = Me
            ClaimsReportFrm.Show()
            ClaimsReportFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub ลกหนคางจายToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ลกหนคางจายToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "ลูกหนี้ค้างจ่าย"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            DebtorFrm.MdiParent = Me
            DebtorFrm.Show()
            DebtorFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub


    Private Sub ตรวจสอบบญชรายวนAuditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ตรวจสอบบญชรายวนAuditToolStripMenuItem.Click
        Try
            strSQL = "SELECT datetime FROM audit WHERE datetime='" & "start" & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            If Not Dr.HasRows Then
                MsgBox("คุณยังไม่ได้เริ่มระบบตรวจสอบบัญชี สิ่งที่ต้องทำคือ" & vbNewLine & _
                        "1.มีเงินทอนที่เพียงพอในการทอนและนับเงินทอนที่จะใช้ทอนในวันพรุ่งนี้" & vbNewLine & _
                        "2.บันทึกเงินทอนลงในโปรแกรม เพื่อเริ่มต้น การตรวจสอบบัญชี" & vbNewLine & _
                        "ต้องนับเงินทอนที่จะใช้ทอนในวันถัดไป เมื่อสิ้นของวันนี้ก่อนเที่ยงคืน ", MsgBoxStyle.Information, "ข้อควรทราบ")
                StartAuditFrm.MdiParent = Me
                StartAuditFrm.Show()
                StartAuditFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
            Else
                If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
                    MiniAllLoginFrm.Close()
                End If
                MenuLoigName = "ตรวจสอบบัญชี/บันทึกค่าใช้จ่าย"
                Call checkAccess()
                If access = 1 Then
                    MiniAllLoginFrm.MdiParent = Me
                    MiniAllLoginFrm.Show()
                ElseIf access = 0 Then
                    AuditFrm.MdiParent = Me
                    AuditFrm.Show()
                    AuditFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
                Else
                    MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
                End If
            End If
        Catch ex As Exception
            Me.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub รายงานรายรบรายจายToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รายงานรายรบรายจายToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "รายงานรายรับ/รายจ่าย"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            AuditReportFrm.MdiParent = Me
            AuditReportFrm.Show()
            AuditReportFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub สถตรายปToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles สถตรายปToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "สถิติรายปี"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            AuditChartFrm.MdiParent = Me
            AuditChartFrm.Show()
            AuditChartFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub รบอะไหลเขาระบบToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รบอะไหลเขาระบบToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "รายการสินค้า"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            ProductDetailFrm.MdiParent = Me
            ProductDetailFrm.Show()
            ProductDetailFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub เชคสตอกSerialNumberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles เชคสตอกSerialNumberToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "เช็คสต็อก Serial Number"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            CheckStockFrm.MdiParent = Me
            CheckStockFrm.Show()
            CheckStockFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub เชคสตอกบารโคตToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles เชคสตอกบารโคตToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "เช็คสต็อกบาร์โค๊ต"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            CheckStoclBarcodeFrm.MdiParent = Me
            CheckStoclBarcodeFrm.Show()
            CheckStoclBarcodeFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "รายงานตรวจสอบสต็อก SN"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            CheckStockReportFrm.MdiParent = Me
            CheckStockReportFrm.Show()
            CheckStockReportFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub รายงานตรวจสอบสตอกบารโคตToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รายงานตรวจสอบสตอกบารโคตToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "รายงานตรวจสอบสต็อกบาร์โค๊ต"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            CheckStockBCReportFrm.MdiParent = Me
            CheckStockBCReportFrm.Show()
            CheckStockBCReportFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub รายงานยอดรวมสตอกToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รายงานยอดรวมสตอกToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "รายงานยอดรวมสต็อก"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            Stock1Frm.MdiParent = Me
            Stock1Frm.Show()
            Stock1Frm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub รายงานจำนวนสตอกToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รายงานจำนวนสตอกToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "รายงานจำนวนสต็อก"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            StockNumberFrm.MdiParent = Me
            StockNumberFrm.Show()
            StockNumberFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "ออกใบเสนอราคา"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            CreateQuotationFrm.MdiParent = Me
            CreateQuotationFrm.Show()
            CreateQuotationFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub คนหาใบเสนอราคาToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles คนหาใบเสนอราคาToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "ค้นหาใบเสนอราคา"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            ViewQuotationFrm.MdiParent = Me
            ViewQuotationFrm.Show()
            ViewQuotationFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub ออกใบกำกบภาษToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ออกใบกำกบภาษToolStripMenuItem.Click
        If MiniAllLoginFrm.WindowState = FormWindowState.Normal Then
            MiniAllLoginFrm.Close()
        End If
        MenuLoigName = "ออกใบกำกับภาษี/ใบส่งของ"
        Call checkAccess()
        If access = 1 Then
            MiniAllLoginFrm.MdiParent = Me
            MiniAllLoginFrm.Show()
        ElseIf access = 0 Then
            TaxInvoiceFrm.MdiParent = Me
            TaxInvoiceFrm.Show()
            TaxInvoiceFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
        Else
            MsgBox("ไม่สามารถเข้าได้เนื่องจากสิทธิการใช้งานไม่ตรงกับเงื่อนไขที่ตั้งไว้", MsgBoxStyle.Critical, "แจ้งเตือน")
        End If
    End Sub

    Private Sub เกยวกบโปรแกรมToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles เกยวกบโปรแกรมToolStripMenuItem.Click
        AboutBoxFrm.MdiParent = Me
        AboutBoxFrm.Show()
    End Sub

    Private Sub คมอการใชงานToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles คมอการใชงานToolStripMenuItem.Click
        Try
            Dim url As String = Application.StartupPath & "\ServiceTickerDoc.pdf"
            Process.Start(url)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Dim p() As Process

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.lblMainStatus.BackColor = SystemColors.Control
        Timer1.Stop()
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.lblMainStatus.Text = "Ready"
        Timer2.Stop()
    End Sub

    Private Sub lblMainStatus_Click(sender As Object, e As EventArgs) Handles lblMainStatus.Click
        StatusFrm.MdiParent = Me
        StatusFrm.Show()
    End Sub
    Private Sub lblMainStatus_TextChanged(sender As Object, e As EventArgs) Handles lblMainStatus.TextChanged
        StatusFrm.txtSatus.AppendText(Environment.NewLine)
        StatusFrm.txtSatus.AppendText(Me.lblMainStatus.Text)
        Me.lblMainStatus.BackColor = Color.Tomato
        Timer1.Start()
    End Sub

    Private Sub พมพSerialNumberToolStripMenuItem_Click(sender As Object, e As EventArgs)
        barcode_snFrm.MdiParent = Me
        barcode_snFrm.Show()
    End Sub

    Private Sub ประวตการอพเดทToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ประวตการอพเดทToolStripMenuItem.Click
        UpdateHistoryFrm.MdiParent = Me
        UpdateHistoryFrm.Show()
    End Sub

    Private Sub รายงานขอผดพลาดโปรแกรมToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รายงานขอผดพลาดโปรแกรมToolStripMenuItem.Click
        DonateFrm.MdiParent = Me
        DonateFrm.Show()
    End Sub

    Private Sub TimerImportune_Tick(sender As Object, e As EventArgs) Handles TimerImportune.Tick
        Call importune()
    End Sub

    Private Sub สนบสนนโปรแกรมToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles สนบสนนโปรแกรมToolStripMenuItem.Click
        DonateFrm.MdiParent = Me
        DonateFrm.Show()
    End Sub

    Private Sub StatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatusToolStripMenuItem.Click

        StatusFrm.Show()

    End Sub
  
    Friend timeBK As Integer = 0
    Private Sub Timer4Backup_Tick(sender As Object, e As EventArgs) Handles Timer4Backup.Tick
        timeBK = timeBK + 1
        If timeBK = tbkh Then
            Try
                Me.lblMainStatus.Text = "กำลังสำรองข้อมูลอัตโนมัติ"
                Dim p() As Process
                p = Process.GetProcessesByName("BackUpMysql.exe")
                If p.Count > 0 Then
                    ' Process is running
                Else
                    Process.Start(Application.StartupPath & "\BackUpMysql.exe")
                End If
            Catch ex As Exception
                Me.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
            timeBK = 0
        End If
    End Sub
    Dim tbkh As Integer
    Private Sub tbk()
        Dim tbkt As Integer = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\serviceticker", "time_backup", Nothing)
        If tbkt = 1 Then
            tbkh = 60
        ElseIf tbkt = 2 Then
            tbkh = 120
        ElseIf tbkt = 3 Then
            tbkh = 180
        ElseIf tbkt = 4 Then
            tbkh = 240
        ElseIf tbkt = 5 Then
            tbkh = 300
        ElseIf tbkt = 6 Then
            tbkh = 360
        ElseIf tbkt = 7 Then
            tbkh = 420
        ElseIf tbkt = 8 Then
            tbkh = 480
        ElseIf tbkt = 9 Then
            tbkh = 540
        ElseIf tbkt = 10 Then
            tbkh = 600
        ElseIf tbkt = 11 Then
            tbkh = 660
        ElseIf tbkt = 12 Then
            tbkh = 720
        End If
    End Sub

    Private Sub ตงคาการอพโหลดToolStripMenuItem_Click(sender As Object, e As EventArgs)
        UploadWebConfigFrm.MdiParent = Me
        UploadWebConfigFrm.Show()
    End Sub
End Class
