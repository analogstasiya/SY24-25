Public Class Form1
    ' Class-level variables to store values across methods
    Private processf As Decimal
    Private servicefee As Decimal
    Private premiumcost As Decimal
    Private connections As Integer
    Private plus As Integer

    Public Sub radio(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged
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

    Private Sub cal(ByVal units As Integer, ByRef charge As Double)
        Calc(processf As Decimal, servicefee As Decimal, premiumcost As Decimal, channels As Integer, )
    End Sub

    Function Calc(processf As Decimal, servicefee As Decimal, premiumcost As Decimal, channels As Integer, connections As Integer, plus As Integer) As Decimal
        Return (processf + servicefee) + (channels * premiumcost + plus)
    End Function

    Public Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim channel As Decimal
        If Convert.ToInt32(ListBox1.Text) = 1 Then
            channel = 1.0
        ElseIf Convert.ToInt32(ListBox1.Text) = 2 Then
            channel = 2.0
        ElseIf Convert.ToInt32(ListBox1.Text) = 3 Then
            channel = 3.0
        Else
            channel = 0
        End If
    End Sub

    Public Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged, RadioButton1.CheckedChanged, RadioButton2.CheckedChanged
        Dim box As Double
        Double.TryParse(ListBox2.Text, box)

        If RadioButton2.Checked Then
            connections = 9
            plus = 0
        ElseIf box = 10 Then
            connections = 10
            plus = 0
        ElseIf RadioButton1.Checked And box = 11 Then
            connections = 11
            plus = 4
        ElseIf RadioButton1.Checked And box = 12 Then
            connections = 12
            plus = 8
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class

