using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.IO;

namespace MVC_Projekt_WebbShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int InStorage { get; set; }
        public double Price { get; set; }
        public string PictureURL{ get; set; }
        public string Description { get; set; }
        public Product(int ID, int INSTORAGE, double PRICE, string NAME, string DESCRIPTION, string PICTUREURL)
        {
            Id = ID;
            InStorage = INSTORAGE;
            Price = PRICE;
            Name = NAME;
            Description = DESCRIPTION;
            PictureURL = PICTUREURL;
        }
        ////public static IEnumerable<Product> List = {new  }; 
        public static List<Product> Catalogue = new List<Product>() {new Product(1, 3, 499.99, "Trivial Pursuit", "Trivial Pursuit Master är fyllt av nya aktuella ämnen som ger en rejäl uppfräschning av det klassiska favoritspelet. Testa era kunskaper och lär er massor av fantastiska fakta. Sätt igång - imponera på varandra och ha kul under tiden. Om du har koll på omvärlden så är Trivial Pursuit Master något för dig. <br> 3000 spännande och till och med dråpliga frågor. Spelet innehåller även en elektronisk timer som skyndar på spelet. Batterier ingår ej.", @"http//ecx.images-amazon.com/images/I/512MlHzVf1L._SY300_.jpg") };

    }
}