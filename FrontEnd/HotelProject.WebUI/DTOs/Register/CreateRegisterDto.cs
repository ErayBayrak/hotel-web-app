using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.DTOs.Register
{
    public class CreateRegisterDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor.")]
        public string ConfirmPassword { get; set; }
    }
}
