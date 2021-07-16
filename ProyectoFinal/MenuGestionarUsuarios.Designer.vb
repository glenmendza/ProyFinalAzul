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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuGestionarUsuarios))
        Me.btnAñadirUsuario = New System.Windows.Forms.Button()
        Me.btnEditarUsuario = New System.Windows.Forms.Button()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAñadirUsuario
        '
        Me.btnAñadirUsuario.BackgroundImage = Global.PROYECTOBORRADOR.My.Resources.Resources.azul
        Me.btnAñadirUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAñadirUsuario.ForeColor = System.Drawing.Color.White
        Me.btnAñadirUsuario.Location = New System.Drawing.Point(241, 315)
        Me.btnAñadirUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAñadirUsuario.Name = "btnAñadirUsuario"
        Me.btnAñadirUsuario.Size = New System.Drawing.Size(299, 70)
        Me.btnAñadirUsuario.TabIndex = 6
        Me.btnAñadirUsuario.Text = "Añadir usuario"
        Me.btnAñadirUsuario.UseVisualStyleBackColor = True
        '
        'btnEditarUsuario
        '
        Me.btnEditarUsuario.BackgroundImage = Global.PROYECTOBORRADOR.My.Resources.Resources.azul
        Me.btnEditarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarUsuario.ForeColor = System.Drawing.Color.White
        Me.btnEditarUsuario.Location = New System.Drawing.Point(792, 315)
        Me.btnEditarUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditarUsuario.Name = "btnEditarUsuario"
        Me.btnEditarUsuario.Size = New System.Drawing.Size(299, 70)
        Me.btnEditarUsuario.TabIndex = 7
        Me.btnEditarUsuario.Text = "Editar usuario"
        Me.btnEditarUsuario.UseVisualStyleBackColor = True
        '
        'ButtonBack
        '
        Me.ButtonBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ButtonBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBack.ForeColor = System.Drawing.Color.White
        Me.ButtonBack.Location = New System.Drawing.Point(16, 15)
        Me.ButtonBack.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(69, 46)
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
        Me.Label1.Location = New System.Drawing.Point(488, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(355, 46)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Gestionar usuarios"
        '
        'MenuGestionarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PROYECTOBORRADOR.My.Resources.Resources.azul2
        Me.ClientSize = New System.Drawing.Size(1359, 794)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.btnEditarUsuario)
        Me.Controls.Add(Me.btnAñadirUsuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MenuGestionarUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuGestionarUsuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAñadirUsuario As Button
    Friend WithEvents btnEditarUsuario As Button
    Private WithEvents ButtonBack As Button
    Friend WithEvents Label1 As Label
End Class
