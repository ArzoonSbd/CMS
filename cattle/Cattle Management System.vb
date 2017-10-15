
Public Class cmsPage

    Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductToolStripMenuItem.Click

    End Sub

    Private Sub DetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailsToolStripMenuItem.Click
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
End Class