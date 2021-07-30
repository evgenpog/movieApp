using System.ComponentModel;

namespace DataLayer
{
    public class MovieViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private MovieInfo mov;
        public MovieViewModel()
        {
            mov = new MovieInfo();
        }
        public string Name
        {
            get { return mov.Name; }
            set
            {
                if (mov.Name != value)
                {
                    mov.Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        private void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(v));
        }
    }
}
