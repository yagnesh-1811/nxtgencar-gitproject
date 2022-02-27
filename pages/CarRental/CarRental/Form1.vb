Public Class Form1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ProgressBar1.Increment(+1)
        If ProgressBar1.Value = 5 Then
            Label2.Text = "."

        End If
        If ProgressBar1.Value = 10 Then
            Label2.Text = "."
            Label3.Text = "."
        End If
        If ProgressBar1.Value = 20 Then
            Label2.Text = "."
            Label3.Text = "."
            Label4.Text = "."
        End If
        If ProgressBar1.Value = 40 Then
            Label2.Text = " "
            Label3.Text = " "
            Label4.Text = " "
        End If
        If ProgressBar1.Value = 45 Then
            Label2.Text = "."

        End If
        If ProgressBar1.Value = 50 Then
            Label2.Text = "."
            Label3.Text = "."
        End If
        If ProgressBar1.Value = 60 Then
            Label2.Text = "."
            Label3.Text = "."
            Label4.Text = "."
        End If
        If ProgressBar1.Value = 65 Then
            Label2.Text = " "
            Label3.Text = " "
            Label4.Text = " "
        End If
        If ProgressBar1.Value = 70 Then
            Label2.Text = "."

        End If
        If ProgressBar1.Value = 80 Then
            Label2.Text = "."
            Label3.Text = "."
        End If
        If ProgressBar1.Value = 90 Then
            Label2.Text = "."
            Label3.Text = "."
            Label4.Text = "."

        End If

        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            Timer1.Enabled = False
            login.Show()
            Me.Close()




        End If
    End Sub

    Private Sub frm_loading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        ProgressBar1.Value = 0
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class
