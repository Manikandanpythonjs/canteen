Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports WinFormsApp2.Form1



Module transgrid

    Public Sub transdatagrid()
        Dim con As SqlConnection = New SqlConnection("Data Source=103.207.1.93;Initial Catalog=canteen;Persist Security Info=True;User ID=mzcanteen;Password=Admin@123")

        Dim command1 As New SqlCommand("select TOP 5 * From Buyer_Details where Spr_No='" + Form1.spr_field.Text + "' And Status='ordered' ", con)
        Dim sda1 As New SqlDataAdapter(command1)
        Dim dt1 As New DataTable
        sda1.Fill(dt1)
        Form1.transaction.DataSource = dt1
    End Sub

End Module
