using DataLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
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
            this.BindingContext = new MovieViewModel 
            {
                Name = "Ajfkds"
            };
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
