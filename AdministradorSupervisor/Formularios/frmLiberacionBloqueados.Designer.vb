<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLiberacionBloqueados
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
        Me.cmbTipoBloqueo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgRegistros = New System.Windows.Forms.DataGridView()
        Me.chkSeleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comuna = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Periodo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnLiberar = New System.Windows.Forms.Button()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.chkSeleccionarTodos = New System.Windows.Forms.CheckBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnMarcar = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.chkEjecutivos = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkListEjecutivos = New System.Windows.Forms.CheckedListBox()
        Me.lblTotalRegistros = New System.Windows.Forms.Label()
        CType(Me.dtgRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbTipoBloqueo
        '
        Me.cmbTipoBloqueo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoBloqueo.FormattingEnabled = True
        Me.cmbTipoBloqueo.Location = New System.Drawing.Point(118, 34)
        Me.cmbTipoBloqueo.Name = "cmbTipoBloqueo"
        Me.cmbTipoBloqueo.Size = New System.Drawing.Size(332, 21)
        Me.cmbTipoBloqueo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Marca Bloqueo"
        '
        'dtgRegistros
        '
        Me.dtgRegistros.AllowUserToAddRows = False
        Me.dtgRegistros.AllowUserToDeleteRows = False
        Me.dtgRegistros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtgRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgRegistros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chkSeleccionar, Me.Id, Me.Nombre, Me.Comuna, Me.Periodo, Me.Estado})
        Me.dtgRegistros.Location = New System.Drawing.Point(12, 152)
        Me.dtgRegistros.Name = "dtgRegistros"
        Me.dtgRegistros.RowHeadersVisible = False
        Me.dtgRegistros.Size = New System.Drawing.Size(745, 319)
        Me.dtgRegistros.TabIndex = 2
        '
        'chkSeleccionar
        '
        Me.chkSeleccionar.HeaderText = "Seleccionar"
        Me.chkSeleccionar.Name = "chkSeleccionar"
        Me.chkSeleccionar.Width = 69
        '
        'Id
        '
        Me.Id.DataPropertyName = "ID"
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 41
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "NOMBRE"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 69
        '
        'Comuna
        '
        Me.Comuna.DataPropertyName = "COMUNA"
        Me.Comuna.HeaderText = "Comuna"
        Me.Comuna.Name = "Comuna"
        Me.Comuna.ReadOnly = True
        Me.Comuna.Width = 71
        '
        'Periodo
        '
        Me.Periodo.DataPropertyName = "PERIODO"
        Me.Periodo.HeaderText = "Periodo"
        Me.Periodo.Name = "Periodo"
        Me.Periodo.ReadOnly = True
        Me.Periodo.Width = 68
        '
        'Estado
        '
        Me.Estado.DataPropertyName = "ESTADO"
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Width = 65
        '
        'btnLiberar
        '
        Me.btnLiberar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLiberar.Location = New System.Drawing.Point(335, 495)
        Me.btnLiberar.Name = "btnLiberar"
        Me.btnLiberar.Size = New System.Drawing.Size(220, 45)
        Me.btnLiberar.TabIndex = 5
        Me.btnLiberar.Text = "Liberar Registros"
        Me.btnLiberar.UseVisualStyleBackColor = True
        '
        'btnListar
        '
        Me.btnListar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListar.Location = New System.Drawing.Point(472, 28)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(83, 32)
        Me.btnListar.TabIndex = 7
        Me.btnListar.Text = "Listar"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'chkSeleccionarTodos
        '
        Me.chkSeleccionarTodos.AutoSize = True
        Me.chkSeleccionarTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSeleccionarTodos.Location = New System.Drawing.Point(12, 123)
        Me.chkSeleccionarTodos.Name = "chkSeleccionarTodos"
        Me.chkSeleccionarTodos.Size = New System.Drawing.Size(142, 20)
        Me.chkSeleccionarTodos.TabIndex = 8
        Me.chkSeleccionarTodos.Text = "Seleccionar Todos"
        Me.chkSeleccionarTodos.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(369, 123)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(41, 20)
        Me.txtCantidad.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(220, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Seleccionar Cantidad: "
        '
        'btnMarcar
        '
        Me.btnMarcar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarcar.Location = New System.Drawing.Point(416, 122)
        Me.btnMarcar.Name = "btnMarcar"
        Me.btnMarcar.Size = New System.Drawing.Size(115, 23)
        Me.btnMarcar.TabIndex = 11
        Me.btnMarcar.Text = "Marcar cantidad"
        Me.btnMarcar.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(587, 127)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblTotal.TabIndex = 12
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(888, 538)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(86, 33)
        Me.btnVolver.TabIndex = 14
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'chkEjecutivos
        '
        Me.chkEjecutivos.AutoSize = True
        Me.chkEjecutivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEjecutivos.Location = New System.Drawing.Point(779, 124)
        Me.chkEjecutivos.Name = "chkEjecutivos"
        Me.chkEjecutivos.Size = New System.Drawing.Size(164, 20)
        Me.chkEjecutivos.TabIndex = 16
        Me.chkEjecutivos.Text = "Seleccionar Ejecutivos"
        Me.chkEjecutivos.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Indigo
        Me.Label2.Location = New System.Drawing.Point(766, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 71)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "* Registros quedan liberados a plataforma. Puede asignar a ejecutivos en la lista" &
    " inferior"
        '
        'chkListEjecutivos
        '
        Me.chkListEjecutivos.FormattingEnabled = True
        Me.chkListEjecutivos.Location = New System.Drawing.Point(779, 152)
        Me.chkListEjecutivos.Name = "chkListEjecutivos"
        Me.chkListEjecutivos.Size = New System.Drawing.Size(176, 319)
        Me.chkListEjecutivos.TabIndex = 18
        Me.chkListEjecutivos.Visible = False
        '
        'lblTotalRegistros
        '
        Me.lblTotalRegistros.AutoSize = True
        Me.lblTotalRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRegistros.Location = New System.Drawing.Point(604, 127)
        Me.lblTotalRegistros.Name = "lblTotalRegistros"
        Me.lblTotalRegistros.Size = New System.Drawing.Size(0, 15)
        Me.lblTotalRegistros.TabIndex = 19
        '
        'frmLiberacionBloqueados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 583)
        Me.Controls.Add(Me.lblTotalRegistros)
        Me.Controls.Add(Me.chkListEjecutivos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkEjecutivos)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnMarcar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.chkSeleccionarTodos)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.btnLiberar)
        Me.Controls.Add(Me.dtgRegistros)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbTipoBloqueo)
        Me.Name = "frmLiberacionBloqueados"
        CType(Me.dtgRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbTipoBloqueo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtgRegistros As DataGridView
    Friend WithEvents btnLiberar As Button
    Friend WithEvents btnListar As Button
    Friend WithEvents chkSeleccionarTodos As CheckBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnMarcar As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents chkSeleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Comuna As DataGridViewTextBoxColumn
    Friend WithEvents Periodo As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents chkEjecutivos As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chkListEjecutivos As CheckedListBox
    Friend WithEvents lblTotalRegistros As Label
End Class
