Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class vehicle

    Private Sub vehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = "Data source = localhost; user id= root;password=;database= cr_user;"
        Dim con As New MySqlConnection(str)
        Dim com As String = "select vehicle_id as 'ID', model as 'Model', license_num as 'License No.', color as 'Color',class_id as 'Class ID', engine_name as 'Engine', daily_rate as 'Daily Rate', weekly_rate as 'Weekly Rate',quantity as 'Quantity',image as 'Photo'  from cr_vehicle"
        Dim adpt As New MySqlDataAdapter(com, con)
        Dim ds As New DataSet()

        adpt.Fill(ds, "vehicles")
        DataGridView1.DataSource = ds.Tables(0)

        Dim str1 As String = "Data source = localhost; user id= root;password=;database= cr_user;"
        Dim con1 As New MySqlConnection(str1)
        Dim com1 As String = "select vehicle_class_id as 'Vehicle Class ID', vehicle_name as 'Vehicle Name' from vehicle_class"
        Dim adpt1 As New MySqlDataAdapter(com1, con1)
        Dim ds1 As New DataSet()

        adpt1.Fill(ds1, "vehicle")
        DataGridView2.DataSource = ds1.Tables(0)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        addnewvehicle.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        main.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        searchform.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        addvehiclecreditcard.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        deleteform.Show()

    End Sub

   

   

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim str As String = "Data source = localhost; user id= root;password=;database= cr_user;"
        Dim con As New MySqlConnection(str)
        Dim com As String = "select vehicle_id as 'ID', model as 'Model', license_num as 'License No.', color as 'Color',class_id as 'Class ID', engine_name as 'Engine', daily_rate as 'Daily Rate', weekly_rate as 'Weekly Rate',quantity as 'Quantity',image as 'Photo'  from cr_vehicle"
        Dim adpt As New MySqlDataAdapter(com, con)
        Dim ds As New DataSet()

        adpt.Fill(ds, "vehicles")
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Refresh()

        Dim str1 As String = "Data source = localhost; user id= root;password=;database= cr_user;"
        Dim con1 As New MySqlConnection(str1)
        Dim com1 As String = "select vehicle_class_id as 'Vehicle Class ID', vehicle_name as 'Vehicle Name' from vehicle_class"
        Dim adpt1 As New MySqlDataAdapter(com1, con1)
        Dim ds1 As New DataSet()

        adpt1.Fill(ds1, "vehicle")
        DataGridView2.DataSource = ds1.Tables(0)
        DataGridView2.Refresh()


    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim str As String = "Data source = localhost; user id= root;password=;database= cr_user;"
        Dim con As New MySqlConnection(str)
        Dim com As String = "select * from cr_vehicle into outfile 'G:/CarRental/CarRental/backup/vehiclelists.txt'  FIELDS TERMINATED BY ',' OPTIONALLY ENCLOSED BY '''' LINES TERMINATED BY '\n' "
        Dim adpt As New MySqlDataAdapter(com, con)
        Dim ds As New DataSet()
        
        adpt.Fill(ds, "ba")
        MsgBox("Backup Successful!")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim str As String = "Data source = localhost; user id= root;password=;database= cr_user;"
        Dim con As New MySqlConnection(str)
        Dim com As String = "Load data infile 'G:/CarRental/CarRental/backup/vehiclelists.txt' into cr_vehicle FIELDS TERMINATED BY ',' OPTIONALLY ENCLOSED BY '''' LINES TERMINATED BY '\n' "
        Dim adpt As New MySqlDataAdapter(com, con)
        Dim ds As New DataSet()

        adpt.Fill(ds, "ba")
        MsgBox("Backup Successful!")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        editform.Show()

    End Sub
End Class