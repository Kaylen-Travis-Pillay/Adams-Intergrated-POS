<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chips
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
        Me.btn_NikNaks = New System.Windows.Forms.Button()
        Me.btn_DoritosCheese = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_LaysSpringOnion = New System.Windows.Forms.Button()
        Me.Group3DataSet1 = New AdamsCoffeeBar_IntegratedPOS.group3DataSet()
        Me.FreshlyMade_ProductTableAdapter1 = New AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.FreshlyMade_ProductTableAdapter()
        Me.OffTheShelf_ProductTableAdapter1 = New AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.OffTheShelf_ProductTableAdapter()
        Me.btn_LaysBalsamicVinegar = New System.Windows.Forms.Button()
        Me.btn_DoritosSweetChilli = New System.Windows.Forms.Button()
        CType(Me.Group3DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_NikNaks
        '
        Me.btn_NikNaks.BackColor = System.Drawing.Color.PeachPuff
        Me.btn_NikNaks.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btn_NikNaks.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_NikNaks.Location = New System.Drawing.Point(219, 328)
        Me.btn_NikNaks.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_NikNaks.Name = "btn_NikNaks"
        Me.btn_NikNaks.Size = New System.Drawing.Size(171, 100)
        Me.btn_NikNaks.TabIndex = 19
        Me.btn_NikNaks.Text = "NIK NAKS"
        Me.btn_NikNaks.UseVisualStyleBackColor = False
        '
        'btn_DoritosCheese
        '
        Me.btn_DoritosCheese.BackColor = System.Drawing.Color.PeachPuff
        Me.btn_DoritosCheese.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btn_DoritosCheese.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_DoritosCheese.Location = New System.Drawing.Point(125, 209)
        Me.btn_DoritosCheese.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_DoritosCheese.Name = "btn_DoritosCheese"
        Me.btn_DoritosCheese.Size = New System.Drawing.Size(171, 100)
        Me.btn_DoritosCheese.TabIndex = 18
        Me.btn_DoritosCheese.Text = "DORITOS - CHEESE"
        Me.btn_DoritosCheese.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 29.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(221, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(156, 57)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Chips"
        '
        'btn_LaysSpringOnion
        '
        Me.btn_LaysSpringOnion.BackColor = System.Drawing.Color.PeachPuff
        Me.btn_LaysSpringOnion.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btn_LaysSpringOnion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_LaysSpringOnion.Location = New System.Drawing.Point(125, 92)
        Me.btn_LaysSpringOnion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_LaysSpringOnion.Name = "btn_LaysSpringOnion"
        Me.btn_LaysSpringOnion.Size = New System.Drawing.Size(171, 100)
        Me.btn_LaysSpringOnion.TabIndex = 16
        Me.btn_LaysSpringOnion.Text = "LAYS - SPRING ONION"
        Me.btn_LaysSpringOnion.UseVisualStyleBackColor = False
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
        'btn_LaysBalsamicVinegar
        '
        Me.btn_LaysBalsamicVinegar.BackColor = System.Drawing.Color.PeachPuff
        Me.btn_LaysBalsamicVinegar.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btn_LaysBalsamicVinegar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_LaysBalsamicVinegar.Location = New System.Drawing.Point(316, 92)
        Me.btn_LaysBalsamicVinegar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_LaysBalsamicVinegar.Name = "btn_LaysBalsamicVinegar"
        Me.btn_LaysBalsamicVinegar.Size = New System.Drawing.Size(171, 100)
        Me.btn_LaysBalsamicVinegar.TabIndex = 16
        Me.btn_LaysBalsamicVinegar.Text = "LAYS - BALSAMIC VINEGAR"
        Me.btn_LaysBalsamicVinegar.UseVisualStyleBackColor = False
        '
        'btn_DoritosSweetChilli
        '
        Me.btn_DoritosSweetChilli.BackColor = System.Drawing.Color.PeachPuff
        Me.btn_DoritosSweetChilli.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btn_DoritosSweetChilli.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_DoritosSweetChilli.Location = New System.Drawing.Point(316, 209)
        Me.btn_DoritosSweetChilli.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_DoritosSweetChilli.Name = "btn_DoritosSweetChilli"
        Me.btn_DoritosSweetChilli.Size = New System.Drawing.Size(171, 100)
        Me.btn_DoritosSweetChilli.TabIndex = 18
        Me.btn_DoritosSweetChilli.Text = "DORITOS - SWEET CHILLI"
        Me.btn_DoritosSweetChilli.UseVisualStyleBackColor = False
        '
        'Chips
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 465)
        Me.Controls.Add(Me.btn_NikNaks)
        Me.Controls.Add(Me.btn_DoritosSweetChilli)
        Me.Controls.Add(Me.btn_DoritosCheese)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_LaysBalsamicVinegar)
        Me.Controls.Add(Me.btn_LaysSpringOnion)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Chips"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chips"
        CType(Me.Group3DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_NikNaks As System.Windows.Forms.Button
    Friend WithEvents btn_DoritosCheese As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_LaysSpringOnion As System.Windows.Forms.Button
    Friend WithEvents Group3DataSet1 As AdamsCoffeeBar_IntegratedPOS.group3DataSet
    Friend WithEvents FreshlyMade_ProductTableAdapter1 As AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.FreshlyMade_ProductTableAdapter
    Friend WithEvents OffTheShelf_ProductTableAdapter1 As AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.OffTheShelf_ProductTableAdapter
    Friend WithEvents btn_LaysBalsamicVinegar As System.Windows.Forms.Button
    Friend WithEvents btn_DoritosSweetChilli As System.Windows.Forms.Button
End Class
