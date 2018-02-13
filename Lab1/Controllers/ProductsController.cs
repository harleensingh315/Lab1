using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab1.Models;

namespace Lab1.Controllers
{
    public class ProductsController : Controller
    {


        IList<products> productsList = new List<products>() {
                    new products(){  productNames="Laptop" },
                    new products(){  productNames="Tablet" },
                    new products(){  productNames="Desktop"}
        };
                   
               
        // GET: Products
        public ActionResult Index()
        {
            ViewBag.Allproducts = productsList;

            return View();
        }

        // GET: Details
        public ActionResult Details(string value)
        {
            string x = "You selected product: [" + value +"]";
            ViewBag.selecteditem = x;
            return View();
        }
    }
}