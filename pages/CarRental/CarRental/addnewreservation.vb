Imports Mysql.data.mysqlclient

Public Class addnewreservation




    Private Sub ClientsBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub addnewreservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = "Data source = localhost; user id= root;password=;database= cr_user;"
        Dim con As New MySqlConnection(str)
        Dim com As String = "select vehicle_id as 'ID', model as 'Model', license_num as 'License No.', color as 'Color',class_id as 'Class ID', engine_name as 'Engine', daily_rate as 'Daily Rate', weekly_rate as 'Weekly Rate',quantity as 'Quantity',image as 'Photo'  from cr_vehicle"
        Dim adpt As New MySqlDataAdapter(com, con)
        Dim ds As New DataSet()

        adpt.Fill(ds, "vehicles")
        DataGridView1.DataSource = ds.Tables(0)

        Timer1.Enabled = False
        ProgressBar1.Value = 0
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim str As String = "Data source = localhost; user id= root;password=;database= cr_user;"
            Dim con As New MySqlConnection(str)
            Dim com As String = "select * from cr_vehicle where vehicle_id = '" & TextBox1.Text & "' "
            Dim adpt As New MySqlDataAdapter(com, con)
            Dim ds As New DataSet()

            adpt.Fill(ds, "vehicles")
            vehicle.DataGridView1.DataSource = ds.Tables(0)
            TextBox3.Text = ds.Tables(0).Rows(0).Item(1)
            TextBox2.Text = ds.Tables(0).Rows(0).Item(2)
            ComboBox1.Text = ds.Tables(0).Rows(0).Item(3)
            TextBox5.Text = ds.Tables(0).Rows(0).Item(5)
            TextBox8.Text = ds.Tables(0).Rows(0).Item(0)
            Dim x As Integer
            x = Val(TextBox4.Text)
            Dim y As String = ds.Tables(0).Rows(0).Item(6)
            TextBox7.Text = x * y
            lblquantity.Text = ds.Tables(0).Rows(0).Item(9)

            If Val(lblquantity.Text) <= 0 Then
                MsgBox("The car you selected is not available")
                TextBox1.Text = " "
                TextBox2.Text = " "
                TextBox3.Text = " "
                TextBox4.Text = " "
                TextBox5.Text = " "
                TextBox6.Text = " "
                TextBox7.Text = " "
                TextBox8.Text = " "
                ComboBox1.Text = " "
            End If

        Catch ex As Exception
            MsgBox("No Record Found!")
            TextBox1.Text = " "
            TextBox2.Text = " "
            ComboBox1.Text = " "
            TextBox4.Text = " "
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        





        If TextBox6.Text = String.Empty Then
            MsgBox("Please input Your ID")
        Else
            Dim str As String = "data source=localhost; user id=root; password=;database=cr_user"
            Dim con As New MySqlConnection(str)
            Dim com As String = "insert into rentlist(client_id,model,color,license_no,engine,day,amount,vehicle_id)values ('" & TextBox6.Text & "', '" & TextBox2.Text & "', '" & ComboBox1.Text & "','" & TextBox3.Text & "','" & TextBox5.Text & "','" & TextBox4.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "') "
           

           

            If Val(TextBox6.Text) = Val(login.lblid.Text) Then



                con.Open()
               
                





                    Dim ds As New DataSet
                    Dim com2 As String = "select * from rentlist where client_id = '" & TextBox6.Text & "' "
                    Dim adpt As New MySqlDataAdapter(com2, con)
                    If adpt.Fill(ds, "ha") = False Then
                        Dim cmd As New MySqlCommand(com, con)
                    Dim com1 As String = "update cr_vehicle set quantity = quantity - 1 where vehicle_id = '" & TextBox1.Text & "' "
                    Dim cmd1 As New MySqlCommand(com1, con)
                        Dim x As String = cmd.ExecuteNonQuery
                        If x >= 1 Then
                            Timer1.Enabled = True
                        Else
                            MsgBox("Renting Failed!")
                        End If
                    Else
                        MsgBox("You have already rent a car. Please make sure you have returned it first!")
                        TextBox1.Text = " "
                        TextBox2.Text = " "
                        TextBox3.Text = " "
                        TextBox4.Text = " "
                        TextBox5.Text = " "
                        TextBox6.Text = " "
                        TextBox7.Text = " "
                        TextBox8.Text = " "
                        ComboBox1.Text = " "

                    End If


                    con.Close()





                Else
                    MsgBox("You have entered an Incorret Client ID!")
                End If

            End If



    End Sub

   

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(+5)
        If ProgressBar1.Value = 10 Then
            Label11.Text = " Please Wait..."
        End If

        If ProgressBar1.Value = 50 Then
            Label11.Text = "Almost Done..."
        End If




        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Label11.Text = "Success!"

            Timer1.Stop()
            Timer1.Enabled = False
            MsgBox("Success!")
            Me.Close()

        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub lblquantity_Click(sender As Object, e As EventArgs) Handles lblquantity.Click

    End Sub

    Private Sub lvlid_Click(sender As Object, e As EventArgs) Handles lvlid.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        searchreservation.Show()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

   
End Class