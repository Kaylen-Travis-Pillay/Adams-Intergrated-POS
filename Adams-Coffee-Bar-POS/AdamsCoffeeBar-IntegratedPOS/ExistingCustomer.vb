Public Class ExistingCustomer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CustomerTableAdapter1.FillByEmail(Group3DataSet1.Customer, TextBox1.Text)

        If Group3DataSet1.Customer.Rows.Count > 0 Then
            Me.Close()
            'MessageBox.Show(" Welcome " & Group3DataSet1.Customer.Rows(0).Item(1).ToString)
            POSForm.Set_Customer_Name(Group3DataSet1.Customer.Rows(0).Item(1).ToString)
            POSForm.lbl_Customer.Text = Group3DataSet1.Customer.Rows(0).Item(1).ToString
            POSForm.gb_Products.Enabled = True
            POSForm.gb_OffTheShelf.Enabled = True

            POSForm.btnCancelOrder.Enabled = True
            Main_MDIForm.btn_LOGIN.Enabled = False
            Main_MDIForm.btn_LOGOUT.Enabled = False
            Main_MDIForm.btn_KITCHEN.Enabled = False
            Main_MDIForm.btn_MANAGER.Enabled = False
            POSForm.customerEmail = TextBox1.Text
            POSForm.btn_checkout.Enabled = False
            POSForm.ExistingCustomerORDERCREATE()
            POSForm.btn_Payment.Enabled = True
            POSForm.btn_ExistingCustomer.Enabled = False
            POSForm.btn_NewCustomer.Enabled = False
            TextBox1.Clear()

        Else
            'CreateObject("WScript.Shell").Popup("Your login failed, please try again", 1, "Wrong login details")
            MessageBox.Show("ERROR: NO SUCH EMAIL")
            TextBox1.Clear()
        End If


    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

  
    Private Sub ExistingCustomer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_AlternativeSearch_Click(sender As System.Object, e As System.EventArgs) Handles btn_AlternativeSearch.Click
        AlternativeCustomerSearch.Show()
        Me.Close()
    End Sub
End Class