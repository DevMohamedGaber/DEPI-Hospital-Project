using DataAccess.Contexts;
using DataAccess.Entities;

namespace DataAccess.Data
{
    public class AppointmentRepository : Repository<Appointment>
    {
        public AppointmentRepository(ApplicationContext context) : base(context) { }

    }
}
