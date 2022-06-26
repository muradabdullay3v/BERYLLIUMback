using System.ComponentModel.DataAnnotations;

namespace BERYLLIUM.ViewModels.Account
{
    public class SignInVM
    {
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        public bool isPersistent { get; set; }
    }
}
