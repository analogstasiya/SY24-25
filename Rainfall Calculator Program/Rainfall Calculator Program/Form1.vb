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

    Private Sub ExitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub CalcButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CalcButton.Click
        Static raincounter As Integer
        Static rainAccum As Decimal
        Dim monthrain As Decimal
        Dim avgrain As Decimal
        If monthTextbox.Text <> String.Empty Then
            Decimal.TryParse(monthTextbox.Text, monthrain)
            rainAccum += monthrain
            raincounter += 1
        End If
        Call calcaverage(raincounter, rainAccum, avgrain)
        TotalLabel.Text = rainAccum.ToString("N2")
        averageLabel.Text = avgrain.ToString("N2")
        monthTextbox.Focus()
        monthTextbox.SelectAll()
    End Sub

    Private Sub monthTextbox_enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles monthTextbox.Enter
        monthTextbox.SelectAll()
    End Sub

    Private Sub monthTextbox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles monthTextbox.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub monthTextbox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles monthTextbox.TextChanged
        TotalLabel.Text = String.Empty
        averageLabel.Text = String.Empty
    End Sub
End Class
