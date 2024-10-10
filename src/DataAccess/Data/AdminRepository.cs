using DataAccess.Contexts;
using DataAccess.Entities;

namespace DataAccess.Data
{
    public class AdminRepository : UserRepository<Admin>
    {
        public AdminRepository(ApplicationContext context) : base(context) { }
    }
}
