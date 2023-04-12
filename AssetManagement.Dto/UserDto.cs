using System;

namespace AssetManagement.Dto
{
    public class UserDto
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public DateTime dateCreated { get; set; }
        public int permissionLevel { get; set; }
    }
}
