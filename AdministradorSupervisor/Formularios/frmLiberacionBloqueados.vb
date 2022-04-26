Imports System.Data.SqlClient


Public Class frmLiberacionBloqueados
    Dim cnn As New SqlConnection("data source = 192.168.1.14; initial catalog = BASE_GENERAL_CORDIAL; User id= cp; password=Cordial.passs")


    Private Sub frmLiberacionBloqueados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListaTipoBloqueo(cmbTipoBloqueo)
        LimpiaControles()

    End Sub

    Private Sub limpiaControles()

        dtgRegistros.DataSource = Nothing
        chkEjecutivos.Checked = False
        chkListEjecutivos.DataSource = Nothing
        chkSeleccionarTodos.Checked = False
        txtCantidad.Text = ""
        lblTotalRegistros.Text = ""
    End Sub

    Private Sub ListaTipoBloqueo(combo As ComboBox)
        Dim miTabla As New DataTable
        Dim dA As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim sql As String = ""
        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "Config.[pa_ListarBloqueados]"
            cmd.CommandText = sql
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idCrm", idCrm)
            dA = New SqlDataAdapter(cmd)
            dA.Fill(miTabla)

            combo.DataSource = miTabla
            combo.DisplayMember = "NOMBRE"
            combo.ValueMember = "MARCABLOQUEO"
            combo.SelectedIndex = -1

        Catch ex As Exception

            MsgBox("Error Listar tipo de bloqueo" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")

        End Try
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        ListarRegistros(cmbTipoBloqueo.SelectedValue)
    End Sub

    Private Sub ListarRegistros(bloq As String)
        Dim tabla As New DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim Simbolo As String = ""
        Dim sql As String = ""



        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "Config.pa_ListarRegistrosBloqueados"
            cmd.Parameters.AddWithValue("@idCrm", idCrm)
            cmd.Parameters.AddWithValue("@NombreBloqueo", bloq)

            cmd.CommandText = sql
            cmd.Connection = cnn
            da = New SqlDataAdapter(cmd)
            da.Fill(tabla)

            If tabla.Rows.Count <= 0 Then
                MsgBox("No existen datos de cliente para mostrar", vbInformation, "")
            Else
                dtgRegistros.DataSource = tabla
            End If

            lblTotalRegistros.Text = "Total: " + tabla.Rows.Count.ToString + " registros"

        Catch ex As Exception
            MsgBox("Error Listar Ventas a Evaluar" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub chkSeleccionarTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeleccionarTodos.CheckedChanged
        If chkSeleccionarTodos.Checked = True Then

            For i As Integer = 0 To dtgRegistros.Rows.Count - 1

                dtgRegistros.Rows(i).Cells(0).Value = True

            Next

        Else
            For i As Integer = 0 To dtgRegistros.Rows.Count - 1

                dtgRegistros.Rows(i).Cells(0).Value = False

            Next
        End If
    End Sub

    Private Sub btnMarcar_Click(sender As Object, e As EventArgs) Handles btnMarcar.Click
        MarcarRegistros(txtCantidad.Text)
    End Sub

    Private Sub MarcarRegistros(text As String)
        Dim num As Integer

        For i As Integer = 0 To dtgRegistros.Rows.Count - 1
            dtgRegistros.Rows(i).Cells(0).Value = False
        Next

        num = Val(text)

        For i As Integer = 0 To num - 1
            dtgRegistros.Rows(i).Cells(0).Value = True
        Next
    End Sub

    Private Sub btnLiberar_Click(sender As Object, e As EventArgs) Handles btnLiberar.Click
        Dim marcaBloqueo As String = ""
        Dim strIDs As String = ""
        Dim strEjecutivos As String = ""

        If dtgRegistros.Rows.Count <= 0 Then Exit Sub

        marcaBloqueo = cmbTipoBloqueo.SelectedValue

        If chkSeleccionarTodos.Checked = True Then

            marcaBloqueo = cmbTipoBloqueo.SelectedValue

        Else
            For Each row As DataGridViewRow In dtgRegistros.Rows
                If row.Cells("chkSeleccionar").Value Then

                    If Not String.IsNullOrEmpty(strIDs) Then
                        strIDs += ","
                    End If
                    strIDs += row.Cells("ID").Value.ToString
                End If

            Next

            If strIDs = "" Then
                MsgBox("Debe seleccionar registros a liberar", vbInformation, "Informacion")
                dtgRegistros.Focus()
                Exit Sub
            End If

        End If



        If chkEjecutivos.Checked = True Then

            If chkListEjecutivos.CheckedItems.Count = 0 Then
                MsgBox("Debe seleccionar ejecutivos a asignar con la opcion de Asignar Ejecutivos", vbExclamation, "Informacion")
                chkListEjecutivos.Focus()
                Exit Sub
            End If

            Dim primero As Boolean = False
            For i As Integer = 0 To chkListEjecutivos.Items.Count - 1
                If (chkListEjecutivos.GetItemChecked(i)) Then

                    If Not String.IsNullOrEmpty(strEjecutivos) Then
                        strEjecutivos += ","
                    End If
                    strEjecutivos += "'" + chkListEjecutivos.Items(i).ToString + "'"
                End If
            Next

        End If

        LiberarBloqueados(marcaBloqueo, strIDs, strEjecutivos)


    End Sub


    Private Sub LiberarBloqueados(ByVal marcaBloqueo As String, ByVal strIDs As String, ByVal strEjecutivos As String)
        Dim tabla As New DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim myTransaction As SqlTransaction
        Dim Bitacora As New clsBitacora
        Dim Especificacion As String
        Dim Simbolo As String = ""
        Dim sql As String = ""



        Try

            cmd.CommandType = CommandType.StoredProcedure



            sql = "Config.pa_LiberarBloqueados"
            cmd.Parameters.AddWithValue("@idCrm", idCrm)
            cmd.Parameters.AddWithValue("@marcaBloqueo", marcaBloqueo)
            cmd.Parameters.AddWithValue("@ids_clientes", strIDs)
            cmd.Parameters.AddWithValue("@ejecutivos", strEjecutivos)


            cnn.Open()
            cmd.CommandText = sql
            cmd.Connection = cnn
            da = New SqlDataAdapter(cmd)
            da.Fill(tabla)
            cmd.ExecuteNonQuery()

            'myTransaction.Commit()

            MsgBox("Resgistros liberados")

            Especificacion = "Liberacion Bloqueados: " & marcaBloqueo & "," & strEjecutivos & ""

            Bitacora.IdCRM = idCrm
            Bitacora.Detalle = Especificacion
            Bitacora.Total = 0
            Bitacora.Supervisor = nombreSupervisor
            'cmd.ExecuteNonQuery()
            IngresaBitacora(Bitacora)

            limpiaControles()
            ListarRegistros(cmbTipoBloqueo.SelectedValue)

        Catch ex As Exception
            ' myTransaction.Rollback()
            MsgBox("Error al liberar registros" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Me.Cursor = Cursors.Default
        Finally
            cnn.Close()



        End Try
    End Sub



    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub chkEjecutivos_CheckedChanged(sender As Object, e As EventArgs) Handles chkEjecutivos.CheckedChanged
        If chkEjecutivos.Checked = True Then
            chkListEjecutivos.Visible = True
            chkListEjecutivos.Items.Clear()
            ListaEjecutivo()
        Else
            chkListEjecutivos.Visible = False
        End If
    End Sub



    Private Sub ListaEjecutivo()
        Dim miTabla As New DataTable
        Dim dA As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim sql As String = ""
        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "[Gestion].[pa_ListaAgentesCampana]"

            cmd.CommandText = sql
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idCrm", idCrm)
            dA = New SqlDataAdapter(cmd)
            dA.Fill(miTabla)

            Dim lstEjecutivos As New List(Of clsEjecutivo)

            For x As Integer = 0 To miTabla.Rows.Count - 1
                Dim row As New clsEjecutivo

                row.Ejecutivo = IIf(IsDBNull(miTabla.Rows(x)("Descripcion")), Nothing, miTabla.Rows(x)("Descripcion"))
                lstEjecutivos.Add(row)
            Next

            For i As Integer = 0 To lstEjecutivos.Count - 1
                chkListEjecutivos.Items.Add(lstEjecutivos.Item(i).Ejecutivo)
            Next



        Catch ex As Exception

            MsgBox("Error Listar Ejecutivos" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")

        End Try
    End Sub

End Class