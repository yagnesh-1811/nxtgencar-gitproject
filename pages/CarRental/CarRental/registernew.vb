Imports MySql.Data.MySqlClient
Public Class registernew

    Private Sub registernew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("1")
        ComboBox1.Items.Add("2")
        ComboBox1.Items.Add("3")
        ComboBox1.Items.Add("4")
        ComboBox1.Items.Add("5")
        ComboBox1.Items.Add("6")
        ComboBox1.Items.Add("7")
        ComboBox1.Items.Add("8")
        ComboBox1.Items.Add("9")
        ComboBox1.Items.Add("10")
        ComboBox1.Items.Add("11")
        ComboBox1.Items.Add("12")
        ComboBox1.Items.Add("13")
        ComboBox1.Items.Add("14")
        ComboBox1.Items.Add("15")
        ComboBox1.Items.Add("16")
        ComboBox1.Items.Add("17")
        ComboBox1.Items.Add("18")
        ComboBox1.Items.Add("19")
        ComboBox1.Items.Add("20")
        ComboBox1.Items.Add("21")
        ComboBox1.Items.Add("22")
        ComboBox1.Items.Add("23")
        ComboBox1.Items.Add("24")
        ComboBox1.Items.Add("25")
        ComboBox1.Items.Add("26")
        ComboBox1.Items.Add("27")
        ComboBox1.Items.Add("28")
        ComboBox1.Items.Add("29")
        ComboBox1.Items.Add("30")
        ComboBox1.Items.Add("31")

        ComboBox2.Items.Add("January")
        ComboBox2.Items.Add("Feburary")
        ComboBox2.Items.Add("March")
        ComboBox2.Items.Add("April")
        ComboBox2.Items.Add("May")
        ComboBox2.Items.Add("June")
        ComboBox2.Items.Add("July")
        ComboBox2.Items.Add("August")
        ComboBox2.Items.Add("September")
        ComboBox2.Items.Add("October")
        ComboBox2.Items.Add("November")
        ComboBox2.Items.Add("December")

        Timer1.Enabled = False
        ProgressBar1.Value = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim role As String = "user"
        Dim str As String = "data source=localhost; user id=root; password=;database=cr_user"
        Dim con As New MySqlConnection(str)
        Dim com As String = "insert into clients(client_id,lname,fname,company_name,dob,pob,local_address,home_address,local_phone,home_phone,email,passport_id,license_id,username,password,role) values ('" & txtid.Text & "','" & txtlname.Text & "', '" & txtname.Text & "','" & txtcompany.Text & "','" & ComboBox2.SelectedItem & "  " & ComboBox1.SelectedItem & "  " & TextBox1.Text & "','" & txtpob.Text & "','" & txtlocaladd.Text & "','" & txthomeadd.Text & "', '" & txtlocalphone.Text & "', '" & txthomephone.Text & "','" & txtemail.Text & "','" & txtpassport.Text & "', '" & txtlicense.Text & "','" & txtusername.Text & "','" & txtpassword.Text & "','" & role & "') "
        con.Open()
        Dim cmd As New MySqlCommand(com, con)


        Dim x As String = cmd.ExecuteNonQuery
        If x >= 1 Then
            Timer1.Enabled = True
            ProgressBar1.Enabled = True

        End If
        con.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(+5)
        If ProgressBar1.Value = 10 Then
            lbl.Text = "Saving ... Please Wait"
        End If

        If ProgressBar1.Value = 50 Then
            lbl.Text = "Almost Done..."
        End If




        If ProgressBar1.Value = ProgressBar1.Maximum Then
            lbl.Text = "Succefully Saved!"

            Timer1.Stop()
            Timer1.Enabled = False
            MsgBox("Success!")
            login.Show()
            clientslist.DataGridView1.Refresh()
            Me.Close()



        End If
    End Sub
End Class