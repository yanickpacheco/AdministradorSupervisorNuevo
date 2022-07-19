Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Office.Interop


Public Class FormDescargarBase
    'Dim ruta As String = txtRuta.Text
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
            sql = "Gestion.pa_Detalle_por_campaña"
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

    Public Function exportarExcel(ByVal DGV As DataGridView, ByVal RutaDescarga As String) As Boolean

        Dim exAppGrab As New Microsoft.Office.Interop.Excel.Application
        Dim exLibroGrab As Microsoft.Office.Interop.Excel.Workbook
        Dim exHojaGrab As Microsoft.Office.Interop.Excel.Worksheet

        Try

            exLibroGrab = exAppGrab.Workbooks.Add
            exHojaGrab = exLibroGrab.Worksheets.Add()

            Dim NCol As Integer = DGV.ColumnCount
            Dim NRow As Integer = DGV.RowCount

            exHojaGrab.Cells.Select()
            exAppGrab.Selection.NumberFormat = "@"


            For i As Integer = 1 To NCol
                If DGV.Columns(i - 1).Visible = True Then
                    exHojaGrab.Cells.Item(1, i) = DGV.Columns(i - 1).DataPropertyName.ToString
                    exHojaGrab = FormatoCabecera(exHojaGrab, 1, i)
                End If
            Next


            Dim FilaExcel As Integer = 2


            For Fila As Integer = 0 To NRow - 1

                For Col As Integer = 0 To NCol - 1
                    If DGV.Columns(Col).Visible = True Then
                        If Col = 0 Then
                            exHojaGrab.Cells.Item(FilaExcel, Col + 1) = DGV.Rows(Fila).Cells(Col).Value()
                        Else
                            exHojaGrab.Cells.Item(FilaExcel, Col + 1) = DGV.Rows(Fila).Cells(Col).Value()
                        End If
                    End If
                Next
                FilaExcel = FilaExcel + 1

            Next

            exHojaGrab.Rows.Item(1).Font.Bold = 1
            exHojaGrab.Rows.Item(1).HorizontalAlignment = 3
            exHojaGrab.Rows.Item(1).Font.ThemeColor = Excel.XlThemeColor.xlThemeColorLight1
            exHojaGrab.Columns.AutoFit()

            exHojaGrab.Range("a1").Select()

            'exLibroGrab.SaveAs(RutaDescarga & "/BASE RESULTANTE_" & Date.Now.ToString("ddMMyyyy"))
            exLibroGrab.SaveAs(RutaDescarga & "/BASE DETALLE CAMPAÑA_" & idCrm)

            exHojaGrab = Nothing
            exLibroGrab = Nothing
            exAppGrab.Quit()
            exAppGrab = Nothing

            Return True

        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & vbNewLine & "Error Exportar Excel", MsgBoxStyle.Critical, "Base Resultante")
            Return False
        End Try

    End Function

    Public Function FormatoCabecera(ByVal hojaExcel As Object, ByVal Fila As Integer, ByVal Columna As Integer) As Object

        hojaExcel.cells(Fila, Columna).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        hojaExcel.cells(Fila, Columna).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlThin
        hojaExcel.cells(Fila, Columna).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        hojaExcel.cells(Fila, Columna).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = Excel.XlBorderWeight.xlThin
        hojaExcel.cells(Fila, Columna).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        hojaExcel.cells(Fila, Columna).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = Excel.XlBorderWeight.xlThin
        hojaExcel.cells(Fila, Columna).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        hojaExcel.cells(Fila, Columna).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlThin
        hojaExcel.cells(Fila, Columna).interior.Pattern = Excel.XlPattern.xlPatternSolid
        hojaExcel.cells(Fila, Columna).interior.ThemeColor = Excel.XlThemeColor.xlThemeColorDark1
        hojaExcel.cells(Fila, Columna).interior.TintAndShade = -0.349986266670736
        hojaExcel.cells(Fila, Columna).Font.ThemeColor = Excel.XlThemeColor.xlThemeColorLight1

        Return hojaExcel

    End Function

    Public Function FormatoCabeceraColor(ByVal hojaExcel As Object, ByVal Fila As Integer, ByVal Columna As Integer) As Object

        hojaExcel.cells(Fila, Columna).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        hojaExcel.cells(Fila, Columna).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlThin
        hojaExcel.cells(Fila, Columna).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        hojaExcel.cells(Fila, Columna).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = Excel.XlBorderWeight.xlThin
        hojaExcel.cells(Fila, Columna).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        hojaExcel.cells(Fila, Columna).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = Excel.XlBorderWeight.xlThin
        hojaExcel.cells(Fila, Columna).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        hojaExcel.cells(Fila, Columna).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlThin
        hojaExcel.cells(Fila, Columna).interior.Pattern = Excel.XlPattern.xlPatternSolid
        hojaExcel.cells(Fila, Columna).interior.color = 65535
        hojaExcel.cells(Fila, Columna).Font.ThemeColor = Excel.XlThemeColor.xlThemeColorLight1

        Return hojaExcel

    End Function

    Public Function FormatoFilas(ByVal hojaExcel As Object, ByVal Fila As Integer, ByVal Columna As Integer) As Object

        hojaExcel.cells(Fila, Columna).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        hojaExcel.cells(Fila, Columna).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlThin
        hojaExcel.cells(Fila, Columna).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
        hojaExcel.cells(Fila, Columna).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = Excel.XlBorderWeight.xlThin
        hojaExcel.cells(Fila, Columna).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
        hojaExcel.cells(Fila, Columna).Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = Excel.XlBorderWeight.xlThin
        hojaExcel.cells(Fila, Columna).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
        hojaExcel.cells(Fila, Columna).Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlThin

        Return hojaExcel

    End Function

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        If txtRuta.Text.Trim = "" Then
            MsgBox("Debe seleccionar la ruta donde guardar las grabaciones", vbExclamation, "CORDIALPHONE")
            Exit Sub
        End If

        'descargarGrabaciones()
        If exportarExcel(dtgMuestraBase, txtRuta.Text) = True Then
            MsgBox("Archivo Excel Generado", vbInformation, "CordialPhone")
            'Cursor = System.Windows.Forms.Cursors.Default
        Else
            MsgBox("Grabaciones Exportadas con exito, Archivo Excel No Fue Generado", vbInformation, "CordialPhone")
            'Cursor = System.Windows.Forms.Cursors.Default
        End If
        'Exportar()
        'llenarExcel(dtgMuestraBase)
    End Sub

    Private Sub btnCarpeta_Click(sender As Object, e As EventArgs) Handles btnCarpeta.Click
        Dim carpeta As New FolderBrowserDialog()
        carpeta.ShowDialog()
        txtRuta.Text = carpeta.SelectedPath
    End Sub

    'Private Sub Exportar()
    '    'LblInfo.Tag = LblInfo.Text
    '    'LblInfo.Text = "Generando Archivo Excel..."
    '    Dim migrid As DataGridView
    '    migrid = dtgMuestraBase

    '    System.Windows.Forms.Application.DoEvents()
    '    Dim exApp As New Microsoft.Office.Interop.Excel.Application
    '    Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
    '    Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
    '    Try
    '        'Añadimos el Libro al programa, y la hoja al libro
    '        exLibro = exApp.Workbooks.Add
    '        exHoja = exLibro.Worksheets.Add()
    '        ' ¿Cuantas columnas y cuantas filas?
    '        Dim NCol As Integer = migrid.ColumnCount
    '        Dim NRow As Integer = migrid.RowCount
    '        'Aqui ecorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
    '        For Each col As DataGridViewColumn In migrid.Columns
    '            If col.Visible = True Then
    '                Dim k = col.DisplayIndex
    '                exHoja.Cells.Item(1, k + 1) = migrid.Columns(col.Index).HeaderText.ToUpper
    '            End If
    '        Next



    '        For Each row As DataGridViewRow In migrid.Rows
    '            For Col As Integer = 0 To NCol - 1
    '                If migrid.Columns(Col).Visible Then
    '                    Dim k As Integer = migrid.Columns(Col).DisplayIndex
    '                    exHoja.Cells.Item(row.Index + 2, k + 1) = migrid.Rows(row.Index).Cells(Col).Value
    '                End If
    '            Next
    '        Next
    '        exHoja.Rows.Item(1).Font.Bold = 1
    '        exHoja.Rows.Item(1).HorizontalAlignment = 3
    '        exHoja.Columns.AutoFit()
    '        exApp.Application.Visible = True



    '        'GC.Collect()
    '        'GC.WaitForPendingFinalizers()
    '        'System.Runtime.InteropServices.Marshal.FinalReleaseComObject(exLibro)
    '        'System.Runtime.InteropServices.Marshal.FinalReleaseComObject(exHoja)
    '        'System.Runtime.InteropServices.Marshal.FinalReleaseComObject(exApp)

    '        'exHoja = Nothing
    '        'exLibro = Nothing
    '        'exApp = Nothing

    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
    '    Finally
    '        Try

    '            GC.Collect()
    '            GC.WaitForPendingFinalizers()
    '            System.Runtime.InteropServices.Marshal.FinalReleaseComObject(exLibro)
    '            System.Runtime.InteropServices.Marshal.FinalReleaseComObject(exHoja)
    '            System.Runtime.InteropServices.Marshal.FinalReleaseComObject(exApp)
    '            'LblInfo.Text = LblInfo.Tag
    '        Catch ex As Exception

    '        End Try
    '    End Try
    'End Sub






    'Function llenarExcel(ByVal ElGrid As DataGridView) As Boolean

    '    'Creamos las variables

    '    Dim exApp As New Microsoft.Office.Interop.Excel.Application

    '    Dim exLibro As Microsoft.Office.Interop.Excel.Workbook

    '    Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

    '    Try

    '        'Añadimos el Libro al programa, y la hoja al libro

    '        exLibro = exApp.Workbooks.Add

    '        exHoja = exLibro.Worksheets.Add()

    '        ' ¿Cuantas columnas y cuantas filas?

    '        Dim NCol As Integer = ElGrid.ColumnCount

    '        Dim NRow As Integer = ElGrid.RowCount

    '        'Aqui recorremos todas las filas, y por cada fila todas las columnas

    '        'y vamos escribiendo.

    '        For i As Integer = 1 To NCol

    '            exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).Name.ToString

    '        Next

    '        For Fila As Integer = 0 To NRow - 1

    '            For Col As Integer = 0 To NCol - 1

    '                exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Item(Col, Fila).Value

    '            Next

    '        Next

    '        'Titulo en negrita, Alineado al centro y que el tamaño de la columna

    '        'se ajuste al texto

    '        exHoja.Rows.Item(1).Font.Bold = 1

    '        exHoja.Rows.Item(1).HorizontalAlignment = 3

    '        exHoja.Columns.AutoFit()

    '        'Aplicación visible

    '        exApp.Application.Visible = True

    '        exHoja = Nothing

    '        exLibro = Nothing

    '        exApp = Nothing

    '    Catch ex As Exception

    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")

    '        Return False

    '    End Try

    '    Return True

    'End Function

End Class