Public Class eCorreo
    Private _idDestinatarioCorreo As Int64
    Public Property idDestinatarioCorreo() As Int64
        Get
            Return _idDestinatarioCorreo
        End Get
        Set(ByVal value As Int64)
            _idDestinatarioCorreo = value
        End Set
    End Property

    Private _para As String
    Public Property para() As String
        Get
            Return _para
        End Get
        Set(ByVal value As String)
            _para = value
        End Set
    End Property

    Private _conCopia As String
    Public Property conCopia() As String
        Get
            Return _conCopia
        End Get
        Set(ByVal value As String)
            _conCopia = value
        End Set
    End Property

    Private _conCopiaOculta As String
    Public Property conCopiaOculta() As String
        Get
            Return _conCopiaOculta
        End Get
        Set(ByVal value As String)
            _conCopiaOculta = value
        End Set
    End Property

    Private _asunto As String
    Public Property asunto() As String
        Get
            Return _asunto
        End Get
        Set(ByVal value As String)
            _asunto = value
        End Set
    End Property

    Private _Cuerpo As String
    Public Property Cuerpo() As String
        Get
            Return _Cuerpo
        End Get
        Set(ByVal value As String)
            _Cuerpo = value
        End Set
    End Property

    Private _direccionCorreo As String
    Public Property direccionCorreo() As String
        Get
            Return _direccionCorreo
        End Get
        Set(ByVal value As String)
            _direccionCorreo = value
        End Set
    End Property

    Private _usuarioCorreo As String
    Public Property usuarioCorreo() As String
        Get
            Return _usuarioCorreo
        End Get
        Set(ByVal value As String)
            _usuarioCorreo = value
        End Set
    End Property

    Private _contraseñaCorreo As String
    Public Property contraseñaCorreo() As String
        Get
            Return _contraseñaCorreo
        End Get
        Set(ByVal value As String)
            _contraseñaCorreo = value
        End Set
    End Property

    Private _host As String
    Public Property host() As String
        Get
            Return _host
        End Get
        Set(ByVal value As String)
            _host = value
        End Set
    End Property

    Private _puerto As String
    Public Property puerto() As String
        Get
            Return _puerto
        End Get
        Set(ByVal value As String)
            _puerto = value
        End Set
    End Property

    Private _ValorSSL As Boolean
    Public Property ValorSSL() As Boolean
        Get
            Return _ValorSSL
        End Get
        Set(ByVal value As Boolean)
            _ValorSSL = value
        End Set
    End Property


End Class