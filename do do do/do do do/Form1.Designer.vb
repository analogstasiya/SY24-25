<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtTask = New TextBox()
        lstTasks = New ListBox()
        btnAddTask = New Button()
        btnMarkComplete = New Button()
        btnDeleteTask = New Button()
        btnSaveTasks = New Button()
        btnLoadTasks = New Button()
        SuspendLayout()
        ' 
        ' txtTask
        ' 
        txtTask.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTask.Location = New Point(458, 12)
        txtTask.Multiline = True
        txtTask.Name = "txtTask"
        txtTask.Size = New Size(330, 72)
        txtTask.TabIndex = 0
        ' 
        ' lstTasks
        ' 
        lstTasks.FormattingEnabled = True
        lstTasks.Location = New Point(12, 24)
        lstTasks.Name = "lstTasks"
        lstTasks.Size = New Size(342, 404)
        lstTasks.TabIndex = 1
        ' 
        ' btnAddTask
        ' 
        btnAddTask.Location = New Point(458, 109)
        btnAddTask.Name = "btnAddTask"
        btnAddTask.Size = New Size(94, 42)
        btnAddTask.TabIndex = 2
        btnAddTask.Text = "Add"
        btnAddTask.UseVisualStyleBackColor = True
        ' 
        ' btnMarkComplete
        ' 
        btnMarkComplete.Location = New Point(573, 109)
        btnMarkComplete.Name = "btnMarkComplete"
        btnMarkComplete.Size = New Size(94, 72)
        btnMarkComplete.TabIndex = 3
        btnMarkComplete.Text = "Mark Coplete!"
        btnMarkComplete.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteTask
        ' 
        btnDeleteTask.Location = New Point(694, 109)
        btnDeleteTask.Name = "btnDeleteTask"
        btnDeleteTask.Size = New Size(94, 42)
        btnDeleteTask.TabIndex = 4
        btnDeleteTask.Text = "Delete"
        btnDeleteTask.UseVisualStyleBackColor = True
        ' 
        ' btnSaveTasks
        ' 
        btnSaveTasks.Location = New Point(504, 187)
        btnSaveTasks.Name = "btnSaveTasks"
        btnSaveTasks.Size = New Size(94, 42)
        btnSaveTasks.TabIndex = 5
        btnSaveTasks.Text = "Save"
        btnSaveTasks.UseVisualStyleBackColor = True
        ' 
        ' btnLoadTasks
        ' 
        btnLoadTasks.Location = New Point(650, 187)
        btnLoadTasks.Name = "btnLoadTasks"
        btnLoadTasks.Size = New Size(94, 42)
        btnLoadTasks.TabIndex = 6
        btnLoadTasks.Text = "Load"
        btnLoadTasks.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnLoadTasks)
        Controls.Add(btnSaveTasks)
        Controls.Add(btnDeleteTask)
        Controls.Add(btnMarkComplete)
        Controls.Add(btnAddTask)
        Controls.Add(lstTasks)
        Controls.Add(txtTask)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtTask As TextBox
    Friend WithEvents lstTasks As ListBox
    Friend WithEvents btnAddTask As Button
    Friend WithEvents btnMarkComplete As Button
    Friend WithEvents btnDeleteTask As Button
    Friend WithEvents btnSaveTasks As Button
    Friend WithEvents btnLoadTasks As Button

End Class
