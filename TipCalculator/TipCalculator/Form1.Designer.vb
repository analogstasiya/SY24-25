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
        fifteenrb = New RadioButton()
        twentyrb = New RadioButton()
        Label1 = New Label()
        tenrb = New RadioButton()
        Label3 = New Label()
        Label2 = New Label()
        AmountTextbox = New TextBox()
        TipTextbox = New TextBox()
        TotalTextbox = New TextBox()
        SuspendLayout()
        ' 
        ' fifteenrb
        ' 
        fifteenrb.AutoSize = True
        fifteenrb.Location = New Point(513, 261)
        fifteenrb.Margin = New Padding(7)
        fifteenrb.Name = "fifteenrb"
        fifteenrb.Size = New Size(105, 50)
        fifteenrb.TabIndex = 1
        fifteenrb.TabStop = True
        fifteenrb.Text = "15%"
        fifteenrb.UseVisualStyleBackColor = True
        ' 
        ' twentyrb
        ' 
        twentyrb.AutoSize = True
        twentyrb.Location = New Point(513, 329)
        twentyrb.Margin = New Padding(7)
        twentyrb.Name = "twentyrb"
        twentyrb.Size = New Size(105, 50)
        twentyrb.TabIndex = 2
        twentyrb.TabStop = True
        twentyrb.Text = "20%"
        twentyrb.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(18, 194)
        Label1.Margin = New Padding(7, 0, 7, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 46)
        Label1.TabIndex = 3
        Label1.Text = "Amount:"
        ' 
        ' tenrb
        ' 
        tenrb.AutoSize = True
        tenrb.Location = New Point(513, 194)
        tenrb.Margin = New Padding(7)
        tenrb.Name = "tenrb"
        tenrb.Size = New Size(105, 50)
        tenrb.TabIndex = 0
        tenrb.TabStop = True
        tenrb.Text = "10%"
        tenrb.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(18, 270)
        Label3.Margin = New Padding(7, 0, 7, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 46)
        Label3.TabIndex = 4
        Label3.Text = "Tip:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(18, 338)
        Label2.Margin = New Padding(7, 0, 7, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 46)
        Label2.TabIndex = 5
        Label2.Text = "Total:"
        ' 
        ' AmountTextbox
        ' 
        AmountTextbox.Location = New Point(178, 187)
        AmountTextbox.Margin = New Padding(7)
        AmountTextbox.Name = "AmountTextbox"
        AmountTextbox.Size = New Size(276, 51)
        AmountTextbox.TabIndex = 6
        ' 
        ' TipTextbox
        ' 
        TipTextbox.Location = New Point(178, 263)
        TipTextbox.Margin = New Padding(7)
        TipTextbox.Name = "TipTextbox"
        TipTextbox.ReadOnly = True
        TipTextbox.Size = New Size(276, 51)
        TipTextbox.TabIndex = 7
        ' 
        ' TotalTextbox
        ' 
        TotalTextbox.Location = New Point(178, 338)
        TotalTextbox.Margin = New Padding(7)
        TotalTextbox.Name = "TotalTextbox"
        TotalTextbox.ReadOnly = True
        TotalTextbox.Size = New Size(276, 51)
        TotalTextbox.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(18F, 45F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1332, 766)
        Controls.Add(TotalTextbox)
        Controls.Add(TipTextbox)
        Controls.Add(AmountTextbox)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(twentyrb)
        Controls.Add(tenrb)
        Controls.Add(fifteenrb)
        Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(7)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents fifteenrb As RadioButton
    Friend WithEvents twentyrb As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents tenrb As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AmountTextbox As TextBox
    Friend WithEvents TipTextbox As TextBox
    Friend WithEvents TotalTextbox As TextBox

End Class
