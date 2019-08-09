using nested_collectionview.ViewModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace nested_collectionview
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ((ViewModel_A)this.BindingContext).Refresh();
        }
    }
}
