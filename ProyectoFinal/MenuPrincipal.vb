Public Class MenuPrincipal

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonAñadirEjercicios.Click
        Me.Hide()
        MenuAñadirEjercicios.Show()
    End Sub

    Private Sub ButtonModificarDatos_Click(sender As Object, e As EventArgs) Handles ButtonModificarDatos.Click
        Me.Hide()
        MenuModificarDatos.Show()
    End Sub

    Private Sub ButtonGestionarUsuarios_Click(sender As Object, e As EventArgs) Handles ButtonGestionarUsuarios.Click
        Me.Hide()
        MenuGestionarUsuarios.Show()
    End Sub

    Private Sub ButtonAgenda_Click(sender As Object, e As EventArgs) Handles ButtonAgenda.Click
        Me.Hide()
        MenuAgenda.Show()
    End Sub

    Private Sub ButtonEstadisticas_Click(sender As Object, e As EventArgs) Handles ButtonEstadisticas.Click
        Me.Hide()
        MenuEstadisticas.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Login.Show()
    End Sub

End Class