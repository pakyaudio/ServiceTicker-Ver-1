Imports MySql.Data.MySqlClient
Public Class ViewProductRepairFrm
   

    Private Sub ViewProductRepairFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        dgVPR.DataSource = dt

    End Sub
    Private Sub getDatatodgRPorderpro()
        Try

            Me.dgVPR.Refresh()
            ds = New DataSet
            dt = New DataTable
            If SearchRepairFrm.txtSRfixStatus.Text = "7 คืนเครื่องแล้ว" Then
                strSQL = "select code_pro,bar_code,name_pro,total_pro,price_buy,unit from cash_sale_barcode where fix_id='" & Me.txtVPRfix_id.Text & "'"
            Else
                strSQL = "select code_pro,bar_code,name_pro,total_pro,price_buy,unit from sale_barcode where fix_id='" & Me.txtVPRfix_id.Text & "'"
            End If
            Mainfrm.lblMainStatus.Text = strSQL
            'strSQL = "select code_pro from sale_barcode where fix_id='" & Me.txtVPRfix_id.Text & "'"
            dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
            Call open_connection()
            If SearchRepairFrm.txtSRfixStatus.Text = "7 คืนเครื่องแล้ว" Then
                dtAdapter.Fill(ds, "cash_sale_barcode")
            Else
                dtAdapter.Fill(ds, "sale_barcode")
            End If
            Me.dgVPR.DataSource = ds.Tables(0)


            If SearchRepairFrm.txtSRfixStatus.Text = "7 คืนเครื่องแล้ว" Then
                strSQL = "SELECT customer_id,sale_id,datetime_save,customer_name,total_all,employee from cash_sale where fix_id=@1"
            Else
                strSQL = "SELECT customer_id,sale_id,datetime_save,customer_name,total_all,employee from sale where fix_id=@1"
            End If
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            cmd.Prepare()
            cmd.Parameters.AddWithValue("@1", Me.txtVPRfix_id.Text)
            Call open_connection()
            Dr = cmd.ExecuteReader

            With Dr
                .Read()
                Me.txtVPRcustomer_id.Text = .Item("customer_id")
                Me.txtVPRsale_id.Text = .Item("sale_id")
                Me.txtVPRdatetime_save.Text = .Item("datetime_save")
                Me.txtVPRcustomer_name.Text = .Item("customer_name")
                'Me.txtVPRcustomer_tel.Text = .Item("customer_tel")
                Me.txtVPRtotal_all.Text = .Item("total_all")
                Me.txtVPRemployee.Text = .Item("employee")
            End With
            Dr.Close()
            Call totalXdata()
            Call totalSumPrice_buy()
            Call countRows()
        Catch ex As Exception
            'Mainfrm.lblMainStatus.Text = ex.Message
            'MsgBox("ไม่พบรายการสินค้า/อะไหล่หรือยังไม่ได้เบิกสินค้า/อะไหล่ สำหรับงานซ่อมนี้", MsgBoxStyle.Information, "แจ้งให้ทราบ")
            'Me.Close()
        End Try
    End Sub
    Private Sub totalSumPrice_buy()
        'If dgRPorderPro.RowCount > 1 Then
        Dim oop As Decimal = 0
        For index As Integer = 0 To dgVPR.RowCount - 1
            oop += CDec(Me.dgVPR.Rows(index).Cells(0).Value)
        Next
        Me.txtVPRtotalProduct.Text = "รวม " & oop.ToString("N2") & " บาท"
        'End If
    End Sub
    Private Sub countRows()
        For index As Integer = 0 To dgVPR.RowCount
            Me.txtVPRlistCount.Text = "มี " & index.ToString & " รายการ"
        Next
    End Sub

    Private Sub totalXdata()
        For f = 0 To dgVPR.RowCount - 1
            Me.dgVPR.Rows(f).Cells(0).Value = CDbl(Me.dgVPR.Rows(f).Cells(5).Value) * CDbl(Me.dgVPR.Rows(f).Cells(4).Value)
        Next
    End Sub

    Private Sub txtVPRsale_id_TextChanged(sender As Object, e As EventArgs) Handles txtVPRfix_id.TextChanged
        Call getDatatodgRPorderpro()
    End Sub

   
End Class