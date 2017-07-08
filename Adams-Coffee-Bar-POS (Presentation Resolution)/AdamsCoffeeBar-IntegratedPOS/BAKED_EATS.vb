Public Class BakedEats

    Private Sub BakedEats_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
   
   

   
    Private Sub btn_BaroneCakeSlice_Click(sender As System.Object, e As System.EventArgs) Handles btn_BaroneCakeSlice.Click
        Dim ProductID As Integer = 50
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

    Private Sub btn_RedVelvetCakeSlice_Click(sender As System.Object, e As System.EventArgs) Handles btn_RedVelvetCakeSlice.Click
        Dim ProductID As Integer = 49
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

    Private Sub btn_BBerryMuffin_Click(sender As System.Object, e As System.EventArgs) Handles btn_BBerryMuffin.Click
        Dim ProductID As Integer = 53
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

    Private Sub btn_ChocChipMuffin_Click(sender As System.Object, e As System.EventArgs) Handles btn_ChocChipMuffin.Click
        Dim ProductID As Integer = 54
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

    Private Sub btn_Scone_Click(sender As System.Object, e As System.EventArgs) Handles btn_Scone.Click
        Dim ProductID As Integer = 51
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

    Private Sub btn_SconeWithCream_Click(sender As System.Object, e As System.EventArgs) Handles btn_SconeWithCream.Click
        Dim ProductID As Integer = 52
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