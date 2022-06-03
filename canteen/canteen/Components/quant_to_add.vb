
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports canteen.Form1
Module quant_field_textxhange

    Public Sub quant_field_textxhange(sender As Object, e As EventArgs)
        Dim quantity = Form1.quant_field.Text
        Dim price = Form1.price_field.Text
        Try
            Dim StringToInteger As Integer = Convert.ToInt32(price)
            Dim StringToInteger1 As Integer = Convert.ToInt32(quantity)

            Dim tot As String

            tot = StringToInteger * StringToInteger1

            Form1.total_field.Text = tot
            LoadDataInGrid()
        Catch ex As Exception
        End Try
    End Sub

End Module
