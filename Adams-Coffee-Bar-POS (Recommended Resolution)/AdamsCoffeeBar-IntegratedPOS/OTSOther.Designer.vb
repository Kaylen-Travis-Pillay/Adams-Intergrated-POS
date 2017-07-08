<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OTSOther
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_CheeseSandwich = New System.Windows.Forms.Button()
        Me.Group3DataSet1 = New AdamsCoffeeBar_IntegratedPOS.group3DataSet()
        Me.FreshlyMade_ProductTableAdapter1 = New AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.FreshlyMade_ProductTableAdapter()
        Me.OffTheShelf_ProductTableAdapter1 = New AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.OffTheShelf_ProductTableAdapter()
        CType(Me.Group3DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 29.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(271, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(152, 57)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Other"
        '
        'btn_CheeseSandwich
        '
        Me.btn_CheeseSandwich.BackColor = System.Drawing.Color.PeachPuff
        Me.btn_CheeseSandwich.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btn_CheeseSandwich.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_CheeseSandwich.Location = New System.Drawing.Point(281, 199)
        Me.btn_CheeseSandwich.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_CheeseSandwich.Name = "btn_CheeseSandwich"
        Me.btn_CheeseSandwich.Size = New System.Drawing.Size(171, 100)
        Me.btn_CheeseSandwich.TabIndex = 19
        Me.btn_CheeseSandwich.Text = "WAFFLE / ICE CREAM"
        Me.btn_CheeseSandwich.UseVisualStyleBackColor = False
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
        'OTSOther
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 470)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_CheeseSandwich)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "OTSOther"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OTSOthervb"
        CType(Me.Group3DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_CheeseSandwich As System.Windows.Forms.Button
    Friend WithEvents Group3DataSet1 As AdamsCoffeeBar_IntegratedPOS.group3DataSet
    Friend WithEvents FreshlyMade_ProductTableAdapter1 As AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.FreshlyMade_ProductTableAdapter
    Friend WithEvents OffTheShelf_ProductTableAdapter1 As AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.OffTheShelf_ProductTableAdapter
End Class
