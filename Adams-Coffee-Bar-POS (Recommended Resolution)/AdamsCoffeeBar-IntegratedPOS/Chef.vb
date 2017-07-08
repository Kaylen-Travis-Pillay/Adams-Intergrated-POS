Public Class Chef

    Dim displayOrdersList As New List(Of Integer)
    Dim orderListBoxList As New List(Of String)
    Dim repopulateBool As Boolean = False

    Private Sub markcomp_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim orderID As Button = DirectCast(sender, Button)

        Dim this_time As String = Now.TimeOfDay.ToString


        Order_TableAdapter1.UpdateCompletionStatus("Complete", this_time, orderID.Name, orderID.Name)
        Order_TableAdapter1.Fill(Group3DataSet1.Order_)
        displayOrdersList.Clear()
        FlowLayoutPanel1.Controls.Clear()
    End Sub

    Private Sub PopulateDisplay()

        Try

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

                        Dim orderline As Integer = 1

                        For orderline = 1 To (Group3DataSet1.Order_Product.Rows.Count) Step 1
                            Dim quantity As Integer = Group3DataSet1.Order_Product.Rows(orderline - 1).Item(4)
                            Dim productDecription As String = FreshlyMade_ProductTableAdapter1.GetDataByProductID(Group3DataSet1.Order_Product.Rows(orderline - 1).Item(2)).Rows(0).Item(4)

                            orderListBoxList.Add(quantity & "x " & productDecription)
                        Next

                        'Create the order display using the custom method'
                        If Group3DataSet1.Order_Product.Rows.Count > 0 Then
                            CreateOrderDisplay(Group3DataSet1.Order_.Rows(orders - 1).Item(0), orderListBoxList)
                            'Add the orderID to the displayOrdersList
                            displayOrdersList.Add(Group3DataSet1.Order_.Rows(orders - 1).Item(0))
                            'Clear the orderListBoxList'
                            orderListBoxList.Clear()

                            repopulateBool = True
                        End If

                    Else

                    End If

                    orderListBoxList.Clear()

                Next
            End If
        Catch e As Exception
            Timer1.Enabled = False
            MessageBox.Show("Connection to the server has been lost, please seek admin help", "ERROR", MessageBoxButtons.OK)
            Me.Close()
        End Try

    End Sub

    Private Sub CreateOrderDisplay(ByVal orderNumber As Integer, ByVal orderstringlist As List(Of String))

        Dim orderID As Integer = orderNumber

        Dim fmt As String = "{0,-5}{1,-30}"

        Dim gb_OrderBox As GroupBox = New GroupBox()
        gb_OrderBox.Font = New Font("Ariel", 14, FontStyle.Bold)
        gb_OrderBox.Text = "FM Order No. " & orderID
        gb_OrderBox.BackColor = Color.AliceBlue
        gb_OrderBox.ForeColor = Color.Black
        gb_OrderBox.Width = 300
        gb_OrderBox.Height = 250

        Dim btn_orderComplete As Button = New Button()

        btn_orderComplete.Font = New Font("Ariel", 12, FontStyle.Bold)
        btn_orderComplete.Name = orderID
        btn_orderComplete.Text = "Order Complete"
        btn_orderComplete.AutoSize = True
        btn_orderComplete.Dock = DockStyle.Bottom
        btn_orderComplete.BackColor = Color.Green
        btn_orderComplete.ForeColor = Color.AliceBlue
        AddHandler btn_orderComplete.Click, AddressOf markcomp_Click

        Dim ProductsListBox As ListBox = New ListBox()
        ProductsListBox.Font = New Font("Ariel", 12)
        ProductsListBox.Name = orderID & "listBox"
        ProductsListBox.Dock = DockStyle.Fill

        With gb_OrderBox.Controls
            .Add(ProductsListBox)
            .Add(btn_orderComplete)
        End With

        For i As Integer = 1 To (orderstringlist.Count) Step 1
            ProductsListBox.Items.Add(orderstringlist.Item(i - 1))
        Next

        FlowLayoutPanel1.Controls.Add(gb_OrderBox)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Group3DataSet1.Reset()
        TableAdapterManager1.UpdateAll(Group3DataSet1)
        PopulateDisplay()
        Me.Refresh()


    End Sub

    Private Sub Chef_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateDisplay()
        Timer1.Enabled = True
    End Sub
End Class