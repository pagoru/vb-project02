Public Class Form1

    Dim inputs() As TextBox = {
        TextBox1, TextBox2, TextBox3, TextBox4,
        TextBox5, TextBox6, TextBox7, TextBox8
    }
    Private Sub button_order_MouseUp(sender As Object, e As MouseEventArgs) Handles button_order.MouseUp
        Dim orderedNumbers(8) As Double
        If RadioButton_ASC.Checked Then

            For index As Integer = 0 To 7

                Me.Text += CStr(index)
                Dim currentInput As TextBox = inputs(index)
                If currentInput.Text.Length > 0 Then
                    Dim value As Double
                    If Double.TryParse(currentInput.Text, value) Then

                    Else
                        currentInput.Focus()
                        Exit For
                    End If

                End If

            Next

        Else

        End If

    End Sub
End Class
