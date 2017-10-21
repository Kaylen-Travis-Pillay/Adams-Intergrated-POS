Public Class HelpForm

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim webAddress As String = "http://www.ktpsolutions.co.za/"
        Process.Start(webAddress)
    End Sub
End Class