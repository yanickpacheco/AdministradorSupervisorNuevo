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
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 15.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(258, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bitacora Cambios"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblCantidad.Location = New System.Drawing.Point(493, 268)
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
        Me.txtCantidad.Location = New System.Drawing.Point(580, 263)
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
        Me.cmbInsumo.Location = New System.Drawing.Point(289, 266)
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
        Me.lblInsumo.Location = New System.Drawing.Point(154, 268)
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
        Me.dtFecha.Location = New System.Drawing.Point(289, 301)
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
        Me.cmbSolicitante.Location = New System.Drawing.Point(289, 226)
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
        Me.cmbPlataforma.Location = New System.Drawing.Point(289, 191)
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
        Me.cmbTipoSolicitud.Location = New System.Drawing.Point(289, 152)
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
        Me.cmbPiso.Location = New System.Drawing.Point(289, 103)
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
        Me.Label6.Location = New System.Drawing.Point(152, 304)
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
        Me.Label5.Location = New System.Drawing.Point(152, 232)
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
        Me.Label4.Location = New System.Drawing.Point(152, 197)
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
        Me.Label3.Location = New System.Drawing.Point(152, 159)
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
        Me.Label2.Location = New System.Drawing.Point(152, 106)
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
        Me.Label8.Location = New System.Drawing.Point(265, 38)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(215, 34)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Bitacora Cambios"
        '
        'frmIngresoSolicitud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 604)
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
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmIngresoSolicitud"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmIngresoSolicitud"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
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
End Class
