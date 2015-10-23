<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class milktypedetails
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Milkdetails = New WindowsApplication2.milkdetails()
        Me.MilktypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MilktypeTableAdapter = New WindowsApplication2.milkdetailsTableAdapters.milktypeTableAdapter()
        Me.CodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Milkdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MilktypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeDataGridViewTextBoxColumn, Me.PrnameDataGridViewTextBoxColumn, Me.RateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MilktypeBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(494, 397)
        Me.DataGridView1.TabIndex = 0
        '
        'Milkdetails
        '
        Me.Milkdetails.DataSetName = "milkdetails"
        Me.Milkdetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MilktypeBindingSource
        '
        Me.MilktypeBindingSource.DataMember = "milktype"
        Me.MilktypeBindingSource.DataSource = Me.Milkdetails
        '
        'MilktypeTableAdapter
        '
        Me.MilktypeTableAdapter.ClearBeforeFill = True
        '
        'CodeDataGridViewTextBoxColumn
        '
        Me.CodeDataGridViewTextBoxColumn.DataPropertyName = "code"
        Me.CodeDataGridViewTextBoxColumn.HeaderText = "code"
        Me.CodeDataGridViewTextBoxColumn.Name = "CodeDataGridViewTextBoxColumn"
        '
        'PrnameDataGridViewTextBoxColumn
        '
        Me.PrnameDataGridViewTextBoxColumn.DataPropertyName = "pr_name"
        Me.PrnameDataGridViewTextBoxColumn.HeaderText = "pr_name"
        Me.PrnameDataGridViewTextBoxColumn.Name = "PrnameDataGridViewTextBoxColumn"
        '
        'RateDataGridViewTextBoxColumn
        '
        Me.RateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RateDataGridViewTextBoxColumn.DataPropertyName = "rate"
        Me.RateDataGridViewTextBoxColumn.HeaderText = "rate"
        Me.RateDataGridViewTextBoxColumn.Name = "RateDataGridViewTextBoxColumn"
        '
        'milktypedetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 397)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "milktypedetails"
        Me.Text = "milktypedetails"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Milkdetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MilktypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Milkdetails As WindowsApplication2.milkdetails
    Friend WithEvents MilktypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MilktypeTableAdapter As WindowsApplication2.milkdetailsTableAdapters.milktypeTableAdapter
    Friend WithEvents CodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
