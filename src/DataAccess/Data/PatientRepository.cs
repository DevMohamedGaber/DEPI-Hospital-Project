using DataAccess.Contexts;
using DataAccess.Entities;
using DataAccess.Interfaces;

namespace DataAccess.Data
{
    public class PatientRepository : Repository<Patient>, IPatientRepository
    {
        public PatientRepository(ApplicationContext context) : base(context) {}

        public Patient GetById(int id)
        {
            var patient = context.Patients.Where(x => x.id == id) as Patient;
            return patient;
        }

        public Patient GetByName(string firstName, string lastName)
        {
            var patient = context.Patients.Where(x => x.firstName == firstName && x.lastName == lastName) as Patient;
            return patient;
        }
    }
}
