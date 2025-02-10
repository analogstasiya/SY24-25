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
        Label2 = New Label()
        Label3 = New Label()
        fortyrb = New RadioButton()
        thirtyrb = New RadioButton()
        seventyrb = New RadioButton()
        onetwentyrb = New RadioButton()
        lengthbox = New TextBox()
        widthbox = New TextBox()
        costbox = New TextBox()
        Label4 = New Label()
        areabox = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 20)
        Label1.TabIndex = 0
        Label1.Text = "Length:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(20, 98)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 20)
        Label2.TabIndex = 1
        Label2.Text = "Width:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(20, 177)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 20)
        Label3.TabIndex = 2
        Label3.Text = "Cost:"
        ' 
        ' fortyrb
        ' 
        fortyrb.AutoSize = True
        fortyrb.Location = New Point(262, 64)
        fortyrb.Name = "fortyrb"
        fortyrb.Size = New Size(129, 24)
        fortyrb.TabIndex = 3
        fortyrb.TabStop = True
        fortyrb.Text = "Wood $40/sqft"
        fortyrb.UseVisualStyleBackColor = True
        ' 
        ' thirtyrb
        ' 
        thirtyrb.AutoSize = True
        thirtyrb.Location = New Point(262, 96)
        thirtyrb.Name = "thirtyrb"
        thirtyrb.Size = New Size(133, 24)
        thirtyrb.TabIndex = 4
        thirtyrb.TabStop = True
        thirtyrb.Text = "Carpet $30/sqft"
        thirtyrb.UseVisualStyleBackColor = True
        ' 
        ' seventyrb
        ' 
        seventyrb.AutoSize = True
        seventyrb.Location = New Point(262, 130)
        seventyrb.Name = "seventyrb"
        seventyrb.Size = New Size(113, 24)
        seventyrb.TabIndex = 5
        seventyrb.TabStop = True
        seventyrb.Text = "Tile $70/sqft"
        seventyrb.UseVisualStyleBackColor = True
        ' 
        ' onetwentyrb
        ' 
        onetwentyrb.AutoSize = True
        onetwentyrb.Location = New Point(262, 160)
        onetwentyrb.Name = "onetwentyrb"
        onetwentyrb.Size = New Size(452, 24)
        onetwentyrb.TabIndex = 6
        onetwentyrb.TabStop = True
        onetwentyrb.Text = "Lava (yes we will fill your house with real molten lava) $120/sqft" & vbCrLf
        onetwentyrb.UseVisualStyleBackColor = True
        ' 
        ' lengthbox
        ' 
        lengthbox.Location = New Point(83, 61)
        lengthbox.Name = "lengthbox"
        lengthbox.Size = New Size(125, 27)
        lengthbox.TabIndex = 7
        ' 
        ' widthbox
        ' 
        widthbox.Location = New Point(83, 98)
        widthbox.Name = "widthbox"
        widthbox.Size = New Size(125, 27)
        widthbox.TabIndex = 8
        ' 
        ' costbox
        ' 
        costbox.Location = New Point(83, 174)
        costbox.Name = "costbox"
        costbox.ReadOnly = True
        costbox.Size = New Size(125, 27)
        costbox.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(20, 134)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 20)
        Label4.TabIndex = 10
        Label4.Text = "Area:"
        ' 
        ' areabox
        ' 
        areabox.Location = New Point(83, 137)
        areabox.Name = "areabox"
        areabox.ReadOnly = True
        areabox.Size = New Size(125, 27)
        areabox.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(262, 205)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 12
        Button1.Text = "Reset"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(270, 256)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 13
        Button2.Text = "Calculate"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(areabox)
        Controls.Add(Label4)
        Controls.Add(costbox)
        Controls.Add(widthbox)
        Controls.Add(lengthbox)
        Controls.Add(onetwentyrb)
        Controls.Add(seventyrb)
        Controls.Add(thirtyrb)
        Controls.Add(fortyrb)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents fortyrb As RadioButton
    Friend WithEvents thirtyrb As RadioButton
    Friend WithEvents seventyrb As RadioButton
    Friend WithEvents onetwentyrb As RadioButton
    Friend WithEvents lengthbox As TextBox
    Friend WithEvents widthbox As TextBox
    Friend WithEvents costbox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents areabox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
