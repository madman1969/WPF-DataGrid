using System.Windows;
using System.Reflection;

namespace DataGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
          this.InitializeComponent();
          this.DataContext = new MainWindowViewModel();
        }

        private void GetSelectedCells(object sender, RoutedEventArgs e)
        {
            var selectedData = "";

            foreach (var dataGridCellInfo in this.selectedCellsGrid.SelectedCells)
            {
                var pi = dataGridCellInfo.Item.GetType().GetProperty(dataGridCellInfo.Column.Header.ToString());
                var value = pi.GetValue(dataGridCellInfo.Item, null);
                selectedData += dataGridCellInfo.Column.Header + ": " + value + "\n";
            }
            MessageBox.Show(selectedData);
        }
    }
}
