using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer
{
    public class MovieFakeProvider : IMovieProvider
    {
        private List<MovieInfo> _items = new List<MovieInfo>();
        public MovieFakeProvider()
        {
            _items.Add(new MovieInfo
            {
                Id = Guid.NewGuid(),
                Name = "Movie1",
                Genre = MovieGenre.Comedy,
                ReleaseDate = new DateTime(1997, 12, 12)
            });
            _items.Add(new MovieInfo
            {
                Id = Guid.NewGuid(),
                Name = "Movie2",
                Genre = MovieGenre.Tragedy,
                ReleaseDate = new DateTime(2007, 12, 18)
            });
            _items.Add(new MovieInfo
            {
                Id = Guid.NewGuid(),
                Name = "Movie3",
                Genre = MovieGenre.Tragedy,
                ReleaseDate = new DateTime(2017, 09, 25)
            });
        }
        public void AddMovie(MovieInfo item)
        {
            _items.Add(item);
        }

        public void DeleteMovie(Guid id)
        {
            _items.Remove(GetMovie(id));
        }

        public MovieInfo GetMovie(Guid id)
        {
            return _items.FirstOrDefault(item => item.Id == id);
        }

        public List<MovieInfo> GetMovies()
        {
            return _items;
        }

        public void UpdateMovie(MovieInfo item)
        {
            var oldItem = GetMovie(item.Id);
            oldItem.Name = item.Name;
            oldItem.Genre = item.Genre;
            oldItem.ReleaseDate = item.ReleaseDate;
        }
    }
}