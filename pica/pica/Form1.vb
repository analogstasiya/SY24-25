Public Class Form1
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        PictureBox1.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub RightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RightToolStripMenuItem.Click
        PictureBox1.Location += New Point(30, 0)
        Me.Refresh()
    End Sub

    Private Sub StretchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StretchToolStripMenuItem.Click
        PictureBox1.Width *= 2
        PictureBox1.Height *= 2
        Me.Refresh()
    End Sub

    Private Sub LeftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeftToolStripMenuItem.Click
        PictureBox1.Location += New Point(-30, 0)
        Me.Refresh()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        PictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        Me.Refresh()
    End Sub

    Private Sub UpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpToolStripMenuItem.Click
        PictureBox1.Location += New Point(0, -30)
        Me.Refresh()
    End Sub

    Private Sub DownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DownToolStripMenuItem.Click
        PictureBox1.Location += New Point(0, 30)
        Me.Refresh()
    End Sub

    Private Sub ShrinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShrinkToolStripMenuItem.Click
        PictureBox1.Width *= 0.5
        PictureBox1.Height *= 0.5
        Me.Refresh()
    End Sub

    Private Sub Left90ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Left90ToolStripMenuItem.Click
        PictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipXY)
        Me.Refresh()
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        TextBox1.Font = FontDialog1.Font
    End Sub

    Private Sub BackColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        TextBox1.BackColor = ColorDialog1.Color
    End Sub

    Private Sub ForecolorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForecolorToolStripMenuItem.Click
        ColorDialog2.ShowDialog()
        TextBox1.ForeColor = ColorDialog2.Color
    End Sub
End Class
