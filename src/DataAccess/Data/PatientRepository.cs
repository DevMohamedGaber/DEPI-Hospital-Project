using DataAccess.Contexts;
using DataAccess.Entities;

namespace DataAccess.Data
{
    public class PatientRepository : UserRepository<Patient>
    {
        public PatientRepository(ApplicationContext context) : base(context) {}

    }
}
