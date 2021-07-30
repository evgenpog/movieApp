using System;

namespace DataLayer
{
    public class MovieInfo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public MovieGenre Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
