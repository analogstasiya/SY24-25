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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Sheffrard = New PictureBox()
        Timer1 = New Timer(components)
        Gold = New PictureBox()
        Frank = New PictureBox()
        lynz = New PictureBox()
        bert = New PictureBox()
        platform = New PictureBox()
        PictureBox1 = New PictureBox()
        CType(Sheffrard, ComponentModel.ISupportInitialize).BeginInit()
        CType(Gold, ComponentModel.ISupportInitialize).BeginInit()
        CType(Frank, ComponentModel.ISupportInitialize).BeginInit()
        CType(lynz, ComponentModel.ISupportInitialize).BeginInit()
        CType(bert, ComponentModel.ISupportInitialize).BeginInit()
        CType(platform, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Sheffrard
        ' 
        Sheffrard.BackgroundImageLayout = ImageLayout.None
        Sheffrard.Image = CType(resources.GetObject("Sheffrard.Image"), Image)
        Sheffrard.Location = New Point(12, 258)
        Sheffrard.Name = "Sheffrard"
        Sheffrard.Size = New Size(154, 183)
        Sheffrard.SizeMode = PictureBoxSizeMode.StretchImage
        Sheffrard.TabIndex = 0
        Sheffrard.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' Gold
        ' 
        Gold.Image = My.Resources.Resources.gold_coin
        Gold.Location = New Point(762, 379)
        Gold.Name = "Gold"
        Gold.Size = New Size(73, 62)
        Gold.SizeMode = PictureBoxSizeMode.StretchImage
        Gold.TabIndex = 1
        Gold.TabStop = False
        ' 
        ' Frank
        ' 
        Frank.Image = CType(resources.GetObject("Frank.Image"), Image)
        Frank.Location = New Point(172, 267)
        Frank.Name = "Frank"
        Frank.Size = New Size(131, 174)
        Frank.SizeMode = PictureBoxSizeMode.StretchImage
        Frank.TabIndex = 2
        Frank.TabStop = False
        ' 
        ' lynz
        ' 
        lynz.Image = CType(resources.GetObject("lynz.Image"), Image)
        lynz.Location = New Point(343, 267)
        lynz.Name = "lynz"
        lynz.Size = New Size(123, 174)
        lynz.SizeMode = PictureBoxSizeMode.StretchImage
        lynz.TabIndex = 4
        lynz.TabStop = False
        ' 
        ' bert
        ' 
        bert.Image = CType(resources.GetObject("bert.Image"), Image)
        bert.Location = New Point(531, 258)
        bert.Name = "bert"
        bert.Size = New Size(93, 174)
        bert.SizeMode = PictureBoxSizeMode.StretchImage
        bert.TabIndex = 5
        bert.TabStop = False
        bert.Tag = "-1"
        ' 
        ' platform
        ' 
        platform.Image = My.Resources.Resources.Stone_JE5_move
        platform.Location = New Point(519, 438)
        platform.Name = "platform"
        platform.Size = New Size(176, 52)
        platform.SizeMode = PictureBoxSizeMode.StretchImage
        platform.TabIndex = 7
        platform.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.AppWorkspace
        PictureBox1.Location = New Point(0, 447)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(303, 43)
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(229), CByte(192), CByte(84))
        ClientSize = New Size(847, 493)
        Controls.Add(platform)
        Controls.Add(PictureBox1)
        Controls.Add(bert)
        Controls.Add(lynz)
        Controls.Add(Frank)
        Controls.Add(Gold)
        Controls.Add(Sheffrard)
        Name = "Form1"
        Text = "Form1"
        CType(Sheffrard, ComponentModel.ISupportInitialize).EndInit()
        CType(Gold, ComponentModel.ISupportInitialize).EndInit()
        CType(Frank, ComponentModel.ISupportInitialize).EndInit()
        CType(lynz, ComponentModel.ISupportInitialize).EndInit()
        CType(bert, ComponentModel.ISupportInitialize).EndInit()
        CType(platform, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Sheffrard As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Gold As PictureBox
    Friend WithEvents Frank As PictureBox
    Friend WithEvents lynz As PictureBox
    Friend WithEvents bert As PictureBox
    Friend WithEvents platform As PictureBox
    Friend WithEvents PictureBox1 As PictureBox

End Class
