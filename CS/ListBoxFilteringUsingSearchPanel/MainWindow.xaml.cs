using System.Windows;

namespace ListBoxFilteringUsingSearchPanel {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            listBox.ItemsSource = Stuff.GetStuff();
        }
    }
}
