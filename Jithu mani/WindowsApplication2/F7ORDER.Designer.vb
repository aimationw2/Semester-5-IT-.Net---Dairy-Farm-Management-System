<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F7ORDER
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.prevordr_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.date_cal = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.plceordr_btn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ordrid_txt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mlkname_combo = New System.Windows.Forms.ComboBox()
        Me.MilktypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Milkdetails = New WindowsApplication2.milkdetails()
        Me.MilktypeTableAdapter = New WindowsApplication2.milkdetailsTableAdapters.milktypeTableAdapter()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.qty_txt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.amt_txt = New System.Windows.Forms.TextBox()
        Me.rate_txt = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.changepwd_txt = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TABLE = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TIME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MILKNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AMOUNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.MilktypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Milkdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TABLE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'prevordr_btn
        '
        Me.prevordr_btn.Location = New System.Drawing.Point(11, 345)
        Me.prevordr_btn.Name = "prevordr_btn"
        Me.prevordr_btn.Size = New System.Drawing.Size(93, 49)
        Me.prevordr_btn.TabIndex = 0
        Me.prevordr_btn.Text = "PREVIOUS ORDERS"
        Me.prevordr_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "WELCOME!!!!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PLEASE PLACE YOUR ORDERS...."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ORDER ON DATE  :"
        '
        'date_cal
        '
        Me.date_cal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_cal.Location = New System.Drawing.Point(161, 104)
        Me.date_cal.Name = "date_cal"
        Me.date_cal.Size = New System.Drawing.Size(131, 20)
        Me.date_cal.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "MILK name  :"
        '
        'plceordr_btn
        '
        Me.plceordr_btn.Location = New System.Drawing.Point(140, 345)
        Me.plceordr_btn.Name = "plceordr_btn"
        Me.plceordr_btn.Size = New System.Drawing.Size(104, 49)
        Me.plceordr_btn.TabIndex = 7
        Me.plceordr_btn.Text = "PLACE ORDER"
        Me.plceordr_btn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "order id"
        '
        'ordrid_txt
        '
        Me.ordrid_txt.Enabled = False
        Me.ordrid_txt.Location = New System.Drawing.Point(161, 78)
        Me.ordrid_txt.Name = "ordrid_txt"
        Me.ordrid_txt.Size = New System.Drawing.Size(100, 20)
        Me.ordrid_txt.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "time"
        '
        'mlkname_combo
        '
        Me.mlkname_combo.DataSource = Me.MilktypeBindingSource
        Me.mlkname_combo.DisplayMember = "pr_name"
        Me.mlkname_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.mlkname_combo.FormattingEnabled = True
        Me.mlkname_combo.Location = New System.Drawing.Point(169, 186)
        Me.mlkname_combo.Name = "mlkname_combo"
        Me.mlkname_combo.Size = New System.Drawing.Size(121, 21)
        Me.mlkname_combo.TabIndex = 12
        Me.mlkname_combo.TabStop = False
        Me.mlkname_combo.ValueMember = "pr_name"
        '
        'MilktypeBindingSource
        '
        Me.MilktypeBindingSource.DataMember = "milktype"
        Me.MilktypeBindingSource.DataSource = Me.Milkdetails
        '
        'Milkdetails
        '
        Me.Milkdetails.DataSetName = "milkdetails"
        Me.Milkdetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MilktypeTableAdapter
        '
        Me.MilktypeTableAdapter.ClearBeforeFill = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(43, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "qty"
        '
        'qty_txt
        '
        Me.qty_txt.Enabled = False
        Me.qty_txt.Location = New System.Drawing.Point(166, 221)
        Me.qty_txt.Name = "qty_txt"
        Me.qty_txt.Size = New System.Drawing.Size(126, 20)
        Me.qty_txt.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(47, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Amount"
        '
        'amt_txt
        '
        Me.amt_txt.Enabled = False
        Me.amt_txt.Location = New System.Drawing.Point(165, 251)
        Me.amt_txt.Name = "amt_txt"
        Me.amt_txt.Size = New System.Drawing.Size(127, 20)
        Me.amt_txt.TabIndex = 16
        '
        'rate_txt
        '
        Me.rate_txt.AutoSize = True
        Me.rate_txt.Location = New System.Drawing.Point(346, 194)
        Me.rate_txt.Name = "rate_txt"
        Me.rate_txt.Size = New System.Drawing.Size(0, 13)
        Me.rate_txt.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(304, 193)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Rate :"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(172, 155)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton1.TabIndex = 19
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "morning"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(248, 158)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(63, 17)
        Me.RadioButton2.TabIndex = 20
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "evening"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(334, 158)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(46, 17)
        Me.RadioButton3.TabIndex = 21
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "both"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'changepwd_txt
        '
        Me.changepwd_txt.Location = New System.Drawing.Point(274, 345)
        Me.changepwd_txt.Name = "changepwd_txt"
        Me.changepwd_txt.Size = New System.Drawing.Size(82, 49)
        Me.changepwd_txt.TabIndex = 22
        Me.changepwd_txt.Text = "CHANGE PASSWORD"
        Me.changepwd_txt.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(40, 301)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 28)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "product rates"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(138, 409)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 42)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "LOGOUT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TABLE
        '
        Me.TABLE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TABLE.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TIME, Me.MILKNAME, Me.QTY, Me.AMOUNT})
        Me.TABLE.Dock = System.Windows.Forms.DockStyle.Right
        Me.TABLE.Location = New System.Drawing.Point(406, 0)
        Me.TABLE.Name = "TABLE"
        Me.TABLE.Size = New System.Drawing.Size(467, 451)
        Me.TABLE.TabIndex = 25
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(208, 301)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 23)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "ADD TO CART"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TIME
        '
        Me.TIME.HeaderText = "TIME"
        Me.TIME.Name = "TIME"
        '
        'MILKNAME
        '
        Me.MILKNAME.HeaderText = "MILKNAME"
        Me.MILKNAME.Name = "MILKNAME"
        '
        'QTY
        '
        Me.QTY.HeaderText = "QUANTITY"
        Me.QTY.Name = "QTY"
        '
        'AMOUNT
        '
        Me.AMOUNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AMOUNT.HeaderText = "AMOUNT"
        Me.AMOUNT.Name = "AMOUNT"
        '
        'F7ORDER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 451)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TABLE)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.changepwd_txt)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.rate_txt)
        Me.Controls.Add(Me.amt_txt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.qty_txt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.mlkname_combo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ordrid_txt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.plceordr_btn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.date_cal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.prevordr_btn)
        Me.Name = "F7ORDER"
        Me.Text = "Form7"
        CType(Me.MilktypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Milkdetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TABLE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents prevordr_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents date_cal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents plceordr_btn As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ordrid_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents mlkname_combo As System.Windows.Forms.ComboBox
    Friend WithEvents Milkdetails As WindowsApplication2.milkdetails
    Friend WithEvents MilktypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MilktypeTableAdapter As WindowsApplication2.milkdetailsTableAdapters.milktypeTableAdapter
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents qty_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents amt_txt As System.Windows.Forms.TextBox
    Friend WithEvents rate_txt As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents changepwd_txt As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TABLE As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TIME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MILKNAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QTY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AMOUNT As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
