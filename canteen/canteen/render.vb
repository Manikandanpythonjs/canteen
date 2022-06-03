Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports canteen.Form1
Module render
    Public Function renderFunction()
        Dim con As SqlConnection = New SqlConnection("Data Source=103.207.1.93;Initial Catalog=canteen;Persist Security Info=True;User ID=mzcanteen;Password=Admin@123")
        con.Open()
        Dim cmd1 As New SqlCommand("select sum(total) From buyer_details where bill_no='" + Form1.Billingno_field.Text + "'", con)
        Dim myreader As SqlDataReader
        myreader = cmd1.ExecuteReader()
        myreader.Read()
        Try
            Form1.grand_field.Text = myreader("")

        Catch ex As Exception

        End Try
        con.Close()
    End Function

End Module
