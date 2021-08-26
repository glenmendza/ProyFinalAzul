Imports System.Data
Imports System.Data.SqlClient

Public Class MenuAñadirEjercicios
    Private Sub MenuAñadirEjercicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'ButtonGuardar.Visible = False
        RichTextBoxPiernas.Visible = False
        RichTextBoxEspalda.Visible = False
        RichTextBoxPecho.Visible = False
        RichTextBoxHombros.Visible = False
        RichTextBoxBrazos.Visible = False

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonPiernas.Click
        If RichTextBoxPiernas.Visible = True Then
            RichTextBoxPiernas.Visible = False
        Else
            RichTextBoxPiernas.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonEspalda.Click
        If RichTextBoxEspalda.Visible = True Then
            RichTextBoxEspalda.Visible = False
        Else
            RichTextBoxEspalda.Visible = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonPecho.Click
        If RichTextBoxPecho.Visible = True Then
            RichTextBoxPecho.Visible = False
        Else
            RichTextBoxPecho.Visible = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonHombros.Click
        If RichTextBoxHombros.Visible = True Then
            RichTextBoxHombros.Visible = False
        Else
            RichTextBoxHombros.Visible = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ButtonBrazos.Click
        If RichTextBoxBrazos.Visible = True Then
            RichTextBoxBrazos.Visible = False
        Else
            RichTextBoxBrazos.Visible = True
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        If Calendario.Visible = True Then
            Calendario.Visible = False
        Else
            Calendario.Visible = True
        End If
    End Sub

    Private Function Button8_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        Call ValidarDatos()

        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "EjerciciosUsuario"

        sel = "INSERT INTO " & NombreTabla &
            " (Cedula, Fecha, NombreEjercicio, Repeticiones) " &
            " VALUES " &
            " (@Cedula, @Fecha, @NombreEjercicio, @Repeticiones)"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)

            'Try
            '    If TextBoxNombre.Text <> "Box Jump" Then
            '        MsgBox("Error")
            '        Exit Function
            '    ElseIf TextBoxNombre.Text <> "Chin up" Then
            '        MsgBox("Error")
            '        Exit Function
            '    End If
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    Exit Function
            'End Try

            Select Case TextBoxNombre.Text
                Case TextBoxNombre.Text <> "Box Jump"
                    MsgBox("El ejercicio no esta disponible")
                    Exit Function
                Case TextBoxNombre.Text <> "Deadlift"
                    MsgBox("El ejercicio no esta disponible ")
                    Exit Function
                Case Else
                    'se agrega el ejercicio a la bd
            End Select

            cmd.Parameters.AddWithValue("@Cedula", cedula)
            cmd.Parameters.AddWithValue("@Fecha", Calendario.SelectionStart)
            cmd.Parameters.AddWithValue("@NombreEjercicio", TextBoxNombre.Text)
            cmd.Parameters.AddWithValue("@Repeticiones", TextBoxRepeticiones.Text)

            con.Open()
            Try
                Dim t As Integer = (cmd.ExecuteScalar())
                MsgBox("Has guardado tus ejercicios el día " + Calendario.SelectionStart + "! (DD/MM/YY)")
                con.Close()
                Return t
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using


    End Function

    Private Sub ValidarDatos()

        Dim stringConection As String
        stringConection = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True”
        Dim stringSelect As String = "SELECT * FROM dbo.EjerciciosUsuarios WHERE (Cedula = " & cedula & ") And (Fecha = '" & Calendario.SelectionStart & "')"

        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter(stringSelect, stringConection)
            da.Fill(dt)
        Catch ex As Exception
        End Try

        If (dt.Rows.Count = 1) Then
            MsgBox("Ya hay datos almacenados en esta fecha :(", MessageBoxIcon.Error, "FIT Tracker")
            Exit Sub
        End If
    End Sub

    '    Private Function BoxJump()
    '        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
    '        Dim sel As String
    '        Dim NombreTabla As String = "EjerciciosUsuario"

    '        sel = "INSERT INTO " & NombreTabla &
    '            " (Cedula, Fecha, CodigoEjercicio, NombreEjercicio) " &
    '            " VALUES " &
    '            " (@Cedula, @Fecha, @CodigoEjercicio, @NombreEjercicio)"

    '        Using con As New SqlConnection(sCon)

    '            Dim cmd As New SqlCommand(sel, con)

    '            cmd.Parameters.AddWithValue("@Cedula", cedula)
    '            cmd.Parameters.AddWithValue("@Fecha", Calendario.SelectionStart)
    '            cmd.Parameters.AddWithValue("@CodigoEjercicio", "PI-1")
    '            cmd.Parameters.AddWithValue("@NombreEjercicio", "Box Jump")

    '            con.Open()
    '            Try
    '                Dim t As Integer = (cmd.ExecuteScalar())
    '                MsgBox("Has guardado tus ejercicios del día " + Calendario.SelectionStart + "! (YY/MM/DD)")
    '                con.Close()
    '                Return t
    '            Catch ex As Exception
    '                MsgBox(ex.Message)
    '            End Try
    '        End Using
    '#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    '    End Function
    '#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código


    Private Sub Calendario_DateChanged(sender As Object, e As DateRangeEventArgs) Handles Calendario.DateChanged
        Label3.Text = Calendario.SelectionStart
    End Sub


#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
End Class