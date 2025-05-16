Public Class Form1
    Private Sub btnAddTask_Click(sender As Object, e As EventArgs) Handles btnAddTask.Click
        Dim task As String = txtTask.Text
        If task <> "" Then
            lstTasks.Items.Add(task)
            txtTask.Clear()
        Else
            MessageBox.Show("Please enter a task.")
        End If
    End Sub
    Private Sub btnMarkComplete_Click(sender As Object, e As EventArgs) Handles btnMarkComplete.Click
        If lstTasks.SelectedIndex <> -1 Then
            Dim selectedTask As String = lstTasks.SelectedItem.ToString()
            lstTasks.Items(lstTasks.SelectedIndex) = selectedTask & " - Completed"
        Else
            MessageBox.Show("Please select a task to mark as complete.")
        End If
    End Sub
    Private Sub btnDeleteTask_Click(sender As Object, e As EventArgs) Handles btnDeleteTask.Click
        If lstTasks.SelectedIndex <> -1 Then
            lstTasks.Items.RemoveAt(lstTasks.SelectedIndex)
        Else
            MessageBox.Show("Please select a task to delete.")
        End If
    End Sub
    Private Sub btnSaveTasks_Click(sender As Object, e As EventArgs) Handles btnSaveTasks.Click
        Dim filePath As String = "tasks.txt"
        Using writer As New IO.StreamWriter(filePath)
            For Each task As String In lstTasks.Items
                writer.WriteLine(task)
            Next
        End Using
        MessageBox.Show("Tasks saved successfully!")
    End Sub
    Private Sub btnLoadTasks_Click(sender As Object, e As EventArgs) Handles btnLoadTasks.Click
        Dim filePath As String = "tasks.txt"
        If IO.File.Exists(filePath) Then
            lstTasks.Items.Clear()
            Using reader As New IO.StreamReader(filePath)
                While Not reader.EndOfStream
                    lstTasks.Items.Add(reader.ReadLine())
                End While
            End Using
            MessageBox.Show("Tasks loaded successfully!")
        Else
            MessageBox.Show("No saved tasks found.")
        End If
    End Sub
End Class
