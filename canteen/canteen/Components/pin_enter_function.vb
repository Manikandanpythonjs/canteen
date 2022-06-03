
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports canteen.pin_form
Imports canteen.clear_fields

Module pin_enter_function

    Dim con As SqlConnection = New SqlConnection("Data Source=103.207.1.93;Initial Catalog=canteen;Persist Security Info=True;User ID=mzcanteen;Password=Admin@123")

    Public Sub ok_btn_Click(sender As Object, e As EventArgs)


        If String.IsNullOrWhiteSpace(pin_form.pin_field.Text) Then


            If MessageBox.Show("Please Fill All Fields", "Error") Then

                pin_form.pin_field.Focus()

            End If




        Else
            Dim pin As SqlCommand = New SqlCommand("select pin from buyer where spr_no='" + Form1.spr_field.Text + "'", con)
            con.Open()
            Dim myreader1 As SqlDataReader
            myreader1 = pin.ExecuteReader
            myreader1.Read()
            Dim a = myreader1("pin")


            con.Close()


            Dim bytes As Byte()
            Dim decrypted As String
            Try
                bytes = Convert.FromBase64String(a)
                decrypted = System.Text.ASCIIEncoding.ASCII.GetString(bytes)
            Catch fe As FormatException
                decrypted = ""
            End Try

            Dim result

            result = Form1.spr_field.Text + pin_form.pin_field.Text



            If (decrypted.Equals(result)) Then

                con.Open()
                Try
                    Dim StringToInteger As Integer = Convert.ToInt32(Form1.balance_field.Text)
                    Dim StringToInteger1 As Integer = Convert.ToInt32(Form1.grand_field.Text)
                    Dim tot As String

                    tot = StringToInteger - StringToInteger1
                    Dim status As String = "Ordered"
                    dtCustomers = ReadFromDatabase("update items set Quantity= items.quantity-Buyer_Details.quantity from items inner join Buyer_Details on items.Product_id=Buyer_Details.Product_Id where bill_no='" + Form1.Billingno_field.Text + "'")
                    dtCustomers = ReadFromDatabase("update buyer set balance=" + tot.ToString + "where Spr_no=" + Form1.spr_field.Text + "")
                    dtCustomers = ReadFromDatabase("update buyer_details set status = '" + status + "' where bill_no='" + Form1.Billingno_field.Text + "'")


                Catch ex As Exception

                End Try






                Form1.Bill_no()
                Form1.LoadDataInGrid()
                con.Close()
                MessageBox.Show(Form1.name_field.Text + " Your Order Successfull", "Info")

                Form1.transaction.DataSource = vbNull
                clear_fields.clear_all_ordered_Click()
                pin_form.pin_field.Clear()
                Form1.Id_field.Focus()
                pin_form.Dispose()


            Else

                If MessageBox.Show("INVALID PIN", "ERROR") Then
                    pin_form.pin_field.Clear()
                    pin_form.Dispose()
                    pin_form.ShowDialog()



                End If

















            End If
        End If

    End Sub

End Module
