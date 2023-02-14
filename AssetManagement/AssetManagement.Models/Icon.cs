using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssetManagement.Models
{
    [Table("Icons")]
    public class Icon
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string iconName { get; set; }
    }
}
