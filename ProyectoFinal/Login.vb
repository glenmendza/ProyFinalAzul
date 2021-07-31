Imports System.Data
Imports System.Data.SqlClient

Public Class Login
    'inicio conexion a base de datos
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim stringConexion As String
        stringConexion = "data source=MSI; initial catalog = Gym; Integrated Security = True”
        Dim stringSelect As String = "SELECT * FROM Usuarios"
        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter(stringSelect, stringConexion)
            da.Fill(dt)

        Catch ex As Exception
        End Try
    End Sub
    Public Function Insertar(ByVal Cedula As Integer,
                         ByVal Nombre As String, PrimerApellido As String, SegundoApellido As String, FechaNacimiento As Date,
                             Correo As String, Genero As Char, Acceso As String, Contraseña As String, Telefono As Integer)

        Dim sCon As String = "data source=MSI; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "Usuarios"

        sel = "INSERT INTO " & NombreTabla &
            " (Cedula, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, Correo, Genero, Acceso, Contraseña, Telefono) " &
            "VALUES " &
            "(@Cedula, @Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento, @Correo, @Genero, @Acceso, @Contraseña, @Telefono )"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)
            cmd.Parameters.AddWithValue("@Cedula", Cedula)
            cmd.Parameters.AddWithValue("@Nombre", Nombre)
            cmd.Parameters.AddWithValue("@PrimerApellido", PrimerApellido)
            cmd.Parameters.AddWithValue("@SegundoApellido", SegundoApellido)
            cmd.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento)
            cmd.Parameters.AddWithValue("@Correo", Correo)
            cmd.Parameters.AddWithValue("@Genero", Genero)
            cmd.Parameters.AddWithValue("@Acceso", Acceso)
            cmd.Parameters.AddWithValue("@Contraseña", Contraseña)
            cmd.Parameters.AddWithValue("@Telefono", Telefono)



            con.Open()
            Dim t As Integer = CInt(cmd.ExecuteScalar())
            con.Close()
            Return t
        End Using
    End Function
    'fin conexion a base de datos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BotonIngresarAdmin.Click 'verificacion de datos boton Ingresar como admin


        If TextBoxCedula.Text = "" Or TextBoxContraseña.Text = "" Then
            MsgBox("Debe ingresar ambos datos", MessageBoxIcon.Information, "FitTracker")

        ElseIf Len(TextBoxCedula.Text) > 9 Then
            MsgBox("La cédula no puede tener más de 9 dígitos", MessageBoxIcon.Error, "FitTracker")

            Me.Hide()
            MenuPrincipalUsuario.Show()
        End If


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BotonIngresar.Click 'verificacion de datos boton Ingresar

        If TextBoxCedula.Text = "" Or TextBoxContraseña.Text = "" Then
            MsgBox("Debe ingresar ambos datos", MessageBoxIcon.Information, "FitTracker")

        ElseIf Len(TextBoxCedula.Text) > 9 Then
            MsgBox("La cédula no puede tener más de 9 dígitos", MessageBoxIcon.Error, "FitTracker")

        Else
            Me.Hide()
            MenuPrincipalUsuario.Show()
        End If
    End Sub





End Class
