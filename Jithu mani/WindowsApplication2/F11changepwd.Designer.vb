<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F11changepwd
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cpwd_txt = New System.Windows.Forms.TextBox()
        Me.newpwd_txt = New System.Windows.Forms.TextBox()
        Me.verify_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.changepwd_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "change password  :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "current password  :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "verify pasword  :"
        '
        'cpwd_txt
        '
        Me.cpwd_txt.Location = New System.Drawing.Point(127, 50)
        Me.cpwd_txt.Name = "cpwd_txt"
        Me.cpwd_txt.Size = New System.Drawing.Size(96, 20)
        Me.cpwd_txt.TabIndex = 3
        '
        'newpwd_txt
        '
        Me.newpwd_txt.Location = New System.Drawing.Point(130, 107)
        Me.newpwd_txt.Name = "newpwd_txt"
        Me.newpwd_txt.Size = New System.Drawing.Size(93, 20)
        Me.newpwd_txt.TabIndex = 4
        '
        'verify_txt
        '
        Me.verify_txt.Location = New System.Drawing.Point(128, 157)
        Me.verify_txt.Name = "verify_txt"
        Me.verify_txt.Size = New System.Drawing.Size(95, 20)
        Me.verify_txt.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "new password  :"
        '
        'changepwd_btn
        '
        Me.changepwd_btn.Location = New System.Drawing.Point(60, 205)
        Me.changepwd_btn.Name = "changepwd_btn"
        Me.changepwd_btn.Size = New System.Drawing.Size(94, 31)
        Me.changepwd_btn.TabIndex = 7
        Me.changepwd_btn.Text = "change"
        Me.changepwd_btn.UseVisualStyleBackColor = True
        '
        'F11changepwd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.changepwd_btn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.verify_txt)
        Me.Controls.Add(Me.newpwd_txt)
        Me.Controls.Add(Me.cpwd_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "F11changepwd"
        Me.Text = "F11changepwd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cpwd_txt As System.Windows.Forms.TextBox
    Friend WithEvents newpwd_txt As System.Windows.Forms.TextBox
    Friend WithEvents verify_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents changepwd_btn As System.Windows.Forms.Button
End Class
