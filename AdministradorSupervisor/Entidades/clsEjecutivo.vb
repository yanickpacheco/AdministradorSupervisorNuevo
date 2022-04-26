Public Class clsEjecutivo

    Dim _ejecutivo As String

    Public Sub New(ejecutivo As String)
        _ejecutivo = ejecutivo
    End Sub

    Public Sub New()
        Ejecutivo = ""
    End Sub

    Public Property Ejecutivo As String
        Get
            Return _ejecutivo
        End Get
        Set(value As String)
            _ejecutivo = value
        End Set
    End Property
End Class
