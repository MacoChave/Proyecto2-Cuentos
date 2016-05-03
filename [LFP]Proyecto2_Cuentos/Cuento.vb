Public Class Cuento
    Private idCuento As Integer
    Private titulo As String
    Private cuento As String
    Private imagen As String
    Private tipoVoz As String
    Private volumen As Integer
    Private velocidad As Integer
    Private traduccion As Boolean
    Private resaltar As Boolean
    Private texto As Boolean

    Sub New()

    End Sub

    Sub New(idCuento As Integer, titulo As String, cuento As String, imagen As String, tipoVoz As String, volumen As Integer, velocidad As Integer, traduccion As Boolean, resaltar As Boolean, texto As Boolean)
        Me.idCuento = idCuento
        Me.titulo = titulo
        Me.cuento = cuento
        Me.imagen = imagen
        Me.tipoVoz = tipoVoz
        Me.volumen = volumen
        Me.velocidad = velocidad
        Me.traduccion = traduccion
        Me.resaltar = resaltar
        Me.texto = texto
    End Sub

    'id
    Public Property _id As Integer
        Get
            Return idCuento
        End Get
        Set(value As Integer)
            idCuento = value
        End Set
    End Property
    'titulo
    Public Property _titulo As String
        Get
            Return titulo
        End Get
        Set(value As String)
            titulo = value
        End Set
    End Property
    'cuento
    Public Property _cuento As String
        Get
            Return cuento
        End Get
        Set(value As String)
            cuento = value
        End Set
    End Property
    'imagen
    Public Property _imagen As String
        Get
            Return imagen
        End Get
        Set(value As String)
            imagen = value
        End Set
    End Property
    'tipoVoz
    Public Property _tipoVoz As String
        Get
            Return tipoVoz
        End Get
        Set(value As String)
            tipoVoz = value
        End Set
    End Property
    'volumen
    Public Property _volumen As Integer
        Get
            Return volumen
        End Get
        Set(value As Integer)
            volumen = value
        End Set
    End Property
    'velocidad
    Public Property _velocidad As Integer
        Get
            Return velocidad
        End Get
        Set(value As Integer)
            velocidad = value
        End Set
    End Property
    'traduccion
    Public Property _traduccion As Boolean
        Get
            Return traduccion
        End Get
        Set(value As Boolean)
            traduccion = value
        End Set
    End Property
    'resaltar
    Public Property _resaltar As Boolean
        Get
            Return resaltar
        End Get
        Set(value As Boolean)
            resaltar = value
        End Set
    End Property
    'texto
    Public Property _texto As Boolean
        Get
            Return texto
        End Get
        Set(value As Boolean)
            texto = value
        End Set
    End Property
End Class