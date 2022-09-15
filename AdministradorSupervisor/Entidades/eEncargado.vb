Public Class eEncargado

    Private _idEncargado As Integer
    Private _nombreEncargado As String
    Private _activo As Boolean

    Public Sub New(idEncargado As Integer, nombreEncargado As String, activo As Boolean)
        Me.IdEncargado = idEncargado
        Me.NombreEncargado = nombreEncargado
        Me.Activo = activo
    End Sub

    Public Sub New()
        IdEncargado = 0
        NombreEncargado = ""
        Activo = False
    End Sub

    Public Property IdEncargado As Integer
        Get
            Return _idEncargado
        End Get
        Set(value As Integer)
            _idEncargado = value
        End Set
    End Property

    Public Property NombreEncargado As String
        Get
            Return _nombreEncargado
        End Get
        Set(value As String)
            _nombreEncargado = value
        End Set
    End Property

    Public Property Activo As Boolean
        Get
            Return _activo
        End Get
        Set(value As Boolean)
            _activo = value
        End Set
    End Property
End Class
