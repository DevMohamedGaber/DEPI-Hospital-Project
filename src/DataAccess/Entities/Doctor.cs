using DataAccess.Abstacts;
using Shared.Enums;

namespace DataAccess.Entities
{
    public class Doctor : User
    {
        public string Password { get; set; }
        public decimal Salary { get; set; } = decimal.Zero;
        public Speciality Speciality { get; set; }

        public int ShiftId { get; set; } = 0;
        public string MedicalLicenseNumber { get; set; } = string.Empty;
    }
}
