Imports System.Diagnostics.Eventing.Reader

Public Class Form1
    Private Sub agetextbox_TextChanged(sender As Object, e As EventArgs) Handles agetextbox.TextChanged
        Dim age As Integer
        Integer.TryParse(agetextbox.Text, age)
        If age >= 18 Then
            Me.BackColor = Color.Green
        Else
            Me.BackColor = Color.Red
        End If
    End Sub

    Private Sub weighttextbox_TextChanged(sender As Object, e As EventArgs) Handles weighttextbox.TextChanged
        Dim weight As Decimal
        Decimal.TryParse(weighttextbox.Text, weight)
        If weight > 100 Then
            Me.BackColor = Color.Purple
            FATTIE.Visible = True
        Else
            Me.BackColor = Color.Yellow
            FATTIE.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r As New Random
        randomlabel.Text = r.Next(1, 11)
        If randomlabel.Text = randomtextbox.Text Then
            Me.BackColor = Color.Green
        Else Me.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles rollbutton.Click
        firstdie.Visible = True
        seconddie.Visible = True
        thirddie.Visible = True
        roll(firstdie)
        roll(seconddie)
        roll(thirddie)
        Timer1.Enabled = True
        Timer2.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        roll(firstdie)
        roll(seconddie)
        roll(thirddie)
    End Sub
    Sub roll(d As PictureBox)
        Dim r As New Random
        Dim num As Integer
        num = r.Next(1, 7)
        If num = 1 Then
            d.Image = die1.Image
            d.Tag = die1.Tag
        End If
        If num = 2 Then
            d.Image = die2.Image
            d.Tag = die2.Tag
        End If
        If num = 3 Then
            d.Image = die3.Image
            d.Tag = die3.Tag
        End If
        If num = 4 Then
            d.Image = die4.Image
            d.Tag = die4.Tag
        End If
        If num = 5 Then
            d.Image = die5.Image
            d.Tag = die5.Tag
        End If
        If num = 6 Then
            d.Image = die6.Image
            d.Tag = die6.Tag
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer1.Enabled = False
        Timer2.Enabled = False
        If firstdie.Tag = seconddie.Tag And seconddie.Tag = thirddie.Tag Then
            winner.Visible = True
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles reset.Click
        firstdie.Visible = False
        seconddie.Visible = False
        thirddie.Visible = False
    End Sub
End Class
