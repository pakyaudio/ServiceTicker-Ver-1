Imports MySql.Data.MySqlClient
Public Class ViewProductReturnFrm
    'edit 2015-11-08
  
    Private Sub getDatatodgRPorderpro()
        Try
            Me.dgVPR.Refresh()
            ds = New DataSet
            dt = New DataTable

            strSQL = "select code_pro,name_pro,total,price_buy,unit from returnproduct_barcode where fix_id='" & Me.txtVPRfix_id.Text & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            'strSQL = "select code_pro from sale_barcode where fix_id='" & Me.txtVPRfix_id.Text & "'"
            dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
            Call open_connection()
            dtAdapter.Fill(ds, "returnproduct_barcode")
            Me.dgVPR.DataSource = ds.Tables(0)

            strSQL = "SELECT customer_id,sale_id,datetime_save,customer_name,total_all,employee from returnproduct where fix_id=@1"
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
                Me.txtVPRtotal_all.Text = .GetDecimal("total_all")
                Me.txtVPRemployee.Text = .Item("employee")
            End With
            Dr.Close()
            Call totalXdata()
            Call totalSumPrice_buy()
            Call countRows()
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = ex.Message
            MsgBox("ไม่พบรายการสินค้า", MsgBoxStyle.Information, "แจ้งให้ทราบ")
            Me.Close()
        End Try
    End Sub
    Private Sub totalSumPrice_buy()
        'If dgRPorderPro.RowCount > 1 Then
        Dim oop As Decimal = 0
        For index As Integer = 0 To dgVPR.RowCount - 1
            oop += CDec(Me.dgVPR.Rows(index).Cells(0).Value)
        Next
        Me.txtVPRtotalProduct.Text = "รวม " & oop & " บาท"
        'End If
    End Sub
    Private Sub countRows()
        For index As Integer = 0 To dgVPR.RowCount
            Me.txtVPRlistCount.Text = "มี " & index.ToString & " รายการ"
        Next
    End Sub

    Private Sub totalXdata()
        For f = 0 To dgVPR.RowCount - 1
            Me.dgVPR.Rows(f).Cells(0).Value = CDec(Me.dgVPR.Rows(f).Cells(4).Value) * CDec(Me.dgVPR.Rows(f).Cells(3).Value)
        Next
    End Sub

    Private Sub txtVPRsale_id_TextChanged(sender As Object, e As EventArgs) Handles txtVPRfix_id.TextChanged
        Call getDatatodgRPorderpro()
    End Sub

    Private Sub ViewProductReturnFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        dgVPR.DataSource = dt
    End Sub
End Class