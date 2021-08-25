Imports System.Data
Imports System.Data.SqlClient
Public Class MenuAgenda
    Dim contador As Integer

    Dim connectionString As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
    Dim connection As SqlConnection
    Dim command As SqlCommand
    Dim lector2 As SqlDataReader

    Public Function ConectorDatos()
        connection = New SqlConnection(connectionString)
        command = connection.CreateCommand()
        command.CommandType = System.Data.CommandType.Text
    End Function


    Public Function Verificar()
        command.CommandText = "SELECT MAX(NumNota) AS NumeroMayor FROM Agenda WHERE Cedula = " & cedula & " AND (Fecha = '" & CalendarioAgenda.SelectionStart & "')"
        Using (connection)
            connection.Open()
            lector2 = command.ExecuteReader()
            lector2.Read()
            If IsDBNull(lector2.Item("NumeroMayor")) Then
                contador = 0

            ElseIf lector2.HasRows Then

                contador = lector2.GetInt32(0)



            End If

        End Using

        contador = contador + 1
        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "Agenda"

        Using con As SqlConnection = New SqlConnection(sCon)
            sel = "INSERT INTO " & NombreTabla &
                " (Cedula,Fecha,NumNota, Notas) " &
                "VALUES " &
                "(@Cedula,@Fecha, @NumNota, @Notas)"

            If contador = 6 Then
                MsgBox("Ha almacenado la cantidad limite de notas por dia", MessageBoxIcon.Warning, "FitTracker")
                Exit Function
            Else
                Dim cmd As New SqlCommand(sel, con)

                cmd.Parameters.AddWithValue("@Cedula", cedula)
                cmd.Parameters.AddWithValue("@Fecha", CalendarioAgenda.SelectionStart)
                cmd.Parameters.AddWithValue("@Notas", TextBoxNota.Text)
                cmd.Parameters.AddWithValue("@NumNota", contador)


                Try
                    con.Open()
                    Dim t As Date = CDate(cmd.ExecuteScalar())
                    MsgBox("Su nota fue almacenada correctamente. Número de nota : " & contador, MessageBoxIcon.Information, "FitTracker")
                    TextBoxNota.Text = " "
                    con.Close()
                    Return t
                Catch
                    MsgBox("Ya no puede almacenar mas notas en este dia", MessageBoxIcon.Warning, "Fit Tracker")
                    Exit Function
                End Try


            End If
        End Using
    End Function
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub

    Private Sub CalendarioAgenda_DateSelected(sender As Object, e As DateRangeEventArgs) Handles CalendarioAgenda.DateSelected
        Label2.Text = CalendarioAgenda.SelectionStart
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonNota.Click
        TextBoxNota.Text = " "
        TextBoxNota.ReadOnly = False
        TextBoxNota.Show()
        ButtonGuardarNota.Show()
    End Sub



    Private Sub ButtonGuardarNota_Click(sender As Object, e As EventArgs) Handles ButtonGuardarNota.Click
        Call ConectorDatos()
        Call Verificar()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonConsultar.Click
        TextBoxNota.Text = " "
        Dim constr As String = ("data source=PROYAZUL; initial catalog = Gym; Integrated Security = True”)

        Using con As SqlConnection = New SqlConnection(constr)
            Using cmd As SqlCommand = New SqlCommand("SELECT Cedula, Notas, NumNota, CONVERT(varchar, Fecha, 101), NumNota FROM Agenda WHERE (Cedula = " & cedula & ") and (Fecha = '" & CalendarioAgenda.SelectionStart & "' )")

                cmd.CommandType = CommandType.Text
                cmd.Connection = con
                con.Open()

                Try
                    Using lector As SqlDataReader = cmd.ExecuteReader()

                        TextBoxNota.Multiline = True
                        TextBoxNota.ReadOnly = True
                        While lector.Read()

                            TextBoxNota.Text &= "Nota: " & lector("Notas").ToString() & vbCrLf
                            TextBoxNota.Show()
                        End While
                    End Using
                Catch

                    MsgBox("No fue posible obtener las notas del dia", MessageBoxIcon.Error, "FitTracker")
                End Try
                con.Close()

            End Using
        End Using

    End Sub


End Class