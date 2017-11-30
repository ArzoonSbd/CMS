<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cmsPage
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CattleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CattleDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncomeAndExpenditureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicalConditionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.CattleToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1352, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'CattleToolStripMenuItem
        '
        Me.CattleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.SaleToolStripMenuItem})
        Me.CattleToolStripMenuItem.Name = "CattleToolStripMenuItem"
        Me.CattleToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.CattleToolStripMenuItem.Text = "Cattle"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddFormToolStripMenuItem})
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'AddFormToolStripMenuItem
        '
        Me.AddFormToolStripMenuItem.Name = "AddFormToolStripMenuItem"
        Me.AddFormToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddFormToolStripMenuItem.Text = "Add form"
        '
        'SaleToolStripMenuItem
        '
        Me.SaleToolStripMenuItem.Name = "SaleToolStripMenuItem"
        Me.SaleToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaleToolStripMenuItem.Text = "Sale"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CattleDetailsToolStripMenuItem, Me.IncomeAndExpenditureToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.MedicalConditionToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'CattleDetailsToolStripMenuItem
        '
        Me.CattleDetailsToolStripMenuItem.Name = "CattleDetailsToolStripMenuItem"
        Me.CattleDetailsToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.CattleDetailsToolStripMenuItem.Text = "Cattle Details"
        '
        'IncomeAndExpenditureToolStripMenuItem
        '
        Me.IncomeAndExpenditureToolStripMenuItem.Name = "IncomeAndExpenditureToolStripMenuItem"
        Me.IncomeAndExpenditureToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.IncomeAndExpenditureToolStripMenuItem.Text = "Income and Expenditure"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'MedicalConditionToolStripMenuItem
        '
        Me.MedicalConditionToolStripMenuItem.Name = "MedicalConditionToolStripMenuItem"
        Me.MedicalConditionToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.MedicalConditionToolStripMenuItem.Text = "Medical Condition"
        '
        'cmsPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1352, 662)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "cmsPage"
        Me.Text = "Cattle Management System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CattleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CattleDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IncomeAndExpenditureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedicalConditionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddFormToolStripMenuItem As ToolStripMenuItem
End Class
