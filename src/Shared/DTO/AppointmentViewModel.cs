using Shared.Enums;namespace Shared.DTO
{
    public class AppointmentViewModel
    {
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime Date { get; set; }
        public AppointmentStatus Status { get; set; } = AppointmentStatus.Pending;
        public AppointmentType Type { get; set; }
    }
}
