Imports MySql.Data.MySqlClient
Public Class SearchRepairFrm
   
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.txtSRsearch.BackColor = Color.Orange
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer1.Enabled = False
        Me.txtSRsearch.BackColor = Color.Empty
    End Sub

    Private Sub SendRepairFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
    End Sub
    Dim btnselect As String
    Private Sub cbbSRsearchAll_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbbSRsearchAll.SelectedValueChanged
        If Me.cbbSRsearchAll.Text = "1 รอซ่อม" Then
            btnselect = "1 รอซ่อม"
        ElseIf Me.cbbSRsearchAll.Text = "2 กำลังซ่อม" Then
            btnselect = "2 กำลังซ่อม"
        ElseIf Me.cbbSRsearchAll.Text = "3 รออะไหล่/ส่งเคลม" Then
            btnselect = "3 รออะไหล่/ส่งเคลม"
        ElseIf Me.cbbSRsearchAll.Text = "4 ซ่อมไม่ได้" Then
            btnselect = "4 ซ่อมไม่ได้"
        ElseIf Me.cbbSRsearchAll.Text = "5 ซ่อมเสร็จ" Then
            btnselect = "5 ซ่อมเสร็จ"
        ElseIf Me.cbbSRsearchAll.Text = "6 ยกเลิกซ่อม" Then
            btnselect = "6 ยกเลิกซ่อม"
        ElseIf Me.cbbSRsearchAll.Text = "7 คืนเครื่องแล้ว" Then
            btnselect = "7 คืนเครื่องแล้ว"
        End If
        Call searchDatacomfixBystatus()
    End Sub
    Private Sub searchDatacomfixBystatus()
        Try
            Call ClearTextBoxes(Me)
            Using dt = New DataTable
                Dim strKeyWord As String = btnselect
                Mainfrm.lblMainStatus.Text = "SELECT fix_id,customer_id,customer_name,sn,symptom,managerdata,date_save,date_get,status,note_repair,teltocus"
                strSQL = "SELECT fix_id,customer_id,customer_name,sn,symptom,managerdata,date_save,date_get,status,note_repair,teltocus from comfix where status='" & btnselect & "'"
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)
                Me.dgSRshowComfix.DataSource = dt
            End Using
            For sum As Integer = 0 To Me.dgSRshowComfix.Rows.Count - 1
                Me.dgSRshowComfix.Rows(sum).Cells(0).Value = sum + 1
            Next
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub searchDatacomfix()
        Try
        If Me.txtSRsearch.Text = "" Then
            MsgBox("ใส่คำสำหรับค้นหาด้วย", MsgBoxStyle.Information, "แจ้งเตือน")
            Timer1.Enabled = True
            Timer2.Enabled = True
            Exit Sub
        End If
            Using dt = New DataTable
                Me.dgSRshowComfix.Rows.Clear()
                Dim strKeyWord As String = Me.txtSRsearch.Text
                strSQL = "SELECT fix_id,customer_id,customer_name,`sn`,symptom,managerdata,date_save,date_get,`status`,note_repair,teltocus FROM comfix WHERE "
                If strKeyWord <> "" Then
                    strSQL = strSQL & "fix_id LIKE '%" & strKeyWord & "%' " _
                        & "OR customer_id LIKE '%" & strKeyWord & "%' " _
                        & "OR customer_name LIKE '%" & strKeyWord & "%' " _
                        & "OR `sn` LIKE '%" & strKeyWord & "%' " _
                        & "OR symptom LIKE '%" & strKeyWord & "%' " _
                        & "OR managerdata LIKE '%" & strKeyWord & "%' " _
                        & "OR `status` LIKE '%" & strKeyWord & "%' " _
                        & "OR note_repair LIKE '%" & strKeyWord & "%' " _
                        & "OR teltocus LIKE '%" & strKeyWord & "%';"
                End If
                Mainfrm.lblMainStatus.Text = strSQL
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)
                Me.dgSRshowComfix.DataSource = dt
            End Using
            For sum As Integer = 0 To Me.dgSRshowComfix.Rows.Count - 1
                Me.dgSRshowComfix.Rows(sum).Cells(0).Value = sum + 1
            Next
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub btnSRsearch_Click(sender As Object, e As EventArgs) Handles btnSRsearch.Click
        Call searchDatacomfix()
    End Sub

    Private Sub txtSRsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSRsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call searchDatacomfix()
        End If
    End Sub

    Private Sub dgSRshowComfix_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSRshowComfix.CellDoubleClick
        Call clearall()
        Call get_sale_id()
        Call get_returnProduct()
        Me.txtSRcustomerID.Text = Me.dgSRshowComfix.SelectedCells.Item(2).Value
        Me.txtSRfixSN.Text = Me.dgSRshowComfix.SelectedCells.Item(4).Value
        Me.txtSRfix_id.Text = Me.dgSRshowComfix.SelectedCells.Item(1).Value
    End Sub
    Private Sub clearall()
        Me.txtSRcustomerID.Clear()
        Me.txtSRcustomerDetail.Clear()
        Me.txtSRfixSN.Clear()
        Me.txtSRfixSNdetail.Clear()
        Me.txtSRfix_id.Clear()
        Me.txtSRfix_idDetail.Clear()
        'Me.txtSRsale_id.Clear()
        'Me.txtSRsale_idDetail.Clear()
        'Me.txtSRreturn_id.Clear()
        'Me.txtSRreturn_total_all.Clear()
        'Me.txtSRsale_id.Clear()
        'Me.txtSRsale_idDetail.Clear()
    End Sub
    Private Sub txtSRcustomerID_TextChanged(sender As Object, e As EventArgs) Handles txtSRcustomerID.TextChanged
        Try
            Using dt = New DataTable
                strSQL = "SELECT customer_name,customer_address,customer_zipcode,customer_tel,customer_tax," _
                    & "customer_section FROM customer WHERE customer_id='" & Me.txtSRcustomerID.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)
                Me.txtSRcustomerDetail.Text = "ชื่อ: " & dt.Rows(0).Item("customer_name") & ", " _
                    & "ที่อยู่: " & dt.Rows(0).Item("customer_address") & " รหัสไปรษณีย์: " & dt.Rows(0).Item("customer_zipcode") & ", " _
                    & "เบอร์โทร: " & dt.Rows(0).Item("customer_tel") & ", หมายเลขผู้เสียภาษี: " & dt.Rows(0).Item("customer_tax") & " " _
                    & "สาขา: " & dt.Rows(0).Item("customer_section")
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub txtSRfixSN_TextChanged(sender As Object, e As EventArgs) Handles txtSRfixSN.TextChanged
        Try
            Using dt = New DataTable
                Mainfrm.lblMainStatus.Text = "SELECT p_type,p_name,model,color,startdate"
                strSQL = "SELECT p_type,p_name,`model`,color,startdate FROM `sn` WHERE Snum='" & Me.txtSRfixSN.Text & "'"
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)
                Me.txtSRfixSNdetail.Text = "ประเภท: " & dt.Rows(0).Item("p_type") & ", ยี่ห้อ: " & dt.Rows(0).Item("p_name") & " รุ่น: " & dt.Rows(0).Item("model") & ", สีตัวเครื่อง: " & dt.Rows(0).Item("color") & ", วันที่บันทึกข้อมูล SN: " & dt.Rows(0).Item("startdate")
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Dim frn As String
    Private Sub txtSRfix_id_TextChanged(sender As Object, e As EventArgs) Handles txtSRfix_id.TextChanged
        Try
            'รายละเอียดเกี่ยวกับใบรับงานซ่อม
            Using dt = New DataTable
                strSQL = "SELECT fixrepairnote,fixaccessory,fixnote,fixtprice,fixuser,status,user_repair,note_repair," _
                    & "date_save,date_get,teltocus,date_send FROM comfix WHERE fix_id='" & Me.txtSRfix_id.Text & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
                Call open_connection()
                dtAdapter.Fill(dt)
                Me.txtSRfix_idDetail.Text = "อาการเสียเพิ่มเติม: " & dt.Rows(0).Item("fixrepairnote") & ", " _
                    & "อุปกรณ์ที่นำมาด้วย: " & dt.Rows(0).Item("fixaccessory") & ", " _
                    & "อาการเสียเพิ่มเติม: " & dt.Rows(0).Item("fixnote") & ", " _
                    & "ประเมินราคาซ่อม: " & dt.Rows(0).Item("fixtprice") & ", " _
                    & "พนักงานผู้รับงาน: " & dt.Rows(0).Item("fixuser") & ", " _
                    & "สถานนะงานซ่อม: " & dt.Rows(0).Item("status") & ", " _
                    & "ช่างซ่อม: " & dt.Rows(0).Item("user_repair") & ", " _
                    & "รายละเอียดการซ่อม: " & dt.Rows(0).Item("note_repair") & ", " _
                    & "วันที่รับงานซ่อม: " & dt.Rows(0).Item("date_save") & ", " _
                    & "วันที่นัดรับงานซ่อม: " & dt.Rows(0).Item("date_get") & ", " _
                    & "การแจ้งลูกค้า: " & dt.Rows(0).Item("teltocus") & ", " _
                    & "วันที่ส่งคืนงานซ่อม: " & dt.Rows(0).Item("date_send")
                Me.txtSRfixStatus.Text = dt.Rows(0).Item("status")
                frn = dt.Rows(0).Item("fixrepairnote")
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub


    Private Sub get_sale_id()
        Dim sumTTA As Decimal
        Dim cusid As Decimal
        Dim countTTA As Decimal
        Dim fixid As String = Me.dgSRshowComfix.SelectedCells.Item(1).Value
        Dim countpd, countcashpd, sumcashTTA As Decimal
        'หาผลรวมทุกบิลของใบขายนี้
        Try
            strSQL = "SELECT SUM(total_all) AS tta FROM sale WHERE fix_id='" & fixid & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            sumTTA = Dr.GetDecimal("tta")
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            sumTTA = 0
        End Try

        Try
            strSQL = "SELECT SUM(total1) AS tt1 FROM pledge_sale WHERE customer_id='" & Me.dgSRshowComfix.SelectedCells.Item(2).Value & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            cusid = Dr.GetDecimal("tt1")
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            cusid = 0
        End Try
        
        Try
            strSQL = "SELECT COUNT(fix_id) AS FID FROM sale WHERE fix_id='" & fixid & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            countTTA = Dr.GetDecimal("FID")
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            countTTA = 0
        End Try
       
        Try
            strSQL = "SELECT COUNT(customer_id) AS CID FROM pledge_sale WHERE customer_id='" & Me.dgSRshowComfix.SelectedCells.Item(2).Value & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            countpd = Dr.GetDecimal("CID")
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            countpd = 0
        End Try
        Try
            strSQL = "SELECT COUNT(fix_id) AS fic FROM cash_sale WHERE fix_id='" & fixid & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            countcashpd = Dr.GetDecimal("fic")
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            countcashpd = 0
        End Try
        Try
            strSQL = "SELECT SUM(total_all) AS tal FROM cash_sale WHERE fix_id='" & fixid & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            sumcashTTA = Dr.GetDecimal("tal")
            Dr.Close()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            sumcashTTA = 0
        End Try
        Dim sat As Decimal = sumTTA - cusid
        Me.txtRSsaleDetail.Text = "พบรายการใบเบิกที่ยังไม่ได้ชำระเงินจำนวน " & countTTA & " ใบ " & vbNewLine & _
                                  "รวมราคายังไม่ได้ชำระทั้งหมด " & sumTTA & " บาท" & vbNewLine & _
                                  "พบรายการที่ชำระเงินแล้ว " & countcashpd & " ใบ " & vbNewLine & _
                                  "รวมราคาที่ชำระแล้วทั้งหมด " & sumcashTTA & " บาท" & vbNewLine & _
                                  "พบใบมัดจำ/ลดหนี้ จำนวน " & countpd & " ใบ " & " รวมราคา " & cusid & " บาท" & vbNewLine & _
                                  "รวมราคาที่ต้องชำระทั้งหมด " & sat & " บาท"

    End Sub

    Private Sub get_returnProduct()
        Try
            'หาผลรวม ราคาสินค้าส่งคืนทั้งหมด
            Dim fixid1 As String = dgSRshowComfix.SelectedCells.Item(1).Value
            strSQL = "SELECT SUM(price_buy) AS pb,COUNT(fix_id) AS fid FROM returnproduct_barcode WHERE fix_id='" & fixid1 & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Dim sumTTA As Decimal

            sumTTA = Dr.GetDecimal("pb")


            'นับจำนวนแถวสินค้าส่งคืน
            strSQL = "SELECT COUNT(fix_id) AS fid FROM returnproduct_barcode WHERE fix_id='" & fixid1 & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            Dr.Read()
            Dim countTTA As Decimal
            countTTA = Dr.GetDecimal("fid")

            Me.txtSRreturnDetail.Text = "พบรายการคืนสินค้าจำนวน " & countTTA & " รายการ " & vbNewLine & "รวมราคาทั้งหมด " & sumTTA & " บาท"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
            Me.txtSRreturnDetail.Text = "ข้อมูลคืนสินค้า ไม่พบข้อมูลการคืนสินค้า" & vbNewLine
        End Try
    End Sub

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.dgSRshowComfix.RowCount = 0 Then
            Mainfrm.lblMainStatus.Text = "กรุณาดับเบิ๊ลคลิ๊กเลือกรายการงานซ่อมที่ต้องการดูรายการสินค้าก่อน"
            MsgBox("กรุณาดับเบิ๊ลคลิ๊กเลือกรายการงานซ่อมที่ต้องการดูรายการสินค้าก่อน", MsgBoxStyle.Information, "แจ้งเตือน")
        Else
            If frn = "ส่งมาจากงานเคลม" Then
                Mainfrm.lblMainStatus.Text = "สินค้านี้เป็นสินค้าเคลมต้องส่งกลับไปที่งานเคลม โปรดทำส่งกลับในหน้า สถานะงานซ่อม"
                MsgBox("สินค้านี้เป็นสินค้าเคลมต้องส่งกลับไปที่งานเคลม โปรดทำส่งกลับในหน้าสถานะงานซ่อม", MsgBoxStyle.Information, "แจ้งเตือน")
                Exit Sub
            Else
                If Me.txtSRfixStatus.Text = "5 ซ่อมเสร็จ" Or Me.txtSRfixStatus.Text = "6 ยกเลิกซ่อม" Or Me.txtSRfixStatus.Text = "4 ซ่อมไม่ได้" Then
                    If Me.txtSRfix_id.Text = "" Then
                        Mainfrm.lblMainStatus.Text = "กรุณาเลือกงานซ่อมก่อน"
                        MsgBox("กรุณาเลือกงานซ่อมก่อน", MsgBoxStyle.Information, "แจ้งเตือน")
                    Else
                        SendRepairFrm.txtHideform.Text = Me.txtSRfix_id.Text
                        SendRepairFrm.cbbSRRcash_status.Enabled = True
                        SendRepairFrm.DateTimePickerSRR.Enabled = True
                        SendRepairFrm.MdiParent = Mainfrm
                        SendRepairFrm.Show()
                        Me.Close()
                    End If
                Else
                    Mainfrm.lblMainStatus.Text = "ต้องเป็นสถานะ ยกเลิกซ่อม, ซ่อมเสร็จ หรือ ซ่อมไม่ได้ ถึงจะทำคืนเครื่องได้ กรุณากลับไปกำหนดสถานะให้เรียบร้อยก่อน"
                    MsgBox("ต้องเป็นสถานะ ยกเลิกซ่อม, ซ่อมเสร็จ หรือ ซ่อมไม่ได้ ถึงจะทำคืนเครื่องได้ กรุณากลับไปกำหนดสถานะให้เรียบร้อยก่อน", MsgBoxStyle.Information, "แจ้งเตือน")
                End If
            End If
            End If
    End Sub

    Private Sub cbbSRsearchAll_Click(sender As Object, e As EventArgs) Handles cbbSRsearchAll.Click
        Me.cbbSRsearchAll.Items.Clear()
        Me.cbbSRsearchAll.Items.Add("1 รอซ่อม")
        Me.cbbSRsearchAll.Items.Add("2 กำลังซ่อม")
        Me.cbbSRsearchAll.Items.Add("3 รออะไหล่/ส่งเคลม")
        Me.cbbSRsearchAll.Items.Add("4 ซ่อมไม่ได้")
        Me.cbbSRsearchAll.Items.Add("5 ซ่อมเสร็จ")
        Me.cbbSRsearchAll.Items.Add("6 ยกเลิกซ่อม")
        Me.cbbSRsearchAll.Items.Add("7 คืนเครื่องแล้ว")

    End Sub

    Private Sub btnSRsearchAll_Click(sender As Object, e As EventArgs) Handles btnSRsearchAll.Click
        Call ClearTextBoxes(Me)
        Call searchDatacomfixBystatus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.dgSRshowComfix.RowCount = 0 Then
            Mainfrm.lblMainStatus.Text = "กรุณาดับเบิ๊ลคลิ๊กเลือกรายการงานซ่อมที่ต้องการดูรายการสินค้าก่อน"
            MsgBox("กรุณาดับเบิ๊ลคลิ๊กเลือกรายการงานซ่อมที่ต้องการดูรายการสินค้าก่อน", MsgBoxStyle.Information, "แจ้งเตือน")
        Else
            ViewProductRepairFrm.MdiParent = Mainfrm
            ViewProductRepairFrm.Show()
            ViewProductRepairFrm.txtVPRfix_id.Text = Me.dgSRshowComfix.SelectedCells.Item(1).Value
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Me.dgSRshowComfix.RowCount = 0 Then
            Mainfrm.lblMainStatus.Text = "กรุณาดับเบิ๊ลคลิ๊กเลือกรายการงานซ่อมที่ต้องการดูรายการสินค้าก่อน"
            MsgBox("กรุณาดับเบิ๊ลคลิ๊กเลือกรายการงานซ่อมที่ต้องการดูรายการสินค้าก่อน", MsgBoxStyle.Information, "แจ้งเตือน")
        Else
            ViewProductReturnFrm.MdiParent = Mainfrm
            ViewProductReturnFrm.Show()
            ViewProductReturnFrm.txtVPRfix_id.Text = Me.dgSRshowComfix.SelectedCells.Item(1).Value
        End If
    End Sub

End Class