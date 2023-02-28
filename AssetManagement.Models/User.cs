using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssetManagement.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        [Required]
        public string userName { get; set; }
        [Required]
        public int permissionLevel { get; set; }

        [ForeignKey("permissionLevel")]
        public virtual AccessLevel AccessLevel { get; set; }
    }
}
