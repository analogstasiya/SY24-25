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
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        OpenToolStripMenuItem = New ToolStripMenuItem()
        FontToolStripMenuItem = New ToolStripMenuItem()
        BackColorToolStripMenuItem = New ToolStripMenuItem()
        ForecolorToolStripMenuItem = New ToolStripMenuItem()
        MoveToolStripMenuItem = New ToolStripMenuItem()
        RightToolStripMenuItem = New ToolStripMenuItem()
        LeftToolStripMenuItem = New ToolStripMenuItem()
        UpToolStripMenuItem = New ToolStripMenuItem()
        DownToolStripMenuItem = New ToolStripMenuItem()
        ScaleToolStripMenuItem = New ToolStripMenuItem()
        StretchToolStripMenuItem = New ToolStripMenuItem()
        ShrinkToolStripMenuItem = New ToolStripMenuItem()
        RotateToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        Left90ToolStripMenuItem = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        TextBox1 = New TextBox()
        FontDialog1 = New FontDialog()
        ColorDialog1 = New ColorDialog()
        ColorDialog2 = New ColorDialog()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, MoveToolStripMenuItem, ScaleToolStripMenuItem, RotateToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {OpenToolStripMenuItem, FontToolStripMenuItem, BackColorToolStripMenuItem, ForecolorToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.Size = New Size(224, 26)
        OpenToolStripMenuItem.Text = "Load"
        ' 
        ' FontToolStripMenuItem
        ' 
        FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        FontToolStripMenuItem.Size = New Size(224, 26)
        FontToolStripMenuItem.Text = "Font"
        ' 
        ' BackColorToolStripMenuItem
        ' 
        BackColorToolStripMenuItem.Name = "BackColorToolStripMenuItem"
        BackColorToolStripMenuItem.Size = New Size(224, 26)
        BackColorToolStripMenuItem.Text = "Back Color"
        ' 
        ' ForecolorToolStripMenuItem
        ' 
        ForecolorToolStripMenuItem.Name = "ForecolorToolStripMenuItem"
        ForecolorToolStripMenuItem.Size = New Size(224, 26)
        ForecolorToolStripMenuItem.Text = "Fore color"
        ' 
        ' MoveToolStripMenuItem
        ' 
        MoveToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RightToolStripMenuItem, LeftToolStripMenuItem, UpToolStripMenuItem, DownToolStripMenuItem})
        MoveToolStripMenuItem.Name = "MoveToolStripMenuItem"
        MoveToolStripMenuItem.Size = New Size(60, 24)
        MoveToolStripMenuItem.Text = "Move"
        ' 
        ' RightToolStripMenuItem
        ' 
        RightToolStripMenuItem.Name = "RightToolStripMenuItem"
        RightToolStripMenuItem.Size = New Size(131, 26)
        RightToolStripMenuItem.Text = "Right"
        ' 
        ' LeftToolStripMenuItem
        ' 
        LeftToolStripMenuItem.Name = "LeftToolStripMenuItem"
        LeftToolStripMenuItem.Size = New Size(131, 26)
        LeftToolStripMenuItem.Text = "Left"
        ' 
        ' UpToolStripMenuItem
        ' 
        UpToolStripMenuItem.Name = "UpToolStripMenuItem"
        UpToolStripMenuItem.Size = New Size(131, 26)
        UpToolStripMenuItem.Text = "Up"
        ' 
        ' DownToolStripMenuItem
        ' 
        DownToolStripMenuItem.Name = "DownToolStripMenuItem"
        DownToolStripMenuItem.Size = New Size(131, 26)
        DownToolStripMenuItem.Text = "Down"
        ' 
        ' ScaleToolStripMenuItem
        ' 
        ScaleToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {StretchToolStripMenuItem, ShrinkToolStripMenuItem})
        ScaleToolStripMenuItem.Name = "ScaleToolStripMenuItem"
        ScaleToolStripMenuItem.Size = New Size(58, 24)
        ScaleToolStripMenuItem.Text = "Scale"
        ' 
        ' StretchToolStripMenuItem
        ' 
        StretchToolStripMenuItem.Name = "StretchToolStripMenuItem"
        StretchToolStripMenuItem.Size = New Size(138, 26)
        StretchToolStripMenuItem.Text = "Stretch"
        ' 
        ' ShrinkToolStripMenuItem
        ' 
        ShrinkToolStripMenuItem.Name = "ShrinkToolStripMenuItem"
        ShrinkToolStripMenuItem.Size = New Size(138, 26)
        ShrinkToolStripMenuItem.Text = "Shrink"
        ' 
        ' RotateToolStripMenuItem
        ' 
        RotateToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem2, Left90ToolStripMenuItem})
        RotateToolStripMenuItem.Name = "RotateToolStripMenuItem"
        RotateToolStripMenuItem.Size = New Size(67, 24)
        RotateToolStripMenuItem.Text = "Rotate"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(147, 26)
        ToolStripMenuItem2.Text = "Right 90"
        ' 
        ' Left90ToolStripMenuItem
        ' 
        Left90ToolStripMenuItem.Name = "Left90ToolStripMenuItem"
        Left90ToolStripMenuItem.Size = New Size(147, 26)
        Left90ToolStripMenuItem.Text = "Left 90"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(228, 85)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(316, 285)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(48, 85)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 116)
        TextBox1.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox1)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents MoveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RotateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeftToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StretchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents UpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DownToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShrinkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Left90ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ForecolorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorDialog2 As ColorDialog

End Class
