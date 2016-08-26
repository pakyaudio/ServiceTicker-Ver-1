Imports MySql.Data.MySqlClient
Public Class ViewReceiveReportFrm
    'edit 2015-11-07
  
    Public Sub getDataViewSelectReceiveProductFrm()
        Try
            strSQL = "SELECT code_pro,bar_code,name_pro,price_cost,count_num,total FROM buy_pro WHERE buy_id='" & ReceiveReportFrm.dgVR.SelectedCells.Item(0).Value & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader
            While (Dr.Read())
                Dim r As Integer
                With Me.dgVSRP
                    r = .Rows.Count
                    .Rows.Add()
                    .Rows(r).Cells(1).Value = Dr.GetString("code_pro")
                    .Rows(r).Cells(2).Value = Dr.GetString("bar_code")
                    .Rows(r).Cells(3).Value = Dr.GetString("name_pro")
                    .Rows(r).Cells(4).Value = Dr.GetDecimal("price_cost")
                    .Rows(r).Cells(5).Value = Dr.GetDecimal("count_num")
                    .Rows(r).Cells(6).Value = Dr.GetDecimal("total")
                End With
            End While
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try

        Try
            For num As Integer = 0 To Me.dgVSRP.Rows.Count - 1
                Me.dgVSRP.Rows(num).Cells(0).Value = num + 1
            Next
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try

        Try
            strSQL = "SELECT buy_id,sale_company_id,sale_company_name,datetime_save,employee from buy_pro where buy_id=@1"
            Mainfrm.lblMainStatus.Text = strSQL
            Call open_connection()
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                cmd.Prepare()
                cmd.Parameters.AddWithValue("@1", ReceiveReportFrm.dgVR.SelectedCells.Item(0).Value)
                Dr = cmd.ExecuteReader
                With Dr
                    .Read()
                    Me.txtVSRPbuy_id.Text = .Item("buy_id")
                    Me.txtVSRPsale_company_id.Text = .Item("sale_company_id")
                    Me.txtVSRPsale_company_name.Text = .Item("sale_company_name")
                    Me.txtVSRPdatetim_save.Text = .Item("datetime_save")
                    Me.txtVSRPemployee.Text = .Item("employee")
                End With
            End Using
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub

    Private Sub ViewSelectReceiveProductFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        Call getDataViewSelectReceiveProductFrm()
    End Sub
End Class