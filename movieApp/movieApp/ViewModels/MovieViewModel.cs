using System.ComponentModel;

namespace DataLayer
{
    public class MovieViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private MovieInfo _movieInfo;
        private string name;

        public MovieViewModel(MovieInfo movieInfo)
        {
            _movieInfo = movieInfo;
            Name = movieInfo.Name;
        }
        public string Name
        {
            get => name; set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        private void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(v));
        }
    }
}
