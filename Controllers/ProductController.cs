using Partial_View2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Partial_View2.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        List<Product> Products = new List<Product>()
        {
            new Product{ProductID = 101, Name = "Cartire", Price = 79.99, Photo = "~/Images/tire.jpg"},
            new Product{ProductID = 102, Name = "Car", Price = 79999, Photo = "~/Images/car.jpg"},
            new Product{ProductID = 103, Name = "Phone", Price = 999, Photo = "~/Images/phone.jpg"},
            new Product{ProductID = 104, Name = "Laptop", Price = 1999, Photo = "~/Images/laptop.jpg"}
        };
        public PartialViewResult Prototype()
        {
            return PartialView();
        }

        public ActionResult Index()
        {
            return View(Products);
        }
    }
}