<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLiberaTerminados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLiberaTerminados))
        Me.TbCCuerpo = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkBloqueado = New System.Windows.Forms.CheckBox()
        Me.chkSinObservaciones = New System.Windows.Forms.CheckBox()
        Me.chkSinIntentos = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbAgentes_1 = New System.Windows.Forms.ComboBox()
        Me.BtnLiberar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnOtrosFiltros = New System.Windows.Forms.Button()
        Me.lblInteresa = New System.Windows.Forms.Label()
        Me.cmbInteresa = New System.Windows.Forms.ComboBox()
        Me.lblCargaBase = New System.Windows.Forms.Label()
        Me.cmbCargaBase = New System.Windows.Forms.ComboBox()
        Me.chkFiltroFechaGeneral = New System.Windows.Forms.CheckBox()
        Me.grxFechaGeneral = New System.Windows.Forms.GroupBox()
        Me.dtpHastaGeneral = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpDesdeGeneral = New System.Windows.Forms.DateTimePicker()
        Me.ChkIntentos = New System.Windows.Forms.CheckBox()
        Me.gbxIntentos = New System.Windows.Forms.GroupBox()
        Me.nudIntentos = New System.Windows.Forms.NumericUpDown()
        Me.CmbSimbolo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnRefrescar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbTipoBase = New System.Windows.Forms.ComboBox()
        Me.CmbConecta = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblTotalLiberar = New System.Windows.Forms.Label()
        Me.ChkSelecTodo = New System.Windows.Forms.CheckBox()
        Me.DGVLiberaTerminados = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BtnActualizaLog = New System.Windows.Forms.Button()
        Me.dgLogLiberacion = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.DtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.chkBloqueado_1 = New System.Windows.Forms.CheckBox()
        Me.chkSinObservaciones_1 = New System.Windows.Forms.CheckBox()
        Me.chkSinIntentos_1 = New System.Windows.Forms.CheckBox()
        Me.btnActualizarDetalle = New System.Windows.Forms.Button()
        Me.chkFiltroFecha = New System.Windows.Forms.CheckBox()
        Me.grxFecha = New System.Windows.Forms.GroupBox()
        Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.lblTitHasta = New System.Windows.Forms.Label()
        Me.lbTitDesde = New System.Windows.Forms.Label()
        Me.dtpFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lblTitAgente = New System.Windows.Forms.Label()
        Me.cmbAgentes = New System.Windows.Forms.ComboBox()
        Me.btnLiberarDetalle = New System.Windows.Forms.Button()
        Me.lblTotalLiberarDetalle = New System.Windows.Forms.Label()
        Me.lblTitLiberar = New System.Windows.Forms.Label()
        Me.dgLiberarDetalle = New System.Windows.Forms.DataGridView()
        Me.LblCampana = New System.Windows.Forms.Label()
        Me.lblAgrupaciones = New System.Windows.Forms.Label()
        Me.TbCCuerpo.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grxFechaGeneral.SuspendLayout()
        Me.gbxIntentos.SuspendLayout()
        CType(Me.nudIntentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVLiberaTerminados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgLogLiberacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.grxFecha.SuspendLayout()
        CType(Me.dgLiberarDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TbCCuerpo
        '
        Me.TbCCuerpo.Controls.Add(Me.TabPage1)
        Me.TbCCuerpo.Controls.Add(Me.TabPage2)
        Me.TbCCuerpo.Controls.Add(Me.TabPage3)
        Me.TbCCuerpo.Location = New System.Drawing.Point(12, 31)
        Me.TbCCuerpo.Name = "TbCCuerpo"
        Me.TbCCuerpo.SelectedIndex = 0
        Me.TbCCuerpo.Size = New System.Drawing.Size(1128, 570)
        Me.TbCCuerpo.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.LblTotalLiberar)
        Me.TabPage1.Controls.Add(Me.ChkSelecTodo)
        Me.TabPage1.Controls.Add(Me.DGVLiberaTerminados)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.ForeColor = System.Drawing.Color.Black
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1120, 544)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registros Terminados"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkBloqueado)
        Me.GroupBox2.Controls.Add(Me.chkSinObservaciones)
        Me.GroupBox2.Controls.Add(Me.chkSinIntentos)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cmbAgentes_1)
        Me.GroupBox2.Controls.Add(Me.BtnLiberar)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(801, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(313, 124)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtros"
        '
        'chkBloqueado
        '
        Me.chkBloqueado.AutoSize = True
        Me.chkBloqueado.Location = New System.Drawing.Point(9, 95)
        Me.chkBloqueado.Name = "chkBloqueado"
        Me.chkBloqueado.Size = New System.Drawing.Size(86, 17)
        Me.chkBloqueado.TabIndex = 13
        Me.chkBloqueado.Text = "Bloqueado"
        Me.chkBloqueado.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkBloqueado.UseVisualStyleBackColor = True
        Me.chkBloqueado.Visible = False
        '
        'chkSinObservaciones
        '
        Me.chkSinObservaciones.AutoSize = True
        Me.chkSinObservaciones.Location = New System.Drawing.Point(143, 72)
        Me.chkSinObservaciones.Name = "chkSinObservaciones"
        Me.chkSinObservaciones.Size = New System.Drawing.Size(132, 17)
        Me.chkSinObservaciones.TabIndex = 12
        Me.chkSinObservaciones.Text = "Sin Observaciones"
        Me.chkSinObservaciones.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkSinObservaciones.UseVisualStyleBackColor = True
        '
        'chkSinIntentos
        '
        Me.chkSinIntentos.AutoSize = True
        Me.chkSinIntentos.Location = New System.Drawing.Point(9, 72)
        Me.chkSinIntentos.Name = "chkSinIntentos"
        Me.chkSinIntentos.Size = New System.Drawing.Size(94, 17)
        Me.chkSinIntentos.TabIndex = 11
        Me.chkSinIntentos.Text = "Sin Intentos"
        Me.chkSinIntentos.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkSinIntentos.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Agente"
        '
        'cmbAgentes_1
        '
        Me.cmbAgentes_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAgentes_1.FormattingEnabled = True
        Me.cmbAgentes_1.Location = New System.Drawing.Point(6, 32)
        Me.cmbAgentes_1.Name = "cmbAgentes_1"
        Me.cmbAgentes_1.Size = New System.Drawing.Size(189, 21)
        Me.cmbAgentes_1.TabIndex = 9
        '
        'BtnLiberar
        '
        Me.BtnLiberar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLiberar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnLiberar.Image = CType(resources.GetObject("BtnLiberar.Image"), System.Drawing.Image)
        Me.BtnLiberar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnLiberar.Location = New System.Drawing.Point(226, 19)
        Me.BtnLiberar.Name = "BtnLiberar"
        Me.BtnLiberar.Size = New System.Drawing.Size(64, 47)
        Me.BtnLiberar.TabIndex = 4
        Me.BtnLiberar.Text = "Reciclar"
        Me.BtnLiberar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnLiberar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnOtrosFiltros)
        Me.GroupBox1.Controls.Add(Me.lblInteresa)
        Me.GroupBox1.Controls.Add(Me.cmbInteresa)
        Me.GroupBox1.Controls.Add(Me.lblCargaBase)
        Me.GroupBox1.Controls.Add(Me.cmbCargaBase)
        Me.GroupBox1.Controls.Add(Me.chkFiltroFechaGeneral)
        Me.GroupBox1.Controls.Add(Me.grxFechaGeneral)
        Me.GroupBox1.Controls.Add(Me.ChkIntentos)
        Me.GroupBox1.Controls.Add(Me.gbxIntentos)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.BtnRefrescar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbTipoBase)
        Me.GroupBox1.Controls.Add(Me.CmbConecta)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(783, 124)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'btnOtrosFiltros
        '
        Me.btnOtrosFiltros.Location = New System.Drawing.Point(583, 75)
        Me.btnOtrosFiltros.Name = "btnOtrosFiltros"
        Me.btnOtrosFiltros.Size = New System.Drawing.Size(99, 41)
        Me.btnOtrosFiltros.TabIndex = 202
        Me.btnOtrosFiltros.Text = "Otros Filtros"
        Me.btnOtrosFiltros.UseVisualStyleBackColor = True
        Me.btnOtrosFiltros.Visible = False
        '
        'lblInteresa
        '
        Me.lblInteresa.AutoSize = True
        Me.lblInteresa.ForeColor = System.Drawing.Color.Black
        Me.lblInteresa.Location = New System.Drawing.Point(580, 16)
        Me.lblInteresa.Name = "lblInteresa"
        Me.lblInteresa.Size = New System.Drawing.Size(53, 13)
        Me.lblInteresa.TabIndex = 201
        Me.lblInteresa.Text = "Interesa"
        Me.lblInteresa.Visible = False
        '
        'cmbInteresa
        '
        Me.cmbInteresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInteresa.FormattingEnabled = True
        Me.cmbInteresa.Location = New System.Drawing.Point(583, 32)
        Me.cmbInteresa.Name = "cmbInteresa"
        Me.cmbInteresa.Size = New System.Drawing.Size(189, 21)
        Me.cmbInteresa.TabIndex = 200
        Me.cmbInteresa.Visible = False
        '
        'lblCargaBase
        '
        Me.lblCargaBase.AutoSize = True
        Me.lblCargaBase.ForeColor = System.Drawing.Color.Black
        Me.lblCargaBase.Location = New System.Drawing.Point(387, 16)
        Me.lblCargaBase.Name = "lblCargaBase"
        Me.lblCargaBase.Size = New System.Drawing.Size(90, 13)
        Me.lblCargaBase.TabIndex = 199
        Me.lblCargaBase.Text = "Carga de Base"
        '
        'cmbCargaBase
        '
        Me.cmbCargaBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCargaBase.FormattingEnabled = True
        Me.cmbCargaBase.Location = New System.Drawing.Point(390, 32)
        Me.cmbCargaBase.Name = "cmbCargaBase"
        Me.cmbCargaBase.Size = New System.Drawing.Size(189, 21)
        Me.cmbCargaBase.TabIndex = 198
        '
        'chkFiltroFechaGeneral
        '
        Me.chkFiltroFechaGeneral.AutoSize = True
        Me.chkFiltroFechaGeneral.Location = New System.Drawing.Point(180, 59)
        Me.chkFiltroFechaGeneral.Name = "chkFiltroFechaGeneral"
        Me.chkFiltroFechaGeneral.Size = New System.Drawing.Size(93, 17)
        Me.chkFiltroFechaGeneral.TabIndex = 197
        Me.chkFiltroFechaGeneral.Text = "Filtro Fecha"
        Me.chkFiltroFechaGeneral.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkFiltroFechaGeneral.UseVisualStyleBackColor = True
        '
        'grxFechaGeneral
        '
        Me.grxFechaGeneral.Controls.Add(Me.dtpHastaGeneral)
        Me.grxFechaGeneral.Controls.Add(Me.Label7)
        Me.grxFechaGeneral.Controls.Add(Me.Label8)
        Me.grxFechaGeneral.Controls.Add(Me.dtpDesdeGeneral)
        Me.grxFechaGeneral.Enabled = False
        Me.grxFechaGeneral.Location = New System.Drawing.Point(180, 75)
        Me.grxFechaGeneral.Name = "grxFechaGeneral"
        Me.grxFechaGeneral.Size = New System.Drawing.Size(298, 41)
        Me.grxFechaGeneral.TabIndex = 196
        Me.grxFechaGeneral.TabStop = False
        Me.grxFechaGeneral.Text = "Fecha"
        '
        'dtpHastaGeneral
        '
        Me.dtpHastaGeneral.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHastaGeneral.Location = New System.Drawing.Point(194, 10)
        Me.dtpHastaGeneral.Name = "dtpHastaGeneral"
        Me.dtpHastaGeneral.Size = New System.Drawing.Size(92, 20)
        Me.dtpHastaGeneral.TabIndex = 286
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(150, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 285
        Me.Label7.Text = "Hasta:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(8, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 283
        Me.Label8.Text = "Desde:"
        '
        'dtpDesdeGeneral
        '
        Me.dtpDesdeGeneral.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesdeGeneral.Location = New System.Drawing.Point(52, 12)
        Me.dtpDesdeGeneral.Name = "dtpDesdeGeneral"
        Me.dtpDesdeGeneral.Size = New System.Drawing.Size(92, 20)
        Me.dtpDesdeGeneral.TabIndex = 282
        '
        'ChkIntentos
        '
        Me.ChkIntentos.AutoSize = True
        Me.ChkIntentos.Location = New System.Drawing.Point(6, 59)
        Me.ChkIntentos.Name = "ChkIntentos"
        Me.ChkIntentos.Size = New System.Drawing.Size(104, 17)
        Me.ChkIntentos.TabIndex = 8
        Me.ChkIntentos.Text = "Filtro Intentos"
        Me.ChkIntentos.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ChkIntentos.UseVisualStyleBackColor = True
        '
        'gbxIntentos
        '
        Me.gbxIntentos.Controls.Add(Me.nudIntentos)
        Me.gbxIntentos.Controls.Add(Me.CmbSimbolo)
        Me.gbxIntentos.Enabled = False
        Me.gbxIntentos.Location = New System.Drawing.Point(6, 72)
        Me.gbxIntentos.Name = "gbxIntentos"
        Me.gbxIntentos.Size = New System.Drawing.Size(168, 40)
        Me.gbxIntentos.TabIndex = 7
        Me.gbxIntentos.TabStop = False
        Me.gbxIntentos.Text = "Intentos"
        '
        'nudIntentos
        '
        Me.nudIntentos.Location = New System.Drawing.Point(111, 15)
        Me.nudIntentos.Maximum = New Decimal(New Integer() {101, 0, 0, 0})
        Me.nudIntentos.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudIntentos.Name = "nudIntentos"
        Me.nudIntentos.Size = New System.Drawing.Size(51, 20)
        Me.nudIntentos.TabIndex = 6
        Me.nudIntentos.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'CmbSimbolo
        '
        Me.CmbSimbolo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSimbolo.FormattingEnabled = True
        Me.CmbSimbolo.Items.AddRange(New Object() {"Igual a", "Mayor a", "Menor a", "Distinto a"})
        Me.CmbSimbolo.Location = New System.Drawing.Point(8, 14)
        Me.CmbSimbolo.Name = "CmbSimbolo"
        Me.CmbSimbolo.Size = New System.Drawing.Size(83, 21)
        Me.CmbSimbolo.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(196, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Tipo Base"
        '
        'BtnRefrescar
        '
        Me.BtnRefrescar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefrescar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnRefrescar.Image = CType(resources.GetObject("BtnRefrescar.Image"), System.Drawing.Image)
        Me.BtnRefrescar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnRefrescar.Location = New System.Drawing.Point(484, 72)
        Me.BtnRefrescar.Name = "BtnRefrescar"
        Me.BtnRefrescar.Size = New System.Drawing.Size(59, 43)
        Me.BtnRefrescar.TabIndex = 5
        Me.BtnRefrescar.Text = "Actualiza"
        Me.BtnRefrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnRefrescar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Conecta"
        '
        'cmbTipoBase
        '
        Me.cmbTipoBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoBase.FormattingEnabled = True
        Me.cmbTipoBase.Location = New System.Drawing.Point(199, 32)
        Me.cmbTipoBase.Name = "cmbTipoBase"
        Me.cmbTipoBase.Size = New System.Drawing.Size(189, 21)
        Me.cmbTipoBase.TabIndex = 0
        '
        'CmbConecta
        '
        Me.CmbConecta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbConecta.FormattingEnabled = True
        Me.CmbConecta.Location = New System.Drawing.Point(6, 32)
        Me.CmbConecta.Name = "CmbConecta"
        Me.CmbConecta.Size = New System.Drawing.Size(189, 21)
        Me.CmbConecta.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Total Liberar:"
        '
        'LblTotalLiberar
        '
        Me.LblTotalLiberar.AutoSize = True
        Me.LblTotalLiberar.ForeColor = System.Drawing.Color.Blue
        Me.LblTotalLiberar.Location = New System.Drawing.Point(98, 141)
        Me.LblTotalLiberar.Name = "LblTotalLiberar"
        Me.LblTotalLiberar.Size = New System.Drawing.Size(14, 13)
        Me.LblTotalLiberar.TabIndex = 2
        Me.LblTotalLiberar.Text = "0"
        '
        'ChkSelecTodo
        '
        Me.ChkSelecTodo.AutoSize = True
        Me.ChkSelecTodo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkSelecTodo.Location = New System.Drawing.Point(1016, 137)
        Me.ChkSelecTodo.Name = "ChkSelecTodo"
        Me.ChkSelecTodo.Size = New System.Drawing.Size(98, 17)
        Me.ChkSelecTodo.TabIndex = 1
        Me.ChkSelecTodo.Text = "Liberar Todo"
        Me.ChkSelecTodo.UseVisualStyleBackColor = True
        '
        'DGVLiberaTerminados
        '
        Me.DGVLiberaTerminados.AllowUserToAddRows = False
        Me.DGVLiberaTerminados.AllowUserToDeleteRows = False
        Me.DGVLiberaTerminados.AllowUserToOrderColumns = True
        Me.DGVLiberaTerminados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVLiberaTerminados.Location = New System.Drawing.Point(12, 161)
        Me.DGVLiberaTerminados.Name = "DGVLiberaTerminados"
        Me.DGVLiberaTerminados.ReadOnly = True
        Me.DGVLiberaTerminados.Size = New System.Drawing.Size(1102, 377)
        Me.DGVLiberaTerminados.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.BtnActualizaLog)
        Me.TabPage2.Controls.Add(Me.dgLogLiberacion)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.DtpHasta)
        Me.TabPage2.Controls.Add(Me.DtpDesde)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1120, 544)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Log Liberacion"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BtnActualizaLog
        '
        Me.BtnActualizaLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizaLog.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnActualizaLog.Image = CType(resources.GetObject("BtnActualizaLog.Image"), System.Drawing.Image)
        Me.BtnActualizaLog.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnActualizaLog.Location = New System.Drawing.Point(850, 0)
        Me.BtnActualizaLog.Name = "BtnActualizaLog"
        Me.BtnActualizaLog.Size = New System.Drawing.Size(59, 43)
        Me.BtnActualizaLog.TabIndex = 6
        Me.BtnActualizaLog.Text = "Actualiza"
        Me.BtnActualizaLog.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnActualizaLog.UseVisualStyleBackColor = True
        '
        'dgLogLiberacion
        '
        Me.dgLogLiberacion.AllowUserToAddRows = False
        Me.dgLogLiberacion.AllowUserToDeleteRows = False
        Me.dgLogLiberacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLogLiberacion.Location = New System.Drawing.Point(9, 49)
        Me.dgLogLiberacion.Name = "dgLogLiberacion"
        Me.dgLogLiberacion.ReadOnly = True
        Me.dgLogLiberacion.Size = New System.Drawing.Size(906, 425)
        Me.dgLogLiberacion.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(119, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Hasta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Desde"
        '
        'DtpHasta
        '
        Me.DtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpHasta.Location = New System.Drawing.Point(122, 16)
        Me.DtpHasta.Name = "DtpHasta"
        Me.DtpHasta.Size = New System.Drawing.Size(95, 20)
        Me.DtpHasta.TabIndex = 0
        Me.DtpHasta.Value = New Date(2012, 9, 13, 0, 0, 0, 0)
        '
        'DtpDesde
        '
        Me.DtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDesde.Location = New System.Drawing.Point(9, 16)
        Me.DtpDesde.Name = "DtpDesde"
        Me.DtpDesde.Size = New System.Drawing.Size(95, 20)
        Me.DtpDesde.TabIndex = 0
        Me.DtpDesde.Value = New Date(2012, 9, 13, 0, 0, 0, 0)
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.chkBloqueado_1)
        Me.TabPage3.Controls.Add(Me.chkSinObservaciones_1)
        Me.TabPage3.Controls.Add(Me.chkSinIntentos_1)
        Me.TabPage3.Controls.Add(Me.btnActualizarDetalle)
        Me.TabPage3.Controls.Add(Me.chkFiltroFecha)
        Me.TabPage3.Controls.Add(Me.grxFecha)
        Me.TabPage3.Controls.Add(Me.btnVolver)
        Me.TabPage3.Controls.Add(Me.lblTitAgente)
        Me.TabPage3.Controls.Add(Me.cmbAgentes)
        Me.TabPage3.Controls.Add(Me.btnLiberarDetalle)
        Me.TabPage3.Controls.Add(Me.lblTotalLiberarDetalle)
        Me.TabPage3.Controls.Add(Me.lblTitLiberar)
        Me.TabPage3.Controls.Add(Me.dgLiberarDetalle)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1120, 544)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Detalle"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'chkBloqueado_1
        '
        Me.chkBloqueado_1.AutoSize = True
        Me.chkBloqueado_1.Location = New System.Drawing.Point(11, 78)
        Me.chkBloqueado_1.Name = "chkBloqueado_1"
        Me.chkBloqueado_1.Size = New System.Drawing.Size(77, 17)
        Me.chkBloqueado_1.TabIndex = 289
        Me.chkBloqueado_1.Text = "Bloqueado"
        Me.chkBloqueado_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkBloqueado_1.UseVisualStyleBackColor = True
        Me.chkBloqueado_1.Visible = False
        '
        'chkSinObservaciones_1
        '
        Me.chkSinObservaciones_1.AutoSize = True
        Me.chkSinObservaciones_1.Location = New System.Drawing.Point(99, 55)
        Me.chkSinObservaciones_1.Name = "chkSinObservaciones_1"
        Me.chkSinObservaciones_1.Size = New System.Drawing.Size(115, 17)
        Me.chkSinObservaciones_1.TabIndex = 288
        Me.chkSinObservaciones_1.Text = "Sin Observaciones"
        Me.chkSinObservaciones_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkSinObservaciones_1.UseVisualStyleBackColor = True
        '
        'chkSinIntentos_1
        '
        Me.chkSinIntentos_1.AutoSize = True
        Me.chkSinIntentos_1.Location = New System.Drawing.Point(11, 55)
        Me.chkSinIntentos_1.Name = "chkSinIntentos_1"
        Me.chkSinIntentos_1.Size = New System.Drawing.Size(82, 17)
        Me.chkSinIntentos_1.TabIndex = 287
        Me.chkSinIntentos_1.Text = "Sin Intentos"
        Me.chkSinIntentos_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkSinIntentos_1.UseVisualStyleBackColor = True
        '
        'btnActualizarDetalle
        '
        Me.btnActualizarDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarDetalle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnActualizarDetalle.Image = CType(resources.GetObject("btnActualizarDetalle.Image"), System.Drawing.Image)
        Me.btnActualizarDetalle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnActualizarDetalle.Location = New System.Drawing.Point(735, 25)
        Me.btnActualizarDetalle.Name = "btnActualizarDetalle"
        Me.btnActualizarDetalle.Size = New System.Drawing.Size(59, 43)
        Me.btnActualizarDetalle.TabIndex = 286
        Me.btnActualizarDetalle.Text = "Actualiza"
        Me.btnActualizarDetalle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnActualizarDetalle.UseVisualStyleBackColor = True
        '
        'chkFiltroFecha
        '
        Me.chkFiltroFecha.AutoSize = True
        Me.chkFiltroFecha.Location = New System.Drawing.Point(431, 11)
        Me.chkFiltroFecha.Name = "chkFiltroFecha"
        Me.chkFiltroFecha.Size = New System.Drawing.Size(81, 17)
        Me.chkFiltroFecha.TabIndex = 195
        Me.chkFiltroFecha.Text = "Filtro Fecha"
        Me.chkFiltroFecha.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkFiltroFecha.UseVisualStyleBackColor = True
        '
        'grxFecha
        '
        Me.grxFecha.Controls.Add(Me.dtpFechaHasta)
        Me.grxFecha.Controls.Add(Me.lblTitHasta)
        Me.grxFecha.Controls.Add(Me.lbTitDesde)
        Me.grxFecha.Controls.Add(Me.dtpFechaDesde)
        Me.grxFecha.Enabled = False
        Me.grxFecha.Location = New System.Drawing.Point(431, 27)
        Me.grxFecha.Name = "grxFecha"
        Me.grxFecha.Size = New System.Drawing.Size(298, 41)
        Me.grxFecha.TabIndex = 194
        Me.grxFecha.TabStop = False
        Me.grxFecha.Text = "Fecha"
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaHasta.Location = New System.Drawing.Point(194, 10)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(92, 20)
        Me.dtpFechaHasta.TabIndex = 286
        '
        'lblTitHasta
        '
        Me.lblTitHasta.AutoSize = True
        Me.lblTitHasta.ForeColor = System.Drawing.Color.Black
        Me.lblTitHasta.Location = New System.Drawing.Point(150, 16)
        Me.lblTitHasta.Name = "lblTitHasta"
        Me.lblTitHasta.Size = New System.Drawing.Size(38, 13)
        Me.lblTitHasta.TabIndex = 285
        Me.lblTitHasta.Text = "Hasta:"
        '
        'lbTitDesde
        '
        Me.lbTitDesde.AutoSize = True
        Me.lbTitDesde.ForeColor = System.Drawing.Color.Black
        Me.lbTitDesde.Location = New System.Drawing.Point(8, 16)
        Me.lbTitDesde.Name = "lbTitDesde"
        Me.lbTitDesde.Size = New System.Drawing.Size(41, 13)
        Me.lbTitDesde.TabIndex = 283
        Me.lbTitDesde.Text = "Desde:"
        '
        'dtpFechaDesde
        '
        Me.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDesde.Location = New System.Drawing.Point(49, 11)
        Me.dtpFechaDesde.Name = "dtpFechaDesde"
        Me.dtpFechaDesde.Size = New System.Drawing.Size(92, 20)
        Me.dtpFechaDesde.TabIndex = 282
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.SystemColors.Control
        Me.btnVolver.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnVolver.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnVolver.Image = CType(resources.GetObject("btnVolver.Image"), System.Drawing.Image)
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnVolver.Location = New System.Drawing.Point(344, 12)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnVolver.Size = New System.Drawing.Size(70, 45)
        Me.btnVolver.TabIndex = 193
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'lblTitAgente
        '
        Me.lblTitAgente.AutoSize = True
        Me.lblTitAgente.ForeColor = System.Drawing.Color.Black
        Me.lblTitAgente.Location = New System.Drawing.Point(11, 12)
        Me.lblTitAgente.Name = "lblTitAgente"
        Me.lblTitAgente.Size = New System.Drawing.Size(41, 13)
        Me.lblTitAgente.TabIndex = 8
        Me.lblTitAgente.Text = "Agente"
        '
        'cmbAgentes
        '
        Me.cmbAgentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAgentes.FormattingEnabled = True
        Me.cmbAgentes.Location = New System.Drawing.Point(11, 28)
        Me.cmbAgentes.Name = "cmbAgentes"
        Me.cmbAgentes.Size = New System.Drawing.Size(236, 21)
        Me.cmbAgentes.TabIndex = 7
        '
        'btnLiberarDetalle
        '
        Me.btnLiberarDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLiberarDetalle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLiberarDetalle.Image = CType(resources.GetObject("btnLiberarDetalle.Image"), System.Drawing.Image)
        Me.btnLiberarDetalle.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLiberarDetalle.Location = New System.Drawing.Point(268, 12)
        Me.btnLiberarDetalle.Name = "btnLiberarDetalle"
        Me.btnLiberarDetalle.Size = New System.Drawing.Size(70, 46)
        Me.btnLiberarDetalle.TabIndex = 6
        Me.btnLiberarDetalle.Text = "Reciclar"
        Me.btnLiberarDetalle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLiberarDetalle.UseVisualStyleBackColor = True
        '
        'lblTotalLiberarDetalle
        '
        Me.lblTotalLiberarDetalle.AutoSize = True
        Me.lblTotalLiberarDetalle.ForeColor = System.Drawing.Color.Blue
        Me.lblTotalLiberarDetalle.Location = New System.Drawing.Point(86, 108)
        Me.lblTotalLiberarDetalle.Name = "lblTotalLiberarDetalle"
        Me.lblTotalLiberarDetalle.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalLiberarDetalle.TabIndex = 5
        Me.lblTotalLiberarDetalle.Text = "0"
        '
        'lblTitLiberar
        '
        Me.lblTitLiberar.AutoSize = True
        Me.lblTitLiberar.Location = New System.Drawing.Point(11, 108)
        Me.lblTitLiberar.Name = "lblTitLiberar"
        Me.lblTitLiberar.Size = New System.Drawing.Size(69, 13)
        Me.lblTitLiberar.TabIndex = 4
        Me.lblTitLiberar.Text = "Total Liberar:"
        '
        'dgLiberarDetalle
        '
        Me.dgLiberarDetalle.AllowUserToAddRows = False
        Me.dgLiberarDetalle.AllowUserToDeleteRows = False
        Me.dgLiberarDetalle.AllowUserToOrderColumns = True
        Me.dgLiberarDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLiberarDetalle.Location = New System.Drawing.Point(11, 134)
        Me.dgLiberarDetalle.Name = "dgLiberarDetalle"
        Me.dgLiberarDetalle.ReadOnly = True
        Me.dgLiberarDetalle.Size = New System.Drawing.Size(1103, 354)
        Me.dgLiberarDetalle.TabIndex = 3
        '
        'LblCampana
        '
        Me.LblCampana.AutoSize = True
        Me.LblCampana.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCampana.ForeColor = System.Drawing.Color.Black
        Me.LblCampana.Location = New System.Drawing.Point(8, 9)
        Me.LblCampana.Name = "LblCampana"
        Me.LblCampana.Size = New System.Drawing.Size(85, 19)
        Me.LblCampana.TabIndex = 1
        Me.LblCampana.Text = "Campaña"
        '
        'lblAgrupaciones
        '
        Me.lblAgrupaciones.AutoSize = True
        Me.lblAgrupaciones.Location = New System.Drawing.Point(389, 13)
        Me.lblAgrupaciones.Name = "lblAgrupaciones"
        Me.lblAgrupaciones.Size = New System.Drawing.Size(82, 13)
        Me.lblAgrupaciones.TabIndex = 2
        Me.lblAgrupaciones.Text = "lblAgrupaciones"
        Me.lblAgrupaciones.Visible = False
        '
        'FrmLiberaTerminados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1152, 607)
        Me.Controls.Add(Me.lblAgrupaciones)
        Me.Controls.Add(Me.LblCampana)
        Me.Controls.Add(Me.TbCCuerpo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLiberaTerminados"
        Me.Text = "Libera Registros Terminados"
        Me.TbCCuerpo.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grxFechaGeneral.ResumeLayout(False)
        Me.grxFechaGeneral.PerformLayout()
        Me.gbxIntentos.ResumeLayout(False)
        CType(Me.nudIntentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVLiberaTerminados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgLogLiberacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.grxFecha.ResumeLayout(False)
        Me.grxFecha.PerformLayout()
        CType(Me.dgLiberarDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TbCCuerpo As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents LblCampana As System.Windows.Forms.Label
    Friend WithEvents DGVLiberaTerminados As System.Windows.Forms.DataGridView
    Friend WithEvents ChkSelecTodo As System.Windows.Forms.CheckBox
    Friend WithEvents LblTotalLiberar As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnLiberar As System.Windows.Forms.Button
    Friend WithEvents BtnRefrescar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoBase As System.Windows.Forms.ComboBox
    Friend WithEvents CmbConecta As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DtpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnActualizaLog As System.Windows.Forms.Button
    Friend WithEvents dgLogLiberacion As System.Windows.Forms.DataGridView
    Friend WithEvents CmbSimbolo As System.Windows.Forms.ComboBox
    Friend WithEvents gbxIntentos As System.Windows.Forms.GroupBox
    Friend WithEvents nudIntentos As System.Windows.Forms.NumericUpDown
    Friend WithEvents ChkIntentos As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgLiberarDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents lblTitLiberar As System.Windows.Forms.Label
    Friend WithEvents lblTotalLiberarDetalle As System.Windows.Forms.Label
    Friend WithEvents btnLiberarDetalle As System.Windows.Forms.Button
    Friend WithEvents lblAgrupaciones As System.Windows.Forms.Label
    Friend WithEvents lblTitAgente As System.Windows.Forms.Label
    Friend WithEvents cmbAgentes As System.Windows.Forms.ComboBox
    Public WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents chkFiltroFecha As System.Windows.Forms.CheckBox
    Friend WithEvents grxFecha As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbTitDesde As System.Windows.Forms.Label
    Friend WithEvents lblTitHasta As System.Windows.Forms.Label
    Friend WithEvents btnActualizarDetalle As System.Windows.Forms.Button
    Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkFiltroFechaGeneral As System.Windows.Forms.CheckBox
    Friend WithEvents grxFechaGeneral As System.Windows.Forms.GroupBox
    Friend WithEvents dtpHastaGeneral As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpDesdeGeneral As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCargaBase As System.Windows.Forms.Label
    Friend WithEvents cmbCargaBase As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbAgentes_1 As System.Windows.Forms.ComboBox
    Friend WithEvents chkSinObservaciones As System.Windows.Forms.CheckBox
    Friend WithEvents chkSinIntentos As System.Windows.Forms.CheckBox
    Friend WithEvents chkSinObservaciones_1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkSinIntentos_1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkBloqueado As System.Windows.Forms.CheckBox
    Friend WithEvents chkBloqueado_1 As System.Windows.Forms.CheckBox
    Friend WithEvents lblInteresa As System.Windows.Forms.Label
    Friend WithEvents cmbInteresa As System.Windows.Forms.ComboBox
    Friend WithEvents btnOtrosFiltros As Button
End Class
