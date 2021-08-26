Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class MenuGestionarAñadirUsuario
    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Hide()
        MenuGestionarUsuarios.Show()
    End Sub

    Public Function Insertar()

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
            Try
                Dim t As Integer = CInt(cmd.ExecuteScalar())
                MessageBox.Show("Usuario registrado con exito!", "FIT Tracker")
                con.Close()
                Return t
            Catch ex As Exception
                MsgBox("Caracteres incorrectos", MessageBoxIcon.Error, "Fit Tracker")
            End Try
        End Using

#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código

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

    Private Sub ButtonGenerarContra_Click(sender As Object, e As EventArgs) Handles ButtonGenerarContra.Click
        TextBoxContraseña.Text = CrearPassword(8)
    End Sub


    Private Function CrearPassword(longitud As Integer) As String
        Dim caracteres As String = "aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ1234567890"
        Dim res As New StringBuilder(0)
        Dim rnd As New Random()
        While 0 < System.Math.Max(System.Threading.Interlocked.Decrement(longitud), longitud + 1)
            res.Append(caracteres(rnd.[Next](caracteres.Length)))
        End While
        Return res.ToString()

    End Function


    Public Sub CalculoIMC()
        Try
            Dim resultado As Double
            Dim peso As Double = TextBoxPeso.Text
            Dim altura As Double = TextBoxAltura.Text
            resultado = (peso / ((altura / 100) ^ 2))
            resultado = Format(resultado, "0.00")
            TextBoxIMC.Text = CStr(resultado)
        Catch
            MsgBox("Rellena la altura y peso", MessageBoxIcon.Information, "Fit Tracker")
            Exit Sub
        End Try
    End Sub

    Private Sub MenuGestionarAñadirUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxGenero.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxAcceso.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub ButtonIMC_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If TextBoxContraseña.Text = "" Then
            MsgBox("Rellena el campo de contraseña para poder copiar!", MessageBoxIcon.Information, "FIT Tracker")
            Exit Sub
        Else
            Clipboard.SetText(TextBoxContraseña.Text)
            MsgBox("Contraseña copiada con éxito!", MessageBoxIcon.Information, "FIT Tracker")
            Exit Sub
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        Call CalculoIMC()

        If TextBoxNombre.Text = "" Then
            MsgBox("Debe ingresar datos de Nombre", MessageBoxIcon.Information, "FIT Tracker")
            Exit Sub
        ElseIf TextBoxApellido1.Text = "" Then
            MsgBox("Debe ingresar datos del Primer Apellido", MessageBoxIcon.Information, "FIT Tracker")
            Exit Sub
        ElseIf TextBoxApellido2.Text = "" Then
            MsgBox("Debe ingresar datos del Segundo Apellido", MessageBoxIcon.Information, "FIT Tracker")
            Exit Sub
        ElseIf TextBoxCedula.Text = "" Then
            MsgBox("Debe ingresar datos de Cedula", MessageBoxIcon.Information, "FIT Tracker")
            Exit Sub
        ElseIf TextBoxCorreo.Text = "" Then
            MsgBox("Debe ingresar datos de Correo Electrónico", MessageBoxIcon.Information, "FIT Tracker")
            Exit Sub
        ElseIf TextBoxTelefono.Text = "" Then
            MsgBox("Debe ingresar datos de Telefono", MessageBoxIcon.Information, "FIT Tracker")
            Exit Sub
        ElseIf ComboBoxAcceso.Text = "" Then
            MsgBox("Debe ingresar datos de Tipo de usuario", MessageBoxIcon.Information, "FIT Tracker")
            Exit Sub
            'ElseIf TextBoxPeso.Text = "" Then
            '    MsgBox("Debe ingresar datos de Peso", MessageBoxIcon.Information, "FIT Tracker")
            '    Exit Sub
            'ElseIf TextBoxAltura.Text = "" Then
            '    MsgBox("Debe ingresar datos de Altura", MessageBoxIcon.Information, "FIT Tracker")
            '    Exit Sub
            'ElseIf TextBoxIMC.Text = "" Then
            '    MsgBox("Debe ingresar datos de IMC", MessageBoxIcon.Information, "FIT Tracker")
            '    Exit Sub
        ElseIf ComboBoxGenero.Text = "" Then
            MsgBox("Debe ingresar datos de Genero", MessageBoxIcon.Information, "FIT Tracker")
            Exit Sub
        ElseIf TextBoxNacimiento.Text = "" Then
            MsgBox("Debe ingresar datos de Fecha de Nacimiento", MessageBoxIcon.Information, "FIT Tracker")
            Exit Sub
        ElseIf TextBoxContraseña.Text = "" Then
            MsgBox("Debe ingresar datos de Contraseña", MessageBoxIcon.Information, "FIT Tracker")
            Exit Sub
        End If

        Call Insertar()
        Call LimpiarCampos()
    End Sub
End Class