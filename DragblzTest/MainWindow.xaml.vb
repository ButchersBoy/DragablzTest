Class MainWindow 

    Public Shared ReadOnly InterTabClientProperty As DependencyProperty = DependencyProperty.Register("InterTabClientInstance",
                                                                                                      GetType(MyInterTabClient),
                                                                                                      GetType(MainWindow),
                                                                                                      New PropertyMetadata(Nothing))

    Public Property InterTabClientInstance As MyInterTabClient
        Get
            If GetValue(InterTabClientProperty) Is Nothing Then InterTabClientInstance = New MyInterTabClient
            Return DirectCast(GetValue(InterTabClientProperty), MyInterTabClient)
        End Get
        Set(value As MyInterTabClient)
            SetValue(InterTabClientProperty, value)
        End Set
    End Property

End Class
