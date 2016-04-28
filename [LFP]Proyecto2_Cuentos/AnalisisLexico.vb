
Class AnalisisLexico
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

            End Select
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
            Case "#"
                indice = 15
            Case Chr(32) 'ESPACIO
                indice = 16
            Case Chr(10) 'RETORNO
                indice = 17
            Case Chr(9) 'TAB
                indice = 18
            Case Else 'CUALQUIER CARACTER
                indice = 19
        End Select

        Return indice
    End Function


End Class
