using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace MVC_Projekt_WebbShop.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool EditAdminAthority { get; set; }
        public AuthorizeAttribute Role { get; set; }
        public UserModel() {
            Name = "Guest";
            Email = "guest@guest.com";
            Password = "Password";
            EditAdminAthority = false;
        }
        public UserModel(string name, string email, string password,bool admin)
        {
            Name = name;
            Email = email; 
            Password = password;
            if (EditAdminAthority) {
                Role.Roles = "Admin";
                
            }
   
        }
        public static object[] Check(string user, string pass, List<UserModel> List)
        {
            object[] retur;
            foreach (UserModel u in List)
            {
                if (u.Name == user)
                {
                    if (u.Password == pass)
                    {
                        retur = new object[2] { "Ok", u };
                        return retur;

                    }
                    retur = new object[2] { "Wrong Password", null };
                    return retur;
                    //return "Wrong Password";
                }
            }
            retur = new object[2] { "Username not found", null };
            return retur;
            //return "Username not found";
        }
    }
}