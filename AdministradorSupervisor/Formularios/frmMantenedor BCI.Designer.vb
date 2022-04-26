<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenedor_BCI
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
        Me.dtSegmentoAgente = New System.Windows.Forms.DataGridView()
        Me.lblAgente = New System.Windows.Forms.Label()
        Me.cmbSegmento = New System.Windows.Forms.ComboBox()
        Me.lblSegmento = New System.Windows.Forms.Label()
        Me.cmbOrden = New System.Windows.Forms.ComboBox()
        Me.lblOrden = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lblAsignados = New System.Windows.Forms.Label()
        Me.btnNuevoSegmento = New System.Windows.Forms.Button()
        Me.btnIngresarSegmento = New System.Windows.Forms.Button()
        Me.txtAgente = New System.Windows.Forms.TextBox()
        Me.btnModifica = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.TextBoxAgente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBoxTodo = New System.Windows.Forms.CheckBox()
        Me.idRegistro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.agente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.segmento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.orden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vigente = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.vigcomparar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.dtSegmentoAgente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtSegmentoAgente
        '
        Me.dtSegmentoAgente.AllowUserToAddRows = False
        Me.dtSegmentoAgente.AllowUserToDeleteRows = False
        Me.dtSegmentoAgente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtSegmentoAgente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idRegistro, Me.agente, Me.segmento, Me.orden, Me.Cantidad, Me.vigente, Me.vigcomparar})
        Me.dtSegmentoAgente.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dtSegmentoAgente.Location = New System.Drawing.Point(12, 62)
        Me.dtSegmentoAgente.Name = "dtSegmentoAgente"
        Me.dtSegmentoAgente.RowHeadersVisible = False
        Me.dtSegmentoAgente.Size = New System.Drawing.Size(602, 324)
        Me.dtSegmentoAgente.TabIndex = 0
        '
        'lblAgente
        '
        Me.lblAgente.AutoSize = True
        Me.lblAgente.Location = New System.Drawing.Point(15, 412)
        Me.lblAgente.Name = "lblAgente"
        Me.lblAgente.Size = New System.Drawing.Size(47, 13)
        Me.lblAgente.TabIndex = 1
        Me.lblAgente.Text = "Agente: "
        '
        'cmbSegmento
        '
        Me.cmbSegmento.FormattingEnabled = True
        Me.cmbSegmento.Location = New System.Drawing.Point(79, 452)
        Me.cmbSegmento.Name = "cmbSegmento"
        Me.cmbSegmento.Size = New System.Drawing.Size(187, 21)
        Me.cmbSegmento.TabIndex = 4
        '
        'lblSegmento
        '
        Me.lblSegmento.AutoSize = True
        Me.lblSegmento.Location = New System.Drawing.Point(15, 455)
        Me.lblSegmento.Name = "lblSegmento"
        Me.lblSegmento.Size = New System.Drawing.Size(61, 13)
        Me.lblSegmento.TabIndex = 3
        Me.lblSegmento.Text = "Segmento: "
        '
        'cmbOrden
        '
        Me.cmbOrden.FormattingEnabled = True
        Me.cmbOrden.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbOrden.Location = New System.Drawing.Point(79, 490)
        Me.cmbOrden.Name = "cmbOrden"
        Me.cmbOrden.Size = New System.Drawing.Size(43, 21)
        Me.cmbOrden.TabIndex = 6
        '
        'lblOrden
        '
        Me.lblOrden.AutoSize = True
        Me.lblOrden.Location = New System.Drawing.Point(15, 493)
        Me.lblOrden.Name = "lblOrden"
        Me.lblOrden.Size = New System.Drawing.Size(42, 13)
        Me.lblOrden.TabIndex = 5
        Me.lblOrden.Text = "Orden: "
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(152, 493)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(57, 13)
        Me.lblCantidad.TabIndex = 7
        Me.lblCantidad.Text = "Asignado: "
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(213, 490)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(52, 20)
        Me.txtCantidad.TabIndex = 8
        '
        'lblAsignados
        '
        Me.lblAsignados.AutoSize = True
        Me.lblAsignados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsignados.ForeColor = System.Drawing.Color.DarkRed
        Me.lblAsignados.Location = New System.Drawing.Point(297, 399)
        Me.lblAsignados.Name = "lblAsignados"
        Me.lblAsignados.Size = New System.Drawing.Size(109, 39)
        Me.lblAsignados.TabIndex = 9
        Me.lblAsignados.Text = "Total Asignados: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Total Recorridos: "
        Me.lblAsignados.Visible = False
        '
        'btnNuevoSegmento
        '
        Me.btnNuevoSegmento.Location = New System.Drawing.Point(291, 452)
        Me.btnNuevoSegmento.Name = "btnNuevoSegmento"
        Me.btnNuevoSegmento.Size = New System.Drawing.Size(126, 23)
        Me.btnNuevoSegmento.TabIndex = 10
        Me.btnNuevoSegmento.Text = "Añadir Segmento"
        Me.btnNuevoSegmento.UseVisualStyleBackColor = True
        '
        'btnIngresarSegmento
        '
        Me.btnIngresarSegmento.Location = New System.Drawing.Point(63, 546)
        Me.btnIngresarSegmento.Name = "btnIngresarSegmento"
        Me.btnIngresarSegmento.Size = New System.Drawing.Size(88, 43)
        Me.btnIngresarSegmento.TabIndex = 11
        Me.btnIngresarSegmento.Text = "Ingresar Asignacion"
        Me.btnIngresarSegmento.UseVisualStyleBackColor = True
        '
        'txtAgente
        '
        Me.txtAgente.Location = New System.Drawing.Point(79, 409)
        Me.txtAgente.Name = "txtAgente"
        Me.txtAgente.Size = New System.Drawing.Size(186, 20)
        Me.txtAgente.TabIndex = 12
        '
        'btnModifica
        '
        Me.btnModifica.Location = New System.Drawing.Point(178, 546)
        Me.btnModifica.Name = "btnModifica"
        Me.btnModifica.Size = New System.Drawing.Size(88, 43)
        Me.btnModifica.TabIndex = 13
        Me.btnModifica.Text = "Modifica Asignacion"
        Me.btnModifica.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(291, 482)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(126, 23)
        Me.btnActualizar.TabIndex = 14
        Me.btnActualizar.Text = "Actualizar Agentes"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'TextBoxAgente
        '
        Me.TextBoxAgente.Location = New System.Drawing.Point(12, 13)
        Me.TextBoxAgente.Name = "TextBoxAgente"
        Me.TextBoxAgente.Size = New System.Drawing.Size(139, 20)
        Me.TextBoxAgente.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(158, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Filtrar por agente"
        '
        'CheckBoxTodo
        '
        Me.CheckBoxTodo.AutoSize = True
        Me.CheckBoxTodo.ForeColor = System.Drawing.Color.Maroon
        Me.CheckBoxTodo.Location = New System.Drawing.Point(274, 19)
        Me.CheckBoxTodo.Name = "CheckBoxTodo"
        Me.CheckBoxTodo.Size = New System.Drawing.Size(241, 17)
        Me.CheckBoxTodo.TabIndex = 17
        Me.CheckBoxTodo.Text = "Ver todos los agentes(incluso los no vigentes)"
        Me.CheckBoxTodo.UseVisualStyleBackColor = True
        '
        'idRegistro
        '
        Me.idRegistro.DataPropertyName = "idSegmentoAgente"
        Me.idRegistro.HeaderText = "Id Registro"
        Me.idRegistro.Name = "idRegistro"
        Me.idRegistro.ReadOnly = True
        Me.idRegistro.Visible = False
        '
        'agente
        '
        Me.agente.DataPropertyName = "nombreAgente"
        Me.agente.HeaderText = "Agente"
        Me.agente.Name = "agente"
        Me.agente.ReadOnly = True
        Me.agente.Width = 180
        '
        'segmento
        '
        Me.segmento.DataPropertyName = "nombreSegmento"
        Me.segmento.HeaderText = "Segmento"
        Me.segmento.Name = "segmento"
        Me.segmento.ReadOnly = True
        '
        'orden
        '
        Me.orden.DataPropertyName = "orden"
        Me.orden.HeaderText = "Orden"
        Me.orden.Name = "orden"
        Me.orden.ReadOnly = True
        Me.orden.Width = 50
        '
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "asignados"
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 70
        '
        'vigente
        '
        Me.vigente.DataPropertyName = "vigente"
        Me.vigente.HeaderText = "Vigente"
        Me.vigente.Name = "vigente"
        Me.vigente.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.vigente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.vigente.Width = 60
        '
        'vigcomparar
        '
        Me.vigcomparar.DataPropertyName = "vigcomparar"
        Me.vigcomparar.HeaderText = "Comparar"
        Me.vigcomparar.Name = "vigcomparar"
        Me.vigcomparar.ReadOnly = True
        Me.vigcomparar.Visible = False
        '
        'frmMantenedor_BCI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 601)
        Me.Controls.Add(Me.CheckBoxTodo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxAgente)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnModifica)
        Me.Controls.Add(Me.txtAgente)
        Me.Controls.Add(Me.btnIngresarSegmento)
        Me.Controls.Add(Me.btnNuevoSegmento)
        Me.Controls.Add(Me.lblAsignados)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.cmbOrden)
        Me.Controls.Add(Me.lblOrden)
        Me.Controls.Add(Me.cmbSegmento)
        Me.Controls.Add(Me.lblSegmento)
        Me.Controls.Add(Me.lblAgente)
        Me.Controls.Add(Me.dtSegmentoAgente)
        Me.Name = "frmMantenedor_BCI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMantenedor_BCI"
        CType(Me.dtSegmentoAgente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtSegmentoAgente As System.Windows.Forms.DataGridView
    Friend WithEvents lblAgente As System.Windows.Forms.Label
    Friend WithEvents cmbSegmento As System.Windows.Forms.ComboBox
    Friend WithEvents lblSegmento As System.Windows.Forms.Label
    Friend WithEvents cmbOrden As System.Windows.Forms.ComboBox
    Friend WithEvents lblOrden As System.Windows.Forms.Label
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents lblAsignados As System.Windows.Forms.Label
    Friend WithEvents btnNuevoSegmento As System.Windows.Forms.Button
    Friend WithEvents btnIngresarSegmento As System.Windows.Forms.Button
    Friend WithEvents txtAgente As System.Windows.Forms.TextBox
    Friend WithEvents btnModifica As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents TextBoxAgente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxTodo As System.Windows.Forms.CheckBox
    Friend WithEvents idRegistro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents agente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents segmento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents orden As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vigente As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents vigcomparar As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
