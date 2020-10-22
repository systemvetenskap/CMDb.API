using System;

namespace CMDbAPI
{
    /// <summary>
    /// DTO object for passing parameters to repository
    /// </summary>
    public class Parameter
    {
        /// <summary>
        /// Sorting order 
        /// Desc = descending
        /// Asc = ascending
        /// </summary>
        public string SortOrder { get; set; }
        /// <summary>
        /// Number of movies  to recevie
        /// </summary>
        public int? Count { get; set; }
        /// <summary>
        /// Type of movielist
        /// Ratings = sort by CMDb rating quota (like - dislike = quota)
        /// Popularity = sort by sum of likes and dislikes. Many reactions equals high popularity 
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Only use ratings since this date
        /// </summary>
        public DateTime? Since { get; set; }
    }
}
