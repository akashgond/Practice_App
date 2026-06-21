namespace Practice_App
{
    public interface IDbService
    {
        public List<Movie> GetMovies();
        public void InsertMovie(Movie movie);
        public bool DeleteMovie(string name);


    }
}