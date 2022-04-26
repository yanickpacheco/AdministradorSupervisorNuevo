Imports System.Data.SqlClient

Public Class FormCampaña
    Dim bandera As Boolean

    Private Sub Actualiza_Cel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bandera = False
    End Sub

    'Private Sub BtCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtCerrar.Click
    '    bandera = True
    '    Close()
    'End Sub

    Private Sub Actualiza_Cel_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If bandera = False Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

    Dim cnn As New SqlConnection("data source = 192.168.1.14; initial catalog = BASE_GENERAL_CORDIAL; User id= cp; password=Cordial.passs ")

    Private Sub FormCampaña_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListaSupervisor(cmbUsuario)
    End Sub

    Private Sub ListaSupervisor(ByVal combo As ComboBox)
        Dim miTabla As New DataTable
        Dim dA As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim sql As String = ""
        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "[Config].[pa_ListaSupervisores]"
            cmd.CommandText = sql
            cmd.Connection = cnn
            dA = New SqlDataAdapter(cmd)
            dA.Fill(miTabla)

            combo.DataSource = miTabla
            combo.DisplayMember = "NombreSupervisor"
            combo.ValueMember = "idSupervisor"
            combo.SelectedIndex = -1

        Catch ex As Exception

            MsgBox("Error Listar Supervisor" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")

        End Try


    End Sub



    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click


        If cmbUsuario.SelectedIndex < 0 Then
            MsgBox("Debe seleccionar Usuario", vbExclamation)
            Exit Sub
        End If


        If cmbUsuario.Text = "" Then
            MsgBox("Debe ingresar Clave", vbExclamation)
            Exit Sub
        End If




        If validaUsuario(cmbUsuario.Text, txtClave.Text) = False Then
            lblClaveInvalida.Visible = True
        Else
            lblClaveInvalida.Visible = False
            NombreSupervisor = cmbUsuario.Text
            idSupervisor = cmbUsuario.SelectedValue


            FormMenu.Show()

            Me.WindowState = FormWindowState.Minimized

        End If

    End Sub

    Private Function validaUsuario(ByVal usuario As String, ByVal clave As String) As Boolean
        Dim miTabla As New DataTable
        Dim dA As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim sql As String = ""
        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "[Config].[pa_validaSupervisor]"
            cmd.CommandText = sql
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@usuario", usuario)
            cmd.Parameters.AddWithValue("@clave", clave)
            dA = New SqlDataAdapter(cmd)
            dA.Fill(miTabla)

            If miTabla.Rows.Count = 0 Then
                validaUsuario = False
            Else
                validaUsuario = True
            End If

        Catch ex As Exception

            MsgBox("Error Validar Usuario" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            validaUsuario = False
        End Try


    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Me.Close()
        'Me.Hide()
        End
    End Sub
End Class
