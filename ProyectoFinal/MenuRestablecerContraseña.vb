Imports System.Data
Imports System.Data.SqlClient
Public Class MenuRestablecerContraseña
    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub BotonConsultar_Click(sender As Object, e As EventArgs) Handles BotonConsultar.Click

        If TextBoxConsultar.Text = "" Then
            MsgBox("Debe ingresar su número de cédula", MessageBoxIcon.Information, "FIT Tracker")
            Exit Sub
        End If

        Dim conn As New SqlConnection
        conn.ConnectionString = ("data source=PROYAZUL; initial catalog = Gym; Integrated Security = True")

        conn.Open()
        Dim strsql As String

        strsql = " SELECT * FROM Usuarios WHERE Cedula =" + TextBoxConsultar.Text + ""

        Dim cmd As New SqlCommand(strsql, conn)

        Dim lector As SqlDataReader

        Try

            lector = cmd.ExecuteReader
            lector.Read()
            MsgBox("Tu contraseña es: " + lector("Contraseña"), MessageBoxIcon.Information, "FIT Tracker")
            Exit Sub
        Catch ex As Exception
            MsgBox("Cedula incorrecta", MessageBoxIcon.Error, "FIT Tracker")
        End Try


    End Sub
End Class