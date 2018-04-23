Imports Microsoft.VisualBasic
Imports System.Windows

Namespace ListBoxFilteringUsingSearchPanel
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			listBox.ItemsSource = Stuff.GetStuff()
		End Sub
	End Class
End Namespace
