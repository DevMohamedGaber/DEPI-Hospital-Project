using DataAccess.Abstacts;

namespace DataAccess.Entities
{
    public class Patient : User
    {
        public string EmergencyContactName { get; set; } = string.Empty;
        public string EmergencyContactRelationship { get; set; } = string.Empty;
        public string EmergencyContactPhone { get; set; } = string.Empty;
    }
}
