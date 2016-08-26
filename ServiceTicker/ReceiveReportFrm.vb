Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Data.SQLite

Public Class ReceiveReportFrm


    Private Sub ViewReceiveFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        DateTimePicker1.Value = DateTime.Now.AddDays(-30)
        DateTimePicker2.Value = DateTime.Now.AddDays(1)
    End Sub
    Private Sub startfrm()

    End Sub
    Private Sub getDtatTocbbVRbuyCompany()
        Try
            Me.cbbVRbuyCompany.Items.Clear()
            strSQL = "SELECT sale_company_name from sale_company"
            Mainfrm.lblMainStatus.Text = strSQL
            Using cmd = New MySqlCommand
                cmd.CommandText = strSQL
                cmd.Connection = ConnectionDB
                Call open_connection()
                Dr = cmd.ExecuteReader
                While (Dr.Read())
                    Me.cbbVRbuyCompany.Items.Add(Dr("sale_company_name"))
                End While
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Dim Selectstrsql As Integer
    Private Sub getData()
        Try
            Me.dgVR.Rows.Clear()
            If Selectstrsql = 100 Then
                strSQL = "SELECT receive_id,buy_id,bill_buy_id,receive_status,total,status,sale_company_id,sale_company_name,datetime_save,employee FROM receive WHERE datetime_save BETWEEN '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "' AND '" & Convert.ToDateTime(DateTimePicker2.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "'"
                Mainfrm.lblMainStatus.Text = strSQL
            ElseIf Selectstrsql = 200 Then
                strSQL = "SELECT receive_id,buy_id,bill_buy_id,receive_status,total,status,sale_company_id,sale_company_name,datetime_save,employee FROM receive WHERE sale_company_name='" & Me.cbbVRbuyCompany.Text & "' AND datetime_save BETWEEN '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "' AND '" & Convert.ToDateTime(DateTimePicker2.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "'"
                Mainfrm.lblMainStatus.Text = strSQL
            End If
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Dim r As Integer
                With Me.dgVR
                    r = .Rows.Count
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.GetString("buy_id")
                    .Rows(r).Cells(1).Value = Dr.GetString("receive_id")
                    .Rows(r).Cells(2).Value = Dr.GetString("bill_buy_id")
                    .Rows(r).Cells(3).Value = Dr.GetString("sale_company_id")
                    .Rows(r).Cells(4).Value = Dr.GetString("sale_company_name")
                    .Rows(r).Cells(5).Value = Dr.GetString("datetime_save")
                    .Rows(r).Cells(6).Value = Dr.GetString("employee")
                    .Rows(r).Cells(7).Value = Dr.GetDecimal("total")
                    .Rows(r).Cells(8).Value = Dr.GetString("status")
                End With
            End While
            'นับจำนวนแถว
            Me.txtRRRsum.Text = ""
            Dim no As Integer = Me.dgVR.RowCount
            Me.txtRRRrow.Text = "จำนวน " & no & " รายการ"
            If no = 0 Then
                Me.txtRRRsum.Text = "รวม 0 บาท"
            Else
                For sum As Integer = 0 To Me.dgVR.Rows.Count - 1
                    Dim ss As Decimal
                    ss += Me.dgVR.Rows(sum).Cells(7).Value
                    Me.txtRRRsum.Text = "รวม " & ss.ToString("N2") & " บาท"
                Next
            End If
            Selectstrsql = Nothing
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub cbbSRPbuyCompany_Click(sender As Object, e As EventArgs) Handles cbbVRbuyCompany.Click
        Call getDtatTocbbVRbuyCompany()
    End Sub

    Private Sub btnVRviewPro_Click(sender As Object, e As EventArgs) Handles btnVRPviewPro.Click
        Dim dgspEmpty As Integer = Me.dgVR.Rows.Count
        If dgspEmpty = 0 Then
            MsgBox("ไม่มีข้อมูล กรุณาเลือกตารางที่ต้องการดูรายการสินค้า", MsgBoxStyle.Exclamation, "แจ้งเตือน")
            Exit Sub
        Else
            ViewReceiveReportFrm.MdiParent = Mainfrm
            ViewReceiveReportFrm.Show()
            Call ViewReceiveReportFrm.getDataViewSelectReceiveProductFrm()
        End If
    End Sub

    Private Sub btnRPshowAll_Click(sender As Object, e As EventArgs) Handles btnRPshowAll.Click
        Selectstrsql = 100
        Call getData()
    End Sub

    Private Sub cbbVRbuyCompany_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbVRbuyCompany.SelectedValueChanged
        Selectstrsql = 200
        Call getData()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If Me.dgVR.Rows.Count = 0 Then
            MsgBox("ไม่มีข้อมูลที่จะพิมพ์", MsgBoxStyle.Exclamation, "No Data")
        Else
            Me.Cursor = Cursors.WaitCursor
            Mainfrm.lblMainStatus.Text = "ล้างข้อมูลรายงานเก่า"
            Try
                strSQLite = "DELETE FROM receivereport"
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
            For r As Integer = 0 To Me.dgVR.Rows.Count - 1
                Try
                    strSQLite = "INSERT INTO receivereport(buy_id,buy_id_in,buy_bill_id,com_id,com_name,datetime_buy,employee,price,`status`)" _
                     & "VALUES(@buy_id,@buy_id_in,@buy_bill_id,@com_id,@com_name,@datetime_buy,@employee,@price,@status)"
                    Mainfrm.lblMainStatus.Text = strSQLite
                    cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                    cmdSQLite.Parameters.AddWithValue("@buy_id", Me.dgVR.Rows(r).Cells(0).Value)
                    cmdSQLite.Parameters.AddWithValue("@buy_id_in", Me.dgVR.Rows(r).Cells(1).Value)
                    cmdSQLite.Parameters.AddWithValue("@buy_bill_id", Me.dgVR.Rows(r).Cells(2).Value)
                    cmdSQLite.Parameters.AddWithValue("@com_id", Me.dgVR.Rows(r).Cells(3).Value)
                    cmdSQLite.Parameters.AddWithValue("@com_name", Me.dgVR.Rows(r).Cells(4).Value)
                    cmdSQLite.Parameters.AddWithValue("@datetime_buy", Me.dgVR.Rows(r).Cells(5).Value)
                    cmdSQLite.Parameters.AddWithValue("@employee", Me.dgVR.Rows(r).Cells(6).Value)
                    cmdSQLite.Parameters.AddWithValue("@price", Me.dgVR.Rows(r).Cells(7).Value)
                    cmdSQLite.Parameters.AddWithValue("@status", Me.dgVR.Rows(r).Cells(8).Value)
                    Call open_connectionSQLite()
                    cmdSQLite.ExecuteNonQuery()
                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                End Try
            Next
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = "โหลดหน้าพิมพ์รายงาน"
            ReceviceReportPrintFrm.Show()
        End If
    End Sub
End Class