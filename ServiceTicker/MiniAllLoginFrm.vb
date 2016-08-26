Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class MiniAllLoginFrm

    Private Sub MiniLoginUserFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        Timer1.Enabled = False
        Me.txtMLUusername.Clear()
        Me.txtMLUpassword.Clear()
        Me.Label1.Text = "ยืนยันตัวตนเพื่อเข้าใช้งาน " & Mainfrm.MenuLoigName
    End Sub
    Dim ifc As String
    Dim Lev As String
    Friend Sub ckUser()
        Try
            Mainfrm.lblMainStatus.Text = "SELECT user_leval"
            strSQL = "SELECT user_leval FROM users WHERE user_usernamelogin='" & Me.txtMLUusername.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Lev = Dr.Item("user_leval")
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub saveLogs()
        Try
            Dim uid, uname As String
            strSQL = "SELECT user_id,user_name FROM users WHERE user_usernamelogin=@1"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            cmd.Prepare()
            cmd.Parameters.AddWithValue("@1", Me.txtMLUusername.Text)
            Call open_connection()
            Dr = cmd.ExecuteReader
            With Dr
                .Read()
                uid = .GetString("user_id")
                uname = .GetString("user_name")
            End With

            strSQL = "INSERT INTO applogs(user_id,user_name,user_usernamelogin,note,date_in)VALUES('" & uid & "','" & uname & "','" & Me.txtMLUusername.Text & "','" & "เข้า" & Mainfrm.MenuLoigName & "','" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CreateSpecificCulture("en-EN")) & "')"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            uid = Nothing
            uname = Nothing
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ok()
        Try
            Mainfrm.lblMainStatus.Text = "SELECT user_usernamelogin,user_password"
            strSQL = "SELECT user_usernamelogin,user_password FROM users WHERE user_usernamelogin='" & Me.txtMLUusername.Text & "' AND user_password = '" & Me.txtMLUpassword.Text & "'"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            cmd.ExecuteNonQuery()
            Dim sqlRead As MySqlDataReader = cmd.ExecuteReader()
            If sqlRead.Read Then
                Call ckUser()
                If Mainfrm.leval <= Lev Then
                    Call SelectFrom()
                    Me.Close()
                Else
                    ifc = "400"
                    Timer1.Start()
                    Timer2.Start()
                    Me.txtMLUusername.Clear()
                    Me.txtMLUpassword.Clear()
                    Me.txtMLUusername.Focus()
                End If
            Else
                ifc = "100"
                Timer1.Start()
                Timer2.Start()
                Me.txtMLUpassword.Clear()
                Me.txtMLUpassword.Focus()
            End If
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub SelectFrom()
        If Mainfrm.MenuLoigName = "ข้อมูลสถานประกอบการ" Then
            CompanyFrm.MdiParent = Mainfrm
            CompanyFrm.Show()
            CompanyFrm.lblEmployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "ผู้ใช้งาน" Then
            UsersFrm.MdiParent = Mainfrm
            UsersFrm.Show()
            UsersFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "ข้อมูลลูกค้า" Then
            CustomerFrm.MdiParent = Mainfrm
            CustomerFrm.Show()
            CustomerFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "ตั้งค่าโปรแกรม" Then
            AppConfigFrm.MdiParent = Mainfrm
            AppConfigFrm.Show()
            AppConfigFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "ตั้งค่าข้อมูลบัตรเครดิต" Then
            CreditCardManagFrm.MdiParent = Mainfrm
            CreditCardManagFrm.Show()
            CreditCardManagFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "ตั้งค่าสิทธิการใช้งานโปรแกรม" Then
            AccessLavelFrm.MdiParent = Mainfrm
            AccessLavelFrm.Show()
            AccessLavelFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "สำรองฐานข้อมูล" Then
            BackupDatabaseFrm.MdiParent = Mainfrm
            BackupDatabaseFrm.Show()
            BackupDatabaseFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "นำเข้าฐานข้อมูล" Then
            ImportRestoreDatabaseFrm.MdiParent = Mainfrm
            ImportRestoreDatabaseFrm.Show()
            ImportRestoreDatabaseFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "เปลี่ยนฐานข้อมูล" Then
            DataBaseConnectFrm.MdiParent = Mainfrm
            DataBaseConnectFrm.Show()
            DataBaseConnectFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "ปรับปรุงฐานข้อมูล" Then
            OpimizeDBFrm.MdiParent = Mainfrm
            OpimizeDBFrm.Show()
            OpimizeDBFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "User Logs" Then
            logsFrm.MdiParent = Mainfrm
            logsFrm.Show()
            logsFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "รับงานซ่อม" Then
            SaveDataFixFrm.MdiParent = Mainfrm
            SaveDataFixFrm.Show()
            SaveDataFixFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "สถานะงานซ่อม" Then
            RepairStatusFrm.MdiParent = Mainfrm
            RepairStatusFrm.Show()
            RepairStatusFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "ค้นหางานซ่อม" Then
            SearchRepairFrm.MdiParent = Mainfrm
            SearchRepairFrm.Show()
            SearchRepairFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "ส่งคืนงานซ่อม" Then
            If RepairStatusFrm.forrepairstatus = 1000 Then
                SendRepairFrm.txtHideform.Text = RepairStatusFrm.dgRSstatus1.CurrentRow.Cells(1).Value
                SendRepairFrm.cbbSRRcash_status.Enabled = True
                SendRepairFrm.DateTimePickerSRR.Enabled = True
            End If
            SendRepairFrm.MdiParent = Mainfrm
            SendRepairFrm.Show()
            SendRepairFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
            RepairStatusFrm.forrepairstatus = Nothing
        ElseIf Mainfrm.MenuLoigName = "รายงานการซ่อมตามรายชื่อช่างซ่อม" Then
            ReportUserRepairFrm.MdiParent = Mainfrm
            ReportUserRepairFrm.Show()
            ReportUserRepairFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "รายงานประวิติงานซ่อม" Then
            RepairHistoryFrm.MdiParent = Mainfrm
            RepairHistoryFrm.Show()
            RepairHistoryFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "สถิติงานช่าง" Then
            ComfixCustomerStatusFrm.MdiParent = Mainfrm
            ComfixCustomerStatusFrm.Show()
            ComfixCustomerStatusFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "รายงานการเบิกสินค้า แบบแสดงรายชื่อสินค้า" Then
            ReportBarcodeComfixFrm.MdiParent = Mainfrm
            ReportBarcodeComfixFrm.Show()
            ReportBarcodeComfixFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "รายงานรวมเบิกสินค้าตามวันที่" Then
            ReportRepairFrm.MdiParent = Mainfrm
            ReportRepairFrm.Show()
            ReportRepairFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "เช็คประกันงานซ่อม" Then
            VarunteeCheckFrm.MdiParent = Mainfrm
            VarunteeCheckFrm.Show()
            VarunteeCheckFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "เช็คประวิติซ่อมเปลี่ยนอะไหล่" Then
            CheckHistoryComfixFrm.MdiParent = Mainfrm
            CheckHistoryComfixFrm.Show()
            CheckHistoryComfixFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "เช็คประกันกับบริษัทผู้จำหน่าย" Then
            WebLinkFrm.MdiParent = Mainfrm
            WebLinkFrm.Show()
            WebLinkFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "ข้อมูลประเภทสินค้า" Then
            ProductFrm.MdiParent = Mainfrm
            ProductFrm.Show()
            ProductFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "ข้อมูลยี่ห้อสินค้า" Then
            ProductNameFrm.MdiParent = Mainfrm
            ProductNameFrm.Show()
            ProductNameFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "ข้อมูลอาการเสีย" Then
            FixcomFrm.MdiParent = Mainfrm
            FixcomFrm.Show()
            FixcomFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "ข้อมูลการจัดการข้อมูล" Then
            ManagerdataFrm.MdiParent = Mainfrm
            ManagerdataFrm.Show()
            ManagerdataFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "ข้อมูลอุปกรณ์ที่นำมาด้วย" Then
            AccessoryEditFrm.MdiParent = Mainfrm
            AccessoryEditFrm.Show()
            AccessoryEditFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "ข้อมูลสีตัวสินค้า" Then
            ProductColorFrm.MdiParent = Mainfrm
            ProductColorFrm.Show()
            ProductColorFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "ข้อมูล SN เครื่องซ่อม" Then
            Mainfrm.snC = 1
            SNFrm.MdiParent = Mainfrm
            SNFrm.Show()
            SNFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "พิมพ์ใบรับซ่อม/ส่งคืนย้อนหลัง" Then
            PrintSaveDatafixSendRepairFrm.MdiParent = Mainfrm
            PrintSaveDatafixSendRepairFrm.Show()
            PrintSaveDatafixSendRepairFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "สั่งซื้อสินค้า" Then
            OrdreFrm.MdiParent = Mainfrm
            OrdreFrm.Show()
            OrdreFrm.lblEmployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "รายการสั่งซื้อสินค้า" Then
            ViewReceiveFrm.MdiParent = Mainfrm
            ViewReceiveFrm.Show()
            ViewReceiveFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "รับสินค้าเข้าระบบ" Then
            ReceiveProductFrm.MdiParent = Mainfrm
            ReceiveProductFrm.Show()
            ReceiveProductFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "รายชื่อบริษัทที่สั่งซื้อ" Then
            SaleCompanyFrm.MdiParent = Mainfrm
            SaleCompanyFrm.Show()
            SaleCompanyFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "รายงานการรับสินค้า" Then
            SaleCompanyFrm.MdiParent = Mainfrm
            SaleCompanyFrm.Show()
            SaleCompanyFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "ขายสินค้า" Then
            SaleFrm.MdiParent = Mainfrm
            SaleFrm.Show()
            SaleFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "คืนสินค้า/ยกเลิกบิลขาย" Then
            ReturnsProductFrm.MdiParent = Mainfrm
            ReturnsProductFrm.Show()
            ReturnsProductFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "รายงานรวมขายสินค้าตามวันที่" Then
            ReportSaleFrm.MdiParent = Mainfrm
            ReportSaleFrm.Show()
            ReportSaleFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "รายงานขาย แบบแสดงรายชื่อสินค้า" Then
            ReportBarcodeFrm.MdiParent = Mainfrm
            ReportBarcodeFrm.Show()
            ReportBarcodeFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "รายงานการคืน รวม" Then
            ReturnProdductReportFrm.MdiParent = Mainfrm
            ReturnProdductReportFrm.Show()
            ReturnProdductReportFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "รายงานคืนสินค้าแบบแสดงชื่อสินค้า" Then
            ReturnProductbarcodeReportFrm.MdiParent = Mainfrm
            ReturnProductbarcodeReportFrm.Show()
            ReturnProductbarcodeReportFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "สถิติงานขาย" Then
            SalesCustomerStatusFrm.MdiParent = Mainfrm
            SalesCustomerStatusFrm.Show()
            SalesCustomerStatusFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "ตรวจสอบราคาสินค้า" Then
            CheckPriceFrm.MdiParent = Mainfrm
            CheckPriceFrm.Show()
            CheckPriceFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "เช็คประกันตัวสินค้า" Then
            VarunteeCheckSNFrm.MdiParent = Mainfrm
            VarunteeCheckSNFrm.Show()
            VarunteeCheckSNFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "รับเคลมสินค้า" Then
            ClaimsFrm.MdiParent = Mainfrm
            ClaimsFrm.Show()
            ClaimsFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "เตรียมสินค้าเคลม" Then
            ClaimsCompanyFrm.MdiParent = Mainfrm
            Mainfrm.selectCompanyClaims = 100
            ClaimsCompanyFrm.Timer1.Start()
            ClaimsCompanyFrm.Show()
            ClaimsFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
            ' Mainfrm.selectCompanyClaims = Nothing   แก้ไข 
        ElseIf Mainfrm.MenuLoigName = "ส่งสินค้าเคลม" Then
            ClaimsSendGroupFrm.MdiParent = Mainfrm
            ClaimsSendGroupFrm.Show()
            ClaimsSendGroupFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "รับเข้าสินค้าเคลม" Then
            ClaimsreceiveGroupFrm.MdiParent = Mainfrm
            ClaimsreceiveGroupFrm.Show()
            ClaimsreceiveGroupFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "ทดสอบสินค้าเคลม" Then
            ClaimsTestResultsFrm.MdiParent = Mainfrm
            ClaimsTestResultsFrm.Show()
            ClaimsTestResultsFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "นำเข้าสินค้าเคลม" Then
            ClaimsImportProFrm.MdiParent = Mainfrm
            ClaimsImportProFrm.Show()
            ClaimsImportProFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "ติดตามสถานะเคลม" Then
            ClaimsStatusFrm.MdiParent = Mainfrm
            ClaimsStatusFrm.Show()
            ClaimsStatusFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "คืนสินค้าเคลม" Then
            ReturnClaimsToCusFrm.MdiParent = Mainfrm
            ReturnClaimsToCusFrm.Show()
            ReturnClaimsToCusFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "พิมพ์ใบปะหน้ากล่อง" Then
            BoxCoverFrm.MdiParent = Mainfrm
            BoxCoverFrm.Show()
            BoxCoverFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "รายงานการเคลม" Then
            ClaimsReportFrm.MdiParent = Mainfrm
            ClaimsReportFrm.Show()
            ClaimsReportFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "ลูกหนี้ค้างจ่าย" Then
            DebtorFrm.MdiParent = Mainfrm
            DebtorFrm.Show()
            DebtorFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "ตรวจสอบบัญชี/บันทึกค่าใช้จ่าย" Then
            AuditFrm.MdiParent = Mainfrm
            AuditFrm.Show()
            AuditFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "รายงานรายรับ/รายจ่าย" Then
            AuditReportFrm.MdiParent = Mainfrm
            AuditReportFrm.Show()
            AuditReportFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "สถิติรายปี" Then
            AuditChartFrm.MdiParent = Mainfrm
            AuditChartFrm.Show()
            AuditChartFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "รายการสินค้า" Then
            ProductDetailFrm.MdiParent = Mainfrm
            ProductDetailFrm.Show()
            ProductDetailFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "เช็คสต็อก Serial Number" Then
            CheckStockFrm.MdiParent = Mainfrm
            CheckStockFrm.Show()
            CheckStockFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "เช็คสต็อกบาร์โค๊ต" Then
            CheckStoclBarcodeFrm.MdiParent = Mainfrm
            CheckStoclBarcodeFrm.Show()
            CheckStoclBarcodeFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "รายงานตรวจสอบสต็อก SN" Then
            CheckStockReportFrm.MdiParent = Mainfrm
            CheckStockReportFrm.Show()
            CheckStockReportFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "รายงานตรวจสอบสต็อกบาร์โค๊ต" Then
            CheckStockBCReportFrm.MdiParent = Mainfrm
            CheckStockBCReportFrm.Show()
            CheckStockBCReportFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "รายงานยอดรวมสต็อก" Then
            Stock1Frm.MdiParent = Mainfrm
            Stock1Frm.Show()
            Stock1Frm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "ออกใบเสนอราคา" Then
            CreateQuotationFrm.MdiParent = Mainfrm
            CreateQuotationFrm.Show()
            CreateQuotationFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "ค้นหาใบเสนอราคา" Then
            ViewQuotationFrm.MdiParent = Mainfrm
            ViewQuotationFrm.Show()
            ViewQuotationFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "ออกใบกำกับภาษี/ใบส่งของ" Then
            TaxInvoiceFrm.MdiParent = Mainfrm
            TaxInvoiceFrm.Show()
            TaxInvoiceFrm.lblemployee.Text = Me.txtMLUusername.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing
        ElseIf Mainfrm.MenuLoigName = "เบิกอะไหล่/ค่าซ่อม" Then
            PartsWithdrawalFrm.MdiParent = Mainfrm
            PartsWithdrawalFrm.Show()
            PartsWithdrawalFrm.lblemployee.Text = Me.txtMLUusername.Text
            PartsWithdrawalFrm.lblemployee.Text = LoginFrm.txtLoginUsername.Text
            PartsWithdrawalFrm.txtPWrepairID.Text = RepairStatusFrm.txtRSfix_id.Text
            PartsWithdrawalFrm.txtPWcusID.Text = RepairStatusFrm.txtRScus_id.Text
            PartsWithdrawalFrm.txtPWcusName.Text = RepairStatusFrm.txtRScus_name.Text
            PartsWithdrawalFrm.txtPWcusTel.Text = RepairStatusFrm.txtRScus_tel.Text
            Call saveLogs()
            Mainfrm.MenuLoigName = Nothing
            Mainfrm.access = Nothing
            Mainfrm.leval = Nothing



        Else
            MsgBox("เงื่อนไขไม่ตรงกับที่ตั้งไว้ กรุณาตรวจสอบ", MsgBoxStyle.Critical, "ผิดพลาด")
        End If

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Label1.ForeColor = Color.Red
        If ifc = "100" Then
            Me.Label1.Text = "ชื่อหรือรหัสผ่านไม่ถูกต้อง"
        ElseIf ifc = "200" Then
            Me.Label1.Text = "กรุณาใส่ชื่อผู้ใช้งาน"
        ElseIf ifc = "300" Then
            Me.Label1.Text = "กรุณาใส่รหัสผ่าน"
        ElseIf ifc = "400" Then
            Me.Label1.Text = "คุณไม่มีสิทธิใช้งานในส่วนนี้ ติดต่อผู้ดูแลระบบเพื่อขอเข้าใช้งาน"
        End If
        If Me.Label1.Visible = True Then
            Me.Label1.Visible = False
        Else
            Me.Label1.Visible = True
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Label1.ForeColor = Color.Black
        Me.Label1.Text = "ยืนยันตัวตนเพื่อเข้าใช้งานเมนู" & Mainfrm.MenuLoigName
        ifc = Nothing
        Me.Timer1.Stop()
        Me.Timer2.Stop()
    End Sub

    Private Sub txtMLUusername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMLUusername.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtMLUpassword.Focus()
        End If
    End Sub

    Private Sub btnMLUok_Click(sender As Object, e As EventArgs) Handles btnMLUok.Click
        If Me.txtMLUusername.Text = "" Then
            ifc = "200"
            Me.Timer1.Start()
            Me.Timer2.Start()
        ElseIf Me.txtMLUpassword.Text = "" Then
            ifc = "300"
            Me.Timer1.Start()
            Me.Timer2.Start()
        Else
            Call ok()
        End If
    End Sub

    Private Sub txtMLUpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMLUpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtMLUusername.Text = "" Then
                ifc = "200"
                Me.Timer1.Start()
                Me.Timer2.Start()
            ElseIf Me.txtMLUpassword.Text = "" Then
                ifc = "300"
                Me.Timer1.Start()
                Me.Timer2.Start()
            Else
                Call ok()
            End If
        End If
    End Sub

    Private Sub btnshowpass_MouseDown(sender As Object, e As MouseEventArgs) Handles btnshowpass.MouseDown
        If Me.txtMLUpassword.UseSystemPasswordChar = True Then
            Me.txtMLUpassword.UseSystemPasswordChar = False
        ElseIf Me.txtMLUpassword.UseSystemPasswordChar = False Then
            Me.txtMLUpassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnshowpass_MouseUp(sender As Object, e As MouseEventArgs) Handles btnshowpass.MouseUp
        If Me.txtMLUpassword.UseSystemPasswordChar = True Then
            Me.txtMLUpassword.UseSystemPasswordChar = False
        ElseIf Me.txtMLUpassword.UseSystemPasswordChar = False Then
            Me.txtMLUpassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class