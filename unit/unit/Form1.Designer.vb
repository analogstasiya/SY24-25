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
        txtFahrenheit = New TextBox()
        txtCelsius = New TextBox()
        txtKg = New TextBox()
        txtLb = New TextBox()
        txtG = New TextBox()
        txtOz = New TextBox()
        txtLiter = New TextBox()
        txtGallon = New TextBox()
        txtCups = New TextBox()
        txtTablespoon = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        le = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        SuspendLayout()
        ' 
        ' txtFahrenheit
        ' 
        txtFahrenheit.Location = New Point(102, 56)
        txtFahrenheit.Name = "txtFahrenheit"
        txtFahrenheit.Size = New Size(125, 27)
        txtFahrenheit.TabIndex = 0
        ' 
        ' txtCelsius
        ' 
        txtCelsius.Location = New Point(326, 56)
        txtCelsius.Name = "txtCelsius"
        txtCelsius.Size = New Size(125, 27)
        txtCelsius.TabIndex = 1
        ' 
        ' txtKg
        ' 
        txtKg.Location = New Point(98, 103)
        txtKg.Name = "txtKg"
        txtKg.Size = New Size(125, 27)
        txtKg.TabIndex = 2
        ' 
        ' txtLb
        ' 
        txtLb.Location = New Point(326, 107)
        txtLb.Name = "txtLb"
        txtLb.Size = New Size(125, 27)
        txtLb.TabIndex = 3
        ' 
        ' txtG
        ' 
        txtG.Location = New Point(102, 169)
        txtG.Name = "txtG"
        txtG.Size = New Size(125, 27)
        txtG.TabIndex = 4
        ' 
        ' txtOz
        ' 
        txtOz.Location = New Point(326, 166)
        txtOz.Name = "txtOz"
        txtOz.Size = New Size(125, 27)
        txtOz.TabIndex = 5
        ' 
        ' txtLiter
        ' 
        txtLiter.Location = New Point(98, 215)
        txtLiter.Name = "txtLiter"
        txtLiter.Size = New Size(125, 27)
        txtLiter.TabIndex = 6
        ' 
        ' txtGallon
        ' 
        txtGallon.Location = New Point(326, 215)
        txtGallon.Name = "txtGallon"
        txtGallon.Size = New Size(125, 27)
        txtGallon.TabIndex = 7
        ' 
        ' txtCups
        ' 
        txtCups.Location = New Point(102, 263)
        txtCups.Name = "txtCups"
        txtCups.Size = New Size(125, 27)
        txtCups.TabIndex = 8
        ' 
        ' txtTablespoon
        ' 
        txtTablespoon.Location = New Point(326, 263)
        txtTablespoon.Name = "txtTablespoon"
        txtTablespoon.Size = New Size(125, 27)
        txtTablespoon.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 20)
        Label1.TabIndex = 10
        Label1.Text = "Fahrenheit:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(62, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(30, 20)
        Label2.TabIndex = 11
        Label2.Text = "KG:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(35, 169)
        Label3.Name = "Label3"
        Label3.Size = New Size(22, 20)
        Label3.TabIndex = 12
        Label3.Text = "G:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(35, 215)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 20)
        Label4.TabIndex = 13
        Label4.Text = "Liter:"
        ' 
        ' le
        ' 
        le.AutoSize = True
        le.Location = New Point(39, 263)
        le.Name = "le"
        le.Size = New Size(44, 20)
        le.TabIndex = 14
        le.Text = "Cups:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(263, 166)
        Label6.Name = "Label6"
        Label6.Size = New Size(32, 20)
        Label6.TabIndex = 15
        Label6.Text = "OZ:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(263, 59)
        Label7.Name = "Label7"
        Label7.Size = New Size(57, 20)
        Label7.TabIndex = 16
        Label7.Text = "Celsius:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(280, 110)
        Label8.Name = "Label8"
        Label8.Size = New Size(28, 20)
        Label8.TabIndex = 17
        Label8.Text = "LB:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(263, 215)
        Label9.Name = "Label9"
        Label9.Size = New Size(55, 20)
        Label9.TabIndex = 18
        Label9.Text = "Gallon:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(233, 266)
        Label10.Name = "Label10"
        Label10.Size = New Size(88, 20)
        Label10.TabIndex = 19
        Label10.Text = "Tablespoon:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(le)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtTablespoon)
        Controls.Add(txtCups)
        Controls.Add(txtGallon)
        Controls.Add(txtLiter)
        Controls.Add(txtOz)
        Controls.Add(txtG)
        Controls.Add(txtLb)
        Controls.Add(txtKg)
        Controls.Add(txtCelsius)
        Controls.Add(txtFahrenheit)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtFahrenheit As TextBox
    Friend WithEvents txtCelsius As TextBox
    Friend WithEvents txtKg As TextBox
    Friend WithEvents txtLb As TextBox
    Friend WithEvents txtG As TextBox
    Friend WithEvents txtOz As TextBox
    Friend WithEvents txtLiter As TextBox
    Friend WithEvents txtGallon As TextBox
    Friend WithEvents txtCups As TextBox
    Friend WithEvents txtTablespoon As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents le As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label

End Class
