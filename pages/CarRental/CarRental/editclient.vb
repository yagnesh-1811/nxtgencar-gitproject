Imports MySql.Data.MySqlClient
Public Class editclient

    Private Sub editclient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim str As String = "Data source = localhost; user id= root;password=;database= cr_user;"
        Dim con As New MySqlConnection(str)
        Dim com As String = "select * from clients  where client_id = '" & TextBox1.Text & "' "
        Dim adpt As New MySqlDataAdapter(com, con)
        Dim ds As New DataSet()

        adpt.Fill(ds, "vehicles")
        clientslist.DataGridView1.DataSource = ds.Tables(0)
        txtname.Text = ds.Tables(0).Rows(0).Item(2)
        txtlname.Text = ds.Tables(0).Rows(0).Item(2)
        txtcompany.Text = ds.Tables(0).Rows(0).Item(3)
        ComboBox2.SelectedItem = ds.Tables(0).Rows(0).Item(3)
        ComboBox1.SelectedItem = ds.Tables(0).Rows(0).Item(3)
        TextBox1.Text = ds.Tables(0).Rows(0).Item(3)
        txtpob.Text = ds.Tables(0).Rows(0).Item(4)
        txtlocaladd.Text = ds.Tables(0).Rows(0).Item(5)
        txthomeadd.Text = ds.Tables(0).Rows(0).Item(6)
        txtlocalphone.Text = ds.Tables(0).Rows(0).Item(7)
        txthomephone.Text = ds.Tables(0).Rows(0).Item(8)

        txtemail.Text = ds.Tables(0).Rows(0).Item(9)
        txtpassport.Text = ds.Tables(0).Rows(0).Item(10)
        txtlicense.Text = ds.Tables(0).Rows(0).Item(11)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class