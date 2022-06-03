
Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.DateTime
Imports canteen.shortcutkey
Imports canteen.order_validation_function
Imports canteen.bill_generate
Imports canteen.load_data
Imports canteen.formclosing
Imports canteen.add_order
Imports canteen.item_change
Imports canteen.transgrid
Imports canteen.id_field_validation
Imports canteen.delete_function
Imports canteen.update_function
Imports canteen.autocomplete_function
Imports canteen.datatablemouseclick
Imports canteen.quant_field_keydown_function


Public Class Form1
    Public con As SqlConnection = New SqlConnection("Data Source=103.207.1.93;Initial Catalog=canteen;Persist Security Info=True;User ID=mzcanteen;Password=Admin@123")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Bill_no()
        LoadDataInGrid()
        transdatagrid()

        autocomplete_function.Autocomplete(sender, e)


        Me.KeyPreview = True
    End Sub

    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click

        add_order.add_btn_Click(sender, e)

    End Sub

    Private Sub transdatagrid()
        transgrid.transdatagrid()
    End Sub
    Public Sub LoadDataInGrid()

        load_data.LoadDataInGrid()

    End Sub
    Private Sub print_btn_Click(sender As Object, e As EventArgs) Handles print_btn.Click, MyBase.DoubleClick

        order_validation_function.print_btn_Click(sender, e)

    End Sub

    Public Sub Bill_no()
        bill_generate.Bill_no()
    End Sub




    Private Sub item_field_TextChanged(sender As Object, e As EventArgs) Handles item_field.TextChanged

        item_change.item_field_TextChanged(sender, e)

    End Sub



    Private Sub item_field_KeyDown(sender As Object, e As KeyEventArgs) Handles item_field.KeyDown
        If e.KeyCode = Keys.Enter Then


            quant_field.Focus()


        Else

            Exit Sub

        End If

        e.SuppressKeyPress = True
    End Sub


    Private Sub quant_field_KeyDown(sender As Object, e As KeyEventArgs) Handles quant_field.KeyDown
        quant_field_keydown_function.Quant_field_keydown_function(sender, e)
    End Sub


    Private Sub Sales_page_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        shortcutkey.Shortcut(sender, e)

    End Sub


    Private Sub Id_field_KeyDown(sender As Object, e As KeyEventArgs) Handles Id_field.KeyDown




        id_field_validation.id_field_validation(sender, e)



    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        delete_function.delete_btn_Click(sender, e)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        FormClosingFunction(sender, e)

    End Sub




    Private Sub quant_field_TextChanged(sender As Object, e As EventArgs) Handles quant_field.TextChanged
        Dim quantity = quant_field.Text
        Dim price = price_field.Text
        Try
            Dim StringToInteger As Integer = Convert.ToInt32(price)
            Dim StringToInteger1 As Integer = Convert.ToInt32(quantity)

            Dim tot As String

            tot = StringToInteger * StringToInteger1

            total_field.Text = tot
            LoadDataInGrid()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click

        update_function.update_btn_Click(sender, e)

    End Sub
    Private Sub data_table_MouseClick(sender As Object, e As MouseEventArgs) Handles data_table.MouseClick

        datatablemouseclick.data_table_MouseClick(sender, e)

    End Sub


End Class

