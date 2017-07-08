<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cash))
        Me.btn_R200 = New System.Windows.Forms.Button()
        Me.btn_R100 = New System.Windows.Forms.Button()
        Me.btn_R50 = New System.Windows.Forms.Button()
        Me.btn_R20 = New System.Windows.Forms.Button()
        Me.btn_R10 = New System.Windows.Forms.Button()
        Me.btn_R5 = New System.Windows.Forms.Button()
        Me.btn_R2 = New System.Windows.Forms.Button()
        Me.btn_R1 = New System.Windows.Forms.Button()
        Me.lbl_AmountDue = New System.Windows.Forms.Label()
        Me.lbl_AmountGiven = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_CalcChange = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_OK = New System.Windows.Forms.Button()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_R200
        '
        Me.btn_R200.BackgroundImage = CType(resources.GetObject("btn_R200.BackgroundImage"), System.Drawing.Image)
        Me.btn_R200.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_R200.Location = New System.Drawing.Point(21, 141)
        Me.btn_R200.Name = "btn_R200"
        Me.btn_R200.Size = New System.Drawing.Size(347, 162)
        Me.btn_R200.TabIndex = 0
        Me.btn_R200.UseVisualStyleBackColor = True
        '
        'btn_R100
        '
        Me.btn_R100.BackgroundImage = CType(resources.GetObject("btn_R100.BackgroundImage"), System.Drawing.Image)
        Me.btn_R100.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_R100.Location = New System.Drawing.Point(393, 141)
        Me.btn_R100.Name = "btn_R100"
        Me.btn_R100.Size = New System.Drawing.Size(347, 162)
        Me.btn_R100.TabIndex = 0
        Me.btn_R100.UseVisualStyleBackColor = True
        '
        'btn_R50
        '
        Me.btn_R50.BackgroundImage = CType(resources.GetObject("btn_R50.BackgroundImage"), System.Drawing.Image)
        Me.btn_R50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_R50.Location = New System.Drawing.Point(21, 322)
        Me.btn_R50.Name = "btn_R50"
        Me.btn_R50.Size = New System.Drawing.Size(347, 162)
        Me.btn_R50.TabIndex = 0
        Me.btn_R50.UseVisualStyleBackColor = True
        '
        'btn_R20
        '
        Me.btn_R20.BackgroundImage = CType(resources.GetObject("btn_R20.BackgroundImage"), System.Drawing.Image)
        Me.btn_R20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_R20.Location = New System.Drawing.Point(393, 322)
        Me.btn_R20.Name = "btn_R20"
        Me.btn_R20.Size = New System.Drawing.Size(347, 162)
        Me.btn_R20.TabIndex = 0
        Me.btn_R20.UseVisualStyleBackColor = True
        '
        'btn_R10
        '
        Me.btn_R10.BackgroundImage = CType(resources.GetObject("btn_R10.BackgroundImage"), System.Drawing.Image)
        Me.btn_R10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_R10.Location = New System.Drawing.Point(203, 508)
        Me.btn_R10.Name = "btn_R10"
        Me.btn_R10.Size = New System.Drawing.Size(347, 162)
        Me.btn_R10.TabIndex = 0
        Me.btn_R10.UseVisualStyleBackColor = True
        '
        'btn_R5
        '
        Me.btn_R5.BackgroundImage = CType(resources.GetObject("btn_R5.BackgroundImage"), System.Drawing.Image)
        Me.btn_R5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_R5.Location = New System.Drawing.Point(851, 164)
        Me.btn_R5.Name = "btn_R5"
        Me.btn_R5.Size = New System.Drawing.Size(135, 117)
        Me.btn_R5.TabIndex = 0
        Me.btn_R5.UseVisualStyleBackColor = True
        '
        'btn_R2
        '
        Me.btn_R2.BackgroundImage = CType(resources.GetObject("btn_R2.BackgroundImage"), System.Drawing.Image)
        Me.btn_R2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_R2.Location = New System.Drawing.Point(851, 296)
        Me.btn_R2.Name = "btn_R2"
        Me.btn_R2.Size = New System.Drawing.Size(135, 117)
        Me.btn_R2.TabIndex = 0
        Me.btn_R2.UseVisualStyleBackColor = True
        '
        'btn_R1
        '
        Me.btn_R1.BackgroundImage = CType(resources.GetObject("btn_R1.BackgroundImage"), System.Drawing.Image)
        Me.btn_R1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_R1.Location = New System.Drawing.Point(851, 446)
        Me.btn_R1.Name = "btn_R1"
        Me.btn_R1.Size = New System.Drawing.Size(135, 117)
        Me.btn_R1.TabIndex = 0
        Me.btn_R1.UseVisualStyleBackColor = True
        '
        'lbl_AmountDue
        '
        Me.lbl_AmountDue.AutoSize = True
        Me.lbl_AmountDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AmountDue.Location = New System.Drawing.Point(288, 9)
        Me.lbl_AmountDue.Name = "lbl_AmountDue"
        Me.lbl_AmountDue.Size = New System.Drawing.Size(45, 32)
        Me.lbl_AmountDue.TabIndex = 1
        Me.lbl_AmountDue.Text = "as"
        '
        'lbl_AmountGiven
        '
        Me.lbl_AmountGiven.AutoSize = True
        Me.lbl_AmountGiven.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AmountGiven.Location = New System.Drawing.Point(288, 61)
        Me.lbl_AmountGiven.Name = "lbl_AmountGiven"
        Me.lbl_AmountGiven.Size = New System.Drawing.Size(45, 32)
        Me.lbl_AmountGiven.TabIndex = 1
        Me.lbl_AmountGiven.Text = "as"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "AMOUNT DUE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(238, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "AMOUNT GIVEN:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'btn_CalcChange
        '
        Me.btn_CalcChange.Location = New System.Drawing.Point(569, 7)
        Me.btn_CalcChange.Name = "btn_CalcChange"
        Me.btn_CalcChange.Size = New System.Drawing.Size(171, 105)
        Me.btn_CalcChange.TabIndex = 13
        Me.btn_CalcChange.Text = "CALCULATE CHANGE"
        Me.btn_CalcChange.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(746, 7)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(171, 105)
        Me.btn_Clear.TabIndex = 14
        Me.btn_Clear.Text = "CLEAR"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'btn_OK
        '
        Me.btn_OK.Enabled = False
        Me.btn_OK.Location = New System.Drawing.Point(392, 7)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(171, 105)
        Me.btn_OK.TabIndex = 15
        Me.btn_OK.Text = "OK"
        Me.btn_OK.UseVisualStyleBackColor = True
        '
        'btn_Back
        '
        Me.btn_Back.Location = New System.Drawing.Point(923, 7)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(171, 105)
        Me.btn_Back.TabIndex = 16
        Me.btn_Back.Text = "BACK"
        Me.btn_Back.UseVisualStyleBackColor = True
        '
        'Cash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1124, 682)
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.btn_OK)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_CalcChange)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_AmountGiven)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_AmountDue)
        Me.Controls.Add(Me.btn_R10)
        Me.Controls.Add(Me.btn_R20)
        Me.Controls.Add(Me.btn_R50)
        Me.Controls.Add(Me.btn_R1)
        Me.Controls.Add(Me.btn_R2)
        Me.Controls.Add(Me.btn_R5)
        Me.Controls.Add(Me.btn_R100)
        Me.Controls.Add(Me.btn_R200)
        Me.Name = "Cash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_R200 As System.Windows.Forms.Button
    Friend WithEvents btn_R100 As System.Windows.Forms.Button
    Friend WithEvents btn_R50 As System.Windows.Forms.Button
    Friend WithEvents btn_R20 As System.Windows.Forms.Button
    Friend WithEvents btn_R10 As System.Windows.Forms.Button
    Friend WithEvents btn_R5 As System.Windows.Forms.Button
    Friend WithEvents btn_R2 As System.Windows.Forms.Button
    Friend WithEvents btn_R1 As System.Windows.Forms.Button
    Friend WithEvents lbl_AmountDue As System.Windows.Forms.Label
    Friend WithEvents lbl_AmountGiven As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btn_CalcChange As System.Windows.Forms.Button
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents btn_OK As System.Windows.Forms.Button
    Friend WithEvents btn_Back As System.Windows.Forms.Button
End Class
