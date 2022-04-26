Public Class FormAdministracionRegistros
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLiberacionRegistros.Click
        LiberacionRegistros.ShowDialog()
    End Sub

    Private Sub btnIngresarDatos_Click(sender As Object, e As EventArgs) Handles btnLiberarBloqueados.Click
        frmLiberacionBloqueados.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnRecicladoBase.Click
        FrmLiberaTerminados.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBuscarRut.Click
        frmBuscarRut.ShowDialog()
    End Sub

    Private Sub FormAdministracionRegistros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case nombreSupervisor
            Case "PABLO CASTILLO", "MAURICIO GOMEZ", "SUSANA COLLAO", "YANETT MUÑOZ", "MATIAS CARRERA", "PAULA ARAOS"
                btnRecicladoBase.Visible = True
                btnLiberarBloqueados.Visible = True
            Case Else
                btnRecicladoBase.Visible = False
                btnLiberarBloqueados.Visible = False
        End Select
    End Sub
End Class