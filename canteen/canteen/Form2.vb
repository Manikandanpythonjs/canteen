

Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports canteen.pin_enter_function

Public Class pin_form
    Public con As SqlConnection = New SqlConnection("Data Source=103.207.1.93;Initial Catalog=canteen;Persist Security Info=True;User ID=mzcanteen;Password=Admin@123")

    Private Sub pin_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pin_field.Focus()

    End Sub

    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click

        If MessageBox.Show("Are You Sure You Want to Cancel", "Warning") Then


            Me.Close()
        Else


        End If

    End Sub


    Private Sub pin_field_KeyDown(sender As Object, e As KeyEventArgs) Handles pin_field.KeyDown

        If e.KeyCode = Keys.Enter Then

            ok_btn.PerformClick()


        Else

            Exit Sub

        End If

        e.SuppressKeyPress = True


    End Sub



    Private Sub ok_btn_Click(sender As Object, e As EventArgs) Handles ok_btn.Click

        pin_enter_function.ok_btn_Click(sender, e)



    End Sub
End Class