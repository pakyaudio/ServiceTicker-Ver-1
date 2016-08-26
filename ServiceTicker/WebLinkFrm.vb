Imports MySql.Data.MySqlClient

Public Class WebLinkFrm
   
    Private Sub getData()
        Try
        Mainfrm.lblMainStatus.Text = "โหลด weblink"
        strSQL = "SELECT id,web_name,web FROM weblink"
        Me.DataGridView1.Rows.Clear()
        cmd = New MySqlCommand(strSQL, ConnectionDB)
        Call open_connection()
        Dr = cmd.ExecuteReader
        While (Dr.Read())
            Dim r As Integer
            With Me.DataGridView1
                r = .Rows.Count
                .Rows.Add()
                .Rows(r).Cells(0).Value = Dr("id")
                .Rows(r).Cells(1).Value = Dr("web_name")
                .Rows(r).Cells(2).Value = Dr("web")

            End With
            End While
            Mainfrm.lblMainStatus.Text = "โหลด weblink แล้ว"
        Catch ex As Exception
            Mainfrm.lblMainStatus.Text = ex.Message
        End Try
    End Sub
    Private Sub WebLinkFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mainfrm.lblMainStatus.Text = "เปิดหน้าต่างเช็คประกัน"
        Me.Icon = Mainfrm.Icon
        Call getData()
        Me.txtWLurl.Clear()
        Me.txtWLwebname.Clear()
        ' Me.btnWLadd.Enabled = False
        Me.btnWLedit.Enabled = False
        Me.btnWLcancel.Enabled = False
        Me.txtWLurl.Enabled = False
        Me.txtWLwebname.Enabled = False

    End Sub

    Private Sub btnWLadd_Click(sender As Object, e As EventArgs) Handles btnWLadd.Click
        If Me.btnWLadd.Text = "เพิ่ม" Then
            Mainfrm.lblMainStatus.Text = "เพิ่ม weblink"
            Me.btnWLedit.Enabled = False
            Me.txtWLurl.Enabled = True
            Me.txtWLwebname.Enabled = True
            Me.btnWLcancel.Enabled = True
            Me.btnWLadd.Text = "บันทึก"
        ElseIf Me.btnWLadd.Text = "บันทึก" Then
            Try
                strSQL = "INSERT INTO weblink(web_name,web)VALUES('" & Me.txtWLwebname.Text & "','" & Me.txtWLurl.Text & "');"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                MsgBox("เพิ่มข้อมูลแล้ว", MsgBoxStyle.Information, "ยืนยัน")
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "เพิ่ม weblink ผิดพลาด"
            End Try
            Me.txtWLurl.Clear()
            Me.txtWLwebname.Clear()
            Me.txtWLurl.Enabled = False
            Me.txtWLwebname.Enabled = False
            Me.btnWLedit.Enabled = False
            Me.btnWLadd.Enabled = True
            Me.btnWLcancel.Enabled = False
            Me.btnWLadd.Text = "เพิ่ม"
            Mainfrm.lblMainStatus.Text = "เพิ่ม weblink แล้ว"
            Call getData()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Me.btnWLadd.Enabled = False
        Me.btnWLedit.Enabled = True
        Me.btnWLcancel.Enabled = True
        'Me.txtWLurl.Enabled = True
        'Me.txtWLwebname.Enabled = True
        Me.txtWLwebname.Text = Me.DataGridView1.SelectedCells.Item(1).Value
        Me.txtWLurl.Text = Me.DataGridView1.SelectedCells.Item(2).Value
    End Sub
    'Private Sub Navigate(ByVal address As String)

    '    If String.IsNullOrEmpty(address) Then Return
    '    If address.Equals("about:blank") Then Return
    '    If Not address.StartsWith("http://") And _
    '        Not address.StartsWith("https://") Then
    '        address = "http://" & address
    '    End If

    '    Try
    '        webBrowser1.Navigate(New Uri(address))
    '    Catch ex As System.UriFormatException
    '        Return
    '    End Try
    '    Mainfrm.lblMainStatus.Text = "โหลดข้อมูลจากอินเตอร์เน็ตแล้ว"
    'End Sub

    '' Updates the URL in TextBoxAddress upon navigation. 
    'Private Sub webBrowser1_Navigated(ByVal sender As Object, _
    '    ByVal e As WebBrowserNavigatedEventArgs) _
    '    Handles WebBrowser1.Navigated

    '    'WebBrowser1.Url = Me.DataGridView1.SelectedCells.Item(2).Value
    'End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Try
            WebBrowser1.Navigate(New Uri(Me.DataGridView1.SelectedCells.Item(2).Value))
        Catch ex As Exception
            Return
        End Try
      
    End Sub

    Private Sub btnWLedit_Click(sender As Object, e As EventArgs) Handles btnWLedit.Click
        If Me.btnWLedit.Text = "แก้ไข" Then
            Mainfrm.lblMainStatus.Text = "แก้ไข weblink"
            Me.txtWLurl.Enabled = True
            Me.txtWLwebname.Enabled = True
            Me.btnWLcancel.Enabled = True
            Me.btnWLedit.Text = "บันทึก"
        ElseIf Me.btnWLedit.Text = "บันทึก" Then
            Try
                strSQL = "UPDATE weblink SET web_name='" & Me.txtWLwebname.Text & "',web='" & Me.txtWLurl.Text & "' WHERE id='" & Me.DataGridView1.SelectedCells.Item(0).Value & "'"
                Mainfrm.lblMainStatus.Text = strSQL
                cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                MsgBox("แก้ไขข้อมูลแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
            Catch ex As Exception
                Mainfrm.lblMainStatus.Text = "แก้ไข weblink ผิดพลาด"
            End Try
            Me.txtWLurl.Clear()
            Me.txtWLwebname.Clear()
            Me.txtWLurl.Enabled = False
            Me.txtWLwebname.Enabled = False
            Me.btnWLedit.Enabled = False
            Me.btnWLadd.Enabled = True
            Me.btnWLedit.Text = "แก้ไข"
            Mainfrm.lblMainStatus.Text = "แก้ไข weblink แล้ว"
            Call getData()
        End If
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Delete Then
            Mainfrm.lblMainStatus.Text = "ลบ weblink"
            If MessageBox.Show("คุณแน่ใจว่าจะลบข้อมูลนี้", "แจ้งเตือน", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Try
                strSQL = "DELETE FROM weblink WHERE id='" & Me.DataGridView1.SelectedCells.Item(0).Value & "'"
                    Mainfrm.lblMainStatus.Text = strSQL
                    cmd = New MySqlCommand(strSQL, ConnectionDB)
                Call open_connection()
                cmd.ExecuteNonQuery()
                    MsgBox("ลบข้อมูลแล้ว", MsgBoxStyle.Information, "แจ้งเตือน")
                Catch ex As Exception
                    Mainfrm.lblMainStatus.Text = "ลบ weblink ผิดพลาด"
                End Try
                Call getData()
            Else
                Mainfrm.lblMainStatus.Text = "ยกเลิกลบ weblink"
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnWLcancel_Click(sender As Object, e As EventArgs) Handles btnWLcancel.Click
        Call getData()
        Me.txtWLurl.Clear()
        Me.txtWLwebname.Clear()
        Me.btnWLadd.Enabled = True
        Me.btnWLedit.Enabled = False
        Me.btnWLcancel.Enabled = False
        Me.txtWLurl.Enabled = False
        Me.txtWLwebname.Enabled = False
        Me.btnWLadd.Text = "เพิ่ม"
        Me.btnWLedit.Text = "แก้ไข"
    End Sub
End Class