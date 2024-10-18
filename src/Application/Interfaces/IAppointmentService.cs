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
		List<Appointment> GetPatientAppointments(uint PatientId);
        List<Appointment> GetDoctortAppointments(uint DoctorId);
	}

}
