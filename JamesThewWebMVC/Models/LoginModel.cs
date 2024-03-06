using System.ComponentModel.DataAnnotations;

namespace JamesThewWebMVC.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Username required")]
        [Display(Name = "Tên đăng nhập")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password required")]
        [Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Username required")]
        public string? Email { get; set; }
    }
}
