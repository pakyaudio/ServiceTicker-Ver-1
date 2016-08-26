Imports MySql.Data.MySqlClient

Public Class CheckHistoryViewProFrm
    Friend Sub searchDataSN()
        Try
            Mainfrm.lblMainStatus.Text = "โหลด comfix"
            Me.dgCHVP.Rows.Clear()
            strSQL = "SELECT name_pro,code_pro,bar_code,serial_pro,date_in,datetime_save,employee FROM cash_sale_serial WHERE fix_id='" & Me.txtVHCPfixid.Text & "'"
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dim r As Integer
                While (Dr.Read())
                    With Me.dgCHVP
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(0).Value = Dr.Item("code_pro")
                        .Rows(r).Cells(1).Value = Dr.Item("bar_code")
                        .Rows(r).Cells(2).Value = Dr.Item("serial_pro")
                        .Rows(r).Cells(3).Value = Dr.Item("name_pro")
                        .Rows(r).Cells(4).Value = Dr.Item("date_in")
                        .Rows(r).Cells(5).Value = Dr.Item("datetime_save")
                        .Rows(r).Cells(6).Value = Dr.Item("employee")
                    End With
                End While
            End Using
            Mainfrm.lblMainStatus.Text = "โหลด comfix แล้ว"
            Mainfrm.lblMainStatus.Text = "โหลด sale_serial"
            strSQL = "SELECT name_pro,code_pro,bar_code,serial_pro,date_in,datetime_save,employee FROM sale_serial WHERE fix_id='" & Me.txtVHCPfixid.Text & "'"
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dim r As Integer
                While (Dr.Read())
                    With Me.dgCHVP
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(0).Value = Dr.Item("code_pro")
                        .Rows(r).Cells(1).Value = Dr.Item("bar_code")
                        .Rows(r).Cells(2).Value = Dr.Item("serial_pro")
                        .Rows(r).Cells(3).Value = Dr.Item("name_pro")
                        .Rows(r).Cells(4).Value = Dr.Item("date_in")
                        .Rows(r).Cells(5).Value = Dr.Item("datetime_save")
                        .Rows(r).Cells(6).Value = Dr.Item("employee")
                    End With
                End While
            End Using

            Dr.Close()
            Mainfrm.lblMainStatus.Text = "โหลด sale_serial แล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "โหลดข้อมูลผิดพลาด"
        End Try
    End Sub

    Private Sub btnVHCPcheckVaruntee_Click(sender As Object, e As EventArgs) Handles btnVHCPcheckVaruntee.Click
        VarunteeCheckSNFrm.MdiParent = Mainfrm
        VarunteeCheckSNFrm.Show()
        VarunteeCheckSNFrm.txtVCSNsearch.Text = Me.dgCHVP.SelectedCells.Item(2).Value
        Call VarunteeCheckSNFrm.searchData()
    End Sub

    Private Sub CheckHistoryViewProFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
    End Sub
End Class