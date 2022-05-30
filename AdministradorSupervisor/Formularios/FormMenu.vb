Imports System.Data.SqlClient

Public Class FormMenu

    Dim cnn As New SqlConnection("data source = 192.168.1.14; initial catalog = BASE_GENERAL_CORDIAL; User id= cp; password=Cordial.passs ")
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ListaCampañas(cmbListaCampaña)



        Select Case nombreSupervisor
            Case "PABLO CASTILLO", "MAURICIO GOMEZ", "SUSANA COLLAO", "YANETT MUÑOZ", "CLAUDIA LOZANO", "MATIAS CARRERA", "JOSE GOHURDETT", "PAULA ARAOS", "ANA RODRIGUEZ", "CRISTIAN ANACONA", "DAMARIS MARIN", "ROSSINI VALDIVIA", "FELIPE DIAZ"
                btnReferidos.Visible = True
            Case Else
                btnReferidos.Visible = False
        End Select

    End Sub


    Private Sub ListaCampañas(ByVal combo As ComboBox)
        Dim miTabla As New DataTable
        Dim dA As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim sql As String = ""
        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "[Entidad].[ListaCampañasActivasAppSupervisor]"
            cmd.CommandText = sql
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@IdSupervisor", idSupervisor)
            dA = New SqlDataAdapter(cmd)

            dA.Fill(miTabla)

            combo.DataSource = miTabla
            combo.DisplayMember = "Nombre"
            combo.ValueMember = "CRM"
            combo.SelectedIndex = -1

        Catch ex As Exception

            MsgBox("Error Listar Campañas" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")

        End Try


    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    'Me.Close()
    'End Sub
    Private Function validaCampaña() As Boolean

        validaCampaña = False

        If cmbListaCampaña.SelectedIndex < 0 Then
            MsgBox("Debe primero seleccionar la campaña", vbExclamation, "CordialPhone")
            cmbListaCampaña.Focus()
            Exit Function
        End If

        validaCampaña = True

    End Function

    Private Sub BtnIngreso_Click(sender As Object, e As EventArgs) Handles BtnIngreso.Click
        If validaCampaña() = True Then
            Ejecutivos.ShowDialog()
            'FormCampaña.Show()
            Me.Close()
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If validaCampaña() = True Then
            FormAdministracionRegistros.ShowDialog()
        End If
    End Sub

    Private Sub btnReferidos_Click(sender As Object, e As EventArgs) Handles btnReferidos.Click
        If validaCampaña() = True Then
            frmCargaReferido.ShowDialog()
        End If
    End Sub

    Private Sub btnHistorialLlamado_Click(sender As Object, e As EventArgs) Handles btnHistorialLlamado.Click
        If validaCampaña() = True Then
            frmHistorialLlamado.ShowDialog()
        End If
    End Sub

    Private Sub cmbListaCampaña_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbListaCampaña.SelectedIndexChanged
        If cmbListaCampaña.ValueMember Is Nothing Or cmbListaCampaña.ValueMember = "" Then
            Exit Sub
        End If
        If cmbListaCampaña.SelectedValue Is Nothing Then
            Exit Sub
        End If

        If cmbListaCampaña.SelectedIndex < 0 Then
            Exit Sub
        End If

        idCrm = cmbListaCampaña.SelectedValue
    End Sub
End Class
