using DataLayer;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace movieApp.ViewModels
{
    public class MoviesViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<MovieInfo> Movies { get; }

        public MoviesViewModel(IMovieProvider _movieProvider)
        {
            Movies = new ObservableCollection<MovieInfo>(_movieProvider.GetMovies());
        }
    }
}
