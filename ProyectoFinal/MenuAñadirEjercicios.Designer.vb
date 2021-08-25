<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuAñadirEjercicios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuAñadirEjercicios))
        Me.ButtonBrazos = New System.Windows.Forms.Button()
        Me.ButtonPiernas = New System.Windows.Forms.Button()
        Me.ButtonEspalda = New System.Windows.Forms.Button()
        Me.ButtonPecho = New System.Windows.Forms.Button()
        Me.ButtonHombros = New System.Windows.Forms.Button()
        Me.ButtonGuardar = New System.Windows.Forms.Button()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Calendario = New System.Windows.Forms.MonthCalendar()
        Me.ButtonFecha = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ButtonBrazos
        '
        Me.ButtonBrazos.BackColor = System.Drawing.Color.Transparent
        Me.ButtonBrazos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBrazos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBrazos.ForeColor = System.Drawing.Color.White
        Me.ButtonBrazos.Location = New System.Drawing.Point(736, 128)
        Me.ButtonBrazos.Name = "ButtonBrazos"
        Me.ButtonBrazos.Size = New System.Drawing.Size(124, 36)
        Me.ButtonBrazos.TabIndex = 6
        Me.ButtonBrazos.Text = "Brazos"
        Me.ButtonBrazos.UseVisualStyleBackColor = False
        '
        'ButtonPiernas
        '
        Me.ButtonPiernas.BackColor = System.Drawing.Color.Transparent
        Me.ButtonPiernas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPiernas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPiernas.ForeColor = System.Drawing.Color.White
        Me.ButtonPiernas.Location = New System.Drawing.Point(127, 128)
        Me.ButtonPiernas.Name = "ButtonPiernas"
        Me.ButtonPiernas.Size = New System.Drawing.Size(124, 36)
        Me.ButtonPiernas.TabIndex = 7
        Me.ButtonPiernas.Text = "Piernas"
        Me.ButtonPiernas.UseVisualStyleBackColor = False
        '
        'ButtonEspalda
        '
        Me.ButtonEspalda.BackColor = System.Drawing.Color.Transparent
        Me.ButtonEspalda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEspalda.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEspalda.ForeColor = System.Drawing.Color.White
        Me.ButtonEspalda.Location = New System.Drawing.Point(285, 128)
        Me.ButtonEspalda.Name = "ButtonEspalda"
        Me.ButtonEspalda.Size = New System.Drawing.Size(124, 36)
        Me.ButtonEspalda.TabIndex = 8
        Me.ButtonEspalda.Text = "Espalda"
        Me.ButtonEspalda.UseVisualStyleBackColor = False
        '
        'ButtonPecho
        '
        Me.ButtonPecho.BackColor = System.Drawing.Color.Transparent
        Me.ButtonPecho.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPecho.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPecho.ForeColor = System.Drawing.Color.White
        Me.ButtonPecho.Location = New System.Drawing.Point(437, 128)
        Me.ButtonPecho.Name = "ButtonPecho"
        Me.ButtonPecho.Size = New System.Drawing.Size(124, 36)
        Me.ButtonPecho.TabIndex = 9
        Me.ButtonPecho.Text = "Pecho"
        Me.ButtonPecho.UseVisualStyleBackColor = False
        '
        'ButtonHombros
        '
        Me.ButtonHombros.BackColor = System.Drawing.Color.Transparent
        Me.ButtonHombros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonHombros.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHombros.ForeColor = System.Drawing.Color.White
        Me.ButtonHombros.Location = New System.Drawing.Point(589, 128)
        Me.ButtonHombros.Name = "ButtonHombros"
        Me.ButtonHombros.Size = New System.Drawing.Size(124, 36)
        Me.ButtonHombros.TabIndex = 10
        Me.ButtonHombros.Text = "Hombros"
        Me.ButtonHombros.UseVisualStyleBackColor = False
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.BackColor = System.Drawing.Color.Transparent
        Me.ButtonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGuardar.ForeColor = System.Drawing.Color.White
        Me.ButtonGuardar.Location = New System.Drawing.Point(896, 585)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(95, 35)
        Me.ButtonGuardar.TabIndex = 16
        Me.ButtonGuardar.Text = "Guardar"
        Me.ButtonGuardar.UseVisualStyleBackColor = False
        '
        'ButtonBack
        '
        Me.ButtonBack.BackColor = System.Drawing.Color.Transparent
        Me.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBack.ForeColor = System.Drawing.Color.White
        Me.ButtonBack.Location = New System.Drawing.Point(12, 12)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(52, 37)
        Me.ButtonBack.TabIndex = 17
        Me.ButtonBack.Text = "←"
        Me.ButtonBack.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(353, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 37)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Añadir mis ejercicios"
        '
        'Calendario
        '
        Me.Calendario.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Calendario.Location = New System.Drawing.Point(383, 444)
        Me.Calendario.Margin = New System.Windows.Forms.Padding(7)
        Me.Calendario.Name = "Calendario"
        Me.Calendario.TabIndex = 23
        Me.Calendario.Visible = False
        '
        'ButtonFecha
        '
        Me.ButtonFecha.BackColor = System.Drawing.Color.Transparent
        Me.ButtonFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFecha.ForeColor = System.Drawing.Color.White
        Me.ButtonFecha.Location = New System.Drawing.Point(448, 385)
        Me.ButtonFecha.Name = "ButtonFecha"
        Me.ButtonFecha.Size = New System.Drawing.Size(124, 36)
        Me.ButtonFecha.TabIndex = 24
        Me.ButtonFecha.Text = "Fecha"
        Me.ButtonFecha.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Box Jump", "Deadlift", "Hip Thrust", "Lunge", "Squad"})
        Me.ComboBox1.Location = New System.Drawing.Point(127, 179)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(124, 32)
        Me.ComboBox1.TabIndex = 26
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Chin Up", "Incline Row", "Pull Up", "Seated Row", "Upright Row"})
        Me.ComboBox2.Location = New System.Drawing.Point(285, 179)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(124, 32)
        Me.ComboBox2.TabIndex = 28
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Bench Press", "Chest Press", "Incline Dumbbel", "Pullover", "Push Ups"})
        Me.ComboBox3.Location = New System.Drawing.Point(437, 179)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(124, 32)
        Me.ComboBox3.TabIndex = 29
        '
        'ComboBox4
        '
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"Arnold Press", "Lateral Raise", "Push Press", "Reverse Fly", "Shrug"})
        Me.ComboBox4.Location = New System.Drawing.Point(589, 179)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(124, 32)
        Me.ComboBox4.TabIndex = 30
        '
        'ComboBox5
        '
        Me.ComboBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"Concentration Curl", "Dips", "Hammer Curl", "Incline Curl", "Tricep Extension"})
        Me.ComboBox5.Location = New System.Drawing.Point(736, 179)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(124, 32)
        Me.ComboBox5.TabIndex = 31
        '
        'MenuAñadirEjercicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1019, 645)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ButtonFecha)
        Me.Controls.Add(Me.Calendario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.ButtonGuardar)
        Me.Controls.Add(Me.ButtonHombros)
        Me.Controls.Add(Me.ButtonPecho)
        Me.Controls.Add(Me.ButtonEspalda)
        Me.Controls.Add(Me.ButtonPiernas)
        Me.Controls.Add(Me.ButtonBrazos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuAñadirEjercicios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuAñadirEjercicios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonBrazos As Button
    Friend WithEvents ButtonPiernas As Button
    Friend WithEvents ButtonEspalda As Button
    Friend WithEvents ButtonPecho As Button
    Friend WithEvents ButtonHombros As Button
    Private WithEvents ButtonGuardar As Button
    Private WithEvents ButtonBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Calendario As MonthCalendar
    Friend WithEvents ButtonFecha As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
End Class
