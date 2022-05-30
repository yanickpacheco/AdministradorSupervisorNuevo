Imports System.Data.SqlClient

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
            Case "PABLO CASTILLO", "MAURICIO GOMEZ", "SUSANA COLLAO", "YANETT MUÑOZ", "MATIAS CARRERA", "PAULA ARAOS", "ANA RODRIGUEZ", "CRISTIAN ANACONA", "DAMARIS MARIN", "ROSSINI VALDIVIA", "FELIPE DIAZ"
                btnRecicladoBase.Visible = True
                btnLiberarBloqueados.Visible = True
                If nombreSupervisor = "YANETT MUÑOZ" Or nombreSupervisor = "PAULA ARAOS" Or nombreSupervisor = "ROSSINI VALDIVIA" Then
                    btnMandato.Visible = True
                End If
            Case Else
                btnRecicladoBase.Visible = False
                btnLiberarBloqueados.Visible = False
        End Select
    End Sub

    Private Sub btnMandato_Click(sender As Object, e As EventArgs) Handles btnMandato.Click
        Dim Tabla As New DataTable
        Dim dA As SqlDataAdapter
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.StoredProcedure
        Dim cnn As New SqlConnection("data source = 192.168.1.14; initial catalog = VENTAS; User id= cp; password=Cordial.passs ")
        Try
            cmd.CommandText = "[Clinicas].[pa_TraspasoVentasMandato]"
            cmd.Connection = cnn
            dA = New SqlDataAdapter(cmd)
            dA.Fill(Tabla)

            If Tabla.Rows.Count <= 0 Then
                MsgBox("No hay registros para traspasar", vbInformation, "")
            Else
                MsgBox("Se traspasaron " + Tabla.Rows(0)("TotalRegistros").ToString() + " registros.", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox("Error al traspasar registros" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")

        End Try
    End Sub
End Class