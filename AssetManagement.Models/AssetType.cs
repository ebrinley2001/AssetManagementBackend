using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssetManagement.Models
{
    [Table("AssetTypes")]
    public class AssetType
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string typeName { get; set; }
    }
}
