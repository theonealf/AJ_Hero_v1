Public Class aj_hero_v1_Info

    Private _heroId As Integer
    Private _itemblock1 As String
    Private _Itemblock2 As String
    Private _assignedUserId As Integer
    Private _createdByUserId As Integer
    Private _lastModifiedByUserId As Integer
    Private _createdOnDate As DateTime
    Private _lastModifiedOnDate As DateTime
    Private _moduleId As Integer
    Private _Status As String


    Public Sub New()
        _heroId = 0
        _itemblock1 = ""
        _Itemblock2 = ""
        _Status = ""
    End Sub
    Public Property HeroId() As Integer
        Get
            Return _heroId
        End Get
        Set(ByVal value As Integer)
            _heroId = value
        End Set
    End Property


    Public Property Itemblock1() As String
        Get
            Return _itemblock1
        End Get
        Set(ByVal value As String)
            _itemblock1 = value
        End Set
    End Property

    Public Property Itemblock2() As String
        Get
            Return _Itemblock2
        End Get
        Set(ByVal value As String)
            _Itemblock2 = value
        End Set
    End Property

    Public Overloads Property AssignedUserId() As Integer
        Get
            Return _assignedUserId
        End Get
        Set(ByVal value As Integer)
            _assignedUserId = value
        End Set
    End Property

    Public Overloads Property CreatedByUserId() As Integer
        Get
            Return _createdByUserId
        End Get
        Set(ByVal value As Integer)
            _createdByUserId = value
        End Set
    End Property

    Public Overloads Property LastModifiedByUserId() As Integer
        Get
            Return _lastModifiedByUserId
        End Get
        Set(ByVal value As Integer)
            _lastModifiedByUserId = value
        End Set
    End Property

    Public Overloads Property CreatedOnDate() As DateTime
        Get
            Return _createdOnDate
        End Get
        Set(ByVal value As DateTime)
            _createdOnDate = value
        End Set
    End Property
    Public Overloads Property LastModifiedOnDate() As DateTime
        Get
            Return _lastModifiedOnDate
        End Get
        Set(ByVal value As DateTime)
            _lastModifiedOnDate = value
        End Set
    End Property

    Public Overloads Property ModuleId() As Integer
        Get
            Return _moduleId
        End Get
        Set(ByVal value As Integer)
            _moduleId = value
        End Set
    End Property

    Public Property Status() As String
        Get
            Return _Status
        End Get
        Set(ByVal value As String)
            _Status = value
        End Set
    End Property

End Class
