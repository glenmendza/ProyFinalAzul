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
        Me.ButtonAñadirEjercicios = New System.Windows.Forms.Button()
        Me.ButtonModificarDatos = New System.Windows.Forms.Button()
        Me.ButtonGestionarUsuarios = New System.Windows.Forms.Button()
        Me.ButtonAgenda = New System.Windows.Forms.Button()
        Me.ButtonEstadisticas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonAñadirEjercicios
        '
        Me.ButtonAñadirEjercicios.BackgroundImage = Global.PROYECTOBORRADOR.My.Resources.Resources.azul
        Me.ButtonAñadirEjercicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAñadirEjercicios.ForeColor = System.Drawing.Color.White
        Me.ButtonAñadirEjercicios.Location = New System.Drawing.Point(182, 233)
        Me.ButtonAñadirEjercicios.Name = "ButtonAñadirEjercicios"
        Me.ButtonAñadirEjercicios.Size = New System.Drawing.Size(224, 57)
        Me.ButtonAñadirEjercicios.TabIndex = 0
        Me.ButtonAñadirEjercicios.Text = "Añadir ejercicios"
        Me.ButtonAñadirEjercicios.UseVisualStyleBackColor = True
        '
        'ButtonModificarDatos
        '
        Me.ButtonModificarDatos.BackgroundImage = Global.PROYECTOBORRADOR.My.Resources.Resources.azul
        Me.ButtonModificarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonModificarDatos.ForeColor = System.Drawing.Color.White
        Me.ButtonModificarDatos.Location = New System.Drawing.Point(182, 314)
        Me.ButtonModificarDatos.Name = "ButtonModificarDatos"
        Me.ButtonModificarDatos.Size = New System.Drawing.Size(224, 57)
        Me.ButtonModificarDatos.TabIndex = 2
        Me.ButtonModificarDatos.Text = "Modificar datos"
        Me.ButtonModificarDatos.UseVisualStyleBackColor = True
        '
        'ButtonGestionarUsuarios
        '
        Me.ButtonGestionarUsuarios.BackgroundImage = Global.PROYECTOBORRADOR.My.Resources.Resources.azul
        Me.ButtonGestionarUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGestionarUsuarios.ForeColor = System.Drawing.Color.White
        Me.ButtonGestionarUsuarios.Location = New System.Drawing.Point(182, 396)
        Me.ButtonGestionarUsuarios.Name = "ButtonGestionarUsuarios"
        Me.ButtonGestionarUsuarios.Size = New System.Drawing.Size(224, 57)
        Me.ButtonGestionarUsuarios.TabIndex = 3
        Me.ButtonGestionarUsuarios.Text = "Gestionar usuarios"
        Me.ButtonGestionarUsuarios.UseVisualStyleBackColor = True
        '
        'ButtonAgenda
        '
        Me.ButtonAgenda.BackgroundImage = Global.PROYECTOBORRADOR.My.Resources.Resources.azul
        Me.ButtonAgenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAgenda.ForeColor = System.Drawing.Color.White
        Me.ButtonAgenda.Location = New System.Drawing.Point(630, 233)
        Me.ButtonAgenda.Name = "ButtonAgenda"
        Me.ButtonAgenda.Size = New System.Drawing.Size(224, 57)
        Me.ButtonAgenda.TabIndex = 5
        Me.ButtonAgenda.Text = "Agenda"
        Me.ButtonAgenda.UseVisualStyleBackColor = True
        '
        'ButtonEstadisticas
        '
        Me.ButtonEstadisticas.BackgroundImage = Global.PROYECTOBORRADOR.My.Resources.Resources.azul
        Me.ButtonEstadisticas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEstadisticas.ForeColor = System.Drawing.Color.White
        Me.ButtonEstadisticas.Location = New System.Drawing.Point(630, 314)
        Me.ButtonEstadisticas.Name = "ButtonEstadisticas"
        Me.ButtonEstadisticas.Size = New System.Drawing.Size(224, 57)
        Me.ButtonEstadisticas.TabIndex = 6
        Me.ButtonEstadisticas.Text = "Estadísticas"
        Me.ButtonEstadisticas.UseVisualStyleBackColor = True
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1019, 645)
        Me.Controls.Add(Me.ButtonEstadisticas)
        Me.Controls.Add(Me.ButtonAgenda)
        Me.Controls.Add(Me.ButtonGestionarUsuarios)
        Me.Controls.Add(Me.ButtonModificarDatos)
        Me.Controls.Add(Me.ButtonAñadirEjercicios)
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonAñadirEjercicios As Button
    Friend WithEvents ButtonModificarDatos As Button
    Friend WithEvents ButtonGestionarUsuarios As Button
    Friend WithEvents ButtonAgenda As Button
    Friend WithEvents ButtonEstadisticas As Button
End Class
