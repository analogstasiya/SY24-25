Public Class Form1
    Public Sub radio(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged
        Dim processf As Decimal
        Dim servicefee As Decimal
        Dim premiumcost As Decimal
        If RadioButton1.Checked Then
            processf = 16.5
            servicefee = 80
            premiumcost = 50
        ElseIf RadioButton2.Checked Then
            processf = 4.5
            servicefee = 30
            premiumcost = 5
        End If
    End Sub

    Private Sub calc(ByVal units As Integer, ByRef charge As Double)

    End Sub
    Function Calc(processf, servicefee, premiumcost, channels, connections, plus) As Decimal
        Return (processf + servicefee) + (channels * premiumcost + plus)
    End Function

    Public Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim channel As Decimal
        If ListBox1.Text = 1 Then
            channel = 1.0
        ElseIf ListBox1.Text = 2 Then
            channel = 2
        ElseIf ListBox1.Text = 3 Then
            channel = 3
        Else
            channel = 0
        End If
    End Sub

    Public Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged, RadioButton1.CheckedChanged, RadioButton2.CheckedChanged
        Dim connections As String
        Dim plus As String
        If RadioButton2.Checked Then
            connections = 9
            plus = 0
        ElseIf ListBox2.Text = 10 Then
            connections = 10
            plus = 0
        ElseIf radiobutton1.checked And ListBox2.Text = 11 Then
            connections = 11
            plus = 4
        ElseIf radiobutton1.checked And ListBox2.Text = 12 Then
            connections = 12
            plus = 8
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
