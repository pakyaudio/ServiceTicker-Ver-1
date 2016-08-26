Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class logsFrm
    Private WithEvents songsDataGridView As New System.Windows.Forms.DataGridView
    Private Sub getData()
        'Dim startdate As String = DateTimePicker1.Value = DateTime.Now.AddDays(0)
        'Dim enddate As String = DateTimePicker2.Value = DateTime.Now.AddDays(0)
        dt = New DataTable
        Mainfrm.lblMainStatus.Text = "select * from applogs"
        strSQL = "select * from applogs where date_in between'" & DateTimePicker1.Value.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "' and '" & DateTimePicker2.Value.ToString("yyyy-MM-dd", CultureInfo.CreateSpecificCulture("en-EN")) & "' ORDER BY date_in DESC"

        dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
        Call open_connection()
        dtAdapter.Fill(dt)
        Me.dgLOGSdata.DataSource = dt
        '******************************'
        Me.dgLOGSdata.Columns.Clear()
        With dgLOGSdata.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Navy
            .ForeColor = Color.White
            .Font = New Font(songsDataGridView.Font, FontStyle.Bold)
        End With
        Dim ColumnTextBox As DataGridViewTextBoxColumn
        '0
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "no"
        ColumnTextBox.HeaderText = "No."
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 30
        Me.dgLOGSdata.Columns.Add(ColumnTextBox)
        '1
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "user_id"
        ColumnTextBox.HeaderText = "รหัสผู้ใช้"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 100
        Me.dgLOGSdata.Columns.Add(ColumnTextBox)
        '2
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "user_name"
        ColumnTextBox.HeaderText = "ชื่อ"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 100
        Me.dgLOGSdata.Columns.Add(ColumnTextBox)
        '3
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "user_usernamelogin"
        ColumnTextBox.HeaderText = "ชื่อสำหรับเข้าระบบ"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 100
        Me.dgLOGSdata.Columns.Add(ColumnTextBox)
        '4
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "note"
        ColumnTextBox.HeaderText = "เข้าที่"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 100
        Me.dgLOGSdata.Columns.Add(ColumnTextBox)
        '5
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "date_in"
        ColumnTextBox.DefaultCellStyle.Format = "dd MMMM yyyy HH:mm:ss น."
        ColumnTextBox.HeaderText = "วันที่เข้าระบบ"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 200
        Me.dgLOGSdata.Columns.Add(ColumnTextBox)

        For sum As Integer = 0 To Me.dgLOGSdata.Rows.Count - 1
            Me.dgLOGSdata.Rows(sum).Cells(0).Value = sum + 1
        Next
    End Sub

    Private Sub logsFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        DateTimePicker1.Value = Date.Now.AddDays(-30)
        DateTimePicker2.Value = Date.Now.AddDays(1)
    End Sub

    Private Sub btnLOGSgetdata_Click(sender As Object, e As EventArgs) Handles btnLOGSgetdata.Click
        Call getData()
    End Sub

End Class