using DataLayer;
using movieApp.ViewModels;
using Xamarin.Forms;

namespace movieApp
{
    public partial class MainPage : ContentPage
    {
        private IMovieProvider _movieProvider;
        public MainPage()
        {
            _movieProvider = new MovieFakeProvider();
            BindingContext = new MoviesViewModel(_movieProvider);
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
