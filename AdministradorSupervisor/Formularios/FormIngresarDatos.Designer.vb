<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIngresarDatos
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
        Me.dtgDatosCliente = New System.Windows.Forms.DataGridView()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbDatoActualiza = New System.Windows.Forms.ComboBox()
        Me.gpbActualizar = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.dtgDatosCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbActualizar.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgDatosCliente
        '
        Me.dtgDatosCliente.AllowUserToAddRows = False
        Me.dtgDatosCliente.AllowUserToDeleteRows = False
        Me.dtgDatosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgDatosCliente.Location = New System.Drawing.Point(30, 257)
        Me.dtgDatosCliente.Name = "dtgDatosCliente"
        Me.dtgDatosCliente.ReadOnly = True
        Me.dtgDatosCliente.Size = New System.Drawing.Size(745, 199)
        Me.dtgDatosCliente.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(258, 43)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(227, 21)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "ACTUALIZACION DE DATOS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Id:"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(93, 103)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(217, 94)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 36)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbDatoActualiza
        '
        Me.cmbDatoActualiza.FormattingEnabled = True
        Me.cmbDatoActualiza.Location = New System.Drawing.Point(153, 19)
        Me.cmbDatoActualiza.Name = "cmbDatoActualiza"
        Me.cmbDatoActualiza.Size = New System.Drawing.Size(202, 21)
        Me.cmbDatoActualiza.TabIndex = 5
        '
        'gpbActualizar
        '
        Me.gpbActualizar.Controls.Add(Me.TextBox1)
        Me.gpbActualizar.Controls.Add(Me.Label2)
        Me.gpbActualizar.Controls.Add(Me.cmbDatoActualiza)
        Me.gpbActualizar.Location = New System.Drawing.Point(378, 76)
        Me.gpbActualizar.Name = "gpbActualizar"
        Me.gpbActualizar.Size = New System.Drawing.Size(410, 130)
        Me.gpbActualizar.TabIndex = 6
        Me.gpbActualizar.TabStop = False
        Me.gpbActualizar.Text = "Actualizar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(13, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Dato a Actualizar:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(153, 56)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(180, 34)
        Me.TextBox1.TabIndex = 7
        '
        'FormIngresarDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 519)
        Me.Controls.Add(Me.gpbActualizar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.dtgDatosCliente)
        Me.Name = "FormIngresarDatos"
        Me.Text = "Ingresar Datos"
        CType(Me.dtgDatosCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbActualizar.ResumeLayout(False)
        Me.gpbActualizar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgDatosCliente As DataGridView
    Friend WithEvents lblTitulo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cmbDatoActualiza As ComboBox
    Friend WithEvents gpbActualizar As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
