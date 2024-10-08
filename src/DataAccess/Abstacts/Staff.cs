using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Abstacts
{
    public abstract class Staff : User
    {
        public string Password { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal Salary { get; set; } = decimal.Zero;
    }
}
