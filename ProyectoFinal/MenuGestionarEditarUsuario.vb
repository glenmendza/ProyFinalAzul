﻿Imports System.Data
Imports System.Data.SqlClient
Public Class MenuGestionarEditarUsuario

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Hide()
        MenuBuscarUsuario.Show()

    End Sub

    Private Sub MenuGestionarEditarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxCedula.Text = cedula2
        Dim constr As String = ("data source=PROYAZUL; initial catalog = Gym; Integrated Security = True”)
        Using con As SqlConnection = New SqlConnection(constr)
            Using cmd As SqlCommand = New SqlCommand("SELECT * FROM Usuarios WHERE (Cedula = " & TextBoxCedula.Text & ")")

                cmd.CommandType = CommandType.Text
                cmd.Connection = con
                con.Open()

                Using sdr As SqlDataReader = cmd.ExecuteReader()

                    sdr.Read()

                    TextBoxNombre.Text = sdr("Nombre")
                    TextBoxPrimerApellido.Text = sdr("PrimerApellido")
                    TextBoxSegundoApellido.Text = sdr("SegundoApellido")
                    TextBoxTelefono.Text = sdr("Telefono")
                    TextBoxCorreo.Text = sdr("Correo")
                    TextBoxAltura.Text = sdr("Altura")
                    TextBoxPeso.Text = sdr("Peso")
                    TextBoxGenero.Text = sdr("Genero")

                End Using

                con.Close()

            End Using
        End Using
    End Sub
    Private Sub ButtonEditarNombre_Click(sender As Object, e As EventArgs) Handles ButtonEditarNombre.Click
        If TextBoxNombre.ReadOnly = True Then
            TextBoxNombre.ReadOnly = False
        End If
    End Sub

    Private Sub ButtonEditarPrimerApellido_Click(sender As Object, e As EventArgs) Handles ButtonEditarApellido1.Click
        If TextBoxPrimerApellido.ReadOnly = True Then
            TextBoxPrimerApellido.ReadOnly = False
        End If
    End Sub

    Private Sub ButtonEditarSegundoApellido_Click(sender As Object, e As EventArgs) Handles ButtonEditarApellido2.Click
        If TextBoxSegundoApellido.ReadOnly = True Then
            TextBoxSegundoApellido.ReadOnly = False
        End If
    End Sub

    Private Sub ButtonEditarAltura_Click(sender As Object, e As EventArgs) Handles ButtonEditarAltura.Click
        If TextBoxAltura.ReadOnly = True Then
            TextBoxAltura.ReadOnly = False
        End If
    End Sub

    Private Sub ButtonEditarPeso_Click(sender As Object, e As EventArgs) Handles ButtonEditarPeso.Click
        If TextBoxPeso.ReadOnly = True Then
            TextBoxPeso.ReadOnly = False
        End If
    End Sub

    Private Sub ButtonEditarTelefono_Click(sender As Object, e As EventArgs) Handles ButtonEditarTelefono.Click
        If TextBoxTelefono.ReadOnly = True Then
            TextBoxTelefono.ReadOnly = False
        End If
    End Sub

    Private Sub ButtonEditarCorreo_Click(sender As Object, e As EventArgs) Handles ButtonEditarCorreo.Click
        If TextBoxCorreo.ReadOnly = True Then
            TextBoxCorreo.ReadOnly = False
        End If
    End Sub
    Private Sub ButtonEditarGenero_Click(sender As Object, e As EventArgs) Handles ButtonEditarGenero.Click
        If TextBoxGenero.ReadOnly = True Then
            TextBoxGenero.ReadOnly = False
        End If
    End Sub


    Public Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        Dim constr As New SqlConnection("data source=PROYAZUL; initial catalog = Gym; Integrated Security = True”)

        Dim cmd As New SqlCommand("UPADTE Usuarios SET Nombre = @Nombre, PrimerApellido = @PrimerApellido, SegundoApellido = @SegundoApellido, Correo = @Correo, Telefono = @Telefono, Genero = @Genero, Altura = @Altura, Peso = @Peso", constr)
        cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = TextBoxNombre.Text
        cmd.Parameters.Add("@PrimerApellido", SqlDbType.VarChar).Value = TextBoxPrimerApellido.Text
        cmd.Parameters.Add("@SegundoApellido", SqlDbType.VarChar).Value = TextBoxSegundoApellido.Text
        cmd.Parameters.Add("@Correo", SqlDbType.VarChar).Value = TextBoxCorreo.Text
        cmd.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = TextBoxTelefono.Text
        cmd.Parameters.Add("@Genero", SqlDbType.VarChar).Value = TextBoxGenero.Text
        cmd.Parameters.Add("@Altura", SqlDbType.VarChar).Value = TextBoxAltura.Text
        cmd.Parameters.Add("@Peso", SqlDbType.VarChar).Value = TextBoxPeso.Text

        constr.Open()
        If cmd.ExecuteNonQuery() = 1 Then
            MsgBox("Datos actualizados con exito")
        Else
            MsgBox("Los datos no fueron actualizados")
        End If
        constr.Close()
    End Sub



    'funcion para eliminar al usuario
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        Dim resultado As DialogResult = MessageBox.Show("Seguro que desea eliminar a " & TextBoxNombre.Text & " " & TextBoxPrimerApellido.Text & " del sistema?", "Fit Tracker", MessageBoxButtons.YesNoCancel)
        If resultado = DialogResult.Cancel Then
            Return
        ElseIf resultado = DialogResult.No Then
            Return

        ElseIf resultado = DialogResult.Yes Then

            Dim constr As String = ("data source=PROYAZUL; initial catalog = Gym; Integrated Security = True”)
            Using con As SqlConnection = New SqlConnection(constr)
                Using cmd As SqlCommand = New SqlCommand("DELETE FROM Usuarios WHERE Cedula = @Cedula", con)
                    cmd.Parameters.Add("@Cedula", SqlDbType.Int).Value = ModuloLogin.cedula2

                    con.Open()

                    If cmd.ExecuteNonQuery() = 1 Then

                        MsgBox("Los datos del usuario fueron eliminados con exito", MessageBoxIcon.Information, "Fit Tracker")
                    Else
                        MsgBox("Usuario no eliminado")

                    End If
                    con.Close()
                    TextBoxNombre.Text = " "
                    TextBoxPrimerApellido.Text = " "
                    TextBoxSegundoApellido.Text = " "
                    TextBoxTelefono.Text = " "
                    TextBoxCorreo.Text = " "
                    TextBoxAltura.Text = " "
                    TextBoxPeso.Text = " "
                    TextBoxGenero.Text = " "
                End Using
            End Using

        End If
    End Sub


End Class