Imports System.Data
Imports System.Data.SqlClient

Public Class MenuBuscarUsuario
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call BuscarUser()
        'Me.Hide()
        'MenuGestionarEditarUsuario.Show()

    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Hide()
        MenuGestionarUsuarios.Show()
    End Sub
    Public Sub BuscarUser()

        If TextBoxCedula.Text = "" Then
            MsgBox("Debe introducir alguna cédula", MessageBoxIcon.Information, "FIT Tracker")
            Exit Sub
        ElseIf Len(TextBoxCedula.Text) > 9 Then
            MsgBox("La cédula no puede tener más de 9 dígitos", MessageBoxIcon.Error, "FIT Tracker")
            Exit Sub
        ElseIf Len(TextBoxCedula.Text) > 9 Or Len(TextBoxCedula.Text) < 9 Then
            MsgBox("La cédula debe tener al menos 9 dígitos", MessageBoxIcon.Error, "FIT Tracker")
            Exit Sub
        End If

        Dim stringConection As String
        stringConection = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True”
        Dim stringSelect As String = "SELECT dbo.Usuarios.* FROM dbo.Usuarios WHERE (Cedula = " & TextBoxCedula.Text & ")"

        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter(stringSelect, stringConection)
            da.Fill(dt)
        Catch ex As Exception
        End Try

        If (dt.Rows.Count = 0) Then
            MsgBox("Usuario no encontrado. Asegurese de ingresar los datos correctos", MessageBoxIcon.Error, "FIT Tracker")
            Exit Sub
        End If

        If dt.Rows(0).Item(0).ToString = (TextBoxCedula.Text) Then
            ModuloLogin.cedula2 = TextBoxCedula.Text
            Me.Hide()
            MenuGestionarEditarUsuario.Show()
        End If

    End Sub

    Private Sub MenuBuscarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class