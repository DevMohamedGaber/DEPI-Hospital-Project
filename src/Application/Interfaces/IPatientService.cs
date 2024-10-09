using DataAccess.Entities;

namespace Application.Interfaces
{
    public interface IPatientService
    {
        bool AddNewPatient(Patient patient);
        bool RemovePatient(uint id);
        bool UpdatePatient(Patient patient);
        Patient GetPatient(uint id);
        IEnumerable<Patient> GetAllPatients(Patient patient);
    }

}
