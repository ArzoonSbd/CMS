<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sale
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.Btnload = New System.Windows.Forms.Button()
        Me.sellsDataGridView = New System.Windows.Forms.DataGridView()
        Me.Btnsave = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SalesQty = New System.Windows.Forms.TextBox()
        Me.SalesRate = New System.Windows.Forms.TextBox()
        Me.Age = New System.Windows.Forms.TextBox()
        Me.Gender = New System.Windows.Forms.TextBox()
        Me.CattleType = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.TextBox()
        Me.CattleId = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.sellsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnDelete)
        Me.GroupBox1.Controls.Add(Me.Btnload)
        Me.GroupBox1.Controls.Add(Me.sellsDataGridView)
        Me.GroupBox1.Controls.Add(Me.Btnsave)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.SalesQty)
        Me.GroupBox1.Controls.Add(Me.SalesRate)
        Me.GroupBox1.Controls.Add(Me.Age)
        Me.GroupBox1.Controls.Add(Me.Gender)
        Me.GroupBox1.Controls.Add(Me.CattleType)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.id)
        Me.GroupBox1.Controls.Add(Me.CattleId)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1346, 662)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sales"
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnDelete.Location = New System.Drawing.Point(203, 497)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(110, 40)
        Me.BtnDelete.TabIndex = 53
        Me.BtnDelete.Text = "Sale"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'Btnload
        '
        Me.Btnload.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnload.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btnload.Location = New System.Drawing.Point(340, 497)
        Me.Btnload.Name = "Btnload"
        Me.Btnload.Size = New System.Drawing.Size(110, 40)
        Me.Btnload.TabIndex = 52
        Me.Btnload.Text = "Load"
        Me.Btnload.UseVisualStyleBackColor = True
        '
        'sellsDataGridView
        '
        Me.sellsDataGridView.AllowUserToOrderColumns = True
        Me.sellsDataGridView.BackgroundColor = System.Drawing.Color.DimGray
        Me.sellsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.sellsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.sellsDataGridView.Location = New System.Drawing.Point(340, 80)
        Me.sellsDataGridView.Name = "sellsDataGridView"
        Me.sellsDataGridView.Size = New System.Drawing.Size(472, 388)
        Me.sellsDataGridView.TabIndex = 51
        '
        'Btnsave
        '
        Me.Btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btnsave.Location = New System.Drawing.Point(40, 497)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(110, 40)
        Me.Btnsave.TabIndex = 50
        Me.Btnsave.Text = "Save"
        Me.Btnsave.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(37, 412)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 16)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Sales Quantity"
        '
        'SalesQty
        '
        Me.SalesQty.Location = New System.Drawing.Point(187, 408)
        Me.SalesQty.Name = "SalesQty"
        Me.SalesQty.Size = New System.Drawing.Size(126, 20)
        Me.SalesQty.TabIndex = 48
        '
        'SalesRate
        '
        Me.SalesRate.Location = New System.Drawing.Point(187, 349)
        Me.SalesRate.Name = "SalesRate"
        Me.SalesRate.Size = New System.Drawing.Size(126, 20)
        Me.SalesRate.TabIndex = 47
        '
        'Age
        '
        Me.Age.Location = New System.Drawing.Point(187, 287)
        Me.Age.Name = "Age"
        Me.Age.Size = New System.Drawing.Size(126, 20)
        Me.Age.TabIndex = 46
        '
        'Gender
        '
        Me.Gender.Location = New System.Drawing.Point(187, 225)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(126, 20)
        Me.Gender.TabIndex = 45
        '
        'CattleType
        '
        Me.CattleType.Location = New System.Drawing.Point(187, 156)
        Me.CattleType.Name = "CattleType"
        Me.CattleType.Size = New System.Drawing.Size(126, 20)
        Me.CattleType.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(37, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "CattleId"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(37, 353)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 16)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Sales Rate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(37, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 16)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Age"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(31, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Gender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(31, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Cattle Type"
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(187, 93)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(126, 20)
        Me.id.TabIndex = 38
        '
        'CattleId
        '
        Me.CattleId.AutoSize = True
        Me.CattleId.Location = New System.Drawing.Point(98, 96)
        Me.CattleId.Name = "CattleId"
        Me.CattleId.Size = New System.Drawing.Size(0, 13)
        Me.CattleId.TabIndex = 37
        '
        'Sale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(828, 571)
        Me.Controls.Add(Me.GroupBox1)
        Me.IsMdiContainer = True
        Me.Name = "Sale"
        Me.Text = "Sale"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.sellsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnDelete As Button
    Friend WithEvents Btnload As Button
    Friend WithEvents sellsDataGridView As DataGridView
    Friend WithEvents Btnsave As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents SalesQty As TextBox
    Friend WithEvents SalesRate As TextBox
    Friend WithEvents Age As TextBox
    Friend WithEvents Gender As TextBox
    Friend WithEvents CattleType As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents id As TextBox
    Friend WithEvents CattleId As Label
End Class
