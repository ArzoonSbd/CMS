<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
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
        Me.lblUname = New System.Windows.Forms.Label()
        Me.lblPword = New System.Windows.Forms.Label()
        Me.btnChkCnn = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtboxUname = New System.Windows.Forms.TextBox()
        Me.txtboxPword = New System.Windows.Forms.TextBox()
        Me.grpboxLogin = New System.Windows.Forms.GroupBox()
        Me.grpboxLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUname
        '
        Me.lblUname.AutoSize = True
        Me.lblUname.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUname.Location = New System.Drawing.Point(65, 68)
        Me.lblUname.Name = "lblUname"
        Me.lblUname.Size = New System.Drawing.Size(122, 31)
        Me.lblUname.TabIndex = 0
        Me.lblUname.Text = "Username"
        '
        'lblPword
        '
        Me.lblPword.AutoSize = True
        Me.lblPword.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPword.Location = New System.Drawing.Point(65, 142)
        Me.lblPword.Name = "lblPword"
        Me.lblPword.Size = New System.Drawing.Size(117, 31)
        Me.lblPword.TabIndex = 1
        Me.lblPword.Text = "Password"
        '
        'btnChkCnn
        '
        Me.btnChkCnn.Location = New System.Drawing.Point(86, 218)
        Me.btnChkCnn.Name = "btnChkCnn"
        Me.btnChkCnn.Size = New System.Drawing.Size(121, 48)
        Me.btnChkCnn.TabIndex = 2
        Me.btnChkCnn.Text = "Check Connection"
        Me.btnChkCnn.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(274, 218)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(112, 48)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtboxUname
        '
        Me.txtboxUname.Location = New System.Drawing.Point(244, 78)
        Me.txtboxUname.Name = "txtboxUname"
        Me.txtboxUname.Size = New System.Drawing.Size(174, 20)
        Me.txtboxUname.TabIndex = 4
        '
        'txtboxPword
        '
        Me.txtboxPword.Location = New System.Drawing.Point(244, 153)
        Me.txtboxPword.Name = "txtboxPword"
        Me.txtboxPword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtboxPword.Size = New System.Drawing.Size(174, 20)
        Me.txtboxPword.TabIndex = 5
        '
        'grpboxLogin
        '
        Me.grpboxLogin.Controls.Add(Me.lblUname)
        Me.grpboxLogin.Controls.Add(Me.btnLogin)
        Me.grpboxLogin.Controls.Add(Me.txtboxPword)
        Me.grpboxLogin.Controls.Add(Me.btnChkCnn)
        Me.grpboxLogin.Controls.Add(Me.txtboxUname)
        Me.grpboxLogin.Controls.Add(Me.lblPword)
        Me.grpboxLogin.Location = New System.Drawing.Point(12, 12)
        Me.grpboxLogin.Name = "grpboxLogin"
        Me.grpboxLogin.Size = New System.Drawing.Size(571, 287)
        Me.grpboxLogin.TabIndex = 6
        Me.grpboxLogin.TabStop = False
        Me.grpboxLogin.Text = "Login Page"
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 311)
        Me.Controls.Add(Me.grpboxLogin)
        Me.Name = "loginForm"
        Me.Text = "Login Authentication"
        Me.grpboxLogin.ResumeLayout(False)
        Me.grpboxLogin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblUname As Label
    Friend WithEvents lblPword As Label
    Friend WithEvents btnChkCnn As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtboxUname As TextBox
    Friend WithEvents txtboxPword As TextBox
    Friend WithEvents grpboxLogin As GroupBox
End Class
