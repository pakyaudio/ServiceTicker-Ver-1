Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Drawing.Printing

Public Class BillingReportFrm
   
    Private Sub BillingReportFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Mainfrm.Icon
        'TODO: This line of code loads data into the 'BillDataSet.sale' table. You can move, or remove it, as needed.
        Me.saleTableAdapter.Fill(Me.BillDataSet.sale)
        'TODO: This line of code loads data into the 'BillDataSet.pledge_sale' table. You can move, or remove it, as needed.
        Me.pledge_saleTableAdapter.Fill(Me.BillDataSet.pledge_sale)
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        'Me.ReportViewer1.PrinterSettings.Copies = 2
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.saleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BillDataSet = New ServiceTicker.BillDataSet()
        Me.pledge_saleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.saleTableAdapter = New ServiceTicker.BillDataSetTableAdapters.saleTableAdapter()
        Me.pledge_saleTableAdapter = New ServiceTicker.BillDataSetTableAdapters.pledge_saleTableAdapter()
        CType(Me.saleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pledge_saleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'saleBindingSource
        '
        Me.saleBindingSource.DataMember = "sale"
        Me.saleBindingSource.DataSource = Me.BillDataSet
        '
        'BillDataSet
        '
        Me.BillDataSet.DataSetName = "BillDataSet"
        Me.BillDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'pledge_saleBindingSource
        '
        Me.pledge_saleBindingSource.DataMember = "pledge_sale"
        Me.pledge_saleBindingSource.DataSource = Me.BillDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "BillingDataSet"
        ReportDataSource1.Value = Me.saleBindingSource
        ReportDataSource2.Name = "PLDataSet"
        ReportDataSource2.Value = Me.pledge_saleBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ServiceTicker.BillingReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(784, 561)
        Me.ReportViewer1.TabIndex = 0
        '
        'saleTableAdapter
        '
        Me.saleTableAdapter.ClearBeforeFill = True
        '
        'pledge_saleTableAdapter
        '
        Me.pledge_saleTableAdapter.ClearBeforeFill = True
        '
        'BillingReportFrm
        '
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "BillingReportFrm"
        Me.Text = "พิมพ์ใบวางบิล/ลดหนี้ (Billing)"
        Me.TopMost = True
        CType(Me.saleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pledge_saleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(false)

End Sub
    Dim cn, ca, ct, em, bl, ims As String
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        strSQL = "select com_name,com_address,com_tel,com_email,com_billing,images from company"
        cmd = New MySqlCommand(strSQL, ConnectionDB)
        Call open_connection()
        Dr = cmd.ExecuteReader
        Dr.Read()

        cn = Dr.Item("com_name")
        ca = Dr.Item("com_address")
        ct = Dr.Item("com_tel")

        ims = Dr.Item("images")
        em = Dr.Item("com_email")
        bl = Dr.Item("com_billing")
        Dim mne As New MoneyExt()
        Dim thaitext As String
        Try
            thaitext = mne.NumberToThaiWord(CDbl(DebtorFrm.txtDTsumALL.Text))
        Catch ex As Exception
            thaitext = ""
        End Try

        ' ''Me.ReportViewer1.RefreshReport()
        ' ''Dim datasource As ReportDataSource = New ReportDataSource("Snum", dt)

        Dim comname As New ReportParameter("com_name", cn)
        Dim comaddress As New ReportParameter("com_address", ca)
        Dim comtel As New ReportParameter("com_tel", ct)
        Dim comemail As New ReportParameter("com_email", em)
        Dim combilling As New ReportParameter("com_billing", bl)
        Dim imgss As New ReportParameter("imagepath1", ims)
        Dim cusid As New ReportParameter("cus_id", DebtorFrm.txtDTcustomer_id.Text)
        Dim cusname As New ReportParameter("cus_name", DebtorFrm.txtDTcustomer_name.Text)
        Dim ttall As New ReportParameter("totalall", DebtorFrm.txtDTsumALL.Text)
        Dim tx As New ReportParameter("thai_text", thaitext)
        Dr.Close()
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {imgss, comname, comaddress, comtel, comemail, combilling, _
                                                                          cusid, cusname, ttall, tx})
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class