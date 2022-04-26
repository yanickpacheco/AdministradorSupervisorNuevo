Imports System.Data.SqlClient

Public Class Ejecutivos
    Dim cnn As New SqlConnection("data source = 192.168.1.14; initial catalog = BASE_GENERAL_CORDIAL; User id= cp; password=Cordial.passs ")
    'Dim cnn As New SqlConnection("data source = 152.231.73.174; initial catalog = BASE_GENERAL_CORDIAL; User id= yp; password=Cordial.passs ")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        GroupBox1.Visible = False
        txtNombre.Text = ""
        txtAsignados.Text = ""
        btnModificar.Visible = False
        chkModificar.Checked = False
        chkUsuario.Checked = False
        Me.Close()
    End Sub

    Private Sub Ejecutivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar_Ejecutivos(1)

    End Sub

    Private Sub Listar_Ejecutivos(ByVal ejecuta As Integer)
        Dim miTabla As New DataTable
        Dim dA As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim sql As String = ""
        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "dbo.Usuarios_Activos"
            cmd.CommandText = sql
            cmd.Parameters.AddWithValue("@idCrm", idCrm)
            cmd.Parameters.AddWithValue("@ejecuta", ejecuta)
            cmd.Connection = cnn
            dA = New SqlDataAdapter(cmd)
            dA.Fill(miTabla)

            dtgEjecutivos.DataSource = miTabla


        Catch ex As Exception
            MsgBox("Error Listar Ejecutivos" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkUsuario.CheckedChanged
        If chkUsuario.Checked = True Then
            GroupBox1.Visible = True
            btnIngresar.Visible = True
            chkModificar.Visible = False
            txtNombre.Text = ""
            cmbPerfil.SelectedIndex = -1
            txtAsignados.Text = ""
        Else
            GroupBox1.Visible = False
            btnIngresar.Visible = False
            chkModificar.Visible = True
        End If



    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If Valida_Campos() = True Then
            IngresaUsuario1(txtNombre.Text, cmbPerfil.SelectedIndex, txtAsignados.Text)
            MsgBox("Ingreso de usuarios con exito", vbInformation, "Ingreso usuarios")
            LimpiaCampos()
            Listar_Ejecutivos(1)
        End If
    End Sub

    Private Function Valida_Campos() As Boolean
        Valida_Campos = False

        If txtNombre.Text = "" Then
            MsgBox("Debe ingresar nombre de usuario", vbInformation, "")
            Exit Function
        End If

        If cmbPerfil.SelectedIndex <= 0 Then
            MsgBox("Debe ingresar tipo de Perfil", vbInformation, "")
            Exit Function
        End If

        If txtAsignados.Text = "" Then
            MsgBox("Debe ingresar cantidad de registros", vbInformation, "")
            Exit Function
        End If

        Valida_Campos = True
    End Function



    Private Sub IngresaUsuario1(ByVal nombre As String, ByVal perfil As String, ByVal asignados As Integer)
        Dim cmd As New SqlCommand
        Dim sql As String
        Dim myTransaction As SqlTransaction

        cnn.Open()
        myTransaction = cnn.BeginTransaction()
        cmd.CommandType = CommandType.StoredProcedure

        sql = "[dbo].[Agrega_Usuarios]"
        cmd.Parameters.AddWithValue("@Usuario", nombre)
        cmd.Parameters.AddWithValue("@Perfil", perfil)
        cmd.Parameters.AddWithValue("@Asignados", asignados)
        cmd.Parameters.AddWithValue("@idCrm", idCrm)
        Try
            cmd.CommandText = sql
            cmd.Connection = cnn
            cmd.Transaction = myTransaction
            'cmd.Parameters("@Usuario").Value = usuario
            'cmd.Parameters("@Perfil").Value = perfil
            'cmd.Parameters("@Asignados").Value = asignados

            cmd.ExecuteNonQuery()
            myTransaction.Commit()
        Catch ex As Exception
            myTransaction.Rollback()
            MsgBox("Error en ingreso de usuario: " & ex.Message, vbInformation)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub LimpiaCampos()
        txtNombre.Text = ""
        cmbPerfil.SelectedIndex = -1
        'cmbPerfil.Visible = False
        txtAsignados.Text = ""
    End Sub

    Private Sub txtAsignados_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAsignados.KeyPress
        If Not (IsNumeric(e.KeyChar)) Then
            If (e.KeyChar <> vbBack) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub dtgEjecutivos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgEjecutivos.CellDoubleClick
        If chkModificar.Checked = True Then
            GroupBox1.Visible = True
            txtNombre.Text = dtgEjecutivos.Rows(e.RowIndex).Cells(0).Value
            cmbPerfil.Text = dtgEjecutivos.Rows(e.RowIndex).Cells(1).Value
            txtAsignados.Text = dtgEjecutivos.Rows(e.RowIndex).Cells(2).Value
            btnModificar.Visible = True
            lblClic.Visible = False
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If Valida_Campos() = True Then
            IngresaUsuario(txtAsignados.Text, txtNombre.Text, cmbPerfil.SelectedIndex)
            LimpiaCampos()
            MsgBox("Modificación de registros asignados con exito", vbInformation, "Registros asignados")
            Listar_Ejecutivos(1)
        End If
    End Sub


    Private Sub IngresaUsuario(ByVal asignados As Integer, ByVal usuario As String, ByVal perfil As String)
        Dim cmd As New SqlCommand
        Dim sql As String
        Dim myTransaction As SqlTransaction

        cnn.Open()
        myTransaction = cnn.BeginTransaction()
        cmd.CommandType = CommandType.StoredProcedure

        sql = "[dbo].[Asignar_Registros]"
        cmd.Parameters.AddWithValue("@Usuario", usuario)
        cmd.Parameters.AddWithValue("@Asignados", asignados)
        cmd.Parameters.AddWithValue("@idCrm", idCrm)
        cmd.Parameters.AddWithValue("@perfil", perfil)
        Try
            cmd.CommandText = sql
            cmd.Connection = cnn
            cmd.Transaction = myTransaction

            cmd.ExecuteNonQuery()
            myTransaction.Commit()
            MsgBox("Seguro que desea actualizar el registro?", vbYesNo, "Actualizar")
        Catch ex As Exception
            myTransaction.Rollback()
            MsgBox("Error modificar usuario: " & ex.Message, vbInformation)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub ActivarDesactivarUsuario(ByVal usuario As String, ByVal activar As Boolean)
        Dim cmd As New SqlCommand
        Dim sql As String
        Dim myTransaction As SqlTransaction

        cnn.Open()
        myTransaction = cnn.BeginTransaction()
        cmd.CommandType = CommandType.StoredProcedure

        sql = "[dbo].[Activar_Desactivar_Usuario]"
        cmd.Parameters.AddWithValue("@Usuario", usuario)
        cmd.Parameters.AddWithValue("@idCrm", idCrm)
        cmd.Parameters.AddWithValue("@activar", activar)
        Try
            cmd.CommandText = sql
            cmd.Connection = cnn
            cmd.Transaction = myTransaction

            cmd.ExecuteNonQuery()
            myTransaction.Commit()
            ' MsgBox("Activar el usuario?", vbYesNo, "Activar")
        Catch ex As Exception
            myTransaction.Rollback()
            MsgBox("Error activar usuario: " & ex.Message, vbInformation)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub chkModificar_CheckedChanged(sender As Object, e As EventArgs) Handles chkModificar.CheckedChanged
        If chkModificar.Checked = True Then
            lblClic.Visible = True
            'GroupBox1.Visible = True
            'btnIngresar.Visible = True
            chkUsuario.Visible = False
            'btnIngresar.Visible = False
        Else
            lblClic.Visible = False
            GroupBox1.Visible = False
            'btnIngresar.Visible = False
            chkUsuario.Visible = True
            'btnIngresar.Visible = True
            btnModificar.Visible = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkTodosEjecutivos.CheckedChanged
        If chkTodosEjecutivos.Checked = True Then
            Listar_Ejecutivos(0)
            txtRed.Visible = True
            lblHabilitar.Visible = True
            For i As Integer = 0 To dtgEjecutivos.Rows.Count - 1
                If dtgEjecutivos.Rows(i).Cells(4).Value = 0 Then
                    dtgEjecutivos.Rows(i).DefaultCellStyle.BackColor = Color.Red
                    dtgEjecutivos.Rows(i).DefaultCellStyle.ForeColor = Color.White
                    'MsgBox("Los valores en rojo son los ejecutivos deshabilitados")
                End If
            Next
        Else
            Listar_Ejecutivos(1)
            txtRed.Visible = False
            lblHabilitar.Visible = False
        End If
    End Sub

    Private Sub dtgEjecutivos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgEjecutivos.CellClick
        'dtgEjecutivos.Rows(e.RowIndex).Cells(4).Value = False
        If chkModificar.Checked = False Then
            'MsgBox("Estado: " & Me.dtgEjecutivos.Rows(e.RowIndex).Cells(4).Value)
            'If dtgEjecutivos.CurrentRow.Cells(4).Value Then

            If dtgEjecutivos.Rows(e.RowIndex).Cells(4).Value = False Then
                If (MsgBox("Desea activar usuario", vbYesNo, "CordialPhone")) = vbYes Then
                    ActivarDesactivarUsuario(dtgEjecutivos.Rows(e.RowIndex).Cells(0).Value, True)
                    dtgEjecutivos.Rows(e.RowIndex).Cells(4).Value = True
                    chkTodosEjecutivos.Checked = False
                End If
                Listar_Ejecutivos(1)
            Else
                If (MsgBox("Desea desactivar el usuario?", vbYesNo, "CordialPhone")) = vbYes Then
                    dtgEjecutivos.Rows(e.RowIndex).Cells(4).Value = False
                    ActivarDesactivarUsuario(dtgEjecutivos.Rows(e.RowIndex).Cells(0).Value, False)
                    chkTodosEjecutivos.Checked = False
                End If
                Listar_Ejecutivos(1)
            End If
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        'txtNombre.Text = UCase(txtNombre.Text)
        txtNombre.CharacterCasing = CharacterCasing.Upper
    End Sub


End Class