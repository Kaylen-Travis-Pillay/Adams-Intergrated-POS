Public Class CashOrCard

    Private Sub btn_Cash_Click(sender As System.Object, e As System.EventArgs) Handles btn_Cash.Click
        Cash.Show()
    End Sub

    Private Sub btn_Card_Click(sender As System.Object, e As System.EventArgs) Handles btn_Card.Click
        CreateObject("WScript.Shell").Popup("Card Machine is processing your payment", 1, "Processing")
        POSForm.btn_checkout.Enabled = True
        POSForm.btn_Payment.Enabled = False
        Me.Close()

    End Sub
End Class