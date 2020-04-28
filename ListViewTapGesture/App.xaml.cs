using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewTapGesture
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage(new ViewModels.MainPageViewModel());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
