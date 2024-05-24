
namespace OverrideConfigurationUsingFluentAPI.Entities
{

    public class Comment
    {

        public int ID { get; set; }
        public int CommentBy { get; set; }
        public int TweetID { get; set; }
        public string CommentText { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
