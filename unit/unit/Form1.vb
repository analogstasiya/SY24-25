
Public Class Form1
        Private Sub txtFahrenheit_TextChanged(sender As Object, e As EventArgs) Handles txtFahrenheit.TextChanged
            ConvertFahrenheitToCelsius()
        End Sub

        Private Sub txtCelsius_TextChanged(sender As Object, e As EventArgs) Handles txtCelsius.TextChanged
            ConvertCelsiusToFahrenheit()
        End Sub

        Private Sub txtKg_TextChanged(sender As Object, e As EventArgs) Handles txtKg.TextChanged
            ConvertKgToLb()
        End Sub

        Private Sub txtLb_TextChanged(sender As Object, e As EventArgs) Handles txtLb.TextChanged
            ConvertLbToKg()
        End Sub

        Private Sub txtG_TextChanged(sender As Object, e As EventArgs) Handles txtG.TextChanged
            ConvertGToOz()
        End Sub

        Private Sub txtOz_TextChanged(sender As Object, e As EventArgs) Handles txtOz.TextChanged
            ConvertOzToG()
        End Sub

        Private Sub txtLiter_TextChanged(sender As Object, e As EventArgs) Handles txtLiter.TextChanged
            ConvertLiterToGallon()
        End Sub

        Private Sub txtGallon_TextChanged(sender As Object, e As EventArgs) Handles txtGallon.TextChanged
            ConvertGallonToLiter()
        End Sub

        Private Sub txtCups_TextChanged(sender As Object, e As EventArgs) Handles txtCups.TextChanged
            ConvertCupsToTablespoon()
        End Sub

        Private Sub txtTablespoon_TextChanged(sender As Object, e As EventArgs) Handles txtTablespoon.TextChanged
            ConvertTablespoonToCups()
        End Sub

        Private Sub ConvertFahrenheitToCelsius()
            If IsNumeric(txtFahrenheit.Text) Then
                Dim fahrenheit As Double = Double.Parse(txtFahrenheit.Text)
                Dim celsius As Double = (fahrenheit - 32) * 5 / 9
                txtCelsius.Text = celsius.ToString("F2")
            End If
        End Sub

        Private Sub ConvertCelsiusToFahrenheit()
            If IsNumeric(txtCelsius.Text) Then
                Dim celsius As Double = Double.Parse(txtCelsius.Text)
                Dim fahrenheit As Double = (celsius * 9 / 5) + 32
                txtFahrenheit.Text = fahrenheit.ToString("F2")
            End If
        End Sub

        Private Sub ConvertKgToLb()
            If IsNumeric(txtKg.Text) Then
                Dim kg As Double = Double.Parse(txtKg.Text)
                Dim lb As Double = kg * 2.20462
                txtLb.Text = lb.ToString("F2")
            End If
        End Sub

        Private Sub ConvertLbToKg()
            If IsNumeric(txtLb.Text) Then
                Dim lb As Double = Double.Parse(txtLb.Text)
                Dim kg As Double = lb / 2.20462
                txtKg.Text = kg.ToString("F2")
            End If
        End Sub

        Private Sub ConvertGToOz()
            If IsNumeric(txtG.Text) Then
                Dim g As Double = Double.Parse(txtG.Text)
                Dim oz As Double = g / 28.3495
                txtOz.Text = oz.ToString("F2")
            End If
        End Sub

        Private Sub ConvertOzToG()
            If IsNumeric(txtOz.Text) Then
                Dim oz As Double = Double.Parse(txtOz.Text)
                Dim g As Double = oz * 28.3495
                txtG.Text = g.ToString("F2")
            End If
        End Sub

        Private Sub ConvertLiterToGallon()
            If IsNumeric(txtLiter.Text) Then
                Dim liter As Double = Double.Parse(txtLiter.Text)
                Dim gallon As Double = liter / 3.78541
                txtGallon.Text = gallon.ToString("F2")
            End If
        End Sub

        Private Sub ConvertGallonToLiter()
            If IsNumeric(txtGallon.Text) Then
                Dim gallon As Double = Double.Parse(txtGallon.Text)
                Dim liter As Double = gallon * 3.78541
                txtLiter.Text = liter.ToString("F2")
            End If
        End Sub

        Private Sub ConvertCupsToTablespoon()
            If IsNumeric(txtCups.Text) Then
                Dim cups As Double = Double.Parse(txtCups.Text)
                Dim tablespoon As Double = cups * 16
                txtTablespoon.Text = tablespoon.ToString("F2")
            End If
        End Sub

        Private Sub ConvertTablespoonToCups()
            If IsNumeric(txtTablespoon.Text) Then
                Dim tablespoon As Double = Double.Parse(txtTablespoon.Text)
                Dim cups As Double = tablespoon / 16
                txtCups.Text = cups.ToString("F2")
            End If
        End Sub
End Class