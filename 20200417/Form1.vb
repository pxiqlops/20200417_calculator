Public Class keisan
    Dim kigou As Integer = 0
    Dim number1 As Decimal = 0
    Dim number2 As Decimal = 0
    Dim result As String = ""

    Private Sub num0_Click(sender As Object, e As EventArgs) Handles num0.Click
        If kigou = 0 Then
            If answer1.Text = "" Then
                answer1.Text = 0
            Else
                If answer1.Text <> 0 Then
                    answer1.Text = answer1.Text & 0
                End If
            End If
        Else
            If answer3.Text = "" Then
                answer1.Text = answer1.Text & 0
                answer3.Text = 0
            Else
                If answer3.Text = 0 Then
                    answer3.Text = 0
                Else
                    answer3.Text = answer3.Text & 0
                End If
            End If
        End If
    End Sub
    Private Sub num1_Click(sender As Object, e As EventArgs) Handles num1.Click
        push(1)
    End Sub
    Private Sub num2_Click(sender As Object, e As EventArgs) Handles num2.Click
        push(2)
    End Sub
    Private Sub num3_Click(sender As Object, e As EventArgs) Handles num3.Click
        push(3)
    End Sub
    Private Sub num4_Click(sender As Object, e As EventArgs) Handles num4.Click
        push(4)
    End Sub
    Private Sub num5_Click(sender As Object, e As EventArgs) Handles num5.Click
        push(5)
    End Sub
    Private Sub num6_Click(sender As Object, e As EventArgs) Handles num6.Click
        push(6)
    End Sub
    Private Sub num7_Click(sender As Object, e As EventArgs) Handles num7.Click
        push(7)
    End Sub
    Private Sub num8_Click(sender As Object, e As EventArgs) Handles num8.Click
        push(8)
    End Sub
    Private Sub num9_Click(sender As Object, e As EventArgs) Handles num9.Click
        push(9)
    End Sub

    Private Sub deletebt_Click(sender As Object, e As EventArgs) Handles deletebt.Click
        answer1.Text = ""
        answer2.Text = ""
        answer3.Text = ""
        kigo.Text = ""
        kigou = 0
        number1 = 0
        number2 = 0
    End Sub

    Private Sub plusbt_Click(sender As Object, e As EventArgs) Handles plusbt.Click
        If IsNumeric(answer1.Text) = True Then
            number1 = answer1.Text
            kigo.Text = "+"
            kigou = 1
        End If
    End Sub

    Private Sub minbt_Click(sender As Object, e As EventArgs) Handles minbt.Click
        If IsNumeric(answer1.Text) = True Then
            number1 = answer1.Text
            kigo.Text = "-"
            kigou = 2
        End If
    End Sub

    Private Sub multibt_Click(sender As Object, e As EventArgs) Handles multibt.Click
        If IsNumeric(answer1.Text) = True Then
            number1 = answer1.Text
            kigo.Text = "*"
            kigou = 3
        End If
    End Sub

    Private Sub divibt_Click(sender As Object, e As EventArgs) Handles divibt.Click
        If IsNumeric(answer1.Text) = True Then
            number1 = answer1.Text
            kigo.Text = "/"
            kigou = 4
        End If
    End Sub

    Private Sub ansbt_Click(sender As Object, e As EventArgs) Handles ansbt.Click
        If kigou = 0 Then
            MessageBox.Show("数字が入力されておりません", "エラー", MessageBoxButtons.OK)
        Else
            number2 = answer3.Text
            If kigou = 4 And number2 = 0 Then
                MessageBox.Show("0で割ることは出来ません", "エラー", MessageBoxButtons.OK)
            Else
                Select Case kigou
                    Case 1
                        answer2.Text = number1 + number2
                    Case 2
                        answer2.Text = number1 - number2
                    Case 3
                        answer2.Text = number1 * number2
                    Case 4
                        answer2.Text = number1 / number2
                End Select
                resultbox.Text = number1 & kigo.Text & number2 & "=" & answer2.Text & vbCrLf & resultbox.Text
            End If
        End If
    End Sub

    Private Sub pribt_Click(sender As Object, e As EventArgs) Handles pribt.Click
        If answer1.Text.Contains(".") = False Then
            If answer1.Text = "" Then
                answer1.Text = answer1.Text & "0."
            End If
        End If
    End Sub

    Public Sub push(num As Integer)
        If kigou = 0 Then
            If answer1.Text = "" Then
                answer1.Text = num
            Else
                If answer1.Text = 0 Then
                    answer1.Text = num
                Else
                    answer1.Text = answer1.Text & num
                End If
            End If
        Else
            If answer3.Text = "" Then
                answer3.Text = num
            Else
                If answer3.Text = 0 Then
                    answer3.Text = num
                Else
                    answer3.Text = answer3.Text & num
                End If
            End If
        End If
    End Sub

    Private Sub resultreset_Click(sender As Object, e As EventArgs) Handles resultreset.Click
        resultbox.Text = ""
    End Sub
End Class
