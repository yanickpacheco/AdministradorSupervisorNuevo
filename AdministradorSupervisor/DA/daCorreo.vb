Imports System.Data.SqlClient

Public Class daCorreo

    Dim cnn As New SqlConnection("data source = 192.168.1.14; initial catalog = VENTAS; User Id= cp; Password=Cordial.passs")

    Public Function datosCorreo(_idDestinatario As Int64) As eCorreo
        Dim sql As String
        Dim da As SqlDataAdapter
        Dim dt As DataTable
        Dim cmd As New SqlCommand
        Dim row As New eCorreo

        cmd.CommandType = CommandType.StoredProcedure

        sql = "ETL.pa_obtieneDatosCorreo"
        cmd.Parameters.AddWithValue("@idDestinatario", _idDestinatario)

        cmd.CommandText = sql
        cmd.Connection = cnn
        da = New SqlDataAdapter(cmd)
        dt = New DataTable()
        da.Fill(dt)

        For x As Integer = 0 To dt.Rows.Count - 1
            row.idDestinatarioCorreo = IIf(IsDBNull(dt.Rows(x)("idDestinatarioCorreo")), Nothing, dt.Rows(x)("idDestinatarioCorreo"))
            row.para = IIf(IsDBNull(dt.Rows(x)("para")), Nothing, dt.Rows(x)("para"))
            row.conCopia = IIf(IsDBNull(dt.Rows(x)("conCopia")), Nothing, dt.Rows(x)("conCopia"))
            row.conCopiaOculta = IIf(IsDBNull(dt.Rows(x)("conCopiaOculta")), Nothing, dt.Rows(x)("conCopiaOculta"))
            row.asunto = IIf(IsDBNull(dt.Rows(x)("asunto")), Nothing, dt.Rows(x)("asunto"))
            row.Cuerpo = IIf(IsDBNull(dt.Rows(x)("Cuerpo")), Nothing, dt.Rows(x)("Cuerpo"))
            row.direccionCorreo = IIf(IsDBNull(dt.Rows(x)("direccionCorreo")), Nothing, dt.Rows(x)("direccionCorreo"))
            row.usuarioCorreo = IIf(IsDBNull(dt.Rows(x)("usuarioCorreo")), Nothing, dt.Rows(x)("usuarioCorreo"))
            row.contraseñaCorreo = IIf(IsDBNull(dt.Rows(x)("contraseñaCorreo")), Nothing, dt.Rows(x)("contraseñaCorreo"))
            row.host = IIf(IsDBNull(dt.Rows(x)("host")), Nothing, dt.Rows(x)("host"))
            row.puerto = IIf(IsDBNull(dt.Rows(x)("puerto")), Nothing, dt.Rows(x)("puerto"))
            row.ValorSSL = IIf(IsDBNull(dt.Rows(x)("ValorSSL")), Nothing, dt.Rows(x)("ValorSSL"))
        Next

        Return row

    End Function



End Class
