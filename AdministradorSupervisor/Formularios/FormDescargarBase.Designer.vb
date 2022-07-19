<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDescargarBase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDescargarBase))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbPeriodo = New System.Windows.Forms.ComboBox()
        Me.dtgMuestraBase = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnCarpeta = New System.Windows.Forms.Button()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        CType(Me.dtgMuestraBase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Elija periodo a descargar :"
        '
        'cmbPeriodo
        '
        Me.cmbPeriodo.FormattingEnabled = True
        Me.cmbPeriodo.Items.AddRange(New Object() {"202201", "202202", "202203", "202204", "202205", "202206", "202207"})
        Me.cmbPeriodo.Location = New System.Drawing.Point(375, 46)
        Me.cmbPeriodo.Name = "cmbPeriodo"
        Me.cmbPeriodo.Size = New System.Drawing.Size(121, 21)
        Me.cmbPeriodo.TabIndex = 1
        '
        'dtgMuestraBase
        '
        Me.dtgMuestraBase.AllowUserToAddRows = False
        Me.dtgMuestraBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgMuestraBase.Location = New System.Drawing.Point(44, 93)
        Me.dtgMuestraBase.Name = "dtgMuestraBase"
        Me.dtgMuestraBase.RowHeadersWidth = 51
        Me.dtgMuestraBase.Size = New System.Drawing.Size(1239, 320)
        Me.dtgMuestraBase.TabIndex = 2
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(592, 40)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(93, 32)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Location = New System.Drawing.Point(1149, 420)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(118, 53)
        Me.btnExportar.TabIndex = 4
        Me.btnExportar.Text = "Descargar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnCarpeta
        '
        Me.btnCarpeta.Image = CType(resources.GetObject("btnCarpeta.Image"), System.Drawing.Image)
        Me.btnCarpeta.Location = New System.Drawing.Point(44, 420)
        Me.btnCarpeta.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCarpeta.Name = "btnCarpeta"
        Me.btnCarpeta.Size = New System.Drawing.Size(147, 53)
        Me.btnCarpeta.TabIndex = 32
        Me.btnCarpeta.Text = "Seleccionar Carpeta"
        Me.btnCarpeta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCarpeta.UseVisualStyleBackColor = True
        '
        'txtRuta
        '
        Me.txtRuta.Location = New System.Drawing.Point(199, 437)
        Me.txtRuta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Size = New System.Drawing.Size(919, 20)
        Me.txtRuta.TabIndex = 33
        '
        'FormDescargarBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1334, 528)
        Me.Controls.Add(Me.txtRuta)
        Me.Controls.Add(Me.btnCarpeta)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.dtgMuestraBase)
        Me.Controls.Add(Me.cmbPeriodo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormDescargarBase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DescargarBase"
        CType(Me.dtgMuestraBase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbPeriodo As ComboBox
    Friend WithEvents dtgMuestraBase As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnExportar As Button
    Friend WithEvents btnCarpeta As Button
    Friend WithEvents txtRuta As TextBox
End Class
