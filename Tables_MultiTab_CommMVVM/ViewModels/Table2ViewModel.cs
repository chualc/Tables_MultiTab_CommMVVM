using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using Tables_MultiTab_CommMVVM.Models;

namespace Tables_MultiTab_CommMVVM.ViewModels
{
    public class Table2ViewModel : ObservableObject
    {
        public ObservableCollection<Table2> Items { get; }
            = new ObservableCollection<Table2>();

        public Table2ViewModel()
        {
            Items.Add(new Table2
            {
                Id = 1,
                Name = "Record A",
                Quantity = 10,
                Price = 25.50m
            });

            Items.Add(new Table2
            {
                Id = 2,
                Name = "Record B",
                Quantity = 20,
                Price = 50.00m
            });
        }
    }
}
