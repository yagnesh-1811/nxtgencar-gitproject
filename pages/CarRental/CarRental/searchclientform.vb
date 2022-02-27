Imports MySql.Data.MySqlClient
Public Class searchclientform

    Private Sub searchclientform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("ID")
        ComboBox1.Items.Add("Name")
        ComboBox1.Items.Add("Email")
        ComboBox1.Items.Add("Passport ID")
        ComboBox1.Items.Add("License ID")
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem = "ID" Then
            Dim str As String = "Data source = localhost; user id= root;password=;database= cr_user;"
            Dim con As New MySqlConnection(str)
            Dim com As String = "select * from clients where client_id like '" & TextBox1.Text & "' "
            Dim adpt As New MySqlDataAdapter(com, con)
            Dim ds As New DataSet()

            adpt.Fill(ds, "vehicles")
            clientslist.DataGridView1.DataSource = ds.Tables(0)
            Me.Hide()
        ElseIf ComboBox1.SelectedItem = "Name" Then
            Dim str As String = "Data source = localhost; user id= root;password=;database= cr_user;"
            Dim con As New MySqlConnection(str)
            Dim com As String = "select * from clients where fname like '" & TextBox1.Text & "' "
            Dim adpt As New MySqlDataAdapter(com, con)
            Dim ds As New DataSet()

            adpt.Fill(ds, "vehicles")
            clientslist.DataGridView1.DataSource = ds.Tables(0)
            Me.Hide()

        ElseIf ComboBox1.SelectedItem = "email" Then
            Dim str As String = "Data source = localhost; user id= root;password=;database= cr_user;"
            Dim con As New MySqlConnection(str)
            Dim com As String = "select * from clients where email like '" & TextBox1.Text & "' "
            Dim adpt As New MySqlDataAdapter(com, con)
            Dim ds As New DataSet()

            adpt.Fill(ds, "cc")
            clientslist.DataGridView1.DataSource = ds.Tables(0)
            Me.Hide()
        ElseIf ComboBox1.SelectedItem = "Passport ID" Then
            Dim str As String = "Data source = localhost; user id= root;password=;database= cr_user;"
            Dim con As New MySqlConnection(str)
            Dim com As String = "select * from clients where passport_id like '" & TextBox1.Text & "' "
            Dim adpt As New MySqlDataAdapter(com, con)
            Dim ds As New DataSet()

            adpt.Fill(ds, "vehicles")
            clientslist.DataGridView1.DataSource = ds.Tables(0)
            Me.Hide()
        ElseIf ComboBox1.SelectedItem = "License ID" Then
            Dim str As String = "Data source = localhost; user id= root;password=;database= cr_user;"
            Dim con As New MySqlConnection(str)
            Dim com As String = "select * from clients where license_id like '" & TextBox1.Text & "' "
            Dim adpt As New MySqlDataAdapter(com, con)
            Dim ds As New DataSet()

            adpt.Fill(ds, "vehicles")
            clientslist.DataGridView1.DataSource = ds.Tables(0)
            Me.Hide()


        End If
    End Sub
  


End Class
