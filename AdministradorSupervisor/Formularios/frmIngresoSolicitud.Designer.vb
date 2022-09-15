<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresoSolicitud
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
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.cmbInsumo = New System.Windows.Forms.ComboBox()
        Me.lblInsumo = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGestión = New System.Windows.Forms.Button()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.cmbSolicitante = New System.Windows.Forms.ComboBox()
        Me.cmbPlataforma = New System.Windows.Forms.ComboBox()
        Me.cmbTipoSolicitud = New System.Windows.Forms.ComboBox()
        Me.cmbPiso = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbNombreEjecutivo = New System.Windows.Forms.ComboBox()
        Me.dtgListaSolicitudes = New System.Windows.Forms.DataGridView()
        Me.IdAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Duracion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Url = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Evaluacion1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Evaluacion2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Evaluacion3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Evaluacion4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Evaluacion5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Evaluacion6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Evaluacion7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Evaluacion8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Evaluacion9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Evaluacion10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Evaluacion11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Evaluador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CRM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ejecutivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaEncuesta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotaFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaEvaluacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbListaEjecutivos = New System.Windows.Forms.ComboBox()
        CType(Me.dtgListaSolicitudes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblCantidad.Location = New System.Drawing.Point(493, 223)
        Me.lblCantidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(75, 20)
        Me.lblCantidad.TabIndex = 39
        Me.lblCantidad.Text = "Cantidad:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtCantidad.Location = New System.Drawing.Point(580, 218)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantidad.Multiline = True
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(75, 30)
        Me.txtCantidad.TabIndex = 38
        '
        'cmbInsumo
        '
        Me.cmbInsumo.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbInsumo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.cmbInsumo.FormattingEnabled = True
        Me.cmbInsumo.Location = New System.Drawing.Point(289, 221)
        Me.cmbInsumo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbInsumo.Name = "cmbInsumo"
        Me.cmbInsumo.Size = New System.Drawing.Size(192, 27)
        Me.cmbInsumo.TabIndex = 36
        '
        'lblInsumo
        '
        Me.lblInsumo.AutoSize = True
        Me.lblInsumo.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsumo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblInsumo.Location = New System.Drawing.Point(154, 223)
        Me.lblInsumo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInsumo.Name = "lblInsumo"
        Me.lblInsumo.Size = New System.Drawing.Size(63, 20)
        Me.lblInsumo.TabIndex = 37
        Me.lblInsumo.Text = "Insumo:"
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Crimson
        Me.btnSalir.Location = New System.Drawing.Point(321, 522)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(121, 44)
        Me.btnSalir.TabIndex = 35
        Me.btnSalir.Text = "Volver"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGestión
        '
        Me.btnGestión.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGestión.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnGestión.Location = New System.Drawing.Point(268, 464)
        Me.btnGestión.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGestión.Name = "btnGestión"
        Me.btnGestión.Size = New System.Drawing.Size(227, 50)
        Me.btnGestión.TabIndex = 34
        Me.btnGestión.Text = "Agregar Gestion"
        Me.btnGestión.UseVisualStyleBackColor = True
        '
        'txtObs
        '
        Me.txtObs.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObs.ForeColor = System.Drawing.SystemColors.Highlight
        Me.txtObs.Location = New System.Drawing.Point(289, 346)
        Me.txtObs.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(336, 79)
        Me.txtObs.TabIndex = 33
        '
        'dtFecha
        '
        Me.dtFecha.Location = New System.Drawing.Point(289, 257)
        Me.dtFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(265, 22)
        Me.dtFecha.TabIndex = 30
        Me.dtFecha.Visible = False
        '
        'cmbSolicitante
        '
        Me.cmbSolicitante.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSolicitante.ForeColor = System.Drawing.SystemColors.Highlight
        Me.cmbSolicitante.FormattingEnabled = True
        Me.cmbSolicitante.Location = New System.Drawing.Point(289, 184)
        Me.cmbSolicitante.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSolicitante.Name = "cmbSolicitante"
        Me.cmbSolicitante.Size = New System.Drawing.Size(192, 27)
        Me.cmbSolicitante.TabIndex = 28
        '
        'cmbPlataforma
        '
        Me.cmbPlataforma.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPlataforma.ForeColor = System.Drawing.SystemColors.Highlight
        Me.cmbPlataforma.FormattingEnabled = True
        Me.cmbPlataforma.Location = New System.Drawing.Point(289, 147)
        Me.cmbPlataforma.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbPlataforma.Name = "cmbPlataforma"
        Me.cmbPlataforma.Size = New System.Drawing.Size(192, 27)
        Me.cmbPlataforma.TabIndex = 27
        '
        'cmbTipoSolicitud
        '
        Me.cmbTipoSolicitud.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoSolicitud.ForeColor = System.Drawing.SystemColors.Highlight
        Me.cmbTipoSolicitud.FormattingEnabled = True
        Me.cmbTipoSolicitud.Location = New System.Drawing.Point(289, 111)
        Me.cmbTipoSolicitud.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTipoSolicitud.Name = "cmbTipoSolicitud"
        Me.cmbTipoSolicitud.Size = New System.Drawing.Size(192, 27)
        Me.cmbTipoSolicitud.TabIndex = 25
        '
        'cmbPiso
        '
        Me.cmbPiso.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPiso.ForeColor = System.Drawing.SystemColors.Highlight
        Me.cmbPiso.FormattingEnabled = True
        Me.cmbPiso.Items.AddRange(New Object() {"[Seleccione]", "PISO 1", "PISO 5"})
        Me.cmbPiso.Location = New System.Drawing.Point(289, 74)
        Me.cmbPiso.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbPiso.Name = "cmbPiso"
        Me.cmbPiso.Size = New System.Drawing.Size(192, 27)
        Me.cmbPiso.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Location = New System.Drawing.Point(154, 352)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 20)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Observaciones:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Location = New System.Drawing.Point(152, 260)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 20)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Fecha y Hora:"
        Me.Label6.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(152, 190)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 20)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Solicitante:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(152, 153)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 20)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Plataforma:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(152, 116)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Tipo Solicitud:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(152, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Piso:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label8.Location = New System.Drawing.Point(265, 20)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(222, 34)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Solicitud Insumos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(152, 297)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Ejecutivo:"
        '
        'cmbNombreEjecutivo
        '
        Me.cmbNombreEjecutivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbNombreEjecutivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbNombreEjecutivo.FormattingEnabled = True
        Me.cmbNombreEjecutivo.Location = New System.Drawing.Point(76, 504)
        Me.cmbNombreEjecutivo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbNombreEjecutivo.Name = "cmbNombreEjecutivo"
        Me.cmbNombreEjecutivo.Size = New System.Drawing.Size(28, 24)
        Me.cmbNombreEjecutivo.TabIndex = 41
        Me.cmbNombreEjecutivo.Visible = False
        '
        'dtgListaSolicitudes
        '
        Me.dtgListaSolicitudes.AllowUserToAddRows = False
        Me.dtgListaSolicitudes.AllowUserToDeleteRows = False
        Me.dtgListaSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgListaSolicitudes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdAsignacion, Me.Duracion, Me.Estado, Me.Subida, Me.Url, Me.Evaluacion1, Me.Evaluacion2, Me.Evaluacion3, Me.Evaluacion4, Me.Evaluacion5, Me.Evaluacion6, Me.Evaluacion7, Me.Evaluacion8, Me.Evaluacion9, Me.Evaluacion10, Me.Evaluacion11, Me.Evaluador, Me.CRM, Me.Ejecutivo, Me.fechaEncuesta, Me.telefono, Me.NotaFinal, Me.FechaEvaluacion, Me.Empresa, Me.Observaciones})
        Me.dtgListaSolicitudes.Location = New System.Drawing.Point(86, 536)
        Me.dtgListaSolicitudes.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgListaSolicitudes.Name = "dtgListaSolicitudes"
        Me.dtgListaSolicitudes.ReadOnly = True
        Me.dtgListaSolicitudes.RowHeadersWidth = 62
        Me.dtgListaSolicitudes.Size = New System.Drawing.Size(51, 30)
        Me.dtgListaSolicitudes.TabIndex = 42
        Me.dtgListaSolicitudes.Visible = False
        '
        'IdAsignacion
        '
        Me.IdAsignacion.DataPropertyName = "Id_Escucha"
        Me.IdAsignacion.HeaderText = "Id Asignacion"
        Me.IdAsignacion.MinimumWidth = 8
        Me.IdAsignacion.Name = "IdAsignacion"
        Me.IdAsignacion.ReadOnly = True
        Me.IdAsignacion.Width = 150
        '
        'Duracion
        '
        Me.Duracion.DataPropertyName = "Duracion"
        Me.Duracion.HeaderText = "Duracion"
        Me.Duracion.MinimumWidth = 8
        Me.Duracion.Name = "Duracion"
        Me.Duracion.ReadOnly = True
        Me.Duracion.Visible = False
        Me.Duracion.Width = 150
        '
        'Estado
        '
        Me.Estado.DataPropertyName = "Estado"
        Me.Estado.HeaderText = "Estado"
        Me.Estado.MinimumWidth = 8
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Visible = False
        Me.Estado.Width = 150
        '
        'Subida
        '
        Me.Subida.DataPropertyName = "Subida"
        Me.Subida.HeaderText = "Subida"
        Me.Subida.MinimumWidth = 8
        Me.Subida.Name = "Subida"
        Me.Subida.ReadOnly = True
        Me.Subida.Visible = False
        Me.Subida.Width = 150
        '
        'Url
        '
        Me.Url.DataPropertyName = "Url"
        Me.Url.HeaderText = "Url"
        Me.Url.MinimumWidth = 8
        Me.Url.Name = "Url"
        Me.Url.ReadOnly = True
        Me.Url.Visible = False
        Me.Url.Width = 150
        '
        'Evaluacion1
        '
        Me.Evaluacion1.DataPropertyName = "Evaluacion1"
        Me.Evaluacion1.HeaderText = "Evaluacion1"
        Me.Evaluacion1.MinimumWidth = 8
        Me.Evaluacion1.Name = "Evaluacion1"
        Me.Evaluacion1.ReadOnly = True
        Me.Evaluacion1.Visible = False
        Me.Evaluacion1.Width = 150
        '
        'Evaluacion2
        '
        Me.Evaluacion2.DataPropertyName = "Evaluacion2"
        Me.Evaluacion2.HeaderText = "Evaluacion2"
        Me.Evaluacion2.MinimumWidth = 8
        Me.Evaluacion2.Name = "Evaluacion2"
        Me.Evaluacion2.ReadOnly = True
        Me.Evaluacion2.Visible = False
        Me.Evaluacion2.Width = 150
        '
        'Evaluacion3
        '
        Me.Evaluacion3.DataPropertyName = "Evaluacion3"
        Me.Evaluacion3.HeaderText = "Evaluacion3"
        Me.Evaluacion3.MinimumWidth = 8
        Me.Evaluacion3.Name = "Evaluacion3"
        Me.Evaluacion3.ReadOnly = True
        Me.Evaluacion3.Visible = False
        Me.Evaluacion3.Width = 150
        '
        'Evaluacion4
        '
        Me.Evaluacion4.DataPropertyName = "Evaluacion4"
        Me.Evaluacion4.HeaderText = "Evaluacion4"
        Me.Evaluacion4.MinimumWidth = 8
        Me.Evaluacion4.Name = "Evaluacion4"
        Me.Evaluacion4.ReadOnly = True
        Me.Evaluacion4.Visible = False
        Me.Evaluacion4.Width = 150
        '
        'Evaluacion5
        '
        Me.Evaluacion5.DataPropertyName = "Evaluacion5"
        Me.Evaluacion5.HeaderText = "Evaluacion5"
        Me.Evaluacion5.MinimumWidth = 8
        Me.Evaluacion5.Name = "Evaluacion5"
        Me.Evaluacion5.ReadOnly = True
        Me.Evaluacion5.Visible = False
        Me.Evaluacion5.Width = 150
        '
        'Evaluacion6
        '
        Me.Evaluacion6.DataPropertyName = "Evaluacion6"
        Me.Evaluacion6.HeaderText = "Evaluacion6"
        Me.Evaluacion6.MinimumWidth = 8
        Me.Evaluacion6.Name = "Evaluacion6"
        Me.Evaluacion6.ReadOnly = True
        Me.Evaluacion6.Visible = False
        Me.Evaluacion6.Width = 150
        '
        'Evaluacion7
        '
        Me.Evaluacion7.DataPropertyName = "Evaluacion7"
        Me.Evaluacion7.HeaderText = "Evaluacion7"
        Me.Evaluacion7.MinimumWidth = 8
        Me.Evaluacion7.Name = "Evaluacion7"
        Me.Evaluacion7.ReadOnly = True
        Me.Evaluacion7.Visible = False
        Me.Evaluacion7.Width = 150
        '
        'Evaluacion8
        '
        Me.Evaluacion8.DataPropertyName = "Evaluacion8"
        Me.Evaluacion8.HeaderText = "Evaluacion8"
        Me.Evaluacion8.MinimumWidth = 8
        Me.Evaluacion8.Name = "Evaluacion8"
        Me.Evaluacion8.ReadOnly = True
        Me.Evaluacion8.Visible = False
        Me.Evaluacion8.Width = 150
        '
        'Evaluacion9
        '
        Me.Evaluacion9.DataPropertyName = "Evaluacion9"
        Me.Evaluacion9.HeaderText = "Evaluacion9"
        Me.Evaluacion9.MinimumWidth = 8
        Me.Evaluacion9.Name = "Evaluacion9"
        Me.Evaluacion9.ReadOnly = True
        Me.Evaluacion9.Visible = False
        Me.Evaluacion9.Width = 150
        '
        'Evaluacion10
        '
        Me.Evaluacion10.DataPropertyName = "Evaluacion10"
        Me.Evaluacion10.HeaderText = "Evaluacion10"
        Me.Evaluacion10.MinimumWidth = 8
        Me.Evaluacion10.Name = "Evaluacion10"
        Me.Evaluacion10.ReadOnly = True
        Me.Evaluacion10.Visible = False
        Me.Evaluacion10.Width = 150
        '
        'Evaluacion11
        '
        Me.Evaluacion11.DataPropertyName = "Evaluacion11"
        Me.Evaluacion11.HeaderText = "Evaluacion11"
        Me.Evaluacion11.MinimumWidth = 8
        Me.Evaluacion11.Name = "Evaluacion11"
        Me.Evaluacion11.ReadOnly = True
        Me.Evaluacion11.Visible = False
        Me.Evaluacion11.Width = 150
        '
        'Evaluador
        '
        Me.Evaluador.DataPropertyName = "Evaluador"
        Me.Evaluador.HeaderText = "Evaluador"
        Me.Evaluador.MinimumWidth = 8
        Me.Evaluador.Name = "Evaluador"
        Me.Evaluador.ReadOnly = True
        Me.Evaluador.Width = 150
        '
        'CRM
        '
        Me.CRM.DataPropertyName = "idCRM"
        Me.CRM.HeaderText = "CRM"
        Me.CRM.MinimumWidth = 8
        Me.CRM.Name = "CRM"
        Me.CRM.ReadOnly = True
        Me.CRM.Width = 150
        '
        'Ejecutivo
        '
        Me.Ejecutivo.DataPropertyName = "Ejecutivo"
        Me.Ejecutivo.HeaderText = "Ejecutivo"
        Me.Ejecutivo.MinimumWidth = 8
        Me.Ejecutivo.Name = "Ejecutivo"
        Me.Ejecutivo.ReadOnly = True
        Me.Ejecutivo.Width = 150
        '
        'fechaEncuesta
        '
        Me.fechaEncuesta.DataPropertyName = "Fecha"
        Me.fechaEncuesta.HeaderText = "Fecha"
        Me.fechaEncuesta.MinimumWidth = 8
        Me.fechaEncuesta.Name = "fechaEncuesta"
        Me.fechaEncuesta.ReadOnly = True
        Me.fechaEncuesta.Width = 150
        '
        'telefono
        '
        Me.telefono.DataPropertyName = "Telefono"
        Me.telefono.HeaderText = "Telefono"
        Me.telefono.MinimumWidth = 8
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        Me.telefono.Visible = False
        Me.telefono.Width = 150
        '
        'NotaFinal
        '
        Me.NotaFinal.DataPropertyName = "Total_Nota"
        Me.NotaFinal.HeaderText = "Nota Final"
        Me.NotaFinal.MinimumWidth = 8
        Me.NotaFinal.Name = "NotaFinal"
        Me.NotaFinal.ReadOnly = True
        Me.NotaFinal.Width = 150
        '
        'FechaEvaluacion
        '
        Me.FechaEvaluacion.DataPropertyName = "FechaEvaluacion"
        Me.FechaEvaluacion.HeaderText = "Fecha Evaluacion"
        Me.FechaEvaluacion.MinimumWidth = 8
        Me.FechaEvaluacion.Name = "FechaEvaluacion"
        Me.FechaEvaluacion.ReadOnly = True
        Me.FechaEvaluacion.Width = 150
        '
        'Empresa
        '
        Me.Empresa.DataPropertyName = "Empresa"
        Me.Empresa.HeaderText = "Empresa"
        Me.Empresa.MinimumWidth = 8
        Me.Empresa.Name = "Empresa"
        Me.Empresa.ReadOnly = True
        Me.Empresa.Width = 150
        '
        'Observaciones
        '
        Me.Observaciones.DataPropertyName = "Observaciones"
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.MinimumWidth = 8
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.ReadOnly = True
        Me.Observaciones.Width = 150
        '
        'cmbListaEjecutivos
        '
        Me.cmbListaEjecutivos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbListaEjecutivos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbListaEjecutivos.FormattingEnabled = True
        Me.cmbListaEjecutivos.Location = New System.Drawing.Point(289, 297)
        Me.cmbListaEjecutivos.Name = "cmbListaEjecutivos"
        Me.cmbListaEjecutivos.Size = New System.Drawing.Size(366, 24)
        Me.cmbListaEjecutivos.TabIndex = 43
        '
        'frmIngresoSolicitud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 604)
        Me.Controls.Add(Me.cmbListaEjecutivos)
        Me.Controls.Add(Me.dtgListaSolicitudes)
        Me.Controls.Add(Me.cmbNombreEjecutivo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.cmbInsumo)
        Me.Controls.Add(Me.lblInsumo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGestión)
        Me.Controls.Add(Me.txtObs)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.cmbSolicitante)
        Me.Controls.Add(Me.cmbPlataforma)
        Me.Controls.Add(Me.cmbTipoSolicitud)
        Me.Controls.Add(Me.cmbPiso)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Name = "frmIngresoSolicitud"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmIngresoSolicitud"
        CType(Me.dtgListaSolicitudes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCantidad As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents cmbInsumo As ComboBox
    Friend WithEvents lblInsumo As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnGestión As Button
    Friend WithEvents txtObs As TextBox
    Friend WithEvents dtFecha As DateTimePicker
    Friend WithEvents cmbSolicitante As ComboBox
    Friend WithEvents cmbPlataforma As ComboBox
    Friend WithEvents cmbTipoSolicitud As ComboBox
    Friend WithEvents cmbPiso As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbNombreEjecutivo As ComboBox
    Friend WithEvents dtgListaSolicitudes As DataGridView
    Friend WithEvents IdAsignacion As DataGridViewTextBoxColumn
    Friend WithEvents Duracion As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents Subida As DataGridViewTextBoxColumn
    Friend WithEvents Url As DataGridViewTextBoxColumn
    Friend WithEvents Evaluacion1 As DataGridViewTextBoxColumn
    Friend WithEvents Evaluacion2 As DataGridViewTextBoxColumn
    Friend WithEvents Evaluacion3 As DataGridViewTextBoxColumn
    Friend WithEvents Evaluacion4 As DataGridViewTextBoxColumn
    Friend WithEvents Evaluacion5 As DataGridViewTextBoxColumn
    Friend WithEvents Evaluacion6 As DataGridViewTextBoxColumn
    Friend WithEvents Evaluacion7 As DataGridViewTextBoxColumn
    Friend WithEvents Evaluacion8 As DataGridViewTextBoxColumn
    Friend WithEvents Evaluacion9 As DataGridViewTextBoxColumn
    Friend WithEvents Evaluacion10 As DataGridViewTextBoxColumn
    Friend WithEvents Evaluacion11 As DataGridViewTextBoxColumn
    Friend WithEvents Evaluador As DataGridViewTextBoxColumn
    Friend WithEvents CRM As DataGridViewTextBoxColumn
    Friend WithEvents Ejecutivo As DataGridViewTextBoxColumn
    Friend WithEvents fechaEncuesta As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents NotaFinal As DataGridViewTextBoxColumn
    Friend WithEvents FechaEvaluacion As DataGridViewTextBoxColumn
    Friend WithEvents Empresa As DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As DataGridViewTextBoxColumn
    Friend WithEvents cmbListaEjecutivos As ComboBox
End Class
