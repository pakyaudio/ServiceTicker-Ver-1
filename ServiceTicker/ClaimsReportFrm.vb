Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Data.SQLite

Public Class ClaimsReportFrm
   

    Private Sub ClaimsStatusFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        DateTimePicker1.Value = DateTime.Now.AddDays(-30)
        DateTimePicker2.Value = DateTime.Now.AddDays(1)
    End Sub
    Friend strsqlSelect As String
    Friend Sub getdataClaims()
        Try
            Mainfrm.lblMainStatus.Text = "โหลดข้อมูล Claims"
            Me.dgCS.Rows.Clear()
            If strsqlSelect = 100 Then
                strSQL = "SELECT claims_id,customer_id,serial_pro,name_pro,symptom,note,note2,status,tel_to_cus,datetime_save FROM " _
                    & "claims_copy WHERE datetime_return between '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "' and '" & Convert.ToDateTime(DateTimePicker2.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "'"
                Mainfrm.lblMainStatus.Text = strSQL
            ElseIf strsqlSelect = 300 Then
                strSQL = "SELECT claims_id,customer_id,serial_pro,name_pro,symptom,note,note2,status,tel_to_cus,datetime_save FROM claims_copy WHERE "
                Dim strKeyWord As String = Me.txtCSsearch.Text
                If strKeyWord <> "" Then
                    strSQL = strSQL & "name_pro like '%" & strKeyWord & "%'  or serial_pro like '%" & strKeyWord & "%';"
                End If
                Mainfrm.lblMainStatus.Text = strSQL
            ElseIf strsqlSelect = 400 Then
                strSQL = "SELECT claims_id,customer_id,serial_pro,name_pro,symptom,note,note2,status,tel_to_cus,datetime_save FROM claims_copy"
                Mainfrm.lblMainStatus.Text = strSQL
            ElseIf strsqlSelect = 500 Then
                strSQL = "SELECT claims_id,customer_id,serial_pro,name_pro,symptom,note,note2,status,tel_to_cus,datetime_save FROM claims " _
                    & "WHERE `status`='" & Me.cbbCRstatus.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
            End If
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dim r As Integer
                While (Dr.Read())
                    With Me.dgCS
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(1).Value = Dr.Item("claims_id")
                        .Rows(r).Cells(2).Value = Dr.Item("customer_id")
                        .Rows(r).Cells(4).Value = Dr.Item("serial_pro")
                        .Rows(r).Cells(5).Value = Dr.Item("name_pro")
                        .Rows(r).Cells(6).Value = Dr.Item("symptom")
                        .Rows(r).Cells(7).Value = Dr.Item("status")
                        .Rows(r).Cells(8).Value = Dr.Item("tel_to_cus")
                        .Rows(r).Cells(9).Value = Dr.Item("datetime_save")
                        .Rows(r).Cells(10).Value = Dr.Item("note2")
                        .Rows(r).Cells(11).Value = Dr.Item("note")
                    End With
                End While
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try

        Try
            'ดึงชื่อลูกค้า
            For sum As Integer = 0 To Me.dgCS.Rows.Count - 1
                strSQL = "SELECT customer_name FROM customer WHERE customer_id='" & Me.dgCS.Rows(sum).Cells(2).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                With Me.dgCS
                    If Dr.HasRows Then
                        .Rows(sum).Cells(3).Value = Dr.Item("customer_name")
                    Else
                        .Rows(sum).Cells(3).Value = "-"
                    End If
                End With
            Next
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try

        Try
            'นับ No.
            For sum As Integer = 0 To Me.dgCS.Rows.Count - 1
                Me.dgCS.Rows(sum).Cells(0).Value = sum + 1
            Next
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try



        Dr.Close()
        Mainfrm.lblMainStatus.Text = "โหลดข้อมูล Claims แล้ว"
        strsqlSelect = Nothing

    End Sub



    Private Sub btnCSshowAll_Click(sender As Object, e As EventArgs) Handles btnCSshowAll.Click
        strsqlSelect = 400
        Call getdataClaims()
    End Sub

    Private Sub txtCSsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCSsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            strsqlSelect = 300
            Call getdataClaims()
        End If
    End Sub

    Private Sub btnCSsearch_Click(sender As Object, e As EventArgs) Handles btnCSsearch.Click
        strsqlSelect = 300
        Call getdataClaims()
    End Sub

    Private Sub btnCRsearchbydate_Click(sender As Object, e As EventArgs) Handles btnCRsearchbydate.Click
        strsqlSelect = 100
        Call getdataClaims()
    End Sub
    Private Sub reportPrint()
        If Me.dgCS.Rows.Count = 0 Then
            MsgBox("ไม่มีข้อมูลที่จะพิมพ์", MsgBoxStyle.Exclamation, "No Data")
        Else
            Me.Cursor = Cursors.WaitCursor
            Mainfrm.lblMainStatus.Text = "ล้างข้อมูลรายงานเก่า"
            Try
                strSQLite = "DELETE FROM claimsreport"
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
            For r As Integer = 0 To Me.dgCS.Rows.Count - 1
                Try
                    strSQLite = "INSERT INTO claimsreport(`no`,claims_id,cus_id,cus_name,`sn`,name_pro,syptom,`status`,t_to_cus,date_in,go_to,`note`)" _
                     & "VALUES(@no,@claims_id,@cus_id,@cus_name,@sn,@name_pro,@syptom,@status,@t_to_cus,@date_in,@go_to,@note)"
                    Mainfrm.lblMainStatus.Text = strSQLite
                    cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                    cmdSQLite.Parameters.AddWithValue("@no", Me.dgCS.Rows(r).Cells(0).Value)
                    cmdSQLite.Parameters.AddWithValue("@claims_id", Me.dgCS.Rows(r).Cells(1).Value)
                    cmdSQLite.Parameters.AddWithValue("@cus_id", Me.dgCS.Rows(r).Cells(2).Value)
                    cmdSQLite.Parameters.AddWithValue("@cus_name", Me.dgCS.Rows(r).Cells(3).Value)
                    cmdSQLite.Parameters.AddWithValue("@sn", Me.dgCS.Rows(r).Cells(4).Value)
                    cmdSQLite.Parameters.AddWithValue("@name_pro", Me.dgCS.Rows(r).Cells(5).Value)
                    cmdSQLite.Parameters.AddWithValue("@syptom", Me.dgCS.Rows(r).Cells(6).Value)
                    cmdSQLite.Parameters.AddWithValue("@status", Me.dgCS.Rows(r).Cells(7).Value)
                    cmdSQLite.Parameters.AddWithValue("@t_to_cus", Me.dgCS.Rows(r).Cells(8).Value)
                    cmdSQLite.Parameters.AddWithValue("@date_in", Me.dgCS.Rows(r).Cells(9).Value)
                    cmdSQLite.Parameters.AddWithValue("@go_to", Me.dgCS.Rows(r).Cells(10).Value)
                    cmdSQLite.Parameters.AddWithValue("@note", Me.dgCS.Rows(r).Cells(11).Value)
                    Call open_connectionSQLite()
                    cmdSQLite.ExecuteNonQuery()
                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                End Try
            Next
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = "โหลดหน้าพิมพ์รายงาน"
            ClaimsReportWorksPrintFrm.Show()
        End If
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Call reportPrint()
    End Sub

    Private Sub cbbCRstatus_Click(sender As Object, e As EventArgs) Handles cbbCRstatus.Click
        Try
            Me.cbbCRstatus.Items.Clear()
            strSQL = "SELECT DISTINCT `status` AS st FROM claims"
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            While Dr.Read()
                Me.cbbCRstatus.Items.Add(Dr.GetString("st"))
            End While
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub cbbCRstatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbCRstatus.SelectedIndexChanged
        strsqlSelect = 500
        Call getdataClaims()
    End Sub
End Class