Public Class FMOther

    Private Sub btn_BeefCurryPie_Click(sender As System.Object, e As System.EventArgs) Handles btn_BeefCurryPie.Click
        Dim ProductID As Integer = 21
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

    Private Sub btn_MuttonCurryPie_Click(sender As System.Object, e As System.EventArgs) Handles btn_MuttonCurryPie.Click
        Dim ProductID As Integer = 22
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

    Private Sub btn_ChickenAndMushroomPie_Click(sender As System.Object, e As System.EventArgs) Handles btn_ChickenAndMushroomPie.Click
        Dim ProductID As Integer = 20
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

    

    
    Private Sub btn_MinceSamoosa_Click(sender As System.Object, e As System.EventArgs) Handles btn_MinceSamoosa.Click
        Dim ProductID As Integer = 13
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

    Private Sub btn_PotatoSamoosa_Click(sender As System.Object, e As System.EventArgs) Handles btn_PotatoSamoosa.Click
        Dim ProductID As Integer = 14
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

    Private Sub btn_ChesseAndSweetcornSamoosa_Click(sender As System.Object, e As System.EventArgs) Handles btn_ChesseAndSweetcornSamoosa.Click
        Dim ProductID As Integer = 15
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

    Private Sub btn_BeefBurger_Click(sender As System.Object, e As System.EventArgs) Handles btn_BeefBurger.Click
        Dim ProductID As Integer = 17
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

    Private Sub btn_CheeseBurger_Click(sender As System.Object, e As System.EventArgs) Handles btn_CheeseBurger.Click
        Dim ProductID As Integer = 18
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

    Private Sub btn_ChickenBurger_Click(sender As System.Object, e As System.EventArgs) Handles btn_ChickenBurger.Click
        Dim ProductID As Integer = 16
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

    Private Sub btn_DoubleChickenBurger_Click(sender As System.Object, e As System.EventArgs) Handles btn_DoubleChickenBurger.Click
        Dim ProductID As Integer = 25
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

    Private Sub btn_DoubleBeefBurger_Click(sender As System.Object, e As System.EventArgs) Handles btn_DoubleBeefBurger.Click
        Dim ProductID As Integer = 27
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

    Private Sub FMOther_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class