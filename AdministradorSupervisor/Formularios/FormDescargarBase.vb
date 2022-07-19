Imports System.Data.SqlClient


Public Class FormDescargarBase
    Dim cnn As New SqlConnection("data source = 192.168.1.14; initial catalog = BASE_GENERAL_CORDIAL; User id= cp; password=Cordial.passs ")

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Muestra_Base(cmbPeriodo.SelectedItem)
    End Sub

    Private Sub Muestra_Base(ByVal periodo As String)
        Dim miTabla As New DataTable
        Dim dA As SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim sql As String = ""
        cmd.CommandType = CommandType.StoredProcedure
        Try
            sql = "Gestion.pa_MuestraBaseResultante"
            cmd.CommandText = sql
            cmd.Parameters.AddWithValue("@idCrm", idCrm)
            cmd.Parameters.AddWithValue("@periodo", periodo)
            cmd.Connection = cnn
            dA = New SqlDataAdapter(cmd)
            dA.Fill(miTabla)

            dtgMuestraBase.DataSource = miTabla


        Catch ex As Exception
            MsgBox("Error Listar Ejecutivos" & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub ExportaExcel()
        'Dim fichero As New SaveFileDialog()
        'fichero.Filter = "Excel (*.xls)|*.xls"
        'If fichero.ShowDialog() = DialogResult.OK Then
        '    Dim aplicacion As Microsoft.Office.Interop.Excel.Application
        '    Dim libros_trabajo As Microsoft.Office.Interop.Excel.Workbook
        '    Dim hoja_trabajo As Microsoft.Office.Interop.Excel.Worksheet
        '    aplicacion = New Microsoft.Office.Interop.Excel.Application()
        '    libros_trabajo = aplicacion.Workbooks.Add()
        '    hoja_trabajo = DirectCast(libros_trabajo.Worksheets.Item(1), Microsoft.Office.Interop.Excel.Worksheet)
        '    'Recorremos el DataGridView rellenando la hoja de trabajo
        '    Dim columnsCount As Integer = dtgMuestraBase.Columns.Count
        '    For i As Integer = 0 To dtgMuestraBase.Rows.Count - 2
        '        For j As Integer = 0 To dtgMuestraBase.Columns.Count - 1
        '            If i = 0 Then 'pintamos cabecera
        '                hoja_trabajo.Cells(i + 1, j + 1) = dtgMuestraBase.Columns(j).HeaderText
        '            Else 'pintamos datos
        '                hoja_trabajo.Cells(i + 1, j + 1) = dtgMuestraBase.Rows(i).Cells(j).Value.ToString()
        '            End If
        '        Next
        '    Next
        '    libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal)
        '    libros_trabajo.Close(True)
        '    aplicacion.Quit()
        Dim dtSource As DataTable
        If dtgMuestraBase.RowCount > 0 Then
            Dim save As New SaveFileDialog
            save.Filter = "ARCHIVO XML (*.xml)|*.xml"
            save.FileName = "EMPLEADOS" & " " & Now.Day & "-" & Now.Month & "-" & Now.Year & ".xml"
            If save.ShowDialog = Windows.Forms.DialogResult.OK Then
                'If Not IO.File.Exists(save.FileName) Then
                Dim fs As System.IO.FileStream
                Dim xtw As System.Xml.XmlTextWriter
                dtSource.TableName = "items"
                fs = New System.IO.FileStream(save.FileName, IO.FileMode.Create)
                xtw = New System.Xml.XmlTextWriter(fs, System.Text.Encoding.Unicode)
                xtw.WriteProcessingInstruction("xml", "version='1.0'")
                xtw.WriteProcessingInstruction("mso-application", "progid='Excel.Sheet'")
                dtSource.WriteXml(xtw)
                xtw.Close()
                MsgBox("SE EXPORTO CORRECTAMENTE")
            End If
        Else
            MsgBox("NO HAY DATOS QUE EXPORTAR", MsgBoxStyle.Critical, "VERIFICAR")
            Exit Sub
        End If
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        ExportaExcel()
    End Sub
End Class