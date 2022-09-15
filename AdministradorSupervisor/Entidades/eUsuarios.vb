Public Class eUsuarios


    Private _Usuario As Integer
    Private _Nombre As String

    Public Sub New(Usuario As Integer, Nombre As String)
        Me.Usuario = Usuario
        Me.Nombre = Nombre
    End Sub

    Public Sub New()
        Usuario = 0
        Nombre = ""
    End Sub

    Public Property Usuario As Integer
        Get
            Return _Usuario
        End Get
        Set(value As Integer)
            _Usuario = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

End Class
