using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_Projekt_WebbShop.Models
{
    public class ShoppingItem
    {
       
        public int Id { get; set; }
        public int Antal { get; set; }
        public double Sum { get; set; }
        public Product Product { get; set; }

        public ShoppingItem() { }
        public ShoppingItem(int i, Product p)
        {
            Antal = i;
            Product = p;
            Id = p.Id;
            Sum = Antal * p.Price;
        }
        public static double ShoppingTotalSum(List<ShoppingItem> ShoppingList)
        {
            double sum=0;
            foreach (var item in ShoppingList)
            {
               sum += item.Sum;
            }
            return sum;
        }
    }
}