Imports System.Windows

Namespace ListBoxFilteringUsingSearchPanel

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.listBox.ItemsSource = GetStaff()
        End Sub
    End Class
End Namespace
