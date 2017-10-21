<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MNG_ProductAndOrderManagement
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TB_price = New System.Windows.Forms.TextBox()
        Me.TB_cost = New System.Windows.Forms.TextBox()
        Me.TB_name = New System.Windows.Forms.TextBox()
        Me.TB_desc = New System.Windows.Forms.TextBox()
        Me.TB_type = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB_products = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.txb_ingreDesc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txb_reThresh = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbx_ingreQTY = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbx_ingreCost = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbx_ingreName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DGV_Ingredients = New System.Windows.Forms.DataGridView()
        Me.Group3DataSet = New AdamsCoffeeBar_IntegratedPOS.group3DataSet()
        Me.FreshlyMade_ProductTableAdapter1 = New AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.FreshlyMade_ProductTableAdapter()
        Me.OffTheShelf_ProductTableAdapter1 = New AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.OffTheShelf_ProductTableAdapter()
        Me.FreshlyMadeProduct_IngredientTableAdapter1 = New AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.FreshlyMadeProduct_IngredientTableAdapter()
        Me.IngredientTableAdapter1 = New AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.IngredientTableAdapter()
        Me.IngredientProportionTableAdapter1 = New AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.IngredientProportionTableAdapter()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Details = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Measurement = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGV_Ingredients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TB_price)
        Me.GroupBox1.Controls.Add(Me.TB_cost)
        Me.GroupBox1.Controls.Add(Me.TB_name)
        Me.GroupBox1.Controls.Add(Me.TB_desc)
        Me.GroupBox1.Controls.Add(Me.TB_type)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CB_products)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(583, 518)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Products"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(436, 471)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 30)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(310, 471)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 30)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Edit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TB_price
        '
        Me.TB_price.Enabled = False
        Me.TB_price.Location = New System.Drawing.Point(177, 388)
        Me.TB_price.Name = "TB_price"
        Me.TB_price.Size = New System.Drawing.Size(379, 26)
        Me.TB_price.TabIndex = 4
        '
        'TB_cost
        '
        Me.TB_cost.Enabled = False
        Me.TB_cost.Location = New System.Drawing.Point(177, 356)
        Me.TB_cost.Name = "TB_cost"
        Me.TB_cost.Size = New System.Drawing.Size(379, 26)
        Me.TB_cost.TabIndex = 4
        '
        'TB_name
        '
        Me.TB_name.Enabled = False
        Me.TB_name.Location = New System.Drawing.Point(177, 254)
        Me.TB_name.Name = "TB_name"
        Me.TB_name.Size = New System.Drawing.Size(379, 26)
        Me.TB_name.TabIndex = 4
        '
        'TB_desc
        '
        Me.TB_desc.Enabled = False
        Me.TB_desc.Location = New System.Drawing.Point(177, 287)
        Me.TB_desc.Multiline = True
        Me.TB_desc.Name = "TB_desc"
        Me.TB_desc.Size = New System.Drawing.Size(379, 63)
        Me.TB_desc.TabIndex = 4
        '
        'TB_type
        '
        Me.TB_type.Enabled = False
        Me.TB_type.Location = New System.Drawing.Point(177, 222)
        Me.TB_type.Name = "TB_type"
        Me.TB_type.Size = New System.Drawing.Size(379, 26)
        Me.TB_type.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 388)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 20)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Product Price: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 356)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Product Cost: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Product Desc: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Product Name: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Product Type: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 20)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Product Selection"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Product Details"
        '
        'CB_products
        '
        Me.CB_products.FormattingEnabled = True
        Me.CB_products.Location = New System.Drawing.Point(6, 85)
        Me.CB_products.Name = "CB_products"
        Me.CB_products.Size = New System.Drawing.Size(550, 28)
        Me.CB_products.TabIndex = 0
        Me.CB_products.Text = "Select Product"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.DGV_Ingredients)
        Me.GroupBox2.Location = New System.Drawing.Point(602, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(564, 518)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Recipie"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnSave)
        Me.GroupBox3.Controls.Add(Me.btnEdit)
        Me.GroupBox3.Controls.Add(Me.txb_ingreDesc)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txb_reThresh)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.tbx_ingreQTY)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.tbx_ingreCost)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.tbx_ingreName)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(21, 211)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(526, 301)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ingredient Details"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(354, 260)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 30)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(228, 260)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(120, 30)
        Me.btnEdit.TabIndex = 21
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'txb_ingreDesc
        '
        Me.txb_ingreDesc.Enabled = False
        Me.txb_ingreDesc.Location = New System.Drawing.Point(214, 171)
        Me.txb_ingreDesc.Multiline = True
        Me.txb_ingreDesc.Name = "txb_ingreDesc"
        Me.txb_ingreDesc.Size = New System.Drawing.Size(260, 62)
        Me.txb_ingreDesc.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Ingre. Desc: "
        '
        'txb_reThresh
        '
        Me.txb_reThresh.Enabled = False
        Me.txb_reThresh.Location = New System.Drawing.Point(214, 139)
        Me.txb_reThresh.Name = "txb_reThresh"
        Me.txb_reThresh.Size = New System.Drawing.Size(260, 26)
        Me.txb_reThresh.TabIndex = 16
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(61, 139)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(157, 20)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Ingre. Re Threshold: "
        '
        'tbx_ingreQTY
        '
        Me.tbx_ingreQTY.Enabled = False
        Me.tbx_ingreQTY.Location = New System.Drawing.Point(214, 107)
        Me.tbx_ingreQTY.Name = "tbx_ingreQTY"
        Me.tbx_ingreQTY.Size = New System.Drawing.Size(260, 26)
        Me.tbx_ingreQTY.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(61, 107)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 20)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Ingre. Qty: "
        '
        'tbx_ingreCost
        '
        Me.tbx_ingreCost.Enabled = False
        Me.tbx_ingreCost.Location = New System.Drawing.Point(214, 75)
        Me.tbx_ingreCost.Name = "tbx_ingreCost"
        Me.tbx_ingreCost.Size = New System.Drawing.Size(260, 26)
        Me.tbx_ingreCost.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(61, 75)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 20)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Ingre. Cost: "
        '
        'tbx_ingreName
        '
        Me.tbx_ingreName.Enabled = False
        Me.tbx_ingreName.Location = New System.Drawing.Point(214, 43)
        Me.tbx_ingreName.Name = "tbx_ingreName"
        Me.tbx_ingreName.Size = New System.Drawing.Size(260, 26)
        Me.tbx_ingreName.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(61, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 20)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Ingre. Name: "
        '
        'DGV_Ingredients
        '
        Me.DGV_Ingredients.AllowUserToAddRows = False
        Me.DGV_Ingredients.AllowUserToDeleteRows = False
        Me.DGV_Ingredients.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_Ingredients.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV_Ingredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Ingredients.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Quantity, Me.Details, Me.Measurement})
        Me.DGV_Ingredients.Location = New System.Drawing.Point(21, 25)
        Me.DGV_Ingredients.Name = "DGV_Ingredients"
        Me.DGV_Ingredients.RowTemplate.Height = 28
        Me.DGV_Ingredients.Size = New System.Drawing.Size(526, 175)
        Me.DGV_Ingredients.TabIndex = 3
        '
        'Group3DataSet
        '
        Me.Group3DataSet.DataSetName = "group3DataSet"
        Me.Group3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FreshlyMade_ProductTableAdapter1
        '
        Me.FreshlyMade_ProductTableAdapter1.ClearBeforeFill = True
        '
        'OffTheShelf_ProductTableAdapter1
        '
        Me.OffTheShelf_ProductTableAdapter1.ClearBeforeFill = True
        '
        'FreshlyMadeProduct_IngredientTableAdapter1
        '
        Me.FreshlyMadeProduct_IngredientTableAdapter1.ClearBeforeFill = True
        '
        'IngredientTableAdapter1
        '
        Me.IngredientTableAdapter1.ClearBeforeFill = True
        '
        'IngredientProportionTableAdapter1
        '
        Me.IngredientProportionTableAdapter1.ClearBeforeFill = True
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'Details
        '
        Me.Details.HeaderText = "Details"
        Me.Details.Name = "Details"
        Me.Details.ReadOnly = True
        Me.Details.Width = 220
        '
        'Measurement
        '
        Me.Measurement.HeaderText = "Measurement"
        Me.Measurement.Items.AddRange(New Object() {"Number", "Grams"})
        Me.Measurement.Name = "Measurement"
        Me.Measurement.ReadOnly = True
        Me.Measurement.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Measurement.Width = 150
        '
        'MNG_ProductAndOrderManagement
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1185, 543)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MNG_ProductAndOrderManagement"
        Me.Text = "MNG_ProductAndOrderManagement"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGV_Ingredients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Group3DataSet As AdamsCoffeeBar_IntegratedPOS.group3DataSet
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CB_products As System.Windows.Forms.ComboBox
    Friend WithEvents DGV_Ingredients As System.Windows.Forms.DataGridView
    Friend WithEvents FreshlyMade_ProductTableAdapter1 As AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.FreshlyMade_ProductTableAdapter
    Friend WithEvents OffTheShelf_ProductTableAdapter1 As AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.OffTheShelf_ProductTableAdapter
    Friend WithEvents TB_price As System.Windows.Forms.TextBox
    Friend WithEvents TB_cost As System.Windows.Forms.TextBox
    Friend WithEvents TB_name As System.Windows.Forms.TextBox
    Friend WithEvents TB_desc As System.Windows.Forms.TextBox
    Friend WithEvents TB_type As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents FreshlyMadeProduct_IngredientTableAdapter1 As AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.FreshlyMadeProduct_IngredientTableAdapter
    Friend WithEvents IngredientTableAdapter1 As AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.IngredientTableAdapter
    Friend WithEvents IngredientProportionTableAdapter1 As AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.IngredientProportionTableAdapter
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents txb_reThresh As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tbx_ingreQTY As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tbx_ingreCost As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbx_ingreName As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txb_ingreDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Details As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Measurement As System.Windows.Forms.DataGridViewComboBoxColumn
End Class
