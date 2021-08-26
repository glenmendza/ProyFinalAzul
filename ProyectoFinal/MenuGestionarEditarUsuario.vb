Imports System.Data
Imports System.Data.SqlClient
Public Class MenuGestionarEditarUsuario
    Private Sub MenuGestionarEditarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Cargar()
        TextBoxCedula.Text = cedula2
    End Sub
    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Close()
        MenuBuscarUsuario.Show()

    End Sub
    Public Sub Cargar()
        Dim constr As String = ("data source=PROYAZUL; initial catalog = Gym; Integrated Security = True”)
        Using con As SqlConnection = New SqlConnection(constr)
            Using cmd As SqlCommand = New SqlCommand("SELECT * FROM Usuarios WHERE (Cedula = " & cedula2 & ")")

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

    Private Sub ButtonEditarAltura_Click(sender As Object, e As EventArgs)
        If TextBoxAltura.ReadOnly = True Then
            TextBoxAltura.ReadOnly = False
        End If
    End Sub

    Private Sub ButtonEditarPeso_Click(sender As Object, e As EventArgs)
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

    Public Sub Insertar()

        Dim myConnectionString As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"

        Dim myConnection As New SqlConnection(myConnectionString)

        Dim rows As Integer

        Dim myCommand As SqlCommand = myConnection.CreateCommand()


        myConnection.Open()

        myCommand.CommandText = "UPDATE Usuarios SET "
        myCommand.CommandText += "Nombre = '" & TextBoxNombre.Text & "', "
        myCommand.CommandText += "PrimerApellido = '" & TextBoxPrimerApellido.Text & "', "
        myCommand.CommandText += "SegundoApellido = '" & TextBoxSegundoApellido.Text & "', "
        myCommand.CommandText += "Altura = '" & TextBoxAltura.Text & "', "
        myCommand.CommandText += "Peso = '" & TextBoxPeso.Text & "', "
        myCommand.CommandText += "Telefono = '" & TextBoxTelefono.Text & "', "
        myCommand.CommandText += "Genero = '" & TextBoxGenero.Text & "', "
        myCommand.CommandText += "Correo = '" & TextBoxCorreo.Text & "' "
        myCommand.CommandText += "WHERE Cedula = " & cedula2 & ""
        Try
            rows = myCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Ha ocurrido un error", MessageBoxIcon.Error, "Fit Tracker")

        End Try


        myConnection.Close()


        MsgBox("Datos actualizados con exito!", MessageBoxIcon.Information, "FIT Tracker")
        Exit Sub
    End Sub


    'funcion para eliminar al usuario
    Private Sub EliminarUser()
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
                    TextBoxCedula.Text = " "
                End Using
            End Using
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Call Insertar()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Call EliminarUser()
    End Sub


End Class