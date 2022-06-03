Imports WinFormsApp2.Form1
Module datatablemouseclick

    Public Sub data_table_MouseClick(sender As Object, e As MouseEventArgs)
        Dim i As Integer

        i = Form1.data_table.CurrentRow.Index
        Form1.ref_field.Text = Form1.data_table.Item(0, i).Value
        Form1.item_field.Text = Form1.data_table.Item(1, i).Value
        Form1.pd_name.Text = Form1.data_table.Item(2, i).Value
        Form1.quant_field.Text = Form1.data_table.Item(3, i).Value
        Form1.price_field.Text = Form1.data_table.Item(4, i).Value
        Form1.total_field.Text = Form1.data_table.Item(5, i).Value

    End Sub

End Module
