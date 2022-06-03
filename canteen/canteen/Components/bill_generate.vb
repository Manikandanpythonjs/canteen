Imports WinFormsApp2.Form1
Module bill_generate


    Public Sub Bill_no()
        Dim numbers As String = "1234567890"

        Dim characters As String = numbers
        Dim length As Integer = 10
        Dim id As String = String.Empty
        For i As Integer = 0 To length - 1
            Dim character As String = String.Empty
            Do
                Dim index As Integer = New Random().Next(0, characters.Length)
                character = characters.ToCharArray()(index).ToString()
            Loop While id.IndexOf(character) <> -1
            id += character
        Next
        Form1.Billingno_field.Text = +id
    End Sub

End Module
