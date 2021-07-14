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
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ButtonPiernas = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Lista1 = New System.Windows.Forms.CheckedListBox()
        Me.Lista2 = New System.Windows.Forms.CheckedListBox()
        Me.Lista3 = New System.Windows.Forms.CheckedListBox()
        Me.Lista4 = New System.Windows.Forms.CheckedListBox()
        Me.Lista5 = New System.Windows.Forms.CheckedListBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(645, 143)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(124, 36)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Brazos"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'ButtonPiernas
        '
        Me.ButtonPiernas.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ButtonPiernas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPiernas.ForeColor = System.Drawing.Color.White
        Me.ButtonPiernas.Location = New System.Drawing.Point(35, 143)
        Me.ButtonPiernas.Name = "ButtonPiernas"
        Me.ButtonPiernas.Size = New System.Drawing.Size(124, 36)
        Me.ButtonPiernas.TabIndex = 7
        Me.ButtonPiernas.Text = "Piernas"
        Me.ButtonPiernas.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(194, 143)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 36)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Espalda"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(346, 143)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 36)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Pecho"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(497, 143)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(124, 36)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Hombros"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Lista1
        '
        Me.Lista1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Lista1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Lista1.CheckOnClick = True
        Me.Lista1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lista1.ForeColor = System.Drawing.Color.White
        Me.Lista1.FormattingEnabled = True
        Me.Lista1.Items.AddRange(New Object() {"Box Jump", "Deadlift", "Hip Thrust", "Lunge", "Squad"})
        Me.Lista1.Location = New System.Drawing.Point(35, 185)
        Me.Lista1.Name = "Lista1"
        Me.Lista1.Size = New System.Drawing.Size(124, 189)
        Me.Lista1.Sorted = True
        Me.Lista1.TabIndex = 11
        Me.Lista1.Visible = False
        '
        'Lista2
        '
        Me.Lista2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Lista2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Lista2.CheckOnClick = True
        Me.Lista2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lista2.ForeColor = System.Drawing.Color.White
        Me.Lista2.FormattingEnabled = True
        Me.Lista2.Items.AddRange(New Object() {"Chin Up", "Incline Row", "Pull Up", "Seated Row", "Upright Row"})
        Me.Lista2.Location = New System.Drawing.Point(194, 185)
        Me.Lista2.Name = "Lista2"
        Me.Lista2.Size = New System.Drawing.Size(124, 210)
        Me.Lista2.Sorted = True
        Me.Lista2.TabIndex = 12
        Me.Lista2.Visible = False
        '
        'Lista3
        '
        Me.Lista3.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Lista3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Lista3.CheckOnClick = True
        Me.Lista3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lista3.ForeColor = System.Drawing.Color.White
        Me.Lista3.FormattingEnabled = True
        Me.Lista3.Items.AddRange(New Object() {"Bench Press", "Chest Press", "Incline Dumbbel", "Pullover", "Push Ups"})
        Me.Lista3.Location = New System.Drawing.Point(346, 185)
        Me.Lista3.Name = "Lista3"
        Me.Lista3.Size = New System.Drawing.Size(124, 210)
        Me.Lista3.Sorted = True
        Me.Lista3.TabIndex = 13
        Me.Lista3.Visible = False
        '
        'Lista4
        '
        Me.Lista4.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Lista4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Lista4.CheckOnClick = True
        Me.Lista4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lista4.ForeColor = System.Drawing.Color.White
        Me.Lista4.FormattingEnabled = True
        Me.Lista4.Items.AddRange(New Object() {"Arnold Press", "Lateral Raise", "Push Press", "Reverse Fly", "Shrug"})
        Me.Lista4.Location = New System.Drawing.Point(497, 185)
        Me.Lista4.Name = "Lista4"
        Me.Lista4.Size = New System.Drawing.Size(124, 210)
        Me.Lista4.Sorted = True
        Me.Lista4.TabIndex = 14
        Me.Lista4.Visible = False
        '
        'Lista5
        '
        Me.Lista5.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Lista5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Lista5.CheckOnClick = True
        Me.Lista5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lista5.ForeColor = System.Drawing.Color.White
        Me.Lista5.FormattingEnabled = True
        Me.Lista5.Items.AddRange(New Object() {"Bench Press", "Chest Press", "Dumbbell Flye", "Pullover", "Push Ups"})
        Me.Lista5.Location = New System.Drawing.Point(645, 185)
        Me.Lista5.Name = "Lista5"
        Me.Lista5.Size = New System.Drawing.Size(124, 210)
        Me.Lista5.Sorted = True
        Me.Lista5.TabIndex = 15
        Me.Lista5.Visible = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(703, 376)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(95, 35)
        Me.Button6.TabIndex = 16
        Me.Button6.Text = "Guardar"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'ButtonBack
        '
        Me.ButtonBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ButtonBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBack.ForeColor = System.Drawing.Color.White
        Me.ButtonBack.Location = New System.Drawing.Point(12, 12)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(52, 37)
        Me.ButtonBack.TabIndex = 17
        Me.ButtonBack.Text = "←"
        Me.ButtonBack.UseVisualStyleBackColor = False
        '
        'MenuAñadirEjercicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(810, 423)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Lista5)
        Me.Controls.Add(Me.Lista4)
        Me.Controls.Add(Me.Lista3)
        Me.Controls.Add(Me.Lista2)
        Me.Controls.Add(Me.Lista1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ButtonPiernas)
        Me.Controls.Add(Me.Button5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuAñadirEjercicios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuAñadirEjercicios"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button5 As Button
    Friend WithEvents ButtonPiernas As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Lista2 As CheckedListBox
    Friend WithEvents Lista3 As CheckedListBox
    Friend WithEvents Lista4 As CheckedListBox
    Friend WithEvents Lista5 As CheckedListBox
    Private WithEvents Lista1 As CheckedListBox
    Private WithEvents Button6 As Button
    Private WithEvents ButtonBack As Button
End Class
