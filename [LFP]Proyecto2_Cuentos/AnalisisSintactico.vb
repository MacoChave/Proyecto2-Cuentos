
Class AnalisisSintactico
    'DATOS DEL CUENTO
    Private idClase As Integer
    Private idMetodo As Integer
    Private variable As String
    Private token As String
    Private tipoDato As String
    Private datoInt As Integer
    Private datoString As String
    Private datoBoolean As Boolean

    'MANEJO DE ERRORES
    Dim siguiente As String
    Dim errorEncontrado As New Errores

    'INSTANCIAR CUENTO
    Dim cuentoNuevo As New Cuento
    Public Sub Analizar()
        Dim pila As New Stack

        Dim var As New Stack
        Dim auxVar As New Stack

        Dim destino As Char = "i"
        Dim contador As Integer = 0
        Dim i As Integer = 0
        Dim entrada As String
        Dim lexema As String
        Dim prod As Char = "S"
        Dim tope As Integer = ListaToken.listaToken.Count
        Dim finMet As Boolean = False
        Dim finClase As Boolean = True

        While (finClase)

            Select Case destino
                Case "i"
                    'i  --  --  P   #
                    pila.Push("#")
                    destino = "P"
                Case "P"
                    'P  --  --  q   S
                    pila.Push("S")
                    destino = "q"
                Case "q"
                    If (contador < tope) Then
                        'ENTRADA A ANALIZAR
                        entrada = ListaToken.listaToken.Item(contador)._token
                        idClase = 0
                        Select Case pila.Peek
                            'TERMINALES
                            Case "clase"
                                Console.WriteLine(pila.Pop)
                            Case "nombre"
                                Console.WriteLine(pila.Pop)
                            Case "metodo"
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
                                    contador += 1
                                Else
                                    errorEncontrado = New Errores
                                    errorEncontrado._columna = ListaToken.listaToken.Item(contador)._columna
                                    errorEncontrado._fila = ListaToken.listaToken.Item(contador)._fila
                                    errorEncontrado._lexema = ListaToken.listaToken.Item(contador)._lexema
                                    errorEncontrado._descripcion = "Error sintáctico, se esperaba reservada class"
                                    contador += 1
                                End If
                            Case "CLASE"
                                If (entrada.Equals("clase")) Then
                                    pila.Push(entrada)
                                    siguiente = "nombre"
                                    contador += 1
                                ElseIf (entrada.Equals("nombre")) Then
                                    pila.Push(entrada)
                                    siguiente = "{"
                                    contador += 1
                                ElseIf (entrada.Equals("{")) Then
                                    pila.Push("CUERPO")
                                    pila.Push(entrada)
                                    siguiente = "reservada def"
                                    contador += 1
                                    'SE ABRIÓ UNA CLASE
                                    idClase += 1
                                ElseIf (entrada.Equals("}")) Then
                                    If (contador < tope - 1) Then
                                        pila.Push(entrada)
                                        siguiente = "reservada class"
                                        contador += 1
                                    Else
                                        pila.Pop()
                                        pila.Push(entrada)
                                    End If
                                Else
                                    errorEncontrado = New Errores
                                    errorEncontrado._columna = ListaToken.listaToken.Item(contador)._columna
                                    errorEncontrado._fila = ListaToken.listaToken.Item(contador)._fila
                                    errorEncontrado._lexema = ListaToken.listaToken.Item(contador)._lexema
                                    errorEncontrado._descripcion = "Error sintáctico, se esperaba " & siguiente
                                    contador += 1
                                End If
                            Case "CUERPO"
                                If (entrada.Equals("definicion")) Then
                                    pila.Pop()
                                    pila.Push("METODO")
                                    pila.Push("CONSTRUCTOR")
                                    pila.Push(entrada)
                                    siguiente = "reservada __init__"
                                    contador += 1
                                ElseIf (entrada.Equals("nombre")) Then
                                    pila.Push("TAGVAR")
                                    pila.Push(entrada)
                                    siguiente = "= o ,"
                                    contador += 1

                                    variable = ListaToken.listaToken(i)._lexema
                                    var.Push(variable)
                                Else
                                    errorEncontrado = New Errores
                                    errorEncontrado._columna = ListaToken.listaToken.Item(contador)._columna
                                    errorEncontrado._fila = ListaToken.listaToken.Item(contador)._fila
                                    errorEncontrado._lexema = ListaToken.listaToken.Item(contador)._lexema
                                    errorEncontrado._descripcion = "Error sintáctico, se esperaba " & siguiente
                                    contador += 1
                                End If
                            Case "CONSTRUCTOR"
                                If (entrada.Equals("constructor")) Then
                                    pila.Push(entrada)
                                    contador += 1
                                    siguiente = "("
                                ElseIf (entrada.Equals("(")) Then
                                    pila.Push(entrada)
                                    contador += 1
                                    siguiente = "reservada self"
                                ElseIf (entrada.Equals("referencia")) Then
                                    pila.Push(entrada)
                                    contador += 1
                                    siguiente = ")"
                                ElseIf (entrada.Equals(")")) Then
                                    pila.Push(entrada)
                                    contador += 1
                                    siguiente = "{"
                                ElseIf (entrada.Equals("{")) Then
                                    pila.Push("VARCONSTRUCTOR")
                                    pila.Push(entrada)
                                    contador += 1
                                    siguiente = "reservada self"
                                    'SE ABRIÓ CONSTRUCTOR
                                    idMetodo = 0
                                ElseIf (entrada.Equals("}")) Then
                                    pila.Pop()
                                    pila.Push(entrada)
                                    contador += 1
                                    siguiente = "reservada def"
                                Else
                                    errorEncontrado = New Errores
                                    errorEncontrado._columna = ListaToken.listaToken.Item(contador)._columna
                                    errorEncontrado._fila = ListaToken.listaToken.Item(contador)._fila
                                    errorEncontrado._lexema = ListaToken.listaToken.Item(contador)._lexema
                                    errorEncontrado._descripcion = "Error sintáctico, se esperaba " & siguiente
                                    contador += 1
                                End If
                            Case "VARCONSTRUCTOR"
                                If (entrada.Equals("referencia")) Then
                                    pila.Push(entrada)
                                    contador += 1
                                    siguiente = "."
                                ElseIf (entrada.Equals(".")) Then
                                    pila.Push("VARIABLE")
                                    pila.Push(entrada)
                                    contador += 1
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
                                    contador += 1
                                    siguiente = "nombre"
                                    finMet = False
                                ElseIf (entrada.Equals("metodo")) Then
                                    pila.Push(entrada)
                                    contador += 1
                                    siguiente = "("
                                    'DIFERENCIAR LOS METODOS
                                    If (ListaToken.listaToken.Item(i)._lexema.Equals("traducir_a_voz")) Then
                                        idMetodo = 1
                                    ElseIf (ListaToken.listaToken.Item(i)._lexema.Equals("resaltar_palabra")) Then
                                        idMetodo = 2
                                    ElseIf (ListaToken.listaToken.Item(i)._lexema.Equals("mostrar_texto_cuento")) Then
                                        idMetodo = 3
                                    End If
                                ElseIf (entrada.Equals("(")) Then
                                    pila.Push(entrada)
                                    contador += 1
                                    siguiente = "reservada self"
                                ElseIf (entrada.Equals("referencia")) Then
                                    pila.Push(entrada)
                                    contador += 1
                                    siguiente = ")"
                                ElseIf (entrada.Equals(")")) Then
                                    pila.Push(entrada)
                                    contador += 1
                                    siguiente = "{"
                                ElseIf (entrada.Equals("{")) Then
                                    pila.Push("VARIABLE")
                                    pila.Push(entrada)
                                    contador += 1
                                    siguiente = "variable"
                                ElseIf (entrada.Equals("}")) Then
                                    If (finMet) Then
                                        pila.Pop()
                                    Else
                                        pila.Push(entrada)
                                        contador += 1
                                        siguiente = "reservada def o cierre de clase"
                                        finMet = True
                                    End If
                                Else
                                    pila.Pop()
                                    errorEncontrado = New Errores
                                    errorEncontrado._columna = ListaToken.listaToken.Item(i)._columna
                                    errorEncontrado._fila = ListaToken.listaToken.Item(i)._fila
                                    errorEncontrado._lexema = ListaToken.listaToken.Item(i)._lexema
                                    errorEncontrado._descripcion = "Error sintáctico, se esperaba " & siguiente
                                    i += 1
                                End If
                            Case "VARIABLE"
                                If (entrada.Equals("variable")) Then
                                    pila.Push(entrada)
                                    contador += 1
                                    siguiente = "="

                                    variable = ListaToken.listaToken.Item(i)._lexema
                                ElseIf (entrada.Equals("=")) Then
                                    pila.Pop()
                                    pila.Push("VALOR")
                                    pila.Push(entrada)
                                    contador += 1
                                    siguiente = "valor"
                                Else
                                    errorEncontrado = New Errores
                                    errorEncontrado._columna = ListaToken.listaToken.Item(contador)._columna
                                    errorEncontrado._fila = ListaToken.listaToken.Item(contador)._fila
                                    errorEncontrado._lexema = ListaToken.listaToken.Item(contador)._lexema
                                    errorEncontrado._descripcion = "Error sintáctico, se esperaba " & siguiente
                                    contador += 1
                                End If
                            Case "VALOR"
                                If (auxVar.Count <> 0) Then
                                    entrada = "nombre"
                                    token = "nombre"
                                End If
                                If (entrada.Equals("cadena")) Then
                                    pila.Pop()
                                    pila.Push(entrada)
                                    contador += 1

                                    lexema = ListaToken.listaToken.Item(i)._lexema

                                    cuentoNuevo = New Cuento
                                    cuentoNuevo._idClase = idClase
                                    cuentoNuevo._idMetodo = idMetodo
                                    cuentoNuevo._variable = variable
                                    cuentoNuevo._token = entrada
                                    cuentoNuevo._tipoDato = "cadena"
                                    cuentoNuevo._datoString = lexema
                                    ListaCuento.listaCuento.Add(cuentoNuevo)

                                    cuentoNuevo = Nothing
                                    variable = Nothing
                                    lexema = Nothing
                                ElseIf (entrada.Equals("nombre")) Then
                                    pila.Pop()
                                    pila.Push(entrada)
                                    contador += 1

                                    lexema = ListaToken.listaToken.Item(i)._lexema

                                    cuentoNuevo = New Cuento
                                    cuentoNuevo._idClase = idClase
                                    cuentoNuevo._idMetodo = idMetodo
                                    cuentoNuevo._variable = variable
                                    cuentoNuevo._token = entrada
                                    cuentoNuevo._tipoDato = "variable"
                                    cuentoNuevo._datoString = lexema
                                    ListaCuento.listaCuento.Add(cuentoNuevo)

                                    cuentoNuevo = Nothing
                                    variable = Nothing
                                    lexema = Nothing
                                ElseIf (entrada.Equals("si")) Then
                                    pila.Pop()
                                    pila.Push(entrada)
                                    contador += 1

                                    lexema = ListaToken.listaToken.Item(i)._lexema

                                    cuentoNuevo = New Cuento
                                    cuentoNuevo._idClase = idClase
                                    cuentoNuevo._idMetodo = idMetodo
                                    cuentoNuevo._variable = variable
                                    cuentoNuevo._token = entrada
                                    cuentoNuevo._tipoDato = "bandera"
                                    cuentoNuevo._datoBoolean = lexema
                                    ListaCuento.listaCuento.Add(cuentoNuevo)

                                    cuentoNuevo = Nothing
                                    variable = Nothing
                                    lexema = Nothing
                                ElseIf (entrada.Equals("no")) Then
                                    pila.Pop()
                                    pila.Push(entrada)
                                    contador += 1

                                    lexema = ListaToken.listaToken.Item(i)._lexema

                                    cuentoNuevo = New Cuento
                                    cuentoNuevo._idClase = idClase
                                    cuentoNuevo._idMetodo = idMetodo
                                    cuentoNuevo._variable = variable
                                    cuentoNuevo._token = entrada
                                    cuentoNuevo._tipoDato = "bandera"
                                    cuentoNuevo._datoBoolean = lexema
                                    ListaCuento.listaCuento.Add(cuentoNuevo)

                                    cuentoNuevo = Nothing
                                    variable = Nothing
                                    lexema = Nothing
                                ElseIf (entrada.Equals("f")) Then
                                    pila.Pop()
                                    pila.Push(entrada)
                                    contador += 1

                                    lexema = ListaToken.listaToken.Item(i)._lexema

                                    cuentoNuevo = New Cuento
                                    cuentoNuevo._idClase = idClase
                                    cuentoNuevo._idMetodo = idMetodo
                                    cuentoNuevo._variable = variable
                                    cuentoNuevo._token = entrada
                                    cuentoNuevo._tipoDato = "f"
                                    cuentoNuevo._datoString = lexema
                                    ListaCuento.listaCuento.Add(cuentoNuevo)

                                    cuentoNuevo = Nothing
                                    variable = Nothing
                                    lexema = Nothing
                                ElseIf (entrada.Equals("m")) Then
                                    pila.Pop()
                                    pila.Push(entrada)
                                    contador += 1

                                    lexema = ListaToken.listaToken.Item(i)._lexema

                                    cuentoNuevo = New Cuento
                                    cuentoNuevo._idClase = idClase
                                    cuentoNuevo._idMetodo = idMetodo
                                    cuentoNuevo._variable = variable
                                    cuentoNuevo._token = entrada
                                    cuentoNuevo._tipoDato = "m"
                                    cuentoNuevo._datoString = lexema
                                    ListaCuento.listaCuento.Add(cuentoNuevo)

                                    cuentoNuevo = Nothing
                                    variable = Nothing
                                    lexema = Nothing
                                Else
                                    pila.Pop()
                                    pila.Push("E")
                                End If
                            Case "TAGVAR"
                                If (entrada.Equals("=")) Then
                                    pila.Pop()
                                    pila.Push("VALOR")
                                    pila.Push(entrada)
                                    contador += 1
                                    siguiente = "valor"


                                    While (var.Count <> 0)
                                        auxVar.Push(var.Pop)
                                    End While
                                ElseIf (entrada.Equals(",")) Then
                                    pila.Pop()
                                    pila.Push("VARS")
                                    pila.Push(entrada)
                                    contador += 1
                                    siguiente = "variable"
                                Else
                                    errorEncontrado = New Errores
                                    errorEncontrado._columna = ListaToken.listaToken.Item(contador)._columna
                                    errorEncontrado._fila = ListaToken.listaToken.Item(contador)._fila
                                    errorEncontrado._lexema = ListaToken.listaToken.Item(contador)._lexema
                                    errorEncontrado._descripcion = "Error sintáctico, se esperaba " & siguiente
                                    contador += 1
                                End If
                            Case "VARS"
                                If (entrada.Equals("nombre")) Then
                                    pila.Pop()
                                    pila.Push("LISTAVAR")
                                    pila.Push(entrada)
                                    contador += 1
                                    siguiente = ","

                                    variable = ListaToken.listaToken.Item(i)._lexema
                                    var.Push(variable)
                                ElseIf (entrada.Equals("=")) Then
                                    pila.Pop()
                                    pila.Push("VALORES")
                                    pila.Push("VALOR")
                                    pila.Push(entrada)
                                    contador += 1
                                    siguiente = "valores"
                                Else
                                    errorEncontrado = New Errores
                                    errorEncontrado._columna = ListaToken.listaToken.Item(contador)._columna
                                    errorEncontrado._fila = ListaToken.listaToken.Item(contador)._fila
                                    errorEncontrado._lexema = ListaToken.listaToken.Item(contador)._lexema
                                    errorEncontrado._descripcion = "Error sintáctico, se esperaba " & siguiente
                                    contador += 1
                                End If
                            Case "LISTAVAR"
                                If (entrada.Equals(",")) Then
                                    pila.Pop()
                                    pila.Push("VARS")
                                    pila.Push(entrada)
                                    contador += 1
                                    siguiente = "variable o ="
                                ElseIf (entrada.Equals("=")) Then
                                    pila.Pop()
                                    pila.Push("VALORES")
                                    pila.Push("VALOR")
                                    pila.Push(entrada)
                                    contador += 1
                                    siguiente = "valor"

                                    While (var.Count <> 0)
                                        auxVar.Push(var.Pop)
                                    End While
                                Else
                                    errorEncontrado = New Errores
                                    errorEncontrado._columna = ListaToken.listaToken.Item(contador)._columna
                                    errorEncontrado._fila = ListaToken.listaToken.Item(contador)._fila
                                    errorEncontrado._lexema = ListaToken.listaToken.Item(contador)._lexema
                                    errorEncontrado._descripcion = "Error sintáctico, se esperaba " & siguiente
                                    contador += 1
                                End If
                            Case "VALORES"
                                If (entrada.Equals(",")) Then
                                    pila.Push("VALOR")
                                    pila.Push(entrada)
                                    contador += 1
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
                                    contador += 1
                                    siguiente = "valor"
                                ElseIf (entrada.Equals("-")) Then
                                    pila.Push("T")
                                    pila.Push(entrada)
                                    contador += 1
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
                                    contador += 1
                                    siguiente = "valor"
                                ElseIf (entrada.Equals("/")) Then
                                    pila.Push("F")
                                    pila.Push(entrada)
                                    contador += 1
                                    siguiente = "valor"
                                Else
                                    pila.Pop()
                                End If
                            Case "F"
                                If (entrada.Equals("entero")) Then
                                    pila.Pop()
                                    pila.Push(entrada)
                                    contador += 1
                                ElseIf (entrada.Equals("(")) Then
                                    pila.Push("E")
                                    pila.Push(entrada)
                                    contador += 1
                                    siguiente = "entero"
                                ElseIf (entrada.Equals(")")) Then
                                    pila.Pop()
                                    pila.Push(entrada)
                                    contador += 1
                                Else
                                    errorEncontrado = New Errores
                                    errorEncontrado._columna = ListaToken.listaToken.Item(contador)._columna
                                    errorEncontrado._fila = ListaToken.listaToken.Item(contador)._fila
                                    errorEncontrado._lexema = ListaToken.listaToken.Item(contador)._lexema
                                    errorEncontrado._descripcion = "Error sintáctico, se esperaba " & siguiente
                                    contador += 1
                                End If
                            Case "#"
                                pila.Pop()
                                destino = "f"
                        End Select
                    End If

                Case "f"
                    finClase = False
                    MessageBox.Show("Análisis sintáctico finalizado", "Exito")
            End Select

        End While

    End Sub

End Class
