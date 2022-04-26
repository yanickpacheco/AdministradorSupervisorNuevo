Public Class clsBitacora
    Private _idBitacora As Integer
    Private _idCRM As Integer
    Private _Fecha As String
    Private _Detalle As String
    Private _Total As Integer
    Private _Supervisor As String

    Public Sub New(_idBitacora As Integer, _idCRM As Integer, _Fecha As String, _Detalle As String, _Total As Integer, _Supervisor As String)
        _idBitacora = IdBitacora
        _idCRM = IdCRM
        _Fecha = Fecha
        _Detalle = Detalle
        _Total = Total
        _Supervisor = _Supervisor
    End Sub

    Public Sub New()
        _idBitacora = 0
        _idCRM = 0
        _Fecha = ""
        _Detalle = ""
        _Total = 0
        _Supervisor = ""
    End Sub

    Public Property IdBitacora As Integer
        Get
            Return _idBitacora
        End Get
        Set(value As Integer)
            _idBitacora = value
        End Set
    End Property

    Public Property IdCRM As Integer
        Get
            Return _idCRM
        End Get
        Set(value As Integer)
            _idCRM = value
        End Set
    End Property

    Public Property Fecha As String
        Get
            Return _Fecha
        End Get
        Set(value As String)
            _Fecha = value
        End Set
    End Property

    Public Property Detalle As String
        Get
            Return _Detalle
        End Get
        Set(value As String)
            _Detalle = value
        End Set
    End Property

    Public Property Total As Integer
        Get
            Return _Total
        End Get
        Set(value As Integer)
            _Total = value
        End Set
    End Property

    Public Property Supervisor As String
        Get
            Return _Supervisor
        End Get
        Set(value As String)
            _Supervisor = value
        End Set
    End Property
End Class
