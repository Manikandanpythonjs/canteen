Imports System.Data.SqlClient

Module Connection


    Public dtCustomers As New DataTable
    Public DBConnectionString As String = "Data Source=103.207.1.93;Initial Catalog=canteen;Persist Security Info=True;User ID=mzcanteen;Password=Admin@123"
    Public Reader As New SqlDataAdapter
    Public Function ReadFromDatabase(ByVal SQL As String) As DataTable
        Dim dtReturn As New DataTable
        Try
            'Open the connection using the connection string
            Using conn As New SqlClient.SqlConnection(DBConnectionString)
                conn.Open()

                Using cmd As New SqlClient.SqlCommand()
                    cmd.Connection = conn
                    cmd.CommandText = SQL
                    Dim da As New SqlClient.SqlDataAdapter(cmd)
                    da.Fill(dtReturn)
                End Using


            End Using
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try


        'Return the result data set
        Return dtReturn
    End Function


    Public name_up As String
    Public password_up As String
    Public year_up As String
    Public dept_up As String
    Public gender_up As String
    Public spr_up As String



End Module
