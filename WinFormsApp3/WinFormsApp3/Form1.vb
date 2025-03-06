Imports System.ComponentModel.Design
Imports System.Windows.Forms.Design.AxImporter

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ask("Do you want to go outside or stay inside", PictureBox2, "go outside", "stay inside") = "go outside" Then
            If ask("What will you wear?", PictureBox3, "A Graphic T-shirt and Jeans", "A Beanie, scarf, coat, and boots") = "A Beanie, scarf, coat, and boots" Then Else

            If ask("Do you build a snowman or sled down the hill your house is built atop?", PictureBox1, "build a snowman", "sled down the hill") = "build a snowman" Then
                    If ask("Do you steal from the super market or do you beg people for money?", PictureBox9, "beg", "steal") = "beg" Then
                        If ask("Buy just the carrot or carrot and flowers?", PictureBox9, "just carrot", "carrot and flowers") = "carrot and flowers" Then
                            If ask("What kind of flowers do you buy??", PictureBox9, "roses", "tulips") = "roses" Then
                                say("She loves roses and falls in love with you because all the other boys at school bully her. 10 years later you guys get happily married and have 2 baby girls. WIN!", PictureBox14)
                            Else say("YOU LOSE. ")
                            End If
                        End If

    End Sub
    Function ask(p As String, pb As PictureBox, a As String, b As String)
        Dim f As New prompt
        f.prompttb.Text = p
        f.promptdisplay.Image = pb.Image
        f.option1.Text = a
        f.option2.Text = b
    End Function
    Function say(s As String, pb As PictureBox)
        Dim f As New prompt
        f.prompttb.Text = s
        f.promptdisplay.Image = pb.Image
    End Function
End Class
