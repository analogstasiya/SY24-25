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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        schoolbox = New TextBox()
        locationbox = New TextBox()
        mascotbox = New TextBox()
        Previous = New Button()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.boulder_creek
        PictureBox1.Location = New Point(71, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(199, 139)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 184)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 20)
        Label1.TabIndex = 1
        Label1.Text = "School Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 220)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 20)
        Label2.TabIndex = 2
        Label2.Text = "Location:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 264)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 20)
        Label3.TabIndex = 3
        Label3.Text = "Mascot:"
        ' 
        ' schoolbox
        ' 
        schoolbox.Location = New Point(120, 182)
        schoolbox.Name = "schoolbox"
        schoolbox.Size = New Size(175, 27)
        schoolbox.TabIndex = 4
        schoolbox.Text = "Boulder Creek"
        ' 
        ' locationbox
        ' 
        locationbox.Location = New Point(119, 220)
        locationbox.Name = "locationbox"
        locationbox.Size = New Size(176, 27)
        locationbox.TabIndex = 5
        locationbox.Text = "Anthem"
        ' 
        ' mascotbox
        ' 
        mascotbox.Location = New Point(119, 261)
        mascotbox.Name = "mascotbox"
        mascotbox.Size = New Size(176, 27)
        mascotbox.TabIndex = 6
        mascotbox.Text = "Jaguar"
        ' 
        ' Previous
        ' 
        Previous.Location = New Point(33, 341)
        Previous.Name = "Previous"
        Previous.Size = New Size(94, 29)
        Previous.TabIndex = 7
        Previous.Text = "Previous"
        Previous.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(172, 342)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 8
        Button1.Text = "Next"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(319, 450)
        Controls.Add(Button1)
        Controls.Add(Previous)
        Controls.Add(mascotbox)
        Controls.Add(locationbox)
        Controls.Add(schoolbox)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents schoolbox As TextBox
    Friend WithEvents locationbox As TextBox
    Friend WithEvents mascotbox As TextBox
    Friend WithEvents Previous As Button
    Friend WithEvents Button1 As Button

End Class
