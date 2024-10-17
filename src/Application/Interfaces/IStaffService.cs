using DataAccess.Entities;

namespace Application.Interfaces
{
    public interface IStaffService
    {
        List<Staff> GetAll();
        Task<List<Staff>> GetAllDoctors();
    }
}
