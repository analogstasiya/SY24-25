Imports System.IO
Imports System.Runtime.Intrinsics.Arm

Public Class Form1
    Dim fs As New IO.StreamReader("DVUSD.csv")
    Dim inde As Integer
    Dim count As Integer
    Dim schools(5) As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fs.ReadLine()
        While fs.Peek > 0
            schools(count) = fs.ReadLine
            count += 1
        End While
        fs.Close()
    End Sub
    Private Sub next_Click(sender As Object, e As EventArgs) Handles Button1.Click
        inde = inde + 1
        showschool(schools(inde))
    End Sub
    Sub showschool(s As String)
        Dim data() As String
        data = s.Split(",")
        locationbox.Text = data(1)
        schoolbox.Text = data(0)
        mascotbox.Text = data(2)
        If File.Exists(schoolbox.Text & ".png") Then
            PictureBox1.Load(schoolbox.Text & ".png")
        Else
            PictureBox1.Image = Nothing
        End If
    End Sub
    Private Sub ok_click(sender As Object, e As EventArgs) Handles Previous.Click
        If inde < count + 1 Then
            inde = inde - 1
            showschool(schools(inde))
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s As String
        s = schoolbox.Text & "," & locationbox.Text & "," & mascotbox.Text & ","
        schools(inde) = s
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim fw As New StreamWriter("DVUSD.csv")
        fw.WriteLine()

        For inde = 0 To count - 1
            fw.WriteLine(schools(inde))
        Next
        fw.Close()
    End Sub
End Class
