<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuModificarDatos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuModificarDatos))
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelNacimiento = New System.Windows.Forms.Label()
        Me.TextBoxCorreo = New System.Windows.Forms.TextBox()
        Me.LabelAltura = New System.Windows.Forms.Label()
        Me.TextBoxTelefono = New System.Windows.Forms.TextBox()
        Me.LabelTelefono = New System.Windows.Forms.Label()
        Me.TextBoxIMC = New System.Windows.Forms.TextBox()
        Me.LabelIMC = New System.Windows.Forms.Label()
        Me.TextBoxPeso = New System.Windows.Forms.TextBox()
        Me.LabelPeso = New System.Windows.Forms.Label()
        Me.TextBoxAltura = New System.Windows.Forms.TextBox()
        Me.TextBoxNacimiento = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.LabelCorreo = New System.Windows.Forms.Label()
        Me.TextBoxContraseña = New System.Windows.Forms.TextBox()
        Me.LabelContraseña = New System.Windows.Forms.Label()
        Me.TextBoxCedula = New System.Windows.Forms.TextBox()
        Me.TextBoxPrimerApellido = New System.Windows.Forms.TextBox()
        Me.TextBoxSegundoApellido = New System.Windows.Forms.TextBox()
        Me.LabelApellido1 = New System.Windows.Forms.Label()
        Me.LabelApellido2 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonEditarSegundoApellido = New System.Windows.Forms.Button()
        Me.ButtonEditarPrimerApellido = New System.Windows.Forms.Button()
        Me.ButtonEditarContraseña = New System.Windows.Forms.Button()
        Me.ButtonEditarCorreo = New System.Windows.Forms.Button()
        Me.ButtonEditarTelefono = New System.Windows.Forms.Button()
        Me.ButtonEditarIMC = New System.Windows.Forms.Button()
        Me.ButtonEditarPeso = New System.Windows.Forms.Button()
        Me.ButtonEditarFechaNacimiento = New System.Windows.Forms.Button()
        Me.ButtonEditarAltura = New System.Windows.Forms.Button()
        Me.ButtonEditarNombre = New System.Windows.Forms.Button()
        Me.Cal1 = New System.Windows.Forms.MonthCalendar()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Label1.Location = New System.Drawing.Point(354, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 37)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Modificar mis datos"
        '
        'LabelNacimiento
        '
        Me.LabelNacimiento.AutoSize = True
        Me.LabelNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNacimiento.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelNacimiento.Location = New System.Drawing.Point(103, 316)
        Me.LabelNacimiento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNacimiento.Name = "LabelNacimiento"
        Me.LabelNacimiento.Size = New System.Drawing.Size(159, 20)
        Me.LabelNacimiento.TabIndex = 82
        Me.LabelNacimiento.Text = "Fecha de Nacimiento"
        '
        'TextBoxCorreo
        '
        Me.TextBoxCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCorreo.Location = New System.Drawing.Point(667, 341)
        Me.TextBoxCorreo.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxCorreo.Name = "TextBoxCorreo"
        Me.TextBoxCorreo.ReadOnly = True
        Me.TextBoxCorreo.Size = New System.Drawing.Size(206, 23)
        Me.TextBoxCorreo.TabIndex = 81
        Me.TextBoxCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelAltura
        '
        Me.LabelAltura.AutoSize = True
        Me.LabelAltura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAltura.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelAltura.Location = New System.Drawing.Point(103, 377)
        Me.LabelAltura.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAltura.Name = "LabelAltura"
        Me.LabelAltura.Size = New System.Drawing.Size(51, 20)
        Me.LabelAltura.TabIndex = 80
        Me.LabelAltura.Text = "Altura"
        '
        'TextBoxTelefono
        '
        Me.TextBoxTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTelefono.Location = New System.Drawing.Point(667, 283)
        Me.TextBoxTelefono.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxTelefono.Name = "TextBoxTelefono"
        Me.TextBoxTelefono.ReadOnly = True
        Me.TextBoxTelefono.Size = New System.Drawing.Size(206, 23)
        Me.TextBoxTelefono.TabIndex = 79
        Me.TextBoxTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelTelefono
        '
        Me.LabelTelefono.AutoSize = True
        Me.LabelTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTelefono.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelTelefono.Location = New System.Drawing.Point(801, 255)
        Me.LabelTelefono.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTelefono.Name = "LabelTelefono"
        Me.LabelTelefono.Size = New System.Drawing.Size(71, 20)
        Me.LabelTelefono.TabIndex = 78
        Me.LabelTelefono.Text = "Teléfono"
        '
        'TextBoxIMC
        '
        Me.TextBoxIMC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxIMC.Location = New System.Drawing.Point(666, 225)
        Me.TextBoxIMC.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxIMC.Name = "TextBoxIMC"
        Me.TextBoxIMC.ReadOnly = True
        Me.TextBoxIMC.Size = New System.Drawing.Size(206, 23)
        Me.TextBoxIMC.TabIndex = 77
        Me.TextBoxIMC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelIMC
        '
        Me.LabelIMC.AutoSize = True
        Me.LabelIMC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIMC.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelIMC.Location = New System.Drawing.Point(694, 200)
        Me.LabelIMC.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelIMC.Name = "LabelIMC"
        Me.LabelIMC.Size = New System.Drawing.Size(178, 20)
        Me.LabelIMC.TabIndex = 76
        Me.LabelIMC.Text = "Indice de masa corporal"
        '
        'TextBoxPeso
        '
        Me.TextBoxPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPeso.Location = New System.Drawing.Point(667, 165)
        Me.TextBoxPeso.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxPeso.Name = "TextBoxPeso"
        Me.TextBoxPeso.ReadOnly = True
        Me.TextBoxPeso.Size = New System.Drawing.Size(206, 23)
        Me.TextBoxPeso.TabIndex = 75
        Me.TextBoxPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelPeso
        '
        Me.LabelPeso.AutoSize = True
        Me.LabelPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPeso.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelPeso.Location = New System.Drawing.Point(827, 143)
        Me.LabelPeso.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelPeso.Name = "LabelPeso"
        Me.LabelPeso.Size = New System.Drawing.Size(45, 20)
        Me.LabelPeso.TabIndex = 74
        Me.LabelPeso.Text = "Peso"
        '
        'TextBoxAltura
        '
        Me.TextBoxAltura.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAltura.Location = New System.Drawing.Point(101, 400)
        Me.TextBoxAltura.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxAltura.Name = "TextBoxAltura"
        Me.TextBoxAltura.ReadOnly = True
        Me.TextBoxAltura.Size = New System.Drawing.Size(206, 23)
        Me.TextBoxAltura.TabIndex = 73
        Me.TextBoxAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxNacimiento
        '
        Me.TextBoxNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNacimiento.Location = New System.Drawing.Point(101, 341)
        Me.TextBoxNacimiento.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxNacimiento.Name = "TextBoxNacimiento"
        Me.TextBoxNacimiento.ReadOnly = True
        Me.TextBoxNacimiento.Size = New System.Drawing.Size(206, 23)
        Me.TextBoxNacimiento.TabIndex = 71
        Me.TextBoxNacimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNombre.Location = New System.Drawing.Point(101, 165)
        Me.TextBoxNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.ReadOnly = True
        Me.TextBoxNombre.Size = New System.Drawing.Size(206, 23)
        Me.TextBoxNombre.TabIndex = 69
        Me.TextBoxNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelNombre.Location = New System.Drawing.Point(103, 143)
        Me.LabelNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(65, 20)
        Me.LabelNombre.TabIndex = 68
        Me.LabelNombre.Text = "Nombre"
        '
        'LabelCorreo
        '
        Me.LabelCorreo.AutoSize = True
        Me.LabelCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCorreo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelCorreo.Location = New System.Drawing.Point(733, 316)
        Me.LabelCorreo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelCorreo.Name = "LabelCorreo"
        Me.LabelCorreo.Size = New System.Drawing.Size(140, 20)
        Me.LabelCorreo.TabIndex = 93
        Me.LabelCorreo.Text = "Correo Electrónico"
        '
        'TextBoxContraseña
        '
        Me.TextBoxContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxContraseña.Location = New System.Drawing.Point(667, 400)
        Me.TextBoxContraseña.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxContraseña.Name = "TextBoxContraseña"
        Me.TextBoxContraseña.ReadOnly = True
        Me.TextBoxContraseña.Size = New System.Drawing.Size(206, 23)
        Me.TextBoxContraseña.TabIndex = 94
        Me.TextBoxContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelContraseña
        '
        Me.LabelContraseña.AutoSize = True
        Me.LabelContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelContraseña.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelContraseña.Location = New System.Drawing.Point(781, 377)
        Me.LabelContraseña.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelContraseña.Name = "LabelContraseña"
        Me.LabelContraseña.Size = New System.Drawing.Size(92, 20)
        Me.LabelContraseña.TabIndex = 97
        Me.LabelContraseña.Text = "Contraseña"
        '
        'TextBoxCedula
        '
        Me.TextBoxCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCedula.Location = New System.Drawing.Point(839, 20)
        Me.TextBoxCedula.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxCedula.Name = "TextBoxCedula"
        Me.TextBoxCedula.Size = New System.Drawing.Size(161, 23)
        Me.TextBoxCedula.TabIndex = 98
        Me.TextBoxCedula.Visible = False
        '
        'TextBoxPrimerApellido
        '
        Me.TextBoxPrimerApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrimerApellido.Location = New System.Drawing.Point(101, 225)
        Me.TextBoxPrimerApellido.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxPrimerApellido.Name = "TextBoxPrimerApellido"
        Me.TextBoxPrimerApellido.ReadOnly = True
        Me.TextBoxPrimerApellido.Size = New System.Drawing.Size(206, 23)
        Me.TextBoxPrimerApellido.TabIndex = 99
        Me.TextBoxPrimerApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxSegundoApellido
        '
        Me.TextBoxSegundoApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSegundoApellido.Location = New System.Drawing.Point(101, 283)
        Me.TextBoxSegundoApellido.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxSegundoApellido.Name = "TextBoxSegundoApellido"
        Me.TextBoxSegundoApellido.ReadOnly = True
        Me.TextBoxSegundoApellido.Size = New System.Drawing.Size(206, 23)
        Me.TextBoxSegundoApellido.TabIndex = 100
        Me.TextBoxSegundoApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelApellido1
        '
        Me.LabelApellido1.AutoSize = True
        Me.LabelApellido1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelApellido1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelApellido1.Location = New System.Drawing.Point(103, 200)
        Me.LabelApellido1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelApellido1.Name = "LabelApellido1"
        Me.LabelApellido1.Size = New System.Drawing.Size(114, 20)
        Me.LabelApellido1.TabIndex = 103
        Me.LabelApellido1.Text = "Primer Apellido"
        '
        'LabelApellido2
        '
        Me.LabelApellido2.AutoSize = True
        Me.LabelApellido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelApellido2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelApellido2.Location = New System.Drawing.Point(103, 255)
        Me.LabelApellido2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelApellido2.Name = "LabelApellido2"
        Me.LabelApellido2.Size = New System.Drawing.Size(134, 20)
        Me.LabelApellido2.TabIndex = 104
        Me.LabelApellido2.Text = "Segundo Apellido"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.ProyectoFinal.My.Resources.Resources.blind
        Me.PictureBox4.Location = New System.Drawing.Point(626, 398)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(29, 25)
        Me.PictureBox4.TabIndex = 108
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.ProyectoFinal.My.Resources.Resources.diskette
        Me.PictureBox3.Location = New System.Drawing.Point(923, 552)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(67, 66)
        Me.PictureBox3.TabIndex = 107
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(356, 225)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(299, 126)
        Me.PictureBox2.TabIndex = 106
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProyectoFinal.My.Resources.Resources.info
        Me.PictureBox1.Location = New System.Drawing.Point(43, 549)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 69)
        Me.PictureBox1.TabIndex = 105
        Me.PictureBox1.TabStop = False
        '
        'ButtonEditarSegundoApellido
        '
        Me.ButtonEditarSegundoApellido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonEditarSegundoApellido.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEditarSegundoApellido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEditarSegundoApellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ButtonEditarSegundoApellido.Image = Global.ProyectoFinal.My.Resources.Resources.edit__1_1
        Me.ButtonEditarSegundoApellido.Location = New System.Drawing.Point(311, 269)
        Me.ButtonEditarSegundoApellido.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEditarSegundoApellido.Name = "ButtonEditarSegundoApellido"
        Me.ButtonEditarSegundoApellido.Size = New System.Drawing.Size(39, 37)
        Me.ButtonEditarSegundoApellido.TabIndex = 102
        Me.ButtonEditarSegundoApellido.UseVisualStyleBackColor = True
        '
        'ButtonEditarPrimerApellido
        '
        Me.ButtonEditarPrimerApellido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonEditarPrimerApellido.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEditarPrimerApellido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEditarPrimerApellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ButtonEditarPrimerApellido.Image = Global.ProyectoFinal.My.Resources.Resources.edit__1_1
        Me.ButtonEditarPrimerApellido.Location = New System.Drawing.Point(311, 211)
        Me.ButtonEditarPrimerApellido.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEditarPrimerApellido.Name = "ButtonEditarPrimerApellido"
        Me.ButtonEditarPrimerApellido.Size = New System.Drawing.Size(39, 37)
        Me.ButtonEditarPrimerApellido.TabIndex = 101
        Me.ButtonEditarPrimerApellido.UseVisualStyleBackColor = True
        '
        'ButtonEditarContraseña
        '
        Me.ButtonEditarContraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonEditarContraseña.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEditarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEditarContraseña.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ButtonEditarContraseña.Image = Global.ProyectoFinal.My.Resources.Resources.edit__1_1
        Me.ButtonEditarContraseña.Location = New System.Drawing.Point(877, 386)
        Me.ButtonEditarContraseña.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEditarContraseña.Name = "ButtonEditarContraseña"
        Me.ButtonEditarContraseña.Size = New System.Drawing.Size(39, 37)
        Me.ButtonEditarContraseña.TabIndex = 95
        Me.ButtonEditarContraseña.UseVisualStyleBackColor = True
        '
        'ButtonEditarCorreo
        '
        Me.ButtonEditarCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonEditarCorreo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEditarCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEditarCorreo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ButtonEditarCorreo.Image = Global.ProyectoFinal.My.Resources.Resources.edit__1_1
        Me.ButtonEditarCorreo.Location = New System.Drawing.Point(877, 327)
        Me.ButtonEditarCorreo.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEditarCorreo.Name = "ButtonEditarCorreo"
        Me.ButtonEditarCorreo.Size = New System.Drawing.Size(39, 37)
        Me.ButtonEditarCorreo.TabIndex = 91
        Me.ButtonEditarCorreo.UseVisualStyleBackColor = True
        '
        'ButtonEditarTelefono
        '
        Me.ButtonEditarTelefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonEditarTelefono.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEditarTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEditarTelefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ButtonEditarTelefono.Image = Global.ProyectoFinal.My.Resources.Resources.edit__1_1
        Me.ButtonEditarTelefono.Location = New System.Drawing.Point(877, 269)
        Me.ButtonEditarTelefono.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEditarTelefono.Name = "ButtonEditarTelefono"
        Me.ButtonEditarTelefono.Size = New System.Drawing.Size(39, 37)
        Me.ButtonEditarTelefono.TabIndex = 90
        Me.ButtonEditarTelefono.UseVisualStyleBackColor = True
        '
        'ButtonEditarIMC
        '
        Me.ButtonEditarIMC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonEditarIMC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEditarIMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEditarIMC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ButtonEditarIMC.Image = Global.ProyectoFinal.My.Resources.Resources.edit__1_1
        Me.ButtonEditarIMC.Location = New System.Drawing.Point(877, 212)
        Me.ButtonEditarIMC.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEditarIMC.Name = "ButtonEditarIMC"
        Me.ButtonEditarIMC.Size = New System.Drawing.Size(39, 36)
        Me.ButtonEditarIMC.TabIndex = 89
        Me.ButtonEditarIMC.UseVisualStyleBackColor = True
        '
        'ButtonEditarPeso
        '
        Me.ButtonEditarPeso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonEditarPeso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEditarPeso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEditarPeso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ButtonEditarPeso.Image = Global.ProyectoFinal.My.Resources.Resources.edit__1_1
        Me.ButtonEditarPeso.Location = New System.Drawing.Point(877, 152)
        Me.ButtonEditarPeso.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEditarPeso.Name = "ButtonEditarPeso"
        Me.ButtonEditarPeso.Size = New System.Drawing.Size(39, 36)
        Me.ButtonEditarPeso.TabIndex = 88
        Me.ButtonEditarPeso.UseVisualStyleBackColor = True
        '
        'ButtonEditarFechaNacimiento
        '
        Me.ButtonEditarFechaNacimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonEditarFechaNacimiento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEditarFechaNacimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEditarFechaNacimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ButtonEditarFechaNacimiento.Image = Global.ProyectoFinal.My.Resources.Resources.edit__1_1
        Me.ButtonEditarFechaNacimiento.Location = New System.Drawing.Point(312, 327)
        Me.ButtonEditarFechaNacimiento.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEditarFechaNacimiento.Name = "ButtonEditarFechaNacimiento"
        Me.ButtonEditarFechaNacimiento.Size = New System.Drawing.Size(39, 37)
        Me.ButtonEditarFechaNacimiento.TabIndex = 87
        Me.ButtonEditarFechaNacimiento.UseVisualStyleBackColor = True
        '
        'ButtonEditarAltura
        '
        Me.ButtonEditarAltura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonEditarAltura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEditarAltura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEditarAltura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ButtonEditarAltura.Image = Global.ProyectoFinal.My.Resources.Resources.edit__1_1
        Me.ButtonEditarAltura.Location = New System.Drawing.Point(311, 386)
        Me.ButtonEditarAltura.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEditarAltura.Name = "ButtonEditarAltura"
        Me.ButtonEditarAltura.Size = New System.Drawing.Size(39, 37)
        Me.ButtonEditarAltura.TabIndex = 86
        Me.ButtonEditarAltura.UseVisualStyleBackColor = True
        '
        'ButtonEditarNombre
        '
        Me.ButtonEditarNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonEditarNombre.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEditarNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEditarNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ButtonEditarNombre.Image = Global.ProyectoFinal.My.Resources.Resources.edit__1_1
        Me.ButtonEditarNombre.Location = New System.Drawing.Point(311, 152)
        Me.ButtonEditarNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonEditarNombre.Name = "ButtonEditarNombre"
        Me.ButtonEditarNombre.Size = New System.Drawing.Size(39, 37)
        Me.ButtonEditarNombre.TabIndex = 85
        Me.ButtonEditarNombre.UseVisualStyleBackColor = True
        '
        'Cal1
        '
        Me.Cal1.Location = New System.Drawing.Point(372, 446)
        Me.Cal1.Name = "Cal1"
        Me.Cal1.TabIndex = 109
        Me.Cal1.Visible = False
        '
        'MenuModificarDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1019, 645)
        Me.Controls.Add(Me.Cal1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelApellido2)
        Me.Controls.Add(Me.LabelApellido1)
        Me.Controls.Add(Me.ButtonEditarSegundoApellido)
        Me.Controls.Add(Me.ButtonEditarPrimerApellido)
        Me.Controls.Add(Me.TextBoxSegundoApellido)
        Me.Controls.Add(Me.TextBoxPrimerApellido)
        Me.Controls.Add(Me.TextBoxCedula)
        Me.Controls.Add(Me.LabelContraseña)
        Me.Controls.Add(Me.ButtonEditarContraseña)
        Me.Controls.Add(Me.TextBoxContraseña)
        Me.Controls.Add(Me.LabelCorreo)
        Me.Controls.Add(Me.ButtonEditarCorreo)
        Me.Controls.Add(Me.ButtonEditarTelefono)
        Me.Controls.Add(Me.ButtonEditarIMC)
        Me.Controls.Add(Me.ButtonEditarPeso)
        Me.Controls.Add(Me.ButtonEditarFechaNacimiento)
        Me.Controls.Add(Me.ButtonEditarAltura)
        Me.Controls.Add(Me.ButtonEditarNombre)
        Me.Controls.Add(Me.LabelNacimiento)
        Me.Controls.Add(Me.TextBoxCorreo)
        Me.Controls.Add(Me.LabelAltura)
        Me.Controls.Add(Me.TextBoxTelefono)
        Me.Controls.Add(Me.LabelTelefono)
        Me.Controls.Add(Me.TextBoxIMC)
        Me.Controls.Add(Me.LabelIMC)
        Me.Controls.Add(Me.TextBoxPeso)
        Me.Controls.Add(Me.LabelPeso)
        Me.Controls.Add(Me.TextBoxAltura)
        Me.Controls.Add(Me.TextBoxNacimiento)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonBack)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuModificarDatos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FIT Tracker"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents ButtonBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonEditarCorreo As Button
    Friend WithEvents ButtonEditarTelefono As Button
    Friend WithEvents ButtonEditarIMC As Button
    Friend WithEvents ButtonEditarPeso As Button
    Friend WithEvents ButtonEditarFechaNacimiento As Button
    Friend WithEvents ButtonEditarAltura As Button
    Friend WithEvents ButtonEditarNombre As Button
    Friend WithEvents LabelNacimiento As Label
    Friend WithEvents TextBoxCorreo As TextBox
    Friend WithEvents LabelAltura As Label
    Friend WithEvents TextBoxTelefono As TextBox
    Friend WithEvents LabelTelefono As Label
    Friend WithEvents TextBoxIMC As TextBox
    Friend WithEvents LabelIMC As Label
    Friend WithEvents TextBoxPeso As TextBox
    Friend WithEvents LabelPeso As Label
    Friend WithEvents TextBoxAltura As TextBox
    Friend WithEvents TextBoxNacimiento As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents LabelNombre As Label
    Friend WithEvents LabelCorreo As Label
    Friend WithEvents TextBoxContraseña As TextBox
    Friend WithEvents ButtonEditarContraseña As Button
    Friend WithEvents LabelContraseña As Label
    Friend WithEvents TextBoxCedula As TextBox
    Friend WithEvents TextBoxPrimerApellido As TextBox
    Friend WithEvents TextBoxSegundoApellido As TextBox
    Friend WithEvents ButtonEditarPrimerApellido As Button
    Friend WithEvents ButtonEditarSegundoApellido As Button
    Friend WithEvents LabelApellido1 As Label
    Friend WithEvents LabelApellido2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Cal1 As MonthCalendar
End Class
