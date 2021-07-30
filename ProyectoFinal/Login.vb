Imports System.Data
Imports System.Data.SqlClient

Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        MenuPrincipalUsuario.Show()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class
