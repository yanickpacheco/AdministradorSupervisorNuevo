<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSolicitudSoporte
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
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnReferidos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Image = Global.AdministradorSupervisor.My.Resources.Resources.volver_2
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVolver.Location = New System.Drawing.Point(239, 238)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(80, 56)
        Me.btnVolver.TabIndex = 12
        Me.btnVolver.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button3.Location = New System.Drawing.Point(41, 128)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(278, 69)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Cambio de Articulo "
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnReferidos
        '
        Me.btnReferidos.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReferidos.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnReferidos.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnReferidos.Location = New System.Drawing.Point(41, 38)
        Me.btnReferidos.Name = "btnReferidos"
        Me.btnReferidos.Size = New System.Drawing.Size(278, 69)
        Me.btnReferidos.TabIndex = 13
        Me.btnReferidos.Text = "Primera Entrega"
        Me.btnReferidos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnReferidos.UseVisualStyleBackColor = True
        '
        'FormSolicitudSoporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 327)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnReferidos)
        Me.Controls.Add(Me.btnVolver)
        Me.Name = "FormSolicitudSoporte"
        Me.Text = "Solicitud A Soporte"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnVolver As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnReferidos As Button
End Class
