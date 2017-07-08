Public Class Keypad
    Dim currentPosition As Integer = 0
    Private Sub btnQ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQ.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            If txtDisplay.Text.Length = 0 Then
                txtDisplay.Text = txtDisplay.Text & "Q"
            Else
                txtDisplay.Text = txtDisplay.Text & "q"
            End If
            currentPosition += 1
            txtDisplay.SelectionStart = currentPosition
        Else
            If currentPosition = 0 Then
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "Q" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            Else
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "q" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            End If
        End If

    End Sub

    Private Sub btnW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnW.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            If txtDisplay.Text.Length = 0 Then
                txtDisplay.Text = txtDisplay.Text & "W"
            Else
                txtDisplay.Text = txtDisplay.Text & "w"
            End If
            currentPosition += 1
            txtDisplay.SelectionStart = currentPosition
        Else
            If currentPosition = 0 Then
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "W" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            Else
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "w" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            End If
        End If
    End Sub

    Private Sub btnE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnE.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            If txtDisplay.Text.Length = 0 Then
                txtDisplay.Text = txtDisplay.Text & "E"
            Else
                txtDisplay.Text = txtDisplay.Text & "e"
            End If
            currentPosition += 1
            txtDisplay.SelectionStart = currentPosition
        Else
            If currentPosition = 0 Then
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "E" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            Else
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "e" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            End If
        End If
    End Sub

    Private Sub btnR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnR.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            If txtDisplay.Text.Length = 0 Then
                txtDisplay.Text = txtDisplay.Text & "R"
            Else
                txtDisplay.Text = txtDisplay.Text & "r"
            End If
            currentPosition += 1
            txtDisplay.SelectionStart = currentPosition
        Else
            If currentPosition = 0 Then
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "R" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            Else
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "r" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            End If
        End If
    End Sub

    Private Sub btnT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnT.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            If txtDisplay.Text.Length = 0 Then
                txtDisplay.Text = txtDisplay.Text & "T"
            Else
                txtDisplay.Text = txtDisplay.Text & "t"
            End If
            currentPosition += 1
            txtDisplay.SelectionStart = currentPosition
        Else
            If currentPosition = 0 Then
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "T" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            Else
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "t" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            End If
        End If
    End Sub

    Private Sub btnY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnY.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            If txtDisplay.Text.Length = 0 Then
                txtDisplay.Text = txtDisplay.Text & "Y"
            Else
                txtDisplay.Text = txtDisplay.Text & "y"
            End If
            currentPosition += 1
            txtDisplay.SelectionStart = currentPosition
        Else
            If currentPosition = 0 Then
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "Y" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            Else
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "y" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            End If
        End If
    End Sub

    Private Sub btnU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnU.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            If txtDisplay.Text.Length = 0 Then
                txtDisplay.Text = txtDisplay.Text & "U"
            Else
                txtDisplay.Text = txtDisplay.Text & "u"
            End If
            currentPosition += 1
            txtDisplay.SelectionStart = currentPosition
        Else
            If currentPosition = 0 Then
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "U" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            Else
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "u" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            End If
        End If
    End Sub

    Private Sub btnI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnI.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            If txtDisplay.Text.Length = 0 Then
                txtDisplay.Text = txtDisplay.Text & "I"
            Else
                txtDisplay.Text = txtDisplay.Text & "i"
            End If
            currentPosition += 1
            txtDisplay.SelectionStart = currentPosition
        Else
            If currentPosition = 0 Then
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "I" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            Else
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "i" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            End If
        End If
    End Sub

    Private Sub btnO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnO.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            If txtDisplay.Text.Length = 0 Then
                txtDisplay.Text = txtDisplay.Text & "O"
            Else
                txtDisplay.Text = txtDisplay.Text & "o"
            End If
            currentPosition += 1
            txtDisplay.SelectionStart = currentPosition
        Else
            If currentPosition = 0 Then
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "O" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            Else
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "o" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            End If
        End If
    End Sub

    Private Sub btnP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnP.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            If txtDisplay.Text.Length = 0 Then
                txtDisplay.Text = txtDisplay.Text & "P"
            Else
                txtDisplay.Text = txtDisplay.Text & "p"
            End If
            currentPosition += 1
            txtDisplay.SelectionStart = currentPosition
        Else
            If currentPosition = 0 Then
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "P" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            Else
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "p" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            End If
        End If
    End Sub

    Private Sub btnA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            If txtDisplay.Text.Length = 0 Then
                txtDisplay.Text = txtDisplay.Text & "A"
            Else
                txtDisplay.Text = txtDisplay.Text & "a"
            End If
            currentPosition += 1
            txtDisplay.SelectionStart = currentPosition
        Else
            If currentPosition = 0 Then
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "A" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            Else
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "a" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            End If
        End If
    End Sub

    Private Sub btnS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnS.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            If txtDisplay.Text.Length = 0 Then
                txtDisplay.Text = txtDisplay.Text & "S"
            Else
                txtDisplay.Text = txtDisplay.Text & "s"
            End If
            currentPosition += 1
            txtDisplay.SelectionStart = currentPosition
        Else
            If currentPosition = 0 Then
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "S" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            Else
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "s" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            End If
        End If
    End Sub

    Private Sub btnD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnD.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            If txtDisplay.Text.Length = 0 Then
                txtDisplay.Text = txtDisplay.Text & "D"
            Else
                txtDisplay.Text = txtDisplay.Text & "d"
            End If
            currentPosition += 1
            txtDisplay.SelectionStart = currentPosition
        Else
            If currentPosition = 0 Then
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "D" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            Else
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "d" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            End If
        End If
    End Sub

    Private Sub btnF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            If txtDisplay.Text.Length = 0 Then
                txtDisplay.Text = txtDisplay.Text & "F"
            Else
                txtDisplay.Text = txtDisplay.Text & "f"
            End If
            currentPosition += 1
            txtDisplay.SelectionStart = currentPosition
        Else
            If currentPosition = 0 Then
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "F" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            Else
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "f" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            End If
        End If
    End Sub

    Private Sub btnG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnG.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            If txtDisplay.Text.Length = 0 Then
                txtDisplay.Text = txtDisplay.Text & "G"
            Else
                txtDisplay.Text = txtDisplay.Text & "g"
            End If
            currentPosition += 1
            txtDisplay.SelectionStart = currentPosition
        Else
            If currentPosition = 0 Then
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "G" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            Else
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "g" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            End If
        End If
    End Sub

    Private Sub btnH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnH.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            If txtDisplay.Text.Length = 0 Then
                txtDisplay.Text = txtDisplay.Text & "H"
            Else
                txtDisplay.Text = txtDisplay.Text & "h"
            End If
            currentPosition += 1
            txtDisplay.SelectionStart = currentPosition
        Else
            If currentPosition = 0 Then
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "H" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            Else
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "h" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            End If
        End If
    End Sub

    Private Sub btnJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJ.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            If txtDisplay.Text.Length = 0 Then
                txtDisplay.Text = txtDisplay.Text & "J"
            Else
                txtDisplay.Text = txtDisplay.Text & "j"
            End If
            currentPosition += 1
            txtDisplay.SelectionStart = currentPosition
        Else
            If currentPosition = 0 Then
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "J" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            Else
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "j" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            End If
        End If
    End Sub

    Private Sub btnK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnK.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            If txtDisplay.Text.Length = 0 Then
                txtDisplay.Text = txtDisplay.Text & "K"
            Else
                txtDisplay.Text = txtDisplay.Text & "k"
            End If
            currentPosition += 1
            txtDisplay.SelectionStart = currentPosition
        Else
            If currentPosition = 0 Then
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "K" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            Else
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "k" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            End If
        End If
    End Sub

    Private Sub btnL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnL.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            If txtDisplay.Text.Length = 0 Then
                txtDisplay.Text = txtDisplay.Text & "L"
            Else
                txtDisplay.Text = txtDisplay.Text & "l"
            End If
            currentPosition += 1
            txtDisplay.SelectionStart = currentPosition
        Else
            If currentPosition = 0 Then
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "L" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            Else
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "l" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            End If
        End If
    End Sub

    Private Sub btnZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZ.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            If txtDisplay.Text.Length = 0 Then
                txtDisplay.Text = txtDisplay.Text & "Z"
            Else
                txtDisplay.Text = txtDisplay.Text & "z"
            End If
            currentPosition += 1
            txtDisplay.SelectionStart = currentPosition
        Else
            If currentPosition = 0 Then
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "Z" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            Else
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "z" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            End If
        End If
    End Sub

    Private Sub btnX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnX.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            If txtDisplay.Text.Length = 0 Then
                txtDisplay.Text = txtDisplay.Text & "X"
            Else
                txtDisplay.Text = txtDisplay.Text & "x"
            End If
            currentPosition += 1
            txtDisplay.SelectionStart = currentPosition
        Else
            If currentPosition = 0 Then
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "X" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            Else
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "x" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            End If
        End If
    End Sub

    Private Sub btnC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            If txtDisplay.Text.Length = 0 Then
                txtDisplay.Text = txtDisplay.Text & "C"
            Else
                txtDisplay.Text = txtDisplay.Text & "c"
            End If
            currentPosition += 1
            txtDisplay.SelectionStart = currentPosition
        Else
            If currentPosition = 0 Then
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "C" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            Else
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "c" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            End If
        End If
    End Sub

    Private Sub btnV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnV.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            If txtDisplay.Text.Length = 0 Then
                txtDisplay.Text = txtDisplay.Text & "V"
            Else
                txtDisplay.Text = txtDisplay.Text & "v"
            End If
            currentPosition += 1
            txtDisplay.SelectionStart = currentPosition
        Else
            If currentPosition = 0 Then
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "V" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            Else
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "v" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            End If
        End If
    End Sub

    Private Sub btnB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnB.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            If txtDisplay.Text.Length = 0 Then
                txtDisplay.Text = txtDisplay.Text & "B"
            Else
                txtDisplay.Text = txtDisplay.Text & "b"
            End If
            currentPosition += 1
            txtDisplay.SelectionStart = currentPosition
        Else
            If currentPosition = 0 Then
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "B" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            Else
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "b" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            End If
        End If
    End Sub

    Private Sub btnN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnN.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            If txtDisplay.Text.Length = 0 Then
                txtDisplay.Text = txtDisplay.Text & "N"
            Else
                txtDisplay.Text = txtDisplay.Text & "n"
            End If
            currentPosition += 1
            txtDisplay.SelectionStart = currentPosition
        Else
            If currentPosition = 0 Then
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "N" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            Else
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "n" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            End If
        End If
    End Sub

    Private Sub btnM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnM.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            If txtDisplay.Text.Length = 0 Then
                txtDisplay.Text = txtDisplay.Text & "M"
            Else
                txtDisplay.Text = txtDisplay.Text & "m"
            End If
            currentPosition += 1
            txtDisplay.SelectionStart = currentPosition
        Else
            If currentPosition = 0 Then
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "M" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            Else
                txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "m" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
                currentPosition += 1
                txtDisplay.SelectionStart = currentPosition
            End If
        End If
    End Sub

    Private Sub btn_DOT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DOT.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            txtDisplay.Text = txtDisplay.Text & "."
        Else
            txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "." + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
        End If

        currentPosition += 1
        txtDisplay.SelectionStart = currentPosition
    End Sub

    Private Sub btn_AT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AT.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            txtDisplay.Text = txtDisplay.Text & "@"
        Else
            txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "@" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
        End If

        currentPosition += 1
        txtDisplay.SelectionStart = currentPosition
    End Sub


    Private Sub btnSpace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpace.Click
        txtDisplay.Focus()

        txtDisplay.Text = txtDisplay.Text & " "

        currentPosition += 1
        txtDisplay.SelectionStart = currentPosition
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub btn_LeftArrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_LeftArrow.Click
        txtDisplay.Focus()
        If currentPosition > 0 Then
            currentPosition -= 1
        End If

        txtDisplay.SelectionStart = currentPosition
    End Sub

    Private Sub btnRightArrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRightArrow.Click
        txtDisplay.Focus()
        If currentPosition < txtDisplay.Text.Length Then
            currentPosition += 1
        End If

        txtDisplay.SelectionStart = currentPosition
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If currentPosition = 0 Then

        ElseIf currentPosition = txtDisplay.Text.Length Then
            txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition - 1)
            currentPosition -= 1
            txtDisplay.SelectionStart = currentPosition
        Else
            txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition - 1) + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
            currentPosition -= 1
            txtDisplay.SelectionStart = currentPosition
        End If
    End Sub

    Public Property Note As String
        Get
            Return txtDisplay.Text
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    
    Private Sub btn_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_1.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            txtDisplay.Text = txtDisplay.Text & "1"
        Else
            txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "1" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
        End If

        currentPosition += 1
        txtDisplay.SelectionStart = currentPosition
    End Sub

    Private Sub btn_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_2.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            txtDisplay.Text = txtDisplay.Text & "2"
        Else
            txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "2" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
        End If

        currentPosition += 1
        txtDisplay.SelectionStart = currentPosition
    End Sub

    Private Sub btn_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_3.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            txtDisplay.Text = txtDisplay.Text & "3"
        Else
            txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "3" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
        End If

        currentPosition += 1
        txtDisplay.SelectionStart = currentPosition
    End Sub

    Private Sub btn_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_4.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            txtDisplay.Text = txtDisplay.Text & "4"
        Else
            txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "4" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
        End If

        currentPosition += 1
        txtDisplay.SelectionStart = currentPosition
    End Sub

    Private Sub btn_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_5.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            txtDisplay.Text = txtDisplay.Text & "5"
        Else
            txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "5" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
        End If

        currentPosition += 1
        txtDisplay.SelectionStart = currentPosition
    End Sub

    Private Sub btn_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_6.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            txtDisplay.Text = txtDisplay.Text & "6"
        Else
            txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "6" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
        End If

        currentPosition += 1
        txtDisplay.SelectionStart = currentPosition
    End Sub

    Private Sub btn_7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_7.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            txtDisplay.Text = txtDisplay.Text & "7"
        Else
            txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "7" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
        End If

        currentPosition += 1
        txtDisplay.SelectionStart = currentPosition
    End Sub

    Private Sub btn_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_8.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            txtDisplay.Text = txtDisplay.Text & "8"
        Else
            txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "8" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
        End If

        currentPosition += 1
        txtDisplay.SelectionStart = currentPosition
    End Sub

    Private Sub btn_9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_9.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            txtDisplay.Text = txtDisplay.Text & "9"
        Else
            txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "9" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
        End If

        currentPosition += 1
        txtDisplay.SelectionStart = currentPosition
    End Sub

    Private Sub btn_0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_0.Click
        txtDisplay.Focus()
        If currentPosition = txtDisplay.Text.Length Then
            txtDisplay.Text = txtDisplay.Text & "0"
        Else
            txtDisplay.Text = txtDisplay.Text.Substring(0, currentPosition) + "0" + txtDisplay.Text.Substring(currentPosition, txtDisplay.Text.Length - currentPosition)
        End If

        currentPosition += 1
        txtDisplay.SelectionStart = currentPosition
    End Sub

    WriteOnly Property Keypad() As String
        Set(ByVal Value As String)
            txtDisplay.Text = Value
            currentPosition = Value.Length
        End Set
    End Property

    Private Sub Keypad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDisplay.Focus()
    End Sub
End Class