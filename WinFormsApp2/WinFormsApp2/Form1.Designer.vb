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
        cboFromCurrency = New ComboBox()
        txtAmount = New TextBox()
        picFlag = New PictureBox()
        cboToCurrency = New ComboBox()
        txtResult = New TextBox()
        btnconvert = New Button()
        lblCurrencySymbol = New TextBox()
        CType(picFlag, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cboFromCurrency
        ' 
        cboFromCurrency.FormattingEnabled = True
        cboFromCurrency.Location = New Point(543, 60)
        cboFromCurrency.Name = "cboFromCurrency"
        cboFromCurrency.Size = New Size(151, 28)
        cboFromCurrency.TabIndex = 0
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(385, 72)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(125, 27)
        txtAmount.TabIndex = 1
        ' 
        ' picFlag
        ' 
        picFlag.Location = New Point(182, 60)
        picFlag.Name = "picFlag"
        picFlag.Size = New Size(117, 75)
        picFlag.SizeMode = PictureBoxSizeMode.StretchImage
        picFlag.TabIndex = 3
        picFlag.TabStop = False
        ' 
        ' cboToCurrency
        ' 
        cboToCurrency.FormattingEnabled = True
        cboToCurrency.Location = New Point(543, 103)
        cboToCurrency.Name = "cboToCurrency"
        cboToCurrency.Size = New Size(151, 28)
        cboToCurrency.TabIndex = 4
        ' 
        ' txtResult
        ' 
        txtResult.Location = New Point(385, 105)
        txtResult.Name = "txtResult"
        txtResult.ReadOnly = True
        txtResult.Size = New Size(125, 27)
        txtResult.TabIndex = 5
        ' 
        ' btnconvert
        ' 
        btnconvert.Location = New Point(567, 175)
        btnconvert.Name = "btnconvert"
        btnconvert.Size = New Size(94, 29)
        btnconvert.TabIndex = 6
        btnconvert.Text = "Convert!"
        btnconvert.UseVisualStyleBackColor = True
        ' 
        ' lblCurrencySymbol
        ' 
        lblCurrencySymbol.Location = New Point(326, 105)
        lblCurrencySymbol.Name = "lblCurrencySymbol"
        lblCurrencySymbol.ReadOnly = True
        lblCurrencySymbol.Size = New Size(53, 27)
        lblCurrencySymbol.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblCurrencySymbol)
        Controls.Add(btnconvert)
        Controls.Add(txtResult)
        Controls.Add(cboToCurrency)
        Controls.Add(picFlag)
        Controls.Add(txtAmount)
        Controls.Add(cboFromCurrency)
        Name = "Form1"
        Text = "Form1"
        CType(picFlag, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cboFromCurrency As ComboBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents picFlag As PictureBox
    Friend WithEvents cboToCurrency As ComboBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents btnconvert As Button
    Friend WithEvents lblCurrencySymbol As TextBox

End Class
