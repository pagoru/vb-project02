Public Class Form1

    Private Sub button_order_MouseUp(sender As Object, e As MouseEventArgs) Handles button_order.MouseUp
        Dim orderedNumbers(7) As Double

        orderedNumbers(0) = getParsedDouble(TextBox1)
        orderedNumbers(1) = getParsedDouble(TextBox2)
        orderedNumbers(2) = getParsedDouble(TextBox3)
        orderedNumbers(3) = getParsedDouble(TextBox4)
        orderedNumbers(4) = getParsedDouble(TextBox5)
        orderedNumbers(5) = getParsedDouble(TextBox6)
        orderedNumbers(6) = getParsedDouble(TextBox7)
        orderedNumbers(7) = getParsedDouble(TextBox8)

        Me.Text = getParsedDouble(TextBox1)

        If RadioButton_ASC.Checked Then
            Array.Sort(orderedNumbers)
            Array.Reverse(orderedNumbers)
        Else
            Array.Sort(orderedNumbers)
        End If

        TextBox1.Text = CStr(orderedNumbers(0))
        TextBox2.Text = CStr(orderedNumbers(1))
        TextBox3.Text = CStr(orderedNumbers(2))
        TextBox4.Text = CStr(orderedNumbers(3))
        TextBox5.Text = CStr(orderedNumbers(4))
        TextBox6.Text = CStr(orderedNumbers(5))
        TextBox7.Text = CStr(orderedNumbers(6))
        TextBox8.Text = CStr(orderedNumbers(7))

    End Sub

    Private Function getParsedDouble(textbox As TextBox)
        If textbox.Text.Length = 0 Then
            Return Nothing
        End If
        Dim number As Double
        If Double.TryParse(textbox.Text, Number) Then
            Return Number
        Else
            textbox.Focus()
            Return Nothing
        End If
    End Function

End Class
