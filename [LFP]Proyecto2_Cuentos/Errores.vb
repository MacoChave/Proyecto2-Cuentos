Public Class Errores
    Private fila As Integer
    Private columna As Integer
    Private lexema As String
    Private descripcion As String

    Sub New()

    End Sub

    Sub New(fila As Integer, columna As Integer, lexema As String, descripcion As String)
        Me.fila = fila
        Me.columna = columna
        Me.lexema = lexema
        Me.descripcion = descripcion
    End Sub

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

    Public Property _lexema As String
        Get
            Return lexema
        End Get
        Set(value As String)
            lexema = value
        End Set
    End Property

    Public Property _descripcion As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property
End Class
