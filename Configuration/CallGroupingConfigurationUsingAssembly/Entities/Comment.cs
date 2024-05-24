namespace CallGroupingConfigurationUsingAssembly.Entities
{
    public class Comment
    {
        public int CommentID { get; set; }
        public int UserID { get; set; }
        public int TweetID { get; set; }
        public string CommentText { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
