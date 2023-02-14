using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssetManagement.Models
{
    [Table("AssetDetails")]
    public class AssetDetail
    {
        [Key]
        public int id { get; set; }
        [Required]
        public int assetAssociation { get; set; }
        [Required]
        public string columnName { get; set; }
        [Required]
        public string value { get; set; }

        [ForeignKey("assetAssociation")]
        public virtual Asset Asset { get; set; }
    }
}
