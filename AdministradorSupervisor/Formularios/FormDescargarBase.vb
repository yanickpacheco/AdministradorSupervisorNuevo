Imports System.Data.SqlClient

Public Class FormDescargarBase
    Dim cnn As New SqlConnection("data source = 192.168.1.14; initial catalog = BASE_GENERAL_CORDIAL; User id= cp; password=Cordial.passs ")

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Muestra_Base(cmbPeriodo.SelectedItem)
    End Sub

    Private Sub Muestra_Base(ByVal periodo As String)
        Dim miTabla As New DataTable
        Dim dA As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim sql As String = ""
        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "Gestion.pa_MuestraBaseResultante"
            cmd.CommandText = sql
            cmd.Parameters.AddWithValue("@idCrm", idCrm)
            cmd.Parameters.AddWithValue("@periodo", periodo)
            cmd.Connection = cnn
            dA = New SqlDataAdapter(cmd)
            dA.Fill(miTabla)

            dtgMuestraBase.DataSource = miTabla


        Catch ex As Exception
            MsgBox("Error Listar Ejecutivos" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
End Class