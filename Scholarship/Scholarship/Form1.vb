Imports System.Diagnostics.Eventing.Reader

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim score As Double
        Dim service As Double
        Double.TryParse(community.Text, service)
        Double.TryParse(gpa.Text, score)

        If score >= 3.5 And score <= 4.0 And service >= 50 And CheckBox1.Checked Then
            TextBox2.Text = "Elgible for scholarship!"
            PictureBox1.Visible = False
        ElseIf score >= 2.0 And score <= 3.4 And service >= 30 Then
            TextBox2.Text = "Elgible for partial scholarship!"
            PictureBox1.Visible = False
        Else
            TextBox2.Text = "Not elgible for scholarship! Sorry!"
            PictureBox1.Visible = True
        End If
    End Sub
End Class
