using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace movieApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void ClickedHelp(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new HelpPage());
        }
        private async void ClickedAddFilm(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AddFilmPage());
        }
    }
}
