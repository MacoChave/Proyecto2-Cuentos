
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

    End Sub

    Private Function Get_TipoCaracter(caracter) As Integer
        Dim indice As Integer
        Select Case caracter
            Case "A" To "Z"
                indice = 0
            Case "a" To "z"
                indice = 1
            Case Chr(32) 'ESPACIO
                indice = 2
            Case "0" To "9"
                indice = 3
            Case "{"
                indice = 4
            Case "}"
                indice = 5
            Case ";"
                indice = 6
            Case ":"
                indice = 7
            Case "="
                indice = 8
            Case ","
                indice = 9
            Case "-"
                indice = 10
            Case "["
                indice = 11
            Case "]"
                indice = 12
            Case Chr(34) 'COMILLAS DOBLES
                indice = 13
            Case "#"
                indice = 14
            Case Chr(9) 'TAB
                indice = 15
            Case Chr(10) 'SALTO
                indice = 16
            Case "."
                indice = 24
        End Select

        Return indice
    End Function


End Class
