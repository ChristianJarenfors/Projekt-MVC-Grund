using MVC_Projekt_WebbShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Projekt_WebbShop.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult StoreIndex()
        {

            return View((List<Product>)Session["ProductList"]);
        }
    }
}