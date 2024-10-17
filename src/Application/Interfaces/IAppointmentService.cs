using DataAccess.Entities;
using Shared.DTO;

namespace Application.Interfaces
{
	public interface IAppointmentService
	{
		List<Appointment> GetAll();
		bool AddAppointment(AppointmentViewModel a);
		bool RemoveAppointment(Appointment a);
		bool UpdateAppointment(Appointment a);
		List<Appointment> GetPatientAppointments(int PatientId);
        List<Appointment> GetDoctortAppointments(int DoctorId);
	}

}
