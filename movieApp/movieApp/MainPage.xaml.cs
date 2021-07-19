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
        public Command LoadItemsCommand { get; }
        private readonly IMovieProvider _movieProvider = new MovieFakeProvider();
        public MainPage()
        {
            LoadItemsCommand = new Command(() => ExecuteLoadItemsCommand());
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            ExecuteLoadItemsCommand();
            base.OnAppearing();
        }
        private void ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Items.Clear();
                var items = _movieProvider.GetMovies();
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
        public ObservableCollection<MovieInfo> Items { get; } = new ObservableCollection<MovieInfo>();
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
