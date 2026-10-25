using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Tables_MultiTab_CommMVVM.Models;
using System.Windows.Media;
using Tables_MultiTab_CommMVVM.Views.Clickable;

namespace Tables_MultiTab_CommMVVM.Views
{
    /// <summary>
    /// Interaction logic for Table1View.xaml
    /// </summary>
    public partial class Table1View : UserControl
    {
        public Table1View()
        {
            InitializeComponent();
        }
        private void DataGrid_MouseDoubleClick(
            object sender,
            MouseButtonEventArgs e)
        {
            var grid = sender as DataGrid;


            if (grid == null)
                return;

            var cell = FindVisualParent<DataGridCell>(
                e.OriginalSource as DependencyObject);

            if (cell == null || cell.DataContext == null)
                return;

            var item = cell.DataContext as Table1;

            if (item == null)
                return;

            string columnName = cell.Column.Header?.ToString()
                                ?? "Unknown";

            object cellValue = cell.Column
                .GetCellContent(item) is TextBlock textBlock
                ? textBlock.Text
                : cell.Content;

            var popup = new PopupWin(
                columnName,
                cellValue,
                item.Id)
            {
                Owner = Window.GetWindow(this)
            };

            popup.ShowDialog();
        }

        private static T FindVisualParent<T>(
            DependencyObject child)
            where T : DependencyObject
        {
            while (child != null)
            {
                if (child is T parent)
                    return parent;

                child = System.Windows.Media.VisualTreeHelper
                    .GetParent(child);
            }

            return null;
        }
    }
}
