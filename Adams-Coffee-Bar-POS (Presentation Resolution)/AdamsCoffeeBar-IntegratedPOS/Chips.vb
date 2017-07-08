Public Class Chips

    Private Sub btn_LaysSpringOnion_Click(sender As System.Object, e As System.EventArgs) Handles btn_LaysSpringOnion.Click
        Dim ProductID As Integer = 13
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

    Private Sub btn_LaysBalsamicVinegar_Click(sender As System.Object, e As System.EventArgs) Handles btn_LaysBalsamicVinegar.Click
        Dim ProductID As Integer = 28
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

    Private Sub btn_DoritosCheese_Click(sender As System.Object, e As System.EventArgs) Handles btn_DoritosCheese.Click
        Dim ProductID As Integer = 29
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

    Private Sub btn_DoritosSweetChilli_Click(sender As System.Object, e As System.EventArgs) Handles btn_DoritosSweetChilli.Click
        Dim ProductID As Integer = 14
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

    Private Sub btn_NikNaks_Click(sender As System.Object, e As System.EventArgs) Handles btn_NikNaks.Click
        Dim ProductID As Integer = 15
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