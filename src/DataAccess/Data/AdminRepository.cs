using DataAccess.Contexts;
using DataAccess.Entities;

namespace DataAccess.Data
{
    public class AdminRepository : StaffRepository<Admin>
    {
        public AdminRepository(ApplicationContext context) : base(context) { }
    }
}
