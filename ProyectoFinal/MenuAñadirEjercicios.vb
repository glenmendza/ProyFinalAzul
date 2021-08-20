Imports System.Data
Imports System.Data.SqlClient

Public Class MenuAñadirEjercicios
    Private Sub MenuAñadirEjercicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonGuardar.Visible = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonPiernas.Click
        If ListaPiernas.Visible = True Then
            ListaPiernas.Visible = False
        Else
            ListaPiernas.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonEspalda.Click
        If ListaEspalda.Visible = True Then
            ListaEspalda.Visible = False
        Else
            ListaEspalda.Visible = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonPecho.Click
        If ListaPecho.Visible = True Then
            ListaPecho.Visible = False
        Else
            ListaPecho.Visible = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonHombros.Click
        If ListaHombros.Visible = True Then
            ListaHombros.Visible = False
        Else
            ListaHombros.Visible = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ButtonBrazos.Click
        If ListaBrazos.Visible = True Then
            ListaBrazos.Visible = False
        Else
            ListaBrazos.Visible = True
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
        Call InsertarDatos()
    End Sub

    Private Sub Lista1_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles ListaPiernas.ItemCheck
        If ListaPiernas.CheckedItems.Count > 1 Then
            ButtonGuardar.Visible = True
        ElseIf ListaPiernas.CheckedItems.Count = 1 And e.NewValue = CheckState.Unchecked Then
            ButtonGuardar.Visible = False
        ElseIf ListaPiernas.CheckedItems.Count = 0 And e.NewValue = CheckState.Checked Then
            ButtonGuardar.Visible = True
        End If
    End Sub
    Private Sub Lista2_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles ListaEspalda.ItemCheck
        If ListaEspalda.CheckedItems.Count > 1 Then
            ButtonGuardar.Visible = True
        ElseIf ListaEspalda.CheckedItems.Count = 1 And e.NewValue = CheckState.Unchecked Then
            ButtonGuardar.Visible = False
        ElseIf ListaEspalda.CheckedItems.Count = 0 And e.NewValue = CheckState.Checked Then
            ButtonGuardar.Visible = True
        End If
    End Sub
    Private Sub Lista3_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles ListaPecho.ItemCheck
        If ListaPecho.CheckedItems.Count > 1 Then
            ButtonGuardar.Visible = True
        ElseIf ListaPecho.CheckedItems.Count = 1 And e.NewValue = CheckState.Unchecked Then
            ButtonGuardar.Visible = False
        ElseIf ListaPecho.CheckedItems.Count = 0 And e.NewValue = CheckState.Checked Then
            ButtonGuardar.Visible = True
        End If
    End Sub
    Private Sub Lista4_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles ListaHombros.ItemCheck
        If ListaHombros.CheckedItems.Count > 1 Then
            ButtonGuardar.Visible = True
        ElseIf ListaHombros.CheckedItems.Count = 1 And e.NewValue = CheckState.Unchecked Then
            ButtonGuardar.Visible = False
        ElseIf ListaHombros.CheckedItems.Count = 0 And e.NewValue = CheckState.Checked Then
            ButtonGuardar.Visible = True
        End If
    End Sub
    Private Sub Lista5_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles ListaBrazos.ItemCheck
        If ListaBrazos.CheckedItems.Count > 1 Then
            ButtonGuardar.Visible = True
        ElseIf ListaBrazos.CheckedItems.Count = 1 And e.NewValue = CheckState.Unchecked Then
            ButtonGuardar.Visible = False
        ElseIf ListaBrazos.CheckedItems.Count = 0 And e.NewValue = CheckState.Checked Then
            ButtonGuardar.Visible = True
        End If
    End Sub

    Private Sub ListaPiernas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListaPiernas.SelectedIndexChanged
        MsgBox(ListaPiernas.SelectedItem)
    End Sub
    Private Sub ValidarDatos()
        Dim stringConection As String
        stringConection = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True”
        Dim stringSelect As String = "SELECT * FROM dbo.EjerciciosUsuarios WHERE (Cedula = " & cedula & ") AND (Fecha = '" & Calendario.SelectionStart & "')"

        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter(stringSelect, stringConection)
            da.Fill(dt)
        Catch ex As Exception
        End Try

        If (dt.Rows.Count = 1) Then
            MsgBox("Ya hay datos almacenados en esta fecha", MessageBoxIcon.Error, "FIT Tracker")
            Exit Sub
        End If
    End Sub

    Private Function InsertarDatos()

        Dim sCon As String = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True"
        Dim sel As String
        Dim NombreTabla As String = "EjerciciosUsuario"

        'Dim Pierna1 As String = "(H-1)"

        sel = "INSERT INTO " & NombreTabla &
            " (Cedula, Fecha, CodigoEjercicio, NombreEjercicio) " &
            " VALUES " &
            " (@Cedula, @Fecha, @CodigoEjercicio, @NombreEjercicio)"

        Using con As New SqlConnection(sCon)

            Dim cmd As New SqlCommand(sel, con)

            cmd.Parameters.AddWithValue("@Cedula", cedula)
            cmd.Parameters.AddWithValue("@Fecha", Calendario.SelectionStart)
            cmd.Parameters.AddWithValue("@NombreEjercicio", ListaPiernas.SelectedItem)

            If ListaPiernas.SelectedItem = "Box Jump" Then
                cmd.Parameters.AddWithValue("@CodigoEjercicio", "PI-1")
            End If
            If ListaPecho.SelectedItem = "Bench Press" Then
                cmd.Parameters.AddWithValue("@CodigoEjercicio", "PE-1")
            End If

            con.Open()
            Try
                Dim t As Integer = CInt(cmd.ExecuteScalar())
                'MessageBox.Show("Datos guardados con exito", "FIT Tracker")
                MsgBox("Has guardado tus ejercicios del día " + Calendario.SelectionStart + "! (YY/MM/DD)")
                con.Close()
                Return t
            Catch ex As Exception
                MsgBox("Error, ya están registrados estos ejercicios en " + Calendario.SelectionStart)
            End Try
        End Using
    End Function

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'MsgBox(ListaPiernas.SelectedItem(1) = CheckState.Checked)
    End Sub


    'Hola grupo


End Class