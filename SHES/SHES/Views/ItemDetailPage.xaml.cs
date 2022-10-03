using SHES.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SHES.Views
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