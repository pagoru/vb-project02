Public Class Form1

    Dim textBoxs() As TextBox

    Private Sub button_order_MouseUp(sender As Object, e As MouseEventArgs) Handles button_order.MouseUp
        textBoxs = {
            TextBox1, TextBox2, TextBox3, TextBox4,
            TextBox5, TextBox6, TextBox7, TextBox8
        }

        Dim orderedNumbers(8) As Double
        Dim canOrder As Boolean = True
        Dim counter As Int64 = 0

        For index As Integer = 0 To 7

            Dim textBox As TextBox = textBoxs(index)
            Dim number As Int64

            textBox.BackColor = Color.White

            If Double.TryParse(textBox.Text, number) Then

                orderedNumbers(counter) = number
                counter += 1

            Else
                If textBox.Text IsNot "" Then

                    textBox.Focus()
                    textBox.BackColor = Color.Red
                    canOrder = False
                    Exit For
                End If
            End If
        Next
        counter -= 1

        If canOrder Then

            Dim newNumbers(counter) As Double
            For index As Integer = 0 To counter
                newNumbers(index) = orderedNumbers(index)
            Next

            For index As Integer = 0 To 7
                Dim textBox As TextBox = textBoxs(index)
                textBox.Text = ""
            Next

            Array.Sort(newNumbers)
            If RadioButton_ASC.Checked Then

                For index As Integer = 0 To counter
                    Dim textBox As TextBox = textBoxs(index)
                    textBox.Text = newNumbers(index)
                Next
            Else
                Array.Reverse(newNumbers)

                Dim index2 As Integer = 0
                For index As Integer = 7 - counter To 7
                    Dim textBox As TextBox = textBoxs(index)
                    textBox.Text = newNumbers(index2)
                    index2 += 1
                Next

            End If
        End If
    End Sub

    Private Function getParsedDouble(textbox As TextBox)
        If textbox.Text.Length = 0 Then
            Return Nothing
        End If
        Dim number As Double
        If Double.TryParse(textbox.Text, number) Then
            Return number
        Else
            textbox.Focus()
            Return Nothing
        End If
    End Function
End Class
