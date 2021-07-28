Public Class MenuAñadirEjercicios
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonPiernas.Click
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

    Private Sub Lista1_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles Lista1.ItemCheck
        If Lista1.CheckedItems.Count > 1 Then
            Button6.Enabled = True
        End If

        If Lista1.CheckedItems.Count = 1 And e.NewValue = CheckState.Unchecked Then
            Button6.Enabled = False
        End If

        If Lista1.CheckedItems.Count = 0 And e.NewValue = CheckState.Checked Then
            Button6.Enabled = True
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ButtonFecha.Click
        If Calendario.Visible = True Then
            Calendario.Visible = False
        Else
            Calendario.Visible = True
        End If
    End Sub

    Private Sub Calendario_DateChanged(sender As Object, e As DateRangeEventArgs) Handles Calendario.DateChanged

    End Sub

    Private Sub Lista5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lista5.SelectedIndexChanged

    End Sub
End Class