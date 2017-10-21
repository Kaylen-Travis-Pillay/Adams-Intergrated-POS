Public Class FreshlyMadeDynamicButtons
    Private Sub CreateDisplayButtons(ByVal productID As Integer, ByVal productName As String)

        Dim btn_orderComplete As Button = New Button()

        btn_orderComplete.Font = New Font("Ariel", 12, FontStyle.Bold)
        btn_orderComplete.Name = productID
        btn_orderComplete.Text = productName
        btn_orderComplete.Width = 207
        btn_orderComplete.Height = 95
        btn_orderComplete.BackColor = Color.Aqua
        btn_orderComplete.ForeColor = Color.Black
        AddHandler btn_orderComplete.Click, AddressOf markcomp_Click

        FlowLayoutPanel1.Controls.Add(btn_orderComplete)
    End Sub

    Private Sub markcomp_Click(sender As Object, e As EventArgs)
        Dim buttonPressed As Button = DirectCast(sender, Button)

        Dim ProductID As Integer = CInt(buttonPressed.Name)
        Dim Product_Type As Integer = 1
        Dim OrderdQty As Integer

        If POSForm.AddToOrder(ProductID, Product_Type) Then

            Try
                OrderdQty = InputBox("Enter the quantity")

                If OrderdQty <= 0 Then
                    CreateObject("WScript.Shell").Popup("Invalid Quantity Entered", 2, "ERROR")
                    Throw New Exception
                End If

                'This code MPILO'
                If Not POSForm.ValidProductPurchase(ProductID, 1, OrderdQty) Then  'For ots use this method POSForm.ValidProductPurchase(ProductID, orderedQTY)
                    CreateObject("WScript.Shell").Popup("Not enough ingredients to make product!", 2, "ERROR")
                    Throw New Exception
                End If

            Catch w As Exception
                CreateObject("WScript.Shell").Popup("Invalid Quantity Entered", 2, "ERROR")
                POSForm.orderMap.Remove(ProductID)
                Return
            End Try



            FreshlyMade_ProductTableAdapter1.FillByFMProductID(Group3DataSet1.FreshlyMade_Product, ProductID)


            'Add Product ID for all the buttons
            If Group3DataSet1.FreshlyMade_Product.Rows.Count > 0 Then
                POSForm.DataGridView1.Rows.Add(ProductID, OrderdQty, Group3DataSet1.FreshlyMade_Product.Rows(0).Item(4).ToString(), (Group3DataSet1.FreshlyMade_Product.Rows(0).Item(3) * OrderdQty))
            End If

        End If


    End Sub

    Private Sub populate()
        FreshlyMade_ProductTableAdapter1.FillByA(Group3DataSet1.FreshlyMade_Product)

        For i As Integer = 0 To Group3DataSet1.FreshlyMade_Product.Rows.Count - 1 Step 1
            Dim id As String = Group3DataSet1.FreshlyMade_Product.Rows(i).Item(0).ToString()
            Dim name As String = Group3DataSet1.FreshlyMade_Product.Rows(i).Item(4).ToString()

            CreateDisplayButtons(id, name)
        Next

    End Sub

    Private Sub FreshlyMadeDynamicButtons_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        populate()
    End Sub
End Class