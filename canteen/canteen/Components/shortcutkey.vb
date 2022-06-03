Imports WinFormsApp2.Form1
Module shortcutkey

    Public Sub Shortcut(sender As Object, e As KeyEventArgs)

        Select Case e.KeyCode
            Case Keys.F3
                Form1.print_btn.PerformClick()
        End Select

        Select Case e.KeyCode
            Case Keys.F2
                Form1.item_field.Focus()
        End Select

        Select Case e.KeyCode
            Case Keys.F1
                Form1.Id_field.Focus()
        End Select

        Select Case e.Alt And e.KeyCode

            Case Keys.F4

                Form1.Close()

        End Select

        Select Case e.Alt And e.KeyCode

            Case Keys.F5


                Form1.item_field.Clear()
                Form1.price_field.Clear()
                Form1.total_field.Clear()
                Form1.quant_field.Clear()
                Form1.pd_name.Clear()

        End Select
        Select Case e.Alt And e.KeyCode

            Case Keys.F7

                Form1.quant_field.Focus()

        End Select
        Select Case e.Alt And e.KeyCode

            Case Keys.F6

                Form1.update_btn.PerformClick()

        End Select

    End Sub


End Module
