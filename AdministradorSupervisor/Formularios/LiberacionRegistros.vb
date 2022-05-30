Imports System.Data.SqlClient

Public Class LiberacionRegistros
    Dim cnn As New SqlConnection("data source = 192.168.1.14; initial catalog = BASE_GENERAL_CORDIAL; User id= cp; password=Cordial.passs ")
    'Dim cnn As New SqlConnection("data source = 152.231.73.174; initial catalog = BASE_GENERAL_CORDIAL; User id= yp; password=Cordial.passs ")
    Private Sub btnBuscarID_Click(sender As Object, e As EventArgs) Handles btnBuscarID.Click
        MostrarAgendados(txtId.Text)
    End Sub

    Private Sub listaEjecutivos(ByVal combo As ComboBox)
        Dim miTabla As New DataTable
        Dim dA As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim sql As String = ""
        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "[Gestion].[pa_ListaEjecutivosPorCRM]"
            cmd.Parameters.AddWithValue("@idCrm", idCrm)
            cmd.CommandText = sql
            cmd.Connection = cnn
            dA = New SqlDataAdapter(cmd)
            dA.Fill(miTabla)

            combo.DataSource = miTabla
            combo.DisplayMember = "Ejecutivo"
            combo.ValueMember = "Ejecutivo"
            combo.SelectedIndex = -1

        Catch ex As Exception

            MsgBox("Error Listar Ejecutivos" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")

        End Try


    End Sub

    Private Sub MostrarAgendados(ByVal Id As String)
        Dim miTabla As New DataTable
        Dim dA As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim sql As String = ""
        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "[Config].[MostrarRegistrosAgendados]"
            cmd.CommandText = sql
            cmd.Parameters.AddWithValue("@idCrm", idCrm)
            cmd.Parameters.AddWithValue("@c_id", Id)
            cmd.Connection = cnn
            dA = New SqlDataAdapter(cmd)
            dA.Fill(miTabla)

            dtgRegistros.DataSource = miTabla

            dtgRegistros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        Catch ex As Exception
            MsgBox("Error Mostrar registros" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub LiberarRegistros(ByVal fecha As String, ByVal hora As String, ByVal id As Integer)
        Dim cmd As New SqlCommand
        Dim sql As String
        Dim myTransaction As SqlTransaction
        Dim Bitacora As New clsBitacora
        Dim Especificacion As String

        cnn.Open()
        myTransaction = cnn.BeginTransaction()
        cmd.CommandType = CommandType.StoredProcedure

        sql = "[Config].[LiberarRegistros]"
        cmd.Parameters.AddWithValue("@fecha", fecha)
        cmd.Parameters.AddWithValue("@hora", hora)
        cmd.Parameters.AddWithValue("@idCrm", idCrm)
        cmd.Parameters.AddWithValue("@c_id", id)
        'cmd.Parameters.AddWithValue("@estado", estado)
        Try
            cmd.CommandText = sql
            cmd.Connection = cnn
            cmd.Transaction = myTransaction

            cmd.ExecuteNonQuery()
            myTransaction.Commit()
            MsgBox("Registro Liberado Correctamente", vbInformation, "Liberacion OK")

            Especificacion = "Liberacion Registro: Id:" & id & ", Campaña: " & idCrm & ""

            Bitacora.IdCRM = idCrm
            Bitacora.Detalle = Especificacion
            Bitacora.Total = 0
            Bitacora.Supervisor = nombreSupervisor
            'cmd.ExecuteNonQuery()
            IngresaBitacora(Bitacora)


        Catch ex As Exception
            myTransaction.Rollback()
            MsgBox("Error Liberar registro: " & ex.Message, vbInformation)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub btnLiberar_Click(sender As Object, e As EventArgs) Handles btnLiberar.Click


        If cmbHora.SelectedIndex < 0 Then
            MsgBox("Debe ingresar Hora de Agendamiento", vbExclamation, "Liberacion")
            cmbHora.Focus()
            Exit Sub
        End If

        If cmbMinutos.SelectedIndex < 0 Then
            MsgBox("Debe ingresar Minutos de Agendamiento", vbExclamation, "Liberacion")
            cmbMinutos.Focus()
            Exit Sub
        End If

        If chkObs.Checked = True Then
            If txtObs.Text.Trim = "" Then
                MsgBox("Debe ingresar Observacion a modificar", vbExclamation, "Liberacion")
                txtObs.Focus()
                Exit Sub
            End If
        ElseIf chkFono.Checked = True Then
            If txtFono.Text.Trim = "" Then
                MsgBox("Debe ingresar Telefono a llamar", vbExclamation, "Liberacion")
                txtFono.Focus()
                Exit Sub
            ElseIf txtFono.Text.Length < 8 Then
                MsgBox("Debe ingresar un número de 8 dígitos")
                txtFono.Focus()
                Exit Sub
            End If
        ElseIf chkOtroEjecutivo.Checked = True Then
            If cmbEjecutivo.SelectedIndex < 0 Then
                MsgBox("Debe ingresar Ejecutivo nuevo", vbExclamation, "Liberacion")
                cmbEjecutivo.Focus()
                Exit Sub
            End If
        End If

        LiberarRegistros(dtpFecha.Value.ToString("yyyyMMdd"), cmbHora.Text + cmbMinutos.Text, txtId.Text)
        If chkObs.Checked = True Then
            ModificaObservacion(txtObs.Text, txtId.Text)
        End If
        If chkFono.Checked = True Then
            AgregarFono(txtFono.Text, txtId.Text)
        End If
        If chkOtroEjecutivo.Checked = True Then
            ModificaEjecutivo(cmbEjecutivo.Text, txtId.Text)
        End If
        MostrarAgendados(txtId.Text)
        dtpFecha.ResetText()
        limpiarFormulario()
    End Sub


    Private Sub chkObs_CheckedChanged(sender As Object, e As EventArgs) Handles chkObs.CheckedChanged
        If chkObs.Checked = True And txtId.Text IsNot "" Then
            gpbObservacion.Visible = True
        Else
            gpbObservacion.Visible = False
        End If
    End Sub

    Private Sub ModificaObservacion(ByVal texto As String, ByVal id As Integer)
        Dim cmd As New SqlCommand
        Dim sql As String
        Dim myTransaction As SqlTransaction

        cnn.Open()
        myTransaction = cnn.BeginTransaction()
        cmd.CommandType = CommandType.StoredProcedure

        sql = "[Config].[ModificaObservacion]"
        cmd.Parameters.AddWithValue("@texto", texto)
        cmd.Parameters.AddWithValue("@idCrm", idCrm)
        cmd.Parameters.AddWithValue("@c_id", id)
        Try
            cmd.CommandText = sql
            cmd.Connection = cnn
            cmd.Transaction = myTransaction

            cmd.ExecuteNonQuery()
            myTransaction.Commit()
        Catch ex As Exception
            myTransaction.Rollback()
            MsgBox("Error en modificar la observación: " & ex.Message, vbInformation)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub ModificaEjecutivo(ByVal ejecutivo As String, ByVal id As Integer)
        Dim cmd As New SqlCommand
        Dim sql As String
        Dim myTransaction As SqlTransaction

        cnn.Open()
        myTransaction = cnn.BeginTransaction()
        cmd.CommandType = CommandType.StoredProcedure

        sql = "[Config].[ModificaEjecutivo]"
        cmd.Parameters.AddWithValue("@Ejecutivo", ejecutivo)
        cmd.Parameters.AddWithValue("@idCrm", idCrm)
        cmd.Parameters.AddWithValue("@c_id", id)
        Try
            cmd.CommandText = sql
            cmd.Connection = cnn
            cmd.Transaction = myTransaction

            cmd.ExecuteNonQuery()
            myTransaction.Commit()
            'If chkObs.Checked = False And txtObs.Text IsNot "" Then
            '    MsgBox("Seguro que desea modificar la Observación?", vbYesNo, "Modificar")
            'End If
        Catch ex As Exception
            myTransaction.Rollback()
            MsgBox("Error en modificar la observación: " & ex.Message, vbInformation)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkFono.CheckedChanged
        If chkFono.Checked = True And txtId.Text IsNot "" Then
            gpbFonoAlternativo.Visible = True
        Else
            gpbFonoAlternativo.Visible = False
        End If
    End Sub

    Private Sub AgregarFono(ByVal fono As String, ByVal id As Integer)
        Dim cmd As New SqlCommand
        Dim sql As String
        Dim myTransaction As SqlTransaction

        cnn.Open()
        myTransaction = cnn.BeginTransaction()
        cmd.CommandType = CommandType.StoredProcedure

        sql = "[Config].[AgregarNuevoTelefono]"
        cmd.Parameters.AddWithValue("@fono", fono)
        cmd.Parameters.AddWithValue("@idCrm", idCrm)
        cmd.Parameters.AddWithValue("@c_id", id)
        Try
            cmd.CommandText = sql
            cmd.Connection = cnn
            cmd.Transaction = myTransaction

            cmd.ExecuteNonQuery()
            myTransaction.Commit()
            'If chkFono.Checked = False And txtFono.Text IsNot "" Then
            '    MsgBox("Seguro que desea ingresar nuevo teléfono?", vbYesNo, "Ingresar nuevo fono")
            'End If
        Catch ex As Exception
            myTransaction.Rollback()
            MsgBox("Error en ingresar nuevo teléfono: " & ex.Message, vbInformation)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub txtFono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFono.KeyPress
        If Not (IsNumeric(e.KeyChar)) Then
            If (e.KeyChar <> vbBack) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub chkOtroEjecutivo_CheckedChanged(sender As Object, e As EventArgs) Handles chkOtroEjecutivo.CheckedChanged
        If chkOtroEjecutivo.Checked = True And txtId.Text.Trim IsNot "" Then
            gpbEjecutivo.Visible = True
        Else
            gpbEjecutivo.Visible = False
        End If
    End Sub

    Private Sub LiberacionRegistros_Load(sender As Object, e As EventArgs) Handles Me.Load

        listaEjecutivosAgenda(cmbEjecutivo)
        limpiarFormulario()
        limpiaControles()
        listaEjecutivos(cmbEjecutivoAgenda)

        Select Case nombreSupervisor
            Case "PABLO CASTILLO", "MAURICIO GOMEZ", "SUSANA COLLAO", "YANETT MUÑOZ", "PAULA ARAOS", "DYLAN RODRIGUEZ", "EDINSSON MALDONADO", "ANA RODRIGUEZ", "CRISTIAN ANACONA", "DAMARIS MARIN", "ROSSINI VALDIVIA", "FELIPE DIAZ"
                rdbPorEjecutivo.Visible = True
            Case Else
                rdbPorEjecutivo.Visible = False
        End Select
        '  rdbPorEjecutivo.Checked = False
        '  rdbPorID.Checked = True

        Dim i As Integer
        i = TabControl1.TabCount - 1
        For i = i To 1 Step -1
            TabControl1.TabPages.Item(i).Parent = Nothing
        Next i
        If TabControl1.TabPages.Item(0).Name <> "tbpLiberacionPorId" Then
            TabControl1.TabPages.Item(0).Parent = Nothing
            TabControl1.TabPages.Add(tbpLiberacionPorId)
        End If

    End Sub

    Private Sub limpiarFormulario()
        chkFono.Checked = False
        chkObs.Checked = False
        chkOtroEjecutivo.Checked = False
        gpbEjecutivo.Visible = False
        gpbObservacion.Visible = False
        gpbFonoAlternativo.Visible = False
        cmbEjecutivo.SelectedIndex = -1
        txtObs.Text = ""
        txtFono.Text = ""
        cmbHora.SelectedIndex = -1
        cmbMinutos.SelectedIndex = -1
        cmbFlujoContacto.SelectedIndex = 0
        txtId.Text = ""
        dtgRegistros.DataSource = Nothing
    End Sub



    Private Sub limpiaControles()

        'dtgAgendados.DataSource = Nothing
        chkSeleccionarTodos.Checked = False
        lblTotalRegistros.Text = ""
        gpbSeleccion.Visible = False
        rdbLiberarOtroEjecutivo.Checked = False
        rdbMismoEjecutivo.Checked = False
        rdbBloquearCarterizar.Checked = False
        chkSinIntentos.Checked = False
        chkObservaciones.Checked = False
        cmbOtroEjecutivo.Visible = False
        cmbOtroEjecutivo.SelectedIndex = -1
    End Sub

    ' PROCEDIMIENTOS DE FORMULARIO LIBERAR POR EJECUTIVO

    Private Sub listaEjecutivosAgenda(combo As ComboBox)
        Dim miTabla As New DataTable
        Dim dA As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim sql As String = ""
        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "[Gestion].[pa_ListaEjecutivosPorCRM]"
            cmd.CommandText = sql
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idCrm", idCrm)
            dA = New SqlDataAdapter(cmd)
            dA.Fill(miTabla)

            combo.DataSource = miTabla
            combo.DisplayMember = "Ejecutivo"
            combo.ValueMember = "Ejecutivo"
            combo.SelectedIndex = -1

        Catch ex As Exception

            MsgBox("Error Listar tipo de bloqueo" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")

        End Try
    End Sub

    Private Sub ListaOtroEjecutivos(combo As ComboBox, ByVal ejecutivo As String)
        Dim miTabla As New DataTable
        Dim dA As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim sql As String = ""
        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "[Gestion].[pa_ListaOtroEjecutivosPorCRM]"
            cmd.CommandText = sql
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@idCrm", idCrm)
            cmd.Parameters.AddWithValue("@ejecutivo", ejecutivo)
            dA = New SqlDataAdapter(cmd)
            dA.Fill(miTabla)

            combo.DataSource = miTabla
            combo.DisplayMember = "Ejecutivo"
            combo.ValueMember = "Ejecutivo"
            combo.SelectedIndex = -1

        Catch ex As Exception

            MsgBox("Error Listar tipo de bloqueo" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")

        End Try
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnMostrarAgendados.Click
        ListaAgendados()
    End Sub

    Private Sub ListaAgendados()
        ListarRegistros(cmbEjecutivoAgenda.SelectedValue, cmbFlujoContacto.Text)
        ListaOtroEjecutivos(cmbOtroEjecutivo, cmbEjecutivoAgenda.SelectedValue)
        gpbSeleccion.Visible = True

        Select Case nombreSupervisor
            Case "DYLAN RODRIGUEZ", "EDINSSON MALDONADO"
                rdbLiberarOtroEjecutivo.Visible = False
                rdbBloquearCarterizar.Visible = False
                cmbOtroEjecutivo.Visible = False
                gbpOtrasOpciones.Visible = False

        End Select

    End Sub

    Private Sub ListarRegistros(ejecutivo As String, flujo As String)
        Dim tabla As New DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim Simbolo As String = ""
        Dim sql As String = ""



        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "Config.pa_ListarRegistrosAgendados"
            cmd.Parameters.AddWithValue("@idCRM", idCrm)
            cmd.Parameters.AddWithValue("@nombreEjecutivo", ejecutivo)
            cmd.Parameters.AddWithValue("@flujoContacto", flujo)

            cmd.CommandText = sql
            cmd.Connection = cnn
            da = New SqlDataAdapter(cmd)
            da.Fill(tabla)

            If tabla.Rows.Count <= 0 Then
                MsgBox("No existen agendados para mostrar", vbInformation, "")
                dtgAgendados.DataSource = Nothing
            Else
                dtgAgendados.DataSource = tabla
                dtgAgendados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            End If

            lblTotalRegistros.Text = "Total: " + tabla.Rows.Count.ToString + " registros"

        Catch ex As Exception
            MsgBox("Error Listar Ventas a Evaluar" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub chkSeleccionarTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chkSeleccionarTodos.CheckedChanged
        If chkSeleccionarTodos.Checked = True Then

            For i As Integer = 0 To dtgAgendados.Rows.Count - 1

                dtgAgendados.Rows(i).Cells(0).Value = True

            Next

        Else
            For i As Integer = 0 To dtgAgendados.Rows.Count - 1

                dtgAgendados.Rows(i).Cells(0).Value = False

            Next
        End If
    End Sub

    Private Sub MarcarRegistros(text As String)
        Dim num As Integer

        For i As Integer = 0 To dtgAgendados.Rows.Count - 1
            dtgAgendados.Rows(i).Cells(0).Value = False
        Next

        num = Val(text)

        For i As Integer = 0 To num - 1
            dtgAgendados.Rows(i).Cells(0).Value = True
        Next
    End Sub

    Private Sub btnLiberarAgendados_Click(sender As Object, e As EventArgs) Handles btnLiberarAgendados.Click
        Dim ejecutivo As String = ""
        Dim strIDs As String = ""
        Dim opcion As Integer

        If dtgAgendados.Rows.Count <= 0 Then Exit Sub

        If rdbLiberarOtroEjecutivo.Checked = False And rdbMismoEjecutivo.Checked = False And rdbBloquearCarterizar.Checked = False Then
            MsgBox("Debe seleccionar una opcion de Liberacion de Agendados", vbInformation, "Informacion")
            rdbLiberarOtroEjecutivo.Focus()
            Exit Sub
        ElseIf rdbLiberarOtroEjecutivo.Checked = True Then
            If cmbOtroEjecutivo.SelectedIndex < 0 Then
                MsgBox("Debe ingresar al menos 1 ejecutivo para liberar estos registros", vbInformation, "Informacion")
                cmbOtroEjecutivo.Focus()
                Exit Sub
            End If
        End If

        ejecutivo = cmbEjecutivoAgenda.SelectedValue

        If chkSeleccionarTodos.Checked = True Then

            ejecutivo = cmbEjecutivoAgenda.SelectedValue

        Else
            For Each row As DataGridViewRow In dtgAgendados.Rows
                If row.Cells("chkSeleccionar").Value Then

                    If Not String.IsNullOrEmpty(strIDs) Then
                        strIDs += ","
                    End If
                    strIDs += row.Cells(1).Value.ToString
                End If

            Next

            If strIDs = "" Then
                MsgBox("Debe seleccionar registros a liberar", vbInformation, "Informacion")
                dtgAgendados.Focus()
                Exit Sub
            End If

        End If


        If rdbMismoEjecutivo.Checked = True Then
            opcion = 1
        ElseIf rdbLiberarOtroEjecutivo.Checked = True Then
            opcion = 2
        ElseIf rdbBloquearCarterizar.Checked = True Then
            opcion = 3
        End If


        LiberarAgendados(ejecutivo, strIDs, opcion, IIf(chkSinIntentos.Checked = True, 1, 0), IIf(chkObservaciones.Checked = True, 1, 0), IIf(rdbLiberarOtroEjecutivo.Checked = True, cmbOtroEjecutivo.Text, ""), cmbFlujoContacto.Text)
        limpiaControles()
        'dtgAgendados.DataSource = Nothing
        ListaAgendados()
        'ListarRegistros(cmbEjecutivoAgenda.SelectedValue, cmbFlujoContacto.Text)

    End Sub


    Private Sub LiberarAgendados(ByVal ejecutivo As String, ByVal strIDs As String, ByVal opcion As Integer, ByVal intentos As Integer, ByVal observaciones As Integer, ByVal otroEjecutivo As String, ByVal flujo As String)
        Dim tabla As New DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim Bitacora As New clsBitacora
        Dim Especificacion As String
        Dim myTransaction As SqlTransaction
        Dim Simbolo As String = ""
        Dim sql As String = ""



        Try

            cmd.CommandType = CommandType.StoredProcedure



            sql = "Config.pa_LiberarAgendados"
            cmd.Parameters.AddWithValue("@idCRM", idCrm)
            cmd.Parameters.AddWithValue("@ejecutivo", ejecutivo)
            cmd.Parameters.AddWithValue("@ids_clientes", strIDs)
            cmd.Parameters.AddWithValue("@opcion", opcion)
            cmd.Parameters.AddWithValue("@intentos", intentos)
            cmd.Parameters.AddWithValue("@observaciones", observaciones)
            cmd.Parameters.AddWithValue("@otroEjecutivo", otroEjecutivo)
            cmd.Parameters.AddWithValue("@flujo", flujo)


            cnn.Open()
            cmd.CommandText = sql
            cmd.Connection = cnn
            da = New SqlDataAdapter(cmd)
            da.Fill(tabla)
            cmd.ExecuteNonQuery()

            'myTransaction.Commit()

            MsgBox("Registros liberados")

            Especificacion = "Liberacion Agendados:  Ejecutivo: " & ejecutivo & ", Otro Ejecutivo: " & otroEjecutivo & ", Ids: " & strIDs & ""

            Bitacora.IdCRM = idCrm
            Bitacora.Detalle = Especificacion
            Bitacora.Total = 0
            Bitacora.Supervisor = nombreSupervisor
            'cmd.ExecuteNonQuery()
            IngresaBitacora(Bitacora)


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


    Private Sub rdbMismoEjecutivo_CheckedChanged(sender As Object, e As EventArgs)

        If rdbMismoEjecutivo.Checked = True Then
            cmbOtroEjecutivo.Visible = False
        ElseIf rdbLiberarOtroEjecutivo.Checked = True Then
            cmbOtroEjecutivo.Visible = True
        ElseIf rdbBloquearCarterizar.Checked = True Then
            cmbOtroEjecutivo.Visible = False
        Else
            cmbOtroEjecutivo.Visible = False
        End If

    End Sub

    Private Sub tbpLiberacionPorEjecutivo_Click(sender As Object, e As EventArgs) Handles tbpLiberacionPorEjecutivo.Click

    End Sub

    Private Sub rdbPorID_CheckedChanged(sender As Object, e As EventArgs) Handles rdbPorID.CheckedChanged
        TabControl1.TabPages.Item(0).Parent = Nothing
        TabControl1.TabPages.Add(tbpLiberacionPorId)
        limpiarFormulario()
        limpiaControles()
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles rdbPorEjecutivo.CheckedChanged
        TabControl1.TabPages.Item(0).Parent = Nothing
        TabControl1.TabPages.Add(tbpLiberacionPorEjecutivo)
        dtgAgendados.DataSource = Nothing
        limpiarFormulario()
        limpiaControles()
    End Sub

    Private Sub rdbMismoEjecutivo_CheckedChanged_1(sender As Object, e As EventArgs) Handles rdbMismoEjecutivo.CheckedChanged
        If rdbMismoEjecutivo.Checked = True Then
            cmbOtroEjecutivo.Visible = False
        Else
            cmbOtroEjecutivo.Visible = True
        End If
    End Sub

    Private Sub rdbLiberarOtroEjecutivo_CheckedChanged(sender As Object, e As EventArgs) Handles rdbLiberarOtroEjecutivo.CheckedChanged
        If rdbLiberarOtroEjecutivo.Checked = True Then
            cmbOtroEjecutivo.Visible = True
        Else
            cmbOtroEjecutivo.Visible = False
        End If
    End Sub
End Class