Public Class Form1
    Dim score As Integer
    Dim movements As New Dictionary(Of String, Collection)
    Dim tracks As New Dictionary(Of String, Integer)
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        follow(Frank, Sheffrard, 7, 3)
        Track(lynz, Sheffrard)
        follow(bert, Sheffrard, 4, 7)
    End Sub
    Sub PaceX(e As PictureBox, p As PictureBox, speed As Integer)
        Dim dir As Integer
        dir = e.Tag

        movee(e, dir * speed, 0)

        If e.Location.X > p.Location.X + p.Width / 2 Then
            e.Tag = dir * -1
        End If
        If e.Location.X < p.Location.X Then
            e.Tag = dir * -1
        End If
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
        If Sheffrard.Bounds.IntersectsWith(coin.Bounds) Then
            coin.Visible = False
            score += 5
        End If
        If Sheffrard.Bounds.IntersectsWith(coin1.Bounds) Then
            coin1.Visible = False
            score += 5
        End If
        If Sheffrard.Bounds.IntersectsWith(coin5.Bounds) Then
            coin5.Visible = False
            score += 5
        End If
        If Sheffrard.Bounds.IntersectsWith(coin6.Bounds) Then
            coin6.Visible = False
            score += 5
        End If
        If Sheffrard.Bounds.IntersectsWith(coin7.Bounds) Then
            coin7.Visible = False
            score += 5
        End If
        If Sheffrard.Bounds.IntersectsWith(coin8.Bounds) Then
            coin8.Visible = False
            score += 5
        End If
        If Sheffrard.Bounds.IntersectsWith(coin9.Bounds) Then
            coin9.Visible = False
            score += 5
        End If
        If Sheffrard.Bounds.IntersectsWith(coin10.Bounds) Then
            coin10.Visible = False
            score += 5
        End If
        If Sheffrard.Bounds.IntersectsWith(coin11.Bounds) Then
            coin11.Visible = False
            score += 5
        End If
        If Sheffrard.Bounds.IntersectsWith(coin12.Bounds) Then
            coin12.Visible = False
            score += 5
        End If
        If Sheffrard.Bounds.IntersectsWith(coin13.Bounds) Then
            coin13.Visible = False
            score += 5
        End If
        If Sheffrard.Bounds.IntersectsWith(coin14.Bounds) Then
            coin14.Visible = False
            score += 5
        End If
        If Sheffrard.Bounds.IntersectsWith(coin15.Bounds) Then
            coin15.Visible = False
            score += 5
        End If
        If Sheffrard.Bounds.IntersectsWith(coin16.Bounds) Then
            coin16.Visible = False
            score += 5
        End If
        If Sheffrard.Bounds.IntersectsWith(coin17.Bounds) Then
            coin17.Visible = False
            score += 5
        End If
        If Sheffrard.Bounds.IntersectsWith(coin18.Bounds) Then
            coin18.Visible = False
            score += 5
        End If
        If Sheffrard.Bounds.IntersectsWith(coin19.Bounds) Then
            coin19.Visible = False
            score += 5
        End If
        If Sheffrard.Bounds.IntersectsWith(finishline.Bounds) Then
            winscreen.Visible = True
            resetbutton.Visible = True
        End If
    End Sub
    Sub movee(p As PictureBox, xdir As Integer, ydir As Integer)
        p.Location += New Point(xdir, ydir)

        If IntersectsWith(p, "wall") Then
            p.Location -= New Point(xdir, ydir)
        End If

        If Not movements.ContainsKey(p.Name) Then
            movements.Add(p.Name, New Collection)
        End If
        movements(p.Name).Add(p.Location)
        If IntersectsWith(p, "enemy") Then
            Timer2.Enabled = False
            deathscreen.Visible = True
            resetbutton.Visible = True
        End If
    End Sub
    Sub Track(e As PictureBox, a As PictureBox)
        If Not tracks.ContainsKey(e.Name & a.Name) Then
            tracks.Add(e.Name & a.Name, 1)
        Else
            Dim idx As Integer
            idx = tracks(e.Name & a.Name)
            If movements.ContainsKey(a.Name) AndAlso idx < movements(a.Name).Count Then
                e.Location = movements(a.Name).Item(idx)
                tracks(e.Name & a.Name) = idx + 1
            End If

        End If
    End Sub

    Function IntersectsWith(p As PictureBox, tag As String, Optional ByRef other As PictureBox = Nothing) As Boolean
        For Each o In Controls
            Dim obj As PictureBox
            obj = TryCast(o, PictureBox)
            If Not obj Is Nothing AndAlso obj.Visible Then
                If p.Bounds.IntersectsWith(obj.Bounds) And (UCase(obj.Tag) = UCase(tag) Or
                    UCase(obj.Name).EndsWith(UCase(tag))) Then
                    other = obj
                    Return True
                End If
            End If
        Next
        Return False
    End Function
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        score += 1
        scorelabel.Text = score
        If Sheffrard.Bounds.IntersectsWith(finishline.Bounds) Then
            Timer2.Enabled = False
        End If
    End Sub

End Class
