using Application.Enums;

namespace DataAccess.Abstacts
{
    public abstract class User
    {
        public uint id { get; set; }
        public string firstName { get; set; }
        public uint lastName { get; set; }
        public Gender SocialNumber { get; set; }
        public string Address { get; set; } = null;
        public string PhoneNumber { get; set; } = null;
    }
}
