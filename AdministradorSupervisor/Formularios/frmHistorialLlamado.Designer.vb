<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistorialLlamado
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistorialLlamado))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblLlamada = New System.Windows.Forms.Label()
        Me.lblLogGestion = New System.Windows.Forms.Label()
        Me.lblGestion = New System.Windows.Forms.Label()
        Me.dtgLogGestion = New System.Windows.Forms.DataGridView()
        Me.fechaLog = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horaLog = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.intentos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ejecutivoLog = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.flujoLog = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtgHistorial = New System.Windows.Forms.DataGridView()
        Me.Rut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.periodo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ejecutivoG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.flujo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dtgGrabaciones = New System.Windows.Forms.DataGridView()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.proceso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idLLamada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ejecutivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaLlamada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horaInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.horaTermino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fonoContacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.duracion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreGrabacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wbLLamada = New System.Windows.Forms.WebBrowser()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.asociarGrabacion = New System.Windows.Forms.DataGridViewImageColumn()
        Me.escucharGrabacion = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.dtgLogGestion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgGrabaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLlamada
        '
        Me.lblLlamada.AutoSize = True
        Me.lblLlamada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.lblLlamada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblLlamada.Location = New System.Drawing.Point(30, 68)
        Me.lblLlamada.Name = "lblLlamada"
        Me.lblLlamada.Size = New System.Drawing.Size(70, 15)
        Me.lblLlamada.TabIndex = 31
        Me.lblLlamada.Text = "Llamadas"
        '
        'lblLogGestion
        '
        Me.lblLogGestion.AutoSize = True
        Me.lblLogGestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.lblLogGestion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblLogGestion.Location = New System.Drawing.Point(30, 406)
        Me.lblLogGestion.Name = "lblLogGestion"
        Me.lblLogGestion.Size = New System.Drawing.Size(104, 15)
        Me.lblLogGestion.TabIndex = 30
        Me.lblLogGestion.Text = "Log de Gestion"
        '
        'lblGestion
        '
        Me.lblGestion.AutoSize = True
        Me.lblGestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.lblGestion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblGestion.Location = New System.Drawing.Point(30, 308)
        Me.lblGestion.Name = "lblGestion"
        Me.lblGestion.Size = New System.Drawing.Size(56, 15)
        Me.lblGestion.TabIndex = 29
        Me.lblGestion.Text = "Gestion"
        '
        'dtgLogGestion
        '
        Me.dtgLogGestion.AllowUserToAddRows = False
        Me.dtgLogGestion.AllowUserToDeleteRows = False
        Me.dtgLogGestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgLogGestion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fechaLog, Me.horaLog, Me.estado, Me.intentos, Me.ejecutivoLog, Me.flujoLog})
        Me.dtgLogGestion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgLogGestion.Location = New System.Drawing.Point(30, 424)
        Me.dtgLogGestion.Name = "dtgLogGestion"
        Me.dtgLogGestion.ReadOnly = True
        Me.dtgLogGestion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dtgLogGestion.RowHeadersVisible = False
        Me.dtgLogGestion.RowHeadersWidth = 55
        Me.dtgLogGestion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtgLogGestion.Size = New System.Drawing.Size(858, 123)
        Me.dtgLogGestion.TabIndex = 28
        '
        'fechaLog
        '
        Me.fechaLog.DataPropertyName = "FECHA"
        Me.fechaLog.HeaderText = "Fecha"
        Me.fechaLog.Name = "fechaLog"
        Me.fechaLog.ReadOnly = True
        '
        'horaLog
        '
        Me.horaLog.DataPropertyName = "HORA"
        Me.horaLog.HeaderText = "Hora"
        Me.horaLog.Name = "horaLog"
        Me.horaLog.ReadOnly = True
        '
        'estado
        '
        Me.estado.DataPropertyName = "ESTADO"
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
        '
        'intentos
        '
        Me.intentos.DataPropertyName = "INTENTOS"
        Me.intentos.HeaderText = "Intentos"
        Me.intentos.Name = "intentos"
        Me.intentos.ReadOnly = True
        '
        'ejecutivoLog
        '
        Me.ejecutivoLog.DataPropertyName = "EJECUTIVO"
        Me.ejecutivoLog.HeaderText = "Ejecutivo"
        Me.ejecutivoLog.Name = "ejecutivoLog"
        Me.ejecutivoLog.ReadOnly = True
        '
        'flujoLog
        '
        Me.flujoLog.DataPropertyName = "FLUJO"
        Me.flujoLog.HeaderText = "Flujo"
        Me.flujoLog.Name = "flujoLog"
        Me.flujoLog.ReadOnly = True
        '
        'dtgHistorial
        '
        Me.dtgHistorial.AllowUserToAddRows = False
        Me.dtgHistorial.AllowUserToDeleteRows = False
        Me.dtgHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgHistorial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Rut, Me.nombre, Me.periodo, Me.fecha, Me.hora, Me.ejecutivoG, Me.flujo})
        Me.dtgHistorial.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgHistorial.Location = New System.Drawing.Point(30, 326)
        Me.dtgHistorial.Name = "dtgHistorial"
        Me.dtgHistorial.ReadOnly = True
        Me.dtgHistorial.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dtgHistorial.RowHeadersVisible = False
        Me.dtgHistorial.RowHeadersWidth = 55
        Me.dtgHistorial.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtgHistorial.Size = New System.Drawing.Size(858, 77)
        Me.dtgHistorial.TabIndex = 27
        '
        'Rut
        '
        Me.Rut.DataPropertyName = "RUT"
        Me.Rut.HeaderText = "Rut"
        Me.Rut.Name = "Rut"
        Me.Rut.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "NOMBRE"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'periodo
        '
        Me.periodo.DataPropertyName = "PERIODO"
        Me.periodo.HeaderText = "Periodo"
        Me.periodo.Name = "periodo"
        Me.periodo.ReadOnly = True
        '
        'fecha
        '
        Me.fecha.DataPropertyName = "FECHA"
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'hora
        '
        Me.hora.DataPropertyName = "HORA"
        Me.hora.HeaderText = "Hora"
        Me.hora.Name = "hora"
        Me.hora.ReadOnly = True
        '
        'ejecutivoG
        '
        Me.ejecutivoG.DataPropertyName = "EJECUTIVO"
        Me.ejecutivoG.HeaderText = "Ejecutivo"
        Me.ejecutivoG.Name = "ejecutivoG"
        Me.ejecutivoG.ReadOnly = True
        '
        'flujo
        '
        Me.flujo.DataPropertyName = "FLUJO"
        Me.flujo.HeaderText = "Flujo"
        Me.flujo.Name = "flujo"
        Me.flujo.ReadOnly = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(223, 16)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(112, 37)
        Me.btnBuscar.TabIndex = 26
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(30, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(585, 15)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "(**) Para asociar audio de Venta, debe hacer doble Click en el icono de Asociar G" &
    "rabacion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(705, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "(*) Grabacion de Venta"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Green
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(652, 35)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(47, 23)
        Me.TextBox1.TabIndex = 23
        '
        'dtgGrabaciones
        '
        Me.dtgGrabaciones.AllowUserToAddRows = False
        Me.dtgGrabaciones.AllowUserToDeleteRows = False
        Me.dtgGrabaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgGrabaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.asociarGrabacion, Me.escucharGrabacion, Me.proceso, Me.idLLamada, Me.ejecutivo, Me.fechaLlamada, Me.horaInicio, Me.horaTermino, Me.fonoContacto, Me.duracion, Me.idVenta, Me.nombreGrabacion})
        Me.dtgGrabaciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgGrabaciones.Location = New System.Drawing.Point(30, 86)
        Me.dtgGrabaciones.Name = "dtgGrabaciones"
        Me.dtgGrabaciones.ReadOnly = True
        Me.dtgGrabaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dtgGrabaciones.RowHeadersVisible = False
        Me.dtgGrabaciones.RowHeadersWidth = 55
        Me.dtgGrabaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtgGrabaciones.Size = New System.Drawing.Size(858, 191)
        Me.dtgGrabaciones.TabIndex = 22
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(67, 23)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 23)
        Me.txtId.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(27, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 17)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Id:"
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(776, 558)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(112, 37)
        Me.btnVolver.TabIndex = 32
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'proceso
        '
        Me.proceso.DataPropertyName = "PROCESO"
        Me.proceso.HeaderText = "Proceso"
        Me.proceso.Name = "proceso"
        Me.proceso.ReadOnly = True
        '
        'idLLamada
        '
        Me.idLLamada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.idLLamada.DataPropertyName = "ID LLAMADA"
        Me.idLLamada.HeaderText = "Id Llamada"
        Me.idLLamada.Name = "idLLamada"
        Me.idLLamada.ReadOnly = True
        Me.idLLamada.Width = 78
        '
        'ejecutivo
        '
        Me.ejecutivo.DataPropertyName = "Ejecutivo"
        Me.ejecutivo.HeaderText = "Ejecutivo"
        Me.ejecutivo.Name = "ejecutivo"
        Me.ejecutivo.ReadOnly = True
        '
        'fechaLlamada
        '
        Me.fechaLlamada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.fechaLlamada.DataPropertyName = "Fecha"
        Me.fechaLlamada.HeaderText = "Fecha Llamada"
        Me.fechaLlamada.Name = "fechaLlamada"
        Me.fechaLlamada.ReadOnly = True
        Me.fechaLlamada.Width = 96
        '
        'horaInicio
        '
        Me.horaInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.horaInicio.DataPropertyName = "Hora_Inicio"
        Me.horaInicio.HeaderText = "Hora Inicio"
        Me.horaInicio.Name = "horaInicio"
        Me.horaInicio.ReadOnly = True
        Me.horaInicio.Width = 77
        '
        'horaTermino
        '
        Me.horaTermino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.horaTermino.DataPropertyName = "Hora_Termino"
        Me.horaTermino.HeaderText = "Hora Termino"
        Me.horaTermino.Name = "horaTermino"
        Me.horaTermino.ReadOnly = True
        Me.horaTermino.Width = 88
        '
        'fonoContacto
        '
        Me.fonoContacto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.fonoContacto.DataPropertyName = "Fono_Contacto"
        Me.fonoContacto.HeaderText = "Fono Contacto"
        Me.fonoContacto.Name = "fonoContacto"
        Me.fonoContacto.ReadOnly = True
        Me.fonoContacto.Width = 94
        '
        'duracion
        '
        Me.duracion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.duracion.DataPropertyName = "duracion"
        Me.duracion.HeaderText = "Duracion LLamada"
        Me.duracion.Name = "duracion"
        Me.duracion.ReadOnly = True
        Me.duracion.Width = 112
        '
        'idVenta
        '
        Me.idVenta.DataPropertyName = "Id_Venta"
        Me.idVenta.HeaderText = "Grabacion Venta"
        Me.idVenta.Name = "idVenta"
        Me.idVenta.ReadOnly = True
        Me.idVenta.Visible = False
        '
        'nombreGrabacion
        '
        Me.nombreGrabacion.DataPropertyName = "NOMBRE_GRABACION"
        Me.nombreGrabacion.HeaderText = "nombreGrabacion"
        Me.nombreGrabacion.Name = "nombreGrabacion"
        Me.nombreGrabacion.ReadOnly = True
        Me.nombreGrabacion.Visible = False
        '
        'wbLLamada
        '
        Me.wbLLamada.Location = New System.Drawing.Point(874, 12)
        Me.wbLLamada.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbLLamada.Name = "wbLLamada"
        Me.wbLLamada.Size = New System.Drawing.Size(35, 20)
        Me.wbLLamada.TabIndex = 33
        Me.wbLLamada.Visible = False
        '
        'DataGridViewImageColumn1
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.NullValue = CType(resources.GetObject("DataGridViewCellStyle3.NullValue"), Object)
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewImageColumn1.HeaderText = "Asociar Grabacion"
        Me.DataGridViewImageColumn1.Image = Global.AdministradorSupervisor.My.Resources.Resources.asociar
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "Escuchar"
        Me.DataGridViewImageColumn2.Image = CType(resources.GetObject("DataGridViewImageColumn2.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        '
        'asociarGrabacion
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.NullValue = CType(resources.GetObject("DataGridViewCellStyle4.NullValue"), Object)
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.asociarGrabacion.DefaultCellStyle = DataGridViewCellStyle4
        Me.asociarGrabacion.HeaderText = "Asociar Grabacion"
        Me.asociarGrabacion.Image = Global.AdministradorSupervisor.My.Resources.Resources.asociar
        Me.asociarGrabacion.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.asociarGrabacion.Name = "asociarGrabacion"
        Me.asociarGrabacion.ReadOnly = True
        Me.asociarGrabacion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.asociarGrabacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'escucharGrabacion
        '
        Me.escucharGrabacion.HeaderText = "Escuchar"
        Me.escucharGrabacion.Image = CType(resources.GetObject("escucharGrabacion.Image"), System.Drawing.Image)
        Me.escucharGrabacion.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.escucharGrabacion.Name = "escucharGrabacion"
        Me.escucharGrabacion.ReadOnly = True
        '
        'frmHistorialLlamado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 607)
        Me.ControlBox = False
        Me.Controls.Add(Me.wbLLamada)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblLlamada)
        Me.Controls.Add(Me.lblLogGestion)
        Me.Controls.Add(Me.lblGestion)
        Me.Controls.Add(Me.dtgLogGestion)
        Me.Controls.Add(Me.dtgHistorial)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.dtgGrabaciones)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmHistorialLlamado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmHistorialLlamado"
        CType(Me.dtgLogGestion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgGrabaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLlamada As Label
    Friend WithEvents lblLogGestion As Label
    Friend WithEvents lblGestion As Label
    Public WithEvents dtgLogGestion As DataGridView
    Friend WithEvents fechaLog As DataGridViewTextBoxColumn
    Friend WithEvents horaLog As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
    Friend WithEvents intentos As DataGridViewTextBoxColumn
    Friend WithEvents ejecutivoLog As DataGridViewTextBoxColumn
    Friend WithEvents flujoLog As DataGridViewTextBoxColumn
    Public WithEvents dtgHistorial As DataGridView
    Friend WithEvents Rut As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents periodo As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents hora As DataGridViewTextBoxColumn
    Friend WithEvents ejecutivoG As DataGridViewTextBoxColumn
    Friend WithEvents flujo As DataGridViewTextBoxColumn
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Public WithEvents dtgGrabaciones As DataGridView
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents asociarGrabacion As DataGridViewImageColumn
    Friend WithEvents escucharGrabacion As DataGridViewImageColumn
    Friend WithEvents proceso As DataGridViewTextBoxColumn
    Friend WithEvents idLLamada As DataGridViewTextBoxColumn
    Friend WithEvents ejecutivo As DataGridViewTextBoxColumn
    Friend WithEvents fechaLlamada As DataGridViewTextBoxColumn
    Friend WithEvents horaInicio As DataGridViewTextBoxColumn
    Friend WithEvents horaTermino As DataGridViewTextBoxColumn
    Friend WithEvents fonoContacto As DataGridViewTextBoxColumn
    Friend WithEvents duracion As DataGridViewTextBoxColumn
    Friend WithEvents idVenta As DataGridViewTextBoxColumn
    Friend WithEvents nombreGrabacion As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents wbLLamada As WebBrowser
End Class
