Public Class ManageEmployees

    Private Sub SearchToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SearchToolStripMenuItem.Click
        LocalFormSetUp(SearchEmployee)
    End Sub

    Private Sub LocalFormSetUp(ByVal ChildForm As Form)
        Try
            If Not (ChildForm.Equals(Me.ActiveMdiChild)) Then
                Me.ActiveMdiChild.Close()
            End If
        Catch ex As Exception
        End Try
        With ChildForm
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub
End Class