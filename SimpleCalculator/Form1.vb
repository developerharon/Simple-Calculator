Public Class Form1

    Dim firstValue As Double
    Dim secondValue As Double
    Dim sign As Int32
    Dim result As Double

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "1"
        Else
            TextBox1.Text += "1"
        End If
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "2"
        Else
            TextBox1.Text += "2"
        End If
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "3"
        Else
            TextBox1.Text += "3"
        End If
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "4"
        Else
            TextBox1.Text += "4"
        End If
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "5"
        Else
            TextBox1.Text += "5"
        End If
    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "6"
        Else
            TextBox1.Text += "6"
        End If
    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "7"
        Else
            TextBox1.Text += "7"
        End If
    End Sub

    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "8"
        Else
            TextBox1.Text += "8"
        End If
    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "9"
        Else
            TextBox1.Text += "9"
        End If
    End Sub

    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "0"
        Else
            TextBox1.Text += "0"
        End If
    End Sub

    Private Sub btnDecimalPoint_Click(sender As Object, e As EventArgs) Handles btnDecimalPoint.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "0"
        Else
            TextBox1.Text += "."
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TextBox1.Text = "0"
        firstValue = 0
        secondValue = 0
        result = 0
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        firstValue = TextBox1.Text
        TextBox1.Text = "0"
        sign = 1
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        firstValue = TextBox1.Text
        TextBox1.Text = "0"
        sign = 2
    End Sub
    Private Sub btnMultiplication_Click(sender As Object, e As EventArgs) Handles btnMultiplication.Click
        firstValue = TextBox1.Text
        TextBox1.Text = "0"
        sign = 3
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        firstValue = TextBox1.Text
        TextBox1.Text = "0"
        sign = 4
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        secondValue = TextBox1.Text

        If sign = 1 Then
            result = firstValue + secondValue
        ElseIf sign = 2 Then
            result = firstValue - secondValue
        ElseIf sign = 3 Then
            result = firstValue * secondValue
        Else
            If secondValue = "0" Then
                MessageBox.Show("Error!\nDivision by zero" + MessageBoxButtons.RetryCancel + MessageBoxIcon.Error)
            Else
                result = firstValue / secondValue
            End If
        End If

        TextBox1.Text = result
    End Sub
End Class
