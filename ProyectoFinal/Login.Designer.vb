<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxCedula = New System.Windows.Forms.TextBox()
        Me.TextBoxContraseña = New System.Windows.Forms.TextBox()
        Me.BotonIngresarAdmin = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.BotonIngresar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(92, 89)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(451, 91)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FIT Tracker"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(757, 350)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cédula:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(700, 497)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contraseña:"
        '
        'TextBoxCedula
        '
        Me.TextBoxCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCedula.Location = New System.Drawing.Point(945, 342)
        Me.TextBoxCedula.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxCedula.MaxLength = 50
        Me.TextBoxCedula.Name = "TextBoxCedula"
        Me.TextBoxCedula.Size = New System.Drawing.Size(337, 41)
        Me.TextBoxCedula.TabIndex = 3
        '
        'TextBoxContraseña
        '
        Me.TextBoxContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxContraseña.Location = New System.Drawing.Point(945, 490)
        Me.TextBoxContraseña.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxContraseña.MaxLength = 50
        Me.TextBoxContraseña.Name = "TextBoxContraseña"
        Me.TextBoxContraseña.Size = New System.Drawing.Size(337, 41)
        Me.TextBoxContraseña.TabIndex = 4
        Me.TextBoxContraseña.UseSystemPasswordChar = True
        '
        'BotonIngresarAdmin
        '
        Me.BotonIngresarAdmin.BackColor = System.Drawing.Color.Transparent
        Me.BotonIngresarAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonIngresarAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonIngresarAdmin.ForeColor = System.Drawing.Color.White
        Me.BotonIngresarAdmin.Location = New System.Drawing.Point(1106, 639)
        Me.BotonIngresarAdmin.Margin = New System.Windows.Forms.Padding(4)
        Me.BotonIngresarAdmin.Name = "BotonIngresarAdmin"
        Me.BotonIngresarAdmin.Size = New System.Drawing.Size(218, 89)
        Me.BotonIngresarAdmin.TabIndex = 5
        Me.BotonIngresarAdmin.Text = "Ingresar como Admin"
        Me.BotonIngresarAdmin.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(1009, 89)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(209, 202)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(988, 548)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(240, 25)
        Me.LinkLabel1.TabIndex = 7
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "¿Olvidaste tu contraseña?"
        '
        'BotonIngresar
        '
        Me.BotonIngresar.BackColor = System.Drawing.Color.Transparent
        Me.BotonIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonIngresar.ForeColor = System.Drawing.Color.White
        Me.BotonIngresar.Location = New System.Drawing.Point(866, 639)
        Me.BotonIngresar.Margin = New System.Windows.Forms.Padding(4)
        Me.BotonIngresar.Name = "BotonIngresar"
        Me.BotonIngresar.Size = New System.Drawing.Size(199, 89)
        Me.BotonIngresar.TabIndex = 8
        Me.BotonIngresar.Text = "Ingresar "
        Me.BotonIngresar.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1353, 789)
        Me.Controls.Add(Me.BotonIngresar)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BotonIngresarAdmin)
        Me.Controls.Add(Me.TextBoxContraseña)
        Me.Controls.Add(Me.TextBoxCedula)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxCedula As TextBox
    Friend WithEvents TextBoxContraseña As TextBox
    Friend WithEvents BotonIngresarAdmin As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents BotonIngresar As Button
End Class
