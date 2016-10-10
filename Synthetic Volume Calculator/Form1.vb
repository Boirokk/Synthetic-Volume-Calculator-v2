Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Declare variables
        Dim decA As Double
        Dim decB As Double
        Dim decC As Double
        Dim decD As Double
        Dim decE As Double
        Dim decF As Double
        Dim decG As Double
        Dim dblgrams As Double
        Dim dblbaseA As Double
        Dim dblCatB As Double

        ' If the textbox is empty assign 0 to the variable
        If txtA.Text = String.Empty Then
            txtA.Text = CStr(0)
            decA = CDbl(txtA.Text)
        Else
            decA = CDbl(txtA.Text)
        End If

        If txtB.Text = String.Empty Then
            txtB.Text = CStr(0)
            decB = CDbl(txtB.Text)
        Else
            decB = CDbl(txtB.Text)
        End If

        If txtC.Text = String.Empty Then
            txtC.Text = CStr(0)
            decC = CDbl(txtC.Text)
        Else
            decC = CDbl(txtC.Text)
        End If

        If txtD.Text = String.Empty Then
            txtD.Text = CStr(0)
            decD = CDbl(txtD.Text)
        Else
            decD = CDbl(txtD.Text)
        End If

        If txtE.Text = String.Empty Then
            txtE.Text = CStr(0)
            decE = CDbl(txtE.Text)
        Else
            decE = CDbl(txtE.Text)
        End If

        If txtF.Text = String.Empty Then
            txtF.Text = CStr(0)
            decF = CDbl(txtF.Text)
        Else
            decF = CDbl(txtF.Text)
        End If

        If txtG.Text = String.Empty Then
            txtG.Text = CStr(0)
            decG = CDbl(txtG.Text)
        Else
            decG = CDbl(txtG.Text)
        End If

        ' If the Inches radio button is checked convert to mm.
        If rbtnAInches.Checked Then
            decA = decA * 25.4
        End If

        If rbtnBInches.Checked Then
            decB = decB * 25.4
        End If

        If rbtnCInches.Checked Then
            decC = decC * 25.4
        End If

        If rbtnDInches.Checked Then
            decD = decD * 25.4
        End If

        If rbtnEInches.Checked Then
            decE = decE * 25.4
        End If

        If rbtnFInches.Checked Then
            decF = decF * 25.4
        End If

        If rbtnGInches.Checked Then
            decG = decG * 25.4
        ElseIf rbtnGFeet.Checked Then
            decG = decG * 304.8
        End If



        ' Do calculations
        Dim sectionArea As Double = (decA * decB) + ((decF - decB) * decE) - (decD * decC)
        dblgrams = Math.Round(Val((sectionArea * 0.000001) * decG * 1.5), 3)
        dblbaseA = Math.Round(Val((dblgrams / 25) * 19), 3)
        dblCatB = Math.Round(Val((dblgrams / 25) * 6), 3)

        ' Display the answer to the label
        lblAnswer.Text = "Total kit = " & dblgrams.ToString() & " Kg"
        lblBaseA.Text = "Base A = " & dblbaseA.ToString() & "  Kg"
        lblCatalystB.Text = "Catalyst B = " & dblCatB.ToString() & " Kg"
        lblAnswer.Visible = True
        lblCatalystB.Visible = True
        lblBaseA.Visible = True

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtA.TextChanged
        lblA.Text = txtA.Text
    End Sub

    Private Sub txtB_TextChanged(sender As Object, e As EventArgs) Handles txtB.TextChanged
        lblB.Text = txtB.Text
    End Sub

    Private Sub txtC_TextChanged(sender As Object, e As EventArgs) Handles txtC.TextChanged
        lblC.Text = txtC.Text
    End Sub

    Private Sub txtD_TextChanged(sender As Object, e As EventArgs) Handles txtD.TextChanged
        lblD.Text = txtD.Text
    End Sub

    Private Sub txtE_TextChanged(sender As Object, e As EventArgs) Handles txtE.TextChanged
        lblE.Text = txtE.Text
    End Sub

    Private Sub txtF_TextChanged(sender As Object, e As EventArgs) Handles txtF.TextChanged
        lblF.Text = txtF.Text
    End Sub

    Private Sub txtG_TextChanged(sender As Object, e As EventArgs) Handles txtG.TextChanged
        lblG.Text = txtG.Text
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtA.Focus()
        txtA.Text = String.Empty
        txtB.Text = String.Empty
        txtC.Text = String.Empty
        txtD.Text = String.Empty
        txtE.Text = String.Empty
        txtF.Text = String.Empty
        txtG.Text = String.Empty

        lblA.Text = "A"
        lblB.Text = "B"
        lblC.Text = "C"
        lblD.Text = "D"
        lblE.Text = "E"
        lblF.Text = "F"
        lblG.Text = "G"
        lblAnswer.Text = String.Empty
        lblCatalystB.Text = String.Empty
        lblBaseA.Text = String.Empty
        lblAnswer.Visible = False
        lblBaseA.Visible = False
        lblCatalystB.Visible = False

        rbtnAmm.Checked = True
        rbtnBmm.Checked = True
        rbtnCmm.Checked = True
        rbtnDmm.Checked = True
        rbtnEmm.Checked = True
        rbtnFmm.Checked = True
        rbtnGmm.Checked = True

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbtnAmm.Checked = True
        rbtnBmm.Checked = True
        rbtnCmm.Checked = True
        rbtnDmm.Checked = True
        rbtnEmm.Checked = True
        rbtnFmm.Checked = True
        rbtnGmm.Checked = True
    End Sub
End Class
