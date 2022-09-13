﻿Imports System.Data.SqlClient

Public Class frmIngresoSolicitud

    Dim cnn As New SqlConnection("data source = 192.168.1.14; initial catalog = SOPORTE; User Id= cp; Password=Cordial.passs")


    Private Sub limpiacampos()

        cmbPiso.SelectedIndex = -1
        txtObs.Text = ""
        dtFecha.Value = Now
        cmbTipoSolicitud.SelectedIndex = -1
        cmbPlataforma.SelectedIndex = -1
        cmbSolicitante.SelectedIndex = -1
        cmbInsumo.SelectedIndex = -1
        txtCantidad.Text = ""
        lblInsumo.Visible = False
        cmbInsumo.Visible = False
        lblCantidad.Visible = False
        txtCantidad.Visible = False
        txtCantidad.Text = ""

    End Sub


    Private Sub ListaTipoSolicitud(ByVal combo As ComboBox)

        Dim mitabla As New DataTable
        Dim DA As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim Simbolo As String = ""
        Dim sql As String = ""
        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "dbo.pa_ListadoTipoSolicitud"

            cmd.CommandText = sql
            cmd.Connection = cnn
            DA = New SqlDataAdapter(cmd)
            DA.Fill(mitabla)


            combo.DataSource = mitabla
            combo.DisplayMember = "TipoTrabajo"
            combo.ValueMember = "idTipoTrabajo"
            combo.SelectedIndex = -1

        Catch ex As Exception
            MsgBox("Error Listar tipo Solicitud" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ListaInsumos(ByVal combo As ComboBox)

        Dim mitabla As New DataTable
        Dim DA As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim Simbolo As String = ""
        Dim sql As String = ""
        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "dbo.pa_ListaInsumos"

            cmd.CommandText = sql
            cmd.Connection = cnn
            DA = New SqlDataAdapter(cmd)
            DA.Fill(mitabla)


            combo.DataSource = mitabla
            combo.DisplayMember = "nombreProducto"
            combo.ValueMember = "idProducto"
            combo.SelectedIndex = -1

        Catch ex As Exception
            MsgBox("Error Listar Insumos" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ListaTipoPlataforma(ByVal combo As ComboBox)

        Dim mitabla As New DataTable
        Dim DA As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim Simbolo As String = ""
        Dim sql As String = ""
        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "dbo.pa_ListaTipoPlataforma"

            cmd.CommandText = sql
            cmd.Connection = cnn
            DA = New SqlDataAdapter(cmd)
            DA.Fill(mitabla)


            combo.DataSource = mitabla
            combo.DisplayMember = "Plataforma"
            combo.ValueMember = "idPlataforma"
            combo.SelectedIndex = -1

        Catch ex As Exception
            MsgBox("Error Listar tipo Plataforma" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ListaSolicitante(ByVal combo As ComboBox)

        Dim mitabla As New DataTable
        Dim DA As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim Simbolo As String = ""
        Dim sql As String = ""
        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "dbo.pa_ListaSolicitante"

            cmd.CommandText = sql
            cmd.Connection = cnn
            DA = New SqlDataAdapter(cmd)
            DA.Fill(mitabla)


            combo.DataSource = mitabla
            combo.DisplayMember = "Solicitante"
            combo.ValueMember = "idSolicitante"
            combo.SelectedIndex = -1

        Catch ex As Exception
            MsgBox("Error Listar tipo Solicitante" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnGestión_Click(sender As Object, e As EventArgs) Handles btnGestión.Click

        If validaCampos() = True Then
            IngresaSolicitud(cmbPiso.Text, cmbTipoSolicitud.SelectedValue, cmbPlataforma.SelectedValue, cmbSolicitante.SelectedValue, txtObs.Text, IIf(cmbInsumo.SelectedValue Is Nothing, 0, cmbInsumo.SelectedValue), txtCantidad.Text)
            limpiacampos()
        End If

    End Sub

    Private Function validaCampos() As Boolean
        validaCampos = False

        If cmbPiso.SelectedIndex <= 0 Then
            MsgBox("Debe ingresar Piso", vbInformation, "")
            Exit Function
        End If

        If cmbPlataforma.SelectedIndex < 0 Then
            MsgBox("Debe ingresar Plataforma", vbInformation, "")
            Exit Function
        End If

        If cmbInsumo.SelectedIndex < 0 Then
            MsgBox("Debe ingresar Plataforma", vbInformation, "")
            Exit Function
        End If

        If cmbSolicitante.SelectedIndex < 0 Then
            MsgBox("Debe ingresar Solicitante", vbInformation, "")
            Exit Function
        End If

        If cmbTipoSolicitud.SelectedIndex < 0 Then
            MsgBox("Debe ingresar Tipo Solicitud", vbInformation, "")
            Exit Function
        ElseIf cmbTipoSolicitud.SelectedValue = 2 Then
            If cmbInsumo.SelectedIndex = -1 Then
                MsgBox("Debe ingresar tipo de Insumo", vbInformation, "")
                Exit Function
            End If
            If txtCantidad.Text = "" Then
                MsgBox("Debe ingresar cantidad de Insumos", vbInformation, "")
                Exit Function
            End If
        End If

        If txtObs.Text = "" Then
            MsgBox("Debe ingresar Observacion", vbInformation, "")
            Exit Function
        End If

        validaCampos = True

    End Function
    ''' <summary>
    ''' Procedimiento que ingresa la solicitud de Soporte, como bitacora
    ''' </summary>
    ''' <param name="piso"></param>
    ''' <param name="tipoSolicitud"></param>
    ''' <param name="plataforma"></param>
    ''' <param name="solicitante"></param>
    ''' <param name="Observaciones"></param>
    ''' <param name="tipoInsumos"></param>
    Private Sub IngresaSolicitud(ByVal piso As String, ByVal tipoSolicitud As Integer, ByVal plataforma As Integer, ByVal solicitante As Integer, ByVal Observaciones As String, ByVal producto As Integer, ByVal cantidad As Integer)
        Dim cmd As New SqlCommand
        Dim sql As String
        Dim myTransaction As SqlTransaction

        cnn.Open()
        myTransaction = cnn.BeginTransaction()
        cmd.CommandType = CommandType.StoredProcedure

        sql = "[dbo].[pa_IngresaBitacora]"
        cmd.Parameters.Add("@piso", SqlDbType.VarChar)
        cmd.Parameters.Add("@tipoSolicitud", SqlDbType.Int)
        cmd.Parameters.Add("@plataforma", SqlDbType.Int)
        cmd.Parameters.Add("@solicitante", SqlDbType.Int)
        cmd.Parameters.Add("@observaciones", SqlDbType.VarChar)

        If tipoSolicitud = 2 Then
            cmd.Parameters.Add("@producto", SqlDbType.Int)
            cmd.Parameters.Add("@cantidad", SqlDbType.Int)
        End If
        Try
            cmd.CommandText = sql
            cmd.Connection = cnn
            cmd.Transaction = myTransaction
            cmd.Parameters("@piso").Value = piso
            cmd.Parameters("@tipoSolicitud").Value = tipoSolicitud
            cmd.Parameters("@plataforma").Value = plataforma
            cmd.Parameters("@solicitante").Value = solicitante
            cmd.Parameters("@observaciones").Value = Observaciones

            If tipoSolicitud = 2 Then
                cmd.Parameters("@producto").Value = producto
                cmd.Parameters("@cantidad").Value = cantidad
            End If

            cmd.ExecuteNonQuery()

            myTransaction.Commit()

            MsgBox("Solicitud Ingresada Correctamente", MsgBoxStyle.Information, "")
        Catch ex As Exception
            myTransaction.Rollback()
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub frmIngresoSolicitud_Load(sender As Object, e As EventArgs) Handles Me.Load
        limpiacampos()
        ListaTipoSolicitud(cmbTipoSolicitud)
        ListaTipoPlataforma(cmbPlataforma)
        ListaSolicitante(cmbSolicitante)
        ListaInsumos(cmbInsumo)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbTipoSolicitud_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoSolicitud.SelectedIndexChanged

        If cmbTipoSolicitud.ValueMember Is Nothing Or cmbTipoSolicitud.ValueMember = "" Then
            Exit Sub
        End If
        If cmbTipoSolicitud.SelectedValue Is Nothing Then
            Exit Sub
        End If

        If cmbTipoSolicitud.SelectedValue = 2 Then
            lblInsumo.Visible = True
            cmbInsumo.Visible = True
            lblCantidad.Visible = True
            txtCantidad.Visible = True
        Else
            lblInsumo.Visible = False
            cmbInsumo.Visible = False
            lblCantidad.Visible = False
            txtCantidad.Visible = False
            cmbInsumo.SelectedIndex = -1
            txtCantidad.Text = ""
        End If
    End Sub
End Class