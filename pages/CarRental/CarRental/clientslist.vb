Imports MySql.Data.MySqlClient
Public Class clientslist

    Private Sub clientslist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = "Data source = localhost; user id= root;password=;database= cr_user;"
        Dim con As New MySqlConnection(str)
        Dim com As String = "select client_id as 'ID', fname as 'First Name',lname as 'Last Name',company_name as 'Company', dob as 'Date of Birth', pob as 'Place of Birth',local_address as 'Local Address',home_address as 'Home Address', local_phone as 'Local Phone', home_phone as 'Home Phone', email as 'Email', passport_id as 'Passport ID',license_id as 'License ID' from clients"
        Dim adpt As New MySqlDataAdapter(com, con)
        Dim ds As New DataSet()

        adpt.Fill(ds, "client")
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        addnewclient.Show()

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        editclient.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim str As String = "Data source = localhost; user id= root;password=;database= cr_user;"
        Dim con As New MySqlConnection(str)
        Dim com As String = "select client_id as 'ID',fname as 'First Name', lname as 'Last Name', company_name as 'Company', dob as 'Date of Birth', pob as 'Place of Birth',local_address as 'Local Address',home_address as 'Home Address', local_phone as 'Local Phone', home_phone as 'Home Phone', email as 'Email', passport_id as 'Passport ID',license_id as 'License ID' from clients"
        Dim adpt As New MySqlDataAdapter(com, con)
        Dim ds As New DataSet()

        adpt.Fill(ds, "clienttt")
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Refresh()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        main.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        main.Show()
        Me.Close()


    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        searchclientform.Show()

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        deleteclient.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim str As String = "Data source = localhost; user id= root;password=;database= cr_user;"
        Dim con As New MySqlConnection(str)
        Dim com As String = "select * from clients into outfile 'C:/Users/dianne sunga/Desktop/backup/bu.txt' FIELDS TERMINATED BY ';' ENCLOSED BY '''' LINES TERMINATED BY '\r\n'; "
        Dim adpt As New MySqlDataAdapter(com, con)
        Dim ds As New DataSet()

        Try
            adpt.Fill(ds, "client")
            MsgBox("Records has been backuped successfuly!")
        Catch ex As Exception
            MsgBox("Failed to back up!")
        End Try




    End Sub
End Class