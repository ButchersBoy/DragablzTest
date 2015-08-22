Class MainWindow
    Private _interTabClientInstance1 As MyInterTabClient

    Public Sub New
        _interTabClientInstance1 = New MyInterTabClient()
    End Sub

    Public Property InterTabClientInstance As MyInterTabClient
        Get
            Return _interTabClientInstance1
        End Get
        Set
            _interTabClientInstance1 = value
        End Set
    End Property
End Class
