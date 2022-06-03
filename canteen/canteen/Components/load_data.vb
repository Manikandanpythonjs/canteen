Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports WinFormsApp2.Form1

Module load_data

    Public Sub LoadDataInGrid()
        Dim con As SqlConnection = New SqlConnection("Data Source=103.207.1.93;Initial Catalog=canteen;Persist Security Info=True;User ID=mzcanteen;Password=Admin@123")

        Dim command As New SqlCommand("select buyer_details.ref_no, items.product_id,items.Product_Name,Buyer_details.Quantity,items.Price,Buyer_Details.Total from Buyer_Details inner join items on items.Product_Id = Buyer_Details.Product_Id where Buyer_Details.bill_no='" + Form1.Billingno_field.Text + "'", con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        Form1.data_table.DataSource = dt
        Form1.data_table.ClearSelection()
    End Sub

End Module
