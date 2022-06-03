Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports canteen.Form1
Module item_change
    Public Sub item_field_TextChanged(sender As Object, e As EventArgs)
        Dim con As SqlConnection = New SqlConnection("Data Source=103.207.1.93;Initial Catalog=canteen;Persist Security Info=True;User ID=mzcanteen;Password=Admin@123")

        con.Open()
        Dim cmd As SqlCommand = New SqlCommand("select product_name,price from items where product_id='" + Form1.item_field.Text + "'", con)
        Dim myreader As SqlDataReader
        myreader = cmd.ExecuteReader
        myreader.Read()


        Try
            Form1.pd_name.Text = myreader("product_name")

            Form1.price_field.Text = myreader("price")


        Catch ex As Exception



        End Try
        con.Close()
        con.Open()
        transdatagrid()
        con.Close()




    End Sub
End Module
