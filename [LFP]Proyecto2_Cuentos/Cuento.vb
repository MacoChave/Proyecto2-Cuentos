Public Class Cuento
    Private idClase As Integer
    Private idMetodo As Integer
    Private variable As String
    Private token As String
    Private tipoDato As String
    Private datoInt As Integer
    Private datoString As String
    Private datoBoolean As Boolean

    Sub New()

    End Sub

    Sub New(idClase As Integer, idMetodo As Integer, variable As String, token As String, tipoDato As String, datoInt As Integer, datoString As String, datoBoolean As Boolean)
        Me.idClase = idClase
        Me.idMetodo = idMetodo
        Me.variable = variable
        Me.token = token
        Me.tipoDato = tipoDato
        Me.datoInt = datoInt
        Me.datoString = datoString
        Me.datoBoolean = datoBoolean
    End Sub

    'idClase
    Public Property _idClase As Integer
        Get
            Return idClase
        End Get
        Set(value As Integer)
            idClase = value
        End Set
    End Property
    'idMetodo
    Public Property _idMetodo As String
        Get
            Return idMetodo
        End Get
        Set(value As String)
            idMetodo = value
        End Set
    End Property
    'lexema
    Public Property _variable As String
        Get
            Return variable
        End Get
        Set(value As String)
            variable = value
        End Set
    End Property
    'token
    Public Property _token As String
        Get
            Return token
        End Get
        Set(value As String)
            token = value
        End Set
    End Property
    'tipoDato
    Public Property _tipoDato As String
        Get
            Return tipoDato
        End Get
        Set(value As String)
            tipoDato = value
        End Set
    End Property
    'datoInt
    Public Property _datoInt As Integer
        Get
            Return datoInt
        End Get
        Set(value As Integer)
            datoInt = value
        End Set
    End Property
    'datoString
    Public Property _datoString As Integer
        Get
            Return datoString
        End Get
        Set(value As Integer)
            datoString = value
        End Set
    End Property
    'datoBoolean
    Public Property _datoBoolean As Boolean
        Get
            Return datoBoolean
        End Get
        Set(value As Boolean)
            datoBoolean = value
        End Set
    End Property
End Class