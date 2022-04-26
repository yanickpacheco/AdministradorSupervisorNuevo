<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnIngreso = New System.Windows.Forms.Button()
        Me.btnReferidos = New System.Windows.Forms.Button()
        Me.btnHistorialLlamado = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbListaCampaña = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button1.Location = New System.Drawing.Point(315, 215)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(278, 69)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Administración de Registros"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.AdministradorSupervisor.My.Resources.Resources.salir_v2
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.Location = New System.Drawing.Point(502, 436)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(76, 89)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(254, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(98, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BtnIngreso
        '
        Me.BtnIngreso.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngreso.ForeColor = System.Drawing.SystemColors.Highlight
        Me.BtnIngreso.Image = CType(resources.GetObject("BtnIngreso.Image"), System.Drawing.Image)
        Me.BtnIngreso.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.BtnIngreso.Location = New System.Drawing.Point(23, 215)
        Me.BtnIngreso.Name = "BtnIngreso"
        Me.BtnIngreso.Size = New System.Drawing.Size(278, 69)
        Me.BtnIngreso.TabIndex = 0
        Me.BtnIngreso.Text = "Control de Ejecutivos"
        Me.BtnIngreso.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnIngreso.UseVisualStyleBackColor = True
        '
        'btnReferidos
        '
        Me.btnReferidos.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReferidos.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnReferidos.Image = CType(resources.GetObject("btnReferidos.Image"), System.Drawing.Image)
        Me.btnReferidos.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnReferidos.Location = New System.Drawing.Point(315, 310)
        Me.btnReferidos.Name = "btnReferidos"
        Me.btnReferidos.Size = New System.Drawing.Size(278, 69)
        Me.btnReferidos.TabIndex = 5
        Me.btnReferidos.Text = "Carga Referidos"
        Me.btnReferidos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnReferidos.UseVisualStyleBackColor = True
        '
        'btnHistorialLlamado
        '
        Me.btnHistorialLlamado.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistorialLlamado.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnHistorialLlamado.Image = CType(resources.GetObject("btnHistorialLlamado.Image"), System.Drawing.Image)
        Me.btnHistorialLlamado.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnHistorialLlamado.Location = New System.Drawing.Point(23, 310)
        Me.btnHistorialLlamado.Name = "btnHistorialLlamado"
        Me.btnHistorialLlamado.Size = New System.Drawing.Size(278, 69)
        Me.btnHistorialLlamado.TabIndex = 6
        Me.btnHistorialLlamado.Text = "Historial de Llamado"
        Me.btnHistorialLlamado.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnHistorialLlamado.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button2.Location = New System.Drawing.Point(147, 398)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(278, 69)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "RetroAlimentacion"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(33, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Campaña"
        '
        'cmbListaCampaña
        '
        Me.cmbListaCampaña.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbListaCampaña.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbListaCampaña.FormattingEnabled = True
        Me.cmbListaCampaña.Location = New System.Drawing.Point(147, 136)
        Me.cmbListaCampaña.Name = "cmbListaCampaña"
        Me.cmbListaCampaña.Size = New System.Drawing.Size(407, 24)
        Me.cmbListaCampaña.TabIndex = 8
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(626, 551)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbListaCampaña)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnHistorialLlamado)
        Me.Controls.Add(Me.btnReferidos)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnIngreso)
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnIngreso As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnReferidos As Button
    Friend WithEvents btnHistorialLlamado As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbListaCampaña As ComboBox
End Class
