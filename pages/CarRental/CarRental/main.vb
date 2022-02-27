


Public Class main

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        vehicle.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        clientslist.Show()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        backupform.Show()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        about.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        reservation.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        invoiceform.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        rentlist.Show()

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        login.Show()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        about.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub

    Private Sub BackUpManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackUpManagerToolStripMenuItem.Click
        backupform.Show()

    End Sub

    Private Sub UsersPrivilegesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersPrivilegesToolStripMenuItem.Click

    End Sub

    Private Sub GeneralSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneralSettingsToolStripMenuItem.Click

    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click

    End Sub

    Private Sub InvoiceListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoiceListToolStripMenuItem.Click
        invoiceform.Show()

    End Sub

    Private Sub InvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoiceToolStripMenuItem.Click

    End Sub

    Private Sub StartEndReservationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartEndReservationToolStripMenuItem.Click
        reservation.Show()
    End Sub

    Private Sub ReservationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservationToolStripMenuItem.Click

    End Sub

    Private Sub ClientListsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientListsToolStripMenuItem.Click
        clientslist.Show()

    End Sub

    Private Sub VehicleListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VehicleListToolStripMenuItem.Click
        vehicle.Show()

    End Sub

    Private Sub VehiclesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VehiclesToolStripMenuItem.Click

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        login.Show()
        Me.Close()

    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub
End Class