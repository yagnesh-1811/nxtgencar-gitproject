Imports MySql.Data.MySqlClient
Public Class searchreservation

    Private Sub searchreservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("ID")
        ComboBox1.Items.Add("Car Model")
        ComboBox1.Items.Add("Color")
        ComboBox1.Items.Add("Class ID")
        ComboBox1.Items.Add("License No.")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem = "ID" Then
            Dim str As String = "Data source = localhost; user id= root;password=;database= cr_user;"
            Dim con As New MySqlConnection(str)
            Dim com As String = "select * from cr_vehicle where vehicle_id like  '" & TextBox1.Text & "' "
            Dim adpt As New MySqlDataAdapter(com, con)
            Dim ds As New DataSet()

            adpt.Fill(ds, "vehicles")
            addnewreservation.DataGridView1.DataSource = ds.Tables(0)
            Me.Hide()
        ElseIf ComboBox1.SelectedItem = "Car Model" Then
            Dim str As String = "Data source = localhost; user id= root;password=;database= cr_user;"
            Dim con As New MySqlConnection(str)
            Dim com As String = "select * from cr_vehicle where model like '" & TextBox1.Text & "' "
            Dim adpt As New MySqlDataAdapter(com, con)
            Dim ds As New DataSet()

            adpt.Fill(ds, "vehicles")
            addnewreservation.DataGridView1.DataSource = ds.Tables(0)
            Me.Hide()

        ElseIf ComboBox1.SelectedItem = "Color" Then
            Dim str As String = "Data source = localhost; user id= root;password=;database= cr_user;"
            Dim con As New MySqlConnection(str)
            Dim com As String = "select * from cr_vehicle where color like '" & TextBox1.Text & "' "
            Dim adpt As New MySqlDataAdapter(com, con)
            Dim ds As New DataSet()

            adpt.Fill(ds, "vehicles")
            addnewreservation.DataGridView1.DataSource = ds.Tables(0)
            Me.Hide()
        ElseIf ComboBox1.SelectedItem = "Class ID" Then
            Dim str As String = "Data source = localhost; user id= root;password=;database= cr_user;"
            Dim con As New MySqlConnection(str)
            Dim com As String = "select * from cr_vehicle where class_id like '" & TextBox1.Text & "' "
            Dim adpt As New MySqlDataAdapter(com, con)
            Dim ds As New DataSet()

            adpt.Fill(ds, "vehicles")
            addnewreservation.DataGridView1.DataSource = ds.Tables(0)
            Me.Hide()
        ElseIf ComboBox1.SelectedItem = "License No." Then
            Dim str As String = "Data source = localhost; user id= root;password=;database= cr_user;"
            Dim con As New MySqlConnection(str)
            Dim com As String = "select * from cr_vehicle where model like '" & TextBox1.Text & "' "
            Dim adpt As New MySqlDataAdapter(com, con)
            Dim ds As New DataSet()

            adpt.Fill(ds, "vehicles")
            addnewreservation.DataGridView1.DataSource = ds.Tables(0)
            Me.Hide()


        End If
    End Sub
End Class