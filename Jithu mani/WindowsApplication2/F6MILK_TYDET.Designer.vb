<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F6MILK_TYDET
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.id_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pdname_txt = New System.Windows.Forms.TextBox()
        Me.add_btn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rate_txt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MILK CODE  :"
        '
        'id_txt
        '
        Me.id_txt.Enabled = False
        Me.id_txt.Location = New System.Drawing.Point(112, 70)
        Me.id_txt.Name = "id_txt"
        Me.id_txt.Size = New System.Drawing.Size(41, 20)
        Me.id_txt.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "MILK DETAILS  :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "PRODUCT NAME  :"
        '
        'pdname_txt
        '
        Me.pdname_txt.Location = New System.Drawing.Point(112, 119)
        Me.pdname_txt.Name = "pdname_txt"
        Me.pdname_txt.Size = New System.Drawing.Size(116, 20)
        Me.pdname_txt.TabIndex = 5
        '
        'add_btn
        '
        Me.add_btn.Location = New System.Drawing.Point(58, 221)
        Me.add_btn.Name = "add_btn"
        Me.add_btn.Size = New System.Drawing.Size(80, 41)
        Me.add_btn.TabIndex = 10
        Me.add_btn.Text = "ADD"
        Me.add_btn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "RATE :"
        '
        'rate_txt
        '
        Me.rate_txt.Location = New System.Drawing.Point(112, 153)
        Me.rate_txt.Name = "rate_txt"
        Me.rate_txt.Size = New System.Drawing.Size(116, 20)
        Me.rate_txt.TabIndex = 13
        '
        'F6MILK_TYDET
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 274)
        Me.Controls.Add(Me.rate_txt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.add_btn)
        Me.Controls.Add(Me.pdname_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.id_txt)
        Me.Controls.Add(Me.Label1)
        Me.Name = "F6MILK_TYDET"
        Me.Text = "FORM6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents id_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pdname_txt As System.Windows.Forms.TextBox
    Friend WithEvents add_btn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rate_txt As System.Windows.Forms.TextBox
End Class
