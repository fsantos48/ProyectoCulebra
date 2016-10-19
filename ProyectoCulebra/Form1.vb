Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Beep()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.BackColor = Color.LightGoldenrodYellow

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Beep()
        Beep()
        Beep()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Numero1 As Int16 = 23
        Dim Numero2 As Int16 = 2
        Dim Resultado As Int16
        Resultado = Numero1 + Numero2
        MessageBox.Show(Resultado)
    End Sub
End Class
