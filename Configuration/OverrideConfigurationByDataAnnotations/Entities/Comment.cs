using System.ComponentModel.DataAnnotations.Schema;

namespace OverrideConfigurationByDataAnnotations.Entities
{
    [Table("tblComments")]
    public class Comment
    {
        [Column("CommentID")]
        public int ID { get; set; }
        public int UserID { get; set; }
        public int TweetID { get; set; }
        public string CommentText { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
