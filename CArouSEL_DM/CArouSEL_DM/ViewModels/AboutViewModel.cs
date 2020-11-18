using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CArouSEL_DM.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamain-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}