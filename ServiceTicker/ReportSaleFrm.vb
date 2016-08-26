Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports System.Data.SQLite

Public Class ReportSaleFrm


    Private Sub ReportRepairFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        DateTimePicker1.Value = DateTime.Now.AddDays(-30)
        DateTimePicker2.Value = DateTime.Now.AddDays(1)
    End Sub
    Dim slectsql As Integer
    Private Sub searchDatadgReport()
        Try
            Me.dgReportRepair.Rows.Clear()
            If slectsql = 100 Then
                strSQL = "SELECT sale_id,fix_id,customer_id,customer_name,total_all,datetime_save FROM cash_sale WHERE " _
                    & "datetime_save BETWEEN '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "' AND " _
                    & "'" & Convert.ToDateTime(DateTimePicker2.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "' AND fix_id='" & "ขายสินค้า" & "'"
            ElseIf slectsql = 200 Then
                strSQL = "SELECT sale_id,fix_id,customer_id,customer_name,total_all,datetime_save FROM sale WHERE " _
                    & "datetime_save BETWEEN '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "' AND " _
                    & "'" & Convert.ToDateTime(DateTimePicker2.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "' AND fix_id='" & "ขายสินค้า" & "'"
            ElseIf slectsql = 300 Then
                strSQL = "SELECT sale_id,fix_id,customer_id,customer_name,total_all,datetime_save FROM cash_sale WHERE " _
                    & "datetime_save='" & Now.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "' AND fix_id='" & "ขายสินค้า" & "'"
            ElseIf slectsql = 400 Then
                strSQL = "SELECT sale_id,fix_id,customer_id,customer_name,total_all,datetime_save FROM sale WHERE " _
                    & "datetime_save='" & Now.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "' AND fix_id='" & "ขายสินค้า" & "'"
            End If
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dim r As Integer
            While (Dr.Read())
                With Me.dgReportRepair
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(1).Value = Dr.Item("sale_id")
                    .Rows(r).Cells(2).Value = Dr.Item("fix_id")
                    .Rows(r).Cells(3).Value = Dr.Item("customer_id")
                    .Rows(r).Cells(4).Value = Dr.Item("customer_name")
                    .Rows(r).Cells(5).Value = Dr.GetDecimal("total_all")
                    .Rows(r).Cells(7).Value = Dr.Item("datetime_save")
                End With
            End While
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Try
            'ดึงส่วนลด
            For DC As Integer = 0 To Me.dgReportRepair.Rows.Count - 1
                strSQL = "SELECT discount FROM discount WHERE sale_id='" & Me.dgReportRepair.Rows(DC).Cells(1).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                If Dr.HasRows Then
                    Me.dgReportRepair.Rows(DC).Cells(6).Value = Dr.GetDecimal("discount")
                Else
                    Me.dgReportRepair.Rows(DC).Cells(6).Value = 0
                End If
            Next
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Try
            'นับจำนวนแถว
            Me.txtmoney.Text = ""
            Dim no As Integer = Me.dgReportRepair.RowCount
            Me.txtRRrows.Text = "จำนวน " & no & " รายการ"
            'นับจำนวนแถวใส่หมายเลขหน้าแถว
            For sum As Integer = 0 To Me.dgReportRepair.Rows.Count - 1
                Me.dgReportRepair.Rows(sum).Cells(0).Value = sum + 1
            Next
            'นับจำนวนเงิน
            If no = 0 Then
                Me.txtRRttp.Text = 0
                Me.txtRRttd.Text = 0
                Me.txtmoney.Text = 0
            Else
                For sum As Integer = 0 To Me.dgReportRepair.Rows.Count - 1
                    Dim ss, ssd, sst As Decimal
                    ss += Me.dgReportRepair.Rows(sum).Cells(5).Value
                    ssd += Me.dgReportRepair.Rows(sum).Cells(6).Value
                    sst = ss - ssd
                    Me.txtRRttp.Text = ss.ToString("N2")
                    Me.txtRRttd.Text = ssd.ToString("N2")
                    Me.txtmoney.Text = sst.ToString("N2")
                Next
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Dr.Close()
        slectsql = Nothing
    End Sub

    Private Sub btnRRdisplayData_Click(sender As Object, e As EventArgs) Handles btnRRdisplayData.Click
        If Me.cbbRRcashstatus.Text = "" Then
            MsgBox("เลือกสถานะ", MsgBoxStyle.Information, "แจ้งเตือน")
            Me.lblRRcashStatus.BackColor = Color.Orange
        Else
            If Me.cbbRRcashstatus.Text = "ชำระเงิน(เลือกตามวันที่)" Then
                slectsql = 100
                'Call searchDatadgReport()
            ElseIf Me.cbbRRcashstatus.Text = "ยังไม่ได้ชำระเงิน(เลือกตามวันที่)" Then
                slectsql = 200
                'Call searchDatadgReport()
            ElseIf Me.cbbRRcashstatus.Text = "ชำระเงิน(วันนี้)" Then
                slectsql = 300
                'Call searchDatadgReport()
            ElseIf Me.cbbRRcashstatus.Text = "ยังไม่ได้ชำระเงิน(วันนี้)" Then
                slectsql = 400
                'Call searchDatadgReport()
            End If
            Call searchDatadgReport()
        End If
    End Sub

    Private Sub cbbRRcashstatus_Click(sender As Object, e As EventArgs) Handles cbbRRcashstatus.Click
        Me.cbbRRcashstatus.Items.Clear()
        Me.cbbRRcashstatus.Items.Add("ชำระเงิน(เลือกตามวันที่)")
        Me.cbbRRcashstatus.Items.Add("ยังไม่ได้ชำระเงิน(เลือกตามวันที่)")
        Me.cbbRRcashstatus.Items.Add("ชำระเงิน(วันนี้)")
        Me.cbbRRcashstatus.Items.Add("ยังไม่ได้ชำระเงิน(วันนี้)")
    End Sub

    Friend selectStatus As Integer
    Private Sub btnRRviewProduct_Click(sender As Object, e As EventArgs) Handles btnRRviewProduct.Click
        Try
            If Me.dgReportRepair.Rows.Count = 0 Then
                MsgBox("เลือกตารางข้อมูลที่ต้องการดูก่อน", MsgBoxStyle.Information, "แจ้งเตือน")
            Else
                strSQL = "SELECT code_pro FROM cash_sale_barcode WHERE sale_id='" & dgReportRepair.SelectedCells.Item(1).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                If Dr.HasRows Then
                    selectStatus = 100
                    ReportRepairViewProductFrm.MdiParent = Mainfrm
                    ReportRepairViewProductFrm.Show()
                    Call ReportRepairViewProductFrm.getData()
                ElseIf Not Dr.HasRows Then
                    selectStatus = 200
                    ReportRepairViewProductFrm.MdiParent = Mainfrm
                    ReportRepairViewProductFrm.Show()
                    Call ReportRepairViewProductFrm.getData()
                End If
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub repoetPrint()
        If Me.dgReportRepair.Rows.Count = 0 Then
            MsgBox("ไม่มีข้อมูลให้พิมพ์", MsgBoxStyle.Information, "No Data")
        Else
            Me.Cursor = Cursors.WaitCursor
            Mainfrm.lblMainStatus.Text = "ล้างข้อมูลรายงานเก่า"
            Try
                strSQLite = "DELETE FROM reportsale"
                Mainfrm.lblMainStatus.Text = strSQLite
                cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                Call open_connectionSQLite()
                cmdSQLite.ExecuteNonQuery()
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
            Mainfrm.lblMainStatus.Text = "สร้างข้อมูลรายงาน"
            Me.Cursor = Cursors.WaitCursor
            Try
                For r As Integer = 0 To Me.dgReportRepair.Rows.Count - 1
                    strSQLite = "INSERT INTO reportsale(`no`,sale_id,fix_id,cus_id,cus_name,total,discount,datetime)" _
                     & "VALUES(@no,@sale_id,@fix_id,@cus_id,@cus_name,@total,@discount,@datetime)"
                    Mainfrm.lblMainStatus.Text = strSQLite
                    cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                    cmdSQLite.Parameters.AddWithValue("@no", Me.dgReportRepair.Rows(r).Cells(0).Value)
                    cmdSQLite.Parameters.AddWithValue("@sale_id", Me.dgReportRepair.Rows(r).Cells(1).Value)
                    cmdSQLite.Parameters.AddWithValue("@fix_id", Me.dgReportRepair.Rows(r).Cells(2).Value)
                    cmdSQLite.Parameters.AddWithValue("@cus_id", Me.dgReportRepair.Rows(r).Cells(3).Value)
                    cmdSQLite.Parameters.AddWithValue("@cus_name", Me.dgReportRepair.Rows(r).Cells(4).Value)
                    cmdSQLite.Parameters.AddWithValue("@total", Me.dgReportRepair.Rows(r).Cells(5).Value)
                    cmdSQLite.Parameters.AddWithValue("@discount", Me.dgReportRepair.Rows(r).Cells(6).Value)
                    cmdSQLite.Parameters.AddWithValue("@datetime", Me.dgReportRepair.Rows(r).Cells(7).Value)
                    Call open_connectionSQLite()
                    cmdSQLite.ExecuteNonQuery()
                Next
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = "โหลดหน้าพิมพ์รายงาน"
            ReportSalePrintFrm.Show()
        End If
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Call repoetPrint()
    End Sub
End Class