using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CArouSEL_DM.Services;
using CArouSEL_DM.Views;

namespace CArouSEL_DM
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
