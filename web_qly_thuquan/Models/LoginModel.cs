using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace web_qly_thuquan.Models
{
    public class LoginModel
    {

        [Required(ErrorMessage = "Vui lòng nhập mã số")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}