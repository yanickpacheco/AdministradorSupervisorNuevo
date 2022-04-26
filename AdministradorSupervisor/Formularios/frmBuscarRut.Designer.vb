<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarRut
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
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDv = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtgDatosRut = New System.Windows.Forms.DataGridView()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.campana = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaGestion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ejecutivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Flujo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dtgDatosRut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Brown
        Me.Label1.Location = New System.Drawing.Point(395, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar Rut"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(250, 68)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(112, 37)
        Me.btnBuscar.TabIndex = 29
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtRut
        '
        Me.txtRut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRut.Location = New System.Drawing.Point(77, 75)
        Me.txtRut.MaxLength = 8
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(100, 23)
        Me.txtRut.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(33, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 17)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Rut:"
        '
        'txtDv
        '
        Me.txtDv.Enabled = False
        Me.txtDv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDv.Location = New System.Drawing.Point(202, 75)
        Me.txtDv.Name = "txtDv"
        Me.txtDv.ReadOnly = True
        Me.txtDv.Size = New System.Drawing.Size(20, 23)
        Me.txtDv.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(182, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 17)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "-"
        '
        'dtgDatosRut
        '
        Me.dtgDatosRut.AllowUserToAddRows = False
        Me.dtgDatosRut.AllowUserToDeleteRows = False
        Me.dtgDatosRut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgDatosRut.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.campana, Me.Venta, Me.Id, Me.Nombre, Me.FechaGestion, Me.Ejecutivo, Me.Estado, Me.Flujo})
        Me.dtgDatosRut.Location = New System.Drawing.Point(36, 142)
        Me.dtgDatosRut.Name = "dtgDatosRut"
        Me.dtgDatosRut.ReadOnly = True
        Me.dtgDatosRut.RowHeadersVisible = False
        Me.dtgDatosRut.Size = New System.Drawing.Size(896, 181)
        Me.dtgDatosRut.TabIndex = 32
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(424, 349)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(88, 29)
        Me.btnVolver.TabIndex = 33
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'campana
        '
        Me.campana.DataPropertyName = "Campaña"
        Me.campana.HeaderText = "Campaña"
        Me.campana.Name = "campana"
        Me.campana.ReadOnly = True
        '
        'Venta
        '
        Me.Venta.DataPropertyName = "Venta"
        Me.Venta.HeaderText = "Venta"
        Me.Venta.Name = "Venta"
        Me.Venta.ReadOnly = True
        '
        'Id
        '
        Me.Id.DataPropertyName = "Id"
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'FechaGestion
        '
        Me.FechaGestion.DataPropertyName = "Fecha Gestion"
        Me.FechaGestion.HeaderText = "Fecha Gestion"
        Me.FechaGestion.Name = "FechaGestion"
        Me.FechaGestion.ReadOnly = True
        '
        'Ejecutivo
        '
        Me.Ejecutivo.DataPropertyName = "Ejecutivo"
        Me.Ejecutivo.HeaderText = "Ejecutivo"
        Me.Ejecutivo.Name = "Ejecutivo"
        Me.Ejecutivo.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.DataPropertyName = "Estado"
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        '
        'Flujo
        '
        Me.Flujo.DataPropertyName = "Flujo"
        Me.Flujo.HeaderText = "Flujo"
        Me.Flujo.Name = "Flujo"
        Me.Flujo.ReadOnly = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.SkyBlue
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(654, 85)
        Me.TextBox1.MaxLength = 8
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(44, 23)
        Me.TextBox1.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(704, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "= Venta"
        '
        'frmBuscarRut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 402)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.dtgDatosRut)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDv)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtRut)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBuscarRut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BuscarRut"
        CType(Me.dtgDatosRut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtRut As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDv As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtgDatosRut As DataGridView
    Friend WithEvents btnVolver As Button
    Friend WithEvents campana As DataGridViewTextBoxColumn
    Friend WithEvents Venta As DataGridViewTextBoxColumn
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents FechaGestion As DataGridViewTextBoxColumn
    Friend WithEvents Ejecutivo As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents Flujo As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
End Class
