Imports System.Windows

Namespace ListBoxFilteringUsingSearchPanel

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.listBox.ItemsSource = GetStuff()
        End Sub
    End Class
End Namespace
