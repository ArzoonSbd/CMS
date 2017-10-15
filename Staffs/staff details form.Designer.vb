<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staffDetailForm
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
        Me.lstboxStaffDetail = New System.Windows.Forms.ListBox()
        Me.staffDetailGrpbox = New System.Windows.Forms.GroupBox()
        Me.btnStaffDetail = New System.Windows.Forms.Button()
        Me.staffDetailGrpbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstboxStaffDetail
        '
        Me.lstboxStaffDetail.FormattingEnabled = True
        Me.lstboxStaffDetail.Location = New System.Drawing.Point(6, 76)
        Me.lstboxStaffDetail.Name = "lstboxStaffDetail"
        Me.lstboxStaffDetail.Size = New System.Drawing.Size(584, 225)
        Me.lstboxStaffDetail.TabIndex = 0
        '
        'staffDetailGrpbox
        '
        Me.staffDetailGrpbox.Controls.Add(Me.btnStaffDetail)
        Me.staffDetailGrpbox.Controls.Add(Me.lstboxStaffDetail)
        Me.staffDetailGrpbox.Location = New System.Drawing.Point(12, 12)
        Me.staffDetailGrpbox.Name = "staffDetailGrpbox"
        Me.staffDetailGrpbox.Size = New System.Drawing.Size(596, 319)
        Me.staffDetailGrpbox.TabIndex = 1
        Me.staffDetailGrpbox.TabStop = False
        Me.staffDetailGrpbox.Text = "Staff Detail"
        '
        'btnStaffDetail
        '
        Me.btnStaffDetail.Location = New System.Drawing.Point(6, 19)
        Me.btnStaffDetail.Name = "btnStaffDetail"
        Me.btnStaffDetail.Size = New System.Drawing.Size(106, 51)
        Me.btnStaffDetail.TabIndex = 1
        Me.btnStaffDetail.Text = "View"
        Me.btnStaffDetail.UseVisualStyleBackColor = True
        '
        'staffDetailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 343)
        Me.Controls.Add(Me.staffDetailGrpbox)
        Me.Name = "staffDetailForm"
        Me.Text = "Staff Details"
        Me.staffDetailGrpbox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstboxStaffDetail As ListBox
    Friend WithEvents staffDetailGrpbox As GroupBox
    Friend WithEvents btnStaffDetail As Button
End Class
