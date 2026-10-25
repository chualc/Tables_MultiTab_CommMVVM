
using CommunityToolkit.Mvvm.ComponentModel;

namespace Tables_MultiTab_CommMVVM.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private int selectedTabIndex;

        // TODO: Step 5: For each tab, create a new ViewModel.
        public Table1ViewModel Table1 { get; }
        public Table2ViewModel Table2 { get; }
        public Table3ViewModel Table3 { get; }
        public Table4ViewModel Table4 { get; }

        public MainViewModel()
        {
            Table1 = new Table1ViewModel();
            Table2 = new Table2ViewModel();
            Table3 = new Table3ViewModel();
            Table4 = new Table4ViewModel();
        }
    }
}
