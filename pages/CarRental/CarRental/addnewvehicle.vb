Imports MySql.Data.MySqlClient
Imports System.IO


Public Class addnewvehicle

    Private Sub addnewvehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim mstream As New System.IO.MemoryStream()
        PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = mstream.GetBuffer()
        mstream.Close()


        Dim str As String = "data source=localhost; user id=root; password=;database=cr_user"
        Dim con As New MySqlConnection(str)
        Dim com As String = "insert into cr_vehicle(license_num,model,color,class_id,engine_name,daily_rate,weekly_rate,quantity,image) values('" & btnlicense.Text & "','" & txtmodel.Text & "','" & ComboBox1.SelectedItem & "','" & txtclassid.Text & "','" & txtengine.Text & "','" & txtdaily.Text & "','" & txtweekly.Text & "','" & TextBox1.Text & "',@image)"
        con.Open()
        Dim cmd As New MySqlCommand(com, con)
        cmd.Parameters.AddWithValue("@image", arrImage)

        Dim x As String = cmd.ExecuteNonQuery
        If x >= 1 Then
            Timer1.Enabled = True
        End If
        con.Close()

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(+5)
        If ProgressBar1.Value = 10 Then
            Label11.Text = "Saving ... Please Wait"
        End If

        If ProgressBar1.Value = 50 Then
            Label11.Text = "Almost Done..."
        End If




        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Label11.Text = "Succefully Saved!"

            Timer1.Stop()
            Timer1.Enabled = False
            MsgBox("Success!")
            vehicle.Show()
            vehicle.DataGridView1.Refresh()
            Me.Close()



        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName > " " Then
            PictureBox1.ImageLocation = OpenFileDialog1.FileName
        End If


    End Sub
End Class