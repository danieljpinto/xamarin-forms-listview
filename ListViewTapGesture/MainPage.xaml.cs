using System.ComponentModel;
using ListViewTapGesture.ViewModels;
using Xamarin.Forms;

namespace ListViewTapGesture
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        protected MainPageViewModel ViewModel { get; private set; }

        public MainPage(MainPageViewModel viewModel)
        {
            ViewModel = viewModel;
            BindingContext = viewModel;
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            ViewModel.Load();
        }
    }
}
