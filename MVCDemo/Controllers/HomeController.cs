using MVCDemo.Models.DataBase;
using MVCDemo.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        private ProductService productService = new ProductService();
        // GET: Home
        public String Index()
        {
            return "Hola Lenin";
        } 
        public IEnumerable<Product> GetProducts()
        {
            return productService.GetProducts();
        }
    }
}