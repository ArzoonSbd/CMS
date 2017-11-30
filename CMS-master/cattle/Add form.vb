Imports MySql.Data.MySqlClient
Imports System.Data.DataTable

Public Class Add_form
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


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Add_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        AddDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub
    Private Sub cleartxt()
        CattleType.Text = ""
        Gender.Text = ""
        Age.Text = ""
        Color.Text = ""



    End Sub

    Private Sub Loadtxt()
        mysqlConn = New MySqlConnection
        mysqlConn.ConnectionString = "server=localhost;user=root;password=Test1234;database=cms"
        'Get the data from the database
        Dim adapter As New MySqlDataAdapter
        Dim dataset As New DataTable
        Dim bsource As New BindingSource
        Try
            mysqlConn.Open()
            Dim Query As String
            Query = "Select * from cms.cmsadd"
            command = New MySqlCommand(Query, mysqlConn)
            adapter.SelectCommand = command
            'Filling datasource to binding source
            adapter.Fill(dataset)
            bsource.DataSource = dataset
            AddDataGridView.DataSource = bsource
            adapter.Update(dataset)
            mysqlConn.Close()



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysqlConn.Dispose()

        End Try

    End Sub
    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click
        mysqlConn = New MySqlConnection
        mysqlConn.ConnectionString = "server=localhost;user=root;password=Test1234;database=cms"
        Dim Sql As String = "Insert into cmsadd (CattleId, CattleType, Gender, Age, Color) values (@CattleId,@CattleType,@Gender,@Age,@Color)"
        cmd = New MySqlCommand(Sql, mysqlConn)

        'Parameters
        cmd.Parameters.AddWithValue("@CattleId", Integer.Parse(CattleId.Text))
        cmd.Parameters.AddWithValue("@CattleType", CattleType.Text)
        cmd.Parameters.AddWithValue("@Gender", Gender.Text)
        cmd.Parameters.AddWithValue("@Age", Integer.Parse(Age.Text))
        cmd.Parameters.AddWithValue("@Color", Color.Text)
        'cmd.Parameters.AddWithValue("@EntryDate", DateTimePicker)
        'open connection and insert
        Try
            mysqlConn.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                MsgBox("Data insert successfully")
                cleartxt()
                Loadtxt()

            End If
            mysqlConn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            mysqlConn.Close()

        End Try
    End Sub




    'Populate datagrid
    'Private Sub populate(CattleId As Integer, CattleType As String, Gender As String, Age As Integer, Color As String, EntryDate As String)
    'Dim row As String() = New String() {CattleId, CattleType, Gender, Age, Color, EntryDate}
    'Add row to rows collection 
    ' AddDataGridView.Rows.Add(row)
    'End Sub





    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AddDataGridView.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnLoad.Click
        Loadtxt()


    End Sub


End Class