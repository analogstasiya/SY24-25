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
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        ListBox1 = New ListBox()
        ListBox2 = New ListBox()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(39, 47)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(85, 24)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Business"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(39, 92)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(103, 24)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Residential"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(229, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 20)
        Label1.TabIndex = 2
        Label1.Text = "Premium Channels:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(380, 35)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 20)
        Label2.TabIndex = 3
        Label2.Text = "Connections:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(39, 183)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(229, 181)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 5
        Button1.Text = "Calculate"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(380, 181)
        Button2.Name = "Button2"
        Button2.Size = New Size(65, 29)
        Button2.TabIndex = 6
        Button2.Text = "Exit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Items.AddRange(New Object() {"0", "1", "2", "3"})
        ListBox1.Location = New Point(259, 78)
        ListBox1.Name = "ListBox1"
        ListBox1.ScrollAlwaysVisible = True
        ListBox1.Size = New Size(42, 84)
        ListBox1.TabIndex = 7
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.Items.AddRange(New Object() {"9", "10", "11", "12"})
        ListBox2.Location = New Point(399, 78)
        ListBox2.Name = "ListBox2"
        ListBox2.ScrollAlwaysVisible = True
        ListBox2.Size = New Size(46, 84)
        ListBox2.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(66, 160)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 20)
        Label3.TabIndex = 9
        Label3.Text = "Total Due:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(135, 267)
        Label4.Name = "Label4"
        Label4.Size = New Size(132, 20)
        Label4.TabIndex = 10
        Label4.Text = "Anastasiya Flinn>:)"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(ListBox2)
        Controls.Add(ListBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

End Class
