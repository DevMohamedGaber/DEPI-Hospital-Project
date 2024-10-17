using Application.Interfaces;
using DataAccess.Entities;
using DataAccess.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace Application.Services
{
    public class StaffService : IStaffService
    {
        IStaffRepository _repository;
        UserManager<Staff> _userManager;

        public StaffService(IStaffRepository repository, UserManager<Staff> userManager)
        {
            this._repository = repository;
            this._userManager = userManager;
        }
        public List<Staff> GetAll()
        {
            return _repository.GetAll().ToList();
        }
        public async Task<List<Staff>> GetAllDoctors()
        {
            var result = await _userManager.GetUsersInRoleAsync("Doctor");
            return result.ToList();
        }
    }
}
