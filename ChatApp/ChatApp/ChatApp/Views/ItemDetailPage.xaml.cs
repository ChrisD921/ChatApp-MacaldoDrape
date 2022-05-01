using ChatApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ChatApp.Views
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