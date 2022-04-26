Imports System.Data.SqlClient

Public Class frmCargaReferido


    Dim cnn As New SqlConnection("data source = 192.168.1.14; initial catalog = BASE_GENERAL_CORDIAL; User id= cp; password=Cordial.passs ")

    Private Sub chkHorarioRegistro_CheckedChanged(sender As Object, e As EventArgs) Handles chkOtroMomento.CheckedChanged, chkAhora.CheckedChanged
        If chkOtroMomento.Checked = True Then
            gpbFechaAgen.Visible = True
            dtpFechaAgen.Value = Now
            cmbMinutosAgen.SelectedIndex = -1
            cmbHoraAgen.SelectedIndex = -1
        Else
            gpbFechaAgen.Visible = False
            dtpFechaAgen.Value = Now
            cmbMinutosAgen.SelectedIndex = -1
            cmbHoraAgen.SelectedIndex = -1
        End If
    End Sub

    Private Sub frmCargaReferido_Load(sender As Object, e As EventArgs) Handles Me.Load
        listaEjecutivos(cmbEjecutivo)
        limpiarFormulario()
        CargaComboTipoBase(cmbTipoBase)
    End Sub

    Private Sub CargaComboTipoBase(ByRef Combo As ComboBox)
        Dim mitabla As New DataTable
        Dim DA As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim Simbolo As String = ""
        Dim sql As String = ""
        cmd.CommandType = CommandType.StoredProcedure

        Try
            sql = "[Gestion].[pa_ListaTipoBaseCampana]"
            cmd.Parameters.AddWithValue("@idCrm", idCrm)
            cmd.CommandText = sql
            cmd.Connection = cnn
            DA = New SqlDataAdapter(cmd)
            DA.Fill(mitabla)

            Combo.DataSource = mitabla
            Combo.DisplayMember = "Descripcion"
            Combo.ValueMember = "TipoBase"
            Combo.SelectedIndex = -1

        Catch ex As Exception

            MsgBox("Error Listar Ejecutivos" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    Private Sub limpiarFormulario()

        txtRut.Text = ""
        txtNombre.Text = ""
        txtPaterno.Text = ""
        txtMaterno.Text = ""
        dtpFechaAgen.Value = Now
        txtTelefono.Text = ""
        txtDireccion.Text = ""
        txtComuna.Text = ""
        cmbEjecutivo.SelectedIndex = -1
        chkAhora.Checked = False
        chkOtroMomento.Checked = False
        gpbFechaAgen.Visible = False
        dtpFechaAgen.Value = Now
        cmbMinutosAgen.SelectedIndex = -1
        cmbHoraAgen.SelectedIndex = -1

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

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub btnLiberar_Click(sender As Object, e As EventArgs) Handles btnLiberar.Click
        If validadatos() = True Then
            CargarReferidos(IIf(txtRut.Text.Trim = "", "0", txtRut.Text), txtNombre.Text, txtPaterno.Text, txtMaterno.Text, IIf(Date.Now.ToString("yyyyMMdd") = dtpFechaNacimiento.Value.ToString("yyyyMMdd"), "", dtpFechaNacimiento.Value.ToString("yyyyMMdd")), txtTelefono.Text, txtDireccion.Text, txtComuna.Text, cmbEjecutivo.Text, IIf(chkOtroMomento.Checked = True, dtpFechaAgen.Value.ToString("yyyyMMdd"), ""), IIf(chkOtroMomento.Checked = True, cmbHoraAgen.Text, ""), IIf(chkOtroMomento.Checked = True, cmbMinutosAgen.Text, ""), cmbTipoBase.SelectedValue)
            limpiarFormulario()
        End If
    End Sub

    Private Function validadatos() As Boolean

        validadatos = False

        If txtTelefono.Text = "" Or txtTelefono.Text.Length < 8 Then
            MsgBox("Debe ingresar un numero valido para cargar", vbExclamation, "Carga Referidos")
            txtTelefono.Focus()
            Exit Function
        End If

        If cmbEjecutivo.SelectedIndex < 0 Then
            MsgBox("Debe ingresar Ejecutivo a Cargar", vbExclamation, "Carga Referidos")
            cmbEjecutivo.Focus()
            Exit Function
        End If

        If chkAhora.Checked = False And chkOtroMomento.Checked = False Then
            MsgBox("Debe indicar si llamada caera ahora o en Otro Momento", vbExclamation, "Carga Referidos")
            chkAhora.Focus()
            Exit Function
        ElseIf chkOtroMomento.Checked = True Then
            If cmbHoraAgen.SelectedIndex < 0 Then
                MsgBox("Debe ingresar hora de Agendamiento", vbExclamation, "Carga Referidos")
                cmbHoraAgen.Focus()
                Exit Function
            End If
            If cmbMinutosAgen.SelectedIndex < 0 Then
                MsgBox("Debe ingresar Minutos de Agendamiento", vbExclamation, "Carga Referidos")
                cmbMinutosAgen.Focus()
                Exit Function
            End If
        End If

        validadatos = True

    End Function



    Private Sub CargarReferidos(ByVal rut As String, ByVal nombre As String, ByVal paterno As String, ByVal materno As String, ByVal fechanacimiento As String, ByVal telefono As String, ByVal direccion As String, ByVal comuna As String, ByVal ejecutivo As String, ByVal fechaAgen As String, ByVal horaAgen As String, ByVal minAgen As String, ByVal tipobase As String)
        Dim cmd As New SqlCommand
        Dim sql As String
        Dim myTransaction As SqlTransaction
        Dim Bitacora As New clsBitacora
        Dim Especificacion As String
        Dim miTabla As New DataTable
        Dim dA As SqlDataAdapter

        cnn.Open()
        cmd.CommandType = CommandType.StoredProcedure

        sql = "[Gestion].[pa_CargaReferido]"

        cmd.Parameters.AddWithValue("@idCrm", idCrm)
        cmd.Parameters.AddWithValue("@rut", rut)
        cmd.Parameters.AddWithValue("@nombre", nombre)
        cmd.Parameters.AddWithValue("@paterno", paterno)
        cmd.Parameters.AddWithValue("@materno", materno)
        cmd.Parameters.AddWithValue("@fechanacimiento", fechanacimiento)
        cmd.Parameters.AddWithValue("@telefono", telefono)
        cmd.Parameters.AddWithValue("@direccion", direccion)
        cmd.Parameters.AddWithValue("@comuna", comuna)
        cmd.Parameters.AddWithValue("@ejecutivo", ejecutivo)
        cmd.Parameters.AddWithValue("@tipobase", tipobase)

        If chkOtroMomento.Checked = True Then

            cmd.Parameters.AddWithValue("@fechaAgen", fechaAgen)
            cmd.Parameters.AddWithValue("@horaAgen", horaAgen)
            cmd.Parameters.AddWithValue("@minAgen", minAgen)

        End If


        Try
            cmd.CommandText = sql
            cmd.Connection = cnn
            dA = New SqlDataAdapter(cmd)
            dA.Fill(miTabla)


            cmd.CommandType = CommandType.Text

            sql = "SELECT MAX(C_ID) AS ID FROM BDD_" + Microsoft.VisualBasic.Right("00" + idCrm.ToString, 3) + ".ENTIDAD.CLIENTE "

            cmd.CommandText = sql
            cmd.Connection = cnn
            dA = New SqlDataAdapter(cmd)
            dA.Fill(miTabla)
            cmd.ExecuteNonQuery()

            MsgBox("Registro Cargado Como Referido" & vbNewLine & "Id Registro: " & miTabla.Rows(0)("ID").ToString, vbInformation, "Liberacion OK")

            Especificacion = "Carga Referido: Campaña: " & idCrm & ",Ejecutivo: " & ejecutivo & " ,Id: " & miTabla.Rows(0)("ID").ToString & ""

            Bitacora.IdCRM = idCrm
            Bitacora.Detalle = Especificacion
            Bitacora.Total = 0
            Bitacora.Supervisor = nombreSupervisor
            'cmd.ExecuteNonQuery()
            IngresaBitacora(Bitacora)


        Catch ex As Exception
            MsgBox("Error Liberar registro: " & ex.Message, vbInformation)
        Finally
            cnn.Close()

        End Try
    End Sub

    Private Sub ValidaNumeros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress, txtRut.KeyPress
        If Not (IsNumeric(e.KeyChar)) Then
            If (e.KeyChar <> vbBack) Then
                e.Handled = True
            End If
        End If
    End Sub


End Class