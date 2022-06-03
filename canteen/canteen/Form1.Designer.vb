<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.name_field = New System.Windows.Forms.TextBox()
        Me.dp_field = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.year_field = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.item_field = New System.Windows.Forms.TextBox()
        Me.price_field = New System.Windows.Forms.TextBox()
        Me.total_field = New System.Windows.Forms.TextBox()
        Me.pd_name = New System.Windows.Forms.TextBox()
        Me.data_table = New System.Windows.Forms.DataGridView()
        Me.add_btn = New System.Windows.Forms.Button()
        Me.print_btn = New System.Windows.Forms.Button()
        Me.type_field = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.quant_field = New System.Windows.Forms.TextBox()
        Me.Billingno_field = New System.Windows.Forms.TextBox()
        Me.balance_field = New System.Windows.Forms.TextBox()
        Me.grand_field = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Id_field = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.spr_field = New System.Windows.Forms.TextBox()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.update_btn = New System.Windows.Forms.Button()
        Me.serial_no = New System.Windows.Forms.TextBox()
        Me.transaction = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ref_field = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.data_table, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.transaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(133, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(588, 5)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'name_field
        '
        Me.name_field.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.name_field.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.name_field.Location = New System.Drawing.Point(511, 47)
        Me.name_field.Margin = New System.Windows.Forms.Padding(4)
        Me.name_field.Multiline = True
        Me.name_field.Name = "name_field"
        Me.name_field.ReadOnly = True
        Me.name_field.Size = New System.Drawing.Size(225, 60)
        Me.name_field.TabIndex = 4
        '
        'dp_field
        '
        Me.dp_field.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dp_field.Location = New System.Drawing.Point(756, 47)
        Me.dp_field.Margin = New System.Windows.Forms.Padding(4)
        Me.dp_field.Multiline = True
        Me.dp_field.Name = "dp_field"
        Me.dp_field.ReadOnly = True
        Me.dp_field.Size = New System.Drawing.Size(99, 59)
        Me.dp_field.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(748, -1)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 38)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Department"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'year_field
        '
        Me.year_field.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.year_field.Location = New System.Drawing.Point(876, 47)
        Me.year_field.Margin = New System.Windows.Forms.Padding(4)
        Me.year_field.Multiline = True
        Me.year_field.Name = "year_field"
        Me.year_field.ReadOnly = True
        Me.year_field.Size = New System.Drawing.Size(109, 59)
        Me.year_field.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(888, 8)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 28)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Year"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'item_field
        '
        Me.item_field.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.item_field.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.item_field.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.item_field.Location = New System.Drawing.Point(3, 12)
        Me.item_field.Margin = New System.Windows.Forms.Padding(4)
        Me.item_field.Name = "item_field"
        Me.item_field.Size = New System.Drawing.Size(204, 24)
        Me.item_field.TabIndex = 10
        '
        'price_field
        '
        Me.price_field.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.price_field.Location = New System.Drawing.Point(608, 178)
        Me.price_field.Margin = New System.Windows.Forms.Padding(4)
        Me.price_field.Multiline = True
        Me.price_field.Name = "price_field"
        Me.price_field.ReadOnly = True
        Me.price_field.Size = New System.Drawing.Size(98, 56)
        Me.price_field.TabIndex = 14
        '
        'total_field
        '
        Me.total_field.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.total_field.Location = New System.Drawing.Point(727, 178)
        Me.total_field.Margin = New System.Windows.Forms.Padding(4)
        Me.total_field.Multiline = True
        Me.total_field.Name = "total_field"
        Me.total_field.ReadOnly = True
        Me.total_field.Size = New System.Drawing.Size(109, 56)
        Me.total_field.TabIndex = 16
        '
        'pd_name
        '
        Me.pd_name.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pd_name.Location = New System.Drawing.Point(299, 178)
        Me.pd_name.Margin = New System.Windows.Forms.Padding(4)
        Me.pd_name.Multiline = True
        Me.pd_name.Name = "pd_name"
        Me.pd_name.ReadOnly = True
        Me.pd_name.Size = New System.Drawing.Size(180, 56)
        Me.pd_name.TabIndex = 20
        '
        'data_table
        '
        Me.data_table.BackgroundColor = System.Drawing.Color.Lavender
        Me.data_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_table.Location = New System.Drawing.Point(64, 311)
        Me.data_table.Margin = New System.Windows.Forms.Padding(4)
        Me.data_table.Name = "data_table"
        Me.data_table.RowHeadersWidth = 62
        Me.data_table.RowTemplate.Height = 28
        Me.data_table.Size = New System.Drawing.Size(672, 251)
        Me.data_table.TabIndex = 21
        '
        'add_btn
        '
        Me.add_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.add_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.add_btn.ForeColor = System.Drawing.SystemColors.Desktop
        Me.add_btn.Location = New System.Drawing.Point(853, 178)
        Me.add_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.add_btn.Name = "add_btn"
        Me.add_btn.Size = New System.Drawing.Size(124, 56)
        Me.add_btn.TabIndex = 23
        Me.add_btn.Text = "Add"
        Me.add_btn.UseVisualStyleBackColor = True
        '
        'print_btn
        '
        Me.print_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.print_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.print_btn.ForeColor = System.Drawing.SystemColors.Desktop
        Me.print_btn.Location = New System.Drawing.Point(984, 178)
        Me.print_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.print_btn.Name = "print_btn"
        Me.print_btn.Size = New System.Drawing.Size(124, 56)
        Me.print_btn.TabIndex = 24
        Me.print_btn.Text = "Order"
        Me.print_btn.UseVisualStyleBackColor = True
        '
        'type_field
        '
        Me.type_field.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.type_field.Location = New System.Drawing.Point(1001, 47)
        Me.type_field.Margin = New System.Windows.Forms.Padding(4)
        Me.type_field.Multiline = True
        Me.type_field.Name = "type_field"
        Me.type_field.ReadOnly = True
        Me.type_field.Size = New System.Drawing.Size(161, 60)
        Me.type_field.TabIndex = 32
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(1040, -1)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 41)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Type"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'quant_field
        '
        Me.quant_field.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.quant_field.Location = New System.Drawing.Point(503, 178)
        Me.quant_field.Margin = New System.Windows.Forms.Padding(4)
        Me.quant_field.Multiline = True
        Me.quant_field.Name = "quant_field"
        Me.quant_field.Size = New System.Drawing.Size(83, 56)
        Me.quant_field.TabIndex = 38
        Me.quant_field.Text = "0"
        Me.quant_field.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Billingno_field
        '
        Me.Billingno_field.AcceptsReturn = True
        Me.Billingno_field.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Billingno_field.Location = New System.Drawing.Point(1251, 60)
        Me.Billingno_field.Margin = New System.Windows.Forms.Padding(4)
        Me.Billingno_field.Multiline = True
        Me.Billingno_field.Name = "Billingno_field"
        Me.Billingno_field.PlaceholderText = "Bill No"
        Me.Billingno_field.ReadOnly = True
        Me.Billingno_field.Size = New System.Drawing.Size(170, 40)
        Me.Billingno_field.TabIndex = 34
        Me.Billingno_field.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Billingno_field.WordWrap = False
        '
        'balance_field
        '
        Me.balance_field.AcceptsReturn = True
        Me.balance_field.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.balance_field.Location = New System.Drawing.Point(1251, 13)
        Me.balance_field.Margin = New System.Windows.Forms.Padding(4)
        Me.balance_field.Multiline = True
        Me.balance_field.Name = "balance_field"
        Me.balance_field.PlaceholderText = "Balance"
        Me.balance_field.ReadOnly = True
        Me.balance_field.Size = New System.Drawing.Size(170, 39)
        Me.balance_field.TabIndex = 34
        Me.balance_field.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grand_field
        '
        Me.grand_field.AcceptsReturn = True
        Me.grand_field.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.grand_field.Location = New System.Drawing.Point(1251, 108)
        Me.grand_field.Margin = New System.Windows.Forms.Padding(4)
        Me.grand_field.Multiline = True
        Me.grand_field.Name = "grand_field"
        Me.grand_field.PlaceholderText = "Grand Total"
        Me.grand_field.ReadOnly = True
        Me.grand_field.Size = New System.Drawing.Size(170, 43)
        Me.grand_field.TabIndex = 36
        Me.grand_field.Text = "0"
        Me.grand_field.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(116, 131)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 43)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Item no"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(502, 130)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 46)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Quantity"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(621, 138)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 37)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Price"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(743, 140)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 26)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Total"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(332, 137)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 27)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Product" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Id_field
        '
        Me.Id_field.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Id_field.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Id_field.Location = New System.Drawing.Point(64, 47)
        Me.Id_field.Margin = New System.Windows.Forms.Padding(4)
        Me.Id_field.MaxLength = 9
        Me.Id_field.Multiline = True
        Me.Id_field.Name = "Id_field"
        Me.Id_field.Size = New System.Drawing.Size(204, 59)
        Me.Id_field.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(332, 5)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 28)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Spr No"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'spr_field
        '
        Me.spr_field.Location = New System.Drawing.Point(299, 47)
        Me.spr_field.Multiline = True
        Me.spr_field.Name = "spr_field"
        Me.spr_field.ReadOnly = True
        Me.spr_field.Size = New System.Drawing.Size(180, 59)
        Me.spr_field.TabIndex = 41
        '
        'delete_btn
        '
        Me.delete_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delete_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.delete_btn.ForeColor = System.Drawing.SystemColors.Desktop
        Me.delete_btn.Location = New System.Drawing.Point(1248, 178)
        Me.delete_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(124, 56)
        Me.delete_btn.TabIndex = 42
        Me.delete_btn.Text = "Delete"
        Me.delete_btn.UseVisualStyleBackColor = True
        '
        'update_btn
        '
        Me.update_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.update_btn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.update_btn.ForeColor = System.Drawing.SystemColors.Desktop
        Me.update_btn.Location = New System.Drawing.Point(1116, 178)
        Me.update_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.update_btn.Name = "update_btn"
        Me.update_btn.Size = New System.Drawing.Size(124, 56)
        Me.update_btn.TabIndex = 43
        Me.update_btn.Text = "Update"
        Me.update_btn.UseVisualStyleBackColor = True
        '
        'serial_no
        '
        Me.serial_no.Enabled = False
        Me.serial_no.Location = New System.Drawing.Point(299, 47)
        Me.serial_no.Multiline = True
        Me.serial_no.Name = "serial_no"
        Me.serial_no.ReadOnly = True
        Me.serial_no.Size = New System.Drawing.Size(180, 59)
        Me.serial_no.TabIndex = 44
        Me.serial_no.Visible = False
        '
        'transaction
        '
        Me.transaction.BackgroundColor = System.Drawing.Color.Lavender
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.transaction.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.transaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.transaction.DefaultCellStyle = DataGridViewCellStyle2
        Me.transaction.Location = New System.Drawing.Point(844, 365)
        Me.transaction.Margin = New System.Windows.Forms.Padding(4)
        Me.transaction.Name = "transaction"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.transaction.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.transaction.RowHeadersWidth = 62
        Me.transaction.RowTemplate.Height = 28
        Me.transaction.Size = New System.Drawing.Size(464, 197)
        Me.transaction.TabIndex = 45
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(984, 320)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(149, 41)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Last Five Transactions"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ref_field
        '
        Me.ref_field.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ref_field.Location = New System.Drawing.Point(299, 47)
        Me.ref_field.Margin = New System.Windows.Forms.Padding(4)
        Me.ref_field.Multiline = True
        Me.ref_field.Name = "ref_field"
        Me.ref_field.ReadOnly = True
        Me.ref_field.Size = New System.Drawing.Size(180, 60)
        Me.ref_field.TabIndex = 48
        Me.ref_field.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.item_field)
        Me.Panel1.Location = New System.Drawing.Point(56, 174)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(212, 60)
        Me.Panel1.TabIndex = 49
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1364, 723)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ref_field)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.transaction)
        Me.Controls.Add(Me.serial_no)
        Me.Controls.Add(Me.update_btn)
        Me.Controls.Add(Me.delete_btn)
        Me.Controls.Add(Me.spr_field)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Id_field)
        Me.Controls.Add(Me.quant_field)
        Me.Controls.Add(Me.grand_field)
        Me.Controls.Add(Me.balance_field)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.type_field)
        Me.Controls.Add(Me.Billingno_field)
        Me.Controls.Add(Me.print_btn)
        Me.Controls.Add(Me.add_btn)
        Me.Controls.Add(Me.data_table)
        Me.Controls.Add(Me.pd_name)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.total_field)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.price_field)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.year_field)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dp_field)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.name_field)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1500, 987)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1358, 726)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "billing"
        CType(Me.data_table, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.transaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents name_field As TextBox
    Friend WithEvents dp_field As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents year_field As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents item_field As TextBox
    Friend WithEvents price_field As TextBox
    Friend WithEvents total_field As TextBox
    Friend WithEvents pd_name As TextBox
    Friend WithEvents data_table As DataGridView
    Friend WithEvents add_btn As Button
    Friend WithEvents print_btn As Button
    Friend WithEvents type_field As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents quant_field As TextBox
    Friend WithEvents Billingno_field As TextBox
    Friend WithEvents balance_field As TextBox
    Friend WithEvents grand_field As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Id_field As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents spr_field As TextBox
    Friend WithEvents delete_btn As Button
    Friend WithEvents update_btn As Button
    Friend WithEvents serial_no As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents transaction As DataGridView
    Friend WithEvents ref_field As TextBox
    Friend WithEvents Panel1 As Panel
End Class
