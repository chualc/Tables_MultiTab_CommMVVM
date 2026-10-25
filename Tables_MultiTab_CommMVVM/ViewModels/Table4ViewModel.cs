using CommunityToolkit.Mvvm.ComponentModel;
using Tables_MultiTab_CommMVVM.Models;
using System;
using System.Collections.ObjectModel;


namespace Tables_MultiTab_CommMVVM.ViewModels
{
    // TODO: Step 2: For each tab, create a new ViewModel.
    // https://learn.microsoft.com/en-us/dotnet/communitytoolkit/mvvm/observableobject
    // allowing your UI to automatically update whenever a property changes in your code.
    public class Table4ViewModel : ObservableObject
    {
        public ObservableCollection<Table4> Items { get; }
            = new ObservableCollection<Table4>();

        public Table4ViewModel()
        {
            Items.Add(new Table4
            {
                Id = 1,
                Name = "Item Tab 4 A",
                Category = "Category Tabe 4 A",
                Value = 100
            });

            Items.Add(new Table4
            {
                Id = 2,
                Name = "Item Tab 4 B",
                Category = "Category Tab 4 B",
                Value = 200
            });
        }
    }
}