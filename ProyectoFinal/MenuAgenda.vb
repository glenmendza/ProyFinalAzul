Imports System.Data
Imports System.Data.SqlClient
Public Class MenuAgenda

    Public Function Insertar()

        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "Agenda"

        sel = "INSERT INTO " & NombreTabla &
            " (Cedula,Fecha, Notas) " &
            "VALUES " &
            "(@Cedula,@Fecha, @Notas)"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)
            cmd.Parameters.AddWithValue("@Cedula", cedula)
            cmd.Parameters.AddWithValue("@Fecha", CalendarioAgenda.SelectionStart)
            cmd.Parameters.AddWithValue("@Notas", TextBoxNota.Text)

            'añadir la opcion de agregar una nueva nota en el mismo dia 

            'Si se almacena una nota con la misma cedula, manda error 
            con.Open()
            Dim t As Integer = CInt(cmd.ExecuteScalar())
            con.Close()
            Return t
        End Using
    End Function
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub



    Private Sub CalendarioAgenda_DateChanged(sender As Object, e As DateRangeEventArgs) Handles CalendarioAgenda.DateChanged

    End Sub

    Private Sub MenuAgenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CalendarioAgenda_DateSelected(sender As Object, e As DateRangeEventArgs) Handles CalendarioAgenda.DateSelected

        Label2.Text = CalendarioAgenda.SelectionStart
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonNota.Click
        TextBoxNota.Show()
        ButtonGuardarNota.Show()
    End Sub

    Private Sub TextBoxNota_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNota.TextChanged

    End Sub

    Private Sub ButtonGuardarNota_Click(sender As Object, e As EventArgs) Handles ButtonGuardarNota.Click
        Call Insertar()
        MsgBox("Su nota fue almacenada correctamente", MessageBoxIcon.Information, "FitTracker")
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonConsultar.Click
        Dim constr As String = ("data source=PROYAZUL; initial catalog = Gym; Integrated Security = True”)

        Using con As SqlConnection = New SqlConnection(constr)
            Using cmd As SqlCommand = New SqlCommand("SELECT Cedula, Notas, CONVERT(varchar, Fecha, 101) FROM Agenda WHERE (Cedula = " + cedula + ") and (Fecha = " + CalendarioAgenda.SelectionStart)

                cmd.CommandType = CommandType.Text
                cmd.Connection = con
                con.Open()

                Using lector As SqlDataReader = cmd.ExecuteReader()

                    lector.Read()

                    MsgBox("Sus notas del dia son: " + lector("Notas"), MessageBoxIcon.Information, "Fit Tracker")


                End Using

                con.Close()

            End Using
        End Using

    End Sub
End Class