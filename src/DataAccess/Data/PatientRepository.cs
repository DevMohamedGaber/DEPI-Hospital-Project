using DataAccess.Contexts;
using DataAccess.Entities;
using DataAccess.Interfaces;

namespace DataAccess.Data
{
    public class PatientRepository : UserRepository<Patient>,IPatientRepository
    {
        public PatientRepository(ApplicationContext context) : base(context) {}

    }
}
