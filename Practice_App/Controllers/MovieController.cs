using Microsoft.AspNetCore.Mvc;

namespace Practice_App
{
    public class MovieController : Controller
    {
        private readonly IDbService _service;

        public MovieController(IDbService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var movies = _service.GetMovies();
            return View(movies);
        }
    }
}