Public Class Form1
    Private Sub one_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button6.Click, Button5.Click, Button4.Click, Button7.Click, Button8.Click, Button9.Click, Button0.Click, ButtonDecimal.Click
        Display.Text = Display.Text + sender.text
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Display.Text = ""
    End Sub
    Dim Mem As String
    Dim firstnum As Long
    Dim oper As String
    Private Sub ButtonMPlus_Click(sender As Object, e As EventArgs) Handles ButtonMPlus.Click
        Mem = Display.Text
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles ButtonMR.Click
        Display.Text = Mem
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim num As Long
        num = Display.Text
        Display.Text = num * num
    End Sub

    Private Sub ButtonPlus_Click(sender As Object, e As EventArgs) Handles ButtonPlus.Click, Button11.Click, ButtonTimes.Click, ButtonDivison.Click
        oper = sender.Text '+
        firstnum = Display.Text
        Display.Text = ""
    End Sub

    Private Sub ButtonEqual_Click(sender As Object, e As EventArgs) Handles ButtonEqual.Click
        If oper = "+" Then
            Display.Text = firstnum + Display.Text
        End If
        If oper = "-" Then
            Display.Text = firstnum - Display.Text
        End If
        If oper = "x" Then
            Display.Text = firstnum * Display.Text
        End If
        If oper = "÷" Then
            Display.Text = firstnum / Display.Text
        End If
    End Sub

    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles Button13.Click
        Display.Text = Math.Sin(Display.Text)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Display.Text = Math.PI
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Display.Text = Math.Tan(Display.Text)
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Display.Text = Math.Cos(Display.Text)
    End Sub
End Class
