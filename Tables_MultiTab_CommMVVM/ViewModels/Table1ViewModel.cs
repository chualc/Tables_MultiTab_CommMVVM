using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using Tables_MultiTab_CommMVVM.Models;

namespace Tables_MultiTab_CommMVVM.ViewModels
{
    public class Table1ViewModel : ObservableObject
    {
        public ObservableCollection<Table1> Items { get; }
            = new ObservableCollection<Table1>();

        public Table1ViewModel()
        {
            Items.Add(new Table1
            {
                Id = 1,
                Name = "Item A",
                Category = "Category A",
                Value = 100
            });

            Items.Add(new Table1
            {
                Id = 2,
                Name = "Item B",
                Category = "Category B",
                Value = 200
            });
        }
    }
}
