<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuAgenda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuAgenda))
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonConsultar = New System.Windows.Forms.Button()
        Me.ButtonNota = New System.Windows.Forms.Button()
        Me.CalendarioAgenda = New System.Windows.Forms.MonthCalendar()
        Me.LabelCedula = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxNota = New System.Windows.Forms.RichTextBox()
        Me.ButtonGuardarNota = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonBack
        '
        Me.ButtonBack.BackColor = System.Drawing.Color.Transparent
        Me.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
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
        Me.Label1.Location = New System.Drawing.Point(583, 106)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 46)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Mi agenda"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonConsultar
        '
        Me.ButtonConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConsultar.ForeColor = System.Drawing.Color.Transparent
        Me.ButtonConsultar.Location = New System.Drawing.Point(409, 417)
        Me.ButtonConsultar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonConsultar.Name = "ButtonConsultar"
        Me.ButtonConsultar.Size = New System.Drawing.Size(165, 65)
        Me.ButtonConsultar.TabIndex = 23
        Me.ButtonConsultar.Text = "Consultar"
        Me.ButtonConsultar.UseVisualStyleBackColor = True
        '
        'ButtonNota
        '
        Me.ButtonNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNota.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNota.ForeColor = System.Drawing.Color.Transparent
        Me.ButtonNota.Location = New System.Drawing.Point(795, 417)
        Me.ButtonNota.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonNota.Name = "ButtonNota"
        Me.ButtonNota.Size = New System.Drawing.Size(204, 65)
        Me.ButtonNota.TabIndex = 24
        Me.ButtonNota.Text = "Agregar nota"
        Me.ButtonNota.UseVisualStyleBackColor = True
        '
        'CalendarioAgenda
        '
        Me.CalendarioAgenda.AllowDrop = True
        Me.CalendarioAgenda.Location = New System.Drawing.Point(555, 161)
        Me.CalendarioAgenda.Name = "CalendarioAgenda"
        Me.CalendarioAgenda.TabIndex = 25
        '
        'LabelCedula
        '
        Me.LabelCedula.AutoSize = True
        Me.LabelCedula.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.LabelCedula.Location = New System.Drawing.Point(1260, 391)
        Me.LabelCedula.Name = "LabelCedula"
        Me.LabelCedula.Size = New System.Drawing.Size(87, 17)
        Me.LabelCedula.TabIndex = 26
        Me.LabelCedula.Text = "LabelCedula"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label2.Location = New System.Drawing.Point(616, 377)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(251, 29)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Fecha Seleccionada"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextBoxNota
        '
        Me.TextBoxNota.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNota.Location = New System.Drawing.Point(464, 499)
        Me.TextBoxNota.MaxLength = 200
        Me.TextBoxNota.Name = "TextBoxNota"
        Me.TextBoxNota.Size = New System.Drawing.Size(453, 157)
        Me.TextBoxNota.TabIndex = 28
        Me.TextBoxNota.Text = ""
        Me.TextBoxNota.Visible = False
        '
        'ButtonGuardarNota
        '
        Me.ButtonGuardarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGuardarNota.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGuardarNota.ForeColor = System.Drawing.Color.Transparent
        Me.ButtonGuardarNota.Location = New System.Drawing.Point(621, 683)
        Me.ButtonGuardarNota.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonGuardarNota.Name = "ButtonGuardarNota"
        Me.ButtonGuardarNota.Size = New System.Drawing.Size(139, 47)
        Me.ButtonGuardarNota.TabIndex = 29
        Me.ButtonGuardarNota.Text = "Guardar"
        Me.ButtonGuardarNota.UseVisualStyleBackColor = True
        Me.ButtonGuardarNota.Visible = False
        '
        'MenuAgenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1359, 794)
        Me.Controls.Add(Me.ButtonGuardarNota)
        Me.Controls.Add(Me.TextBoxNota)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabelCedula)
        Me.Controls.Add(Me.CalendarioAgenda)
        Me.Controls.Add(Me.ButtonNota)
        Me.Controls.Add(Me.ButtonConsultar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonBack)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MenuAgenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuAgenda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents ButtonBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonConsultar As Button
    Friend WithEvents ButtonNota As Button
    Friend WithEvents CalendarioAgenda As MonthCalendar
    Friend WithEvents LabelCedula As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxNota As RichTextBox
    Friend WithEvents ButtonGuardarNota As Button
End Class
