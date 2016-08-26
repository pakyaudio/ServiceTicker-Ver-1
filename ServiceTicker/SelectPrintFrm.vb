Imports MySql.Data.MySqlClient

Public Class SelectPrintFrm
    Private Sub Data_History_Bus_Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Call SaveDataFixFrm.saveDatalistFixcom()
    End Sub
    Private Sub loadIcon()
        Try
            Mainfrm.lblMainStatus.Text = "โหลดไอคอน"
            dt = New DataTable
            strSQL = "SELECT ver_icon FROM ver_detail"
            dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
            Call open_connection()
            dtAdapter.Fill(dt)
            Dim IconPath As String = dt.Rows(0).Item("ver_icon")
            Dim Ico As New System.Drawing.Icon(IconPath)
            Me.Icon = Ico
            Mainfrm.lblMainStatus.Text = "โหลดไอคอนแล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = "โหลดไอคอนผิดพลาด"
        End Try

    End Sub
    Private Sub btnSPcancel_Click(sender As Object, e As EventArgs) Handles btnSPcancel.Click
        Me.Close()
    End Sub

    Private Sub SelectPrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loadIcon()
    End Sub

    Private Sub btnSPok_Click(sender As Object, e As EventArgs) Handles btnSPok.Click
        If rbSPa4.Checked Then
            RepairBillA4Frm.MdiParent = Mainfrm
            RepairBillA4Frm.Show()
            Call SaveDataFixFrm.saveDatalistFixcom()
            Me.Close()
        Else
            RepairBillFrm.MdiParent = Mainfrm
            RepairBillFrm.Show()
            Call SaveDataFixFrm.saveDatalistFixcom()
            Me.Close()
        End If
    End Sub
End Class