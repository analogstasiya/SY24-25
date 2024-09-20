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
        ouch = New Label()
        lynz = New PictureBox()
        CType(Sheffrard, ComponentModel.ISupportInitialize).BeginInit()
        CType(Gold, ComponentModel.ISupportInitialize).BeginInit()
        CType(Frank, ComponentModel.ISupportInitialize).BeginInit()
        CType(lynz, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Sheffrard
        ' 
        Sheffrard.BackgroundImageLayout = ImageLayout.None
        Sheffrard.Image = CType(resources.GetObject("Sheffrard.Image"), Image)
        Sheffrard.Location = New Point(2, -1)
        Sheffrard.Name = "Sheffrard"
        Sheffrard.Size = New Size(172, 220)
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
        Gold.Location = New Point(249, 419)
        Gold.Name = "Gold"
        Gold.Size = New Size(73, 62)
        Gold.SizeMode = PictureBoxSizeMode.StretchImage
        Gold.TabIndex = 1
        Gold.TabStop = False
        ' 
        ' Frank
        ' 
        Frank.Image = CType(resources.GetObject("Frank.Image"), Image)
        Frank.Location = New Point(214, 68)
        Frank.Name = "Frank"
        Frank.Size = New Size(151, 223)
        Frank.SizeMode = PictureBoxSizeMode.StretchImage
        Frank.TabIndex = 2
        Frank.TabStop = False
        ' 
        ' ouch
        ' 
        ouch.AutoSize = True
        ouch.BackColor = Color.White
        ouch.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ouch.Location = New Point(12, 364)
        ouch.Name = "ouch"
        ouch.Size = New Size(98, 41)
        ouch.TabIndex = 3
        ouch.Text = "Ouch!"
        ouch.Visible = False
        ' 
        ' lynz
        ' 
        lynz.Image = CType(resources.GetObject("lynz.Image"), Image)
        lynz.Location = New Point(471, 135)
        lynz.Name = "lynz"
        lynz.Size = New Size(151, 223)
        lynz.SizeMode = PictureBoxSizeMode.StretchImage
        lynz.TabIndex = 4
        lynz.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(847, 493)
        Controls.Add(lynz)
        Controls.Add(ouch)
        Controls.Add(Frank)
        Controls.Add(Gold)
        Controls.Add(Sheffrard)
        Name = "Form1"
        Text = "Form1"
        CType(Sheffrard, ComponentModel.ISupportInitialize).EndInit()
        CType(Gold, ComponentModel.ISupportInitialize).EndInit()
        CType(Frank, ComponentModel.ISupportInitialize).EndInit()
        CType(lynz, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Sheffrard As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Gold As PictureBox
    Friend WithEvents Frank As PictureBox
    Friend WithEvents ouch As Label
    Friend WithEvents lynz As PictureBox

End Class
