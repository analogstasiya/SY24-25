Imports System.ComponentModel.Design
Imports System.Windows.Forms.Design.AxImporter

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Function ask(p As String, pb As PictureBox, a As String, b As String) As String
        Dim f As New prompt
        f.prompttb.Text = p
        f.promptdisplay.Image = pb.Image
        f.option1.Text = a
        f.option2.Text = b
        f.ShowDialog()
        Return f.answer
    End Function
    Function say(s As String, pb As PictureBox)
        Dim f As New prompt
        f.prompttb.Text = s
        f.promptdisplay.Image = pb.Image
        f.ShowDialog()
        Return f.answer
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Visible = False
        TextBox1.Visible = False
        If ask("Do you want to go outside or stay inside", PictureBox2, "go outside", "stay inside") = "stay inside" Then
            say("You die of boredom. YOU LOSE. PLAY AGAIN.", PictureBox1)
            Button1.Visible = True
        Else
            If ask("What will you wear?", PictureBox3, "A Graphic T-shirt and Jeans", "A Beanie, scarf, coat, and boots") = "A Graphic T-shirt and Jeans" Then
                say("You freeze to death and die. Play Again.", PictureBox15)
                Button1.Visible = True
            Else
                If ask("Do you build a snowman or sled down the hill your house is built atop?", PictureBox1, "build a snowman", "sled down the hill") = "sled down the hill" Then
                    say("You fall down the hill and crack your skull open and bleed to death. YOU LOSE. PLAY AGAIN.", PictureBox5)
                    Button1.Visible = True
                Else
                    say("You build a snowman, but you're missing the most important part, the carrot nose. You have no money to buy a carrot.", PictureBox6)
                    If ask("Do you steal from the super market or do you beg people for money?", PictureBox9, "beg", "steal") = "steal" Then
                        say("You get caught and are shot 4 times by store security and die. YOU LOSE. PLAY AGAIN.", PictureBox7)
                        Button1.Visible = True
                    Else
                        say("An old lady pities you and gives you $10, which is enough to buy a carrot AND some flowers to give to your crush.", PictureBox9)
                        If ask("Buy just the carrot or carrot and flowers?", PictureBox9, "just carrot", "carrot and flowers") = "just carrot" Then
                            say("You finish building a beautiful snowman without dying. WIN! Play again if you want! :)", PictureBox13)
                            Button1.Visible = True
                        Else
                            If ask("What kind of flowers do you buy??", PictureBox9, "roses", "tulips") = "roses" Then
                                say("She loves roses and falls in love with you because all the other boys at school bully her. 10 years later you guys get happily married and have 2 baby girls. WIN! Play again if you want! :)", PictureBox14)
                            Else
                                say("Her cat eats part of the flower you gave her, and it dies. She resents you for killing her cat, and she murders you in your sleep. YOU LOSE. PLAY AGAIN.", PictureBox12)
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ask("Do you want to go outside or stay inside", PictureBox2, "go outside", "stay inside") = "stay inside" Then
            say("You die of boredom. YOU LOSE. PLAY AGAIN.", PictureBox1)
            Button1.Visible = True
        Else
            If ask("What will you wear?", PictureBox3, "A Graphic T-shirt and Jeans", "A Beanie, scarf, coat, and boots") = "A Graphic T-shirt and Jeans" Then
                say("You freeze to death and die. Play Again.", PictureBox15)
                Button1.Visible = True
            Else
                If ask("Do you build a snowman or sled down the hill your house is built atop?", PictureBox1, "build a snowman", "sled down the hill") = "sled down the hill" Then
                    say("You fall down the hill and crack your skull open and bleed to death. YOU LOSE. PLAY AGAIN.", PictureBox5)
                    Button1.Visible = True
                    If ask("Do you steal from the super market or do you beg people for money?", PictureBox9, "beg", "steal") = "steal" Then
                        say("You get caught and are shot 4 times by store security and die. YOU LOSE. PLAY AGAIN.", PictureBox7)
                        Button1.Visible = True
                    Else
                        If ask("Buy just the carrot or carrot and flowers?", PictureBox9, "just carrot", "carrot and flowers") = "just carrot" Then
                            say("You finish building a beautiful snowman without dying. WIN! Play again if you want! :)", PictureBox13)
                            Button1.Visible = True
                        Else
                            If ask("What kind of flowers do you buy??", PictureBox9, "roses", "tulips") = "roses" Then
                                say("She loves roses and falls in love with you because all the other boys at school bully her. 10 years later you guys get happily married and have 2 baby girls. WIN! Play again if you want! :)", PictureBox14)
                            Else
                                say("Her cat eats part of the flower you gave her, and it dies. She resents you for killing her cat, and she murders you in your sleep. YOU LOSE. PLAY AGAIN.", PictureBox12)
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
End Class
