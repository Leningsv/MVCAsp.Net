using MVCDemo.Models.Services;
using MVCWebApi.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebApi.Controllers
{
    public class ProductController : Controller
    {
        private ProductService productService = new ProductService();
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult GetProducts()
        {
            ViewBag.Products = productService.GetProducts();
            return View();
        }
        //En caso de varios parametros  ?name=Lenin
        public Product GetProduct(int id)
        {
            Product product = productService.GetProduct(id);
            return product;
        }
    }
}