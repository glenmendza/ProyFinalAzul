Imports System.Data
Imports System.Data.SqlClient
Public Class MenuGestionarEditarUsuario
    'prueba 
    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Hide()
        MenuBuscarUsuario.Show()
    End Sub
    Private Sub CargarDatos()
        Dim constr As String = ("data source=PROYAZUL; initial catalog = Gym; Integrated Security = True”)
        Using con As SqlConnection = New SqlConnection(constr)
            Using cmd As SqlCommand = New SqlCommand("SELECT * FROM dbo.Usuarios WHERE (Cedula = " + ModuloLogin.cedula2 + ")")

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
    Private Sub MenuGestionarEditarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CargarDatos()




    End Sub

    Private Sub TextBoxNombre_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNombre.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Public Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        Call GuardarCambios()
    End Sub
    Public Sub GuardarCambios()
        Dim myConnectionString As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"

        Dim myConnection As New SqlConnection(myConnectionString)

        Dim rows As Integer

        Dim myCommand As SqlCommand = myConnection.CreateCommand()

        Try
            myConnection.Open()

            myCommand.CommandText = "UPDATE Usuarios SET "
            myCommand.CommandText += "Nombre = '" & TextBoxNombre.Text & "', "
            myCommand.CommandText += "PrimerApellido = '" & TextBoxPrimerApellido.Text & "', "
            myCommand.CommandText += "SegundoApellido = '" & TextBoxSegundoApellido.Text & "', "
            myCommand.CommandText += "Altura = '" & TextBoxAltura.Text & "', "
            myCommand.CommandText += "Peso = '" & TextBoxPeso.Text & "', "
            myCommand.CommandText += "Telefono = '" & TextBoxTelefono.Text & "', "
            myCommand.CommandText += "Correo = '" & TextBoxCorreo.Text & "', "
            myCommand.CommandText += "Genero = '" & TextBoxGenero.Text & "', "
            myCommand.CommandText += "WHERE Cedula = " & ModuloLogin.cedula2 & ""

            rows = myCommand.ExecuteNonQuery()

        Catch ex As SqlException

        Finally
            myConnection.Close()
        End Try

        MessageBox.Show("Datos actualizados con exito!", "FIT Tracker")
        Exit Sub
    End Sub

End Class