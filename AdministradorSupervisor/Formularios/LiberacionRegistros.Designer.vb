<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LiberacionRegistros
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LiberacionRegistros))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.dtgRegistros = New System.Windows.Forms.DataGridView()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblFecAgendar = New System.Windows.Forms.Label()
        Me.lblHorAgendar = New System.Windows.Forms.Label()
        Me.cmbHora = New System.Windows.Forms.ComboBox()
        Me.cmbMinutos = New System.Windows.Forms.ComboBox()
        Me.btnLiberar = New System.Windows.Forms.Button()
        Me.btnBuscarID = New System.Windows.Forms.Button()
        Me.chkObs = New System.Windows.Forms.CheckBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.lblObs = New System.Windows.Forms.Label()
        Me.chkFono = New System.Windows.Forms.CheckBox()
        Me.lblFono = New System.Windows.Forms.Label()
        Me.txtFono = New System.Windows.Forms.TextBox()
        Me.gpbObservacion = New System.Windows.Forms.GroupBox()
        Me.gpbFonoAlternativo = New System.Windows.Forms.GroupBox()
        Me.gpbEjecutivo = New System.Windows.Forms.GroupBox()
        Me.cmbEjecutivo = New System.Windows.Forms.ComboBox()
        Me.lblEjecutivo = New System.Windows.Forms.Label()
        Me.chkOtroEjecutivo = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbpLiberacionPorId = New System.Windows.Forms.TabPage()
        Me.tbpLiberacionPorEjecutivo = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbFlujoContacto = New System.Windows.Forms.ComboBox()
        Me.lblTotalRegistros = New System.Windows.Forms.Label()
        Me.gpbSeleccion = New System.Windows.Forms.GroupBox()
        Me.rdbBloquearCarterizar = New System.Windows.Forms.RadioButton()
        Me.rdbLiberarOtroEjecutivo = New System.Windows.Forms.RadioButton()
        Me.rdbMismoEjecutivo = New System.Windows.Forms.RadioButton()
        Me.cmbOtroEjecutivo = New System.Windows.Forms.ComboBox()
        Me.gbpOtrasOpciones = New System.Windows.Forms.GroupBox()
        Me.chkObservaciones = New System.Windows.Forms.CheckBox()
        Me.chkSinIntentos = New System.Windows.Forms.CheckBox()
        Me.dtgAgendados = New System.Windows.Forms.DataGridView()
        Me.chkSeleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.idAgenda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreAgenda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaGestionAgenda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAgenda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraAgenda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlujoAgenda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observacionesAgenda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbEjecutivoAgenda = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLiberarAgendados = New System.Windows.Forms.Button()
        Me.chkSeleccionarTodos = New System.Windows.Forms.CheckBox()
        Me.btnMostrarAgendados = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.rdbPorID = New System.Windows.Forms.RadioButton()
        Me.rdbPorEjecutivo = New System.Windows.Forms.RadioButton()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEjecutivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idRut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bloqueado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marcaBloqueo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.flujo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idFechaAgenda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdHoraAgenda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtgRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbObservacion.SuspendLayout()
        Me.gpbFonoAlternativo.SuspendLayout()
        Me.gpbEjecutivo.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tbpLiberacionPorId.SuspendLayout()
        Me.tbpLiberacionPorEjecutivo.SuspendLayout()
        Me.gpbSeleccion.SuspendLayout()
        Me.gbpOtrasOpciones.SuspendLayout()
        CType(Me.dtgAgendados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id :"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(41, 13)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(93, 20)
        Me.txtId.TabIndex = 1
        '
        'dtgRegistros
        '
        Me.dtgRegistros.AllowUserToAddRows = False
        Me.dtgRegistros.AllowUserToDeleteRows = False
        Me.dtgRegistros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgRegistros.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgRegistros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.IdEjecutivo, Me.idRut, Me.idNombre, Me.idEstado, Me.bloqueado, Me.marcaBloqueo, Me.flujo, Me.idFechaAgenda, Me.IdHoraAgenda})
        Me.dtgRegistros.Location = New System.Drawing.Point(6, 45)
        Me.dtgRegistros.Name = "dtgRegistros"
        Me.dtgRegistros.ReadOnly = True
        Me.dtgRegistros.RowHeadersVisible = False
        Me.dtgRegistros.Size = New System.Drawing.Size(1077, 148)
        Me.dtgRegistros.TabIndex = 3
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(120, 226)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(131, 20)
        Me.dtpFecha.TabIndex = 4
        '
        'lblFecAgendar
        '
        Me.lblFecAgendar.AutoSize = True
        Me.lblFecAgendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecAgendar.Location = New System.Drawing.Point(3, 232)
        Me.lblFecAgendar.Name = "lblFecAgendar"
        Me.lblFecAgendar.Size = New System.Drawing.Size(93, 13)
        Me.lblFecAgendar.TabIndex = 5
        Me.lblFecAgendar.Text = "Fecha Agendar"
        '
        'lblHorAgendar
        '
        Me.lblHorAgendar.AutoSize = True
        Me.lblHorAgendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorAgendar.Location = New System.Drawing.Point(3, 262)
        Me.lblHorAgendar.Name = "lblHorAgendar"
        Me.lblHorAgendar.Size = New System.Drawing.Size(85, 13)
        Me.lblHorAgendar.TabIndex = 6
        Me.lblHorAgendar.Text = "Hora Agendar"
        '
        'cmbHora
        '
        Me.cmbHora.FormattingEnabled = True
        Me.cmbHora.Items.AddRange(New Object() {"09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cmbHora.Location = New System.Drawing.Point(120, 259)
        Me.cmbHora.Name = "cmbHora"
        Me.cmbHora.Size = New System.Drawing.Size(55, 21)
        Me.cmbHora.TabIndex = 7
        '
        'cmbMinutos
        '
        Me.cmbMinutos.FormattingEnabled = True
        Me.cmbMinutos.Items.AddRange(New Object() {"00", "05", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55"})
        Me.cmbMinutos.Location = New System.Drawing.Point(188, 259)
        Me.cmbMinutos.Name = "cmbMinutos"
        Me.cmbMinutos.Size = New System.Drawing.Size(63, 21)
        Me.cmbMinutos.TabIndex = 8
        '
        'btnLiberar
        '
        Me.btnLiberar.Location = New System.Drawing.Point(137, 303)
        Me.btnLiberar.Name = "btnLiberar"
        Me.btnLiberar.Size = New System.Drawing.Size(114, 48)
        Me.btnLiberar.TabIndex = 9
        Me.btnLiberar.Text = "Liberar"
        Me.btnLiberar.UseVisualStyleBackColor = True
        '
        'btnBuscarID
        '
        Me.btnBuscarID.Image = CType(resources.GetObject("btnBuscarID.Image"), System.Drawing.Image)
        Me.btnBuscarID.Location = New System.Drawing.Point(156, 6)
        Me.btnBuscarID.Name = "btnBuscarID"
        Me.btnBuscarID.Size = New System.Drawing.Size(44, 33)
        Me.btnBuscarID.TabIndex = 2
        Me.btnBuscarID.UseVisualStyleBackColor = True
        '
        'chkObs
        '
        Me.chkObs.AutoSize = True
        Me.chkObs.Location = New System.Drawing.Point(299, 215)
        Me.chkObs.Name = "chkObs"
        Me.chkObs.Size = New System.Drawing.Size(86, 30)
        Me.chkObs.TabIndex = 12
        Me.chkObs.Text = "Liberar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Observación"
        Me.chkObs.UseVisualStyleBackColor = True
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(6, 34)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(179, 93)
        Me.txtObs.TabIndex = 13
        '
        'lblObs
        '
        Me.lblObs.AutoSize = True
        Me.lblObs.Location = New System.Drawing.Point(3, 17)
        Me.lblObs.Name = "lblObs"
        Me.lblObs.Size = New System.Drawing.Size(102, 13)
        Me.lblObs.TabIndex = 14
        Me.lblObs.Text = "Nueva Observación"
        '
        'chkFono
        '
        Me.chkFono.AutoSize = True
        Me.chkFono.Location = New System.Drawing.Point(517, 222)
        Me.chkFono.Name = "chkFono"
        Me.chkFono.Size = New System.Drawing.Size(142, 17)
        Me.chkFono.TabIndex = 15
        Me.chkFono.Text = "Agregar Fono alternativo"
        Me.chkFono.UseVisualStyleBackColor = True
        '
        'lblFono
        '
        Me.lblFono.AutoSize = True
        Me.lblFono.Location = New System.Drawing.Point(6, 17)
        Me.lblFono.Name = "lblFono"
        Me.lblFono.Size = New System.Drawing.Size(37, 13)
        Me.lblFono.TabIndex = 17
        Me.lblFono.Text = "Fono :"
        '
        'txtFono
        '
        Me.txtFono.Location = New System.Drawing.Point(9, 34)
        Me.txtFono.MaxLength = 9
        Me.txtFono.Name = "txtFono"
        Me.txtFono.Size = New System.Drawing.Size(87, 20)
        Me.txtFono.TabIndex = 18
        '
        'gpbObservacion
        '
        Me.gpbObservacion.Controls.Add(Me.txtObs)
        Me.gpbObservacion.Controls.Add(Me.lblObs)
        Me.gpbObservacion.Location = New System.Drawing.Point(299, 252)
        Me.gpbObservacion.Name = "gpbObservacion"
        Me.gpbObservacion.Size = New System.Drawing.Size(197, 149)
        Me.gpbObservacion.TabIndex = 19
        Me.gpbObservacion.TabStop = False
        '
        'gpbFonoAlternativo
        '
        Me.gpbFonoAlternativo.Controls.Add(Me.lblFono)
        Me.gpbFonoAlternativo.Controls.Add(Me.txtFono)
        Me.gpbFonoAlternativo.Location = New System.Drawing.Point(517, 252)
        Me.gpbFonoAlternativo.Name = "gpbFonoAlternativo"
        Me.gpbFonoAlternativo.Size = New System.Drawing.Size(197, 149)
        Me.gpbFonoAlternativo.TabIndex = 20
        Me.gpbFonoAlternativo.TabStop = False
        '
        'gpbEjecutivo
        '
        Me.gpbEjecutivo.Controls.Add(Me.cmbEjecutivo)
        Me.gpbEjecutivo.Controls.Add(Me.lblEjecutivo)
        Me.gpbEjecutivo.Location = New System.Drawing.Point(734, 252)
        Me.gpbEjecutivo.Name = "gpbEjecutivo"
        Me.gpbEjecutivo.Size = New System.Drawing.Size(197, 149)
        Me.gpbEjecutivo.TabIndex = 22
        Me.gpbEjecutivo.TabStop = False
        Me.gpbEjecutivo.Visible = False
        '
        'cmbEjecutivo
        '
        Me.cmbEjecutivo.FormattingEnabled = True
        Me.cmbEjecutivo.Location = New System.Drawing.Point(9, 34)
        Me.cmbEjecutivo.Name = "cmbEjecutivo"
        Me.cmbEjecutivo.Size = New System.Drawing.Size(182, 21)
        Me.cmbEjecutivo.TabIndex = 18
        '
        'lblEjecutivo
        '
        Me.lblEjecutivo.AutoSize = True
        Me.lblEjecutivo.Location = New System.Drawing.Point(6, 17)
        Me.lblEjecutivo.Name = "lblEjecutivo"
        Me.lblEjecutivo.Size = New System.Drawing.Size(57, 13)
        Me.lblEjecutivo.TabIndex = 17
        Me.lblEjecutivo.Text = "Ejecutivo :"
        Me.lblEjecutivo.Visible = False
        '
        'chkOtroEjecutivo
        '
        Me.chkOtroEjecutivo.AutoSize = True
        Me.chkOtroEjecutivo.Location = New System.Drawing.Point(734, 222)
        Me.chkOtroEjecutivo.Name = "chkOtroEjecutivo"
        Me.chkOtroEjecutivo.Size = New System.Drawing.Size(128, 17)
        Me.chkOtroEjecutivo.TabIndex = 21
        Me.chkOtroEjecutivo.Text = "Liberar Otro Ejecutivo"
        Me.chkOtroEjecutivo.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbpLiberacionPorId)
        Me.TabControl1.Controls.Add(Me.tbpLiberacionPorEjecutivo)
        Me.TabControl1.Location = New System.Drawing.Point(18, 81)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1111, 546)
        Me.TabControl1.TabIndex = 23
        '
        'tbpLiberacionPorId
        '
        Me.tbpLiberacionPorId.Controls.Add(Me.btnBuscarID)
        Me.tbpLiberacionPorId.Controls.Add(Me.gpbEjecutivo)
        Me.tbpLiberacionPorId.Controls.Add(Me.Label1)
        Me.tbpLiberacionPorId.Controls.Add(Me.chkOtroEjecutivo)
        Me.tbpLiberacionPorId.Controls.Add(Me.txtId)
        Me.tbpLiberacionPorId.Controls.Add(Me.gpbFonoAlternativo)
        Me.tbpLiberacionPorId.Controls.Add(Me.dtgRegistros)
        Me.tbpLiberacionPorId.Controls.Add(Me.gpbObservacion)
        Me.tbpLiberacionPorId.Controls.Add(Me.dtpFecha)
        Me.tbpLiberacionPorId.Controls.Add(Me.chkFono)
        Me.tbpLiberacionPorId.Controls.Add(Me.lblFecAgendar)
        Me.tbpLiberacionPorId.Controls.Add(Me.chkObs)
        Me.tbpLiberacionPorId.Controls.Add(Me.lblHorAgendar)
        Me.tbpLiberacionPorId.Controls.Add(Me.cmbHora)
        Me.tbpLiberacionPorId.Controls.Add(Me.btnLiberar)
        Me.tbpLiberacionPorId.Controls.Add(Me.cmbMinutos)
        Me.tbpLiberacionPorId.Location = New System.Drawing.Point(4, 22)
        Me.tbpLiberacionPorId.Name = "tbpLiberacionPorId"
        Me.tbpLiberacionPorId.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpLiberacionPorId.Size = New System.Drawing.Size(1103, 520)
        Me.tbpLiberacionPorId.TabIndex = 0
        Me.tbpLiberacionPorId.Text = "Por ID"
        Me.tbpLiberacionPorId.UseVisualStyleBackColor = True
        '
        'tbpLiberacionPorEjecutivo
        '
        Me.tbpLiberacionPorEjecutivo.Controls.Add(Me.Label3)
        Me.tbpLiberacionPorEjecutivo.Controls.Add(Me.cmbFlujoContacto)
        Me.tbpLiberacionPorEjecutivo.Controls.Add(Me.lblTotalRegistros)
        Me.tbpLiberacionPorEjecutivo.Controls.Add(Me.gpbSeleccion)
        Me.tbpLiberacionPorEjecutivo.Controls.Add(Me.dtgAgendados)
        Me.tbpLiberacionPorEjecutivo.Controls.Add(Me.cmbEjecutivoAgenda)
        Me.tbpLiberacionPorEjecutivo.Controls.Add(Me.Label2)
        Me.tbpLiberacionPorEjecutivo.Controls.Add(Me.btnLiberarAgendados)
        Me.tbpLiberacionPorEjecutivo.Controls.Add(Me.chkSeleccionarTodos)
        Me.tbpLiberacionPorEjecutivo.Controls.Add(Me.btnMostrarAgendados)
        Me.tbpLiberacionPorEjecutivo.Location = New System.Drawing.Point(4, 22)
        Me.tbpLiberacionPorEjecutivo.Name = "tbpLiberacionPorEjecutivo"
        Me.tbpLiberacionPorEjecutivo.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpLiberacionPorEjecutivo.Size = New System.Drawing.Size(1103, 520)
        Me.tbpLiberacionPorEjecutivo.TabIndex = 1
        Me.tbpLiberacionPorEjecutivo.Text = "Por Ejecutivo"
        Me.tbpLiberacionPorEjecutivo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(347, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Flujos"
        '
        'cmbFlujoContacto
        '
        Me.cmbFlujoContacto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFlujoContacto.FormattingEnabled = True
        Me.cmbFlujoContacto.Items.AddRange(New Object() {"TODOS", "CONECTA", "NO CONECTA"})
        Me.cmbFlujoContacto.Location = New System.Drawing.Point(397, 17)
        Me.cmbFlujoContacto.Name = "cmbFlujoContacto"
        Me.cmbFlujoContacto.Size = New System.Drawing.Size(200, 21)
        Me.cmbFlujoContacto.TabIndex = 22
        '
        'lblTotalRegistros
        '
        Me.lblTotalRegistros.AutoSize = True
        Me.lblTotalRegistros.Location = New System.Drawing.Point(649, 73)
        Me.lblTotalRegistros.Name = "lblTotalRegistros"
        Me.lblTotalRegistros.Size = New System.Drawing.Size(81, 13)
        Me.lblTotalRegistros.TabIndex = 21
        Me.lblTotalRegistros.Text = "Total Registros:"
        '
        'gpbSeleccion
        '
        Me.gpbSeleccion.Controls.Add(Me.rdbBloquearCarterizar)
        Me.gpbSeleccion.Controls.Add(Me.rdbLiberarOtroEjecutivo)
        Me.gpbSeleccion.Controls.Add(Me.rdbMismoEjecutivo)
        Me.gpbSeleccion.Controls.Add(Me.cmbOtroEjecutivo)
        Me.gpbSeleccion.Controls.Add(Me.gbpOtrasOpciones)
        Me.gpbSeleccion.Location = New System.Drawing.Point(840, 96)
        Me.gpbSeleccion.Name = "gpbSeleccion"
        Me.gpbSeleccion.Size = New System.Drawing.Size(243, 362)
        Me.gpbSeleccion.TabIndex = 20
        Me.gpbSeleccion.TabStop = False
        Me.gpbSeleccion.Text = "Seleccion de Liberacion"
        '
        'rdbBloquearCarterizar
        '
        Me.rdbBloquearCarterizar.AutoSize = True
        Me.rdbBloquearCarterizar.Location = New System.Drawing.Point(19, 94)
        Me.rdbBloquearCarterizar.Name = "rdbBloquearCarterizar"
        Me.rdbBloquearCarterizar.Size = New System.Drawing.Size(123, 17)
        Me.rdbBloquearCarterizar.TabIndex = 7
        Me.rdbBloquearCarterizar.TabStop = True
        Me.rdbBloquearCarterizar.Text = "Bloquear a Carterizar"
        Me.rdbBloquearCarterizar.UseVisualStyleBackColor = True
        '
        'rdbLiberarOtroEjecutivo
        '
        Me.rdbLiberarOtroEjecutivo.AutoSize = True
        Me.rdbLiberarOtroEjecutivo.Location = New System.Drawing.Point(19, 62)
        Me.rdbLiberarOtroEjecutivo.Name = "rdbLiberarOtroEjecutivo"
        Me.rdbLiberarOtroEjecutivo.Size = New System.Drawing.Size(136, 17)
        Me.rdbLiberarOtroEjecutivo.TabIndex = 6
        Me.rdbLiberarOtroEjecutivo.TabStop = True
        Me.rdbLiberarOtroEjecutivo.Text = "Liberar a Otro Ejecutivo"
        Me.rdbLiberarOtroEjecutivo.UseVisualStyleBackColor = True
        '
        'rdbMismoEjecutivo
        '
        Me.rdbMismoEjecutivo.AutoSize = True
        Me.rdbMismoEjecutivo.Location = New System.Drawing.Point(19, 30)
        Me.rdbMismoEjecutivo.Name = "rdbMismoEjecutivo"
        Me.rdbMismoEjecutivo.Size = New System.Drawing.Size(148, 17)
        Me.rdbMismoEjecutivo.TabIndex = 5
        Me.rdbMismoEjecutivo.TabStop = True
        Me.rdbMismoEjecutivo.Text = "Liberar al Mismo Ejecutivo"
        Me.rdbMismoEjecutivo.UseVisualStyleBackColor = True
        '
        'cmbOtroEjecutivo
        '
        Me.cmbOtroEjecutivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOtroEjecutivo.FormattingEnabled = True
        Me.cmbOtroEjecutivo.Location = New System.Drawing.Point(19, 133)
        Me.cmbOtroEjecutivo.Name = "cmbOtroEjecutivo"
        Me.cmbOtroEjecutivo.Size = New System.Drawing.Size(200, 21)
        Me.cmbOtroEjecutivo.TabIndex = 4
        '
        'gbpOtrasOpciones
        '
        Me.gbpOtrasOpciones.Controls.Add(Me.chkObservaciones)
        Me.gbpOtrasOpciones.Controls.Add(Me.chkSinIntentos)
        Me.gbpOtrasOpciones.Location = New System.Drawing.Point(19, 203)
        Me.gbpOtrasOpciones.Name = "gbpOtrasOpciones"
        Me.gbpOtrasOpciones.Size = New System.Drawing.Size(214, 138)
        Me.gbpOtrasOpciones.TabIndex = 3
        Me.gbpOtrasOpciones.TabStop = False
        Me.gbpOtrasOpciones.Text = "Otras Opciones Adicionales"
        '
        'chkObservaciones
        '
        Me.chkObservaciones.AutoSize = True
        Me.chkObservaciones.Location = New System.Drawing.Point(18, 62)
        Me.chkObservaciones.Name = "chkObservaciones"
        Me.chkObservaciones.Size = New System.Drawing.Size(115, 17)
        Me.chkObservaciones.TabIndex = 4
        Me.chkObservaciones.Text = "Sin Observaciones"
        Me.chkObservaciones.UseVisualStyleBackColor = True
        '
        'chkSinIntentos
        '
        Me.chkSinIntentos.AutoSize = True
        Me.chkSinIntentos.Location = New System.Drawing.Point(18, 29)
        Me.chkSinIntentos.Name = "chkSinIntentos"
        Me.chkSinIntentos.Size = New System.Drawing.Size(68, 17)
        Me.chkSinIntentos.TabIndex = 3
        Me.chkSinIntentos.Text = "Intento 0"
        Me.chkSinIntentos.UseVisualStyleBackColor = True
        '
        'dtgAgendados
        '
        Me.dtgAgendados.AllowUserToAddRows = False
        Me.dtgAgendados.AllowUserToDeleteRows = False
        Me.dtgAgendados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtgAgendados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgAgendados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chkSeleccionar, Me.idAgenda, Me.nombreAgenda, Me.FechaGestionAgenda, Me.FechaAgenda, Me.HoraAgenda, Me.FlujoAgenda, Me.observacionesAgenda, Me.DataGridViewTextBoxColumn7})
        Me.dtgAgendados.Location = New System.Drawing.Point(19, 96)
        Me.dtgAgendados.Name = "dtgAgendados"
        Me.dtgAgendados.RowHeadersVisible = False
        Me.dtgAgendados.Size = New System.Drawing.Size(815, 362)
        Me.dtgAgendados.TabIndex = 2
        '
        'chkSeleccionar
        '
        Me.chkSeleccionar.HeaderText = "Seleccionar"
        Me.chkSeleccionar.Name = "chkSeleccionar"
        Me.chkSeleccionar.Width = 69
        '
        'idAgenda
        '
        Me.idAgenda.DataPropertyName = "ID"
        Me.idAgenda.HeaderText = "Id"
        Me.idAgenda.Name = "idAgenda"
        Me.idAgenda.ReadOnly = True
        Me.idAgenda.Width = 41
        '
        'nombreAgenda
        '
        Me.nombreAgenda.DataPropertyName = "NOMBRE_CLIENTE"
        Me.nombreAgenda.HeaderText = "Nombre"
        Me.nombreAgenda.Name = "nombreAgenda"
        Me.nombreAgenda.ReadOnly = True
        Me.nombreAgenda.Width = 69
        '
        'FechaGestionAgenda
        '
        Me.FechaGestionAgenda.DataPropertyName = "FECHA_GESTION"
        Me.FechaGestionAgenda.HeaderText = "Fecha Gestion"
        Me.FechaGestionAgenda.Name = "FechaGestionAgenda"
        Me.FechaGestionAgenda.ReadOnly = True
        Me.FechaGestionAgenda.Width = 93
        '
        'FechaAgenda
        '
        Me.FechaAgenda.DataPropertyName = "FECHA_AGENDAMIENTO"
        Me.FechaAgenda.HeaderText = "Fecha Agendamiento"
        Me.FechaAgenda.Name = "FechaAgenda"
        Me.FechaAgenda.Width = 122
        '
        'HoraAgenda
        '
        Me.HoraAgenda.DataPropertyName = "HORA_AGENDAMIENTO"
        Me.HoraAgenda.HeaderText = "Hora Agendamiento"
        Me.HoraAgenda.Name = "HoraAgenda"
        Me.HoraAgenda.ReadOnly = True
        Me.HoraAgenda.Width = 115
        '
        'FlujoAgenda
        '
        Me.FlujoAgenda.DataPropertyName = "FLUJO"
        Me.FlujoAgenda.HeaderText = "Flujo"
        Me.FlujoAgenda.Name = "FlujoAgenda"
        Me.FlujoAgenda.ReadOnly = True
        Me.FlujoAgenda.Width = 54
        '
        'observacionesAgenda
        '
        Me.observacionesAgenda.DataPropertyName = "OBSERVACIONES"
        Me.observacionesAgenda.HeaderText = "Observaciones"
        Me.observacionesAgenda.Name = "observacionesAgenda"
        Me.observacionesAgenda.Width = 103
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Periodo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Periodo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 68
        '
        'cmbEjecutivoAgenda
        '
        Me.cmbEjecutivoAgenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEjecutivoAgenda.FormattingEnabled = True
        Me.cmbEjecutivoAgenda.Location = New System.Drawing.Point(85, 17)
        Me.cmbEjecutivoAgenda.Name = "cmbEjecutivoAgenda"
        Me.cmbEjecutivoAgenda.Size = New System.Drawing.Size(237, 21)
        Me.cmbEjecutivoAgenda.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ejecutivo"
        '
        'btnLiberarAgendados
        '
        Me.btnLiberarAgendados.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLiberarAgendados.Location = New System.Drawing.Point(505, 464)
        Me.btnLiberarAgendados.Name = "btnLiberarAgendados"
        Me.btnLiberarAgendados.Size = New System.Drawing.Size(122, 46)
        Me.btnLiberarAgendados.TabIndex = 5
        Me.btnLiberarAgendados.Text = "Liberar Agendados"
        Me.btnLiberarAgendados.UseVisualStyleBackColor = True
        '
        'chkSeleccionarTodos
        '
        Me.chkSeleccionarTodos.AutoSize = True
        Me.chkSeleccionarTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSeleccionarTodos.Location = New System.Drawing.Point(19, 67)
        Me.chkSeleccionarTodos.Name = "chkSeleccionarTodos"
        Me.chkSeleccionarTodos.Size = New System.Drawing.Size(142, 20)
        Me.chkSeleccionarTodos.TabIndex = 8
        Me.chkSeleccionarTodos.Text = "Seleccionar Todos"
        Me.chkSeleccionarTodos.UseVisualStyleBackColor = True
        '
        'btnMostrarAgendados
        '
        Me.btnMostrarAgendados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrarAgendados.Location = New System.Drawing.Point(652, 14)
        Me.btnMostrarAgendados.Name = "btnMostrarAgendados"
        Me.btnMostrarAgendados.Size = New System.Drawing.Size(99, 32)
        Me.btnMostrarAgendados.TabIndex = 7
        Me.btnMostrarAgendados.Text = "Buscar"
        Me.btnMostrarAgendados.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(1019, 575)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(86, 33)
        Me.btnVolver.TabIndex = 14
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'rdbPorID
        '
        Me.rdbPorID.AutoSize = True
        Me.rdbPorID.Location = New System.Drawing.Point(22, 23)
        Me.rdbPorID.Name = "rdbPorID"
        Me.rdbPorID.Size = New System.Drawing.Size(89, 17)
        Me.rdbPorID.TabIndex = 24
        Me.rdbPorID.TabStop = True
        Me.rdbPorID.Text = "Liberar por ID"
        Me.rdbPorID.UseVisualStyleBackColor = True
        '
        'rdbPorEjecutivo
        '
        Me.rdbPorEjecutivo.AutoSize = True
        Me.rdbPorEjecutivo.Location = New System.Drawing.Point(155, 23)
        Me.rdbPorEjecutivo.Name = "rdbPorEjecutivo"
        Me.rdbPorEjecutivo.Size = New System.Drawing.Size(122, 17)
        Me.rdbPorEjecutivo.TabIndex = 25
        Me.rdbPorEjecutivo.TabStop = True
        Me.rdbPorEjecutivo.Text = "Liberar por Ejecutivo"
        Me.rdbPorEjecutivo.UseVisualStyleBackColor = True
        '
        'Id
        '
        Me.Id.DataPropertyName = "C_ID"
        Me.Id.HeaderText = "C_id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        '
        'IdEjecutivo
        '
        Me.IdEjecutivo.DataPropertyName = "Ejecutivo"
        Me.IdEjecutivo.HeaderText = "Ejecutivo"
        Me.IdEjecutivo.Name = "IdEjecutivo"
        Me.IdEjecutivo.ReadOnly = True
        '
        'idRut
        '
        Me.idRut.DataPropertyName = "C_RUT"
        Me.idRut.HeaderText = "Rut"
        Me.idRut.Name = "idRut"
        Me.idRut.ReadOnly = True
        '
        'idNombre
        '
        Me.idNombre.DataPropertyName = "C_NOMBRE"
        Me.idNombre.HeaderText = "Nombre"
        Me.idNombre.Name = "idNombre"
        Me.idNombre.ReadOnly = True
        '
        'idEstado
        '
        Me.idEstado.DataPropertyName = "G_ESTADO"
        Me.idEstado.HeaderText = "Estado"
        Me.idEstado.Name = "idEstado"
        Me.idEstado.ReadOnly = True
        '
        'bloqueado
        '
        Me.bloqueado.DataPropertyName = "Bloqueado"
        Me.bloqueado.HeaderText = "Bloqueado"
        Me.bloqueado.Name = "bloqueado"
        Me.bloqueado.ReadOnly = True
        '
        'marcaBloqueo
        '
        Me.marcaBloqueo.DataPropertyName = "MarcaBloqueo"
        Me.marcaBloqueo.HeaderText = "Marca Bloqueo"
        Me.marcaBloqueo.Name = "marcaBloqueo"
        Me.marcaBloqueo.ReadOnly = True
        '
        'flujo
        '
        Me.flujo.DataPropertyName = "FLUJO"
        Me.flujo.HeaderText = "Flujo"
        Me.flujo.Name = "flujo"
        Me.flujo.ReadOnly = True
        '
        'idFechaAgenda
        '
        Me.idFechaAgenda.DataPropertyName = "Fecha Agendar"
        Me.idFechaAgenda.HeaderText = "Fecha Agenda"
        Me.idFechaAgenda.Name = "idFechaAgenda"
        Me.idFechaAgenda.ReadOnly = True
        '
        'IdHoraAgenda
        '
        Me.IdHoraAgenda.DataPropertyName = "Hora Agendar"
        Me.IdHoraAgenda.HeaderText = "Hora Agenda"
        Me.IdHoraAgenda.Name = "IdHoraAgenda"
        Me.IdHoraAgenda.ReadOnly = True
        '
        'LiberacionRegistros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1141, 639)
        Me.Controls.Add(Me.rdbPorEjecutivo)
        Me.Controls.Add(Me.rdbPorID)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "LiberacionRegistros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LiberacionRegistros"
        CType(Me.dtgRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbObservacion.ResumeLayout(False)
        Me.gpbObservacion.PerformLayout()
        Me.gpbFonoAlternativo.ResumeLayout(False)
        Me.gpbFonoAlternativo.PerformLayout()
        Me.gpbEjecutivo.ResumeLayout(False)
        Me.gpbEjecutivo.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tbpLiberacionPorId.ResumeLayout(False)
        Me.tbpLiberacionPorId.PerformLayout()
        Me.tbpLiberacionPorEjecutivo.ResumeLayout(False)
        Me.tbpLiberacionPorEjecutivo.PerformLayout()
        Me.gpbSeleccion.ResumeLayout(False)
        Me.gpbSeleccion.PerformLayout()
        Me.gbpOtrasOpciones.ResumeLayout(False)
        Me.gbpOtrasOpciones.PerformLayout()
        CType(Me.dtgAgendados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents btnBuscarID As Button
    Friend WithEvents dtgRegistros As DataGridView
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents lblFecAgendar As Label
    Friend WithEvents lblHorAgendar As Label
    Friend WithEvents cmbHora As ComboBox
    Friend WithEvents cmbMinutos As ComboBox
    Friend WithEvents btnLiberar As Button
    Friend WithEvents chkObs As CheckBox
    Friend WithEvents txtObs As TextBox
    Friend WithEvents lblObs As Label
    Friend WithEvents chkFono As CheckBox
    Friend WithEvents lblFono As Label
    Friend WithEvents txtFono As TextBox
    Friend WithEvents gpbObservacion As GroupBox
    Friend WithEvents gpbFonoAlternativo As GroupBox
    Friend WithEvents gpbEjecutivo As GroupBox
    Friend WithEvents cmbEjecutivo As ComboBox
    Friend WithEvents lblEjecutivo As Label
    Friend WithEvents chkOtroEjecutivo As CheckBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbpLiberacionPorId As TabPage
    Friend WithEvents tbpLiberacionPorEjecutivo As TabPage
    Friend WithEvents dtgAgendados As DataGridView
    Friend WithEvents cmbEjecutivoAgenda As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLiberarAgendados As Button
    Friend WithEvents chkSeleccionarTodos As CheckBox
    Friend WithEvents btnMostrarAgendados As Button
    Friend WithEvents gpbSeleccion As GroupBox
    Friend WithEvents rdbBloquearCarterizar As RadioButton
    Friend WithEvents rdbLiberarOtroEjecutivo As RadioButton
    Friend WithEvents rdbMismoEjecutivo As RadioButton
    Friend WithEvents cmbOtroEjecutivo As ComboBox
    Friend WithEvents gbpOtrasOpciones As GroupBox
    Friend WithEvents chkObservaciones As CheckBox
    Friend WithEvents chkSinIntentos As CheckBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents rdbPorID As RadioButton
    Friend WithEvents rdbPorEjecutivo As RadioButton
    Friend WithEvents lblTotalRegistros As Label
    Friend WithEvents chkSeleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents idAgenda As DataGridViewTextBoxColumn
    Friend WithEvents nombreAgenda As DataGridViewTextBoxColumn
    Friend WithEvents FechaGestionAgenda As DataGridViewTextBoxColumn
    Friend WithEvents FechaAgenda As DataGridViewTextBoxColumn
    Friend WithEvents HoraAgenda As DataGridViewTextBoxColumn
    Friend WithEvents FlujoAgenda As DataGridViewTextBoxColumn
    Friend WithEvents observacionesAgenda As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbFlujoContacto As ComboBox
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents IdEjecutivo As DataGridViewTextBoxColumn
    Friend WithEvents idRut As DataGridViewTextBoxColumn
    Friend WithEvents idNombre As DataGridViewTextBoxColumn
    Friend WithEvents idEstado As DataGridViewTextBoxColumn
    Friend WithEvents bloqueado As DataGridViewTextBoxColumn
    Friend WithEvents marcaBloqueo As DataGridViewTextBoxColumn
    Friend WithEvents flujo As DataGridViewTextBoxColumn
    Friend WithEvents idFechaAgenda As DataGridViewTextBoxColumn
    Friend WithEvents IdHoraAgenda As DataGridViewTextBoxColumn
End Class
