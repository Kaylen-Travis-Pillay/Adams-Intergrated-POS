Public Class Login

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtbx_Password.UseSystemPasswordChar = Not CheckBox2.Checked
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtbx_Password.UseSystemPasswordChar = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            EmployeeTableAdapter1.FillByEmployeeLogin(Group3DataSet1.Employee, txtbx_Username.Text, txtbx_Password.Text)

            If (Group3DataSet1.Employee.Rows.Count > 0) Then

                Me.Close()
                Main_MDIForm.SetEmployeeName(Group3DataSet1.Employee.Rows(0).Item(1).ToString)
                Main_MDIForm.SetEmployeeType(Group3DataSet1.Employee.Rows(0).Item(12))

                Main_MDIForm.employeeID = Group3DataSet1.Employee.Rows(0).Item(0)

                If Main_MDIForm.GetEmployeeType() = 1 Then
                    Main_MDIForm.btn_LOGIN.Enabled = False
                    Main_MDIForm.btn_KITCHEN.Enabled = False
                    Main_MDIForm.btn_MANAGER.Enabled = False

                    Main_MDIForm.btn_POS.Enabled = True
                    Main_MDIForm.btn_CALLMANAGER.Enabled = True

                    Main_MDIForm.lbl_CURRENTSTATUS.Text = "CASHIER"
                    Main_MDIForm.SetEmployeeTpeString("CASHIER")
                    Main_MDIForm.lbl_LOGGINAS.Text = Group3DataSet1.Employee.Rows(0).Item(1).ToString().ToUpper

                ElseIf Main_MDIForm.GetEmployeeType() = 2 Then
                    Main_MDIForm.btn_LOGIN.Enabled = False
                    Main_MDIForm.btn_MANAGER.Enabled = False
                    Main_MDIForm.btn_POS.Enabled = False

                    Main_MDIForm.btn_CALLMANAGER.Enabled = True
                    Main_MDIForm.btn_KITCHEN.Enabled = True

                    Main_MDIForm.lbl_CURRENTSTATUS.Text = "CHEF"
                    Main_MDIForm.SetEmployeeTpeString("CHEF")
                    Main_MDIForm.lbl_LOGGINAS.Text = Group3DataSet1.Employee.Rows(0).Item(1).ToString().ToUpper

                ElseIf Main_MDIForm.GetEmployeeType() = 3 Then
                    Main_MDIForm.btn_LOGIN.Enabled = True
                    Main_MDIForm.btn_POS.Enabled = True
                    Main_MDIForm.btn_KITCHEN.Enabled = True
                    Main_MDIForm.btn_CALLMANAGER.Enabled = False

                    Main_MDIForm.btn_MANAGER.Enabled = True

                    Main_MDIForm.lbl_CURRENTSTATUS.Text = "MANAGER"
                    Main_MDIForm.SetEmployeeTpeString("MANAGER")
                    Main_MDIForm.lbl_LOGGINAS.Text = Group3DataSet1.Employee.Rows(0).Item(1).ToString().ToUpper
                End If
                'MessageBox.Show("Successful login, Welcome " & Group3DataSet1.Employee.Rows(0).Item(1).ToString)
                CreateObject("WScript.Shell").Popup("Welcome " & Group3DataSet1.Employee.Rows(0).Item(1).ToString, 1, "Successful login")
                txtbx_Password.Clear()
                txtbx_Username.Clear()
                POSForm.btn_checkout.Enabled = False
                POSForm.btn_Payment.Enabled = False
                'MessageBox.Show(Main_MDIForm.employeeID)

            Else

                'Remeber to make this message better
                CreateObject("WScript.Shell").Popup("Your login failed, please try again", 1, "Wrong login details")
                txtbx_Password.Clear()


            End If
        Catch z As Exception

        End Try
    End Sub

    Private Sub txtbx_Password_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtbx_Password.KeyPress
        Try
            If (e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return)) Then

                EmployeeTableAdapter1.FillByEmployeeLogin(Group3DataSet1.Employee, txtbx_Username.Text, txtbx_Password.Text)

                If (Group3DataSet1.Employee.Rows.Count > 0) Then

                    Me.Close()
                    Main_MDIForm.SetEmployeeName(Group3DataSet1.Employee.Rows(0).Item(1).ToString)
                    Main_MDIForm.SetEmployeeType(Group3DataSet1.Employee.Rows(0).Item(12))

                    Main_MDIForm.employeeID = Group3DataSet1.Employee.Rows(0).Item(0)

                    If Main_MDIForm.GetEmployeeType() = 1 Then
                        Main_MDIForm.btn_LOGIN.Enabled = False
                        Main_MDIForm.btn_KITCHEN.Enabled = False
                        Main_MDIForm.btn_MANAGER.Enabled = False

                        Main_MDIForm.btn_POS.Enabled = True
                        Main_MDIForm.btn_CALLMANAGER.Enabled = True

                        Main_MDIForm.lbl_CURRENTSTATUS.Text = "CASHIER"
                        Main_MDIForm.SetEmployeeTpeString("CASHIER")
                        Main_MDIForm.lbl_LOGGINAS.Text = Group3DataSet1.Employee.Rows(0).Item(1).ToString().ToUpper

                    ElseIf Main_MDIForm.GetEmployeeType() = 2 Then
                        Main_MDIForm.btn_LOGIN.Enabled = False
                        Main_MDIForm.btn_MANAGER.Enabled = False
                        Main_MDIForm.btn_POS.Enabled = False

                        Main_MDIForm.btn_CALLMANAGER.Enabled = True
                        Main_MDIForm.btn_KITCHEN.Enabled = True

                        Main_MDIForm.lbl_CURRENTSTATUS.Text = "CHEF"
                        Main_MDIForm.SetEmployeeTpeString("CHEF")
                        Main_MDIForm.lbl_LOGGINAS.Text = Group3DataSet1.Employee.Rows(0).Item(1).ToString().ToUpper

                    ElseIf Main_MDIForm.GetEmployeeType() = 3 Then
                        Main_MDIForm.btn_LOGIN.Enabled = True
                        Main_MDIForm.btn_POS.Enabled = True
                        Main_MDIForm.btn_KITCHEN.Enabled = True
                        Main_MDIForm.btn_CALLMANAGER.Enabled = False

                        Main_MDIForm.btn_MANAGER.Enabled = True

                        Main_MDIForm.lbl_CURRENTSTATUS.Text = "MANAGER"
                        Main_MDIForm.SetEmployeeTpeString("MANAGER")
                        Main_MDIForm.lbl_LOGGINAS.Text = Group3DataSet1.Employee.Rows(0).Item(1).ToString().ToUpper
                    End If
                    'MessageBox.Show("Successful login, Welcome " & Group3DataSet1.Employee.Rows(0).Item(1).ToString)
                    CreateObject("WScript.Shell").Popup("Welcome " & Group3DataSet1.Employee.Rows(0).Item(1).ToString, 1, "Successful login")
                    txtbx_Password.Clear()
                    txtbx_Username.Clear()
                    POSForm.btn_checkout.Enabled = False
                    POSForm.btn_Payment.Enabled = False
                    'MessageBox.Show(Main_MDIForm.employeeID)

                Else
                    If (Group3DataSet1.Employee.Rows(0).Item(10) <> Nothing) Then
                        MessageBox.Show("Login details are no longer valid", "ERROR: LOGIN FAILED")
                        txtbx_Password.Clear()
                    Else
                        'Remeber to make this message better
                        CreateObject("WScript.Shell").Popup("Your login failed, please try again", 1, "Wrong login details")
                        txtbx_Password.Clear()
                    End If

                End If
            End If

        Catch z As Exception

        End Try
    End Sub

    Private Sub Login_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        
    End Sub
End Class