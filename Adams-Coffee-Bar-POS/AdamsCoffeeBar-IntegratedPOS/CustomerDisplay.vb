Public Class CustomerDisplay

    Dim displayOrdersList As New List(Of Integer)

    Public Sub populateCurrentlyBeingPrepared()


        Order_TableAdapter1.ClearBeforeFill = True
        Order_TableAdapter1.Fill(Group3DataSet1.Order_)
        Dim isOrderNotComplete As Boolean = False
        Dim isContainedInDisplay As Boolean = False

        'For all the orders in the table adapter'
        If Group3DataSet1.Order_.Rows.Count > 0 Then
            For orders As Integer = 1 To (Group3DataSet1.Order_.Rows.Count) Step 1
                isOrderNotComplete = Group3DataSet1.Order_.Rows(orders - 1).Item(6).ToString = "Not Complete"
                isContainedInDisplay = displayOrdersList.Contains(Group3DataSet1.Order_.Rows(orders - 1).Item(0))

                If isOrderNotComplete And (Not isContainedInDisplay) Then

                    Order_ProductTableAdapter1.FillByFMOrderProduct(Group3DataSet1.Order_Product, Group3DataSet1.Order_.Rows(orders - 1).Item(0))
                    'Create the order display using the custom method'
                    If Group3DataSet1.Order_Product.Rows.Count > 0 Then
                        CreateOrderDisplay_PENDING(Group3DataSet1.Order_.Rows(orders - 1).Item(0))
                        'Add the orderID to the displayOrdersList
                        displayOrdersList.Add(Group3DataSet1.Order_.Rows(orders - 1).Item(0))
                        'Clear the orderListBoxList'

                    End If

                Else

                End If
            Next
        End If
    End Sub

    Private Sub CreateOrderDisplay_PENDING(ByVal orderNumber As Integer)

        Dim orderID As Integer = orderNumber

        Dim fmt As String = "{0,-5}{1,-30}"

        Dim gb_OrderBox As GroupBox = New GroupBox()
        gb_OrderBox.Font = New Font("Ariel", 14, FontStyle.Bold)
        gb_OrderBox.Text = "Order No. " & orderID
        gb_OrderBox.BackColor = Color.AliceBlue
        gb_OrderBox.ForeColor = Color.Black
        gb_OrderBox.Width = 250
        gb_OrderBox.Height = 100


        Dim ProductsListBox As ListBox = New ListBox()
        ProductsListBox.Font = New Font("Ariel", 16)
        ProductsListBox.Name = orderID & "listBox"
        ProductsListBox.Dock = DockStyle.Fill

        With gb_OrderBox.Controls
            .Add(ProductsListBox)
        End With

        ' ProductsListBox.Items.Add("   Name: " & CustomerTableAdapter1.GetDataByCustomerID(Order_TableAdapter1.GetDataByOrderID(orderID).Rows(0).Item(8)).Rows(0).Item(1).ToString())
        'ProductsListBox.Items.Add("Surname: " & CustomerTableAdapter1.GetDataByCustomerID(Order_TableAdapter1.GetDataByOrderID(orderID).Rows(0).Item(8)).Rows(0).Item(2).ToString())

        FlowLayoutPanel1.Controls.Add(gb_OrderBox)
    End Sub

    Private Sub CreateOrderDisplay_COMPLETE(ByVal orderNumber As Integer)
        Dim orderID As Integer = orderNumber

        Dim fmt As String = "{0,-5}{1,-30}"

        Dim gb_OrderBox As GroupBox = New GroupBox()
        gb_OrderBox.Font = New Font("Ariel", 14, FontStyle.Bold)
        gb_OrderBox.Text = "Order No. " & orderID
        gb_OrderBox.BackColor = Color.AliceBlue
        gb_OrderBox.ForeColor = Color.Black
        gb_OrderBox.Width = 100
        gb_OrderBox.Height = 100


        Dim ProductsListBox As ListBox = New ListBox()
        ProductsListBox.Font = New Font("Ariel", 18)
        ProductsListBox.Name = orderID & "listBox"
        ProductsListBox.Dock = DockStyle.Fill

        With gb_OrderBox.Controls
            .Add(ProductsListBox)
        End With

        'ProductsListBox.Items.Add("   Name: " & CustomerTableAdapter1.GetDataByCustomerID(Order_TableAdapter1.GetDataByOrderID(orderID).Rows(0).Item(8)).Rows(0).Item(1).ToString())
        'ProductsListBox.Items.Add("Surname: " & CustomerTableAdapter1.GetDataByCustomerID(Order_TableAdapter1.GetDataByOrderID(orderID).Rows(0).Item(8)).Rows(0).Item(2).ToString())

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Group3DataSet1.Reset()
        TableAdapterManager1.UpdateAll(Group3DataSet1)
        populateCurrentlyBeingPrepared()
        Me.Refresh()

        flushDisplay()
    End Sub

    Private Sub flushDisplay()

        Order_TableAdapter1.ClearBeforeFill = True
        Order_TableAdapter1.Fill(Group3DataSet1.Order_)
        Dim isOrderComplete As Boolean = False
        Dim isContainedInDisplay As Boolean = False

        If Group3DataSet1.Order_.Rows.Count > 0 Then
            For orders As Integer = 1 To (Group3DataSet1.Order_.Rows.Count) Step 1
                isOrderComplete = Group3DataSet1.Order_.Rows(orders - 1).Item(6).ToString = "Complete"
                isContainedInDisplay = displayOrdersList.Contains(Group3DataSet1.Order_.Rows(orders - 1).Item(0))

                If isOrderComplete And (isContainedInDisplay) Then

                    Order_ProductTableAdapter1.FillByFMOrderProduct(Group3DataSet1.Order_Product, Group3DataSet1.Order_.Rows(orders - 1).Item(0))
                    'Create the order display using the custom method'
                    If Group3DataSet1.Order_Product.Rows.Count > 0 Then
                        FlowLayoutPanel1.Controls.Clear()
                        displayOrdersList.Clear()

                    End If

                Else

                End If
            Next
        End If
    End Sub

    Public Sub flushSecondaryDisplay()
        Order_TableAdapter1.ClearBeforeFill = True
        Order_TableAdapter1.Fill(Group3DataSet1.Order_)
        Dim isOrderComplete As Boolean = False
        Dim isContainedInDisplay As Boolean = False

        If Group3DataSet1.Order_.Rows.Count > 0 Then
            For orders As Integer = 1 To (Group3DataSet1.Order_.Rows.Count) Step 1
                isOrderComplete = Group3DataSet1.Order_.Rows(orders - 1).Item(6).ToString = "Complete"
                isContainedInDisplay = displayOrdersList.Contains(Group3DataSet1.Order_.Rows(orders - 1).Item(0))

                If isOrderComplete And (isContainedInDisplay) Then

                    Order_ProductTableAdapter1.FillByFMOrderProduct(Group3DataSet1.Order_Product, Group3DataSet1.Order_.Rows(orders - 1).Item(0))
                    'Create the order display using the custom method'
                    If Group3DataSet1.Order_Product.Rows.Count > 0 Then
                        FlowLayoutPanel1.Controls.Clear()
                        displayOrdersList.Clear()

                    End If

                Else

                End If
            Next
        End If
    End Sub

    Private Sub CustomerDisplay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class