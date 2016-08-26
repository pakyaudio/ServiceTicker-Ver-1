Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Data.SQLite

Public Class ReturnProductbarcodeReportFrm

    Private Sub ReportRepairFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        DateTimePicker1.Value = DateTime.Now.AddDays(-30)
        DateTimePicker2.Value = DateTime.Now.AddDays(1)
    End Sub

    Private Sub searchDatadgReportReturnbarcode()

        Me.dgReportRepair.Rows.Clear()
        Try
            If strss = 100 Then
                strSQL = "SELECT return_id,return_status FROM returnproduct WHERE " _
                    & "datetime_save BETWEEN '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "' AND " _
                    & "'" & Convert.ToDateTime(DateTimePicker2.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "' AND return_status='" & "เครดิต" & "'"
            ElseIf strss = 200 Then
                strSQL = "SELECT return_id,return_status FROM returnproduct WHERE " _
                    & "datetime_save BETWEEN '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "' AND " _
                    & "'" & Convert.ToDateTime(DateTimePicker2.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "' AND return_status='" & "เงินสด" & "'"
            ElseIf strss = 300 Then
                strSQL = "SELECT return_id,return_status FROM returnproduct WHERE " _
                    & "datetime_save BETWEEN '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "' AND " _
                    & "'" & Convert.ToDateTime(DateTimePicker2.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "'"
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
                    .Rows(r).Cells(1).Value = Dr.Item("return_id")
                    .Rows(r).Cells(11).Value = Dr.Item("return_status")
                End With
            End While
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try

        Try
            For cROWS As Integer = 0 To Me.dgReportRepair.Rows.Count - 1
                strSQL = "SELECT sale_id,fix_id,code_pro,name_pro,price_buy,total,employee,datetime_save FROM returnproduct_barcode WHERE " _
                    & "return_id='" & Me.dgReportRepair.Rows(cROWS).Cells(1).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                With Me.dgReportRepair
                    .Rows(cROWS).Cells(2).Value = Dr.Item("sale_id")
                    .Rows(cROWS).Cells(3).Value = Dr.Item("fix_id")
                    .Rows(cROWS).Cells(4).Value = Dr.Item("code_pro")
                    .Rows(cROWS).Cells(5).Value = Dr.Item("name_pro")
                    .Rows(cROWS).Cells(6).Value = Dr.Item("total")
                    .Rows(cROWS).Cells(7).Value = Dr.GetDecimal("price_buy")
                    .Rows(cROWS).Cells(9).Value = Dr.Item("datetime_save")
                    .Rows(cROWS).Cells(10).Value = Dr.Item("employee")
                End With
            Next
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try

        Try
            'นับจำนวนชิ้น
            Dim ss2 As Integer
            For sumn As Integer = 0 To Me.dgReportRepair.Rows.Count - 1
                ss2 += Me.dgReportRepair.Rows(sumn).Cells(6).Value
            Next

            'นับจำนวนแถว
            Me.txtmoney.Text = ""
            Dim no As Integer = Me.dgReportRepair.RowCount
            Me.txtRRrows.Text = "จำนวน " & no & " รายการ" & ", " & ss2 & " ชิ้น"

            'นับจำนวนแถวใส่หมายเลขหน้าแถว
            For sum As Integer = 0 To Me.dgReportRepair.Rows.Count - 1
                Me.dgReportRepair.Rows(sum).Cells(0).Value = sum + 1
                Me.dgReportRepair.Rows(sum).Cells(8).Value = CDec(Me.dgReportRepair.Rows(sum).Cells(7).Value) * CDec(Me.dgReportRepair.Rows(sum).Cells(6).Value)
            Next

            'นับจำนวนเงิน
            If no = 0 Then
                Me.txtmoney.Text = "รวมราคา 0 บาท "
            Else
                For sum As Integer = 0 To Me.dgReportRepair.Rows.Count - 1
                    Dim ss As Decimal
                    ss += CDec(Me.dgReportRepair.Rows(sum).Cells(7).Value)
                    Me.txtmoney.Text = "รวมราคา " & ss.ToString("N2") & " บาท "
                Next
            End If
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        strss = Nothing
    End Sub

    Private Sub btnRRdisplayData_Click(sender As Object, e As EventArgs) Handles btnRRdisplayData.Click
        If Me.ComboBox1.Text = "" Then
            MsgBox("เลือกสถานะ", MsgBoxStyle.Exclamation, "แจ้งเตือน")
        ElseIf Me.ComboBox1.Text = "เครดิต" Then
            strss = 100
            Call searchDatadgReportReturnbarcode()
        ElseIf Me.ComboBox1.Text = "เงินสด" Then
            strss = 200
            Call searchDatadgReportReturnbarcode()
        ElseIf Me.ComboBox1.Text = "ทั้งหมด" Then
            strss = 300
            Call searchDatadgReportReturnbarcode()
        End If

    End Sub
    Dim strss As Integer
    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        Me.ComboBox1.Items.Clear()
        Me.ComboBox1.Items.Add("เครดิต")
        Me.ComboBox1.Items.Add("เงินสด")
        Me.ComboBox1.Items.Add("ทั้งหมด")
    End Sub
    Private Sub reportPrint()
        If Me.dgReportRepair.Rows.Count = 0 Then
            MsgBox("ไม่มีข้อมูลที่จะพิมพ์", MsgBoxStyle.Exclamation, "No Data")
        Else
            Me.Cursor = Cursors.WaitCursor
            Mainfrm.lblMainStatus.Text = "ล้างข้อมูลรายงานเก่า"
            Try
                strSQLite = "DELETE FROM returnproductbarcode"
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
            For r As Integer = 0 To Me.dgReportRepair.Rows.Count - 1
                Try
                    strSQLite = "INSERT INTO returnproductbarcode(`no`,return_id,sale_id,bar_code,name_pro,total_pro,price_buy,total_price_buy,datetime,employee,`status`,fix_id)" _
                     & "VALUES(@no,@return_id,@sale_id,@bar_code,@name_pro,@total_pro,@price_buy,@total_price_buy,@datetime,@employee,@status,@fix_id)"
                    Mainfrm.lblMainStatus.Text = strSQLite
                    cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                    cmdSQLite.Parameters.AddWithValue("@no", Me.dgReportRepair.Rows(r).Cells(0).Value)
                    cmdSQLite.Parameters.AddWithValue("@return_id", Me.dgReportRepair.Rows(r).Cells(1).Value)
                    cmdSQLite.Parameters.AddWithValue("@sale_id", Me.dgReportRepair.Rows(r).Cells(2).Value)

                    cmdSQLite.Parameters.AddWithValue("@bar_code", Me.dgReportRepair.Rows(r).Cells(4).Value)
                    cmdSQLite.Parameters.AddWithValue("@name_pro", Me.dgReportRepair.Rows(r).Cells(5).Value)
                    cmdSQLite.Parameters.AddWithValue("@total_pro", Me.dgReportRepair.Rows(r).Cells(6).Value)
                    cmdSQLite.Parameters.AddWithValue("@price_buy", Me.dgReportRepair.Rows(r).Cells(7).Value)
                    cmdSQLite.Parameters.AddWithValue("@total_price_buy", Me.dgReportRepair.Rows(r).Cells(8).Value)
                    cmdSQLite.Parameters.AddWithValue("@datetime", Me.dgReportRepair.Rows(r).Cells(9).Value)
                    cmdSQLite.Parameters.AddWithValue("@employee", Me.dgReportRepair.Rows(r).Cells(10).Value)
                    cmdSQLite.Parameters.AddWithValue("@status", Me.dgReportRepair.Rows(r).Cells(11).Value)
                    cmdSQLite.Parameters.AddWithValue("@fix_id", Me.dgReportRepair.Rows(r).Cells(3).Value)
                    Call open_connectionSQLite()
                    cmdSQLite.ExecuteNonQuery()
                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                End Try
            Next
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = "โหลดหน้าพิมพ์รายงาน"
            ReturnProductBarcodePrintFrm.Show()
        End If
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Call reportPrint()
    End Sub
End Class