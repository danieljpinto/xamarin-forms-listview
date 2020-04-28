using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using ListViewTapGesture.Models;
using Xamarin.Forms;

namespace ListViewTapGesture.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            AddTappedCommand = new Command(ExecuteCommand, CanExecuteCommnd);
        }

        public ICommand AddTappedCommand { get; protected set; }

        protected void ExecuteCommand(object parameter)
        {
            Debug.Print($"Event called");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<MyModel> MyList { get; set; } = new ObservableCollection<MyModel>();

        public bool CanExecuteCommnd(object parameter)
        {
            return true;
        }

        public void Load()
        {
            for (int i = 1; i <= 10; i++)
            {
                MyList.Add(new MyModel { Id = i, Name = $"Name {i}" });
            }

        }
    }
}
