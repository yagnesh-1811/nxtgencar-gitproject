Imports MySql.Data.MySqlClient
Public Class myaccount

    Private Sub myaccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = "Data source = localhost; user id= root;password=;database= cr_user;"
        Dim con As New MySqlConnection(str)
        Dim com As String = "select * from clients where client_id = '" & login.lblid.Text & "' "
        Dim adpt As New MySqlDataAdapter(com, con)
        Dim ds As New DataSet()

        adpt.Fill(ds, "vehicles")
        lblclientid.Text = ds.Tables(0).Rows(0).Item(0)
        lbllname.Text = ds.Tables(0).Rows(0).Item(1)
        lblfname.Text = ds.Tables(0).Rows(0).Item(2)
        lblcompany.Text = ds.Tables(0).Rows(0).Item(3)
        lblpob.Text = ds.Tables(0).Rows(0).Item(4)
        lbllocaladd.Text = ds.Tables(0).Rows(0).Item(5)
        lblhomeadd.Text = ds.Tables(0).Rows(0).Item(6)
        lbllocalphone.Text = ds.Tables(0).Rows(0).Item(7)
        lblhomephone.Text = ds.Tables(0).Rows(0).Item(8)
        lblemail.Text = ds.Tables(0).Rows(0).Item(9)
        lblpassport.Text = ds.Tables(0).Rows(0).Item(10)
        lbllicense.Text = ds.Tables(0).Rows(0).Item(11)
        lbldob.Text = ds.Tables(0).Rows(0).Item(12)
        lblusername.Text = ds.Tables(0).Rows(0).Item(13)


    End Sub
End Class