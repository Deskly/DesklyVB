Public Class redditJson
    Public Property color() As String
        Get
            Return m_color
        End Get
        Set
            m_color = Value
        End Set
    End Property
    Private m_color As String
    Public Property value() As String
        Get
            Return m_value
        End Get
        Set
            m_value = Value
        End Set
    End Property
    Private m_value As String
End Class