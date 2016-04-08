using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Projekt_WebbShop.Models
{
    public class UserModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool EditAthority { get; set; }
    }
}