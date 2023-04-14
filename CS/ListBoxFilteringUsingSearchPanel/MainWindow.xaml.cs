using System.Windows;

namespace ListBoxFilteringUsingSearchPanel {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            listBox.ItemsSource = Staff.GetStaff();
        }
    }
}
