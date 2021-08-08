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
                    TextBoxTelefono.Text = sdr("Telefono")
                    TextBoxCorreo.Text = sdr("Correo")
                    TextBoxNacimiento.Text = sdr("FechaNacimiento")
                    TextBoxContraseña.Text = sdr("Contraseña")
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

    Private Sub TextBoxCedula_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCedula.TextChanged

    End Sub
End Class