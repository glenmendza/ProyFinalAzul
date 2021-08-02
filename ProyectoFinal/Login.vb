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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BotonIngresarAdmin.Click 'verificacion de datos boton Ingresar como admin

        If TextBoxCedula.Text = "" Or TextBoxContraseña.Text = "" Then
            MsgBox("Debe ingresar ambos datos", MessageBoxIcon.Information, "FitTracker")

        ElseIf Len(TextBoxCedula.Text) > 9 Or Len(TextBoxCedula.Text) < 9 Then
            MsgBox("La cédula debe tener 9 dígitos", MessageBoxIcon.Error, "FitTracker")

        Else
            Dim conn As New SqlConnection
            conn.ConnectionString = ("data source=MSI; initial catalog = Gym; Integrated Security = True")

            conn.Open()
            Dim strsql As String



            strsql = " SELECT * FROM Usuarios where Cedula=" + TextBoxCedula.Text + ""


            Dim cmd As New SqlCommand(strsql, conn)
                Dim lector As SqlDataReader
                lector = cmd.ExecuteReader
                lector.Read()


            TextBoxCedula.Text = lector("Cedula")

                If lector("Acceso") = "Admin" Then
                    If TextBoxContraseña.Text = lector("Contraseña") Then

                        Me.Hide()
                        MenuPrincipal.Show()
                        conn.Close()
                    Else
                        MsgBox("La contraseña es incorrecta", MessageBoxIcon.Error, "FitTracker")

                    End If
                Else MsgBox("No tiene acceso a las funciones administrativas", MessageBoxIcon.Information, "FitTracker")
                End If
            End If



    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BotonIngresar.Click 'verificacion de datos boton Ingresar

        If TextBoxCedula.Text = "" Or TextBoxContraseña.Text = "" Then
            MsgBox("Debe ingresar ambos datos", MessageBoxIcon.Information, "FitTracker")

        ElseIf Len(TextBoxCedula.Text) > 9 Or Len(TextBoxCedula.Text) < 9 Then
            MsgBox("La cédula debe tener 9 dígitos", MessageBoxIcon.Error, "FitTracker")

        Else
            Dim conn As New SqlConnection
            conn.ConnectionString = ("data source=MSI; initial catalog = Gym; Integrated Security = True")

            conn.Open()
            Dim strsql As String



            strsql = " SELECT * FROM Usuarios where Cedula=" + TextBoxCedula.Text + ""


            Dim cmd As New SqlCommand(strsql, conn)
            Dim lector As SqlDataReader
            lector = cmd.ExecuteReader
            lector.Read()


            TextBoxCedula.Text = lector("Cedula")

            If lector("Acceso") = "Cliente" Then
                If TextBoxContraseña.Text = lector("Contraseña") Then

                    Me.Hide()
                    MenuPrincipal.Show()
                    conn.Close()
                Else
                    MsgBox("La contraseña es incorrecta", MessageBoxIcon.Error, "FitTracker")

                End If
            Else MsgBox("El usuario solo tiene acceso a las funciones administrativas", MessageBoxIcon.Information, "FitTracker")
            End If
        End If

    End Sub





End Class
