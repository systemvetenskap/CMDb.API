namespace CMDbAPI
{
    public class Movie
    {
       /// <summary>
       /// Internet Movie Database Id
       /// </summary>
        public string ImdbID { get; set; }
        /// <summary>
        /// Number of likes from CMDb Community
        /// </summary>
        public int NumberOfLikes { get; set; }
        /// <summary>
        /// Number of dislikes from CMDb Community
        /// </summary>
        public int NumberOfDislikes { get; set; }
    }
}
