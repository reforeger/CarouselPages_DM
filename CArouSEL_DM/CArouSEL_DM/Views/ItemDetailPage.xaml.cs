using System.ComponentModel;
using Xamarin.Forms;
using CArouSEL_DM.ViewModels;

namespace CArouSEL_DM.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}