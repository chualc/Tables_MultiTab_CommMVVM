using CommunityToolkit.Mvvm.ComponentModel;
using Tables_MultiTab_CommMVVM.Models;
using System;
using System.Collections.ObjectModel;


namespace Tables_MultiTab_CommMVVM.ViewModels
{
    public class Table3ViewModel : ObservableObject
    {
        public ObservableCollection<Table3> Items { get; }
            = new ObservableCollection<Table3>();

        public Table3ViewModel()
        {
            Items.Add(new Table3
            {
                Id = 1,
                Description = "Record A",
                Date = new DateTime(2026, 10, 20),
                Amount = 450.00m
            });

            Items.Add(new Table3
            {
                Id = 2,
                Description = "Record B",
                Date = new DateTime(2026, 10, 22),
                Amount = 820.50m
            });
        }
    }
}