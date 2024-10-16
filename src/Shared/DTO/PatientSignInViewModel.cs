using System.ComponentModel.DataAnnotations;

namespace Shared.DTO
{
    public class PatientSignInViewModel
    {
        [StringLength(21)]
        public string SocialId { get; set; }
    }
}
