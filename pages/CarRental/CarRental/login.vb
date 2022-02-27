Imports MySql.Data.MySqlClient
Public Class login

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("User")
        ComboBox1.Items.Add("Admin")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem = "User" Then

            Try

                If TextBox1.Text = String.Empty Then
                    MsgBox("Please Input Username")

                ElseIf TextBox2.Text = String.Empty Then
                    MsgBox("Please enter your password")

                Else

                    Dim role As String = "user"
                    Dim str As String = "Data source=localhost;user id=root; password= ;database=cr_user;"
                    Dim con As New MySqlConnection(str)
                    Dim com As String = "select * from clients where username = '" & TextBox1.Text & "' and password = '" & TextBox2.Text & "' and role = '" & role & "'  "
                    Dim adpt As New MySqlDataAdapter(com, con)
                    Dim ds As New DataSet()

                    adpt.Fill(ds, "account")
                    Dim x As Integer = ds.Tables(0).Rows.Count
                    If x >= 1 Then

                        Dim id As Integer = ds.Tables(0).Rows(0).Item(0)
                        lblid.Text = id

                        MsgBox("Log In Successful")
                        clientsmain.Show()
                        Me.Hide()
                    Else
                        MsgBox("Incorrect Username & Password Combination!")

                    End If


                End If
                    Catch ex As Exception
                MsgBox("An error occurred")
            End Try



        ElseIf ComboBox1.SelectedItem = "Admin" Then

            Try

                If TextBox1.Text = String.Empty Then
                    MsgBox("Please Input Username")

                ElseIf TextBox2.Text = String.Empty Then
                    MsgBox("Please enter your password")

                Else

                    Dim role1 As String = "admin"
                    Dim str As String = "Data source=localhost;user id=root; password= ;database=cr_user;"
                    Dim con As New MySqlConnection(str)
                    Dim com As String = "select * from accounts where username = '" & TextBox1.Text & "' and password = '" & TextBox2.Text & "' and role = '" & role1 & "' "
                    Dim adpt As New MySqlDataAdapter(com, con)
                    Dim ds As New DataSet()

                    adpt.Fill(ds, "account")
                    Dim x As Integer = ds.Tables(0).Rows.Count
                    If x >= 1 Then


                        MsgBox("Log In Successful")
                        main.Show()
                        Me.Hide()
                    Else
                        MsgBox("Incorrect Username & Password Combination!")

                    End If
                End If
            Catch ex As Exception
                MsgBox("An error occurred")
            End Try

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        registernew.Show()
        Me.Hide()

    End Sub
End Class