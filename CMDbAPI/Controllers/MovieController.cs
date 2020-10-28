using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CMDbAPI.Controllers
{
    [Route("api/[controller]")]
    [Route("api/")]

    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepository context;
        public MovieController(IMovieRepository repository)
        {
            context = repository;
        }

        [HttpGet]
        // GET: api/
        public async Task<IEnumerable<Movie>> Get()
        {
            return await context.GetAllMovieRatings();
        }

        [HttpGet("{imdbId}")]
        // GET: api/Movie/3
        public async Task<ActionResult<Movie>> MovieRating(string imdbId)
        {
            return await context.GetMovieRatings(imdbId);
        }
        // Ändra här om du vill ha en Post hellre än en Get
       // [HttpPost("{imdbId}/like")]
        [HttpGet("{imdbId}/like")]
        // GET: api/Movie/3/Like
        public async Task<ActionResult<Movie>> LikeMovie(string imdbId)
        {
            if (!imdbId.IsValidImdbId())
                return BadRequest();

            return await context.Rate(imdbId);
        }
        [HttpGet("{imdbId}/dislike")]
        // GET: api/Movie/3/Dislike
        public async Task<ActionResult<Movie>> DislikeMovie(string imdbId)
        {
            if (!imdbId.IsValidImdbId())
                return BadRequest();

            return await context.Rate(imdbId, Rating.Dislike);
        }

    }
}
