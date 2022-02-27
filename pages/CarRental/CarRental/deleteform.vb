Imports MySql.Data.MySqlClient
Public Class deleteform

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String = "data source=localhost; user id=root; password=;database=cr_user"
        Dim con As New MySqlConnection(str)
        Dim com As String = "delete from cr_vehicle where vehicle_id = '" & TextBox1.Text & "' "
        con.Open()
        Dim cmd As New MySqlCommand(com, con)


        Dim x As String = cmd.ExecuteNonQuery
        If x >= 1 Then
            Timer1.Enabled = True
        End If
        con.Close()
    End Sub

    Private Sub deleteform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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