Imports System.Data.SqlClient

Public Class clsGrabaciones
    Dim cnn As New SqlConnection("data source = 192.168.1.14; initial catalog = BASE_GENERAL_CORDIAL; User id= cp; password=Cordial.passs ")

    Public Function obtieneRutasGrabaciones() As DataTable
        Dim miTabla As New DataTable
        Dim dA As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim sql As String = ""
        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "Entidad.pa_ObtieneRutasGrabaciones"
            cmd.CommandText = sql
            cmd.Connection = cnn
            dA = New SqlDataAdapter(cmd)
            dA.Fill(miTabla)

        Catch ex As Exception
            MsgBox("Error Listar Campañas" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Return miTabla
    End Function
End Class
