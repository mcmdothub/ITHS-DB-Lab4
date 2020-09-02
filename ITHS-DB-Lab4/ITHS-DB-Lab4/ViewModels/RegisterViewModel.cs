using System.ComponentModel.DataAnnotations;

namespace ITHS_DB_Lab4.ViewModels
{
    /// <summary>
    /// View model to implement Login form
    /// </summary>
    public class RegisterViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }

}
