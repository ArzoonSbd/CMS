Imports MySql.Data.MySqlClient
Public Class Sale
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

    Private Sub Btnsave_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Btnload_Click(sender As Object, e As EventArgs)
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
    Private Sub cleartxt()
        CattleType.Text = ""
        Gender.Text = ""
        Age.Text = ""
        SalesRate.Text = ""
        SalesQty.Text = ""



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btnload.Click
        mysqlConn = New MySqlConnection
        mysqlConn.ConnectionString = "server=localhost;user=root;password=Test1234;database=cms"
        'Get the data from the database
        Dim adapter As New MySqlDataAdapter
        Dim dataset As New DataTable
        Dim bsource As New BindingSource
        Try
            mysqlConn.Open()
            Dim Query As String
            Query = "Select * from cms.cmssells"
            command = New MySqlCommand(Query, mysqlConn)
            adapter.SelectCommand = command
            'Filling datasource to binding source
            adapter.Fill(dataset)
            bsource.DataSource = dataset
            sellsDataGridView.DataSource = bsource
            adapter.Update(dataset)
            mysqlConn.Close()



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysqlConn.Dispose()

        End Try

    End Sub

    Private Sub Sale_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
    Public Sub ExecuteQuery(query As String)
        Try
            Dim cmd As New MySqlCommand(query, mysqlConn)
            mysqlConn.Open()
            cmd.ExecuteNonQuery()
            mysqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim deleteQuery As String = "Delete from cmssells where CattleId =" + id.Text
        ExecuteQuery(deleteQuery)
        MessageBox.Show("Data deleted successfully")
    End Sub

    Private Sub Btnsave_Click_1(sender As Object, e As EventArgs) Handles Btnsave.Click
        mysqlConn = New MySqlConnection
        mysqlConn.ConnectionString = "server=localhost;user=root;password=Test1234;database=cms"
        Dim Sql As String = "Insert into cmssells (CattleId, CattleType, Gender, Age, SalesRate,SalesQty) values (@CattleId,@CattleType,@Gender,@Age,@SalesRate,@SalesQty)"
        cmd = New MySqlCommand(Sql, mysqlConn)

        'Parameters
        cmd.Parameters.AddWithValue("@CattleId", Integer.Parse(id.Text))
        cmd.Parameters.AddWithValue("@CattleType", CattleType.Text)
        cmd.Parameters.AddWithValue("@Gender", Gender.Text)
        cmd.Parameters.AddWithValue("@Age", Integer.Parse(Age.Text))
        cmd.Parameters.AddWithValue("@SalesRate", Integer.Parse(SalesRate.Text))
        cmd.Parameters.AddWithValue("@SalesQty", Integer.Parse(SalesQty.Text))
        'cmd.Parameters.AddWithValue("@EntryDate", DateTimePicker)
        'open connection and insert
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
End Class