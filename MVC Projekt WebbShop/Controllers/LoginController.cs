using MVC_Projekt_WebbShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Projekt_WebbShop.Controllers
{
    
    public class LoginController : Controller
    {
        // GET: Login
       
        public ActionResult Login()
        {
            UserModel UM = new UserModel();
            if (Request.TotalBytes != 0)
            {
                object[] retur = UserModel.Check(Request["Username"], Request["Password"], (List<UserModel>)Session["AnvändarLista"]);
                string check = (string)retur[0];
                UserModel User = (UserModel)retur[1];
                if (check == "Ok")
                {
                    //ViewBag.IsLoggedIn = true;
                    Session["LoginStatus"] = true;
                    Session["User"] = User;
                }
                else if (Request["logoutButton"] != null)
                {
                    //ViewBag.IsLoggedIn = false;
                    Session["LoginStatus"] = false;
                    ViewBag.Message = null;
                }
                else
                {
                    ViewBag.Message = check;
                    Session["LoginStatus"] = false;
                    //ViewBag.IsLoggedIn = false;
                }
            }
            return View();
            //ViewBag.ReturnUrl();
            //return View();
        }
        public ActionResult Logout()
        {
            Session["User"] = null;
            Session["LoginStatus"] = false;
            return RedirectToAction("Index", "Home");
        }
    }
}