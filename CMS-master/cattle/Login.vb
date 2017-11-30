Imports MySql.Data.MySqlClient
Public Class LoginForm
    Dim mysqlConn As MySqlConnection
    Dim command As MySqlCommand

    Private Sub txtboxUname_TextChanged(sender As Object, e As EventArgs) Handles txtboxUname.TextChanged

    End Sub

    Private Sub btnChkCnn_Click(sender As Object, e As EventArgs) Handles btnChkCnn.Click
        mysqlConn = New MySqlConnection
        mysqlConn.ConnectionString = "server=localhost;user=root;password=Test1234;database=cms"

        Try
            mysqlConn.Open()
            MessageBox.Show("Connection Successful")
            mysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            mysqlConn.Dispose()
        End Try
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        mysqlConn = New MySqlConnection
        mysqlConn.ConnectionString = "server=localhost;user=root;password=Test1234;database=cms"
        Dim reader As MySqlDataReader
        Try
            mysqlConn.Open()
            Dim query As String
            query = "select * from cmsemp where username= '" & txtboxUname.Text & "' and EmpPassword = '" & txtboxPword.Text & "' "
            command = New MySqlCommand(query, mysqlConn)
            reader = command.ExecuteReader
            Dim count As Integer = Nothing
            While reader.Read
                count = count + 1
            End While

            If count = 1 Then
                cmsPage.Show()
                Me.Hide()
            ElseIf count > 1 Then
                MessageBox.Show("Username and password are dublicate")
            Else
                MessageBox.Show("Username or Password is incorrect")
            End If

            mysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            mysqlConn.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Dim signup As SignUp = New SignUp
        Dim x As SignUp = New SignUp
        x.Show()


        'SignUp.Show()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class