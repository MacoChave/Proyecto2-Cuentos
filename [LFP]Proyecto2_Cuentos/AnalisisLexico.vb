
Public Class AnalisisLexico
    'CONTROL DE ESTADOS
    Dim estado As Integer
    Dim caracter As Char
    Dim tipoCaracter As Integer
    Dim fila As Integer
    Dim columna As Integer
    'CONTROL DE TOKEN
    Dim id_aux As Integer
    Dim lexema As String
    Dim token As String
    Dim tokenEncontrado As New Token
    Dim errorEncontrado As New Errores

    Public Sub Analizar(texto As String)
        ListaToken.listaToken.Clear()
        ListaError.listaError.Clear()
        estado = 0
        fila = 1
        columna = 0

        texto += "#"
        For i As Integer = 0 To texto.Count - 1 Step 1
            caracter = texto.Chars(i)
            tipoCaracter = Get_TipoCaracter(caracter)
            Select Case estado
                Case 0 'ESTADO A
                    Select Case tipoCaracter
                        '_, L, l -> ESTADO B - 1
                        Case 0 '_
                            lexema = caracter
                            columna += 1
                            estado = 1
                        Case 1 'L
                            lexema = caracter
                            columna += 1
                            estado = 1
                        Case 2 'l
                            lexema = caracter
                            columna += 1
                            estado = 1
                            '" -> ESTADO C - 2
                        Case 3 '"
                            lexema = caracter
                            columna += 1
                            estado = 2
                            'd -> ESTADO D - 3
                        Case 4 'd
                            lexema = caracter
                            columna += 1
                            estado = 3
                            '+, -, *, /, (, ), {, }, =, . -> ESTADO E - 4
                        Case 5 '+
                            lexema = caracter
                            token = caracter
                            id_aux = tipoCaracter
                            columna += 1
                            estado = 4
                        Case 6 '-
                            lexema = caracter
                            token = caracter
                            id_aux = tipoCaracter
                            columna += 1
                            estado = 4
                        Case 7 '*
                            lexema = caracter
                            token = caracter
                            id_aux = tipoCaracter
                            columna += 1
                            estado = 4
                        Case 8 '/
                            lexema = caracter
                            token = caracter
                            id_aux = tipoCaracter
                            columna += 1
                            estado = 4
                        Case 9 '(
                            lexema = caracter
                            token = caracter
                            id_aux = tipoCaracter
                            columna += 1
                            estado = 4
                        Case 10 ')
                            lexema = caracter
                            token = caracter
                            id_aux = tipoCaracter
                            columna += 1
                            estado = 4
                        Case 11 '{
                            lexema = caracter
                            token = caracter
                            id_aux = tipoCaracter
                            columna += 1
                            estado = 4
                        Case 12 '}
                            lexema = caracter
                            token = caracter
                            id_aux = tipoCaracter
                            columna += 1
                            estado = 4
                        Case 13 '=
                            lexema = caracter
                            token = caracter
                            id_aux = tipoCaracter
                            columna += 1
                            estado = 4
                        Case 14 '.
                            lexema = caracter
                            token = caracter
                            id_aux = tipoCaracter
                            columna += 1
                            estado = 4
                            '# -> ESTADO F - 5
                        Case 15 ',
                            lexema = caracter
                            token = caracter
                            id_aux = tipoCaracter
                            columna += 1
                            estado = 4
                        Case 16 '#
                            Try
                                If (texto.Count - 1 <> i) Then
                                    columna += 1
                                    estado = 5
                                Else
                                    MessageBox.Show("Análisis léxico finalizado")
                                End If
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                            '17 - ESPACIO
                        Case 17
                            columna += 1
                            '18 - RETORNO
                        Case 18
                            columna = 0
                            fila += 1
                            '19 - TAB
                        Case 19
                            columna += 4
                        Case Else
                            'AGREGAR ERROR
                            errorEncontrado = New Errores
                            errorEncontrado._columna = columna
                            errorEncontrado._fila = fila
                            errorEncontrado._lexema = caracter
                            errorEncontrado._descripcion = "Error léxico, caracter desconocido"
                            ListaError.listaError.Add(errorEncontrado)
                    End Select
                Case 1 'ESTADO B
                    Select Case tipoCaracter
                        '_, L, l -> ESTADO B
                        Case 0 '_
                            lexema += caracter
                            columna += 1
                        Case 1 'L
                            lexema += caracter
                            columna += 1
                        Case 2 'l
                            lexema += caracter
                            columna += 1
                            'OTRO -> ESTADO A - 0
                            'ACEPTACION
                        Case Else
                            If (lexema.Equals("class")) Then
                                token = "clase"
                                id_aux = 24
                                'AGREGAR TOKEN
                            ElseIf (lexema.Equals("def")) Then
                                token = "definicion"
                                id_aux = 25
                                'AGREGAR TOKEN
                            ElseIf (lexema.Equals("__init__")) Then
                                token = "constructor"
                                id_aux = 26
                                'AGREGAR TOKEN
                            ElseIf (lexema.Equals("self")) Then
                                token = "referencia"
                                id_aux = 27
                                'AGREGAR TOKEN
                            ElseIf (lexema.Equals("traductor_a_voz")) Then
                                token = "nombre"
                                id_aux = 28
                                'AGREGAR TOKEN
                            ElseIf (lexema.Equals("resaltar_palabra")) Then
                                token = "nombre"
                                id_aux = 29
                                'AGREGAR TOKEN
                            ElseIf (lexema.Equals("mostrar_texto_cuento")) Then
                                token = "nombre"
                                id_aux = 30
                                'AGREGAR TOKEN
                            ElseIf (lexema.Equals("titulo")) Then
                                token = "variable"
                                id_aux = 31
                                'AGREGAR TOKEN
                            ElseIf (lexema.Equals("cuento")) Then
                                token = "variable"
                                id_aux = 32
                                'AGREGAR TOKEN
                            ElseIf (lexema.Equals("imagen")) Then
                                token = "variable"
                                id_aux = 33
                                'AGREGAR TOKEN
                            ElseIf (lexema.Equals("tipoVoz")) Then
                                token = "variable"
                                id_aux = 34
                                'AGREGAR TOKEN
                            ElseIf (lexema.Equals("volumen")) Then
                                token = "variable"
                                id_aux = 35
                                'AGREGAR TOKEN
                            ElseIf (lexema.Equals("velocidad")) Then
                                token = "variable"
                                id_aux = 36
                                'AGREGAR TOKEN
                            ElseIf (lexema.Equals("traduccion")) Then
                                token = "variable"
                                id_aux = 37
                                'AGREGAR TOKEN
                            ElseIf (lexema.Equals("resaltar")) Then
                                token = "variable"
                                id_aux = 38
                                'AGREGAR TOKEN
                            ElseIf (lexema.Equals("texto")) Then
                                token = "variable"
                                id_aux = 39
                                'AGREGAR TOKEN
                            ElseIf (lexema.Equals("True")) Then
                                token = "si"
                                id_aux = 40
                                'AGREGAR TOKEN
                            ElseIf (lexema.Equals("False")) Then
                                token = "no"
                                id_aux = 41
                                'AGREGAR TOKEN
                            ElseIf (lexema.Equals("Female")) Then
                                token = "f"
                                id_aux = 42
                                'AGREGAR TOKEN
                            ElseIf (lexema.Equals("Male")) Then
                                token = "m"
                                id_aux = 43
                                'AGREGAR TOKEN
                            Else
                                token = "nombre"
                                id_aux = 23
                                'AGREGAR TOKEN
                            End If
                            tokenEncontrado = New Token
                            tokenEncontrado._id = id_aux
                            tokenEncontrado._columna = columna
                            tokenEncontrado._fila = fila
                            tokenEncontrado._lexema = lexema
                            tokenEncontrado._token = token
                            ListaToken.listaToken.Add(tokenEncontrado)

                            lexema = Nothing
                            token = Nothing
                            id_aux = Nothing
                            i -= 1
                            estado = 0
                    End Select
                Case 2 'ESTADO C
                    Select Case tipoCaracter
                        '" -> ESTADO H - 7
                        Case 3 '"
                            lexema += caracter
                            columna += 1
                            estado = 7
                            'caracter -> ESTADO G - 6
                        Case Else 'L, l, caracter
                            lexema += caracter
                            columna += 1
                            estado = 6
                    End Select
                Case 3 'ESTADO D
                    Select Case tipoCaracter
                        'd -> ESTADO D
                        Case 4 'd
                            lexema += caracter
                            columna += 1
                            'cualquiera ACEPTACION
                        Case Else
                            token = "entero"
                            id_aux = 4
                            'AGREGAR TOKEN
                            tokenEncontrado = New Token
                            tokenEncontrado._id = id_aux
                            tokenEncontrado._columna = columna
                            tokenEncontrado._fila = fila
                            tokenEncontrado._lexema = lexema
                            tokenEncontrado._token = token
                            ListaToken.listaToken.Add(tokenEncontrado)

                            lexema = Nothing
                            token = Nothing
                            id_aux = Nothing
                            i -= 1
                            estado = 0
                    End Select
                Case 4 'ESTADO E
                    'AGREGAR TOKEN
                    tokenEncontrado = New Token
                    tokenEncontrado._id = id_aux
                    tokenEncontrado._columna = columna
                    tokenEncontrado._fila = fila
                    tokenEncontrado._lexema = lexema
                    tokenEncontrado._token = token
                    ListaToken.listaToken.Add(tokenEncontrado)

                    i -= 1
                    estado = 0
                    lexema = Nothing
                    token = Nothing
                    id_aux = Nothing
                Case 5 'ESTADO F
                    Select Case tipoCaracter
                        '\n -> ESTADO E - 4
                        Case 18 '\n
                            estado = 0
                            fila += 1
                            columna = 0
                            'cualquiera IGNORAR
                        Case Else
                            columna += 1
                    End Select
                Case 6 'ESTADO G
                    Select Case tipoCaracter
                        '" -> ESTADO E - 4
                        Case 3
                            lexema += caracter
                            token = "cadena"
                            id_aux = 21
                            columna += 1
                            estado = 4
                            'caracter -> ESTADO G - 6
                        Case Else
                            lexema += caracter
                            columna += 1
                    End Select
                Case 7 'ESTADO H
                    Select Case tipoCaracter
                        '" -> ESTADO I - 8
                        Case 3
                            lexema = Nothing
                            columna += 1
                            estado = 8
                            'cualquiera ERROR
                        Case Else
                            columna += 1
                            'AGREGAR ERROR
                            errorEncontrado = New Errores
                            errorEncontrado._columna = columna
                            errorEncontrado._fila = fila
                            errorEncontrado._lexema = caracter
                            errorEncontrado._descripcion = "Error léxico, caracter desconocido"
                            ListaError.listaError.Add(errorEncontrado)
                    End Select
                Case 8 'ESTADO I
                        'INICIA COMENTARIO DE VARIAS LÍNEAS
                    '" -> ESTADO  J - 9
                    estado = 9
                    columna += 1
                Case 9 'ESTADO J
                    Select Case tipoCaracter
                        '" -> ESTADO K - 10
                        Case 3
                            lexema = Nothing
                            columna += 1
                            estado = 10
                            'cualquier caracter
                        Case Else
                            columna += 1
                    End Select
                Case 10 'ESTADO K
                    Select Case tipoCaracter
                        '" -> ESTADO L - 11
                        Case 3
                            lexema = Nothing
                            columna += 1
                            estado = 11
                            'cualquiera ERROR
                        Case Else
                            columna += 1
                            'AGREGAR ERROR
                            errorEncontrado = New Errores
                            errorEncontrado._columna = columna
                            errorEncontrado._fila = fila
                            errorEncontrado._lexema = caracter
                            errorEncontrado._descripcion = "Error léxico, caracter desconocido"
                            ListaError.listaError.Add(errorEncontrado)
                    End Select
                Case 11 'ESTADO L
                    Select Case tipoCaracter
                        '" -> ESTADO E - 4
                        Case 3
                            estado = 0
                            columna += 1
                            'lexema = Nothing
                            'estado = 4
                            'cualquiera ERROR
                        Case Else
                            columna += 1
                            'AGREGAR ERROR
                            errorEncontrado = New Errores
                            errorEncontrado._columna = columna
                            errorEncontrado._fila = fila
                            errorEncontrado._lexema = caracter
                            errorEncontrado._descripcion = "Error léxico, caracter desconocido"
                            ListaError.listaError.Add(errorEncontrado)
                    End Select
            End Select
            tokenEncontrado = Nothing
            errorEncontrado = Nothing
        Next
    End Sub

    Private Function Get_TipoCaracter(caracter) As Integer
        Dim indice As Integer
        Select Case caracter
            Case "_"
                indice = 0
            Case "A" To "Z"
                indice = 1
            Case "a" To "z"
                indice = 2
            Case Chr(34) 'COMILLAS DOBLES
                indice = 3
            Case "0" To "9"
                indice = 4
            Case "+"
                indice = 5
            Case "-"
                indice = 6
            Case "*"
                indice = 7
            Case "/"
                indice = 8
            Case "("
                indice = 9
            Case ")"
                indice = 10
            Case "{"
                indice = 11
            Case "}"
                indice = 12
            Case "="
                indice = 13
            Case "."
                indice = 14
            Case ","
                indice = 15
            Case "#"
                indice = 16
            Case Chr(32) 'ESPACIO
                indice = 17
            Case Chr(10) 'RETORNO
                indice = 18
            Case Chr(9) 'TAB
                indice = 19
            Case Else 'CUALQUIER CARACTER
                indice = 20
        End Select

        Return indice
    End Function


End Class
