Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Public Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim dealer As Decimal
        If ListBox1.Text = "1%" Then
            dealer = 0.01
        ElseIf ListBox1.Text = "2%" Then
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
        If ListBox3.Text = "1" Then
            term = 12
        ElseIf ListBox3.Text = "2" Then
            term = 24
        ElseIf ListBox3.Text = "3" Then
            term = 36
        Else
            term = 48
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        ' Initialize or calculate the rebate value here
        Dim rebate As Integer = 0
        TextBox4.Text = rebate.ToString()
    End Sub

    Public Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Initialize or calculate the price value here
        Dim price As Integer = 0
        TextBox1.Text = price.ToString()
    End Sub

    Function Financialpmt(dealer As Decimal, term As Integer, price As Integer) As Decimal
        ' Implement the actual calculation here
        Return price * dealer / term
    End Function

    Function Financialpmt(bank As Decimal, term As Integer, price As Integer, rebate As Integer) As Decimal
        ' Implement the actual calculation here
        Return (price * bank / term) - rebate
    End Function

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dealer As Decimal = Convert.ToDecimal(ListBox1.Text.TrimEnd("%"c)) / 100
        Dim bank As Decimal = Convert.ToDecimal(ListBox2.Text.TrimEnd("%"c)) / 100
        Dim term As Integer = Convert.ToInt32(ListBox3.Text)
        Dim rebate As Integer = Convert.ToInt32(TextBox4.Text)
        Dim price As Integer = Convert.ToInt32(TextBox1.Text)

        TextBox2.Text = Financialpmt(dealer, term, price).ToString()
        TextBox3.Text = Financialpmt(bank, term, price, rebate).ToString()
    End Sub

    Public Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class

