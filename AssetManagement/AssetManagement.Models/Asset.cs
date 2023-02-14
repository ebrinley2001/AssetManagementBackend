using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssetManagement.Models
{
    [Table("Assets")]
    public class Asset
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public int iconId { get; set; }
        public int? userRelation { get; set; }

        [ForeignKey("iconId")]
        public virtual Icon Icon { get; set; }

        [ForeignKey("userRelation")]
        public virtual User User { get; set; }
    }
}
