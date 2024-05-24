using System.ComponentModel.DataAnnotations.Schema;

namespace OverrideConfigurationByDataAnnotations.Entities
{
    [Table("tblTweets")]
    public class Tweet
    {
        public int TweetID { get; set; }
        public int UserID { get; set; }
        public string TweetText { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
