Imports System.Data
Imports System.Data.SqlClient

Public Class MenuAñadirEjercicios
    Private Sub MenuAñadirEjercicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ButtonGuardar.Visible = False
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox3.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox4.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox5.DropDownStyle = ComboBoxStyle.DropDownList

        ComboBox1.Visible = False
        ComboBox2.Visible = False
        ComboBox3.Visible = False
        ComboBox4.Visible = False
        ComboBox5.Visible = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonPiernas.Click
        If ComboBox1.Visible = True Then
            ComboBox1.Visible = False
        Else
            ComboBox1.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonEspalda.Click
        If ComboBox2.Visible = True Then
            ComboBox2.Visible = False
        Else
            ComboBox2.Visible = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonPecho.Click
        If ComboBox3.Visible = True Then
            ComboBox3.Visible = False
        Else
            ComboBox3.Visible = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonHombros.Click
        If ComboBox4.Visible = True Then
            ComboBox4.Visible = False
        Else
            ComboBox4.Visible = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ButtonBrazos.Click
        If ComboBox5.Visible = True Then
            ComboBox5.Visible = False
        Else
            ComboBox5.Visible = True
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles ButtonFecha.Click
        If Calendario.Visible = True Then
            Calendario.Visible = False
        Else
            Calendario.Visible = True
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        Call ValidarDatos()

        If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
            Call BoxJump()
        ElseIf ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
            Call Deadlift()
        ElseIf ComboBox1.SelectedItem = ComboBox1.Items.Item(2) Then
            Call HipThrust()
        ElseIf ComboBox1.SelectedItem = ComboBox1.Items.Item(3) Then
            Call Lunge()
        ElseIf ComboBox1.SelectedItem = ComboBox1.Items.Item(4) Then
            Call Squad()
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(0) Then
            Call ChinUp()
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(1) Then
            Call InclineRow()
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(2) Then
            Call PullUp()
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(3) Then
            Call Seatedrow()
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(4) Then
            Call Uprightrow()
        ElseIf ComboBox3.SelectedItem = ComboBox3.Items.Item(0) Then
            Call BenchPress()
        ElseIf ComboBox3.SelectedItem = ComboBox3.Items.Item(1) Then
            Call ChestPress()
        ElseIf ComboBox3.SelectedItem = ComboBox3.Items.Item(2) Then
            Call InclineDumbbel()
        ElseIf ComboBox3.SelectedItem = ComboBox3.Items.Item(3) Then
            Call Pullover()
        ElseIf ComboBox3.SelectedItem = ComboBox3.Items.Item(4) Then
            Call PushUps()
        ElseIf ComboBox4.SelectedItem = ComboBox4.Items.Item(0) Then
            Call ArnoldPress()
        ElseIf ComboBox4.SelectedItem = ComboBox4.Items.Item(1) Then
            Call LateralRaise()
        ElseIf ComboBox4.SelectedItem = ComboBox4.Items.Item(2) Then
            Call PushPress()
        ElseIf ComboBox4.SelectedItem = ComboBox4.Items.Item(3) Then
            Call ReverseFly()
        ElseIf ComboBox4.SelectedItem = ComboBox4.Items.Item(4) Then
            Call Shrug()
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(0) Then
            Call ConcentrationCurl()
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(1) Then
            Call Dips()
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(2) Then
            Call HammerCurl()
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(3) Then
            Call InclineCurl()
        ElseIf ComboBox5.SelectedItem = ComboBox5.Items.Item(4) Then
            Call TricepExtension()
        End If
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox5.Text = ""

    End Sub

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

    Private Function BoxJump()
        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "EjerciciosUsuario"

        sel = "INSERT INTO " & NombreTabla &
            " (Cedula, Fecha, CodigoEjercicio, NombreEjercicio) " &
            " VALUES " &
            " (@Cedula, @Fecha, @CodigoEjercicio, @NombreEjercicio)"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)

            cmd.Parameters.AddWithValue("@Cedula", cedula)
            cmd.Parameters.AddWithValue("@Fecha", Calendario.SelectionStart)
            cmd.Parameters.AddWithValue("@CodigoEjercicio", "PI-1")
            cmd.Parameters.AddWithValue("@NombreEjercicio", "Box Jump")

            con.Open()
            Try
                Dim t As Integer = CInt(cmd.ExecuteScalar())
                MsgBox("Has guardado tus ejercicios del día " + Calendario.SelectionStart + "! (YY/MM/DD)")
                con.Close()
                Return t
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    Private Function Deadlift()
        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "EjerciciosUsuario"

        sel = "INSERT INTO " & NombreTabla &
            " (Cedula, Fecha, CodigoEjercicio, NombreEjercicio) " &
            " VALUES " &
            " (@Cedula, @Fecha, @CodigoEjercicio, @NombreEjercicio)"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)

            cmd.Parameters.AddWithValue("@Cedula", cedula)
            cmd.Parameters.AddWithValue("@Fecha", Calendario.SelectionStart)
            cmd.Parameters.AddWithValue("@CodigoEjercicio", "PI-2")
            cmd.Parameters.AddWithValue("@NombreEjercicio", "Deadlift")

            con.Open()
            Try
                Dim t As Integer = CInt(cmd.ExecuteScalar())
                MsgBox("Has guardado tus ejercicios del día " + Calendario.SelectionStart + "! (YY/MM/DD)")
                con.Close()
                Return t
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código\
    Private Function HipThrust()
        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "EjerciciosUsuario"

        sel = "INSERT INTO " & NombreTabla &
            " (Cedula, Fecha, CodigoEjercicio, NombreEjercicio) " &
            " VALUES " &
            " (@Cedula, @Fecha, @CodigoEjercicio, @NombreEjercicio)"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)

            cmd.Parameters.AddWithValue("@Cedula", cedula)
            cmd.Parameters.AddWithValue("@Fecha", Calendario.SelectionStart)
            cmd.Parameters.AddWithValue("@CodigoEjercicio", "PI-3")
            cmd.Parameters.AddWithValue("@NombreEjercicio", "Hip Thrust")

            con.Open()
            Try
                Dim t As Integer = CInt(cmd.ExecuteScalar())
                MsgBox("Has guardado tus ejercicios del día " + Calendario.SelectionStart + "! (YY/MM/DD)")
                con.Close()
                Return t
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    Private Function Lunge()
        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "EjerciciosUsuario"

        sel = "INSERT INTO " & NombreTabla &
            " (Cedula, Fecha, CodigoEjercicio, NombreEjercicio) " &
            " VALUES " &
            " (@Cedula, @Fecha, @CodigoEjercicio, @NombreEjercicio)"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)

            cmd.Parameters.AddWithValue("@Cedula", cedula)
            cmd.Parameters.AddWithValue("@Fecha", Calendario.SelectionStart)
            cmd.Parameters.AddWithValue("@CodigoEjercicio", "PI-4")
            cmd.Parameters.AddWithValue("@NombreEjercicio", "Lunge")

            con.Open()
            Try
                Dim t As Integer = CInt(cmd.ExecuteScalar())
                MsgBox("Has guardado tus ejercicios del día " + Calendario.SelectionStart + "! (YY/MM/DD)")
                con.Close()
                Return t
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    Private Function Squad()
        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "EjerciciosUsuario"

        sel = "INSERT INTO " & NombreTabla &
            " (Cedula, Fecha, CodigoEjercicio, NombreEjercicio) " &
            " VALUES " &
            " (@Cedula, @Fecha, @CodigoEjercicio, @NombreEjercicio)"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)

            cmd.Parameters.AddWithValue("@Cedula", cedula)
            cmd.Parameters.AddWithValue("@Fecha", Calendario.SelectionStart)
            cmd.Parameters.AddWithValue("@CodigoEjercicio", "PI-5")
            cmd.Parameters.AddWithValue("@NombreEjercicio", "Squad")

            con.Open()
            Try
                Dim t As Integer = CInt(cmd.ExecuteScalar())
                MsgBox("Has guardado tus ejercicios del día " + Calendario.SelectionStart + "! (YY/MM/DD)")
                con.Close()
                Return t
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    Private Function ChinUp()
        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "EjerciciosUsuario"

        sel = "INSERT INTO " & NombreTabla &
            " (Cedula, Fecha, CodigoEjercicio, NombreEjercicio) " &
            " VALUES " &
            " (@Cedula, @Fecha, @CodigoEjercicio, @NombreEjercicio)"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)

            cmd.Parameters.AddWithValue("@Cedula", cedula)
            cmd.Parameters.AddWithValue("@Fecha", Calendario.SelectionStart)
            cmd.Parameters.AddWithValue("@CodigoEjercicio", "E-1")
            cmd.Parameters.AddWithValue("@NombreEjercicio", "Chin Up")

            con.Open()
            Try
                Dim t As Integer = CInt(cmd.ExecuteScalar())
                MsgBox("Has guardado tus ejercicios del día " + Calendario.SelectionStart + "! (YY/MM/DD)")
                con.Close()
                Return t
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    Private Function InclineRow()
        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "EjerciciosUsuario"

        sel = "INSERT INTO " & NombreTabla &
            " (Cedula, Fecha, CodigoEjercicio, NombreEjercicio) " &
            " VALUES " &
            " (@Cedula, @Fecha, @CodigoEjercicio, @NombreEjercicio)"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)

            cmd.Parameters.AddWithValue("@Cedula", cedula)
            cmd.Parameters.AddWithValue("@Fecha", Calendario.SelectionStart)
            cmd.Parameters.AddWithValue("@CodigoEjercicio", "E-2")
            cmd.Parameters.AddWithValue("@NombreEjercicio", "Incline Row")

            con.Open()
            Try
                Dim t As Integer = CInt(cmd.ExecuteScalar())
                MsgBox("Has guardado tus ejercicios del día " + Calendario.SelectionStart + "! (YY/MM/DD)")
                con.Close()
                Return t
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    Private Function PullUp()
        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "EjerciciosUsuario"

        sel = "INSERT INTO " & NombreTabla &
            " (Cedula, Fecha, CodigoEjercicio, NombreEjercicio) " &
            " VALUES " &
            " (@Cedula, @Fecha, @CodigoEjercicio, @NombreEjercicio)"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)

            cmd.Parameters.AddWithValue("@Cedula", cedula)
            cmd.Parameters.AddWithValue("@Fecha", Calendario.SelectionStart)
            cmd.Parameters.AddWithValue("@CodigoEjercicio", "E-3")
            cmd.Parameters.AddWithValue("@NombreEjercicio", "Pull Up")

            con.Open()
            Try
                Dim t As Integer = CInt(cmd.ExecuteScalar())
                MsgBox("Has guardado tus ejercicios del día " + Calendario.SelectionStart + "! (YY/MM/DD)")
                con.Close()
                Return t
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    Private Function Seatedrow()
        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "EjerciciosUsuario"

        sel = "INSERT INTO " & NombreTabla &
            " (Cedula, Fecha, CodigoEjercicio, NombreEjercicio) " &
            " VALUES " &
            " (@Cedula, @Fecha, @CodigoEjercicio, @NombreEjercicio)"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)

            cmd.Parameters.AddWithValue("@Cedula", cedula)
            cmd.Parameters.AddWithValue("@Fecha", Calendario.SelectionStart)
            cmd.Parameters.AddWithValue("@CodigoEjercicio", "E-4")
            cmd.Parameters.AddWithValue("@NombreEjercicio", "Seated Row")

            con.Open()
            Try
                Dim t As Integer = CInt(cmd.ExecuteScalar())
                MsgBox("Has guardado tus ejercicios del día " + Calendario.SelectionStart + "! (YY/MM/DD)")
                con.Close()
                Return t
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    Private Function Uprightrow()
        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "EjerciciosUsuario"

        sel = "INSERT INTO " & NombreTabla &
            " (Cedula, Fecha, CodigoEjercicio, NombreEjercicio) " &
            " VALUES " &
            " (@Cedula, @Fecha, @CodigoEjercicio, @NombreEjercicio)"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)

            cmd.Parameters.AddWithValue("@Cedula", cedula)
            cmd.Parameters.AddWithValue("@Fecha", Calendario.SelectionStart)
            cmd.Parameters.AddWithValue("@CodigoEjercicio", "E-5")
            cmd.Parameters.AddWithValue("@NombreEjercicio", "Upright Row")

            con.Open()
            Try
                Dim t As Integer = CInt(cmd.ExecuteScalar())
                MsgBox("Has guardado tus ejercicios del día " + Calendario.SelectionStart + "! (YY/MM/DD)")
                con.Close()
                Return t
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    Private Function BenchPress()
        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "EjerciciosUsuario"

        sel = "INSERT INTO " & NombreTabla &
            " (Cedula, Fecha, CodigoEjercicio, NombreEjercicio) " &
            " VALUES " &
            " (@Cedula, @Fecha, @CodigoEjercicio, @NombreEjercicio)"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)

            cmd.Parameters.AddWithValue("@Cedula", cedula)
            cmd.Parameters.AddWithValue("@Fecha", Calendario.SelectionStart)
            cmd.Parameters.AddWithValue("@CodigoEjercicio", "PE-1")
            cmd.Parameters.AddWithValue("@NombreEjercicio", "Bench Press")

            con.Open()
            Try
                Dim t As Integer = CInt(cmd.ExecuteScalar())
                MsgBox("Has guardado tus ejercicios del día " + Calendario.SelectionStart + "! (YY/MM/DD)")
                con.Close()
                Return t
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    Private Function ChestPress()
        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "EjerciciosUsuario"

        sel = "INSERT INTO " & NombreTabla &
            " (Cedula, Fecha, CodigoEjercicio, NombreEjercicio) " &
            " VALUES " &
            " (@Cedula, @Fecha, @CodigoEjercicio, @NombreEjercicio)"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)

            cmd.Parameters.AddWithValue("@Cedula", cedula)
            cmd.Parameters.AddWithValue("@Fecha", Calendario.SelectionStart)
            cmd.Parameters.AddWithValue("@CodigoEjercicio", "PE-2")
            cmd.Parameters.AddWithValue("@NombreEjercicio", "Chest Press")

            con.Open()
            Try
                Dim t As Integer = CInt(cmd.ExecuteScalar())
                MsgBox("Has guardado tus ejercicios del día " + Calendario.SelectionStart + "! (YY/MM/DD)")
                con.Close()
                Return t
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function

    Private Function InclineDumbbel()
        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "EjerciciosUsuario"

        sel = "INSERT INTO " & NombreTabla &
            " (Cedula, Fecha, CodigoEjercicio, NombreEjercicio) " &
            " VALUES " &
            " (@Cedula, @Fecha, @CodigoEjercicio, @NombreEjercicio)"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)

            cmd.Parameters.AddWithValue("@Cedula", cedula)
            cmd.Parameters.AddWithValue("@Fecha", Calendario.SelectionStart)
            cmd.Parameters.AddWithValue("@CodigoEjercicio", "PE-3")
            cmd.Parameters.AddWithValue("@NombreEjercicio", "Incline Dumbbel")

            con.Open()
            Try
                Dim t As Integer = CInt(cmd.ExecuteScalar())
                MsgBox("Has guardado tus ejercicios del día " + Calendario.SelectionStart + "! (YY/MM/DD)")
                con.Close()
                Return t
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
    Private Function Pullover()
        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "EjerciciosUsuario"

        sel = "INSERT INTO " & NombreTabla &
            " (Cedula, Fecha, CodigoEjercicio, NombreEjercicio) " &
            " VALUES " &
            " (@Cedula, @Fecha, @CodigoEjercicio, @NombreEjercicio)"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)

            cmd.Parameters.AddWithValue("@Cedula", cedula)
            cmd.Parameters.AddWithValue("@Fecha", Calendario.SelectionStart)
            cmd.Parameters.AddWithValue("@CodigoEjercicio", "PE-4")
            cmd.Parameters.AddWithValue("@NombreEjercicio", "Pull over")

            con.Open()
            Try
                Dim t As Integer = CInt(cmd.ExecuteScalar())
                MsgBox("Has guardado tus ejercicios del día " + Calendario.SelectionStart + "! (YY/MM/DD)")
                con.Close()
                Return t
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
    Private Function PushUps()
        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "EjerciciosUsuario"

        sel = "INSERT INTO " & NombreTabla &
            " (Cedula, Fecha, CodigoEjercicio, NombreEjercicio) " &
            " VALUES " &
            " (@Cedula, @Fecha, @CodigoEjercicio, @NombreEjercicio)"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)

            cmd.Parameters.AddWithValue("@Cedula", cedula)
            cmd.Parameters.AddWithValue("@Fecha", Calendario.SelectionStart)
            cmd.Parameters.AddWithValue("@CodigoEjercicio", "PE-5")
            cmd.Parameters.AddWithValue("@NombreEjercicio", "Push Ups")

            con.Open()
            Try
                Dim t As Integer = CInt(cmd.ExecuteScalar())
                MsgBox("Has guardado tus ejercicios del día " + Calendario.SelectionStart + "! (YY/MM/DD)")
                con.Close()
                Return t
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código

    Private Function ArnoldPress()
        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "EjerciciosUsuario"

        sel = "INSERT INTO " & NombreTabla &
            " (Cedula, Fecha, CodigoEjercicio, NombreEjercicio) " &
            " VALUES " &
            " (@Cedula, @Fecha, @CodigoEjercicio, @NombreEjercicio)"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)

            cmd.Parameters.AddWithValue("@Cedula", cedula)
            cmd.Parameters.AddWithValue("@Fecha", Calendario.SelectionStart)
            cmd.Parameters.AddWithValue("@CodigoEjercicio", "H-1")
            cmd.Parameters.AddWithValue("@NombreEjercicio", "Arnold Press")

            con.Open()
            Try
                Dim t As Integer = CInt(cmd.ExecuteScalar())
                MsgBox("Has guardado tus ejercicios del día " + Calendario.SelectionStart + "! (YY/MM/DD)")
                con.Close()
                Return t
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    Private Function LateralRaise()
        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "EjerciciosUsuario"

        sel = "INSERT INTO " & NombreTabla &
            " (Cedula, Fecha, CodigoEjercicio, NombreEjercicio) " &
            " VALUES " &
            " (@Cedula, @Fecha, @CodigoEjercicio, @NombreEjercicio)"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)

            cmd.Parameters.AddWithValue("@Cedula", cedula)
            cmd.Parameters.AddWithValue("@Fecha", Calendario.SelectionStart)
            cmd.Parameters.AddWithValue("@CodigoEjercicio", "H-2")
            cmd.Parameters.AddWithValue("@NombreEjercicio", "Lateral Raise")

            con.Open()
            Try
                Dim t As Integer = CInt(cmd.ExecuteScalar())
                MsgBox("Has guardado tus ejercicios del día " + Calendario.SelectionStart + "! (YY/MM/DD)")
                con.Close()
                Return t
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    Private Function PushPress()
        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "EjerciciosUsuario"

        sel = "INSERT INTO " & NombreTabla &
            " (Cedula, Fecha, CodigoEjercicio, NombreEjercicio) " &
            " VALUES " &
            " (@Cedula, @Fecha, @CodigoEjercicio, @NombreEjercicio)"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)

            cmd.Parameters.AddWithValue("@Cedula", cedula)
            cmd.Parameters.AddWithValue("@Fecha", Calendario.SelectionStart)
            cmd.Parameters.AddWithValue("@CodigoEjercicio", "H-3")
            cmd.Parameters.AddWithValue("@NombreEjercicio", "Push Press")


            con.Open()
            Try
                Dim t As Integer = CInt(cmd.ExecuteScalar())
                MsgBox("Has guardado tus ejercicios del día " + Calendario.SelectionStart + "! (YY/MM/DD)")
                con.Close()
                Return t
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    Private Function ReverseFly()
        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "EjerciciosUsuario"

        sel = "INSERT INTO " & NombreTabla &
            " (Cedula, Fecha, CodigoEjercicio, NombreEjercicio) " &
            " VALUES " &
            " (@Cedula, @Fecha, @CodigoEjercicio, @NombreEjercicio)"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)

            cmd.Parameters.AddWithValue("@Cedula", cedula)
            cmd.Parameters.AddWithValue("@Fecha", Calendario.SelectionStart)
            cmd.Parameters.AddWithValue("@CodigoEjercicio", "H-4")
            cmd.Parameters.AddWithValue("@NombreEjercicio", "Reverse Fly")

            con.Open()
            Try
                Dim t As Integer = CInt(cmd.ExecuteScalar())
                MsgBox("Has guardado tus ejercicios del día " + Calendario.SelectionStart + "! (YY/MM/DD)")
                con.Close()
                Return t
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    Private Function Shrug()
        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "EjerciciosUsuario"

        sel = "INSERT INTO " & NombreTabla &
            " (Cedula, Fecha, CodigoEjercicio, NombreEjercicio) " &
            " VALUES " &
            " (@Cedula, @Fecha, @CodigoEjercicio, @NombreEjercicio)"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)

            cmd.Parameters.AddWithValue("@Cedula", cedula)
            cmd.Parameters.AddWithValue("@Fecha", Calendario.SelectionStart)
            cmd.Parameters.AddWithValue("@CodigoEjercicio", "H-5")
            cmd.Parameters.AddWithValue("@NombreEjercicio", "Shrug")

            con.Open()
            Try
                Dim t As Integer = CInt(cmd.ExecuteScalar())
                MsgBox("Has guardado tus ejercicios del día " + Calendario.SelectionStart + "! (YY/MM/DD)")
                con.Close()
                Return t
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    Private Function ConcentrationCurl()
        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "EjerciciosUsuario"

        sel = "INSERT INTO " & NombreTabla &
            " (Cedula, Fecha, CodigoEjercicio, NombreEjercicio) " &
            " VALUES " &
            " (@Cedula, @Fecha, @CodigoEjercicio, @NombreEjercicio)"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)

            cmd.Parameters.AddWithValue("@Cedula", cedula)
            cmd.Parameters.AddWithValue("@Fecha", Calendario.SelectionStart)
            cmd.Parameters.AddWithValue("@CodigoEjercicio", "B-1")
            cmd.Parameters.AddWithValue("@NombreEjercicio", "Concentration Curl")

            con.Open()
            Try
                Dim t As Integer = CInt(cmd.ExecuteScalar())
                MsgBox("Has guardado tus ejercicios del día " + Calendario.SelectionStart + "! (YY/MM/DD)")
                con.Close()
                Return t
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    Private Function Dips()
        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "EjerciciosUsuario"

        sel = "INSERT INTO " & NombreTabla &
            " (Cedula, Fecha, CodigoEjercicio, NombreEjercicio) " &
            " VALUES " &
            " (@Cedula, @Fecha, @CodigoEjercicio, @NombreEjercicio)"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)

            cmd.Parameters.AddWithValue("@Cedula", cedula)
            cmd.Parameters.AddWithValue("@Fecha", Calendario.SelectionStart)
            cmd.Parameters.AddWithValue("@CodigoEjercicio", "B-2")
            cmd.Parameters.AddWithValue("@NombreEjercicio", "Dips")

            con.Open()
            Try
                Dim t As Integer = CInt(cmd.ExecuteScalar())
                MsgBox("Has guardado tus ejercicios del día " + Calendario.SelectionStart + "! (YY/MM/DD)")
                con.Close()
                Return t
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    Private Function HammerCurl()
        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "EjerciciosUsuario"

        sel = "INSERT INTO " & NombreTabla &
            " (Cedula, Fecha, CodigoEjercicio, NombreEjercicio) " &
            " VALUES " &
            " (@Cedula, @Fecha, @CodigoEjercicio, @NombreEjercicio)"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)

            cmd.Parameters.AddWithValue("@Cedula", cedula)
            cmd.Parameters.AddWithValue("@Fecha", Calendario.SelectionStart)
            cmd.Parameters.AddWithValue("@CodigoEjercicio", "B-3")
            cmd.Parameters.AddWithValue("@NombreEjercicio", "Hammer Curl")

            con.Open()
            Try
                Dim t As Integer = CInt(cmd.ExecuteScalar())
                MsgBox("Has guardado tus ejercicios del día " + Calendario.SelectionStart + "! (YY/MM/DD)")
                con.Close()
                Return t
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    Private Function InclineCurl()
        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "EjerciciosUsuario"

        sel = "INSERT INTO " & NombreTabla &
            " (Cedula, Fecha, CodigoEjercicio, NombreEjercicio) " &
            " VALUES " &
            " (@Cedula, @Fecha, @CodigoEjercicio, @NombreEjercicio)"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)

            cmd.Parameters.AddWithValue("@Cedula", cedula)
            cmd.Parameters.AddWithValue("@Fecha", Calendario.SelectionStart)
            cmd.Parameters.AddWithValue("@CodigoEjercicio", "B-4")
            cmd.Parameters.AddWithValue("@NombreEjercicio", "Incline Curl")

            con.Open()
            Try
                Dim t As Integer = CInt(cmd.ExecuteScalar())
                MsgBox("Has guardado tus ejercicios del día " + Calendario.SelectionStart + "! (YY/MM/DD)")
                con.Close()
                Return t
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    Private Function TricepExtension()
        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "EjerciciosUsuario"

        sel = "INSERT INTO " & NombreTabla &
            " (Cedula, Fecha, CodigoEjercicio, NombreEjercicio) " &
            " VALUES " &
            " (@Cedula, @Fecha, @CodigoEjercicio, @NombreEjercicio)"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)

            cmd.Parameters.AddWithValue("@Cedula", cedula)
            cmd.Parameters.AddWithValue("@Fecha", Calendario.SelectionStart)
            cmd.Parameters.AddWithValue("@CodigoEjercicio", "B-5")
            cmd.Parameters.AddWithValue("@NombreEjercicio", "TricepExtension")

            con.Open()
            Try
                Dim t As Integer = CInt(cmd.ExecuteScalar())
                MsgBox("Has guardado tus ejercicios del día " + Calendario.SelectionStart + "! (YY/MM/DD)")
                con.Close()
                Return t
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
#Disable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
    End Function
#Enable Warning BC42105 ' La función no devuelve un valor en todas las rutas de código
End Class