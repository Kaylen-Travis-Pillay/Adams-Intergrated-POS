<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashOrCard
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Cash = New System.Windows.Forms.Button()
        Me.btn_Card = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PAYMENT METHOD"
        '
        'btn_Cash
        '
        Me.btn_Cash.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_Cash.BackColor = System.Drawing.Color.Violet
        Me.btn_Cash.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btn_Cash.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Cash.Location = New System.Drawing.Point(8, 64)
        Me.btn_Cash.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Cash.Name = "btn_Cash"
        Me.btn_Cash.Size = New System.Drawing.Size(171, 100)
        Me.btn_Cash.TabIndex = 21
        Me.btn_Cash.Text = "CASH"
        Me.btn_Cash.UseVisualStyleBackColor = False
        '
        'btn_Card
        '
        Me.btn_Card.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_Card.BackColor = System.Drawing.Color.Violet
        Me.btn_Card.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btn_Card.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Card.Location = New System.Drawing.Point(198, 64)
        Me.btn_Card.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Card.Name = "btn_Card"
        Me.btn_Card.Size = New System.Drawing.Size(171, 100)
        Me.btn_Card.TabIndex = 21
        Me.btn_Card.Text = "CARD"
        Me.btn_Card.UseVisualStyleBackColor = False
        '
        'CashOrCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 175)
        Me.Controls.Add(Me.btn_Card)
        Me.Controls.Add(Me.btn_Cash)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CashOrCard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment Method"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_Cash As System.Windows.Forms.Button
    Friend WithEvents btn_Card As System.Windows.Forms.Button
End Class
