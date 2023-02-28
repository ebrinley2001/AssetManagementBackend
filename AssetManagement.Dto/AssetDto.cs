namespace AssetManagement.Dto
{
    public class AssetDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public int type { get; set; }
        public int iconId { get; set; }
        public int? userRelation { get; set; }
    }
}
