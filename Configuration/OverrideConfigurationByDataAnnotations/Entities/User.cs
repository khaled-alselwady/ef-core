using System.ComponentModel.DataAnnotations.Schema;

namespace OverrideConfigurationByDataAnnotations.Entities
{
    [Table("tblUsers")]
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
    }
}
