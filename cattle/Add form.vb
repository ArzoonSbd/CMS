Imports MySql.Data.MySqlClient
Public Class Add_form
    'Global Decleration

    ' Dim mysqlConn ConnectionString 
    Dim constring As String = ("server=localhost;user=root;password=Test1234;database=cms")
    Dim con As New MySqlConnection(constring)
    Dim cmd As MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim dt As New DataTable()
    Dim AddWithValue As String


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Add_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Construct Database Gridview
        DataGridView1.ColumnCount = 6
        DataGridView1.Columns(0).Name = "CattleId"
        DataGridView1.Columns(1).Name = "CattleType"
        DataGridView1.Columns(2).Name = "Gender"
        DataGridView1.Columns(3).Name = "Age"
        DataGridView1.Columns(4).Name = "Color"
        DataGridView1.Columns(5).Name = "Entry Date"
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub
    Private Sub cleartxt()

    End Sub

    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click
        Dim Sql As String = "Insert into cmsadd (CattleId, CattleType, Gender, Age, Color, EntryDate) values (@CattleId,@CattleType,@Gender,@Age,@Color,@EntryDate)"
        cmd = New MySqlCommand(Sql, con)

        'Parameters
        cmd.Parameters.AddWithValue("@CattleId", CattleId)
        cmd.Parameters.AddWithValue("@CattleType", CattleType.Text)
        cmd.Parameters.AddWithValue("@Gender", Gender.Text)
        cmd.Parameters.AddWithValue("@Age", Age.Text)
        cmd.Parameters.AddWithValue("@Color", Color.Text)
        ' cmd.Parameters.AddWithValue("@Entry Date", DateTimePicker)
        'open connection and insert
        Try
            con.Open()
            If cmd.ExecuteNonQuery() > 0 Then
                MsgBox("Data insert successfully")
                cleartxt()
            End If
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()

        End Try
    End Sub
    'Populate datagrid
    Private Sub populate(CattleId As Integer, CattleType As String, Gender As String, Age As Integer, Color As String, EntryDate As String)
        Dim row As String() = New String() {CattleId, CattleType, Gender, Age, Color, EntryDate}
        'Add row to rows collection 
        DataGridView1.Rows.Add(row)
    End Sub
    'Retrive data
    Private Sub retrive()
        DataGridView1.Rows.Clear()
        'SQL Statement
        Dim MySql As String = "Select * from cmsadd"
        cmd = New MySqlCommand(MySql, con)
        'Open connection,Retrive,Fill DataGrid
        Try
            con.Open()
            adapter = New MySqlDataAdapter(cmd)
            adapter.Fill(dt)
            'Fill GridView
            For Each row In dt.Rows
                populate(row(0), row(1), row(2), row(3), row(4), row(5))
            Next
            con.Close()
            'Clear DT
            dt.Rows.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()

        End Try

    End Sub
    Private Sub Btnclear_Click(sender As Object, e As EventArgs)

        CattleType.Clear()
        Gender.Clear()
        Age.Clear()
        Color.Clear()


    End Sub


End Class