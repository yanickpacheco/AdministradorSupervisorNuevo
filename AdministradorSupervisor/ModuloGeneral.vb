Imports System.Data.SqlClient
Imports System.Net

Module ModuloGeneral
    Public idCrm As Integer
    Public nombreSupervisor As String
    Public idSupervisor As Int32

    Dim cnn As New SqlConnection("data source = 192.168.1.14; initial catalog = BASE_GENERAL_CORDIAL; User id= cp; password=Cordial.passs ")
    ' Public usuario As String
    ' Public perfil As ComboBox
    ' Public asignados As Integer


    Public Sub IngresaBitacora(ByVal bitacora As clsBitacora)

        Dim cmd As New SqlCommand
        Dim sql As String
        Dim myTransaction As SqlTransaction
        Dim miTabla As New DataTable
        Dim dA As SqlDataAdapter

        'cnn.Open()
        cmd.CommandType = CommandType.StoredProcedure

        sql = "[Config].[pa_IngresaBitacora]"

        Try


            cmd.Parameters.AddWithValue("@idCRM", bitacora.IdCRM)
            cmd.Parameters.AddWithValue("@detalle", bitacora.Detalle)
            cmd.Parameters.AddWithValue("@total", bitacora.Total)
            cmd.Parameters.AddWithValue("@supervisor", bitacora.Supervisor)
            cmd.CommandText = sql
            cmd.Connection = cnn
            dA = New SqlDataAdapter(cmd)
            dA.Fill(miTabla)


        Catch ex As Exception
            MsgBox("Error en ingreso de Bitacora" & vbNewLine & ex.Message, vbExclamation, "Informacion")
        End Try

    End Sub

End Module
