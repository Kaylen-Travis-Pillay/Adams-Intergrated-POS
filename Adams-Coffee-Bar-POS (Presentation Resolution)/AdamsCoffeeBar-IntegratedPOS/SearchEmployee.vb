Public Class SearchEmployee

    Private Sub SearchEmployee_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        EmpSearch_DataGridView.ColumnCount = 13
        EmpSearch_DataGridView.Columns(0).Name = "EmpID"
        EmpSearch_DataGridView.Columns(1).Name = "First Name"
        EmpSearch_DataGridView.Columns(2).Name = "Surname"
        EmpSearch_DataGridView.Columns(3).Name = "ID Number"
        EmpSearch_DataGridView.Columns(4).Name = "Email"
        EmpSearch_DataGridView.Columns(5).Name = "Cellphone Number"
        EmpSearch_DataGridView.Columns(6).Name = "Street Address"
        EmpSearch_DataGridView.Columns(7).Name = "City"
        EmpSearch_DataGridView.Columns(8).Name = "Area Code"
        EmpSearch_DataGridView.Columns(9).Name = "Hire Date"
        EmpSearch_DataGridView.Columns(10).Name = "Release Date"
        EmpSearch_DataGridView.Columns(11).Name = "Salary"
        EmpSearch_DataGridView.Columns(12).Name = "Job Type"
    End Sub

    Private Sub btn_Search_Click(sender As System.Object, e As System.EventArgs) Handles btn_Search.Click
        EmpSearch_DataGridView.Rows.Clear()
        EmployeeTableAdapter1.FillByFirstName(Group3DataSet1.Employee, txtbox_Name.Text)

        If Group3DataSet1.Employee.Rows.Count > 0 Then


            For i As Integer = 1 To (Group3DataSet1.Employee.Rows.Count) Step 1
                Dim EmpID As Integer = Group3DataSet1.Employee.Rows(i - 1).Item(0)
                Dim Fname As String = Group3DataSet1.Employee.Rows(i - 1).Item(1)
                Dim Surname As String = Group3DataSet1.Employee.Rows(i - 1).Item(2)
                Dim IDNo As Double = Group3DataSet1.Employee.Rows(i - 1).Item(3)
                Dim Email As String = Group3DataSet1.Employee.Rows(i - 1).Item(4)
                Dim PhoneNo As Integer = Group3DataSet1.Employee.Rows(i - 1).Item(5)
                Dim StreetAddr As String = Group3DataSet1.Employee.Rows(i - 1).Item(6)
                Dim City As String = Group3DataSet1.Employee.Rows(i - 1).Item(7)
                Dim AreaCode As Integer = Group3DataSet1.Employee.Rows(i - 1).Item(8)
                Dim HireDate As String = Group3DataSet1.Employee.Rows(i - 1).Item(9)


                Dim ReleaseDate As Object = Group3DataSet1.Employee.Rows(i - 1).Item(10)



                Dim Salary As Integer = Group3DataSet1.Employee.Rows(i - 1).Item(11)
                Dim JobType As Integer = Group3DataSet1.Employee.Rows(i - 1).Item(12)

                EmpSearch_DataGridView.Rows.Add(EmpID, Fname, Surname, IDNo, Email, PhoneNo,
                                                StreetAddr, City, AreaCode, HireDate, ReleaseDate, Salary, JobType)

            Next


        Else
            MessageBox.Show("ERROR HERE")
        End If
    End Sub

    Private Sub btn_Clear_Click(sender As System.Object, e As System.EventArgs)
        EmpSearch_DataGridView.Rows.Clear()
    End Sub
End Class