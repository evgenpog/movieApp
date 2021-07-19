using System;
using System.Collections.Generic;

namespace DataLayer
{
    public interface IMovieProvider
    {
        List<MovieInfo> GetMovies();
        MovieInfo GetMovie(Guid id);
        void AddMovie(MovieInfo item);
        void UpdateMovie(MovieInfo item);
        void DeleteMovie(Guid id);
    }

}
