Imports MySql.Data.MySqlClient
Public Class SignUp
    'Global Decleration
    Dim mysqlConn As MySqlConnection
    Dim command As MySqlCommand




    ' Dim mysqlConn ConnectionString 
    'Dim constring As String = "server=localhost;user=root;password=Test1234;database=cms"
    'Dim Mysqlconn As New MySqlConnection(constring)
    Dim cmd As MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim dt As New DataTable()
    Dim AddWithValue As String
    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub cleartxt()
        EmpName.Text = ""
        EmpUname.Text = ""
        EmpPassword.Text = ""
        EmpPhoneno.Text = ""
        ' Empemail.Text = ""
        EmpAdd.Text = ""
        Emppost.Text = ""

    End Sub
    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        mysqlConn = New MySqlConnection
        mysqlConn.ConnectionString = "server=localhost;user=root;password=Test1234;database=cms"
        Dim Sql As String = "Insert into cmsemp (EmpId, EmpName, UserName, EmpPassword, Phoneno ,Address ,Post) values (@EmpId, @EmpName, @UserName, @EmpPassword, @Phoneno,@Address,@Post)"
        cmd = New MySqlCommand(Sql, mysqlConn)

        'Parameters
        cmd.Parameters.AddWithValue("@EmpId", Integer.Parse(Empid.Text))
        cmd.Parameters.AddWithValue("@EmpName", EmpName.Text)
        cmd.Parameters.AddWithValue("@Username", EmpUname.Text)
        cmd.Parameters.AddWithValue("@EmpPassword", EmpPassword.Text)
        cmd.Parameters.AddWithValue("@Phoneno", Integer.Parse(EmpPhoneno.Text))
        'cmd.Parameters.AddWithValue("@EmailAddress", Empemail.Text)
        cmd.Parameters.AddWithValue("@Address", EmpAdd.Text)
        cmd.Parameters.AddWithValue("@Post", Emppost.Text)



        Try
            mysqlConn.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                MsgBox("Data insert successfully")
                cleartxt()
            End If
            mysqlConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            mysqlConn.Close()

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpDataGridView1.CellContentClick

    End Sub

    Private Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles BtnLoad.Click
        mysqlConn = New MySqlConnection
        mysqlConn.ConnectionString = "server=localhost;user=root;password=Test1234;database=cms"
        'Get the data from the database
        Dim adapter As New MySqlDataAdapter
        Dim dataset As New DataTable
        Dim bsource As New BindingSource
        Try
            mysqlConn.Open()
            Dim Query As String
            Query = "Select * from cms.cmsemp"
            command = New MySqlCommand(Query, mysqlConn)
            adapter.SelectCommand = command
            'Filling datasource to binding source
            adapter.Fill(dataset)
            bsource.DataSource = dataset
            EmpDataGridView1.DataSource = bsource
            adapter.Update(dataset)
            mysqlConn.Close()



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysqlConn.Dispose()

        End Try


    End Sub
    Public Sub ExecuteQuery(query As String)
        Dim cmd As New MySqlCommand(query, mysqlConn)
        mysqlConn.Open()
        cmd.ExecuteNonQuery()
        mysqlConn.Close()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click

        Dim UpdateQuery As String = "Update cmsemp set EmpName='" + EmpName.Text + "',Username='" + EmpUname.Text + "',EmpPassword='" + EmpPassword.Text + "',Phoneno='" + EmpPhoneno.Text + "',Address='" + EmpAdd.Text + "',Post='" + Emppost.Text + "' where EmpId ='" + Empid.Text + "'"

        ExecuteQuery(UpdateQuery)
        MessageBox.Show("Data Update successfully")
    End Sub

    Private Sub Btndelete_Click(sender As Object, e As EventArgs) Handles Btndelete.Click
        Dim deleteQuery As String = "Delete from cmsemp where EmpId =" & Empid.Text
        ExecuteQuery(deleteQuery)
        MessageBox.Show("Data deleted successfully")
    End Sub
End Class