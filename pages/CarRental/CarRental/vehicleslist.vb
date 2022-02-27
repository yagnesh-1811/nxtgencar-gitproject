Imports MySql.Data.MySqlClient
Public Class vehicleslist

    Private Sub vehicleslist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = "Data source = localhost; user id= root;password=;database= cr_user;"
        Dim con As New MySqlConnection(str)
        Dim com As String = "select vehicle_id as 'ID', model as 'Model', license_num as 'License No.', color as 'Color',class_id as 'Class ID', engine_name as 'Engine', daily_rate as 'Daily Rate', weekly_rate as 'Weekly Rate',quantity as 'Quantity',image as 'Photo'  from cr_vehicle"
        Dim adpt As New MySqlDataAdapter(com, con)
        Dim ds As New DataSet()

        adpt.Fill(ds, "vehicles")
        DataGridView1.DataSource = ds.Tables(0)

        
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        clientsmain.Show()
        Me.Close()


    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        clientsmain.Show()

    End Sub
End Class