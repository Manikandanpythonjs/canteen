Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports canteen.Form1
Module formclosing

    Public Sub FormClosingFunction(sender As Object, e As FormClosingEventArgs)
        Dim status As String = "unordered"
        dtCustomers = ReadFromDatabase("delete from buyer_details where status='" + status + "'")


    End Sub

End Module
