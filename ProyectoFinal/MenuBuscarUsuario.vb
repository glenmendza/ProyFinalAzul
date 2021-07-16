Public Class MenuBuscarUsuario
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MenuGestionarEditarUsuario.Show()
    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Hide()
        MenuGestionarUsuarios.Show()
    End Sub
End Class