<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sweets
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
        Me.btn_Niki = New System.Windows.Forms.Button()
        Me.btn_MintImperials = New System.Windows.Forms.Button()
        Me.btn_TvBar = New System.Windows.Forms.Button()
        Me.btn_Tex = New System.Windows.Forms.Button()
        Me.btn_LunchBar = New System.Windows.Forms.Button()
        Me.btn_AllSorts = New System.Windows.Forms.Button()
        Me.btn_KitKat = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_Maynards = New System.Windows.Forms.Button()
        Me.btn_Nosh = New System.Windows.Forms.Button()
        Me.btn_Jennings = New System.Windows.Forms.Button()
        Me.Group3DataSet1 = New AdamsCoffeeBar_IntegratedPOS.group3DataSet()
        Me.FreshlyMade_ProductTableAdapter1 = New AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.FreshlyMade_ProductTableAdapter()
        Me.OffTheShelf_ProductTableAdapter1 = New AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.OffTheShelf_ProductTableAdapter()
        CType(Me.Group3DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Niki
        '
        Me.btn_Niki.BackColor = System.Drawing.Color.PeachPuff
        Me.btn_Niki.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btn_Niki.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Niki.Location = New System.Drawing.Point(479, 87)
        Me.btn_Niki.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Niki.Name = "btn_Niki"
        Me.btn_Niki.Size = New System.Drawing.Size(171, 100)
        Me.btn_Niki.TabIndex = 24
        Me.btn_Niki.Text = "NIKI"
        Me.btn_Niki.UseVisualStyleBackColor = False
        '
        'btn_MintImperials
        '
        Me.btn_MintImperials.BackColor = System.Drawing.Color.PeachPuff
        Me.btn_MintImperials.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btn_MintImperials.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_MintImperials.Location = New System.Drawing.Point(479, 322)
        Me.btn_MintImperials.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_MintImperials.Name = "btn_MintImperials"
        Me.btn_MintImperials.Size = New System.Drawing.Size(171, 100)
        Me.btn_MintImperials.TabIndex = 23
        Me.btn_MintImperials.Text = "MINT IMPERIALS"
        Me.btn_MintImperials.UseVisualStyleBackColor = False
        '
        'btn_TvBar
        '
        Me.btn_TvBar.BackColor = System.Drawing.Color.PeachPuff
        Me.btn_TvBar.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btn_TvBar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_TvBar.Location = New System.Drawing.Point(479, 201)
        Me.btn_TvBar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_TvBar.Name = "btn_TvBar"
        Me.btn_TvBar.Size = New System.Drawing.Size(171, 100)
        Me.btn_TvBar.TabIndex = 22
        Me.btn_TvBar.Text = "TV BAR"
        Me.btn_TvBar.UseVisualStyleBackColor = False
        '
        'btn_Tex
        '
        Me.btn_Tex.BackColor = System.Drawing.Color.PeachPuff
        Me.btn_Tex.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btn_Tex.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Tex.Location = New System.Drawing.Point(102, 201)
        Me.btn_Tex.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Tex.Name = "btn_Tex"
        Me.btn_Tex.Size = New System.Drawing.Size(171, 100)
        Me.btn_Tex.TabIndex = 21
        Me.btn_Tex.Text = "TEX"
        Me.btn_Tex.UseVisualStyleBackColor = False
        '
        'btn_LunchBar
        '
        Me.btn_LunchBar.BackColor = System.Drawing.Color.PeachPuff
        Me.btn_LunchBar.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btn_LunchBar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_LunchBar.Location = New System.Drawing.Point(293, 87)
        Me.btn_LunchBar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_LunchBar.Name = "btn_LunchBar"
        Me.btn_LunchBar.Size = New System.Drawing.Size(171, 100)
        Me.btn_LunchBar.TabIndex = 20
        Me.btn_LunchBar.Text = "LUNCH BAR"
        Me.btn_LunchBar.UseVisualStyleBackColor = False
        '
        'btn_AllSorts
        '
        Me.btn_AllSorts.BackColor = System.Drawing.Color.PeachPuff
        Me.btn_AllSorts.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btn_AllSorts.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_AllSorts.Location = New System.Drawing.Point(293, 322)
        Me.btn_AllSorts.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_AllSorts.Name = "btn_AllSorts"
        Me.btn_AllSorts.Size = New System.Drawing.Size(171, 100)
        Me.btn_AllSorts.TabIndex = 19
        Me.btn_AllSorts.Text = "ALL SORTS"
        Me.btn_AllSorts.UseVisualStyleBackColor = False
        '
        'btn_KitKat
        '
        Me.btn_KitKat.BackColor = System.Drawing.Color.PeachPuff
        Me.btn_KitKat.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btn_KitKat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_KitKat.Location = New System.Drawing.Point(102, 87)
        Me.btn_KitKat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_KitKat.Name = "btn_KitKat"
        Me.btn_KitKat.Size = New System.Drawing.Size(171, 100)
        Me.btn_KitKat.TabIndex = 18
        Me.btn_KitKat.Text = "KIT KAT"
        Me.btn_KitKat.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 29.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(282, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(192, 57)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Sweets"
        '
        'btn_Maynards
        '
        Me.btn_Maynards.BackColor = System.Drawing.Color.PeachPuff
        Me.btn_Maynards.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btn_Maynards.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Maynards.Location = New System.Drawing.Point(102, 322)
        Me.btn_Maynards.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Maynards.Name = "btn_Maynards"
        Me.btn_Maynards.Size = New System.Drawing.Size(171, 100)
        Me.btn_Maynards.TabIndex = 16
        Me.btn_Maynards.Text = "MAYNARDS"
        Me.btn_Maynards.UseVisualStyleBackColor = False
        '
        'btn_Nosh
        '
        Me.btn_Nosh.BackColor = System.Drawing.Color.PeachPuff
        Me.btn_Nosh.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btn_Nosh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Nosh.Location = New System.Drawing.Point(293, 201)
        Me.btn_Nosh.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Nosh.Name = "btn_Nosh"
        Me.btn_Nosh.Size = New System.Drawing.Size(171, 100)
        Me.btn_Nosh.TabIndex = 26
        Me.btn_Nosh.Text = "NOSH"
        Me.btn_Nosh.UseVisualStyleBackColor = False
        '
        'btn_Jennings
        '
        Me.btn_Jennings.BackColor = System.Drawing.Color.PeachPuff
        Me.btn_Jennings.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btn_Jennings.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Jennings.Location = New System.Drawing.Point(293, 440)
        Me.btn_Jennings.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Jennings.Name = "btn_Jennings"
        Me.btn_Jennings.Size = New System.Drawing.Size(171, 100)
        Me.btn_Jennings.TabIndex = 25
        Me.btn_Jennings.Text = "JENNINGS (PEANUT AND SESAME BRITTLE)"
        Me.btn_Jennings.UseVisualStyleBackColor = False
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
        'Sweets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 572)
        Me.Controls.Add(Me.btn_Nosh)
        Me.Controls.Add(Me.btn_Jennings)
        Me.Controls.Add(Me.btn_Niki)
        Me.Controls.Add(Me.btn_MintImperials)
        Me.Controls.Add(Me.btn_TvBar)
        Me.Controls.Add(Me.btn_Tex)
        Me.Controls.Add(Me.btn_LunchBar)
        Me.Controls.Add(Me.btn_AllSorts)
        Me.Controls.Add(Me.btn_KitKat)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_Maynards)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Sweets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sweets"
        CType(Me.Group3DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Niki As System.Windows.Forms.Button
    Friend WithEvents btn_MintImperials As System.Windows.Forms.Button
    Friend WithEvents btn_TvBar As System.Windows.Forms.Button
    Friend WithEvents btn_Tex As System.Windows.Forms.Button
    Friend WithEvents btn_LunchBar As System.Windows.Forms.Button
    Friend WithEvents btn_AllSorts As System.Windows.Forms.Button
    Friend WithEvents btn_KitKat As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_Maynards As System.Windows.Forms.Button
    Friend WithEvents btn_Nosh As System.Windows.Forms.Button
    Friend WithEvents btn_Jennings As System.Windows.Forms.Button
    Friend WithEvents Group3DataSet1 As AdamsCoffeeBar_IntegratedPOS.group3DataSet
    Friend WithEvents FreshlyMade_ProductTableAdapter1 As AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.FreshlyMade_ProductTableAdapter
    Friend WithEvents OffTheShelf_ProductTableAdapter1 As AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.OffTheShelf_ProductTableAdapter
End Class
