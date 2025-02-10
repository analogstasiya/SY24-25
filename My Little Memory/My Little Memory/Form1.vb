Public Class Form1

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        TextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
        My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TextBox1.Text, True)
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        TextBox1.Font = FontDialog1.Font
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        TextBox1.BackColor = ColorDialog1.Color
    End Sub

    Private Sub FontColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontColorToolStripMenuItem.Click
        ColorDialog2.ShowDialog()
        TextBox1.ForeColor = ColorDialog2.Color
    End Sub
End Class
