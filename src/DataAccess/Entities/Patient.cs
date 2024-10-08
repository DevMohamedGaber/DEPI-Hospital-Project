using DataAccess.Abstacts;

namespace DataAccess.Entities
{
    public class Patient : User
    {
        public string? EmergencyContactName { get; set; }
        public string? EmergencyContactRelationship { get; set; }
        public string? EmergencyContactPhone { get; set; }
    }
}
