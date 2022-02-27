Imports MySql.Data.MySqlClient
Public Class rentlist

    Private Sub rentlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = "Data source = localhost; user id= root;password=;database= cr_user;"
        Dim con As New MySqlConnection(str)
        Dim com As String = "select client_id as 'Customer ID', day as 'Days of Rent',vehicle_id as 'Vehicle ID',model as 'Car Model', color as 'Color',engine as 'Engine',license_no as 'License No.' from rentlist"
        Dim adpt As New MySqlDataAdapter(com, con)
        Dim ds As New DataSet()

        adpt.Fill(ds, "vehicles")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        main.Show()
        Me.Close()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim str As String = "Data source = localhost; user id= root;password=;database= cr_user;"
        Dim con As New MySqlConnection(str)
        Dim com As String = "select * from rentlist where client_id = '" & TextBox1.Text & "' "
        Dim adpt As New MySqlDataAdapter(com, con)
        Dim ds As New DataSet()

        adpt.Fill(ds, "v")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim str As String = "data source=localhost; user id=root; password=;database=cr_user"
        Dim con As New MySqlConnection(str)
        Dim com As String = "delete from rentlist where client_id = '" & TextBox1.Text & "' "
        con.Open()
        Dim cmd As New MySqlCommand(com, con)


        Dim x As String = cmd.ExecuteNonQuery
        If x >= 1 Then
            MsgBox("Deleted Successfully")
            DataGridView1.Refresh()

        End If
        con.Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim str As String = "Data source = localhost; user id= root;password=;database= cr_user;"
        Dim con As New MySqlConnection(str)
        Dim com As String = "select client_id as 'Client ID', day as 'Days of Rent',vehicle_id as 'Vehicle ID',model as 'Car Model', color as 'Color',engine as 'Engine',license_no as 'License No.' from rentlist"
        Dim adpt As New MySqlDataAdapter(com, con)
        Dim ds As New DataSet()

        adpt.Fill(ds, "vehicles")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub
End Class