Imports MySql.Data.MySqlClient

Public Class ReturnClaimsToCusFrm
    Friend strsqlSelect As String
    Private Sub Data_History_Bus_Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub
   
    Friend Sub getdataClaims()
        Try
            Mainfrm.lblMainStatus.Text = "โหลดข้อมูล Claims"
            Me.dgRCTC.Rows.Clear()
            If strsqlSelect = 100 Then
                strSQL = "SELECT claims_id,customer_id,serial_pro,name_pro,datetime_save FROM claims WHERE status='" & "รอส่งคืน" & "'"
                Mainfrm.lblMainStatus.Text = strSQL
            ElseIf strsqlSelect = 200 Then
                strSQL = "SELECT claims_id,customer_id,serial_pro,name_pro,datetime_save FROM claims WHERE "
                Dim strKeyWord As String = Me.txtRTCTsearchSN.Text
                If strKeyWord <> "" Then
                    strSQL = strSQL & "serial_pro like '%" & strKeyWord & "%';"
                End If
                Mainfrm.lblMainStatus.Text = strSQL
            End If
            Using cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dim r As Integer

                Application.DoEvents()
                While (Dr.Read())
                    With Me.dgRCTC
                        r = .RowCount
                        .Rows.Add()
                        .Rows(r).Cells(1).Value = Dr.Item("claims_id")
                        .Rows(r).Cells(2).Value = Dr.Item("customer_id")
                        .Rows(r).Cells(4).Value = Dr.Item("serial_pro")
                        .Rows(r).Cells(5).Value = Dr.Item("name_pro")
                        .Rows(r).Cells(6).Value = Dr.Item("datetime_save")
                    End With
                End While
            End Using
            For sum As Integer = 0 To Me.dgRCTC.Rows.Count - 1
                Me.dgRCTC.Rows(sum).Cells(0).Value = sum + 1
                strSQL = "SELECT customer_name FROM customer WHERE customer_id='" & Me.dgRCTC.Rows(sum).Cells(2).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                Dr = cmd.ExecuteReader()
                Dr.Read()
                With Me.dgRCTC
                    .Rows(sum).Cells(3).Value = Dr.Item("customer_name")
                End With
            Next

            Dr.Close()
            Mainfrm.lblMainStatus.Text = "โหลดข้อมูล Claims แล้ว"
            strsqlSelect = Nothing
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "ผิดพลาด " & ex.Message
        End Try
    End Sub
    Private Sub getDataSN()
        Try
            strSQL = "SELECT claims_id FROM claims WHERE serial_pro='" & Me.txtRTCTsearchSN.Text & "' AND `status`='" & "รอส่งคืน" & "'"
            Mainfrm.lblMainStatus.Text = strSQL
            cmd = New MySqlCommand(strSQL, ConnectionDB)
            Call open_connection()
            Dr = cmd.ExecuteReader()
            Dr.Read()
            If Dr.HasRows Then
                ReturnClaimstoCus1Frm.MdiParent = Mainfrm
                ReturnClaimstoCus1Frm.Show()
                ReturnClaimstoCus1Frm.txtRCTC1claims_id.Text = Dr.GetString("claims_id")
                Call ReturnClaimstoCus1Frm.getdataClaims()
            Else
                MsgBox("ไม่พบข้อมูล", MsgBoxStyle.Exclamation, "แจ้งเตือน")
            End If
            Me.txtRTCTsearchSN.Text = ""
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ReturnClaimsToCusFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        strsqlSelect = 100
        Call getdataClaims()
    End Sub

    Private Sub btnRTCTrefresh_Click(sender As Object, e As EventArgs) Handles btnRTCTrefresh.Click
        strsqlSelect = 100
        Call getdataClaims()
    End Sub

    Private Sub txtRTCTsearchSN_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRTCTsearchSN.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call getDataSN()
        End If
    End Sub
End Class