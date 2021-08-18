Imports System.Data
Imports System.Data.SqlClient
Public Class MenuPrincipal
    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ValidarRango()
    End Sub
    Public Sub ValidarRango()
        Dim stringConection As String
        stringConection = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True”
        Dim stringSelect As String = "SELECT * FROM dbo.Usuarios WHERE (Cedula = " & ModuloLogin.cedula & ")"
        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter(stringSelect, stringConection)
            da.Fill(dt)
        Catch ex As Exception
        End Try


        'If dt.Rows(1).Item(7).ToString = "Admin" Then
        '    ButtonGestionarUsuarios.Visible = True
        'Else
        '    ButtonGestionarUsuarios.Visible = False
        'End If

        'Dim constr As String = ("data source=PROYAZUL; initial catalog = Gym; Integrated Security = True”)

        'Using con As SqlConnection = New SqlConnection(constr)
        '    Using cmd As SqlCommand = New SqlCommand("SELECT * FROM dbo.Usuarios WHERE (Acceso = " + dt. + ")")

        '        cmd.CommandType = CommandType.Text
        '        cmd.Connection = con
        '        con.Open()

        '        Using lector As SqlDataReader = cmd.ExecuteReader()

        '            lector.Read()

        '            If lector("Acceso").ToString = "Admin" Then
        '                ButtonGestionarUsuarios.Visible = True
        '            Else
        '                ButtonGestionarUsuarios.Visible = False
        '            End If

        '        End Using

        '        con.Close()

        '    End Using
        'End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        MenuAñadirEjercicios.Show()
    End Sub


End Class