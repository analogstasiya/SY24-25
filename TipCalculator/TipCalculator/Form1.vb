Public Class Form1
    Private Sub AmountTextbox_TextChanged(sender As Object, e As EventArgs) Handles AmountTextbox.TextChanged, tenrb.CheckedChanged, fifteenrb.CheckedChanged, twentyrb.CheckedChanged
        calc()
    End Sub
    Sub calc()
        Dim amt As Decimal
        Decimal.TryParse(AmountTextbox.Text, amt)
        Dim pct As Decimal
        If tenrb.Checked Then
            pct = 10
        ElseIf fifteenrb.Checked Then
            pct = 15
        Else
            pct = 20
        End If
        TipTextbox.Text = tip(amt, pct).ToString("C2")
        TotalTextbox.Text = total(amt, pct).ToString("C2")
    End Sub
    Function tip(amt As Decimal, pct As Decimal) As Decimal
        Return amt * pct / 100
    End Function
    Function total(amt As Decimal, pct As Decimal) As Decimal
        Return amt + (amt * pct / 100)
    End Function
End Class
