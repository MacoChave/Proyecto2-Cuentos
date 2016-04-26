Public Class Desarrollador

    Dim contador As Integer = 0
    Dim lexico As New AnalisisLexico()
    Dim sintactico As New AnalisisSintactico()
    Dim archivos As New crearArchivo()
    Private Sub MenuNuevo_Click(sender As Object, e As EventArgs) Handles MenuNuevo.Click
        '" & chr(9) & " TAB
        '" & chr(10) & " SALTO
        '" & chr(34) & " COMILLAS
        Dim texto As String
        texto = "Grafica" & Chr(10) &
            "{" & Chr(10) &
            Chr(9) & "Nombre: " & Chr(34) & "Nombre de la grafica" & Chr(34) & ";" & Chr(10) &
            Chr(9) & "Tipo: " & Chr(34) & "Barras|Circular" & Chr(34) & ";" & Chr(10) &
            Chr(9) & "Datos:" & Chr(10) &
            Chr(9) & "{" & Chr(10) &
            Chr(9) & Chr(9) & "Intervalo 1 = {[ Limite inferior - Limite superior ], Frecuencia absoluta};" & Chr(10) &
            Chr(9) & "}" & Chr(10) &
            "}"
        addPage("Pestaña " & contador + 1, texto)
    End Sub

    Private Sub MenuAbrir_Click(sender As Object, e As EventArgs) Handles MenuAbrir.Click
        Try
            Dim OFD As New OpenFileDialog
            OFD.Title = "Seleccione su archivo"
            OFD.Filter = "Archivo LFP-py | *.py"
            OFD.ShowDialog()

            Dim SR As New IO.StreamReader(OFD.FileName)
            addPage(OFD.SafeFileName, SR.ReadToEnd)
            SR.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "¡ERROR!")
        End Try

    End Sub

    Private Sub addPage(text As String, texto As String)
        Dim newPage As New TabPage()
        newPage.Name = "Pestaña" & contador
        newPage.Text = text

        TabControl.TabPages.Add(newPage)
        addCaja(newPage, texto)
        TabControl.SelectedTab = newPage
        contador += 1
    End Sub

    Private Sub addCaja(newPage As TabPage, texto As String)
        Dim newRText As New RichTextBox
        newRText.Name = "rchText" & contador
        newRText.Parent = newPage
        newRText.Dock = DockStyle.Fill
        newRText.ForeColor = Color.Teal
        newRText.Font = New Font("Consolas", 12, FontStyle.Regular, GraphicsUnit.Pixel)
        newRText.Text = texto

        newPage.Controls.Add(newRText)
    End Sub

    Private Sub MenuGuardar_Click(sender As Object, e As EventArgs) Handles MenuGuardar.Click
        Try
            Dim childControl As Control
            If (TabControl.SelectedTab.HasChildren) Then
                For Each childControl In TabControl.SelectedTab.Controls
                    If TypeOf childControl Is RichTextBox Then
                        Dim SFD As New SaveFileDialog
                        SFD.Title = "Seleccione el destino"
                        SFD.Filter = "Archivo LFP-py | *.py"
                        SFD.ShowDialog()

                        Dim SW As New IO.StreamWriter(SFD.FileName)
                        SW.Write(childControl.Text)
                        SW.Close()
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "¡ERROR!")
        End Try
    End Sub

    Private Sub MenuCerrar_Click(sender As Object, e As EventArgs) Handles MenuCerrar.Click
        Try
            TabControl.TabPages.Remove(TabControl.SelectedTab)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "¡ERROR!")
        End Try
    End Sub

    Private Sub MenuCerrarTodo_Click(sender As Object, e As EventArgs) Handles MenuCerrarTodo.Click
        Try
            TabControl.TabPages.Clear()
            contador = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message, "¡ERROR!")
        End Try
    End Sub

    Private Sub MenuSalir_Click(sender As Object, e As EventArgs) Handles MenuSalir.Click
        End
    End Sub

    Private Sub MenuGenerarArchivo_Click(sender As Object, e As EventArgs) Handles MenuGenerarArchivo.Click
        Try
            archivos.tokenHtml()
            archivos.errorHtml()
            MessageBox.Show("Tablas generadas satisfactoriamente" & vbCrLf &
                            "Las tablas se encuentran en el escritorio", "¡EXITO!")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "¡ERROR!")
        End Try

    End Sub

    Private Sub MenuManual_Click(sender As Object, e As EventArgs) Handles MenuManual.Click
        System.Diagnostics.Process.Start("file:///C:/Users/u/Desktop/Practica-2 LFP/Documentacion/Manual de usuario.pdf")
    End Sub

    Private Sub MenuAcerca_Click(sender As Object, e As EventArgs) Handles MenuAcercaDe.Click
        MessageBox.Show("Practica 2 " & vbCrLf &
                        "Lenguajes Formales y de Programación" & vbCrLf &
                        "Nombre: Marco Antonio Fidencio Chávez Fuentes" & vbCrLf &
                        "Carne: 2010-20831", "Acerca De")
    End Sub

    Private Sub btnALexico_Click(sender As Object, e As EventArgs) Handles btnALexico.Click
        Try
            Dim childControl As Control
            If (TabControl.SelectedTab.HasChildren) Then
                For Each childControl In TabControl.SelectedTab.Controls
                    If TypeOf childControl Is RichTextBox Then
                        lexico.Analizar(childControl.Text)
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "¡ERROR!")
        End Try
    End Sub

    Private Sub btnASintactico_Click(sender As Object, e As EventArgs) Handles btnASintactico.Click
        If (ListaError.listaError.Count > 0) Then
            MessageBox.Show("Se encontraron errores léxicos" & vbCrLf &
                            "No se procederá con el análisis sintactico" & vbCrLf &
                            "Genere archivos para ver los errores", "¡ERROR!")
        Else
            sintactico.Analizar()
        End If
    End Sub

    Private Sub btnGenerarArchivos_Click(sender As Object, e As EventArgs) Handles btnGenerarArchivos.Click

    End Sub
End Class