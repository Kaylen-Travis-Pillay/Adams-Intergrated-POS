﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerDisplay
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
        Me.TableAdapterManager1 = New AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.TableAdapterManager()
        Me.Order_ProductTableAdapter1 = New AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.Order_ProductTableAdapter()
        Me.Order_TableAdapter1 = New AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.Order_TableAdapter()
        Me.CustomerTableAdapter1 = New AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.CustomerTableAdapter()
        Me.Group3DataSet1 = New AdamsCoffeeBar_IntegratedPOS.group3DataSet()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Group3DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.CustomerTableAdapter = Nothing
        Me.TableAdapterManager1.Employee_TypeTableAdapter = Nothing
        Me.TableAdapterManager1.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager1.FreshlyMade_ProductTableAdapter = Nothing
        Me.TableAdapterManager1.FreshlyMadeProduct_IngredientTableAdapter = Nothing
        Me.TableAdapterManager1.Ingredient_StockOrderTableAdapter = Nothing
        Me.TableAdapterManager1.IngredientProportionTableAdapter = Nothing
        Me.TableAdapterManager1.IngredientTableAdapter = Nothing
        Me.TableAdapterManager1.OffTheShelf_ProductTableAdapter = Nothing
        Me.TableAdapterManager1.OffTheShelf_StockOrderTableAdapter = Nothing
        Me.TableAdapterManager1.Order_ProductTableAdapter = Me.Order_ProductTableAdapter1
        Me.TableAdapterManager1.Order_TableAdapter = Me.Order_TableAdapter1
        Me.TableAdapterManager1.Product_TypeTableAdapter = Nothing
        Me.TableAdapterManager1.StockOrderTableAdapter = Nothing
        Me.TableAdapterManager1.SupplierTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Order_ProductTableAdapter1
        '
        Me.Order_ProductTableAdapter1.ClearBeforeFill = True
        '
        'Order_TableAdapter1
        '
        Me.Order_TableAdapter1.ClearBeforeFill = True
        '
        'CustomerTableAdapter1
        '
        Me.CustomerTableAdapter1.ClearBeforeFill = True
        '
        'Group3DataSet1
        '
        Me.Group3DataSet1.DataSetName = "group3DataSet"
        Me.Group3DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1598, 853)
        Me.SplitContainer1.SplitterDistance = 69
        Me.SplitContainer1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.LimeGreen
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1598, 780)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(511, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(536, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Orders Currently Being Made"
        '
        'CustomerDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1598, 853)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "CustomerDisplay"
        Me.Text = "CustomerDisplay"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Group3DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableAdapterManager1 As AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Order_ProductTableAdapter1 As AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.Order_ProductTableAdapter
    Friend WithEvents Order_TableAdapter1 As AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.Order_TableAdapter
    Friend WithEvents CustomerTableAdapter1 As AdamsCoffeeBar_IntegratedPOS.group3DataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents Group3DataSet1 As AdamsCoffeeBar_IntegratedPOS.group3DataSet
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
End Class
