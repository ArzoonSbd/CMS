Imports MySql.Data.MySqlClient
Public Class staffDetailForm

    Dim mysqlconn As MySqlConnection
    Dim command As MySqlCommand
    Private Sub staffDetailForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnStaffDetail_Click(sender As Object, e As EventArgs) Handles btnStaffDetail.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = "server=localhost;userid=root;password=hero8;database=cms"
        Dim reader As MySqlDataReader
        mysqlconn.Open()
        Dim query As String
        query = "select * from cms.staffinfo where username= '"
        lstboxStaffDetail.Text = query
    End Sub
End Class