Imports System.Data
Imports System.Data.SqlClient

Public Class Login
    'inicio conexion a base de datos
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub ValidarUser()

        If TextBoxCedula.Text = "" Or TextBoxContraseña.Text = "" Then
            MsgBox("Debe ingresar ambos datos", MessageBoxIcon.Information, "FIT Tracker")
            Exit Sub
        End If

        Dim stringConection As String
        stringConection = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True”
        Dim stringSelect As String = "SELECT dbo.Usuarios.* FROM dbo.Usuarios WHERE (Cedula = " & TextBoxCedula.Text & ") AND (Contraseña LIKE '" & TextBoxContraseña.Text & "')"

        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter(stringSelect, stringConection)
            da.Fill(dt)
        Catch ex As Exception
        End Try

        'MsgBox(dt.Rows.Count)


        If (dt.Rows.Count = 0) Then
            MsgBox("Usuario o contraseña son inválidas", MessageBoxIcon.Error, "FIT Tracker")
            Exit Sub
        End If


        If dt.Rows(0).Item(7).ToString = "Admin" And (dt.Rows(0).Item(8).ToString() = TextBoxContraseña.Text) Then
            Me.Hide()
            MenuPrincipal.Show()
        Else
            Me.Hide()
            MenuPrincipalUsuario.Show()
        End If



        'For i = 0 To dt.Rows.Count - 1
        '    MsgBox("El codigo es " & dt.Rows(i).Item(0).ToString() & " y su nombre es " & dt.Rows(i).Item(1).ToString())
        'Next i


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BotonIngresar.Click 'verificacion de datos boton Ingresar

        Call ValidarUser()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        MenuRestablecerContraseña.Show()
    End Sub
End Class
