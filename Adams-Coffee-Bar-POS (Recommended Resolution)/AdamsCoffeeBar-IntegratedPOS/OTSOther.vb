Public Class OTSOther

    Private Sub btn_CheeseSandwich_Click(sender As System.Object, e As System.EventArgs) Handles btn_CheeseSandwich.Click
        Dim ProductID As Integer = 11
        Dim Product_Type As Integer = 2
        Dim OrderdQty As Integer
        If POSForm.AddToOrder(ProductID, Product_Type) Then
            Try
                OrderdQty = InputBox("Enter the quantity")
                If OrderdQty <= 0 Then
                    Throw New Exception
                End If
            Catch w As Exception
                CreateObject("WScript.Shell").Popup("Product has not been added!", 1, "ERROR")
                POSForm.orderMap.Remove(ProductID)
                Return
            End Try
            OffTheShelf_ProductTableAdapter1.FillByProductID(Group3DataSet1.OffTheShelf_Product, ProductID)
            If Group3DataSet1.OffTheShelf_Product.Rows.Count > 0 Then
                POSForm.DataGridView1.Rows.Add(OrderdQty, Group3DataSet1.OffTheShelf_Product.Rows(0).Item(3).ToString(), (Group3DataSet1.OffTheShelf_Product.Rows(0).Item(5) * OrderdQty))
            End If
        End If
    End Sub
End Class