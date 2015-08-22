Public Class MyInterTabClient
    Implements Dragablz.IInterTabClient

    Public Function GetNewHost(interTabClient As Dragablz.IInterTabClient, partition As Object, source As Dragablz.TabablzControl) As Dragablz.INewTabHost(Of Window) Implements Dragablz.IInterTabClient.GetNewHost
        Dim host As New TabHost

        host.tabMain.InterTabController = New Dragablz.InterTabController With {.InterTabClient = Me}

        Return New Dragablz.NewTabHost(Of TabHost)(host, host.tabMain)
    End Function

    Public Function TabEmptiedHandler(tabControl As Dragablz.TabablzControl, window As Window) As Dragablz.TabEmptiedResponse Implements Dragablz.IInterTabClient.TabEmptiedHandler
        Return Dragablz.TabEmptiedResponse.CloseWindowOrLayoutBranch
    End Function
End Class
