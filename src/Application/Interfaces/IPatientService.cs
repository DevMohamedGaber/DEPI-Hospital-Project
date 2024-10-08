using DataAccess.Entities;

namespace Application.Interfaces
{
    public interface IPatientService
    {
        bool AddNewPatient(Patient patient);
    }
}
