Public Class Sweets

    Private Sub btn_KitKat_Click(sender As System.Object, e As System.EventArgs) Handles btn_KitKat.Click
        Dim ProductID As Integer = 3
        Dim Product_Type As Integer = 2
        Dim OrderdQty As Integer
        If POSForm.AddToOrder(ProductID, Product_Type) Then
            Try
                OrderdQty = InputBox("Enter the quantity")
                If OrderdQty <= 0 Then
                    Throw New Exception
                End If

                If Not POSForm.ValidProductPurchase(ProductID, , OrderdQty) Then  'For ots use this method POSForm.ValidProductPurchase(ProductID, orderedQTY)
                    CreateObject("WScript.Shell").Popup("Not enough ingredients to make product!", 2, "ERROR")
                    Throw New Exception
                End If


            Catch w As Exception
                CreateObject("WScript.Shell").Popup("Product has not been added!", 1, "ERROR")
                POSForm.orderMap.Remove(ProductID)
                Return
            End Try

            OffTheShelf_ProductTableAdapter1.FillByProductID(Group3DataSet1.OffTheShelf_Product, ProductID)

            If Group3DataSet1.OffTheShelf_Product.Rows.Count > 0 Then
                POSForm.DataGridView1.Rows.Add(ProductID, OrderdQty, Group3DataSet1.OffTheShelf_Product.Rows(0).Item(3).ToString(), (Group3DataSet1.OffTheShelf_Product.Rows(0).Item(5) * OrderdQty))
            End If
        End If
    End Sub

    Private Sub btn_LunchBar_Click(sender As System.Object, e As System.EventArgs) Handles btn_LunchBar.Click
        Dim ProductID As Integer = 5
        Dim Product_Type As Integer = 2
        Dim OrderdQty As Integer
        If POSForm.AddToOrder(ProductID, Product_Type) Then
            Try
                OrderdQty = InputBox("Enter the quantity")
                If OrderdQty <= 0 Then
                    Throw New Exception
                End If

                If Not POSForm.ValidProductPurchase(ProductID, , OrderdQty) Then  'For ots use this method POSForm.ValidProductPurchase(ProductID, orderedQTY)
                    CreateObject("WScript.Shell").Popup("Not enough ingredients to make product!", 2, "ERROR")
                    Throw New Exception
                End If


            Catch w As Exception
                CreateObject("WScript.Shell").Popup("Product has not been added!", 1, "ERROR")
                POSForm.orderMap.Remove(ProductID)
                Return
            End Try

            OffTheShelf_ProductTableAdapter1.FillByProductID(Group3DataSet1.OffTheShelf_Product, ProductID)

            If Group3DataSet1.OffTheShelf_Product.Rows.Count > 0 Then
                POSForm.DataGridView1.Rows.Add(ProductID, OrderdQty, Group3DataSet1.OffTheShelf_Product.Rows(0).Item(3).ToString(), (Group3DataSet1.OffTheShelf_Product.Rows(0).Item(5) * OrderdQty))
            End If
        End If
    End Sub

    Private Sub btn_Niki_Click(sender As System.Object, e As System.EventArgs) Handles btn_Niki.Click
        Dim ProductID As Integer = 8
        Dim Product_Type As Integer = 2
        Dim OrderdQty As Integer
        If POSForm.AddToOrder(ProductID, Product_Type) Then
            Try
                OrderdQty = InputBox("Enter the quantity")
                If OrderdQty <= 0 Then
                    Throw New Exception
                End If

                If Not POSForm.ValidProductPurchase(ProductID, , OrderdQty) Then  'For ots use this method POSForm.ValidProductPurchase(ProductID, orderedQTY)
                    CreateObject("WScript.Shell").Popup("Not enough ingredients to make product!", 2, "ERROR")
                    Throw New Exception
                End If


            Catch w As Exception
                CreateObject("WScript.Shell").Popup("Product has not been added!", 1, "ERROR")
                POSForm.orderMap.Remove(ProductID)
                Return
            End Try

            OffTheShelf_ProductTableAdapter1.FillByProductID(Group3DataSet1.OffTheShelf_Product, ProductID)

            If Group3DataSet1.OffTheShelf_Product.Rows.Count > 0 Then
                POSForm.DataGridView1.Rows.Add(ProductID, OrderdQty, Group3DataSet1.OffTheShelf_Product.Rows(0).Item(3).ToString(), (Group3DataSet1.OffTheShelf_Product.Rows(0).Item(5) * OrderdQty))
            End If
        End If
    End Sub

    Private Sub btn_Tex_Click(sender As System.Object, e As System.EventArgs) Handles btn_Tex.Click
        Dim ProductID As Integer = 6
        Dim Product_Type As Integer = 2
        Dim OrderdQty As Integer
        If POSForm.AddToOrder(ProductID, Product_Type) Then
            Try
                OrderdQty = InputBox("Enter the quantity")
                If OrderdQty <= 0 Then
                    Throw New Exception
                End If

                If Not POSForm.ValidProductPurchase(ProductID, , OrderdQty) Then  'For ots use this method POSForm.ValidProductPurchase(ProductID, orderedQTY)
                    CreateObject("WScript.Shell").Popup("Not enough ingredients to make product!", 2, "ERROR")
                    Throw New Exception
                End If


            Catch w As Exception
                CreateObject("WScript.Shell").Popup("Product has not been added!", 1, "ERROR")
                POSForm.orderMap.Remove(ProductID)
                Return
            End Try

            OffTheShelf_ProductTableAdapter1.FillByProductID(Group3DataSet1.OffTheShelf_Product, ProductID)

            If Group3DataSet1.OffTheShelf_Product.Rows.Count > 0 Then
                POSForm.DataGridView1.Rows.Add(ProductID, OrderdQty, Group3DataSet1.OffTheShelf_Product.Rows(0).Item(3).ToString(), (Group3DataSet1.OffTheShelf_Product.Rows(0).Item(5) * OrderdQty))
            End If
        End If
    End Sub

    Private Sub btn_Nosh_Click(sender As System.Object, e As System.EventArgs) Handles btn_Nosh.Click
        Dim ProductID As Integer = 24
        Dim Product_Type As Integer = 2
        Dim OrderdQty As Integer
        If POSForm.AddToOrder(ProductID, Product_Type) Then
            Try
                OrderdQty = InputBox("Enter the quantity")
                If OrderdQty <= 0 Then
                    Throw New Exception
                End If

                If Not POSForm.ValidProductPurchase(ProductID, , OrderdQty) Then  'For ots use this method POSForm.ValidProductPurchase(ProductID, orderedQTY)
                    CreateObject("WScript.Shell").Popup("Not enough ingredients to make product!", 2, "ERROR")
                    Throw New Exception
                End If


            Catch w As Exception
                CreateObject("WScript.Shell").Popup("Product has not been added!", 1, "ERROR")
                POSForm.orderMap.Remove(ProductID)
                Return
            End Try

            OffTheShelf_ProductTableAdapter1.FillByProductID(Group3DataSet1.OffTheShelf_Product, ProductID)

            If Group3DataSet1.OffTheShelf_Product.Rows.Count > 0 Then
                POSForm.DataGridView1.Rows.Add(ProductID, OrderdQty, Group3DataSet1.OffTheShelf_Product.Rows(0).Item(3).ToString(), (Group3DataSet1.OffTheShelf_Product.Rows(0).Item(5) * OrderdQty))
            End If
        End If
    End Sub

    Private Sub btn_TvBar_Click(sender As System.Object, e As System.EventArgs) Handles btn_TvBar.Click
        Dim ProductID As Integer = 7
        Dim Product_Type As Integer = 2
        Dim OrderdQty As Integer
        If POSForm.AddToOrder(ProductID, Product_Type) Then
            Try
                OrderdQty = InputBox("Enter the quantity")
                If OrderdQty <= 0 Then
                    Throw New Exception
                End If

                If Not POSForm.ValidProductPurchase(ProductID, , OrderdQty) Then  'For ots use this method POSForm.ValidProductPurchase(ProductID, orderedQTY)
                    CreateObject("WScript.Shell").Popup("Not enough ingredients to make product!", 2, "ERROR")
                    Throw New Exception
                End If


            Catch w As Exception
                CreateObject("WScript.Shell").Popup("Product has not been added!", 1, "ERROR")
                POSForm.orderMap.Remove(ProductID)
                Return
            End Try

            OffTheShelf_ProductTableAdapter1.FillByProductID(Group3DataSet1.OffTheShelf_Product, ProductID)

            If Group3DataSet1.OffTheShelf_Product.Rows.Count > 0 Then
                POSForm.DataGridView1.Rows.Add(ProductID, OrderdQty, Group3DataSet1.OffTheShelf_Product.Rows(0).Item(3).ToString(), (Group3DataSet1.OffTheShelf_Product.Rows(0).Item(5) * OrderdQty))
            End If
        End If
    End Sub

    Private Sub btn_Maynards_Click(sender As System.Object, e As System.EventArgs) Handles btn_Maynards.Click
        Dim ProductID As Integer = 2
        Dim Product_Type As Integer = 2
        Dim OrderdQty As Integer
        If POSForm.AddToOrder(ProductID, Product_Type) Then
            Try
                OrderdQty = InputBox("Enter the quantity")
                If OrderdQty <= 0 Then
                    Throw New Exception
                End If

                If Not POSForm.ValidProductPurchase(ProductID, , OrderdQty) Then  'For ots use this method POSForm.ValidProductPurchase(ProductID, orderedQTY)
                    CreateObject("WScript.Shell").Popup("Not enough ingredients to make product!", 2, "ERROR")
                    Throw New Exception
                End If


            Catch w As Exception
                CreateObject("WScript.Shell").Popup("Product has not been added!", 1, "ERROR")
                POSForm.orderMap.Remove(ProductID)
                Return
            End Try

            OffTheShelf_ProductTableAdapter1.FillByProductID(Group3DataSet1.OffTheShelf_Product, ProductID)

            If Group3DataSet1.OffTheShelf_Product.Rows.Count > 0 Then
                POSForm.DataGridView1.Rows.Add(ProductID, OrderdQty, Group3DataSet1.OffTheShelf_Product.Rows(0).Item(3).ToString(), (Group3DataSet1.OffTheShelf_Product.Rows(0).Item(5) * OrderdQty))
            End If
        End If
    End Sub

    Private Sub btn_AllSorts_Click(sender As System.Object, e As System.EventArgs) Handles btn_AllSorts.Click
        Dim ProductID As Integer = 4
        Dim Product_Type As Integer = 2
        Dim OrderdQty As Integer
        If POSForm.AddToOrder(ProductID, Product_Type) Then
            Try
                OrderdQty = InputBox("Enter the quantity")
                If OrderdQty <= 0 Then
                    Throw New Exception
                End If

                If Not POSForm.ValidProductPurchase(ProductID, , OrderdQty) Then  'For ots use this method POSForm.ValidProductPurchase(ProductID, orderedQTY)
                    CreateObject("WScript.Shell").Popup("Not enough ingredients to make product!", 2, "ERROR")
                    Throw New Exception
                End If


            Catch w As Exception
                CreateObject("WScript.Shell").Popup("Product has not been added!", 1, "ERROR")
                POSForm.orderMap.Remove(ProductID)
                Return
            End Try

            OffTheShelf_ProductTableAdapter1.FillByProductID(Group3DataSet1.OffTheShelf_Product, ProductID)

            If Group3DataSet1.OffTheShelf_Product.Rows.Count > 0 Then
                POSForm.DataGridView1.Rows.Add(ProductID, OrderdQty, Group3DataSet1.OffTheShelf_Product.Rows(0).Item(3).ToString(), (Group3DataSet1.OffTheShelf_Product.Rows(0).Item(5) * OrderdQty))
            End If
        End If
    End Sub

    Private Sub btn_MintImperials_Click(sender As System.Object, e As System.EventArgs) Handles btn_MintImperials.Click
        Dim ProductID As Integer = 9
        Dim Product_Type As Integer = 2
        Dim OrderdQty As Integer
        If POSForm.AddToOrder(ProductID, Product_Type) Then
            Try
                OrderdQty = InputBox("Enter the quantity")
                If OrderdQty <= 0 Then
                    Throw New Exception
                End If

                If Not POSForm.ValidProductPurchase(ProductID, , OrderdQty) Then  'For ots use this method POSForm.ValidProductPurchase(ProductID, orderedQTY)
                    CreateObject("WScript.Shell").Popup("Not enough ingredients to make product!", 2, "ERROR")
                    Throw New Exception
                End If


            Catch w As Exception
                CreateObject("WScript.Shell").Popup("Product has not been added!", 1, "ERROR")
                POSForm.orderMap.Remove(ProductID)
                Return
            End Try

            OffTheShelf_ProductTableAdapter1.FillByProductID(Group3DataSet1.OffTheShelf_Product, ProductID)

            If Group3DataSet1.OffTheShelf_Product.Rows.Count > 0 Then
                POSForm.DataGridView1.Rows.Add(ProductID, OrderdQty, Group3DataSet1.OffTheShelf_Product.Rows(0).Item(3).ToString(), (Group3DataSet1.OffTheShelf_Product.Rows(0).Item(5) * OrderdQty))
            End If
        End If
    End Sub

    Private Sub btn_Jennings_Click(sender As System.Object, e As System.EventArgs) Handles btn_Jennings.Click
        Dim ProductID As Integer = 10
        Dim Product_Type As Integer = 2
        Dim OrderdQty As Integer
        If POSForm.AddToOrder(ProductID, Product_Type) Then
            Try
                OrderdQty = InputBox("Enter the quantity")
                If OrderdQty <= 0 Then
                    Throw New Exception
                End If

                If Not POSForm.ValidProductPurchase(ProductID, , OrderdQty) Then  'For ots use this method POSForm.ValidProductPurchase(ProductID, orderedQTY)
                    CreateObject("WScript.Shell").Popup("Not enough ingredients to make product!", 2, "ERROR")
                    Throw New Exception
                End If


            Catch w As Exception
                CreateObject("WScript.Shell").Popup("Product has not been added!", 1, "ERROR")
                POSForm.orderMap.Remove(ProductID)
                Return
            End Try

            OffTheShelf_ProductTableAdapter1.FillByProductID(Group3DataSet1.OffTheShelf_Product, ProductID)

            If Group3DataSet1.OffTheShelf_Product.Rows.Count > 0 Then
                POSForm.DataGridView1.Rows.Add(ProductID, OrderdQty, Group3DataSet1.OffTheShelf_Product.Rows(0).Item(3).ToString(), (Group3DataSet1.OffTheShelf_Product.Rows(0).Item(5) * OrderdQty))
            End If
        End If
    End Sub
End Class