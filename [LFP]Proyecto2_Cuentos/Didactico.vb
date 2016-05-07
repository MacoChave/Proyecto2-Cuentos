Public Class Didactico
    Dim nombre As String
    Dim img As String
    Dim cuento As String
    Dim genero As String
    Dim volumen As Integer
    Dim velocidad As Integer
    Dim traduccion As Integer
    Dim resaltar As Boolean
    Dim texto As Boolean
    Private Sub Didactico_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim contador As Integer = 0

        For c As Integer = 0 To ListaCuento.listaCuento.Count - 1 Step 1
            If ListaCuento.listaCuento.Item(c)._idClase = contador And ListaCuento.listaCuento.Item(c)._idMetodo = 0 Then
                Try
                    If ListaCuento.listaCuento.Item(c)._variable.Equals("titulo") Then
                        nombre = ListaCuento.listaCuento.Item(c)._datoString
                    ElseIf ListaCuento.listaCuento.Item(c)._variable.Equals("imagen") Then
                        img = ListaCuento.listaCuento.Item(c)._datoString
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
                
            End If
            If nombre <> Nothing And img <> Nothing Then
                Dim l As ListViewItem
                l = ListView.Items.Add(nombre)

                nombre = Nothing
                img = Nothing
                contador += 1
            End If
        Next
    End Sub

    'Private Sub cmbCancion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCancion.SelectedIndexChanged
    '    MessageBox.Show("Item seleccionado " & cmbCancion.SelectedItem & " con indice " & cmbCancion.SelectedIndex)
    'End Sub

    Private Sub ListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView.SelectedIndexChanged
        Try
            Dim l As ListViewItem
            l = ListView.SelectedItems(0)
            Dim item As Integer = l.Index

            For c As Integer = 0 To ListaCuento.listaCuento.Count - 1 Step 1
                If ListaCuento.listaCuento.Item(c)._idClase = item Then
                    If ListaCuento.listaCuento.Item(c)._idMetodo = 0 And ListaCuento.listaCuento.Item(c)._variable.Equals("cuento") Then
                        cuento = ListaCuento.listaCuento.Item(c)._datoString
                    ElseIf ListaCuento.listaCuento.Item(c)._idMetodo = 0 And ListaCuento.listaCuento.Item(c)._variable.Equals("tipoVoz") Then
                        genero = ListaCuento.listaCuento.Item(c)._datoString
                    ElseIf ListaCuento.listaCuento.Item(c)._idMetodo = 0 And ListaCuento.listaCuento.Item(c)._variable.Equals("volumen") Then
                        volumen = ListaCuento.listaCuento.Item(c)._datoInt
                    ElseIf ListaCuento.listaCuento.Item(c)._idMetodo = 0 And ListaCuento.listaCuento.Item(c)._variable.Equals("velocidad") Then
                        velocidad = ListaCuento.listaCuento.Item(c)._datoInt
                    ElseIf ListaCuento.listaCuento.Item(c)._idMetodo = 1 And ListaCuento.listaCuento.Item(c)._variable.Equals("traduccion") Then
                        traduccion = ListaCuento.listaCuento.Item(c)._datoBoolean
                    ElseIf ListaCuento.listaCuento.Item(c)._idMetodo = 2 And ListaCuento.listaCuento.Item(c)._variable.Equals("resaltar") Then
                        resaltar = ListaCuento.listaCuento.Item(c)._datoBoolean
                    ElseIf ListaCuento.listaCuento.Item(c)._idMetodo = 3 And ListaCuento.listaCuento.Item(c)._variable.Equals("texto") Then
                        texto = ListaCuento.listaCuento.Item(c)._datoBoolean
                    End If
                ElseIf ListaCuento.listaCuento.Item(c)._idClase > item Then
                    Exit For
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnTexto_Click(sender As Object, e As EventArgs) Handles btnTexto.Click
        If texto Then
            RchTxtTexto.Text = cuento
        End If
    End Sub

    Private Sub btnReproducir_Click(sender As Object, e As EventArgs) Handles btnReproducir.Click
        Try
            If traduccion And texto Then
                Dim SAPI As Object
                SAPI = CreateObject("SAPI.spvoice")
                SAPI.speak(cuento)
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        
    End Sub
End Class