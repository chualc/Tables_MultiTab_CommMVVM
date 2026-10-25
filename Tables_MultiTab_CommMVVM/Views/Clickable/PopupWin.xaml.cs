using System.Windows;


namespace Tables_MultiTab_CommMVVM.Views.Clickable
{
    /// <summary>
    /// Interaction logic for PopupWin.xaml
    /// </summary>
    public partial class PopupWin : Window
    {
        public PopupWin(
            string columnName,
            object cellValue,
            object rowId)
        {
            InitializeComponent();

        DataContext = new
            {
            ColumnName = columnName,
                CellValue = cellValue,
                RowId = rowId
        };
        }

        private void CloseButton_Click(
            object sender,
            RoutedEventArgs e)
        {
            Close();
        }
    }
}
