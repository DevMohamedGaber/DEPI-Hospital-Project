using DataAccess.Contexts;
using DataAccess.Entities;

namespace DataAccess.Data
{
    public class DoctorRepository : UserRepository<Doctor>
    {
        public DoctorRepository(ApplicationContext context) : base(context) { }
    }
}
