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
            if (Session["Search"]==null)
            {
                return View((List<Product>)Session["ProductList"]);
            }
            else
            {
                List<Product> SearchResult = (List<Product>)Session["Search"];
                Session["Search"] = null;
                return View(SearchResult);
            }
            
            
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {

            return View();
        }
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id)
        {
            List<Product> List = (List<Product>)Session["ProductList"];
            Product p = new Product();
            foreach (Product pn in List)
            {
                if (pn.Id == id)
                {
                    p.Name = pn.Name;
                    p.Description = pn.Description;
                    p.Id = pn.Id;
                    p.InStorage = pn.InStorage;
                    p.Price = pn.Price;
                    p.PictureURL = pn.PictureURL;
                }
            }

            return View(p);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? ID)
        {
            List<Product> List = (List<Product>)Session["ProductList"];
            Product item=null;
            if (ID == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                if (Request["Delete"]!=null)
                {
                    item = List.First(x => x.Id == ID);
                }            
            }
            
            if (item != null )
            {
                List.Remove(item);
            }


            if (Request["Delete"]==null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("StoreIndex");
            }

            
        }
        [Authorize(Roles = "Admin")]
        public ActionResult Details(int id)
        {
            List<Product> List = (List<Product>)Session["ProductList"];
            Product p = new Product();
            foreach (Product pn in List)
            {
                if (pn.Id == id)
                {
                    p.Name = pn.Name;
                    p.Description = pn.Description;
                    p.Id = pn.Id;
                    p.InStorage = pn.InStorage;
                    p.Price = pn.Price;
                    p.PictureURL = pn.PictureURL;
                }
            }

            return View(p);
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(Product p)
        {
            List<Product> List = (List<Product>)Session["ProductList"];
            if (!ModelState.IsValid)
            {
                return View("Edit", p);
            }

            foreach (Product pn in List)
            {
                if (pn.Id == p.Id)
                {
                    pn.Name = p.Name;
                    pn.Description = p.Description;
                    pn.Id = p.Id;
                    pn.InStorage = p.InStorage;
                    pn.Price = p.Price;
                    pn.PictureURL = p.PictureURL;
                }
            }

            return RedirectToAction("StoreIndex");
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Create(Product p)
        {
            List<Product> List = (List<Product>)Session["ProductList"];
            if (!ModelState.IsValid)
            {
                return View("Create", p);
            }

            List.Add(p);

            return RedirectToAction("StoreIndex");
        }

    }
}