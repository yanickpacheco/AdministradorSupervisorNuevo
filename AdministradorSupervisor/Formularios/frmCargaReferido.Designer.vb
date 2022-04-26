<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargaReferido
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaterno = New System.Windows.Forms.TextBox()
        Me.txtPaterno = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtComuna = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbTipoBase = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.gpbFechaAgen = New System.Windows.Forms.GroupBox()
        Me.dtpFechaAgen = New System.Windows.Forms.DateTimePicker()
        Me.lblFecAgendar = New System.Windows.Forms.Label()
        Me.cmbMinutosAgen = New System.Windows.Forms.ComboBox()
        Me.lblHorAgendar = New System.Windows.Forms.Label()
        Me.cmbHoraAgen = New System.Windows.Forms.ComboBox()
        Me.btnLiberar = New System.Windows.Forms.Button()
        Me.chkOtroMomento = New System.Windows.Forms.RadioButton()
        Me.chkAhora = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbEjecutivo = New System.Windows.Forms.ComboBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.gpbFechaAgen.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(25, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rut"
        '
        'txtRut
        '
        Me.txtRut.Location = New System.Drawing.Point(151, 30)
        Me.txtRut.MaxLength = 8
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(100, 20)
        Me.txtRut.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(147, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CARGA REFERIDOS"
        '
        'txtMaterno
        '
        Me.txtMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMaterno.Location = New System.Drawing.Point(151, 141)
        Me.txtMaterno.MaxLength = 50
        Me.txtMaterno.Name = "txtMaterno"
        Me.txtMaterno.Size = New System.Drawing.Size(178, 20)
        Me.txtMaterno.TabIndex = 4
        '
        'txtPaterno
        '
        Me.txtPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPaterno.Location = New System.Drawing.Point(151, 107)
        Me.txtPaterno.MaxLength = 50
        Me.txtPaterno.Name = "txtPaterno"
        Me.txtPaterno.Size = New System.Drawing.Size(178, 20)
        Me.txtPaterno.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Location = New System.Drawing.Point(151, 63)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(178, 20)
        Me.txtNombre.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label7.Location = New System.Drawing.Point(25, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label3.Location = New System.Drawing.Point(25, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Paterno"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(25, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Materno"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label5.Location = New System.Drawing.Point(25, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Fecha Nacimiento"
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(152, 173)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(100, 20)
        Me.dtpFechaNacimiento.TabIndex = 5
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(151, 208)
        Me.txtTelefono.MaxLength = 9
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label6.Location = New System.Drawing.Point(25, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Telefono"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label8.Location = New System.Drawing.Point(25, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Direccion"
        '
        'txtDireccion
        '
        Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion.Location = New System.Drawing.Point(151, 245)
        Me.txtDireccion.MaxLength = 200
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(178, 20)
        Me.txtDireccion.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label9.Location = New System.Drawing.Point(25, 283)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 17)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Comuna"
        '
        'txtComuna
        '
        Me.txtComuna.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComuna.Location = New System.Drawing.Point(151, 282)
        Me.txtComuna.MaxLength = 100
        Me.txtComuna.Name = "txtComuna"
        Me.txtComuna.Size = New System.Drawing.Size(178, 20)
        Me.txtComuna.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbTipoBase)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.gpbFechaAgen)
        Me.GroupBox1.Controls.Add(Me.btnLiberar)
        Me.GroupBox1.Controls.Add(Me.chkOtroMomento)
        Me.GroupBox1.Controls.Add(Me.chkAhora)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cmbEjecutivo)
        Me.GroupBox1.Controls.Add(Me.txtPaterno)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtComuna)
        Me.GroupBox1.Controls.Add(Me.txtRut)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtMaterno)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpFechaNacimiento)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(390, 593)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        '
        'cmbTipoBase
        '
        Me.cmbTipoBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoBase.FormattingEnabled = True
        Me.cmbTipoBase.Location = New System.Drawing.Point(151, 322)
        Me.cmbTipoBase.Name = "cmbTipoBase"
        Me.cmbTipoBase.Size = New System.Drawing.Size(178, 21)
        Me.cmbTipoBase.TabIndex = 35
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label11.Location = New System.Drawing.Point(25, 322)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 17)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Tipo de base"
        '
        'gpbFechaAgen
        '
        Me.gpbFechaAgen.Controls.Add(Me.dtpFechaAgen)
        Me.gpbFechaAgen.Controls.Add(Me.lblFecAgendar)
        Me.gpbFechaAgen.Controls.Add(Me.cmbMinutosAgen)
        Me.gpbFechaAgen.Controls.Add(Me.lblHorAgendar)
        Me.gpbFechaAgen.Controls.Add(Me.cmbHoraAgen)
        Me.gpbFechaAgen.Location = New System.Drawing.Point(213, 429)
        Me.gpbFechaAgen.Name = "gpbFechaAgen"
        Me.gpbFechaAgen.Size = New System.Drawing.Size(156, 91)
        Me.gpbFechaAgen.TabIndex = 33
        Me.gpbFechaAgen.TabStop = False
        '
        'dtpFechaAgen
        '
        Me.dtpFechaAgen.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAgen.Location = New System.Drawing.Point(58, 19)
        Me.dtpFechaAgen.Name = "dtpFechaAgen"
        Me.dtpFechaAgen.Size = New System.Drawing.Size(83, 20)
        Me.dtpFechaAgen.TabIndex = 27
        '
        'lblFecAgendar
        '
        Me.lblFecAgendar.AutoSize = True
        Me.lblFecAgendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecAgendar.Location = New System.Drawing.Point(4, 25)
        Me.lblFecAgendar.Name = "lblFecAgendar"
        Me.lblFecAgendar.Size = New System.Drawing.Size(42, 13)
        Me.lblFecAgendar.TabIndex = 28
        Me.lblFecAgendar.Text = "Fecha"
        '
        'cmbMinutosAgen
        '
        Me.cmbMinutosAgen.FormattingEnabled = True
        Me.cmbMinutosAgen.Items.AddRange(New Object() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55"})
        Me.cmbMinutosAgen.Location = New System.Drawing.Point(105, 52)
        Me.cmbMinutosAgen.Name = "cmbMinutosAgen"
        Me.cmbMinutosAgen.Size = New System.Drawing.Size(44, 21)
        Me.cmbMinutosAgen.TabIndex = 31
        '
        'lblHorAgendar
        '
        Me.lblHorAgendar.AutoSize = True
        Me.lblHorAgendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorAgendar.Location = New System.Drawing.Point(4, 55)
        Me.lblHorAgendar.Name = "lblHorAgendar"
        Me.lblHorAgendar.Size = New System.Drawing.Size(34, 13)
        Me.lblHorAgendar.TabIndex = 29
        Me.lblHorAgendar.Text = "Hora"
        '
        'cmbHoraAgen
        '
        Me.cmbHoraAgen.FormattingEnabled = True
        Me.cmbHoraAgen.Items.AddRange(New Object() {"09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cmbHoraAgen.Location = New System.Drawing.Point(57, 52)
        Me.cmbHoraAgen.Name = "cmbHoraAgen"
        Me.cmbHoraAgen.Size = New System.Drawing.Size(42, 21)
        Me.cmbHoraAgen.TabIndex = 30
        '
        'btnLiberar
        '
        Me.btnLiberar.ForeColor = System.Drawing.Color.DarkRed
        Me.btnLiberar.Location = New System.Drawing.Point(127, 530)
        Me.btnLiberar.Name = "btnLiberar"
        Me.btnLiberar.Size = New System.Drawing.Size(132, 47)
        Me.btnLiberar.TabIndex = 32
        Me.btnLiberar.Text = "CARGAR REFERIDO"
        Me.btnLiberar.UseVisualStyleBackColor = True
        '
        'chkOtroMomento
        '
        Me.chkOtroMomento.AutoSize = True
        Me.chkOtroMomento.Location = New System.Drawing.Point(200, 406)
        Me.chkOtroMomento.Name = "chkOtroMomento"
        Me.chkOtroMomento.Size = New System.Drawing.Size(138, 17)
        Me.chkOtroMomento.TabIndex = 26
        Me.chkOtroMomento.TabStop = True
        Me.chkOtroMomento.Text = "Cargar en otro momento"
        Me.chkOtroMomento.UseVisualStyleBackColor = True
        '
        'chkAhora
        '
        Me.chkAhora.AutoSize = True
        Me.chkAhora.Location = New System.Drawing.Point(58, 406)
        Me.chkAhora.Name = "chkAhora"
        Me.chkAhora.Size = New System.Drawing.Size(87, 17)
        Me.chkAhora.TabIndex = 25
        Me.chkAhora.TabStop = True
        Me.chkAhora.Text = "Cargar Ahora"
        Me.chkAhora.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label10.Location = New System.Drawing.Point(25, 361)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 17)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Ejecutivo"
        '
        'cmbEjecutivo
        '
        Me.cmbEjecutivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEjecutivo.FormattingEnabled = True
        Me.cmbEjecutivo.Location = New System.Drawing.Point(152, 361)
        Me.cmbEjecutivo.Name = "cmbEjecutivo"
        Me.cmbEjecutivo.Size = New System.Drawing.Size(178, 21)
        Me.cmbEjecutivo.TabIndex = 9
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(187, 642)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(83, 27)
        Me.btnVolver.TabIndex = 33
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'frmCargaReferido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 693)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmCargaReferido"
        Me.Text = "Carga de Referido"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gpbFechaAgen.ResumeLayout(False)
        Me.gpbFechaAgen.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtRut As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaterno As TextBox
    Friend WithEvents txtPaterno As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpFechaNacimiento As DateTimePicker
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtComuna As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkOtroMomento As RadioButton
    Friend WithEvents chkAhora As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbEjecutivo As ComboBox
    Friend WithEvents gpbFechaAgen As GroupBox
    Friend WithEvents dtpFechaAgen As DateTimePicker
    Friend WithEvents lblFecAgendar As Label
    Friend WithEvents cmbMinutosAgen As ComboBox
    Friend WithEvents lblHorAgendar As Label
    Friend WithEvents cmbHoraAgen As ComboBox
    Friend WithEvents btnLiberar As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbTipoBase As ComboBox
End Class
