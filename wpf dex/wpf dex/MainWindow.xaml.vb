Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        englandimg.Visibility = Visibility.Visible
        desertimg.Visibility = Visibility.Hidden
        nclb1.Visibility = Visibility.Visible
        nclb2.Visibility = Visibility.Visible
        nclb3.Visibility = Visibility.Visible
        nclb4.Visibility = Visibility.Visible
        dclb1.Visibility = Visibility.Hidden
        dclb2.Visibility = Visibility.Hidden
        dclb3.Visibility = Visibility.Hidden
        dclb4.Visibility = Visibility.Hidden
        mrlb1.Visibility = Visibility.Hidden
        mrlb2.Visibility = Visibility.Hidden
        mrlb3.Visibility = Visibility.Hidden
        mrlb4.Visibility = Visibility.Hidden
        marshimg.Visibility = Visibility.Hidden
    End Sub

    Private Sub a(sender As Object, e As RoutedEventArgs)
        desertimg.Visibility = Visibility.Visible
        dclb1.Visibility = Visibility.Visible
        dclb2.Visibility = Visibility.Visible
        dclb3.Visibility = Visibility.Visible
        dclb4.Visibility = Visibility.Visible
        englandimg.Visibility = Visibility.Hidden
        nclb1.Visibility = Visibility.Hidden
        nclb2.Visibility = Visibility.Hidden
        nclb3.Visibility = Visibility.Hidden
        nclb4.Visibility = Visibility.Hidden
        mrlb1.Visibility = Visibility.Hidden
        mrlb2.Visibility = Visibility.Hidden
        mrlb3.Visibility = Visibility.Hidden
        mrlb4.Visibility = Visibility.Hidden
        englandimg.Visibility = Visibility.Hidden
        marshimg.Visibility = Visibility.Hidden
    End Sub

    Private Sub b(sender As Object, e As RoutedEventArgs)
        marshimg.Visibility = Visibility.Visible
        mrlb1.Visibility = Visibility.Visible
        mrlb2.Visibility = Visibility.Visible
        mrlb3.Visibility = Visibility.Visible
        mrlb4.Visibility = Visibility.Visible
        nclb1.Visibility = Visibility.Hidden
        nclb2.Visibility = Visibility.Hidden
        nclb3.Visibility = Visibility.Hidden
        nclb3.Visibility = Visibility.Hidden
        dclb1.Visibility = Visibility.Hidden
        dclb2.Visibility = Visibility.Hidden
        dclb3.Visibility = Visibility.Hidden
        dclb4.Visibility = Visibility.Hidden
        desertimg.Visibility = Visibility.Hidden
        englandimg.Visibility = Visibility.Hidden
    End Sub
End Class
