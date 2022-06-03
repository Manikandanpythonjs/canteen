Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports canteen.Form1
Imports canteen.Connection
Imports canteen.render

Module delete_function

    Public Sub delete_btn_Click(sender As Object, e As EventArgs)
        Dim con As SqlConnection = New SqlConnection("Data Source=103.207.1.93;Initial Catalog=canteen;Persist Security Info=True;User ID=mzcanteen;Password=Admin@123")

        For i As Integer = 0 To Form1.data_table.SelectedRows.Count - 1
            dtCustomers = ReadFromDatabase("delete from buyer_details where Ref_No='" + Form1.ref_field.Text + "'")

        Next
        LoadDataInGrid()
        render.renderFunction()
        MessageBox.Show("Data deleted Successfully")
    End Sub

End Module
