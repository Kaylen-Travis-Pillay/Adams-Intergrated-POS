Imports System.Drawing.Printing

Public Class POSForm

    Dim customer As String
    Public orderMap As New Dictionary(Of Integer, Integer)
    Public orderId As Integer
    Public customerId As Integer
    Public customerEmail As String
    Public employeeId As Integer
    Dim tempQuantity As Integer

    Public Function AddToOrder(ByVal ProductID As Integer, ByVal ProductType As Integer) As Boolean
        If Not orderMap.ContainsKey(ProductID) Then
            orderMap.Add(ProductID, ProductType)
            Return True
        Else
            MessageBox.Show("Already added to the order list")
            Return False
        End If
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub btn_NewCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_NewCustomer.Click
        NewCustomerForm.ShowDialog()

    End Sub

    Public Sub FormSetUp(ByVal ChildForm As Form)
        Try
            If Not (ChildForm.Equals(Me.ActiveMdiChild)) Then
                Me.ActiveMdiChild.Close()
            End If
        Catch ex As Exception
        End Try
        With ChildForm
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub btn_ExistingCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExistingCustomer.Click

        ExistingCustomer.ShowDialog()
        
    End Sub

    Public Sub Set_Customer_Name(ByVal e As String)
        customer = e
    End Sub

    Private Sub PrintRecieptForMrMpilo()
        Dim printer As New myPrinter
        Dim reciept As String = ""

        reciept += "                                                ADAMS COFFEE BAR                             " & vbNewLine
        reciept += "                                        Developed by NeuroSolutions (2017)" & vbNewLine
        reciept += "Cashier: " & Main_MDIForm.lbl_LOGGINAS.Text
        reciept += "                                " & Now.Date.ToString("dd MMM yyyy")
        reciept += "                                       " & Format(Now, "HH:mm:ss")
        reciept += vbNewLine & vbNewLine

        For i As Integer = 0 To (DataGridView1.Rows.Count - 2) Step 1
            Dim values() As Object = {DataGridView1.Rows(i).Cells(2).Value.ToString, "(" & DataGridView1.Rows(i).Cells(1).Value.ToString & "@ R" & (DataGridView1.Rows(i).Cells(3).Value / DataGridView1.Rows(i).Cells(1).Value).ToString & ")", "R" & DataGridView1.Rows(i).Cells(3).Value.ToString}
            Dim output As String = String.Format("{0,-50} {1,-50} {2:N2}", values)

            reciept += output & vbNewLine
        Next

        reciept += vbNewLine & vbNewLine
        reciept += Order_TableAdapter1.GetDataByOrderID(orderId).Rows(0).Item(1).ToString & " Items" & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "Total    R" & Order_TableAdapter1.GetDataByOrderID(orderId).Rows(0).Item(2).ToString + vbNewLine

        reciept += vbNewLine & vbNewLine & "                                          ORDER NUMBER:  " & orderId
        printer.PRINT(reciept)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Sandwitch.ShowDialog()
    End Sub

    Private Sub POSForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DataGridView1.ColumnCount = 4
        DataGridView1.Columns(0).Name = "PID"
        DataGridView1.Columns(1).Name = "Quantity"
        DataGridView1.Columns(2).Name = "Product Name"
        DataGridView1.Columns(3).Name = "Price"

        DataGridView1.Columns(0).ReadOnly = True
        DataGridView1.Columns(2).ReadOnly = True
        DataGridView1.Columns(3).ReadOnly = True

        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(3).DefaultCellStyle.Format = "C2"

        gb_Products.Enabled = False
        gb_OffTheShelf.Enabled = False
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)
        For Each kvp As KeyValuePair(Of Integer, Integer) In orderMap
            MessageBox.Show(kvp.Key, kvp.Value)
        Next
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs)
        NextCustomerButtonClick()
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged

        Try
            If (CInt(DataGridView1.Rows(e.RowIndex).Cells(1).Value)) <= 0 Then
                Throw New Exception
            End If


            Dim unitCost As Integer = 0

            If orderMap(CInt(DataGridView1.Rows(e.RowIndex).Cells(0).Value)) = 2 Then
                If ValidProductPurchase(CInt(DataGridView1.Rows(e.RowIndex).Cells(0).Value), , CInt(DataGridView1.Rows(e.RowIndex).Cells(1).Value)) Then
                    unitCost = OffTheShelf_ProductTableAdapter1.GetDataByProductID(CInt(DataGridView1.Rows(e.RowIndex).Cells(0).Value)).Rows(0).Item(5)

                Else
                    MessageBox.Show("Not enough ingrediants to complete this order!")
                    DataGridView1.Rows(e.RowIndex).Cells(1).Value = tempQuantity
                End If

            Else
                If ValidProductPurchase(CInt(DataGridView1.Rows(e.RowIndex).Cells(0).Value), 1) Then
                    unitCost = FreshlyMade_ProductTableAdapter1.GetDataByProductID(CInt(DataGridView1.Rows(e.RowIndex).Cells(0).Value)).Rows(0).Item(3)
                Else
                    MessageBox.Show("Not enough ingrediants to complete this order!")
                    DataGridView1.Rows(e.RowIndex).Cells(1).Value = tempQuantity
                End If

            End If

            DataGridView1.Rows(e.RowIndex).Cells(3).Value = unitCost * CInt(DataGridView1.Rows(e.RowIndex).Cells(1).Value)

        Catch ex As Exception
            MessageBox.Show("Invalid Quantity entered", "ERROR")
            DataGridView1.Rows(e.RowIndex).Cells(1).Value = tempQuantity
        End Try

    End Sub

    Public Function ValidProductPurchase(ByVal ProductID As Integer, Optional ByVal ProductType As Integer = -1, Optional ByVal OrderedQty As Integer = 0) As Boolean
        Dim returnBool As Boolean = True
        If ProductType = 1 Then
            'Freshly Made Product'
            FreshlyMadeProduct_IngredientTableAdapter1.FillByProductID(Group3DataSet1.FreshlyMadeProduct_Ingredient, ProductID)

            If Group3DataSet1.FreshlyMadeProduct_Ingredient.Rows.Count > 0 Then
                For i As Integer = 0 To Group3DataSet1.FreshlyMadeProduct_Ingredient.Rows.Count - 1 Step 1
                    Dim ingredientID As Integer = Group3DataSet1.FreshlyMadeProduct_Ingredient.Rows(i).Item(1)
                    Dim currentQTY As Integer = IngredientTableAdapter1.GetIngrediant(ingredientID).Rows(0).Item(2)
                    Dim RecepieQTY As Integer = Group3DataSet1.FreshlyMadeProduct_Ingredient.Rows(i).Item(2)

                    If RecepieQTY > currentQTY Then
                        returnBool = False

                    End If
                Next



            Else
                returnBool = False
            End If

            Return returnBool
        Else
            'Off The shelf products'
            OffTheShelf_ProductTableAdapter1.FillByProductID(Group3DataSet1.OffTheShelf_Product, ProductID)

            If Group3DataSet1.OffTheShelf_Product.Rows.Count > 0 Then
                If (OrderedQty > Group3DataSet1.OffTheShelf_Product.Rows(0).Item(2)) Then
                    returnBool = False
                Else
                    returnBool = True
                End If
            Else
                returnBool = False
            End If
        End If
        Return returnBool
    End Function

    Private Sub btnCancelOrder_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelOrder.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to cancel the order ?", "WARNING!", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Order_TableAdapter1.DeleteOrderByOrderID(orderId)
            'MessageBox.Show("Order Has Been Cancelled!", "Order Cancelled")
            CreateObject("WScript.Shell").Popup("Order Has Been Cancelled", 2, "Order Cancelled")
            NextCustomerButtonClick()
            btn_checkout.Enabled = False
            btn_ExistingCustomer.Enabled = True
            btn_NewCustomer.Enabled = True

            Dim employeeType As Integer = EmployeeTableAdapter1.GetDataByEmpID(Main_MDIForm.employeeID).Rows(0).Item(12)

            If employeeType = 3 Then
                Main_MDIForm.btn_LOGIN.Enabled = True
                Main_MDIForm.btn_LOGOUT.Enabled = True
                Main_MDIForm.btn_KITCHEN.Enabled = True
                Main_MDIForm.btn_MANAGER.Enabled = True
            Else
                Main_MDIForm.btn_LOGOUT.Enabled = True

            End If
        End If

    End Sub

    Private Sub btn_checkout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_checkout.Click
        If orderMap.Count > 0 Then
            Dim totalOrderPrice As Double = 0
            For i As Integer = 0 To (DataGridView1.RowCount - 2) Step 1
                Dim productID As Integer = DataGridView1.Rows(i).Cells(0).Value
                Dim orderedQTY As Integer = DataGridView1.Rows(i).Cells(1).Value
                Dim productType As Integer = orderMap(DataGridView1.Rows(i).Cells(0).Value)
                Dim totalCost As Double = DataGridView1.Rows(i).Cells(3).Value

                'Increase total cost'
                totalOrderPrice += totalCost

                'Decrease stock for the product'
                DecreaseInventory(productID, productType, orderedQTY)

                'Create order_product (AKA order line!)'
                CreateOrderProduct(productID, orderedQTY, totalCost, productType)

                'Update the customers order!'

                AddOrderLineToOrder(orderedQTY, totalCost)


            Next

            MessageBox.Show("Order has been made!", "ORDER MADE")


            'Display for the reciept'

            Dim result As Integer = MessageBox.Show("Would you like to print a reciept?", "ATT: Print Reciept", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                PrintRecieptForMrMpilo()
            End If

            NextCustomerButtonClick()
            btn_checkout.Enabled = False
            btn_ExistingCustomer.Enabled = True
            btn_NewCustomer.Enabled = True


            Dim employeeType As Integer = EmployeeTableAdapter1.GetDataByEmpID(Main_MDIForm.employeeID).Rows(0).Item(12)

            If employeeType = 3 Then
                Main_MDIForm.btn_LOGIN.Enabled = True
                Main_MDIForm.btn_LOGOUT.Enabled = True
                Main_MDIForm.btn_KITCHEN.Enabled = True
                Main_MDIForm.btn_MANAGER.Enabled = True
            Else
                Main_MDIForm.btn_LOGOUT.Enabled = True

            End If
        Else
            MessageBox.Show("No items added to the order! Checkout failed", "CHECKOUT ERROR")
        End If
    End Sub

    Public Sub DecreaseInventory(ByVal productID As Integer, ByVal productType As Integer, ByVal orderedQTY As Integer)
        If productType = 1 Then
            FreshlyMadeProduct_IngredientTableAdapter1.FillByProductID(Group3DataSet1.FreshlyMadeProduct_Ingredient, productID)

            If Group3DataSet1.FreshlyMadeProduct_Ingredient.Rows.Count > 0 Then
                For i As Integer = 0 To Group3DataSet1.FreshlyMadeProduct_Ingredient.Rows.Count - 1 Step 1
                    Dim ingredientID As Integer = Group3DataSet1.FreshlyMadeProduct_Ingredient.Rows(i).Item(1)
                    Dim currentIngrediantQTY As Integer = IngredientTableAdapter1.GetIngrediant(ingredientID).Rows(0).Item(2)
                    Dim RecepieQTY As Integer = Group3DataSet1.FreshlyMadeProduct_Ingredient.Rows(i).Item(2)

                    IngredientTableAdapter1.UpdateInventoryQTY(currentIngrediantQTY - (RecepieQTY * orderedQTY), ingredientID, ingredientID)
                Next

            End If
        Else
            OffTheShelf_ProductTableAdapter1.FillByProductID(Group3DataSet1.OffTheShelf_Product, productID)

            If Group3DataSet1.OffTheShelf_Product.Rows.Count > 0 Then
                Dim currentQTY As Integer = OffTheShelf_ProductTableAdapter1.GetDataByProductID(productID).Rows(0).Item(2)
                OffTheShelf_ProductTableAdapter1.UpdateOTSInventory(currentQTY - orderedQTY, productID, productID)
            End If
        End If
    End Sub

    Public Sub CreateOrderProduct(ByVal productID As Integer, ByVal orderedQTY As Integer, ByVal totalPrice As Double, ByVal productType As Integer)
        If productType = 1 Then
            'Freshly made product'
            Order_ProductTableAdapter1.InsertOrderProduct(orderId, productID, Nothing, orderedQTY, totalPrice, productType)
        Else
            Order_ProductTableAdapter1.InsertOrderProduct(orderId, Nothing, productID, orderedQTY, totalPrice, productType)
        End If

    End Sub

    Public Sub AddOrderLineToOrder(ByVal orderedQTY As Integer, ByVal totalCost As Double)
        Dim currentOrderQTY As Integer = Order_TableAdapter1.GetDataByOrderID(orderId).Rows(0).Item(1)
        Dim currentTotalPrice As Double = Order_TableAdapter1.GetDataByOrderID(orderId).Rows(0).Item(2)

        If Not isOrderOnlyOTF() Then
            Order_TableAdapter1.UpdateOrderWithOrderLine(currentOrderQTY + orderedQTY, currentTotalPrice + totalCost, orderId, orderId)
        Else
            Dim this_time As String = Now.TimeOfDay.ToString
            Order_TableAdapter1.AddOrderLineToOrderOTF(currentOrderQTY + orderedQTY, currentTotalPrice + totalCost, "Complete", this_time, orderId, orderId)

        End If


    End Sub

    Public Sub NextCustomerButtonClick()
        lbl_Customer.Text = ""
        gb_Products.Enabled = False
        gb_OffTheShelf.Enabled = False
        btnCancelOrder.Enabled = False
        DataGridView1.Rows.Clear()
        orderMap.Clear()
        btn_checkout.Enabled = True
    End Sub

    Public Sub ExistingCustomerORDERCREATE()
        'Create default order'
        Dim this_date As String = Now.Date.ToString
        Dim this_time As String = Now.TimeOfDay.ToString

        'Getting the customers Id'
        customerId = CustomerTableAdapter1.GetDataByEmail(customerEmail).Rows(0).Item(0)

        Order_TableAdapter1.makeNewOrder(0, 0, this_date, this_time, "0", "Not Complete", Main_MDIForm.employeeID, customerId) '''''''
        orderId = Order_TableAdapter1.GetDataByDateTimeCustID(this_date, this_time, customerId).Rows(0).Item(0)
    End Sub

    Public Sub NewCustomerORDERCREATE()

        'Create default order'
        Dim this_date As String = Now.Date.ToString
        Dim this_time As String = Now.TimeOfDay.ToString

        'Getting the customers Id'
        customerId = CustomerTableAdapter1.GetDataByEmail(customerEmail).Rows(0).Item(0)

        Order_TableAdapter1.makeNewOrder(0, 0, this_date, this_time, "0", "Not Complete", Main_MDIForm.employeeID, customerId)
        orderId = Order_TableAdapter1.GetDataByDateTimeCustID(this_date, this_time, customerId).Rows(0).Item(0)
    End Sub


    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        ColdBeverages.ShowDialog()
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Sweets.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        FMOther.ShowDialog()
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        HotBeverages1.ShowDialog()
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        FMColdBeverages.ShowDialog()
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Chips.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        BakedEats.ShowDialog()
    End Sub

    Private Sub Button6_Click_1(sender As System.Object, e As System.EventArgs)
        OTSOther.ShowDialog()
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click

    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Dim totalCost As Double = 0
        For i As Integer = 0 To (DataGridView1.RowCount - 2) Step 1
            totalCost += DataGridView1.Rows(i).Cells(3).Value
        Next
        lbl_Lable.Text = totalCost
    End Sub

    Private Sub btn_Payment_Click(sender As System.Object, e As System.EventArgs) Handles btn_Payment.Click
        If orderMap.Count < 1 Then
            MessageBox.Show("No items added to the order! Payment failed", "PAYMENT ERROR")
        Else
            CashOrCard.Show()
        End If
    End Sub

    Public Function isOrderOnlyOTF() As Boolean
        Dim counter As Integer = 0

        For Each i As KeyValuePair(Of Integer, Integer) In orderMap
            If orderMap(i.Key) = 2 Then
                counter += 1
            End If
        Next

        If counter = orderMap.Count Then
            Return True
        Else
            Return False
        End If


    End Function

    Private Sub DataGridView1_RowHeaderMouseDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseDoubleClick
        Dim result As Integer = MessageBox.Show("Do you want to delete this order line?", "WARNING", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            orderMap.Remove(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
            DataGridView1.Rows.RemoveAt(e.RowIndex)
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        tempQuantity = DataGridView1.Rows(e.RowIndex).Cells(1).Value
    End Sub

    
End Class

Public Class myPrinter
    Friend TextToBePrinted As String
    Public Sub PRINT(ByVal text As String)
        TextToBePrinted = text
        Dim prn As New Printing.PrintDocument
        Using (prn)
            prn.PrinterSettings.PrinterName = "Microsoft Print to PDF"
            AddHandler prn.PrintPage, AddressOf Me.PrintPageHandler
            prn.Print()
            RemoveHandler prn.PrintPage, AddressOf Me.PrintPageHandler
        End Using
    End Sub

    Private Sub PrintPageHandler(ByVal sender As Object, ByVal args As Printing.PrintPageEventArgs)
        Dim myFont As New Font("Microsoft San Serif", 10)
        args.Graphics.DrawString(TextToBePrinted, New Font(myFont, FontStyle.Regular), Brushes.Black, 50, 50)
    End Sub
End Class