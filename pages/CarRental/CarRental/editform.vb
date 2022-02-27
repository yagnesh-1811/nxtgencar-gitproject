Imports MySql.Data.MySqlClient
Public Class editform

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

      

        Dim str As String = "Data source = localhost; user id= root;password=;database= cr_user;"
        Dim con As New MySqlConnection(str)
        Dim com As String = "select * from cr_vehicle where vehicle_id = '" & TextBox1.Text & "' "
        Dim adpt As New MySqlDataAdapter(com, con)
        Dim ds As New DataSet()

        adpt.Fill(ds, "vehicles")
        vehicle.DataGridView1.DataSource = ds.Tables(0)
        btnlicense.Text = ds.Tables(0).Rows(0).Item(1)
        txtmodel.Text = ds.Tables(0).Rows(0).Item(2)

        ComboBox1.SelectedItem = ds.Tables(0).Rows(0).Item(3)
        txtclassid.Text = ds.Tables(0).Rows(0).Item(4)
        TextBox2.Text = ds.Tables(0).Rows(0).Item(9)
        txtengine.Text = ds.Tables(0).Rows(0).Item(5)

        txtdaily.Text = ds.Tables(0).Rows(0).Item(6)
        txtweekly.Text = ds.Tables(0).Rows(0).Item(7)

    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        

        Dim str As String = "data source=localhost; user id=root; password=;database=cr_user"
        Dim con As New MySqlConnection(str)
        Dim com As String = "update cr_vehicle set license_num = '" & btnlicense.Text & "', model = '" & txtmodel.Text & "' , color= '" & ComboBox1.SelectedItem & "', class_id = '" & txtclassid.Text & "', quantity = '" & TextBox2.Text & "', engine_name = '" & txtengine.Text & "', daily_rate = '" & txtdaily.Text & "', weekly_rate = '" & txtweekly.Text & "' where vehicle_id = '" & TextBox1.Text & "' "
        con.Open()
        Dim cmd As New MySqlCommand(com, con)
       

        Dim x As String = cmd.ExecuteNonQuery
        If x >= 1 Then
            Timer1.Enabled = True


        End If
        con.Close()
    End Sub

    Private Sub editform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Red")
        ComboBox1.Items.Add("Blue")
        ComboBox1.Items.Add("Green")
        ComboBox1.Items.Add("White")
        ComboBox1.Items.Add("Black")
        ComboBox1.Items.Add("Grey")
        ComboBox1.Items.Add("Yellow")




        Timer1.Enabled = False
        ProgressBar1.Value = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(+5)




        If ProgressBar1.Value = ProgressBar1.Maximum Then


            Timer1.Stop()
            Timer1.Enabled = False
            MsgBox("Success!")
            vehicle.Show()
            vehicle.DataGridView1.Refresh()
            Me.Close()

        End If

    End Sub
End Class



   
 