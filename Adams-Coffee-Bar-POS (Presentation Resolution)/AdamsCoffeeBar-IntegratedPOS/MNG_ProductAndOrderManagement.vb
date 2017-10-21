Imports System.Web
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Collections

Public Class MNG_ProductAndOrderManagement

    Dim m_PRODUCTID As Integer = 0

    Private Sub MNG_ProductAndOrderManagement_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group3DataSet.FreshlyMade_Product' table. You can move, or remove it, as needed
        FreshlyMade_ProductTableAdapter1.Fill(Group3DataSet.FreshlyMade_Product)
        OffTheShelf_ProductTableAdapter1.Fill(Group3DataSet.OffTheShelf_Product)

        Try
            For i As Integer = 0 To Group3DataSet.FreshlyMade_Product.Rows.Count - 1 Step 1
                CB_products.Items.Add(Group3DataSet.FreshlyMade_Product.Rows(i).Item(4).ToString)
            Next

            For j As Integer = 0 To Group3DataSet.OffTheShelf_Product.Rows.Count - 1 Step 1
                CB_products.Items.Add(Group3DataSet.OffTheShelf_Product.Rows(j).Item(3).ToString)
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToggleTB(ByVal b As Boolean)
        TB_cost.Enabled = b
        TB_desc.Enabled = b
        TB_name.Enabled = b
        TB_price.Enabled = b
    End Sub

    Private Sub ClearTB()
        TB_cost.Text = ""
        TB_desc.Text = ""
        TB_name.Text = ""
        TB_price.Text = ""
        TB_type.Text = ""
    End Sub

    Private Sub CB_products_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CB_products.SelectedIndexChanged
        Try
            ToggleTB(False)
            DGV_Ingredients.Rows.Clear()
            Dim h As String = CB_products.SelectedItem
            FreshlyMade_ProductTableAdapter1.FillByName(Group3DataSet.FreshlyMade_Product, h)
            If Group3DataSet.FreshlyMade_Product.Rows.Count > 0 Then
                m_PRODUCTID = Group3DataSet.FreshlyMade_Product.Rows(0).Item(0)
                TB_type.Text = "Freshly Made"
                TB_name.Text = Group3DataSet.FreshlyMade_Product.Rows(0).Item(4).ToString
                TB_desc.Text = Group3DataSet.FreshlyMade_Product.Rows(0).Item(2).ToString
                TB_cost.Text = FormatCurrency(Group3DataSet.FreshlyMade_Product.Rows(0).Item(1), 2)
                TB_price.Text = FormatCurrency(Group3DataSet.FreshlyMade_Product.Rows(0).Item(3), 2)

                FreshlyMadeProduct_IngredientTableAdapter1.FillByProductID(Group3DataSet.FreshlyMadeProduct_Ingredient, m_PRODUCTID)

                For k As Integer = 0 To Group3DataSet.FreshlyMadeProduct_Ingredient.Rows.Count - 1 Step 1
                    Dim u As String = IngredientTableAdapter1.GetIngrediant(Group3DataSet.FreshlyMadeProduct_Ingredient.Rows(k).Item(1)).Rows(0).Item(5)
                    Dim w As String = IngredientProportionTableAdapter1.GetDataBy(IngredientTableAdapter1.GetIngrediant(Group3DataSet.FreshlyMadeProduct_Ingredient.Rows(k).Item(1)).Rows(0).Item(6)).Rows(0).Item(1)
                    DGV_Ingredients.Rows.Add(Group3DataSet.FreshlyMadeProduct_Ingredient.Rows(k).Item(2), u, w)
                Next

                DGV_Ingredients.Visible = True
            End If
        Catch ex As Exception
            MsgBox("ERROR")
        End Try

        Try
            ToggleTB(False)
            Dim h As String = CB_products.SelectedItem
            OffTheShelf_ProductTableAdapter1.FillByProductDescription(Group3DataSet.OffTheShelf_Product, h)

            If Group3DataSet.OffTheShelf_Product.Rows.Count > 0 Then
                MsgBox("OffTheShelf")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TB_cost.Enabled = True Then
            ToggleTB(False)
        Else
            ToggleTB(True)
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            If TB_type.Text = "Freshly Made" Then
                FreshlyMade_ProductTableAdapter1.UpdateFMProduct(TB_cost.Text, TB_desc.Text, TB_price.Text, TB_name.Text, m_PRODUCTID, m_PRODUCTID)
                ToggleTB(False)
                CB_products.ResetText()
                MsgBox("Product details saved!")
                ClearTB()
            End If

        Catch ex As Exception
            MessageBox.Show("Invalid Input", "Error: Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ToggleTB(False)
            CB_products.ResetText()
            ClearTB()
        End Try

    End Sub

    Private Sub DGV_Ingredients_RowHeaderMouseClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV_Ingredients.RowHeaderMouseClick
        IngredientTableAdapter1.FillByName(Group3DataSet.Ingredient, DGV_Ingredients.Rows(e.RowIndex).Cells(1).Value)

        tbx_ingreName.Text = Group3DataSet.Ingredient.Rows(0).Item(5).ToString
        tbx_ingreCost.Text = Group3DataSet.Ingredient.Rows(0).Item(1).ToString
        tbx_ingreQTY.Text = Group3DataSet.Ingredient.Rows(0).Item(2).ToString
        txb_reThresh.Text = Group3DataSet.Ingredient.Rows(0).Item(4).ToString
        txb_ingreDesc.Text = Group3DataSet.Ingredient.Rows(0).Item(3).ToString
    End Sub
End Class