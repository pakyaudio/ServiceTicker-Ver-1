Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class ViewQuotationFrm
   
    Dim strSelect As Integer
    Private Sub getDtatQuotation()
        Try
        Me.dgVQ.Rows.Clear()
        Me.txtVQshowDetail.Text = "คลิ๊กที่ตารางเพื่อดูชื่อลูกค้า ดับเบิ๊ลคลิ๊กเพื่อดูข้อมูลใบสินค้าทั้งหมดในใบเสนอราคาหมายเลขนั้น"
        If strSelect = 100 Then
            If Me.txtVQsearch.Text = "" Then
                Exit Sub
            Else
                strSQL = "SELECT quotation_id,customer_id,code_pro,name_pro,unit,total_pro,price_buy,multiply,datetime_save FROM quotation where name_pro LIKE '%" & Me.txtVQsearch.Text & "%'"
            End If
        ElseIf strSelect = 200 Then
            strSQL = "SELECT quotation_id,customer_id,code_pro,name_pro,unit,total_pro,price_buy,multiply,datetime_save FROM quotation WHERE datetime_save BETWEEN '" & Convert.ToDateTime(DateTimePicker1.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "' AND '" & Convert.ToDateTime(DateTimePicker2.Value).ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "'"
        ElseIf strSelect = 300 Then
            strSQL = "SELECT quotation_id,customer_id,code_pro,name_pro,unit,total_pro,price_buy,multiply,datetime_save FROM quotation WHERE quotation_id='" & dgcell & "'"
        ElseIf strSelect = 400 Then
            strSQL = "SELECT quotation_id,customer_id,code_pro,name_pro,unit,total_pro,price_buy,multiply,datetime_save FROM quotation"

        End If
        Mainfrm.lblMainStatus.Text = strSQL
        cmd = New MySqlCommand(strSQL, ConnectionDB)
        Call open_connection()
        Dr = cmd.ExecuteReader
        While (Dr.Read())
            Dim r As Integer
                With Me.dgVQ
                    r = .Rows.Count
                    .Rows.Add()
                    .Rows(r).Cells(0).Value = Dr.GetString("quotation_id")
                    .Rows(r).Cells(1).Value = Dr.GetString("customer_id")
                    .Rows(r).Cells(2).Value = Dr.GetString("code_pro")
                    .Rows(r).Cells(3).Value = Dr.GetString("name_pro")
                    .Rows(r).Cells(4).Value = Dr.GetString("unit")
                    .Rows(r).Cells(5).Value = Dr.GetString("total_pro")
                    .Rows(r).Cells(6).Value = Dr.GetDecimal("price_buy")
                    .Rows(r).Cells(7).Value = Dr.GetDecimal("multiply")
                    .Rows(r).Cells(8).Value = Dr.GetString("datetime_save")
                End With
        End While
        strSelect = Nothing
            dgcell = Nothing
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
    End Sub

    Private Sub ViewQuotationFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        Me.btnVQprint.Enabled = False
        Me.btnVQdel.Enabled = False
        DateTimePicker1.Value = DateTime.Now.AddDays(-30)
        DateTimePicker2.Value = DateTime.Now.AddDays(1)
    End Sub

    Private Sub txtVQsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtVQsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            strSelect = 100
            Call getDtatQuotation()
            Me.txtVQsearch.Text = ""
            Me.btnVQprint.Enabled = False
        End If
    End Sub

    Private Sub btnVQsearch_Click(sender As Object, e As EventArgs) Handles btnVQsearch.Click
        strSelect = 100
        Call getDtatQuotation()
        Me.txtVQsearch.Text = ""
        Me.btnVQprint.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        strSelect = 200
        Call getDtatQuotation()
        Me.btnVQprint.Enabled = False
    End Sub
    Dim dgcell As String
    Private Sub dgVQ_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgVQ.CellClick
        Try
        Me.txtVQshowDetail.Clear()
        dgcell = Me.dgVQ.SelectedCells.Item(0).Value
        strSQL = "SELECT customer_name,customer_address,customer_zipcode,customer_tel FROM customer WHERE customer_id='" & Me.dgVQ.SelectedCells.Item(1).Value & "'"
        Mainfrm.lblMainStatus.Text = strSQL
        cmd = New MySqlCommand(strSQL, ConnectionDB)
        Call open_connection()
        Dr = cmd.ExecuteReader
        Dr.Read()
        Me.txtVQshowDetail.Text = "ชื่อ " & Dr("customer_name") & " ที่อยู่ " & Dr("customer_address") & " " & Dr("customer_zipcode") & " เบอร์โทร " & Dr("customer_tel")
        Me.btnVQprint.Enabled = True
            Me.btnVQdel.Enabled = True
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
    End Sub

    Private Sub btnVQprint_Click(sender As Object, e As EventArgs) Handles btnVQprint.Click
        If rbVQwithPic.Checked Then
            ReQotationReportPrintFrm.MdiParent = Mainfrm
            ReQotationReportPrintFrm.Show()
            Me.Close()
        ElseIf rbVQwithOutPic.Checked Then
            ReQotationNoPicReportPrintFrm.MdiParent = Mainfrm
            ReQotationNoPicReportPrintFrm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub dgVQ_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgVQ.CellContentDoubleClick
        Me.txtVQshowDetail.Text = "คลิ๊กที่ตารางเพื่อดูชื่อลูกค้า ดับเบิ๊ลคลิ๊กเพื่อดูข้อมูลใบสินค้าทั้งหมดในใบเสนอราคาหมายเลขนั้น"
        strSelect = 300
        Call getDtatQuotation()
        Me.btnVQprint.Enabled = False
        Me.btnVQdel.Enabled = False
    End Sub

    Private Sub btnVQall_Click(sender As Object, e As EventArgs) Handles btnVQall.Click
        Me.txtVQshowDetail.Text = "คลิ๊กที่ตารางเพื่อดูชื่อลูกค้า ดับเบิ๊ลคลิ๊กเพื่อดูข้อมูลใบสินค้าทั้งหมดในใบเสนอราคาหมายเลขนั้น"
        strSelect = 400
        Call getDtatQuotation()
        Me.btnVQprint.Enabled = False
    End Sub

    Private Sub btnVQdel_Click(sender As Object, e As EventArgs) Handles btnVQdel.Click
        If Me.txtVQshowDetail.Text = "คลิ๊กที่ตารางเพื่อดูชื่อลูกค้า ดับเบิ๊ลคลิ๊กเพื่อดูข้อมูลใบสินค้าทั้งหมดในใบเสนอราคาหมายเลขนั้น" Then
            MsgBox("คลิ๊กเลือกที่ตารางก่อนลบ", MsgBoxStyle.Exclamation, "แจ้งเตือน")
        Else
            Try
                If MessageBox.Show("คุณแน่ใจว่าจะใบเสนอราคา หมายเลข " & dgcell & " นี้", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    strSQL = "DELETE FROM quotation WHERE quotation_id='" & dgcell & "'"
                    Mainfrm.lblMainStatus.Text = strSQL
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                    Call open_connection()
                    cmd.ExecuteNonQuery()
                Else
                    Exit Sub
                End If
                strSelect = 400
                Call getDtatQuotation()
                Me.btnVQprint.Enabled = False
                Me.btnVQdel.Enabled = False
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = ex.Message
            End Try
        End If
    End Sub
End Class