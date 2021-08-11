Imports System.Data
Imports System.Data.SqlClient
Public Class MenuAgenda
    Public Function Conexion()
        Dim stringConexion As String
        stringConexion = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True”
        Dim stringSelect As String = "SELECT * FROM Agenda"
        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter(stringSelect, stringConexion)
            da.Fill(dt)

        Catch ex As Exception
        End Try
    End Function

    Public Function Leer()


    End Function
    Public Function Insertar()

        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "Agenda"

        sel = "INSERT INTO " & NombreTabla &
            " (Fecha, Notas) " &
            "VALUES " &
            "(@Fecha, @Notas)"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)
            cmd.Parameters.AddWithValue("@Fecha", CalendarioAgenda.SelectionStart)
            cmd.Parameters.AddWithValue("@Notas", TextBoxNota.Text)




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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

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
        Conexion()

    End Sub
End Class