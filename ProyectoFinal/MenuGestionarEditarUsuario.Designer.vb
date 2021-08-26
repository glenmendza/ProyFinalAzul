<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuGestionarEditarUsuario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuGestionarEditarUsuario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxGenero = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxTelefono = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxCorreo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxSegundoApellido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxPrimerApellido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.TextBoxAltura = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxPeso = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxCedula = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ButtonEditarPeso = New System.Windows.Forms.Button()
        Me.ButtonEditarAltura = New System.Windows.Forms.Button()
        Me.ButtonEditarGenero = New System.Windows.Forms.Button()
        Me.ButtonEditarTelefono = New System.Windows.Forms.Button()
        Me.ButtonEditarCorreo = New System.Windows.Forms.Button()
        Me.ButtonEditarApellido2 = New System.Windows.Forms.Button()
        Me.ButtonEditarApellido1 = New System.Windows.Forms.Button()
        Me.ButtonEditarNombre = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(411, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 37)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Editar Usuario"
        '
        'TextBoxGenero
        '
        Me.TextBoxGenero.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxGenero.Location = New System.Drawing.Point(710, 226)
        Me.TextBoxGenero.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxGenero.Name = "TextBoxGenero"
        Me.TextBoxGenero.ReadOnly = True
        Me.TextBoxGenero.Size = New System.Drawing.Size(135, 23)
        Me.TextBoxGenero.TabIndex = 54
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(787, 203)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 20)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Género"
        '
        'TextBoxTelefono
        '
        Me.TextBoxTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTelefono.Location = New System.Drawing.Point(710, 166)
        Me.TextBoxTelefono.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxTelefono.Name = "TextBoxTelefono"
        Me.TextBoxTelefono.ReadOnly = True
        Me.TextBoxTelefono.Size = New System.Drawing.Size(135, 23)
        Me.TextBoxTelefono.TabIndex = 52
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(777, 143)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 20)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Teléfono"
        '
        'TextBoxCorreo
        '
        Me.TextBoxCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCorreo.Location = New System.Drawing.Point(123, 356)
        Me.TextBoxCorreo.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxCorreo.Name = "TextBoxCorreo"
        Me.TextBoxCorreo.ReadOnly = True
        Me.TextBoxCorreo.Size = New System.Drawing.Size(175, 23)
        Me.TextBoxCorreo.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(119, 325)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 20)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Correo Electronico"
        '
        'TextBoxSegundoApellido
        '
        Me.TextBoxSegundoApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSegundoApellido.Location = New System.Drawing.Point(124, 291)
        Me.TextBoxSegundoApellido.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxSegundoApellido.Name = "TextBoxSegundoApellido"
        Me.TextBoxSegundoApellido.ReadOnly = True
        Me.TextBoxSegundoApellido.Size = New System.Drawing.Size(175, 23)
        Me.TextBoxSegundoApellido.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(120, 261)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 20)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Segundo Apellido"
        '
        'TextBoxPrimerApellido
        '
        Me.TextBoxPrimerApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrimerApellido.Location = New System.Drawing.Point(124, 232)
        Me.TextBoxPrimerApellido.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxPrimerApellido.Name = "TextBoxPrimerApellido"
        Me.TextBoxPrimerApellido.ReadOnly = True
        Me.TextBoxPrimerApellido.Size = New System.Drawing.Size(175, 23)
        Me.TextBoxPrimerApellido.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(120, 203)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 20)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Primer Apellido"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNombre.Location = New System.Drawing.Point(124, 172)
        Me.TextBoxNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.ReadOnly = True
        Me.TextBoxNombre.Size = New System.Drawing.Size(175, 23)
        Me.TextBoxNombre.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(120, 143)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Nombre"
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
        Me.ButtonBack.TabIndex = 68
        Me.ButtonBack.Text = "←"
        Me.ButtonBack.UseVisualStyleBackColor = False
        '
        'TextBoxAltura
        '
        Me.TextBoxAltura.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAltura.Location = New System.Drawing.Point(710, 284)
        Me.TextBoxAltura.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxAltura.Name = "TextBoxAltura"
        Me.TextBoxAltura.ReadOnly = True
        Me.TextBoxAltura.Size = New System.Drawing.Size(135, 23)
        Me.TextBoxAltura.TabIndex = 71
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(795, 263)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 20)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Altura"
        '
        'TextBoxPeso
        '
        Me.TextBoxPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPeso.Location = New System.Drawing.Point(708, 341)
        Me.TextBoxPeso.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxPeso.Name = "TextBoxPeso"
        Me.TextBoxPeso.ReadOnly = True
        Me.TextBoxPeso.Size = New System.Drawing.Size(135, 23)
        Me.TextBoxPeso.TabIndex = 74
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(799, 319)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 20)
        Me.Label9.TabIndex = 73
        Me.Label9.Text = "Peso"
        '
        'TextBoxCedula
        '
        Me.TextBoxCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCedula.Location = New System.Drawing.Point(437, 128)
        Me.TextBoxCedula.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxCedula.Name = "TextBoxCedula"
        Me.TextBoxCedula.Size = New System.Drawing.Size(150, 28)
        Me.TextBoxCedula.TabIndex = 76
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProyectoFinal.My.Resources.Resources.MicrosoftTeams_image__1_
        Me.PictureBox1.Location = New System.Drawing.Point(30, 552)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 65)
        Me.PictureBox1.TabIndex = 80
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.ProyectoFinal.My.Resources.Resources.diskette
        Me.PictureBox3.Location = New System.Drawing.Point(923, 552)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(66, 65)
        Me.PictureBox3.TabIndex = 79
        Me.PictureBox3.TabStop = False
        '
        'ButtonEditarPeso
        '
        Me.ButtonEditarPeso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonEditarPeso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEditarPeso.Image = CType(resources.GetObject("ButtonEditarPeso.Image"), System.Drawing.Image)
        Me.ButtonEditarPeso.Location = New System.Drawing.Point(849, 326)
        Me.ButtonEditarPeso.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEditarPeso.Name = "ButtonEditarPeso"
        Me.ButtonEditarPeso.Size = New System.Drawing.Size(39, 37)
        Me.ButtonEditarPeso.TabIndex = 78
        Me.ButtonEditarPeso.UseVisualStyleBackColor = True
        '
        'ButtonEditarAltura
        '
        Me.ButtonEditarAltura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonEditarAltura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEditarAltura.Image = CType(resources.GetObject("ButtonEditarAltura.Image"), System.Drawing.Image)
        Me.ButtonEditarAltura.Location = New System.Drawing.Point(849, 270)
        Me.ButtonEditarAltura.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEditarAltura.Name = "ButtonEditarAltura"
        Me.ButtonEditarAltura.Size = New System.Drawing.Size(39, 37)
        Me.ButtonEditarAltura.TabIndex = 77
        Me.ButtonEditarAltura.UseVisualStyleBackColor = True
        '
        'ButtonEditarGenero
        '
        Me.ButtonEditarGenero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonEditarGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEditarGenero.Image = CType(resources.GetObject("ButtonEditarGenero.Image"), System.Drawing.Image)
        Me.ButtonEditarGenero.Location = New System.Drawing.Point(848, 214)
        Me.ButtonEditarGenero.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEditarGenero.Name = "ButtonEditarGenero"
        Me.ButtonEditarGenero.Size = New System.Drawing.Size(39, 37)
        Me.ButtonEditarGenero.TabIndex = 66
        Me.ButtonEditarGenero.UseVisualStyleBackColor = True
        '
        'ButtonEditarTelefono
        '
        Me.ButtonEditarTelefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonEditarTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEditarTelefono.Image = CType(resources.GetObject("ButtonEditarTelefono.Image"), System.Drawing.Image)
        Me.ButtonEditarTelefono.Location = New System.Drawing.Point(849, 151)
        Me.ButtonEditarTelefono.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEditarTelefono.Name = "ButtonEditarTelefono"
        Me.ButtonEditarTelefono.Size = New System.Drawing.Size(39, 37)
        Me.ButtonEditarTelefono.TabIndex = 65
        Me.ButtonEditarTelefono.UseVisualStyleBackColor = True
        '
        'ButtonEditarCorreo
        '
        Me.ButtonEditarCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonEditarCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEditarCorreo.Image = CType(resources.GetObject("ButtonEditarCorreo.Image"), System.Drawing.Image)
        Me.ButtonEditarCorreo.Location = New System.Drawing.Point(302, 341)
        Me.ButtonEditarCorreo.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEditarCorreo.Name = "ButtonEditarCorreo"
        Me.ButtonEditarCorreo.Size = New System.Drawing.Size(39, 37)
        Me.ButtonEditarCorreo.TabIndex = 64
        Me.ButtonEditarCorreo.UseVisualStyleBackColor = True
        '
        'ButtonEditarApellido2
        '
        Me.ButtonEditarApellido2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonEditarApellido2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEditarApellido2.Image = CType(resources.GetObject("ButtonEditarApellido2.Image"), System.Drawing.Image)
        Me.ButtonEditarApellido2.Location = New System.Drawing.Point(303, 276)
        Me.ButtonEditarApellido2.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEditarApellido2.Name = "ButtonEditarApellido2"
        Me.ButtonEditarApellido2.Size = New System.Drawing.Size(39, 37)
        Me.ButtonEditarApellido2.TabIndex = 62
        Me.ButtonEditarApellido2.UseVisualStyleBackColor = True
        '
        'ButtonEditarApellido1
        '
        Me.ButtonEditarApellido1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonEditarApellido1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEditarApellido1.Image = CType(resources.GetObject("ButtonEditarApellido1.Image"), System.Drawing.Image)
        Me.ButtonEditarApellido1.Location = New System.Drawing.Point(303, 219)
        Me.ButtonEditarApellido1.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEditarApellido1.Name = "ButtonEditarApellido1"
        Me.ButtonEditarApellido1.Size = New System.Drawing.Size(39, 37)
        Me.ButtonEditarApellido1.TabIndex = 61
        Me.ButtonEditarApellido1.UseVisualStyleBackColor = True
        '
        'ButtonEditarNombre
        '
        Me.ButtonEditarNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonEditarNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEditarNombre.Image = CType(resources.GetObject("ButtonEditarNombre.Image"), System.Drawing.Image)
        Me.ButtonEditarNombre.Location = New System.Drawing.Point(303, 159)
        Me.ButtonEditarNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEditarNombre.Name = "ButtonEditarNombre"
        Me.ButtonEditarNombre.Size = New System.Drawing.Size(39, 37)
        Me.ButtonEditarNombre.TabIndex = 60
        Me.ButtonEditarNombre.UseVisualStyleBackColor = True
        '
        'MenuGestionarEditarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1019, 645)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.ButtonEditarPeso)
        Me.Controls.Add(Me.ButtonEditarAltura)
        Me.Controls.Add(Me.TextBoxCedula)
        Me.Controls.Add(Me.TextBoxPeso)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBoxAltura)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.ButtonEditarGenero)
        Me.Controls.Add(Me.ButtonEditarTelefono)
        Me.Controls.Add(Me.ButtonEditarCorreo)
        Me.Controls.Add(Me.ButtonEditarApellido2)
        Me.Controls.Add(Me.ButtonEditarApellido1)
        Me.Controls.Add(Me.ButtonEditarNombre)
        Me.Controls.Add(Me.TextBoxGenero)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxTelefono)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxCorreo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxSegundoApellido)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxPrimerApellido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MenuGestionarEditarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FIT Tracker"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxGenero As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxTelefono As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxCorreo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxSegundoApellido As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxPrimerApellido As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonEditarNombre As Button
    Friend WithEvents ButtonEditarApellido1 As Button
    Friend WithEvents ButtonEditarApellido2 As Button
    Friend WithEvents ButtonEditarCorreo As Button
    Friend WithEvents ButtonEditarTelefono As Button
    Friend WithEvents ButtonEditarGenero As Button
    Private WithEvents ButtonBack As Button
    Friend WithEvents TextBoxAltura As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxPeso As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxCedula As TextBox
    Friend WithEvents ButtonEditarAltura As Button
    Friend WithEvents ButtonEditarPeso As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
