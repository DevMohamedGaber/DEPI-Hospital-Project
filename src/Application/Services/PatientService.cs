using Application.Interfaces;
using DataAccess.Entities;
using DataAccess.Interfaces;

namespace Application.Services
{
    public class PatientService : IPatientService
    {
        IPatientRepository repository;
        public PatientService(IPatientRepository repository)
        {
            this.repository = repository;
        }

        public bool AddNewPatient(Patient patient)
        {
            repository.Create(patient);
            return true;
        }
    }
}
