Public Class FMColdBeverages

    Private Sub btn_BGumMilkshake_Click(sender As System.Object, e As System.EventArgs) Handles btn_BGumMilkshake.Click
        Dim ProductID As Integer = 38
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

    Private Sub btn_RberryMilkshake_Click(sender As System.Object, e As System.EventArgs) Handles btn_RberryMilkshake.Click
        Dim ProductID As Integer = 39
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

    Private Sub btn_ColdMilo_Click(sender As System.Object, e As System.EventArgs) Handles btn_ColdMilo.Click
        Dim ProductID As Integer = 45
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

    Private Sub btn_ColdMiloWithCream_Click(sender As System.Object, e As System.EventArgs) Handles btn_ColdMiloWithCream.Click
        Dim ProductID As Integer = 46
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

    Private Sub btn_ColdChocolate_Click(sender As System.Object, e As System.EventArgs) Handles btn_ColdChocolate.Click
        Dim ProductID As Integer = 47
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

    Private Sub btn_ColdChocolateWithCream_Click(sender As System.Object, e As System.EventArgs) Handles btn_ColdChocolateWithCream.Click
        Dim ProductID As Integer = 48
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

    Private Sub btn_IcedCoffee_Click(sender As System.Object, e As System.EventArgs) Handles btn_IcedCoffee.Click
        Dim ProductID As Integer = 40
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

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub
End Class