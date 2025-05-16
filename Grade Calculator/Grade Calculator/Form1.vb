Public Class Form1
    Private assessmentGrades As New List(Of Double)
    Private courseworkGrades As New List(Of Double)

    Private Sub btnAddAssessment_Click(sender As Object, e As EventArgs) Handles btnAddAssessment.Click
        If IsNumeric(txtAssessment.Text) Then
            assessmentGrades.Add(Double.Parse(txtAssessment.Text))
            txtAssessment.Clear()
            UpdateGrades()
        End If
    End Sub

    Private Sub btnAddCoursework_Click(sender As Object, e As EventArgs) Handles btnAddCoursework.Click
        If IsNumeric(txtCoursework.Text) Then
            courseworkGrades.Add(Double.Parse(txtCoursework.Text))
            txtCoursework.Clear()
            UpdateGrades()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        assessmentGrades.Clear()
        courseworkGrades.Clear()
        UpdateGrades()
    End Sub

    Private Sub UpdateGrades()
        Dim totalAssessment As Double = assessmentGrades.Sum()
        Dim totalCoursework As Double = courseworkGrades.Sum()
        Dim averageAssessment As Double = If(assessmentGrades.Count > 0, totalAssessment / assessmentGrades.Count, 0)
        Dim averageCoursework As Double = If(courseworkGrades.Count > 0, totalCoursework / courseworkGrades.Count, 0)

        txtAssessmentGrade.Text = averageAssessment.ToString("F2")
        txtCourseworkGrade.Text = averageCoursework.ToString("F2")

        Dim overallGrade As Double = (averageAssessment * 0.8) + (averageCoursework * 0.2)
        txtOverallGrade.Text = overallGrade.ToString("F2")
    End Sub
End Class

