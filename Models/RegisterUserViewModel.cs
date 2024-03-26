using System.ComponentModel.DataAnnotations;

namespace FunctionalApi;

public class RegisterUserViewModel
{
    [Required(ErrorMessage = "{0} field is mandatory")]
    [EmailAddress(ErrorMessage = "{0} field is invalid")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "{0} field is mandatory")]
    [StringLength(100, ErrorMessage = "{0} field must be between {1} and {2} characters", MinimumLength = 6)]
    public string? Password { get; set; }
    
    [Compare("Password", ErrorMessage = "Passwords does not match.")]
    public string? ConfirmPassword { get; set; }
}
