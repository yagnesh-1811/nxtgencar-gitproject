Imports System.IO
Public Class backupform

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = " "

        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
        Else
            TextBox1.Text = ""

        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = " "

        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            TextBox2.Text = FolderBrowserDialog1.SelectedPath
        Else
            TextBox2.Text = ""

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim location As String
        Dim locationsave As String

        location = TextBox1.Text
        locationsave = TextBox2.Text

        My.Computer.FileSystem.CopyDirectory(location, locationsave, True)
        Label3.Text = "Completed:" & locationsave
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        main.Show()
        Me.Close()

    End Sub

    Private Sub backupform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class