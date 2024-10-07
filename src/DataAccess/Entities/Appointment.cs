using Shared.Enums;

namespace DataAccess.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime Date { get; set; }
        public AppointmentStatus Status { get; set; }
        public AppointmentType Type { get; set; }
    }
}
