Public Class MenuPrincipal

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonAñadirEjercicios.Click
        MenuAñadirEjercicios.Show()
    End Sub

    Private Sub ButtonModificarDatos_Click(sender As Object, e As EventArgs) Handles ButtonModificarDatos.Click
        MenuModificarDatos.Show()
    End Sub

    Private Sub ButtonGestionarUsuarios_Click(sender As Object, e As EventArgs) Handles ButtonGestionarUsuarios.Click
        MenuGestionarUsuarios.Show()
    End Sub

    Private Sub ButtonAgenda_Click(sender As Object, e As EventArgs) Handles ButtonAgenda.Click
        MenuAgenda.Show()
    End Sub

    Private Sub ButtonEstadisticas_Click(sender As Object, e As EventArgs) Handles ButtonEstadisticas.Click
        MenuEstadisticas.Show()
    End Sub
End Class