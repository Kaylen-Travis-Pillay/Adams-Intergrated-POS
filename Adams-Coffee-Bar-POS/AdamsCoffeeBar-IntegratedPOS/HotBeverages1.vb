Public Class HotBeverages1

    
    Private Sub btn_FilterCoffee_Click(sender As System.Object, e As System.EventArgs) Handles btn_FilterCoffee.Click
        Dim ProductID As Integer = 30
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
                If Not POSForm.ValidProductPurchase(ProductID, 1) Then  'For ots use this method POSForm.ValidProductPurchase(ProductID, orderedQTY)
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

    Private Sub btn_SingleExpresso_Click(sender As System.Object, e As System.EventArgs) Handles btn_SingleExpresso.Click
        Dim ProductID As Integer = 31
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
                If Not POSForm.ValidProductPurchase(ProductID, 1) Then  'For ots use this method POSForm.ValidProductPurchase(ProductID, orderedQTY)
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

    Private Sub btn_DoubleExpresso_Click(sender As System.Object, e As System.EventArgs) Handles btn_DoubleExpresso.Click
        Dim ProductID As Integer = 32
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
                If Not POSForm.ValidProductPurchase(ProductID, 1) Then  'For ots use this method POSForm.ValidProductPurchase(ProductID, orderedQTY)
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

    Private Sub btn_Cappuccino_Click(sender As System.Object, e As System.EventArgs) Handles btn_Cappuccino.Click
        Dim ProductID As Integer = 33
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
                If Not POSForm.ValidProductPurchase(ProductID, 1) Then  'For ots use this method POSForm.ValidProductPurchase(ProductID, orderedQTY)
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

    Private Sub btn_CappuccinoWithCream_Click(sender As System.Object, e As System.EventArgs) Handles btn_CappuccinoWithCream.Click
        Dim ProductID As Integer = 34
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
                If Not POSForm.ValidProductPurchase(ProductID, 1) Then  'For ots use this method POSForm.ValidProductPurchase(ProductID, orderedQTY)
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

    Private Sub btn_HotMilo_Click(sender As System.Object, e As System.EventArgs) Handles btn_HotMilo.Click
        Dim ProductID As Integer = 43
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
                If Not POSForm.ValidProductPurchase(ProductID, 1) Then  'For ots use this method POSForm.ValidProductPurchase(ProductID, orderedQTY)
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

    Private Sub btn_HotChocolate_Click(sender As System.Object, e As System.EventArgs) Handles btn_HotChocolate.Click
        Dim ProductID As Integer = 28
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
                If Not POSForm.ValidProductPurchase(ProductID, 1) Then  'For ots use this method POSForm.ValidProductPurchase(ProductID, orderedQTY)
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

    Private Sub btn_HotChocolateWithCream_Click(sender As System.Object, e As System.EventArgs) Handles btn_HotChocolateWithCream.Click
        Dim ProductID As Integer = 29
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
                If Not POSForm.ValidProductPurchase(ProductID, 1) Then  'For ots use this method POSForm.ValidProductPurchase(ProductID, orderedQTY)
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

    Private Sub btn_EarlGreyTea_Click(sender As System.Object, e As System.EventArgs) Handles btn_EarlGreyTea.Click
        Dim ProductID As Integer = 35
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
                If Not POSForm.ValidProductPurchase(ProductID, 1) Then  'For ots use this method POSForm.ValidProductPurchase(ProductID, orderedQTY)
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

    Private Sub btn_RooibosTea_Click(sender As System.Object, e As System.EventArgs) Handles btn_RooibosTea.Click
        Dim ProductID As Integer = 36
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
                If Not POSForm.ValidProductPurchase(ProductID, 1) Then  'For ots use this method POSForm.ValidProductPurchase(ProductID, orderedQTY)
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

    Private Sub btn_FiveRosesTea_Click(sender As System.Object, e As System.EventArgs) Handles btn_FiveRosesTea.Click
        Dim ProductID As Integer = 37
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
                If Not POSForm.ValidProductPurchase(ProductID, 1) Then  'For ots use this method POSForm.ValidProductPurchase(ProductID, orderedQTY)
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
End Class