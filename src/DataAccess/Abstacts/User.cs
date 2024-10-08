using Shared.Enums;

namespace DataAccess.Abstacts
{
    public abstract class User
    {
        public uint id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string? SocialNumber { get; set; }
        public Gender gender { get; set; } = Gender.Male;
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
