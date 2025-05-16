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
        Label1 = New Label()
        gpa = New TextBox()
        Label2 = New Label()
        community = New TextBox()
        r = New Label()
        CheckBox1 = New CheckBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(23, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 20)
        Label1.TabIndex = 0
        Label1.Text = "GPA:"
        ' 
        ' gpa
        ' 
        gpa.Location = New Point(68, 75)
        gpa.Name = "gpa"
        gpa.Size = New Size(125, 27)
        gpa.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 119)
        Label2.Name = "Label2"
        Label2.Size = New Size(281, 20)
        Label2.TabIndex = 2
        Label2.Text = "Involved in School Activites? Check if yes:"
        ' 
        ' community
        ' 
        community.Location = New Point(238, 161)
        community.Name = "community"
        community.Size = New Size(125, 27)
        community.TabIndex = 3
        ' 
        ' r
        ' 
        r.AutoSize = True
        r.Location = New Point(13, 161)
        r.Name = "r"
        r.Size = New Size(207, 20)
        r.TabIndex = 4
        r.Text = "Number of Community Hours:"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(299, 119)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(18, 17)
        CheckBox1.TabIndex = 5
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(585, 63)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(125, 63)
        TextBox2.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(318, 257)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 58)
        Button1.TabIndex = 7
        Button1.Text = "Check!"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.ahsosorry
        PictureBox1.Location = New Point(560, 207)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(193, 191)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        PictureBox1.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(CheckBox1)
        Controls.Add(r)
        Controls.Add(community)
        Controls.Add(Label2)
        Controls.Add(gpa)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents gpa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents community As TextBox
    Friend WithEvents r As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class
