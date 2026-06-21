namespace Practice_App
{
    public class DbService : IDbService
    {
        List<Movie> movies = new List<Movie>
        {
         new Movie{Id =1,MovieName ="Sultan",Genre ="Drama",Price = 350 },
         new  Movie{Id =2,MovieName ="It",Genre ="Horror",Price = 250 }
        };
        int id = 1;


        public List<Movie> GetMovies()
        {
            return movies;
        }

        public void InsertMovie(Movie movie)
        {
            movies.Add(movie);
        }

        public bool DeleteMovie(string name)
        {
            var movie = movies.Find(e => e.MovieName == name);
           return movies.Remove(movie);
        }
    }
}
