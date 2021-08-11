Imports System.Data
Imports System.Data.SqlClient
Public Class MenuGestionarAñadirUsuario
    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Hide()
        MenuGestionarUsuarios.Show()
    End Sub

    Public Sub Insert()
    End Sub

    Private Sub MenuGestionarAñadirUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim stringConexion As String
        stringConexion = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True”
        Dim stringSelect As String = "SELECT * FROM Usuarios"
        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter(stringSelect, stringConexion)
            da.Fill(dt)

        Catch ex As Exception



        End Try
    End Sub

    Public Function Insertar()


        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "Usuarios"

        sel = "INSERT INTO " & NombreTabla &
            " (Cedula, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, Correo, Genero, Acceso, Contraseña, Telefono, Peso, Altura, IMC) " &
            " VALUES " &
            " (@Cedula, @Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento, @Correo, @Genero, @Acceso, @Contraseña, @Telefono, @Peso, @Altura, @IMC )"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)
            cmd.Parameters.AddWithValue("@Cedula", TextBoxCedula.Text)
            cmd.Parameters.AddWithValue("@Nombre", TextBoxNombre.Text)
            cmd.Parameters.AddWithValue("@PrimerApellido", TextBoxApellido1.Text)
            cmd.Parameters.AddWithValue("@SegundoApellido", TextBoxApellido2.Text)
            cmd.Parameters.AddWithValue("@FechaNacimiento", TextBoxEdad.Text)
            cmd.Parameters.AddWithValue("@Correo", TextBoxCorreo.Text)
            cmd.Parameters.AddWithValue("@Genero", TextBoxGenero.Text)
            cmd.Parameters.AddWithValue("@Acceso", ComboBox1.Text)
            cmd.Parameters.AddWithValue("@Contraseña", TextBoxContraseña.Text)
            cmd.Parameters.AddWithValue("@Telefono", TextBoxTelefono.Text)
            cmd.Parameters.AddWithValue("@Peso", TextBoxPeso.Text)
            cmd.Parameters.AddWithValue("@Altura", TextBoxAltura.Text)
            cmd.Parameters.AddWithValue("@IMC", TextBoxIMC.Text)


            con.Open()
            Dim t As Integer = CInt(cmd.ExecuteScalar())
            con.Close()
            Return t
        End Using
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Insertar()


    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub ButtonGenerarContra_Click(sender As Object, e As EventArgs) Handles ButtonGenerarContra.Click

    End Sub
End Class