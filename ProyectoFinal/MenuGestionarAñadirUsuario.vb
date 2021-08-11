Imports System.Data
Imports System.Data.SqlClient
Public Class MenuGestionarAñadirUsuario
    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Hide()
        MenuGestionarUsuarios.Show()
    End Sub


    Private Sub MenuGestionarAñadirUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Function Insertar()

        If TextBoxNombre.Text = "" Then
            MsgBox("Debe ingresar datos de Nombre", MessageBoxIcon.Information, "FIT Tracker")
            Exit Function
        End If
        If TextBoxApellido1.Text = "" Then
            MsgBox("Debe ingresar datos del Primer Apellido", MessageBoxIcon.Information, "FIT Tracker")
            Exit Function
        End If
        If TextBoxApellido2.Text = "" Then
            MsgBox("Debe ingresar datos del Segundo Apellido", MessageBoxIcon.Information, "FIT Tracker")
            Exit Function
        End If
        If TextBoxCedula.Text = "" Then
            MsgBox("Debe ingresar datos de Cedula", MessageBoxIcon.Information, "FIT Tracker")
            Exit Function
        End If
        If TextBoxCorreo.Text = "" Then
            MsgBox("Debe ingresar datos de Correo Electrónico", MessageBoxIcon.Information, "FIT Tracker")
            Exit Function
        End If
        If TextBoxTelefono.Text = "" Then
            MsgBox("Debe ingresar datos de Telefono", MessageBoxIcon.Information, "FIT Tracker")
            Exit Function
        End If
        If ComboBoxAcceso.Text = "" Then
            MsgBox("Debe ingresar datos de Tipo de usuario", MessageBoxIcon.Information, "FIT Tracker")
            Exit Function
        End If
        If TextBoxPeso.Text = "" Then
            MsgBox("Debe ingresar datos de Peso", MessageBoxIcon.Information, "FIT Tracker")
            Exit Function
        End If
        If TextBoxAltura.Text = "" Then
            MsgBox("Debe ingresar datos de Altura", MessageBoxIcon.Information, "FIT Tracker")
            Exit Function
        End If
        If TextBoxIMC.Text = "" Then
            MsgBox("Debe ingresar datos de IMC", MessageBoxIcon.Information, "FIT Tracker")
            Exit Function
        End If
        If ComboBoxGenero.Text = "" Then
            MsgBox("Debe ingresar datos de Genero", MessageBoxIcon.Information, "FIT Tracker")
            Exit Function
        End If
        If TextBoxNacimiento.Text = "" Then
            MsgBox("Debe ingresar datos de Fecha de Nacimiento", MessageBoxIcon.Information, "FIT Tracker")
            Exit Function
        End If
        If TextBoxContraseña.Text = "" Then
            MsgBox("Debe ingresar datos de Contraseña", MessageBoxIcon.Information, "FIT Tracker")
            Exit Function
        End If

        Dim stringConection As String
        stringConection = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True”
        Dim stringSelect As String = "SELECT * FROM dbo.Usuarios WHERE (Cedula = " & TextBoxCedula.Text & ")"

        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter(stringSelect, stringConection)
            da.Fill(dt)
        Catch ex As Exception
        End Try

        If (dt.Rows.Count = 1) Then
            MsgBox("Cedula ya registrada", MessageBoxIcon.Error, "FIT Tracker")
            Exit Function
        End If

        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "Usuarios"

        sel = "INSERT INTO " & NombreTabla &
            " (Cedula, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, Correo, Genero, Acceso, Contraseña, Telefono, Peso, Altura, IMC) " &
            " VALUES " &
            " (@Cedula, @Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento, @Correo, @Genero, @Acceso, @Contraseña, @Telefono, @Peso, @Altura, @IMC )"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)

            cmd.Parameters.AddWithValue("@Nombre", TextBoxNombre.Text)
            cmd.Parameters.AddWithValue("@PrimerApellido", TextBoxApellido1.Text)
            cmd.Parameters.AddWithValue("@SegundoApellido", TextBoxApellido2.Text)
            cmd.Parameters.AddWithValue("@Cedula", TextBoxCedula.Text)
            cmd.Parameters.AddWithValue("@Correo", TextBoxCorreo.Text)
            cmd.Parameters.AddWithValue("@Telefono", TextBoxTelefono.Text)
            cmd.Parameters.AddWithValue("@Acceso", ComboBoxAcceso.Text)
            cmd.Parameters.AddWithValue("@Peso", TextBoxPeso.Text)
            cmd.Parameters.AddWithValue("@Altura", TextBoxAltura.Text)
            cmd.Parameters.AddWithValue("@IMC", TextBoxIMC.Text)
            cmd.Parameters.AddWithValue("@Genero", ComboBoxGenero.Text)
            cmd.Parameters.AddWithValue("@FechaNacimiento", TextBoxNacimiento.Text)
            cmd.Parameters.AddWithValue("@Contraseña", TextBoxContraseña.Text)



            con.Open()
            Dim t As Integer = CInt(cmd.ExecuteScalar())
            MessageBox.Show("Usuario registrado con exito!", "FIT Tracker")
            con.Close()
            Return t

        End Using

    End Function

    Public Sub LimpiarCampos()

        TextBoxNombre.Text = " "
        TextBoxApellido1.Text = " "
        TextBoxApellido2.Text = " "
        TextBoxCedula.Text = " "
        TextBoxCorreo.Text = " "
        TextBoxTelefono.Text = " "
        ComboBoxAcceso.Text = " "
        TextBoxPeso.Text = " "
        TextBoxAltura.Text = " "
        TextBoxIMC.Text = " "
        ComboBoxGenero.Text = " "
        TextBoxNacimiento.Text = " "
        TextBoxContraseña.Text = " "

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Insertar()
        Call LimpiarCampos()
    End Sub
End Class