Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MenuPrincipalUsuario.Show()
    End Sub
End Class