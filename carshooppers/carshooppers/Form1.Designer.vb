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
        Button1 = New Button()
        Button2 = New Button()
        TextBox1 = New TextBox()
        Label1 = New Label()
        TextBox2 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        ListBox1 = New ListBox()
        Label4 = New Label()
        ListBox2 = New ListBox()
        Label5 = New Label()
        ListBox3 = New ListBox()
        Label6 = New Label()
        TextBox3 = New TextBox()
        Label7 = New Label()
        TextBox4 = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(146, 256)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 0
        Button1.Text = "Calculate"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(284, 256)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 1
        Button2.Text = "Exit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(48, 190)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(72, 157)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 20)
        Label1.TabIndex = 3
        Label1.Text = "Price:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(113, 353)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(95, 27)
        TextBox2.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(242, 157)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 20)
        Label2.TabIndex = 5
        Label2.Text = "Rebate:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(367, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 20)
        Label3.TabIndex = 6
        Label3.Text = "Dealer Rate:"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Items.AddRange(New Object() {"1%", "2%", "3%"})
        ListBox1.Location = New Point(377, 158)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(33, 64)
        ListBox1.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(463, 131)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 20)
        Label4.TabIndex = 8
        Label4.Text = "Bank Rate:"
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.Items.AddRange(New Object() {"6%", "7%", "8%"})
        ListBox2.Location = New Point(478, 157)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(33, 64)
        ListBox2.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(563, 131)
        Label5.Name = "Label5"
        Label5.Size = New Size(143, 20)
        Label5.TabIndex = 10
        Label5.Text = "Term Rate (in years):"
        ' 
        ' ListBox3
        ' 
        ListBox3.FormattingEnabled = True
        ListBox3.Items.AddRange(New Object() {"1", "2", "3", "4"})
        ListBox3.Location = New Point(584, 158)
        ListBox3.Name = "ListBox3"
        ListBox3.Size = New Size(21, 84)
        ListBox3.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(82, 321)
        Label6.Name = "Label6"
        Label6.Size = New Size(148, 20)
        Label6.TabIndex = 12
        Label6.Text = "Dealer Monthly Rate:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(339, 353)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(95, 27)
        TextBox3.TabIndex = 13
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(309, 321)
        Label7.Name = "Label7"
        Label7.Size = New Size(136, 20)
        Label7.TabIndex = 14
        Label7.Text = "Bank Monthly Rate:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(217, 190)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(125, 27)
        TextBox4.TabIndex = 15
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox4)
        Controls.Add(Label7)
        Controls.Add(TextBox3)
        Controls.Add(Label6)
        Controls.Add(ListBox3)
        Controls.Add(Label5)
        Controls.Add(ListBox2)
        Controls.Add(Label4)
        Controls.Add(ListBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox4 As TextBox

End Class
