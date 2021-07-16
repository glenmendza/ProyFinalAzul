Public Class MenuGestionarUsuarios
    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub

    Private Sub btnEditarUsuario_Click(sender As Object, e As EventArgs) Handles btnEditarUsuario.Click
        Me.Hide()
        MenuBuscarUsuario.Show()
    End Sub

    Private Sub btnAñadirUsuario_Click(sender As Object, e As EventArgs) Handles btnAñadirUsuario.Click
        Me.Hide()
        MenuGestionarAñadirUsuario.Show()
    End Sub
End Class