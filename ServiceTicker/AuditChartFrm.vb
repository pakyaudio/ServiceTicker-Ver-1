Imports MySql.Data.MySqlClient
Imports System.Data.SQLite

Public Class AuditChartFrm

    Private Sub AuditChartFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        Call GetYears()
        Call SelectTab()
    End Sub

    Private Sub GetYears()
        Try
            Me.cbbACyears.Items.Clear()
            strSQL = "SELECT DISTINCT YEAR(datetime_save) AS ds FROM cash_sale ORDER BY datetime_save DESC"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read
                Me.cbbACyears.Items.Add(Dr.GetString("ds"))
            End While
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub SelectTab()
        If Me.TabControl1.SelectedTab Is TabPage1 Then
            Me.Label1.Visible = True
            Me.cbbACyears.Visible = True
            Me.btnACgetData.Visible = False
            Me.lblLimit.Visible = False
            Me.lblYear.Visible = False
            Me.PictureBox1.Visible = True
            Me.NumericUpDown1.Visible = False
        ElseIf Me.TabControl1.SelectedTab Is TabPage2 Then
            Me.Label1.Visible = True
            Me.cbbACyears.Visible = True
            Me.btnACgetData.Visible = False
            Me.lblLimit.Visible = False
            Me.lblYear.Visible = False
            Me.PictureBox1.Visible = False
            Me.NumericUpDown1.Visible = False
        ElseIf Me.TabControl1.SelectedTab Is TabPage3 Then
            Me.Label1.Visible = False
            Me.cbbACyears.Visible = False
            Me.btnACgetData.Visible = True
            Me.lblLimit.Visible = True
            Me.lblYear.Visible = True
            Me.PictureBox1.Visible = True
            Me.NumericUpDown1.Visible = True
        ElseIf Me.TabControl1.SelectedTab Is TabPage4 Then
            Me.Label1.Visible = False
            Me.cbbACyears.Visible = False
            Me.btnACgetData.Visible = True
            Me.lblLimit.Visible = True
            Me.lblYear.Visible = True
            Me.PictureBox1.Visible = False
            Me.NumericUpDown1.Visible = True
        End If
    End Sub
    'ข้อมูลเป็น ปี แสดงย่อยเป็นเดือน
    Private Sub cbbACyears_TextChanged(sender As Object, e As EventArgs) Handles cbbACyears.TextChanged
        Me.dgACnumber.Rows.Clear()
        For mount As Integer = 0 To 12
            Me.dgACnumber.Rows.Add()
        Next
        With Me.dgACnumber
            .Rows(0).Cells(0).Value = "มกราคม"
            .Rows(1).Cells(0).Value = "กุมภาพันธ์"
            .Rows(2).Cells(0).Value = "มีนาคม"
            .Rows(3).Cells(0).Value = "เมษายน"
            .Rows(4).Cells(0).Value = "พฤษภาคม"
            .Rows(5).Cells(0).Value = "มิถุนายน"
            .Rows(6).Cells(0).Value = "กรกฏาคม"
            .Rows(7).Cells(0).Value = "สิงหาคม"
            .Rows(8).Cells(0).Value = "กันยายน"
            .Rows(9).Cells(0).Value = "ตุลาคม"
            .Rows(10).Cells(0).Value = "พฤจิกายน"
            .Rows(11).Cells(0).Value = "ธันวาคม"
            .Rows(12).Cells(0).Value = "รวม"
        End With


        Dim mmo As Date
        For tt As Integer = 0 To Me.dgACnumber.Rows.Count - 1
            With Me.dgACnumber
                If .Rows(tt).Cells(0).Value = "มกราคม" Then
                    mmo = Me.cbbACyears.Text & "-" & "01"
                ElseIf .Rows(tt).Cells(0).Value = "กุมภาพันธ์" Then
                    mmo = Me.cbbACyears.Text & "-" & "02"
                ElseIf .Rows(tt).Cells(0).Value = "มีนาคม" Then
                    mmo = Me.cbbACyears.Text & "-" & "03"
                ElseIf .Rows(tt).Cells(0).Value = "เมษายน" Then
                    mmo = Me.cbbACyears.Text & "-" & "04"
                ElseIf .Rows(tt).Cells(0).Value = "พฤษภาคม" Then
                    mmo = Me.cbbACyears.Text & "-" & "05"
                ElseIf .Rows(tt).Cells(0).Value = "มิถุนายน" Then
                    mmo = Me.cbbACyears.Text & "-" & "06"
                ElseIf .Rows(tt).Cells(0).Value = "กรกฏาคม" Then
                    mmo = Me.cbbACyears.Text & "-" & "07"
                ElseIf .Rows(tt).Cells(0).Value = "สิงหาคม" Then
                    mmo = Me.cbbACyears.Text & "-" & "08"
                ElseIf .Rows(tt).Cells(0).Value = "กันยายน" Then
                    mmo = Me.cbbACyears.Text & "-" & "09"
                ElseIf .Rows(tt).Cells(0).Value = "ตุลาคม" Then
                    mmo = Me.cbbACyears.Text & "-" & "10"
                ElseIf .Rows(tt).Cells(0).Value = "พฤจิกายน" Then
                    mmo = Me.cbbACyears.Text & "-" & "11"
                ElseIf .Rows(tt).Cells(0).Value = "ธันวาคม" Then
                    mmo = Me.cbbACyears.Text & "-" & "12"
                End If
            End With
            Try
                Mainfrm.lblMainStatus.Text = mmo.ToString("yyyy-MM")
                strSQL = "SELECT COALESCE(SUM(replace(total_all, ',', '')),0) AS ttl FROM cash_sale WHERE " _
                     & "datetime_save LIKE '%" & mmo.ToString("yyyy-MM") & "%'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgACnumber
                    .Rows(tt).Cells(1).Value = Dr.GetDecimal("ttl")
                End With
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
            Try
                'หายอดจัดซื้อ
                strSQL = "SELECT COALESCE(SUM(CAST(REPLACE(`total`,',','') AS DECIMAL(20,2))),0) AS buybuy FROM buy WHERE " _
                    & "datetime_save LIKE '%" & mmo.ToString("yyyy-MM") & "%' AND status='" & "ได้รับสินค้าแล้ว" & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgACnumber
                    .Rows(tt).Cells(2).Value = Dr.GetDecimal("buybuy")
                End With
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
            'หายอดรวม
            Try
                Dim sale As Decimal = 0
                Dim buy As Decimal = 0
                Dim allProfit As Decimal = 0
                For i As Integer = 0 To Me.dgACnumber.Rows.Count - 1
                    Me.dgACnumber.Rows(i).Cells(3).Value = CDec(Me.dgACnumber.Rows(i).Cells(1).Value) - CDec(Me.dgACnumber.Rows(i).Cells(2).Value)
                    sale += CDec(Me.dgACnumber.Rows(i).Cells(1).Value)
                    buy += CDec(Me.dgACnumber.Rows(i).Cells(2).Value)
                    allProfit += CDec(Me.dgACnumber.Rows(i).Cells(3).Value)
                Next
                Me.dgACnumber.Rows(12).Cells(1).Value = sale
                Me.dgACnumber.Rows(12).Cells(2).Value = buy
                Me.dgACnumber.Rows(12).Cells(3).Value = allProfit
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
            Try
                Chart1.Series("ยอดขาย/ซ่อม").Points.Clear()
                Chart1.Series("ยอดจัดซื้อ").Points.Clear()
                For i As Integer = 0 To Me.dgACnumber.Rows.Count - 1
                    Chart1.Series("ยอดขาย/ซ่อม").Points.AddXY(Me.dgACnumber.Rows(i).Cells(0).Value, Me.dgACnumber.Rows(i).Cells(1).Value)
                    Chart1.Series("ยอดจัดซื้อ").Points.AddXY(Me.dgACnumber.Rows(i).Cells(0).Value, Me.dgACnumber.Rows(i).Cells(2).Value)
                Next
                Chart1.Titles(0).Text = "ปีดำเนินการ " & Me.cbbACyears.Text
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
            mmo = Nothing
        Next
    End Sub
    'ข้อมูลเป็น ปี (รวมทั้งปี)
    Private Sub GetDataInYear()
        'หาปี
        Try
            Me.dgACinYear.Rows.Clear()
            strSQL = "SELECT DISTINCT YEAR(datetime_save) AS ds FROM cash_sale ORDER BY datetime_save DESC LIMIT " & Me.NumericUpDown1.Value & ""
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While Dr.Read
                Dim r As Integer
                With Me.dgACinYear
                    r = .Rows.Count
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.GetString("ds")
                End With
            End While
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        'บวกจำนวนเงิน ตามปีที่หาได้

        For tt As Integer = 0 To Me.dgACinYear.Rows.Count - 1
            Try
                Mainfrm.lblMainStatus.Text = Me.dgACinYear.Rows(tt).Cells(0).Value
                strSQL = "SELECT COALESCE(SUM(replace(total_all, ',', '')),0) AS ttl FROM cash_sale WHERE " _
                     & "datetime_save LIKE '%" & Me.dgACinYear.Rows(tt).Cells(0).Value & "%'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgACinYear
                    .Rows(tt).Cells(1).Value = Dr.GetDecimal("ttl")
                End With
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
            Try
                'หายอดจัดซื้อ
                Mainfrm.lblMainStatus.Text = Me.dgACinYear.Rows(tt).Cells(0).Value
                strSQL = "SELECT COALESCE(SUM(CAST(REPLACE(`total`,',','') AS DECIMAL(20,2))),0) AS buybuy FROM buy WHERE " _
                    & "datetime_save LIKE '%" & Me.dgACinYear.Rows(tt).Cells(0).Value & "%' AND status='" & "ได้รับสินค้าแล้ว" & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgACinYear
                    .Rows(tt).Cells(2).Value = Dr.GetDecimal("buybuy")
                End With
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            End Try
        Next
        'หายอดรวม
        Try
            Dim sale_y As Decimal = 0
            Dim buy_y As Decimal = 0
            Dim allProfit_y As Decimal = 0
            For i As Integer = 0 To Me.dgACinYear.Rows.Count - 1
                Me.dgACinYear.Rows(i).Cells(3).Value = CDec(Me.dgACinYear.Rows(i).Cells(1).Value) - CDec(Me.dgACinYear.Rows(i).Cells(2).Value)
                sale_y += CDec(Me.dgACinYear.Rows(i).Cells(1).Value)
                buy_y += CDec(Me.dgACinYear.Rows(i).Cells(2).Value)
                allProfit_y += CDec(Me.dgACinYear.Rows(i).Cells(3).Value)
            Next
            Me.dgACinYear.Rows(12).Cells(1).Value = sale_y
            Me.dgACinYear.Rows(12).Cells(2).Value = buy_y
            Me.dgACinYear.Rows(12).Cells(3).Value = allProfit_y
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
        Try
            Chart2.Series("ยอดขาย/ซ่อม").Points.Clear()
            Chart2.Series("ยอดจัดซื้อ").Points.Clear()
            For i As Integer = 0 To Me.dgACinYear.Rows.Count - 1
                Chart2.Series("ยอดขาย/ซ่อม").Points.AddXY(Me.dgACinYear.Rows(i).Cells(0).Value, Me.dgACinYear.Rows(i).Cells(1).Value)
                Chart2.Series("ยอดจัดซื้อ").Points.AddXY(Me.dgACinYear.Rows(i).Cells(0).Value, Me.dgACinYear.Rows(i).Cells(2).Value)
            Next
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try

    End Sub
    Private Sub TabControl1_Click(sender As Object, e As EventArgs) Handles TabControl1.Click
        Call SelectTab()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click
        Call SelectTab()
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click
        Call SelectTab()

    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click
        Call SelectTab()
    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click
        Call SelectTab()
    End Sub

    Private Sub btnACgetData_Click(sender As Object, e As EventArgs) Handles btnACgetData.Click
        Call GetDataInYear()
    End Sub
    Friend header, hhtext As String
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Me.TabControl1.SelectedTab Is TabPage1 Then
            If Me.dgACnumber.Rows.Count = 0 Then
                MsgBox("ไม่มีข้อมูลในตาราง", MsgBoxStyle.Information, "ไม่มีข้อมูล")
            Else
                Me.Cursor = Cursors.WaitCursor
                Mainfrm.lblMainStatus.Text = "ล้างข้อมูลรายงานเก่า"
                Try
                    strSQLite = "DELETE FROM satitis"
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
                For r As Integer = 0 To Me.dgACnumber.Rows.Count - 1
                    Try
                        strSQLite = "INSERT INTO satitis(m,sale_fix,buy,profit)" _
                         & "VALUES(@m,@sale_fix,@buy,@profit)"
                        Mainfrm.lblMainStatus.Text = strSQLite
                        cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                        cmdSQLite.Parameters.AddWithValue("@m", Me.dgACnumber.Rows(r).Cells(0).Value)
                        cmdSQLite.Parameters.AddWithValue("@sale_fix", Me.dgACnumber.Rows(r).Cells(1).Value)
                        cmdSQLite.Parameters.AddWithValue("@buy", Me.dgACnumber.Rows(r).Cells(2).Value)
                        cmdSQLite.Parameters.AddWithValue("@profit", Me.dgACnumber.Rows(r).Cells(3).Value)

                        Call open_connectionSQLite()
                        cmdSQLite.ExecuteNonQuery()
                    Catch ex As Exception
                        Me.Cursor = Cursors.Default
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try
                Next
                Me.Cursor = Cursors.Default
                Mainfrm.lblMainStatus.Text = "โหลดหน้าพิมพ์รายงาน"
                header = Me.cbbACyears.Text
                hhtext = "เดือน"
                AuditSatitisPrintFrm.Show()
            End If
        ElseIf Me.TabControl1.SelectedTab Is TabPage3 Then
            If Me.dgACinYear.Rows.Count = 0 Then
                MsgBox("ไม่มีข้อมูลในตาราง", MsgBoxStyle.Information, "ไม่มีข้อมูล")
            Else
                Me.Cursor = Cursors.WaitCursor
                Mainfrm.lblMainStatus.Text = "ล้างข้อมูลรายงานเก่า"
                Try
                    strSQLite = "DELETE FROM satitis"
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
                For r As Integer = 0 To Me.dgACinYear.Rows.Count - 1
                    Try
                        strSQLite = "INSERT INTO satitis(m,sale_fix,buy,profit)" _
                         & "VALUES(@m,@sale_fix,@buy,@profit)"
                        Mainfrm.lblMainStatus.Text = strSQLite
                        cmdSQLite = New SQLiteCommand(strSQLite, connSQLite)
                        cmdSQLite.Parameters.AddWithValue("@m", Me.dgACinYear.Rows(r).Cells(0).Value)
                        cmdSQLite.Parameters.AddWithValue("@sale_fix", Me.dgACinYear.Rows(r).Cells(1).Value)
                        cmdSQLite.Parameters.AddWithValue("@buy", Me.dgACinYear.Rows(r).Cells(2).Value)
                        cmdSQLite.Parameters.AddWithValue("@profit", Me.dgACinYear.Rows(r).Cells(3).Value)

                        Call open_connectionSQLite()
                        cmdSQLite.ExecuteNonQuery()
                    Catch ex As Exception
                        Me.Cursor = Cursors.Default
                        Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
                    End Try
                Next
                Me.Cursor = Cursors.Default
                Mainfrm.lblMainStatus.Text = "โหลดหน้าพิมพ์รายงาน"
                header = ""
                hhtext = "ปี"
                AuditSatitisPrintFrm.Show()
            End If
        End If
    End Sub
End Class