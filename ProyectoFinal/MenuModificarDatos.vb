Imports System.Data
Imports System.Data.SqlClient

Public Class MenuModificarDatos
    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Close()
        MenuPrincipal.Show()
    End Sub

    Private Sub MenuModificarDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox2.Visible = False
        TextBoxCedula.Text = ModuloLogin.cedula

        Dim constr As String = ("data source=PROYAZUL; initial catalog = Gym; Integrated Security = True”)
        Using con As SqlConnection = New SqlConnection(constr)
            Using cmd As SqlCommand = New SqlCommand("SELECT * FROM dbo.Usuarios WHERE (Cedula = " & TextBoxCedula.Text & ")")

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
                    TextBoxNacimiento.Text = sdr("FechaNacimiento")
                    TextBoxContraseña.Text = sdr("Contraseña")
                    TextBoxAltura.Text = sdr("Altura")
                    TextBoxIMC.Text = sdr("IMC")
                    TextBoxPeso.Text = sdr("Peso")

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

    Private Sub ButtonEditarPrimerApellido_Click(sender As Object, e As EventArgs) Handles ButtonEditarPrimerApellido.Click
        If TextBoxPrimerApellido.ReadOnly = True Then
            TextBoxPrimerApellido.ReadOnly = False
        End If
    End Sub

    Private Sub ButtonEditarSegundoApellido_Click(sender As Object, e As EventArgs) Handles ButtonEditarSegundoApellido.Click
        If TextBoxSegundoApellido.ReadOnly = True Then
            TextBoxSegundoApellido.ReadOnly = False
        End If
    End Sub

    Private Sub ButtonEditarFechaNacimiento_Click(sender As Object, e As EventArgs) Handles ButtonEditarFechaNacimiento.Click
        If TextBoxNacimiento.ReadOnly = True Then
            TextBoxNacimiento.ReadOnly = False
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

    Private Sub ButtonEditarIMC_Click(sender As Object, e As EventArgs) Handles ButtonEditarIMC.Click
        If TextBoxIMC.ReadOnly = True Then
            TextBoxIMC.ReadOnly = False
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

    Private Sub ButtonEditarContraseña_Click(sender As Object, e As EventArgs) Handles ButtonEditarContraseña.Click
        If TextBoxContraseña.ReadOnly = True Then
            TextBoxContraseña.ReadOnly = False
        End If
    End Sub

    Public Sub Insert()

        Dim myConnectionString As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"

        Dim myConnection As New SqlConnection(myConnectionString)

        Dim rows As Integer

        Dim myCommand As SqlCommand = myConnection.CreateCommand()

        'Dim resultado As Double
        'Dim resultado2 As String
        'Dim peso As Double = TextBoxPeso.Text
        'Dim altura As Double = TextBoxAltura.Text
        'resultado = (peso / ((altura / 100) ^ 2))
        'resultado2 = Format(resultado, "0.00")

        Try
            myConnection.Open()

            myCommand.CommandText = "UPDATE Usuarios SET "
            myCommand.CommandText += "Nombre = '" & TextBoxNombre.Text & "', "
            myCommand.CommandText += "PrimerApellido = '" & TextBoxPrimerApellido.Text & "', "
            myCommand.CommandText += "SegundoApellido = '" & TextBoxSegundoApellido.Text & "', "
            myCommand.CommandText += "FechaNacimiento = '" & TextBoxNacimiento.Text & "', "
            myCommand.CommandText += "Altura = '" & TextBoxAltura.Text & "', "
            myCommand.CommandText += "Peso = '" & TextBoxPeso.Text & "', "
            myCommand.CommandText += "IMC = '" & TextBoxIMC.Text & "', "
            myCommand.CommandText += "Telefono = '" & TextBoxTelefono.Text & "', "
            myCommand.CommandText += "Correo = '" & TextBoxCorreo.Text & "', "
            myCommand.CommandText += "Contraseña = '" & TextBoxContraseña.Text & "' "
            myCommand.CommandText += "WHERE Cedula = " & ModuloLogin.cedula & ""

            rows = myCommand.ExecuteNonQuery()

        Catch ex As Exception

        Finally
            myConnection.Close()
        End Try

        MessageBox.Show("Datos actualizados con exito!", "FIT Tracker")
        Exit Sub

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If PictureBox2.Visible = False Then
            PictureBox2.Visible = True
        ElseIf PictureBox2.Visible = True Then
            PictureBox2.Visible = False
        End If
    End Sub

    Private Sub Calculo()
        Try
            Dim resultado As Double
            Dim peso As Double = TextBoxPeso.Text
            Dim altura As Double = TextBoxAltura.Text
            resultado = (peso / ((altura / 100) ^ 2))
            TextBoxIMC.Text = CStr(Format(resultado, "0.00"))
        Catch
            MsgBox("Error 404")
        End Try
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Call Calculo()
        Call Insert()
        Call InsertadoEnStats()
    End Sub

    Private Function InsertadoEnStats()
        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "Estadisticas1"

        sel = "INSERT INTO " & NombreTabla &
            " (Cedula, Fecha, Peso, IMC) " &
            " VALUES " &
            " (@Cedula, @Fecha, @Peso, @IMC)"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)

            cmd.Parameters.AddWithValue("@Cedula", TextBoxCedula.Text)
            cmd.Parameters.AddWithValue("Fecha", Cal1.SelectionStart)
            cmd.Parameters.AddWithValue("@Peso", TextBoxPeso.Text)
            cmd.Parameters.AddWithValue("@IMC", TextBoxIMC.Text)

            con.Open()
            Try
                Dim t As Integer = CInt(cmd.ExecuteScalar())
                'MessageBox.Show("Usuario registrado con exito!", "FIT Tracker")
                con.Close()
                Return t
            Catch ex As Exception
                MsgBox("Ha ocurrido un error", MessageBoxIcon.Error, "FIT Tracker")
            End Try
        End Using
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If TextBoxContraseña.Visible = True Then
            TextBoxContraseña.Visible = False
        ElseIf TextBoxContraseña.Visible = False Then
            TextBoxContraseña.Visible = True
        End If
    End Sub
End Class