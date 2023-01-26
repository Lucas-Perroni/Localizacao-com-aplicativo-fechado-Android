using BackgroundLocation.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace BackgroundLocation.Views
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