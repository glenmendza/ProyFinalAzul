<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.ButtonModificarDatos = New System.Windows.Forms.Button()
        Me.ButtonGestionarUsuarios = New System.Windows.Forms.Button()
        Me.ButtonAgenda = New System.Windows.Forms.Button()
        Me.ButtonEstadisticas = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonModificarDatos
        '
        Me.ButtonModificarDatos.BackColor = System.Drawing.Color.Transparent
        Me.ButtonModificarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonModificarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonModificarDatos.ForeColor = System.Drawing.Color.White
        Me.ButtonModificarDatos.Location = New System.Drawing.Point(182, 314)
        Me.ButtonModificarDatos.Name = "ButtonModificarDatos"
        Me.ButtonModificarDatos.Size = New System.Drawing.Size(224, 57)
        Me.ButtonModificarDatos.TabIndex = 2
        Me.ButtonModificarDatos.Text = "Modificar datos"
        Me.ButtonModificarDatos.UseVisualStyleBackColor = False
        '
        'ButtonGestionarUsuarios
        '
        Me.ButtonGestionarUsuarios.BackColor = System.Drawing.Color.Transparent
        Me.ButtonGestionarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGestionarUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGestionarUsuarios.ForeColor = System.Drawing.Color.White
        Me.ButtonGestionarUsuarios.Location = New System.Drawing.Point(182, 396)
        Me.ButtonGestionarUsuarios.Name = "ButtonGestionarUsuarios"
        Me.ButtonGestionarUsuarios.Size = New System.Drawing.Size(224, 57)
        Me.ButtonGestionarUsuarios.TabIndex = 3
        Me.ButtonGestionarUsuarios.Text = "Gestionar usuarios"
        Me.ButtonGestionarUsuarios.UseVisualStyleBackColor = False
        '
        'ButtonAgenda
        '
        Me.ButtonAgenda.BackColor = System.Drawing.Color.Transparent
        Me.ButtonAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAgenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAgenda.ForeColor = System.Drawing.Color.White
        Me.ButtonAgenda.Location = New System.Drawing.Point(630, 233)
        Me.ButtonAgenda.Name = "ButtonAgenda"
        Me.ButtonAgenda.Size = New System.Drawing.Size(224, 57)
        Me.ButtonAgenda.TabIndex = 5
        Me.ButtonAgenda.Text = "Agenda"
        Me.ButtonAgenda.UseVisualStyleBackColor = False
        '
        'ButtonEstadisticas
        '
        Me.ButtonEstadisticas.BackColor = System.Drawing.Color.Transparent
        Me.ButtonEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEstadisticas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEstadisticas.ForeColor = System.Drawing.Color.White
        Me.ButtonEstadisticas.Location = New System.Drawing.Point(630, 314)
        Me.ButtonEstadisticas.Name = "ButtonEstadisticas"
        Me.ButtonEstadisticas.Size = New System.Drawing.Size(224, 57)
        Me.ButtonEstadisticas.TabIndex = 6
        Me.ButtonEstadisticas.Text = "Estadísticas"
        Me.ButtonEstadisticas.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(881, 592)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 41)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Cerrar sesión"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(379, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 37)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "FIT Tracker | Menu"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(182, 233)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(224, 57)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Añadir ejercicios"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-3, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1022, 641)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1019, 645)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonEstadisticas)
        Me.Controls.Add(Me.ButtonAgenda)
        Me.Controls.Add(Me.ButtonGestionarUsuarios)
        Me.Controls.Add(Me.ButtonModificarDatos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonModificarDatos As Button
    Friend WithEvents ButtonGestionarUsuarios As Button
    Friend WithEvents ButtonAgenda As Button
    Friend WithEvents ButtonEstadisticas As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
