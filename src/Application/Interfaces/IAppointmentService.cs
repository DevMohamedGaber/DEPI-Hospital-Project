using DataAccess.Entities;

namespace Application.Interfaces
{
	public interface IAppointmentService
	{
		bool AddAppointment(Appointment a);
		bool RemoveAppointment(Appointment a);
		bool UpdateAppointment(Appointment a);
		IEnumerable<Appointment> GetPatientAppointments(int PatientId);
		IEnumerable<Appointment> GetDoctortAppointments(int DoctorId);
	}

}
