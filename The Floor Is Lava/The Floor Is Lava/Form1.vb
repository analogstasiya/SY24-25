Public Class Form1
    Sub calc()
        Dim floorcost As Integer
        Dim l As Integer
        l = lengthbox.Text
        Dim w As Integer
        w = widthbox.Text
        Integer.TryParse(lengthbox.Text, l)
        If fortyrb.Checked Then
            floorcost = 40
        ElseIf thirtyrb.Checked Then
            floorcost = 30
        ElseIf seventyrb.Checked Then
            floorcost = 70
        Else
            floorcost = 120
        End If
        areabox.Text = area(lengthbox.Text, widthbox.Text)
        costbox.Text = cost(floorcost, lengthbox.Text, widthbox.Text).ToString("C2")

    End Sub
    Function area(l As Integer, w As Integer) As Integer
        Return l * w
    End Function
    Function cost(floorcost As Integer, l As Integer, w As Integer) As Integer
        Return floorcost * (l * w)
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        areabox.Text = ""
        costbox.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        calc()
    End Sub
End Class
