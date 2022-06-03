Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.Data

Module readerconnection
    Public sqlconnect As String = "Data Source=103.207.1.93;Initial Catalog=canteen;Persist Security Info=True;User ID=mzcanteen;Password=Admin@123"

    Public Function getNenaRecords(ByVal myStatus As String, ByVal reead As String, ByVal field As String) As SqlDataReader

        Using conn As New SqlClient.SqlConnection(sqlconnect)

            conn.Open()

            Dim Myreader As SqlDataReader

            Dim cmd As SqlCommand = New SqlCommand(myStatus, conn)
            Myreader = cmd.ExecuteReader
            Myreader.Read()




            Dim result As String



            result = Myreader.GetValue(reead)

            field = result

            conn.Close()
            conn.Dispose()






        End Using


    End Function




End Module
