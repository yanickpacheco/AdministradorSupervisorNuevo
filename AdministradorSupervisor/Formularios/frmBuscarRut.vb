Imports System.Data.SqlClient

Public Class frmBuscarRut

    Dim cnn As New SqlConnection("data source = 192.168.1.14; initial catalog = BASE_GENERAL_CORDIAL; User id= cp; password=Cordial.passs")
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        System.Windows.Forms.Cursor.Current = Windows.Forms.Cursors.WaitCursor
        If txtRut.Text.Length < 6 Then
            MsgBox("Debe ingresar un rut válido", MsgBoxStyle.Information)
            Exit Sub
        End If
        txtDv.Text = buscarDigito(txtRut.Text)
        dtgDatosRut.DataSource = Nothing
        BuscaInfoRut(txtRut.Text)
        System.Windows.Forms.Cursor.Current = Windows.Forms.Cursors.Default
    End Sub


    Private Sub BuscaInfoRut(ByVal rut As String)
        Dim tabla As New DataTable
        Dim da As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim Simbolo As String = ""
        Dim sql As String = ""


        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "[Config].[pa_BuscarRutInfo]"
            cmd.Parameters.AddWithValue("@RUT", rut)

            cmd.CommandText = sql
            cmd.Connection = cnn
            da = New SqlDataAdapter(cmd)
            da.Fill(tabla)

            If tabla.Rows.Count > 0 Then
                dtgDatosRut.DataSource = tabla
                dtgDatosRut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                For i As Integer = 0 To dtgDatosRut.Rows.Count - 1
                    If dtgDatosRut.Rows(i).Cells(1).Value = "SI" Then
                        dtgDatosRut.Rows(i).DefaultCellStyle.BackColor = Color.SkyBlue
                        'dtgDatosRut.Rows(i).DefaultCellStyle.ForeColor = Color.White
                    End If
                Next

            Else
                MsgBox("Rut no se encuentra cargado en ninguna base actual", vbInformation, "CordialPhone")
            End If


        Catch ex As Exception
            MsgBox("Error Buscar Rut" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub frmBuscarRut_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtRut.Text = ""
        txtdv.text = ""
        dtgDatosRut.DataSource = Nothing

    End Sub

    Private Function buscarDigito(rut As String) As String
        Dim t As Integer
        Dim aux As Integer
        Dim aux1 As Integer
        Dim dv As String

        t = 2
        For i = 0 To Len(rut) - 1
            aux = aux + Val(Mid$(rut, Len(rut) - i, 1)) * t

            If t > 6 Then
                t = 2
            Else
                t = t + 1
            End If

        Next i

        aux1 = 11 - (aux Mod 11)

        If aux1 < 10 Then
            dv = aux1
        Else
            dv = "K"
        End If

        Return dv

    End Function

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub
End Class