Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports WinFormsApp2.Form1
Module id_field_validation

    Public Sub id_field_validation(sender As Object, e As KeyEventArgs)
        Dim con As SqlConnection = New SqlConnection("Data Source=103.207.1.93;Initial Catalog=canteen;Persist Security Info=True;User ID=mzcanteen;Password=Admin@123")


        If e.KeyCode = Keys.Enter Then


            If Form1.Id_field.Text = "" Then

                MessageBox.Show("Please Fill The  ID Field", "Empty")

                Form1.Id_field.Focus()
                Form1.Id_field.Clear()

            Else
                If Form1.Id_field.Text.Length >= 9 Then

                    Try
                        con.Open()
                        Dim cmd As SqlCommand = New SqlCommand("select spr_no,name,department,year,type,balance from buyer where id='" + Form1.Id_field.Text + "'", con)
                        Dim myreader As SqlDataReader
                        myreader = cmd.ExecuteReader
                        myreader.Read()
                        Form1.spr_field.Text = myreader("spr_no")
                        Form1.name_field.Text = myreader("name")
                        Form1.type_field.Text = myreader("type")
                        Form1.dp_field.Text = myreader("department")
                        Form1.year_field.Text = myreader("year")
                        Form1.type_field.Text = myreader("type")
                        Form1.balance_field.Text = myreader("balance")
                        con.Close()
                        Form1.item_field.Focus()
                    Catch ex As Exception

                    End Try
                Else

                    MessageBox.Show("Invalid ID", "Error")
                    Form1.Id_field.Clear()
                    Form1.Id_field.Focus()


                End If



            End If


        Else

            Exit Sub

        End If

        e.SuppressKeyPress = True


    End Sub

End Module
