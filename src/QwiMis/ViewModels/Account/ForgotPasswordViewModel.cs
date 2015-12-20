using System.ComponentModel.DataAnnotations;

namespace QwiMis.ViewModels.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}