Public Class prompt
    Public answer As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles option1.Click, option2.Click
        answer = sender.text
        Me.Close()
    End Sub
End Class