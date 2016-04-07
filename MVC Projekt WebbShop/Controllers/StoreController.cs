using MVC_Projekt_WebbShop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
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
        public ActionResult Create()
        {

            return View();
        }
        
        public ActionResult Edit()
        {

            return View();
        }


        public ActionResult Delete()
        {

            return View();
        }


    }
}