using System.ComponentModel.DataAnnotations;

namespace API8.DTOs
{
    public class RegistrationDTO
    {
        [Required(ErrorMessage = "Name is required.")]
        public string name {  get; set; }
        [Required(ErrorMessage = "User Name is required.")]
        public string username {  get; set; }
        [Required(ErrorMessage = "Email is required.")]
        public string email { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        public string password { get; set; }

    }
}
