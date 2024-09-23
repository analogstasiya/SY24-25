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
        Label1 = New Label()
        agetextbox = New TextBox()
        Label2 = New Label()
        weighttextbox = New TextBox()
        PictureBox1 = New PictureBox()
        FATTIE = New TextBox()
        Button1 = New Button()
        randomlabel = New Label()
        randomtextbox = New TextBox()
        die1 = New PictureBox()
        die2 = New PictureBox()
        die3 = New PictureBox()
        die4 = New PictureBox()
        rollbutton = New Button()
        die5 = New PictureBox()
        die6 = New PictureBox()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        firstdie = New PictureBox()
        seconddie = New PictureBox()
        thirddie = New PictureBox()
        winner = New Label()
        reset = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(die1, ComponentModel.ISupportInitialize).BeginInit()
        CType(die2, ComponentModel.ISupportInitialize).BeginInit()
        CType(die3, ComponentModel.ISupportInitialize).BeginInit()
        CType(die4, ComponentModel.ISupportInitialize).BeginInit()
        CType(die5, ComponentModel.ISupportInitialize).BeginInit()
        CType(die6, ComponentModel.ISupportInitialize).BeginInit()
        CType(firstdie, ComponentModel.ISupportInitialize).BeginInit()
        CType(seconddie, ComponentModel.ISupportInitialize).BeginInit()
        CType(thirddie, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(24, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(36, 20)
        Label1.TabIndex = 0
        Label1.Text = "Age"
        ' 
        ' agetextbox
        ' 
        agetextbox.Location = New Point(75, 47)
        agetextbox.Name = "agetextbox"
        agetextbox.Size = New Size(125, 27)
        agetextbox.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 20)
        Label2.TabIndex = 2
        Label2.Text = "Weight"
        ' 
        ' weighttextbox
        ' 
        weighttextbox.Location = New Point(74, 86)
        weighttextbox.Name = "weighttextbox"
        weighttextbox.Size = New Size(125, 27)
        weighttextbox.TabIndex = 3
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.rump
        PictureBox1.Location = New Point(736, 19)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(52, 94)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' FATTIE
        ' 
        FATTIE.Font = New Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FATTIE.Location = New Point(-1, 117)
        FATTIE.Multiline = True
        FATTIE.Name = "FATTIE"
        FATTIE.Size = New Size(359, 252)
        FATTIE.TabIndex = 5
        FATTIE.Text = "YOURE FAT!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!"
        FATTIE.Visible = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(294, 38)
        Button1.Name = "Button1"
        Button1.Size = New Size(105, 29)
        Button1.TabIndex = 6
        Button1.Text = "heyyyyy ;ppp"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' randomlabel
        ' 
        randomlabel.AutoSize = True
        randomlabel.BorderStyle = BorderStyle.FixedSingle
        randomlabel.Location = New Point(235, 84)
        randomlabel.Name = "randomlabel"
        randomlabel.Size = New Size(2, 22)
        randomlabel.TabIndex = 7
        ' 
        ' randomtextbox
        ' 
        randomtextbox.Location = New Point(405, 40)
        randomtextbox.Name = "randomtextbox"
        randomtextbox.Size = New Size(125, 27)
        randomtextbox.TabIndex = 8
        ' 
        ' die1
        ' 
        die1.Image = My.Resources.Resources.dice
        die1.Location = New Point(268, 117)
        die1.Name = "die1"
        die1.Size = New Size(68, 62)
        die1.SizeMode = PictureBoxSizeMode.StretchImage
        die1.TabIndex = 9
        die1.TabStop = False
        die1.Tag = "1"
        die1.Visible = False
        ' 
        ' die2
        ' 
        die2.Image = My.Resources.Resources.dice2
        die2.Location = New Point(268, 117)
        die2.Name = "die2"
        die2.Size = New Size(68, 62)
        die2.SizeMode = PictureBoxSizeMode.StretchImage
        die2.TabIndex = 10
        die2.TabStop = False
        die2.Tag = "2"
        die2.Visible = False
        ' 
        ' die3
        ' 
        die3.Image = My.Resources.Resources.die3
        die3.Location = New Point(268, 117)
        die3.Name = "die3"
        die3.Size = New Size(68, 62)
        die3.SizeMode = PictureBoxSizeMode.StretchImage
        die3.TabIndex = 11
        die3.TabStop = False
        die3.Tag = "3"
        die3.Visible = False
        ' 
        ' die4
        ' 
        die4.Image = My.Resources.Resources.die4
        die4.Location = New Point(258, 117)
        die4.Name = "die4"
        die4.Size = New Size(78, 62)
        die4.SizeMode = PictureBoxSizeMode.StretchImage
        die4.TabIndex = 12
        die4.TabStop = False
        die4.Tag = "4"
        die4.Visible = False
        ' 
        ' rollbutton
        ' 
        rollbutton.Location = New Point(598, 12)
        rollbutton.Name = "rollbutton"
        rollbutton.Size = New Size(94, 40)
        rollbutton.TabIndex = 13
        rollbutton.Text = "ROLL!!!"
        rollbutton.UseVisualStyleBackColor = True
        ' 
        ' die5
        ' 
        die5.Image = My.Resources.Resources.die5
        die5.Location = New Point(258, 117)
        die5.Name = "die5"
        die5.Size = New Size(78, 62)
        die5.SizeMode = PictureBoxSizeMode.StretchImage
        die5.TabIndex = 14
        die5.TabStop = False
        die5.Tag = "5"
        die5.Visible = False
        ' 
        ' die6
        ' 
        die6.Image = My.Resources.Resources.dicee
        die6.Location = New Point(258, 117)
        die6.Name = "die6"
        die6.Size = New Size(90, 62)
        die6.SizeMode = PictureBoxSizeMode.StretchImage
        die6.TabIndex = 15
        die6.TabStop = False
        die6.Tag = "6"
        die6.Visible = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 5000
        ' 
        ' Timer2
        ' 
        Timer2.Interval = 5000
        ' 
        ' firstdie
        ' 
        firstdie.Location = New Point(594, 123)
        firstdie.Name = "firstdie"
        firstdie.Size = New Size(96, 74)
        firstdie.SizeMode = PictureBoxSizeMode.StretchImage
        firstdie.TabIndex = 16
        firstdie.TabStop = False
        ' 
        ' seconddie
        ' 
        seconddie.Location = New Point(596, 207)
        seconddie.Name = "seconddie"
        seconddie.Size = New Size(94, 74)
        seconddie.TabIndex = 17
        seconddie.TabStop = False
        ' 
        ' thirddie
        ' 
        thirddie.Location = New Point(596, 297)
        thirddie.Name = "thirddie"
        thirddie.Size = New Size(94, 74)
        thirddie.TabIndex = 18
        thirddie.TabStop = False
        ' 
        ' winner
        ' 
        winner.AutoSize = True
        winner.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        winner.Location = New Point(391, 207)
        winner.Name = "winner"
        winner.Size = New Size(178, 46)
        winner.TabIndex = 19
        winner.Text = "You won!!!"
        winner.Visible = False
        ' 
        ' reset
        ' 
        reset.Location = New Point(598, 66)
        reset.Name = "reset"
        reset.Size = New Size(94, 40)
        reset.TabIndex = 20
        reset.Text = "RESET!!!"
        reset.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(reset)
        Controls.Add(winner)
        Controls.Add(thirddie)
        Controls.Add(seconddie)
        Controls.Add(firstdie)
        Controls.Add(die6)
        Controls.Add(die5)
        Controls.Add(rollbutton)
        Controls.Add(die4)
        Controls.Add(die3)
        Controls.Add(die2)
        Controls.Add(die1)
        Controls.Add(randomtextbox)
        Controls.Add(randomlabel)
        Controls.Add(Button1)
        Controls.Add(FATTIE)
        Controls.Add(PictureBox1)
        Controls.Add(weighttextbox)
        Controls.Add(Label2)
        Controls.Add(agetextbox)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(die1, ComponentModel.ISupportInitialize).EndInit()
        CType(die2, ComponentModel.ISupportInitialize).EndInit()
        CType(die3, ComponentModel.ISupportInitialize).EndInit()
        CType(die4, ComponentModel.ISupportInitialize).EndInit()
        CType(die5, ComponentModel.ISupportInitialize).EndInit()
        CType(die6, ComponentModel.ISupportInitialize).EndInit()
        CType(firstdie, ComponentModel.ISupportInitialize).EndInit()
        CType(seconddie, ComponentModel.ISupportInitialize).EndInit()
        CType(thirddie, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents agetextbox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents weighttextbox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FATTIE As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents randomlabel As Label
    Friend WithEvents randomtextbox As TextBox
    Friend WithEvents die1 As PictureBox
    Friend WithEvents die2 As PictureBox
    Friend WithEvents die3 As PictureBox
    Friend WithEvents die4 As PictureBox
    Friend WithEvents rollbutton As Button
    Friend WithEvents die5 As PictureBox
    Friend WithEvents die6 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents firstdie As PictureBox
    Friend WithEvents seconddie As PictureBox
    Friend WithEvents thirddie As PictureBox
    Friend WithEvents winner As Label
    Friend WithEvents reset As Button

End Class
