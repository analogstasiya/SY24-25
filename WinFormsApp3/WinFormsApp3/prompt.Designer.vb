<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prompt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        promptdisplay = New PictureBox()
        option1 = New Button()
        option2 = New Button()
        prompttb = New TextBox()
        CType(promptdisplay, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' promptdisplay
        ' 
        promptdisplay.Location = New Point(492, 34)
        promptdisplay.Name = "promptdisplay"
        promptdisplay.Size = New Size(259, 178)
        promptdisplay.SizeMode = PictureBoxSizeMode.StretchImage
        promptdisplay.TabIndex = 0
        promptdisplay.TabStop = False
        ' 
        ' option1
        ' 
        option1.Location = New Point(316, 260)
        option1.Name = "option1"
        option1.Size = New Size(161, 113)
        option1.TabIndex = 1
        option1.Text = "Button1"
        option1.UseVisualStyleBackColor = True
        ' 
        ' option2
        ' 
        option2.Location = New Point(492, 260)
        option2.Name = "option2"
        option2.Size = New Size(164, 113)
        option2.TabIndex = 2
        option2.Text = "Button2"
        option2.UseVisualStyleBackColor = True
        ' 
        ' prompttb
        ' 
        prompttb.Location = New Point(95, 151)
        prompttb.Multiline = True
        prompttb.Name = "prompttb"
        prompttb.ReadOnly = True
        prompttb.Size = New Size(193, 89)
        prompttb.TabIndex = 3
        ' 
        ' prompt
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(prompttb)
        Controls.Add(option2)
        Controls.Add(option1)
        Controls.Add(promptdisplay)
        Name = "prompt"
        Text = "prompt"
        CType(promptdisplay, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents promptdisplay As PictureBox
    Friend WithEvents option1 As Button
    Friend WithEvents option2 As Button
    Friend WithEvents prompttb As TextBox
End Class
