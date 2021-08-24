<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuEstadisticas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuEstadisticas))
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
<<<<<<< Updated upstream
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
=======
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
>>>>>>> Stashed changes
        Me.SuspendLayout()
        '
        'ButtonBack
        '
        Me.ButtonBack.BackColor = System.Drawing.Color.Transparent
        Me.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBack.ForeColor = System.Drawing.Color.White
<<<<<<< Updated upstream
        Me.ButtonBack.Location = New System.Drawing.Point(12, 12)
=======
        Me.ButtonBack.Location = New System.Drawing.Point(16, 15)
        Me.ButtonBack.Margin = New System.Windows.Forms.Padding(4)
>>>>>>> Stashed changes
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(52, 37)
        Me.ButtonBack.TabIndex = 18
        Me.ButtonBack.Text = "←"
        Me.ButtonBack.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(381, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 37)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Mis estadísticas"
        '
        'Chart1
        '
<<<<<<< Updated upstream
        Me.PictureBox1.Location = New System.Drawing.Point(255, 181)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(520, 286)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
=======
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(429, 212)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Peso"
        Series1.YValuesPerPoint = 2
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(496, 300)
        Me.Chart1.TabIndex = 21
        Me.Chart1.Text = "Chart1"
>>>>>>> Stashed changes
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(479, 526)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuEstadisticas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
<<<<<<< Updated upstream
        Me.ClientSize = New System.Drawing.Size(1019, 645)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonBack)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
=======
        Me.ClientSize = New System.Drawing.Size(1359, 794)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonBack)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
>>>>>>> Stashed changes
        Me.Name = "MenuEstadisticas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents ButtonBack As Button
    Friend WithEvents Label1 As Label
<<<<<<< Updated upstream
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
=======
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
>>>>>>> Stashed changes
End Class
