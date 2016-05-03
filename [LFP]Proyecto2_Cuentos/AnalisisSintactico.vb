
Class AnalisisSintactico
    'DATOS DEL CUENTO
    Private idCuento As Integer = 0
    Private titulo As String
    Private cuento As String
    Private imagen As String
    Private tipoVoz As String
    Private volumen As Integer
    Private velocidad As Integer
    Private traduccion As Boolean
    Private resaltar As Boolean
    Private texto As Boolean

    'MANEJO DE ERRORES
    Dim siguiente As String
    Dim errorEncontrado As New Errores

    'INSTANCIAR CUENTO
    Dim cuentoNuevo As New Cuento
    Public Sub Analizar()
        Dim pila As New Stack
        Dim destino As Char = "i"
        Dim origen As Char
        Dim pop As String
        Dim push As String

        Dim i As Integer = 0
        Dim entrada As String
        Dim prod As Char = "S"
        Dim tope As Integer = ListaToken.listaToken.Count

        Dim finMet As Boolean = False
        Dim fin As Boolean = True

        While (fin)

            Select Case destino
                Case "i"
                    'i  --  --  P   #
                    push = "#"
                    pila.Push(push)
                    origen = destino
                    destino = "P"
                Case "P"
                    'P  --  --  q   S
                    push = "S"
                    pila.Push(push)
                    origen = destino
                    destino = "q"
                Case "q"
                    If (i < tope) Then
                        'ENTRADA A ANALIZAR
                        entrada = ListaToken.listaToken.Item(i)._token
                        Select Case pila.Peek
                            'TERMINALES
                            Case "clase"
                                Console.WriteLine(pila.Pop)
                            Case "nombre"
                                Console.WriteLine(pila.Pop)
                            Case "{"
                                Console.WriteLine(pila.Pop)
                            Case "}"
                                Console.WriteLine(pila.Pop)
                            Case "definicion"
                                Console.WriteLine(pila.Pop)
                            Case "constructor"
                                Console.WriteLine(pila.Pop)
                            Case "("
                                Console.WriteLine(pila.Pop)
                            Case "referencia"
                                Console.WriteLine(pila.Pop)
                            Case "."
                                Console.WriteLine(pila.Pop)
                            Case ")"
                                Console.WriteLine(pila.Pop)
                            Case "cadena"
                                Console.WriteLine(pila.Pop)
                            Case "variable"
                                Console.WriteLine(pila.Pop)
                            Case "="
                                Console.WriteLine(pila.Pop)
                            Case ","
                                Console.WriteLine(pila.Pop)
                            Case "+"
                                Console.WriteLine(pila.Pop)
                            Case "-"
                                Console.WriteLine(pila.Pop)
                            Case "*"
                                Console.WriteLine(pila.Pop)
                            Case "/"
                                Console.WriteLine(pila.Pop)
                            Case "valorvar"
                                Console.WriteLine(pila.Pop)
                            Case "entero"
                                Console.WriteLine(pila.Pop)
                            Case "no"
                                Console.WriteLine(pila.Pop)
                            Case "si"
                                Console.WriteLine(pila.Pop)

                                'NO TERMINALES
                            Case "S"
                                If (entrada.Equals("clase")) Then
                                    pila.Pop()
                                    pila.Push("CLASE")
                                    pila.Push(entrada)
                                    siguiente = "nombre"
                                    i += 1
                                Else
                                    errorEncontrado = New Errores
                                    errorEncontrado._columna = ListaToken.listaToken.Item(i)._columna
                                    errorEncontrado._fila = ListaToken.listaToken.Item(i)._fila
                                    errorEncontrado._lexema = ListaToken.listaToken.Item(i)._lexema
                                    errorEncontrado._descripcion = "Error sintáctico, se esperaba reservada class"
                                    i += 1
                                End If
                            Case "CLASE"
                                If (entrada.Equals("clase")) Then
                                    pila.Push(entrada)
                                    siguiente = "nombre"
                                    i += 1
                                ElseIf (entrada.Equals("nombre")) Then
                                    pila.Push(entrada)
                                    siguiente = "{"
                                    i += 1
                                ElseIf (entrada.Equals("{")) Then
                                    pila.Push("CUERPO")
                                    pila.Push(entrada)
                                    siguiente = "reservada def"
                                    i += 1
                                ElseIf (entrada.Equals("}")) Then
                                    If (i < tope - 1) Then
                                        pila.Push(entrada)
                                        siguiente = "reservada class"
                                        i += 1
                                    Else
                                        pila.Pop()
                                        pila.Push(entrada)
                                    End If
                                Else
                                    errorEncontrado = New Errores
                                    errorEncontrado._columna = ListaToken.listaToken.Item(i)._columna
                                    errorEncontrado._fila = ListaToken.listaToken.Item(i)._fila
                                    errorEncontrado._lexema = ListaToken.listaToken.Item(i)._lexema
                                    errorEncontrado._descripcion = "Error sintáctico, se esperaba " & siguiente
                                    i += 1
                                End If
                            Case "CUERPO"
                                If (entrada.Equals("definicion")) Then
                                    pila.Pop()
                                    pila.Push("METODO")
                                    pila.Push("CONSTRUCTOR")
                                    pila.Push(entrada)
                                    siguiente = "reservada __init__"
                                    i += 1
                                ElseIf (entrada.Equals("nombre")) Then
                                    pila.Push("TAGVAR")
                                    pila.Push(entrada)
                                    siguiente = "= o ,"
                                    i += 1
                                Else
                                    errorEncontrado = New Errores
                                    errorEncontrado._columna = ListaToken.listaToken.Item(i)._columna
                                    errorEncontrado._fila = ListaToken.listaToken.Item(i)._fila
                                    errorEncontrado._lexema = ListaToken.listaToken.Item(i)._lexema
                                    errorEncontrado._descripcion = "Error sintáctico, se esperaba " & siguiente
                                    i += 1
                                End If
                            Case "CONSTRUCTOR"
                                If (entrada.Equals("constructor")) Then
                                    pila.Push(entrada)
                                    i += 1
                                    siguiente = "("
                                ElseIf (entrada.Equals("(")) Then
                                    pila.Push(entrada)
                                    i += 1
                                    siguiente = "reservada self"
                                ElseIf (entrada.Equals("referencia")) Then
                                    pila.Push(entrada)
                                    i += 1
                                    siguiente = ")"
                                ElseIf (entrada.Equals(")")) Then
                                    pila.Push(entrada)
                                    i += 1
                                    siguiente = "{"
                                ElseIf (entrada.Equals("{")) Then
                                    pila.Push("VARCONSTRUCTOR")
                                    pila.Push(entrada)
                                    i += 1
                                    siguiente = "reservada self"
                                ElseIf (entrada.Equals("}")) Then
                                    pila.Pop()
                                    pila.Push(entrada)
                                    i += 1
                                    siguiente = "reservada def"
                                Else
                                    errorEncontrado = New Errores
                                    errorEncontrado._columna = ListaToken.listaToken.Item(i)._columna
                                    errorEncontrado._fila = ListaToken.listaToken.Item(i)._fila
                                    errorEncontrado._lexema = ListaToken.listaToken.Item(i)._lexema
                                    errorEncontrado._descripcion = "Error sintáctico, se esperaba " & siguiente
                                    i += 1
                                End If
                            Case "VARCONSTRUCTOR"
                                If (entrada.Equals("referencia")) Then
                                    pila.Push(entrada)
                                    i += 1
                                    siguiente = "."
                                ElseIf (entrada.Equals(".")) Then
                                    pila.Push("VARIABLE")
                                    pila.Push(entrada)
                                    i += 1
                                    siguiente = "variable"
                                Else
                                    pila.Pop()
                                    'errorEncontrado = New Errores
                                    'errorEncontrado._columna = ListaToken.listaToken.Item(i)._columna
                                    'errorEncontrado._fila = ListaToken.listaToken.Item(i)._fila
                                    'errorEncontrado._lexema = ListaToken.listaToken.Item(i)._lexema
                                    'errorEncontrado._descripcion = "Error sintáctico, se esperaba " & siguiente
                                    'i += 1
                                End If
                            Case "METODO"
                                If (entrada.Equals("definicion")) Then
                                    pila.Push(entrada)
                                    i += 1
                                    siguiente = "nombre"
                                    finMet = False
                                ElseIf (entrada.Equals("nombre")) Then
                                    pila.Push(entrada)
                                    i += 1
                                    siguiente = "("
                                ElseIf (entrada.Equals("(")) Then
                                    pila.Push(entrada)
                                    i += 1
                                    siguiente = "reservada self"
                                ElseIf (entrada.Equals("referencia")) Then
                                    pila.Push(entrada)
                                    i += 1
                                    siguiente = ")"
                                ElseIf (entrada.Equals(")")) Then
                                    pila.Push(entrada)
                                    i += 1
                                    siguiente = "{"
                                ElseIf (entrada.Equals("{")) Then
                                    pila.Push("VARIABLE")
                                    pila.Push(entrada)
                                    i += 1
                                    siguiente = "variable"
                                ElseIf (entrada.Equals("}")) Then
                                    If (finMet) Then
                                        pila.Pop()
                                    Else
                                        pila.Push(entrada)
                                        i += 1
                                        siguiente = "reservada def o cierre de clase"
                                        finMet = True
                                    End If
                                Else
                                    'pila.Pop()
                                    'errorEncontrado = New Errores
                                    'errorEncontrado._columna = ListaToken.listaToken.Item(i)._columna
                                    'errorEncontrado._fila = ListaToken.listaToken.Item(i)._fila
                                    'errorEncontrado._lexema = ListaToken.listaToken.Item(i)._lexema
                                    'errorEncontrado._descripcion = "Error sintáctico, se esperaba " & siguiente
                                    'i += 1
                                End If
                            Case "VARIABLE"
                                If (entrada.Equals("variable")) Then
                                    pila.Push(entrada)
                                    i += 1
                                    siguiente = "="
                                ElseIf (entrada.Equals("=")) Then
                                    pila.Pop()
                                    pila.Push("VALOR")
                                    pila.Push(entrada)
                                    i += 1
                                    siguiente = "valor"
                                Else
                                    errorEncontrado = New Errores
                                    errorEncontrado._columna = ListaToken.listaToken.Item(i)._columna
                                    errorEncontrado._fila = ListaToken.listaToken.Item(i)._fila
                                    errorEncontrado._lexema = ListaToken.listaToken.Item(i)._lexema
                                    errorEncontrado._descripcion = "Error sintáctico, se esperaba " & siguiente
                                    i += 1
                                End If
                            Case "VALOR"
                                If (entrada.Equals("cadena")) Then
                                    pila.Pop()
                                    pila.Push(entrada)
                                    i += 1
                                ElseIf (entrada.Equals("nombre")) Then
                                    pila.Pop()
                                    pila.Push(entrada)
                                    i += 1
                                ElseIf (entrada.Equals("si")) Then
                                    pila.Pop()
                                    pila.Push(entrada)
                                    i += 1
                                ElseIf (entrada.Equals("no")) Then
                                    pila.Pop()
                                    pila.Push(entrada)
                                    i += 1
                                ElseIf (entrada.Equals("f")) Then
                                    pila.Pop()
                                    pila.Push(entrada)
                                    i += 1
                                ElseIf (entrada.Equals("m")) Then
                                    pila.Pop()
                                    pila.Push(entrada)
                                    i += 1
                                Else
                                    pila.Pop()
                                    pila.Push("E")
                                End If
                            Case "TAGVAR"
                                If (entrada.Equals("=")) Then
                                    pila.Pop()
                                    pila.Push("VALOR")
                                    pila.Push(entrada)
                                    i += 1
                                    siguiente = "valor"
                                ElseIf (entrada.Equals(",")) Then
                                    pila.Pop()
                                    pila.Push("VARS")
                                    pila.Push(entrada)
                                    i += 1
                                    siguiente = "variable"
                                Else
                                    errorEncontrado = New Errores
                                    errorEncontrado._columna = ListaToken.listaToken.Item(i)._columna
                                    errorEncontrado._fila = ListaToken.listaToken.Item(i)._fila
                                    errorEncontrado._lexema = ListaToken.listaToken.Item(i)._lexema
                                    errorEncontrado._descripcion = "Error sintáctico, se esperaba " & siguiente
                                    i += 1
                                End If
                            Case "VARS"
                                If (entrada.Equals("nombre")) Then
                                    pila.Pop()
                                    pila.Push("LISTAVAR")
                                    pila.Push(entrada)
                                    i += 1
                                    siguiente = ","
                                ElseIf (entrada.Equals("=")) Then
                                    pila.Pop()
                                    pila.Push("VALORES")
                                    pila.Push("VALOR")
                                    pila.Push(entrada)
                                    i += 1
                                    siguiente = "valores"
                                Else
                                    errorEncontrado = New Errores
                                    errorEncontrado._columna = ListaToken.listaToken.Item(i)._columna
                                    errorEncontrado._fila = ListaToken.listaToken.Item(i)._fila
                                    errorEncontrado._lexema = ListaToken.listaToken.Item(i)._lexema
                                    errorEncontrado._descripcion = "Error sintáctico, se esperaba " & siguiente
                                    i += 1
                                End If
                            Case "LISTAVAR"
                                If (entrada.Equals(",")) Then
                                    pila.Pop()
                                    pila.Push("VARS")
                                    pila.Push(entrada)
                                    i += 1
                                    siguiente = "variable o ="
                                ElseIf (entrada.Equals("=")) Then
                                    pila.Pop()
                                    pila.Push("VALORES")
                                    pila.Push("VALOR")
                                    pila.Push(entrada)
                                    i += 1
                                    siguiente = "valor"
                                Else
                                    errorEncontrado = New Errores
                                    errorEncontrado._columna = ListaToken.listaToken.Item(i)._columna
                                    errorEncontrado._fila = ListaToken.listaToken.Item(i)._fila
                                    errorEncontrado._lexema = ListaToken.listaToken.Item(i)._lexema
                                    errorEncontrado._descripcion = "Error sintáctico, se esperaba " & siguiente
                                    i += 1
                                End If
                            Case "VALORES"
                                If (entrada.Equals(",")) Then
                                    pila.Push("VALOR")
                                    pila.Push(entrada)
                                    i += 1
                                    siguiente = "reservada def"
                                Else
                                    pila.Pop()
                                    'errorEncontrado = New Errores
                                    'errorEncontrado._columna = ListaToken.listaToken.Item(i)._columna
                                    'errorEncontrado._fila = ListaToken.listaToken.Item(i)._fila
                                    'errorEncontrado._lexema = ListaToken.listaToken.Item(i)._lexema
                                    'errorEncontrado._descripcion = "Error sintáctico, se esperaba " & siguiente
                                    'i += 1
                                End If
                            Case "E"
                                pila.Pop()
                                pila.Push("E2")
                                pila.Push("T")
                            Case "E2"
                                If (entrada.Equals("+")) Then
                                    pila.Push("T")
                                    pila.Push(entrada)
                                    i += 1
                                    siguiente = "valor"
                                ElseIf (entrada.Equals("-")) Then
                                    pila.Push("T")
                                    pila.Push(entrada)
                                    i += 1
                                    siguiente = "valor"
                                Else
                                    pila.Pop()
                                End If
                            Case "T"
                                pila.Pop()
                                pila.Push("T2")
                                pila.Push("F")
                            Case "T2"
                                If (entrada.Equals("*")) Then
                                    pila.Push("F")
                                    pila.Push(entrada)
                                    i += 1
                                    siguiente = "valor"
                                ElseIf (entrada.Equals("/")) Then
                                    pila.Push("F")
                                    pila.Push(entrada)
                                    i += 1
                                    siguiente = "valor"
                                Else
                                    pila.Pop()
                                End If
                            Case "F"
                                If (entrada.Equals("entero")) Then
                                    pila.Pop()
                                    pila.Push(entrada)
                                    i += 1
                                ElseIf (entrada.Equals("(")) Then
                                    pila.Push("E")
                                    pila.Push(entrada)
                                    i += 1
                                    siguiente = "entero"
                                ElseIf (entrada.Equals(")")) Then
                                    pila.Pop()
                                    pila.Push(entrada)
                                    i += 1
                                Else
                                    errorEncontrado = New Errores
                                    errorEncontrado._columna = ListaToken.listaToken.Item(i)._columna
                                    errorEncontrado._fila = ListaToken.listaToken.Item(i)._fila
                                    errorEncontrado._lexema = ListaToken.listaToken.Item(i)._lexema
                                    errorEncontrado._descripcion = "Error sintáctico, se esperaba " & siguiente
                                    i += 1
                                End If
                            Case "#"
                                pop = pila.Pop
                                destino = "f"
                        End Select
                    End If

                Case "f"
                    fin = False
                    MessageBox.Show("Análisis sintáctico finalizado", "Exito")
            End Select
            pop = Nothing
            push = Nothing
        End While
    End Sub

End Class
