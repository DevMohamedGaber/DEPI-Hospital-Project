using DataAccess.Abstacts;
using Shared.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities
{
    public class Doctor : Staff
    {
        public Speciality Speciality { get; set; }

        public int ShiftId { get; set; } = 0;
        public string MedicalLicenseNumber { get; set; } = string.Empty;
    }
}
