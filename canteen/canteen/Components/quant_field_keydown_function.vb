Imports canteen.Form1
Module quant_field_keydown_function

    Public Sub Quant_field_keydown_function(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then

            If String.IsNullOrWhiteSpace(Form1.Id_field.Text) Then


                If MessageBox.Show("Please Fill All Fields", "Error") Then

                    Form1.Id_field.Focus()

                End If


            Else
                Form1.add_btn.Focus()
                Form1.data_table.ClearSelection()

            End If

        Else

            Exit Sub

        End If

        e.SuppressKeyPress = True
    End Sub

End Module
