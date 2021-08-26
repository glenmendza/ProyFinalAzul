Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting


Public Class MenuEstadisticas
    Dim conn As SqlConnection
    Dim COMMAND As SqlCommand
    Dim dbDataSet As New DataSet
    Private Sub MenuEstadisticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection
        conn.ConnectionString = "data source=PROYAZUL; initial catalog = Gym; Integrated Security = True”
        Dim READER As SqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT Fecha, Peso, IMC FROM dbo.Estadisticas1 Where Cedula =" & cedula
            COMMAND = New SqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            While READER.Read

                Chart1.Series("Peso").Points.AddXY(READER("Fecha"), READER("Peso"))
                Chart1.Series("IMC").Points.AddXY(READER("Fecha"), READER("IMC"))

            End While
            conn.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try






    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Hide()
        MenuPrincipal.Show()
    End Sub
End Class