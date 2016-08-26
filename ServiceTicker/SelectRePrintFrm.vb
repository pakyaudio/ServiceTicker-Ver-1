Imports MySql.Data.MySqlClient

Public Class SelectRePrintFrm
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

    Private Sub SelectRePrintFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loadIcon()
    End Sub

    Private Sub btnSPok_Click(sender As Object, e As EventArgs) Handles btnSPok.Click
        If rbSPa4.Checked Then
            ReSaveDataFixPrintA4Frm.Show()
            Me.Close()
        ElseIf rbSPha4.Checked Then
            ReSaveDataFixPrintFrm.Show()
            Me.Close()
        Else
            MsgBox("กรุณาเลือกขนาดกระดาษ")
        End If
    End Sub
End Class