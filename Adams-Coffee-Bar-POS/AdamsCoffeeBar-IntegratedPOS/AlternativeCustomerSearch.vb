Public Class AlternativeCustomerSearch

    Private Sub btn_Search_Click(sender As System.Object, e As System.EventArgs) Handles btn_Search.Click

        CustomerDataGridView.Rows.Clear()
        CustomerTableAdapter1.FillByFirstName(Group3DataSet1.Customer, txtbox_Name.Text)

        If Group3DataSet1.Customer.Rows.Count > 0 Then


            For i As Integer = 1 To (Group3DataSet1.Customer.Rows.Count) Step 1
                Dim CustID As String = Group3DataSet1.Customer.Rows(i - 1).Item(0)
                Dim Fname As String = Group3DataSet1.Customer.Rows(i - 1).Item(1)
                Dim Surname As String = Group3DataSet1.Customer.Rows(i - 1).Item(2)
                Dim Email As String = Group3DataSet1.Customer.Rows(i - 1).Item(3)
                Dim PhoneNo As Integer = Group3DataSet1.Customer.Rows(i - 1).Item(4)
                Dim Address As String = Group3DataSet1.Customer.Rows(i - 1).Item(5)
                Dim City As String = Group3DataSet1.Customer.Rows(i - 1).Item(6)
                Dim AreaCode As String = Group3DataSet1.Customer.Rows(i - 1).Item(7)

                CustomerDataGridView.Rows.Add(CustID, Fname, Surname, Email, PhoneNo, Address, City, AreaCode)

            Next


        Else
            MessageBox.Show("ERROR HERE")
        End If
    End Sub

    Private Sub AlternativeCustomerSearch_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        CustomerDataGridView.ColumnCount = 8
        CustomerDataGridView.Columns(0).Name = "Customer ID"
        CustomerDataGridView.Columns(1).Name = "First Name"
        CustomerDataGridView.Columns(2).Name = "Surname"
        CustomerDataGridView.Columns(3).Name = "Email"
        CustomerDataGridView.Columns(4).Name = "Cell Number"
        CustomerDataGridView.Columns(5).Name = "Address Street"
        CustomerDataGridView.Columns(6).Name = "City"
        CustomerDataGridView.Columns(7).Name = "Area Code"

        'CustomerDataGridView.Columns(0).ReadOnly = True
        'CustomerDataGridView.Columns(2).ReadOnly = True
        'CustomerDataGridView.Columns(3).ReadOnly = True

        'CustomerDataGridView.Columns(0).Visible = False

        
    End Sub

    Private Sub CustomerDataGridView_RowHeaderMouseDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles CustomerDataGridView.RowHeaderMouseDoubleClick
        If Not CustomerDataGridView.Rows(e.RowIndex).Cells(0).Value = Nothing Then

            Dim tempEmail As String = CustomerDataGridView.Rows(e.RowIndex).Cells(3).Value.ToString
            CustomerTableAdapter1.FillByEmail(Group3DataSet1.Customer, tempEmail)

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
                POSForm.customerEmail = tempEmail
                POSForm.btn_checkout.Enabled = False
                POSForm.ExistingCustomerORDERCREATE()
                POSForm.btn_Payment.Enabled = True
                POSForm.btn_ExistingCustomer.Enabled = False
                POSForm.btn_NewCustomer.Enabled = False
            Else

                MessageBox.Show("ERROR: NO SUCH CUSTOMER")

            End If

        End If
        
    End Sub

    
    Private Sub txtbox_Name_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtbox_Name.KeyPress

    End Sub

    Private Sub btn_ViewAllCustomers_Click(sender As System.Object, e As System.EventArgs) Handles btn_ViewAllCustomers.Click
        'CustomerTableAdapter1.
        CustomerDataGridView.Rows.Clear()
        CustomerTableAdapter1.Fill(Group3DataSet1.Customer)

        If Group3DataSet1.Customer.Rows.Count > 0 Then


            For i As Integer = 1 To (Group3DataSet1.Customer.Rows.Count) Step 1
                Dim CustID As String = Group3DataSet1.Customer.Rows(i - 1).Item(0)
                Dim Fname As String = Group3DataSet1.Customer.Rows(i - 1).Item(1)
                Dim Surname As String = Group3DataSet1.Customer.Rows(i - 1).Item(2)
                Dim Email As String = Group3DataSet1.Customer.Rows(i - 1).Item(3)
                Dim PhoneNo As Integer = Group3DataSet1.Customer.Rows(i - 1).Item(4)
                Dim Address As String = Group3DataSet1.Customer.Rows(i - 1).Item(5)
                Dim City As String = Group3DataSet1.Customer.Rows(i - 1).Item(6)
                Dim AreaCode As String = Group3DataSet1.Customer.Rows(i - 1).Item(7)

                CustomerDataGridView.Rows.Add(CustID, Fname, Surname, Email, PhoneNo, Address, City, AreaCode)

            Next


        Else
            MessageBox.Show("ERROR HERE")
        End If
    End Sub
End Class