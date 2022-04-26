Imports System.Data.SqlClient
Imports System.Net

Public Class FrmLiberaTerminados
    '   Dim cnn As New SqlConnection("data source = 192.168.1.14; initial catalog = Global; User Id= USER_PROCALL; Password=rbMv2YawFI")
    Dim cnn As New SqlConnection("data source = 192.168.1.14; initial catalog = BASE_GENERAL_CORDIAL; User Id= cp; Password=Cordial.passs")
    'Dim cnnGeneral As New SqlConnection("data source = 192.168.1.245; initial catalog = Global_peru; User Id= aspnet; Password=123")
    Dim GlMitabla As New DataTable
    Dim sql As String

    Private Sub FrmLiberaTerminados_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = "Libera Registros Terminados (" & idCrm & ")"
        LblCampana.Text = idCrm
        TbCCuerpo.TabPages.Remove(TabPage3)
        If TbCCuerpo.TabPages.Count = 1 Then
            TbCCuerpo.TabPages.Add(TabPage1)
            TbCCuerpo.TabPages.Remove(TabPage2)
            TbCCuerpo.TabPages.Add(TabPage2)
        End If
        ChkSelecTodo.Checked = False
        ChkIntentos.Checked = False
        gbxIntentos.Enabled = False
        nudIntentos.Value = 1
        CmbSimbolo.SelectedIndex = 0
        DGVLiberaTerminados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgLogLiberacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DtpDesde.Value = "01-" & Now.Month & "-" & Now.Year
        DtpHasta.Value = Now
        LlenaCombo()
        LlenaGrilla()
        LlenaGrillaLog()
        TabPage1.Focus()
    End Sub

    Private Sub ListaCargaBase()

        Dim mitabla As DataTable = New DataTable
        Dim DA As SqlDataAdapter
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.StoredProcedure
        Try

            'LblTotalLiberar.Text = "0"
            sql = "[Gestion].[pa_ListaFechaCargaCampana]"
            cmd.Parameters.AddWithValue("@idcrm", idCrm)


            cmd.CommandText = sql
            cmd.Connection = cnn
            DA = New SqlDataAdapter(cmd)
            DA.Fill(mitabla)

            'Dim fila As String() = {"Sin Filtro"}
            ' mitabla.Rows.Add(fila)
            'row.Item("Descripcion") = 

            cmbCargaBase.DisplayMember = "Descripcion"
            cmbCargaBase.ValueMember = "Descripcion"
            cmbCargaBase.DataSource = mitabla

            cmbCargaBase.SelectedValue = "Sin Filtro"

        Catch ex As Exception
            MsgBox("Error Llenar Grilla CargaBase" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Informacion")
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub LlenaCombo()
        'cmbTipoBase.SelectedIndex = 0
        CargaCombo(CmbConecta, "[Gestion].[pa_ListaConectaCampana]")
        CargaComboTipoBase(cmbTipoBase, "[Gestion].[pa_ListaTipoBaseCampana]")
        CargaCombo(cmbInteresa, "[Gestion].[pa_ListaInteresaCampana]")
        CargaCombo(cmbAgentes, "[Gestion].[pa_ListaAgentesCampana]")
        CargaCombo(cmbAgentes_1, "[Gestion].[pa_ListaAgentesCampana]")
        ListaCargaBase()
        'CargaCombo(cmbCargaBase, "Calidad.CampanaListacategoria " + CStr(vpSesion.Codigo))

    End Sub
    Private Sub CargaCombo(ByRef Combo As ComboBox, ByVal query As String)
        Dim mitabla As New DataTable
        Dim DA As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim Simbolo As String = ""
        Dim sql As String = ""
        cmd.CommandType = CommandType.StoredProcedure

        Try

            sql = query
            cmd.Parameters.AddWithValue("@idCRM", idCrm)

            cmd.CommandText = sql
            cmd.Connection = cnn
            DA = New SqlDataAdapter(cmd)
            DA.Fill(mitabla)
            Combo.DataSource = mitabla
            Combo.DisplayMember = "Descripcion"
            Combo.ValueMember = "Descripcion"
            If Combo.Name = "CmbConecta" Then
                Combo.SelectedIndex = 0
            End If
        Catch ex As Exception
            MsgBox("Error Llenar Combo para la consulta " & query & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Informacion.")
        End Try

    End Sub


    Private Sub CargaComboTipoBase(ByRef Combo As ComboBox, ByVal query As String)
        Dim mitabla As New DataTable
        Dim DA As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim Simbolo As String = ""
        Dim sql As String = ""
        cmd.CommandType = CommandType.StoredProcedure

        Try

            sql = query
            cmd.Parameters.AddWithValue("@idCRM", idCrm)

            cmd.CommandText = sql
            cmd.Connection = cnn
            DA = New SqlDataAdapter(cmd)
            DA.Fill(mitabla)
            Combo.DataSource = mitabla
            Combo.DisplayMember = "Descripcion"
            Combo.ValueMember = "tipobase"
            If Combo.Name = "CmbConecta" Then
                Combo.SelectedIndex = 0
            End If
        Catch ex As Exception
            MsgBox("Error Llenar Combo Tipo Base" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Informacion.")
        End Try

    End Sub


    Private Sub LlenaGrilla()
        'Dim DS As New DataSet
        Dim mitabla As DataTable = New DataTable
        Dim DA As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim Simbolo As String = ""
        cmd.CommandType = CommandType.StoredProcedure
        Try

            Simbolo = ObtieneSimbolo(CmbSimbolo)
            LblTotalLiberar.Text = "0"
            sql = "[Config].[pa_ListarRegTerminados]"
            cmd.Parameters.AddWithValue("@idCRM", idCrm)
            cmd.Parameters.AddWithValue("@FlujoConecta", CmbConecta.Text)
            cmd.Parameters.AddWithValue("@FlujoInteres", "Sin Filtro")
            'cmd.Parameters.AdWithValued("@TipoBase", SqlDbType.VarChar)
            cmd.Parameters.AddWithValue("@TipoBase", cmbTipoBase.SelectedValue)
            cmd.Parameters.AddWithValue("@ConIntentos", ChkIntentos.Checked)
            cmd.Parameters.AddWithValue("@Simbolo", Simbolo)
            cmd.Parameters.AddWithValue("@Intentos", nudIntentos.Value)
            cmd.Parameters.AddWithValue("@cargaBase", cmbCargaBase.SelectedValue)


            If grxFechaGeneral.Enabled Then

                cmd.Parameters.AddWithValue("@FechaDesde", dtpDesdeGeneral.Value)
                cmd.Parameters.AddWithValue("@FechaHasta", dtpHastaGeneral.Value)

            End If

            cmd.CommandText = sql
            cmd.Connection = cnn

            Dim column As New DataColumn()
            With column
                .DataType = System.Type.GetType("System.Boolean")
                .ColumnName = "Liberar"
                .ReadOnly = False
                .Unique = False
                .DefaultValue = False
            End With

            'Dim columnDetalle As New DataColumn()
            'With column
            '    .DataType = System.Type.GetType("System.Boolean")
            '    .ColumnName = "Total"
            '    .ReadOnly = False
            '    .Unique = False
            '    .DefaultValue = False
            'End With

            DA = New SqlDataAdapter(cmd)
            DA.Fill(mitabla)
            mitabla.Columns.Add(column)
            'mitabla.Columns.Add(columnDetalle)
            DGVLiberaTerminados.DataSource = mitabla
            For i As Integer = 0 To DGVLiberaTerminados.Rows.Count - 1
                DGVLiberaTerminados.Rows().Item(i).Cells(5).Style.ForeColor = Color.Red
            Next


        Catch ex As Exception
            MsgBox("Error Llenar Grilla" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Informacion.")
        Finally
            cnn.Close()
        End Try
    End Sub



    Private Sub LlenaGrillaLog()

        Dim mitabla As DataTable = New DataTable
        Dim DA As SqlDataAdapter
        Dim cmd As New SqlCommand
        cmd.CommandType = CommandType.StoredProcedure
        Try

            LblTotalLiberar.Text = "0"
            sql = "[Config].[LiberaTerminadoListaLog]"
            cmd.Parameters.Add("@idCRM", SqlDbType.Int)
            cmd.Parameters.Add("@Desde", SqlDbType.DateTime)
            cmd.Parameters.Add("@Hasta", SqlDbType.DateTime)



            cmd.Parameters("@idCRM").Value = idCrm
            cmd.Parameters("@Desde").Value = DtpDesde.Value.ToShortDateString
            cmd.Parameters("@Hasta").Value = DtpHasta.Value.ToShortDateString


            cmd.CommandText = sql
            cmd.Connection = cnn
            DA = New SqlDataAdapter(cmd)
            DA.Fill(mitabla)

            dgLogLiberacion.DataSource = mitabla
        Catch ex As Exception
            MsgBox("Error Llenar Grilla LOG" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Informacion.")
        Finally
            cnn.Close()
        End Try
    End Sub
    Private Sub DGVTablaTerminados_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVLiberaTerminados.CellClick
        If e.RowIndex < 0 Then Exit Sub
        Dim row As DataGridViewRow = DGVLiberaTerminados.Rows(e.RowIndex)
        If DGVLiberaTerminados.Columns.Count - 1 <> e.ColumnIndex And DGVLiberaTerminados.Columns.Count - 2 <> e.ColumnIndex Then
            Exit Sub
            'ElseIf DGVLiberaTerminados.Columns.Count - 2 <> e.ColumnIndex Then
            '    Exit Sub
        End If
        If DGVLiberaTerminados.Rows(e.RowIndex).Cells("Liberar").Value Then
            DGVLiberaTerminados.Rows(e.RowIndex).Cells("Liberar").Value = False
            LblTotalLiberar.Text = LblTotalLiberar.Text - DGVLiberaTerminados.Rows(e.RowIndex).Cells("Total").Value
            row.DefaultCellStyle.BackColor = Color.White

        Else
            DGVLiberaTerminados.Rows(e.RowIndex).Cells("Liberar").Value = True
            LblTotalLiberar.Text = LblTotalLiberar.Text + DGVLiberaTerminados.Rows(e.RowIndex).Cells("Total").Value
            row.DefaultCellStyle.BackColor = Color.CornflowerBlue
        End If

        'DGVTablaTerminados.Rows(e.RowIndex).Cells("Liberar").Value = Not DGVTablaTerminados.Rows(e.RowIndex).Cells("Liberar").Value
    End Sub

    Private Sub ChkSelecTodo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkSelecTodo.CheckedChanged
        Dim vTotal As Double
        vTotal = 0
        For Each row As DataGridViewRow In DGVLiberaTerminados.Rows
            row.Cells("Liberar").Value = ChkSelecTodo.Checked

            If ChkSelecTodo.Checked Then
                vTotal = vTotal + row.Cells("Total").Value
                row.DefaultCellStyle.BackColor = Color.CornflowerBlue
            Else
                row.DefaultCellStyle.BackColor = Color.White
            End If
        Next
        LblTotalLiberar.Text = vTotal
    End Sub


    Private Sub BtnLiberar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLiberar.Click

        If LblTotalLiberar.Text = "0" Then MsgBox("Debe Seleccionar al menos 1 tipo de resgistro a liberar") : Exit Sub

        If MsgBox("¿Está seguro de Liberar " & LblTotalLiberar.Text & " Resgistros?", MsgBoxStyle.DefaultButton3 + MsgBoxStyle.YesNoCancel + MsgBoxStyle.Question, "atención") = MsgBoxResult.Yes Then
            If chkBloqueado.Checked = True Then
                '  frmBloqueado.ShowDialog()
                If validaBloqueo = True Then
                    GrabaLiberacion()
                    LimpiaDatos()
                    LlenaGrilla()
                End If
            Else
                GrabaLiberacion()
                LimpiaDatos()
                LlenaGrilla()
            End If
        End If



    End Sub
    Private Sub LimpiaDatos()
        'cmbFlujoConexion.SelectedIndex = 0
        CmbConecta.SelectedIndex = 0
        cmbInteresa.SelectedIndex = 0
        'cmbTipoBase.SelectedIndex = 0
        ChkSelecTodo.Checked = False
        ChkIntentos.Checked = False
        nudIntentos.Value = 1
        CmbSimbolo.SelectedIndex = 0
        gbxIntentos.Enabled = False
        chkSinIntentos.Checked = False
        chkSinIntentos_1.Checked = False
        chkSinObservaciones.Checked = False
        chkSinObservaciones_1.Checked = False
        chkBloqueado.Checked = False
        chkBloqueado_1.Checked = False
    End Sub
    Private Sub GrabaLiberacion()
        Dim cmd As New SqlCommand
        Dim sql As String
        Dim myTransaction As SqlTransaction
        Dim Bitacora As New clsBitacora
        Dim Especificacion As String
        Dim Simbolo As String = ""

        cnn.Open()
        myTransaction = cnn.BeginTransaction()
        cmd.CommandType = CommandType.StoredProcedure
        Simbolo = ObtieneSimbolo(CmbSimbolo)

        sql = "[Config].[pa_LiberarTerminados]"

        Try
            cmd.CommandText = sql
            cmd.Connection = cnn
            cmd.Transaction = myTransaction

            For Each row As DataGridViewRow In DGVLiberaTerminados.Rows
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@idCRM", idCrm)
                cmd.Parameters.AddWithValue("@TipoBase", cmbTipoBase.SelectedValue)
                cmd.Parameters.AddWithValue("@ConIntentos", ChkIntentos.Checked)
                cmd.Parameters.AddWithValue("@Simbolo", Simbolo)
                cmd.Parameters.AddWithValue("@Intentos", nudIntentos.Value)
                cmd.Parameters.AddWithValue("@cargaBase", cmbCargaBase.SelectedValue)
                cmd.Parameters.AddWithValue("@Agente", cmbAgentes_1.SelectedValue)
                cmd.Parameters.AddWithValue("@cambiaIntentos", chkSinIntentos.Checked)
                cmd.Parameters.AddWithValue("@cambiaObserbaciones", chkSinObservaciones.Checked)
                cmd.Parameters.AddWithValue("@bloqueado", chkBloqueado.Checked)
                ' cmd.Parameters("@marca").Value = marca

                If grxFechaGeneral.Enabled Then

                    cmd.Parameters.AddWithValue("@FechaDesde", dtpDesdeGeneral.Value)
                    cmd.Parameters.AddWithValue("@FechaHasta", dtpHastaGeneral.Value)

                End If

                If row.Cells("Liberar").Value = True Then
                    cmd.Parameters.AddWithValue("@CONECTA", row.Cells("Conecta").Value)
                    cmd.Parameters.AddWithValue("@NO_CONECTA", row.Cells("NO Conecta").Value)
                    cmd.Parameters.AddWithValue("@COMUNICA_CON", row.Cells("Comunica Con").Value)
                    cmd.Parameters.AddWithValue("@FLUJO_CONTACTO", row.Cells("Flujo Registro").Value)
                    cmd.Parameters.AddWithValue("@MTVO_NOCONTRATA", row.Cells("Mtvo No Contrata").Value)
                    cmd.ExecuteNonQuery()

                    myTransaction.Commit()

                    Especificacion = "Flujo Conecta: " & CmbConecta.Text
                    Especificacion += "," + "TipoBase:" & cmbTipoBase.Text
                    Especificacion += "," + "Con Intentos: " & IIf(ChkIntentos.Checked, "Si " & CmbSimbolo.Text & " " & nudIntentos.Value, "No")
                    Especificacion += "," + row.Cells("Conecta").Value
                    Especificacion += "," + row.Cells("NO Conecta").Value
                    Especificacion += "," + row.Cells("Comunica Con").Value
                    Especificacion += "," + row.Cells("Flujo Registro").Value
                    Especificacion += "," + row.Cells("Mtvo No Contrata").Value
                    Especificacion += "," + "Agente:" & cmbAgentes_1.Text
                    Especificacion += "," + "Sin Intentos:" & chkSinIntentos.Checked
                    Especificacion += "," + "Sin Observaciones:" & chkSinObservaciones.Checked

                    If grxFechaGeneral.Enabled Then
                        Especificacion += "," + "Fecha desde: " & Mid(cmd.Parameters("@FechaDesde").Value.ToString, 1, 10)
                        Especificacion += "," + "Fecha hasta: " & Mid(cmd.Parameters("@FechaHasta").Value.ToString, 1, 10)
                    End If


                    Bitacora.IdCRM = idCrm
                    Bitacora.Detalle = Especificacion
                    Bitacora.Total = row.Cells("Total").Value
                    Bitacora.Supervisor = nombreSupervisor
                    'cmd.ExecuteNonQuery()
                    IngresaBitacora(Bitacora)

                End If



            Next


        Catch ex As Exception
            myTransaction.Rollback()
            MsgBox("No se pudo liberar" & vbNewLine & ex.Message, vbInformation, "Informacion")
        Finally
            cnn.Close()
            MsgBox("Resgistros librerados: " + LblTotalLiberar.Text)
            LblTotalLiberar.Text = 0

        End Try
    End Sub

    Private Sub BtnRefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefrescar.Click
        LlenaGrilla()
    End Sub


    Private Sub BtnActualizaLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnActualizaLog.Click
        LlenaGrillaLog()
    End Sub

    Private Sub ChkIntentos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkIntentos.CheckedChanged
        If ChkIntentos.Checked = True Then
            gbxIntentos.Enabled = True
        Else
            gbxIntentos.Enabled = False
        End If
    End Sub



    Private Sub DGVLiberaTerminados_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVLiberaTerminados.CellContentClick


    End Sub
    Private Sub LlenaGrillaDetalle(ByVal strConecta As String, ByVal strNoConecta As String, ByVal strComunicaCon As String,
                                   ByVal strFlujoContacto As String, ByVal strMtvoNocontrata As String)


        Dim DA As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim Simbolo As String = ""
        cmd.CommandType = CommandType.StoredProcedure
        Dim mitabla As New DataTable
        mitabla.Columns.Clear()
        mitabla.Rows.Clear()
        GlMitabla.Columns.Clear()
        GlMitabla.Rows.Clear()

        Try

            Simbolo = ObtieneSimbolo(CmbSimbolo)
            LblTotalLiberar.Text = "0"
            sql = "[Config].[pa_TerminadosDetalle]"
            cmd.Parameters.AddWithValue("@idCRM", idCrm)
            cmd.Parameters.AddWithValue("@CONECTA", strConecta.Trim)
            cmd.Parameters.AddWithValue("@NO_CONECTA", strNoConecta.Trim)
            cmd.Parameters.AddWithValue("@COMUNICA_CON", strComunicaCon.Trim)
            cmd.Parameters.AddWithValue("@FLUJO_CONTACTO", strFlujoContacto.Trim)
            cmd.Parameters.AddWithValue("@MTVO_NOCONTRATA", strMtvoNocontrata.Trim)
            cmd.Parameters.AddWithValue("@DescrProducto", CmbConecta.Text)
            cmd.Parameters.AddWithValue("@TipoBase", cmbTipoBase.SelectedValue)
            cmd.Parameters.AddWithValue("@ConIntentos", ChkIntentos.Checked)
            cmd.Parameters.AddWithValue("@Simbolo", Simbolo)
            cmd.Parameters.AddWithValue("@Intentos", nudIntentos.Value)

            cmd.CommandText = sql
            cmd.Connection = cnn

            Dim column As New DataColumn()
            With column
                .DataType = System.Type.GetType("System.Boolean")
                .ColumnName = "Liberacion"
                .ReadOnly = False
                .Unique = False
                .DefaultValue = False
            End With

            DA = New SqlDataAdapter(cmd)
            DA.Fill(mitabla)
            mitabla.Columns.Add(column)



            'GlMitabla = mitabla
            For y As Integer = 0 To mitabla.Columns.Count - 1
                GlMitabla.Columns.Add(mitabla.Columns(y).ColumnName)
            Next
            For i As Integer = 0 To mitabla.Rows.Count - 1
                GlMitabla.ImportRow(mitabla.Rows(i))
            Next


            dgLiberarDetalle.DataSource = mitabla

            'mitabla.Columns.Remove(column)

        Catch ex As Exception
            MsgBox("Error Llenar Grilla" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Informacion.")
        Finally
            cnn.Close()
        End Try

    End Sub

    Private Function validaBloqueo() As Boolean

    End Function

    Private Sub btnLiberarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLiberarDetalle.Click
        If lblTotalLiberarDetalle.Text = "0" Then MsgBox("Debe Seleccionar al menos 1 tipo de resgistro a liberar") : Exit Sub

        If MsgBox("¿Está seguro de Liberar " & lblTotalLiberarDetalle.Text & " Resgistros?", MsgBoxStyle.DefaultButton3 + MsgBoxStyle.YesNoCancel + MsgBoxStyle.Question, "Atención") = MsgBoxResult.Yes Then
            If chkBloqueado_1.Checked = True Then
                ' frmBloqueado.ShowDialog()
                If validaBloqueo = True Then
                    Dim strIDs As String = ""

                    For Each row As DataGridViewRow In dgLiberarDetalle.Rows
                        If row.Cells("Liberacion").Value Then

                            If Not String.IsNullOrEmpty(strIDs) Then
                                strIDs += ","
                            End If
                            strIDs += row.Cells("ID").Value.ToString

                        End If

                    Next

                    LiberarDetallados(strIDs)
                    LimpiaDatos()
                End If
            Else
                Dim strIDs As String = ""

                For Each row As DataGridViewRow In dgLiberarDetalle.Rows
                    If row.Cells("Liberacion").Value Then

                        If Not String.IsNullOrEmpty(strIDs) Then
                            strIDs += ","
                        End If
                        strIDs += row.Cells("ID").Value.ToString

                    End If

                Next

                LiberarDetallados(strIDs)
                LimpiaDatos()
            End If



        End If
    End Sub




    Private Sub LiberarDetallados(ByVal strIDs As String)

        Dim cmd As New SqlCommand
        Dim sql As String
        Dim myTransaction As SqlTransaction
        Dim Bitacora As New clsBitacora
        Dim Especificacion As String
        Dim Simbolo As String = ""
        Dim strAgente As String

        If cmbAgentes.Text.Trim = "Sin Agente" Then
            strAgente = ""
        Else
            strAgente = cmbAgentes.Text.Trim
        End If

        cnn.Open()
        myTransaction = cnn.BeginTransaction()
        cmd.CommandType = CommandType.StoredProcedure
        Simbolo = ObtieneSimbolo(CmbSimbolo)

        sql = "[Config].[pa_LiberarTerminadosDetallados]"

        Try

            cmd.CommandText = sql
            cmd.Connection = cnn
            cmd.Transaction = myTransaction
            cmd.Parameters.AddWithValue("@ids_clientes", strIDs)
            cmd.Parameters.AddWithValue("@idCRM", idCrm)
            cmd.Parameters.AddWithValue("@agenteAsignado", strAgente)
            cmd.Parameters.AddWithValue("@cambiaIntentos", chkSinIntentos_1.Checked)
            cmd.Parameters.AddWithValue("@cambiaObserbaciones", chkSinObservaciones_1.Checked)
            cmd.Parameters.AddWithValue("@bloqueado", chkBloqueado_1.Checked)
            ' cmd.Parameters("@marca").Value = marca
            cmd.ExecuteNonQuery()



            myTransaction.Commit()

            Especificacion = "Liberacion de Ids - Producto: " & CmbConecta.Text
            Especificacion += "," + "TipoBase:" & cmbTipoBase.Text
            Especificacion += "," + "Con Intentos: " & IIf(ChkIntentos.Checked, "Si " & CmbSimbolo.Text & " " & nudIntentos.Value, "No")
            Especificacion += ", Agrupados por: " & lblAgrupaciones.Text
            Especificacion += "," + "Sin Intentos:" & chkSinIntentos_1.Checked
            Especificacion += "," + "Sin Observaciones:" & chkSinObservaciones_1.Checked


            Bitacora.IdCRM = idCrm
            Bitacora.Detalle = Especificacion
            Bitacora.Total = 0
            Bitacora.Supervisor = nombreSupervisor
            'cmd.ExecuteNonQuery()
            IngresaBitacora(Bitacora)


            MsgBox("Registros liberados: " + lblTotalLiberarDetalle.Text)
            lblTotalLiberarDetalle.Text = 0

        Catch ex As Exception
            MsgBox("Ha ocurrido un error al intentar la liberación de los registros" & vbNewLine & ex.Message, vbExclamation, "Informacion")
            myTransaction.Rollback()
        Finally
            cnn.Close()



            Dim strAgrupaciones As String() = lblAgrupaciones.Text.Split(", ")

            LlenaGrillaDetalle(strAgrupaciones(0), strAgrupaciones(1), strAgrupaciones(2), strAgrupaciones(3),
                               strAgrupaciones(4))

            If grxFecha.Enabled Then

                Dim dt As DataTable = New DataTable
                For y As Integer = 0 To GlMitabla.Columns.Count - 1
                    dt.Columns.Add(GlMitabla.Columns(y).ColumnName)
                Next
                For i As Integer = 0 To GlMitabla.Rows.Count - 1
                    dt.ImportRow(GlMitabla.Rows(i))
                Next
                For x As Integer = 0 To dt.Rows.Count - 1
                    If Date.Parse(dt.Rows(x)("Fecha")) < Date.Parse(dtpFechaDesde.Value.ToString.Split(" ")(0)) Or
                    Date.Parse(dt.Rows(x)("Fecha").ToString) > Date.Parse(dtpFechaHasta.Value.ToString.Split(" ")(0)) Then
                        dt.Rows(x).Delete()
                    End If
                Next
                dgLiberarDetalle.DataSource = dt

            End If
        End Try

    End Sub

    Private Sub dgLiberarDetalle_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgLiberarDetalle.CellClick
        If e.RowIndex < 0 Then Exit Sub
        Dim row As DataGridViewRow = dgLiberarDetalle.Rows(e.RowIndex)
        If dgLiberarDetalle.Columns.Count - 1 <> e.ColumnIndex Then Exit Sub
        If dgLiberarDetalle.Rows(e.RowIndex).Cells("Liberacion").Value Then
            dgLiberarDetalle.Rows(e.RowIndex).Cells("Liberacion").Value = False
            lblTotalLiberarDetalle.Text = Long.Parse(lblTotalLiberarDetalle.Text) - 1
            row.DefaultCellStyle.BackColor = Color.White
        Else
            dgLiberarDetalle.Rows(e.RowIndex).Cells("Liberacion").Value = True
            lblTotalLiberarDetalle.Text = Long.Parse(lblTotalLiberarDetalle.Text) + 1
            row.DefaultCellStyle.BackColor = Color.CornflowerBlue
        End If

    End Sub

    'Private Sub dgLiberarDetalle_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgLiberarDetalle.CellContentClick
    '    Select Case e.ColumnIndex
    '        Case 8
    '    End Select
    'End Sub
    Private Sub recargas()

        LlenaGrilla()
        cmbAgentes.SelectedIndex = 0

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click

        lblTotalLiberarDetalle.Text = "0"
        recargas()
        TbCCuerpo.TabPages.Add(TabPage1)
        TbCCuerpo.TabPages.Remove(TabPage3)
        TbCCuerpo.TabPages.Remove(TabPage2)
        TbCCuerpo.TabPages.Add(TabPage2)
        TbCCuerpo.SelectedTab = TabPage1

    End Sub

    Private Sub chkFiltroFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFiltroFecha.CheckedChanged
        If chkFiltroFecha.Checked = True Then
            grxFecha.Enabled = True
        Else
            grxFecha.Enabled = False
        End If
    End Sub

    'Private Sub dtpFechaDesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaDesde.ValueChanged
    'End Sub
    'Private Sub dtpFechaHasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaHasta.ValueChanged
    '    Dim dt As DataTable = mitabla
    '    For x As Integer = 0 To dt.Rows.Count - 1
    '        If Not Date.Parse(dt.Rows(x)("Fecha").ToString) >= dtpFechaDesde.Value And Not Date.Parse(dt.Rows(x)("Fecha").ToString) <= DtpHasta.Value Then
    '            dt.Rows(x).Delete()
    '        End If
    '        MsgBox(Date.Parse(dt.Rows(x)("Fecha").ToString) + " / " + dtpFechaDesde.Value)
    '    Next
    '    dgLiberarDetalle.DataSource = dt
    'End Sub
    Private Sub btnActualizarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarDetalle.Click

        If grxFecha.Enabled Then

            Dim dt As DataTable = New DataTable
            For y As Integer = 0 To GlMitabla.Columns.Count - 1
                dt.Columns.Add(GlMitabla.Columns(y).ColumnName)
            Next
            For i As Integer = 0 To GlMitabla.Rows.Count - 1
                dt.ImportRow(GlMitabla.Rows(i))
            Next
            For x As Integer = 0 To dt.Rows.Count - 1
                'If Not Date.Parse(dt.Rows(x)("Fecha")) >= dtpFechaDesde.Value And Not Date.Parse(dt.Rows(x)("Fecha")) <= DtpHasta.Value Then
                '    dt.Rows(x).Delete()
                'End If
                'MsgBox(Date.Parse(dtpFechaDesde.Value.ToString.Split(" ")(0)))
                'MsgBox(Date.Parse(dt.Rows(x)("Fecha")).ToString + "<" + Date.Parse(dtpFechaDesde.Value.ToString.Split(" ")(0)).ToString)
                If Date.Parse(dt.Rows(x)("Fecha")) < Date.Parse(dtpFechaDesde.Value.ToString.Split(" ")(0)) Or
                Date.Parse(dt.Rows(x)("Fecha").ToString) > Date.Parse(dtpFechaHasta.Value.ToString.Split(" ")(0)) Then
                    dt.Rows(x).Delete()
                End If
                'MsgBox(Date.Parse(dt.Rows(x)("Fecha")).ToString + ">" + Date.Parse(dtpFechaHasta.Value.ToString.Split(" ")(0)).ToString)
                'MsgBox(Date.Parse(dt.Rows(x)("Fecha").ToString) + " / " + Date.Parse(dtpFechaDesde.Value.ToString.Split(" ")(0))).ToString()
            Next
            dgLiberarDetalle.DataSource = dt

        Else
            MsgBox("No se ha habilitado ninguna opción de filtro.", MsgBoxStyle.Information, "Informacion.")
        End If


    End Sub


    Private Sub chkFiltroFechaGeneral_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFiltroFechaGeneral.CheckedChanged

        If chkFiltroFechaGeneral.Checked = True Then
            grxFechaGeneral.Enabled = True
        Else
            grxFechaGeneral.Enabled = False
        End If

    End Sub

    Function ObtieneSimbolo(ByVal Combo As ComboBox) As String
        Select Case Combo.Text
            Case "Igual a"
                ObtieneSimbolo = "="
            Case "Mayor a"
                ObtieneSimbolo = ">"
            Case "Menor a"
                ObtieneSimbolo = "<"
            Case "Distinto a"
                ObtieneSimbolo = "<>"
            Case "Mayor Igual a"
                ObtieneSimbolo = ">="
            Case "Menor Igual a"
                ObtieneSimbolo = "<="
            Case Else
                ObtieneSimbolo = ""
        End Select

    End Function

    Private Sub CmbConecta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbConecta.SelectedIndexChanged
        If CmbConecta.Text = "CONECTA" Then

            lblInteresa.Visible = False
            cmbInteresa.Visible = False

        Else
            lblInteresa.Visible = False
            cmbInteresa.Visible = False

        End If
    End Sub

    Private Sub DGVLiberaTerminados_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVLiberaTerminados.CellContentDoubleClick

        Select Case e.ColumnIndex
            Case 5

                LlenaGrillaDetalle(Me.DGVLiberaTerminados.CurrentRow.Cells.Item("Conecta").Value.ToString(), Me.DGVLiberaTerminados.CurrentRow.Cells.Item("NO Conecta").Value.ToString(),
                                   Me.DGVLiberaTerminados.CurrentRow.Cells.Item("Comunica Con").Value.ToString(), Me.DGVLiberaTerminados.CurrentRow.Cells.Item("Flujo Registro").Value.ToString(),
                                    Me.DGVLiberaTerminados.CurrentRow.Cells.Item("Mtvo No Contrata").Value.ToString())

                lblAgrupaciones.Text = Me.DGVLiberaTerminados.CurrentRow.Cells.Item("Conecta").Value.ToString() _
                                    & ", " & Me.DGVLiberaTerminados.CurrentRow.Cells.Item("NO Conecta").Value.ToString() _
                                   & ", " & Me.DGVLiberaTerminados.CurrentRow.Cells.Item("Comunica Con").Value.ToString() _
                                   & ", " & Me.DGVLiberaTerminados.CurrentRow.Cells.Item("Flujo Registro").Value.ToString() _
                                   & ", " & Me.DGVLiberaTerminados.CurrentRow.Cells.Item("Mtvo No Contrata").Value.ToString()
                'TbCCuerpo.TabPages(2).Show()
                TbCCuerpo.TabPages.Remove(TabPage1)
                TbCCuerpo.TabPages.Add(TabPage3)
                'TbCCuerpo.TabPages.Item("TabPage3").Focus()
                TbCCuerpo.SelectedTab = TabPage3
                'TabPage1.Parent = Nothing
                'Me.DGVLiberaTerminados.CurrentRow.Cells.Item(6).Style.ForeColor = Color.Red

                If grxFechaGeneral.Enabled Then

                    chkFiltroFecha.Checked = True
                    dtpFechaDesde.Value = dtpDesdeGeneral.Value
                    dtpFechaHasta.Value = dtpHastaGeneral.Value

                    Dim dt As DataTable = New DataTable
                    For y As Integer = 0 To GlMitabla.Columns.Count - 1
                        dt.Columns.Add(GlMitabla.Columns(y).ColumnName)
                    Next
                    For i As Integer = 0 To GlMitabla.Rows.Count - 1
                        dt.ImportRow(GlMitabla.Rows(i))
                    Next
                    For x As Integer = 0 To dt.Rows.Count - 1

                        If Date.Parse(dt.Rows(x)("Fecha")) < Date.Parse(dtpFechaDesde.Value.ToString.Split(" ")(0)) Or
                        Date.Parse(dt.Rows(x)("Fecha").ToString) > Date.Parse(dtpFechaHasta.Value.ToString.Split(" ")(0)) Then
                            dt.Rows(x).Delete()
                        End If

                    Next
                    dgLiberarDetalle.DataSource = dt

                End If

            Case 7

                LlenaGrillaDetalle(Me.DGVLiberaTerminados.CurrentRow.Cells.Item("Conecta").Value.ToString(), Me.DGVLiberaTerminados.CurrentRow.Cells.Item("No Conecta").Value.ToString(),
                                   Me.DGVLiberaTerminados.CurrentRow.Cells.Item("Comunica Con").Value.ToString(), Me.DGVLiberaTerminados.CurrentRow.Cells.Item("Flujo Registro").Value.ToString(),
                                   Me.DGVLiberaTerminados.CurrentRow.Cells.Item("Mtvo No Contrata").Value.ToString())

                lblAgrupaciones.Text = Me.DGVLiberaTerminados.CurrentRow.Cells.Item("Conecta").Value.ToString() _
                                    & ", " & Me.DGVLiberaTerminados.CurrentRow.Cells.Item("No Conecta").Value.ToString() _
                                   & ", " & Me.DGVLiberaTerminados.CurrentRow.Cells.Item("Comunica Con").Value.ToString() _
                                   & ", " & Me.DGVLiberaTerminados.CurrentRow.Cells.Item("Flujo Registro").Value.ToString() _
                                   & ", " & Me.DGVLiberaTerminados.CurrentRow.Cells.Item("Mtvo No Contrata").Value.ToString()
                'TbCCuerpo.TabPages(2).Show()
                TbCCuerpo.TabPages.Remove(TabPage1)
                TbCCuerpo.TabPages.Add(TabPage3)
                'TbCCuerpo.TabPages.Item("TabPage3").Focus()
                TbCCuerpo.SelectedTab = TabPage3
                'TabPage1.Parent = Nothing
                'Me.DGVLiberaTerminados.CurrentRow.Cells.Item(6).Style.ForeColor = Color.Red

                If grxFechaGeneral.Enabled Then

                    chkFiltroFecha.Checked = True
                    dtpFechaDesde.Value = dtpDesdeGeneral.Value
                    dtpFechaHasta.Value = dtpHastaGeneral.Value

                    Dim dt As DataTable = New DataTable
                    For y As Integer = 0 To GlMitabla.Columns.Count - 1
                        dt.Columns.Add(GlMitabla.Columns(y).ColumnName)
                    Next
                    For i As Integer = 0 To GlMitabla.Rows.Count - 1
                        dt.ImportRow(GlMitabla.Rows(i))
                    Next
                    For x As Integer = 0 To dt.Rows.Count - 1

                        If Date.Parse(dt.Rows(x)("Fecha")) < Date.Parse(dtpFechaDesde.Value.ToString.Split(" ")(0)) Or
                        Date.Parse(dt.Rows(x)("Fecha").ToString) > Date.Parse(dtpFechaHasta.Value.ToString.Split(" ")(0)) Then
                            dt.Rows(x).Delete()
                        End If

                    Next
                    dgLiberarDetalle.DataSource = dt

                End If
        End Select
    End Sub



End Class


