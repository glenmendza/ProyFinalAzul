Imports System.Data
Imports System.Data.SqlClient
Public Class MenuAgenda
    Dim contador As Integer = 1
    Dim contador2 As Integer = contador
    Public Function Insertar()

        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "Agenda"
        sel = "INSERT INTO " & NombreTabla &
            " (Cedula,Fecha,NumNota, Notas) " &
            "VALUES " &
            "(@Cedula,@Fecha, @NumNota, @Notas)"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)

            cmd.Parameters.AddWithValue("@Cedula", cedula)
            cmd.Parameters.AddWithValue("@Fecha", CalendarioAgenda.SelectionStart)
            cmd.Parameters.AddWithValue("@Notas", TextBoxNota.Text)
            cmd.Parameters.AddWithValue("@NumNota", contador)

            Try
                con.Open()
                Dim t As Date = CDate(cmd.ExecuteScalar())
                con.Close()
                Return t
            Catch
                MsgBox("Una nota ya fue almacenada en esta posicion")
            End Try



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
        Call Insertar()
        contador = contador + 1
        MsgBox("Su nota fue almacenada correctamente", MessageBoxIcon.Information, "FitTracker")
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonConsultar.Click

        Dim constr As String = ("data source=PROYAZUL; initial catalog = Gym; Integrated Security = True”)

        Using con As SqlConnection = New SqlConnection(constr)
            Using cmd As SqlCommand = New SqlCommand("SELECT Cedula, Notas, CONVERT(varchar, Fecha, 101), NumNota FROM Agenda WHERE (Cedula = " & cedula & "), (NumNota = )" & contador2 & " and (Fecha = '" & CalendarioAgenda.SelectionStart & "' )")

                cmd.CommandType = CommandType.Text
                cmd.Connection = con
                con.Open()
                Try
                    Using lector As SqlDataReader = cmd.ExecuteReader()

                        lector.Read()


                        TextBoxNota.Multiline = True
                        TextBoxNota.ReadOnly = True
                        TextBoxNota.Text =
                            "Sus notas del dia son: " & vbCrLf & lector("Notas")
                        TextBoxNota.Show()
                    End Using
                Catch

                    MsgBox("No tiene notas almacenadas en este dia", MessageBoxIcon.Error, "FitTracker")
                End Try
                con.Close()

            End Using
        End Using

    End Sub


End Class