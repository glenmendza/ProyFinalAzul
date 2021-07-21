Public Class MenuPrincipalUsuario
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub ButtonAñadirEjercicios_Click(sender As Object, e As EventArgs) Handles ButtonAñadirEjercicios.Click
        Me.Hide()
        MenuAñadirEjercicios.Show()
    End Sub

    Private Sub ButtonModificarDatos_Click(sender As Object, e As EventArgs) Handles ButtonModificarDatos.Click
        Me.Hide()
        MenuModificarDatos.Show()
    End Sub

    Private Sub ButtonAgenda_Click(sender As Object, e As EventArgs) Handles ButtonAgenda.Click
        Me.Hide()
        MenuAgenda.Show()
    End Sub

    Private Sub ButtonEstadisticas_Click(sender As Object, e As EventArgs) Handles ButtonEstadisticas.Click
        Me.Hide()
        MenuEstadisticas.Show()
    End Sub
End Class