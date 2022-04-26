Imports System.Data.SqlClient
Imports System.IO

Public Class frmHistorialLlamado

    Dim cnn As New SqlConnection("data source = 192.168.1.14; initial catalog = BASE_GENERAL_CORDIAL; User id= cp; password=Cordial.passs")


    Private Sub frmAsociarGrabacion_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtId.Text = ""
        dtgGrabaciones.DataSource = Nothing
        dtgHistorial.DataSource = Nothing
        dtgLogGestion.DataSource = Nothing
    End Sub

    Private Sub listarAudiosAsociados(ByVal id As Integer, ByVal crm As String)
        Dim tabla As New DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim Simbolo As String = ""
        Dim sql As String = ""


        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "[Config].[pa_HistorialGrabaciones]"
            cmd.Parameters.AddWithValue("@C_ID", id)
            cmd.Parameters.AddWithValue("@codigoCampana", crm)

            cmd.CommandText = sql
            cmd.Connection = cnn
            da = New SqlDataAdapter(cmd)
            da.Fill(tabla)

            If tabla.Rows.Count <= 0 Then
                MsgBox("No existen datos de grabaciones para mostrar", vbInformation, "")
            Else
                dtgGrabaciones.DataSource = tabla
                dtgGrabaciones.RowHeadersWidth = 60

                dtgGrabaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                For i As Integer = 0 To dtgGrabaciones.Rows.Count - 1
                    If dtgGrabaciones.Rows(i).Cells(10).Value = "SI" Then
                        dtgGrabaciones.Rows(i).DefaultCellStyle.BackColor = Color.Green
                        dtgGrabaciones.Rows(i).DefaultCellStyle.ForeColor = Color.White
                    End If
                Next
            End If



        Catch ex As Exception
            MsgBox("Error Listar Grabaciones Por Id" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub dtgGrabaciones_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgGrabaciones.CellMouseMove
        If e.ColumnIndex = 0 Then
            Me.Cursor = Cursors.Hand
        Else
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub dtgGrabaciones_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgGrabaciones.CellContentDoubleClick
        If e.ColumnIndex = 0 Then
            If (MsgBox("¿Desea asociar este audio como el audio de Venta?", vbYesNo, "Asociar Grabacion")) = vbYes Then
                actualizarGrabacion(txtId.Text, dtgGrabaciones.Rows(e.RowIndex).Cells(3).Value, idCrm)
            End If
        ElseIf e.ColumnIndex = 1 Then
            escuchaGrabacion(txtId.Text, dtgGrabaciones.Rows(e.RowIndex).Cells(3).Value, idCrm, dtgGrabaciones.Rows(e.RowIndex).Cells(5).Value, dtgGrabaciones.Rows(e.RowIndex).Cells(11).Value)
        End If
    End Sub

    Private Sub escuchaGrabacion(ByVal id As Integer, ByVal _idLlamada As String, ByVal _idCRM As String, ByVal fecha As String, ByVal nombreGrabacion As String)
        Dim dia As String
        Dim Mes As String
        Dim anio As String
        Dim rutaOrigen As String
        Dim crm As Integer

        dia = Mid(fecha, 1, 2)
        Mes = Mid(fecha, 4, 2)
        anio = Mid(fecha, 7, 4)

        Dim nomFinalcrm As String = ""
        nomFinalcrm = Microsoft.VisualBasic.Right("00" + _idCRM.ToString, 3).ToString

        ''Se obtienen las rutas en donde estén depositadas las grabaciones
        Dim cantidad As Int16 = 0
        Dim tablaGrabaciones As New DataTable
        Dim grabaciones As New clsGrabaciones
        tablaGrabaciones = grabaciones.obtieneRutasGrabaciones()

        Dim grabacion As String = ""
        For Each row As DataRow In tablaGrabaciones.Rows
            Try
                rutaOrigen = row("rutaGrabaciones")
                rutaOrigen = rutaOrigen.Replace("[crm]", nomFinalcrm)
                rutaOrigen = rutaOrigen.Replace("[anio]", anio)
                rutaOrigen = rutaOrigen.Replace("[mes]", Mes)
                rutaOrigen = rutaOrigen.Replace("[dia]", dia)

                Dim di As New IO.DirectoryInfo(rutaOrigen)
                Dim idLlamadaAux As Int64 = Mid(_idLlamada, 2, _idLlamada.Length)
                Dim aryFi As IO.FileInfo() = di.GetFiles("*" + idLlamadaAux.ToString + "*")
                rutaOrigen = rutaOrigen + "\" + aryFi(0).ToString()
                cantidad = 0

                If File.Exists(rutaOrigen) Then
                    grabacion = rutaOrigen
                End If

                crm = nomFinalcrm

                Process.Start(grabacion)
                Exit For

            Catch ex As Exception
                cantidad += 1
                If cantidad = tablaGrabaciones.Rows.Count Then
                    MsgBox("No existe grabacion para este llamado.", vbExclamation, "CALIDAD")
                End If
            End Try
        Next
    End Sub

    Private Sub actualizarGrabacion(ByVal id As Integer, ByVal idLlamada As String, ByVal idCRM As String)
        Dim tabla As New DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim Simbolo As String = ""
        Dim sql As String = ""



        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "[Config].[pa_AsociarGrabacion]"
            cmd.Parameters.AddWithValue("@C_ID", id)
            cmd.Parameters.AddWithValue("@IdLlamada", idLlamada)
            cmd.Parameters.AddWithValue("@codigoCampana", idCRM)

            cmd.CommandText = sql
            cmd.Connection = cnn
            da = New SqlDataAdapter(cmd)
            da.Fill(tabla)

            MsgBox("Grabacion asociada correctamente", vbInformation, "Actualización Correcta")
            listarAudiosAsociados(id, idCRM)

        Catch ex As Exception
            MsgBox("Error Asociar Grabacion" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        dtgGrabaciones.DataSource = Nothing
        dtgLogGestion.DataSource = Nothing
        dtgHistorial.DataSource = Nothing
        listarHistorialLlamado(txtId.Text, idCrm)
        listarHistorialLogGestion(txtId.Text, idCrm)
        listarAudiosAsociados(txtId.Text, idCrm)
    End Sub

    Private Sub listarHistorialLlamado(ByVal id As Integer, ByVal crm As String)
        Dim tabla As New DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim Simbolo As String = ""
        Dim sql As String = ""


        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "[Config].[pa_HistorialGestion]"
            cmd.Parameters.AddWithValue("@C_ID", id)
            cmd.Parameters.AddWithValue("@codigoCampana", crm)

            cmd.CommandText = sql
            cmd.Connection = cnn
            da = New SqlDataAdapter(cmd)
            da.Fill(tabla)

            If tabla.Rows.Count > 0 Then
                dtgHistorial.DataSource = tabla
                dtgHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            End If


        Catch ex As Exception
            MsgBox("Error Listar Gestiones Por Id" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub listarHistorialLogGestion(ByVal id As Integer, ByVal crm As String)
        Dim tabla As New DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim Simbolo As String = ""
        Dim sql As String = ""

        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "[Config].[pa_HistorialLogGestion]"
            cmd.Parameters.AddWithValue("@C_ID", id)
            cmd.Parameters.AddWithValue("@codigoCampana", crm)

            cmd.CommandText = sql
            cmd.Connection = cnn
            da = New SqlDataAdapter(cmd)
            da.Fill(tabla)

            If tabla.Rows.Count > 0 Then
                dtgLogGestion.DataSource = tabla
                dtgLogGestion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            End If


        Catch ex As Exception
            MsgBox("Error Listar LogGestion Por Id" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class