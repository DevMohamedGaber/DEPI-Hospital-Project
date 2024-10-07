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
            throw new NotImplementedException();
        }

        public Patient GetByName(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }
    }
}
