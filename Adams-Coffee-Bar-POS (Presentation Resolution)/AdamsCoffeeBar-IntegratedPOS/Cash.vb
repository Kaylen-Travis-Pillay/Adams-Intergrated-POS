Public Class Cash
    Public amtDue As Double = CDbl(POSForm.lbl_Lable.Text)
    Public totalGiven As Double = 0
    Public change As Double = 0
    Dim PaymentFlag As Boolean = False
    Private Sub Cash_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lbl_AmountDue.Text = "R" & POSForm.lbl_Lable.Text
        change = totalGiven - amtDue

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        lbl_AmountGiven.Text = "R" & totalGiven.ToString
        change = totalGiven - amtDue
    End Sub

    Private Sub btn_R200_Click(sender As System.Object, e As System.EventArgs) Handles btn_R200.Click
        totalGiven += 200
    End Sub

    Private Sub btn_R100_Click(sender As System.Object, e As System.EventArgs) Handles btn_R100.Click
        totalGiven += 100
    End Sub

    Private Sub btn_R50_Click(sender As System.Object, e As System.EventArgs) Handles btn_R50.Click
        totalGiven += 50
    End Sub

    Private Sub btn_R20_Click(sender As System.Object, e As System.EventArgs) Handles btn_R20.Click
        totalGiven += 20
    End Sub

    Private Sub btn_R10_Click(sender As System.Object, e As System.EventArgs) Handles btn_R10.Click
        totalGiven += 10
    End Sub

    Private Sub btn_R5_Click(sender As System.Object, e As System.EventArgs) Handles btn_R5.Click
        totalGiven += 5
    End Sub

    Private Sub btn_R2_Click(sender As System.Object, e As System.EventArgs) Handles btn_R2.Click
        totalGiven += 2
    End Sub

    Private Sub btn_R1_Click(sender As System.Object, e As System.EventArgs) Handles btn_R1.Click
        totalGiven += 1
    End Sub

    Private Sub btn_CalcChange_Click(sender As System.Object, e As System.EventArgs) Handles btn_CalcChange.Click
        If change < 0 Then
            PaymentFlag = False
            MessageBox.Show("Insufficient funds given!" & " Amount is R" & (change * -1) & " short.")

        ElseIf change = amtDue Then
            PaymentFlag = True
            MessageBox.Show("No change")
        Else
            PaymentFlag = True
            MessageBox.Show("Change is: R" & change)

        End If

    End Sub

    Private Sub btn_Clear_Click(sender As System.Object, e As System.EventArgs) Handles btn_Clear.Click
        totalGiven = 0
        lbl_AmountGiven.Text = "R" & totalGiven
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        If PaymentFlag Then
            btn_OK.Enabled = True
            btn_CalcChange.Enabled = False

        Else
            btn_OK.Enabled = False
        End If
    End Sub

    Private Sub btn_Back_Click(sender As System.Object, e As System.EventArgs) Handles btn_Back.Click
        Me.Close()

    End Sub

    Private Sub btn_OK_Click(sender As System.Object, e As System.EventArgs) Handles btn_OK.Click
        Me.Close()
        CashOrCard.Close()
        POSForm.btn_Payment.Enabled = False

        POSForm.btn_checkout.Enabled = True



    End Sub
End Class