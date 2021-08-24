Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting


Public Class MenuEstadisticas
    Dim conn As SqlConnection
    Dim COMMAND As SqlCommand
    Dim dbDataSet As New DataSet
    'Public Property Chart1 As Object

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub

<<<<<<< Updated upstream
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'conn = New SqlConnection
        'conn.ConnectionString = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True”
        'Dim READER As SqlDataReader
        'Try
        '    conn.Open()
        '    Dim Query As String
        '    Query = "SELECT * FROM dbo.Usuarios"
        '    COMMAND = New SqlCommand(Query, conn)
        '    READER = Command.ExecuteReader
        '    While READER.Read

        '        Chart1.Series("Peso").Points.AddXY(READER("Nombre"), READER("Peso"))

        '    End While
        '    conn.Close()

        'Catch ex As SqlException
        '    MessageBox.Show(ex.Message)
        'Finally
        '    conn.Dispose()
        'End Try
=======
    Private Sub Button1_Click(sender As Object, e As EventArgs)

>>>>>>> Stashed changes
    End Sub

    Private Sub MenuEstadisticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

<<<<<<< Updated upstream
=======
        conn = New SqlConnection
        conn.ConnectionString = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True”
        Dim READER As SqlDataReader


        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT Peso, Nombre FROM dbo.Usuarios WHERE Cedula = " + cedula
            COMMAND = New SqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            While READER.Read

                Chart1.Series("Peso").Points.AddXY(READER("Nombre"), READER("Peso"))

            End While
            conn.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try


>>>>>>> Stashed changes
    End Sub
End Class