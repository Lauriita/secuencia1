Public Class Form1

    Dim inter As Integer
    Dim salida As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        inter = TextBox2.Text

        For n3 As Integer = 0 To inter Step 2

            salida = n3
            TextBox1.Text = TextBox1.Text + salida & vbNewLine


        Next

    End Sub
End Class
