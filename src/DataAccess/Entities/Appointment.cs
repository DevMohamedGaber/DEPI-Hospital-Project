using DataAccess.Abstacts;
using Shared.Enums;

namespace DataAccess.Entities
{
    public class Appointment : BaseEntity
    {
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime Date { get; set; }
        public AppointmentStatus Status { get; set; }
        public AppointmentType Type { get; set; }
    }
}
