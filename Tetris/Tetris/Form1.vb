Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        follow(Frank, Sheffrard, 3, 3)
        follow(lynz, Sheffrard, 7, 7)
        follow(bert, Sheffrard, 5, 6)
    End Sub
    Sub follow(e As PictureBox, a As PictureBox, xspeed As Integer, yspeed As Integer)
        If e.Location.Y < a.Location.Y Then
            movee(e, 0, yspeed)
        Else
            movee(e, 0, -yspeed)
        End If
        If e.Location.X < a.Location.X Then
            movee(e, xspeed, 0)
        Else
            movee(e, -xspeed, 0)
        End If
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Or e.KeyCode = Keys.D Then
            movee(Sheffrard, 30, 0)
        End If
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.A Then
            movee(Sheffrard, -30, 0)
        End If
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.S Then
            movee(Sheffrard, 0, 30)
        End If
        If e.KeyCode = Keys.Space Then
            Sheffrard.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.W Then
            movee(Sheffrard, 0, -30)
        End If
        Sheffrard.Refresh()
        If Sheffrard.Bounds.IntersectsWith(Gold.Bounds) Then
            Gold.Visible = False
        End If
    End Sub
    Sub movee(p As PictureBox, xdir As Integer, ydir As Integer)
        p.Location += New Point(xdir, ydir)
    End Sub

End Class
