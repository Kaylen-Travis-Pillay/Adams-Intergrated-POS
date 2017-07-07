Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class NewCustomerForm

    Dim errorString As String = ""
    Dim con As New SqlConnection

    
    Private Function Check_Customer_Details() As Boolean
        Dim returnbool As Boolean = False
        If txtFirstName.Text.Length > 0 And txtFirstName.Text.Length < 100 Then
            returnbool = True

        Else
            errorString += "The Customers Name must be less than 100 characters! " + Environment.NewLine
            returnbool = False
        End If

        If txtSurname.Text.Length > 0 And txtSurname.Text.Length < 100 Then
            returnbool = True

        Else
            errorString += "The Customers Surname must be less than 100 characters!" + Environment.NewLine
            returnbool = False
        End If

        If txtEmail.Text.Length > 0 And txtEmail.Text.Length < 320 Then
            returnbool = True

        Else
            errorString += "The Customers Email must be less than 320 characters!" + Environment.NewLine
            returnbool = False
        End If

        If (Regex.IsMatch(txtCellNumber.Text, "^[0-9 ]+$")) And txtCellNumber.Text.Length <= 10 Then
            returnbool = True

        Else
            errorString += "The Customers Cell Number must be a number that is less than 11 digits!" + Environment.NewLine
            returnbool = False
        End If

        If txtAddress.Text.Length > 0 And txtAddress.Text.Length < 300 Then
            returnbool = True

        Else
            errorString += "The Customers Address must be less than 300 characters!" + Environment.NewLine
            returnbool = False
        End If


        If (Regex.IsMatch(txtAreaCode.Text, "^[0-9 ]+$")) And txtAreaCode.Text.Length <= 4 Then

            returnbool = True
        Else
            errorString += "The Customers Area Code must be a number that is less than 5 digits!" + Environment.NewLine

            returnbool = False
        End If
        Return returnbool
    End Function

    Private Sub NewCustomerForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=146.230.177.46\ist3;Initial Catalog=group3;Persist Security Info=True;User ID=group3;Password=m7g2k"
    End Sub

    Private Sub Save_Customer_Details_To_Database()
        con.Open()

        Dim cmd As New SqlCommand(("INSERT INTO Customer VALUES('" & txtFirstName.Text & "','" & txtSurname.Text & "','" & txtEmail.Text & "','" & txtCellNumber.Text & "','" & txtAddress.Text & "','" & comboBox_City.Text & "','" & txtAreaCode.Text & "')"), con)

        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Not Check_Customer_Details() Then
            MessageBox.Show(errorString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            errorString = ""
        Else
            Save_Customer_Details_To_Database()
            MessageBox.Show("Customer successfully saved", "Sucess...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            POSForm.lbl_Customer.Text = txtFirstName.Text
            POSForm.Set_Customer_Name(txtFirstName.Text)
            POSForm.customerEmail = txtEmail.Text
            POSForm.btnCancelOrder.Enabled = True
            POSForm.gb_Products.Enabled = True
            POSForm.gb_OffTheShelf.Enabled = True

            POSForm.btn_checkout.Enabled = False
            POSForm.NewCustomerORDERCREATE()
            POSForm.btn_Payment.Enabled = True

            Main_MDIForm.btn_LOGIN.Enabled = False
            Main_MDIForm.btn_LOGOUT.Enabled = False
            Main_MDIForm.btn_KITCHEN.Enabled = False
            Main_MDIForm.btn_MANAGER.Enabled = False
            POSForm.btn_ExistingCustomer.Enabled = False
            POSForm.btn_NewCustomer.Enabled = False
            Me.Close()
        End If
    End Sub

    
    Private Sub comboBox_City_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles comboBox_City.SelectedIndexChanged

    End Sub
End Class