Imports MySql.Data.MySqlClient
Public Class SearchCustomerGroupFrm
    'เสร็จ v2 2014/12/27
  
    Private Sub GetAllData()
        Mainfrm.lblMainStatus.Text = "select customer_id "
        strSQL = "select customer_id as รหัสลูกค้า, customer_name as ชื่อ, customer_address as ที่อยู่, customer_zipcode as รหัสไปรษณีย์, customer_tel as เบอร์โทร from customer order by customer_id"
        dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
        ds = New DataSet
        Call open_connection()
        dtAdapter.Fill(ds, "customer")
        Me.dgSearchCustoSaveFix.DataSource = ds
        Me.dgSearchCustoSaveFix.DataMember = "customer"
    End Sub
    Private WithEvents songsDataGridView As New System.Windows.Forms.DataGridView
    Private Sub search_record()
        dt = New DataTable
        Dim strKeyWord As String = Me.txtSearchCus.Text
        Mainfrm.lblMainStatus.Text = "select * from customer"
        strSQL = "select * from customer where 1=1"
        If strKeyWord <> "" Then
            strSQL = strSQL & " and customer_id like '%" & strKeyWord & "%' or customer_name like '%" & strKeyWord & "%' or customer_address like '%" & strKeyWord & "%' or customer_tel like '%" & strKeyWord & "%' "
        End If
        dtAdapter = New MySqlDataAdapter(strSQL, ConnectionDB)
        Call open_connection()
        dtAdapter.Fill(dt)
        Me.dgSearchCustoSaveFix.DataSource = dt
        '******************************'
        Me.dgSearchCustoSaveFix.Columns.Clear()
        With dgSearchCustoSaveFix.ColumnHeadersDefaultCellStyle
            .BackColor = Color.Navy
            .ForeColor = Color.White
            .Font = New Font(songsDataGridView.Font, FontStyle.Bold)
        End With
        Dim ColumnTextBox As DataGridViewTextBoxColumn
        '1
        '*** Column (CustomerID) ***'
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "customer_id"
        ColumnTextBox.HeaderText = "รหัสลูกค้า"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 100
        Me.dgSearchCustoSaveFix.Columns.Add(ColumnTextBox)
        '2
        '*** Column (Name) ***'
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "customer_name"
        ColumnTextBox.HeaderText = "ชื่อ"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 100
        Me.dgSearchCustoSaveFix.Columns.Add(ColumnTextBox)
        '3
        '*** Column (Email) ***'
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "customer_address"
        ColumnTextBox.HeaderText = "ที่อยู่"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 100
        Me.dgSearchCustoSaveFix.Columns.Add(ColumnTextBox)
        '4
        '*** Column (CountryCode) ***'
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "customer_zipcode"
        ColumnTextBox.HeaderText = "รหัสไปรษณีย์"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 100
        Me.dgSearchCustoSaveFix.Columns.Add(ColumnTextBox)
        '5
        '*** Column (Budget) ***'
        ColumnTextBox = New DataGridViewTextBoxColumn()
        ColumnTextBox.DataPropertyName = "customer_tel"
        ColumnTextBox.HeaderText = "เบอร์โทร"
        ColumnTextBox.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ColumnTextBox.Width = 100
        Me.dgSearchCustoSaveFix.Columns.Add(ColumnTextBox)
    End Sub
    Private Sub btnsearchShowAll_Click(sender As Object, e As EventArgs) Handles btnsearchShowAll.Click
        Call GetAllData()
    End Sub
    Private Sub dgSearchCustoSaveFix_MouseClick(sender As Object, e As MouseEventArgs) Handles dgSearchCustoSaveFix.MouseClick
        If Me.dgSearchCustoSaveFix.Rows.Count = 0 Then
            Exit Sub
        End If
        Me.txtSearchCusShowTel.Text = Me.dgSearchCustoSaveFix.SelectedCells(1).Value
    End Sub
    Private Sub btnSendtoSavedatafix_Click(sender As Object, e As EventArgs) Handles btnSendtoSavedatafix.Click
        If Me.dgSearchCustoSaveFix.Rows.Count = 0 Then
            Exit Sub
        End If
        If Me.btnSendtoSavedatafix.Text = "เลือกไปหน้ารับงานซ่อม" Then
            SaveDataFixGroupFrm.txtSDFCusID.Text = Me.dgSearchCustoSaveFix.SelectedCells(0).Value
            SaveDataFixGroupFrm.txtSDFcusname.Text = Me.dgSearchCustoSaveFix.SelectedCells(1).Value
            SaveDataFixGroupFrm.txtSDFcusaddress.Text = Me.dgSearchCustoSaveFix.SelectedCells(2).Value
            SaveDataFixGroupFrm.txtSDFcuszipcode.Text = Me.dgSearchCustoSaveFix.SelectedCells(3).Value
            SaveDataFixGroupFrm.txtSDFcusTel.Text = Me.dgSearchCustoSaveFix.SelectedCells(4).Value
            Me.Close()
        ElseIf Me.btnSendtoSavedatafix.Text = "เลือกไปหน้าเคลมสินค้า" Then
            ClaimsFrm.txtCFcustomer_id.Text = Me.dgSearchCustoSaveFix.SelectedCells(0).Value
            ClaimsFrm.txtCFcustomer_name.Text = Me.dgSearchCustoSaveFix.SelectedCells(1).Value
            Me.Close()
        ElseIf Me.btnSendtoSavedatafix.Text = "เลือกไปหน้าค้นหาประวัติงานซ่อม" Then
            RepairHistoryFrm.txtRHsearchCusID.Text = Me.dgSearchCustoSaveFix.SelectedCells(0).Value
            RepairHistoryFrm.getDataComfix()
            RepairHistoryFrm.sumDetail()
            RepairHistoryFrm.txtRHsearchCusID.Clear()
            Me.Close()
        ElseIf Me.btnSendtoSavedatafix.Text = "เลือกไปหน้าสถิติงานซ่อม" Then
            'ComfixCustomerStatusFrm.bsearch = 100
            For sRows As Integer = 0 To Me.dgSearchCustoSaveFix.SelectedRows.Count - 1
                ComfixCustomerStatusFrm.dgCCcusStatus.Rows.Add()
                Dim cdg As Integer = ComfixCustomerStatusFrm.dgCCcusStatus.Rows.Count
                ComfixCustomerStatusFrm.dgCCcusStatus.Rows(cdg).Cells(1).Value = Me.dgSearchCustoSaveFix.Rows(sRows).Cells(0).Value
            Next
            ComfixCustomerStatusFrm.cusID = Me.dgSearchCustoSaveFix.SelectedCells(0).Value
            ComfixCustomerStatusFrm.getCustomerStatus()
            Me.Close()
        ElseIf Me.btnSendtoSavedatafix.Text = "เลือกไปหน้าสถิติงานขาย(สินค้า)" Then
            For sRows As Integer = 0 To Me.dgSearchCustoSaveFix.SelectedRows.Count - 1
                SalesCustomerStatusFrm.dgCCcusStatusPro.Rows.Add()
                Dim cdg As Integer = SalesCustomerStatusFrm.dgCCcusStatusPro.Rows.Count
                SalesCustomerStatusFrm.dgCCcusStatusPro.Rows(cdg).Cells(1).Value = Me.dgSearchCustoSaveFix.Rows(sRows).Cells(0).Value
            Next
            SalesCustomerStatusFrm.cusID = Me.dgSearchCustoSaveFix.SelectedCells(0).Value
            SalesCustomerStatusFrm.getCustomerStatusPro()
            Me.Close()
        End If
    End Sub
    Private Sub txtSearchCus_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchCus.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Call search_record()
        End If
    End Sub
    Private Sub btnsearchCusSearch_Click(sender As Object, e As EventArgs) Handles btnsearchCusSearch.Click
        Call search_record()
    End Sub

    Private Sub SearchCustomerFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
    End Sub



    Private Sub dgSearchCustoSaveFix_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSearchCustoSaveFix.CellContentDoubleClick
        If Me.dgSearchCustoSaveFix.Rows.Count = 0 Then
            Exit Sub
        ElseIf Me.btnSendtoSavedatafix.Text = "เลือกไปหน้าสถิติงานซ่อม" Then
            ComfixCustomerStatusFrm.bsearch = 200
            ComfixCustomerStatusFrm.dgCCcusStatus.Rows.Add()
            Dim cdg As Integer = ComfixCustomerStatusFrm.dgCCcusStatus.Rows.Count - 1
            Mainfrm.lblMainStatus.Text = cdg.ToString
            ComfixCustomerStatusFrm.dgCCcusStatus.Rows(cdg).Cells(1).Value = Me.dgSearchCustoSaveFix.SelectedCells.Item(0).Value
            ComfixCustomerStatusFrm.dgCCcusStatus.Rows(cdg).Cells(2).Value = Me.dgSearchCustoSaveFix.SelectedCells.Item(1).Value
            ComfixCustomerStatusFrm.getCustomerStatus()
        ElseIf Me.btnSendtoSavedatafix.Text = "เลือกไปหน้าสถิติงานขาย(สินค้า)" Then
            SalesCustomerStatusFrm.bsearch = 200
            SalesCustomerStatusFrm.dgCCcusStatusPro.Rows.Add()
            Dim cdg As Integer = SalesCustomerStatusFrm.dgCCcusStatusPro.Rows.Count - 1
            Mainfrm.lblMainStatus.Text = cdg.ToString
            SalesCustomerStatusFrm.dgCCcusStatusPro.Rows(cdg).Cells(1).Value = Me.dgSearchCustoSaveFix.SelectedCells.Item(0).Value
            SalesCustomerStatusFrm.dgCCcusStatusPro.Rows(cdg).Cells(2).Value = Me.dgSearchCustoSaveFix.SelectedCells.Item(1).Value
            SalesCustomerStatusFrm.getCustomerStatusPro()
        End If
    End Sub
End Class