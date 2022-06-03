Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports canteen.Form1
Imports canteen.pin_form




Module order_validation_function


    Public Sub print_btn_Click(sender As Object, e As EventArgs)

        If String.IsNullOrWhiteSpace(Form1.Id_field.Text) Then

            MessageBox.Show("Please Fill the All Fields", "ERROR")

        Else

            If (Form1.balance_field.Text < Form1.grand_field.Text) Then
                MsgBox("Insufficient Balance")
            Else

                pin_form.ShowDialog()
                Form1.Id_field.Focus()
            End If

        End If

    End Sub


End Module
