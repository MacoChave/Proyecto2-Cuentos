Public Class Token
    Private id As Integer
    Private lexema As String
    Private token As String
    Private fila As Integer
    Private columna As Integer

    Sub New()

    End Sub

    Sub New(id As Integer, lexema As String, token As String, fila As Integer, columna As Integer)
        Me.id = id
        Me.lexema = lexema
        Me.token = token
        Me.fila = fila
        Me.columna = columna
    End Sub

    Public Property _id As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property _lexema As String
        Get
            Return lexema
        End Get
        Set(value As String)
            lexema = value
        End Set
    End Property

    Public Property _token As String
        Get
            Return token
        End Get
        Set(value As String)
            token = value
        End Set
    End Property

    Public Property _fila As Integer
        Get
            Return fila
        End Get
        Set(value As Integer)
            fila = value
        End Set
    End Property

    Public Property _columna As Integer
        Get
            Return columna
        End Get
        Set(value As Integer)
            columna = value
        End Set
    End Property
End Class
