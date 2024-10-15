using DataAccess.Contexts;
using DataAccess.Entities;

namespace DataAccess.Data
{
    public class NurseRepository : UserRepository<Nurse>
    {
        public NurseRepository(ApplicationContext context) : base(context) { }
    }
}
