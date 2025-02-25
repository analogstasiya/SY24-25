Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Public Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim dealer As Decimal
        If ListBox1.Text = "1%" Then
            dealer = 0.01
        ElseIf ListBox2.Text = "2%" Then
            dealer = 0.02
        Else
            dealer = 0.03
        End If
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        Dim bank As Decimal
        If ListBox2.Text = "6%" Then
            bank = 0.06
        ElseIf ListBox2.Text = "7%" Then
            bank = 0.07
        Else
            bank = 0.08
        End If
    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged
        Dim term As Integer
        If ListBox3.Text = 1 Then
            term = 12
        ElseIf ListBox3.Text = 2 Then
            term = 24
        ElseIf ListBox3.Text = 3 Then
            term = 36
        Else
            term = 48
        End If
    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Dim rebate As Integer
        TextBox4.Text = rebate
    End Sub

    Public Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim price As Integer
        TextBox1.Text = price
    End Sub
    Function Financialpmt(term As Integer, bank As Decimal, dealer As Decimal) As Decimal
        TextBox2.Text = Financialpmt(dealer, term, price)
        TextBox3.Text = Financialpmt(bank, term, price) - rebate
    End Function

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Financialpmt(ListBox1.Text, ListBox2.Text, ListBox3.Text, TextBox4.Text, TextBox1.Text)
    End Sub

    Public Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
