Imports System.Data
Imports System.Data.SqlClient
Public Class MenuGestionarVerUsuarios
    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Hide()
        MenuGestionarUsuarios.Show()
    End Sub

    Private Sub MenuGestionarVerUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1.ReadOnly = True

        Dim stringConection As String
        stringConection = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True”
        Dim stringSelect As String = "SELECT * FROM Usuarios"
        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        Try
            da = New SqlDataAdapter(stringSelect, stringConection)
            da.Fill(dt)
            Me.DataGridView1.DataSource = dt
            LabelInfo.Text = String.Format("Total datos en la tabla: {0}", dt.Rows.Count)
        Catch ex As Exception

            LabelInfo.Text = "Error: " & ex.Message

        End Try
    End Sub
End Class