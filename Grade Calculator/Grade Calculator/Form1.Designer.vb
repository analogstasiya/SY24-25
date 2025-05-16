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
        txtAssessment = New TextBox()
        txtCoursework = New TextBox()
        txtAssessmentGrade = New TextBox()
        txtCourseworkGrade = New TextBox()
        txtOverallGrade = New TextBox()
        btnAddAssessment = New Button()
        btnAddCoursework = New Button()
        btnClear = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' txtAssessment
        ' 
        txtAssessment.Location = New Point(104, 61)
        txtAssessment.Name = "txtAssessment"
        txtAssessment.Size = New Size(125, 27)
        txtAssessment.TabIndex = 0
        ' 
        ' txtCoursework
        ' 
        txtCoursework.Location = New Point(104, 112)
        txtCoursework.Name = "txtCoursework"
        txtCoursework.Size = New Size(125, 27)
        txtCoursework.TabIndex = 1
        ' 
        ' txtAssessmentGrade
        ' 
        txtAssessmentGrade.Location = New Point(498, 61)
        txtAssessmentGrade.Name = "txtAssessmentGrade"
        txtAssessmentGrade.ReadOnly = True
        txtAssessmentGrade.Size = New Size(125, 27)
        txtAssessmentGrade.TabIndex = 2
        ' 
        ' txtCourseworkGrade
        ' 
        txtCourseworkGrade.Location = New Point(498, 112)
        txtCourseworkGrade.Name = "txtCourseworkGrade"
        txtCourseworkGrade.ReadOnly = True
        txtCourseworkGrade.Size = New Size(125, 27)
        txtCourseworkGrade.TabIndex = 3
        ' 
        ' txtOverallGrade
        ' 
        txtOverallGrade.Location = New Point(498, 164)
        txtOverallGrade.Name = "txtOverallGrade"
        txtOverallGrade.ReadOnly = True
        txtOverallGrade.Size = New Size(125, 27)
        txtOverallGrade.TabIndex = 4
        ' 
        ' btnAddAssessment
        ' 
        btnAddAssessment.Location = New Point(79, 295)
        btnAddAssessment.Name = "btnAddAssessment"
        btnAddAssessment.Size = New Size(139, 29)
        btnAddAssessment.TabIndex = 5
        btnAddAssessment.Text = "Add Assessment"
        btnAddAssessment.UseVisualStyleBackColor = True
        ' 
        ' btnAddCoursework
        ' 
        btnAddCoursework.Location = New Point(259, 295)
        btnAddCoursework.Name = "btnAddCoursework"
        btnAddCoursework.Size = New Size(139, 29)
        btnAddCoursework.TabIndex = 6
        btnAddCoursework.Text = "Add Coursework"
        btnAddCoursework.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(429, 295)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(139, 29)
        btnClear.TabIndex = 7
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(10, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 20)
        Label1.TabIndex = 8
        Label1.Text = "Assessment:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(10, 115)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 20)
        Label2.TabIndex = 9
        Label2.Text = "Coursework:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(337, 68)
        Label3.Name = "Label3"
        Label3.Size = New Size(132, 20)
        Label3.TabIndex = 10
        Label3.Text = "Assessment Grade:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(337, 115)
        Label4.Name = "Label4"
        Label4.Size = New Size(133, 20)
        Label4.TabIndex = 11
        Label4.Text = "Coursework Grade:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(366, 171)
        Label5.Name = "Label5"
        Label5.Size = New Size(103, 20)
        Label5.TabIndex = 12
        Label5.Text = "Overall Grade:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnClear)
        Controls.Add(btnAddCoursework)
        Controls.Add(btnAddAssessment)
        Controls.Add(txtOverallGrade)
        Controls.Add(txtCourseworkGrade)
        Controls.Add(txtAssessmentGrade)
        Controls.Add(txtCoursework)
        Controls.Add(txtAssessment)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtAssessment As TextBox
    Friend WithEvents txtCoursework As TextBox
    Friend WithEvents txtAssessmentGrade As TextBox
    Friend WithEvents txtCourseworkGrade As TextBox
    Friend WithEvents txtOverallGrade As TextBox
    Friend WithEvents btnAddAssessment As Button
    Friend WithEvents btnAddCoursework As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label

End Class
