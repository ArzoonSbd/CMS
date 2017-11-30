<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Me.EmpPhoneno = New System.Windows.Forms.TextBox()
        Me.EmpPassword = New System.Windows.Forms.TextBox()
        Me.EmpUname = New System.Windows.Forms.TextBox()
        Me.EmpName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Empid = New System.Windows.Forms.TextBox()
        Me.CattleId = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Emppost = New System.Windows.Forms.TextBox()
        Me.EmpAdd = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.EmpDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.Btndelete = New System.Windows.Forms.Button()
        Me.BtnLoad = New System.Windows.Forms.Button()
        CType(Me.EmpDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmpPhoneno
        '
        Me.EmpPhoneno.Location = New System.Drawing.Point(228, 305)
        Me.EmpPhoneno.Name = "EmpPhoneno"
        Me.EmpPhoneno.Size = New System.Drawing.Size(126, 20)
        Me.EmpPhoneno.TabIndex = 26
        '
        'EmpPassword
        '
        Me.EmpPassword.Location = New System.Drawing.Point(228, 243)
        Me.EmpPassword.Name = "EmpPassword"
        Me.EmpPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.EmpPassword.Size = New System.Drawing.Size(126, 20)
        Me.EmpPassword.TabIndex = 25
        '
        'EmpUname
        '
        Me.EmpUname.Location = New System.Drawing.Point(228, 180)
        Me.EmpUname.Name = "EmpUname"
        Me.EmpUname.Size = New System.Drawing.Size(126, 20)
        Me.EmpUname.TabIndex = 24
        '
        'EmpName
        '
        Me.EmpName.Location = New System.Drawing.Point(228, 112)
        Me.EmpName.Name = "EmpName"
        Me.EmpName.Size = New System.Drawing.Size(126, 20)
        Me.EmpName.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(78, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "EmpId"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(78, 309)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Phone no"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(78, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "EmpPassword"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(72, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(72, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "EmpName"
        '
        'Empid
        '
        Me.Empid.Location = New System.Drawing.Point(228, 49)
        Me.Empid.Name = "Empid"
        Me.Empid.Size = New System.Drawing.Size(126, 20)
        Me.Empid.TabIndex = 17
        '
        'CattleId
        '
        Me.CattleId.AutoSize = True
        Me.CattleId.Location = New System.Drawing.Point(72, 52)
        Me.CattleId.Name = "CattleId"
        Me.CattleId.Size = New System.Drawing.Size(0, 13)
        Me.CattleId.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(78, 440)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 16)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Post"
        '
        'Emppost
        '
        Me.Emppost.Location = New System.Drawing.Point(228, 436)
        Me.Emppost.Name = "Emppost"
        Me.Emppost.Size = New System.Drawing.Size(126, 20)
        Me.Emppost.TabIndex = 33
        '
        'EmpAdd
        '
        Me.EmpAdd.Location = New System.Drawing.Point(228, 374)
        Me.EmpAdd.Name = "EmpAdd"
        Me.EmpAdd.Size = New System.Drawing.Size(126, 20)
        Me.EmpAdd.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(78, 378)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 16)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Address"
        '
        'EmpDataGridView1
        '
        Me.EmpDataGridView1.AllowUserToOrderColumns = True
        Me.EmpDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpDataGridView1.Location = New System.Drawing.Point(415, 25)
        Me.EmpDataGridView1.Name = "EmpDataGridView1"
        Me.EmpDataGridView1.Size = New System.Drawing.Size(879, 535)
        Me.EmpDataGridView1.TabIndex = 35
        '
        'BtnCreate
        '
        Me.BtnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnCreate.Location = New System.Drawing.Point(12, 617)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(92, 33)
        Me.BtnCreate.TabIndex = 36
        Me.BtnCreate.Text = "Create"
        Me.BtnCreate.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnUpdate.Location = New System.Drawing.Point(132, 617)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(92, 33)
        Me.BtnUpdate.TabIndex = 37
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'Btndelete
        '
        Me.Btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btndelete.Location = New System.Drawing.Point(262, 617)
        Me.Btndelete.Name = "Btndelete"
        Me.Btndelete.Size = New System.Drawing.Size(92, 33)
        Me.Btndelete.TabIndex = 38
        Me.Btndelete.Text = "Delete"
        Me.Btndelete.UseVisualStyleBackColor = True
        '
        'BtnLoad
        '
        Me.BtnLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnLoad.Location = New System.Drawing.Point(386, 617)
        Me.BtnLoad.Name = "BtnLoad"
        Me.BtnLoad.Size = New System.Drawing.Size(92, 33)
        Me.BtnLoad.TabIndex = 39
        Me.BtnLoad.Text = "Load"
        Me.BtnLoad.UseVisualStyleBackColor = True
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1352, 662)
        Me.Controls.Add(Me.BtnLoad)
        Me.Controls.Add(Me.Btndelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.EmpDataGridView1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Emppost)
        Me.Controls.Add(Me.EmpAdd)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.EmpPhoneno)
        Me.Controls.Add(Me.EmpPassword)
        Me.Controls.Add(Me.EmpUname)
        Me.Controls.Add(Me.EmpName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Empid)
        Me.Controls.Add(Me.CattleId)
        Me.Name = "SignUp"
        Me.Text = "SignUp"
        CType(Me.EmpDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EmpPhoneno As TextBox
    Friend WithEvents EmpPassword As TextBox
    Friend WithEvents EmpUname As TextBox
    Friend WithEvents EmpName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Empid As TextBox
    Friend WithEvents CattleId As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Emppost As TextBox
    Friend WithEvents EmpAdd As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents EmpDataGridView1 As DataGridView
    Friend WithEvents BtnCreate As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents Btndelete As Button
    Friend WithEvents BtnLoad As Button
End Class
