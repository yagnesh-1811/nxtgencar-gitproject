Public Class clientreservation

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        clientsmain.Show()
        Me.Close()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        endreservation.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        addnewreservation.Show()

    End Sub
End Class