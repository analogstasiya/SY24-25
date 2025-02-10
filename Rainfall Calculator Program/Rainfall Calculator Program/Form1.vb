'Created by Anastasiya Flinn>:) on 2/10/25
Option Explicit On
Option Strict On
Option Infer Off
Public Class Form1
    Private Sub calcaverage(ByVal counter As Integer, ByVal accumulator As Decimal, ByRef avg As Decimal)
        If counter > 0 Then
            avg = accumulator / counter
        Else
            avg = 0
        End If
    End Sub
End Class
