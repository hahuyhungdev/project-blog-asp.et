using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDemo.Areas.Admin.Models
{
    public class LoginViewModel
    {
        [key]
        [MaxLength(50)]
        [Required(ErrorMessage =" Vui Lòng nhập Email")]
        [Display(Name = "Địa chỉ Email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = " Vui Lòng nhập Email")]
        public string Email { get; set; }

        [Display(Name = " Mật khẩu")]
        [Required(ErrorMessage = " Vui Lòng nhập mật khẩu")]
        [MaxLength(30, ErrorMessage = " Vui Lòng nhập Email")]
        public string Password { get; set; }
    }
}
