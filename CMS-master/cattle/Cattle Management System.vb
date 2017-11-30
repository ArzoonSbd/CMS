
Public Class cmsPage

    Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub DetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        Dim staffdetail As staffDetailForm = New staffDetailForm
        staffdetail.MdiParent = Me
        staffdetail.Show()
    End Sub

    Private Sub cmsPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AddFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddFormToolStripMenuItem.Click
        Dim add As Add_form = New Add_form
        add.MdiParent = Me
        add.Show()
    End Sub

    Private Sub SalesFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaleToolStripMenuItem.Click
        Dim y As Sale = New Sale
        y.Show()
        Me.Hide()
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click

    End Sub

    Private Sub SaleToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
End Class