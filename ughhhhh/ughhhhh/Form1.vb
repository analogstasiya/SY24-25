Public Class Form1
    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click, btnProcess.Click
        Dim input = txtInput.Text

        ' Reverse the string
        txtReversed.Text = ReverseString(input)

        ' Count words
        txtWordCount.Text = CountWords(input).ToString

        ' Count vowels
        Dim vowelCounts = CountVowels(input)
        txtA.Text = vowelCounts("A").ToString
        txtE.Text = vowelCounts("E").ToString
        txtI.Text = vowelCounts("I").ToString
        txtO.Text = vowelCounts("O").ToString
        txtU.Text = vowelCounts("U").ToString
        If String.IsNullOrWhiteSpace(input) Then
            MessageBox.Show("Please enter a valid string.")
            Return
        End If

    End Sub

    Private Function ReverseString(ByVal input As String) As String
        Return New String(input.Reverse().ToArray())
    End Function

    Private Function CountWords(ByVal input As String) As Integer
        If String.IsNullOrWhiteSpace(input) Then
            Return 0
        End If
        Dim words = input.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
        Return words.Length
    End Function

    Private Function CountVowels(ByVal input As String) As Dictionary(Of Char, Integer)
        Dim vowelCounts As New Dictionary(Of Char, Integer) From {{"A"c, 0}, {"E"c, 0}, {"I"c, 0}, {"O"c, 0}, {"U"c, 0}}
        For Each ch As Char In input.ToUpper()
            If vowelCounts.ContainsKey(ch) Then
                vowelCounts(ch) += 1
            End If
        Next
        Return vowelCounts
    End Function
End Class
