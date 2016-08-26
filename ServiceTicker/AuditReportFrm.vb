Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class AuditReportFrm
   
    Private Sub getDataaudit()
        Try
            'สร้างวันที่
            Me.dgAR.Rows.Clear()
            Dim d1 As DateTime = DateTimePicker1.Value
            Dim days1 As Integer = d1.Day
            Dim month1 As Integer = d1.Month
            Dim years1 As Integer = d1.Year
            Dim dt1 As String = years1 & "-" & month1 & "-" & days1
            Dim d2 As DateTime = DateTimePicker2.Value
            Dim days2 As Integer = d2.Day
            Dim month2 As Integer = d2.Month
            Dim years2 As Integer = d2.Year
            Dim dt2 As String = years2 & "-" & month2 & "-" & days2
            For Each Day As DateTime In DateRange(dt1, dt2)
                Dim r As Integer
                With Me.dgAR
                    r = .RowCount
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Day.ToString("yyyy-MM-dd")
                End With
            Next
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
        Try
            Me.Cursor = Cursors.WaitCursor
            'หายอดขาย
            For tt As Integer = 0 To Me.dgAR.Rows.Count - 1
                strSQL = "SELECT COALESCE(SUM(replace(total_all, ',', '')),0) AS ttl FROM cash_sale WHERE " _
                    & "datetime_save LIKE '%" & Me.dgAR.Rows(tt).Cells(0).Value & "%' AND fix_id='" & "ขายสินค้า" & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()

                If Dr.HasRows Then
                    With Me.dgAR
                        .Rows(tt).Cells(1).Value = Dr.GetDecimal(0)
                    End With
                End If
            Next
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try

        Try
            Me.Cursor = Cursors.WaitCursor
            'หายอดซ่อม
            For tt As Integer = 0 To Me.dgAR.Rows.Count - 1
                strSQL = "SELECT COALESCE(SUM(replace(total_all, ',', '')),0) AS ttl FROM cash_sale WHERE " _
                    & "datetime_save LIKE '%" & Me.dgAR.Rows(tt).Cells(0).Value & "%' AND NOT (fix_id='" & "ขายสินค้า" & "')"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgAR
                    .Rows(tt).Cells(2).Value = Dr.GetDecimal("ttl")
                End With
            Next
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
        Try
            'รวมยอดขาย ซ่อม
            Me.Cursor = Cursors.WaitCursor
            For SUMfs As Integer = 0 To Me.dgAR.Rows.Count - 1
                Me.dgAR.Rows(SUMfs).Cells(3).Value = CDec(Me.dgAR.Rows(SUMfs).Cells(1).Value) + CDec(Me.dgAR.Rows(SUMfs).Cells(2).Value)
            Next
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
        '-----------------------------------------------------------------------------------------------------------------------------------'
        Try
            Me.Cursor = Cursors.WaitCursor
            'หายอดทุนขาย
            For tt As Integer = 0 To Me.dgAR.Rows.Count - 1
                strSQL = "SELECT COALESCE(SUM(CAST(price_cost AS DECIMAL(20,2)) * CAST(total_pro AS DECIMAL(20,2))),0) AS one FROM cash_sale_barcode WHERE " _
                    & "datetime_save LIKE '%" & Me.dgAR.Rows(tt).Cells(0).Value & "%' AND (fix_id='" & "ขายสินค้า" & "')"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgAR
                    .Rows(tt).Cells(4).Value = Dr.GetDecimal("one")
                End With
            Next
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
        Try
            Me.Cursor = Cursors.WaitCursor
            'หายอดทุนซ่อม
            For tt As Integer = 0 To Me.dgAR.Rows.Count - 1
                strSQL = "SELECT COALESCE(SUM(CAST(price_cost AS DECIMAL(20,2)) * CAST(total_pro AS DECIMAL(20,2))),0) AS one FROM cash_sale_barcode WHERE " _
                    & "datetime_save LIKE '%" & Me.dgAR.Rows(tt).Cells(0).Value & "%' AND NOT (fix_id='" & "ขายสินค้า" & "')"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgAR
                    .Rows(tt).Cells(5).Value = Dr.GetDecimal("one")
                End With
            Next
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
        Try
            'รวมยอดรวมขาย ซ่อม
            Me.Cursor = Cursors.WaitCursor
            For SUMfs As Integer = 0 To Me.dgAR.Rows.Count - 1
                Me.dgAR.Rows(SUMfs).Cells(6).Value = CDec(Me.dgAR.Rows(SUMfs).Cells(4).Value) + CDec(Me.dgAR.Rows(SUMfs).Cells(5).Value)
            Next
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
        Try
            Me.Cursor = Cursors.WaitCursor
            'หายอดทุนซ่อม
            For tt As Integer = 0 To Me.dgAR.Rows.Count - 1
                strSQL = "SELECT COALESCE(SUM(replace(total_all, ',', '')),0) AS ttl1 FROM pledge_sale WHERE " _
                    & "datetime_save LIKE '%" & Me.dgAR.Rows(tt).Cells(0).Value & "%'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgAR
                    .Rows(tt).Cells(7).Value = Dr.GetDecimal("ttl1")
                End With
            Next
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
        '-----------------------------------------------------------------------------------------------------------------------------------'
        Try
            Me.Cursor = Cursors.WaitCursor
            'หายอดส่วนลด
            For tt As Integer = 0 To Me.dgAR.Rows.Count - 1
                strSQL = "SELECT COALESCE(SUM(replace(discount, ',', '')),0) AS dc FROM discount WHERE " _
                    & "datetime_save LIKE '%" & Me.dgAR.Rows(tt).Cells(0).Value & "%'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgAR
                    .Rows(tt).Cells(8).Value = Dr.GetDecimal("dc")
                End With
            Next
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
        Try
            Me.Cursor = Cursors.WaitCursor
            'หายอดรายจ่าย
            For tt As Integer = 0 To Me.dgAR.Rows.Count - 1
                strSQL = "SELECT COALESCE(SUM(replace(money, ',', '')),0) AS dc FROM audit_outgoings WHERE " _
                    & "datetime LIKE '%" & Me.dgAR.Rows(tt).Cells(0).Value & "%'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgAR
                    .Rows(tt).Cells(9).Value = Dr.GetDecimal("dc")
                End With
            Next
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
        '-----------------------------------------------------------------------------------------------------------------------------------'
        Try
            Me.Cursor = Cursors.WaitCursor
            'หายอดค้างชำระงานขาย
            For tt As Integer = 0 To Me.dgAR.Rows.Count - 1
                strSQL = "SELECT COALESCE(SUM(replace(total_all, ',', '')),0) AS sta FROM sale WHERE " _
                    & "datetime_save LIKE '%" & Me.dgAR.Rows(tt).Cells(0).Value & "%' AND fix_id='" & "ขายสินค้า" & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgAR
                    .Rows(tt).Cells(10).Value = Dr.GetDecimal("sta")
                End With
            Next
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
        Try
            Me.Cursor = Cursors.WaitCursor
            'หายอดค้างชำระงานซ่อม
            For tt As Integer = 0 To Me.dgAR.Rows.Count - 1
                strSQL = "SELECT COALESCE(SUM(replace(total_all, ',', '')),0) AS sta FROM sale WHERE " _
                    & "datetime_save LIKE '%" & Me.dgAR.Rows(tt).Cells(0).Value & "%' AND NOT (fix_id='" & "ขายสินค้า" & "')"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgAR
                    .Rows(tt).Cells(11).Value = Dr.GetDecimal("sta")
                End With
            Next
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
        Try
            'รวมยอดค้างชำระขาย ซ่อม
            Me.Cursor = Cursors.WaitCursor
            For SUMfs As Integer = 0 To Me.dgAR.Rows.Count - 1
                Me.dgAR.Rows(SUMfs).Cells(12).Value = CDec(Me.dgAR.Rows(SUMfs).Cells(10).Value) + CDec(Me.dgAR.Rows(SUMfs).Cells(11).Value)
            Next
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
        '-----------------------------------------------------------------------------------------------------------------------------------'
        Try
            Me.Cursor = Cursors.WaitCursor
            'หายอดค้างทุนขาย
            For tt As Integer = 0 To Me.dgAR.Rows.Count - 1
                strSQL = "SELECT COALESCE(SUM(CAST(price_cost AS DECIMAL(20,2)) * CAST(total_pro AS DECIMAL(20,2))),0) AS one FROM sale_barcode WHERE " _
                    & "datetime_save LIKE '%" & Me.dgAR.Rows(tt).Cells(0).Value & "%' AND (fix_id='" & "ขายสินค้า" & "')"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgAR
                    .Rows(tt).Cells(13).Value = Dr.GetDecimal("one")
                End With
            Next
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
        Try
            Me.Cursor = Cursors.WaitCursor
            'หายอดค้างยอดทุนซ่อม
            For tt As Integer = 0 To Me.dgAR.Rows.Count - 1
                strSQL = "SELECT COALESCE(SUM(CAST(price_cost AS DECIMAL(20,2)) * CAST(total_pro AS DECIMAL(20,2))),0) AS one FROM sale_barcode WHERE " _
                    & "datetime_save LIKE '%" & Me.dgAR.Rows(tt).Cells(0).Value & "%' AND NOT (fix_id='" & "ขายสินค้า" & "')"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgAR
                    .Rows(tt).Cells(14).Value = Dr.GetDecimal("one")
                End With
            Next
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
        Try
            'รวมยอดรวมทุนค้างชำระขาย ซ่อม
            Me.Cursor = Cursors.WaitCursor
            For SUMfs As Integer = 0 To Me.dgAR.Rows.Count - 1
                Me.dgAR.Rows(SUMfs).Cells(15).Value = CDec(Me.dgAR.Rows(SUMfs).Cells(13).Value) + CDec(Me.dgAR.Rows(SUMfs).Cells(14).Value)
            Next
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try

        '-----------------------------------------------------------------------------------------------------------------------------------'

        Try
            Me.Cursor = Cursors.WaitCursor
            'หายอดคืนสินค้างานขาย เครดิต
            For tt As Integer = 0 To Me.dgAR.Rows.Count - 1
                strSQL = "SELECT COALESCE(SUM(replace(total_all, ',', '')),0) AS reproTTLc FROM returnproduct WHERE " _
                    & "datetime_save LIKE '%" & Me.dgAR.Rows(tt).Cells(0).Value & "%' AND (fix_id='" & "ขายสินค้า" & "') AND (return_status='" & "เครดิต" & "')"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgAR
                    .Rows(tt).Cells(16).Value = Dr.GetDecimal("reproTTLc")
                End With
            Next
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
        Try
            Me.Cursor = Cursors.WaitCursor
            'หายอดคืนสินค้างานซ่อม เครดิต
            For tt As Integer = 0 To Me.dgAR.Rows.Count - 1
                strSQL = "SELECT COALESCE(SUM(replace(total_all, ',', '')),0) AS reproTTLf FROM returnproduct WHERE " _
                    & "datetime_save LIKE '%" & Me.dgAR.Rows(tt).Cells(0).Value & "%' AND NOT (fix_id='" & "ขายสินค้า" & "') AND (return_status='" & "เครดิต" & "')"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgAR
                    .Rows(tt).Cells(17).Value = Dr.GetDecimal("reproTTLf")
                End With
            Next
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
        Try
            'รวมยอดคืนรวมขาย ซ่อม เครดิต
            Me.Cursor = Cursors.WaitCursor
            For SUMfs As Integer = 0 To Me.dgAR.Rows.Count - 1
                Me.dgAR.Rows(SUMfs).Cells(18).Value = CDec(Me.dgAR.Rows(SUMfs).Cells(16).Value) + CDec(Me.dgAR.Rows(SUMfs).Cells(17).Value)
            Next
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try

        '-----------------------------------------------------------------------------------------------------------------------------------'

        Try
            Me.Cursor = Cursors.WaitCursor
            'หายอดคืนสินค้างานขาย สด
            For tt As Integer = 0 To Me.dgAR.Rows.Count - 1
                strSQL = "SELECT COALESCE(SUM(replace(total_all, ',', '')),0) AS reproTTLc FROM returnproduct WHERE " _
                    & "datetime_save LIKE '%" & Me.dgAR.Rows(tt).Cells(0).Value & "%' AND (fix_id='" & "ขายสินค้า" & "') AND (return_status='" & "เงินสด" & "')"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgAR
                    .Rows(tt).Cells(19).Value = Dr.GetDecimal("reproTTLc")
                End With
            Next
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
        Try
            Me.Cursor = Cursors.WaitCursor
            'หายอดคืนสินค้างานซ่อม สด
            For tt As Integer = 0 To Me.dgAR.Rows.Count - 1
                strSQL = "SELECT COALESCE(SUM(replace(total_all, ',', '')),0) AS reproTTLf FROM returnproduct WHERE " _
                    & "datetime_save LIKE '%" & Me.dgAR.Rows(tt).Cells(0).Value & "%' AND NOT (fix_id='" & "ขายสินค้า" & "') AND (return_status='" & "เงินสด" & "')"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgAR
                    .Rows(tt).Cells(20).Value = Dr.GetDecimal("reproTTLf")
                End With
            Next
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
        Try
            'รวมยอดคืนรวมขาย ซ่อม สด
            Me.Cursor = Cursors.WaitCursor
            For SUMfs As Integer = 0 To Me.dgAR.Rows.Count - 1
                Me.dgAR.Rows(SUMfs).Cells(21).Value = CDec(Me.dgAR.Rows(SUMfs).Cells(19).Value) + CDec(Me.dgAR.Rows(SUMfs).Cells(20).Value)
            Next
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
        '-----------------------------------------------------------------------------------------------------------------------------------'
        'หายอดจัดซื้อ
        Try
            Me.Cursor = Cursors.WaitCursor
            'หายอดจัดซื้อ
            For tt As Integer = 0 To Me.dgAR.Rows.Count - 1
                strSQL = "SELECT COALESCE(SUM(CAST(REPLACE(`total`,',','') AS DECIMAL(20,2))),0) AS buybuy FROM buy WHERE " _
                    & "datetime_save LIKE '%" & Me.dgAR.Rows(tt).Cells(0).Value & "%' AND status='" & "ได้รับสินค้าแล้ว" & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader
                Dr.Read()
                With Me.dgAR
                    .Rows(tt).Cells(22).Value = Dr.GetDecimal("buybuy")
                End With
            Next
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
        '-----------------------------------------------------------------------------------------------------------------------------------'
        'คำนวนสต็อกที่มี
        Try
            Me.Cursor = Cursors.WaitCursor
            strSQL = "SELECT COALESCE(SUM(replace(count_num, ',', '')),0) AS ProStock FROM product"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Me.txtStockPro.Text = Dr.Item("ProStock")
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try

        'คำนวนราคาขาย
        Try
            Me.Cursor = Cursors.WaitCursor
            strSQL = "SELECT COALESCE(SUM(CAST(price_buy AS DECIMAL(20,2)) * CAST(count_num AS DECIMAL(20,2))),0) AS PBStock FROM product"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Dim ss As Decimal = Dr.GetDecimal("PBStock")
            Me.txtStockBuy.Text = ss.ToString("N2")
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
        'คำนวนราคาทุน
        Try
            Me.Cursor = Cursors.WaitCursor
            strSQL = "SELECT COALESCE(SUM(CAST(price_cost AS DECIMAL(20,2)) * CAST(count_num AS DECIMAL(20,2))),0) AS PCStock FROM product"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Dim sa As Decimal = Dr.GetDecimal("PCStock")
            Me.txtStockCost.Text = sa.ToString("N2")
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
        '-----------------------------------------------------------------------------------------------------------------------------------'
        Try
            'รวมตามตารางแนวตั้ง 
            Me.Cursor = Cursors.WaitCursor
            Mainfrm.lblMainStatus.Text = "SUM DataGridView"
            Dim txt1 As Decimal = 0
            Dim txt2 As Decimal = 0
            Dim txt3 As Decimal = 0
            Dim txt4 As Decimal = 0
            Dim txt5 As Decimal = 0
            Dim txt6 As Decimal = 0
            Dim txt7 As Decimal = 0
            Dim txt8 As Decimal = 0
            Dim txt9 As Decimal = 0
            Dim txt10 As Decimal = 0
            Dim txt11 As Decimal = 0
            Dim txt12 As Decimal = 0
            Dim txt13 As Decimal = 0
            Dim txt14 As Decimal = 0
            Dim txt15 As Decimal = 0
            Dim txt16 As Decimal = 0
            Dim txt17 As Decimal = 0
            Dim txt18 As Decimal = 0
            Dim txt19 As Decimal = 0
            Dim txt20 As Decimal = 0
            Dim txt21 As Decimal = 0
            Dim txt22 As Decimal = 0
            For SUMfs As Integer = 0 To Me.dgAR.Rows.Count - 1
                txt1 += CDec(Me.dgAR.Rows(SUMfs).Cells(1).Value)
                txt2 += CDec(Me.dgAR.Rows(SUMfs).Cells(2).Value)
                txt3 += CDec(Me.dgAR.Rows(SUMfs).Cells(3).Value)
                txt4 += CDec(Me.dgAR.Rows(SUMfs).Cells(4).Value)
                txt5 += CDec(Me.dgAR.Rows(SUMfs).Cells(5).Value)
                txt6 += CDec(Me.dgAR.Rows(SUMfs).Cells(6).Value)
                txt7 += CDec(Me.dgAR.Rows(SUMfs).Cells(7).Value)
                txt8 += CDec(Me.dgAR.Rows(SUMfs).Cells(8).Value)
                txt9 += CDec(Me.dgAR.Rows(SUMfs).Cells(9).Value)
                txt10 += CDec(Me.dgAR.Rows(SUMfs).Cells(10).Value)
                txt11 += CDec(Me.dgAR.Rows(SUMfs).Cells(11).Value)
                txt12 += CDec(Me.dgAR.Rows(SUMfs).Cells(12).Value)
                txt13 += CDec(Me.dgAR.Rows(SUMfs).Cells(13).Value)
                txt14 += CDec(Me.dgAR.Rows(SUMfs).Cells(14).Value)
                txt15 += CDec(Me.dgAR.Rows(SUMfs).Cells(15).Value)
                txt16 += CDec(Me.dgAR.Rows(SUMfs).Cells(16).Value)
                txt17 += CDec(Me.dgAR.Rows(SUMfs).Cells(17).Value)
                txt18 += CDec(Me.dgAR.Rows(SUMfs).Cells(18).Value)
                txt19 += CDec(Me.dgAR.Rows(SUMfs).Cells(19).Value)
                txt20 += CDec(Me.dgAR.Rows(SUMfs).Cells(20).Value)
                txt21 += CDec(Me.dgAR.Rows(SUMfs).Cells(21).Value)
                txt22 += CDec(Me.dgAR.Rows(SUMfs).Cells(22).Value)
            Next
            Me.txt1.Text = txt1.ToString("N2")
            Me.txt2.Text = txt2.ToString("N2")
            Me.txt3.Text = txt3.ToString("N2")
            Me.txt4.Text = txt4.ToString("N2")
            Me.txt5.Text = txt5.ToString("N2")
            Me.txt6.Text = txt6.ToString("N2")
            Me.txt7.Text = txt7.ToString("N2")
            Me.txt8.Text = txt8.ToString("N2")
            Me.txt9.Text = txt9.ToString("N2")
            Me.txt10.Text = txt10.ToString("N2")
            Me.txt11.Text = txt11.ToString("N2")
            Me.txt12.Text = txt12.ToString("N2")
            Me.txt13.Text = txt13.ToString("N2")
            Me.txt14.Text = txt14.ToString("N2")
            Me.txt15.Text = txt15.ToString("N2")
            Me.txt16.Text = txt16.ToString("N2")
            Me.txt17.Text = txt17.ToString("N2")
            Me.txt18.Text = txt18.ToString("N2")
            Me.txt19.Text = txt19.ToString("N2")
            Me.txt20.Text = txt20.ToString("N2")
            Me.txt21.Text = txt21.ToString("N2")
            Me.txtBuy.Text = txt22.ToString("N2")
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
        '-----------------------------------------------------------------------------------------------------------------------------------'
        Me.Cursor = Cursors.Default
        MsgBox("รวบรวมข้อมูลเสร็จเรียบร้อย", MsgBoxStyle.Information, "แจ้งเพื่อทราบ")
     
    End Sub
   
    Private Sub AuditReportFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        DateTimePicker1.Value = Date.Now.AddDays(0)
        DateTimePicker2.Value = Date.Now.AddDays(0)
    End Sub

    Private Sub btnARshowData_Click(sender As Object, e As EventArgs) Handles btnARshowData.Click
        Dim dtt1 As DateTime = Convert.ToDateTime(DateTimePicker1.Value)
        Dim dtt2 As DateTime = Convert.ToDateTime(DateTimePicker2.Value)
        Dim ts As TimeSpan = dtt2.Subtract(dtt1)
        If Convert.ToInt32(ts.Days) > 300 Then
            If MessageBox.Show("คำเตือน การดึงข้อมูลจำนวนมากอาจใช้เวลานาน ต้องการทำต่อหรือไม่", "ต้องใช้เวลามาก", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Call getDataaudit()
            Else
                Exit Sub
            End If
        Else
            Call getDataaudit()
        End If
    End Sub
   

    Public Shared Function DateRange(Start As DateTime, Thru As DateTime) As IEnumerable(Of Date)
        Return Enumerable.Range(0, (Thru.Date - Start.Date).Days + 1).Select(Function(i) Start.AddDays(i))
    End Function
    
    Private Sub txt1_MouseHover(sender As Object, e As EventArgs) Handles txt1.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txt1.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txt1, thaitext)
    End Sub

    Private Sub txt2_MouseHover(sender As Object, e As EventArgs) Handles txt2.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txt2.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txt2, thaitext)
    End Sub

    Private Sub txt3_MouseHover(sender As Object, e As EventArgs) Handles txt3.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txt3.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txt3, thaitext)
    End Sub

    Private Sub txt4_MouseHover(sender As Object, e As EventArgs) Handles txt4.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txt4.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txt4, thaitext)
    End Sub

    Private Sub txt5_MouseHover(sender As Object, e As EventArgs) Handles txt5.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txt5.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txt5, thaitext)
    End Sub

    Private Sub txt6_MouseHover(sender As Object, e As EventArgs) Handles txt6.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txt6.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txt6, thaitext)
    End Sub

    Private Sub txt7_MouseHover(sender As Object, e As EventArgs) Handles txt7.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txt7.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txt7, thaitext)
    End Sub

    Private Sub txt8_MouseHover(sender As Object, e As EventArgs) Handles txt8.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txt8.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txt8, thaitext)
    End Sub

    Private Sub txt9_MouseHover(sender As Object, e As EventArgs) Handles txt9.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txt9.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txt9, thaitext)
    End Sub

    Private Sub txt10_MouseHover(sender As Object, e As EventArgs) Handles txt10.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txt10.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txt10, thaitext)
    End Sub

    Private Sub txt11_MouseHover(sender As Object, e As EventArgs) Handles txt11.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txt11.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txt11, thaitext)
    End Sub

    Private Sub txt12_MouseHover(sender As Object, e As EventArgs) Handles txt12.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txt12.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txt12, thaitext)
    End Sub

    Private Sub txt13_MouseHover(sender As Object, e As EventArgs) Handles txt13.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txt13.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txt13, thaitext)
    End Sub

    Private Sub txt14_MouseHover(sender As Object, e As EventArgs) Handles txt14.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txt14.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txt14, thaitext)
    End Sub

    Private Sub txt15_MouseHover(sender As Object, e As EventArgs) Handles txt15.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txt15.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txt15, thaitext)
    End Sub

    Private Sub txt16_MouseHover(sender As Object, e As EventArgs) Handles txt16.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txt16.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txt16, thaitext)
    End Sub

    Private Sub txt17_MouseHover(sender As Object, e As EventArgs) Handles txt17.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txt17.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txt17, thaitext)
    End Sub

    Private Sub txt18_MouseHover(sender As Object, e As EventArgs) Handles txt18.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txt18.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txt18, thaitext)
    End Sub

    Private Sub txt19_MouseHover(sender As Object, e As EventArgs) Handles txt19.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txt19.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txt19, thaitext)
    End Sub

    Private Sub txt20_MouseHover(sender As Object, e As EventArgs) Handles txt20.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txt20.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txt20, thaitext)
    End Sub

    Private Sub txt21_MouseHover(sender As Object, e As EventArgs) Handles txt21.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txt21.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txt21, thaitext)
    End Sub

    Private Sub txtStockBuy_MouseHover(sender As Object, e As EventArgs) Handles txtStockBuy.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txtStockBuy.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txtStockBuy, thaitext)
    End Sub

    Private Sub txtStockCost_MouseHover(sender As Object, e As EventArgs) Handles txtStockCost.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txtStockCost.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txtStockCost, thaitext)
    End Sub

    Private Sub txtBuy_MouseHover(sender As Object, e As EventArgs) Handles txtBuy.MouseHover
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(Me.txtBuy.Text)
        Catch ex As Exception
            thaitext = ""
        End Try
        ToolTip1.SetToolTip(txtBuy, thaitext)
    End Sub


End Class