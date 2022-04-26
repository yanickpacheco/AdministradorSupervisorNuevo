<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdministracionRegistros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdministracionRegistros))
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnLiberacionRegistros = New System.Windows.Forms.Button()
        Me.btnLiberarBloqueados = New System.Windows.Forms.Button()
        Me.btnRecicladoBase = New System.Windows.Forms.Button()
        Me.btnBuscarRut = New System.Windows.Forms.Button()
        Me.btnMandato = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Image = Global.AdministradorSupervisor.My.Resources.Resources.volver_2
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVolver.Location = New System.Drawing.Point(327, 586)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(107, 69)
        Me.btnVolver.TabIndex = 11
        Me.btnVolver.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnLiberacionRegistros
        '
        Me.btnLiberacionRegistros.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLiberacionRegistros.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.btnLiberacionRegistros.Image = CType(resources.GetObject("btnLiberacionRegistros.Image"), System.Drawing.Image)
        Me.btnLiberacionRegistros.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnLiberacionRegistros.Location = New System.Drawing.Point(203, 55)
        Me.btnLiberacionRegistros.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLiberacionRegistros.Name = "btnLiberacionRegistros"
        Me.btnLiberacionRegistros.Size = New System.Drawing.Size(361, 85)
        Me.btnLiberacionRegistros.TabIndex = 12
        Me.btnLiberacionRegistros.Text = "Liberacion de Registros"
        Me.btnLiberacionRegistros.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnLiberacionRegistros.UseVisualStyleBackColor = True
        '
        'btnLiberarBloqueados
        '
        Me.btnLiberarBloqueados.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLiberarBloqueados.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.btnLiberarBloqueados.Image = CType(resources.GetObject("btnLiberarBloqueados.Image"), System.Drawing.Image)
        Me.btnLiberarBloqueados.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnLiberarBloqueados.Location = New System.Drawing.Point(203, 342)
        Me.btnLiberarBloqueados.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLiberarBloqueados.Name = "btnLiberarBloqueados"
        Me.btnLiberarBloqueados.Size = New System.Drawing.Size(361, 85)
        Me.btnLiberarBloqueados.TabIndex = 13
        Me.btnLiberarBloqueados.Text = "Liberacion de Bloqueados"
        Me.btnLiberarBloqueados.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnLiberarBloqueados.UseVisualStyleBackColor = True
        '
        'btnRecicladoBase
        '
        Me.btnRecicladoBase.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecicladoBase.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.btnRecicladoBase.Image = CType(resources.GetObject("btnRecicladoBase.Image"), System.Drawing.Image)
        Me.btnRecicladoBase.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnRecicladoBase.Location = New System.Drawing.Point(203, 244)
        Me.btnRecicladoBase.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRecicladoBase.Name = "btnRecicladoBase"
        Me.btnRecicladoBase.Size = New System.Drawing.Size(361, 90)
        Me.btnRecicladoBase.TabIndex = 14
        Me.btnRecicladoBase.Text = "Reciclado de Base"
        Me.btnRecicladoBase.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnRecicladoBase.UseVisualStyleBackColor = True
        '
        'btnBuscarRut
        '
        Me.btnBuscarRut.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarRut.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.btnBuscarRut.Image = CType(resources.GetObject("btnBuscarRut.Image"), System.Drawing.Image)
        Me.btnBuscarRut.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnBuscarRut.Location = New System.Drawing.Point(203, 147)
        Me.btnBuscarRut.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBuscarRut.Name = "btnBuscarRut"
        Me.btnBuscarRut.Size = New System.Drawing.Size(361, 90)
        Me.btnBuscarRut.TabIndex = 15
        Me.btnBuscarRut.Text = "Busqueda Rut"
        Me.btnBuscarRut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnBuscarRut.UseVisualStyleBackColor = True
        '
        'btnMandato
        '
        Me.btnMandato.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMandato.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.btnMandato.Image = CType(resources.GetObject("btnMandato.Image"), System.Drawing.Image)
        Me.btnMandato.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnMandato.Location = New System.Drawing.Point(203, 435)
        Me.btnMandato.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMandato.Name = "btnMandato"
        Me.btnMandato.Size = New System.Drawing.Size(361, 85)
        Me.btnMandato.TabIndex = 16
        Me.btnMandato.Text = "Traspaso Mandato"
        Me.btnMandato.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnMandato.UseVisualStyleBackColor = True
        Me.btnMandato.Visible = False
        '
        'FormAdministracionRegistros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(783, 684)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnMandato)
        Me.Controls.Add(Me.btnBuscarRut)
        Me.Controls.Add(Me.btnRecicladoBase)
        Me.Controls.Add(Me.btnLiberarBloqueados)
        Me.Controls.Add(Me.btnLiberacionRegistros)
        Me.Controls.Add(Me.btnVolver)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormAdministracionRegistros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administracion Registros"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnVolver As Button
    Friend WithEvents btnLiberacionRegistros As Button
    Friend WithEvents btnLiberarBloqueados As Button
    Friend WithEvents btnRecicladoBase As Button
    Friend WithEvents btnBuscarRut As Button
    Friend WithEvents btnMandato As Button
End Class
