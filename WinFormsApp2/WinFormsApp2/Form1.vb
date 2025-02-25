Public Class Form1


    ' Create dictionary to store exchange rates
    Dim exchangeRates As New Dictionary(Of String, Double) From {
        {"USD", 1.0}, ' US Dollar
        {"EUR", 0.93}, ' Euro
        {"RUB", 78.85}, ' Russian Ruble
        {"MXN", 18.35}, ' Mexican Peso
        {"RSD", 103.25}, ' Serbian Dinar
        {"JPY", 136.5} ' Japanese Yen
    }

        ' Store the symbols for currencies
        Dim currencySymbols As New Dictionary(Of String, String) From {
        {"USD", "$"},
        {"EUR", "€"},
        {"RUB", "₽"},
        {"MXN", "₱"},
        {"RSD", "Дин."},
        {"JPY", "¥"}
    }

        ' Store the flag images for currencies
        Dim currencyFlags As New Dictionary(Of String, String) From {
        {"USD", "flags/usa.png"},
        {"EUR", "flags/europe.png"},
        {"RUB", "flags/russia.png"},
        {"MXN", "flags/mexico.png"},
        {"RSD", "flags/serbia.png"},
        {"JPY", "flags/japan.png"}
    }

        ' Event when currency is selected or value is changed
        Public Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
            Dim fromCurrency As String = cboFromCurrency.SelectedItem.ToString()
            Dim toCurrency As String = cboToCurrency.SelectedItem.ToString()
        Dim amount As Double = Double.Parse(txtAmount.Text)

        ' Calculate the conversion rate
        Dim result As Double = ConvertCurrency(amount, fromCurrency, toCurrency)

        ' Update the result textbox
        txtResult.Text = result.ToString("F2")

        ' Show the symbol of the target currency
        lblCurrencySymbol.Text = currencySymbols(toCurrency)

        ' Update the flag image based on target currency
        picFlag.Image = Image.FromFile(currencyFlags(toCurrency))
    End Sub

        ' Convert currency based on selected rates
        Private Function ConvertCurrency(amount As Double, fromCurrency As String, toCurrency As String) As Double
            Dim fromRate As Double = exchangeRates(fromCurrency)
            Dim toRate As Double = exchangeRates(toCurrency)

            ' Convert the amount into USD first
            Dim amountInUSD As Double = amount / fromRate

            ' Then convert USD to the target currency
            Return amountInUSD * toRate
        End Function

    ' Event to initialize the form and fill combo boxes with currencies
    Public Sub CurrencyConverterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboFromCurrency.Items.AddRange(New String() {"USD", "EUR", "RUB", "MXN", "RSD", "JPY"})
        cboToCurrency.Items.AddRange(New String() {"USD", "EUR", "RUB", "MXN", "RSD", "JPY"})

        ' Default selections
        cboFromCurrency.SelectedIndex = 0
        cboToCurrency.SelectedIndex = 1
    End Sub
End Class

