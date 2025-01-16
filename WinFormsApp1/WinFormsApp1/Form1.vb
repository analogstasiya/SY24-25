Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged
        If TextBox1.Text Like TextBox2.Text Then
            Me.BackColor = Color.Green
        Else
            Me.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sp As Integer
        sp = TextBox1.Text.IndexOf(" ")
        TextBox2.Text = TextBox1.Text.Substring(0, sp)
    End Sub
End Class

