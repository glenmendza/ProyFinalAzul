Imports System.Data
Imports System.Data.SqlClient

Public Class MenuModificarDatos
    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub

    Private Sub MenuModificarDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Public Sub Datos()


        'Dim stringConection As String
        'stringConection = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True”
        'Dim stringSelect As String = "SELECT * FROM dbo.Usuarios WHERE (Cedula = " & ModuloLogin.cedula & ")"

        'Dim da As SqlDataAdapter
        'Dim dt As New DataTable
        'Try
        '    da = New SqlDataAdapter(stringSelect, stringConection)
        '    da.Fill(dt)
        'Catch ex As Exception
        'End Try

        ''If ModuloLogin.cedula = TextBoxCedula.Text Then
        ''    TextBoxNombre.Text = dt.Rows(0).Item(1).ToString
        ''    TextBoxTelefono.Text = dt.Rows(0).Item(9).ToString
        ''    TextBoxCorreo.Text = dt.Rows(0).Item(5).ToString
        ''    TextBoxContraseña.Text = dt.Rows(0).Item(8).ToString
        ''End If
        ''Dim conn As New SqlConnection
        ''conn.ConnectionString = ("data source=PROYAZUL; initial catalog = Gym; Integrated Security = True”)


        ''conn.Open()
        ''Dim strsql As String
        ''strsql = "select * from usuarios where id=" + ModuloLogin.cedula + ""
        ''Dim cmd As New SqlCommand(strsql, conn)
        ''Dim lector As SqlDataReader
        ''lector = cmd.ExecuteReader
        ''lector.Read()



        'If ModuloLogin.cedula = lector(cedula) Then
        '    TextBoxNombre.Text = lector("Nombre")
        '    TextBoxTelefono.Text = lector("Telefono")
        '    TextBoxCorreo.Text = lector("Correo")
        '    TextBoxContraseña.Text = lector("Contraseña")
        'End If

    End Sub


    Private Sub ButtonMostrarEsconder_Click(sender As Object, e As EventArgs) Handles ButtonMostrarEsconder.Click
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

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        Call Insert()
    End Sub
    Public Function Insert()
        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "dbo.Usuarios"



        sel = "UPDATE " & NombreTabla &
            " (Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, Altura, Peso, IMC, Telefono, Correo, Contraseña) " &
            "VALUES " &
            "(@Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento, @Altura, @Peso, @IMC, @Telefono, @Correo, @Contraseña )"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)
            cmd.Parameters.AddWithValue("@Nombre", TextBoxNombre.Text)
            cmd.Parameters.AddWithValue("@PrimerApellido", TextBoxPrimerApellido.Text)
            cmd.Parameters.AddWithValue("@SegundoApellido", TextBoxSegundoApellido.Text)
            cmd.Parameters.AddWithValue("@FechaNacimiento", TextBoxNacimiento.Text)
            cmd.Parameters.AddWithValue("@Altura", TextBoxAltura.Text)
            cmd.Parameters.AddWithValue("@Peso", TextBoxPeso.Text)
            cmd.Parameters.AddWithValue("@IMC", TextBoxIMC.Text)
            cmd.Parameters.AddWithValue("@Telefono", TextBoxTelefono.Text)
            cmd.Parameters.AddWithValue("@Correo", TextBoxCorreo.Text)
            cmd.Parameters.AddWithValue("@Contraseña", TextBoxContraseña.Text)

            con.Open()
                Dim t As Integer = (cmd.ExecuteScalar())
                con.Close()

                Return t

        End Using
    End Function
End Class