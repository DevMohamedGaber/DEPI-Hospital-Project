using Application.Interfaces;
using DataAccess.Entities;
using DataAccess.Interfaces;

namespace Application.Services
{
    public class AppointmentService : IAppointmentService
    {
        IAppointmentRepository appointments_repository;

        public AppointmentService(IAppointmentRepository repository)
        {
            this.appointments_repository = repository;
        }

        public bool AddAppointment(Appointment a)
        {
            appointments_repository.Create(a);
            return true;
        }

        public List<Appointment> GetAll()
        {
            return appointments_repository.GetAll().ToList();
        }

        public IEnumerable<Appointment> GetDoctortAppointments(int DoctorId)
        {
            return appointments_repository.GetAll().
                Where(a => a.DoctorId == DoctorId).ToList();
        }

        public IEnumerable<Appointment> GetPatientAppointments(int PatientId)
        {
            return appointments_repository.GetAll().
                Where(a => a.PatientId == PatientId).ToList();
        }

        public bool RemoveAppointment(Appointment a)
        {
            appointments_repository.Delete(a);
            return true;
        }

        public bool UpdateAppointment(Appointment a)
        {
            appointments_repository.Update(a);
            return true;
        }
    }
}
