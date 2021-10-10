using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDemo.Areas.Admin.Models
{
    public class ChangePasswordViewModel
    {
        [key]
        public int AccountID { get; set; }
        [Display(Name = "Mật khẩu hiện tại")]
        public string PasswordNow { get; set; }
        [Display(Name = "Mật khẩu mới")]
        [Required(ErrorMessage = " Vui Lòng nhập mật khẩu")]
        [MinLength(5, ErrorMessage = " bạn cần đặt mật khẩu tối thiểu 5 ký tự")]
        public string Password { get; set; }
        [MinLength(5, ErrorMessage = " bạn cần đặt mật khẩu tối thiểu 5 ký tự")]
        [Display(Name = "Mật khẩu mới")]
        [Compare("Password", ErrorMessage = "Mật khẩu không được giống nhau")]
        public string ConfirmPassword { get; set; }
    }
}
