Imports MySql.Data.MySqlClient
Public Class register

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String = "data source=localhost;user id= root;password=;database= cr_user;"

        Dim con As New MySqlConnection(str)
        Dim com As String = "insert into accounts(username,password) values('" & TextBox1.Text & "','" & TextBox2.Text & "')"
        con.Open()
        Dim cmd As New MySqlCommand(com, con)
        Dim x As String = cmd.ExecuteNonQuery()
        If x >= 1 Then
            MsgBox("Registration Successful!")
            login.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        login.Show()
        Me.Hide()

    End Sub

    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class