Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports WinFormsApp2.Form1


Module autocomplete_function

    Public Sub Autocomplete(sender As Object, e As EventArgs)
        Bill_no()
        LoadDataInGrid()
        transdatagrid()
        Dim con As SqlConnection = New SqlConnection("Data Source=103.207.1.93;Initial Catalog=canteen;Persist Security Info=True;User ID=mzcanteen;Password=Admin@123")
        Dim command As New SqlCommand("select product_id from items", con)
        Dim da As New SqlDataAdapter(command)
        Dim dt As New DataSet

        da.Fill(dt)

        Dim column1 As New AutoCompleteStringCollection

        For i As Integer = 0 To dt.Tables(0).Rows.Count - 1

            column1.Add(dt.Tables(0).Rows(i)("product_id").ToString())

        Next
        Form1.item_field.Multiline = False

        Form1.item_field.AutoCompleteSource = AutoCompleteSource.CustomSource
        Form1.item_field.AutoCompleteCustomSource = column1
        Form1.item_field.AutoCompleteMode = AutoCompleteMode.Suggest





    End Sub
End Module
