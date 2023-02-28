using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssetManagement.Models
{
    [Table("AccessLevels")]
    public class AccessLevel
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string levelName { get; set; }
    }
}
