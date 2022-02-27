Imports MySql.Data.MySqlClient

Public Class addvehiclecreditcard

    Private Sub addvehiclecreditcard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String = "data source=localhost; user id=root; password=;database=cr_user"
        Dim con As New MySqlConnection(str)
        Dim com As String = "insert into vehicle_creditcard (vehicle_id,bank_name,card_type,validfrom,validto,customer_name,customer_num) values ('" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "', #" + Format(DateTimePicker1.Value, "MM/dd/yyyy") + "#, #" + Format(DateTimePicker2.Value, "MM/dd/yyyy") + "#, '" & TextBox5.Text & "','" & TextBox6.Text & "')"
        con.Open()
        Dim cmd As New MySqlCommand(com, con)
        cmd.Parameters.AddWithValue("validtocorrector", Format(DateTimePicker2.Value, "dd/MM/yyyy"))
        cmd.Parameters.AddWithValue("validfromcorrector", Format(DateTimePicker1.Value, "dd/MM/yyyy"))


        Dim x As String = cmd.ExecuteNonQuery
        If x > 0 Then

            MsgBox(" records have inserted successfully")
            Me.Close()


        Else
            MsgBox("Failed to insert")
        End If



        con.Close()
    End Sub
End Class