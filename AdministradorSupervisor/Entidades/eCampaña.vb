Public Class eCampaña


    Private _CRM As Integer
    Private _Nombre As String

    Public Sub New(CRM As Integer, Nombre As String)
        Me.CRM = CRM
        Me.Nombre = Nombre
    End Sub

    Public Sub New()
        CRM = 0
        Nombre = ""
    End Sub

    Public Property CRM As Integer
        Get
            Return _CRM
        End Get
        Set(value As Integer)
            _CRM = value
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
