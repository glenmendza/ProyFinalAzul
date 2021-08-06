Imports System.Data
Imports System.Data.SqlClient
Public Class MenuGestionarAñadirUsuario
    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Hide()
        MenuGestionarUsuarios.Show()
    End Sub

    Public Sub Insert()
    End Sub

    'esto es un ejemplo de glen

    'Private Sub MenuGestionarAñadirUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    '    Dim stringConexion As String
    '    stringConexion = "data source=MSI; initial catalog = Gym; Integrated Security = True”
    '    Dim stringSelect As String = "SELECT * FROM Usuarios"
    '    Dim da As SqlDataAdapter
    '    Dim dt As New DataTable
    '    Try
    '        da = New SqlDataAdapter(stringSelect, stringConexion)
    '        da.Fill(dt)

    '    Catch ex As Exception



    '    End Try
    'End Sub

    'Public Function Insertar(ByVal Cedula As Integer,
    '                     ByVal Nombre As String, PrimerApellido As String, SegundoApellido As String, FechaNacimiento As Date,
    '                         Correo As String, Genero As Char, Acceso As String, Contraseña As String, Telefono As Integer)

    '    Dim sCon As String = "data source=MSI; initial catalog = Gym; Integrated Security = True"
    '    Dim sel As String
    '    Dim NombreTabla As String = "Usuarios"

    '    sel = "INSERT INTO " & NombreTabla &
    '        " (Cedula, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, Correo, Genero, Acceso, Contraseña, Telefono) " &
    '        "VALUES " &
    '        "(@Cedula, @Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento, @Correo, @Genero, @Acceso, @Contraseña, @Telefono )"

    '    Using con As New SqlConnection(sCon)

    '        Dim cmd As New SqlCommand(sel, con)
    '        cmd.Parameters.AddWithValue("@Cedula", Cedula)
    '        cmd.Parameters.AddWithValue("@Nombre", Nombre)
    '        cmd.Parameters.AddWithValue("@PrimerApellido", PrimerApellido)
    '        cmd.Parameters.AddWithValue("@SegundoApellido", SegundoApellido)
    '        cmd.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento)
    '        cmd.Parameters.AddWithValue("@Correo", Correo)
    '        cmd.Parameters.AddWithValue("@Genero", Genero)
    '        cmd.Parameters.AddWithValue("@Acceso", Acceso)
    '        cmd.Parameters.AddWithValue("@Contraseña", Contraseña)
    '        cmd.Parameters.AddWithValue("@Telefono", Telefono)



    '        con.Open()
    '        Dim t As Integer = CInt(cmd.ExecuteScalar())
    '        con.Close()
    '        Return t
    '    End Using
    'End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim Insertado As Integer
        'Insertado = Insertar(7123513, "Haziel", "Lopez", "Rodriguez", "01/01/2000", "haziel@", "M", "Cliente", "723thf3iu8", "6763826")

    End Sub

End Class