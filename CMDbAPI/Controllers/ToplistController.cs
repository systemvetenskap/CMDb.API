using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CMDbAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToplistController : ControllerBase
    {
        private readonly IMovieRepository context;
        public ToplistController(IMovieRepository repository)
        {
            context = repository;
        }


        /// <summary>
        /// Sends a list of <see cref="Movie"/>
        /// </summary>
        /// <param name="sort">asc/desc</param>
        /// <param name="count">number of movies to grab from database</param>
        /// <param name="type">ratings/popularity</param>
        /// <param name="since">only get ratings since this date eg. yyyy-MM-dd or yyyy-MM-ddTHH:mm:ss</param>
        /// <returns>List of <see cref="Movie"/></returns>
        /// <example>
        /// This will get the 5 least popular movies in the database: 
        /// api/toplist?type=ratings&sort=asc&count=5
        /// 
        /// Get top three movies with biggest number of total votes (like and dislikes)
        /// api/toplist?type=popularity&sort=desc&count=3
        /// 
        /// Get top movies since 2020-10-21(hottest)
        /// api/toplist?since=2020-10-21
        /// </example>
        [HttpGet]
        // GET: api/Toplist/
        public async Task<IEnumerable<Movie>> Toplist([FromQuery]string sort, [Range(1, int.MaxValue, ErrorMessage = "Only positive number allowed")][FromQuery] int? count, [FromQuery] string type, [FromQuery] DateTime? since)
        {
            Parameter parameter = new Parameter
            {
                SortOrder = sort,
                Count = count,
                Type = type,
                Since = since
            };
            return await context.GetToplist(parameter);
        }
    }
}
