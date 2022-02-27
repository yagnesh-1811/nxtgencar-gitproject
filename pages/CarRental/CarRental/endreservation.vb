Imports MySql.Data.MySqlClient
Public Class endreservation

    Private Sub endreservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        ProgressBar1.Value = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim str As String = "Data source = localhost; user id= root;password=;database= cr_user;"
            Dim con As New MySqlConnection(str)
            Dim com As String = "select * from rentlist where client_id = '" & TextBox1.Text & "' "
            Dim adpt As New MySqlDataAdapter(com, con)
            Dim ds As New DataSet()

            adpt.Fill(ds, "vs")

            lblid.Text = ds.Tables(0).Rows(0).Item(0)
            lblamount.Text = ds.Tables(0).Rows(0).Item(2)
            lvldays.Text = ds.Tables(0).Rows(0).Item(1)
            lblvehicleid.Text = ds.Tables(0).Rows(0).Item(7)

        Catch ex As Exception
            MsgBox("No record Found")


        End Try





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim str As String = "data source=localhost; user id=root; password=;database=cr_user"
        Dim con As New MySqlConnection(str)
        Dim com As String = "delete from rentlist where client_id = '" & TextBox1.Text & "' "
        con.Open()
        Dim cmd As New MySqlCommand(com, con)
    

        Dim x As String = cmd.ExecuteNonQuery
        If x >= 1 Then
            Timer1.Enabled = True
        End If
        Dim com1 As String = "update cr_vehicle set quantity = quantity + 1 where vehicle_id = '" & lblvehicleid.Text & "' "
        Dim cmd1 As New MySqlCommand(com1, con)
        Dim y As Integer = cmd1.ExecuteNonQuery
        con.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(+5)


        If ProgressBar1.Value = ProgressBar1.Maximum Then


            Timer1.Stop()
            Timer1.Enabled = False
            MsgBox("Success!")
            main.Show()

            Me.Close()

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        main.Show()
        Me.Close()

    End Sub
End Class