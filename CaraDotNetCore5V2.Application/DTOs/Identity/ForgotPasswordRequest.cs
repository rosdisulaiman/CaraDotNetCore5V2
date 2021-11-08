using System.ComponentModel.DataAnnotations;

namespace CaraDotNetCore5V2.Application.DTOs.Identity
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}