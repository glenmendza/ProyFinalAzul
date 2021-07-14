Public Class MenuAñadirEjercicios
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Lista1.Visible = True Then
            Lista1.Visible = False
        Else
            Lista1.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Lista2.Visible = True Then
            Lista2.Visible = False
        Else
            Lista2.Visible = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Lista3.Visible = True Then
            Lista3.Visible = False
        Else
            Lista3.Visible = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Lista4.Visible = True Then
            Lista4.Visible = False
        Else
            Lista4.Visible = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Lista5.Visible = True Then
            Lista5.Visible = False
        Else
            Lista5.Visible = True
        End If
    End Sub


End Class