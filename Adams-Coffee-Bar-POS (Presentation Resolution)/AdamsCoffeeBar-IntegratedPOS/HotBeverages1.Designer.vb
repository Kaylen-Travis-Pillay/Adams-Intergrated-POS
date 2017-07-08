<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HotBeverages1
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
        Me.btn_EarlGreyTea = New System.Windows.Forms.Button()
        Me.btn_FiveRosesTea = New System.Windows.Forms.Button()
        Me.btn_HotChocolate = New System.Windows.Forms.Button()
        Me.btn_HotMilo = New System.Windows.Forms.Button()
        Me.btn_CappuccinoWithCream = New System.Windows.Forms.Button()
        Me.btn_DoubleExpresso = New System.Windows.Forms.Button()
        Me.btn_SingleExpresso = New System.Windows.Forms.Button()
        Me.btn_FilterCoffee = New System.Windows.Forms.Button()
        Me.btn_RooibosTea = New System.Windows.Forms.Button()
        Me.btn_HotChocolateWithCream = New System.Windows.Forms.Button()
        Me.btn_Cappuccino = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Group3DataSet1 = New AdamsCoffeeBar_IntegratedPOS.group3DataSet()
        Me.FreshlyMade_ProductTableAdapter1 = New AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.FreshlyMade_ProductTableAdapter()
        Me.OffTheShelf_ProductTableAdapter1 = New AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.OffTheShelf_ProductTableAdapter()
        CType(Me.Group3DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_EarlGreyTea
        '
        Me.btn_EarlGreyTea.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btn_EarlGreyTea.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btn_EarlGreyTea.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_EarlGreyTea.Location = New System.Drawing.Point(164, 333)
        Me.btn_EarlGreyTea.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_EarlGreyTea.Name = "btn_EarlGreyTea"
        Me.btn_EarlGreyTea.Size = New System.Drawing.Size(148, 100)
        Me.btn_EarlGreyTea.TabIndex = 29
        Me.btn_EarlGreyTea.Text = "EARL GREY TEA"
        Me.btn_EarlGreyTea.UseVisualStyleBackColor = False
        '
        'btn_FiveRosesTea
        '
        Me.btn_FiveRosesTea.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btn_FiveRosesTea.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btn_FiveRosesTea.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_FiveRosesTea.Location = New System.Drawing.Point(520, 333)
        Me.btn_FiveRosesTea.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_FiveRosesTea.Name = "btn_FiveRosesTea"
        Me.btn_FiveRosesTea.Size = New System.Drawing.Size(148, 100)
        Me.btn_FiveRosesTea.TabIndex = 28
        Me.btn_FiveRosesTea.Text = "FIVE ROSES TEA"
        Me.btn_FiveRosesTea.UseVisualStyleBackColor = False
        '
        'btn_HotChocolate
        '
        Me.btn_HotChocolate.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_HotChocolate.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btn_HotChocolate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_HotChocolate.Location = New System.Drawing.Point(404, 208)
        Me.btn_HotChocolate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_HotChocolate.Name = "btn_HotChocolate"
        Me.btn_HotChocolate.Size = New System.Drawing.Size(148, 100)
        Me.btn_HotChocolate.TabIndex = 27
        Me.btn_HotChocolate.Text = "HOT CHOCOLATE"
        Me.btn_HotChocolate.UseVisualStyleBackColor = False
        '
        'btn_HotMilo
        '
        Me.btn_HotMilo.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btn_HotMilo.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btn_HotMilo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_HotMilo.Location = New System.Drawing.Point(233, 208)
        Me.btn_HotMilo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_HotMilo.Name = "btn_HotMilo"
        Me.btn_HotMilo.Size = New System.Drawing.Size(148, 100)
        Me.btn_HotMilo.TabIndex = 26
        Me.btn_HotMilo.Text = "HOT MILO"
        Me.btn_HotMilo.UseVisualStyleBackColor = False
        '
        'btn_CappuccinoWithCream
        '
        Me.btn_CappuccinoWithCream.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_CappuccinoWithCream.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btn_CappuccinoWithCream.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_CappuccinoWithCream.Location = New System.Drawing.Point(64, 208)
        Me.btn_CappuccinoWithCream.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_CappuccinoWithCream.Name = "btn_CappuccinoWithCream"
        Me.btn_CappuccinoWithCream.Size = New System.Drawing.Size(148, 100)
        Me.btn_CappuccinoWithCream.TabIndex = 25
        Me.btn_CappuccinoWithCream.Text = "CAPPACCINO w/Cream"
        Me.btn_CappuccinoWithCream.UseVisualStyleBackColor = False
        '
        'btn_DoubleExpresso
        '
        Me.btn_DoubleExpresso.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btn_DoubleExpresso.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btn_DoubleExpresso.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_DoubleExpresso.Location = New System.Drawing.Point(400, 87)
        Me.btn_DoubleExpresso.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_DoubleExpresso.Name = "btn_DoubleExpresso"
        Me.btn_DoubleExpresso.Size = New System.Drawing.Size(148, 100)
        Me.btn_DoubleExpresso.TabIndex = 24
        Me.btn_DoubleExpresso.Text = "DOUBLE EXPRESSO"
        Me.btn_DoubleExpresso.UseVisualStyleBackColor = False
        '
        'btn_SingleExpresso
        '
        Me.btn_SingleExpresso.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_SingleExpresso.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btn_SingleExpresso.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_SingleExpresso.Location = New System.Drawing.Point(230, 87)
        Me.btn_SingleExpresso.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_SingleExpresso.Name = "btn_SingleExpresso"
        Me.btn_SingleExpresso.Size = New System.Drawing.Size(148, 100)
        Me.btn_SingleExpresso.TabIndex = 23
        Me.btn_SingleExpresso.Text = "SINGLE EXPRESSO"
        Me.btn_SingleExpresso.UseVisualStyleBackColor = False
        '
        'btn_FilterCoffee
        '
        Me.btn_FilterCoffee.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btn_FilterCoffee.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btn_FilterCoffee.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_FilterCoffee.Location = New System.Drawing.Point(64, 87)
        Me.btn_FilterCoffee.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_FilterCoffee.Name = "btn_FilterCoffee"
        Me.btn_FilterCoffee.Size = New System.Drawing.Size(148, 100)
        Me.btn_FilterCoffee.TabIndex = 22
        Me.btn_FilterCoffee.Text = "FILTER COFFEE"
        Me.btn_FilterCoffee.UseVisualStyleBackColor = False
        '
        'btn_RooibosTea
        '
        Me.btn_RooibosTea.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_RooibosTea.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btn_RooibosTea.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_RooibosTea.Location = New System.Drawing.Point(341, 333)
        Me.btn_RooibosTea.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_RooibosTea.Name = "btn_RooibosTea"
        Me.btn_RooibosTea.Size = New System.Drawing.Size(148, 100)
        Me.btn_RooibosTea.TabIndex = 30
        Me.btn_RooibosTea.Text = "ROOI BOS TEA"
        Me.btn_RooibosTea.UseVisualStyleBackColor = False
        '
        'btn_HotChocolateWithCream
        '
        Me.btn_HotChocolateWithCream.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btn_HotChocolateWithCream.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btn_HotChocolateWithCream.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_HotChocolateWithCream.Location = New System.Drawing.Point(575, 208)
        Me.btn_HotChocolateWithCream.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_HotChocolateWithCream.Name = "btn_HotChocolateWithCream"
        Me.btn_HotChocolateWithCream.Size = New System.Drawing.Size(148, 100)
        Me.btn_HotChocolateWithCream.TabIndex = 31
        Me.btn_HotChocolateWithCream.Text = "HOT CHOCOLATE w/Cream"
        Me.btn_HotChocolateWithCream.UseVisualStyleBackColor = False
        '
        'btn_Cappuccino
        '
        Me.btn_Cappuccino.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_Cappuccino.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btn_Cappuccino.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Cappuccino.Location = New System.Drawing.Point(574, 87)
        Me.btn_Cappuccino.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Cappuccino.Name = "btn_Cappuccino"
        Me.btn_Cappuccino.Size = New System.Drawing.Size(148, 100)
        Me.btn_Cappuccino.TabIndex = 33
        Me.btn_Cappuccino.Text = "CAPPUCCINO"
        Me.btn_Cappuccino.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 29.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(220, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 57)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Hot Beverages"
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
        'OffTheShelf_ProductTableAdapter1
        '
        Me.OffTheShelf_ProductTableAdapter1.ClearBeforeFill = True
        '
        'HotBeverages1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 480)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Cappuccino)
        Me.Controls.Add(Me.btn_RooibosTea)
        Me.Controls.Add(Me.btn_HotChocolateWithCream)
        Me.Controls.Add(Me.btn_EarlGreyTea)
        Me.Controls.Add(Me.btn_FiveRosesTea)
        Me.Controls.Add(Me.btn_HotChocolate)
        Me.Controls.Add(Me.btn_HotMilo)
        Me.Controls.Add(Me.btn_CappuccinoWithCream)
        Me.Controls.Add(Me.btn_DoubleExpresso)
        Me.Controls.Add(Me.btn_SingleExpresso)
        Me.Controls.Add(Me.btn_FilterCoffee)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "HotBeverages1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hot Beverages"
        CType(Me.Group3DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_EarlGreyTea As System.Windows.Forms.Button
    Friend WithEvents btn_FiveRosesTea As System.Windows.Forms.Button
    Friend WithEvents btn_HotChocolate As System.Windows.Forms.Button
    Friend WithEvents btn_HotMilo As System.Windows.Forms.Button
    Friend WithEvents btn_CappuccinoWithCream As System.Windows.Forms.Button
    Friend WithEvents btn_DoubleExpresso As System.Windows.Forms.Button
    Friend WithEvents btn_SingleExpresso As System.Windows.Forms.Button
    Friend WithEvents btn_FilterCoffee As System.Windows.Forms.Button
    Friend WithEvents btn_RooibosTea As System.Windows.Forms.Button
    Friend WithEvents btn_HotChocolateWithCream As System.Windows.Forms.Button
    Friend WithEvents btn_Cappuccino As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Group3DataSet1 As AdamsCoffeeBar_IntegratedPOS.group3DataSet
    Friend WithEvents FreshlyMade_ProductTableAdapter1 As AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.FreshlyMade_ProductTableAdapter
    Friend WithEvents OffTheShelf_ProductTableAdapter1 As AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.OffTheShelf_ProductTableAdapter
End Class
