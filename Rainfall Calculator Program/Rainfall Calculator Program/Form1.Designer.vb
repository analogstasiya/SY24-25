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
        monthTextbox = New TextBox()
        Label1 = New Label()
        t = New Label()
        TotalLabel = New TextBox()
        Label2 = New Label()
        averageLabel = New TextBox()
        CalcButton = New Button()
        ExitButton = New Button()
        SuspendLayout()
        ' 
        ' monthTextbox
        ' 
        monthTextbox.Location = New Point(153, 47)
        monthTextbox.Name = "monthTextbox"
        monthTextbox.Size = New Size(125, 27)
        monthTextbox.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 20)
        Label1.TabIndex = 1
        Label1.Text = "Monthly Rainfall:"
        ' 
        ' t
        ' 
        t.AutoSize = True
        t.Location = New Point(48, 88)
        t.Name = "t"
        t.Size = New Size(99, 20)
        t.TabIndex = 2
        t.Text = "Total Rainfall:"
        ' 
        ' TotalLabel
        ' 
        TotalLabel.Location = New Point(153, 85)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New Size(125, 27)
        TotalLabel.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(48, 138)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 20)
        Label2.TabIndex = 4
        Label2.Text = "Total Rainfall:"
        ' 
        ' averageLabel
        ' 
        averageLabel.Location = New Point(153, 135)
        averageLabel.Name = "averageLabel"
        averageLabel.Size = New Size(125, 27)
        averageLabel.TabIndex = 5
        ' 
        ' CalcButton
        ' 
        CalcButton.Location = New Point(325, 69)
        CalcButton.Name = "CalcButton"
        CalcButton.Size = New Size(94, 29)
        CalcButton.TabIndex = 6
        CalcButton.Text = "Calculate"
        CalcButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(325, 116)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(94, 29)
        ExitButton.TabIndex = 7
        ExitButton.Text = "Exit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ExitButton)
        Controls.Add(CalcButton)
        Controls.Add(averageLabel)
        Controls.Add(Label2)
        Controls.Add(TotalLabel)
        Controls.Add(t)
        Controls.Add(Label1)
        Controls.Add(monthTextbox)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents monthTextbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents t As Label
    Friend WithEvents TotalLabel As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents averageLabel As TextBox
    Friend WithEvents CalcButton As Button
    Friend WithEvents ExitButton As Button

End Class
