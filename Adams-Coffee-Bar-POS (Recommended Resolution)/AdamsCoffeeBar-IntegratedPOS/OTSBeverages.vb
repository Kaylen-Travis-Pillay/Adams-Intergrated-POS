Public Class ColdBeverages

    Private Sub btn_Coke330_Click(sender As System.Object, e As System.EventArgs) Handles btn_Coke330.Click
        Dim ProductID As Integer = 16
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

    Private Sub btn_CremeSoda330_Click(sender As System.Object, e As System.EventArgs) Handles btn_CremeSoda330.Click
        Dim ProductID As Integer = 19
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

    Private Sub btn_FantaOrange330_Click(sender As System.Object, e As System.EventArgs) Handles btn_FantaOrange330.Click
        Dim ProductID As Integer = 17
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

    Private Sub btn_FantaGrape330_Click(sender As System.Object, e As System.EventArgs) Handles btn_FantaGrape330.Click
        Dim ProductID As Integer = 18
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

    Private Sub btn_Coke500_Click(sender As System.Object, e As System.EventArgs) Handles btn_Coke500.Click
        Dim ProductID As Integer = 20
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

    Private Sub btn_CremeSoda500_Click(sender As System.Object, e As System.EventArgs) Handles btn_CremeSoda500.Click
        Dim ProductID As Integer = 23
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

    Private Sub btn_FantaOrange500_Click(sender As System.Object, e As System.EventArgs) Handles btn_FantaOrange500.Click
        Dim ProductID As Integer = 21
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

    Private Sub btn_FantaGrape500_Click(sender As System.Object, e As System.EventArgs) Handles btn_FantaGrape500.Click
        Dim ProductID As Integer = 22
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