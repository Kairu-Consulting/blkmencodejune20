using blackmencodeapp.viewModel;
using Xamarin.Forms;

namespace blackmencodeapp
{
    public partial class BlkMenCodeLandingPage : ContentPage
    {
        //LandingPageViewModel viewModel;

        public BlkMenCodeLandingPage()
        {
            InitializeComponent();
            BindingContext = new LandingPageViewModel();
            //BindingContext = viewModel = new LandingPageViewModel();
        }

        void testSwitch_Toggled(System.Object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            Application.Current.MainPage.DisplayAlert("Black Men Code", "BlackMenCode", "Toggle changed to" + ((Switch)(sender)).IsToggled);
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Application.Current.MainPage.DisplayAlert("Black Men Code", "BlackMenCode", "Button Clicked");
        }
    }
}
