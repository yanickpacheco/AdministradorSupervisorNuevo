<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejecutivos
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ejecutivos))
        Me.dtgEjecutivos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAsignados = New System.Windows.Forms.TextBox()
        Me.cmbPerfil = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.chkUsuario = New System.Windows.Forms.CheckBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.chkModificar = New System.Windows.Forms.CheckBox()
        Me.lblClic = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.chkTodosEjecutivos = New System.Windows.Forms.CheckBox()
        Me.lblHabilitar = New System.Windows.Forms.Label()
        Me.idUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idPerfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idAsignados = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idRecorridos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Activo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtRed = New System.Windows.Forms.TextBox()
        CType(Me.dtgEjecutivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgEjecutivos
        '
        Me.dtgEjecutivos.AllowUserToAddRows = False
        Me.dtgEjecutivos.AllowUserToDeleteRows = False
        Me.dtgEjecutivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgEjecutivos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idUsuario, Me.idPerfil, Me.idAsignados, Me.idRecorridos, Me.Activo})
        Me.dtgEjecutivos.Location = New System.Drawing.Point(12, 28)
        Me.dtgEjecutivos.Name = "dtgEjecutivos"
        Me.dtgEjecutivos.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dtgEjecutivos.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgEjecutivos.Size = New System.Drawing.Size(589, 293)
        Me.dtgEjecutivos.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.txtAsignados)
        Me.GroupBox1.Controls.Add(Me.cmbPerfil)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(114, 369)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(315, 110)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'txtAsignados
        '
        Me.txtAsignados.Location = New System.Drawing.Point(100, 78)
        Me.txtAsignados.Name = "txtAsignados"
        Me.txtAsignados.Size = New System.Drawing.Size(100, 20)
        Me.txtAsignados.TabIndex = 5
        '
        'cmbPerfil
        '
        Me.cmbPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPerfil.FormattingEnabled = True
        Me.cmbPerfil.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbPerfil.Items.AddRange(New Object() {"[Seleccione]", "Ventas", "Recuperación"})
        Me.cmbPerfil.Location = New System.Drawing.Point(100, 44)
        Me.cmbPerfil.Name = "cmbPerfil"
        Me.cmbPerfil.Size = New System.Drawing.Size(121, 21)
        Me.cmbPerfil.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Asignados"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Perfil"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(100, 13)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(193, 20)
        Me.txtNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(131, 492)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(125, 23)
        Me.btnIngresar.TabIndex = 2
        Me.btnIngresar.Text = "Ingresar Usuario"
        Me.btnIngresar.UseVisualStyleBackColor = True
        Me.btnIngresar.Visible = False
        '
        'chkUsuario
        '
        Me.chkUsuario.AutoSize = True
        Me.chkUsuario.Location = New System.Drawing.Point(40, 327)
        Me.chkUsuario.Name = "chkUsuario"
        Me.chkUsuario.Size = New System.Drawing.Size(95, 17)
        Me.chkUsuario.TabIndex = 4
        Me.chkUsuario.Text = "Nuevo usuario"
        Me.chkUsuario.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(283, 491)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(124, 23)
        Me.btnModificar.TabIndex = 5
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        Me.btnModificar.Visible = False
        '
        'chkModificar
        '
        Me.chkModificar.AutoSize = True
        Me.chkModificar.Location = New System.Drawing.Point(406, 327)
        Me.chkModificar.Name = "chkModificar"
        Me.chkModificar.Size = New System.Drawing.Size(114, 17)
        Me.chkModificar.TabIndex = 6
        Me.chkModificar.Text = "Modificar registros "
        Me.chkModificar.UseVisualStyleBackColor = True
        '
        'lblClic
        '
        Me.lblClic.AutoSize = True
        Me.lblClic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClic.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblClic.Location = New System.Drawing.Point(98, 354)
        Me.lblClic.Name = "lblClic"
        Me.lblClic.Size = New System.Drawing.Size(345, 13)
        Me.lblClic.TabIndex = 7
        Me.lblClic.Text = "HAGA DOBLE CLIC EN UN USUARIO PARA MODIFICARLO"
        Me.lblClic.Visible = False
        '
        'btnVolver
        '
        Me.btnVolver.Image = CType(resources.GetObject("btnVolver.Image"), System.Drawing.Image)
        Me.btnVolver.Location = New System.Drawing.Point(247, 520)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(67, 68)
        Me.btnVolver.TabIndex = 3
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'chkTodosEjecutivos
        '
        Me.chkTodosEjecutivos.AutoSize = True
        Me.chkTodosEjecutivos.Location = New System.Drawing.Point(21, 7)
        Me.chkTodosEjecutivos.Name = "chkTodosEjecutivos"
        Me.chkTodosEjecutivos.Size = New System.Drawing.Size(138, 17)
        Me.chkTodosEjecutivos.TabIndex = 8
        Me.chkTodosEjecutivos.Text = "Ver todos los ejecutivos"
        Me.chkTodosEjecutivos.UseVisualStyleBackColor = True
        '
        'lblHabilitar
        '
        Me.lblHabilitar.AutoSize = True
        Me.lblHabilitar.Location = New System.Drawing.Point(443, 8)
        Me.lblHabilitar.Name = "lblHabilitar"
        Me.lblHabilitar.Size = New System.Drawing.Size(123, 13)
        Me.lblHabilitar.TabIndex = 9
        Me.lblHabilitar.Text = "(*) Usuarios Inhabilitados"
        Me.lblHabilitar.Visible = False
        '
        'idUsuario
        '
        Me.idUsuario.DataPropertyName = "Usuario"
        Me.idUsuario.HeaderText = "Usuario"
        Me.idUsuario.Name = "idUsuario"
        Me.idUsuario.ReadOnly = True
        Me.idUsuario.Width = 150
        '
        'idPerfil
        '
        Me.idPerfil.DataPropertyName = "Perfil"
        Me.idPerfil.HeaderText = "Perfil"
        Me.idPerfil.Name = "idPerfil"
        Me.idPerfil.ReadOnly = True
        '
        'idAsignados
        '
        Me.idAsignados.DataPropertyName = "Registros Asignados"
        Me.idAsignados.HeaderText = "Asignados"
        Me.idAsignados.Name = "idAsignados"
        Me.idAsignados.ReadOnly = True
        '
        'idRecorridos
        '
        Me.idRecorridos.DataPropertyName = "Registros Recorridos"
        Me.idRecorridos.HeaderText = "Recorridos"
        Me.idRecorridos.Name = "idRecorridos"
        Me.idRecorridos.ReadOnly = True
        '
        'Activo
        '
        Me.Activo.DataPropertyName = "activo"
        Me.Activo.HeaderText = "Activo"
        Me.Activo.Name = "Activo"
        Me.Activo.ReadOnly = True
        Me.Activo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Activo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'txtRed
        '
        Me.txtRed.BackColor = System.Drawing.Color.Red
        Me.txtRed.Location = New System.Drawing.Point(406, 4)
        Me.txtRed.Name = "txtRed"
        Me.txtRed.Size = New System.Drawing.Size(31, 20)
        Me.txtRed.TabIndex = 10
        Me.txtRed.Visible = False
        '
        'Ejecutivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(613, 596)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtRed)
        Me.Controls.Add(Me.lblHabilitar)
        Me.Controls.Add(Me.chkTodosEjecutivos)
        Me.Controls.Add(Me.lblClic)
        Me.Controls.Add(Me.chkModificar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.chkUsuario)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtgEjecutivos)
        Me.DoubleBuffered = True
        Me.Name = "Ejecutivos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ejecutivos"
        CType(Me.dtgEjecutivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgEjecutivos As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnIngresar As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents txtAsignados As TextBox
    Friend WithEvents cmbPerfil As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chkUsuario As CheckBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents chkModificar As CheckBox
    Friend WithEvents lblClic As Label
    Friend WithEvents chkTodosEjecutivos As CheckBox
    Friend WithEvents lblHabilitar As Label
    Friend WithEvents idUsuario As DataGridViewTextBoxColumn
    Friend WithEvents idPerfil As DataGridViewTextBoxColumn
    Friend WithEvents idAsignados As DataGridViewTextBoxColumn
    Friend WithEvents idRecorridos As DataGridViewTextBoxColumn
    Friend WithEvents Activo As DataGridViewCheckBoxColumn
    Friend WithEvents txtRed As TextBox
End Class
