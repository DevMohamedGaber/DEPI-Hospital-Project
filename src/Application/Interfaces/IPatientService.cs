using DataAccess.Entities;
using Shared.DTO;

namespace Application.Interfaces
{
    public interface IPatientService
    {
        bool AddNewPatient(Patient patient);
        bool RemovePatient(uint id);
        bool UpdatePatient(Patient patient);
        Patient GetPatient(uint id);
        Patient GetPatientBySocialNumber(PatientSignInViewModel socialNumber);
        IEnumerable<Patient> GetAllPatients(Patient patient);

    }

}
