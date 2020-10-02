using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMDbAPI
{
    public interface IMovieRepository
    {
        /// <summary>
        /// Rate one CMDd movie
        /// </summary>
        /// <param name="imdbId">unique movie id</param>
        /// <param name="rating">Like or dislike</param>
        /// <returns>Latest count for likes or dislikes for current movie</returns>
        Task<Movie> Rate(string imdbId, Rating rating = Rating.Like);
        /// <summary>
        /// Get counts for likes and dislikes
        /// </summary>
        /// <param name="imdbId"></param>
        /// <returns></returns>
        Task<Movie> GetMovieRatings(string imdbId);
        /// <summary>
        /// Generates a list of movies sorted by input parameter. 
        /// 
        /// </summary>
        /// <param name="parameter">Object of type <see cref="Parameter"/></param>
        /// <remarks>Default is null</remarks>
        /// <returns></returns>
        Task<IEnumerable<Movie>> GetToplist(Parameter parameter = null);
        
        /// <summary>
        /// Generates a list of all rated movies . 
        /// </summary>
        /// <remarks>This operation will take time if there are many movies in the datatabase</remarks>
        Task<IEnumerable<Movie>> GetAllMovieRatings();
    }
}