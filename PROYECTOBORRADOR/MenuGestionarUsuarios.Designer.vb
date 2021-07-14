<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuGestionarUsuarios
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
        Me.btnAñadirUsuario = New System.Windows.Forms.Button()
        Me.btnEditarUsuario = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAñadirUsuario
        '
        Me.btnAñadirUsuario.BackgroundImage = Global.PROYECTOBORRADOR.My.Resources.Resources.azul
        Me.btnAñadirUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAñadirUsuario.ForeColor = System.Drawing.Color.White
        Me.btnAñadirUsuario.Location = New System.Drawing.Point(79, 224)
        Me.btnAñadirUsuario.Name = "btnAñadirUsuario"
        Me.btnAñadirUsuario.Size = New System.Drawing.Size(224, 57)
        Me.btnAñadirUsuario.TabIndex = 6
        Me.btnAñadirUsuario.Text = "Añadir usuario"
        Me.btnAñadirUsuario.UseVisualStyleBackColor = True
        '
        'btnEditarUsuario
        '
        Me.btnEditarUsuario.BackgroundImage = Global.PROYECTOBORRADOR.My.Resources.Resources.azul
        Me.btnEditarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarUsuario.ForeColor = System.Drawing.Color.White
        Me.btnEditarUsuario.Location = New System.Drawing.Point(492, 224)
        Me.btnEditarUsuario.Name = "btnEditarUsuario"
        Me.btnEditarUsuario.Size = New System.Drawing.Size(224, 57)
        Me.btnEditarUsuario.TabIndex = 7
        Me.btnEditarUsuario.Text = "Editar usuario"
        Me.btnEditarUsuario.UseVisualStyleBackColor = True
        '
        'MenuGestionarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PROYECTOBORRADOR.My.Resources.Resources.azul2
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEditarUsuario)
        Me.Controls.Add(Me.btnAñadirUsuario)
        Me.Name = "MenuGestionarUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuGestionarUsuarios"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAñadirUsuario As Button
    Friend WithEvents btnEditarUsuario As Button
End Class
