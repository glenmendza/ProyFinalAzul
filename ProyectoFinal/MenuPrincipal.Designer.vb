﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.SuspendLayout()
        '
        'ButtonModificarDatos
        '
        Me.ButtonModificarDatos.BackColor = System.Drawing.Color.Transparent
        Me.ButtonModificarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonModificarDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonModificarDatos.ForeColor = System.Drawing.Color.White
        Me.ButtonModificarDatos.Location = New System.Drawing.Point(243, 386)
        Me.ButtonModificarDatos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonModificarDatos.Name = "ButtonModificarDatos"
        Me.ButtonModificarDatos.Size = New System.Drawing.Size(299, 70)
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
        Me.ButtonGestionarUsuarios.Location = New System.Drawing.Point(243, 487)
        Me.ButtonGestionarUsuarios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonGestionarUsuarios.Name = "ButtonGestionarUsuarios"
        Me.ButtonGestionarUsuarios.Size = New System.Drawing.Size(299, 70)
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
        Me.ButtonAgenda.Location = New System.Drawing.Point(840, 287)
        Me.ButtonAgenda.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonAgenda.Name = "ButtonAgenda"
        Me.ButtonAgenda.Size = New System.Drawing.Size(299, 70)
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
        Me.ButtonEstadisticas.Location = New System.Drawing.Point(840, 386)
        Me.ButtonEstadisticas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonEstadisticas.Name = "ButtonEstadisticas"
        Me.ButtonEstadisticas.Size = New System.Drawing.Size(299, 70)
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
        Me.Button1.Location = New System.Drawing.Point(1175, 729)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 50)
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
        Me.Label1.Location = New System.Drawing.Point(505, 71)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(355, 46)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "FIT Tracker | Menu"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(243, 287)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(299, 70)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Añadir ejercicios"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1359, 794)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonEstadisticas)
        Me.Controls.Add(Me.ButtonAgenda)
        Me.Controls.Add(Me.ButtonGestionarUsuarios)
        Me.Controls.Add(Me.ButtonModificarDatos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
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
End Class
