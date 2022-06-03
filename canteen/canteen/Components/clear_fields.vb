Imports WinFormsApp3.Form1
Module clear_fields

    Public Function clear_all_ordered_Click()
        Form1.spr_field.Clear()
        Form1.name_field.Clear()
        Form1.dp_field.Clear()
        Form1.year_field.Clear()
        Form1.item_field.Clear()
        Form1.pd_name.Clear()
        Form1.price_field.Clear()
        Form1.quant_field.Clear()
        Form1.total_field.Clear()
        Form1.type_field.Clear()
        Form1.grand_field.Clear()
        Form1.spr_field.Focus()
        Form1.spr_field.Clear()
        Form1.name_field.Clear()
        Form1.dp_field.Clear()
        Form1.year_field.Clear()
        Form1.item_field.Clear()
        Form1.pd_name.Clear()
        Form1.price_field.Clear()
        Form1.quant_field.Text = 1
        Form1.total_field.Clear()
        Form1.type_field.Clear()
        Form1.grand_field.Clear()
        Form1.Id_field.Clear()
        Form1.balance_field.Clear()
    End Function


End Module
