using DataAccess.Abstacts;

namespace DataAccess.Entities
{
    public class Admin : User
    {
        public string Password { get; set; }
    }
}
