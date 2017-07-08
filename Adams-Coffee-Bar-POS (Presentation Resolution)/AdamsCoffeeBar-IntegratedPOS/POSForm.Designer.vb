<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class POSForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gb_Products = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btn_NewCustomer = New System.Windows.Forms.Button()
        Me.btn_ExistingCustomer = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_Customer = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OffTheShelf_ProductTableAdapter1 = New AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.OffTheShelf_ProductTableAdapter()
        Me.Group3DataSet1 = New AdamsCoffeeBar_IntegratedPOS.group3DataSet()
        Me.FreshlyMade_ProductTableAdapter1 = New AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.FreshlyMade_ProductTableAdapter()
        Me.FreshlyMadeProduct_IngredientTableAdapter1 = New AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.FreshlyMadeProduct_IngredientTableAdapter()
        Me.IngredientTableAdapter1 = New AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.IngredientTableAdapter()
        Me.CustomerTableAdapter1 = New AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.CustomerTableAdapter()
        Me.Order_TableAdapter1 = New AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.Order_TableAdapter()
        Me.btnCancelOrder = New System.Windows.Forms.Button()
        Me.btn_checkout = New System.Windows.Forms.Button()
        Me.Order_ProductTableAdapter1 = New AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.Order_ProductTableAdapter()
        Me.gb_OffTheShelf = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_Lable = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_Payment = New System.Windows.Forms.Button()
        Me.EmployeeTableAdapter1 = New AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.EmployeeTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.gb_Products.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group3DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_OffTheShelf.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(1442, 9)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(152, 75)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Current Time"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 39)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "00:00:00"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(540, 55)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Adam's Coffee Bar POS"
        '
        'gb_Products
        '
        Me.gb_Products.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_Products.Controls.Add(Me.GroupBox2)
        Me.gb_Products.Controls.Add(Me.GroupBox3)
        Me.gb_Products.Location = New System.Drawing.Point(448, 78)
        Me.gb_Products.Margin = New System.Windows.Forms.Padding(2)
        Me.gb_Products.Name = "gb_Products"
        Me.gb_Products.Padding = New System.Windows.Forms.Padding(2)
        Me.gb_Products.Size = New System.Drawing.Size(440, 206)
        Me.gb_Products.TabIndex = 10
        Me.gb_Products.TabStop = False
        Me.gb_Products.Text = "Freshly Made Products"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button11)
        Me.GroupBox2.Controls.Add(Me.Button10)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 110)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(403, 75)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Beverage"
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button11.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button11.Location = New System.Drawing.Point(243, 17)
        Me.Button11.Margin = New System.Windows.Forms.Padding(2)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(92, 36)
        Me.Button11.TabIndex = 28
        Me.Button11.Text = "COLD BEVERAGES"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Button10.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button10.Location = New System.Drawing.Point(84, 17)
        Me.Button10.Margin = New System.Windows.Forms.Padding(2)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(93, 36)
        Me.Button10.TabIndex = 27
        Me.Button10.Text = "HOT BEVERAGES"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 17)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(403, 89)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Food"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Salmon
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Location = New System.Drawing.Point(152, 33)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 39)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "BAKED EATS"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.PeachPuff
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Location = New System.Drawing.Point(273, 33)
        Me.Button5.Margin = New System.Windows.Forms.Padding(2)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(104, 39)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "OTHER"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.PeachPuff
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(28, 33)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 39)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "SANDWICH"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btn_NewCustomer
        '
        Me.btn_NewCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_NewCustomer.BackColor = System.Drawing.Color.Gold
        Me.btn_NewCustomer.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btn_NewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_NewCustomer.Location = New System.Drawing.Point(38, 468)
        Me.btn_NewCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_NewCustomer.Name = "btn_NewCustomer"
        Me.btn_NewCustomer.Size = New System.Drawing.Size(122, 50)
        Me.btn_NewCustomer.TabIndex = 11
        Me.btn_NewCustomer.Text = "NEW CUSTOMER"
        Me.btn_NewCustomer.UseVisualStyleBackColor = False
        '
        'btn_ExistingCustomer
        '
        Me.btn_ExistingCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_ExistingCustomer.BackColor = System.Drawing.Color.Gold
        Me.btn_ExistingCustomer.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btn_ExistingCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_ExistingCustomer.Location = New System.Drawing.Point(229, 468)
        Me.btn_ExistingCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_ExistingCustomer.Name = "btn_ExistingCustomer"
        Me.btn_ExistingCustomer.Size = New System.Drawing.Size(132, 50)
        Me.btn_ExistingCustomer.TabIndex = 12
        Me.btn_ExistingCustomer.Text = "EXISTING CUSTOMER"
        Me.btn_ExistingCustomer.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 63)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(272, 31)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Current Customer is: "
        '
        'lbl_Customer
        '
        Me.lbl_Customer.AutoSize = True
        Me.lbl_Customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Customer.Location = New System.Drawing.Point(259, 63)
        Me.lbl_Customer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Customer.Name = "lbl_Customer"
        Me.lbl_Customer.Size = New System.Drawing.Size(0, 31)
        Me.lbl_Customer.TabIndex = 15
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.Location = New System.Drawing.Point(19, 112)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(363, 234)
        Me.DataGridView1.TabIndex = 16
        '
        'OffTheShelf_ProductTableAdapter1
        '
        Me.OffTheShelf_ProductTableAdapter1.ClearBeforeFill = True
        '
        'Group3DataSet1
        '
        Me.Group3DataSet1.DataSetName = "group3DataSet"
        Me.Group3DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FreshlyMade_ProductTableAdapter1
        '
        Me.FreshlyMade_ProductTableAdapter1.ClearBeforeFill = True
        '
        'FreshlyMadeProduct_IngredientTableAdapter1
        '
        Me.FreshlyMadeProduct_IngredientTableAdapter1.ClearBeforeFill = True
        '
        'IngredientTableAdapter1
        '
        Me.IngredientTableAdapter1.ClearBeforeFill = True
        '
        'CustomerTableAdapter1
        '
        Me.CustomerTableAdapter1.ClearBeforeFill = True
        '
        'Order_TableAdapter1
        '
        Me.Order_TableAdapter1.ClearBeforeFill = True
        '
        'btnCancelOrder
        '
        Me.btnCancelOrder.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCancelOrder.BackColor = System.Drawing.Color.Red
        Me.btnCancelOrder.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btnCancelOrder.Enabled = False
        Me.btnCancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelOrder.Location = New System.Drawing.Point(133, 532)
        Me.btnCancelOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelOrder.Name = "btnCancelOrder"
        Me.btnCancelOrder.Size = New System.Drawing.Size(122, 50)
        Me.btnCancelOrder.TabIndex = 19
        Me.btnCancelOrder.Text = "CANCEL ORDER"
        Me.btnCancelOrder.UseVisualStyleBackColor = False
        '
        'btn_checkout
        '
        Me.btn_checkout.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_checkout.BackColor = System.Drawing.Color.LawnGreen
        Me.btn_checkout.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btn_checkout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_checkout.Location = New System.Drawing.Point(229, 391)
        Me.btn_checkout.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_checkout.Name = "btn_checkout"
        Me.btn_checkout.Size = New System.Drawing.Size(132, 54)
        Me.btn_checkout.TabIndex = 20
        Me.btn_checkout.Text = "CHECKOUT"
        Me.btn_checkout.UseVisualStyleBackColor = False
        '
        'Order_ProductTableAdapter1
        '
        Me.Order_ProductTableAdapter1.ClearBeforeFill = True
        '
        'gb_OffTheShelf
        '
        Me.gb_OffTheShelf.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_OffTheShelf.Controls.Add(Me.GroupBox6)
        Me.gb_OffTheShelf.Controls.Add(Me.GroupBox7)
        Me.gb_OffTheShelf.Location = New System.Drawing.Point(448, 304)
        Me.gb_OffTheShelf.Margin = New System.Windows.Forms.Padding(2)
        Me.gb_OffTheShelf.Name = "gb_OffTheShelf"
        Me.gb_OffTheShelf.Padding = New System.Windows.Forms.Padding(2)
        Me.gb_OffTheShelf.Size = New System.Drawing.Size(440, 211)
        Me.gb_OffTheShelf.TabIndex = 12
        Me.gb_OffTheShelf.TabStop = False
        Me.gb_OffTheShelf.Text = "Off The Shelf Products"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Button7)
        Me.GroupBox6.Controls.Add(Me.Button8)
        Me.GroupBox6.Location = New System.Drawing.Point(16, 30)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox6.Size = New System.Drawing.Size(402, 69)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Food"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Salmon
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Location = New System.Drawing.Point(242, 17)
        Me.Button7.Margin = New System.Windows.Forms.Padding(2)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(95, 35)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "SWEETS"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.PeachPuff
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Location = New System.Drawing.Point(83, 15)
        Me.Button8.Margin = New System.Windows.Forms.Padding(2)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(93, 37)
        Me.Button8.TabIndex = 6
        Me.Button8.Text = "CHIPS"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Button12)
        Me.GroupBox7.Controls.Add(Me.Button9)
        Me.GroupBox7.Location = New System.Drawing.Point(16, 116)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox7.Size = New System.Drawing.Size(402, 74)
        Me.GroupBox7.TabIndex = 1
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Beverage"
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Button12.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button12.Location = New System.Drawing.Point(228, 17)
        Me.Button12.Margin = New System.Windows.Forms.Padding(2)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(125, 41)
        Me.Button12.TabIndex = 29
        Me.Button12.Text = "HOT BEVERAGES"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button9.Location = New System.Drawing.Point(71, 17)
        Me.Button9.Margin = New System.Windows.Forms.Padding(2)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(122, 41)
        Me.Button9.TabIndex = 28
        Me.Button9.Text = "COLD BEVERAGES"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(233, 349)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 26)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Total:  R"
        '
        'lbl_Lable
        '
        Me.lbl_Lable.AutoSize = True
        Me.lbl_Lable.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Lable.Location = New System.Drawing.Point(330, 349)
        Me.lbl_Lable.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Lable.Name = "lbl_Lable"
        Me.lbl_Lable.Size = New System.Drawing.Size(0, 26)
        Me.lbl_Lable.TabIndex = 22
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'btn_Payment
        '
        Me.btn_Payment.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_Payment.BackColor = System.Drawing.Color.LawnGreen
        Me.btn_Payment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Payment.Location = New System.Drawing.Point(38, 391)
        Me.btn_Payment.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_Payment.Name = "btn_Payment"
        Me.btn_Payment.Size = New System.Drawing.Size(122, 54)
        Me.btn_Payment.TabIndex = 23
        Me.btn_Payment.Text = "PROCESS PAYMENT"
        Me.btn_Payment.UseVisualStyleBackColor = False
        '
        'EmployeeTableAdapter1
        '
        Me.EmployeeTableAdapter1.ClearBeforeFill = True
        '
        'POSForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 602)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_Payment)
        Me.Controls.Add(Me.lbl_Lable)
        Me.Controls.Add(Me.gb_OffTheShelf)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_checkout)
        Me.Controls.Add(Me.btnCancelOrder)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lbl_Customer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_ExistingCustomer)
        Me.Controls.Add(Me.btn_NewCustomer)
        Me.Controls.Add(Me.gb_Products)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "POSForm"
        Me.Text = "POSForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gb_Products.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group3DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_OffTheShelf.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gb_Products As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btn_NewCustomer As System.Windows.Forms.Button
    Friend WithEvents btn_ExistingCustomer As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_Customer As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents OffTheShelf_ProductTableAdapter1 As AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.OffTheShelf_ProductTableAdapter
    Friend WithEvents Group3DataSet1 As AdamsCoffeeBar_IntegratedPOS.group3DataSet
    Friend WithEvents FreshlyMade_ProductTableAdapter1 As AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.FreshlyMade_ProductTableAdapter
    Friend WithEvents FreshlyMadeProduct_IngredientTableAdapter1 As AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.FreshlyMadeProduct_IngredientTableAdapter
    Friend WithEvents IngredientTableAdapter1 As AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.IngredientTableAdapter
    Friend WithEvents CustomerTableAdapter1 As AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents Order_TableAdapter1 As AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.Order_TableAdapter
    Friend WithEvents btnCancelOrder As System.Windows.Forms.Button
    Friend WithEvents btn_checkout As System.Windows.Forms.Button
    Friend WithEvents Order_ProductTableAdapter1 As AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.Order_ProductTableAdapter
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents gb_OffTheShelf As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_Lable As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents btn_Payment As System.Windows.Forms.Button
    Friend WithEvents EmployeeTableAdapter1 As AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.EmployeeTableAdapter
End Class
