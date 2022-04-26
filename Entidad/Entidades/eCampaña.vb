Public Class eCampaña
    Private _CRM As String
    Private _NOmbre As String

    Public Sub New(cRM As String, nOmbre As String)
        _CRM = cRM
        _NOmbre = nOmbre
    End Sub

    Public Property CRM As String
        Get
            Return _CRM
        End Get
        Set(value As String)
            _CRM = value
        End Set
    End Property

    Public Property NOmbre As String
        Get
            Return _NOmbre
        End Get
        Set(value As String)
            _NOmbre = value
        End Set
    End Property
End Class
